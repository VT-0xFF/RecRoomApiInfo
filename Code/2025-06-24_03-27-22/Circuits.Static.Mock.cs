using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2959190", Offset = "0x2957D90", VA = "0x182959190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FIKKBFELHPF<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, AFHJFGFNFMA.CLIHBJIEPPA<TAction, TNetSys> where TReceiverDeps : notnull, AFHJFGFNFMA.PNKKLKBNADN<TAction, TReceiver> where TRootDeps : notnull, AFHJFGFNFMA.KLIPFOIGICN<PDKGHPFBEOL, TAction, TRoot> where TRoot : notnull where TDeps : notnull, AFHJFGFNFMA.OFOPAMEGJPF<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class DFDKBBBECOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? GKPGNAMMIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<DGIIBEBJOCJ<TAction>> ENJOPCKDMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool ALFMOLIMIDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> HAHEPHDNLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool KMIBNLNGDHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? JMCKHDGELEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly KIIIPFOEKFO<PDKGHPFBEOL, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> LMNDKJHLOBF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool DAFLJBDCDMH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x4295770", Offset = "0x4294370", VA = "0x184295770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4295810", Offset = "0x4294410", VA = "0x184295810")]
		public DFDKBBBECOI(int? PLPPHMAAKPP, List<DGIIBEBJOCJ<TAction>> DPAAHEAFBJP, bool IANFOLJNPAB, List<Func<Task>> JBCJFKDAEEM, bool IPGLFPMGLNG, TAction[]? NHMJLAMNKDD, KIIIPFOEKFO<PDKGHPFBEOL, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> GKADPAHCEOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4295520", Offset = "0x4294120", VA = "0x184295520")]
		public static FIKKBFELHPF<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.DFDKBBBECOI JHMOIFLKJAD(TDeps FCHJEFGMLNE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DFAFLCJGCPI
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
			public DFAFLCJGCPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<MDDPJNIIBBI<object?, JHFNBJHGPJG>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x42705A0", Offset = "0x426F1A0", VA = "0x1842705A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4270CD0", Offset = "0x426F8D0", VA = "0x184270CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public DFDKBBBECOI client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IKLALLBKLKC<KJCLJNBJCIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<MDDPJNIIBBI<object?, JHFNBJHGPJG>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DFAFLCJGCPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x42951F0", Offset = "0x4293DF0", VA = "0x1842951F0")]
		[AsyncStateMachine(typeof(FIKKBFELHPF<, , , , , , , >.DFAFLCJGCPI.<<SendActionToAll>b__0>d))]
		internal Task EDDDANPGHHA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct FICHIBLFOOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FIKKBFELHPF<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public IKLALLBKLKC<KJCLJNBJCIN> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IKLALLBKLKC<KJCLJNBJCIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public IKLALLBKLKC<PDKGHPFBEOL> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<MDDPJNIIBBI<object, JHFNBJHGPJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4C0FF70", Offset = "0x4C0EB70", VA = "0x184C0FF70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4C10440", Offset = "0x4C0F040", VA = "0x184C10440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FKBNOJLBGKB<KJCLJNBJCIN, DFDKBBBECOI> FJMCGDCMIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<DGIIBEBJOCJ<TAction>> DCFDPKHNHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int OKMLBGJEDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int NOCJJDIEJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int ELIDDKNHOAH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4C14C20", Offset = "0x4C13820", VA = "0x184C14C20")]
	public FIKKBFELHPF(int CEAEMJMOKLA, int OIPPNLIINDM, int BAHNFKAPNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4C14930", Offset = "0x4C13530", VA = "0x184C14930", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C14400", Offset = "0x4C13000", VA = "0x184C14400")]
	public void BODFABNMNLK(IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO, TDeps FCHJEFGMLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C14950", Offset = "0x4C13550", VA = "0x184C14950")]
	public void FMHLIIJPBMA(IKLALLBKLKC<KJCLJNBJCIN> KPGHEBOCEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C13600", Offset = "0x4C12200", VA = "0x184C13600")]
	public void BELDBNFIHBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C13630", Offset = "0x4C12230", VA = "0x184C13630")]
	public (Task, Task[]) BMDDJNJNMEG(TRoot HMGDINOCJAI, [In] HHAPOFMILMM<KJCLJNBJCIN> PICOFBFIKIJ, [In] FKBNOJLBGKB<KJCLJNBJCIN, TNetSys> KABHJPHLFAP, [In] FKBNOJLBGKB<KJCLJNBJCIN, TReceiver> HDMNJOPCAHG, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, IKLALLBKLKC<PDKGHPFBEOL> NFHIONLLLPO, TAction IFDCDCHOGGB)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C14120", Offset = "0x4C12D20", VA = "0x184C14120")]
	public Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> BMDDJNJNMEG(TRoot HMGDINOCJAI, TNetSys MONEFJFBDPB, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, TAction IFDCDCHOGGB, bool DLHOJKLEPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C14970", Offset = "0x4C13570", VA = "0x184C14970")]
	[AsyncStateMachine(typeof(FIKKBFELHPF<, , , , , , , >.FICHIBLFOOH))]
	public Task JHICCGNIOLB(TRoot HMGDINOCJAI, TNetSys LAGEJJBCPNF, TReceiver ODPFHLHHEBI, IKLALLBKLKC<KJCLJNBJCIN> ANBJOOBDMHA, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, IKLALLBKLKC<PDKGHPFBEOL> NFHIONLLLPO, TAction IFDCDCHOGGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C146D0", Offset = "0x4C132D0", VA = "0x184C146D0")]
	public Task CFIOLOKGBGF(TRoot HMGDINOCJAI, TNetSys LAGEJJBCPNF, TReceiver ODPFHLHHEBI, IKLALLBKLKC<KJCLJNBJCIN> ANBJOOBDMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct DGIIBEBJOCJ<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly IKLALLBKLKC<KJCLJNBJCIN> HCIIHFKNFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly IKLALLBKLKC<PDKGHPFBEOL> HEHCEPGOOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction CNKCEOPCPAB;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xCBBCC0", Offset = "0xCBA8C0", VA = "0x180CBBCC0")]
	public DGIIBEBJOCJ(IKLALLBKLKC<KJCLJNBJCIN> KJIKHIJJPOK, IKLALLBKLKC<PDKGHPFBEOL> NFHIONLLLPO, TAction IFDCDCHOGGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class GFNENKJEGAN
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3A89890", Offset = "0x3A88490", VA = "0x183A89890")]
	public static DGIIBEBJOCJ<TAction> JHMOIFLKJAD<TAction>(IKLALLBKLKC<KJCLJNBJCIN> KJIKHIJJPOK, IKLALLBKLKC<PDKGHPFBEOL> NFHIONLLLPO, TAction IFDCDCHOGGB) where TAction : notnull
	{
		return default(DGIIBEBJOCJ<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class DOINOKDAIBM<TRoot, TDeps> : JCEPCEKHIIH where TRoot : notnull where TDeps : notnull, IBPCOKIOLBL.GHMEADBPKPI<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DGONOJHGLIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<MDDPJNIIBBI<object?, JHFNBJHGPJG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public DOINOKDAIBM<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public KDEPIGGKFKP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<MDDPJNIIBBI<object?, JHFNBJHGPJG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x429FAD0", Offset = "0x429E6D0", VA = "0x18429FAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x429FE00", Offset = "0x429EA00", VA = "0x18429FE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps MPDEJFBBCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot FDOKJEJPACH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IKLALLBKLKC<KJCLJNBJCIN> CADPENEOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0")]
		[CompilerGenerated]
		get
		{
			return default(IKLALLBKLKC<KJCLJNBJCIN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E621E0", Offset = "0x2E60DE0", VA = "0x182E621E0")]
	public DOINOKDAIBM(TDeps FCHJEFGMLNE, TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> MEHEKMFODFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42D37D0", Offset = "0x42D23D0", VA = "0x1842D37D0", Slot = "4")]
	[AsyncStateMachine(typeof(DOINOKDAIBM<, >.DGONOJHGLIP))]
	public Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> BMDDJNJNMEG(KDEPIGGKFKP IFDCDCHOGGB, bool DLHOJKLEPHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IBPCOKIOLBL
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GHMEADBPKPI<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<MDDPJNIIBBI<object, JHFNBJHGPJG>> BMDDJNJNMEG(TRoot HMGDINOCJAI, IKLALLBKLKC<KJCLJNBJCIN> IBPDAEBHBNH, KDEPIGGKFKP IFDCDCHOGGB, bool DLHOJKLEPHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IGLDJBJHCML : HFPNDHJFHJB
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void EMBONECBKNL();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly IGLDJBJHCML LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EMBONECBKNL? MIBMFBKNBDJ;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	public IGLDJBJHCML([Optional] EMBONECBKNL? HGCFAMBENKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x11FDA70", Offset = "0x11FC670", VA = "0x1811FDA70", Slot = "4")]
	public void CNHGLLCJEHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class LFOELBCIAIA : HKCGODDAPIN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void JOKPGNDONNE(IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<PPCGBNBBHPM> PHKGJJHBGDJ, IKLALLBKLKC<EFEDBHKEGPL> OPCMCAALBND);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void OPBHNBCFGKG(IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<PPCGBNBBHPM> PHKGJJHBGDJ, IKLALLBKLKC<EFEDBHKEGPL> OPCMCAALBND);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void LAIHLBEMMFC(IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<DKJICOCFIKD> GKLJHCMGFAB);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly LFOELBCIAIA LBPNLDGACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly JOKPGNDONNE? GAKIEFPMIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OPBHNBCFGKG? OAMNGJADILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LAIHLBEMMFC? PGAAPCMJABP;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xCEAF50", Offset = "0xCE9B50", VA = "0x180CEAF50")]
	public LFOELBCIAIA([Optional] JOKPGNDONNE? PFEKOIBGIBB, [Optional] OPBHNBCFGKG? CACLPHECMPA, [Optional] LAIHLBEMMFC? DEEPIHBJLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2959080", Offset = "0x2957C80", VA = "0x182959080", Slot = "4")]
	public void OnEdgeDidAdd(IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<PPCGBNBBHPM> PHKGJJHBGDJ, IKLALLBKLKC<EFEDBHKEGPL> OPCMCAALBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29590A0", Offset = "0x2957CA0", VA = "0x1829590A0", Slot = "5")]
	public void OnEdgeWillRemove(IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<PPCGBNBBHPM> PHKGJJHBGDJ, IKLALLBKLKC<EFEDBHKEGPL> OPCMCAALBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29590C0", Offset = "0x2957CC0", VA = "0x1829590C0", Slot = "6")]
	public void PPNDKIJAHDF(IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<DKJICOCFIKD> GKLJHCMGFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "11")]
	public void OnEditGraphDidPop()
	{
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
