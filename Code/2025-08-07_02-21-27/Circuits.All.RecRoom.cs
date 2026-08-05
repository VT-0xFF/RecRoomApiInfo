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
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
internal sealed class ZHPALOHOCAQ<a, b>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly a UANANVVMULJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly b JOZWGLEWRKL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public a TOPLVEXZASU
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xFA77C0", Offset = "0xFA63C0", VA = "0x180FA77C0")]
		get
		{
			return (a)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public b NTGXPBZYTGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4491800", Offset = "0x4490400", VA = "0x184491800")]
		get
		{
			return (b)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4495EC0", Offset = "0x4494AC0", VA = "0x184495EC0")]
	[DebuggerHidden]
	public ZHPALOHOCAQ(a a, b b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4491A00", Offset = "0x4490600", VA = "0x184491A00", Slot = "0")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4492D80", Offset = "0x4491980", VA = "0x184492D80", Slot = "2")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4495060", Offset = "0x4493C60", VA = "0x184495060", Slot = "3")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D7FEB0", Offset = "0x2D7EAB0", VA = "0x182D7FEB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D7FB90", Offset = "0x2D7E790", VA = "0x182D7FB90", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace Circuits.All.RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class QBUZPCMMQEU : IDisposable, UVXOEOANMEZ, EVMQDAXXTXG, WUSHAMEVCPD, HIEMMFGSUTF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public abstract class GHJLWEGETFB : ZWBQGEKCHWS
		{
			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			public abstract int YQWFQWNZDBV
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2D711B0", Offset = "0x2D6FDB0", VA = "0x182D711B0", Slot = "5")]
			public CAWAPZYOHWY WCVKNOCDKTN(IYSCTJMEFHV.ZWBQGEKCHWS a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void JTLKLAAAVJP();

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "12")]
			public abstract void VUHEDKZPPJS();

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2D5EE00", Offset = "0x2D5DA00", VA = "0x182D5EE00", Slot = "13")]
			public virtual void DOCGKORNSBS(QBUZPCMMQEU a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2D71130", Offset = "0x2D6FD30", VA = "0x182D71130", Slot = "14")]
			public virtual void KDYLPGOSAXD(QBUZPCMMQEU a, FJCTCRTIJZZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			protected GHJLWEGETFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public interface ZWBQGEKCHWS
		{
			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			int YQWFQWNZDBV
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			CAWAPZYOHWY WCVKNOCDKTN(IYSCTJMEFHV.ZWBQGEKCHWS a);

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void JTLKLAAAVJP();

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void VUHEDKZPPJS();

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void DOCGKORNSBS(QBUZPCMMQEU a);

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void KDYLPGOSAXD(QBUZPCMMQEU a, FJCTCRTIJZZ b);
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private readonly struct Reducer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public readonly Reducer<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>> Impl;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
			internal Reducer(Reducer<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>> impl)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public sealed class VIEMKMIYKDP : TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>
		{
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly VIEMKMIYKDP CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private VIEMKMIYKDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCDF130", Offset = "0xCDDD30", VA = "0x180CDF130", Slot = "4")]
			public ActionKind SPGAEXWGVXT(FJCTCRTIJZZ a)
			{
				return default(ActionKind);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BE80", Offset = "0x2D8AA80", VA = "0x182D8BE80", Slot = "5")]
			public void DOCGKORNSBS(QBUZPCMMQEU a, FJCTCRTIJZZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BF90", Offset = "0x2D8AB90", VA = "0x182D8BF90", Slot = "6")]
			public void KDYLPGOSAXD(QBUZPCMMQEU a, FJCTCRTIJZZ b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct ReducerFactory
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ReducerFactory<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>> Impl;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2D841D0", Offset = "0x2D82DD0", VA = "0x182D841D0")]
			internal ReducerFactory(ReducerFactory<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>> impl)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2D84180", Offset = "0x2D82D80", VA = "0x182D84180")]
			public static ReducerFactory New()
			{
				return default(ReducerFactory);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public readonly struct StaticNetSysReceiverDeps : CKZYRSCPJVN.DDNRUXYNJKJ<FJCTCRTIJZZ, QBUZPCMMQEU>
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
				public AsyncTaskMethodBuilder<Result<object?, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public QBUZPCMMQEU receiver;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public FJCTCRTIJZZ action;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public StaticNetSysReceiverDeps <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400001D")]
				private TaskAwaiter<Result<object?, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x2D86A00", Offset = "0x2D85600", VA = "0x182D86A00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2D86BE0", Offset = "0x2D857E0", VA = "0x182D86BE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xB7C6E0", Offset = "0xB7B2E0", VA = "0x180B7C6E0", Slot = "4")]
			public Id32<NAXUEJSETKJ> MWIBQUIXVCC(QBUZPCMMQEU a)
			{
				return default(Id32<NAXUEJSETKJ>);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2D842B0", Offset = "0x2D82EB0", VA = "0x182D842B0", Slot = "5")]
			public void CZKNVZEJCRD(QBUZPCMMQEU a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2D84330", Offset = "0x2D82F30", VA = "0x182D84330", Slot = "6")]
			[AsyncStateMachine(typeof(<ReceiveAction>d__2))]
			public Task<Result<object, JGXPLWKAZER>> KREQFJWIICM(QBUZPCMMQEU a, FJCTCRTIJZZ b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2D84310", Offset = "0x2D82F10", VA = "0x182D84310", Slot = "7")]
			public FJCTCRTIJZZ[] DDKUKJMIWQK(QBUZPCMMQEU a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <DebugSendSnapshot>d__39 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<MultiResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public QBUZPCMMQEU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private FJCTCRTIJZZ[] <snapshotActions>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private Result<object, GOLLTPPMOJR>[] <results>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private Result<object, GOLLTPPMOJR> <r>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private Result<object, GOLLTPPMOJR>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2D85280", Offset = "0x2D83E80", VA = "0x182D85280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2D85660", Offset = "0x2D84260", VA = "0x182D85660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Result<object?, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public QBUZPCMMQEU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public FJCTCRTIJZZ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<Result<object?, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2D86C50", Offset = "0x2D85850", VA = "0x182D86C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2D86E40", Offset = "0x2D85A40", VA = "0x182D86E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <RequestInitializeFromSave>d__31 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public AsyncTaskMethodBuilder<Result<bool, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public QBUZPCMMQEU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private TaskAwaiter<Result<bool, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2D88390", Offset = "0x2D86F90", VA = "0x182D88390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2D88620", Offset = "0x2D87220", VA = "0x182D88620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <RequestRefreshLifecycle>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public QBUZPCMMQEU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2D88690", Offset = "0x2D87290", VA = "0x182D88690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x2D88870", Offset = "0x2D87470", VA = "0x182D88870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Id32<NAXUEJSETKJ> PFZEYDKEHXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Reducer PZTUMAZWLVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly Registry KKLJCFQBGYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal readonly RegistryV2 IYEEFUKZLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DF8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly HJGLKQKSWYJ QYMRQMDAMQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E00")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal readonly CKCMJRRVCXJ.CreationArgs SHDKOAWVGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly VSFHYYPHKYE UVKXPPEVOZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal readonly IIAEPFWMYAU IGJYUKSQWLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal readonly WZJVHGKIMTT KNHVBNTSXQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly WXGHAZZMPVF XJUJYCWXEDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E48")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private SnapshotReassembly MKEZKUJWYVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PartialActionReassembly MCBCUZCIQTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E78")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		internal readonly Registry.EVRequest MHQUYWIXUCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E80")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		internal readonly EVRequestExtended AQBJOXRXVOG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Registry RERRAOEGPYC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x2D818B0", Offset = "0x2D804B0", VA = "0x182D818B0")]
			get
			{
				return default(Registry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal ZWBQGEKCHWS TGAEMNHCWCB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x2D821F0", Offset = "0x2D80DF0", VA = "0x182D821F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		internal CAWAPZYOHWY YRFLAEUZZZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x2D813B0", Offset = "0x2D7FFB0", VA = "0x182D813B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2D820A0", Offset = "0x2D80CA0", VA = "0x182D820A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		internal bool EVIDEKZPIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x2D80F20", Offset = "0x2D7FB20", VA = "0x182D80F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2D822C0", Offset = "0x2D80EC0", VA = "0x182D822C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public VLZBEVXRCYX VSFHYYPHKYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2D826A0", Offset = "0x2D812A0", VA = "0x182D826A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CADMUCPHRCB IIAEPFWMYAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2D826B0", Offset = "0x2D812B0", VA = "0x182D826B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public UUQTXJCUZUW WXGHAZZMPVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2D826D0", Offset = "0x2D812D0", VA = "0x182D826D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public SMDDDYAIWZA WZJVHGKIMTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2D826C0", Offset = "0x2D812C0", VA = "0x182D826C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public CKCMJRRVCXJ? CKCMJRRVCXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2D81830", Offset = "0x2D80430", VA = "0x182D81830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private InternalRRStaticStateSysAccess? EETXGIBRLZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2D820C0", Offset = "0x2D80CC0", VA = "0x182D820C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2D823C0", Offset = "0x2D80FC0", VA = "0x182D823C0")]
		private QBUZPCMMQEU(HJGLKQKSWYJ a, Id32<NAXUEJSETKJ> actorId, [In] Reducer reducer, [In] Registry registry, [In] RegistryV2 registryV2, CAWAPZYOHWY b, [In] CKCMJRRVCXJ.CreationArgs cv2CreationArgs, Registry.EVRequest c, EVRequestExtended d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2D81B70", Offset = "0x2D80770", VA = "0x182D81B70")]
		public static QBUZPCMMQEU New(HJGLKQKSWYJ deps, [In] RuntimeFnRegistry runtimeFnRegistry, RuntimeFns runtimeFns, [In] ExternalFnRegistry externalFnRegistry, ExternalFns externalFns, Id32<NAXUEJSETKJ> actorId, Id32<JCZZZGYZEZI> rootNetworkObjectId, GGQWPRURVBI staticNetSys, SILNEZLGRTM dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2D81CB0", Offset = "0x2D808B0", VA = "0x182D81CB0")]
		public static QBUZPCMMQEU New(HJGLKQKSWYJ dependencies, [In] Registry registry, [In] RegistryV2 registryV2, Id32<NAXUEJSETKJ> actorId, Id32<JCZZZGYZEZI> rootNetworkObjectId, GGQWPRURVBI staticNetSys, SILNEZLGRTM dynamicNetSys)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2D815D0", Offset = "0x2D801D0", VA = "0x182D815D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2D822D0", Offset = "0x2D80ED0", VA = "0x182D822D0")]
		[AsyncStateMachine(typeof(<RequestInitializeFromSave>d__31))]
		public Task<Result<bool, JGXPLWKAZER>> YZVLUVEJOIV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2D81FB0", Offset = "0x2D80BB0", VA = "0x182D81FB0")]
		[AsyncStateMachine(typeof(<RequestRefreshLifecycle>d__32))]
		public Task<Result<None, JGXPLWKAZER>> QAGPHBLCROD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2D813C0", Offset = "0x2D7FFC0", VA = "0x182D813C0")]
		internal void DOJQJOMSNOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2D82240", Offset = "0x2D80E40", VA = "0x182D82240")]
		internal Option<FJCTCRTIJZZ> WLGCSBISPWR([In] PartialInitializePayload partialInitializePayload)
		{
			return default(Option<FJCTCRTIJZZ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2D817C0", Offset = "0x2D803C0", VA = "0x182D817C0")]
		internal bool IKRVNMQLPIO([In] PartialInitializePayload partialInitializePayload)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2D818C0", Offset = "0x2D804C0", VA = "0x182D818C0")]
		internal Result<FJCTCRTIJZZ, JGXPLWKAZER> MYYFNZBBHPH([In] PartialActionPayload partialActionPayload)
		{
			return default(Result<FJCTCRTIJZZ, JGXPLWKAZER>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2D80F30", Offset = "0x2D7FB30", VA = "0x182D80F30")]
		private void CZKNVZEJCRD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2D80E10", Offset = "0x2D7FA10", VA = "0x182D80E10")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__38))]
		internal Task<Result<object, JGXPLWKAZER>> AYQJUSGSYCV(FJCTCRTIJZZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2D81A50", Offset = "0x2D80650", VA = "0x182D81A50")]
		[AsyncStateMachine(typeof(<DebugSendSnapshot>d__39))]
		public Task<MultiResult> NISOBBYCVUO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2D80F80", Offset = "0x2D7FB80", VA = "0x182D80F80")]
		private FJCTCRTIJZZ[] DDKUKJMIWQK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class PRCGAPSALGA<a> : UTITDXZLKVK, IRJIMSMWTFI, GOLLTPPMOJR where a : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Id128<LWYTCPIHOQE>? VMMKIELEIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly string RJCOATNWHYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly a RXLJWTQVVNH;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Id128<LWYTCPIHOQE>? WFRTVRNPDPX
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x305CB40", Offset = "0x305B740", VA = "0x18305CB40", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6187920", Offset = "0x6186520", VA = "0x186187920")]
		internal PRCGAPSALGA([In] Id128<LWYTCPIHOQE>? lastNode, Id32<QPIYMGVHWXV>? lastPort, IOKind? a, string b, [In] a data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class JAQZSAXVOSK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x2D73000", Offset = "0x2D71C00", VA = "0x182D73000")]
		public static Result<DebugExecutionResult, IRJIMSMWTFI> WXNQTKFUUQR([In] this LegacyCV2Result<LegacyExecOk> legacyCV2Result)
		{
			return default(Result<DebugExecutionResult, IRJIMSMWTFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C418E0", Offset = "0x3C404E0", VA = "0x183C418E0")]
		public static Result<TOk, IRJIMSMWTFI> HPMFFSXBMED<TOk>([In] this Result<TOk, IRJIMSMWTFI> self, [In] Id128<LWYTCPIHOQE>? lastNode, Id32<QPIYMGVHWXV>? lastPort, IOKind? a, string b) where TOk : notnull
		{
			return default(Result<TOk, IRJIMSMWTFI>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface HJGLKQKSWYJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		BBDQXSJXACB.ZWBQGEKCHWS FGZLEXXGFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		IYSCTJMEFHV.ZWBQGEKCHWS HQSTJLTFMHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		QBUZPCMMQEU.ZWBQGEKCHWS HLOMVPQQCOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		QGHELZNSXBF.ZWBQGEKCHWS QQJGBXLBDMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU> VIEMKMIYKDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		CV2Request.ZWBQGEKCHWS ALRWSWUTPXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		HQZRPDRLYMD YOEBAIBRSBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		SIAQCCPWYWO SVTYZEGMKLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		LPPYWEGICFS FCFVUKHTKAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		HQZHXJLGZCY UAQJIWJGAYH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		ZWOKKWUVOWC VJNALATDEKR
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}
	}
}
namespace Circuits.All.RecRoom.Payload
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class PHPFQDKFVPY
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2D80210", Offset = "0x2D7EE10", VA = "0x182D80210")]
		public static FJCTCRTIJZZ BVFJSXAAMZD(this FJCTCRTIJZZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2D80320", Offset = "0x2D7EF20", VA = "0x182D80320")]
		public static FJCTCRTIJZZ EUKSYNBFZKS(this CompressedPayload a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public readonly struct CompressedPayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public AsyncTaskMethodBuilder<Result<object?, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public QBUZPCMMQEU root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public CompressedPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private TaskAwaiter<Result<object?, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2D86EB0", Offset = "0x2D85AB0", VA = "0x182D86EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2D875E0", Offset = "0x2D861E0", VA = "0x182D875E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public readonly ByteString Value;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		private CompressedPayload(ByteString value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2D6A9A0", Offset = "0x2D695A0", VA = "0x182D6A9A0")]
		public static FJCTCRTIJZZ AZPPBDLKMAD(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2D6AA60", Offset = "0x2D69660", VA = "0x182D6AA60")]
		public static ReduceAction<ActionKind, CompressedPayload> UYYAKCXVFJE(FJCTCRTIJZZ actionData)
		{
			return default(ReduceAction<ActionKind, CompressedPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2D6A890", Offset = "0x2D69490", VA = "0x182D6A890")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<object, JGXPLWKAZER>> AYQJUSGSYCV(QBUZPCMMQEU a, CompressedPayload b)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public readonly struct DestroyPayload
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D6AB10", Offset = "0x2D69710", VA = "0x182D6AB10")]
		public static FJCTCRTIJZZ AZPPBDLKMAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2D6AC30", Offset = "0x2D69830", VA = "0x182D6AC30")]
		public static ReduceAction<ActionKind, DestroyPayload> UYYAKCXVFJE(FJCTCRTIJZZ actionData)
		{
			return default(ReduceAction<ActionKind, DestroyPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2D6ABB0", Offset = "0x2D697B0", VA = "0x182D6ABB0")]
		public static Result<None, NJKZNHRVAZM> OMFFNDUCKPZ(QBUZPCMMQEU a, [In] DestroyPayload self)
		{
			return default(Result<None, NJKZNHRVAZM>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct FullInitializePayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AsyncTaskMethodBuilder<Result<None, NJKZNHRVAZM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public QBUZPCMMQEU root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public FullInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private Result<None, NJKZNHRVAZM> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2D876C0", Offset = "0x2D862C0", VA = "0x182D876C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2D882B0", Offset = "0x2D86EB0", VA = "0x182D882B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public readonly RootData? RootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public readonly CircuitRootData? CircuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly SuperRoomData? SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CircuitStudioUnitySubAssetUsageData? StudioUnitySubAssetUsageData;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2803100", Offset = "0x2801D00", VA = "0x182803100")]
		private FullInitializePayload(RootData? rootData, CircuitRootData? circuitRootData, SuperRoomData? superRoomData, CircuitStudioUnitySubAssetUsageData? studioUnitySubAssetUsageData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2D70CF0", Offset = "0x2D6F8F0", VA = "0x182D70CF0")]
		public static FJCTCRTIJZZ? AZPPBDLKMAD(RootData? a, CircuitRootData? b, SuperRoomData? c, CircuitStudioUnitySubAssetUsageData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2D70E00", Offset = "0x2D6FA00", VA = "0x182D70E00")]
		public static ReduceAction<ActionKind, FullInitializePayload> UYYAKCXVFJE(FJCTCRTIJZZ actionData)
		{
			return default(ReduceAction<ActionKind, FullInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2D70BB0", Offset = "0x2D6F7B0", VA = "0x182D70BB0")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<None, NJKZNHRVAZM>> AYQJUSGSYCV(QBUZPCMMQEU a, FullInitializePayload b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public readonly struct MultiPayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public AsyncTaskMethodBuilder<Result<MultiResult, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public MultiPayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public QBUZPCMMQEU root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private Result<MultiResult, JGXPLWKAZER> <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Result<object?, GOLLTPPMOJR>[] <aggregateResult>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int <i>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private Result<object?, GOLLTPPMOJR> <r2>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private Result<object?, GOLLTPPMOJR>[] <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private int <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private TaskAwaiter<Result<object?, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2D87170", Offset = "0x2D85D70", VA = "0x182D87170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2D87650", Offset = "0x2D86250", VA = "0x182D87650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly IReadOnlyList<FJCTCRTIJZZ> Actions;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		private MultiPayload(IReadOnlyList<FJCTCRTIJZZ> actions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FD50", Offset = "0x2D7E950", VA = "0x182D7FD50")]
		public static FJCTCRTIJZZ AZPPBDLKMAD(IReadOnlyList<FJCTCRTIJZZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FE10", Offset = "0x2D7EA10", VA = "0x182D7FE10")]
		public static ReduceAction<ActionKind, MultiPayload> UYYAKCXVFJE(FJCTCRTIJZZ actionData)
		{
			return default(ReduceAction<ActionKind, MultiPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FC10", Offset = "0x2D7E810", VA = "0x182D7FC10")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__4))]
		public static Task<Result<MultiResult, JGXPLWKAZER>> AYQJUSGSYCV(QBUZPCMMQEU a, MultiPayload b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public readonly struct PartialActionPayload
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public sealed class M
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Id128<M> PCTRTBKIIXM;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2D714B0", Offset = "0x2D700B0", VA = "0x182D714B0")]
			internal FJCTCRTIJZZ MFKRQEYZLMG(int a, int b, [In] ReadOnlySpan<byte> span)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly Id128<M> ActionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public readonly int Count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly byte[] Data;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2D808F0", Offset = "0x2D7F4F0", VA = "0x182D808F0")]
		private PartialActionPayload(Id128<M> actionId, int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2D803F0", Offset = "0x2D7EFF0", VA = "0x182D803F0")]
		public static FJCTCRTIJZZ AZPPBDLKMAD(Id128<M> actionId, int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2D807F0", Offset = "0x2D7F3F0", VA = "0x182D807F0")]
		public static FJCTCRTIJZZ[] YNPEAROPPFE(FJCTCRTIJZZ a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2D806A0", Offset = "0x2D7F2A0", VA = "0x182D806A0")]
		public static ReduceAction<ActionKind, PartialActionPayload> UYYAKCXVFJE(FJCTCRTIJZZ actionData)
		{
			return default(ReduceAction<ActionKind, PartialActionPayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2D80500", Offset = "0x2D7F100", VA = "0x182D80500")]
		public static Result<FJCTCRTIJZZ, JGXPLWKAZER> OMFFNDUCKPZ(QBUZPCMMQEU a, [In] PartialActionPayload self)
		{
			return default(Result<FJCTCRTIJZZ, JGXPLWKAZER>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct PartialInitializePayload
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private struct <ReduceAsync>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AsyncTaskMethodBuilder<Result<bool, NJKZNHRVAZM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public QBUZPCMMQEU root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public PartialInitializePayload self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private Result<bool, NJKZNHRVAZM> <r>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter<Result<None, NJKZNHRVAZM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2D87C70", Offset = "0x2D86870", VA = "0x182D87C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x2D88320", Offset = "0x2D86F20", VA = "0x182D88320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly int Count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly int Index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly byte[] Data;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xDF2A10", Offset = "0xDF1610", VA = "0x180DF2A10")]
		private PartialInitializePayload(int count, int index, byte[] data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x2D80A40", Offset = "0x2D7F640", VA = "0x182D80A40")]
		public static FJCTCRTIJZZ AZPPBDLKMAD(int a, int b, ByteString c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2D80B20", Offset = "0x2D7F720", VA = "0x182D80B20")]
		public static FJCTCRTIJZZ?[]? KEGXJBFRDTC(int a, RootData? b, CircuitRootData? c, SuperRoomData? d, CircuitStudioUnitySubAssetUsageData? e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2D80D30", Offset = "0x2D7F930", VA = "0x182D80D30")]
		public static ReduceAction<ActionKind, PartialInitializePayload> UYYAKCXVFJE(FJCTCRTIJZZ actionData)
		{
			return default(ReduceAction<ActionKind, PartialInitializePayload>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2D80910", Offset = "0x2D7F510", VA = "0x182D80910")]
		[AsyncStateMachine(typeof(<ReduceAsync>d__7))]
		public static Task<Result<bool, NJKZNHRVAZM>> AYQJUSGSYCV(QBUZPCMMQEU a, PartialInitializePayload b)
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Integration
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class VSFHYYPHKYE : VLZBEVXRCYX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly QBUZPCMMQEU CYOVMHDASMV;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public SFZSPZBTLDS? CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x2D8C110", Offset = "0x2D8AD10", VA = "0x182D8C110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		internal VSFHYYPHKYE(QBUZPCMMQEU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class TWRJDPRFSRF : SFZSPZBTLDS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly QBUZPCMMQEU CYOVMHDASMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly AGTBEXVKYHM JDQPJOGSLRG;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public TWRJDPRFSRF(QBUZPCMMQEU a, AGTBEXVKYHM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2D84460", Offset = "0x2D83060", VA = "0x182D84460", Slot = "4")]
		public Result<DebugExecutionResult, IRJIMSMWTFI> HHPYTHIMTFV(Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<GIQEAILWCVY> inputId)
		{
			return default(Result<DebugExecutionResult, IRJIMSMWTFI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2D84A30", Offset = "0x2D83630", VA = "0x182D84A30", Slot = "5")]
		public Result<DebugExecutionResult, IRJIMSMWTFI> ZZBRMAIRAVU(Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<DJLWKSNXJYV> outputId)
		{
			return default(Result<DebugExecutionResult, IRJIMSMWTFI>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class BBDQXSJXACB : RCCZIPRQHLG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public interface ZWBQGEKCHWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<AGTBEXVKYHM> YLPZSQHTISW(QBUZPCMMQEU a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b);

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(Slot = "1")]
			ACYUMWBFMLS BKNDDAKIQAE(QBUZPCMMQEU a, RootData b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public sealed class GHJLWEGETFB : ZWBQGEKCHWS
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200002A")]
			[CompilerGenerated]
			private struct <DeserializeCV2RootSysAsync>d__2 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000071")]
				public AsyncTaskMethodBuilder<AGTBEXVKYHM> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000072")]
				public QBUZPCMMQEU circuitsManager;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000073")]
				public CircuitRootData cv2RoomData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				public SuperRoomData cv2SuperRoomData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				private TaskAwaiter<QGHELZNSXBF> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x2D85C10", Offset = "0x2D84810", VA = "0x182D85C10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x2D85DE0", Offset = "0x2D849E0", VA = "0x182D85DE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly GHJLWEGETFB CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private GHJLWEGETFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2D712E0", Offset = "0x2D6FEE0", VA = "0x182D712E0", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeCV2RootSysAsync>d__2))]
			public Task<AGTBEXVKYHM> YLPZSQHTISW(QBUZPCMMQEU a, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x2D71110", Offset = "0x2D6FD10", VA = "0x182D71110", Slot = "5")]
			public ACYUMWBFMLS BKNDDAKIQAE(QBUZPCMMQEU a, RootData b)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <DeserializeAsync>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AsyncTaskMethodBuilder<BBDQXSJXACB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public QBUZPCMMQEU circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public RootData evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private ZWBQGEKCHWS <selfDeps>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private TaskAwaiter<AGTBEXVKYHM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2D856D0", Offset = "0x2D842D0", VA = "0x182D856D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x2D85BA0", Offset = "0x2D847A0", VA = "0x182D85BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly AGTBEXVKYHM JDQPJOGSLRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly ACYUMWBFMLS TTBWZFOKWHI;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CKCMJRRVCXJ CKCMJRRVCXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2D6A6C0", Offset = "0x2D692C0", VA = "0x182D6A6C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public InternalRRStaticStateSysAccess SMGAHXJQNNI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2D6A590", Offset = "0x2D69190", VA = "0x182D6A590", Slot = "5")]
			get
			{
				return default(InternalRRStaticStateSysAccess);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public TWRJDPRFSRF TWRJDPRFSRF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public OHLXCYTMNOA OHLXCYTMNOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x11F0770", Offset = "0x11EF370", VA = "0x1811F0770")]
		private BBDQXSJXACB(AGTBEXVKYHM a, ACYUMWBFMLS b, TWRJDPRFSRF c, OHLXCYTMNOA d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2D6A420", Offset = "0x2D69020", VA = "0x182D6A420")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__3))]
		public static Task<BBDQXSJXACB> BZRQNWXRYZC(QBUZPCMMQEU a, RootData b, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2D6A650", Offset = "0x2D69250", VA = "0x182D6A650", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class IYSCTJMEFHV : CAWAPZYOHWY, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public interface ZWBQGEKCHWS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<RCCZIPRQHLG> BKMTNDKJWWM(QBUZPCMMQEU a, RootData b, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken c);

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void LifecycleWillDestroy();
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public abstract class GHJLWEGETFB : ZWBQGEKCHWS
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			[CompilerGenerated]
			private struct <DeserializeCircuitsJunctionAsync>d__0 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				public AsyncTaskMethodBuilder<RCCZIPRQHLG> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				public QBUZPCMMQEU circuitsManager;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public RootData evRoomData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				public CircuitRootData cv2RoomData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public SuperRoomData cv2SuperRoomData;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public CancellationToken cancellationToken;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x400008F")]
				private TaskAwaiter<BBDQXSJXACB> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0x2D85E50", Offset = "0x2D84A50", VA = "0x182D85E50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000AF")]
				[Cpp2IlInjected.Address(RVA = "0x2D86190", Offset = "0x2D84D90", VA = "0x182D86190", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x2D70FB0", Offset = "0x2D6FBB0", VA = "0x182D70FB0", Slot = "4")]
			[AsyncStateMachine(typeof(<DeserializeCircuitsJunctionAsync>d__0))]
			public Task<RCCZIPRQHLG> BKMTNDKJWWM(QBUZPCMMQEU a, RootData b, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData, CancellationToken c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void LifecycleDidInitialize();

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void LifecycleWillDestroy();

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			protected GHJLWEGETFB()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private struct <GetJunctionAsync>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AsyncTaskMethodBuilder<RCCZIPRQHLG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public IYSCTJMEFHV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private TaskAwaiter<None> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x2D86200", Offset = "0x2D84E00", VA = "0x182D86200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x2D86400", Offset = "0x2D85000", VA = "0x182D86400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private struct <InitializeAsync>d__24 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public IYSCTJMEFHV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public QBUZPCMMQEU circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public RootData evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public CircuitRootData cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public SuperRoomData cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private TaskAwaiter<RCCZIPRQHLG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x2D86470", Offset = "0x2D85070", VA = "0x182D86470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x2D869A0", Offset = "0x2D855A0", VA = "0x182D869A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly ZWBQGEKCHWS KOIFGESKYOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly TaskCompletionSource<None> OYRKPNCHTVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly TaskCompletionSource<None> SVCLRKEWPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly CancellationTokenSource SJLMNKIYXSU;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EVIDEKZPIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xC66AC0", Offset = "0xC656C0", VA = "0x180C66AC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCB0820", Offset = "0xCAF420", VA = "0x180CB0820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xFC4050", Offset = "0xFC2C50", VA = "0x180FC4050", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x1010A50", Offset = "0x100F650", VA = "0x181010A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool PFYKMZKAPEB
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D550", Offset = "0x1E0C150", VA = "0x181E0D550")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D560", Offset = "0x1E0C160", VA = "0x181E0D560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public RCCZIPRQHLG? PRQBDSPTPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D72CB0", Offset = "0x2D718B0", VA = "0x182D72CB0", Slot = "7")]
		[AsyncStateMachine(typeof(<GetJunctionAsync>d__20))]
		public Task<RCCZIPRQHLG> JYPPPZGXUSB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D72F00", Offset = "0x2D71B00", VA = "0x182D72F00")]
		public IYSCTJMEFHV(ZWBQGEKCHWS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D72DA0", Offset = "0x2D719A0", VA = "0x182D72DA0", Slot = "8")]
		[AsyncStateMachine(typeof(<InitializeAsync>d__24))]
		public Task XXIQNESWDZH(QBUZPCMMQEU a, RootData b, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D72B40", Offset = "0x2D71740", VA = "0x182D72B40", Slot = "9")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class HTCWFLGEEXE : PTONQBFNJNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly OHLXCYTMNOA CNQEMONALED;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public HTCWFLGEEXE(OHLXCYTMNOA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class BZRKLBIFZZL
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private class PCXPDUCTGJH<a> : CMFLWIUZKZI where a : CYUKXICDMVO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			protected readonly a LKSALYFMSXY;

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			public virtual ObjectBoardProps? EEQPZUQQEOU
			{
				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0xF70900", Offset = "0xF6F500", VA = "0x180F70900", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public virtual Id128<LWYTCPIHOQE>? AWCRVCOTKEI
			{
				[Cpp2IlInjected.Token(Token = "0x60000B8")]
				[Cpp2IlInjected.Address(RVA = "0x6178BC0", Offset = "0x61777C0", VA = "0x186178BC0", Slot = "9")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public Id32<JQPVMRMCZNG> LGSCAVMTATU
			{
				[Cpp2IlInjected.Token(Token = "0x60000B9")]
				[Cpp2IlInjected.Address(RVA = "0x305E8F0", Offset = "0x305D4F0", VA = "0x18305E8F0", Slot = "5")]
				get
				{
					return default(Id32<JQPVMRMCZNG>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public Id32<JQPVMRMCZNG>? KRGIYFTCCIK
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x6178B40", Offset = "0x6177740", VA = "0x186178B40", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
			public PCXPDUCTGJH(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		private sealed class LCFDGUPVPMV : PCXPDUCTGJH<PXSSWANYVDD>
		{
			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public override ObjectBoardProps? EEQPZUQQEOU
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x1116860", Offset = "0x1115460", VA = "0x181116860", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x2D74870", Offset = "0x2D73470", VA = "0x182D74870")]
			public LCFDGUPVPMV(PXSSWANYVDD a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D6A710", Offset = "0x2D69310", VA = "0x182D6A710")]
		public static CMFLWIUZKZI New(CYUKXICDMVO graph)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class ECNQONAYIXX : NONTLGDXKSQ, TXCKZOIHSCK, EAPWZEKDOJL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class RGBAJBLOFPN
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public RGBAJBLOFPN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public HQZRPDRLYMD errReporting_;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x2D89A70", Offset = "0x2D88670", VA = "0x182D89A70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x2D89CE0", Offset = "0x2D888E0", VA = "0x182D89CE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public ECNQONAYIXX VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public bool UYGIMZVFGNY;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public RGBAJBLOFPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2D827C0", Offset = "0x2D813C0", VA = "0x182D827C0")]
			[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
			internal Task FCYOMWKOEUX(HQZRPDRLYMD a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class HPUDPQOSLZV
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003B")]
			private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public HPUDPQOSLZV <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x2D89D40", Offset = "0x2D88940", VA = "0x182D89D40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0x2D8A020", Offset = "0x2D88C20", VA = "0x182D8A020", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public ECNQONAYIXX VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public int UYGIMZVFGNY;

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HPUDPQOSLZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2D72A70", Offset = "0x2D71670", VA = "0x182D72A70")]
			[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
			internal Task HMJOEUBRYIN(HQZRPDRLYMD a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class FTNYYFHXZBU
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private struct <<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public FTNYYFHXZBU <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x2D8A590", Offset = "0x2D89190", VA = "0x182D8A590", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010F")]
				[Cpp2IlInjected.Address(RVA = "0x2D8AA40", Offset = "0x2D89640", VA = "0x182D8AA40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public string UYGIMZVFGNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public ECNQONAYIXX VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int XTFALOGGIMG;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public FTNYYFHXZBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2D70AE0", Offset = "0x2D6F6E0", VA = "0x182D70AE0")]
			[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
			internal Task LIEEBDXOGQH(HQZRPDRLYMD a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class SSMORKVWSZT
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200003F")]
			private struct <<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public SSMORKVWSZT <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x2D8A080", Offset = "0x2D88C80", VA = "0x182D8A080", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000113")]
				[Cpp2IlInjected.Address(RVA = "0x2D8A530", Offset = "0x2D89130", VA = "0x182D8A530", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public string UYGIMZVFGNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public ECNQONAYIXX VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public int XTFALOGGIMG;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public SSMORKVWSZT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x2D841E0", Offset = "0x2D82DE0", VA = "0x182D841E0")]
			[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
			internal Task HIMRMOJZPUT(HQZRPDRLYMD a)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private struct <RequestSetDefaultValue>d__32 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public bool checkStringPurity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public ECNQONAYIXX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2D888E0", Offset = "0x2D874E0", VA = "0x182D888E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2D88DE0", Offset = "0x2D879E0", VA = "0x182D88DE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private readonly PITLKUDDKGI WUNMHGAZECW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ICollection<NAEGKHVBMUW> JDLZHELVUBZ;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private HJGLKQKSWYJ GHJLWEGETFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x2D6D290", Offset = "0x2D6BE90", VA = "0x182D6D290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Id32<GIQEAILWCVY> SLURXSQVXPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x10FC340", Offset = "0x10FAF40", VA = "0x1810FC340", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<GIQEAILWCVY>);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x11A62C0", Offset = "0x11A4EC0", VA = "0x1811A62C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private Id32<VPKCJSHTFFF> YNQUABDVXNB
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x2D6DFD0", Offset = "0x2D6CBD0", VA = "0x182D6DFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Id32<AWZVWRTEXTC> HOANWQLKQKW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x1338B30", Offset = "0x1337730", VA = "0x181338B30", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<AWZVWRTEXTC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override Id32<QPIYMGVHWXV> OZMFWSPYFEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2D6DFE0", Offset = "0x2D6CBE0", VA = "0x182D6DFE0", Slot = "22")]
			get
			{
				return default(Id32<QPIYMGVHWXV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AXCFGELMPAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x2D6C000", Offset = "0x2D6AC00", VA = "0x182D6C000", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D6EAF0", Offset = "0x2D6D6F0", VA = "0x182D6EAF0")]
		private ECNQONAYIXX(QBUZPCMMQEU a, OINYKCZIBWN b, PITLKUDDKGI c, Id32<CUMWXIQVBDQ> portGroupId, Id32<GIQEAILWCVY> inputId, Id32<VPKCJSHTFFF> inputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D760", Offset = "0x2D6C360", VA = "0x182D6D760")]
		public static ECNQONAYIXX New(QBUZPCMMQEU circuitsManager, OINYKCZIBWN node, PITLKUDDKGI input, Id32<CUMWXIQVBDQ> portGroupId, Id32<VPKCJSHTFFF> inputDefId, Id32<GIQEAILWCVY> inputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C750", Offset = "0x2D6B350", VA = "0x182D6C750", Slot = "23")]
		protected override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C490", Offset = "0x2D6B090", VA = "0x182D6C490", Slot = "24")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x2D6AE60", Offset = "0x2D69A60", VA = "0x182D6AE60", Slot = "32")]
		public void AYBOBVAZNZS(NAEGKHVBMUW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D2B0", Offset = "0x2D6BEB0", VA = "0x182D6D2B0", Slot = "29")]
		public void MMYWXQPXGBZ(MWJVYZXYCXM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2D6AEC0", Offset = "0x2D69AC0", VA = "0x182D6AEC0", Slot = "30")]
		public void BEVVSLIZEEG(EWORBMNSPDC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C7F0", Offset = "0x2D6B3F0", VA = "0x182D6C7F0", Slot = "25")]
		protected override void JDCOSIQEHEE(LRRWLGFUBVR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DD90", Offset = "0x2D6C990", VA = "0x182D6DD90", Slot = "34")]
		public string PNMCHLOTVIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E180", Offset = "0x2D6CD80", VA = "0x182D6E180", Slot = "31")]
		public string UTSXIUGSXZB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C530", Offset = "0x2D6B130", VA = "0x182D6C530")]
		private void IJUCTAIDXGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DB10", Offset = "0x2D6C710", VA = "0x182D6DB10", Slot = "33")]
		public void PFWUFUXGCOD(NAEGKHVBMUW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DBD0", Offset = "0x2D6C7D0", VA = "0x182D6DBD0")]
		private void PHSMKLTWPGI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E820", Offset = "0x2D6D420", VA = "0x182D6E820", Slot = "35")]
		[AsyncStateMachine(typeof(<RequestSetDefaultValue>d__32))]
		public Task XRTCTMXEELW(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E030", Offset = "0x2D6CC30", VA = "0x182D6E030")]
		public void TFXRYPVHCPH(string a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D6BE60", Offset = "0x2D6AA60", VA = "0x182D6BE60")]
		private void COCYWSHAUPP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E930", Offset = "0x2D6D530", VA = "0x182D6E930")]
		private void ZOLJNNCWYKZ(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D6ACA0", Offset = "0x2D698A0", VA = "0x182D6ACA0")]
		private void AQWLAKRKJDU(int a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D620", Offset = "0x2D6C220", VA = "0x182D6D620")]
		private string MXVPLNXUGDH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D120", Offset = "0x2D6BD20", VA = "0x182D6D120")]
		private string LOVSOSPLYME(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x11A62C0", Offset = "0x11A4EC0", VA = "0x1811A62C0")]
		internal void TGFBUCSPDPJ(Id32<GIQEAILWCVY> value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CBE0", Offset = "0x2D6B7E0", VA = "0x182D6CBE0")]
		[CompilerGenerated]
		private void JOPZPRTZAMY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CC60", Offset = "0x2D6B860", VA = "0x182D6CC60")]
		[CompilerGenerated]
		private bool JOVGMYNWJYH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CE50", Offset = "0x2D6BA50", VA = "0x182D6CE50")]
		[CompilerGenerated]
		private bool JPFUHMBRCUZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CF10", Offset = "0x2D6BB10", VA = "0x182D6CF10")]
		[CompilerGenerated]
		private int JPLBESVOMGI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CFC0", Offset = "0x2D6BBC0", VA = "0x182D6CFC0")]
		[CompilerGenerated]
		private bool JPQIBZPLVRR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D050", Offset = "0x2D6BC50", VA = "0x182D6D050")]
		[CompilerGenerated]
		private void JPVOZGJJFDA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2D6D060", Offset = "0x2D6BC60", VA = "0x182D6D060")]
		[CompilerGenerated]
		private bool JQAVWNDGOOJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C8D0", Offset = "0x2D6B4D0", VA = "0x182D6C8D0")]
		[CompilerGenerated]
		private bool JMZWLPQUDAE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C920", Offset = "0x2D6B520", VA = "0x182D6C920")]
		[CompilerGenerated]
		private bool JNFDIWKRMLN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CF10", Offset = "0x2D6BB10", VA = "0x182D6CF10")]
		[CompilerGenerated]
		private int VTCUGEUUCRP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E5F0", Offset = "0x2D6D1F0", VA = "0x182D6E5F0")]
		[CompilerGenerated]
		private bool VSXNIYAWTGG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E590", Offset = "0x2D6D190", VA = "0x182D6E590")]
		[CompilerGenerated]
		private object VSSGLRGZJUX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CF60", Offset = "0x2D6BB60", VA = "0x182D6CF60")]
		[CompilerGenerated]
		private void VSMZOKNCAJO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E750", Offset = "0x2D6D350", VA = "0x182D6E750")]
		[CompilerGenerated]
		private bool VTSOXZCMEZQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E6D0", Offset = "0x2D6D2D0", VA = "0x182D6E6D0")]
		[CompilerGenerated]
		private string VTNIASIOVOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E6C0", Offset = "0x2D6D2C0", VA = "0x182D6E6C0")]
		[CompilerGenerated]
		private void VTIBDLORMCY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E4C0", Offset = "0x2D6D0C0", VA = "0x182D6E4C0")]
		[CompilerGenerated]
		private bool VRMRCCRPFEV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x2D6E440", Offset = "0x2D6D040", VA = "0x182D6E440")]
		[CompilerGenerated]
		private string VRHKEVXRVTM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C3B0", Offset = "0x2D6AFB0", VA = "0x182D6C3B0")]
		[CompilerGenerated]
		private void CTTZEXCWSJY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C3C0", Offset = "0x2D6AFC0", VA = "0x182D6C3C0")]
		[CompilerGenerated]
		private bool CTZGCDWUBVH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C320", Offset = "0x2D6AF20", VA = "0x182D6C320")]
		[CompilerGenerated]
		private string CTJLKJPBZNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C3A0", Offset = "0x2D6AFA0", VA = "0x182D6C3A0")]
		[CompilerGenerated]
		private void CTOSHQIZIYP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C1E0", Offset = "0x2D6ADE0", VA = "0x182D6C1E0")]
		[CompilerGenerated]
		private bool CSYXPWBHGQO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C2B0", Offset = "0x2D6AEB0", VA = "0x182D6C2B0")]
		[CompilerGenerated]
		private string CTEENCVEQBX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C100", Offset = "0x2D6AD00", VA = "0x182D6C100")]
		[CompilerGenerated]
		private void CSOJVINMNTW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C110", Offset = "0x2D6AD10", VA = "0x182D6C110")]
		[CompilerGenerated]
		private bool CSTQSPHJXFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C080", Offset = "0x2D6AC80", VA = "0x182D6C080")]
		[CompilerGenerated]
		private string CSDWAUZRUXE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C0F0", Offset = "0x2D6ACF0", VA = "0x182D6C0F0")]
		[CompilerGenerated]
		private void CSJCYBTPEIN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CA20", Offset = "0x2D6B620", VA = "0x182D6CA20")]
		[CompilerGenerated]
		private bool JNYRNGYFSDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x2D6C9B0", Offset = "0x2D6B5B0", VA = "0x182D6C9B0")]
		[CompilerGenerated]
		private string JNTKQAEIIRW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CBC0", Offset = "0x2D6B7C0", VA = "0x182D6CBC0")]
		[CompilerGenerated]
		private void JOJFHUMAKZX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CAF0", Offset = "0x2D6B6F0", VA = "0x182D6CAF0")]
		[CompilerGenerated]
		private bool JODYKNSDBOO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CBF0", Offset = "0x2D6B7F0", VA = "0x182D6CBF0")]
		[CompilerGenerated]
		private string JOTTCHZVDWP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CBD0", Offset = "0x2D6B7D0", VA = "0x182D6CBD0")]
		[CompilerGenerated]
		private void JOOMFBFXULG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CD80", Offset = "0x2D6B980", VA = "0x182D6CD80")]
		[CompilerGenerated]
		private bool JPEGWVNPWTH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CD20", Offset = "0x2D6B920", VA = "0x182D6CD20")]
		[CompilerGenerated]
		private object JOYZZOTSNHY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x2D6CF60", Offset = "0x2D6BB60", VA = "0x182D6CF60")]
		[CompilerGenerated]
		private void JPOURJBKPPZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2D6DF00", Offset = "0x2D6CB00", VA = "0x182D6DF00")]
		[CompilerGenerated]
		private bool QOPWLZGIHVO()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class RRIHLFQGCVL
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		private sealed class OLCFEZHRRCD : TVMAPYLHDJB<RequestAvatarLocomotionAnimationNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000043")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public OLCFEZHRRCD VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x6000119")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600011A")]
				[Cpp2IlInjected.Address(RVA = "0x2D72190", Offset = "0x2D70D90", VA = "0x182D72190")]
				internal object EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600011B")]
				[Cpp2IlInjected.Address(RVA = "0x2D71D80", Offset = "0x2D70980", VA = "0x182D71D80")]
				internal void EQIQZGORPWK(object a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2D801A0", Offset = "0x2D7EDA0", VA = "0x182D801A0")]
			public OLCFEZHRRCD(QBUZPCMMQEU a, RequestAvatarLocomotionAnimationNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x2D7FF30", Offset = "0x2D7EB30", VA = "0x182D7FF30", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public sealed class ZBJAZSYXVVA : LTSOXDTERVS<AmbientAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public override AudioClipType WLXJYYWPHHV
			{
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x2D8CBE0", Offset = "0x2D8B7E0", VA = "0x182D8CBE0")]
			public ZBJAZSYXVVA(QBUZPCMMQEU a, AmbientAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public sealed class VESXXFEVZOU : TVMAPYLHDJB<AwardConsumableNode>
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BE10", Offset = "0x2D8AA10", VA = "0x182D8BE10")]
			public VESXXFEVZOU(QBUZPCMMQEU a, AwardConsumableNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BCB0", Offset = "0x2D8A8B0", VA = "0x182D8BCB0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BC60", Offset = "0x2D8A860", VA = "0x182D8BC60")]
			[CompilerGenerated]
			private bool CKDYTKXLKYN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2D8BB30", Offset = "0x2D8A730", VA = "0x182D8BB30")]
			[CompilerGenerated]
			private void CJYRWEDOBNE(bool a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public sealed class AAIEOSFAYWI : TVMAPYLHDJB<AwardCurrencyFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public AAIEOSFAYWI VISDDFDIKLJ;

				[Cpp2IlInjected.Token(Token = "0x6000124")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0x2D72140", Offset = "0x2D70D40", VA = "0x182D72140")]
				internal void EQNXWNIOZHT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x2D720A0", Offset = "0x2D70CA0", VA = "0x182D720A0")]
				internal bool EQIQZGORPWK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x2D71AB0", Offset = "0x2D706B0", VA = "0x182D71AB0")]
				internal bool EQDKBZUUGLB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x2D718E0", Offset = "0x2D704E0", VA = "0x182D718E0")]
				internal void EPYDETAWWZS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x2D71820", Offset = "0x2D70420", VA = "0x182D71820")]
				internal bool EPSWHMGZNOJ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2D6A3B0", Offset = "0x2D68FB0", VA = "0x182D6A3B0")]
			public AAIEOSFAYWI(QBUZPCMMQEU a, AwardCurrencyFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2D6A0A0", Offset = "0x2D68CA0", VA = "0x182D6A0A0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public sealed class LKNKKYFGNIQ : TVMAPYLHDJB<AwardCurrencyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public LKNKKYFGNIQ VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public Predicate<Guid> VPAJZRIHYUN;

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x2D721F0", Offset = "0x2D70DF0", VA = "0x182D721F0")]
				internal object? EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0x2D71620", Offset = "0x2D70220", VA = "0x182D71620")]
				internal bool EPDBPRZHLGI(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012F")]
				[Cpp2IlInjected.Address(RVA = "0x2D71E50", Offset = "0x2D70A50", VA = "0x182D71E50")]
				internal void EQIQZGORPWK(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0x2D71B00", Offset = "0x2D70700", VA = "0x182D71B00")]
				internal string EQDKBZUUGLB(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0x2D71A10", Offset = "0x2D70610", VA = "0x182D71A10")]
				internal IReadOnlyList<object> EPYDETAWWZS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0x2D71870", Offset = "0x2D70470", VA = "0x182D71870")]
				internal bool EPSWHMGZNOJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0x2D717D0", Offset = "0x2D703D0", VA = "0x182D717D0")]
				internal bool EPNPKFNCEDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x2D716A0", Offset = "0x2D702A0", VA = "0x182D716A0")]
				internal void EPIIMYTEURR(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2D7FB20", Offset = "0x2D7E720", VA = "0x182D7FB20")]
			public LKNKKYFGNIQ(QBUZPCMMQEU a, AwardCurrencyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2D7F420", Offset = "0x2D7E020", VA = "0x182D7F420", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public sealed class ZKLLVRRYOGD : TVMAPYLHDJB<AwardRoomKeyNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public ZKLLVRRYOGD VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000138")]
				[Cpp2IlInjected.Address(RVA = "0x2D720F0", Offset = "0x2D70CF0", VA = "0x182D720F0")]
				internal bool EQNXWNIOZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0x2D71C50", Offset = "0x2D70850", VA = "0x182D71C50")]
				internal void EQIQZGORPWK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600013A")]
				[Cpp2IlInjected.Address(RVA = "0x2D71A60", Offset = "0x2D70660", VA = "0x182D71A60")]
				internal bool EQDKBZUUGLB()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x2D8CE50", Offset = "0x2D8BA50", VA = "0x182D8CE50")]
			public ZKLLVRRYOGD(QBUZPCMMQEU a, AwardRoomKeyNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x2D8CC40", Offset = "0x2D8B840", VA = "0x182D8CC40", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class KRYPBRHPSTG : TVMAPYLHDJB<CNZTMTSADLL>
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class HCFOWLTMZUC
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200004E")]
				private struct <<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000DA")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40000DB")]
					public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000DC")]
					public HCFOWLTMZUC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000DD")]
					private TaskAwaiter<Result<Id32<XXUTQJTARJE>, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0x2D89220", Offset = "0x2D87E20", VA = "0x182D89220", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0x2D89600", Offset = "0x2D88200", VA = "0x182D89600", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200004F")]
				private struct <<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000DE")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40000DF")]
					public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000E0")]
					public HCFOWLTMZUC <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000E1")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0x2D89670", Offset = "0x2D88270", VA = "0x182D89670", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0x2D89A00", Offset = "0x2D88600", VA = "0x182D89A00", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public Task MOLYBXRHHVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public string XESLNLFSXCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public TXKDNVJCJHK.JQMEYYQIKVE FRIRQYVMTQN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public bool TLVNTTBJUEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public KRYPBRHPSTG VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public TXKDNVJCJHK ECXAKOICCCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public Action KAXKJDHWLFH;

				[Cpp2IlInjected.Token(Token = "0x6000142")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public HCFOWLTMZUC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000143")]
				[Cpp2IlInjected.Address(RVA = "0x2D72A40", Offset = "0x2D71640", VA = "0x182D72A40")]
				internal bool VYTSMVGYMRJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				internal string LOYYNSUEGMU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0x2D728D0", Offset = "0x2D714D0", VA = "0x182D728D0")]
				internal void LPOTFNBWIUV(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000146")]
				[Cpp2IlInjected.Address(RVA = "0x2D72880", Offset = "0x2D71480", VA = "0x182D72880")]
				internal void LPJMIGHYZJM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000147")]
				[Cpp2IlInjected.Address(RVA = "0x16B9430", Offset = "0x16B8030", VA = "0x1816B9430")]
				internal bool LOJDVYMMEET()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0x2D72620", Offset = "0x2D71220", VA = "0x182D72620")]
				internal void LODWYRSOUTK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x2D72840", Offset = "0x2D71440", VA = "0x182D72840")]
				internal bool LOTRQMAGXBL()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0x2D72530", Offset = "0x2D71130", VA = "0x182D72530")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__CreateNewBehavior|7>d))]
				internal Task<Result<None, JGXPLWKAZER>> HRAAEMBQUGH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0x2D72950", Offset = "0x2D71550", VA = "0x182D72950")]
				[AsyncStateMachine(typeof(<<OnAddOrEditBehaviorButtonClicked>g__EditBehavior|8>d))]
				internal Task<Result<None, JGXPLWKAZER>> ONFSTGIPFJS()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000050")]
			[CompilerGenerated]
			private sealed class XYJRREPQRHS
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000051")]
				private struct <<BuildConfigMenuInternal>g__CreateNewVersion|0>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40000E8")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40000E9")]
					public AsyncTaskMethodBuilder<Result<Id32<XXUTQJTARJE>, JGXPLWKAZER>> <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
					[Cpp2IlInjected.Token(Token = "0x40000EA")]
					public XYJRREPQRHS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40000EB")]
					private TaskAwaiter<Result<Id32<XXUTQJTARJE>, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0x2D88E40", Offset = "0x2D87A40", VA = "0x182D88E40", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0x2D891B0", Offset = "0x2D87DB0", VA = "0x182D891B0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public KRYPBRHPSTG VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public RIUQPTLWHHA RZPVQTMKZXF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				public bool ZULBWQVDBJV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				public TXKDNVJCJHK ECXAKOICCCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				public OHUCYPOHKAG QEUOCMJGFXT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				public Action VLZKOTVVNGI;

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public XYJRREPQRHS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C8F0", Offset = "0x2D8B4F0", VA = "0x182D8C8F0")]
				internal object? EQIQZGORPWK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C800", Offset = "0x2D8B400", VA = "0x182D8C800")]
				internal void EQDKBZUUGLB(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C710", Offset = "0x2D8B310", VA = "0x182D8C710")]
				internal string EPYDETAWWZS(object? v)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000154")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C670", Offset = "0x2D8B270", VA = "0x182D8C670")]
				internal IReadOnlyList<object> EPSWHMGZNOJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C510", Offset = "0x2D8B110", VA = "0x182D8C510")]
				internal void EPNPKFNCEDA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C4A0", Offset = "0x2D8B0A0", VA = "0x182D8C4A0")]
				internal bool EPIIMYTEURR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C3E0", Offset = "0x2D8AFE0", VA = "0x182D8C3E0")]
				internal void EPDBPRZHLGI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C390", Offset = "0x2D8AF90", VA = "0x182D8C390")]
				internal void EOXUSLFKBUZ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C310", Offset = "0x2D8AF10", VA = "0x182D8C310")]
				internal void EOSNVELMSJQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C960", Offset = "0x2D8B560", VA = "0x182D8C960")]
				internal bool YCYSMLJLKXI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0x2D8C220", Offset = "0x2D8AE20", VA = "0x182D8C220")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>g__CreateNewVersion|0>d))]
				internal Task<Result<Id32<XXUTQJTARJE>, JGXPLWKAZER>> CCTVENDTHLQ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600013B")]
				[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000031")]
			public override bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600013C")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000032")]
			public override Id32<JQPVMRMCZNG>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600013D")]
				[Cpp2IlInjected.Address(RVA = "0x2D74830", Offset = "0x2D73430", VA = "0x182D74830", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			protected override bool MAMZSVMDOYP
			{
				[Cpp2IlInjected.Token(Token = "0x600013E")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x2D747C0", Offset = "0x2D733C0", VA = "0x182D747C0")]
			public KRYPBRHPSTG(QBUZPCMMQEU a, CNZTMTSADLL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x2D737A0", Offset = "0x2D723A0", VA = "0x182D737A0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x2D74130", Offset = "0x2D72D30", VA = "0x182D74130")]
			private void WVSJHDRSTUB(TXKDNVJCJHK a, Id32<XXUTQJTARJE>? behaviorId, Action? onSuccessfullySetBehavior)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private sealed class KRRSSIAHWWF : EKJDOPKEKWM<ZMVHTCKLGVA>
		{
			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x1744A20", Offset = "0x1743620", VA = "0x181744A20", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public override bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			protected override bool PQEFWZRVFHS
			{
				[Cpp2IlInjected.Token(Token = "0x6000162")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			protected override bool XTUAPRPGDSL
			{
				[Cpp2IlInjected.Token(Token = "0x6000163")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			protected override bool ZPTONGQVGBY
			{
				[Cpp2IlInjected.Token(Token = "0x6000164")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			protected override bool MAMZSVMDOYP
			{
				[Cpp2IlInjected.Token(Token = "0x6000165")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x2D73740", Offset = "0x2D72340", VA = "0x182D73740")]
			public KRRSSIAHWWF(QBUZPCMMQEU a, ZMVHTCKLGVA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public abstract class JYMIUZXGJNP<a> : TVMAPYLHDJB<a> where a : notnull, JXKXDWTXVKL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000054")]
			[CompilerGenerated]
			private struct <AddPortGroup>d__7 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				public AsyncTaskMethodBuilder<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public JYMIUZXGJNP<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				private TaskAwaiter<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x53705C0", Offset = "0x536F1C0", VA = "0x1853705C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x5370910", Offset = "0x536F510", VA = "0x185370910", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			[CompilerGenerated]
			private struct <RemovePortGroup>d__11 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				public JYMIUZXGJNP<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				public Id32<CUMWXIQVBDQ> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x55F03F0", Offset = "0x55EEFF0", VA = "0x1855F03F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x55F0740", Offset = "0x55EF340", VA = "0x1855F0740", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public sealed override bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000167")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public sealed override Id32<CUMWXIQVBDQ>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000168")]
				[Cpp2IlInjected.Address(RVA = "0x57326B0", Offset = "0x57312B0", VA = "0x1857326B0", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x5732680", Offset = "0x5731280", VA = "0x185732680")]
			protected JYMIUZXGJNP(QBUZPCMMQEU a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x5732560", Offset = "0x5731160", VA = "0x185732560", Slot = "122")]
			[AsyncStateMachine(typeof(JYMIUZXGJNP<>.<AddPortGroup>d__7))]
			public override Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> TXYUKLOTKFU(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x5732420", Offset = "0x5731020", VA = "0x185732420", Slot = "149")]
			public sealed override bool IGYPXLPSLTF(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x57324C0", Offset = "0x57310C0", VA = "0x1857324C0", Slot = "134")]
			protected sealed override bool OQPVAPFAKVP(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x5732380", Offset = "0x5730F80", VA = "0x185732380", Slot = "135")]
			protected override bool HEQUXAYPEZE(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x5732270", Offset = "0x5730E70", VA = "0x185732270", Slot = "123")]
			[AsyncStateMachine(typeof(JYMIUZXGJNP<>.<RemovePortGroup>d__11))]
			public override Task<Result<None, JGXPLWKAZER>> EMVVQHAPLMV(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public sealed class JQFOBXWAOFK : BEBUHZZYJSX<BoolNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				public JQFOBXWAOFK VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000176")]
				[Cpp2IlInjected.Address(RVA = "0x2D722E0", Offset = "0x2D70EE0", VA = "0x182D722E0")]
				internal bool JYYGBZYKCVG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x2D723E0", Offset = "0x2D70FE0", VA = "0x182D723E0")]
				internal void JZDMZGSHMGP(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x2D736E0", Offset = "0x2D722E0", VA = "0x182D736E0")]
			public JQFOBXWAOFK(QBUZPCMMQEU a, BoolNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x2D734A0", Offset = "0x2D720A0", VA = "0x182D734A0", Slot = "151")]
			protected override void JUYYYBSEVZO(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class GCQHBMTTGLB : EKJDOPKEKWM<XBUFPLAIPLS>
		{
			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x2D70F50", Offset = "0x2D6FB50", VA = "0x182D70F50")]
			public GCQHBMTTGLB(QBUZPCMMQEU a, XBUFPLAIPLS b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public abstract class EKJDOPKEKWM<a> : TVMAPYLHDJB<a> where a : notnull, ABDFCXSCHCE
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			[CompilerGenerated]
			private sealed class UCNFUKMIBEA
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005C")]
				private struct <<BuildConfigMenuInternal>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000106")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000107")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000108")]
					public UCNFUKMIBEA <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000109")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0x428D360", Offset = "0x428BF60", VA = "0x18428D360", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				public TXKDNVJCJHK ECXAKOICCCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public EKJDOPKEKWM<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public Action VOVDCKOKPJE;

				[Cpp2IlInjected.Token(Token = "0x60001A3")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public UCNFUKMIBEA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A4")]
				[Cpp2IlInjected.Address(RVA = "0x6809BA0", Offset = "0x68087A0", VA = "0x186809BA0")]
				internal void EQNXWNIOZHT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A5")]
				[Cpp2IlInjected.Address(RVA = "0x68096F0", Offset = "0x68082F0", VA = "0x1868096F0")]
				[AsyncStateMachine(typeof(EKJDOPKEKWM<>.UCNFUKMIBEA.<<BuildConfigMenuInternal>b__6>d))]
				internal void EPIIMYTEURR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001A6")]
				[Cpp2IlInjected.Address(RVA = "0x6809790", Offset = "0x6808390", VA = "0x186809790")]
				internal bool EQIQZGORPWK()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005D")]
			[CompilerGenerated]
			private sealed class UCSMRRGFKPJ
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200005E")]
				private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400010F")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000110")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000111")]
					public UCSMRRGFKPJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000112")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000113")]
					private TaskAwaiter<TaskStatus> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0x428CF60", Offset = "0x428BB60", VA = "0x18428CF60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public string SBVETTNIGGC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public UCNFUKMIBEA JZUGHOQQQFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public Func<string> VOFIKQGSNBD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public Action<string> VOKPHXAPWMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public Action VOPWFDUNFXV;

				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public UCSMRRGFKPJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x6809F10", Offset = "0x6808B10", VA = "0x186809F10")]
				internal void EQDKBZUUGLB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				internal string EPYDETAWWZS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				internal void EPSWHMGZNOJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x6809E70", Offset = "0x6808A70", VA = "0x186809E70")]
				[AsyncStateMachine(typeof(EKJDOPKEKWM<>.UCSMRRGFKPJ.<<BuildConfigMenuInternal>b__5>d))]
				internal void EPNPKFNCEDA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200005F")]
			[CompilerGenerated]
			private sealed class PLZNLAKFXUV
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000060")]
				private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000121")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000122")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000123")]
					public PLZNLAKFXUV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000124")]
					private TaskAwaiter<Result<Id32<TIEJMITYOHO>, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0x428AD80", Offset = "0x4289980", VA = "0x18428AD80", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000061")]
				private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000125")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000126")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000127")]
					public PLZNLAKFXUV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000128")]
					private TaskAwaiter<TaskStatus> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0x428B4C0", Offset = "0x428A0C0", VA = "0x18428B4C0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000062")]
				private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000129")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012A")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012B")]
					public PLZNLAKFXUV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400012C")]
					private TaskAwaiter<Result<Id32<VPKCJSHTFFF>, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0x428B6A0", Offset = "0x428A2A0", VA = "0x18428B6A0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public EKJDOPKEKWM<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public Id32<CUMWXIQVBDQ> JOBUTHOWAUU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public TXKDNVJCJHK ECXAKOICCCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				public JDUQSSPECCA RAWCDXWJMFB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				public int JMNEBDCOFDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public int ZMCWPBXZRWE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public YTMTLPGRGSJ SIJJZIWILZK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public string OCSVYVVPZTH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public List<HAZNRURCQZV> VSUYXIKMWRW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public YTMTLPGRGSJ FJTYDJABYAZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				public string MROKPOJWTXA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				public List<HAZNRURCQZV> GDZTQYIHGSB;

				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public PLZNLAKFXUV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0x6184400", Offset = "0x6183000", VA = "0x186184400")]
				internal bool OZKFWHHCUEM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B2")]
				[Cpp2IlInjected.Address(RVA = "0x6184470", Offset = "0x6183070", VA = "0x186184470")]
				internal void OZPMTOBADPV(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B3")]
				[Cpp2IlInjected.Address(RVA = "0x6183E70", Offset = "0x6182A70", VA = "0x186183E70")]
				internal bool IFZKNPBOGEM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B4")]
				[Cpp2IlInjected.Address(RVA = "0x61844E0", Offset = "0x61830E0", VA = "0x1861844E0")]
				[AsyncStateMachine(typeof(EKJDOPKEKWM<>.PLZNLAKFXUV.<<AddDynamicNodeGroupSettingV2>b__2>d))]
				internal void OZUTQUUXNBE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B5")]
				[Cpp2IlInjected.Address(RVA = "0x6184580", Offset = "0x6183180", VA = "0x186184580")]
				internal bool PAAAOBOUWMN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B6")]
				[Cpp2IlInjected.Address(RVA = "0x6183D90", Offset = "0x6182990", VA = "0x186183D90")]
				internal void IFEIYNZYULC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B7")]
				[Cpp2IlInjected.Address(RVA = "0x6184090", Offset = "0x6182C90", VA = "0x186184090")]
				internal bool IIFIJLMLFZH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x6183FB0", Offset = "0x6182BB0", VA = "0x186183FB0")]
				internal void IIABMESNWNY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x61845C0", Offset = "0x61831C0", VA = "0x1861845C0")]
				internal bool PHGKEBRIYEW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x6184220", Offset = "0x6182E20", VA = "0x186184220")]
				internal bool OYPEHGFNILC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001BB")]
				[Cpp2IlInjected.Address(RVA = "0x6184290", Offset = "0x6182E90", VA = "0x186184290")]
				internal void OYULEMZKRWL(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0x6184300", Offset = "0x6182F00", VA = "0x186184300")]
				[AsyncStateMachine(typeof(EKJDOPKEKWM<>.PLZNLAKFXUV.<<AddDynamicNodeGroupSettingV2>b__6>d))]
				internal void OYZSBTTIBHU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(RVA = "0x61843A0", Offset = "0x6182FA0", VA = "0x1861843A0")]
				internal bool OZEYZANFKTD()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(RVA = "0x6184140", Offset = "0x6182D40", VA = "0x186184140")]
				internal bool OXUCSFDXWRS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x61841B0", Offset = "0x6182DB0", VA = "0x1861841B0")]
				internal void OXZJPLXVGDB(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x6183F10", Offset = "0x6182B10", VA = "0x186183F10")]
				[AsyncStateMachine(typeof(EKJDOPKEKWM<>.PLZNLAKFXUV.<<AddDynamicNodeGroupSettingV2>b__10>d))]
				internal void IGPFFJJGIMN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C1")]
				[Cpp2IlInjected.Address(RVA = "0x6183EB0", Offset = "0x6182AB0", VA = "0x186183EB0")]
				internal bool IGJYICPIZBE()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000063")]
			[CompilerGenerated]
			private sealed class PLUGNTQIOJM
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000064")]
				private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000132")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000133")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000134")]
					public PLUGNTQIOJM <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000135")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000136")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0x428B070", Offset = "0x4289C70", VA = "0x18428B070", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				public string JDOWLBZZALE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				public PLZNLAKFXUV JZUGHOQQQFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				public Func<string> BVIFYQPIVSF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				public Action<string> BVCZBJVLMGW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				public Action BUXSEDBOCVN;

				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public PLUGNTQIOJM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001C9")]
				[Cpp2IlInjected.Address(RVA = "0x61828C0", Offset = "0x61814C0", VA = "0x1861828C0")]
				internal void IGERKVVLPPV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CA")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				internal string IFUDQIHQWTD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001CB")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				internal void IFOWTBNTNHU(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001CC")]
				[Cpp2IlInjected.Address(RVA = "0x6182820", Offset = "0x6181420", VA = "0x186182820")]
				[AsyncStateMachine(typeof(EKJDOPKEKWM<>.PLUGNTQIOJM.<<AddDynamicNodeGroupSettingV2>b__16>d))]
				internal void IFJPVUTWDWL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000065")]
			[CompilerGenerated]
			private sealed class TYYXAWPANUK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				public bool VSUYXIKMWRW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				public JDUQSSPECCA RAWCDXWJMFB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				public List<HAZNRURCQZV> KYDVQZHFBZD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				public EKJDOPKEKWM<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				public Id32<CUMWXIQVBDQ> JOBUTHOWAUU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				public int JBDVOOTQXJP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				public Func<bool> VNUUQCSXUEL;

				[Cpp2IlInjected.Token(Token = "0x60001CF")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public TYYXAWPANUK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D0")]
				[Cpp2IlInjected.Address(RVA = "0x6612460", Offset = "0x6611060", VA = "0x186612460")]
				internal bool XZCRZDZHHGE()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000066")]
			[CompilerGenerated]
			private sealed class TZEDYDIXXFT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				public EAPWZEKDOJL BFDWJQVVDVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				public TYYXAWPANUK JZUGHOQQQFE;

				[Cpp2IlInjected.Token(Token = "0x60001D1")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public TZEDYDIXXFT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D2")]
				[Cpp2IlInjected.Address(RVA = "0x6612700", Offset = "0x6611300", VA = "0x186612700")]
				internal void XZSMQYGZJOF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D3")]
				[Cpp2IlInjected.Address(RVA = "0x66126B0", Offset = "0x66112B0", VA = "0x1866126B0")]
				internal bool XZNFTRNCACW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60001D4")]
				[Cpp2IlInjected.Address(RVA = "0x6612520", Offset = "0x6611120", VA = "0x186612520")]
				internal void XYMXHJRPEYD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x66124C0", Offset = "0x66110C0", VA = "0x1866124C0")]
				internal bool XYHQKCXRVMU()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000067")]
			[CompilerGenerated]
			private sealed class TYOJGJBFUXS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				public HAZNRURCQZV PMESTIRHSAI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				public TZEDYDIXXFT JZOZKHWTGTV;

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public TYOJGJBFUXS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x66121E0", Offset = "0x6610DE0", VA = "0x1866121E0")]
				internal void XZHYWKTEQRN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000068")]
			[CompilerGenerated]
			private sealed class ELZBGXNWURJ
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000069")]
				private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000149")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400014A")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400014B")]
					public ELZBGXNWURJ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400014C")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400014D")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400014E")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0x428E0B0", Offset = "0x428CCB0", VA = "0x18428E0B0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				public List<object> OIYPJMPWBYU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				public YTMTLPGRGSJ ALUWFWGHGKY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				public bool VSUYXIKMWRW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				public JDUQSSPECCA RAWCDXWJMFB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				public EAPWZEKDOJL BFDWJQVVDVQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				public string JDOWLBZZALE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x60001D8")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public ELZBGXNWURJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x4CCFF00", Offset = "0x4CCEB00", VA = "0x184CCFF00")]
				internal int JIBJJUWDVDZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001DA")]
				[Cpp2IlInjected.Address(RVA = "0x4CCFCB0", Offset = "0x4CCE8B0", VA = "0x184CCFCB0")]
				internal void JHWCMOCGLSQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001DB")]
				[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
				internal string JILXEIJYOAR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60001DC")]
				[Cpp2IlInjected.Address(RVA = "0x4CCFF40", Offset = "0x4CCEB40", VA = "0x184CCFF40")]
				[AsyncStateMachine(typeof(EKJDOPKEKWM<>.ELZBGXNWURJ.<<CreatePortItemV2>b__3>d))]
				internal void JIGQHBQBEPI(string a)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			[CompilerGenerated]
			private struct <AddPortGroup>d__20 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400014F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000150")]
				public AsyncTaskMethodBuilder<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000151")]
				public EKJDOPKEKWM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000152")]
				public string name;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000153")]
				private TaskAwaiter<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001DF")]
				[Cpp2IlInjected.Address(RVA = "0x53701A0", Offset = "0x536EDA0", VA = "0x1853701A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E0")]
				[Cpp2IlInjected.Address(RVA = "0x5370550", Offset = "0x536F150", VA = "0x185370550", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			[CompilerGenerated]
			private struct <RemovePortGroup>d__21 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000154")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000155")]
				public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000156")]
				public EKJDOPKEKWM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000157")]
				public Id32<CUMWXIQVBDQ> portGroupId;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000158")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x55F07B0", Offset = "0x55EF3B0", VA = "0x1855F07B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0x55F0AE0", Offset = "0x55EF6E0", VA = "0x1855F0AE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006C")]
			[CompilerGenerated]
			private struct <RequestDeleteAllBoardContent>d__26 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000159")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400015A")]
				public AsyncTaskMethodBuilder<Result<MultiResult, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400015B")]
				public EKJDOPKEKWM<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400015C")]
				private TaskAwaiter<Result<MultiResult, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x55F64E0", Offset = "0x55F50E0", VA = "0x1855F64E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x55F6A80", Offset = "0x55F5680", VA = "0x1855F6A80", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private readonly Dictionary<Id32<CUMWXIQVBDQ>, bool> YJFSYAANXYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private readonly Dictionary<Id32<CUMWXIQVBDQ>, bool> IPEYBJMXNJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private readonly Dictionary<Id32<CUMWXIQVBDQ>, bool> RJZLQVEFLVP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private Dictionary<Id32<CUMWXIQVBDQ>, bool> THNLUPGGERY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private Dictionary<Id32<CUMWXIQVBDQ>, bool> HAGQJOLVDBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private Dictionary<Id32<CUMWXIQVBDQ>, bool> WPTNQHDQBUL;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public override bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			protected virtual bool PQEFWZRVFHS
			{
				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "151")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			protected virtual bool XTUAPRPGDSL
			{
				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "152")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			protected virtual bool ZPTONGQVGBY
			{
				[Cpp2IlInjected.Token(Token = "0x600017D")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "153")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override Id32<JQPVMRMCZNG>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600017E")]
				[Cpp2IlInjected.Address(RVA = "0x4CCC1E0", Offset = "0x4CCADE0", VA = "0x184CCC1E0", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public override Id32<CUMWXIQVBDQ>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x600017F")]
				[Cpp2IlInjected.Address(RVA = "0x4CCC450", Offset = "0x4CCB050", VA = "0x184CCC450", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override IEnumerable<Id128<LWYTCPIHOQE>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x4CCC260", Offset = "0x4CCAE60", VA = "0x184CCC260", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4CCC010", Offset = "0x4CCAC10", VA = "0x184CCC010")]
			public EKJDOPKEKWM(QBUZPCMMQEU a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "154")]
			protected virtual bool URYXCKVCEGJ(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "155")]
			protected virtual bool YSKAMACCACW(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "156")]
			protected virtual bool OVFFEPCTNFN(int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "157")]
			protected virtual void CQBYGVNZEMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4CC7EC0", Offset = "0x4CC6AC0", VA = "0x184CC7EC0", Slot = "149")]
			public override bool IGYPXLPSLTF(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4CC9210", Offset = "0x4CC7E10", VA = "0x184CC9210", Slot = "122")]
			[AsyncStateMachine(typeof(EKJDOPKEKWM<>.<AddPortGroup>d__20))]
			public override Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> TXYUKLOTKFU(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4CC77D0", Offset = "0x4CC63D0", VA = "0x184CC77D0", Slot = "123")]
			[AsyncStateMachine(typeof(EKJDOPKEKWM<>.<RemovePortGroup>d__21))]
			public override Task<Result<None, JGXPLWKAZER>> EMVVQHAPLMV(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4CC7D20", Offset = "0x4CC6920", VA = "0x184CC7D20", Slot = "124")]
			public override void HEIVUXIONDT(Id32<CUMWXIQVBDQ> index, Id32<CUMWXIQVBDQ> target)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4CC7AD0", Offset = "0x4CC66D0", VA = "0x184CC7AD0", Slot = "125")]
			public override IEnumerable<FJCTCRTIJZZ> FVIDWVYXVZE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4CC76D0", Offset = "0x4CC62D0", VA = "0x184CC76D0")]
			[AsyncStateMachine(typeof(EKJDOPKEKWM<>.<RequestDeleteAllBoardContent>d__26))]
			private Task<Result<MultiResult, JGXPLWKAZER>> CMILTRAUDPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "158")]
			protected virtual bool GZONODDDPHC(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "159")]
			protected virtual bool FXDORMQHMXU(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "160")]
			protected virtual bool FQHMNOOCDZR(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "161")]
			protected virtual bool OOTSWMRMUUH(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "162")]
			protected virtual bool CWFFGEXWNPZ(Id32<CUMWXIQVBDQ> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "163")]
			protected virtual bool WNNCSGXBYYE(Id32<CUMWXIQVBDQ> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "164")]
			protected virtual bool UQCXNLAHSMC(Id32<CUMWXIQVBDQ> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "165")]
			protected virtual bool CPDEKBPIBML(Id32<CUMWXIQVBDQ> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "166")]
			protected virtual bool ELSSQPUDQBF(Id32<CUMWXIQVBDQ> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "167")]
			protected virtual bool BWWBOKGLDOW(Id32<CUMWXIQVBDQ> portGroupId, int a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x4CC7F60", Offset = "0x4CC6B60", VA = "0x184CC7F60", Slot = "168")]
			protected virtual List<YTMTLPGRGSJ> JVYAIDNWYGM(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "169")]
			protected virtual void JOPIMUBVCAJ(TXKDNVJCJHK a, SCQCCQCRVAW b, JDUQSSPECCA c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x4CC9330", Offset = "0x4CC7F30", VA = "0x184CC9330", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x4CC9D30", Offset = "0x4CC8930", VA = "0x184CC9D30")]
			private SCQCCQCRVAW WLUFUEDWMDC(TXKDNVJCJHK a, JDUQSSPECCA b, Id32<CUMWXIQVBDQ> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4CC81B0", Offset = "0x4CC6DB0", VA = "0x184CC81B0")]
			private List<HAZNRURCQZV> OAXOSLNUWXH(TXKDNVJCJHK a, JDUQSSPECCA b, SCQCCQCRVAW c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x4CCB680", Offset = "0x4CCA280", VA = "0x184CCB680")]
			private List<HAZNRURCQZV> YRHRWHUYXUV(TXKDNVJCJHK a, JDUQSSPECCA b, EAPWZEKDOJL c, bool d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x4CC78E0", Offset = "0x4CC64E0", VA = "0x184CC78E0")]
			private YTMTLPGRGSJ FJPERMPAIQZ(List<YTMTLPGRGSJ> a, EAPWZEKDOJL b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4CC9CD0", Offset = "0x4CC88D0", VA = "0x184CC9CD0")]
			[CompilerGenerated]
			private FJCTCRTIJZZ ULQYZPTFUJX(OINYKCZIBWN a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public sealed class YJXQADMSXOH : TVMAPYLHDJB<ColorConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			[CompilerGenerated]
			private sealed class QBWFFRHGRMS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400015D")]
				public YJXQADMSXOH VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400015E")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public QBWFFRHGRMS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x2D82770", Offset = "0x2D81370", VA = "0x182D82770")]
				internal int EQNXWNIOZHT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001EA")]
				[Cpp2IlInjected.Address(RVA = "0x2D826E0", Offset = "0x2D812E0", VA = "0x182D826E0")]
				internal void EQIQZGORPWK(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x13736F0", Offset = "0x13722F0", VA = "0x1813736F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x2D8CB70", Offset = "0x2D8B770", VA = "0x182D8CB70")]
			public YJXQADMSXOH(QBUZPCMMQEU a, ColorConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x2D8C9C0", Offset = "0x2D8B5C0", VA = "0x182D8C9C0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public sealed class TZNKARGZFRV : BEBUHZZYJSX<ColorNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000070")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400015F")]
				public TZNKARGZFRV VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000160")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x60001ED")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0x2D72360", Offset = "0x2D70F60", VA = "0x182D72360")]
				internal int JYYGBZYKCVG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60001EF")]
				[Cpp2IlInjected.Address(RVA = "0x2D72490", Offset = "0x2D71090", VA = "0x182D72490")]
				internal void JZDMZGSHMGP(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2D85220", Offset = "0x2D83E20", VA = "0x182D85220")]
			public TZNKARGZFRV(QBUZPCMMQEU a, ColorNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2D85000", Offset = "0x2D83C00", VA = "0x182D85000", Slot = "151")]
			protected override void JUYYYBSEVZO(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private sealed class ETVMESPAWMJ : TVMAPYLHDJB<CommentNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60001F0")]
				[Cpp2IlInjected.Address(RVA = "0xFA3DD0", Offset = "0xFA29D0", VA = "0x180FA3DD0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x2D6ED10", Offset = "0x2D6D910", VA = "0x182D6ED10")]
			public ETVMESPAWMJ(QBUZPCMMQEU a, CommentNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public sealed class FLBNDZHKHHL : TVMAPYLHDJB<IVNCIBJJYSC>
		{
			[Cpp2IlInjected.Token(Token = "0x2000074")]
			[CompilerGenerated]
			private sealed class LIKIZMPSLOB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public FLBNDZHKHHL VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				public TXKDNVJCJHK ECXAKOICCCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				public Func<string> MQLPRGIPKXJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				public Action<string> MQQWONCMUIS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018E")]
				public Func<int> MPQOCFGZZDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018F")]
				public Action<int> MPVUZMAXIPI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000190")]
				public Func<bool> MQBBWSUUSAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
				[Cpp2IlInjected.Token(Token = "0x4000191")]
				public Func<bool> MRWLYBRWYYU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
				[Cpp2IlInjected.Token(Token = "0x4000192")]
				public Func<bool> MSBSVILUIKD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
				[Cpp2IlInjected.Token(Token = "0x4000193")]
				public Func<float> TQXNSRWUREJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				public Action<float> TQSGVLCXHTA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				public Func<bool> TQMZYEIZYHR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				public Func<bool> TQHTAXPCOWI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				public Func<bool> TQCMDQVFFKZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
				[Cpp2IlInjected.Token(Token = "0x4000198")]
				public Func<string> TPXFGKBHVZQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				public Action<string> TPRYJDHKMOH;

				[Cpp2IlInjected.Token(Token = "0x600021E")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public LIKIZMPSLOB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600021F")]
				[Cpp2IlInjected.Address(RVA = "0x2D75770", Offset = "0x2D74370", VA = "0x182D75770")]
				internal bool EQNXWNIOZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000220")]
				[Cpp2IlInjected.Address(RVA = "0x2D75710", Offset = "0x2D74310", VA = "0x182D75710")]
				internal void EQIQZGORPWK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000221")]
				[Cpp2IlInjected.Address(RVA = "0x2D756C0", Offset = "0x2D742C0", VA = "0x182D756C0")]
				internal bool EPSWHMGZNOJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000222")]
				[Cpp2IlInjected.Address(RVA = "0x2D75670", Offset = "0x2D74270", VA = "0x182D75670")]
				internal bool EPNPKFNCEDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000223")]
				[Cpp2IlInjected.Address(RVA = "0x2D75610", Offset = "0x2D74210", VA = "0x182D75610")]
				internal void EPIIMYTEURR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000224")]
				[Cpp2IlInjected.Address(RVA = "0x2D755C0", Offset = "0x2D741C0", VA = "0x182D755C0")]
				internal bool EOSNVELMSJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000225")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F080", Offset = "0x2D7DC80", VA = "0x182D7F080")]
				internal bool YCYSMLJLKXI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000226")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F0D0", Offset = "0x2D7DCD0", VA = "0x182D7F0D0")]
				internal void YDDZJSDIUIR(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000227")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F190", Offset = "0x2D7DD90", VA = "0x182D7F190")]
				internal bool YDTUBMLAWQS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000228")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F1E0", Offset = "0x2D7DDE0", VA = "0x182D7F1E0")]
				internal bool YDZAYTEYGCB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000229")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F130", Offset = "0x2D7DD30", VA = "0x182D7F130")]
				internal void YDJGGYXGDUA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600022A")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F030", Offset = "0x2D7DC30", VA = "0x182D7F030")]
				internal bool YBNWFQADWVX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022B")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C580", Offset = "0x2D7B180", VA = "0x182D7C580")]
				internal bool LATFNHQRFPO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022C")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C5D0", Offset = "0x2D7B1D0", VA = "0x182D7C5D0")]
				internal bool LAYMKOKOPAX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022D")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C620", Offset = "0x2D7B220", VA = "0x182D7C620")]
				internal bool LBDTHVELYMG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022E")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C720", Offset = "0x2D7B320", VA = "0x182D7C720")]
				internal bool LDEKGKVLOVS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600022F")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C770", Offset = "0x2D7B370", VA = "0x182D7C770")]
				internal bool LDJRDRPIYHB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000230")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DF70", Offset = "0x2D7CB70", VA = "0x182D7DF70")]
				internal bool RCHNNTBIVEZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000231")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DF20", Offset = "0x2D7CB20", VA = "0x182D7DF20")]
				internal bool RCCGQMHLLTQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000232")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DEC0", Offset = "0x2D7CAC0", VA = "0x182D7DEC0")]
				internal void RBWZTFNOCIH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000233")]
				[Cpp2IlInjected.Address(RVA = "0x2D75330", Offset = "0x2D73F30", VA = "0x182D75330")]
				internal bool EARVGJQGSFG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000234")]
				[Cpp2IlInjected.Address(RVA = "0x2D753D0", Offset = "0x2D73FD0", VA = "0x182D753D0")]
				internal bool EBHPYDXYUNH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000235")]
				[Cpp2IlInjected.Address(RVA = "0x2D75380", Offset = "0x2D73F80", VA = "0x182D75380")]
				internal bool EBCJAXEBLBY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000236")]
				[Cpp2IlInjected.Address(RVA = "0x2D75420", Offset = "0x2D74020", VA = "0x182D75420")]
				internal bool EBMWVKRWDYQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000237")]
				[Cpp2IlInjected.Address(RVA = "0x2D754C0", Offset = "0x2D740C0", VA = "0x182D754C0")]
				internal bool ECCRNEZOGGR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000238")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DE70", Offset = "0x2D7CA70", VA = "0x182D7DE70")]
				internal bool RBRSVYTQSWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000239")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DE20", Offset = "0x2D7CA20", VA = "0x182D7DE20")]
				internal bool RBMLYRZTJLP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023A")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DDC0", Offset = "0x2D7C9C0", VA = "0x182D7DDC0")]
				internal void RBHFBLFWAAG(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DD70", Offset = "0x2D7C970", VA = "0x182D7DD70")]
				internal bool RBBYEELYQOX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DD20", Offset = "0x2D7C920", VA = "0x182D7DD20")]
				internal bool RAWRGXSBHDO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023D")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E010", Offset = "0x2D7CC10", VA = "0x182D7E010")]
				internal void RDXQRVENSRT(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600023E")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DFC0", Offset = "0x2D7CBC0", VA = "0x182D7DFC0")]
				internal bool RDSJUOKQJGK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600023F")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C670", Offset = "0x2D7B270", VA = "0x182D7C670")]
				internal bool LBOHCISGRIY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000240")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C6C0", Offset = "0x2D7B2C0", VA = "0x182D7C6C0")]
				internal void LBTNZPMEAUH(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000241")]
				[Cpp2IlInjected.Address(RVA = "0x2D766E0", Offset = "0x2D752E0", VA = "0x182D766E0")]
				internal List<HAZNRURCQZV> KIKGGLTWLWY(string a)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000242")]
				[Cpp2IlInjected.Address(RVA = "0x2D75470", Offset = "0x2D74070", VA = "0x182D75470")]
				internal bool EBXKPYFQWVI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000243")]
				[Cpp2IlInjected.Address(RVA = "0x2D75570", Offset = "0x2D74170", VA = "0x182D75570")]
				internal int ECNFHSNIZDJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000244")]
				[Cpp2IlInjected.Address(RVA = "0x2D75510", Offset = "0x2D74110", VA = "0x182D75510")]
				internal void ECHYKLTLPSA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000245")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EC50", Offset = "0x2D7D850", VA = "0x182D7EC50")]
				internal bool XGSJVGOVBXI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000246")]
				[Cpp2IlInjected.Address(RVA = "0x2D7ECA0", Offset = "0x2D7D8A0", VA = "0x182D7ECA0")]
				internal bool XGXQSNISLIR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EBB0", Offset = "0x2D7D7B0", VA = "0x182D7EBB0")]
				internal bool XGHWATBAJAQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EC00", Offset = "0x2D7D800", VA = "0x182D7EC00")]
				internal int XGNCXZUXSLZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EB00", Offset = "0x2D7D700", VA = "0x182D7EB00")]
				internal void XFXIGFNFQDY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600024A")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EB60", Offset = "0x2D7D760", VA = "0x182D7EB60")]
				internal bool XGCPDMHCZPH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024B")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EA60", Offset = "0x2D7D660", VA = "0x182D7EA60")]
				internal bool XFMULRZKXHG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024C")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EAB0", Offset = "0x2D7D6B0", VA = "0x182D7EAB0")]
				internal bool XFSBIYTIGSP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024D")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EA10", Offset = "0x2D7D610", VA = "0x182D7EA10")]
				internal bool XFHNOLFNNVX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024E")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D470", Offset = "0x2D7C070", VA = "0x182D7D470")]
				internal bool QGBEWOGSMEZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600024F")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E7D0", Offset = "0x2D7D3D0", VA = "0x182D7E7D0")]
				internal string UMZNRZKGVBM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E760", Offset = "0x2D7D360", VA = "0x182D7E760")]
				internal void UMUGUSQJLQD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E710", Offset = "0x2D7D310", VA = "0x182D7E710")]
				internal int UMEMCYIRJIC()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E6B0", Offset = "0x2D7D2B0", VA = "0x182D7E6B0")]
				internal void ULZFFROTZWT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E660", Offset = "0x2D7D260", VA = "0x182D7E660")]
				internal bool ULTYIKUWQLK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000254")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E610", Offset = "0x2D7D210", VA = "0x182D7E610")]
				internal bool ULORLEAZHAB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E5C0", Offset = "0x2D7D1C0", VA = "0x182D7E5C0")]
				internal bool ULJKNXHBXOS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CF70", Offset = "0x2D7BB70", VA = "0x182D7CF70")]
				internal float OMLODVVCAQU()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CFC0", Offset = "0x2D7BBC0", VA = "0x182D7CFC0")]
				internal void OMQVBCOZKCD(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D020", Offset = "0x2D7BC20", VA = "0x182D7D020")]
				internal bool OMWBYJIWTNM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000259")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D070", Offset = "0x2D7BC70", VA = "0x182D7D070")]
				internal bool ONBIVQCUCYV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CE60", Offset = "0x2D7BA60", VA = "0x182D7CE60")]
				internal bool OLQMOUTMOXK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D420", Offset = "0x2D7C020", VA = "0x182D7D420")]
				internal bool QFQRCASXTIH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025C")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D3D0", Offset = "0x2D7BFD0", VA = "0x182D7D3D0")]
				internal bool QFLKETZAJWY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025D")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D970", Offset = "0x2D7C570", VA = "0x182D7D970")]
				internal bool QGWGLPIHXYJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600025E")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D560", Offset = "0x2D7C160", VA = "0x182D7D560")]
				internal void QGQZOIOKONA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600025F")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CEB0", Offset = "0x2D7BAB0", VA = "0x182D7CEB0")]
				internal string OLVTMBNJYIT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000260")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CF00", Offset = "0x2D7BB00", VA = "0x182D7CF00")]
				internal void OMBAJIHHHUC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D510", Offset = "0x2D7C110", VA = "0x182D7D510")]
				internal bool QGLSRBUNFBR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D4C0", Offset = "0x2D7C0C0", VA = "0x182D7D4C0")]
				internal bool QGGLTVAPVQI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D380", Offset = "0x2D7BF80", VA = "0x182D7D380")]
				internal bool QELBSMDNOSF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D0C0", Offset = "0x2D7BCC0", VA = "0x182D7D0C0")]
				internal void QEFUVFJQFGW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x2D76450", Offset = "0x2D75050", VA = "0x182D76450")]
				internal bool JFJZXVYPWMQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000266")]
				[Cpp2IlInjected.Address(RVA = "0x2D764A0", Offset = "0x2D750A0", VA = "0x182D764A0")]
				internal bool JFPGVCSNFXZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000267")]
				[Cpp2IlInjected.Address(RVA = "0x2D764F0", Offset = "0x2D750F0", VA = "0x182D764F0")]
				internal bool JFUNSJMKPJI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000268")]
				[Cpp2IlInjected.Address(RVA = "0x2D76540", Offset = "0x2D75140", VA = "0x182D76540")]
				internal bool JFZUPQGHYUR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000269")]
				[Cpp2IlInjected.Address(RVA = "0x2D76590", Offset = "0x2D75190", VA = "0x182D76590")]
				internal void JGFBMXAFIGA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026A")]
				[Cpp2IlInjected.Address(RVA = "0x2D765F0", Offset = "0x2D751F0", VA = "0x182D765F0")]
				internal bool JGKIKDUCRRJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026B")]
				[Cpp2IlInjected.Address(RVA = "0x2D76640", Offset = "0x2D75240", VA = "0x182D76640")]
				internal bool JGPPHKOABCS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026C")]
				[Cpp2IlInjected.Address(RVA = "0x2D76690", Offset = "0x2D75290", VA = "0x182D76690")]
				internal bool JGUWERHXKOB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026D")]
				[Cpp2IlInjected.Address(RVA = "0x2D763A0", Offset = "0x2D74FA0", VA = "0x182D763A0")]
				internal bool JDTWTTVKYZW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600026E")]
				[Cpp2IlInjected.Address(RVA = "0x2D763F0", Offset = "0x2D74FF0", VA = "0x182D763F0")]
				internal void JDZDRAPIILF(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600026F")]
				[Cpp2IlInjected.Address(RVA = "0x2D751A0", Offset = "0x2D73DA0", VA = "0x182D751A0")]
				internal bool DEQTMLPNSQP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0x2D75150", Offset = "0x2D73D50", VA = "0x182D75150")]
				internal bool DELMPEVQJFG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000271")]
				[Cpp2IlInjected.Address(RVA = "0x2D75240", Offset = "0x2D73E40", VA = "0x182D75240")]
				internal bool DFBHGZDILNH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0x2D751F0", Offset = "0x2D73DF0", VA = "0x182D751F0")]
				internal bool DEWAJSJLCBY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000273")]
				[Cpp2IlInjected.Address(RVA = "0x2D750E0", Offset = "0x2D73CE0", VA = "0x182D750E0")]
				internal object DEGFRYBSZTX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000274")]
				[Cpp2IlInjected.Address(RVA = "0x2D75050", Offset = "0x2D73C50", VA = "0x182D75050")]
				internal void DEAYURHVQIO(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000275")]
				[Cpp2IlInjected.Address(RVA = "0x2D752E0", Offset = "0x2D73EE0", VA = "0x182D752E0")]
				internal bool DGGWQNSSQDJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x2D75290", Offset = "0x2D73E90", VA = "0x182D75290")]
				internal bool DGBPTGYVGSA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E8D0", Offset = "0x2D7D4D0", VA = "0x182D7E8D0")]
				internal int WEEVLABIMJP()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E870", Offset = "0x2D7D470", VA = "0x182D7E870")]
				internal void WDPATFTQKBO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E970", Offset = "0x2D7D570", VA = "0x182D7E970")]
				internal bool WEZXABCXYCZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027A")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E920", Offset = "0x2D7D520", VA = "0x182D7E920")]
				internal bool WEKCIGVFVUY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E9C0", Offset = "0x2D7D5C0", VA = "0x182D7E9C0")]
				internal int WFUYPCENJWJ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E260", Offset = "0x2D7CE60", VA = "0x182D7E260")]
				internal void SPXBKTHSVLI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600027D")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E2C0", Offset = "0x2D7CEC0", VA = "0x182D7E2C0")]
				internal bool SQCIIABQEWR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027E")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E1C0", Offset = "0x2D7CDC0", VA = "0x182D7E1C0")]
				internal bool SPMNQFTYCOQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600027F")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E210", Offset = "0x2D7CE10", VA = "0x182D7E210")]
				internal bool SPRUNMNVLZZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E110", Offset = "0x2D7CD10", VA = "0x182D7E110")]
				internal int SORMBESIQVG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E160", Offset = "0x2D7CD60", VA = "0x182D7E160")]
				internal void SOWSYLMGAGP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E070", Offset = "0x2D7CC70", VA = "0x182D7E070")]
				internal bool SOGYGRENXYO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E0C0", Offset = "0x2D7CCC0", VA = "0x182D7E0C0")]
				internal bool SOMFDXYLHJX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000284")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F230", Offset = "0x2D7DE30", VA = "0x182D7F230")]
				internal bool ZKBTTDDBVEP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F280", Offset = "0x2D7DE80", VA = "0x182D7F280")]
				internal object ZKROKXKTXMQ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F2F0", Offset = "0x2D7DEF0", VA = "0x182D7F2F0")]
				internal void ZLHJCRSLZUR(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000287")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F3D0", Offset = "0x2D7DFD0", VA = "0x182D7F3D0")]
				internal bool ZLRWXFGGSRJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000288")]
				[Cpp2IlInjected.Address(RVA = "0x2D7F380", Offset = "0x2D7DF80", VA = "0x182D7F380")]
				internal bool ZLMPZYMJJGA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000289")]
				[Cpp2IlInjected.Address(RVA = "0x2D75860", Offset = "0x2D74460", VA = "0x182D75860")]
				internal object? FOMQAQQOBWY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x2D758D0", Offset = "0x2D744D0", VA = "0x182D758D0")]
				internal void FORWXXKLLIH(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x2D75960", Offset = "0x2D74560", VA = "0x182D75960")]
				internal bool FPHRPRSDNQI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028C")]
				[Cpp2IlInjected.Address(RVA = "0x2D759B0", Offset = "0x2D745B0", VA = "0x182D759B0")]
				internal int FPMYMYMAXBR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x2D75A00", Offset = "0x2D74600", VA = "0x182D75A00")]
				internal void FPSFKFFYGNA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x2D75A60", Offset = "0x2D74660", VA = "0x182D75A60")]
				internal bool FPXMHLZVPYJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600028F")]
				[Cpp2IlInjected.Address(RVA = "0x2D757C0", Offset = "0x2D743C0", VA = "0x182D757C0")]
				internal bool FMWMWONJEKE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000290")]
				[Cpp2IlInjected.Address(RVA = "0x2D75810", Offset = "0x2D74410", VA = "0x182D75810")]
				internal bool FNBTTVHGNVN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000291")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C960", Offset = "0x2D7B560", VA = "0x182D7C960")]
				internal int LPFWMAZQFSZ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000292")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C900", Offset = "0x2D7B500", VA = "0x182D7C900")]
				internal void LPAPOUFSWHQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000293")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C8B0", Offset = "0x2D7B4B0", VA = "0x182D7C8B0")]
				internal bool LOVIRNLVMWH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000294")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C860", Offset = "0x2D7B460", VA = "0x182D7C860")]
				internal bool LOQBUGRYDKY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000295")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CAB0", Offset = "0x2D7B6B0", VA = "0x182D7CAB0")]
				internal bool LQAYBCBFRMJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000296")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CA60", Offset = "0x2D7B660", VA = "0x182D7CA60")]
				internal float LPVRDVHIIBA()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000297")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CA00", Offset = "0x2D7B600", VA = "0x182D7CA00")]
				internal void LPQKGONKYPR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000298")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C9B0", Offset = "0x2D7B5B0", VA = "0x182D7C9B0")]
				internal bool LPLDJHTNPEI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000299")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C810", Offset = "0x2D7B410", VA = "0x182D7C810")]
				internal bool LNPTHYWLIGF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029A")]
				[Cpp2IlInjected.Address(RVA = "0x2D7C7C0", Offset = "0x2D7B3C0", VA = "0x182D7C7C0")]
				internal bool LNKMKSCNYUW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029B")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E400", Offset = "0x2D7D000", VA = "0x182D7E400")]
				internal float TMDKBYCJELI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600029C")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E450", Offset = "0x2D7D050", VA = "0x182D7E450")]
				internal void TMIQZEWGNWR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600029D")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E3B0", Offset = "0x2D7CFB0", VA = "0x182D7E3B0")]
				internal bool TLSWHKOOLOQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029E")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E570", Offset = "0x2D7D170", VA = "0x182D7E570")]
				internal bool TNDSOFXVZQB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600029F")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E4B0", Offset = "0x2D7D0B0", VA = "0x182D7E4B0")]
				internal string TMNXWLQDXIA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A0")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E500", Offset = "0x2D7D100", VA = "0x182D7E500")]
				internal void TMTETSKBGTJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A1")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E310", Offset = "0x2D7CF10", VA = "0x182D7E310")]
				internal bool TKNGXVZEGYO(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A2")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E360", Offset = "0x2D7CF60", VA = "0x182D7E360")]
				internal bool TKSNVCTBQJX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A3")]
				[Cpp2IlInjected.Address(RVA = "0x2D74C30", Offset = "0x2D73830", VA = "0x182D74C30")]
				internal bool AMUPAQKLUDR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A4")]
				[Cpp2IlInjected.Address(RVA = "0x2D74BE0", Offset = "0x2D737E0", VA = "0x182D74BE0")]
				internal bool AMPIDJQOKSI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A5")]
				[Cpp2IlInjected.Address(RVA = "0x2D74CF0", Offset = "0x2D738F0", VA = "0x182D74CF0")]
				internal string ANFCVDYGNAJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x2D74C80", Offset = "0x2D73880", VA = "0x182D74C80")]
				internal void AMZVXXEJDPA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2D74AF0", Offset = "0x2D736F0", VA = "0x182D74AF0")]
				internal bool ALZNLPIWIKH(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x2D74AA0", Offset = "0x2D736A0", VA = "0x182D74AA0")]
				internal bool ALUGOIOYYYY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002A9")]
				[Cpp2IlInjected.Address(RVA = "0x2D74B90", Offset = "0x2D73790", VA = "0x182D74B90")]
				internal bool AMKBGCWRBGZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AA")]
				[Cpp2IlInjected.Address(RVA = "0x2D74B40", Offset = "0x2D73740", VA = "0x182D74B40")]
				internal bool AMEUIWCTRVQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AB")]
				[Cpp2IlInjected.Address(RVA = "0x2D74A00", Offset = "0x2D73600", VA = "0x182D74A00")]
				internal string ALELWOHGWQX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0x2D74940", Offset = "0x2D73540", VA = "0x182D74940")]
				internal void AKZEZHNJNFO(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002AD")]
				[Cpp2IlInjected.Address(RVA = "0x2D75C10", Offset = "0x2D74810", VA = "0x182D75C10")]
				internal bool GKSYRVLEKWY(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0x2D75C60", Offset = "0x2D74860", VA = "0x182D75C60")]
				internal bool GKYFPCFBUIH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002AF")]
				[Cpp2IlInjected.Address(RVA = "0x2D75CB0", Offset = "0x2D748B0", VA = "0x182D75CB0")]
				internal bool GLDMMIYZDTQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B0")]
				[Cpp2IlInjected.Address(RVA = "0x2D75D00", Offset = "0x2D74900", VA = "0x182D75D00")]
				internal bool GLITJPSWNEZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B1")]
				[Cpp2IlInjected.Address(RVA = "0x2D75AB0", Offset = "0x2D746B0", VA = "0x182D75AB0")]
				internal string GJXXCUJOZDO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0x2D75B00", Offset = "0x2D74700", VA = "0x182D75B00")]
				internal void GKDEABDMIOX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x2D75B70", Offset = "0x2D74770", VA = "0x182D75B70")]
				internal bool GKIKXHXJSAG(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0x2D75BC0", Offset = "0x2D747C0", VA = "0x182D75BC0")]
				internal bool GKNRUORHBLP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B5")]
				[Cpp2IlInjected.Address(RVA = "0x2D75D50", Offset = "0x2D74950", VA = "0x182D75D50")]
				internal bool GMJBVXOJIJS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B6")]
				[Cpp2IlInjected.Address(RVA = "0x2D75DA0", Offset = "0x2D749A0", VA = "0x182D75DA0")]
				internal bool GMOITEIGRVB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002B7")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CD70", Offset = "0x2D7B970", VA = "0x182D7CD70")]
				internal string NLKDQNTHAPH()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CD00", Offset = "0x2D7B900", VA = "0x182D7CD00")]
				internal void NLEWTGZJRDY(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002B9")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CCB0", Offset = "0x2D7B8B0", VA = "0x182D7CCB0")]
				internal bool NKZPWAFMHSP(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CC60", Offset = "0x2D7B860", VA = "0x182D7CC60")]
				internal bool NKUIYTLOYHG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CC10", Offset = "0x2D7B810", VA = "0x182D7CC10")]
				internal bool NKPCBMRROVX()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CBC0", Offset = "0x2D7B7C0", VA = "0x182D7CBC0")]
				internal bool NKJVEFXUFKO()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CB70", Offset = "0x2D7B770", VA = "0x182D7CB70")]
				internal string NKEOGZDWVZF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CB00", Offset = "0x2D7B700", VA = "0x182D7CB00")]
				internal void NJZHJSJZMNW(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CE10", Offset = "0x2D7BA10", VA = "0x182D7CE10")]
				internal bool NNAGUPWLYCB(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C0")]
				[Cpp2IlInjected.Address(RVA = "0x2D7CDC0", Offset = "0x2D7B9C0", VA = "0x182D7CDC0")]
				internal bool NMUZXJCOOQS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C1")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DBC0", Offset = "0x2D7C7C0", VA = "0x182D7DBC0")]
				internal bool QQXXMBFSNMG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DC10", Offset = "0x2D7C810", VA = "0x182D7DC10")]
				internal bool QRDEJHZPWXP()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DB00", Offset = "0x2D7C700", VA = "0x182D7DB00")]
				internal string QQNJRNRXUPO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DB50", Offset = "0x2D7C750", VA = "0x182D7DB50")]
				internal void QQSQOULVEAX(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DA60", Offset = "0x2D7C660", VA = "0x182D7DA60")]
				internal bool QQCVXAEDBSW(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DAB0", Offset = "0x2D7C6B0", VA = "0x182D7DAB0")]
				internal bool QQICUGYALEF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2D7D9C0", Offset = "0x2D7C5C0", VA = "0x182D7D9C0")]
				internal bool QPSICMQIIWE()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DA10", Offset = "0x2D7C610", VA = "0x182D7DA10")]
				internal bool QPXOZTKFSHN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DC60", Offset = "0x2D7C860", VA = "0x182D7DC60")]
				internal string QSOAQDIXKZA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2D7DCB0", Offset = "0x2D7C8B0", VA = "0x182D7DCB0")]
				internal void QSTHNKCUUKJ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EDE0", Offset = "0x2D7D9E0", VA = "0x182D7EDE0")]
				internal bool XRPCKTNVDEP(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x2D7ED90", Offset = "0x2D7D990", VA = "0x182D7ED90")]
				internal bool XRJVNMTXTTG()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EE80", Offset = "0x2D7DA80", VA = "0x182D7EE80")]
				internal bool XRZQFHBPWBH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EE30", Offset = "0x2D7DA30", VA = "0x182D7EE30")]
				internal bool XRUJIAHSMPY()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EF40", Offset = "0x2D7DB40", VA = "0x182D7EF40")]
				internal string XSKDZUPKOXZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D0")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EED0", Offset = "0x2D7DAD0", VA = "0x182D7EED0")]
				internal void XSEXCNVNFMQ(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D1")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EFE0", Offset = "0x2D7DBE0", VA = "0x182D7EFE0")]
				internal bool XSURUIDFHUR(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D2")]
				[Cpp2IlInjected.Address(RVA = "0x2D7EF90", Offset = "0x2D7DB90", VA = "0x182D7EF90")]
				internal bool XSPKXBJHYJI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x2D7ED40", Offset = "0x2D7D940", VA = "0x182D7ED40")]
				internal bool XPYZGRKQFRV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x2D7ECF0", Offset = "0x2D7D8F0", VA = "0x182D7ECF0")]
				internal bool XPTSJKQSWGM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x2D76260", Offset = "0x2D74E60", VA = "0x182D76260")]
				internal string IIARWIHPTYL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x2D761F0", Offset = "0x2D74DF0", VA = "0x182D761F0")]
				internal void IHVKZBNSKNC(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x2D762B0", Offset = "0x2D74EB0", VA = "0x182D762B0")]
				internal bool IIFYTPBNDJU()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x2D760E0", Offset = "0x2D74CE0", VA = "0x182D760E0")]
				internal bool IHFQHHGAIFB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x2D76090", Offset = "0x2D74C90", VA = "0x182D76090")]
				internal bool IHAJKAMCYTS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x2D761A0", Offset = "0x2D74DA0", VA = "0x182D761A0")]
				internal string IHQEBUTVBBT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x2D76130", Offset = "0x2D74D30", VA = "0x182D76130")]
				internal void IHKXENZXRQK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2D76350", Offset = "0x2D74F50", VA = "0x182D76350")]
				internal bool IJQVAKKURLF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x2D76300", Offset = "0x2D74F00", VA = "0x182D76300")]
				internal bool IJLODDQXHZW()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2D74E00", Offset = "0x2D73A00", VA = "0x182D74E00")]
				internal bool BHJMXPZNEGC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2D74E50", Offset = "0x2D73A50", VA = "0x182D74E50")]
				internal string BHOTUWTKNRL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x2D74D40", Offset = "0x2D73940", VA = "0x182D74D40")]
				internal void BGYZDCLSLJK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x2D74DB0", Offset = "0x2D739B0", VA = "0x182D74DB0")]
				internal bool BHEGAJFPUUT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x2D74F60", Offset = "0x2D73B60", VA = "0x182D74F60")]
				internal bool BIEOMRBCPZM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x2D74FB0", Offset = "0x2D73BB0", VA = "0x182D74FB0")]
				internal bool BIJVJXUZZKV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x2D74EA0", Offset = "0x2D73AA0", VA = "0x182D74EA0")]
				internal string BHUASDNHXCU()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x2D74EF0", Offset = "0x2D73AF0", VA = "0x182D74EF0")]
				internal void BHZHPKHFGOD(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x2D75000", Offset = "0x2D73C00", VA = "0x182D75000")]
				internal bool BJEWYYWPLEF()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x2D7E820", Offset = "0x2D7D420", VA = "0x182D7E820")]
				internal bool UNEUPGEEEMV(string a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x2D75F00", Offset = "0x2D74B00", VA = "0x182D75F00")]
				internal float HMEWZRAUDVD()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0x2D75EA0", Offset = "0x2D74AA0", VA = "0x182D75EA0")]
				internal void HLZQCKGWUJU(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x2D75FA0", Offset = "0x2D74BA0", VA = "0x182D75FA0")]
				internal bool HMPKUEOOWRV()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0x2D75F50", Offset = "0x2D74B50", VA = "0x182D75F50")]
				internal bool HMKDWXURNGM()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x2D76040", Offset = "0x2D74C40", VA = "0x182D76040")]
				internal bool HMZYOSCJPON()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0x2D75FF0", Offset = "0x2D74BF0", VA = "0x182D75FF0")]
				internal int HMURRLIMGDE()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0x2D75E40", Offset = "0x2D74A40", VA = "0x182D75E40")]
				internal void HKEGBBJUNLR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0x2D75DF0", Offset = "0x2D749F0", VA = "0x182D75DF0")]
				internal bool HJYZDUPXEAI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002F0")]
				[Cpp2IlInjected.Address(RVA = "0x2D749B0", Offset = "0x2D735B0", VA = "0x182D749B0")]
				internal bool ALDEGLEWVGC()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60002F1")]
				[Cpp2IlInjected.Address(RVA = "0x2D74A50", Offset = "0x2D73650", VA = "0x182D74A50")]
				internal bool ALILDRYUERL()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000075")]
			[CompilerGenerated]
			private sealed class LIFCCFVVCCS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				public string JKWEDXDVJVL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019B")]
				public LIKIZMPSLOB JZUGHOQQQFE;

				[Cpp2IlInjected.Token(Token = "0x60002F2")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public LIFCCFVVCCS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002F3")]
				[Cpp2IlInjected.Address(RVA = "0x2D97AA0", Offset = "0x2D966A0", VA = "0x182D97AA0")]
				internal void QFVXZHMVCTQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000076")]
			[CompilerGenerated]
			private sealed class LHZVEZBXSRJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019C")]
				public char[] QYMHYFMBYRM;

				[Cpp2IlInjected.Token(Token = "0x60002F4")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public LHZVEZBXSRJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0x2D97A30", Offset = "0x2D96630", VA = "0x182D97A30")]
				internal bool HLPCHWTCBNC(char a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			private readonly PrimitivePortGroupModifiers QQBYCPGPNLV;

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x2D70980", Offset = "0x2D6F580", VA = "0x182D70980")]
			public FLBNDZHKHHL(QBUZPCMMQEU a, IVNCIBJJYSC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x2D6ED80", Offset = "0x2D6D980", VA = "0x182D6ED80", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public sealed class AXKJSNMWGEI : TVMAPYLHDJB<ConstantGiftDropShopItemNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000078")]
			[CompilerGenerated]
			private sealed class QBWFFRHGRMS
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000079")]
				private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400019F")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001A0")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40001A1")]
					public QBWFFRHGRMS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40001A2")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40001A3")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40001A4")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x60002FE")]
					[Cpp2IlInjected.Address(RVA = "0x2DA6220", Offset = "0x2DA4E20", VA = "0x182DA6220", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60002FF")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400019D")]
				public AXKJSNMWGEI VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x60002F9")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public QBWFFRHGRMS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FA")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EA00", Offset = "0x2D9D600", VA = "0x182D9EA00")]
				internal string EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60002FB")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E540", Offset = "0x2D9D140", VA = "0x182D9E540")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void EQIQZGORPWK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E080", Offset = "0x2D9CC80", VA = "0x182D9E080")]
				internal int EQDKBZUUGLB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DE80", Offset = "0x2D9CA80", VA = "0x182D9DE80")]
				internal void EPYDETAWWZS(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x13736F0", Offset = "0x13722F0", VA = "0x1813736F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2D8E340", Offset = "0x2D8CF40", VA = "0x182D8E340")]
			public AXKJSNMWGEI(QBUZPCMMQEU a, ConstantGiftDropShopItemNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2D8E010", Offset = "0x2D8CC10", VA = "0x182D8E010", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007A")]
		public sealed class NHWXFLCOZZP : TVMAPYLHDJB<ConstantObjectiveMarkerNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007B")]
			[CompilerGenerated]
			private sealed class CWLCWDGOHPR
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200007C")]
				private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001A7")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001A8")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40001A9")]
					public CWLCWDGOHPR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40001AA")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40001AB")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40001AC")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000313")]
					[Cpp2IlInjected.Address(RVA = "0x2DA5EE0", Offset = "0x2DA4AE0", VA = "0x182DA5EE0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000314")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x200007D")]
				private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001AD")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001AE")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40001AF")]
					public CWLCWDGOHPR <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40001B0")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40001B1")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40001B2")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000315")]
					[Cpp2IlInjected.Address(RVA = "0x2DA6530", Offset = "0x2DA5130", VA = "0x182DA6530", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000316")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				public NHWXFLCOZZP VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public CWLCWDGOHPR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x2D8ED20", Offset = "0x2D8D920", VA = "0x182D8ED20")]
				internal string EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EC50", Offset = "0x2D8D850", VA = "0x182D8EC50")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
				internal void EQIQZGORPWK(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EC00", Offset = "0x2D8D800", VA = "0x182D8EC00")]
				internal int EQDKBZUUGLB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EB70", Offset = "0x2D8D770", VA = "0x182D8EB70")]
				internal void EPYDETAWWZS(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EB20", Offset = "0x2D8D720", VA = "0x182D8EB20")]
				internal string EPSWHMGZNOJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EA50", Offset = "0x2D8D650", VA = "0x182D8EA50")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
				internal void EPNPKFNCEDA(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EA00", Offset = "0x2D8D600", VA = "0x182D8EA00")]
				internal bool EPIIMYTEURR()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E970", Offset = "0x2D8D570", VA = "0x182D8E970")]
				internal void EPDBPRZHLGI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E920", Offset = "0x2D8D520", VA = "0x182D8E920")]
				internal bool EOXUSLFKBUZ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E890", Offset = "0x2D8D490", VA = "0x182D8E890")]
				internal void EOSNVELMSJQ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EE70", Offset = "0x2D8DA70", VA = "0x182D8EE70")]
				internal float YCYSMLJLKXI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EEC0", Offset = "0x2D8DAC0", VA = "0x182D8EEC0")]
				internal void YDDZJSDIUIR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0x2D8ED70", Offset = "0x2D8D970", VA = "0x182D8ED70")]
				internal int YCOERXVQSAQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EDD0", Offset = "0x2D8D9D0", VA = "0x182D8EDD0")]
				internal void YCTLPEPOBLZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0x2D8EF50", Offset = "0x2D8DB50", VA = "0x182D8EF50")]
				internal bool YDTUBMLAWQS()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0x13736F0", Offset = "0x13722F0", VA = "0x1813736F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x2D9AF80", Offset = "0x2D99B80", VA = "0x182D9AF80")]
			public NHWXFLCOZZP(QBUZPCMMQEU a, ConstantObjectiveMarkerNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2D9A630", Offset = "0x2D99230", VA = "0x182D9A630", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class ZKCDVYSPLRC : TVMAPYLHDJB<ConstantPlayerOutfitSlotFlagNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200007F")]
			[CompilerGenerated]
			private sealed class QBWFFRHGRMS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				public ZKCDVYSPLRC VISDDFDIKLJ;

				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public QBWFFRHGRMS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EA50", Offset = "0x2D9D650", VA = "0x182D9EA50")]
				internal Dictionary<string, EnumChoiceData> EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E610", Offset = "0x2D9D210", VA = "0x182D9E610")]
				internal int EQIQZGORPWK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E220", Offset = "0x2D9CE20", VA = "0x182D9E220")]
				internal void EQDKBZUUGLB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DFB0", Offset = "0x2D9CBB0", VA = "0x182D9DFB0")]
				internal bool EPYDETAWWZS()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0x13736F0", Offset = "0x13722F0", VA = "0x1813736F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2DA87A0", Offset = "0x2DA73A0", VA = "0x182DA87A0")]
			public ZKCDVYSPLRC(QBUZPCMMQEU a, ConstantPlayerOutfitSlotFlagNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x2DA84F0", Offset = "0x2DA70F0", VA = "0x182DA84F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public sealed class NJZWYOXWHUF : TVMAPYLHDJB<OGFFCDGSDYO>
		{
			[Cpp2IlInjected.Token(Token = "0x2000081")]
			[CompilerGenerated]
			private sealed class QBWFFRHGRMS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				public NJZWYOXWHUF VISDDFDIKLJ;

				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public QBWFFRHGRMS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E8A0", Offset = "0x2D9D4A0", VA = "0x182D9E8A0")]
				internal void EQNXWNIOZHT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x13736F0", Offset = "0x13722F0", VA = "0x1813736F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B170", Offset = "0x2D99D70", VA = "0x182D9B170")]
			public NJZWYOXWHUF(QBUZPCMMQEU a, OGFFCDGSDYO b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x2D9AFF0", Offset = "0x2D99BF0", VA = "0x182D9AFF0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public class DRWSLZHLPTR<a> : EKJDOPKEKWM<a> where a : notnull, KEJDLKADIBH
		{
			[Cpp2IlInjected.Token(Token = "0x1700004B")]
			public override bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004C")]
			public override CCKZZXOVVJO? MSSANBVEZFT
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x4668E60", Offset = "0x4667A60", VA = "0x184668E60", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004D")]
			public override bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0x4668EC0", Offset = "0x4667AC0", VA = "0x184668EC0", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004E")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0xF8EB00", Offset = "0xF8D700", VA = "0x180F8EB00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x4668EA0", Offset = "0x4667AA0", VA = "0x184668EA0")]
			public DRWSLZHLPTR(QBUZPCMMQEU a, a b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public class NHDLLXYVHFZ : DRWSLZHLPTR<HXKABVYEKIU>
		{
			[Cpp2IlInjected.Token(Token = "0x2000084")]
			[CompilerGenerated]
			private sealed class LIKIZMPSLOB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				public NHDLLXYVHFZ VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001B9")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public LIKIZMPSLOB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x2D988D0", Offset = "0x2D974D0", VA = "0x182D988D0")]
				internal object EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x2D987B0", Offset = "0x2D973B0", VA = "0x182D987B0")]
				internal void EQIQZGORPWK(object a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0x2D98630", Offset = "0x2D97230", VA = "0x182D98630")]
				internal void EQDKBZUUGLB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			private static object[]? GQTQNLCIGXB;

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2D9A5D0", Offset = "0x2D991D0", VA = "0x182D9A5D0")]
			public NHDLLXYVHFZ(QBUZPCMMQEU a, HXKABVYEKIU b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x2D9A050", Offset = "0x2D98C50", VA = "0x182D9A050", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public sealed class NBVDDYGYUVU : TVMAPYLHDJB<TNHMECWBUQH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000087")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001BD")]
				public NBVDDYGYUVU VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001BE")]
				public List<Id32<XBXCGKIEZZS>> CKALTSGZCTM;

				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x2D96340", Offset = "0x2D94F40", VA = "0x182D96340")]
				internal int EQIQZGORPWK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000337")]
				[Cpp2IlInjected.Address(RVA = "0x2D958C0", Offset = "0x2D944C0", VA = "0x182D958C0")]
				internal void EQDKBZUUGLB(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000088")]
			[CompilerGenerated]
			private sealed class GWLPQCWEVLF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001BF")]
				public Id32<XBXCGKIEZZS> TOVTRILVTKE;

				[Cpp2IlInjected.Token(Token = "0x6000338")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWLPQCWEVLF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x2D96AE0", Offset = "0x2D956E0", VA = "0x182D96AE0")]
				internal bool EPSWHMGZNOJ(Id32<XBXCGKIEZZS> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x2D99FE0", Offset = "0x2D98BE0", VA = "0x182D99FE0")]
			public NBVDDYGYUVU(QBUZPCMMQEU a, TNHMECWBUQH b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2D99AF0", Offset = "0x2D986F0", VA = "0x182D99AF0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000089")]
		private sealed class KAYCQWKOPBQ : TVMAPYLHDJB<WAYWDVXOGKT>
		{
			[Cpp2IlInjected.Token(Token = "0x1700004F")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0xE68C50", Offset = "0xE67850", VA = "0x180E68C50", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x2D979C0", Offset = "0x2D965C0", VA = "0x182D979C0")]
			public KAYCQWKOPBQ(QBUZPCMMQEU a, WAYWDVXOGKT b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		private sealed class SBWGMJCEWJL : TVMAPYLHDJB<TPZIDCVSSHA>
		{
			[Cpp2IlInjected.Token(Token = "0x17000050")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600033D")]
				[Cpp2IlInjected.Address(RVA = "0xC21E00", Offset = "0xC20A00", VA = "0x180C21E00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x2DA0130", Offset = "0x2D9ED30", VA = "0x182DA0130")]
			public SBWGMJCEWJL(QBUZPCMMQEU a, TPZIDCVSSHA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "134")]
			protected override bool OQPVAPFAKVP(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private sealed class NTKDJDCNKYN : TVMAPYLHDJB<QZSYNJILNBY>
		{
			[Cpp2IlInjected.Token(Token = "0x17000051")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000341")]
				[Cpp2IlInjected.Address(RVA = "0xD93C40", Offset = "0xD92840", VA = "0x180D93C40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000052")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000342")]
				[Cpp2IlInjected.Address(RVA = "0x2D9CED0", Offset = "0x2D9BAD0", VA = "0x182D9CED0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000053")]
			protected override bool MAMZSVMDOYP
			{
				[Cpp2IlInjected.Token(Token = "0x6000343")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x2D9CE60", Offset = "0x2D9BA60", VA = "0x182D9CE60")]
			public NTKDJDCNKYN(QBUZPCMMQEU a, QZSYNJILNBY b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008C")]
		private sealed class IPNMOPUDWBD : TVMAPYLHDJB<POFLHXFFJAC>
		{
			[Cpp2IlInjected.Token(Token = "0x17000054")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000055")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x2D97910", Offset = "0x2D96510", VA = "0x182D97910", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000056")]
			protected override bool MAMZSVMDOYP
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2D978A0", Offset = "0x2D964A0", VA = "0x182D978A0")]
			public IPNMOPUDWBD(QBUZPCMMQEU a, POFLHXFFJAC b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008D")]
		public sealed class SMBPEDAHVTC : BEBUHZZYJSX<FloatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200008E")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001C0")]
				public SMBPEDAHVTC VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001C1")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600034E")]
				[Cpp2IlInjected.Address(RVA = "0x2D967D0", Offset = "0x2D953D0", VA = "0x182D967D0")]
				internal float JYYGBZYKCVG()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x600034F")]
				[Cpp2IlInjected.Address(RVA = "0x2D969A0", Offset = "0x2D955A0", VA = "0x182D969A0")]
				internal void JZDMZGSHMGP(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x2DA0410", Offset = "0x2D9F010", VA = "0x182DA0410")]
			public SMBPEDAHVTC(QBUZPCMMQEU a, FloatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x2DA01A0", Offset = "0x2D9EDA0", VA = "0x182DA01A0", Slot = "151")]
			protected override void JUYYYBSEVZO(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008F")]
		public sealed class FZGNFIMAGFX : TVMAPYLHDJB<TKUQZAYDEFI>
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000090")]
			[CompilerGenerated]
			private struct <<BuildConfigMenuInternal>b__6_1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C4")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001C6")]
				public FZGNFIMAGFX <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001C7")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000357")]
				[Cpp2IlInjected.Address(RVA = "0x2DA6BF0", Offset = "0x2DA57F0", VA = "0x182DA6BF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000358")]
				[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000092")]
			[CompilerGenerated]
			private sealed class BZLIFPWZYIV
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000093")]
				private struct <<BuildConfigMenuInternal>b__11>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001D0")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001D1")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40001D2")]
					public BZLIFPWZYIV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40001D3")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40001D4")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40001D5")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x6000368")]
					[Cpp2IlInjected.Address(RVA = "0x2DA5970", Offset = "0x2DA4570", VA = "0x182DA5970", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000369")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000094")]
				private struct <<BuildConfigMenuInternal>b__12>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001D6")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001D7")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40001D8")]
					public BZLIFPWZYIV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40001D9")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600036A")]
					[Cpp2IlInjected.Address(RVA = "0x2DA5CF0", Offset = "0x2DA48F0", VA = "0x182DA5CF0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600036B")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000095")]
				private struct <<BuildConfigMenuInternal>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001DA")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001DB")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40001DC")]
					public BZLIFPWZYIV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40001DD")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40001DE")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40001DF")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600036C")]
					[Cpp2IlInjected.Address(RVA = "0x2DA6870", Offset = "0x2DA5470", VA = "0x182DA6870", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600036D")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x2000096")]
				private struct <<BuildConfigMenuInternal>b__8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40001E0")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40001E1")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40001E2")]
					public int value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40001E3")]
					public BZLIFPWZYIV <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40001E4")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x600036E")]
					[Cpp2IlInjected.Address(RVA = "0x2DA6DC0", Offset = "0x2DA59C0", VA = "0x182DA6DC0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600036F")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				public int IXEGXZQHKSB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001CC")]
				public StructuredDataEntry DBQHUADBCNR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001CD")]
				public int DMPVJOPMYMT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				public FZGNFIMAGFX VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				public Func<IDLCASSILBG, bool> BTXJRVGBHQU;

				[Cpp2IlInjected.Token(Token = "0x600035D")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public BZLIFPWZYIV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E690", Offset = "0x2D8D290", VA = "0x182D8E690")]
				internal bool EPYDETAWWZS()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E620", Offset = "0x2D8D220", VA = "0x182D8E620")]
				internal void EPSWHMGZNOJ(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				internal string EPNPKFNCEDA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E550", Offset = "0x2D8D150", VA = "0x182D8E550")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__6>d))]
				internal void EPIIMYTEURR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000362")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E470", Offset = "0x2D8D070", VA = "0x182D8E470")]
				internal int EPDBPRZHLGI()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000363")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E7A0", Offset = "0x2D8D3A0", VA = "0x182D8E7A0")]
				internal bool YCTLPEPOBLZ(IDLCASSILBG a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000364")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E3B0", Offset = "0x2D8CFB0", VA = "0x182D8E3B0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__8>d))]
				internal void EOXUSLFKBUZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000365")]
				[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
				internal string YCYSMLJLKXI()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E7C0", Offset = "0x2D8D3C0", VA = "0x182D8E7C0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__11>d))]
				internal void YDDZJSDIUIR(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000367")]
				[Cpp2IlInjected.Address(RVA = "0x2D8E6F0", Offset = "0x2D8D2F0", VA = "0x182D8E6F0")]
				[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__12>d))]
				internal void YCOERXVQSAQ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private readonly Dictionary<int, bool> KRSCWOLVTRT;

			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private static readonly List<IDLCASSILBG> HYLAEKIGKFM;

			[Cpp2IlInjected.Token(Token = "0x17000057")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x2D95480", Offset = "0x2D94080", VA = "0x182D95480")]
			public FZGNFIMAGFX(QBUZPCMMQEU a, TKUQZAYDEFI b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x2D94250", Offset = "0x2D92E50", VA = "0x182D94250", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x2D94430", Offset = "0x2D93030", VA = "0x182D94430", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x2D94310", Offset = "0x2D92F10", VA = "0x182D94310")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__6_1>d))]
			[CompilerGenerated]
			private void HHEGDXWQIAX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x2D943C0", Offset = "0x2D92FC0", VA = "0x182D943C0")]
			[CompilerGenerated]
			private bool HHJNBEQNRMG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public sealed class OBXXKFARKUE : TVMAPYLHDJB<GetBalanceFromConstantNode>
		{
			[Cpp2IlInjected.Token(Token = "0x2000098")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				public OBXXKFARKUE VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x6000372")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000373")]
				[Cpp2IlInjected.Address(RVA = "0x2D965B0", Offset = "0x2D951B0", VA = "0x182D965B0")]
				internal bool EQNXWNIOZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000374")]
				[Cpp2IlInjected.Address(RVA = "0x2D96180", Offset = "0x2D94D80", VA = "0x182D96180")]
				internal void EQIQZGORPWK(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D1B0", Offset = "0x2D9BDB0", VA = "0x182D9D1B0")]
			public OBXXKFARKUE(QBUZPCMMQEU a, GetBalanceFromConstantNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x2D9CF20", Offset = "0x2D9BB20", VA = "0x182D9CF20", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000099")]
		public sealed class LZAPKBPCTYQ : TVMAPYLHDJB<GetBalanceNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009A")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public LZAPKBPCTYQ VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public Predicate<Guid> VPAJZRIHYUN;

				[Cpp2IlInjected.Token(Token = "0x6000377")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000378")]
				[Cpp2IlInjected.Address(RVA = "0x2D966A0", Offset = "0x2D952A0", VA = "0x182D966A0")]
				internal object? EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000379")]
				[Cpp2IlInjected.Address(RVA = "0x2D95600", Offset = "0x2D94200", VA = "0x182D95600")]
				internal bool EPDBPRZHLGI(Guid a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600037A")]
				[Cpp2IlInjected.Address(RVA = "0x2D95D60", Offset = "0x2D94960", VA = "0x182D95D60")]
				internal void EQIQZGORPWK(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600037B")]
				[Cpp2IlInjected.Address(RVA = "0x2D95B80", Offset = "0x2D94780", VA = "0x182D95B80")]
				internal string EQDKBZUUGLB(object? key)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600037C")]
				[Cpp2IlInjected.Address(RVA = "0x2D95870", Offset = "0x2D94470", VA = "0x182D95870")]
				internal IReadOnlyList<object> EPYDETAWWZS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600037D")]
				[Cpp2IlInjected.Address(RVA = "0x2D95800", Offset = "0x2D94400", VA = "0x182D95800")]
				internal bool EPSWHMGZNOJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600037E")]
				[Cpp2IlInjected.Address(RVA = "0x2D957B0", Offset = "0x2D943B0", VA = "0x182D957B0")]
				internal bool EPNPKFNCEDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600037F")]
				[Cpp2IlInjected.Address(RVA = "0x2D95680", Offset = "0x2D94280", VA = "0x182D95680")]
				internal void EPIIMYTEURR(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x2D999E0", Offset = "0x2D985E0", VA = "0x182D999E0")]
			public LZAPKBPCTYQ(QBUZPCMMQEU a, GetBalanceNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x2D992F0", Offset = "0x2D97EF0", VA = "0x182D992F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		public sealed class RMRTCPEQFJF : JYMIUZXGJNP<InBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000058")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000380")]
				[Cpp2IlInjected.Address(RVA = "0xF85FF0", Offset = "0xF84BF0", VA = "0x180F85FF0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x2D9FB70", Offset = "0x2D9E770", VA = "0x182D9FB70")]
			public RMRTCPEQFJF(QBUZPCMMQEU a, InBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009C")]
		public sealed class YYULVRMMCCN : BEBUHZZYJSX<IntNode>
		{
			[Cpp2IlInjected.Token(Token = "0x200009D")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public YYULVRMMCCN VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x6000384")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000385")]
				[Cpp2IlInjected.Address(RVA = "0x2D96920", Offset = "0x2D95520", VA = "0x182D96920")]
				internal int JYYGBZYKCVG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000386")]
				[Cpp2IlInjected.Address(RVA = "0x2D96A40", Offset = "0x2D95640", VA = "0x182D96A40")]
				internal void JZDMZGSHMGP(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x2DA8060", Offset = "0x2DA6C60", VA = "0x182DA8060")]
			public YYULVRMMCCN(QBUZPCMMQEU a, IntNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x2DA7DF0", Offset = "0x2DA69F0", VA = "0x182DA7DF0", Slot = "151")]
			protected override void JUYYYBSEVZO(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		public sealed class XVIBSCIDZPB : TVMAPYLHDJB<VPECCQSYKKQ>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A0")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001EF")]
				public XVIBSCIDZPB VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001F0")]
				public List<Id32<XBXCGKIEZZS>> CKALTSGZCTM;

				[Cpp2IlInjected.Token(Token = "0x600038D")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0x2D96040", Offset = "0x2D94C40", VA = "0x182D96040")]
				internal int EQIQZGORPWK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600038F")]
				[Cpp2IlInjected.Address(RVA = "0x2D95A20", Offset = "0x2D94620", VA = "0x182D95A20")]
				internal void EQDKBZUUGLB(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000A1")]
			[CompilerGenerated]
			private sealed class GWLPQCWEVLF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001F1")]
				public Id32<XBXCGKIEZZS> TOVTRILVTKE;

				[Cpp2IlInjected.Token(Token = "0x6000390")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWLPQCWEVLF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000391")]
				[Cpp2IlInjected.Address(RVA = "0x2D96B30", Offset = "0x2D95730", VA = "0x182D96B30")]
				internal bool EPSWHMGZNOJ(Id32<XBXCGKIEZZS> a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x2DA7D20", Offset = "0x2DA6920", VA = "0x182DA7D20")]
			public XVIBSCIDZPB(QBUZPCMMQEU a, VPECCQSYKKQ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x2DA7830", Offset = "0x2DA6430", VA = "0x182DA7830", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		public sealed class ZQZGQMOWPOF : TVMAPYLHDJB<LocomotionRequestSteeringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A3")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				public ZQZGQMOWPOF VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x6000394")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000395")]
				[Cpp2IlInjected.Address(RVA = "0x2D96560", Offset = "0x2D95160", VA = "0x182D96560")]
				internal bool EQNXWNIOZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0x2D95FB0", Offset = "0x2D94BB0", VA = "0x182D95FB0")]
				internal void EQIQZGORPWK(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x2DA89E0", Offset = "0x2DA75E0", VA = "0x182DA89E0")]
			public ZQZGQMOWPOF(QBUZPCMMQEU a, LocomotionRequestSteeringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x2DA8810", Offset = "0x2DA7410", VA = "0x182DA8810", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		public sealed class OWVCHKJWZRD : TVMAPYLHDJB<LocomotionRequestSteeringR2Node>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A5")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001F4")]
				public OWVCHKJWZRD VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001F5")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x6000399")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600039A")]
				[Cpp2IlInjected.Address(RVA = "0x2D96510", Offset = "0x2D95110", VA = "0x182D96510")]
				internal bool EQNXWNIOZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600039B")]
				[Cpp2IlInjected.Address(RVA = "0x2D962B0", Offset = "0x2D94EB0", VA = "0x182D962B0")]
				internal void EQIQZGORPWK(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D480", Offset = "0x2D9C080", VA = "0x182D9D480")]
			public OWVCHKJWZRD(QBUZPCMMQEU a, LocomotionRequestSteeringR2Node b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D2B0", Offset = "0x2D9BEB0", VA = "0x182D9D2B0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public sealed class NNCDVHSCPTV : TVMAPYLHDJB<LogStringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000A7")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40001F6")]
				public NNCDVHSCPTV VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40001F7")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x600039E")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600039F")]
				[Cpp2IlInjected.Address(RVA = "0x2D96600", Offset = "0x2D95200", VA = "0x182D96600")]
				internal int EQNXWNIOZHT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0x2D95CD0", Offset = "0x2D948D0", VA = "0x182D95CD0")]
				internal void EQIQZGORPWK(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B430", Offset = "0x2D9A030", VA = "0x182D9B430")]
			public NNCDVHSCPTV(QBUZPCMMQEU a, LogStringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B1E0", Offset = "0x2D99DE0", VA = "0x182D9B1E0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		public static class OWUZSLNBRVG
		{
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public static readonly Log DNBXSEXRPWR;
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		public abstract class TVYPMQGIBLF<a> : TVMAPYLHDJB<a> where a : notnull, MessageNodeBase
		{
			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			[CompilerGenerated]
			private sealed class WFWDIIKMSFQ
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000AC")]
				private struct <<AddMessageNamePicker>g__TryCommitMessageSelection|5>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000209")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400020A")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400020B")]
					public WFWDIIKMSFQ <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400020C")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003D5")]
					[Cpp2IlInjected.Address(RVA = "0x428B990", Offset = "0x428A590", VA = "0x18428B990", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003D6")]
					[Cpp2IlInjected.Address(RVA = "0x428BCD0", Offset = "0x428A8D0", VA = "0x18428BCD0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000207")]
				public CV2SetMessageNodeMessageNamePayload MKEJLVLTUUR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000208")]
				public TVYPMQGIBLF<a> VISDDFDIKLJ;

				[Cpp2IlInjected.Token(Token = "0x60003D2")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public WFWDIIKMSFQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x6D58830", Offset = "0x6D57430", VA = "0x186D58830")]
				[AsyncStateMachine(typeof(TVYPMQGIBLF<>.WFWDIIKMSFQ.<<AddMessageNamePicker>g__TryCommitMessageSelection|5>d))]
				internal Task INGSEZXLZLB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0x6D58900", Offset = "0x6D57500", VA = "0x186D58900")]
				internal void LKMWYZPHDGE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000AD")]
			[CompilerGenerated]
			private sealed class VSFAPRYZFDS
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000AE")]
				private struct <<OnAddOrEditMessageButtonClicked>b__8>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000218")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000219")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400021A")]
					public VSFAPRYZFDS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400021B")]
					private TaskAwaiter<string?> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003E8")]
					[Cpp2IlInjected.Address(RVA = "0x4296C00", Offset = "0x4295800", VA = "0x184296C00", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003E9")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000AF")]
				private struct <<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400021C")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400021D")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400021E")]
					public VSFAPRYZFDS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400021F")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003EA")]
					[Cpp2IlInjected.Address(RVA = "0x42984F0", Offset = "0x42970F0", VA = "0x1842984F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003EB")]
					[Cpp2IlInjected.Address(RVA = "0x4298C00", Offset = "0x4297800", VA = "0x184298C00", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				public TXKDNVJCJHK.JQMEYYQIKVE FRIRQYVMTQN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				public string PSGNMNGACKG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				public string XYSUNKCHPHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000210")]
				public TVYPMQGIBLF<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000211")]
				public ConfigMenuStringPurificationHelper OCQKOJYXTYK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				public bool NQCPJFIQHWU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000213")]
				public Action CCZBYPUUBAW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000214")]
				public bool NHWSEGVYOPA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000215")]
				public string WAYETHNEWUW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000216")]
				public Action BSRUIGQRDAS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000217")]
				public Action IVEJIHVVZRE;

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public VSFAPRYZFDS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x6938E00", Offset = "0x6937A00", VA = "0x186938E00")]
				internal void VTHUKSZQVAD(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x6938D90", Offset = "0x6937990", VA = "0x186938D90")]
				internal void VTCNNMFTLOU(ConfigMenuStringPurificationHelper a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DA")]
				[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
				internal string GMPDBRNKMUC()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003DB")]
				[Cpp2IlInjected.Address(RVA = "0x6938990", Offset = "0x6937590", VA = "0x186938990")]
				internal void GMUJYYHHWFL(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003DC")]
				[Cpp2IlInjected.Address(RVA = "0x69388E0", Offset = "0x69374E0", VA = "0x1869388E0")]
				internal bool GMEPHDZPTXK()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003DD")]
				[Cpp2IlInjected.Address(RVA = "0x69388F0", Offset = "0x69374F0", VA = "0x1869388F0")]
				internal char GMJWEKTNDIT((string text, int charIndex, char addedChar) args)
				{
					return default(char);
				}

				[Cpp2IlInjected.Token(Token = "0x60003DE")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
				internal string? GLUBMQLVBAS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003DF")]
				[Cpp2IlInjected.Address(RVA = "0xFA5700", Offset = "0xFA4300", VA = "0x180FA5700")]
				internal bool GLZIJXFSKMB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x6938820", Offset = "0x6937420", VA = "0x186938820")]
				internal void GLJNSCYAIEA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x69388E0", Offset = "0x69374E0", VA = "0x1869388E0")]
				internal bool GLOUPJRXRPJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003E2")]
				[Cpp2IlInjected.Address(RVA = "0x6938740", Offset = "0x6937340", VA = "0x186938740")]
				[AsyncStateMachine(typeof(TVYPMQGIBLF<>.VSFAPRYZFDS.<<OnAddOrEditMessageButtonClicked>b__8>d))]
				internal void GKYZXPKFPHI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0x6938B70", Offset = "0x6937770", VA = "0x186938B70")]
				internal void UWFIYJQCLHA(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E4")]
				[Cpp2IlInjected.Address(RVA = "0x69385B0", Offset = "0x69371B0", VA = "0x1869385B0")]
				[AsyncStateMachine(typeof(TVYPMQGIBLF<>.VSFAPRYZFDS.<<OnAddOrEditMessageButtonClicked>g__TryCommitEditOrAdd|13>d))]
				internal Task AUVRFLHXADZ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003E5")]
				[Cpp2IlInjected.Address(RVA = "0x6938C70", Offset = "0x6937870", VA = "0x186938C70")]
				internal void VRMKJKCOOCA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E6")]
				[Cpp2IlInjected.Address(RVA = "0x6938680", Offset = "0x6937280", VA = "0x186938680")]
				internal void BRGEBYAJLTK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003E7")]
				[Cpp2IlInjected.Address(RVA = "0x69387E0", Offset = "0x69373E0", VA = "0x1869387E0")]
				internal bool GLEGUWECYSR()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B0")]
			[CompilerGenerated]
			private sealed class HTIMJELZZJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000220")]
				public MessageParameter TOPLVEXZASU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000221")]
				public TVYPMQGIBLF<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000222")]
				public Action<TXKDNVJCJHK.VZUJAEBJZSM> BUNEJPNTJYV;

				[Cpp2IlInjected.Token(Token = "0x60003EC")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public HTIMJELZZJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003ED")]
				[Cpp2IlInjected.Address(RVA = "0x547F700", Offset = "0x547E300", VA = "0x18547F700")]
				internal bool BCBVFQDRRTJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003EE")]
				[Cpp2IlInjected.Address(RVA = "0x547F740", Offset = "0x547E340", VA = "0x18547F740")]
				internal void LHMAQWGYXDT(TXKDNVJCJHK.VZUJAEBJZSM a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[CompilerGenerated]
			private sealed class HTDFLXSCPYC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000223")]
				public bool VGPVROJUFDQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000224")]
				public HAZNRURCQZV MIRVLWGRHLW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000225")]
				public HAZNRURCQZV EEJGPIJPIXX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000226")]
				public HAZNRURCQZV BOPQIMMDCMK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000227")]
				public string IIABBXXWYEF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000228")]
				public HTIMJELZZJL JZUGHOQQQFE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000229")]
				public Action VMERMAPSWRR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400022A")]
				public Action BTXJRVGBHQU;

				[Cpp2IlInjected.Token(Token = "0x60003EF")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public HTDFLXSCPYC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F0")]
				[Cpp2IlInjected.Address(RVA = "0xC798B0", Offset = "0xC784B0", VA = "0x180C798B0")]
				internal bool ESGKNXZEDPH()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60003F1")]
				[Cpp2IlInjected.Address(RVA = "0x547E1E0", Offset = "0x547CDE0", VA = "0x18547E1E0")]
				internal void SYJNCOALONC(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F2")]
				[Cpp2IlInjected.Address(RVA = "0x547D980", Offset = "0x547C580", VA = "0x18547D980")]
				internal void BCHCCWXPBES(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F3")]
				[Cpp2IlInjected.Address(RVA = "0x547E1C0", Offset = "0x547CDC0", VA = "0x18547E1C0")]
				internal void BEMZYTIMAZN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F4")]
				[Cpp2IlInjected.Address(RVA = "0x547DDD0", Offset = "0x547C9D0", VA = "0x18547DDD0")]
				internal void BDHKPETBWJL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F5")]
				[Cpp2IlInjected.Address(RVA = "0x547D340", Offset = "0x547BF40", VA = "0x18547D340")]
				internal void BBWOIJJUIIA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F6")]
				[Cpp2IlInjected.Address(RVA = "0x547E1C0", Offset = "0x547CDC0", VA = "0x18547E1C0")]
				internal void LGWFZBZGUVS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B2")]
			[CompilerGenerated]
			private sealed class HSXYOQYFGMT
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000B3")]
				private struct <<UpdateParameterFoldout>g__TryCommitToggle|7>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400022D")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400022E")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400022F")]
					public HSXYOQYFGMT <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000230")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003FA")]
					[Cpp2IlInjected.Address(RVA = "0x42AC840", Offset = "0x42AB440", VA = "0x1842AC840", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60003FB")]
					[Cpp2IlInjected.Address(RVA = "0x42ACE80", Offset = "0x42ABA80", VA = "0x1842ACE80", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400022B")]
				public bool UYGIMZVFGNY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400022C")]
				public HTDFLXSCPYC JZOZKHWTGTV;

				[Cpp2IlInjected.Token(Token = "0x60003F7")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public HSXYOQYFGMT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003F8")]
				[Cpp2IlInjected.Address(RVA = "0x547D270", Offset = "0x547BE70", VA = "0x18547D270")]
				[AsyncStateMachine(typeof(TVYPMQGIBLF<>.HSXYOQYFGMT.<<UpdateParameterFoldout>g__TryCommitToggle|7>d))]
				internal Task ETOFOEOIKNO()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003F9")]
				[Cpp2IlInjected.Address(RVA = "0x547D200", Offset = "0x547BE00", VA = "0x18547D200")]
				internal void BEHTBMOOROE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B4")]
			[CompilerGenerated]
			private sealed class HSSRRKEHXBK
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000B5")]
				private struct <<UpdateParameterFoldout>g__TryCommitDeletion|11>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000233")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000234")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000235")]
					public HSSRRKEHXBK <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000236")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60003FF")]
					[Cpp2IlInjected.Address(RVA = "0x42AC240", Offset = "0x42AAE40", VA = "0x1842AC240", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000400")]
					[Cpp2IlInjected.Address(RVA = "0x42AC7E0", Offset = "0x42AB3E0", VA = "0x1842AC7E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000231")]
				public CV2ManageMessageParameterPayload RRYUZTFRQAV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				public HTDFLXSCPYC JZJSNBCVXIM;

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public HSSRRKEHXBK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FD")]
				[Cpp2IlInjected.Address(RVA = "0x547D0C0", Offset = "0x547BCC0", VA = "0x18547D0C0")]
				[AsyncStateMachine(typeof(TVYPMQGIBLF<>.HSSRRKEHXBK.<<UpdateParameterFoldout>g__TryCommitDeletion|11>d))]
				internal Task FRYKMGXOBDF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60003FE")]
				[Cpp2IlInjected.Address(RVA = "0x547D190", Offset = "0x547BD90", VA = "0x18547D190")]
				internal void LHBMWITEEHB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B6")]
			[CompilerGenerated]
			private sealed class LCAFIZDCZRS
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000B7")]
				private struct <<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023A")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023B")]
					public AsyncTaskMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023C")]
					public LCAFIZDCZRS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400023D")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000406")]
					[Cpp2IlInjected.Address(RVA = "0x42ABD60", Offset = "0x42AA960", VA = "0x1842ABD60", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000407")]
					[Cpp2IlInjected.Address(RVA = "0x42AC1E0", Offset = "0x42AADE0", VA = "0x1842AC1E0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				public TVYPMQGIBLF<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				public CV2ManageMessageParameterPayload JHTHNBIHBLX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				public TXKDNVJCJHK.VZUJAEBJZSM FRIRQYVMTQN;

				[Cpp2IlInjected.Token(Token = "0x6000401")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public LCAFIZDCZRS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000402")]
				[Cpp2IlInjected.Address(RVA = "0x59799D0", Offset = "0x59785D0", VA = "0x1859799D0")]
				[AsyncStateMachine(typeof(TVYPMQGIBLF<>.LCAFIZDCZRS.<<TryCommitParameterDetailsDialog>g__TryCommitChange|0>d))]
				internal Task OZEDKLKITBL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000403")]
				[Cpp2IlInjected.Address(RVA = "0x5979AA0", Offset = "0x59786A0", VA = "0x185979AA0")]
				internal bool QKCVFJJCKXV(MessageParameter? a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000404")]
				[Cpp2IlInjected.Address(RVA = "0x5979B80", Offset = "0x5978780", VA = "0x185979B80")]
				internal void QKICCQCZUJE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000405")]
				[Cpp2IlInjected.Address(RVA = "0x5979CA0", Offset = "0x59788A0", VA = "0x185979CA0")]
				internal void QKNIZWWXDUN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000B8")]
			[CompilerGenerated]
			private sealed class HPUDPQOSLZV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023E")]
				public string XFNGDEPQBSU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023F")]
				public HAZNRURCQZV HSLTBCGYOXN;

				[Cpp2IlInjected.Token(Token = "0x6000408")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public HPUDPQOSLZV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000409")]
				[Cpp2IlInjected.Address(RVA = "0x5477B80", Offset = "0x5476780", VA = "0x185477B80")]
				internal string? ZRJXSICLNJE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600040A")]
				[Cpp2IlInjected.Address(RVA = "0xCAEF50", Offset = "0xCADB50", VA = "0x180CAEF50")]
				internal bool ZRPEPOWIWUN()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600040B")]
				[Cpp2IlInjected.Address(RVA = "0x5477B10", Offset = "0x5476710", VA = "0x185477B10")]
				internal void ZQZJXUOQUMM(string? a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			private bool GRAREPEQWQF;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			protected static Log DNBXSEXRPWR
			{
				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x660B870", Offset = "0x660A470", VA = "0x18660B870")]
				get
				{
					return default(Log);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			protected override bool MAMZSVMDOYP
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			public override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x60003A5")]
				[Cpp2IlInjected.Address(RVA = "0x660DBF0", Offset = "0x660C7F0", VA = "0x18660DBF0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			protected TXKDNVJCJHK ECXAKOICCCP
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0xB1B7A0", Offset = "0xB1A3A0", VA = "0x180B1B7A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0xB1B720", Offset = "0xB1A320", VA = "0x180B1B720")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			protected Action<string?> LCLGSYVNKOK
			{
				[Cpp2IlInjected.Token(Token = "0x60003AC")]
				[Cpp2IlInjected.Address(RVA = "0xBA7EA0", Offset = "0xBA6AA0", VA = "0x180BA7EA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003AD")]
				[Cpp2IlInjected.Address(RVA = "0xBA75B0", Offset = "0xBA61B0", VA = "0x180BA75B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			protected OHUCYPOHKAG NJJDTSAJRGN
			{
				[Cpp2IlInjected.Token(Token = "0x60003AE")]
				[Cpp2IlInjected.Address(RVA = "0xBA7EC0", Offset = "0xBA6AC0", VA = "0x180BA7EC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003AF")]
				[Cpp2IlInjected.Address(RVA = "0xBA7E00", Offset = "0xBA6A00", VA = "0x180BA7E00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			protected SCQCCQCRVAW AWFJUGTJYXT
			{
				[Cpp2IlInjected.Token(Token = "0x60003B0")]
				[Cpp2IlInjected.Address(RVA = "0xBA7EB0", Offset = "0xBA6AB0", VA = "0x180BA7EB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60003B1")]
				[Cpp2IlInjected.Address(RVA = "0xBA74A0", Offset = "0xBA60A0", VA = "0x180BA74A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x59D9770", Offset = "0x59D8370", VA = "0x1859D9770")]
			protected TVYPMQGIBLF(QBUZPCMMQEU a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x660A500", Offset = "0x6609100", VA = "0x18660A500", Slot = "120")]
			public override void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x660A4D0", Offset = "0x66090D0", VA = "0x18660A4D0", Slot = "121")]
			public override void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x660A530", Offset = "0x6609130", VA = "0x18660A530", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x660B8C0", Offset = "0x660A4C0", VA = "0x18660B8C0")]
			private void PKRHCOCJPDK(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x660C110", Offset = "0x660AD10", VA = "0x18660C110", Slot = "145")]
			protected sealed override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x660B200", Offset = "0x6609E00", VA = "0x18660B200")]
			private void KRSSHJDOZLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x660D080", Offset = "0x660BC80", VA = "0x18660D080")]
			private void XJLAPEKMINQ(string? a, Action? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "151")]
			protected virtual void LWBJAXMLQHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x660B0F0", Offset = "0x6609CF0", VA = "0x18660B0F0")]
			private void HDRPWULUXPX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x660A5C0", Offset = "0x66091C0", VA = "0x18660A5C0")]
			private void FJEINPKYEUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x660C280", Offset = "0x660AE80", VA = "0x18660C280")]
			private void UKZMQENMKEA(TXKDNVJCJHK.VZUJAEBJZSM a, NamedType? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x660BB80", Offset = "0x660A780", VA = "0x18660BB80")]
			private void QNCFJZYCKQS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x660B060", Offset = "0x6609C60", VA = "0x18660B060")]
			protected void FLIMCJCWKXO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x660DB80", Offset = "0x660C780", VA = "0x18660DB80")]
			private void ZYGYZVAGEKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x660A4B0", Offset = "0x66090B0", VA = "0x18660A4B0")]
			private void CSBWKCOYVPU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x660B090", Offset = "0x6609C90", VA = "0x18660B090")]
			private void FWQYNOZNHDH(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x660BD80", Offset = "0x660A980", VA = "0x18660BD80")]
			private string RQTHASCKPWH((int DisconnectionCount, int SenderCount, int ReceiverCount) estimated)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x660C080", Offset = "0x660AC80", VA = "0x18660C080")]
			private string SEYWRJUOMVK(int a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x6609900", Offset = "0x6608500", VA = "0x186609900")]
			[CompilerGenerated]
			private object? AFEMHBMXXDK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x6609930", Offset = "0x6608530", VA = "0x186609930")]
			[CompilerGenerated]
			private void AFJTEIGVGOT(object? a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x660A0A0", Offset = "0x6608CA0", VA = "0x18660A0A0")]
			[CompilerGenerated]
			private IReadOnlyList<object> AFUGYVUPZLL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x6609870", Offset = "0x6608470", VA = "0x186609870")]
			[CompilerGenerated]
			private void AEJKSALILKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x660A130", Offset = "0x6608D30", VA = "0x18660A130")]
			[CompilerGenerated]
			private void AGZWIKKAEBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x660D040", Offset = "0x660BC40", VA = "0x18660D040")]
			[CompilerGenerated]
			private void VOCPKPJOEKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x660A180", Offset = "0x6608D80", VA = "0x18660A180")]
			[CompilerGenerated]
			private void CDWAFBNRKWZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x660A580", Offset = "0x6609180", VA = "0x18660A580")]
			[CompilerGenerated]
			private void EGNQAATYYNA(TXKDNVJCJHK.VZUJAEBJZSM a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public class HWAXCCRJNWQ : TVYPMQGIBLF<MessageReceiverNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600040C")]
				[Cpp2IlInjected.Address(RVA = "0xD93C40", Offset = "0xD92840", VA = "0x180D93C40", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x2D96B80", Offset = "0x2D95780", VA = "0x182D96B80")]
			public HWAXCCRJNWQ(QBUZPCMMQEU a, MessageReceiverNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		public class IGVUAMTXCOY : TVYPMQGIBLF<MessageSenderNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000BB")]
			private class ReceiverScopeSelection : IEquatable<ReceiverScopeSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000062")]
				[CompilerGenerated]
				protected virtual Type RAEISDJSSFV
				{
					[Cpp2IlInjected.Token(Token = "0x6000414")]
					[Cpp2IlInjected.Address(RVA = "0x2D9FFF0", Offset = "0x2D9EBF0", VA = "0x182D9FFF0", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public MessageReceiverScope UXQBGJYLLCM
				{
					[Cpp2IlInjected.Token(Token = "0x6000415")]
					[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
					[CompilerGenerated]
					get
					{
						return default(MessageReceiverScope);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public string FGACHKNNQCS
				{
					[Cpp2IlInjected.Token(Token = "0x6000416")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000413")]
				[Cpp2IlInjected.Address(RVA = "0x14F36A0", Offset = "0x14F22A0", VA = "0x1814F36A0")]
				public ReceiverScopeSelection(MessageReceiverScope ReceiverScope, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000417")]
				[Cpp2IlInjected.Address(RVA = "0x2DA0040", Offset = "0x2D9EC40", VA = "0x182DA0040", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000418")]
				[Cpp2IlInjected.Address(RVA = "0x2D9FE10", Offset = "0x2D9EA10", VA = "0x182D9FE10", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool GYERVTDYCHN(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000419")]
				[Cpp2IlInjected.Address(RVA = "0x2D9FEE0", Offset = "0x2D9EAE0", VA = "0x182D9FEE0", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600041A")]
				[Cpp2IlInjected.Address(RVA = "0x2D9FD80", Offset = "0x2D9E980", VA = "0x182D9FD80", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600041B")]
				[Cpp2IlInjected.Address(RVA = "0x2D9FC30", Offset = "0x2D9E830", VA = "0x182D9FC30", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(ReceiverScopeSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000BC")]
			private class TargetPlayersSelection : IEquatable<TargetPlayersSelection>
			{
				[Cpp2IlInjected.Token(Token = "0x17000065")]
				[CompilerGenerated]
				protected virtual Type RAEISDJSSFV
				{
					[Cpp2IlInjected.Token(Token = "0x600041D")]
					[Cpp2IlInjected.Address(RVA = "0x2DA0EE0", Offset = "0x2D9FAE0", VA = "0x182DA0EE0", Slot = "5")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public MessageTargetPlayers CVYFQVENMSO
				{
					[Cpp2IlInjected.Token(Token = "0x600041E")]
					[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110")]
					[CompilerGenerated]
					get
					{
						return default(MessageTargetPlayers);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public string FGACHKNNQCS
				{
					[Cpp2IlInjected.Token(Token = "0x600041F")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600041C")]
				[Cpp2IlInjected.Address(RVA = "0x14F36A0", Offset = "0x14F22A0", VA = "0x1814F36A0")]
				public TargetPlayersSelection(MessageTargetPlayers TargetPlayers, string DisplayText)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000420")]
				[Cpp2IlInjected.Address(RVA = "0x2DA0F30", Offset = "0x2D9FB30", VA = "0x182DA0F30", Slot = "3")]
				[CompilerGenerated]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000421")]
				[Cpp2IlInjected.Address(RVA = "0x2DA0D00", Offset = "0x2D9F900", VA = "0x182DA0D00", Slot = "6")]
				[CompilerGenerated]
				protected virtual bool GYERVTDYCHN(StringBuilder a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000422")]
				[Cpp2IlInjected.Address(RVA = "0x2DA0DD0", Offset = "0x2D9F9D0", VA = "0x182DA0DD0", Slot = "2")]
				[CompilerGenerated]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000423")]
				[Cpp2IlInjected.Address(RVA = "0x2DA0B20", Offset = "0x2D9F720", VA = "0x182DA0B20", Slot = "0")]
				[CompilerGenerated]
				public override bool Equals(object? obj)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000424")]
				[Cpp2IlInjected.Address(RVA = "0x2DA0BB0", Offset = "0x2D9F7B0", VA = "0x182DA0BB0", Slot = "7")]
				[CompilerGenerated]
				public virtual bool Equals(TargetPlayersSelection? other)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000BE")]
			[CompilerGenerated]
			private sealed class QBWFFRHGRMS
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000BF")]
				private struct <<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400024F")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000250")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000251")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000252")]
					public QBWFFRHGRMS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000253")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000432")]
					[Cpp2IlInjected.Address(RVA = "0x2DA4DD0", Offset = "0x2DA39D0", VA = "0x182DA4DD0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000433")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000C0")]
				private struct <<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000254")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000255")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x4000256")]
					public object value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x4000257")]
					public QBWFFRHGRMS <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x4000258")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x6000434")]
					[Cpp2IlInjected.Address(RVA = "0x2DA51F0", Offset = "0x2DA3DF0", VA = "0x182DA51F0", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000435")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400024B")]
				public IGVUAMTXCOY VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400024C")]
				public OHUCYPOHKAG FPXYQKCWEQL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400024D")]
				public Func<ReceiverScopeSelection, bool> VLZKOTVVNGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400024E")]
				public Func<TargetPlayersSelection, bool> VMERMAPSWRR;

				[Cpp2IlInjected.Token(Token = "0x600042A")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public QBWFFRHGRMS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600042B")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DAB0", Offset = "0x2D9C6B0", VA = "0x182D9DAB0")]
				internal object? AWWAGJZXTNR()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600042C")]
				[Cpp2IlInjected.Address(RVA = "0x2D9D760", Offset = "0x2D9C360", VA = "0x182D9D760")]
				internal bool AVFXCHWSWAX(ReceiverScopeSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600042D")]
				[Cpp2IlInjected.Address(RVA = "0x2D9D9E0", Offset = "0x2D9C5E0", VA = "0x182D9D9E0")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__1>d))]
				internal void AWQTJDGAKCI(object? a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600042E")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EE20", Offset = "0x2D9DA20", VA = "0x182D9EE20")]
				internal IReadOnlyList<TargetPlayersSelection> RYUVIGQKVHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600042F")]
				[Cpp2IlInjected.Address(RVA = "0x2D9D7C0", Offset = "0x2D9C3C0", VA = "0x182D9D7C0")]
				internal object? AVVRUCEKYIY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000430")]
				[Cpp2IlInjected.Address(RVA = "0x2D9D700", Offset = "0x2D9C300", VA = "0x182D9D700")]
				internal bool AVAQFBCVMPO(TargetPlayersSelection a)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000431")]
				[Cpp2IlInjected.Address(RVA = "0x2D9D910", Offset = "0x2D9C510", VA = "0x182D9D910")]
				[AsyncStateMachine(typeof(<<AddControlsBetweenNamePickerAndParametersFoldout>b__6>d))]
				internal void AWLMLWMDAQZ(object? a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000240")]
			private static readonly IReadOnlyList<ReceiverScopeSelection> XMPHEUGLBBF;

			[Cpp2IlInjected.Token(Token = "0x4000241")]
			private static readonly IReadOnlyList<TargetPlayersSelection> PFNJOFBJOWF;

			[Cpp2IlInjected.Token(Token = "0x4000242")]
			private static readonly IReadOnlyList<TargetPlayersSelection> PUQQEXSZTVH;

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600040E")]
				[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x2D977D0", Offset = "0x2D963D0", VA = "0x182D977D0")]
			public IGVUAMTXCOY(QBUZPCMMQEU a, MessageSenderNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x2D97040", Offset = "0x2D95C40", VA = "0x182D97040", Slot = "151")]
			protected override void LWBJAXMLQHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x2D96BE0", Offset = "0x2D957E0", VA = "0x182D96BE0")]
			private static IReadOnlyList<TargetPlayersSelection> EHLVMXJBEUC(MessageReceiverScope a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C1")]
		public sealed class RVZGHNWQHUV : LTSOXDTERVS<MusicAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x17000068")]
			public override AudioClipType WLXJYYWPHHV
			{
				[Cpp2IlInjected.Token(Token = "0x6000437")]
				[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x2D9FBD0", Offset = "0x2D9E7D0", VA = "0x182D9FBD0")]
			public RVZGHNWQHUV(QBUZPCMMQEU a, MusicAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public class OWOBAXIAKCA : TVMAPYLHDJB<OINYKCZIBWN>
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x2D97830", Offset = "0x2D96430", VA = "0x182D97830")]
			public OWOBAXIAKCA(QBUZPCMMQEU a, OINYKCZIBWN b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		public abstract class TVMAPYLHDJB<a> : VXTUWJBKUSC, IDisposable where a : notnull, OINYKCZIBWN
		{
			[Cpp2IlInjected.Token(Token = "0x20000C4")]
			[CompilerGenerated]
			private sealed class HCFOWLTMZUC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000271")]
				public TVMAPYLHDJB<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000272")]
				public QBUZPCMMQEU WXXITQQZDSU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000273")]
				public a HILXSABAWVT;

				[Cpp2IlInjected.Token(Token = "0x60004C4")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public HCFOWLTMZUC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C5")]
				[Cpp2IlInjected.Address(RVA = "0x546ADD0", Offset = "0x54699D0", VA = "0x18546ADD0")]
				internal DBNXKIZLIWP EJUXWRQNATQ(JSZSMMNDASI a, int b)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C5")]
			[CompilerGenerated]
			private sealed class SGWEZPBLNTU
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000C6")]
				private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027B")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027C")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027D")]
					public SGWEZPBLNTU <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400027E")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.Token(Token = "0x60004CA")]
					[Cpp2IlInjected.Address(RVA = "0x428D520", Offset = "0x428C120", VA = "0x18428D520", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x60004CB")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000274")]
				public string JDOWLBZZALE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000275")]
				public Func<string, Result<string, JGXPLWKAZER>> TIOKKPHVUHN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000276")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000277")]
				public TVMAPYLHDJB<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000278")]
				public Func<string> WJMMSIRHIAJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000279")]
				public TXKDNVJCJHK ECXAKOICCCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027A")]
				public Action<string> XDUXQRYTHPD;

				[Cpp2IlInjected.Token(Token = "0x60004C6")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public SGWEZPBLNTU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C7")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				internal string CKSRNXUUQFW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004C8")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				internal void CKXYLEORZRF(string a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004C9")]
				[Cpp2IlInjected.Address(RVA = "0x64F3190", Offset = "0x64F1D90", VA = "0x1864F3190")]
				[AsyncStateMachine(typeof(TVMAPYLHDJB<>.SGWEZPBLNTU.<<BuildStringChangeMenuInternal>b__2>d))]
				internal void CLDFILIPJCO()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000C7")]
			[CompilerGenerated]
			private sealed class GJHBZQLSGXR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027F")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x60004CC")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GJHBZQLSGXR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CD")]
				[Cpp2IlInjected.Address(RVA = "0x540C7B0", Offset = "0x540B3B0", VA = "0x18540C7B0")]
				internal Result<string, JGXPLWKAZER> OSDTDNDHNLE(string a)
				{
					return default(Result<string, JGXPLWKAZER>);
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000C8")]
			[CompilerGenerated]
			private struct <RequestColorChange>d__27 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000280")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000281")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000282")]
				public TVMAPYLHDJB<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000283")]
				public int newColor;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000284")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004CE")]
				[Cpp2IlInjected.Address(RVA = "0x55F3BE0", Offset = "0x55F27E0", VA = "0x1855F3BE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004CF")]
				[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000C9")]
			[CompilerGenerated]
			private struct <RequestLocalTransformChange>d__82 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000285")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000286")]
				public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000287")]
				public TVMAPYLHDJB<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000288")]
				public CircuitsVec3? localPosition;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000289")]
				public CircuitsQuat? localRotation;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028A")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004D0")]
				[Cpp2IlInjected.Address(RVA = "0x55F6AF0", Offset = "0x55F56F0", VA = "0x1855F6AF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D1")]
				[Cpp2IlInjected.Address(RVA = "0x55F6D40", Offset = "0x55F5940", VA = "0x1855F6D40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000CA")]
			[CompilerGenerated]
			private struct <RequestNameChange>d__224 : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028C")]
				public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028D")]
				public TVMAPYLHDJB<a> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028E")]
				public string newName;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400028F")]
				private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x55F6DB0", Offset = "0x55F59B0", VA = "0x1855F6DB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004D3")]
				[Cpp2IlInjected.Address(RVA = "0x55F7030", Offset = "0x55F5C30", VA = "0x1855F7030", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			private readonly QBUZPCMMQEU CYOVMHDASMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			private readonly bool DWCPWACMTQR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			private IdArray<CUMWXIQVBDQ, DBNXKIZLIWP> NDWKEFSXSIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			private IdArray<CUMWXIQVBDQ, JDUQSSPECCA> KTFWXDIHQII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			private List<Action> QQOYXRZMIYT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			[CompilerGenerated]
			private Action<Id32<CUMWXIQVBDQ>>? GRXAJNHTADT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			[CompilerGenerated]
			private Action<Id32<CUMWXIQVBDQ>, JDUQSSPECCA>? RUUJBRCXRCM;

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			protected YHTFDKLWCND OHLXCYTMNOA
			{
				[Cpp2IlInjected.Token(Token = "0x6000439")]
				[Cpp2IlInjected.Address(RVA = "0x6607790", Offset = "0x6606390", VA = "0x186607790")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006A")]
			protected QDGIPSGLXID QDGIPSGLXID
			{
				[Cpp2IlInjected.Token(Token = "0x600043A")]
				[Cpp2IlInjected.Address(RVA = "0x6608300", Offset = "0x6606F00", VA = "0x186608300")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			protected RIUQPTLWHHA FWUHDWCYSQR
			{
				[Cpp2IlInjected.Token(Token = "0x600043B")]
				[Cpp2IlInjected.Address(RVA = "0x66059F0", Offset = "0x66045F0", VA = "0x1866059F0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			protected a OINYKCZIBWN
			{
				[Cpp2IlInjected.Token(Token = "0x600043F")]
				[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006D")]
			public Id128<EPXTWKGOJAA> NodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000440")]
				[Cpp2IlInjected.Address(RVA = "0x1737700", Offset = "0x1736300", VA = "0x181737700", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(Id128<EPXTWKGOJAA>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public Id32<TFITIOWUSRJ> NewNodeTypeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000441")]
				[Cpp2IlInjected.Address(RVA = "0x66096D0", Offset = "0x66082D0", VA = "0x1866096D0", Slot = "6")]
				get
				{
					return default(Id32<TFITIOWUSRJ>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			public object Object
			{
				[Cpp2IlInjected.Token(Token = "0x6000442")]
				[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000070")]
			public virtual bool ShowName
			{
				[Cpp2IlInjected.Token(Token = "0x6000443")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public int Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000444")]
				[Cpp2IlInjected.Address(RVA = "0x6609540", Offset = "0x6608140", VA = "0x186609540", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public CircuitsColor CircuitsEmissionColor
			{
				[Cpp2IlInjected.Token(Token = "0x6000446")]
				[Cpp2IlInjected.Address(RVA = "0x6609520", Offset = "0x6608120", VA = "0x186609520", Slot = "10")]
				get
				{
					return default(CircuitsColor);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			public string StaticName
			{
				[Cpp2IlInjected.Token(Token = "0x6000447")]
				[Cpp2IlInjected.Address(RVA = "0x6609830", Offset = "0x6608430", VA = "0x186609830", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			protected virtual bool MAMZSVMDOYP
			{
				[Cpp2IlInjected.Token(Token = "0x6000448")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000075")]
			public virtual NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000449")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000076")]
			public Id32<KWZBWBHJPPH> IconId
			{
				[Cpp2IlInjected.Token(Token = "0x600044A")]
				[Cpp2IlInjected.Address(RVA = "0xBB3D40", Offset = "0xBB2940", VA = "0x180BB3D40", Slot = "13")]
				[CompilerGenerated]
				get
				{
					return default(Id32<KWZBWBHJPPH>);
				}
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x104E340", Offset = "0x104CF40", VA = "0x18104E340")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public virtual bool IsRoomAssetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "113")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			public virtual bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000079")]
			public virtual bool IsObjectBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "115")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			public virtual MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0xB64510", Offset = "0xB63110", VA = "0x180B64510", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			public bool CanClone
			{
				[Cpp2IlInjected.Token(Token = "0x6000450")]
				[Cpp2IlInjected.Address(RVA = "0x66093F0", Offset = "0x6607FF0", VA = "0x1866093F0", Slot = "18")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			public bool CanDestroy
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x6609420", Offset = "0x6608020", VA = "0x186609420", Slot = "19")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			public bool CanModifyWithMakerPen
			{
				[Cpp2IlInjected.Token(Token = "0x6000452")]
				[Cpp2IlInjected.Address(RVA = "0x6609450", Offset = "0x6608050", VA = "0x186609450", Slot = "20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public int MakerPenInteractionFilter
			{
				[Cpp2IlInjected.Token(Token = "0x6000453")]
				[Cpp2IlInjected.Address(RVA = "0x66096B0", Offset = "0x66082B0", VA = "0x1866096B0", Slot = "21")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public bool IsRoomContributorLocked
			{
				[Cpp2IlInjected.Token(Token = "0x6000454")]
				[Cpp2IlInjected.Address(RVA = "0x66095E0", Offset = "0x66081E0", VA = "0x1866095E0", Slot = "22")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public CanSaveObjectIntoInventionResultType CanSaveIntoInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000455")]
				[Cpp2IlInjected.Address(RVA = "0x66094C0", Offset = "0x66080C0", VA = "0x1866094C0", Slot = "23")]
				get
				{
					return default(CanSaveObjectIntoInventionResultType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public bool CanPublishInInventions
			{
				[Cpp2IlInjected.Token(Token = "0x6000456")]
				[Cpp2IlInjected.Address(RVA = "0x6609490", Offset = "0x6608090", VA = "0x186609490", Slot = "24")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public bool IsDeprecating
			{
				[Cpp2IlInjected.Token(Token = "0x6000457")]
				[Cpp2IlInjected.Address(RVA = "0x1192A40", Offset = "0x1191640", VA = "0x181192A40", Slot = "25")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000458")]
				[Cpp2IlInjected.Address(RVA = "0x18B5990", Offset = "0x18B4590", VA = "0x1818B5990")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public virtual bool SupportsCustomEditControls
			{
				[Cpp2IlInjected.Token(Token = "0x6000459")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "117")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public virtual bool CanPlaceInCircuitBoard
			{
				[Cpp2IlInjected.Token(Token = "0x600045A")]
				[Cpp2IlInjected.Address(RVA = "0x6609480", Offset = "0x6608080", VA = "0x186609480", Slot = "118")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public bool IsBeingEdited
			{
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x6609590", Offset = "0x6608190", VA = "0x186609590", Slot = "28")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public CircuitsVec3 LocalPosition
			{
				[Cpp2IlInjected.Token(Token = "0x600045C")]
				[Cpp2IlInjected.Address(RVA = "0x6609650", Offset = "0x6608250", VA = "0x186609650", Slot = "29")]
				get
				{
					return default(CircuitsVec3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public CircuitsQuat LocalRotation
			{
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x6609680", Offset = "0x6608280", VA = "0x186609680", Slot = "31")]
				get
				{
					return default(CircuitsQuat);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public bool IsFrozen
			{
				[Cpp2IlInjected.Token(Token = "0x6000460")]
				[Cpp2IlInjected.Address(RVA = "0x66095C0", Offset = "0x66081C0", VA = "0x1866095C0", Slot = "33")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual bool HasFloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x600047E")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "130")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public virtual IPCVLPTKDCR? FloatingText
			{
				[Cpp2IlInjected.Token(Token = "0x600047F")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "131")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual CCKZZXOVVJO? MSSANBVEZFT
			{
				[Cpp2IlInjected.Token(Token = "0x6000480")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "132")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual IEnumerable<Id128<LWYTCPIHOQE>>? InnerGraphNodeIds
			{
				[Cpp2IlInjected.Token(Token = "0x6000481")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "133")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public bool CanSetName
			{
				[Cpp2IlInjected.Token(Token = "0x6000486")]
				[Cpp2IlInjected.Address(RVA = "0x66094F0", Offset = "0x66080F0", VA = "0x1866094F0", Slot = "136")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public Id128<JQPVMRMCZNG> LegacyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000487")]
				[Cpp2IlInjected.Address(RVA = "0x6609600", Offset = "0x6608200", VA = "0x186609600", Slot = "68")]
				get
				{
					return default(Id128<JQPVMRMCZNG>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public Id32<JQPVMRMCZNG> GraphId
			{
				[Cpp2IlInjected.Token(Token = "0x6000488")]
				[Cpp2IlInjected.Address(RVA = "0x6609560", Offset = "0x6608160", VA = "0x186609560", Slot = "59")]
				get
				{
					return default(Id32<JQPVMRMCZNG>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool IsBusNode
			{
				[Cpp2IlInjected.Token(Token = "0x6000489")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "137")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual Id32<JQPVMRMCZNG>? InnerGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600048A")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "138")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual bool IsProxyNode
			{
				[Cpp2IlInjected.Token(Token = "0x600048B")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "139")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual Id32<JQPVMRMCZNG>? ProxyGraphId
			{
				[Cpp2IlInjected.Token(Token = "0x600048C")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "140")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public virtual bool IsProxyTargetNode
			{
				[Cpp2IlInjected.Token(Token = "0x600048D")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "141")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public virtual bool IsPositionAttachedToObject
			{
				[Cpp2IlInjected.Token(Token = "0x600048E")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "142")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public bool IsParentPreviewGraph
			{
				[Cpp2IlInjected.Token(Token = "0x600048F")]
				[Cpp2IlInjected.Address(RVA = "0x66072F0", Offset = "0x6605EF0", VA = "0x1866072F0", Slot = "67")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x6000490")]
				[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0", Slot = "71")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000491")]
				[Cpp2IlInjected.Address(RVA = "0xB1D6A0", Offset = "0xB1C2A0", VA = "0x180B1D6A0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public string PaletteName
			{
				[Cpp2IlInjected.Token(Token = "0x6000492")]
				[Cpp2IlInjected.Address(RVA = "0xB1D6B0", Offset = "0xB1C2B0", VA = "0x180B1D6B0", Slot = "72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000493")]
				[Cpp2IlInjected.Address(RVA = "0xB1D760", Offset = "0xB1C360", VA = "0x180B1D760")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public Id32<LWYTCPIHOQE> NodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000494")]
				[Cpp2IlInjected.Address(RVA = "0x6609710", Offset = "0x6608310", VA = "0x186609710", Slot = "69")]
				get
				{
					return default(Id32<LWYTCPIHOQE>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public Id128<LWYTCPIHOQE> LegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000495")]
				[Cpp2IlInjected.Address(RVA = "0x6609630", Offset = "0x6608230", VA = "0x186609630", Slot = "70")]
				get
				{
					return default(Id128<LWYTCPIHOQE>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public Id128<LWYTCPIHOQE>? ParentLegacyNodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000496")]
				[Cpp2IlInjected.Address(RVA = "0x6609730", Offset = "0x6608330", VA = "0x186609730", Slot = "143")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public ReadOnlyIdArray<CUMWXIQVBDQ, JDUQSSPECCA> PortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x6000497")]
				[Cpp2IlInjected.Address(RVA = "0x66097F0", Offset = "0x66083F0", VA = "0x1866097F0", Slot = "73")]
				get
				{
					return default(ReadOnlyIdArray<CUMWXIQVBDQ, JDUQSSPECCA>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			public virtual Id32<CUMWXIQVBDQ>? SelfPortGroupId
			{
				[Cpp2IlInjected.Token(Token = "0x6000498")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "144")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			public virtual bool CanAddRemovePortGroups
			{
				[Cpp2IlInjected.Token(Token = "0x60004AD")]
				[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "147")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			public virtual bool IncludeExecInPortConfig
			{
				[Cpp2IlInjected.Token(Token = "0x60004AE")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "148")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000001")]
			public event Action UACDRGUFSNS
			{
				[Cpp2IlInjected.Token(Token = "0x6000467")]
				[Cpp2IlInjected.Address(RVA = "0x6607500", Offset = "0x6606100", VA = "0x186607500", Slot = "40")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000468")]
				[Cpp2IlInjected.Address(RVA = "0x6605A20", Offset = "0x6604620", VA = "0x186605A20", Slot = "41")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000002")]
			public event PositionChangeDelegate VMGJLDNZUOF
			{
				[Cpp2IlInjected.Token(Token = "0x600046A")]
				[Cpp2IlInjected.Address(RVA = "0x66066F0", Offset = "0x66052F0", VA = "0x1866066F0", Slot = "42")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600046B")]
				[Cpp2IlInjected.Address(RVA = "0x6608EA0", Offset = "0x6607AA0", VA = "0x186608EA0", Slot = "43")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000003")]
			public event RotationChangeDelegate KRRSJYLZHFM
			{
				[Cpp2IlInjected.Token(Token = "0x600046C")]
				[Cpp2IlInjected.Address(RVA = "0x66076F0", Offset = "0x66062F0", VA = "0x1866076F0", Slot = "44")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600046D")]
				[Cpp2IlInjected.Address(RVA = "0x66070A0", Offset = "0x6605CA0", VA = "0x1866070A0", Slot = "45")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000004")]
			public event Action VPNRBGRESEK
			{
				[Cpp2IlInjected.Token(Token = "0x600046E")]
				[Cpp2IlInjected.Address(RVA = "0x6606640", Offset = "0x6605240", VA = "0x186606640", Slot = "46")]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600046F")]
				[Cpp2IlInjected.Address(RVA = "0x6605240", Offset = "0x6603E40", VA = "0x186605240", Slot = "47")]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			public event Action JBQCQSHKFFZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000470")]
				[Cpp2IlInjected.Address(RVA = "0x6606140", Offset = "0x6604D40", VA = "0x186606140", Slot = "48")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000471")]
				[Cpp2IlInjected.Address(RVA = "0x6607B50", Offset = "0x6606750", VA = "0x186607B50", Slot = "49")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action<Id32<CUMWXIQVBDQ>, JDUQSSPECCA> DFHRIGEYONA
			{
				[Cpp2IlInjected.Token(Token = "0x6000499")]
				[Cpp2IlInjected.Address(RVA = "0x6605C60", Offset = "0x6604860", VA = "0x186605C60", Slot = "75")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600049A")]
				[Cpp2IlInjected.Address(RVA = "0x6606BC0", Offset = "0x66057C0", VA = "0x186606BC0", Slot = "76")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action<Id32<CUMWXIQVBDQ>, JDUQSSPECCA> WHQGEXYLTUZ
			{
				[Cpp2IlInjected.Token(Token = "0x600049B")]
				[Cpp2IlInjected.Address(RVA = "0x66062C0", Offset = "0x6604EC0", VA = "0x1866062C0", Slot = "79")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600049C")]
				[Cpp2IlInjected.Address(RVA = "0x6605750", Offset = "0x6604350", VA = "0x186605750", Slot = "80")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000008")]
			public event Action<Id32<CUMWXIQVBDQ>> HUCXSOZHUFZ
			{
				[Cpp2IlInjected.Token(Token = "0x600049D")]
				[Cpp2IlInjected.Address(RVA = "0x66061E0", Offset = "0x6604DE0", VA = "0x1866061E0", Slot = "77")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600049E")]
				[Cpp2IlInjected.Address(RVA = "0x6605D20", Offset = "0x6604920", VA = "0x186605D20", Slot = "78")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000009")]
			public event Action<Id32<CUMWXIQVBDQ>, Id32<CUMWXIQVBDQ>> AQLVKXHKRIK
			{
				[Cpp2IlInjected.Token(Token = "0x600049F")]
				[Cpp2IlInjected.Address(RVA = "0x6607DC0", Offset = "0x66069C0", VA = "0x186607DC0", Slot = "81")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x60004A0")]
				[Cpp2IlInjected.Address(RVA = "0x6606790", Offset = "0x6605390", VA = "0x186606790", Slot = "82")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000A")]
			public event Action<Id32<CUMWXIQVBDQ>, JDUQSSPECCA> JHFFNZIZLAC
			{
				[Cpp2IlInjected.Token(Token = "0x60004A1")]
				[Cpp2IlInjected.Address(RVA = "0x6607A90", Offset = "0x6606690", VA = "0x186607A90", Slot = "83")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x60004A2")]
				[Cpp2IlInjected.Address(RVA = "0x6605BA0", Offset = "0x66047A0", VA = "0x186605BA0", Slot = "84")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000B")]
			public event Action<Id32<CUMWXIQVBDQ>, Id32<CUMWXIQVBDQ>> VWEKMICVOGV
			{
				[Cpp2IlInjected.Token(Token = "0x60004A3")]
				[Cpp2IlInjected.Address(RVA = "0x6606B00", Offset = "0x6605700", VA = "0x186606B00", Slot = "85")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x60004A4")]
				[Cpp2IlInjected.Address(RVA = "0x6605130", Offset = "0x6603D30", VA = "0x186605130", Slot = "86")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1400000C")]
			public event Action<bool> BBRCDZYYYOK
			{
				[Cpp2IlInjected.Token(Token = "0x60004A5")]
				[Cpp2IlInjected.Address(RVA = "0x6606060", Offset = "0x6604C60", VA = "0x186606060", Slot = "87")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x60004A6")]
				[Cpp2IlInjected.Address(RVA = "0x66052A0", Offset = "0x6603EA0", VA = "0x1866052A0", Slot = "88")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x6608F70", Offset = "0x6607B70", VA = "0x186608F70")]
			[Todo("Need to handle `Name` better.")]
			[Todo("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
			protected TVMAPYLHDJB(QBUZPCMMQEU a, a b, bool c = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x6606430", Offset = "0x6605030", VA = "0x186606430", Slot = "108")]
			protected virtual void Initialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x66053F0", Offset = "0x6603FF0", VA = "0x1866053F0", Slot = "109")]
			public virtual void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x6605940", Offset = "0x6604540", VA = "0x186605940", Slot = "9")]
			[AsyncStateMachine(typeof(TVMAPYLHDJB<>.<RequestColorChange>d__27))]
			public void EUDFZTPDNVP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x66072C0", Offset = "0x6605EC0", VA = "0x1866072C0")]
			public bool OPHPAEQDUWZ([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x66065F0", Offset = "0x66051F0", VA = "0x1866065F0")]
			public bool JCCDDYKHFVC([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x6606380", Offset = "0x6604F80", VA = "0x186606380", Slot = "34")]
			public void ITTRBSLVCFS(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x66073F0", Offset = "0x6605FF0", VA = "0x1866073F0", Slot = "35")]
			public Task QBLVBZMHKAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x66075A0", Offset = "0x66061A0", VA = "0x1866075A0", Slot = "36")]
			[AsyncStateMachine(typeof(TVMAPYLHDJB<>.<RequestLocalTransformChange>d__82))]
			public Task<Result<None, JGXPLWKAZER>> RITKJVGWMDN(CircuitsVec3? a, CircuitsQuat? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "119")]
			public virtual void VBRSOHLCAVK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "120")]
			public virtual void ConfigurableWillShow()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "121")]
			public virtual void ConfigurableWillHide()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x118ABE0", Offset = "0x11897E0", VA = "0x18118ABE0")]
			protected void MDEUKLXERIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x25C60D0", Offset = "0x25C4CD0", VA = "0x1825C60D0")]
			protected void LFUHUYIXEOT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x258F5B0", Offset = "0x258E1B0", VA = "0x18258F5B0")]
			private void JNCADBIVTER([In] CircuitsQuat rotation)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x6607E80", Offset = "0x6606A80", VA = "0x186607E80", Slot = "122")]
			public virtual Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> TXYUKLOTKFU(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x6605810", Offset = "0x6604410", VA = "0x186605810", Slot = "123")]
			public virtual Task<Result<None, JGXPLWKAZER>> EMVVQHAPLMV(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "124")]
			public virtual void HEIVUXIONDT(Id32<CUMWXIQVBDQ> sourceId, Id32<CUMWXIQVBDQ> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x6605AC0", Offset = "0x66046C0", VA = "0x186605AC0", Slot = "125")]
			public virtual IEnumerable<FJCTCRTIJZZ> FVIDWVYXVZE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x6605B60", Offset = "0x6604760", VA = "0x186605B60", Slot = "126")]
			public Result<None, JGXPLWKAZER> GCMSJUVKUCP(string a)
			{
				return default(Result<None, JGXPLWKAZER>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x6605010", Offset = "0x6603C10", VA = "0x186605010", Slot = "50")]
			public bool ANCCKLNFRLR([Out] Guid a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x6605DE0", Offset = "0x66049E0", VA = "0x186605DE0")]
			public bool HBLAGMIARHC([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600047B")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "127")]
			public virtual void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "128")]
			public virtual void GLEUQOHEDYO(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "129")]
			public virtual OGQAUMAECCF FMWSVBGCCSC([In] TDRIXRAFYDC audioRecorder)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x6607140", Offset = "0x6605D40", VA = "0x186607140")]
			protected void OPEAAXAVGCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0x66072F0", Offset = "0x6605EF0", VA = "0x1866072F0", Slot = "134")]
			protected virtual bool OQPVAPFAKVP(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x6608F40", Offset = "0x6607B40", VA = "0x186608F40", Slot = "96")]
			public bool ZMGZZXLYJDJ(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "135")]
			protected virtual bool HEQUXAYPEZE(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected virtual void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0x6608510", Offset = "0x6607110", VA = "0x186608510")]
			protected void XUAOJYETBQE(TXKDNVJCJHK a, Func<string> b, Action<string> c, string d, string e, string f, CircuitsUIContentKind g, CircuitsUICharacterValidationKind h, string? characterValidationRegex, Func<string, Result<string, JGXPLWKAZER>>? tryAcceptTextEntry)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x6607860", Offset = "0x6606460", VA = "0x186607860")]
			protected void SMDPQYXLJXM(TXKDNVJCJHK a, Func<string> b, Action<string> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0x6607BF0", Offset = "0x66067F0", VA = "0x186607BF0", Slot = "146")]
			protected virtual void TMUAWETFSSD(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x66051F0", Offset = "0x6603DF0", VA = "0x1866051F0", Slot = "90")]
			public void BEVVSLIZEEG(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x66077F0", Offset = "0x66063F0", VA = "0x1866077F0", Slot = "91")]
			public CircuitsRigidTransform RSLCVKZOBVN()
			{
				return default(CircuitsRigidTransform);
			}

			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "149")]
			public virtual bool IGYPXLPSLTF(Id32<CUMWXIQVBDQ> portGroupId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x66062A0", Offset = "0x6604EA0", VA = "0x1866062A0")]
			private void ICHDBUMFHSW([In] CircuitsVec3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x6607330", Offset = "0x6605F30", VA = "0x186607330")]
			private void PWPEPAIZMZB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x118ABE0", Offset = "0x11897E0", VA = "0x18118ABE0", Slot = "97")]
			private void EEMTGGNHWTU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0x66088C0", Offset = "0x66074C0", VA = "0x1866088C0", Slot = "99")]
			private void YOUPBOAVZKT(Id32<CUMWXIQVBDQ> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x6605730", Offset = "0x6604330", VA = "0x186605730", Slot = "101")]
			private void EFVGIZAVGLK(Id32<CUMWXIQVBDQ> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x66069C0", Offset = "0x66055C0", VA = "0x1866069C0", Slot = "103")]
			private void LAKODBUZXSK(Id32<CUMWXIQVBDQ> id)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x6607F40", Offset = "0x6606B40", VA = "0x186607F40", Slot = "104")]
			private void ULHJLGWUMAO(Id32<CUMWXIQVBDQ> sourceId, Id32<CUMWXIQVBDQ> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x6606120", Offset = "0x6604D20", VA = "0x186606120", Slot = "105")]
			private void HVAJJWZFLNF(Id32<CUMWXIQVBDQ> sourceId, Id32<CUMWXIQVBDQ> targetId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x23E1750", Offset = "0x23E0350", VA = "0x1823E1750", Slot = "98")]
			private void PHSVGBGHSPE(Id32<CUMWXIQVBDQ> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B9")]
			[Cpp2IlInjected.Address(RVA = "0x6606C80", Offset = "0x6605880", VA = "0x186606C80", Slot = "100")]
			private void NLWYNZQONZF(Id32<CUMWXIQVBDQ> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x66058D0", Offset = "0x66044D0", VA = "0x1866058D0", Slot = "102")]
			private void EPPTPURNHLT(Id32<CUMWXIQVBDQ> portGroupId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0x6607A70", Offset = "0x6606670", VA = "0x186607A70", Slot = "106")]
			private void SRKOCURYCYL(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x66083F0", Offset = "0x6606FF0", VA = "0x1866083F0", Slot = "150")]
			[AsyncStateMachine(typeof(TVMAPYLHDJB<>.<RequestNameChange>d__224))]
			public Task<Result<None, JGXPLWKAZER>> WXVAQUUCLEF(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x6605360", Offset = "0x6603F60", VA = "0x186605360", Slot = "57")]
			private void CPMKGGZHOXV(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x6608E10", Offset = "0x6607A10", VA = "0x186608E10", Slot = "58")]
			private void YYPZFQQRIKQ(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x66072C0", Offset = "0x6605EC0", VA = "0x1866072C0", Slot = "30")]
			private bool XWIRZZYTUXC([In] CircuitsVec3 value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x66065F0", Offset = "0x66051F0", VA = "0x1866065F0", Slot = "32")]
			private bool QPEKKJXAVQJ([In] CircuitsQuat value)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0x6606620", Offset = "0x6605220", VA = "0x186606620", Slot = "51")]
			private bool JJMGJGVQPIJ([In] Guid graphId)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6C0", Offset = "0xB1C2C0", VA = "0x180B1D6C0")]
			[CompilerGenerated]
			private string KYDECBBVYSV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0x6606850", Offset = "0x6605450", VA = "0x186606850")]
			[CompilerGenerated]
			private void KXXXEUHYPHM(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		public sealed class LTQZAQLLYRU : JYMIUZXGJNP<OutBusNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0xF8A320", Offset = "0xF88F20", VA = "0x180F8A320", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x2D99290", Offset = "0x2D97E90", VA = "0x182D99290")]
			public LTQZAQLLYRU(QBUZPCMMQEU a, OutBusNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CC")]
		public sealed class LLVDZULCVGU : TVMAPYLHDJB<ParticleVfxNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000CD")]
			[CompilerGenerated]
			private sealed class QBWFFRHGRMS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000290")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> BKWWCCVTBMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000291")]
				public LLVDZULCVGU VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000292")]
				public IReadOnlyDictionary<Guid, int> ZUCUXYUXHTD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000293")]
				public IReadOnlyDictionary<int, Guid> NDEJCOKREZX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000294")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x60004D9")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public QBWFFRHGRMS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004DA")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004DB")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E780", Offset = "0x2D9D380", VA = "0x182D9E780")]
				internal int EQIQZGORPWK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004DC")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E350", Offset = "0x2D9CF50", VA = "0x182D9E350")]
				internal void EQDKBZUUGLB(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004D7")]
				[Cpp2IlInjected.Address(RVA = "0x13736F0", Offset = "0x13722F0", VA = "0x1813736F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x2D98FE0", Offset = "0x2D97BE0", VA = "0x182D98FE0")]
			public LLVDZULCVGU(QBUZPCMMQEU a, ParticleVfxNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D8")]
			[Cpp2IlInjected.Address(RVA = "0x2D98D00", Offset = "0x2D97900", VA = "0x182D98D00", Slot = "145")]
			protected sealed override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		private sealed class NPCKVAABOFE : EKJDOPKEKWM<ISQMNSLHPDN>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004DD")]
				[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0x2D9CE00", Offset = "0x2D9BA00", VA = "0x182D9CE00")]
			public NPCKVAABOFE(QBUZPCMMQEU a, ISQMNSLHPDN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004DF")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		public sealed class LPHYSCNGFPK : TVMAPYLHDJB<FKIOJVQXATP>
		{
			[Cpp2IlInjected.Token(Token = "0x20000D0")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000295")]
				public LPHYSCNGFPK VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000296")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x60004E2")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E3")]
				[Cpp2IlInjected.Address(RVA = "0x2D96650", Offset = "0x2D95250", VA = "0x182D96650")]
				internal bool EQNXWNIOZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004E4")]
				[Cpp2IlInjected.Address(RVA = "0x2D96480", Offset = "0x2D95080", VA = "0x182D96480")]
				internal void EQIQZGORPWK(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004E0")]
			[Cpp2IlInjected.Address(RVA = "0x2D99220", Offset = "0x2D97E20", VA = "0x182D99220")]
			public LPHYSCNGFPK(QBUZPCMMQEU a, FKIOJVQXATP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0x2D99050", Offset = "0x2D97C50", VA = "0x182D99050", Slot = "145")]
			protected sealed override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		public sealed class AVDSFNMVSQV : TVMAPYLHDJB<ProjectileNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000D2")]
			[CompilerGenerated]
			private sealed class QBWFFRHGRMS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000297")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> EBSRHBBRJUL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000298")]
				public AVDSFNMVSQV VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000299")]
				public IReadOnlyDictionary<Guid, int> NUVKVIVZCCV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400029A")]
				public IReadOnlyDictionary<int, Guid> XAXYSSQGBXD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400029B")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x60004E8")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public QBWFFRHGRMS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004E9")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60004EA")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E660", Offset = "0x2D9D260", VA = "0x182D9E660")]
				internal int EQIQZGORPWK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EB")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E0D0", Offset = "0x2D9CCD0", VA = "0x182D9E0D0")]
				internal void EQDKBZUUGLB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EC")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DE30", Offset = "0x2D9CA30", VA = "0x182D9DE30")]
				internal int EPYDETAWWZS()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004ED")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DDA0", Offset = "0x2D9C9A0", VA = "0x182D9DDA0")]
				internal void EPSWHMGZNOJ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004EE")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EF60", Offset = "0x2D9DB60", VA = "0x182D9EF60")]
				internal int YBNWFQADWVX()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004EF")]
				[Cpp2IlInjected.Address(RVA = "0x2D9ED90", Offset = "0x2D9D990", VA = "0x182D9ED90")]
				internal void RCHNNTBIVEZ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F0")]
				[Cpp2IlInjected.Address(RVA = "0x2D9ED40", Offset = "0x2D9D940", VA = "0x182D9ED40")]
				internal int RCCGQMHLLTQ()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F1")]
				[Cpp2IlInjected.Address(RVA = "0x2D9ECB0", Offset = "0x2D9D8B0", VA = "0x182D9ECB0")]
				internal void RBWZTFNOCIH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F2")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EC60", Offset = "0x2D9D860", VA = "0x182D9EC60")]
				internal int RBRSVYTQSWY()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F3")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EBD0", Offset = "0x2D9D7D0", VA = "0x182D9EBD0")]
				internal void RBMLYRZTJLP(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F4")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EB80", Offset = "0x2D9D780", VA = "0x182D9EB80")]
				internal int RBHFBLFWAAG()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F5")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EAF0", Offset = "0x2D9D6F0", VA = "0x182D9EAF0")]
				internal void RBBYEELYQOX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F6")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DD50", Offset = "0x2D9C950", VA = "0x182D9DD50")]
				internal float EPNPKFNCEDA()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F7")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DCC0", Offset = "0x2D9C8C0", VA = "0x182D9DCC0")]
				internal void EPIIMYTEURR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004F8")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DC70", Offset = "0x2D9C870", VA = "0x182D9DC70")]
				internal float EPDBPRZHLGI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004F9")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DBE0", Offset = "0x2D9C7E0", VA = "0x182D9DBE0")]
				internal void EOXUSLFKBUZ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FA")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DB90", Offset = "0x2D9C790", VA = "0x182D9DB90")]
				internal bool EOSNVELMSJQ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60004FB")]
				[Cpp2IlInjected.Address(RVA = "0x2D9F090", Offset = "0x2D9DC90", VA = "0x182D9F090")]
				internal void YCYSMLJLKXI(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FC")]
				[Cpp2IlInjected.Address(RVA = "0x2D9F120", Offset = "0x2D9DD20", VA = "0x182D9F120")]
				internal int YDDZJSDIUIR()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60004FD")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EFB0", Offset = "0x2D9DBB0", VA = "0x182D9EFB0")]
				internal void YCOERXVQSAQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60004FE")]
				[Cpp2IlInjected.Address(RVA = "0x2D9F040", Offset = "0x2D9DC40", VA = "0x182D9F040")]
				internal float YCTLPEPOBLZ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x60004FF")]
				[Cpp2IlInjected.Address(RVA = "0x2D9F250", Offset = "0x2D9DE50", VA = "0x182D9F250")]
				internal void YDTUBMLAWQS(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000500")]
				[Cpp2IlInjected.Address(RVA = "0x2D9F2E0", Offset = "0x2D9DEE0", VA = "0x182D9F2E0")]
				internal float YDZAYTEYGCB()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000501")]
				[Cpp2IlInjected.Address(RVA = "0x2D9F170", Offset = "0x2D9DD70", VA = "0x182D9F170")]
				internal void YDJGGYXGDUA(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000502")]
				[Cpp2IlInjected.Address(RVA = "0x2D9F200", Offset = "0x2D9DE00", VA = "0x182D9F200")]
				internal bool YDONEFRDNFJ()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000503")]
				[Cpp2IlInjected.Address(RVA = "0x2D9EED0", Offset = "0x2D9DAD0", VA = "0x182D9EED0")]
				internal void YBIPIJGGNKO(bool a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A3")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x60004E6")]
				[Cpp2IlInjected.Address(RVA = "0x13736F0", Offset = "0x13722F0", VA = "0x1813736F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0x2D8DFA0", Offset = "0x2D8CBA0", VA = "0x182D8DFA0")]
			public AVDSFNMVSQV(QBUZPCMMQEU a, ProjectileNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0x2D8CEC0", Offset = "0x2D8BAC0", VA = "0x182D8CEC0", Slot = "145")]
			protected sealed override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public abstract class LTSOXDTERVS<a> : TVMAPYLHDJB<a> where a : notnull, PVSTJQHEMJC
		{
			[Cpp2IlInjected.Token(Token = "0x20000D4")]
			[CompilerGenerated]
			private sealed class PYHWMDJZEDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029C")]
				public IReadOnlyList<KeyValuePair<string, EnumChoiceData>> EBSRHBBRJUL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029D")]
				public LTSOXDTERVS<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029E")]
				public IReadOnlyDictionary<Guid, int> NUVKVIVZCCV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400029F")]
				public IReadOnlyDictionary<int, Guid> XAXYSSQGBXD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A0")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002A1")]
				public AudioClipType HAKCLCPGYZJ;

				[Cpp2IlInjected.Token(Token = "0x6000508")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public PYHWMDJZEDC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000509")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				internal IReadOnlyList<KeyValuePair<string, EnumChoiceData>> EQNXWNIOZHT()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600050A")]
				[Cpp2IlInjected.Address(RVA = "0x6197290", Offset = "0x6195E90", VA = "0x186197290")]
				internal int EQIQZGORPWK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600050B")]
				[Cpp2IlInjected.Address(RVA = "0x61970A0", Offset = "0x6195CA0", VA = "0x1861970A0")]
				internal void EQDKBZUUGLB(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050C")]
				[Cpp2IlInjected.Address(RVA = "0x6197050", Offset = "0x6195C50", VA = "0x186197050")]
				internal void EPYDETAWWZS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050D")]
				[Cpp2IlInjected.Address(RVA = "0x6196F40", Offset = "0x6195B40", VA = "0x186196F40")]
				internal void EPSWHMGZNOJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600050E")]
				[Cpp2IlInjected.Address(RVA = "0x6196E90", Offset = "0x6195A90", VA = "0x186196E90")]
				internal bool EPNPKFNCEDA()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600050F")]
				[Cpp2IlInjected.Address(RVA = "0x6196EF0", Offset = "0x6195AF0", VA = "0x186196EF0")]
				internal void EPIIMYTEURR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000510")]
				[Cpp2IlInjected.Address(RVA = "0x6196E90", Offset = "0x6195A90", VA = "0x186196E90")]
				internal bool EPDBPRZHLGI()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000511")]
				[Cpp2IlInjected.Address(RVA = "0x6196E60", Offset = "0x6195A60", VA = "0x186196E60")]
				internal float EOXUSLFKBUZ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000512")]
				[Cpp2IlInjected.Address(RVA = "0x6196DD0", Offset = "0x61959D0", VA = "0x186196DD0")]
				internal void EOSNVELMSJQ(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000513")]
				[Cpp2IlInjected.Address(RVA = "0x6197F40", Offset = "0x6196B40", VA = "0x186197F40")]
				internal float YCYSMLJLKXI()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000514")]
				[Cpp2IlInjected.Address(RVA = "0x6197F70", Offset = "0x6196B70", VA = "0x186197F70")]
				internal void YDDZJSDIUIR(float a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000515")]
				[Cpp2IlInjected.Address(RVA = "0x6197E80", Offset = "0x6196A80", VA = "0x186197E80")]
				internal float YCOERXVQSAQ()
				{
					return default(float);
				}

				[Cpp2IlInjected.Token(Token = "0x6000516")]
				[Cpp2IlInjected.Address(RVA = "0x6197EB0", Offset = "0x6196AB0", VA = "0x186197EB0")]
				internal void YCTLPEPOBLZ(float a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000505")]
				[Cpp2IlInjected.Address(RVA = "0x13736F0", Offset = "0x13722F0", VA = "0x1813736F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			public abstract AudioClipType WLXJYYWPHHV
			{
				[Cpp2IlInjected.Token(Token = "0x6000506")]
				[Cpp2IlInjected.Address(Slot = "151")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000504")]
			[Cpp2IlInjected.Address(RVA = "0x59D9770", Offset = "0x59D8370", VA = "0x1859D9770")]
			public LTSOXDTERVS(QBUZPCMMQEU a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000507")]
			[Cpp2IlInjected.Address(RVA = "0x59D8D50", Offset = "0x59D7950", VA = "0x1859D8D50", Slot = "145")]
			protected sealed override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		private sealed class SSPWEWATYEE : TVMAPYLHDJB<RerouteNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000517")]
				[Cpp2IlInjected.Address(RVA = "0xF9C0A0", Offset = "0xF9ACA0", VA = "0x180F9C0A0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x2DA0470", Offset = "0x2D9F070", VA = "0x182DA0470")]
			public SSPWEWATYEE(QBUZPCMMQEU a, RerouteNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		public sealed class LKMPZGPFMDR : TVMAPYLHDJB<SetLocalPlayerLeaderboardStatNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000D8")]
			[CompilerGenerated]
			private sealed class LIKIZMPSLOB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002A5")]
				public LKMPZGPFMDR VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002A6")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x600051E")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public LIKIZMPSLOB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600051F")]
				[Cpp2IlInjected.Address(RVA = "0x2D98880", Offset = "0x2D97480", VA = "0x182D98880")]
				internal int EQIQZGORPWK()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000520")]
				[Cpp2IlInjected.Address(RVA = "0x2D98720", Offset = "0x2D97320", VA = "0x182D98720")]
				internal void EQDKBZUUGLB(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			private static Dictionary<string, EnumChoiceData>? JVGJQFAPCMS;

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x2D98C90", Offset = "0x2D97890", VA = "0x182D98C90")]
			public LKMPZGPFMDR(QBUZPCMMQEU a, SetLocalPlayerLeaderboardStatNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x2D98930", Offset = "0x2D97530", VA = "0x182D98930", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D9")]
		public sealed class WDRYIGTOKHD : LTSOXDTERVS<SFXAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			public override AudioClipType WLXJYYWPHHV
			{
				[Cpp2IlInjected.Token(Token = "0x6000522")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x2DA77D0", Offset = "0x2DA63D0", VA = "0x182DA77D0")]
			public WDRYIGTOKHD(QBUZPCMMQEU a, SFXAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		private sealed class GFLCOEANVKG : EKJDOPKEKWM<RBFIXEQAAXJ>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000523")]
				[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x2D955A0", Offset = "0x2D941A0", VA = "0x182D955A0")]
			public GFLCOEANVKG(QBUZPCMMQEU a, RBFIXEQAAXJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		private sealed class ISNQMDCDQHD : EKJDOPKEKWM<PQWDCOFZZXA>
		{
			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000526")]
				[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000527")]
			[Cpp2IlInjected.Address(RVA = "0x2D97960", Offset = "0x2D96560", VA = "0x182D97960")]
			public ISNQMDCDQHD(QBUZPCMMQEU a, PQWDCOFZZXA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000528")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		public sealed class TBEBJKKTGET : BEBUHZZYJSX<StringNode>
		{
			[Cpp2IlInjected.Token(Token = "0x20000DD")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[StructLayout((LayoutKind)3)]
				[Cpp2IlInjected.Token(Token = "0x20000DE")]
				private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002A9")]
					public int <>1__state;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002AA")]
					public AsyncVoidMethodBuilder <>t__builder;

					[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
					[Cpp2IlInjected.Token(Token = "0x40002AB")]
					public GWGISWCHLZW <>4__this;

					[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
					[Cpp2IlInjected.Token(Token = "0x40002AC")]
					public string value;

					[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
					[Cpp2IlInjected.Token(Token = "0x40002AD")]
					private TaskAwaiter<bool> <>u__1;

					[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
					[Cpp2IlInjected.Token(Token = "0x40002AE")]
					private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__2;

					[Cpp2IlInjected.Token(Token = "0x600052D")]
					[Cpp2IlInjected.Address(RVA = "0x2DA5660", Offset = "0x2DA4260", VA = "0x182DA5660", Slot = "4")]
					private void MoveNext()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600052E")]
					[Cpp2IlInjected.Address(RVA = "0xB7AEC0", Offset = "0xB79AC0", VA = "0x180B7AEC0", Slot = "5")]
					[DebuggerHidden]
					private void SetStateMachine(IAsyncStateMachine stateMachine)
					{
					}
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002A7")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002A8")]
				public TBEBJKKTGET VISDDFDIKLJ;

				[Cpp2IlInjected.Token(Token = "0x600052B")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600052C")]
				[Cpp2IlInjected.Address(RVA = "0x2D96850", Offset = "0x2D95450", VA = "0x182D96850")]
				[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
				internal void JYYGBZYKCVG(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000529")]
			[Cpp2IlInjected.Address(RVA = "0x2DA0760", Offset = "0x2D9F360", VA = "0x182DA0760")]
			public TBEBJKKTGET(QBUZPCMMQEU a, StringNode b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600052A")]
			[Cpp2IlInjected.Address(RVA = "0x2DA04E0", Offset = "0x2D9F0E0", VA = "0x182DA04E0", Slot = "151")]
			protected override void JUYYYBSEVZO(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		public sealed class YLPKQSGELCG : LTSOXDTERVS<StudioAudioNode>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public override AudioClipType WLXJYYWPHHV
			{
				[Cpp2IlInjected.Token(Token = "0x6000530")]
				[Cpp2IlInjected.Address(RVA = "0xD93C40", Offset = "0xD92840", VA = "0x180D93C40", Slot = "151")]
				get
				{
					return default(AudioClipType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x2DA7D90", Offset = "0x2DA6990", VA = "0x182DA7D90")]
			public YLPKQSGELCG(QBUZPCMMQEU a, StudioAudioNode b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		private sealed class QLZUPYQOBTB : TVMAPYLHDJB<WEAAGCQJTXL>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000531")]
				[Cpp2IlInjected.Address(RVA = "0xF85700", Offset = "0xF84300", VA = "0x180F85700", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x2D9FB00", Offset = "0x2D9E700", VA = "0x182D9FB00")]
			public QLZUPYQOBTB(QBUZPCMMQEU a, WEAAGCQJTXL b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000533")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		public sealed class ZACITMBSIJQ : TVMAPYLHDJB<UCNULAKUVLR>
		{
			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			public sealed override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000534")]
				[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			public sealed override bool IsRegisteredToEvent
			{
				[Cpp2IlInjected.Token(Token = "0x6000535")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "114")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			protected sealed override bool MAMZSVMDOYP
			{
				[Cpp2IlInjected.Token(Token = "0x6000536")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "111")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x2DA8480", Offset = "0x2DA7080", VA = "0x182DA8480")]
			public ZACITMBSIJQ(QBUZPCMMQEU a, UCNULAKUVLR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x2DA8130", Offset = "0x2DA6D30", VA = "0x182DA8130", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x2DA8440", Offset = "0x2DA7040", VA = "0x182DA8440")]
			private int UEAVWRFJHWY()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x2DA80C0", Offset = "0x2DA6CC0", VA = "0x182DA80C0")]
			private void QCUHKXRNXQI(int a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		public class INMFRNACXKF : OWOBAXIAKCA
		{
			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x2D97830", Offset = "0x2D96430", VA = "0x182D97830")]
			public INMFRNACXKF(QBUZPCMMQEU a, OINYKCZIBWN b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		public sealed class TFOMGXDGRZV : TVMAPYLHDJB<YAKPPPUHBAA>
		{
			[Cpp2IlInjected.Token(Token = "0x20000E4")]
			[CompilerGenerated]
			private sealed class QBWFFRHGRMS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002AF")]
				public TFOMGXDGRZV VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40002B0")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public QBWFFRHGRMS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000541")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E9B0", Offset = "0x2D9D5B0", VA = "0x182D9E9B0")]
				internal int EQNXWNIOZHT()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E4A0", Offset = "0x2D9D0A0", VA = "0x182D9E4A0")]
				internal void EQIQZGORPWK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x2D9E030", Offset = "0x2D9CC30", VA = "0x182D9E030")]
				internal int EQDKBZUUGLB()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x2D9DF10", Offset = "0x2D9CB10", VA = "0x182D9DF10")]
				internal void EPYDETAWWZS(int a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x13736F0", Offset = "0x13722F0", VA = "0x1813736F0", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x2DA0AB0", Offset = "0x2D9F6B0", VA = "0x182DA0AB0")]
			public TFOMGXDGRZV(QBUZPCMMQEU a, YAKPPPUHBAA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053F")]
			[Cpp2IlInjected.Address(RVA = "0x2DA07C0", Offset = "0x2D9F3C0", VA = "0x182DA07C0", Slot = "145")]
			protected sealed override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		public sealed class PPQOICTSOMM : BEBUHZZYJSX<PUEFDVRJVLT>
		{
			[Cpp2IlInjected.Token(Token = "0x6000545")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D6A0", Offset = "0x2D9C2A0", VA = "0x182D9D6A0")]
			public PPQOICTSOMM(QBUZPCMMQEU a, PUEFDVRJVLT b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public abstract class BEBUHZZYJSX<a> : TVMAPYLHDJB<a> where a : notnull, PUEFDVRJVLT
		{
			[Cpp2IlInjected.Token(Token = "0x20000E7")]
			[CompilerGenerated]
			private sealed class BZLIFPWZYIV
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B1")]
				public BEBUHZZYJSX<a> VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B2")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public BZLIFPWZYIV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600054E")]
				[Cpp2IlInjected.Address(RVA = "0x77C7040", Offset = "0x77C5C40", VA = "0x1877C7040")]
				internal bool EQNXWNIOZHT()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(RVA = "0x77C6FB0", Offset = "0x77C5BB0", VA = "0x1877C6FB0")]
				internal void EQIQZGORPWK(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(RVA = "0x77C6F80", Offset = "0x77C5B80", VA = "0x1877C6F80")]
				internal bool EQDKBZUUGLB()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(RVA = "0x77C6EF0", Offset = "0x77C5AF0", VA = "0x1877C6EF0")]
				internal void EPYDETAWWZS(bool a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(RVA = "0x77C6E80", Offset = "0x77C5A80", VA = "0x1877C6E80")]
				internal bool EPSWHMGZNOJ()
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			[CompilerGenerated]
			private sealed class GLPIMGKKXXA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B3")]
				public RIUQPTLWHHA POGDWXLUFMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002B4")]
				public BEBUHZZYJSX<a> VISDDFDIKLJ;

				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GLPIMGKKXXA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(RVA = "0x5411690", Offset = "0x5410290", VA = "0x185411690")]
				internal void JYYGBZYKCVG(string a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			public override NodeVisualizationKey Key
			{
				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0xDD0430", Offset = "0xDCF030", VA = "0x180DD0430", Slot = "112")]
				get
				{
					return default(NodeVisualizationKey);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			public override MemoryType VariableMemoryType
			{
				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x76E2460", Offset = "0x76E1060", VA = "0x1876E2460", Slot = "116")]
				get
				{
					return default(MemoryType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x76E2350", Offset = "0x76E0F50", VA = "0x1876E2350")]
			protected BEBUHZZYJSX(QBUZPCMMQEU a, a b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x76E1BC0", Offset = "0x76E07C0", VA = "0x1876E1BC0", Slot = "109")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x76E1FD0", Offset = "0x76E0BD0", VA = "0x1876E1FD0", Slot = "145")]
			protected override void TYFKAPOXAGH(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x76E1CB0", Offset = "0x76E08B0", VA = "0x1876E1CB0", Slot = "151")]
			protected virtual void JUYYYBSEVZO(TXKDNVJCJHK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x76E1F90", Offset = "0x76E0B90", VA = "0x1876E1F90", Slot = "127")]
			public override void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2D828B0", Offset = "0x2D814B0", VA = "0x182D828B0")]
		public static VXTUWJBKUSC New(QBUZPCMMQEU circuitsManager, OINYKCZIBWN node)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class QGJIYLUNIES : NONTLGDXKSQ, CQXNAEUPHGL, EAPWZEKDOJL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public Id32<IEQQYWIVYHH> NZUDWCQOASR
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0xE1C0C0", Offset = "0xE1ACC0", VA = "0x180E1C0C0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return default(Id32<IEQQYWIVYHH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public Id32<DJLWKSNXJYV> JPDAWZBPOTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x2186E60", Offset = "0x2185A60", VA = "0x182186E60", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(Id32<DJLWKSNXJYV>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x27ED940", Offset = "0x27EC540", VA = "0x1827ED940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private Id32<TIEJMITYOHO> SEQMONFXOYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0xF7CAF0", Offset = "0xF7B6F0", VA = "0x180F7CAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public override Id32<QPIYMGVHWXV> OZMFWSPYFEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0x2D9F810", Offset = "0x2D9E410", VA = "0x182D9F810", Slot = "22")]
			get
			{
				return default(Id32<QPIYMGVHWXV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F860", Offset = "0x2D9E460", VA = "0x182D9F860")]
		private QGJIYLUNIES(QBUZPCMMQEU a, OINYKCZIBWN b, ZWOMZNWDUPR c, Id32<CUMWXIQVBDQ> portGroupId, Id32<DJLWKSNXJYV> outputId, Id32<TIEJMITYOHO> outputDefId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F4C0", Offset = "0x2D9E0C0", VA = "0x182D9F4C0")]
		public static QGJIYLUNIES New(QBUZPCMMQEU circuitsManager, OINYKCZIBWN node, ZWOMZNWDUPR output, Id32<CUMWXIQVBDQ> portGroupId, Id32<TIEJMITYOHO> outputDefId, Id32<DJLWKSNXJYV> outputId, bool canInteract, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x27ED940", Offset = "0x27EC540", VA = "0x1827ED940")]
		internal void FGQVXHNKRDU(Id32<DJLWKSNXJYV> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public abstract class NONTLGDXKSQ : EAPWZEKDOJL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		private struct LazyTypeAdapter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private CQHASNVOJQY? _typeAdapter;

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x2D99A50", Offset = "0x2D98650", VA = "0x182D99A50")]
			public void Clear()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x2D99A60", Offset = "0x2D98660", VA = "0x182D99A60")]
			public CQHASNVOJQY GQLWUEAYTHE(NONTLGDXKSQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected readonly QBUZPCMMQEU CYOVMHDASMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected readonly OINYKCZIBWN ISZOJWPYZLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private LazyTypeAdapter WKBAKHRRSKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private readonly XZPKRNSZWPV YCSLXIOWNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private readonly List<HFSKVMSXLFT> DAVOJCHOZHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private readonly List<PMZMMSKUDKT> XLKTGEHCWFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private readonly bool GRKFGFRFXCO;

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		[Todo("To be deprecated with NodeConnection")]
		public IEnumerable<StaticEdge> RMXWNDFASUO
		{
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x2D9C9C0", Offset = "0x2D9B5C0", VA = "0x182D9C9C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public DisplayKind OUMLOWGQAJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600055E")]
			[Cpp2IlInjected.Address(RVA = "0xB31CB0", Offset = "0xB308B0", VA = "0x180B31CB0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DisplayKind);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public Id32<JQPVMRMCZNG> LGSCAVMTATU
		{
			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x2D9B550", Offset = "0x2D9A150", VA = "0x182D9B550", Slot = "6")]
			get
			{
				return default(Id32<JQPVMRMCZNG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public Id128<JQPVMRMCZNG> WDWIWIPILVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x2D9BC70", Offset = "0x2D9A870", VA = "0x182D9BC70", Slot = "7")]
			get
			{
				return default(Id128<JQPVMRMCZNG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public IDLCASSILBG URXEOMIPXEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x2D9BA60", Offset = "0x2D9A660", VA = "0x182D9BA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public OHIRIUFGIUC VFFWURSPVNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x2D9C7F0", Offset = "0x2D9B3F0", VA = "0x182D9C7F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		protected CQHASNVOJQY KJRTPQNEDYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x2D9C7F0", Offset = "0x2D9B3F0", VA = "0x182D9C7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public PortImage MELVBFDMGKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x2D9C880", Offset = "0x2D9B480", VA = "0x182D9C880", Slot = "13")]
			get
			{
				return default(PortImage);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Id128<LWYTCPIHOQE> PATYYQBRWBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x2D9BFC0", Offset = "0x2D9ABC0", VA = "0x182D9BFC0", Slot = "9")]
			get
			{
				return default(Id128<LWYTCPIHOQE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public Id32<CUMWXIQVBDQ> NMRRFENDSBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0xF31B10", Offset = "0xF30710", VA = "0x180F31B10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(Id32<CUMWXIQVBDQ>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x1A9D7C0", Offset = "0x1A9C3C0", VA = "0x181A9D7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public abstract Id32<QPIYMGVHWXV> OZMFWSPYFEC
		{
			[Cpp2IlInjected.Token(Token = "0x600056A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public bool ECIXHQXMDXR
		{
			[Cpp2IlInjected.Token(Token = "0x600056B")]
			[Cpp2IlInjected.Address(RVA = "0xFD49C0", Offset = "0xFD35C0", VA = "0x180FD49C0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CCB0", Offset = "0x2D9B8B0", VA = "0x182D9CCB0")]
		protected NONTLGDXKSQ(QBUZPCMMQEU a, OINYKCZIBWN b, XZPKRNSZWPV c, Id32<CUMWXIQVBDQ> portGroupId, bool d, string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BB30", Offset = "0x2D9A730", VA = "0x182D9BB30", Slot = "23")]
		protected virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B800", Offset = "0x2D9A400", VA = "0x182D9B800", Slot = "24")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BA80", Offset = "0x2D9A680", VA = "0x182D9BA80", Slot = "14")]
		public void GWSYEGFHBSE(HFSKVMSXLFT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B4A0", Offset = "0x2D9A0A0", VA = "0x182D9B4A0", Slot = "15")]
		public void BREJVJOMYRE(PMZMMSKUDKT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BCA0", Offset = "0x2D9A8A0", VA = "0x182D9BCA0")]
		private bool JNCOPJJUHGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BFE0", Offset = "0x2D9ABE0", VA = "0x182D9BFE0", Slot = "17")]
		public void QMYRLDHACAS(LRRWLGFUBVR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x2D9BC10", Offset = "0x2D9A810", VA = "0x182D9BC10", Slot = "25")]
		protected virtual void JDCOSIQEHEE(LRRWLGFUBVR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B8E0", Offset = "0x2D9A4E0", VA = "0x182D9B8E0", Slot = "20")]
		private void FUGOPBJSTST(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CB00", Offset = "0x2D9B700", VA = "0x182D9CB00")]
		private void VRCFDCVJCOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B660", Offset = "0x2D9A260", VA = "0x182D9B660")]
		private void DMLDIRPQJJO([In] TraversalProperties traversalProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B600", Offset = "0x2D9A200", VA = "0x182D9B600", Slot = "18")]
		public void DFESWAZKLLH(HFSKVMSXLFT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B580", Offset = "0x2D9A180", VA = "0x182D9B580", Slot = "19")]
		public void CAXPHXGZNGD(PMZMMSKUDKT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
		internal void PEBJQNBROQI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B5E0", Offset = "0x2D9A1E0", VA = "0x182D9B5E0")]
		internal void CSJJMVRXAOX(QDGIPSGLXID a, IDLCASSILBG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x1A9D7C0", Offset = "0x1A9C3C0", VA = "0x181A9D7C0")]
		internal void ZWUCPPEYPVU(Id32<CUMWXIQVBDQ> portGroupId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class DBNXKIZLIWP : JDUQSSPECCA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class PCIKKLSAIKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public QBUZPCMMQEU WXXITQQZDSU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			public OINYKCZIBWN HILXSABAWVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			public Id32<CUMWXIQVBDQ> JOBUTHOWAUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			public bool NNFYSUYAPJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			public bool KOSVKQUKYNS;

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PCIKKLSAIKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D5C0", Offset = "0x2D9C1C0", VA = "0x182D9D5C0")]
			internal ECNQONAYIXX DRJTYBKFTHV((int PortDescIndex, int PortIndex, PITLKUDDKGI InputPort) i)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x2D9D4F0", Offset = "0x2D9C0F0", VA = "0x182D9D4F0")]
			internal QGJIYLUNIES DRENAUQIJWM(ZWOMZNWDUPR a, int b)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		[CompilerGenerated]
		private struct <AddInputPort>d__86 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x2DA1020", Offset = "0x2D9FC20", VA = "0x182DA1020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x2DA1490", Offset = "0x2DA0090", VA = "0x182DA1490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private struct <RemoveInputDef>d__108 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public Id32<VPKCJSHTFFF> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x2DA2620", Offset = "0x2DA1220", VA = "0x182DA2620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x2DA2970", Offset = "0x2DA1570", VA = "0x182DA2970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[CompilerGenerated]
		private struct <RemoveInputPort>d__112 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F8")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x2DA29E0", Offset = "0x2DA15E0", VA = "0x182DA29E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x2DA2E60", Offset = "0x2DA1A60", VA = "0x182DA2E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private struct <RemoveOutputDef>d__109 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FA")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public Id32<TIEJMITYOHO> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x2DA2ED0", Offset = "0x2DA1AD0", VA = "0x182DA2ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3220", Offset = "0x2DA1E20", VA = "0x182DA3220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[CompilerGenerated]
		private struct <Rename>d__113 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3A50", Offset = "0x2DA2650", VA = "0x182DA3A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3DA0", Offset = "0x2DA29A0", VA = "0x182DA3DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[CompilerGenerated]
		private struct <RenameInputDef>d__114 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public Id32<VPKCJSHTFFF> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3290", Offset = "0x2DA1E90", VA = "0x182DA3290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3600", Offset = "0x2DA2200", VA = "0x182DA3600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		[CompilerGenerated]
		private struct <RenameOutputDef>d__115 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public Id32<TIEJMITYOHO> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3670", Offset = "0x2DA2270", VA = "0x182DA3670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x2DA39E0", Offset = "0x2DA25E0", VA = "0x182DA39E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[CompilerGenerated]
		private struct <RetypeInputDef>d__116 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public YTMTLPGRGSJ type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			public Id32<VPKCJSHTFFF> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x2DA3E10", Offset = "0x2DA2A10", VA = "0x182DA3E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DC")]
			[Cpp2IlInjected.Address(RVA = "0x2DA41B0", Offset = "0x2DA2DB0", VA = "0x182DA41B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[CompilerGenerated]
		private struct <RetypeOutputDef>d__117 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			public YTMTLPGRGSJ type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public Id32<TIEJMITYOHO> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4220", Offset = "0x2DA2E20", VA = "0x182DA4220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x2DA45C0", Offset = "0x2DA31C0", VA = "0x182DA45C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private struct <SetInputDefIndex>d__110 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public Id32<VPKCJSHTFFF> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Id32<VPKCJSHTFFF> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4630", Offset = "0x2DA3230", VA = "0x182DA4630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4990", Offset = "0x2DA3590", VA = "0x182DA4990", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		[CompilerGenerated]
		private struct <SetOutputDefIndex>d__111 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public DBNXKIZLIWP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public Id32<TIEJMITYOHO> outputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public Id32<TIEJMITYOHO> targetIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			private HQZRPDRLYMD <errReporting>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4A00", Offset = "0x2DA3600", VA = "0x182DA4A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4D60", Offset = "0x2DA3960", VA = "0x182DA4D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private readonly bool KWGEJQWBFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private readonly QBUZPCMMQEU CYOVMHDASMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private readonly bool WYHBVWLMDEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private ReadOnlyIdArray<GIQEAILWCVY, ECNQONAYIXX> XWBORCNNRKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private ReadOnlyIdArray<GIQEAILWCVY, TXCKZOIHSCK> TPBMCHHZKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private readonly OINYKCZIBWN ISZOJWPYZLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private ReadOnlyIdArray<DJLWKSNXJYV, QGJIYLUNIES> OCIAEYLFVTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private ReadOnlyIdArray<DJLWKSNXJYV, CQXNAEUPHGL> QPWWFIQMWUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private string? ZGZPDLFINER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private readonly JSZSMMNDASI CULWXCXDZVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private Id32<CUMWXIQVBDQ> EZLXDCNOIMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private readonly bool DWCPWACMTQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[CompilerGenerated]
		private Action? ZODOIUDJYUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[CompilerGenerated]
		private Action? PGRZQTIMJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[CompilerGenerated]
		private Action<Id32<GIQEAILWCVY>>? CZOQFJRRNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[CompilerGenerated]
		private Action<Id32<DJLWKSNXJYV>>? BJQSVVOXWEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[CompilerGenerated]
		private JDUQSSPECCA.PortGroupIdChangeDelegate? YXQLQVSQDWF;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool FCMTSOTFUKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x2D8F6D0", Offset = "0x2D8E2D0", VA = "0x182D8F6D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public bool WTXNWLBELEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x2D91C10", Offset = "0x2D90810", VA = "0x182D91C10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public bool BAUAQXPLUYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x2D92F30", Offset = "0x2D91B30", VA = "0x182D92F30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public Id128<JQPVMRMCZNG> WDWIWIPILVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x2D91390", Offset = "0x2D8FF90", VA = "0x182D91390", Slot = "7")]
			get
			{
				return default(Id128<JQPVMRMCZNG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public bool JXRTGJYGHTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x2D936F0", Offset = "0x2D922F0", VA = "0x182D936F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public ReadOnlyIdArray<GIQEAILWCVY, TXCKZOIHSCK> NFEHNMKPGQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "9")]
			get
			{
				return default(ReadOnlyIdArray<GIQEAILWCVY, TXCKZOIHSCK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x2D929F0", Offset = "0x2D915F0", VA = "0x182D929F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public Id128<LWYTCPIHOQE> PATYYQBRWBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x2D913C0", Offset = "0x2D8FFC0", VA = "0x182D913C0", Slot = "11")]
			get
			{
				return default(Id128<LWYTCPIHOQE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public ReadOnlyIdArray<DJLWKSNXJYV, CQXNAEUPHGL> RATUKFOUOMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "12")]
			get
			{
				return default(ReadOnlyIdArray<DJLWKSNXJYV, CQXNAEUPHGL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public Id32<CUMWXIQVBDQ> NMRRFENDSBC
		{
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xB6E220", Offset = "0xB6CE20", VA = "0x180B6E220", Slot = "13")]
			get
			{
				return default(Id32<CUMWXIQVBDQ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action? SKJVATXIDVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x2D93770", Offset = "0x2D92370", VA = "0x182D93770", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0x2D940B0", Offset = "0x2D92CB0", VA = "0x182D940B0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action? GTRUIZHRNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x2D8F620", Offset = "0x2D8E220", VA = "0x182D8F620", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x2D8F080", Offset = "0x2D8DC80", VA = "0x182D8F080", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<Id32<GIQEAILWCVY?>, Id32<GIQEAILWCVY?>>? MJFIFRJYTTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x2D920D0", Offset = "0x2D90CD0", VA = "0x182D920D0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x2D906D0", Offset = "0x2D8F2D0", VA = "0x182D906D0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<Id32<GIQEAILWCVY?>, Id32<GIQEAILWCVY?>>? KBHMZCECKDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x2D8EFC0", Offset = "0x2D8DBC0", VA = "0x182D8EFC0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0x2D93C40", Offset = "0x2D92840", VA = "0x182D93C40", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action<Id32<DJLWKSNXJYV?>, Id32<DJLWKSNXJYV?>>? JRJASMZNPVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x2D91A50", Offset = "0x2D90650", VA = "0x182D91A50", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x2D905F0", Offset = "0x2D8F1F0", VA = "0x182D905F0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public event Action<Id32<DJLWKSNXJYV?>, Id32<DJLWKSNXJYV?>>? OYWNPADTAGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x2D93630", Offset = "0x2D92230", VA = "0x182D93630", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x2D90C00", Offset = "0x2D8F800", VA = "0x182D90C00", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<Id32<GIQEAILWCVY?>, TXCKZOIHSCK?>? GCZTLAPAEDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x2D92AE0", Offset = "0x2D916E0", VA = "0x182D92AE0", Slot = "26")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x2D93570", Offset = "0x2D92170", VA = "0x182D93570", Slot = "27")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<Id32<GIQEAILWCVY?>>? MQDOAPINIPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x2D91D90", Offset = "0x2D90990", VA = "0x182D91D90", Slot = "28")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x2D93A90", Offset = "0x2D92690", VA = "0x182D93A90", Slot = "29")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<Id32<GIQEAILWCVY?>, TXCKZOIHSCK?>? AEVJUITETLF
		{
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x2D90400", Offset = "0x2D8F000", VA = "0x182D90400", Slot = "30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x2D92C30", Offset = "0x2D91830", VA = "0x182D92C30", Slot = "31")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<Id32<DJLWKSNXJYV?>, CQXNAEUPHGL?>? YFRSDFGJMIO
		{
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x2D92E70", Offset = "0x2D91A70", VA = "0x182D92E70", Slot = "32")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x2D92930", Offset = "0x2D91530", VA = "0x182D92930", Slot = "33")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<Id32<DJLWKSNXJYV?>>? NPZMESSFRNB
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x2D8FBF0", Offset = "0x2D8E7F0", VA = "0x182D8FBF0", Slot = "34")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x2D91B10", Offset = "0x2D90710", VA = "0x182D91B10", Slot = "35")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<Id32<DJLWKSNXJYV?>, CQXNAEUPHGL?>? WPQKQTXUMNA
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x2D92A20", Offset = "0x2D91620", VA = "0x182D92A20", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x2D913E0", Offset = "0x2D8FFE0", VA = "0x182D913E0", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D94150", Offset = "0x2D92D50", VA = "0x182D94150")]
		private DBNXKIZLIWP(bool a, QBUZPCMMQEU b, bool c, ReadOnlyIdArray<GIQEAILWCVY, ECNQONAYIXX> inputs, ReadOnlyIdArray<GIQEAILWCVY, TXCKZOIHSCK> inputsAsStaticInputs, OINYKCZIBWN d, ReadOnlyIdArray<DJLWKSNXJYV, QGJIYLUNIES> outputs, ReadOnlyIdArray<DJLWKSNXJYV, CQXNAEUPHGL> outputsAsStaticOutputs, string? overrideName, JSZSMMNDASI e, Id32<CUMWXIQVBDQ> portGroupId, bool f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D922C0", Offset = "0x2D90EC0", VA = "0x182D922C0")]
		public static DBNXKIZLIWP New(bool canInteract, QBUZPCMMQEU circuitsManager, bool hasFunctionHeader, OINYKCZIBWN node, JSZSMMNDASI portGroup, Id32<CUMWXIQVBDQ> portGroupId, bool ignoreChipConfigPortNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FCB0", Offset = "0x2D8E8B0", VA = "0x182D8FCB0", Slot = "69")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D92D80", Offset = "0x2D91980", VA = "0x182D92D80", Slot = "38")]
		[AsyncStateMachine(typeof(<AddInputPort>d__86))]
		public Task<Result<None, JGXPLWKAZER?>>? SLRXXMRZVYX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F8A0", Offset = "0x2D8E4A0", VA = "0x182D8F8A0")]
		private (SGQJNZSRMMW?, int)? CGMBZWEEZTR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D93980", Offset = "0x2D92580", VA = "0x182D93980", Slot = "58")]
		private void YPCPJEBAZNH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x27D4290", Offset = "0x27D2E90", VA = "0x1827D4290", Slot = "57")]
		private void ITWYLFLQSWA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F250", Offset = "0x2D8DE50", VA = "0x182D8F250", Slot = "61")]
		private void BIUVRHFFNSG(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D92CF0", Offset = "0x2D918F0", VA = "0x182D92CF0", Slot = "63")]
		private void SEBTVKBABPP(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D914A0", Offset = "0x2D900A0", VA = "0x182D914A0", Slot = "50")]
		private void KVOWASEFNQE(int a, Id32<GIQEAILWCVY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D906B0", Offset = "0x2D8F2B0", VA = "0x182D906B0", Slot = "54")]
		private void FSTXYNGQUHD(int a, Id32<GIQEAILWCVY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D91BF0", Offset = "0x2D907F0", VA = "0x182D91BF0", Slot = "49")]
		private void LIXRNBAXNFB(int a, Id32<GIQEAILWCVY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D93120", Offset = "0x2D91D20", VA = "0x182D93120", Slot = "53")]
		private void UKOTFGMHACY(int a, Id32<GIQEAILWCVY> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D91F60", Offset = "0x2D90B60", VA = "0x182D91F60", Slot = "66")]
		private void MSZFRZMADGG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x11CC310", Offset = "0x11CAF10", VA = "0x1811CC310", Slot = "65")]
		private void NSYEMAUGODZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F790", Offset = "0x2D8E390", VA = "0x182D8F790", Slot = "60")]
		private void CDAMYKHBRUI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x27D4290", Offset = "0x27D2E90", VA = "0x1827D4290", Slot = "59")]
		private void HABYLUSFSDB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D90030", Offset = "0x2D8EC30", VA = "0x182D90030", Slot = "62")]
		private void EJZTYAZQEGF(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D92BA0", Offset = "0x2D917A0", VA = "0x182D92BA0", Slot = "64")]
		private void QKLJXOZLSZC(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D90CC0", Offset = "0x2D8F8C0", VA = "0x182D90CC0", Slot = "52")]
		private void IYEUGJVBZBV(int a, Id32<DJLWKSNXJYV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D91BD0", Offset = "0x2D907D0", VA = "0x182D91BD0", Slot = "56")]
		private void LCFVAZAATLW(int a, Id32<DJLWKSNXJYV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D91C50", Offset = "0x2D90850", VA = "0x182D91C50", Slot = "51")]
		private void LWJZECKFLLQ(int a, Id32<DJLWKSNXJYV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D90790", Offset = "0x2D8F390", VA = "0x182D90790", Slot = "55")]
		private void IPUWNAHTHTJ(int a, Id32<DJLWKSNXJYV> portId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D93810", Offset = "0x2D92410", VA = "0x182D93810", Slot = "68")]
		private void YFVASVTTJED(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x11CC310", Offset = "0x11CAF10", VA = "0x1811CC310", Slot = "67")]
		private void KPHRZRZRGUU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D91E50", Offset = "0x2D90A50", VA = "0x182D91E50", Slot = "39")]
		[AsyncStateMachine(typeof(<RemoveInputDef>d__108))]
		public Task<Result<None, JGXPLWKAZER?>>? MRJADUIJXCK(Id32<VPKCJSHTFFF> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FAE0", Offset = "0x2D8E6E0", VA = "0x182D8FAE0", Slot = "40")]
		[AsyncStateMachine(typeof(<RemoveOutputDef>d__109))]
		public Task<Result<None, JGXPLWKAZER?>>? CQPJBPXFUXF(Id32<TIEJMITYOHO> outputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x2D91C70", Offset = "0x2D90870", VA = "0x182D91C70", Slot = "41")]
		[AsyncStateMachine(typeof(<SetInputDefIndex>d__110))]
		public Task<Result<None, JGXPLWKAZER?>>? MEMSRKEJQBC(Id32<VPKCJSHTFFF> inputDefId, Id32<VPKCJSHTFFF> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F130", Offset = "0x2D8DD30", VA = "0x182D8F130", Slot = "42")]
		[AsyncStateMachine(typeof(<SetOutputDefIndex>d__111))]
		public Task<Result<None, JGXPLWKAZER?>>? BFUJWVVNOET(Id32<TIEJMITYOHO> outputDefId, Id32<TIEJMITYOHO> targetIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x2D93B50", Offset = "0x2D92750", VA = "0x182D93B50", Slot = "43")]
		[AsyncStateMachine(typeof(<RemoveInputPort>d__112))]
		public Task<Result<None, JGXPLWKAZER?>>? YVTCNFCYKNS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x2D92810", Offset = "0x2D91410", VA = "0x182D92810", Slot = "44")]
		[AsyncStateMachine(typeof(<Rename>d__113))]
		public Task<Result<None, JGXPLWKAZER>> OKGAIVFXYBB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x2D92FF0", Offset = "0x2D91BF0", VA = "0x182D92FF0", Slot = "45")]
		[AsyncStateMachine(typeof(<RenameInputDef>d__114))]
		public Task<Result<None, JGXPLWKAZER>> UBHGLZINNUU(Id32<VPKCJSHTFFF> inputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x2D904C0", Offset = "0x2D8F0C0", VA = "0x182D904C0", Slot = "46")]
		[AsyncStateMachine(typeof(<RenameOutputDef>d__115))]
		public Task<Result<None, JGXPLWKAZER>> FMPVMSNKDFH(Id32<TIEJMITYOHO> outputDefId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x2D91260", Offset = "0x2D8FE60", VA = "0x182D91260", Slot = "47")]
		[AsyncStateMachine(typeof(<RetypeInputDef>d__116))]
		public Task<Result<None, JGXPLWKAZER>> IZNLHMMYPXR(Id32<VPKCJSHTFFF> inputDefId, YTMTLPGRGSJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x2D92190", Offset = "0x2D90D90", VA = "0x182D92190", Slot = "48")]
		[AsyncStateMachine(typeof(<RetypeOutputDef>d__117))]
		public Task<Result<None, JGXPLWKAZER>> NREWQMRLOPG(Id32<TIEJMITYOHO> outputDefId, YTMTLPGRGSJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x2D93D00", Offset = "0x2D92900", VA = "0x182D93D00")]
		internal void ZWUCPPEYPVU(Id32<CUMWXIQVBDQ> value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class QGHELZNSXBF : AGTBEXVKYHM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public interface ZWBQGEKCHWS
		{
			[Cpp2IlInjected.Token(Token = "0x20000FD")]
			public readonly struct CircuitGraphToolMapping
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000330")]
				public readonly IReadOnlyDictionary<Id128<JQPVMRMCZNG>, Guid>? mapping;

				[Cpp2IlInjected.Token(Token = "0x60005EE")]
				[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
				public CircuitGraphToolMapping(IReadOnlyDictionary<Id128<JQPVMRMCZNG>, Guid>? mapping)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			QDGIPSGLXID QDGIPSGLXID
			{
				[Cpp2IlInjected.Token(Token = "0x60005E7")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			Task<CircuitRootData> PCSAGAVORGM(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			Task<SuperRoomData> DBGJUNNFCJJ(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(Slot = "3")]
			Task<CHEUGVJIRCB> XGUIWAWDYMM(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(Slot = "4")]
			Task<VMMHASWVFTD> SKUPCDKWKYV(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(Slot = "5")]
			Task<CircuitGraphToolMapping> ECIDWSIVOUS(CancellationToken a);

			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(Slot = "6")]
			Task<StaticCircuitsConfig> OJVIESBXCZX(CancellationToken a);
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		[CompilerGenerated]
		private struct <DeserializeAsync>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public AsyncTaskMethodBuilder<QGHELZNSXBF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public QBUZPCMMQEU circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public CircuitRootData roomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public SuperRoomData superRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			private ZWBQGEKCHWS <selfDeps>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			private CircuitRootData <downloadedRoomData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			private CircuitRootData <actualRoomData>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			private StaticCircuitsConfig <actualStaticConfig>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			private SuperRoomData <finalSuperRoomData>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private CHEUGVJIRCB <roomAssetData>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private VMMHASWVFTD <playerSaveData>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			private TaskAwaiter<CircuitRootData> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			private CircuitRootData <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			private TaskAwaiter<StaticCircuitsConfig> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			private TaskAwaiter<SuperRoomData> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			private TaskAwaiter<CHEUGVJIRCB> <>u__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			private TaskAwaiter<VMMHASWVFTD> <>u__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			private TaskAwaiter<ZWBQGEKCHWS.CircuitGraphToolMapping> <>u__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			private TaskAwaiter<CKCMJRRVCXJ> <>u__7;

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x2DA1500", Offset = "0x2DA0100", VA = "0x182DA1500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x2DA25B0", Offset = "0x2DA11B0", VA = "0x182DA25B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private readonly CKCMJRRVCXJ AWRDSECCDUQ;

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public CKCMJRRVCXJ CKCMJRRVCXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		private QGHELZNSXBF(CKCMJRRVCXJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F330", Offset = "0x2D9DF30", VA = "0x182D9F330")]
		[AsyncStateMachine(typeof(<DeserializeAsync>d__2))]
		public static Task<QGHELZNSXBF> BZRQNWXRYZC(QBUZPCMMQEU a, CircuitRootData? roomData, SuperRoomData? superRoomData, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F4A0", Offset = "0x2D9E0A0", VA = "0x182D9F4A0", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public readonly struct EVRequestExtended
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[CompilerGenerated]
		private struct <Destroy>d__5 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x2DB7D10", Offset = "0x2DB6910", VA = "0x182DB7D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x2DB7F50", Offset = "0x2DB6B50", VA = "0x182DB7F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000101")]
		[CompilerGenerated]
		private struct <MultipartInitialize>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public AsyncTaskMethodBuilder<Result<bool, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public int splitSizeBytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public RootData rootData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public CircuitRootData circuitRootData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public SuperRoomData superRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			private FJCTCRTIJZZ[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x2DB8760", Offset = "0x2DB7360", VA = "0x182DB8760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x2DB8B30", Offset = "0x2DB7730", VA = "0x182DB8B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private struct <Request>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public EVRequestExtended <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public FJCTCRTIJZZ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x2DBD1D0", Offset = "0x2DBBDD0", VA = "0x182DBD1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x2DBD650", Offset = "0x2DBC250", VA = "0x182DBD650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private readonly GGQWPRURVBI _staticNetSys;

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xF290B0", Offset = "0xF27CB0", VA = "0x180F290B0")]
		public EVRequestExtended(GGQWPRURVBI staticNetSys)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD6C0", Offset = "0x2DAC2C0", VA = "0x182DAD6C0")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, JGXPLWKAZER>> JYDCJYGVPCK(FJCTCRTIJZZ a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD7F0", Offset = "0x2DAC3F0", VA = "0x182DAD7F0")]
		[AsyncStateMachine(typeof(<MultipartInitialize>d__3))]
		public Task<Result<bool, JGXPLWKAZER?>>? QSZCLLQWWXL(int a, RootData? b, CircuitRootData? c, SuperRoomData? d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD5D0", Offset = "0x2DAC1D0", VA = "0x182DAD5D0")]
		[AsyncStateMachine(typeof(<Destroy>d__5))]
		public Task<Result<None, JGXPLWKAZER>> Destroy()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public sealed class FNWLWJWOONJ : ACYUMWBFMLS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private readonly INFKYHURQQV ESVADLMYGUG;

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public INFKYHURQQV INFKYHURQQV
		{
			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		private FNWLWJWOONJ(INFKYHURQQV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD970", Offset = "0x2DAC570", VA = "0x182DAD970")]
		public static FNWLWJWOONJ GBPRBWZJNOI(QBUZPCMMQEU a, RootData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2DAD950", Offset = "0x2DAC550", VA = "0x182DAD950", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public interface RCCZIPRQHLG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		CKCMJRRVCXJ CKCMJRRVCXJ
		{
			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		InternalRRStaticStateSysAccess SMGAHXJQNNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		TWRJDPRFSRF TWRJDPRFSRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		OHLXCYTMNOA OHLXCYTMNOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public interface CAWAPZYOHWY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		RCCZIPRQHLG? PRQBDSPTPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		bool EVIDEKZPIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<RCCZIPRQHLG?>? JYPPPZGXUSB();

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task XXIQNESWDZH(QBUZPCMMQEU a, RootData b, CircuitRootData? cv2RoomData, SuperRoomData? cv2SuperRoomData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[WillBeRenamedTo("IStaticCV2Instance")]
	public interface AGTBEXVKYHM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		CKCMJRRVCXJ CKCMJRRVCXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000608")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[WillBeRenamedTo("IStaticEVInstance")]
	public interface ACYUMWBFMLS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		INFKYHURQQV INFKYHURQQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public static class XBICUSTWSSN
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x2DBEFF0", Offset = "0x2DBDBF0", VA = "0x182DBEFF0")]
		public static ReducerFactory<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>> IXNTCRJJAYK([In] this ReducerFactory<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>> reducerFactory)
		{
			return default(ReducerFactory<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU, TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU>>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	public sealed class IIAEPFWMYAU : CADMUCPHRCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private readonly QBUZPCMMQEU CYOVMHDASMV;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public bool EVIDEKZPIGD
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2DADB50", Offset = "0x2DAC750", VA = "0x182DADB50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		internal IIAEPFWMYAU(QBUZPCMMQEU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	internal sealed class WZJVHGKIMTT : SMDDDYAIWZA
	{
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x2DBEF60", Offset = "0x2DBDB60", VA = "0x182DBEF60", Slot = "4")]
		public USCRJZCBVQY? VUUBLHCZHPB(string? a, string? b, string? c, RoomDoorData.MMDAOZKJIDU.RoomDoorInviteMode d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2DBED90", Offset = "0x2DBD990", VA = "0x182DBED90", Slot = "5")]
		public HIWIDUWOSUC IGRNKLGPBLR(string a, string b, List<string> c, int d, int e, int f, int g, JWXRIQWBJDO h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2DBEEC0", Offset = "0x2DBDAC0", VA = "0x182DBEEC0", Slot = "6")]
		public JWXRIQWBJDO MHEGMTIJVDJ(int a, string b, string c, string d, string e, int f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2DBEE50", Offset = "0x2DBDA50", VA = "0x182DBEE50", Slot = "7")]
		public GPQTOWORXJM? MCHJKELFLHL(string? a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public WZJVHGKIMTT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public sealed class WXGHAZZMPVF : UUQTXJCUZUW
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[CompilerGenerated]
		private struct <GetInstanceAsync>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public AsyncTaskMethodBuilder<YHTFDKLWCND> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public WXGHAZZMPVF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private TaskAwaiter<RCCZIPRQHLG?> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x2DB7FC0", Offset = "0x2DB6BC0", VA = "0x182DB7FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x2DB8260", Offset = "0x2DB6E60", VA = "0x182DB8260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private readonly QBUZPCMMQEU CYOVMHDASMV;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public YHTFDKLWCND? CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x2DBE950", Offset = "0x2DBD550", VA = "0x182DBE950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public OHLXCYTMNOA? AZZPBEJSJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x2DBE7B0", Offset = "0x2DBD3B0", VA = "0x182DBE7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public bool SUNRJGVOXYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x2DBE1D0", Offset = "0x2DBCDD0", VA = "0x182DBE1D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public bool EMOSKMMUISE
		{
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x2DBE9D0", Offset = "0x2DBD5D0", VA = "0x182DBE9D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2DBEBB0", Offset = "0x2DBD7B0", VA = "0x182DBEBB0")]
		internal WXGHAZZMPVF(QBUZPCMMQEU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2DBE860", Offset = "0x2DBD460", VA = "0x182DBE860", Slot = "7")]
		[AsyncStateMachine(typeof(<GetInstanceAsync>d__16))]
		public Task<YHTFDKLWCND> LWFZECXAPOQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2DBE230", Offset = "0x2DBCE30", VA = "0x182DBE230", Slot = "9")]
		public IReadOnlyDictionary<Id128<JQPVMRMCZNG>, Guid> CKYAUJJRENQ(IEnumerable<ABLNPBVPOUZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2DBEA30", Offset = "0x2DBD630", VA = "0x182DBEA30", Slot = "10")]
		public CircuitGraphToolMappingRegistryData YVJCAZELXCY(IEnumerable<ABLNPBVPOUZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2DBE5B0", Offset = "0x2DBD1B0", VA = "0x182DBE5B0")]
		public Result<CircuitsRoomData, GOLLTPPMOJR> CSIDKNHRING([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, GOLLTPPMOJR>);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2DBE830", Offset = "0x2DBD430", VA = "0x182DBE830", Slot = "8")]
		private Result<CircuitsRoomData, GOLLTPPMOJR> IVQOZFSCAVD([In] CircuitsRoomData circuitsTemplateData)
		{
			return default(Result<CircuitsRoomData, GOLLTPPMOJR>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	public sealed class OHLXCYTMNOA : YHTFDKLWCND, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		internal static class AOYIQWFFYJV
		{
			[Cpp2IlInjected.Token(Token = "0x2000111")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000370")]
				public int VRSRIUHPOMI;

				[Cpp2IlInjected.Token(Token = "0x60006A4")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60006A5")]
				[Cpp2IlInjected.Address(RVA = "0x2DADB30", Offset = "0x2DAC730", VA = "0x182DADB30")]
				internal void SHOKHTTECIV(CircuitsV2.Protobuf.CircuitNodeData a)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0x2DAA8E0", Offset = "0x2DA94E0", VA = "0x182DAA8E0")]
			public static Result<YHTFDKLWCND.PrepareTemplateForCloneResult, VOMTLWUOHYQ> Run(OHLXCYTMNOA self, [In] YHTFDKLWCND.PrepareTemplateForCloneArgs args)
			{
				return default(Result<YHTFDKLWCND.PrepareTemplateForCloneResult, VOMTLWUOHYQ>);
			}

			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x2DA9B50", Offset = "0x2DA8750", VA = "0x182DA9B50")]
			internal static Result<(PADQCMXGTCZ, CircuitTemplateRootData), VOMTLWUOHYQ> KYTHWVMIFCI(OHLXCYTMNOA a, CircuitTemplateRootData b, bool c, [In] Id128<JQPVMRMCZNG> spawnIntoGraphId, [In] int? makerPenInteractionFilterKey, [In] CircuitsRigidTransform? spawnTransform, [In] CircuitsRigidTransform? originTransform)
			{
				return default(Result<(PADQCMXGTCZ, CircuitTemplateRootData), VOMTLWUOHYQ>);
			}

			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x2DA9710", Offset = "0x2DA8310", VA = "0x182DA9710")]
			private static void FSABWWBAXHA(bool a, ABLNPBVPOUZ b, PADQCMXGTCZ c, [In] Id128<JQPVMRMCZNG> spawnIntoGraphId)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0x2DAAE20", Offset = "0x2DA9A20", VA = "0x182DAAE20")]
			public static void XAFQDJIIDRZ(IOKTUYUAJJS a, [In] YHTFDKLWCND.PrepareTemplateForCloneNewInventionArgs inventionArgs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x2DA9180", Offset = "0x2DA7D80", VA = "0x182DA9180")]
			[CompilerGenerated]
			internal static bool CZFDWUUTQZM(CKCMJRRVCXJ a, CYUKXICDMVO b, CircuitTemplateRootData c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0x2DAA8B0", Offset = "0x2DA94B0", VA = "0x182DAA8B0")]
			[CompilerGenerated]
			internal static bool LCOCXXSYZPV(CircuitsV2.Protobuf.CircuitNodeData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class OUJTYFKTQUZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public OHLXCYTMNOA VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public Id32<JQPVMRMCZNG> IYXWHRDTYMB;

			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public OUJTYFKTQUZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0x2DB6AB0", Offset = "0x2DB56B0", VA = "0x182DB6AB0")]
			internal Id128<LWYTCPIHOQE> YELNRJHGQXY(Id32<LWYTCPIHOQE> a)
			{
				return default(Id128<LWYTCPIHOQE>);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000114")]
		[CompilerGenerated]
		private struct <RequestAddEdge>d__95 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public Id32<IEQQYWIVYHH> srcId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Id32<AWZVWRTEXTC> dstId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x2DB8BA0", Offset = "0x2DB77A0", VA = "0x182DB8BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0x2DB91F0", Offset = "0x2DB7DF0", VA = "0x182DB91F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		[CompilerGenerated]
		private struct <RequestAddInputPort>d__144 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public Id32<LWYTCPIHOQE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public Id32<CUMWXIQVBDQ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Id32<VPKCJSHTFFF> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x2DB9260", Offset = "0x2DB7E60", VA = "0x182DB9260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x2DB95D0", Offset = "0x2DB81D0", VA = "0x182DB95D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		[CompilerGenerated]
		private struct <RequestAddNode>d__97 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public AsyncTaskMethodBuilder<Result<Id32<LWYTCPIHOQE>, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Id32<TFITIOWUSRJ> nodeDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public CircuitsVec3 localSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public CircuitsQuat localSpaceRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			private CKCMJRRVCXJ <state>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			private TaskAwaiter<Result<Guid, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x2DB9950", Offset = "0x2DB8550", VA = "0x182DB9950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0x2DB9DD0", Offset = "0x2DB89D0", VA = "0x182DB9DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[CompilerGenerated]
		private struct <RequestAddNodeDesc>d__98 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public AsyncTaskMethodBuilder<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Id32<LWYTCPIHOQE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			private TaskAwaiter<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x2DB9640", Offset = "0x2DB8240", VA = "0x182DB9640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x2DB98E0", Offset = "0x2DB84E0", VA = "0x182DB98E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000118")]
		[CompilerGenerated]
		private struct <RequestDeleteAllNodes>d__135 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x2DB9E40", Offset = "0x2DB8A40", VA = "0x182DB9E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x2DBA060", Offset = "0x2DB8C60", VA = "0x182DBA060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000119")]
		[CompilerGenerated]
		private struct <RequestGroupNodesIntoCircuitBoard>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public Id32<JQPVMRMCZNG> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public Id128<LWYTCPIHOQE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public List<Id32<LWYTCPIHOQE>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public CircuitsVec3 localBoardPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public CircuitsQuat localBoardRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006B5")]
			[Cpp2IlInjected.Address(RVA = "0x2DBA0D0", Offset = "0x2DB8CD0", VA = "0x182DBA0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B6")]
			[Cpp2IlInjected.Address(RVA = "0x2DBA390", Offset = "0x2DB8F90", VA = "0x182DBA390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011A")]
		[CompilerGenerated]
		private struct <RequestGroupNodesIntoObjectBoard>d__81 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public Id128<JQPVMRMCZNG> legacyGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public Id128<LWYTCPIHOQE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public IReadOnlyList<Id128<LWYTCPIHOQE>> nodeLegacyIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public IReadOnlyDictionary<LegacyInputId, (Id32<CUMWXIQVBDQ>, Id32<GIQEAILWCVY>)> inputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public IReadOnlyDictionary<LegacyOutputId, (Id32<CUMWXIQVBDQ>, Id32<DJLWKSNXJYV>)> outputMapping;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0x2DBA400", Offset = "0x2DB9000", VA = "0x182DBA400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0x2DBA9F0", Offset = "0x2DB95F0", VA = "0x182DBA9F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		[CompilerGenerated]
		private struct <RequestMoveToBoard>d__78 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public Id32<JQPVMRMCZNG> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			public Id128<LWYTCPIHOQE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public List<Id32<LWYTCPIHOQE>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006B9")]
			[Cpp2IlInjected.Address(RVA = "0x2DBAA50", Offset = "0x2DB9650", VA = "0x182DBAA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0x2DBAC90", Offset = "0x2DB9890", VA = "0x182DBAC90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011C")]
		[CompilerGenerated]
		private struct <RequestRemoveInputPortConnections>d__106 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public Id128<LWYTCPIHOQE> inputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public Id128<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Id32<CUMWXIQVBDQ> inputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public Id32<GIQEAILWCVY> inputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0x2DBAD00", Offset = "0x2DB9900", VA = "0x182DBAD00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0x2DBB040", Offset = "0x2DB9C40", VA = "0x182DBB040", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011D")]
		[CompilerGenerated]
		private struct <RequestRemoveLastInputPort>d__145 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public Id32<LWYTCPIHOQE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public Id32<CUMWXIQVBDQ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public Id32<VPKCJSHTFFF> inputDefId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x2DBB0B0", Offset = "0x2DB9CB0", VA = "0x182DBB0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0x2DBB4B0", Offset = "0x2DBA0B0", VA = "0x182DBB4B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		[CompilerGenerated]
		private struct <RequestRemoveNode>d__109 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public Id32<LWYTCPIHOQE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x2DBB520", Offset = "0x2DBA120", VA = "0x182DBB520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x2DBB810", Offset = "0x2DBA410", VA = "0x182DBB810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[CompilerGenerated]
		private struct <RequestRemoveOutputPortConnections>d__107 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public Id128<LWYTCPIHOQE> outputNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public Id128<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public Id32<CUMWXIQVBDQ> outputPortGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public Id32<DJLWKSNXJYV> outputId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x2DBB880", Offset = "0x2DBA480", VA = "0x182DBB880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x2DBBBC0", Offset = "0x2DBA7C0", VA = "0x182DBBBC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[CompilerGenerated]
		private struct <RequestSetNodeLocalTransform>d__149 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public Id32<LWYTCPIHOQE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public CircuitsVec3 localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public CircuitsQuat localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x2DBBC30", Offset = "0x2DBA830", VA = "0x182DBBC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x2DBBFD0", Offset = "0x2DBABD0", VA = "0x182DBBFD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		[CompilerGenerated]
		private struct <RequestSetNodeName>d__136 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public Id32<LWYTCPIHOQE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0x2DBC040", Offset = "0x2DBAC40", VA = "0x182DBC040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x2DBC320", Offset = "0x2DBAF20", VA = "0x182DBC320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[CompilerGenerated]
		private struct <RequestSetVariableHomeValue>d__148 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public Id32<LWYTCPIHOQE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public string value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x2DBC390", Offset = "0x2DBAF90", VA = "0x182DBC390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x2DBC670", Offset = "0x2DBB270", VA = "0x182DBC670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[CompilerGenerated]
		private struct <RequestSpawnTemplate>d__115 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public AsyncTaskMethodBuilder<Result<IEnumerable<Id128<LWYTCPIHOQE>>, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Id128<JQPVMRMCZNG> intoGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public IEnumerable<ABLNPBVPOUZ> persistenceViews;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public CircuitTemplateRootData templateData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			private TaskAwaiter<Result<IEnumerable<OINYKCZIBWN>, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0x2DBC6E0", Offset = "0x2DBB2E0", VA = "0x182DBC6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x2DBCEB0", Offset = "0x2DBBAB0", VA = "0x182DBCEB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[CompilerGenerated]
		private struct <RequestSplitFromBoard>d__79 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public Id32<JQPVMRMCZNG> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public Id128<LWYTCPIHOQE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public Id32<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public List<Id32<LWYTCPIHOQE>> nodeIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006CB")]
			[Cpp2IlInjected.Address(RVA = "0x2DBCF20", Offset = "0x2DBBB20", VA = "0x182DBCF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x2DBD160", Offset = "0x2DBBD60", VA = "0x182DBD160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000125")]
		[CompilerGenerated]
		private struct <RequestUngroupBoard>d__76 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public AsyncTaskMethodBuilder<Result<None, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public OHLXCYTMNOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public Id32<JQPVMRMCZNG> parentGraphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Id32<LWYTCPIHOQE> boardNodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public CircuitsVec3 offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public bool deleteBoard;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			private TaskAwaiter<Result<None, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x2DBD6C0", Offset = "0x2DBC2C0", VA = "0x182DBD6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0x2DBD910", Offset = "0x2DBC510", VA = "0x182DBD910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private readonly QBUZPCMMQEU CYOVMHDASMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private readonly AGTBEXVKYHM JDQPJOGSLRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private readonly ACYUMWBFMLS TTBWZFOKWHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private readonly PrimitivePortGroupModifiers QQBYCPGPNLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private readonly WXGHAZZMPVF QCRFIQRFFAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private Dictionary<Id128<LWYTCPIHOQE>, VXTUWJBKUSC> FYACUJKSXVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[CompilerGenerated]
		private Action<Id128<LWYTCPIHOQE>>? VPNRBGRESEK;

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public Id128<JQPVMRMCZNG> KVTXXAFCZDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x2DAFD00", Offset = "0x2DAE900", VA = "0x182DAFD00", Slot = "4")]
			get
			{
				return default(Id128<JQPVMRMCZNG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public PrimitivePortGroupModifiers OAQDBHUPCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x2D818B0", Offset = "0x2D804B0", VA = "0x182D818B0", Slot = "5")]
			get
			{
				return default(PrimitivePortGroupModifiers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public IReadOnlyList<string> KUGAWDIPGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x2DAF150", Offset = "0x2DADD50", VA = "0x182DAF150", Slot = "86")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action DWWCFZWLJRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x2DB10B0", Offset = "0x2DAFCB0", VA = "0x182DB10B0", Slot = "87")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x2DB65A0", Offset = "0x2DB51A0", VA = "0x182DB65A0", Slot = "88")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<string> GXSYDRSPBDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0x2DB59D0", Offset = "0x2DB45D0", VA = "0x182DB59D0", Slot = "89")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x2DB30B0", Offset = "0x2DB1CB0", VA = "0x182DB30B0", Slot = "90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6610", Offset = "0x2DB5210", VA = "0x182DB6610")]
		public OHLXCYTMNOA(QBUZPCMMQEU a, AGTBEXVKYHM b, ACYUMWBFMLS c, WXGHAZZMPVF d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF5C0", Offset = "0x2DAE1C0", VA = "0x182DAF5C0", Slot = "93")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFD60", Offset = "0x2DAE960", VA = "0x182DAFD60", Slot = "94")]
		public Id32<JKFKBVVIBGI> GFPFFYTISMD(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> inputId)
		{
			return default(Id32<JKFKBVVIBGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF3B0", Offset = "0x2DADFB0", VA = "0x182DAF3B0", Slot = "95")]
		public Id32<BIMMTVVZQUL> DHXJCNIOUDY(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> outputId)
		{
			return default(Id32<BIMMTVVZQUL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE280", Offset = "0x2DACE80", VA = "0x182DAE280", Slot = "6")]
		public (bool, bool) AZIOCHSUSMJ(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId)
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x2DB24B0", Offset = "0x2DB10B0", VA = "0x182DB24B0")]
		public bool NRDQDUJALSI(Id32<JQPVMRMCZNG> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB48A0", Offset = "0x2DB34A0", VA = "0x182DB48A0", Slot = "8")]
		public bool UQCZLGJIDPM(TXCKZOIHSCK a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3840", Offset = "0x2DB2440", VA = "0x182DB3840", Slot = "9")]
		public bool SJVLRXSTFKR(CQXNAEUPHGL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5EF0", Offset = "0x2DB4AF0", VA = "0x182DB5EF0", Slot = "10")]
		public AbsoluteLegacyInputId? XXRPBSEHONI(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB32E0", Offset = "0x2DB1EE0", VA = "0x182DB32E0", Slot = "11")]
		public AbsoluteLegacyOutputId? RAXXPCGOLVH(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x2DB35C0", Offset = "0x2DB21C0", VA = "0x182DB35C0", Slot = "12")]
		public Id32<IEQQYWIVYHH>? RSRJBUCZZZR(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<DJLWKSNXJYV> outputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3950", Offset = "0x2DB2550", VA = "0x182DB3950", Slot = "13")]
		public Id32<AWZVWRTEXTC>? SQLSPHUODYU(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<GIQEAILWCVY> inputIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x2DB37B0", Offset = "0x2DB23B0", VA = "0x182DB37B0", Slot = "14")]
		public IEnumerable<Id32<JQPVMRMCZNG>> SEEJDDSWVEA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4420", Offset = "0x2DB3020", VA = "0x182DB4420", Slot = "15")]
		public IEnumerable<Id32<FFORBNFDOVK>> TRBRNDATVYD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x2DB58E0", Offset = "0x2DB44E0", VA = "0x182DB58E0", Slot = "16")]
		public string WLIVAJFVEMF(Id32<FFORBNFDOVK> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5D00", Offset = "0x2DB4900", VA = "0x182DB5D00", Slot = "17")]
		public string XKNONFRWSOM(Id32<FFORBNFDOVK> functionDeclId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0F30", Offset = "0x2DAFB30", VA = "0x182DB0F30")]
		public VXTUWJBKUSC? JVWCAVZODPV([In] Id128<LWYTCPIHOQE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0290", Offset = "0x2DAEE90", VA = "0x182DB0290", Slot = "24")]
		public Id32<TFITIOWUSRJ> GQJQKPCMRDZ(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId)
		{
			return default(Id32<TFITIOWUSRJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5950", Offset = "0x2DB4550", VA = "0x182DB5950")]
		public Id32<LWYTCPIHOQE> WTGSQRWEQQK(Id32<JQPVMRMCZNG> graphId, [In] Id128<LWYTCPIHOQE> legacyNodeId)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0EB0", Offset = "0x2DAFAB0", VA = "0x182DB0EB0", Slot = "35")]
		public Id32<LWYTCPIHOQE> JSJZQKYHKNN(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> inputId)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFF50", Offset = "0x2DAEB50", VA = "0x182DAFF50", Slot = "36")]
		public Id32<LWYTCPIHOQE> GFVDUBNXXAG(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> outputId)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2F50", Offset = "0x2DB1B50", VA = "0x182DB2F50")]
		public Id32<LWYTCPIHOQE>? OZPKHYGRBVM(Id32<JQPVMRMCZNG> graphId, [In] Id128<LWYTCPIHOQE> legacyNodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF1B0", Offset = "0x2DADDB0", VA = "0x182DAF1B0", Slot = "26")]
		public AbsoluteNodeId? CTKVZQBQAVW(Id32<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB33A0", Offset = "0x2DB1FA0", VA = "0x182DB33A0", Slot = "27")]
		public long RGHJTBCKNVL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0660", Offset = "0x2DAF260", VA = "0x182DB0660")]
		private void HRLHOYEZQAF(Id128<LWYTCPIHOQE> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE770", Offset = "0x2DAD370", VA = "0x182DAE770", Slot = "32")]
		public IEnumerable<(Id32<JQPVMRMCZNG>, Id32<LWYTCPIHOQE>)> BAFEPZNUSBR(Id32<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF430", Offset = "0x2DAE030", VA = "0x182DAF430")]
		public IEnumerable<VXTUWJBKUSC> DNJAJWRHXKN([In] Id128<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB38C0", Offset = "0x2DB24C0", VA = "0x182DB38C0", Slot = "34")]
		public Id32<AWZVWRTEXTC> SQLSPHUODYU(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<JKFKBVVIBGI> inputIndex)
		{
			return default(Id32<AWZVWRTEXTC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3650", Offset = "0x2DB2250", VA = "0x182DB3650", Slot = "37")]
		public Id32<IEQQYWIVYHH> RSRJBUCZZZR(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<BIMMTVVZQUL> outputIndex)
		{
			return default(Id32<IEQQYWIVYHH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF580", Offset = "0x2DAE180", VA = "0x182DAF580")]
		private VXTUWJBKUSC? DYTGIABQGHE([In] Id128<LWYTCPIHOQE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF2E0", Offset = "0x2DADEE0", VA = "0x182DAF2E0")]
		private VXTUWJBKUSC DFWPBJFBABB([In] Id128<LWYTCPIHOQE> nodeId, OINYKCZIBWN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFC60", Offset = "0x2DAE860", VA = "0x182DAFC60")]
		public OINYKCZIBWN? FJHPYLVBQHC([In] Id128<LWYTCPIHOQE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2F20", Offset = "0x2DB1B20", VA = "0x182DB2F20")]
		public CMFLWIUZKZI? UHBREDZJHNP([In] Id128<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x2DB46D0", Offset = "0x2DB32D0", VA = "0x182DB46D0", Slot = "19")]
		public CMFLWIUZKZI? UHBREDZJHNP(Id32<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x2DB00A0", Offset = "0x2DAECA0", VA = "0x182DB00A0", Slot = "28")]
		public IEnumerable<NewStaticEdge> GIGAVCVOCRR(Id32<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0B40", Offset = "0x2DAF740", VA = "0x182DB0B40", Slot = "29")]
		public bool JKSXCUFRUCD(Id32<FFORBNFDOVK> functionDeclId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x2DB16A0", Offset = "0x2DB02A0", VA = "0x182DB16A0", Slot = "30")]
		public IEnumerable<StableStaticEdge> LZHGMCRDCQT(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0C40", Offset = "0x2DAF840", VA = "0x182DB0C40", Slot = "31")]
		public IEnumerable<StableStaticEdge> JRBEDOFUGNI(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0AC0", Offset = "0x2DAF6C0", VA = "0x182DB0AC0")]
		public Id32<JQPVMRMCZNG> JFZCIWKFMPS([In] Id128<JQPVMRMCZNG> graphId)
		{
			return default(Id32<JQPVMRMCZNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3540", Offset = "0x2DB2140", VA = "0x182DB3540")]
		public Id32<JQPVMRMCZNG>? RSOATTACXAQ([In] Id128<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2FE0", Offset = "0x2DB1BE0", VA = "0x182DB2FE0")]
		private CYUKXICDMVO? PIMGOXPGXKI([In] Id128<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2F20", Offset = "0x2DB1B20", VA = "0x182DB2F20")]
		private CMFLWIUZKZI? OKEFAUAJCTB([In] Id128<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0160", Offset = "0x2DAED60", VA = "0x182DB0160", Slot = "22")]
		public Id32<JQPVMRMCZNG>? GNUYAUTJWDV(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1A70", Offset = "0x2DB0670", VA = "0x182DB1A70", Slot = "41")]
		public Id128<JQPVMRMCZNG> MZVOOTRPOIZ(Id32<JQPVMRMCZNG> graphId)
		{
			return default(Id128<JQPVMRMCZNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF500", Offset = "0x2DAE100", VA = "0x182DAF500", Slot = "42")]
		public Id128<LWYTCPIHOQE> DUQDOTAHAFH(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId)
		{
			return default(Id128<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEF50", Offset = "0x2DADB50", VA = "0x182DAEF50", Slot = "38")]
		public IEnumerable<YTMTLPGRGSJ> CFJHYGTMMHN(RoomVersion a, bool b, bool c, bool d, bool e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3B40", Offset = "0x2DB2740", VA = "0x182DB3B40", Slot = "39")]
		public YTMTLPGRGSJ TGSRHZYWKGO(RoomVersion a, EAPWZEKDOJL b, bool c, bool d, bool e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFDE0", Offset = "0x2DAE9E0", VA = "0x182DAFDE0")]
		public NewStaticEdge GFQUMKAJFPW(Id32<JQPVMRMCZNG> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE820", Offset = "0x2DAD420", VA = "0x182DAE820", Slot = "43")]
		public StableStaticEdge BBASKYDYWJT(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId)
		{
			return default(StableStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x2DB03C0", Offset = "0x2DAEFC0", VA = "0x182DB03C0", Slot = "44")]
		[AsyncStateMachine(typeof(<RequestUngroupBoard>d__76))]
		public Task<Result<None, JGXPLWKAZER>> HNUIDIACQXS(Id32<JQPVMRMCZNG> parentGraphId, Id32<LWYTCPIHOQE> boardNodeId, CircuitsVec3 a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5D70", Offset = "0x2DB4970", VA = "0x182DB5D70", Slot = "45")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoCircuitBoard>d__77))]
		public Task<Result<None, JGXPLWKAZER>> XQVXVSYWEKZ(Id32<JQPVMRMCZNG> parentGraphId, Id128<LWYTCPIHOQE> boardNodeId, List<Id32<LWYTCPIHOQE>> nodeIds, CircuitsVec3 a, CircuitsQuat b, CircuitsVec3 c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0510", Offset = "0x2DAF110", VA = "0x182DB0510", Slot = "48")]
		[AsyncStateMachine(typeof(<RequestMoveToBoard>d__78))]
		public Task<Result<None, JGXPLWKAZER>> HQUMQASFMQC(Id32<JQPVMRMCZNG> parentGraphId, Id128<LWYTCPIHOQE> boardNodeId, List<Id32<LWYTCPIHOQE>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEA50", Offset = "0x2DAD650", VA = "0x182DAEA50", Slot = "49")]
		[AsyncStateMachine(typeof(<RequestSplitFromBoard>d__79))]
		public Task<Result<None, JGXPLWKAZER>> BTVINWMYVXU(Id32<JQPVMRMCZNG> parentGraphId, Id128<LWYTCPIHOQE> boardNodeId, Id32<JQPVMRMCZNG> graphId, List<Id32<LWYTCPIHOQE>> nodeIds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1910", Offset = "0x2DB0510", VA = "0x182DB1910", Slot = "46")]
		public (IReadOnlyDictionary<LegacyInputId, (Id32<CUMWXIQVBDQ>, Id32<GIQEAILWCVY>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<CUMWXIQVBDQ>, Id32<DJLWKSNXJYV>)>) MYOHWIRWZOD(Id128<JQPVMRMCZNG> legacyGraphId, Id32<LWYTCPIHOQE> boardNodeId)
		{
			return default((IReadOnlyDictionary<LegacyInputId, (Id32<CUMWXIQVBDQ>, Id32<GIQEAILWCVY>)>, IReadOnlyDictionary<LegacyOutputId, (Id32<CUMWXIQVBDQ>, Id32<DJLWKSNXJYV>)>));
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4980", Offset = "0x2DB3580", VA = "0x182DB4980", Slot = "47")]
		[AsyncStateMachine(typeof(<RequestGroupNodesIntoObjectBoard>d__81))]
		public Task UYBJIMFJTGZ(Id128<JQPVMRMCZNG> legacyGraphId, Id128<LWYTCPIHOQE> boardNodeId, IReadOnlyList<Id128<LWYTCPIHOQE>> nodeLegacyIds, IReadOnlyDictionary<LegacyInputId, (Id32<CUMWXIQVBDQ>, Id32<GIQEAILWCVY>)> inputMapping, IReadOnlyDictionary<LegacyOutputId, (Id32<CUMWXIQVBDQ>, Id32<DJLWKSNXJYV>)> outputMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6240", Offset = "0x2DB4E40", VA = "0x182DB6240", Slot = "50")]
		public bool YNNUZLDLNVD(Id32<JQPVMRMCZNG> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1620", Offset = "0x2DB0220", VA = "0x182DB1620", Slot = "51")]
		public bool LYCNNQKHWOV(Id32<JQPVMRMCZNG> graphId, Id32<AWZVWRTEXTC> inputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1030", Offset = "0x2DAFC30", VA = "0x182DB1030", Slot = "52")]
		public bool KCTNIVUDGUW(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> outputId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4EE0", Offset = "0x2DB3AE0", VA = "0x182DB4EE0")]
		public Result<YHTFDKLWCND.PrepareTemplateForCloneResult, VOMTLWUOHYQ> ZHEGZRTXIVA([In] YHTFDKLWCND.PrepareTemplateForCloneArgs args)
		{
			return default(Result<YHTFDKLWCND.PrepareTemplateForCloneResult, VOMTLWUOHYQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFA50", Offset = "0x2DAE650", VA = "0x182DAFA50", Slot = "54")]
		[AsyncStateMachine(typeof(<RequestAddEdge>d__95))]
		public Task<Result<None, JGXPLWKAZER>> EGQMAKOFSYQ(Id32<JQPVMRMCZNG> graphId, Id32<IEQQYWIVYHH> srcId, Id32<AWZVWRTEXTC> dstId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3120", Offset = "0x2DB1D20", VA = "0x182DB3120", Slot = "55")]
		[AsyncStateMachine(typeof(<RequestAddNode>d__97))]
		public Task<Result<Id32<LWYTCPIHOQE>, JGXPLWKAZER>> QKCAXAQRHGB(Id32<JQPVMRMCZNG> graphId, Id32<TFITIOWUSRJ> nodeDefId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1120", Offset = "0x2DAFD20", VA = "0x182DB1120", Slot = "56")]
		[AsyncStateMachine(typeof(<RequestAddNodeDesc>d__98))]
		public Task<Result<Id32<CUMWXIQVBDQ>, JGXPLWKAZER>> KGUMIMGFKKY(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1260", Offset = "0x2DAFE60", VA = "0x182DB1260", Slot = "57")]
		public Result<ControlPanelRootData, GOLLTPPMOJR> LTDCCPBBKPI(Id128<JQPVMRMCZNG> graphId, ControlPanelRootData a, CircuitsQuat b)
		{
			return default(Result<ControlPanelRootData, GOLLTPPMOJR>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x2DB39E0", Offset = "0x2DB25E0", VA = "0x182DB39E0", Slot = "58")]
		[AsyncStateMachine(typeof(<RequestRemoveInputPortConnections>d__106))]
		public Task<Result<None, JGXPLWKAZER>> SSVLCPEDRUK(Id128<JQPVMRMCZNG> graphId, Id128<LWYTCPIHOQE> inputNodeId, Id32<CUMWXIQVBDQ> inputPortGroupId, Id32<GIQEAILWCVY> inputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEDF0", Offset = "0x2DAD9F0", VA = "0x182DAEDF0", Slot = "59")]
		[AsyncStateMachine(typeof(<RequestRemoveOutputPortConnections>d__107))]
		public Task<Result<None, JGXPLWKAZER>> CBOCIPNCELL(Id128<JQPVMRMCZNG> graphId, Id128<LWYTCPIHOQE> outputNodeId, Id32<CUMWXIQVBDQ> outputPortGroupId, Id32<DJLWKSNXJYV> outputId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x2DB44D0", Offset = "0x2DB30D0", VA = "0x182DB44D0", Slot = "60")]
		[AsyncStateMachine(typeof(<RequestRemoveNode>d__109))]
		public Task<Result<None, JGXPLWKAZER>> UAERFJANUNI(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x2DB06F0", Offset = "0x2DAF2F0", VA = "0x182DB06F0", Slot = "61")]
		[AsyncStateMachine(typeof(<RequestSpawnTemplate>d__115))]
		public Task<Result<IEnumerable<Id128<LWYTCPIHOQE>>, JGXPLWKAZER>> IATHKKJRYLZ(Id128<JQPVMRMCZNG> intoGraphId, CircuitTemplateRootData a, IEnumerable<ABLNPBVPOUZ> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x2DB62B0", Offset = "0x2DB4EB0", VA = "0x182DB62B0", Slot = "62")]
		public CircuitsData YPGYTTVGURH()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0850", Offset = "0x2DAF450", VA = "0x182DB0850", Slot = "63")]
		public CircuitsData INYYROPZIAI()
		{
			return default(CircuitsData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x2DB63D0", Offset = "0x2DB4FD0", VA = "0x182DB63D0", Slot = "66")]
		public CircuitsTemplateData YWCYAKNWOOX(TemplateSerializationReason a, Id32<JQPVMRMCZNG> sourceGraphId, IEnumerable<Id128<JQPVMRMCZNG>> graphIds, IEnumerable<Id128<LWYTCPIHOQE>> nodeIds, ISet<Id128<CRFUMRQJTMA>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5FB0", Offset = "0x2DB4BB0", VA = "0x182DB5FB0")]
		private CircuitsTemplateData XXZOPDTSMPE(TemplateSerializationReason a, Id32<JQPVMRMCZNG> sourceGraphId, IEnumerable<Id128<JQPVMRMCZNG>> graphIds, IEnumerable<Id128<LWYTCPIHOQE>> nodeIds, ISet<Id128<CRFUMRQJTMA>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x2DADDE0", Offset = "0x2DAC9E0", VA = "0x182DADDE0", Slot = "64")]
		public CircuitsTemplateData ALOFFAUJYNA(TemplateSerializationReason a, Id32<JQPVMRMCZNG> sourceGraphId, IEnumerable<Id128<LWYTCPIHOQE>> nodeIds, IEnumerable<ABLNPBVPOUZ> b, ISet<Id128<CRFUMRQJTMA>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE060", Offset = "0x2DACC60", VA = "0x182DAE060", Slot = "65")]
		public CircuitsTemplateData ALOFFAUJYNA(TemplateSerializationReason a, Id32<JQPVMRMCZNG> sourceGraphId, IEnumerable<Id32<LWYTCPIHOQE>> nodeIds, IEnumerable<ABLNPBVPOUZ> b, ISet<Id128<CRFUMRQJTMA>>? allPrefabIds)
		{
			return default(CircuitsTemplateData);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF680", Offset = "0x2DAE280", VA = "0x182DAF680")]
		private static IEnumerable<Id128<JQPVMRMCZNG>> EARIBOISDNY(IEnumerable<ABLNPBVPOUZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3E30", Offset = "0x2DB2A30", VA = "0x182DB3E30")]
		private IEnumerable<Id128<LWYTCPIHOQE>> TLLTUGLXZQE(IEnumerable<ABLNPBVPOUZ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5C70", Offset = "0x2DB4870", VA = "0x182DB5C70", Slot = "67")]
		public List<YQTIKHJWKGT> XHUBSMRQBKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2860", Offset = "0x2DB1460", VA = "0x182DB2860")]
		public (List<YQTIKHJWKGT>, bool) NWSTHOJXXDM([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, EZLAWBCIVGN b, JUZDWRULVVJ c)
		{
			return default((List<YQTIKHJWKGT>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFFD0", Offset = "0x2DAEBD0", VA = "0x182DAFFD0", Slot = "69")]
		public bool GGRROSIUHPJ(Id32<JQPVMRMCZNG> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x2DB36E0", Offset = "0x2DB22E0", VA = "0x182DB36E0", Slot = "70")]
		public bool SBGJLGETLPL(Id32<JQPVMRMCZNG> graphId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3280", Offset = "0x2DB1E80", VA = "0x182DB3280")]
		internal void QWUOXKDSGYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4920", Offset = "0x2DB3520", VA = "0x182DB4920")]
		internal Task UXKHIGGMZHW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x2DB1AE0", Offset = "0x2DB06E0", VA = "0x182DB1AE0", Slot = "71")]
		public Result<Id32<IEQQYWIVYHH>?, JGXPLWKAZER> NPECMLSIDAA(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<AWZVWRTEXTC> inputId)
		{
			return default(Result<Id32<IEQQYWIVYHH>?, JGXPLWKAZER>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4F10", Offset = "0x2DB3B10", VA = "0x182DB4F10", Slot = "72")]
		public Result<Id32<AWZVWRTEXTC>?, JGXPLWKAZER> WKCXKHNNFCE(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<IEQQYWIVYHH> outputId)
		{
			return default(Result<Id32<AWZVWRTEXTC>?, JGXPLWKAZER>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x2DB45E0", Offset = "0x2DB31E0", VA = "0x182DB45E0", Slot = "73")]
		[AsyncStateMachine(typeof(<RequestDeleteAllNodes>d__135))]
		public Task<Result<None, JGXPLWKAZER>> UCXZIGIAPGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4C00", Offset = "0x2DB3800", VA = "0x182DB4C00", Slot = "74")]
		[AsyncStateMachine(typeof(<RequestSetNodeName>d__136))]
		public Task<Result<None, JGXPLWKAZER>> VADXINSBSWB(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4DB0", Offset = "0x2DB39B0", VA = "0x182DB4DB0", Slot = "75")]
		public Id32<LWYTCPIHOQE>? VWZANAJDXDF(Id32<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4AD0", Offset = "0x2DB36D0", VA = "0x182DB4AD0", Slot = "76")]
		public Id32<LWYTCPIHOQE>? UZAGHLZJIQQ(Id32<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0310", Offset = "0x2DAEF10", VA = "0x182DB0310", Slot = "77")]
		public int GWEDMGYHSZE(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4330", Offset = "0x2DB2F30", VA = "0x182DB4330", Slot = "78")]
		public int TOEXOQHMOTF(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF040", Offset = "0x2DADC40", VA = "0x182DAF040", Slot = "79")]
		public int CMBIWMTDQNG(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<VPKCJSHTFFF> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2DAE170", Offset = "0x2DACD70", VA = "0x182DAE170", Slot = "80")]
		public int AUUGXRTHDDI(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<VPKCJSHTFFF> inputDefId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3400", Offset = "0x2DB2000", VA = "0x182DB3400", Slot = "81")]
		[AsyncStateMachine(typeof(<RequestAddInputPort>d__144))]
		public Task<Result<None, JGXPLWKAZER>> RNOKRQVKVIE(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<VPKCJSHTFFF> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5B30", Offset = "0x2DB4730", VA = "0x182DB5B30", Slot = "82")]
		[AsyncStateMachine(typeof(<RequestRemoveLastInputPort>d__145))]
		public Task<Result<None, JGXPLWKAZER>> XFWVHKKTPIV(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, Id32<VPKCJSHTFFF> inputDefId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFB80", Offset = "0x2DAE780", VA = "0x182DAFB80", Slot = "83")]
		public int EZSBKBAEXQY(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4760", Offset = "0x2DB3360", VA = "0x182DB4760", Slot = "84")]
		[AsyncStateMachine(typeof(<RequestSetVariableHomeValue>d__148))]
		public Task<Result<None, JGXPLWKAZER>> UNAYXVHWBWG(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEC90", Offset = "0x2DAD890", VA = "0x182DAEC90", Slot = "85")]
		[AsyncStateMachine(typeof(<RequestSetNodeLocalTransform>d__149))]
		public Task<Result<None, JGXPLWKAZER>> BZUICACSOOX(Id32<JQPVMRMCZNG> graphId, Id32<LWYTCPIHOQE> nodeId, CircuitsVec3 a, CircuitsQuat b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0970", Offset = "0x2DAF570", VA = "0x182DB0970", Slot = "91")]
		public IEnumerable<Id32<XXUTQJTARJE>> IPQLLIIVYIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4D40", Offset = "0x2DB3940", VA = "0x182DB4D40", Slot = "92")]
		public string? VGTXRGWTFBE(Id32<XXUTQJTARJE> behaviorId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFCF0", Offset = "0x2DAE8F0", VA = "0x182DAFCF0", Slot = "7")]
		private bool FLLQJCDNXZO(Id32<JQPVMRMCZNG> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2F20", Offset = "0x2DB1B20", VA = "0x182DB2F20", Slot = "18")]
		private CMFLWIUZKZI XSWHAJOYKAR([In] Id128<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2FD0", Offset = "0x2DB1BD0", VA = "0x182DB2FD0", Slot = "20")]
		private Id32<JQPVMRMCZNG> PFIWHHGPHYY([In] Id128<JQPVMRMCZNG> graphId)
		{
			return default(Id32<JQPVMRMCZNG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3540", Offset = "0x2DB2140", VA = "0x182DB3540", Slot = "21")]
		private Id32<JQPVMRMCZNG>? SKEFZYOUOAY([In] Id128<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB09D0", Offset = "0x2DAF5D0", VA = "0x182DB09D0", Slot = "23")]
		private VXTUWJBKUSC ITBEDFFIKYT([In] Id128<LWYTCPIHOQE> nodeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x2DB30A0", Offset = "0x2DB1CA0", VA = "0x182DB30A0", Slot = "25")]
		private Id32<LWYTCPIHOQE> PZSKAHGVVCG(Id32<JQPVMRMCZNG> graphId, [In] Id128<LWYTCPIHOQE> legacyNodeId)
		{
			return default(Id32<LWYTCPIHOQE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x2DAF430", Offset = "0x2DAE030", VA = "0x182DAF430", Slot = "33")]
		private IEnumerable<VXTUWJBKUSC> MHAFSSOECNP([In] Id128<JQPVMRMCZNG> graphId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x2DAFDE0", Offset = "0x2DAE9E0", VA = "0x182DAFDE0", Slot = "40")]
		private NewStaticEdge RUMILNLTYSQ(Id32<JQPVMRMCZNG> graphId, [In] StableStaticEdge stableEdge)
		{
			return default(NewStaticEdge);
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2DB4EE0", Offset = "0x2DB3AE0", VA = "0x182DB4EE0", Slot = "53")]
		private Result<YHTFDKLWCND.PrepareTemplateForCloneResult, VOMTLWUOHYQ> WKBUAEDPGOK([In] YHTFDKLWCND.PrepareTemplateForCloneArgs args)
		{
			return default(Result<YHTFDKLWCND.PrepareTemplateForCloneResult, VOMTLWUOHYQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x2DB2800", Offset = "0x2DB1400", VA = "0x182DB2800", Slot = "68")]
		private (List<YQTIKHJWKGT>, bool) NSAZANCOISW([In] CircuitsValidationConfig validationConfig, string a, [In] LogDelegates logSys, EZLAWBCIVGN b, JUZDWRULVVJ c)
		{
			return default((List<YQTIKHJWKGT>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5A40", Offset = "0x2DB4640", VA = "0x182DB5A40")]
		[CompilerGenerated]
		private VXTUWJBKUSC WXMBXOWNTDP(OINYKCZIBWN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x2DB0BD0", Offset = "0x2DAF7D0", VA = "0x182DB0BD0")]
		[CompilerGenerated]
		private UXYQJCPNHRA JPTIHLWQLSZ(IDLCASSILBG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEBB0", Offset = "0x2DAD7B0", VA = "0x182DAEBB0")]
		[CompilerGenerated]
		private OINYKCZIBWN BXRAAXISYQU(Id128<LWYTCPIHOQE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x2DAEC20", Offset = "0x2DAD820", VA = "0x182DAEC20")]
		[CompilerGenerated]
		private CYUKXICDMVO BXWGYECQICD(Id128<JQPVMRMCZNG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6160", Offset = "0x2DB4D60", VA = "0x182DB6160")]
		[CompilerGenerated]
		private OINYKCZIBWN YJBWBEDXYAA(Id128<LWYTCPIHOQE> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB61D0", Offset = "0x2DB4DD0", VA = "0x182DB61D0")]
		[CompilerGenerated]
		private CYUKXICDMVO YJHCYKXVHLJ(Id128<JQPVMRMCZNG> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	public sealed class UXYQJCPNHRA : YTMTLPGRGSJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[CompilerGenerated]
		private struct <AddInputDef>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public AsyncTaskMethodBuilder<Result<Id32<VPKCJSHTFFF>, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public UXYQJCPNHRA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			public Id128<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public Id128<LWYTCPIHOQE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public Id32<CUMWXIQVBDQ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			private TaskAwaiter<Result<Id32<VPKCJSHTFFF>, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x2DB7730", Offset = "0x2DB6330", VA = "0x182DB7730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x2DB79B0", Offset = "0x2DB65B0", VA = "0x182DB79B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		[CompilerGenerated]
		private struct <AddOutputDef>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public AsyncTaskMethodBuilder<Result<Id32<TIEJMITYOHO>, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public UXYQJCPNHRA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public Id128<JQPVMRMCZNG> graphId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public Id128<LWYTCPIHOQE> nodeId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public Id32<CUMWXIQVBDQ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			private TaskAwaiter<Result<Id32<TIEJMITYOHO>, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x2DB7A20", Offset = "0x2DB6620", VA = "0x182DB7A20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0x2DB7CA0", Offset = "0x2DB68A0", VA = "0x182DB7CA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private readonly IDLCASSILBG PZPUABVTUMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private readonly AGTBEXVKYHM JDQPJOGSLRG;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public TypeKey JBHNPJLELII
		{
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public string MPOTAIMFXOO
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x2DABA80", Offset = "0x2DAA680", VA = "0x182DABA80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public IDLCASSILBG IDLCASSILBG
		{
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2DBE130", Offset = "0x2DBCD30", VA = "0x182DBE130")]
		public UXYQJCPNHRA(IDLCASSILBG a, AGTBEXVKYHM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x2DBDFC0", Offset = "0x2DBCBC0", VA = "0x182DBDFC0", Slot = "6")]
		[AsyncStateMachine(typeof(<AddInputDef>d__10))]
		public Task<Result<Id32<VPKCJSHTFFF>, JGXPLWKAZER>> NCCVHRRQDFR(Id128<JQPVMRMCZNG> graphId, Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2DBDE50", Offset = "0x2DBCA50", VA = "0x182DBDE50", Slot = "7")]
		[AsyncStateMachine(typeof(<AddOutputDef>d__11))]
		public Task<Result<Id32<TIEJMITYOHO>, JGXPLWKAZER>> KHFBDWEETNS(Id128<JQPVMRMCZNG> graphId, Id128<LWYTCPIHOQE> nodeId, Id32<CUMWXIQVBDQ> portGroupId, string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	public sealed class CQHASNVOJQY : OHIRIUFGIUC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private readonly IDLCASSILBG OEGDIYQRJYQ;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private static readonly HashSet<IDLCASSILBG> ENCAAXGTYSS;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private static readonly HashSet<IDLCASSILBG> NOMUPGZKWGH;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private static readonly HashSet<IDLCASSILBG> TVJCRLYARCO;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public IDLCASSILBG JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public TypeKey Key
		{
			[Cpp2IlInjected.Token(Token = "0x60006DA")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD360", Offset = "0x2DABF60", VA = "0x182DAD360", Slot = "6")]
			get
			{
				return default(TypeKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool IsArray
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD350", Offset = "0x2DABF50", VA = "0x182DAD350", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool SupportsDisplayValue
		{
			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD3B0", Offset = "0x2DABFB0", VA = "0x182DAD3B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public bool InputValueAsText
		{
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD2D0", Offset = "0x2DABED0", VA = "0x182DAD2D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB680", Offset = "0x2DAA280", VA = "0x182DAB680")]
		public bool OLZFYBCEPRL(string a, [Out] CircuitSignal b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public CQHASNVOJQY(IDLCASSILBG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB8F0", Offset = "0x2DAA4F0", VA = "0x182DAB8F0")]
		internal static TypeKey QEDXWEHWPWC(IDLCASSILBG a)
		{
			return default(TypeKey);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2DABA80", Offset = "0x2DAA680", VA = "0x182DABA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Circuits.All.RecRoom.Injection
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	public readonly struct ActionDeps : CKZYRSCPJVN.ANUMCWZZTHU<FJCTCRTIJZZ, None>
	{
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB320", Offset = "0x2DA9F20", VA = "0x182DAB320", Slot = "4")]
		public int WUJDWWEIQFW(None a, FJCTCRTIJZZ b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB2D0", Offset = "0x2DA9ED0", VA = "0x182DAB2D0", Slot = "5")]
		public FJCTCRTIJZZ MNCQESCFBTR(None a, FJCTCRTIJZZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB260", Offset = "0x2DA9E60", VA = "0x182DAB260", Slot = "6")]
		public FJCTCRTIJZZ DRLFOLBZPJS(None a, FJCTCRTIJZZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB360", Offset = "0x2DA9F60", VA = "0x182DAB360", Slot = "7")]
		public IReadOnlyList<FJCTCRTIJZZ> YUZXGRDATYC(None a, FJCTCRTIJZZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB230", Offset = "0x2DA9E30", VA = "0x182DAB230", Slot = "8")]
		public FJCTCRTIJZZ[] BTSIDZFQYPX(None a, FJCTCRTIJZZ b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB2B0", Offset = "0x2DA9EB0", VA = "0x182DAB2B0", Slot = "9")]
		public bool LQITHRXJZTM(None a, FJCTCRTIJZZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB290", Offset = "0x2DA9E90", VA = "0x182DAB290", Slot = "10")]
		public bool JERHRNSQHFW(None a, FJCTCRTIJZZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB2E0", Offset = "0x2DA9EE0", VA = "0x182DAB2E0", Slot = "11")]
		public bool NPXSWSBYUXM(None a, FJCTCRTIJZZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB240", Offset = "0x2DA9E40", VA = "0x182DAB240", Slot = "12")]
		public bool BYCWIHPYCUU(None a, FJCTCRTIJZZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB300", Offset = "0x2DA9F00", VA = "0x182DAB300", Slot = "13")]
		public bool WJMUFYLOCLU(None a, FJCTCRTIJZZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB340", Offset = "0x2DA9F40", VA = "0x182DAB340", Slot = "14")]
		public bool YJZHIAOBRLB(None a, FJCTCRTIJZZ b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	public abstract class CIMIKXVTSVD : HJGLKQKSWYJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public BBDQXSJXACB.ZWBQGEKCHWS FGZLEXXGFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x2DAB5E0", Offset = "0x2DAA1E0", VA = "0x182DAB5E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public abstract IYSCTJMEFHV.ZWBQGEKCHWS HQSTJLTFMHH
		{
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public abstract QBUZPCMMQEU.ZWBQGEKCHWS HLOMVPQQCOO
		{
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public abstract QGHELZNSXBF.ZWBQGEKCHWS QQJGBXLBDMV
		{
			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		public TWZYVPJPRWX.MQBQDZFUSGT<ActionKind, FJCTCRTIJZZ, QBUZPCMMQEU> VIEMKMIYKDP
		{
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x2DAB630", Offset = "0x2DAA230", VA = "0x182DAB630", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public abstract CV2Request.ZWBQGEKCHWS ALRWSWUTPXD
		{
			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public abstract HQZRPDRLYMD YOEBAIBRSBI
		{
			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public abstract SIAQCCPWYWO SVTYZEGMKLR
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public abstract LPPYWEGICFS FCFVUKHTKAD
		{
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract HQZHXJLGZCY UAQJIWJGAYH
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public abstract ZWOKKWUVOWC VJNALATDEKR
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected CIMIKXVTSVD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	public sealed class CHZSZEMMJIV : PHAFMRWLSOP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		[CompilerGenerated]
		private struct <Multi>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			public AsyncTaskMethodBuilder<Result<MultiResult, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			public IReadOnlyList<FJCTCRTIJZZ> actions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			public CHZSZEMMJIV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006FD")]
			[Cpp2IlInjected.Address(RVA = "0x2DB82D0", Offset = "0x2DB6ED0", VA = "0x182DB82D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0x2DB86F0", Offset = "0x2DB72F0", VA = "0x182DB86F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[CompilerGenerated]
		private struct <Request>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			public AsyncTaskMethodBuilder<Result<object, JGXPLWKAZER>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			public CHZSZEMMJIV <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			public FJCTCRTIJZZ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000420")]
			private TaskAwaiter<Result<object, JGXPLWKAZER>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006FF")]
			[Cpp2IlInjected.Address(RVA = "0x2DBD3D0", Offset = "0x2DBBFD0", VA = "0x182DBD3D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0x2DBD5E0", Offset = "0x2DBC1E0", VA = "0x182DBD5E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private readonly GGQWPRURVBI IGDFOJSGXMQ;

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public CHZSZEMMJIV(GGQWPRURVBI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB380", Offset = "0x2DA9F80", VA = "0x182DAB380")]
		[AsyncStateMachine(typeof(<Request>d__2))]
		private Task<Result<object, JGXPLWKAZER>> JYDCJYGVPCK(FJCTCRTIJZZ a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x2DAB4B0", Offset = "0x2DAA0B0", VA = "0x182DAB4B0", Slot = "4")]
		[AsyncStateMachine(typeof(<Multi>d__3))]
		public Task<Result<MultiResult, JGXPLWKAZER>> YDGPJMUPWVQ(IReadOnlyList<FJCTCRTIJZZ> a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	public struct PartialActionReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		internal PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, FJCTCRTIJZZ, PartialActionReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private PartialActionReassembly([In] PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, FJCTCRTIJZZ, PartialActionReassemblyDeps> partialActionReassembly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6D40", Offset = "0x2DB5940", VA = "0x182DB6D40")]
		public static PartialActionReassembly New()
		{
			return default(PartialActionReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	public static class GRKGTBGJHMU
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390")]
		public static PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, FJCTCRTIJZZ, PartialActionReassemblyDeps> YXACYNUPMAX(this PartialActionReassembly a)
		{
			return default(PartialActionReassembly<PartialActionPayload, Id128<PartialActionPayload.M>, FJCTCRTIJZZ, PartialActionReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	public struct PartialActionReassemblyDeps : PTFHOSMCVOJ.MQBQDZFUSGT<PartialActionPayload, Id128<PartialActionPayload.M>, FJCTCRTIJZZ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6B50", Offset = "0x2DB5750", VA = "0x182DB6B50", Slot = "7")]
		public FJCTCRTIJZZ XRCOQPQXOIN(PartialActionPayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x136FAC0", Offset = "0x136E6C0", VA = "0x18136FAC0")]
		public Id128<PartialActionPayload.M> FHZTJNEMSMZ([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x1387AB0", Offset = "0x13866B0", VA = "0x181387AB0")]
		public int XWUMJQQQCAD([In] PartialActionPayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6B40", Offset = "0x2DB5740", VA = "0x182DB6B40")]
		public int CPOGEMODEWM([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x1387AB0", Offset = "0x13866B0", VA = "0x181387AB0", Slot = "4")]
		private int UCCBILIENNH([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6B40", Offset = "0x2DB5740", VA = "0x182DB6B40", Slot = "5")]
		private int NAZNNNUVAFI([In] PartialActionPayload partialAction)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x136FAC0", Offset = "0x136E6C0", VA = "0x18136FAC0", Slot = "6")]
		private Id128<PartialActionPayload.M> SUOTDIGWAIT([In] PartialActionPayload partialAction)
		{
			return default(Id128<PartialActionPayload.M>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	public struct SnapshotReassembly
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		internal SnapshotReassembly<PartialInitializePayload, FJCTCRTIJZZ, SnapshotReassemblyDeps> _impl;

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x13722D0", Offset = "0x1370ED0", VA = "0x1813722D0")]
		private SnapshotReassembly([In] SnapshotReassembly<PartialInitializePayload, FJCTCRTIJZZ, SnapshotReassemblyDeps> snapshotReassambly)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6F90", Offset = "0x2DB5B90", VA = "0x182DB6F90")]
		public static SnapshotReassembly New()
		{
			return default(SnapshotReassembly);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	public static class VSDKGSGSWUX
	{
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xE7E390", Offset = "0xE7CF90", VA = "0x180E7E390")]
		public static SnapshotReassembly<PartialInitializePayload, FJCTCRTIJZZ, SnapshotReassemblyDeps> YXACYNUPMAX(this SnapshotReassembly a)
		{
			return default(SnapshotReassembly<PartialInitializePayload, FJCTCRTIJZZ, SnapshotReassemblyDeps>);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	public struct SnapshotReassemblyDeps : NOXVGYFJVAA.MPWJGSLXIVK<PartialInitializePayload, FJCTCRTIJZZ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x1542A70", Offset = "0x1541670", VA = "0x181542A70")]
		public int TMCJQSHGFUN([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6DA0", Offset = "0x2DB59A0", VA = "0x182DB6DA0", Slot = "5")]
		public FJCTCRTIJZZ RNFCKWGOVBJ(PartialInitializePayload[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x1542A70", Offset = "0x1541670", VA = "0x181542A70", Slot = "4")]
		private int SVQJXXWRQYX([In] PartialInitializePayload partialSnapshot)
		{
			return default(int);
		}
	}
}
namespace Circuits.All.RecRoom.Error
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	public class JJZRVSFJNMZ : UTITDXZLKVK, VOMTLWUOHYQ, JGXPLWKAZER, GOLLTPPMOJR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private readonly GOLLTPPMOJR? UKWYLHZLGNL;

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public PrepareTemplateForCloneErrKind IXVPXZPOTQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(PrepareTemplateForCloneErrKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public override GOLLTPPMOJR? WEKJUCAYMKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000719")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x2DADC40", Offset = "0x2DAC840", VA = "0x182DADC40", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x2DADDA0", Offset = "0x2DAC9A0", VA = "0x182DADDA0")]
		private JJZRVSFJNMZ(PrepareTemplateForCloneErrKind a, GOLLTPPMOJR? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x2DADB70", Offset = "0x2DAC770", VA = "0x182DADB70")]
		public static JJZRVSFJNMZ AMCELRMXIER(GOLLTPPMOJR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x2DADD40", Offset = "0x2DAC940", VA = "0x182DADD40")]
		public static JJZRVSFJNMZ NXPVCJKDCJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x2DADBE0", Offset = "0x2DAC7E0", VA = "0x182DADBE0")]
		public static JJZRVSFJNMZ AYKTYAFYVSD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	public static class ZRYOMAYYTJW
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x41F4230", Offset = "0x41F2E30", VA = "0x1841F4230")]
		public static Result<TOk, VOMTLWUOHYQ> ZQAKEGAROYG<TOk>([In] this Result<TOk, VOMTLWUOHYQ> self, GOLLTPPMOJR a) where TOk : notnull
		{
			return default(Result<TOk, VOMTLWUOHYQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x41F4060", Offset = "0x41F2C60", VA = "0x1841F4060")]
		public static Result<a?, VOMTLWUOHYQ?> IVAPWIATTYY<a>([In] this Result<a, VOMTLWUOHYQ> self)
		{
			return default(Result<a, VOMTLWUOHYQ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x41F41B0", Offset = "0x41F2DB0", VA = "0x1841F41B0")]
		public static Result<b?, VOMTLWUOHYQ?> RMFLTQGHBJA<b>([In] this Result<b, VOMTLWUOHYQ> self)
		{
			return default(Result<b, VOMTLWUOHYQ>);
		}
	}
}
namespace Circuits.All.RecRoom.Dependencies
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public interface HQZRPDRLYMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool SXTVIADDXIF([In] Result<None, GOLLTPPMOJR> result);
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	public static class EQSERCBOHCZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x3ADCBD0", Offset = "0x3ADB7D0", VA = "0x183ADCBD0")]
		public static bool SXTVIADDXIF<TOk, TErr>(this HQZRPDRLYMD a, [In] Result<TOk, TErr> result) where TOk : notnull where TErr : notnull, GOLLTPPMOJR
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	public interface SIAQCCPWYWO
	{
		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		EBUYLMQOMBA CANTJJXMVKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	public interface LPPYWEGICFS
	{
		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CircuitsColor MYBJKXOLEQF(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	public interface TVEFEGBSGUJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	public interface DVSTOKFWFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(Slot = "0")]
		STGUBIHCUSI? RWCCLNVHJWP(Id32<CUMWXIQVBDQ> portGroupId);
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public interface UPLRCHSECDE
	{
		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	public interface STGUBIHCUSI
	{
		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		UPLRCHSECDE? ABYZSVIXHPD(Id32<VPKCJSHTFFF> inputDefId);

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TVEFEGBSGUJ? CHYUHZCHRPG(Id32<TIEJMITYOHO> outputDefId);
	}
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	public interface HQZHXJLGZCY
	{
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<bool> VCNVGRVBWIS(string a, string b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	public interface ZWOKKWUVOWC
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DVSTOKFWFDA? EGVDGHBJMMD([In] Id128<EPXTWKGOJAA> nodeDefId);
	}
}
namespace Circuits.All.RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	public sealed class TQUCDOZTNIR
	{
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct Diagnostic
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public int Index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public CircuitRootData? BaseState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CircuitRootData? FinalState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public readonly List<FJCTCRTIJZZ> Actions;

			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD580", Offset = "0x2DAC180", VA = "0x182DAD580")]
			private Diagnostic(int index, CircuitRootData? baseState, CircuitRootData? finalState, List<FJCTCRTIJZZ> actions)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0x2DAD4D0", Offset = "0x2DAC0D0", VA = "0x182DAD4D0")]
			public static Diagnostic New()
			{
				return default(Diagnostic);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private readonly COZUKCDKNIS<Diagnostic> IYQVGKWANEL;

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		public static TQUCDOZTNIR CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x2DB7490", Offset = "0x2DB6090", VA = "0x182DB7490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		public bool QKVSUAUGCJR
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0xBF7010", Offset = "0xBF5C10", VA = "0x180BF7010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x2DB74E0", Offset = "0x2DB60E0", VA = "0x182DB74E0")]
		public void WGJCQRRSTEG(CKCMJRRVCXJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0x2DB6FF0", Offset = "0x2DB5BF0", VA = "0x182DB6FF0")]
		public void FFOKFJDRXSP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2DB72D0", Offset = "0x2DB5ED0", VA = "0x182DB72D0")]
		private static string? MNROXJRVGNV([In] Diagnostic diagnostic)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x2DB7690", Offset = "0x2DB6290", VA = "0x182DB7690")]
		public TQUCDOZTNIR()
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
