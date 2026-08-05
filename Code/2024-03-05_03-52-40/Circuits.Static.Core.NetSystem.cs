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
public struct FFNHPHJFLMG<TPartialAction, TFullAction, TDeps> where TDeps : MNEIKEBAFFB.HNMPNKNECPD<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] AJOFNPCGMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int CGCPIHFAPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps OHEILJJDMBM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x35FB790", Offset = "0x35FA590", VA = "0x1835FB790")]
	internal FFNHPHJFLMG(TPartialAction[] IGIJHKOLNEB, int CBKELNCCAPD, TDeps IKMKPNFBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35FB6C0", Offset = "0x35FA4C0", VA = "0x1835FB6C0")]
	public static FFNHPHJFLMG<TPartialAction, TFullAction, TDeps> IKCDCJJCDKO(TDeps IKMKPNFBOIN)
	{
		return default(FFNHPHJFLMG<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MNEIKEBAFFB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface HNMPNKNECPD<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BEFMBFIEFHN([In] TPartialAction KCHBOIOEAFD);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction GLBMLOIJBCA(TPartialAction[] AKDJPKKBHKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2814810", Offset = "0x2813610", VA = "0x182814810")]
	public static BAAANDEIBME<TFullAction> ENLNOCEEJBH<TFullAction, TPartialAction, TDeps>(this FFNHPHJFLMG<TPartialAction, TFullAction, TDeps> OELHNDCFEMO, TPartialAction KCHBOIOEAFD) where TDeps : HNMPNKNECPD<TPartialAction, TFullAction>
	{
		return default(BAAANDEIBME<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CFJCMJIIMOD<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : CBGNLGEHMIC.LCPELIJHJOF<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] FKOEIEBOJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int AOMEMDLGCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps OHEILJJDMBM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35FB790", Offset = "0x35FA590", VA = "0x1835FB790")]
	internal CFJCMJIIMOD(TPartialSnapshot[] OBDEKJLOACN, int GGGOCMOBNPO, TDeps IKMKPNFBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x35FB6C0", Offset = "0x35FA4C0", VA = "0x1835FB6C0")]
	public static CFJCMJIIMOD<TPartialSnapshot, TFullSnapshot, TDeps> IKCDCJJCDKO(TDeps IKMKPNFBOIN)
	{
		return default(CFJCMJIIMOD<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CBGNLGEHMIC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LCPELIJHJOF<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int POGEDLKNNAM([In] TPartialSnapshot LFBGMNOPKIF);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot ONDBHDGKPAL(TPartialSnapshot[] PFPCKHLEOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2589BE0", Offset = "0x25889E0", VA = "0x182589BE0")]
	public static BAAANDEIBME<TFullSnapshot> ENLNOCEEJBH<TFullSnapshot, TPartialSnapshot, TDeps>(this CFJCMJIIMOD<TPartialSnapshot, TFullSnapshot, TDeps> OELHNDCFEMO, TPartialSnapshot LFBGMNOPKIF) where TDeps : LCPELIJHJOF<TPartialSnapshot, TFullSnapshot>
	{
		return default(BAAANDEIBME<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2589F90", Offset = "0x2588D90", VA = "0x182589F90")]
	public static bool KBALPNGGLPJ<TPartialSnapshot, TFullSnapshot, TDeps>(this CFJCMJIIMOD<TPartialSnapshot, TFullSnapshot, TDeps> OELHNDCFEMO, TPartialSnapshot LFBGMNOPKIF) where TDeps : LCPELIJHJOF<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class KFHGLAGAEHF : FMIGMFBOJEI
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC950", Offset = "0x1DBB750", VA = "0x181DBC950", Slot = "7")]
	public override string LFKJGAHPPDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC980", Offset = "0x1DBB780", VA = "0x181DBC980")]
	public KFHGLAGAEHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class MKMAAJBBFGO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : IFGDLKOLGND.CNOAGCEAEDF<TAction, TNetSys> where TReceiverDeps : IFGDLKOLGND.KINGLGBOKCE<TMActor, TAction, TReceiver> where TRootDeps : IFGDLKOLGND.HOEAONKAJHM<TMRequest, TMActor, TAction, TRoot> where TDeps : IFGDLKOLGND.BFLKDMPGNHE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface NOEEPJIMGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HCCKCMIHCKO([In] BOHHCOEKANF<object, NOBEHEHNHMO> ELGNBNFKLLL);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FGJLACDDILM();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		BOHHCOEKANF<object, NOBEHEHNHMO> JDOOMKADOFP();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AFPBMBAGEIN(Exception IAOBDGOKOMA);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class NHOPNHHIIPI : NOEEPJIMGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<BOHHCOEKANF<object, NOBEHEHNHMO>> ILNCLOKDCLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<BOHHCOEKANF<object, NCKLHJJKDCC>> PKPDGOADLCJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3EB1E70", Offset = "0x3EB0C70", VA = "0x183EB1E70")]
		private NHOPNHHIIPI(TaskCompletionSource<BOHHCOEKANF<object, NOBEHEHNHMO>> KKPEIDAJNKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x36E39B0", Offset = "0x36E27B0", VA = "0x1836E39B0")]
		public static NHOPNHHIIPI IKCDCJJCDKO(TaskCompletionSource<BOHHCOEKANF<object, NOBEHEHNHMO>> KKPEIDAJNKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3EB1C10", Offset = "0x3EB0A10", VA = "0x183EB1C10")]
		public void HCCKCMIHCKO([In] BOHHCOEKANF<object, NOBEHEHNHMO> ELGNBNFKLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3EB1A30", Offset = "0x3EB0830", VA = "0x183EB1A30", Slot = "5")]
		public void FGJLACDDILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3EB1D10", Offset = "0x3EB0B10", VA = "0x183EB1D10", Slot = "6")]
		public BOHHCOEKANF<object, NOBEHEHNHMO> JDOOMKADOFP()
		{
			return default(BOHHCOEKANF<object, NOBEHEHNHMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3EB18F0", Offset = "0x3EB06F0", VA = "0x183EB18F0", Slot = "7")]
		public void AFPBMBAGEIN(Exception IAOBDGOKOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37B0800", Offset = "0x37AF600", VA = "0x1837B0800", Slot = "4")]
		private void ILELGNGNFHE([In] BOHHCOEKANF<object, NOBEHEHNHMO> ELGNBNFKLLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class DHHIECDLJLO : NOEEPJIMGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<BOHHCOEKANF<object, NOBEHEHNHMO>> ILNCLOKDCLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BOHHCOEKANF<object, NOBEHEHNHMO> NPIGCEEGLGD;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
		private DHHIECDLJLO(TaskCompletionSource<BOHHCOEKANF<object, NOBEHEHNHMO>> KKPEIDAJNKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x36E39B0", Offset = "0x36E27B0", VA = "0x1836E39B0")]
		public static DHHIECDLJLO IKCDCJJCDKO(TaskCompletionSource<BOHHCOEKANF<object, NOBEHEHNHMO>> KKPEIDAJNKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x47660F0", Offset = "0x4764EF0", VA = "0x1847660F0")]
		public void HCCKCMIHCKO([In] BOHHCOEKANF<object, NOBEHEHNHMO> ELGNBNFKLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x503F7E0", Offset = "0x503E5E0", VA = "0x18503F7E0", Slot = "5")]
		public void FGJLACDDILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA87FC0", Offset = "0xA86DC0", VA = "0x180A87FC0", Slot = "6")]
		public BOHHCOEKANF<object, NOBEHEHNHMO> JDOOMKADOFP()
		{
			return default(BOHHCOEKANF<object, NOBEHEHNHMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x503F720", Offset = "0x503E520", VA = "0x18503F720", Slot = "7")]
		public void AFPBMBAGEIN(Exception IAOBDGOKOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37B0800", Offset = "0x37AF600", VA = "0x1837B0800", Slot = "4")]
		private void ILELGNGNFHE([In] BOHHCOEKANF<object, NOBEHEHNHMO> ELGNBNFKLLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NEOLDOLLDIJ : NOEEPJIMGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<BOHHCOEKANF<object, NOBEHEHNHMO>> PKPDGOADLCJ;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE040", Offset = "0x3EACE40", VA = "0x183EAE040")]
		private NEOLDOLLDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3C462C0", Offset = "0x3C450C0", VA = "0x183C462C0")]
		public static NEOLDOLLDIJ IKCDCJJCDKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3EADEB0", Offset = "0x3EACCB0", VA = "0x183EADEB0")]
		public void HCCKCMIHCKO([In] BOHHCOEKANF<object, NOBEHEHNHMO> ELGNBNFKLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void FGJLACDDILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3EADF80", Offset = "0x3EACD80", VA = "0x183EADF80", Slot = "6")]
		public BOHHCOEKANF<object, NOBEHEHNHMO> JDOOMKADOFP()
		{
			return default(BOHHCOEKANF<object, NOBEHEHNHMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3EADD40", Offset = "0x3EACB40", VA = "0x183EADD40", Slot = "7")]
		[PMMFACMNNCA("This may be terminal and should probably do more than discarding the exception.")]
		public void AFPBMBAGEIN(Exception IAOBDGOKOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37B0800", Offset = "0x37AF600", VA = "0x1837B0800", Slot = "4")]
		private void ILELGNGNFHE([In] BOHHCOEKANF<object, NOBEHEHNHMO> ELGNBNFKLLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class LPFFFKKMCJO : NOEEPJIMGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BOHHCOEKANF<object, NOBEHEHNHMO> NPIGCEEGLGD;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		private LPFFFKKMCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C462C0", Offset = "0x3C450C0", VA = "0x183C462C0")]
		public static LPFFFKKMCJO IKCDCJJCDKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x14F6650", Offset = "0x14F5450", VA = "0x1814F6650")]
		public void HCCKCMIHCKO([In] BOHHCOEKANF<object, NOBEHEHNHMO> ELGNBNFKLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void FGJLACDDILM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70", Slot = "6")]
		public BOHHCOEKANF<object, NOBEHEHNHMO> JDOOMKADOFP()
		{
			return default(BOHHCOEKANF<object, NOBEHEHNHMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3C46220", Offset = "0x3C45020", VA = "0x183C46220", Slot = "7")]
		[PMMFACMNNCA("This may be terminal and should probably do more than discarding the exception.")]
		public void AFPBMBAGEIN(Exception IAOBDGOKOMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37B0800", Offset = "0x37AF600", VA = "0x1837B0800", Slot = "4")]
		private void ILELGNGNFHE([In] BOHHCOEKANF<object, NOBEHEHNHMO> ELGNBNFKLLL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CPNNDOMBHBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<BOHHCOEKANF<object, NOBEHEHNHMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::MKMAAJBBFGO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public GPIFJNELMMP<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<BOHHCOEKANF<object, NOBEHEHNHMO>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<BOHHCOEKANF<object, NOBEHEHNHMO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4D3F390", Offset = "0x4D3E190", VA = "0x184D3F390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D3FDD0", Offset = "0x4D3EBD0", VA = "0x184D3FDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KIBBELDKFGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<BOHHCOEKANF<object, NOBEHEHNHMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::MKMAAJBBFGO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public GPIFJNELMMP<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<BOHHCOEKANF<object, NOBEHEHNHMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3B1D290", Offset = "0x3B1C090", VA = "0x183B1D290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DB80", Offset = "0x3B1C980", VA = "0x183B1DB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JMHNBEAFFBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<BOHHCOEKANF<object, NOBEHEHNHMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::MKMAAJBBFGO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public GPIFJNELMMP<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public GPIFJNELMMP<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<BOHHCOEKANF<object, NOBEHEHNHMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3A77160", Offset = "0x3A75F60", VA = "0x183A77160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3A774C0", Offset = "0x3A762C0", VA = "0x183A774C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BCDDMHHFPBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<BOHHCOEKANF<object, NOBEHEHNHMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::MKMAAJBBFGO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GPIFJNELMMP<TMActor> senderId;

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
		public GPIFJNELMMP<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private NOEEPJIMGOC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x47650C0", Offset = "0x4763EC0", VA = "0x1847650C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4765CF0", Offset = "0x4764AF0", VA = "0x184765CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ABPFJCEGMDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::MKMAAJBBFGO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public NOEEPJIMGOC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private NOEEPJIMGOC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<BOHHCOEKANF<object, NOBEHEHNHMO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x36C0100", Offset = "0x36BEF00", VA = "0x1836C0100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x36C1EB0", Offset = "0x36C0CB0", VA = "0x1836C1EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps OHEILJJDMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<GPIFJNELMMP<TMRequest>, TaskCompletionSource<BOHHCOEKANF<object, NOBEHEHNHMO>>> CINBPOLNLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FGCHKOGPDAO<TMRequest> FHMIKECNCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int ODDIHAHDPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task CNLHGAIHIPF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps LBIJPMAOCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2CCA0", Offset = "0x3E2BAA0", VA = "0x183E2CCA0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps NGDBNELIACK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B1B0", Offset = "0x3E29FB0", VA = "0x183E2B1B0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps DBNJDFKCFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E2BE60", Offset = "0x3E2AC60", VA = "0x183E2BE60")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JPPPGPKAGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDB3D80", Offset = "0xDB2B80", VA = "0x180DB3D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x118FDA0", Offset = "0x118EBA0", VA = "0x18118FDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BBDLOOAJDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD9FC70", Offset = "0xD9EA70", VA = "0x180D9FC70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1C8E7C0", Offset = "0x1C8D5C0", VA = "0x181C8E7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MAHJNMLEKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C24B0", Offset = "0x7C12B0", VA = "0x1807C24B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D010", Offset = "0x3E2BE10", VA = "0x183E2D010")]
	public MKMAAJBBFGO(TDeps IKMKPNFBOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E2C3B0", Offset = "0x3E2B1B0", VA = "0x183E2C3B0")]
	public Task<BOHHCOEKANF<object, NOBEHEHNHMO>> KBLOHGFMKKJ(TRoot GOKLEGFJHEB, TNetSys CCBNBDCFEHB, GPIFJNELMMP<TMActor> NHAAIOIBMGP, TAction CJMBDOEJJJI, bool GLFMIPCFMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E2C6D0", Offset = "0x3E2B4D0", VA = "0x183E2C6D0")]
	[AsyncStateMachine(typeof(global::MKMAAJBBFGO<, , , , , , , , , >.CPNNDOMBHBH))]
	private Task<BOHHCOEKANF<object, NOBEHEHNHMO>> KBLOHGFMKKJ(TRoot GOKLEGFJHEB, GPIFJNELMMP<TMActor> NHAAIOIBMGP, TAction CJMBDOEJJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3E2BCB0", Offset = "0x3E2AAB0", VA = "0x183E2BCB0")]
	[AsyncStateMachine(typeof(global::MKMAAJBBFGO<, , , , , , , , , >.KIBBELDKFGE))]
	private Task<BOHHCOEKANF<object, NOBEHEHNHMO>> GHLDAKPFMMH(TRoot GOKLEGFJHEB, GPIFJNELMMP<TMActor> NHAAIOIBMGP, TAction[] BBKOMOBNKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CEA0", Offset = "0x3E2BCA0", VA = "0x183E2CEA0")]
	[AsyncStateMachine(typeof(global::MKMAAJBBFGO<, , , , , , , , , >.JMHNBEAFFBL))]
	public Task<BOHHCOEKANF<object, NOBEHEHNHMO>> PHABEABMAAG(TRoot GOKLEGFJHEB, TNetSys ACEFJOGNOEM, TReceiver LIOAKILKMJA, GPIFJNELMMP<TMActor> NHAAIOIBMGP, GPIFJNELMMP<TMRequest> OPOHAGDAJNJ, TAction CJMBDOEJJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3E2C990", Offset = "0x3E2B790", VA = "0x183E2C990")]
	[AsyncStateMachine(typeof(global::MKMAAJBBFGO<, , , , , , , , , >.BCDDMHHFPBI))]
	private Task<BOHHCOEKANF<object, NOBEHEHNHMO>> MHFLOHBNFAM(TRoot GOKLEGFJHEB, TNetSys ACEFJOGNOEM, TReceiver LIOAKILKMJA, GPIFJNELMMP<TMActor> NHAAIOIBMGP, GPIFJNELMMP<TMRequest> OPOHAGDAJNJ, TAction CJMBDOEJJJI, Task IPJAJMPFOIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3E2B230", Offset = "0x3E2A030", VA = "0x183E2B230")]
	[AsyncStateMachine(typeof(global::MKMAAJBBFGO<, , , , , , , , , >.ABPFJCEGMDK))]
	private Task DKINPLGEDJE(TRoot GOKLEGFJHEB, TNetSys ACEFJOGNOEM, TReceiver LIOAKILKMJA, TAction CJMBDOEJJJI, NOEEPJIMGOC MLMNODBAAPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3E2B870", Offset = "0x3E2A670", VA = "0x183E2B870")]
	private void FNJNPGJBONE(TRoot GOKLEGFJHEB, TNetSys ACEFJOGNOEM, TReceiver LIOAKILKMJA, GPIFJNELMMP<TMActor> NHAAIOIBMGP, TAction CJMBDOEJJJI, bool NBPKOPEAMPO, bool INHIJMICICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IFGDLKOLGND
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface CNOAGCEAEDF<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DEHJMPPJPDO(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction DFBKAMNGCOP(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction HOGBJPPHILD(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> BDFBIMDJOBM(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] IOMMDMKOCHK(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI, int LJONPLJNHDC);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NOFNIOKPBNH(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GLAMEPLIBKA(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EPHFGGOJIIB(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool KCANADMMFCH(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool NKLIAAIIMLJ(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool KBOJOIKEMNL(TNetSys NCLLFHKGFME, TAction CJMBDOEJJJI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BFLKDMPGNHE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps LBIJPMAOCCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps DBNJDFKCFCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps NGDBNELIACK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface KINGLGBOKCE<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GPIFJNELMMP<TMActor> BMKKFADEBDD(TReceiver LIOAKILKMJA);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BOHHCOEKANF<object, NOBEHEHNHMO>> PHABEABMAAG(TReceiver LIOAKILKMJA, TAction CJMBDOEJJJI);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] LPCKDBDNOAD(TReceiver LIOAKILKMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface HOEAONKAJHM<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BBBHOHJNJMB(TRoot GOKLEGFJHEB);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int IHGBAJGJGMD(TRoot GOKLEGFJHEB);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int ADHMFHPIGLJ(TRoot GOKLEGFJHEB);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int NAHBALCAACP(TRoot GOKLEGFJHEB);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HNMLOOGBKPG(TRoot GOKLEGFJHEB);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task KBLOHGFMKKJ(TRoot GOKLEGFJHEB, GPIFJNELMMP<TMActor> NHAAIOIBMGP, GPIFJNELMMP<TMRequest> OPOHAGDAJNJ, TAction CJMBDOEJJJI, bool KHFCCANNKNE = true);
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
