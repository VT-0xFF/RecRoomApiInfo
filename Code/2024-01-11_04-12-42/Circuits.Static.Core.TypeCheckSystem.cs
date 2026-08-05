using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct MHMGHFCADMP<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType KBCPOJJINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind PAHONEIDDCB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x179EA50", Offset = "0x179D450", VA = "0x18179EA50")]
	internal MHMGHFCADMP(TType AKDFFJNHJJN, IOKind HJPLODFMNPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3DD9730", Offset = "0x3DD8130", VA = "0x183DD9730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NIBNNADAMPP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2745960", Offset = "0x2744360", VA = "0x182745960")]
	public static MHMGHFCADMP<TType> KBFODEGLBLG<TType>(TType AKDFFJNHJJN, IOKind HJPLODFMNPL)
	{
		return default(MHMGHFCADMP<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2745920", Offset = "0x2744320", VA = "0x182745920")]
	public static (TType, IOKind) GCLPFKGLPAF<TType>([In] this MHMGHFCADMP<TType> JFFAAHPEFOB)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2745990", Offset = "0x2744390", VA = "0x182745990")]
	public static void LKKAPGAGEOB<TType>([In] this MHMGHFCADMP<TType> JFFAAHPEFOB, [Out] TType AKDFFJNHJJN, [Out] IOKind HJPLODFMNPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct OEPPAKAFBPE<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IDGIIMIAGAE<TNode> MFDOHNNKNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly IDGIIMIAGAE<TNode> PKKCBHNDMHB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3F7B360", Offset = "0x3F79D60", VA = "0x183F7B360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HMDOIPDJOKO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2619030", Offset = "0x2617A30", VA = "0x182619030")]
	public static (IDGIIMIAGAE<TNode>, IDGIIMIAGAE<TNode>) GCLPFKGLPAF<TNode>([In] this OEPPAKAFBPE<TNode> JFFAAHPEFOB)
	{
		return default((IDGIIMIAGAE<TNode>, IDGIIMIAGAE<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26190D0", Offset = "0x2617AD0", VA = "0x1826190D0")]
	public static void LKKAPGAGEOB<TNode>([In] this OEPPAKAFBPE<TNode> JFFAAHPEFOB, [Out] IDGIIMIAGAE<TNode> GHGBJDGFDKJ, [Out] IDGIIMIAGAE<TNode> PHPPILHFFME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IJFOAPMNPDH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IFGBPCBJDGI IALHKHNAJPA(TRoot AJBLHMMPNNM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType OPFDLEBPDBL(TRoot AJBLHMMPNNM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHMGHFCADMP<TType> PPAOPELAPDG(TRoot AJBLHMMPNNM, [In] MHMGHFCADMP<TType> KKLPBLEHAEB, [In] MHMGHFCADMP<TType> MFJBAALKDKH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OCMOEGDIOKH(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TNode NADDHKKGBAN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ABGMDEDMNEG(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TNode NADDHKKGBAN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput JODJHMPLMDB(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TNode NADDHKKGBAN, int BNALCEABILL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CKIEINLBKCD(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TNode NADDHKKGBAN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput AACECGFPFGB(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TNode NADDHKKGBAN, int BNALCEABILL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<PMGFBKIBNFE<TType>> MPDHAJILLNH(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TNode NADDHKKGBAN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<OEPPAKAFBPE<TNode>> KLNBGPFKNAC(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TNode NADDHKKGBAN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType IPKIOKJJHHK(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TInput KIEPLBLJKOI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int ADJMHOHHHJA(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TInput KIEPLBLJKOI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput FBPMJLINFGH(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TInput KIEPLBLJKOI, int BNALCEABILL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode JACOILDMEPO(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TInput KIEPLBLJKOI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType PMEHAPGDGBI(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TOutput ALJNGLCOPJD);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int AMLAKFPLHMP(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TOutput ALJNGLCOPJD);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput EMNBGJJEHGC(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TOutput ALJNGLCOPJD, int BNALCEABILL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode LGAJAMOPJBP(TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, TOutput ALJNGLCOPJD);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GECIDEBGCCJ(TRoot AJBLHMMPNNM, TType AKDFFJNHJJN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType KHOHHHPBKLG(TRoot AJBLHMMPNNM, TType AKDFFJNHJJN, IEnumerable<TType> OICCOKNKCBD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GPGGCGPENAA(TRoot AJBLHMMPNNM, TType AKDFFJNHJJN, Action<TType> KPHDHKJCMEM, Action<TType> AIGACMMMIGH, Action<TType> PJEAOANGMOO, Action<TType> FCAJLBKJAFE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType HCAFKEFIPOJ(TRoot AJBLHMMPNNM, TType AKDFFJNHJJN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string BLLCFMGLGOF(TRoot AJBLHMMPNNM, TType AKDFFJNHJJN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification LBIECLMJCHO(TRoot AJBLHMMPNNM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GAFDMEJHKLE<TOutputSubstitution[], FPFCLMBFIMG> IHBCILOAMMG(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm PMABBODMJPL(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm DMCJMHAECMH(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TTerm OCFAGBPOHDM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm BCIGFNGGDPB(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TTerm HFLKNOEOMLO, TTerm MKNIMCJLKGN);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GFGJJHOKFFI(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TTerm KKLPBLEHAEB, TTerm MFJBAALKDKH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool BFPILNABDLK(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TOutputTerm EBMHGALCDCC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool LGDNHKAFBII(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TOutputTerm EBMHGALCDCC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm LAFPPKOBJNN(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TOutputTerm EBMHGALCDCC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm KCEEKOPECDF(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TOutputTerm EBMHGALCDCC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm ACFIJNLBCLH(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TOutputTerm EBMHGALCDCC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm PAKABDKJGEN(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TOutputSubstitution ECGHFLBFCIL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm GNCECCKMDBD(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TOutputSubstitution ECGHFLBFCIL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm JFMIACAEGLG(TRoot AJBLHMMPNNM, TUnification JNBIPOMCHBE, TTerm OCFAGBPOHDM);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MKDDIDGIENN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::IJFOAPMNPDH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550")]
	public static global::MKDDIDGIENN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> KBFODEGLBLG()
	{
		return default(global::MKDDIDGIENN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EFGDAFHDKAH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class JKFBAGMGGDK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::IJFOAPMNPDH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class BACKCLDIIAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot DABPAFAJNAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps NKJMNJFHKJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification HAKHHDCHNBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph DGFIJAPKLKA;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public IFGBPCBJDGI FMDBDMALMEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x46DB390", Offset = "0x46D9D90", VA = "0x1846DB390")]
				get
				{
					return default(IFGBPCBJDGI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x46DCCF0", Offset = "0x46DB6F0", VA = "0x1846DCCF0")]
			private BACKCLDIIAB(TRoot AJBLHMMPNNM, TDeps APDKDADOJDA, TUnification DFCEJNEGHII, TGraph COGJFEICKFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x46DBBB0", Offset = "0x46DA5B0", VA = "0x1846DBBB0")]
			public static BACKCLDIIAB KBFODEGLBLG(TRoot AJBLHMMPNNM, TDeps APDKDADOJDA, TUnification DFCEJNEGHII, TGraph COGJFEICKFK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x46DC6F0", Offset = "0x46DB0F0", VA = "0x1846DC6F0")]
			public TType OPFDLEBPDBL()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x46DCC30", Offset = "0x46DB630", VA = "0x1846DCC30")]
			public MHMGHFCADMP<TType> PPAOPELAPDG(MHMGHFCADMP<TType> KKLPBLEHAEB, MHMGHFCADMP<TType> MFJBAALKDKH)
			{
				return default(MHMGHFCADMP<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x46DC550", Offset = "0x46DAF50", VA = "0x1846DC550")]
			public int OCMOEGDIOKH(TNode NADDHKKGBAN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x46DA2F0", Offset = "0x46D8CF0", VA = "0x1846DA2F0")]
			public int ABGMDEDMNEG(TNode NADDHKKGBAN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x46DBB60", Offset = "0x46DA560", VA = "0x1846DBB60")]
			public TInput JODJHMPLMDB(TNode NADDHKKGBAN, int BNALCEABILL)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x46DA920", Offset = "0x46D9320", VA = "0x1846DA920")]
			public int CKIEINLBKCD(TNode NADDHKKGBAN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x46DA220", Offset = "0x46D8C20", VA = "0x1846DA220")]
			public TOutput AACECGFPFGB(TNode NADDHKKGBAN, int BNALCEABILL)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x46DC490", Offset = "0x46DAE90", VA = "0x1846DC490")]
			public IEnumerable<PMGFBKIBNFE<TType>> MPDHAJILLNH(TNode NADDHKKGBAN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x46DC090", Offset = "0x46DAA90", VA = "0x1846DC090")]
			public IEnumerable<OEPPAKAFBPE<TNode>> KLNBGPFKNAC([In] TNode NADDHKKGBAN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x46DB550", Offset = "0x46D9F50", VA = "0x1846DB550")]
			public TType IPKIOKJJHHK(TInput KIEPLBLJKOI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x46DB940", Offset = "0x46DA340", VA = "0x1846DB940")]
			public int JNJMMFCNNFD(TInput KIEPLBLJKOI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x46DAD50", Offset = "0x46D9750", VA = "0x1846DAD50")]
			public TOutput FBPMJLINFGH(TInput KIEPLBLJKOI, int BNALCEABILL)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x46DB5E0", Offset = "0x46D9FE0", VA = "0x1846DB5E0")]
			public TNode JACOILDMEPO(TInput KIEPLBLJKOI)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x46DCA00", Offset = "0x46DB400", VA = "0x1846DCA00")]
			public TType PMEHAPGDGBI(TOutput ALJNGLCOPJD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x46DC650", Offset = "0x46DB050", VA = "0x1846DC650")]
			public int OHFHKDANIEK(TOutput ALJNGLCOPJD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x46DAAC0", Offset = "0x46D94C0", VA = "0x1846DAAC0")]
			public TInput EMNBGJJEHGC(TOutput ALJNGLCOPJD, int BNALCEABILL)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x46DC260", Offset = "0x46DAC60", VA = "0x1846DC260")]
			public TNode LGAJAMOPJBP(TOutput ALJNGLCOPJD)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x46DADA0", Offset = "0x46D97A0", VA = "0x1846DADA0")]
			public bool GECIDEBGCCJ(TType AKDFFJNHJJN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x46DBFD0", Offset = "0x46DA9D0", VA = "0x1846DBFD0")]
			public TType KHOHHHPBKLG(TType AKDFFJNHJJN, IEnumerable<TType> OICCOKNKCBD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x46DB120", Offset = "0x46D9B20", VA = "0x1846DB120")]
			public void GPGGCGPENAA(TType AKDFFJNHJJN, Action<TType> KPHDHKJCMEM, Action<TType> AIGACMMMIGH, Action<TType> PJEAOANGMOO, Action<TType> FCAJLBKJAFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x46DB310", Offset = "0x46D9D10", VA = "0x1846DB310")]
			public TType HCAFKEFIPOJ(TType AKDFFJNHJJN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x46DA750", Offset = "0x46D9150", VA = "0x1846DA750")]
			public string BLLCFMGLGOF(TType AKDFFJNHJJN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x46DC910", Offset = "0x46DB310", VA = "0x1846DC910")]
			public TTerm PMABBODMJPL()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x46DA9F0", Offset = "0x46D93F0", VA = "0x1846DA9F0")]
			public TTerm DMCJMHAECMH(TTerm OCFAGBPOHDM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x46DA4E0", Offset = "0x46D8EE0", VA = "0x1846DA4E0")]
			public TTerm BCIGFNGGDPB(TTerm HFLKNOEOMLO, TTerm MKNIMCJLKGN)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x46DAF00", Offset = "0x46D9900", VA = "0x1846DAF00")]
			public void GFGJJHOKFFI(TTerm KKLPBLEHAEB, TTerm MFJBAALKDKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x46DC380", Offset = "0x46DAD80", VA = "0x1846DC380")]
			public bool LGDNHKAFBII(TOutputTerm OCFAGBPOHDM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x46DA630", Offset = "0x46D9030", VA = "0x1846DA630")]
			public bool BFPILNABDLK(TOutputTerm OCFAGBPOHDM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x46DB7D0", Offset = "0x46DA1D0", VA = "0x1846DB7D0")]
			public TTerm JDGIJKKHMEE(TOutputTerm EBMHGALCDCC)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x46DBEB0", Offset = "0x46DA8B0", VA = "0x1846DBEB0")]
			public TOutputTerm KCEEKOPECDF(TOutputTerm OCFAGBPOHDM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x46DA440", Offset = "0x46D8E40", VA = "0x1846DA440")]
			public TOutputTerm ACFIJNLBCLH(TOutputTerm OCFAGBPOHDM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x46DC840", Offset = "0x46DB240", VA = "0x1846DC840")]
			public TTerm PAKABDKJGEN(TOutputSubstitution GDODAFDHHJG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x46DB050", Offset = "0x46D9A50", VA = "0x1846DB050")]
			public TOutputTerm GNCECCKMDBD(TOutputSubstitution GDODAFDHHJG)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x46DB820", Offset = "0x46DA220", VA = "0x1846DB820")]
			public TOutputTerm JFMIACAEGLG(TTerm OCFAGBPOHDM)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class JBEPNAJNKKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public BACKCLDIIAB arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public JBEPNAJNKKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x39EC5E0", Offset = "0x39EAFE0", VA = "0x1839EC5E0")]
			internal int NDOAMAKOBEG(BACKCLDIIAB arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x39EC470", Offset = "0x39EAE70", VA = "0x1839EC470")]
			internal TInput CPHACOKJAGF(BACKCLDIIAB arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x39EC680", Offset = "0x39EB080", VA = "0x1839EC680")]
			internal int OPPNHIGFPGJ(BACKCLDIIAB arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x39EC590", Offset = "0x39EAF90", VA = "0x1839EC590")]
			internal TOutput MOBOMJKEKPG(BACKCLDIIAB arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KLMFIJLBINI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public BACKCLDIIAB arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, IDGIIMIAGAE<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<IDGIIMIAGAE<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public KLMFIJLBINI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3AEC5C0", Offset = "0x3AEAFC0", VA = "0x183AEC5C0")]
			internal (string, TTerm) BICLJMJDDNH(PMGFBKIBNFE<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MPBPBPDMIKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public BACKCLDIIAB arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> idToType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IOKind ioKind;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public List<TTerm> terms;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IReadOnlyDictionary<string, TTerm> typeParameterToId;

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public MPBPBPDMIKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3DF5CB0", Offset = "0x3DF46B0", VA = "0x183DF5CB0")]
			internal void EJKDMCIIHAP(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3DF5AF0", Offset = "0x3DF44F0", VA = "0x183DF5AF0")]
			internal void ALOGCHPIILH(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3DF6130", Offset = "0x3DF4B30", VA = "0x183DF6130")]
			internal void HIONNCDFHJB(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3DF65F0", Offset = "0x3DF4FF0", VA = "0x183DF65F0")]
			internal void PCMJDEMIAJE(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BCONHFOMHJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public BACKCLDIIAB arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public BCONHFOMHJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x35A6E00", Offset = "0x35A5800", VA = "0x1835A6E00")]
			internal TTerm EDLLOLPEGKB(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3A43650", Offset = "0x3A42050", VA = "0x183A43650")]
		private static AOIALOCGNFG IBDIOBOGFAM([CallerMemberName] string CDHDOGOGPME = "")
		{
			return default(AOIALOCGNFG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3A374F0", Offset = "0x3A35EF0", VA = "0x183A374F0")]
		public static Dictionary<TNode, List<PMGFBKIBNFE<TType>>> AJBPEJFNKIE(TRoot AJBLHMMPNNM, TDeps APDKDADOJDA, TGraph COGJFEICKFK, IEnumerable<TNode> DIIKPNHFJPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A47640", Offset = "0x3A46040", VA = "0x183A47640")]
		private static (Dictionary<TTerm, IDGIIMIAGAE<TNode>>, List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>>) KMEOGAPJPFE(IEnumerable<TNode> DIIKPNHFJPB, BACKCLDIIAB GKNEMODKAOC)
		{
			return default((Dictionary<TTerm, IDGIIMIAGAE<TNode>>, List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A35CA0", Offset = "0x3A346A0", VA = "0x183A35CA0")]
		private static void ADOKFOILOFG(TNode NADDHKKGBAN, Dictionary<TInput, TTerm> BCNMFDBEOKB, Dictionary<TOutput, TTerm> BMOCOMPAKEN, Dictionary<TTerm, IDGIIMIAGAE<TNode>> ECIOFJHHKDC, Dictionary<IDGIIMIAGAE<TNode>, TTerm> KGEPIIEBFBL, List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> PEGEACGEMOA, Stack<TNode> CDCLCGKONPB, List<OEPPAKAFBPE<TNode>> CIPGLGEAIBE, BACKCLDIIAB GKNEMODKAOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A43710", Offset = "0x3A42110", VA = "0x183A43710")]
		private static Dictionary<string, TTerm> JLAMPNNOHFE(TNode NADDHKKGBAN, Dictionary<TTerm, IDGIIMIAGAE<TNode>> ECIOFJHHKDC, Dictionary<IDGIIMIAGAE<TNode>, TTerm> EDHFBHDPAKN, List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> PEGEACGEMOA, BACKCLDIIAB GKNEMODKAOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x21BBF10", Offset = "0x21BA910", VA = "0x1821BBF10")]
		private static (TPort, TTerm)[] BIPBBKCKMPL<TPort>(TNode NADDHKKGBAN, Func<BACKCLDIIAB, TNode, int> DIHIODMHNBL, Func<BACKCLDIIAB, TNode, int, TPort> CLMODKBJOBA, Func<BACKCLDIIAB, TPort, TType> KIFEJMBFJGM, Dictionary<TPort, TTerm> MAEFHFHNPOD, BACKCLDIIAB GKNEMODKAOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A39510", Offset = "0x3A37F10", VA = "0x183A39510")]
		private static (TTerm, TTerm) CHIOPMJGAMG((TOutput Output, TTerm Id)[] IKGIMODMNHD, List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> PEGEACGEMOA, Dictionary<string, TTerm> EDHFBHDPAKN, Stack<TNode> CDCLCGKONPB, BACKCLDIIAB GKNEMODKAOC)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3A3BB30", Offset = "0x3A3A530", VA = "0x183A3BB30")]
		private static void EFHFKBLCCBF((TInput PortKey, TTerm Id)[] LGFLJBEEBBB, TTerm MHDEGKMDGDI, TTerm CHAJCMIFDOP, List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> PEGEACGEMOA, Dictionary<TOutput, TTerm> BMOCOMPAKEN, Dictionary<string, TTerm> EDHFBHDPAKN, Stack<TNode> CDCLCGKONPB, BACKCLDIIAB GKNEMODKAOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3A41990", Offset = "0x3A40390", VA = "0x183A41990")]
		private static TTerm HJBBOPAAOOM(TInput KIEPLBLJKOI, List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> PEGEACGEMOA, Dictionary<TOutput, TTerm> BMOCOMPAKEN, Stack<TNode> CDCLCGKONPB, BACKCLDIIAB GKNEMODKAOC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3A48100", Offset = "0x3A46B00", VA = "0x183A48100")]
		private static TTerm LIFKLPGPGNM([In] TType AKDFFJNHJJN, IOKind HJPLODFMNPL, List<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> PEGEACGEMOA, IReadOnlyDictionary<string, TTerm> EDHFBHDPAKN, BACKCLDIIAB GKNEMODKAOC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A44900", Offset = "0x3A43300", VA = "0x183A44900")]
		private static Dictionary<TNode, List<PMGFBKIBNFE<TType>>> KDGGBIPNOIB(TOutputSubstitution[] IKJEMLFBAID, Dictionary<TTerm, IDGIIMIAGAE<TNode>> ECIOFJHHKDC, IEnumerable<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> PEGEACGEMOA, BACKCLDIIAB GKNEMODKAOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3A431E0", Offset = "0x3A41BE0", VA = "0x183A431E0")]
		private static Dictionary<TNode, List<PMGFBKIBNFE<TType>>> HLJGDJJPFPJ(Dictionary<TTerm, IDGIIMIAGAE<TNode>> ECIOFJHHKDC, BACKCLDIIAB GKNEMODKAOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E880", Offset = "0x3A3D280", VA = "0x183A3E880")]
		private static void EPKHLOMKGJL([In] TNode NADDHKKGBAN, Stack<TNode> CDCLCGKONPB, List<OEPPAKAFBPE<TNode>> CIPGLGEAIBE, BACKCLDIIAB GKNEMODKAOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3A386F0", Offset = "0x3A370F0", VA = "0x183A386F0")]
		private static void BEMOOFLFMPE(Dictionary<IDGIIMIAGAE<TNode>, TTerm> EDHFBHDPAKN, List<OEPPAKAFBPE<TNode>> CIPGLGEAIBE, BACKCLDIIAB GKNEMODKAOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3A40AA0", Offset = "0x3A3F4A0", VA = "0x183A40AA0")]
		private static Dictionary<TTerm, TType> GMMLGHFFFBG(Dictionary<TTerm, TOutputSubstitution> IKJEMLFBAID, IEnumerable<KeyValuePair<TTerm, MHMGHFCADMP<TType>>> PEGEACGEMOA, BACKCLDIIAB GKNEMODKAOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3A48CE0", Offset = "0x3A476E0", VA = "0x183A48CE0")]
		private static GEHGOLLEGKI<TType> NPHFAMJHNMK(TOutputTerm AKDFFJNHJJN, Dictionary<TTerm, TType> PEGEACGEMOA, Dictionary<TTerm, TType> JOHPOAIIMHB, BACKCLDIIAB GKNEMODKAOC)
		{
			return default(GEHGOLLEGKI<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3A486C0", Offset = "0x3A470C0", VA = "0x183A486C0")]
		private static TOutputTerm LMPMPGHHFDP(TOutputTerm JBABIDJEGNG, BACKCLDIIAB GKNEMODKAOC)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x24A45E0", Offset = "0x24A2FE0", VA = "0x1824A45E0")]
	public static Dictionary<TNode, List<PMGFBKIBNFE<TType>>> AJBPEJFNKIE<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::MKDDIDGIENN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> JFFAAHPEFOB, TRoot AJBLHMMPNNM, TGraph COGJFEICKFK, IEnumerable<TNode> DIIKPNHFJPB) where TDeps : global::IJFOAPMNPDH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PMGFBKIBNFE<TType> : IEquatable<PMGFBKIBNFE<TType>>, DECBLHBCBCN<PMGFBKIBNFE<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string JHMJHFOLNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType DBKPJBCJIPI;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x40A25C0", Offset = "0x40A0FC0", VA = "0x1840A25C0")]
	internal PMGFBKIBNFE(string CDHDOGOGPME, [In] TType OIAEAMHCNEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x40A24B0", Offset = "0x40A0EB0", VA = "0x1840A24B0")]
	public bool NMCMGCFNLJP([In] PMGFBKIBNFE<TType> CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x40A2410", Offset = "0x40A0E10", VA = "0x1840A2410", Slot = "4")]
	public bool Equals(PMGFBKIBNFE<TType> CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x381E290", Offset = "0x381CC90", VA = "0x18381E290", Slot = "0")]
	public override bool Equals(object CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D55A50", Offset = "0x1D54450", VA = "0x181D55A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x40A2580", Offset = "0x40A0F80", VA = "0x1840A2580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x40A2460", Offset = "0x40A0E60", VA = "0x1840A2460", Slot = "5")]
	private bool GGNFBLJDJCI([In] PMGFBKIBNFE<TType> CGDFJMJIABO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FAMEIPPFFGB
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x25DCBD0", Offset = "0x25DB5D0", VA = "0x1825DCBD0")]
	public static PMGFBKIBNFE<TType> KBFODEGLBLG<TType>(string CDHDOGOGPME, TType OIAEAMHCNEA)
	{
		return default(PMGFBKIBNFE<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x25DCB90", Offset = "0x25DB590", VA = "0x1825DCB90")]
	public static (string, TType) GCLPFKGLPAF<TType>([In] this PMGFBKIBNFE<TType> JFFAAHPEFOB)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct IDGIIMIAGAE<TNode> : IEquatable<IDGIIMIAGAE<TNode>>, DECBLHBCBCN<IDGIIMIAGAE<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode FONIGIILOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string JHMJHFOLNND;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xB9F900", Offset = "0xB9E300", VA = "0x180B9F900")]
	internal IDGIIMIAGAE(TNode NADDHKKGBAN, string CDHDOGOGPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x381E4F0", Offset = "0x381CEF0", VA = "0x18381E4F0")]
	public bool NMCMGCFNLJP([In] IDGIIMIAGAE<TNode> CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x381E240", Offset = "0x381CC40", VA = "0x18381E240", Slot = "4")]
	public bool Equals(IDGIIMIAGAE<TNode> CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x381E290", Offset = "0x381CC90", VA = "0x18381E290", Slot = "0")]
	public override bool Equals(object CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x381E310", Offset = "0x381CD10", VA = "0x18381E310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x381E5C0", Offset = "0x381CFC0", VA = "0x18381E5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x381E3D0", Offset = "0x381CDD0", VA = "0x18381E3D0", Slot = "5")]
	private bool MFKMMFAHDGJ([In] IDGIIMIAGAE<TNode> CGDFJMJIABO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IKGLHPDBPPL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x26380E0", Offset = "0x2636AE0", VA = "0x1826380E0")]
	public static IDGIIMIAGAE<TNode> KBFODEGLBLG<TNode>(TNode NADDHKKGBAN, string CDHDOGOGPME)
	{
		return default(IDGIIMIAGAE<TNode>);
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
