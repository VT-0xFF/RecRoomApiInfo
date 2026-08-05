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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x2920D30", Offset = "0x291F730", VA = "0x182920D30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class POKPJMJGCPK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, BKNGMHEAEKI.DOIGJLHHJNF<TAction, TNetSys> where TReceiverDeps : notnull, BKNGMHEAEKI.MGICJFBDCKP<TAction, TReceiver> where TRootDeps : notnull, BKNGMHEAEKI.PMGCHJOMIJL<HDADMFPJMIH, TAction, TRoot> where TRoot : notnull where TDeps : notnull, BKNGMHEAEKI.BICIKKHEKNO<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class IGBEBPLBFIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? OCBFIAHMAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<BHMIKDOAMKE<TAction>> CODIFNHNOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool NGIJPLNHFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> BLGMKAGNNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool ABIBNHDIKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? ODDKCLOMFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly ONEOPDDILII<HDADMFPJMIH, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> CKIMBILMIDE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool HPBDIEJMIHD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x4E4FE80", Offset = "0x4E4E880", VA = "0x184E4FE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4E4FF20", Offset = "0x4E4E920", VA = "0x184E4FF20")]
		public IGBEBPLBFIJ(int? MDOABEEEDPI, List<BHMIKDOAMKE<TAction>> KNCLOJPBEFF, bool PLJCKKKHEHE, List<Func<Task>> BHLJEOCCFMA, bool NAMGEGJKLHD, TAction[]? HEDFEPPINMN, ONEOPDDILII<HDADMFPJMIH, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> PHOIINKLMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4E4FC30", Offset = "0x4E4E630", VA = "0x184E4FC30")]
		public static POKPJMJGCPK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.IGBEBPLBFIJ FMDOFBCLPJB(TDeps BFPFMKIIKBG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BGFNNOEODDJ
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
			public BGFNNOEODDJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<KAFLOHEKGBO<object?, EOIBCJECGDC>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<KAFLOHEKGBO<object, EOIBCJECGDC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x42396D0", Offset = "0x42380D0", VA = "0x1842396D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4239E00", Offset = "0x4238800", VA = "0x184239E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public IGBEBPLBFIJ client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EHLNDDDNIPO<PKGIIJDCHID> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<KAFLOHEKGBO<object?, EOIBCJECGDC>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BGFNNOEODDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x610E360", Offset = "0x610CD60", VA = "0x18610E360")]
		[AsyncStateMachine(typeof(POKPJMJGCPK<, , , , , , , >.BGFNNOEODDJ.<<SendActionToAll>b__0>d))]
		internal Task FGFJDNABAPG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BAHCFPMAHMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public POKPJMJGCPK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EHLNDDDNIPO<PKGIIJDCHID> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public EHLNDDDNIPO<PKGIIJDCHID> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public EHLNDDDNIPO<HDADMFPJMIH> requestId;

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
		private TaskAwaiter<KAFLOHEKGBO<object, EOIBCJECGDC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5F9FCA0", Offset = "0x5F9E6A0", VA = "0x185F9FCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FA0570", Offset = "0x5F9EF70", VA = "0x185FA0570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private CFFOMBMNIPG<PKGIIJDCHID, IGBEBPLBFIJ> FJHJNDDJOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<BHMIKDOAMKE<TAction>> NAGACBKIHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int DFGHOHJMDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int PKJDCLABBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int LEJLGFLOOJL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5791AD0", Offset = "0x57904D0", VA = "0x185791AD0")]
	public POKPJMJGCPK(int AAGEOPJMAHB, int INBMAJFMKLC, int NIOCBIEAIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x57914E0", Offset = "0x578FEE0", VA = "0x1857914E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5791A60", Offset = "0x5790460", VA = "0x185791A60")]
	public void OFOHCAAECGE(EHLNDDDNIPO<PKGIIJDCHID> KKNDHFCJJOK, TDeps BFPFMKIIKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x57904B0", Offset = "0x578EEB0", VA = "0x1857904B0")]
	public void BBOFGGCBLLK(EHLNDDDNIPO<PKGIIJDCHID> KKNDHFCJJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5791500", Offset = "0x578FF00", VA = "0x185791500")]
	public void EENOFGDEPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5790780", Offset = "0x578F180", VA = "0x185790780")]
	public (Task, Task[]) CJKMKOILCDN(TRoot ALPBGLGCPNB, [In] EENHIBOLGKA<PKGIIJDCHID> CAEHIKDKCAM, [In] CFFOMBMNIPG<PKGIIJDCHID, TNetSys> GFFMNMLDGIO, [In] CFFOMBMNIPG<PKGIIJDCHID, TReceiver> NILNOCODGHI, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, EHLNDDDNIPO<HDADMFPJMIH> EKKOCKBOLHD, TAction KPGBPPBMJJK)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5791270", Offset = "0x578FC70", VA = "0x185791270")]
	public Task<KAFLOHEKGBO<object, EOIBCJECGDC>> CJKMKOILCDN(TRoot ALPBGLGCPNB, TNetSys GAMOJFHOMGC, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, TAction KPGBPPBMJJK, bool HNAKPKJPFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x57904D0", Offset = "0x578EED0", VA = "0x1857904D0")]
	[AsyncStateMachine(typeof(POKPJMJGCPK<, , , , , , , >.BAHCFPMAHMB))]
	public Task CIBCPJFKCGM(TRoot ALPBGLGCPNB, TNetSys NJCDPDIJAME, TReceiver BGDEMBOCEKP, EHLNDDDNIPO<PKGIIJDCHID> LEPPEPJFDHH, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, EHLNDDDNIPO<HDADMFPJMIH> EKKOCKBOLHD, TAction KPGBPPBMJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5791530", Offset = "0x578FF30", VA = "0x185791530")]
	public Task NOCCMNLJPIK(TRoot ALPBGLGCPNB, TNetSys NJCDPDIJAME, TReceiver BGDEMBOCEKP, EHLNDDDNIPO<PKGIIJDCHID> LEPPEPJFDHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct BHMIKDOAMKE<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly EHLNDDDNIPO<PKGIIJDCHID> HGBOIMEEPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly EHLNDDDNIPO<HDADMFPJMIH> BHAOKHNOOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction FDKANNFDBNK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xCA80C0", Offset = "0xCA6AC0", VA = "0x180CA80C0")]
	public BHMIKDOAMKE(EHLNDDDNIPO<PKGIIJDCHID> NIHHJEGJCCB, EHLNDDDNIPO<HDADMFPJMIH> EKKOCKBOLHD, TAction KPGBPPBMJJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class MPOJEGFNJML
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3B5D180", Offset = "0x3B5BB80", VA = "0x183B5D180")]
	public static BHMIKDOAMKE<TAction> FMDOFBCLPJB<TAction>(EHLNDDDNIPO<PKGIIJDCHID> NIHHJEGJCCB, EHLNDDDNIPO<HDADMFPJMIH> EKKOCKBOLHD, TAction KPGBPPBMJJK) where TAction : notnull
	{
		return default(BHMIKDOAMKE<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class CEHDJMJLPFD<TRoot, TDeps> : FBBJLADGJML where TRoot : notnull where TDeps : notnull, JNKGBPMBPIC.ELEMOCKJLDD<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HFNNFKKPJLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<object?, EOIBCJECGDC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public CEHDJMJLPFD<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public KFCOHCHPBOF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<KAFLOHEKGBO<object?, EOIBCJECGDC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4CEECC0", Offset = "0x4CED6C0", VA = "0x184CEECC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4CEF2A0", Offset = "0x4CEDCA0", VA = "0x184CEF2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps JIMKFPLDKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot FKAJFJBPKHB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public EHLNDDDNIPO<PKGIIJDCHID> FKHKCNLGBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
		[CompilerGenerated]
		get
		{
			return default(EHLNDDDNIPO<PKGIIJDCHID>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2E25720", Offset = "0x2E24120", VA = "0x182E25720")]
	public CEHDJMJLPFD(TDeps BFPFMKIIKBG, TRoot ALPBGLGCPNB, EHLNDDDNIPO<PKGIIJDCHID> HFIEPKKAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64BE910", Offset = "0x64BD310", VA = "0x1864BE910", Slot = "4")]
	[AsyncStateMachine(typeof(CEHDJMJLPFD<, >.HFNNFKKPJLK))]
	public Task<KAFLOHEKGBO<object, EOIBCJECGDC>> CJKMKOILCDN(KFCOHCHPBOF KPGBPPBMJJK, bool HNAKPKJPFDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JNKGBPMBPIC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ELEMOCKJLDD<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<KAFLOHEKGBO<object, EOIBCJECGDC>> CJKMKOILCDN(TRoot ALPBGLGCPNB, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, KFCOHCHPBOF KPGBPPBMJJK, bool HNAKPKJPFDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BMDLKABFKKG : JHEJKGJJHMM
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void IOEOBFBOOEI();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly BMDLKABFKKG FDCAMNOGINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly IOEOBFBOOEI? DKPIBKNGEAG;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public BMDLKABFKKG([Optional] IOEOBFBOOEI? LFOICCJILFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x11DF5F0", Offset = "0x11DDFF0", VA = "0x1811DF5F0", Slot = "4")]
	public void BGBDGCGCAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class FIEBEFFPHPL : GKBBEPHMKHK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void ACLACIIAIBN(EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<AJNLPJGEJEJ> CLNILBJELJF, EHLNDDDNIPO<BGLCIALODCA> KLDLBJCOKAC);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void MPNDJHNLAIA(EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<AJNLPJGEJEJ> CLNILBJELJF, EHLNDDDNIPO<BGLCIALODCA> KLDLBJCOKAC);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void MANPMOLGFIN(EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<FMDMBPGDGPO> MKAMFGFDAIG);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly FIEBEFFPHPL FDCAMNOGINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly ACLACIIAIBN? DMLEODOMPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MPNDJHNLAIA? CNEDGGLBOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MANPMOLGFIN? IKMJKFKMFME;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xCC55F0", Offset = "0xCC3FF0", VA = "0x180CC55F0")]
	public FIEBEFFPHPL([Optional] ACLACIIAIBN? GLHCIBLCAPO, [Optional] MPNDJHNLAIA? KAJHCECPIGH, [Optional] MANPMOLGFIN? EDHLGHBCOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2920C40", Offset = "0x291F640", VA = "0x182920C40", Slot = "4")]
	public void OnEdgeDidAdd(EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<AJNLPJGEJEJ> CLNILBJELJF, EHLNDDDNIPO<BGLCIALODCA> KLDLBJCOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2920C60", Offset = "0x291F660", VA = "0x182920C60", Slot = "5")]
	public void OnEdgeWillRemove(EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<AJNLPJGEJEJ> CLNILBJELJF, EHLNDDDNIPO<BGLCIALODCA> KLDLBJCOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2920C20", Offset = "0x291F620", VA = "0x182920C20", Slot = "6")]
	public void GMBKLICDGPO(EHLNDDDNIPO<JIFLPHMJMBF> MNODKBPNLJF, EHLNDDDNIPO<FMDMBPGDGPO> MKAMFGFDAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "11")]
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
