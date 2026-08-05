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
public struct JNEIBOCCAPI<TPartialAction, TFullAction, TDeps> where TDeps : INAMNCOIDAJ.GEJCBPMJGGA<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] ILMDMGJHFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int PLFJIGEGNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps KDDFIFIFPAP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C31EE0", Offset = "0x3C310E0", VA = "0x183C31EE0")]
	internal JNEIBOCCAPI(TPartialAction[] FJPHIFAHINN, int LDNIHFOLAKH, TDeps NMAKCOKENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C31E10", Offset = "0x3C31010", VA = "0x183C31E10")]
	public static JNEIBOCCAPI<TPartialAction, TFullAction, TDeps> MIJABIECKKD(TDeps NMAKCOKENKA)
	{
		return default(JNEIBOCCAPI<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class INAMNCOIDAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface GEJCBPMJGGA<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CJHINBJIINH([In] TPartialAction LKEDIBHLMPC);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction JDLJLJNIBFE(TPartialAction[] FAJJFEHMODK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2930C90", Offset = "0x292FE90", VA = "0x182930C90")]
	public static PKNGEFGGMEI<TFullAction> ACJFFJINDLI<TFullAction, TPartialAction, TDeps>(this JNEIBOCCAPI<TPartialAction, TFullAction, TDeps> KNKOEEEKHDK, TPartialAction LKEDIBHLMPC) where TDeps : GEJCBPMJGGA<TPartialAction, TFullAction>
	{
		return default(PKNGEFGGMEI<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NFLBDBNOJJB<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : PJJPJAOJNCG.NFLLPKCHPKM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] MBDFOJEBKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int NKLKMKBFKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps KDDFIFIFPAP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C31EE0", Offset = "0x3C310E0", VA = "0x183C31EE0")]
	internal NFLBDBNOJJB(TPartialSnapshot[] HIBFGJPDFII, int CCHCPNIICNP, TDeps NMAKCOKENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C31E10", Offset = "0x3C31010", VA = "0x183C31E10")]
	public static NFLBDBNOJJB<TPartialSnapshot, TFullSnapshot, TDeps> MIJABIECKKD(TDeps NMAKCOKENKA)
	{
		return default(NFLBDBNOJJB<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PJJPJAOJNCG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NFLLPKCHPKM<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PBLFINKNFBB([In] TPartialSnapshot LEMLAGDKCNH);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot NGKPHMMOPKI(TPartialSnapshot[] AGCJACPAOEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C800", Offset = "0x2A6BA00", VA = "0x182A6C800")]
	public static PKNGEFGGMEI<TFullSnapshot> ACJFFJINDLI<TFullSnapshot, TPartialSnapshot, TDeps>(this NFLBDBNOJJB<TPartialSnapshot, TFullSnapshot, TDeps> KNKOEEEKHDK, TPartialSnapshot LEMLAGDKCNH) where TDeps : NFLLPKCHPKM<TPartialSnapshot, TFullSnapshot>
	{
		return default(PKNGEFGGMEI<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2A6C960", Offset = "0x2A6BB60", VA = "0x182A6C960")]
	public static bool BOKGIBJKGGF<TPartialSnapshot, TFullSnapshot, TDeps>(this NFLBDBNOJJB<TPartialSnapshot, TFullSnapshot, TDeps> KNKOEEEKHDK, TPartialSnapshot LEMLAGDKCNH) where TDeps : NFLLPKCHPKM<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class JNCJLHDMINP : NNADKGMIMDE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E58FA0", Offset = "0x1E581A0", VA = "0x181E58FA0", Slot = "7")]
	public override string FIHEJJCABJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E58FD0", Offset = "0x1E581D0", VA = "0x181E58FD0")]
	public JNCJLHDMINP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FJPEGJGDKEI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : MJAHKGBLMAK.MHBHJFCKOBB<TAction, TNetSys> where TReceiverDeps : MJAHKGBLMAK.MMGEAFANICP<TAction, TReceiver> where TRootDeps : MJAHKGBLMAK.JJFKIGKALIJ<TMRequest, TAction, TRoot> where TDeps : MJAHKGBLMAK.EJOCKAMAGDN<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface IMDCIINMCHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KPJMLFGPDBF([In] NFMFLMAOFMP<object, CEGADOEINOB> HCIDHCBMOPD);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OOAPDMBMIDH();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NFMFLMAOFMP<object, CEGADOEINOB> LNNDLPJIPCI();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GDPLOJLGJOF(Exception PGAHDJGBLJL);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class AFANHFIDIOJ : IMDCIINMCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<NFMFLMAOFMP<object, CEGADOEINOB>> AMDKHJIPNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<NFMFLMAOFMP<object, LNFCDOMCNGI>> MFEBCKPOIPI;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x388C430", Offset = "0x388B630", VA = "0x18388C430")]
		private AFANHFIDIOJ(TaskCompletionSource<NFMFLMAOFMP<object, CEGADOEINOB>> MECAMIGLBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x388C110", Offset = "0x388B310", VA = "0x18388C110")]
		public static AFANHFIDIOJ MIJABIECKKD(TaskCompletionSource<NFMFLMAOFMP<object, CEGADOEINOB>> MECAMIGLBGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x388BEB0", Offset = "0x388B0B0", VA = "0x18388BEB0")]
		public void KPJMLFGPDBF([In] NFMFLMAOFMP<object, CEGADOEINOB> HCIDHCBMOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x388C2B0", Offset = "0x388B4B0", VA = "0x18388C2B0", Slot = "5")]
		public void OOAPDMBMIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x388C060", Offset = "0x388B260", VA = "0x18388C060", Slot = "6")]
		public NFMFLMAOFMP<object, CEGADOEINOB> LNNDLPJIPCI()
		{
			return default(NFMFLMAOFMP<object, CEGADOEINOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x388BD30", Offset = "0x388AF30", VA = "0x18388BD30", Slot = "7")]
		public void GDPLOJLGJOF(Exception PGAHDJGBLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x388BD90", Offset = "0x388AF90", VA = "0x18388BD90", Slot = "4")]
		private void HDGOHLDDKBA([In] NFMFLMAOFMP<object, CEGADOEINOB> HCIDHCBMOPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class AIDGEPBODIH : IMDCIINMCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<NFMFLMAOFMP<object, CEGADOEINOB>> AMDKHJIPNKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NFMFLMAOFMP<object, CEGADOEINOB> CHOGMEKINCM;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
		private AIDGEPBODIH(TaskCompletionSource<NFMFLMAOFMP<object, CEGADOEINOB>> MECAMIGLBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x388C110", Offset = "0x388B310", VA = "0x18388C110")]
		public static AIDGEPBODIH MIJABIECKKD(TaskCompletionSource<NFMFLMAOFMP<object, CEGADOEINOB>> MECAMIGLBGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3473E70", Offset = "0x3473070", VA = "0x183473E70")]
		public void KPJMLFGPDBF([In] NFMFLMAOFMP<object, CEGADOEINOB> HCIDHCBMOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3A03010", Offset = "0x3A02210", VA = "0x183A03010", Slot = "5")]
		public void OOAPDMBMIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAEBD30", Offset = "0xAEAF30", VA = "0x180AEBD30", Slot = "6")]
		public NFMFLMAOFMP<object, CEGADOEINOB> LNNDLPJIPCI()
		{
			return default(NFMFLMAOFMP<object, CEGADOEINOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3A02F50", Offset = "0x3A02150", VA = "0x183A02F50", Slot = "7")]
		public void GDPLOJLGJOF(Exception PGAHDJGBLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x388BD90", Offset = "0x388AF90", VA = "0x18388BD90", Slot = "4")]
		private void HDGOHLDDKBA([In] NFMFLMAOFMP<object, CEGADOEINOB> HCIDHCBMOPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class AJFICGPEGIE : IMDCIINMCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<NFMFLMAOFMP<object, CEGADOEINOB>> MFEBCKPOIPI;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3A08390", Offset = "0x3A07590", VA = "0x183A08390")]
		private AJFICGPEGIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x391DCB0", Offset = "0x391CEB0", VA = "0x18391DCB0")]
		public static AJFICGPEGIE MIJABIECKKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A080A0", Offset = "0x3A072A0", VA = "0x183A080A0")]
		public void KPJMLFGPDBF([In] NFMFLMAOFMP<object, CEGADOEINOB> HCIDHCBMOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void OOAPDMBMIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A08240", Offset = "0x3A07440", VA = "0x183A08240", Slot = "6")]
		public NFMFLMAOFMP<object, CEGADOEINOB> LNNDLPJIPCI()
		{
			return default(NFMFLMAOFMP<object, CEGADOEINOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A08050", Offset = "0x3A07250", VA = "0x183A08050", Slot = "7")]
		[HHAPCIPDAID("This may be terminal and should probably do more than discarding the exception.")]
		public void GDPLOJLGJOF(Exception PGAHDJGBLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x388BD90", Offset = "0x388AF90", VA = "0x18388BD90", Slot = "4")]
		private void HDGOHLDDKBA([In] NFMFLMAOFMP<object, CEGADOEINOB> HCIDHCBMOPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class HDBENAPOOCL : IMDCIINMCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NFMFLMAOFMP<object, CEGADOEINOB> CHOGMEKINCM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private HDBENAPOOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x391DCB0", Offset = "0x391CEB0", VA = "0x18391DCB0")]
		public static HDBENAPOOCL MIJABIECKKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x156BDD0", Offset = "0x156AFD0", VA = "0x18156BDD0")]
		public void KPJMLFGPDBF([In] NFMFLMAOFMP<object, CEGADOEINOB> HCIDHCBMOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void OOAPDMBMIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x843A80", Offset = "0x842C80", VA = "0x180843A80", Slot = "6")]
		public NFMFLMAOFMP<object, CEGADOEINOB> LNNDLPJIPCI()
		{
			return default(NFMFLMAOFMP<object, CEGADOEINOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x391DC60", Offset = "0x391CE60", VA = "0x18391DC60", Slot = "7")]
		[HHAPCIPDAID("This may be terminal and should probably do more than discarding the exception.")]
		public void GDPLOJLGJOF(Exception PGAHDJGBLJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x388BD90", Offset = "0x388AF90", VA = "0x18388BD90", Slot = "4")]
		private void HDGOHLDDKBA([In] NFMFLMAOFMP<object, CEGADOEINOB> HCIDHCBMOPD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct BBBOKLHHEGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FJPEGJGDKEI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EIPPGFCFCGI<JMEIIMJEHGK> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<NFMFLMAOFMP<object, CEGADOEINOB>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x48904C0", Offset = "0x488F6C0", VA = "0x1848904C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4890F40", Offset = "0x4890140", VA = "0x184890F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DNOKBJNJPIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public FJPEGJGDKEI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public EIPPGFCFCGI<JMEIIMJEHGK> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5137F40", Offset = "0x5137140", VA = "0x185137F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5138370", Offset = "0x5137570", VA = "0x185138370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IOIDEBGPKPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public FJPEGJGDKEI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public EIPPGFCFCGI<JMEIIMJEHGK> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public EIPPGFCFCGI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3A613E0", Offset = "0x3A605E0", VA = "0x183A613E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A617A0", Offset = "0x3A609A0", VA = "0x183A617A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OHBAHOIHONH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public FJPEGJGDKEI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public EIPPGFCFCGI<JMEIIMJEHGK> senderId;

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
		public EIPPGFCFCGI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IMDCIINMCHK <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4184AE0", Offset = "0x4183CE0", VA = "0x184184AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4185670", Offset = "0x4184870", VA = "0x184185670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct MAKBHEMFECM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FJPEGJGDKEI<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public IMDCIINMCHK completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IMDCIINMCHK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3F413C0", Offset = "0x3F405C0", VA = "0x183F413C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F43090", Offset = "0x3F42290", VA = "0x183F43090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps KDDFIFIFPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<EIPPGFCFCGI<TMRequest>, TaskCompletionSource<NFMFLMAOFMP<object, CEGADOEINOB>>> DPLMNFKCMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private PDADCPILJAK<TMRequest> AEFOBBFKJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int OBLOLKLDFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task FGDNIMCBBHA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps LAEOOFOKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3808F20", Offset = "0x3808120", VA = "0x183808F20")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps CIACHFMCOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3808440", Offset = "0x3807640", VA = "0x183808440")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps HDIBIHEKLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3809580", Offset = "0x3808780", VA = "0x183809580")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BCLKHJCMPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDF14F0", Offset = "0xDF06F0", VA = "0x180DF14F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11F2A60", Offset = "0x11F1C60", VA = "0x1811F2A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EFENAADBCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDF3000", Offset = "0xDF2200", VA = "0x180DF3000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1D1FB80", Offset = "0x1D1ED80", VA = "0x181D1FB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MCAPIDCIJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B9980", Offset = "0x7B8B80", VA = "0x1807B9980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x38098B0", Offset = "0x3808AB0", VA = "0x1838098B0")]
	public FJPEGJGDKEI(TDeps NMAKCOKENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x38084C0", Offset = "0x38076C0", VA = "0x1838084C0")]
	public Task<NFMFLMAOFMP<object, CEGADOEINOB>> JFKDEKJDCDC(TRoot MIAAKEAGJGI, TNetSys EGMLKEONKKN, EIPPGFCFCGI<JMEIIMJEHGK> BELDNHKAMHL, TAction GKGLDBAJJCH, bool OCHKIPLOHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3808C10", Offset = "0x3807E10", VA = "0x183808C10")]
	[AsyncStateMachine(typeof(FJPEGJGDKEI<, , , , , , , , >.BBBOKLHHEGI))]
	private Task<NFMFLMAOFMP<object, CEGADOEINOB>> JFKDEKJDCDC(TRoot MIAAKEAGJGI, EIPPGFCFCGI<JMEIIMJEHGK> BELDNHKAMHL, TAction GKGLDBAJJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3808180", Offset = "0x3807380", VA = "0x183808180")]
	[AsyncStateMachine(typeof(FJPEGJGDKEI<, , , , , , , , >.DNOKBJNJPIG))]
	private Task<NFMFLMAOFMP<object, CEGADOEINOB>> DBNFMJFCKHD(TRoot MIAAKEAGJGI, EIPPGFCFCGI<JMEIIMJEHGK> BELDNHKAMHL, TAction[] KHONCCLLIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3807B90", Offset = "0x3806D90", VA = "0x183807B90")]
	[AsyncStateMachine(typeof(FJPEGJGDKEI<, , , , , , , , >.IOIDEBGPKPD))]
	public Task<NFMFLMAOFMP<object, CEGADOEINOB>> APAHPNBMFEJ(TRoot MIAAKEAGJGI, TNetSys KLLHLMEGMEJ, TReceiver LNCHGILPLKL, EIPPGFCFCGI<JMEIIMJEHGK> BELDNHKAMHL, EIPPGFCFCGI<TMRequest> CFBKFFNGANL, TAction GKGLDBAJJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3808000", Offset = "0x3807200", VA = "0x183808000")]
	[AsyncStateMachine(typeof(FJPEGJGDKEI<, , , , , , , , >.OHBAHOIHONH))]
	private Task<NFMFLMAOFMP<object, CEGADOEINOB>> BEDBGKIEEKM(TRoot MIAAKEAGJGI, TNetSys KLLHLMEGMEJ, TReceiver LNCHGILPLKL, EIPPGFCFCGI<JMEIIMJEHGK> BELDNHKAMHL, EIPPGFCFCGI<TMRequest> CFBKFFNGANL, TAction GKGLDBAJJCH, Task OJBPAGMEMOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3809760", Offset = "0x3808960", VA = "0x183809760")]
	[AsyncStateMachine(typeof(FJPEGJGDKEI<, , , , , , , , >.MAKBHEMFECM))]
	private Task PPHLLHBBPEP(TRoot MIAAKEAGJGI, TNetSys KLLHLMEGMEJ, TReceiver LNCHGILPLKL, TAction GKGLDBAJJCH, IMDCIINMCHK JOBHNBMMIME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3808F50", Offset = "0x3808150", VA = "0x183808F50")]
	private void OFPCHMBHJAJ(TRoot MIAAKEAGJGI, TNetSys KLLHLMEGMEJ, TReceiver LNCHGILPLKL, EIPPGFCFCGI<JMEIIMJEHGK> BELDNHKAMHL, TAction GKGLDBAJJCH, bool GJPEFMPCIAD, bool KNJLEGJEKNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MJAHKGBLMAK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface MHBHJFCKOBB<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MBOBLMGHEFL(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction HABELLFHOAJ(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction MGOPJPOKCKN(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> AEKPHNFOEFK(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] JEGLBKGAIOC(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH, int FPNPAFHHCPG);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool AKFPCGDEGGA(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CENFPOBKGOP(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool OMIIEFMFAPB(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool GGABGOCJLBE(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool NEOMNMJEJBK(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool GJDLHAMGNML(TNetSys HAFOMDBJDBF, TAction GKGLDBAJJCH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface EJOCKAMAGDN<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps LAEOOFOKPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps HDIBIHEKLIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps CIACHFMCOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MMGEAFANICP<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EIPPGFCFCGI<JMEIIMJEHGK> JKODCJBKNKB(TReceiver LNCHGILPLKL);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<NFMFLMAOFMP<object, CEGADOEINOB>> APAHPNBMFEJ(TReceiver LNCHGILPLKL, TAction GKGLDBAJJCH);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] FLDGMLDNHFJ(TReceiver LNCHGILPLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface JJFKIGKALIJ<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AGGIFGCEEEO(TRoot MIAAKEAGJGI);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int DACOMBOPKDP(TRoot MIAAKEAGJGI);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int APMJBONEPFG(TRoot MIAAKEAGJGI);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int LBOJFDCAANL(TRoot MIAAKEAGJGI);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DBONJKCFHHF(TRoot MIAAKEAGJGI);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task JFKDEKJDCDC(TRoot MIAAKEAGJGI, EIPPGFCFCGI<JMEIIMJEHGK> BELDNHKAMHL, EIPPGFCFCGI<TMRequest> CFBKFFNGANL, TAction GKGLDBAJJCH, bool FMOPFLCDBCN = true);
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
