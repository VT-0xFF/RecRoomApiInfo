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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2BAD230", Offset = "0x2BAC630", VA = "0x182BAD230")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class MHHBPHJUUGA<a, b, c, d, e, f, g, h> : IDisposable where a : notnull where b : notnull where c : notnull where d : notnull, UXOUZHAFSJC.YWYJNPIOPIT<a, b> where e : notnull, UXOUZHAFSJC.EIUEKENQCJW<a, c> where f : notnull, UXOUZHAFSJC.FWOEJNVWAJL<a, g> where g : notnull where h : notnull, UXOUZHAFSJC.MDFEQTCPLCK<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		internal sealed class FKOWIFAOFJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			internal int? PCBVLFURGJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			internal readonly List<Func<Task>> KIAOTXOWCSM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			internal bool DOYLMAFIDZS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			internal readonly List<Func<Task>> GAGZIUYREOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			internal bool LOXPVVJEHEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			internal a[]? TTXSQLFXGLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			internal readonly CSRTKGILMEU<a, b, c, d, e, f, g, h> UXOUZHAFSJC;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			internal bool JQHGIGNIFKT
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x627B860", Offset = "0x627AC60", VA = "0x18627B860")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x627B900", Offset = "0x627AD00", VA = "0x18627B900")]
			public FKOWIFAOFJE(int? a, List<Func<Task>> b, bool c, List<Func<Task>> d, bool e, a[]? pausedSnapshot, CSRTKGILMEU<a, b, c, d, e, f, g, h> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x627B430", Offset = "0x627A830", VA = "0x18627B430")]
			public static MHHBPHJUUGA<a, b, c, d, e, f, g, h>.FKOWIFAOFJE New(h deps)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class DPSXTTGDTBT
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
				public DPSXTTGDTBT <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				private TaskCompletionSource<Result<object?, SKKNIPYCQUO>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x41E0DF0", Offset = "0x41E01F0", VA = "0x1841E0DF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x41E18B0", Offset = "0x41E0CB0", VA = "0x1841E18B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public FKOWIFAOFJE PNDHLYVBPAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public g JBSQCTQPIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public b SYPZOGFBRDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Id32<BVHHKRGRDMC> PBKNUXMMEPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public bool SMWGHTYPTBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public TaskCompletionSource<Result<object?, SKKNIPYCQUO>> OFNABDWGGOQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public a TXIJCXHDNBL;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public DPSXTTGDTBT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x5340AD0", Offset = "0x533FED0", VA = "0x185340AD0")]
			[AsyncStateMachine(typeof(MHHBPHJUUGA<, , , , , , , >.DPSXTTGDTBT.<<SendActionToAll>b__0>d))]
			internal Task HECEJLYEGBC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class QLDETKWUZQC
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
				public QLDETKWUZQC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private TaskCompletionSource<Result<object, SKKNIPYCQUO>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				private TaskAwaiter<Result<object, SKKNIPYCQUO>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x41DC730", Offset = "0x41DBB30", VA = "0x1841DC730", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x41DCB00", Offset = "0x41DBF00", VA = "0x1841DCB00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public FKOWIFAOFJE PNDHLYVBPAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public g JBSQCTQPIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public b NSBVACCFECX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public c WRKCIOLXSEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Id32<BVHHKRGRDMC> PBKNUXMMEPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public a DVPPDHBXRUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public TaskCompletionSource<Result<object, SKKNIPYCQUO>> OFNABDWGGOQ;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public QLDETKWUZQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7666620", Offset = "0x7665A20", VA = "0x187666620")]
			[AsyncStateMachine(typeof(MHHBPHJUUGA<, , , , , , , >.QLDETKWUZQC.<<ReceiveAction>b__0>d))]
			internal Task JEEFMDGKDJT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAField<BVHHKRGRDMC, FKOWIFAOFJE> BEBGMLFPZTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<CachedAction<a>> HZVPFORDMQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly int HVPRVEHYLHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly int ZTYVOQKPEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly int TJCTGCLYEVN;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DC90", Offset = "0x6F8D090", VA = "0x186F8DC90")]
		public MHHBPHJUUGA(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BD90", Offset = "0x6F8B190", VA = "0x186F8BD90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F8BEA0", Offset = "0x6F8B2A0", VA = "0x186F8BEA0")]
		public void OOQAABLUGUM(Id32<BVHHKRGRDMC> clientId, h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F8DBE0", Offset = "0x6F8CFE0", VA = "0x186F8DBE0")]
		public void ZHUNHONDTBC(Id32<BVHHKRGRDMC> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B0E0", Offset = "0x6F8A4E0", VA = "0x186F8B0E0")]
		public void BZOACXAHRRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8CDB0", Offset = "0x6F8C1B0", VA = "0x186F8CDB0")]
		public Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(g a, [In] SOAId32<BVHHKRGRDMC> clientIds, [In] SOAField<BVHHKRGRDMC, b> clients, [In] SOAField<BVHHKRGRDMC, c> receivers, Id32<BVHHKRGRDMC> senderId, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8D0D0", Offset = "0x6F8C4D0", VA = "0x186F8D0D0")]
		public Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(g a, b b, Id32<BVHHKRGRDMC> senderId, a c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8B150", Offset = "0x6F8A550", VA = "0x186F8B150")]
		public Task<Result<object, SKKNIPYCQUO>> DHXGMDSKOIZ(g a, b b, c c, Id32<BVHHKRGRDMC> receiverId, Id32<BVHHKRGRDMC> senderId, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C480", Offset = "0x6F8B880", VA = "0x186F8C480")]
		public Task PSUIBKYUFCT(g a, b b, c c, Id32<BVHHKRGRDMC> receiverId)
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
		public readonly Id32<BVHHKRGRDMC> ActorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly TAction Action;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1997630", Offset = "0x1996A30", VA = "0x181997630")]
		public CachedAction(Id32<BVHHKRGRDMC> actorId, TAction action)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class ZFDJYPCELJU
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4120860", Offset = "0x411FC60", VA = "0x184120860")]
		public static CachedAction<TAction> New<TAction>(Id32<BVHHKRGRDMC> actorId, TAction action) where TAction : notnull
		{
			return default(CachedAction<TAction>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class DDBBEEAJJTS<a, b> : OKXJRNOVLSL where a : notnull where b : notnull, FKOWIFAOFJE.MCUQWFOUSFS<a>
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
			public AsyncTaskMethodBuilder<Result<object?, SKKNIPYCQUO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public DDBBEEAJJTS<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public PXBFMCKNGBK action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TaskAwaiter<Result<object?, SKKNIPYCQUO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6C7A2F0", Offset = "0x6C796F0", VA = "0x186C7A2F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6C7A570", Offset = "0x6C79970", VA = "0x186C7A570", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly b RATSQORCBWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly a SOWSTSWRDPN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<BVHHKRGRDMC> JMPYBRFMZMT
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD05550", Offset = "0xD04950", VA = "0x180D05550")]
			[CompilerGenerated]
			get
			{
				return default(Id32<BVHHKRGRDMC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5330040", Offset = "0x532F440", VA = "0x185330040")]
		public DDBBEEAJJTS(b a, a b, Id32<BVHHKRGRDMC> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x532FDC0", Offset = "0x532F1C0", VA = "0x18532FDC0", Slot = "4")]
		[AsyncStateMachine(typeof(DDBBEEAJJTS<, >.<SendActionToAll>d__6))]
		public Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(PXBFMCKNGBK a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class FKOWIFAOFJE
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public interface MCUQWFOUSFS<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<Result<object, SKKNIPYCQUO>> VWNRQDAMUSS(a a, Id32<BVHHKRGRDMC> senderId, PXBFMCKNGBK b, bool c);
		}
	}
}
namespace Circuits.Static.Mock.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class XUOYAXZSDBA : IQCKFZTPFKV
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void OnEdgeDidAddDelegate(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void OnEdgeWillRemoveDelegate(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void OnStaticNodeWillDestroyDelegate(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly XUOYAXZSDBA LDHSFMFGGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly OnEdgeDidAddDelegate? YJLDMEKAIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly OnEdgeWillRemoveDelegate? VCIQNSKRMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly OnStaticNodeWillDestroyDelegate? TRPAFYEULCJ;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xDE3B70", Offset = "0xDE2F70", VA = "0x180DE3B70")]
		public XUOYAXZSDBA([Optional] OnEdgeDidAddDelegate? a, [Optional] OnEdgeWillRemoveDelegate? b, [Optional] OnStaticNodeWillDestroyDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD360", Offset = "0x2BAC760", VA = "0x182BAD360", Slot = "4")]
		public void OnEdgeDidAdd(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD380", Offset = "0x2BAC780", VA = "0x182BAD380", Slot = "5")]
		public void OnEdgeWillRemove(Id32<EVDWFGHNUCH> graphId, Id32<FOQLRVXTRHG> srcId, Id32<NTSCAYGKXQL> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2BAD3A0", Offset = "0x2BAC7A0", VA = "0x182BAD3A0", Slot = "6")]
		public void YZMQLPAJHSN(Id32<EVDWFGHNUCH> graphId, Id32<IHXSJTKSKEJ> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
		public void OnFunctionDeclsRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "10")]
		public void OnObjectPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "11")]
		public void OnPlayerPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "12")]
		public void OnEditGraphDidPush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "13")]
		public void OnEditGraphDidPop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "8")]
		public void HHRKIAAWFFD(Id32<AXCQMZDPZIR> functionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "9")]
		public void VPHGCXYBMKT(Id32<AXCQMZDPZIR> functionId)
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
