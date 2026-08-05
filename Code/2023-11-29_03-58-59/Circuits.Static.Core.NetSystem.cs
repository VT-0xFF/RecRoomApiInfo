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
	[Cpp2IlInjected.Address(RVA = "0x3620610", Offset = "0x361FA10", VA = "0x183620610")]
	internal HPNCLNPMLNJ(TPartialAction[] CKMPKIKEAOH, int IGFOONMJMIE, TDeps MCFGCLDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3620540", Offset = "0x361F940", VA = "0x183620540")]
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
	[Cpp2IlInjected.Address(RVA = "0x22C88E0", Offset = "0x22C7CE0", VA = "0x1822C88E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3620660", Offset = "0x361FA60", VA = "0x183620660")]
	internal BHMHKPJIPJF(TPartialSnapshot[] FDCONPFGFBE, int CFGCGMEMLFB, TDeps MCFGCLDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36205B0", Offset = "0x361F9B0", VA = "0x1836205B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2661FB0", Offset = "0x26613B0", VA = "0x182661FB0")]
	public static PDAIFMGJHAK<TFullSnapshot> KFNICGDADJK<TFullSnapshot, TPartialSnapshot, TDeps>(this BHMHKPJIPJF<TPartialSnapshot, TFullSnapshot, TDeps> EAODMOEAJOC, TPartialSnapshot MNGFJEPEICE) where TDeps : FBPNNGPENPD<TPartialSnapshot, TFullSnapshot>
	{
		return default(PDAIFMGJHAK<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2661E60", Offset = "0x2661260", VA = "0x182661E60")]
	public static bool HDAHEHBIEMF<TPartialSnapshot, TFullSnapshot, TDeps>(this BHMHKPJIPJF<TPartialSnapshot, TFullSnapshot, TDeps> EAODMOEAJOC, TPartialSnapshot MNGFJEPEICE) where TDeps : FBPNNGPENPD<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class IKCIJCDGPCD : BPKDACEDAGC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCE9C0", Offset = "0x1CCDDC0", VA = "0x181CCE9C0", Slot = "7")]
	public override string KHDKMLPELIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCE9F0", Offset = "0x1CCDDF0", VA = "0x181CCE9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x39126B0", Offset = "0x3911AB0", VA = "0x1839126B0")]
		private JMDPNPEMGOB(TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> KGCILHALMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x376C9F0", Offset = "0x376BDF0", VA = "0x18376C9F0")]
		public static JMDPNPEMGOB PBDMNAJCIOP(TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> KGCILHALMAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3912420", Offset = "0x3911820", VA = "0x183912420")]
		public void CIOJKGFFBHM([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3912520", Offset = "0x3911920", VA = "0x183912520", Slot = "5")]
		public void JLLHMIIFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3912600", Offset = "0x3911A00", VA = "0x183912600", Slot = "6")]
		public EFPDAHOJLMO<object, CKBHJGGJPMD> ODOOEGBINOP()
		{
			return default(EFPDAHOJLMO<object, CKBHJGGJPMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39123C0", Offset = "0x39117C0", VA = "0x1839123C0", Slot = "7")]
		public void BMIANFLLHAA(Exception LLKMJCLKBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3565C40", Offset = "0x3565040", VA = "0x183565C40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x376C9F0", Offset = "0x376BDF0", VA = "0x18376C9F0")]
		public static LMKCPGNEEAM PBDMNAJCIOP(TaskCompletionSource<EFPDAHOJLMO<object, CKBHJGGJPMD>> KGCILHALMAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA3B0", Offset = "0x3AA97B0", VA = "0x183AAA3B0")]
		public void CIOJKGFFBHM([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA430", Offset = "0x3AA9830", VA = "0x183AAA430", Slot = "5")]
		public void JLLHMIIFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9FC980", Offset = "0x9FBD80", VA = "0x1809FC980", Slot = "6")]
		public EFPDAHOJLMO<object, CKBHJGGJPMD> ODOOEGBINOP()
		{
			return default(EFPDAHOJLMO<object, CKBHJGGJPMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA350", Offset = "0x3AA9750", VA = "0x183AAA350", Slot = "7")]
		public void BMIANFLLHAA(Exception LLKMJCLKBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3565C40", Offset = "0x3565040", VA = "0x183565C40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A8D690", Offset = "0x3A8CA90", VA = "0x183A8D690")]
		private LGBOCBOPFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x397B4D0", Offset = "0x397A8D0", VA = "0x18397B4D0")]
		public static LGBOCBOPFHF PBDMNAJCIOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D500", Offset = "0x3A8C900", VA = "0x183A8D500")]
		public void CIOJKGFFBHM([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void JLLHMIIFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D5D0", Offset = "0x3A8C9D0", VA = "0x183A8D5D0", Slot = "6")]
		public EFPDAHOJLMO<object, CKBHJGGJPMD> ODOOEGBINOP()
		{
			return default(EFPDAHOJLMO<object, CKBHJGGJPMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A8D3E0", Offset = "0x3A8C7E0", VA = "0x183A8D3E0", Slot = "7")]
		[GBPNDICKPEO("This may be terminal and should probably do more than discarding the exception.")]
		public void BMIANFLLHAA(Exception LLKMJCLKBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3565C40", Offset = "0x3565040", VA = "0x183565C40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x397B4D0", Offset = "0x397A8D0", VA = "0x18397B4D0")]
		public static KGAAEMGPJEM PBDMNAJCIOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x397B4B0", Offset = "0x397A8B0", VA = "0x18397B4B0")]
		public void CIOJKGFFBHM([In] EFPDAHOJLMO<object, CKBHJGGJPMD> KHFCBCPBAFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		public void JLLHMIIFFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB18E90", Offset = "0xB18290", VA = "0x180B18E90", Slot = "6")]
		public EFPDAHOJLMO<object, CKBHJGGJPMD> ODOOEGBINOP()
		{
			return default(EFPDAHOJLMO<object, CKBHJGGJPMD>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x397B410", Offset = "0x397A810", VA = "0x18397B410", Slot = "7")]
		[GBPNDICKPEO("This may be terminal and should probably do more than discarding the exception.")]
		public void BMIANFLLHAA(Exception LLKMJCLKBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3565C40", Offset = "0x3565040", VA = "0x183565C40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x310BBD0", Offset = "0x310AFD0", VA = "0x18310BBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x310C110", Offset = "0x310B510", VA = "0x18310C110", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x355A1A0", Offset = "0x35595A0", VA = "0x18355A1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x355A650", Offset = "0x3559A50", VA = "0x18355A650", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3555F30", Offset = "0x3555330", VA = "0x183555F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3556290", Offset = "0x3555690", VA = "0x183556290", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x373BFE0", Offset = "0x373B3E0", VA = "0x18373BFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x373D8E0", Offset = "0x373CCE0", VA = "0x18373D8E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F18580", Offset = "0x3F17980", VA = "0x183F18580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F1A330", Offset = "0x3F19730", VA = "0x183F1A330", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4DBCD40", Offset = "0x4DBC140", VA = "0x184DBCD40")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps MLECACEKOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD0D0", Offset = "0x4DBC4D0", VA = "0x184DBD0D0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps JKCDMBGPELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4DBB360", Offset = "0x4DBA760", VA = "0x184DBB360")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FIFPDNCNEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10CE2D0", Offset = "0x10CD6D0", VA = "0x1810CE2D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10CE2E0", Offset = "0x10CD6E0", VA = "0x1810CE2E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GHFHHIPFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1BB95E0", Offset = "0x1BB89E0", VA = "0x181BB95E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1BB98C0", Offset = "0x1BB8CC0", VA = "0x181BB98C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4DBD260", Offset = "0x4DBC660", VA = "0x184DBD260")]
	public DFFAFBCJPDJ(TDeps MCFGCLDLEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4DBC9D0", Offset = "0x4DBBDD0", VA = "0x184DBC9D0")]
	public Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> GIIHCJEOEGM(TRoot AFFGDBELLLE, TNetSys GFJLNKFDGON, JLMPPIICGFM<TMActor> ICKIHGGBMGE, TAction ONCLGAMIHNG, bool FEIACJOGPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4DBC870", Offset = "0x4DBBC70", VA = "0x184DBC870")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.EOKMFCBJDFJ))]
	private Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> GIIHCJEOEGM(TRoot AFFGDBELLLE, JLMPPIICGFM<TMActor> ICKIHGGBMGE, TAction ONCLGAMIHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4DBB4F0", Offset = "0x4DBA8F0", VA = "0x184DBB4F0")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.AEOCLNIMPNE))]
	private Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> CIFEADNMHKH(TRoot AFFGDBELLLE, JLMPPIICGFM<TMActor> ICKIHGGBMGE, TAction[] GMJIOIIHBBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4DBB7D0", Offset = "0x4DBABD0", VA = "0x184DBB7D0")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.AAJHDEONKBD))]
	public Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> ELPNAHPMMCO(TRoot AFFGDBELLLE, TNetSys HHFHEMKOADI, TReceiver DDJGFIBIACD, JLMPPIICGFM<TMActor> ICKIHGGBMGE, JLMPPIICGFM<TMRequest> HLGFKBPLPKF, TAction ONCLGAMIHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4DBCF00", Offset = "0x4DBC300", VA = "0x184DBCF00")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.IDIJJJEKGLN))]
	private Task<EFPDAHOJLMO<object, CKBHJGGJPMD>> JICDOGBECFJ(TRoot AFFGDBELLLE, TNetSys HHFHEMKOADI, TReceiver DDJGFIBIACD, JLMPPIICGFM<TMActor> ICKIHGGBMGE, JLMPPIICGFM<TMRequest> HLGFKBPLPKF, TAction ONCLGAMIHNG, Task DFFIHFLEIPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4DBB940", Offset = "0x4DBAD40", VA = "0x184DBB940")]
	[AsyncStateMachine(typeof(global::DFFAFBCJPDJ<, , , , , , , , , >.PIJEPCGKFMB))]
	private Task FDGCPKEAOHI(TRoot AFFGDBELLLE, TNetSys HHFHEMKOADI, TReceiver DDJGFIBIACD, TAction ONCLGAMIHNG, EENPJGLJGBO DPNOKIIKKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4DBBF80", Offset = "0x4DBB380", VA = "0x184DBBF80")]
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
