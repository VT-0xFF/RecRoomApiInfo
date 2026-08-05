using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct JBGDJPPGGAN<TPartialAction, TFullAction, TDeps> where TDeps : NABPMKPMHPA.PNBPKPOBIKM<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] FEDCCLHAMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int EFFJLEDKCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps AJFJAGOPOOC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x334E080", Offset = "0x334CC80", VA = "0x18334E080")]
	internal JBGDJPPGGAN(TPartialAction[] AGJPLNLOMGJ, int FLPGAAEONME, TDeps BNNGNHILECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x334DF60", Offset = "0x334CB60", VA = "0x18334DF60")]
	public static JBGDJPPGGAN<TPartialAction, TFullAction, TDeps> CIGBOGDFGOD(TDeps BNNGNHILECN)
	{
		return default(JBGDJPPGGAN<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NABPMKPMHPA
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PNBPKPOBIKM<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FMKOMIABKON([In] TPartialAction JIGGJNIOAFI);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction EFKAHGALPDO(TPartialAction[] EFBDBJKCMMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2906080", Offset = "0x2904C80", VA = "0x182906080")]
	public static FJLODHFCFCH<TFullAction> NIBIDCEHIKI<TFullAction, TPartialAction, TDeps>(this JBGDJPPGGAN<TPartialAction, TFullAction, TDeps> NOLNJDLEMAA, TPartialAction JIGGJNIOAFI) where TDeps : PNBPKPOBIKM<TPartialAction, TFullAction>
	{
		return default(FJLODHFCFCH<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EOGFNHMMICL<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : KLMPDDMAEBO.EFOBIIPCAKP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] NJMBHFONDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int CPODOLMGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps AJFJAGOPOOC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x334E080", Offset = "0x334CC80", VA = "0x18334E080")]
	internal EOGFNHMMICL(TPartialSnapshot[] FFOIMMAPMNP, int NPNLJIALMPH, TDeps BNNGNHILECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x334DF60", Offset = "0x334CB60", VA = "0x18334DF60")]
	public static EOGFNHMMICL<TPartialSnapshot, TFullSnapshot, TDeps> CIGBOGDFGOD(TDeps BNNGNHILECN)
	{
		return default(EOGFNHMMICL<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KLMPDDMAEBO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface EFOBIIPCAKP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IPLPMMIEOLB([In] TPartialSnapshot DLFNGOGDHBK);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot KNGDCGAGFPH(TPartialSnapshot[] BNPPGHGCGLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28590C0", Offset = "0x2857CC0", VA = "0x1828590C0")]
	public static FJLODHFCFCH<TFullSnapshot> NIBIDCEHIKI<TFullSnapshot, TPartialSnapshot, TDeps>(this EOGFNHMMICL<TPartialSnapshot, TFullSnapshot, TDeps> NOLNJDLEMAA, TPartialSnapshot DLFNGOGDHBK) where TDeps : EFOBIIPCAKP<TPartialSnapshot, TFullSnapshot>
	{
		return default(FJLODHFCFCH<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2858F70", Offset = "0x2857B70", VA = "0x182858F70")]
	public static bool KLEPHMNHBOH<TPartialSnapshot, TFullSnapshot, TDeps>(this EOGFNHMMICL<TPartialSnapshot, TFullSnapshot, TDeps> NOLNJDLEMAA, TPartialSnapshot DLFNGOGDHBK) where TDeps : EFOBIIPCAKP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GMLDBBOMDIP : PGJMJGCIBHB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E083F0", Offset = "0x1E06FF0", VA = "0x181E083F0", Slot = "7")]
	public override string HJJFPLKFILC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E08420", Offset = "0x1E07020", VA = "0x181E08420")]
	public GMLDBBOMDIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LLNPDPCMKAC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : BHNIIDLKBFO.OKDNLNKHCOF<TAction, TNetSys> where TReceiverDeps : BHNIIDLKBFO.DEBNHMBIKMA<TAction, TReceiver> where TRootDeps : BHNIIDLKBFO.MGFFKFGHLMP<TMRequest, TAction, TRoot> where TDeps : BHNIIDLKBFO.IHINPDFNFCN<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface ELPOIGIDLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NHDLDNBAENJ([In] DGKNLHNBBJB<object, BNLEFJJKIPP> MGHLKGJFBCD);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NIHIGLCAJMK();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DGKNLHNBBJB<object, BNLEFJJKIPP> IJNNDKBINFL();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KDNBJDBFCBD(Exception BJCOEJJDGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class CGDDFMMFJCH : ELPOIGIDLCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<DGKNLHNBBJB<object, BNLEFJJKIPP>> JCNKMPGKCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<DGKNLHNBBJB<object, JIEDJHBPKDD>> BEHAFHDMOBM;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4BB3330", Offset = "0x4BB1F30", VA = "0x184BB3330")]
		private CGDDFMMFJCH(TaskCompletionSource<DGKNLHNBBJB<object, BNLEFJJKIPP>> BCAKEJEFJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37B4B80", Offset = "0x37B3780", VA = "0x1837B4B80")]
		public static CGDDFMMFJCH CIGBOGDFGOD(TaskCompletionSource<DGKNLHNBBJB<object, BNLEFJJKIPP>> BCAKEJEFJBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4BB3070", Offset = "0x4BB1C70", VA = "0x184BB3070")]
		public void NHDLDNBAENJ([In] DGKNLHNBBJB<object, BNLEFJJKIPP> MGHLKGJFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4BB3170", Offset = "0x4BB1D70", VA = "0x184BB3170", Slot = "5")]
		public void NIHIGLCAJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2D50", Offset = "0x4BB1950", VA = "0x184BB2D50", Slot = "6")]
		public DGKNLHNBBJB<object, BNLEFJJKIPP> IJNNDKBINFL()
		{
			return default(DGKNLHNBBJB<object, BNLEFJJKIPP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2F10", Offset = "0x4BB1B10", VA = "0x184BB2F10", Slot = "7")]
		public void KDNBJDBFCBD(Exception BJCOEJJDGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x334A060", Offset = "0x3348C60", VA = "0x18334A060", Slot = "4")]
		private void JNMELONNDMI([In] DGKNLHNBBJB<object, BNLEFJJKIPP> MGHLKGJFBCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class JBLJBJMKACE : ELPOIGIDLCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<DGKNLHNBBJB<object, BNLEFJJKIPP>> JCNKMPGKCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private DGKNLHNBBJB<object, BNLEFJJKIPP> BDCGBKCAPJN;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B1480", Offset = "0x7B0080", VA = "0x1807B1480")]
		private JBLJBJMKACE(TaskCompletionSource<DGKNLHNBBJB<object, BNLEFJJKIPP>> BCAKEJEFJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x37B4B80", Offset = "0x37B3780", VA = "0x1837B4B80")]
		public static JBLJBJMKACE CIGBOGDFGOD(TaskCompletionSource<DGKNLHNBBJB<object, BNLEFJJKIPP>> BCAKEJEFJBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x369FFE0", Offset = "0x369EBE0", VA = "0x18369FFE0")]
		public void NHDLDNBAENJ([In] DGKNLHNBBJB<object, BNLEFJJKIPP> MGHLKGJFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA230", Offset = "0x3AE8E30", VA = "0x183AEA230", Slot = "5")]
		public void NIHIGLCAJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xADE5B0", Offset = "0xADD1B0", VA = "0x180ADE5B0", Slot = "6")]
		public DGKNLHNBBJB<object, BNLEFJJKIPP> IJNNDKBINFL()
		{
			return default(DGKNLHNBBJB<object, BNLEFJJKIPP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA1D0", Offset = "0x3AE8DD0", VA = "0x183AEA1D0", Slot = "7")]
		public void KDNBJDBFCBD(Exception BJCOEJJDGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x334A060", Offset = "0x3348C60", VA = "0x18334A060", Slot = "4")]
		private void JNMELONNDMI([In] DGKNLHNBBJB<object, BNLEFJJKIPP> MGHLKGJFBCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class GCKPHJPCLOL : ELPOIGIDLCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<DGKNLHNBBJB<object, BNLEFJJKIPP>> BEHAFHDMOBM;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3768C30", Offset = "0x3767830", VA = "0x183768C30")]
		private GCKPHJPCLOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3349FA0", Offset = "0x3348BA0", VA = "0x183349FA0")]
		public static GCKPHJPCLOL CIGBOGDFGOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3768AD0", Offset = "0x37676D0", VA = "0x183768AD0")]
		public void NHDLDNBAENJ([In] DGKNLHNBBJB<object, BNLEFJJKIPP> MGHLKGJFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		public void NIHIGLCAJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37688A0", Offset = "0x37674A0", VA = "0x1837688A0", Slot = "6")]
		public DGKNLHNBBJB<object, BNLEFJJKIPP> IJNNDKBINFL()
		{
			return default(DGKNLHNBBJB<object, BNLEFJJKIPP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37689B0", Offset = "0x37675B0", VA = "0x1837689B0", Slot = "7")]
		[ONOAPBNPKCD("This may be terminal and should probably do more than discarding the exception.")]
		public void KDNBJDBFCBD(Exception BJCOEJJDGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x334A060", Offset = "0x3348C60", VA = "0x18334A060", Slot = "4")]
		private void JNMELONNDMI([In] DGKNLHNBBJB<object, BNLEFJJKIPP> MGHLKGJFBCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class EMCLJAADOFJ : ELPOIGIDLCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DGKNLHNBBJB<object, BNLEFJJKIPP> BDCGBKCAPJN;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		private EMCLJAADOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3349FA0", Offset = "0x3348BA0", VA = "0x183349FA0")]
		public static EMCLJAADOFJ CIGBOGDFGOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x153DCD0", Offset = "0x153C8D0", VA = "0x18153DCD0")]
		public void NHDLDNBAENJ([In] DGKNLHNBBJB<object, BNLEFJJKIPP> MGHLKGJFBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		public void NIHIGLCAJMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40", Slot = "6")]
		public DGKNLHNBBJB<object, BNLEFJJKIPP> IJNNDKBINFL()
		{
			return default(DGKNLHNBBJB<object, BNLEFJJKIPP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x334A080", Offset = "0x3348C80", VA = "0x18334A080", Slot = "7")]
		[ONOAPBNPKCD("This may be terminal and should probably do more than discarding the exception.")]
		public void KDNBJDBFCBD(Exception BJCOEJJDGCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x334A060", Offset = "0x3348C60", VA = "0x18334A060", Slot = "4")]
		private void JNMELONNDMI([In] DGKNLHNBBJB<object, BNLEFJJKIPP> MGHLKGJFBCD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LDALKPCPOIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LLNPDPCMKAC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public FEAGCKDELFK<HHCCPIMKDMJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<DGKNLHNBBJB<object, BNLEFJJKIPP>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C006C0", Offset = "0x3BFF2C0", VA = "0x183C006C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C00C00", Offset = "0x3BFF800", VA = "0x183C00C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HPJLDCGPICJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LLNPDPCMKAC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FEAGCKDELFK<HHCCPIMKDMJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x388CB50", Offset = "0x388B750", VA = "0x18388CB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x388CF90", Offset = "0x388BB90", VA = "0x18388CF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JJPNLFBDAFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public LLNPDPCMKAC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public FEAGCKDELFK<HHCCPIMKDMJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public FEAGCKDELFK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3B026C0", Offset = "0x3B012C0", VA = "0x183B026C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B02D70", Offset = "0x3B01970", VA = "0x183B02D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BIOEFAMIBKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public LLNPDPCMKAC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FEAGCKDELFK<HHCCPIMKDMJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FEAGCKDELFK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ELPOIGIDLCM <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x478FF00", Offset = "0x478EB00", VA = "0x18478FF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4791800", Offset = "0x4790400", VA = "0x184791800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EJJMJDIBPOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public LLNPDPCMKAC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public ELPOIGIDLCM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private ELPOIGIDLCM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<DGKNLHNBBJB<object, BNLEFJJKIPP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3330D30", Offset = "0x332F930", VA = "0x183330D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3334A50", Offset = "0x3333650", VA = "0x183334A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps AJFJAGOPOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<FEAGCKDELFK<TMRequest>, TaskCompletionSource<DGKNLHNBBJB<object, BNLEFJJKIPP>>> BODDMHEFCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KMMDIPOGOMB<TMRequest> JMEECJBJJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int BBIFGCDEDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task LAHOAKHOAOI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps KGAJIIFEIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3C323A0", Offset = "0x3C30FA0", VA = "0x183C323A0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps NFIINEACBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C33BC0", Offset = "0x3C327C0", VA = "0x183C33BC0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps DCHLENFPCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3C32D80", Offset = "0x3C31980", VA = "0x183C32D80")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool EFABJEDBGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDDC690", Offset = "0xDDB290", VA = "0x180DDC690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11D1C80", Offset = "0x11D0880", VA = "0x1811D1C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OLDELBJMANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDD12B0", Offset = "0xDCFEB0", VA = "0x180DD12B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1CD36D0", Offset = "0x1CD22D0", VA = "0x181CD36D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JDBNFDKOIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CC0", Offset = "0x7B58C0", VA = "0x1807B6CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3C341B0", Offset = "0x3C32DB0", VA = "0x183C341B0")]
	public LLNPDPCMKAC(TDeps BNNGNHILECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3C33070", Offset = "0x3C31C70", VA = "0x183C33070")]
	public Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> HEFGECLCICM(TRoot EBCHPMPLBLG, TNetSys MLABKPIIOBG, FEAGCKDELFK<HHCCPIMKDMJ> FOGDIMNNGDP, TAction ODKDNEPMNIA, bool GKKMBFLEHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C32F10", Offset = "0x3C31B10", VA = "0x183C32F10")]
	[AsyncStateMachine(typeof(LLNPDPCMKAC<, , , , , , , , >.LDALKPCPOIB))]
	private Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> HEFGECLCICM(TRoot EBCHPMPLBLG, FEAGCKDELFK<HHCCPIMKDMJ> FOGDIMNNGDP, TAction ODKDNEPMNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3C33EF0", Offset = "0x3C32AF0", VA = "0x183C33EF0")]
	[AsyncStateMachine(typeof(LLNPDPCMKAC<, , , , , , , , >.HPJLDCGPICJ))]
	private Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> OGLHAKFAGDE(TRoot EBCHPMPLBLG, FEAGCKDELFK<HHCCPIMKDMJ> FOGDIMNNGDP, TAction[] OBCPCGLFBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C32A40", Offset = "0x3C31640", VA = "0x183C32A40")]
	[AsyncStateMachine(typeof(LLNPDPCMKAC<, , , , , , , , >.JJPNLFBDAFB))]
	public Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> BPHEMFKFDPH(TRoot EBCHPMPLBLG, TNetSys DCBDALDFANJ, TReceiver IPJAHGCJIBA, FEAGCKDELFK<HHCCPIMKDMJ> FOGDIMNNGDP, FEAGCKDELFK<TMRequest> MELOLDAMCEO, TAction ODKDNEPMNIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C33A40", Offset = "0x3C32640", VA = "0x183C33A40")]
	[AsyncStateMachine(typeof(LLNPDPCMKAC<, , , , , , , , >.BIOEFAMIBKO))]
	private Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> HHHCPHBDEJO(TRoot EBCHPMPLBLG, TNetSys DCBDALDFANJ, TReceiver IPJAHGCJIBA, FEAGCKDELFK<HHCCPIMKDMJ> FOGDIMNNGDP, FEAGCKDELFK<TMRequest> MELOLDAMCEO, TAction ODKDNEPMNIA, Task EEGOJBHIKBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C33DA0", Offset = "0x3C329A0", VA = "0x183C33DA0")]
	[AsyncStateMachine(typeof(LLNPDPCMKAC<, , , , , , , , >.EJJMJDIBPOC))]
	private Task LFPCALKDJAG(TRoot EBCHPMPLBLG, TNetSys DCBDALDFANJ, TReceiver IPJAHGCJIBA, TAction ODKDNEPMNIA, ELPOIGIDLCM ODNIAPAIAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C32760", Offset = "0x3C31360", VA = "0x183C32760")]
	private void BFOFFGLHIIG(TRoot EBCHPMPLBLG, TNetSys DCBDALDFANJ, TReceiver IPJAHGCJIBA, FEAGCKDELFK<HHCCPIMKDMJ> FOGDIMNNGDP, TAction ODKDNEPMNIA, bool FEOMCABAGAO, bool IGPPHDNNPJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BHNIIDLKBFO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface OKDNLNKHCOF<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CHOAMPOLBFL(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction GPMBGMPIPLL(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction DAGIFNJLAMO(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> ELBADFMBNBH(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] BDDJNCNGPGF(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA, int GGBMDIHGHPJ);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool MBNIGOIJLHF(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HLBJHLBGJEF(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool JJIOBEFBLLL(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool DPLCIFIJPAE(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool IINGDCEECDF(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool EENDEKCJGHI(TNetSys JKPOGACKCLN, TAction ODKDNEPMNIA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface IHINPDFNFCN<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps KGAJIIFEIEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps DCHLENFPCED
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps NFIINEACBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DEBNHMBIKMA<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FEAGCKDELFK<HHCCPIMKDMJ> OFIPPLPFHFP(TReceiver IPJAHGCJIBA);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<DGKNLHNBBJB<object, BNLEFJJKIPP>> BPHEMFKFDPH(TReceiver IPJAHGCJIBA, TAction ODKDNEPMNIA);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] KHPJFFDDEFK(TReceiver IPJAHGCJIBA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface MGFFKFGHLMP<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GNLGLBDBLDK(TRoot EBCHPMPLBLG);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int NBKOCBJKNJD(TRoot EBCHPMPLBLG);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int GIMKAJJHKCH(TRoot EBCHPMPLBLG);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int KMJLJHOHIGN(TRoot EBCHPMPLBLG);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PEOBGGOHPOP(TRoot EBCHPMPLBLG);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task HEFGECLCICM(TRoot EBCHPMPLBLG, FEAGCKDELFK<HHCCPIMKDMJ> FOGDIMNNGDP, FEAGCKDELFK<TMRequest> MELOLDAMCEO, TAction ODKDNEPMNIA, bool LFKMHEACNMP = true);
	}
}
namespace Cpp2IlInjected;

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
