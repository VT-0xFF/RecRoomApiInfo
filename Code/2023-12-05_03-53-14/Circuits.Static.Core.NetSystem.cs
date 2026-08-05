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
public struct HPNCLNPMLNJ<TPartialAction, TFullAction, TDeps> where TDeps : BLMKPPHIKEC.FGGPLHOFOEM<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] KFDPAHADILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int LLBOIOHOBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps MHDAFDFFEGC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3621C20", Offset = "0x3621020", VA = "0x183621C20")]
	internal HPNCLNPMLNJ(TPartialAction[] CKMPKIKEAOH, int IGFOONMJMIE, TDeps MCFGCLDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3621B50", Offset = "0x3620F50", VA = "0x183621B50")]
	public static HPNCLNPMLNJ<TPartialAction, TFullAction, TDeps> PBDMNAJCIOP(TDeps MCFGCLDLEGH)
	{
		return default(HPNCLNPMLNJ<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BLMKPPHIKEC
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface FGGPLHOFOEM<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NKFJHOHPJEE([In] TPartialAction LPPOEBMEGAO);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction DNNAOJJOMEE(TPartialAction[] OKBEPBHAKGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22C89A0", Offset = "0x22C7DA0", VA = "0x1822C89A0")]
	public static PDAIFMGJHAK<TFullAction> KFNICGDADJK<TFullAction, TPartialAction, TDeps>(this HPNCLNPMLNJ<TPartialAction, TFullAction, TDeps> EAODMOEAJOC, TPartialAction LPPOEBMEGAO) where TDeps : FGGPLHOFOEM<TPartialAction, TFullAction>
	{
		return default(PDAIFMGJHAK<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BHMHKPJIPJF<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : OOEOBHGJGAL.FBPNNGPENPD<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] BIGMHLEPCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int JCDIPKLHJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps MHDAFDFFEGC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3621C70", Offset = "0x3621070", VA = "0x183621C70")]
	internal BHMHKPJIPJF(TPartialSnapshot[] FDCONPFGFBE, int CFGCGMEMLFB, TDeps MCFGCLDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3621BC0", Offset = "0x3620FC0", VA = "0x183621BC0")]
	public static BHMHKPJIPJF<TPartialSnapshot, TFullSnapshot, TDeps> PBDMNAJCIOP(TDeps MCFGCLDLEGH)
	{
		return default(BHMHKPJIPJF<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OOEOBHGJGAL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FBPNNGPENPD<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CFDPLGCCCML([In] TPartialSnapshot MNGFJEPEICE);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot APAPJFLCLMO(TPartialSnapshot[] AJGMPCJDNBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2662040", Offset = "0x2661440", VA = "0x182662040")]
	public static PDAIFMGJHAK<TFullSnapshot> KFNICGDADJK<TFullSnapshot, TPartialSnapshot, TDeps>(this BHMHKPJIPJF<TPartialSnapshot, TFullSnapshot, TDeps> EAODMOEAJOC, TPartialSnapshot MNGFJEPEICE) where TDeps : FBPNNGPENPD<TPartialSnapshot, TFullSnapshot>
	{
		return default(PDAIFMGJHAK<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2661EF0", Offset = "0x26612F0", VA = "0x182661EF0")]
	public static bool HDAHEHBIEMF<TPartialSnapshot, TFullSnapshot, TDeps>(this BHMHKPJIPJF<TPartialSnapshot, TFullSnapshot, TDeps> EAODMOEAJOC, TPartialSnapshot MNGFJEPEICE) where TDeps : FBPNNGPENPD<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class IKCIJCDGPCD : BPKDACEDAGC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCEBB0", Offset = "0x1CCDFB0", VA = "0x181CCEBB0", Slot = "7")]
	public override string KHDKMLPELIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCEBE0", Offset = "0x1CCDFE0", VA = "0x181CCEBE0")]
	public IKCIJCDGPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DFFAFBCJPDJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : NCEOAOLBKJK.BPKHNLENEKN<TAction, TNetSys> where TReceiverDeps : NCEOAOLBKJK.JJEEEHPHBKD<TMActor, TAction, TReceiver> where TRootDeps : NCEOAOLBKJK.KNALEBNNACM<TMRequest, TMActor, TAction, TRoot> where TDeps : NCEOAOLBKJK.FPNMJIFHKMH<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface EENPJGLJGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CIOJKGFFBHM([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JLLHMIIFFMJ();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EFPDAHOJLMO<object, CKBHJGGJPMD> ODOOEGBINOP();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BMIANFLLHAA(Exception LLKMJCLKBJP);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class JMDPNPEMGOB : EENPJGLJGBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> HLOGIIKAHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<EFPDAHOJLMO<object, MLDPNJCMKGI>> NFHPEFINDGF;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3913F10", Offset = "0x3913310", VA = "0x183913F10")]
		private JMDPNPEMGOB(TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> KGCILHALMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x376DFA0", Offset = "0x376D3A0", VA = "0x18376DFA0")]
		public static JMDPNPEMGOB PBDMNAJCIOP(TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> KGCILHALMAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3913AF0", Offset = "0x3912EF0", VA = "0x183913AF0")]
		public void CIOJKGFFBHM([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3913CD0", Offset = "0x39130D0", VA = "0x183913CD0", Slot = "5")]
		public void JLLHMIIFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3913E60", Offset = "0x3913260", VA = "0x183913E60", Slot = "6")]
		public EFPDAHOJLMO<object, CKBHJGGJPMD> ODOOEGBINOP()
		{
			return default(EFPDAHOJLMO<object, CKBHJGGJPMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3913990", Offset = "0x3912D90", VA = "0x183913990", Slot = "7")]
		public void BMIANFLLHAA(Exception LLKMJCLKBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x35636E0", Offset = "0x3562AE0", VA = "0x1835636E0", Slot = "4")]
		private void ACBJNDMNOMF([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class LMKCPGNEEAM : EENPJGLJGBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> HLOGIIKAHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EFPDAHOJLMO<object, CKBHJGGJPMD> ANCDMMLKOOB;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77C090", VA = "0x18077CC90")]
		private LMKCPGNEEAM(TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> KGCILHALMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x376DFA0", Offset = "0x376D3A0", VA = "0x18376DFA0")]
		public static LMKCPGNEEAM PBDMNAJCIOP(TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> KGCILHALMAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB820", Offset = "0x3AAAC20", VA = "0x183AAB820")]
		public void CIOJKGFFBHM([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB8A0", Offset = "0x3AAACA0", VA = "0x183AAB8A0", Slot = "5")]
		public void JLLHMIIFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FBE30", VA = "0x1809FCA30", Slot = "6")]
		public EFPDAHOJLMO<object, CKBHJGGJPMD> ODOOEGBINOP()
		{
			return default(EFPDAHOJLMO<object, CKBHJGGJPMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB7C0", Offset = "0x3AAABC0", VA = "0x183AAB7C0", Slot = "7")]
		public void BMIANFLLHAA(Exception LLKMJCLKBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x35636E0", Offset = "0x3562AE0", VA = "0x1835636E0", Slot = "4")]
		private void ACBJNDMNOMF([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class LGBOCBOPFHF : EENPJGLJGBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<EFPDAHOJLMO<object, CKBHJGGJPMD>> NFHPEFINDGF;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3A8EB00", Offset = "0x3A8DF00", VA = "0x183A8EB00")]
		private LGBOCBOPFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x397C9C0", Offset = "0x397BDC0", VA = "0x18397C9C0")]
		public static LGBOCBOPFHF PBDMNAJCIOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E970", Offset = "0x3A8DD70", VA = "0x183A8E970")]
		public void CIOJKGFFBHM([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void JLLHMIIFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A8EA40", Offset = "0x3A8DE40", VA = "0x183A8EA40", Slot = "6")]
		public EFPDAHOJLMO<object, CKBHJGGJPMD> ODOOEGBINOP()
		{
			return default(EFPDAHOJLMO<object, CKBHJGGJPMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E850", Offset = "0x3A8DC50", VA = "0x183A8E850", Slot = "7")]
		[GBPNDICKPEO("This may be terminal and should probably do more than discarding the exception.")]
		public void BMIANFLLHAA(Exception LLKMJCLKBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x35636E0", Offset = "0x3562AE0", VA = "0x1835636E0", Slot = "4")]
		private void ACBJNDMNOMF([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class KGAAEMGPJEM : EENPJGLJGBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private EFPDAHOJLMO<object, CKBHJGGJPMD> ANCDMMLKOOB;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		private KGAAEMGPJEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x397C9C0", Offset = "0x397BDC0", VA = "0x18397C9C0")]
		public static KGAAEMGPJEM PBDMNAJCIOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x397C9A0", Offset = "0x397BDA0", VA = "0x18397C9A0")]
		public void CIOJKGFFBHM([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void JLLHMIIFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB18F40", Offset = "0xB18340", VA = "0x180B18F40", Slot = "6")]
		public EFPDAHOJLMO<object, CKBHJGGJPMD> ODOOEGBINOP()
		{
			return default(EFPDAHOJLMO<object, CKBHJGGJPMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x397C900", Offset = "0x397BD00", VA = "0x18397C900", Slot = "7")]
		[GBPNDICKPEO("This may be terminal and should probably do more than discarding the exception.")]
		public void BMIANFLLHAA(Exception LLKMJCLKBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x35636E0", Offset = "0x3562AE0", VA = "0x1835636E0", Slot = "4")]
		private void ACBJNDMNOMF([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EOKMFCBJDFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::DFFAFBCJPDJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JLMPPIICGFM<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x310D1C0", Offset = "0x310C5C0", VA = "0x18310D1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x310D700", Offset = "0x310CB00", VA = "0x18310D700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AEOCLNIMPNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::DFFAFBCJPDJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JLMPPIICGFM<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3557C40", Offset = "0x3557040", VA = "0x183557C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x35580F0", Offset = "0x35574F0", VA = "0x1835580F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct AAJHDEONKBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::DFFAFBCJPDJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JLMPPIICGFM<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JLMPPIICGFM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x35539D0", Offset = "0x3552DD0", VA = "0x1835539D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3553D30", Offset = "0x3553130", VA = "0x183553D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IDIJJJEKGLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::DFFAFBCJPDJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public JLMPPIICGFM<TMActor> senderId;

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
		public JLMPPIICGFM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private EENPJGLJGBO <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x373D590", Offset = "0x373C990", VA = "0x18373D590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x373EE90", Offset = "0x373E290", VA = "0x18373EE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PIJEPCGKFMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::DFFAFBCJPDJ<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public EENPJGLJGBO completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EENPJGLJGBO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<EFPDAHOJLMO<object, CKBHJGGJPMD>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3F199A0", Offset = "0x3F18DA0", VA = "0x183F199A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F1B750", Offset = "0x3F1AB50", VA = "0x183F1B750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps MHDAFDFFEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<JLMPPIICGFM<TMRequest>, TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>>> EJCAGCBPANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private CLEGHFIENEJ<TMRequest> LGJLEONPNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int IMNBFAACEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task KOGBFALAPEC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps GHEHINENPHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4DBCC60", Offset = "0x4DBC060", VA = "0x184DBCC60")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps MLECACEKOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4DBCFF0", Offset = "0x4DBC3F0", VA = "0x184DBCFF0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps JKCDMBGPELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4DBB280", Offset = "0x4DBA680", VA = "0x184DBB280")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FIFPDNCNEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10CE380", Offset = "0x10CD780", VA = "0x1810CE380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10CE390", Offset = "0x10CD790", VA = "0x1810CE390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GHFHHIPFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1BB97D0", Offset = "0x1BB8BD0", VA = "0x181BB97D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1BB9AB0", Offset = "0x1BB8EB0", VA = "0x181BB9AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int COHFAINFOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x77B2F0", Offset = "0x77A6F0", VA = "0x18077B2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4DBD180", Offset = "0x4DBC580", VA = "0x184DBD180")]
	public DFFAFBCJPDJ(TDeps MCFGCLDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4DBC8F0", Offset = "0x4DBBCF0", VA = "0x184DBC8F0")]
	public Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> GIIHCJEOEGM(TRoot AFFGDBELLLE, TNetSys GFJLNKFDGON, JLMPPIICGFM<TMActor> ICKIHGGBMGE, TAction ONCLGAMIHNG, bool FEIACJOGPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4DBC790", Offset = "0x4DBBB90", VA = "0x184DBC790")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.EOKMFCBJDFJ))]
	private Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> GIIHCJEOEGM(TRoot AFFGDBELLLE, JLMPPIICGFM<TMActor> ICKIHGGBMGE, TAction ONCLGAMIHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4DBB410", Offset = "0x4DBA810", VA = "0x184DBB410")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.AEOCLNIMPNE))]
	private Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> CIFEADNMHKH(TRoot AFFGDBELLLE, JLMPPIICGFM<TMActor> ICKIHGGBMGE, TAction[] GMJIOIIHBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4DBB6F0", Offset = "0x4DBAAF0", VA = "0x184DBB6F0")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.AAJHDEONKBD))]
	public Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> ELPNAHPMMCO(TRoot AFFGDBELLLE, TNetSys HHFHEMKOADI, TReceiver DDJGFIBIACD, JLMPPIICGFM<TMActor> ICKIHGGBMGE, JLMPPIICGFM<TMRequest> HLGFKBPLPKF, TAction ONCLGAMIHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4DBCE20", Offset = "0x4DBC220", VA = "0x184DBCE20")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.IDIJJJEKGLN))]
	private Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> JICDOGBECFJ(TRoot AFFGDBELLLE, TNetSys HHFHEMKOADI, TReceiver DDJGFIBIACD, JLMPPIICGFM<TMActor> ICKIHGGBMGE, JLMPPIICGFM<TMRequest> HLGFKBPLPKF, TAction ONCLGAMIHNG, Task DFFIHFLEIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4DBB860", Offset = "0x4DBAC60", VA = "0x184DBB860")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.PIJEPCGKFMB))]
	private Task FDGCPKEAOHI(TRoot AFFGDBELLLE, TNetSys HHFHEMKOADI, TReceiver DDJGFIBIACD, TAction ONCLGAMIHNG, EENPJGLJGBO DPNOKIIKKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4DBBEA0", Offset = "0x4DBB2A0", VA = "0x184DBBEA0")]
	private void FFKEAGNMOJA(TRoot AFFGDBELLLE, TNetSys HHFHEMKOADI, TReceiver DDJGFIBIACD, JLMPPIICGFM<TMActor> ICKIHGGBMGE, TAction ONCLGAMIHNG, bool HDPFMEDFILN, bool NCIOKLAHHFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NCEOAOLBKJK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface BPKHNLENEKN<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OKGEIEONLOP(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction FKJDJNCCHJA(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction DFMNOPMHEBE(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> DFCNJMOPICB(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] NLHHKOBKNDP(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG, int INJPPNOBADM);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool KHJOLMHNDDK(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool PPLFCPECEJL(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IJAMLIJOFLF(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool ILGINBFEHHB(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool KGOIBKLJPMD(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool CAMJFEGNKHC(TNetSys LJPFKJLDINN, TAction ONCLGAMIHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface FPNMJIFHKMH<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps GHEHINENPHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps JKCDMBGPELJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps MLECACEKOMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface JJEEEHPHBKD<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JLMPPIICGFM<TMActor> CKGAAHMBNFN(TReceiver DDJGFIBIACD);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> ELPNAHPMMCO(TReceiver DDJGFIBIACD, TAction ONCLGAMIHNG);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] MMNGCJFDJGD(TReceiver DDJGFIBIACD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface KNALEBNNACM<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KBCDDBOGEKP(TRoot AFFGDBELLLE);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int IHLILOGCBFL(TRoot AFFGDBELLLE);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int KCALLCPKBGE(TRoot AFFGDBELLLE);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int EEFHBBBHPDE(TRoot AFFGDBELLLE);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EJPEDALMBBF(TRoot AFFGDBELLLE);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task GIIHCJEOEGM(TRoot AFFGDBELLLE, JLMPPIICGFM<TMActor> ICKIHGGBMGE, JLMPPIICGFM<TMRequest> HLGFKBPLPKF, TAction ONCLGAMIHNG, bool AIHJEIGGBDK = true);
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
