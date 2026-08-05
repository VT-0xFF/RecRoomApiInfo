using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.NetSystem;
using Circuits.Static.Mock.Core.NetSystem;
using Circuits.Static.RecRoom.Dependencies;
using Circuits.Static.RecRoom.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6C60", Offset = "0x2BC5660", VA = "0x182BC6C60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class KLPRZZNRKZU<a, b, c, d, e, f, g, h> : IDisposable where a : notnull where b : notnull where c : notnull where d : notnull, DFCGLAFPUYG.WHVOVQHCERL<a, b> where e : notnull, DFCGLAFPUYG.STZNCVHKQZI<a, c> where f : notnull, DFCGLAFPUYG.YKCEPJNVAWP<a, g> where g : notnull where h : notnull, DFCGLAFPUYG.ZFCLKDKZCRS<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		internal sealed class GXWCFSPOAEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			internal int? JZIBXTMAMKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			internal readonly List<Func<Task>> ECKGVVEPKUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			internal bool NYVZPBIOKXM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			internal readonly List<Func<Task>> UJIJVOXWCAT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			internal bool CEGCEOVBEOW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			internal a[]? JXMCICQPLEW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			internal readonly JUSAZMDMCXI<a, b, c, d, e, f, g, h> DFCGLAFPUYG;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			internal bool CUCPVUOWWDL
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x6509110", Offset = "0x6507B10", VA = "0x186509110")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x65091B0", Offset = "0x6507BB0", VA = "0x1865091B0")]
			public GXWCFSPOAEI(int? a, List<Func<Task>> b, bool c, List<Func<Task>> d, bool e, a[]? pausedSnapshot, JUSAZMDMCXI<a, b, c, d, e, f, g, h> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6508CC0", Offset = "0x65076C0", VA = "0x186508CC0")]
			public static KLPRZZNRKZU<a, b, c, d, e, f, g, h>.GXWCFSPOAEI New(h deps)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class JYJCOEDILOT
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public JYJCOEDILOT <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				private TaskCompletionSource<Result<object?, RYUTMMKYXMA>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				private TaskAwaiter<Result<object, RYUTMMKYXMA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x41EEF80", Offset = "0x41ED980", VA = "0x1841EEF80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x41EF360", Offset = "0x41EDD60", VA = "0x1841EF360", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public GXWCFSPOAEI WZHCUQAAXQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public g XBKNLMWAWOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public b CASZKVFJOKZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Id32<QEBRWUBFUFW> JHBIYOTNPMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public bool QONESOYRFGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public TaskCompletionSource<Result<object?, RYUTMMKYXMA>> KHOOTBXGWFU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public a LVTEAHSZRWT;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public JYJCOEDILOT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67DA9E0", Offset = "0x67D93E0", VA = "0x1867DA9E0")]
			[AsyncStateMachine(typeof(KLPRZZNRKZU<, , , , , , , >.JYJCOEDILOT.<<SendActionToAll>b__0>d))]
			internal Task TYCJAOOCQWS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class XTRIBDTADZK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private struct <<ReceiveAction>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public XTRIBDTADZK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private TaskCompletionSource<Result<object, RYUTMMKYXMA>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				private TaskAwaiter<Result<object, RYUTMMKYXMA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x41E9830", Offset = "0x41E8230", VA = "0x1841E9830", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x41EA360", Offset = "0x41E8D60", VA = "0x1841EA360", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public GXWCFSPOAEI WZHCUQAAXQX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public g XBKNLMWAWOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public b KGLZCWSJSOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public c CYONCLROSMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Id32<QEBRWUBFUFW> JHBIYOTNPMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public a LCQPVBNBQTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public TaskCompletionSource<Result<object, RYUTMMKYXMA>> KHOOTBXGWFU;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public XTRIBDTADZK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x50CBF20", Offset = "0x50CA920", VA = "0x1850CBF20")]
			[AsyncStateMachine(typeof(KLPRZZNRKZU<, , , , , , , >.XTRIBDTADZK.<<ReceiveAction>b__0>d))]
			internal Task AIGQURAVBWL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAField<QEBRWUBFUFW, GXWCFSPOAEI> RXQTNWPVFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<CachedAction<a>> IDIMQLUSMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly int LLNQPWUECIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly int BXPMXOQBLUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly int XMUYGOEDLTP;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68FF510", Offset = "0x68FDF10", VA = "0x1868FF510")]
		public KLPRZZNRKZU(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68FC780", Offset = "0x68FB180", VA = "0x1868FC780", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68FEB50", Offset = "0x68FD550", VA = "0x1868FEB50")]
		public void OMUFVTCAFLQ(Id32<QEBRWUBFUFW> clientId, h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x68FEBC0", Offset = "0x68FD5C0", VA = "0x1868FEBC0")]
		public void UGJDDZFOSBQ(Id32<QEBRWUBFUFW> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68FD3C0", Offset = "0x68FBDC0", VA = "0x1868FD3C0")]
		public void LLLWOQZUJWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68FD430", Offset = "0x68FBE30", VA = "0x1868FD430")]
		public Task<Result<object, RYUTMMKYXMA>> LWYLDUSLRGQ(g a, [In] SOAId32<QEBRWUBFUFW> clientIds, [In] SOAField<QEBRWUBFUFW, b> clients, [In] SOAField<QEBRWUBFUFW, c> receivers, Id32<QEBRWUBFUFW> senderId, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68FD770", Offset = "0x68FC170", VA = "0x1868FD770")]
		public Task<Result<object, RYUTMMKYXMA>> LWYLDUSLRGQ(g a, b b, Id32<QEBRWUBFUFW> senderId, a c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68FC7A0", Offset = "0x68FB1A0", VA = "0x1868FC7A0")]
		public Task<Result<object, RYUTMMKYXMA>> IQOLMAAGTUX(g a, b b, c c, Id32<QEBRWUBFUFW> receiverId, Id32<QEBRWUBFUFW> senderId, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68FEC70", Offset = "0x68FD670", VA = "0x1868FEC70")]
		public Task VKEYNOPKXJP(g a, b b, c c, Id32<QEBRWUBFUFW> receiverId)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Mock.Core.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal readonly struct CachedAction<TAction> where TAction : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly Id32<QEBRWUBFUFW> ActorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly TAction Action;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x19B2B90", Offset = "0x19B1590", VA = "0x1819B2B90")]
		public CachedAction(Id32<QEBRWUBFUFW> actorId, TAction action)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class IGGKAMOSIWY
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B82CB0", Offset = "0x3B816B0", VA = "0x183B82CB0")]
		public static CachedAction<TAction> New<TAction>(Id32<QEBRWUBFUFW> actorId, TAction action) where TAction : notnull
		{
			return default(CachedAction<TAction>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class FZBXDZLWBIS<a, b> : ISJHRHKEWBX where a : notnull where b : notnull, GXWCFSPOAEI.ZFMZEQYTVOK<a>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <SendActionToAll>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<Result<object?, RYUTMMKYXMA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public FZBXDZLWBIS<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public SYXPYTMUMKS action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TaskAwaiter<Result<object?, RYUTMMKYXMA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6DB80A0", Offset = "0x6DB6AA0", VA = "0x186DB80A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8830", Offset = "0x6DB7230", VA = "0x186DB8830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly b ANTAOVGZRYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly a EYQJGPXKOQR;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<QEBRWUBFUFW> HGMEIUADVSR
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD1B530", Offset = "0xD19F30", VA = "0x180D1B530")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QEBRWUBFUFW>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51A09E0", Offset = "0x519F3E0", VA = "0x1851A09E0")]
		public FZBXDZLWBIS(b a, a b, Id32<QEBRWUBFUFW> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6404260", Offset = "0x6402C60", VA = "0x186404260", Slot = "4")]
		[AsyncStateMachine(typeof(FZBXDZLWBIS<, >.<SendActionToAll>d__6))]
		public Task<Result<object, RYUTMMKYXMA>> LWYLDUSLRGQ(SYXPYTMUMKS a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GXWCFSPOAEI
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public interface ZFMZEQYTVOK<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<Result<object, RYUTMMKYXMA>> LWYLDUSLRGQ(a a, Id32<QEBRWUBFUFW> senderId, SYXPYTMUMKS b, bool c);
		}
	}
}
namespace Circuits.Static.Mock.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class WIRFPDIDVLO : GNUHQACMLVZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void OnEdgeDidAddDelegate(Id32<MHARATWVONH> graphId, Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void OnEdgeWillRemoveDelegate(Id32<MHARATWVONH> graphId, Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void OnStaticNodeWillDestroyDelegate(Id32<MHARATWVONH> graphId, Id32<TOXCFTIABCD> nodeId);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly WIRFPDIDVLO IWMDTGRRYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly OnEdgeDidAddDelegate? PPPJOYISUGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly OnEdgeWillRemoveDelegate? VJRADCRAFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly OnStaticNodeWillDestroyDelegate? WNFBDBCOMMH;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xDED770", Offset = "0xDEC170", VA = "0x180DED770")]
		public WIRFPDIDVLO([Optional] OnEdgeDidAddDelegate? a, [Optional] OnEdgeWillRemoveDelegate? b, [Optional] OnStaticNodeWillDestroyDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6DB0", Offset = "0x2BC57B0", VA = "0x182BC6DB0", Slot = "4")]
		public void OnEdgeDidAdd(Id32<MHARATWVONH> graphId, Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6DD0", Offset = "0x2BC57D0", VA = "0x182BC6DD0", Slot = "5")]
		public void OnEdgeWillRemove(Id32<MHARATWVONH> graphId, Id32<TCUAKPZLGNE> srcId, Id32<TMHZGRJSWQB> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6D90", Offset = "0x2BC5790", VA = "0x182BC6D90", Slot = "6")]
		public void ENXGYESWLXN(Id32<MHARATWVONH> graphId, Id32<TOXCFTIABCD> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
		public void OnFunctionDeclsRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "10")]
		public void OnObjectPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "11")]
		public void OnPlayerPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "12")]
		public void OnEditGraphDidPush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "13")]
		public void OnEditGraphDidPop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "8")]
		public void YOGBRKAFEQX(Id32<UNDPTPKOLZB> functionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "9")]
		public void JWEDXYNKTZT(Id32<UNDPTPKOLZB> functionId)
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
