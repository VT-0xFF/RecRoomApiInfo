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
public struct FOMFGEDLPOL<TPartialAction, TFullAction, TDeps> where TDeps : DHBHOKKKNNE.COLHCHBEECF<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] EILNFIHPLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int BHGCAKLJBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps GNFPFODOMGM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C810B0", Offset = "0x3C7F6B0", VA = "0x183C810B0")]
	internal FOMFGEDLPOL(TPartialAction[] KEMOJPKBHIJ, int PGKCNDJKPKB, TDeps OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C80F90", Offset = "0x3C7F590", VA = "0x183C80F90")]
	public static FOMFGEDLPOL<TPartialAction, TFullAction, TDeps> HCLFOFEHDJP(TDeps OJGLDAGFLKC)
	{
		return default(FOMFGEDLPOL<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DHBHOKKKNNE
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface COLHCHBEECF<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LBDKIEPAIEF([In] TPartialAction CIGGNCELACH);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction KOPEFNAMCKL(TPartialAction[] ENHIMKDFLJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x296DE40", Offset = "0x296C440", VA = "0x18296DE40")]
	public static GBGJJMPMMOC<TFullAction> DEGKOGJHDPP<TFullAction, TPartialAction, TDeps>(this FOMFGEDLPOL<TPartialAction, TFullAction, TDeps> OLDDCPCBGIL, TPartialAction CIGGNCELACH) where TDeps : COLHCHBEECF<TPartialAction, TFullAction>
	{
		return default(GBGJJMPMMOC<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MDJMPLHOKKJ<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : IJGEFNBNJHM.EEGPBEIABJC<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] ILMNGEIIECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int PFNBDFGKOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps GNFPFODOMGM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C810B0", Offset = "0x3C7F6B0", VA = "0x183C810B0")]
	internal MDJMPLHOKKJ(TPartialSnapshot[] DCKLCLKEIMI, int CGLLFFMDMGN, TDeps OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C80F90", Offset = "0x3C7F590", VA = "0x183C80F90")]
	public static MDJMPLHOKKJ<TPartialSnapshot, TFullSnapshot, TDeps> HCLFOFEHDJP(TDeps OJGLDAGFLKC)
	{
		return default(MDJMPLHOKKJ<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IJGEFNBNJHM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface EEGPBEIABJC<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FAAMDAHGCGF([In] TPartialSnapshot EKOGPHNJFMN);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot CEEFOGPAMMO(TPartialSnapshot[] BNEPOBMHODH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B31D90", Offset = "0x2B30390", VA = "0x182B31D90")]
	public static GBGJJMPMMOC<TFullSnapshot> DEGKOGJHDPP<TFullSnapshot, TPartialSnapshot, TDeps>(this MDJMPLHOKKJ<TPartialSnapshot, TFullSnapshot, TDeps> OLDDCPCBGIL, TPartialSnapshot EKOGPHNJFMN) where TDeps : EEGPBEIABJC<TPartialSnapshot, TFullSnapshot>
	{
		return default(GBGJJMPMMOC<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B31C40", Offset = "0x2B30240", VA = "0x182B31C40")]
	public static bool ALFOLMECEJH<TPartialSnapshot, TFullSnapshot, TDeps>(this MDJMPLHOKKJ<TPartialSnapshot, TFullSnapshot, TDeps> OLDDCPCBGIL, TPartialSnapshot EKOGPHNJFMN) where TDeps : EEGPBEIABJC<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class LBODEKODGKJ : JPAMHBNAPMB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FD34A0", Offset = "0x1FD1AA0", VA = "0x181FD34A0", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FD34D0", Offset = "0x1FD1AD0", VA = "0x181FD34D0")]
	public LBODEKODGKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LHBPAENCBFP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : OAJKKMGDBOO.ECFPAMJGJJM<TAction, TNetSys> where TReceiverDeps : OAJKKMGDBOO.CCGIGCEDEPA<TAction, TReceiver> where TRootDeps : OAJKKMGDBOO.CGOKPFLPDJM<TMRequest, TAction, TRoot> where TDeps : OAJKKMGDBOO.FNIABKCMOKB<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface DDABHODOABK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FEMHPOOPEGJ([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JCIKHFBFMGK();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PIJKHLBEMKP<object, NJADGKCOIIE> BDAKLOKHENO();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AEECHDMAGDO(Exception CNGGKHFOGEI);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class IBOEFBHCLAJ : DDABHODOABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> AAEKONPMODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<PIJKHLBEMKP<object, PFPHCNGMPPA>> JGIGDEAFHPI;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C280", Offset = "0x3E9A880", VA = "0x183E9C280")]
		private IBOEFBHCLAJ(TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> JJKMKHFJDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C0C0", Offset = "0x3E9A6C0", VA = "0x183E9C0C0")]
		public static IBOEFBHCLAJ HCLFOFEHDJP(TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> JJKMKHFJDHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BFA0", Offset = "0x3E9A5A0", VA = "0x183E9BFA0")]
		public void FEMHPOOPEGJ([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C1A0", Offset = "0x3E9A7A0", VA = "0x183E9C1A0", Slot = "5")]
		public void JCIKHFBFMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BEF0", Offset = "0x3E9A4F0", VA = "0x183E9BEF0", Slot = "6")]
		public PIJKHLBEMKP<object, NJADGKCOIIE> BDAKLOKHENO()
		{
			return default(PIJKHLBEMKP<object, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BE90", Offset = "0x3E9A490", VA = "0x183E9BE90", Slot = "7")]
		public void AEECHDMAGDO(Exception CNGGKHFOGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D100B0", Offset = "0x3D0E6B0", VA = "0x183D100B0", Slot = "4")]
		private void BLJCPFPBOIE([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class NHDKMAFDDDP : DDABHODOABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> AAEKONPMODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private PIJKHLBEMKP<object, NJADGKCOIIE> JKAGPNHLIDI;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
		private NHDKMAFDDDP(TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> JJKMKHFJDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C0C0", Offset = "0x3E9A6C0", VA = "0x183E9C0C0")]
		public static NHDKMAFDDDP HCLFOFEHDJP(TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> JJKMKHFJDHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DDA0", Offset = "0x3D7C3A0", VA = "0x183D7DDA0")]
		public void FEMHPOOPEGJ([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4555810", Offset = "0x4553E10", VA = "0x184555810", Slot = "5")]
		public void JCIKHFBFMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC3DCF0", Offset = "0xC3C2F0", VA = "0x180C3DCF0", Slot = "6")]
		public PIJKHLBEMKP<object, NJADGKCOIIE> BDAKLOKHENO()
		{
			return default(PIJKHLBEMKP<object, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4555750", Offset = "0x4553D50", VA = "0x184555750", Slot = "7")]
		public void AEECHDMAGDO(Exception CNGGKHFOGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D100B0", Offset = "0x3D0E6B0", VA = "0x183D100B0", Slot = "4")]
		private void BLJCPFPBOIE([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class PHIJBBFLHIJ : DDABHODOABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<PIJKHLBEMKP<object, NJADGKCOIIE>> JGIGDEAFHPI;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4755280", Offset = "0x4753880", VA = "0x184755280")]
		private PHIJBBFLHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D100F0", Offset = "0x3D0E6F0", VA = "0x183D100F0")]
		public static PHIJBBFLHIJ HCLFOFEHDJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4755030", Offset = "0x4753630", VA = "0x184755030")]
		public void FEMHPOOPEGJ([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void JCIKHFBFMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4754FD0", Offset = "0x47535D0", VA = "0x184754FD0", Slot = "6")]
		public PIJKHLBEMKP<object, NJADGKCOIIE> BDAKLOKHENO()
		{
			return default(PIJKHLBEMKP<object, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4754ED0", Offset = "0x47534D0", VA = "0x184754ED0", Slot = "7")]
		[NONNNOEJCPN("This may be terminal and should probably do more than discarding the exception.")]
		public void AEECHDMAGDO(Exception CNGGKHFOGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D100B0", Offset = "0x3D0E6B0", VA = "0x183D100B0", Slot = "4")]
		private void BLJCPFPBOIE([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class GBHJAIHBFOF : DDABHODOABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PIJKHLBEMKP<object, NJADGKCOIIE> JKAGPNHLIDI;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		private GBHJAIHBFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D100F0", Offset = "0x3D0E6F0", VA = "0x183D100F0")]
		public static GBHJAIHBFOF HCLFOFEHDJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1704120", Offset = "0x1702720", VA = "0x181704120")]
		public void FEMHPOOPEGJ([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void JCIKHFBFMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8D4790", Offset = "0x8D2D90", VA = "0x1808D4790", Slot = "6")]
		public PIJKHLBEMKP<object, NJADGKCOIIE> BDAKLOKHENO()
		{
			return default(PIJKHLBEMKP<object, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3D10010", Offset = "0x3D0E610", VA = "0x183D10010", Slot = "7")]
		[NONNNOEJCPN("This may be terminal and should probably do more than discarding the exception.")]
		public void AEECHDMAGDO(Exception CNGGKHFOGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D100B0", Offset = "0x3D0E6B0", VA = "0x183D100B0", Slot = "4")]
		private void BLJCPFPBOIE([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EOPJAILDCHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LHBPAENCBFP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public HBKKMIFHCOI<EIKFNDMDOJI> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x383CCA0", Offset = "0x383B2A0", VA = "0x18383CCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x383D750", Offset = "0x383BD50", VA = "0x18383D750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct FMEFCGFLMOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LHBPAENCBFP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HBKKMIFHCOI<EIKFNDMDOJI> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3C59230", Offset = "0x3C57830", VA = "0x183C59230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C596B0", Offset = "0x3C57CB0", VA = "0x183C596B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ABOOBKPOBLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public LHBPAENCBFP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public HBKKMIFHCOI<EIKFNDMDOJI> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public HBKKMIFHCOI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4360", Offset = "0x3CC2960", VA = "0x183CC4360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4AB0", Offset = "0x3CC30B0", VA = "0x183CC4AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct NENLOKNMKDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<PIJKHLBEMKP<object, NJADGKCOIIE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public LHBPAENCBFP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public HBKKMIFHCOI<EIKFNDMDOJI> senderId;

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
		public HBKKMIFHCOI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private DDABHODOABK <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x453DD20", Offset = "0x453C320", VA = "0x18453DD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x453F7A0", Offset = "0x453DDA0", VA = "0x18453F7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OODHFPPMGGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public LHBPAENCBFP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public DDABHODOABK completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private DDABHODOABK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<PIJKHLBEMKP<object, NJADGKCOIIE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x46A7D00", Offset = "0x46A6300", VA = "0x1846A7D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x46A9C70", Offset = "0x46A8270", VA = "0x1846A9C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps GNFPFODOMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<HBKKMIFHCOI<TMRequest>, TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>>> KCPAELBKKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EHBAOMPFHOL<TMRequest> JOBHFFCFELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int NEHPGFFPKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task EAPGKLDHCCA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps GKHEMLGNOIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x42B6A60", Offset = "0x42B5060", VA = "0x1842B6A60")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps FDBACCFMILD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x42B70B0", Offset = "0x42B56B0", VA = "0x1842B70B0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps NBIJPDLCOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x42B8430", Offset = "0x42B6A30", VA = "0x1842B8430")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool POKCNIJGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x92F410", Offset = "0x92DA10", VA = "0x18092F410")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1392210", Offset = "0x1390810", VA = "0x181392210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KNFOOKGJLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF2CE20", Offset = "0xF2B420", VA = "0x180F2CE20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E79460", Offset = "0x1E77A60", VA = "0x181E79460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KDJOOMICDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x865830", Offset = "0x863E30", VA = "0x180865830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x42B85F0", Offset = "0x42B6BF0", VA = "0x1842B85F0")]
	public LHBPAENCBFP(TDeps OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42B77F0", Offset = "0x42B5DF0", VA = "0x1842B77F0")]
	public Task<PIJKHLBEMKP<object, NJADGKCOIIE>> KMLDIFIFEMO(TRoot FMGEJNFFGHE, TNetSys BCBECHDNKIK, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, TAction OGLJLDNLGIJ, bool EPJOLNMCGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x42B7B70", Offset = "0x42B6170", VA = "0x1842B7B70")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.EOPJAILDCHM))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> KMLDIFIFEMO(TRoot FMGEJNFFGHE, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, TAction OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x42B6AE0", Offset = "0x42B50E0", VA = "0x1842B6AE0")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.FMEFCGFLMOC))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> HIEOCEGCGLK(TRoot FMGEJNFFGHE, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, TAction[] HAMKHHIHPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x42B6770", Offset = "0x42B4D70", VA = "0x1842B6770")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.ABOOBKPOBLP))]
	public Task<PIJKHLBEMKP<object, NJADGKCOIIE>> EJNDJKMCFEN(TRoot FMGEJNFFGHE, TNetSys NJMOGCDPIHH, TReceiver PMALGFDMMMA, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, HBKKMIFHCOI<TMRequest> IKMCAHAKNPM, TAction OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42B6DA0", Offset = "0x42B53A0", VA = "0x1842B6DA0")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.NENLOKNMKDO))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> JJPMOPEHBPD(TRoot FMGEJNFFGHE, TNetSys NJMOGCDPIHH, TReceiver PMALGFDMMMA, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, HBKKMIFHCOI<TMRequest> IKMCAHAKNPM, TAction OGLJLDNLGIJ, Task IBOGCKJGBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42B64C0", Offset = "0x42B4AC0", VA = "0x1842B64C0")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.OODHFPPMGGA))]
	private Task CPCHKFEGEBE(TRoot FMGEJNFFGHE, TNetSys NJMOGCDPIHH, TReceiver PMALGFDMMMA, TAction OGLJLDNLGIJ, DDABHODOABK GCOOHJEEIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42B80B0", Offset = "0x42B66B0", VA = "0x1842B80B0")]
	private void MJGFJOHCMLM(TRoot FMGEJNFFGHE, TNetSys NJMOGCDPIHH, TReceiver PMALGFDMMMA, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, TAction OGLJLDNLGIJ, bool KEBKGGNDGFP, bool EOCMHMKPEHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OAJKKMGDBOO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ECFPAMJGJJM<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EBDLGCFHBFK(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction DCEEMHKKCGJ(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction EMMAMFOOIDG(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> CFMLLODKBLJ(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] MCPMJGFCBPH(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ, int OBGBEPEHGPM);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BBDJJHKHEOF(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GCHBHHIKIOH(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool GJEEBCLJENJ(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool ODACACMOFCB(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool GPGPCNFFAPD(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool DBANGNDLDAC(TNetSys PEGGANACAPA, TAction OGLJLDNLGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface FNIABKCMOKB<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps GKHEMLGNOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps NBIJPDLCOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps FDBACCFMILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface CCGIGCEDEPA<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HBKKMIFHCOI<EIKFNDMDOJI> BCKIGFDBJGI(TReceiver PMALGFDMMMA);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<PIJKHLBEMKP<object, NJADGKCOIIE>> EJNDJKMCFEN(TReceiver PMALGFDMMMA, TAction OGLJLDNLGIJ);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] MCKGHELMHJF(TReceiver PMALGFDMMMA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface CGOKPFLPDJM<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BLLLOGJNAAP(TRoot FMGEJNFFGHE);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int IHOGONFAAFB(TRoot FMGEJNFFGHE);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MJIDFOMNODD(TRoot FMGEJNFFGHE);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JKLLFFOCBKA(TRoot FMGEJNFFGHE);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HPECOPFECHK(TRoot FMGEJNFFGHE);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task KMLDIFIFEMO(TRoot FMGEJNFFGHE, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, HBKKMIFHCOI<TMRequest> IKMCAHAKNPM, TAction OGLJLDNLGIJ, bool HJGJKDCOLMC = true);
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
