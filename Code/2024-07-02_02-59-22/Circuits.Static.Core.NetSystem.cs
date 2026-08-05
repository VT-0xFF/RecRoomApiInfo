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
	[Cpp2IlInjected.Address(RVA = "0x3C9BC70", Offset = "0x3C9AC70", VA = "0x183C9BC70")]
	internal FOMFGEDLPOL(TPartialAction[] KEMOJPKBHIJ, int PGKCNDJKPKB, TDeps OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BB50", Offset = "0x3C9AB50", VA = "0x183C9BB50")]
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
	[Cpp2IlInjected.Address(RVA = "0x297E600", Offset = "0x297D600", VA = "0x18297E600")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C9BC70", Offset = "0x3C9AC70", VA = "0x183C9BC70")]
	internal MDJMPLHOKKJ(TPartialSnapshot[] DCKLCLKEIMI, int CGLLFFMDMGN, TDeps OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BB50", Offset = "0x3C9AB50", VA = "0x183C9BB50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2B4AB60", Offset = "0x2B49B60", VA = "0x182B4AB60")]
	public static GBGJJMPMMOC<TFullSnapshot> DEGKOGJHDPP<TFullSnapshot, TPartialSnapshot, TDeps>(this MDJMPLHOKKJ<TPartialSnapshot, TFullSnapshot, TDeps> OLDDCPCBGIL, TPartialSnapshot EKOGPHNJFMN) where TDeps : EEGPBEIABJC<TPartialSnapshot, TFullSnapshot>
	{
		return default(GBGJJMPMMOC<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B4AA10", Offset = "0x2B49A10", VA = "0x182B4AA10")]
	public static bool ALFOLMECEJH<TPartialSnapshot, TFullSnapshot, TDeps>(this MDJMPLHOKKJ<TPartialSnapshot, TFullSnapshot, TDeps> OLDDCPCBGIL, TPartialSnapshot EKOGPHNJFMN) where TDeps : EEGPBEIABJC<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class LBODEKODGKJ : JPAMHBNAPMB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0E80", Offset = "0x1FDFE80", VA = "0x181FE0E80", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0EB0", Offset = "0x1FDFEB0", VA = "0x181FE0EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EB80B0", Offset = "0x3EB70B0", VA = "0x183EB80B0")]
		private IBOEFBHCLAJ(TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> JJKMKHFJDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7D70", Offset = "0x3EB6D70", VA = "0x183EB7D70")]
		public static IBOEFBHCLAJ HCLFOFEHDJP(TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> JJKMKHFJDHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7B30", Offset = "0x3EB6B30", VA = "0x183EB7B30")]
		public void FEMHPOOPEGJ([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7F30", Offset = "0x3EB6F30", VA = "0x183EB7F30", Slot = "5")]
		public void JCIKHFBFMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3EB79D0", Offset = "0x3EB69D0", VA = "0x183EB79D0", Slot = "6")]
		public PIJKHLBEMKP<object, NJADGKCOIIE> BDAKLOKHENO()
		{
			return default(PIJKHLBEMKP<object, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7910", Offset = "0x3EB6910", VA = "0x183EB7910", Slot = "7")]
		public void AEECHDMAGDO(Exception CNGGKHFOGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A240", Offset = "0x3D29240", VA = "0x183D2A240", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86CB90", Offset = "0x86BB90", VA = "0x18086CB90")]
		private NHDKMAFDDDP(TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> JJKMKHFJDHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7D70", Offset = "0x3EB6D70", VA = "0x183EB7D70")]
		public static NHDKMAFDDDP HCLFOFEHDJP(TaskCompletionSource<PIJKHLBEMKP<object, NJADGKCOIIE>> JJKMKHFJDHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3D941C0", Offset = "0x3D931C0", VA = "0x183D941C0")]
		public void FEMHPOOPEGJ([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x45773E0", Offset = "0x45763E0", VA = "0x1845773E0", Slot = "5")]
		public void JCIKHFBFMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC43BD0", Offset = "0xC42BD0", VA = "0x180C43BD0", Slot = "6")]
		public PIJKHLBEMKP<object, NJADGKCOIIE> BDAKLOKHENO()
		{
			return default(PIJKHLBEMKP<object, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4577320", Offset = "0x4576320", VA = "0x184577320", Slot = "7")]
		public void AEECHDMAGDO(Exception CNGGKHFOGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A240", Offset = "0x3D29240", VA = "0x183D2A240", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4776990", Offset = "0x4775990", VA = "0x184776990")]
		private PHIJBBFLHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A280", Offset = "0x3D29280", VA = "0x183D2A280")]
		public static PHIJBBFLHIJ HCLFOFEHDJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4776740", Offset = "0x4775740", VA = "0x184776740")]
		public void FEMHPOOPEGJ([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		public void JCIKHFBFMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x47766E0", Offset = "0x47756E0", VA = "0x1847766E0", Slot = "6")]
		public PIJKHLBEMKP<object, NJADGKCOIIE> BDAKLOKHENO()
		{
			return default(PIJKHLBEMKP<object, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x47765E0", Offset = "0x47755E0", VA = "0x1847765E0", Slot = "7")]
		[NONNNOEJCPN("This may be terminal and should probably do more than discarding the exception.")]
		public void AEECHDMAGDO(Exception CNGGKHFOGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A240", Offset = "0x3D29240", VA = "0x183D2A240", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		private GBHJAIHBFOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A280", Offset = "0x3D29280", VA = "0x183D2A280")]
		public static GBHJAIHBFOF HCLFOFEHDJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x170CA20", Offset = "0x170BA20", VA = "0x18170CA20")]
		public void FEMHPOOPEGJ([In] PIJKHLBEMKP<object, NJADGKCOIIE> HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		public void JCIKHFBFMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8D74E0", Offset = "0x8D64E0", VA = "0x1808D74E0", Slot = "6")]
		public PIJKHLBEMKP<object, NJADGKCOIIE> BDAKLOKHENO()
		{
			return default(PIJKHLBEMKP<object, NJADGKCOIIE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A1A0", Offset = "0x3D291A0", VA = "0x183D2A1A0", Slot = "7")]
		[NONNNOEJCPN("This may be terminal and should probably do more than discarding the exception.")]
		public void AEECHDMAGDO(Exception CNGGKHFOGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2A240", Offset = "0x3D29240", VA = "0x183D2A240", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3857630", Offset = "0x3856630", VA = "0x183857630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x38580E0", Offset = "0x38570E0", VA = "0x1838580E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C73E40", Offset = "0x3C72E40", VA = "0x183C73E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3C742C0", Offset = "0x3C732C0", VA = "0x183C742C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CDED40", Offset = "0x3CDDD40", VA = "0x183CDED40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF490", Offset = "0x3CDE490", VA = "0x183CDF490", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x455F7E0", Offset = "0x455E7E0", VA = "0x18455F7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4561260", Offset = "0x4560260", VA = "0x184561260", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x46C7CA0", Offset = "0x46C6CA0", VA = "0x1846C7CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x46C9C10", Offset = "0x46C8C10", VA = "0x1846C9C10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x42D62D0", Offset = "0x42D52D0", VA = "0x1842D62D0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps FDBACCFMILD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x42D6920", Offset = "0x42D5920", VA = "0x1842D6920")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps NBIJPDLCOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x42D7C40", Offset = "0x42D6C40", VA = "0x1842D7C40")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool POKCNIJGBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9323A0", Offset = "0x9313A0", VA = "0x1809323A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1399BB0", Offset = "0x1398BB0", VA = "0x181399BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KNFOOKGJLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF34D90", Offset = "0xF33D90", VA = "0x180F34D90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E86E40", Offset = "0x1E85E40", VA = "0x181E86E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KDJOOMICDGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x868830", Offset = "0x867830", VA = "0x180868830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x42D7E00", Offset = "0x42D6E00", VA = "0x1842D7E00")]
	public LHBPAENCBFP(TDeps OJGLDAGFLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42D7000", Offset = "0x42D6000", VA = "0x1842D7000")]
	public Task<PIJKHLBEMKP<object, NJADGKCOIIE>> KMLDIFIFEMO(TRoot FMGEJNFFGHE, TNetSys BCBECHDNKIK, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, TAction OGLJLDNLGIJ, bool EPJOLNMCGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x42D7380", Offset = "0x42D6380", VA = "0x1842D7380")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.EOPJAILDCHM))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> KMLDIFIFEMO(TRoot FMGEJNFFGHE, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, TAction OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x42D6350", Offset = "0x42D5350", VA = "0x1842D6350")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.FMEFCGFLMOC))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> HIEOCEGCGLK(TRoot FMGEJNFFGHE, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, TAction[] HAMKHHIHPNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x42D5FE0", Offset = "0x42D4FE0", VA = "0x1842D5FE0")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.ABOOBKPOBLP))]
	public Task<PIJKHLBEMKP<object, NJADGKCOIIE>> EJNDJKMCFEN(TRoot FMGEJNFFGHE, TNetSys NJMOGCDPIHH, TReceiver PMALGFDMMMA, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, HBKKMIFHCOI<TMRequest> IKMCAHAKNPM, TAction OGLJLDNLGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42D6610", Offset = "0x42D5610", VA = "0x1842D6610")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.NENLOKNMKDO))]
	private Task<PIJKHLBEMKP<object, NJADGKCOIIE>> JJPMOPEHBPD(TRoot FMGEJNFFGHE, TNetSys NJMOGCDPIHH, TReceiver PMALGFDMMMA, HBKKMIFHCOI<EIKFNDMDOJI> DGMGNCFDIHK, HBKKMIFHCOI<TMRequest> IKMCAHAKNPM, TAction OGLJLDNLGIJ, Task IBOGCKJGBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42D5D30", Offset = "0x42D4D30", VA = "0x1842D5D30")]
	[AsyncStateMachine(typeof(LHBPAENCBFP<, , , , , , , , >.OODHFPPMGGA))]
	private Task CPCHKFEGEBE(TRoot FMGEJNFFGHE, TNetSys NJMOGCDPIHH, TReceiver PMALGFDMMMA, TAction OGLJLDNLGIJ, DDABHODOABK GCOOHJEEIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42D78C0", Offset = "0x42D68C0", VA = "0x1842D78C0")]
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
