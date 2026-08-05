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
public struct IAKLEJCIEOM<TPartialAction, TFullAction, TDeps> where TDeps : POICDENFELB.JLADOGCNHGF<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] LMGJMDDDBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int JPMIKECKMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps BCBDJODLAEE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x38C47C0", Offset = "0x38C3BC0", VA = "0x1838C47C0")]
	internal IAKLEJCIEOM(TPartialAction[] OJMJPNNINHA, int HFCLMPBCJLK, TDeps BFMHNHDBGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38C46F0", Offset = "0x38C3AF0", VA = "0x1838C46F0")]
	public static IAKLEJCIEOM<TPartialAction, TFullAction, TDeps> PIJMMFMEPKL(TDeps BFMHNHDBGGN)
	{
		return default(IAKLEJCIEOM<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class POICDENFELB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JLADOGCNHGF<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DGNMCEEMEGM([In] TPartialAction NEDJGBBPLAE);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction LFGPDFHNFNN(TPartialAction[] MMFFNLNIEHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x279F5C0", Offset = "0x279E9C0", VA = "0x18279F5C0")]
	public static NMGFKHEHGDM<TFullAction> BKHNLAAEMPK<TFullAction, TPartialAction, TDeps>(this IAKLEJCIEOM<TPartialAction, TFullAction, TDeps> LHCHBOKBAPK, TPartialAction NEDJGBBPLAE) where TDeps : JLADOGCNHGF<TPartialAction, TFullAction>
	{
		return default(NMGFKHEHGDM<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OCGDFHJCFNJ<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : LHJMDCAAFGG.MLDEBNHELCH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] JFCNPNDNDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int GPOCOKOBCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps BCBDJODLAEE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x38C47C0", Offset = "0x38C3BC0", VA = "0x1838C47C0")]
	internal OCGDFHJCFNJ(TPartialSnapshot[] PJAKIJKOGEL, int KNEOJBOCAID, TDeps BFMHNHDBGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38C46F0", Offset = "0x38C3AF0", VA = "0x1838C46F0")]
	public static OCGDFHJCFNJ<TPartialSnapshot, TFullSnapshot, TDeps> PIJMMFMEPKL(TDeps BFMHNHDBGGN)
	{
		return default(OCGDFHJCFNJ<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LHJMDCAAFGG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MLDEBNHELCH<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MOOFJHJGBKO([In] TPartialSnapshot DCOAHGHIADK);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot NNGKCMELOPJ(TPartialSnapshot[] LCBOCFJGGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26AF660", Offset = "0x26AEA60", VA = "0x1826AF660")]
	public static NMGFKHEHGDM<TFullSnapshot> BKHNLAAEMPK<TFullSnapshot, TPartialSnapshot, TDeps>(this OCGDFHJCFNJ<TPartialSnapshot, TFullSnapshot, TDeps> LHCHBOKBAPK, TPartialSnapshot DCOAHGHIADK) where TDeps : MLDEBNHELCH<TPartialSnapshot, TFullSnapshot>
	{
		return default(NMGFKHEHGDM<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x26AFA10", Offset = "0x26AEE10", VA = "0x1826AFA10")]
	public static bool HFOIDENIDAB<TPartialSnapshot, TFullSnapshot, TDeps>(this OCGDFHJCFNJ<TPartialSnapshot, TFullSnapshot, TDeps> LHCHBOKBAPK, TPartialSnapshot DCOAHGHIADK) where TDeps : MLDEBNHELCH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class MKGCOPALCOF : GOLJEOBBMJE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D233F0", Offset = "0x1D227F0", VA = "0x181D233F0", Slot = "7")]
	public override string GPDEFFKCMGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D23420", Offset = "0x1D22820", VA = "0x181D23420")]
	public MKGCOPALCOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MBJHDOJAABG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : DLPCGGHNGEA.LOPGOAMIJMK<TAction, TNetSys> where TReceiverDeps : DLPCGGHNGEA.AIFKLHHOEOP<TMActor, TAction, TReceiver> where TRootDeps : DLPCGGHNGEA.PCJOHOLDPEI<TMRequest, TMActor, TAction, TRoot> where TDeps : DLPCGGHNGEA.COGPJIAIIDD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface IOGHJLNPCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GOMGAJDBKMN([In] EGECKPFNJNE<object, APEAMGBOOBA> APCONDCGDJA);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FJLAPMANCCF();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EGECKPFNJNE<object, APEAMGBOOBA> EFMMBLNBMGC();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CJJJKGFOHPA(Exception EAIHDKDABHO);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class GGHLCCBHGAD : IOGHJLNPCEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<EGECKPFNJNE<object, APEAMGBOOBA>> OGCDPJGDPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<EGECKPFNJNE<object, IGBINOOJKPE>> CKFEBPOMBGO;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x377C800", Offset = "0x377BC00", VA = "0x18377C800")]
		private GGHLCCBHGAD(TaskCompletionSource<EGECKPFNJNE<object, APEAMGBOOBA>> DBEOHBPJKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x377C690", Offset = "0x377BA90", VA = "0x18377C690")]
		public static GGHLCCBHGAD PIJMMFMEPKL(TaskCompletionSource<EGECKPFNJNE<object, APEAMGBOOBA>> DBEOHBPJKIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x377C490", Offset = "0x377B890", VA = "0x18377C490")]
		public void GOMGAJDBKMN([In] EGECKPFNJNE<object, APEAMGBOOBA> APCONDCGDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x377C2D0", Offset = "0x377B6D0", VA = "0x18377C2D0", Slot = "5")]
		public void FJLAPMANCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x377C170", Offset = "0x377B570", VA = "0x18377C170", Slot = "6")]
		public EGECKPFNJNE<object, APEAMGBOOBA> EFMMBLNBMGC()
		{
			return default(EGECKPFNJNE<object, APEAMGBOOBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x377C0B0", Offset = "0x377B4B0", VA = "0x18377C0B0", Slot = "7")]
		public void CJJJKGFOHPA(Exception EAIHDKDABHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3773180", Offset = "0x3772580", VA = "0x183773180", Slot = "4")]
		private void HBLEAJMFLJC([In] EGECKPFNJNE<object, APEAMGBOOBA> APCONDCGDJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class AOPHGLNNHNE : IOGHJLNPCEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<EGECKPFNJNE<object, APEAMGBOOBA>> OGCDPJGDPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EGECKPFNJNE<object, APEAMGBOOBA> EEBDFGHEJKF;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
		private AOPHGLNNHNE(TaskCompletionSource<EGECKPFNJNE<object, APEAMGBOOBA>> DBEOHBPJKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x377C690", Offset = "0x377BA90", VA = "0x18377C690")]
		public static AOPHGLNNHNE PIJMMFMEPKL(TaskCompletionSource<EGECKPFNJNE<object, APEAMGBOOBA>> DBEOHBPJKIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x38A1EB0", Offset = "0x38A12B0", VA = "0x1838A1EB0")]
		public void GOMGAJDBKMN([In] EGECKPFNJNE<object, APEAMGBOOBA> APCONDCGDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x38A1E50", Offset = "0x38A1250", VA = "0x1838A1E50", Slot = "5")]
		public void FJLAPMANCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA31A50", Offset = "0xA30E50", VA = "0x180A31A50", Slot = "6")]
		public EGECKPFNJNE<object, APEAMGBOOBA> EFMMBLNBMGC()
		{
			return default(EGECKPFNJNE<object, APEAMGBOOBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x38A1D90", Offset = "0x38A1190", VA = "0x1838A1D90", Slot = "7")]
		public void CJJJKGFOHPA(Exception EAIHDKDABHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3773180", Offset = "0x3772580", VA = "0x183773180", Slot = "4")]
		private void HBLEAJMFLJC([In] EGECKPFNJNE<object, APEAMGBOOBA> APCONDCGDJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class DLFDIGGIKGN : IOGHJLNPCEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<EGECKPFNJNE<object, APEAMGBOOBA>> CKFEBPOMBGO;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4FB0700", Offset = "0x4FAFB00", VA = "0x184FB0700")]
		private DLFDIGGIKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3E92B90", Offset = "0x3E91F90", VA = "0x183E92B90")]
		public static DLFDIGGIKGN PIJMMFMEPKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4FB0630", Offset = "0x4FAFA30", VA = "0x184FB0630")]
		public void GOMGAJDBKMN([In] EGECKPFNJNE<object, APEAMGBOOBA> APCONDCGDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		public void FJLAPMANCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4FB0500", Offset = "0x4FAF900", VA = "0x184FB0500", Slot = "6")]
		public EGECKPFNJNE<object, APEAMGBOOBA> EFMMBLNBMGC()
		{
			return default(EGECKPFNJNE<object, APEAMGBOOBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4FB0450", Offset = "0x4FAF850", VA = "0x184FB0450", Slot = "7")]
		[BHFIKJBBKEL("This may be terminal and should probably do more than discarding the exception.")]
		public void CJJJKGFOHPA(Exception EAIHDKDABHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3773180", Offset = "0x3772580", VA = "0x183773180", Slot = "4")]
		private void HBLEAJMFLJC([In] EGECKPFNJNE<object, APEAMGBOOBA> APCONDCGDJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class NHFFHHNCDBF : IOGHJLNPCEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EGECKPFNJNE<object, APEAMGBOOBA> EEBDFGHEJKF;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		private NHFFHHNCDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3E92B90", Offset = "0x3E91F90", VA = "0x183E92B90")]
		public static NHFFHHNCDBF PIJMMFMEPKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1476B20", Offset = "0x1475F20", VA = "0x181476B20")]
		public void GOMGAJDBKMN([In] EGECKPFNJNE<object, APEAMGBOOBA> APCONDCGDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		public void FJLAPMANCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0", Slot = "6")]
		public EGECKPFNJNE<object, APEAMGBOOBA> EFMMBLNBMGC()
		{
			return default(EGECKPFNJNE<object, APEAMGBOOBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3E92B40", Offset = "0x3E91F40", VA = "0x183E92B40", Slot = "7")]
		[BHFIKJBBKEL("This may be terminal and should probably do more than discarding the exception.")]
		public void CJJJKGFOHPA(Exception EAIHDKDABHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3773180", Offset = "0x3772580", VA = "0x183773180", Slot = "4")]
		private void HBLEAJMFLJC([In] EGECKPFNJNE<object, APEAMGBOOBA> APCONDCGDJA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CCBFPOCBFAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::MBJHDOJAABG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public AFJMJHOPNGM<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<EGECKPFNJNE<object, APEAMGBOOBA>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x49BDEA0", Offset = "0x49BD2A0", VA = "0x1849BDEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x49BE950", Offset = "0x49BDD50", VA = "0x1849BE950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct OGBANBMGKLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::MBJHDOJAABG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AFJMJHOPNGM<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3F96670", Offset = "0x3F95A70", VA = "0x183F96670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3F96B20", Offset = "0x3F95F20", VA = "0x183F96B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct AIFKFFFLMAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::MBJHDOJAABG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AFJMJHOPNGM<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AFJMJHOPNGM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x374E760", Offset = "0x374DB60", VA = "0x18374E760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x374EAC0", Offset = "0x374DEC0", VA = "0x18374EAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AOBHLPIJMMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::MBJHDOJAABG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AFJMJHOPNGM<TMActor> senderId;

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
		public AFJMJHOPNGM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IOGHJLNPCEE <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x38A0C80", Offset = "0x38A0080", VA = "0x1838A0C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x38A18B0", Offset = "0x38A0CB0", VA = "0x1838A18B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KHKOOJPOPBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::MBJHDOJAABG<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public IOGHJLNPCEE completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IOGHJLNPCEE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3B3A310", Offset = "0x3B39710", VA = "0x183B3A310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3B3DFD0", Offset = "0x3B3D3D0", VA = "0x183B3DFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps BCBDJODLAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<AFJMJHOPNGM<TMRequest>, TaskCompletionSource<EGECKPFNJNE<object, APEAMGBOOBA>>> CEFKLHCIHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private PKDIDNOPFIN<TMRequest> DAJPFIIKHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int MBBEFGFBCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task KIIMLBEJOAI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps PCONLKADPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB2A0", Offset = "0x3DFA6A0", VA = "0x183DFB2A0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps EONONHCDMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAF60", Offset = "0x3DFA360", VA = "0x183DFAF60")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps EJEMODHDEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3DFAE90", Offset = "0x3DFA290", VA = "0x183DFAE90")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JOPICPMDMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x110D810", Offset = "0x110CC10", VA = "0x18110D810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x110D820", Offset = "0x110CC20", VA = "0x18110D820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EJEPOIBLHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1C09470", Offset = "0x1C08870", VA = "0x181C09470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1C09750", Offset = "0x1C08B50", VA = "0x181C09750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JGOBFJEHBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x797290", Offset = "0x796690", VA = "0x180797290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB990", Offset = "0x3DFAD90", VA = "0x183DFB990")]
	public MBJHDOJAABG(TDeps BFMHNHDBGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DFA750", Offset = "0x3DF9B50", VA = "0x183DFA750")]
	public Task<EGECKPFNJNE<object, APEAMGBOOBA>> FOCILJLKANI(TRoot MMKDJDGOBEM, TNetSys IHKOJIGFOON, AFJMJHOPNGM<TMActor> LMKNMDIBABJ, TAction EEEBGEOHFMI, bool CDDKLPOEMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DFAA70", Offset = "0x3DF9E70", VA = "0x183DFAA70")]
	[AsyncStateMachine(typeof(global::MBJHDOJAABG<, , , , , , , , , >.CCBFPOCBFAC))]
	private Task<EGECKPFNJNE<object, APEAMGBOOBA>> FOCILJLKANI(TRoot MMKDJDGOBEM, AFJMJHOPNGM<TMActor> LMKNMDIBABJ, TAction EEEBGEOHFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3DFABD0", Offset = "0x3DF9FD0", VA = "0x183DFABD0")]
	[AsyncStateMachine(typeof(global::MBJHDOJAABG<, , , , , , , , , >.OGBANBMGKLA))]
	private Task<EGECKPFNJNE<object, APEAMGBOOBA>> IKOPAICCIAD(TRoot MMKDJDGOBEM, AFJMJHOPNGM<TMActor> LMKNMDIBABJ, TAction[] HDLHNKOGPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9B30", Offset = "0x3DF8F30", VA = "0x183DF9B30")]
	[AsyncStateMachine(typeof(global::MBJHDOJAABG<, , , , , , , , , >.AIFKFFFLMAJ))]
	public Task<EGECKPFNJNE<object, APEAMGBOOBA>> BFPDLBPHOHP(TRoot MMKDJDGOBEM, TNetSys AILNBNEGNDN, TReceiver PBGFHGDDDAM, AFJMJHOPNGM<TMActor> LMKNMDIBABJ, AFJMJHOPNGM<TMRequest> MPBLJIGCKLO, TAction EEEBGEOHFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB120", Offset = "0x3DFA520", VA = "0x183DFB120")]
	[AsyncStateMachine(typeof(global::MBJHDOJAABG<, , , , , , , , , >.AOBHLPIJMMP))]
	private Task<EGECKPFNJNE<object, APEAMGBOOBA>> MGJLAPKACKK(TRoot MMKDJDGOBEM, TNetSys AILNBNEGNDN, TReceiver PBGFHGDDDAM, AFJMJHOPNGM<TMActor> LMKNMDIBABJ, AFJMJHOPNGM<TMRequest> MPBLJIGCKLO, TAction EEEBGEOHFMI, Task JJPKABDLPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF9F80", Offset = "0x3DF9380", VA = "0x183DF9F80")]
	[AsyncStateMachine(typeof(global::MBJHDOJAABG<, , , , , , , , , >.KHKOOJPOPBL))]
	private Task DADFIKHJNAO(TRoot MMKDJDGOBEM, TNetSys AILNBNEGNDN, TReceiver PBGFHGDDDAM, TAction EEEBGEOHFMI, IOGHJLNPCEE NENAMOHJEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFB6B0", Offset = "0x3DFAAB0", VA = "0x183DFB6B0")]
	private void PDAMHHGGEKM(TRoot MMKDJDGOBEM, TNetSys AILNBNEGNDN, TReceiver PBGFHGDDDAM, AFJMJHOPNGM<TMActor> LMKNMDIBABJ, TAction EEEBGEOHFMI, bool FAAJAPHMFKM, bool LANINKNCLOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DLPCGGHNGEA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface LOPGOAMIJMK<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PDCMCILBHFM(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction FLOPGMKFDIL(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction JDFNGMNKLOL(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> CMCGCBFFCGI(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] BGKLHILNBBF(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI, int LNBDAKHHFJB);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BNCIPDCMCJO(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DCBEBCBEAOH(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool GCPKBDDJBNC(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LPAPMPDPFGG(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool DCJBDHOJNHH(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool BIBHDMOGMMN(TNetSys AICHEBOPGIK, TAction EEEBGEOHFMI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface COGPJIAIIDD<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps PCONLKADPLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps EJEMODHDEDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps EONONHCDMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface AIFKLHHOEOP<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AFJMJHOPNGM<TMActor> FIDOELKJCAI(TReceiver PBGFHGDDDAM);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<EGECKPFNJNE<object, APEAMGBOOBA>> BFPDLBPHOHP(TReceiver PBGFHGDDDAM, TAction EEEBGEOHFMI);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] HDOJFEJNAEL(TReceiver PBGFHGDDDAM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface PCJOHOLDPEI<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NHFKONMGNBH(TRoot MMKDJDGOBEM);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int PBNOECOOPMN(TRoot MMKDJDGOBEM);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MECLAPGONEN(TRoot MMKDJDGOBEM);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int AIJILBLGAOB(TRoot MMKDJDGOBEM);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KKFGACLFMFN(TRoot MMKDJDGOBEM);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task FOCILJLKANI(TRoot MMKDJDGOBEM, AFJMJHOPNGM<TMActor> LMKNMDIBABJ, AFJMJHOPNGM<TMRequest> MPBLJIGCKLO, TAction EEEBGEOHFMI, bool DHHFKBHJDHD = true);
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
