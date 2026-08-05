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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BDF590", Offset = "0x2BDDF90", VA = "0x182BDF590")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class NTEHWETUNNP<a, b, c, d, e, f, g, h> : IDisposable where a : notnull where b : notnull where c : notnull where d : notnull, CACFZSSVVJB.YBIHNSSNITM<a, b> where e : notnull, CACFZSSVVJB.MMQTUXUFWIF<a, c> where f : notnull, CACFZSSVVJB.QHUWUHZIAAI<a, g> where g : notnull where h : notnull, CACFZSSVVJB.EXOUKTTMMZJ<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		internal sealed class SDZTLNETUVH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			internal int? RWGEEPDKHWG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			internal readonly List<Func<Task>> ICWNZATTPYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			internal bool LDJWOSDDGJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			internal readonly List<Func<Task>> XPHMQNWDJPQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			internal bool ECHRRBYBJSX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			internal a[]? DZIYRAYOJGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			internal readonly EQMPTCYXFUT<a, b, c, d, e, f, g, h> CACFZSSVVJB;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			internal bool KRNVWFATPXC
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x79EEEA0", Offset = "0x79ED8A0", VA = "0x1879EEEA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x79EF340", Offset = "0x79EDD40", VA = "0x1879EF340")]
			public SDZTLNETUVH(int? a, List<Func<Task>> b, bool c, List<Func<Task>> d, bool e, a[]? pausedSnapshot, EQMPTCYXFUT<a, b, c, d, e, f, g, h> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x79EF190", Offset = "0x79EDB90", VA = "0x1879EF190")]
			public static NTEHWETUNNP<a, b, c, d, e, f, g, h>.SDZTLNETUVH New(h deps)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class GEFSAEGAKYY
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
				public GEFSAEGAKYY <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				private TaskCompletionSource<Result<object?, KXUOEYSOWHL>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x4219A20", Offset = "0x4218420", VA = "0x184219A20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x4219E00", Offset = "0x4218800", VA = "0x184219E00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public SDZTLNETUVH DCDUPWDHMKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public g NEXPSVAOOPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public b PFMVASWLLQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Id32<QOLQCAXXJSV> FIXNDTJZHZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public bool PHVDGPSIOYR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public TaskCompletionSource<Result<object?, KXUOEYSOWHL>> UQKVQPZKLZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public a NYWBMXWUHCS;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public GEFSAEGAKYY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6441BD0", Offset = "0x64405D0", VA = "0x186441BD0")]
			[AsyncStateMachine(typeof(NTEHWETUNNP<, , , , , , , >.GEFSAEGAKYY.<<SendActionToAll>b__0>d))]
			internal Task HUHZWTSKSSJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class SIXMNEQISOH
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
				public SIXMNEQISOH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private TaskCompletionSource<Result<object, KXUOEYSOWHL>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				private TaskAwaiter<Result<object, KXUOEYSOWHL>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x42142C0", Offset = "0x4212CC0", VA = "0x1842142C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x4214E50", Offset = "0x4213850", VA = "0x184214E50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public SDZTLNETUVH DCDUPWDHMKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public g NEXPSVAOOPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public b LQAZISDSYKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public c HUZHHAGZELO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Id32<QOLQCAXXJSV> FIXNDTJZHZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public a ODUTGMXWONR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public TaskCompletionSource<Result<object, KXUOEYSOWHL>> UQKVQPZKLZH;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public SIXMNEQISOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x79F5300", Offset = "0x79F3D00", VA = "0x1879F5300")]
			[AsyncStateMachine(typeof(NTEHWETUNNP<, , , , , , , >.SIXMNEQISOH.<<ReceiveAction>b__0>d))]
			internal Task PBSFWEEZIOY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAField<QOLQCAXXJSV, SDZTLNETUVH> AGHSJNYKMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<CachedAction<a>> LVXBDDIIXVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly int GCUOIBKQQVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly int DBLPKLGQSAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly int CGITSZOKYAY;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x726A5B0", Offset = "0x7268FB0", VA = "0x18726A5B0")]
		public NTEHWETUNNP(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7268E90", Offset = "0x7267890", VA = "0x187268E90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72681F0", Offset = "0x7266BF0", VA = "0x1872681F0")]
		public void CWSGNZHWRLF(Id32<QOLQCAXXJSV> clientId, h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x726A520", Offset = "0x7268F20", VA = "0x18726A520")]
		public void QHEAOUFKBDH(Id32<QOLQCAXXJSV> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x726A490", Offset = "0x7268E90", VA = "0x18726A490")]
		public void PZDVVTGVBBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7269620", Offset = "0x7268020", VA = "0x187269620")]
		public Task<Result<object, KXUOEYSOWHL>> NZBEKAXHMZJ(g a, [In] SOAId32<QOLQCAXXJSV> clientIds, [In] SOAField<QOLQCAXXJSV, b> clients, [In] SOAField<QOLQCAXXJSV, c> receivers, Id32<QOLQCAXXJSV> senderId, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x726A250", Offset = "0x7268C50", VA = "0x18726A250")]
		public Task<Result<object, KXUOEYSOWHL>> NZBEKAXHMZJ(g a, b b, Id32<QOLQCAXXJSV> senderId, a c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7268B80", Offset = "0x7267580", VA = "0x187268B80")]
		public Task<Result<object, KXUOEYSOWHL>> DLYYCINMCJS(g a, b b, c c, Id32<QOLQCAXXJSV> receiverId, Id32<QOLQCAXXJSV> senderId, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7267F10", Offset = "0x7266910", VA = "0x187267F10")]
		public Task BHGZFLOJFFK(g a, b b, c c, Id32<QOLQCAXXJSV> receiverId)
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
		public readonly Id32<QOLQCAXXJSV> ActorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly TAction Action;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x19BF880", Offset = "0x19BE280", VA = "0x1819BF880")]
		public CachedAction(Id32<QOLQCAXXJSV> actorId, TAction action)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class GNHSCBGEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B09C10", Offset = "0x3B08610", VA = "0x183B09C10")]
		public static CachedAction<TAction> New<TAction>(Id32<QOLQCAXXJSV> actorId, TAction action) where TAction : notnull
		{
			return default(CachedAction<TAction>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class OHLNKQHDPWD<a, b> : KVHMMDKOSSW where a : notnull where b : notnull, SDZTLNETUVH.EXZIFHHHFWB<a>
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
			public AsyncTaskMethodBuilder<Result<object?, KXUOEYSOWHL>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public OHLNKQHDPWD<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public JGWKKBUFZYH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TaskAwaiter<Result<object?, KXUOEYSOWHL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6CDAFF0", Offset = "0x6CD99F0", VA = "0x186CDAFF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6CDB7E0", Offset = "0x6CDA1E0", VA = "0x186CDB7E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly b BJEOXILCYDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly a QNEDICCFGWK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<QOLQCAXXJSV> RUKDXKNBBVC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			[CompilerGenerated]
			get
			{
				return default(Id32<QOLQCAXXJSV>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6504420", Offset = "0x6502E20", VA = "0x186504420")]
		public OHLNKQHDPWD(b a, a b, Id32<QOLQCAXXJSV> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x73B9100", Offset = "0x73B7B00", VA = "0x1873B9100", Slot = "4")]
		[AsyncStateMachine(typeof(OHLNKQHDPWD<, >.<SendActionToAll>d__6))]
		public Task<Result<object, KXUOEYSOWHL>> NZBEKAXHMZJ(JGWKKBUFZYH a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class SDZTLNETUVH
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public interface EXZIFHHHFWB<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<Result<object, KXUOEYSOWHL>> NZBEKAXHMZJ(a a, Id32<QOLQCAXXJSV> senderId, JGWKKBUFZYH b, bool c);
		}
	}
}
namespace Circuits.Static.Mock.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class TJZEBFVXLRB : YZHTLTWFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void OnEdgeDidAddDelegate(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void OnEdgeWillRemoveDelegate(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void OnStaticNodeWillDestroyDelegate(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly TJZEBFVXLRB GFQGJWBHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly OnEdgeDidAddDelegate? PECDNVNGKVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly OnEdgeWillRemoveDelegate? SFFZBVBYAUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly OnStaticNodeWillDestroyDelegate? NSJFAURSNHU;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xE078A0", Offset = "0xE062A0", VA = "0x180E078A0")]
		public TJZEBFVXLRB([Optional] OnEdgeDidAddDelegate? a, [Optional] OnEdgeWillRemoveDelegate? b, [Optional] OnStaticNodeWillDestroyDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF6C0", Offset = "0x2BDE0C0", VA = "0x182BDF6C0", Slot = "4")]
		public void OnEdgeDidAdd(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF6E0", Offset = "0x2BDE0E0", VA = "0x182BDF6E0", Slot = "5")]
		public void OnEdgeWillRemove(Id32<VFKNGTPUEMY> graphId, Id32<ADNWLQIRYCV> srcId, Id32<QLUJOYTGVHG> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF700", Offset = "0x2BDE100", VA = "0x182BDF700", Slot = "6")]
		public void YBVRHYJVZTW(Id32<VFKNGTPUEMY> graphId, Id32<MVBOYPURKWM> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
		public void OnFunctionDeclsRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "10")]
		public void OnObjectPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "11")]
		public void OnPlayerPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "12")]
		public void OnEditGraphDidPush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "13")]
		public void OnEditGraphDidPop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "8")]
		public void FNVKMKFCXHC(Id32<YTGXVMERIIQ> functionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "9")]
		public void HLQKUTYMJKG(Id32<YTGXVMERIIQ> functionId)
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
