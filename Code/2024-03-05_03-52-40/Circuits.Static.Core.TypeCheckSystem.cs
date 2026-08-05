using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LLDPCHIGJIH<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType BCIPLIOEBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind EKBAMLOLIIF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1865EF0", Offset = "0x1864CF0", VA = "0x181865EF0")]
	internal LLDPCHIGJIH(TType LPFFKBBBCBL, IOKind BCBLDNDIHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C29F10", Offset = "0x3C28D10", VA = "0x183C29F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KNOMGNDKEPG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27D7AB0", Offset = "0x27D68B0", VA = "0x1827D7AB0")]
	public static LLDPCHIGJIH<TType> IKCDCJJCDKO<TType>(TType LPFFKBBBCBL, IOKind BCBLDNDIHCH)
	{
		return default(LLDPCHIGJIH<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27D7A10", Offset = "0x27D6810", VA = "0x1827D7A10")]
	public static (TType, IOKind) BLNAPIDKLNK<TType>([In] this LLDPCHIGJIH<TType> OELHNDCFEMO)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27D7A50", Offset = "0x27D6850", VA = "0x1827D7A50")]
	public static void ELPMHLPMEKH<TType>([In] this LLDPCHIGJIH<TType> OELHNDCFEMO, [Out] TType LPFFKBBBCBL, [Out] IOKind BCBLDNDIHCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct EMMKCGLIIDB<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GBEJPLIDJKI<TNode> OEJOJOKALDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GBEJPLIDJKI<TNode> HEPBCIDKLEP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x32B40B0", Offset = "0x32B2EB0", VA = "0x1832B40B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IFEIILDDKNO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2782760", Offset = "0x2781560", VA = "0x182782760")]
	public static (GBEJPLIDJKI<TNode>, GBEJPLIDJKI<TNode>) BLNAPIDKLNK<TNode>([In] this EMMKCGLIIDB<TNode> OELHNDCFEMO)
	{
		return default((GBEJPLIDJKI<TNode>, GBEJPLIDJKI<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2782800", Offset = "0x2781600", VA = "0x182782800")]
	public static void ELPMHLPMEKH<TNode>([In] this EMMKCGLIIDB<TNode> OELHNDCFEMO, [Out] GBEJPLIDJKI<TNode> LDPIALBNJEB, [Out] GBEJPLIDJKI<TNode> HLCIAKLFNHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NNJMCEJCFHE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JMFEBOEDDND PAPAGEDKCHF(TRoot GOKLEGFJHEB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType OKJDADJLLBI(TRoot GOKLEGFJHEB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LLDPCHIGJIH<TType> IDFLAPFOEPE(TRoot GOKLEGFJHEB, [In] LLDPCHIGJIH<TType> MAJJJNOEIPE, [In] LLDPCHIGJIH<TType> FBEFKCHGALI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BEGJGPKAHFN(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TNode NBFOPMANPGI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DALGGLOIIMC(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TNode NBFOPMANPGI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput IHLOPEABAKN(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TNode NBFOPMANPGI, int OHINPGIGDNE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HHAFLJOLJHP(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TNode NBFOPMANPGI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput JBCEILNOMNL(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TNode NBFOPMANPGI, int OHINPGIGDNE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<DLANLCBOMBM<TType>> GLCAIDLKECO(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TNode NBFOPMANPGI);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<EMMKCGLIIDB<TNode>> IKNBBHHNGHG(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TNode NBFOPMANPGI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType CLEHKAAAAAH(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TInput PMNEDIFJMIN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int LOBGEHLKLEF(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TInput PMNEDIFJMIN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput FPIDBAIINNB(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TInput PMNEDIFJMIN, int OHINPGIGDNE);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode ENCKAIGJKIP(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TInput PMNEDIFJMIN);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType DNAAHPKJMCI(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TOutput BPPAPIIBMAL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int CDCMMINMOCB(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TOutput BPPAPIIBMAL);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput MMPEONAGHNE(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TOutput BPPAPIIBMAL, int OHINPGIGDNE);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode HMINNGMNGDO(TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, TOutput BPPAPIIBMAL);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HAJIDFAJJOE(TRoot GOKLEGFJHEB, TType LPFFKBBBCBL);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType IJNELBBKOPD(TRoot GOKLEGFJHEB, TType LPFFKBBBCBL, IEnumerable<TType> GDPCIGBEFJE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FDJLALNAFAG(TRoot GOKLEGFJHEB, TType LPFFKBBBCBL, Action<TType> EBOPHNLJGJO, Action<TType> ANBGNMJJNJC, Action<TType> KCBFBDPCNJI, Action<TType> OAGNNFMMMLC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType CGOJHLACHAH(TRoot GOKLEGFJHEB, TType LPFFKBBBCBL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string OEJLNLNMBEI(TRoot GOKLEGFJHEB, TType LPFFKBBBCBL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification ILMLOAMAPPM(TRoot GOKLEGFJHEB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BOHHCOEKANF<TOutputSubstitution[], NLLFNEOCDJB> PFECNAEEEFL(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm GDIAPIFPFBO(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm HBCFLMGBNBM(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TTerm LDKEHLGMDNE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm FMKBFFPDKAN(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TTerm MJNOHBDDECC, TTerm ANDIBGAILAG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LFAECPIABAK(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TTerm MAJJJNOEIPE, TTerm FBEFKCHGALI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool HEKCMJCBIMA(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TOutputTerm ACKNAFEOLBB);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool MGLBKIDHEOF(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TOutputTerm ACKNAFEOLBB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm OBJDDCBMEIO(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TOutputTerm ACKNAFEOLBB);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm OMKBCMCPCKP(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TOutputTerm ACKNAFEOLBB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm HEKIIIBOEAM(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TOutputTerm ACKNAFEOLBB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm ECOADDIOCOD(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TOutputSubstitution FLEIKIMLGPO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm EMOJPGHMDFK(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TOutputSubstitution FLEIKIMLGPO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm OJHLBEPGNAN(TRoot GOKLEGFJHEB, TUnification JOALGGOEODF, TTerm LDKEHLGMDNE);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IPDBNNDKHNI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::NNJMCEJCFHE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0")]
	public static global::IPDBNNDKHNI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> IKCDCJJCDKO()
	{
		return default(global::IPDBNNDKHNI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NMNCLCDPDKE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class FMDHNFOHIHP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::NNJMCEJCFHE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class DECENIKJKDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot IJIEPIJIKFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps BHLJEHFEGCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification DMBJGICOJKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph FDGKOPBKKPF;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public JMFEBOEDDND BKKHMGPDHKI
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x502C700", Offset = "0x502B500", VA = "0x18502C700")]
				get
				{
					return default(JMFEBOEDDND);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x502CCA0", Offset = "0x502BAA0", VA = "0x18502CCA0")]
			private DECENIKJKDL(TRoot GOKLEGFJHEB, TDeps IKMKPNFBOIN, TUnification NANGFIPIABN, TGraph FNHIIKAPEEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x502BC70", Offset = "0x502AA70", VA = "0x18502BC70")]
			public static DECENIKJKDL IKCDCJJCDKO(TRoot GOKLEGFJHEB, TDeps IKMKPNFBOIN, TUnification NANGFIPIABN, TGraph FNHIIKAPEEC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x502C9F0", Offset = "0x502B7F0", VA = "0x18502C9F0")]
			public TType OKJDADJLLBI()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x502B770", Offset = "0x502A570", VA = "0x18502B770")]
			public LLDPCHIGJIH<TType> IDFLAPFOEPE(LLDPCHIGJIH<TType> MAJJJNOEIPE, LLDPCHIGJIH<TType> FBEFKCHGALI)
			{
				return default(LLDPCHIGJIH<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x502A220", Offset = "0x5029020", VA = "0x18502A220")]
			public int BEGJGPKAHFN(TNode NBFOPMANPGI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x502A460", Offset = "0x5029260", VA = "0x18502A460")]
			public int DALGGLOIIMC(TNode NBFOPMANPGI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x502BA50", Offset = "0x502A850", VA = "0x18502BA50")]
			public TInput IHLOPEABAKN(TNode NBFOPMANPGI, int OHINPGIGDNE)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x502B610", Offset = "0x502A410", VA = "0x18502B610")]
			public int HHAFLJOLJHP(TNode NBFOPMANPGI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x502C0E0", Offset = "0x502AEE0", VA = "0x18502C0E0")]
			public TOutput JBCEILNOMNL(TNode NBFOPMANPGI, int OHINPGIGDNE)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x502AFE0", Offset = "0x5029DE0", VA = "0x18502AFE0")]
			public IEnumerable<DLANLCBOMBM<TType>> GLCAIDLKECO(TNode NBFOPMANPGI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x502C030", Offset = "0x502AE30", VA = "0x18502C030")]
			public IEnumerable<EMMKCGLIIDB<TNode>> IKNBBHHNGHG([In] TNode NBFOPMANPGI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x502A350", Offset = "0x5029150", VA = "0x18502A350")]
			public TType CLEHKAAAAAH(TInput PMNEDIFJMIN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x502BB70", Offset = "0x502A970", VA = "0x18502BB70")]
			public int IIJDMBPLGHB(TInput PMNEDIFJMIN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x502AE00", Offset = "0x5029C00", VA = "0x18502AE00")]
			public TOutput FPIDBAIINNB(TInput PMNEDIFJMIN, int OHINPGIGDNE)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x502A870", Offset = "0x5029670", VA = "0x18502A870")]
			public TNode ENCKAIGJKIP(TInput PMNEDIFJMIN)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x502A560", Offset = "0x5029360", VA = "0x18502A560")]
			public TType DNAAHPKJMCI(TOutput BPPAPIIBMAL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x502ACE0", Offset = "0x5029AE0", VA = "0x18502ACE0")]
			public int FOEEKHKDBNE(TOutput BPPAPIIBMAL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x502C530", Offset = "0x502B330", VA = "0x18502C530")]
			public TInput MMPEONAGHNE(TOutput BPPAPIIBMAL, int OHINPGIGDNE)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x502B6D0", Offset = "0x502A4D0", VA = "0x18502B6D0")]
			public TNode HMINNGMNGDO(TOutput BPPAPIIBMAL)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x502B0E0", Offset = "0x5029EE0", VA = "0x18502B0E0")]
			public bool HAJIDFAJJOE(TType LPFFKBBBCBL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x502BBB0", Offset = "0x502A9B0", VA = "0x18502BBB0")]
			public TType IJNELBBKOPD(TType LPFFKBBBCBL, IEnumerable<TType> GDPCIGBEFJE)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x502AA60", Offset = "0x5029860", VA = "0x18502AA60")]
			public void FDJLALNAFAG(TType LPFFKBBBCBL, Action<TType> EBOPHNLJGJO, Action<TType> ANBGNMJJNJC, Action<TType> KCBFBDPCNJI, Action<TType> OAGNNFMMMLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x502A260", Offset = "0x5029060", VA = "0x18502A260")]
			public TType CGOJHLACHAH(TType LPFFKBBBCBL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x502C850", Offset = "0x502B650", VA = "0x18502C850")]
			public string OEJLNLNMBEI(TType LPFFKBBBCBL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x502AF60", Offset = "0x5029D60", VA = "0x18502AF60")]
			public TTerm GDIAPIFPFBO()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x502B1F0", Offset = "0x5029FF0", VA = "0x18502B1F0")]
			public TTerm HBCFLMGBNBM(TTerm LDKEHLGMDNE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x502AAC0", Offset = "0x50298C0", VA = "0x18502AAC0")]
			public TTerm FMKBFFPDKAN(TTerm MJNOHBDDECC, TTerm ANDIBGAILAG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x502C2D0", Offset = "0x502B0D0", VA = "0x18502C2D0")]
			public void LFAECPIABAK(TTerm MAJJJNOEIPE, TTerm FBEFKCHGALI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x502C3C0", Offset = "0x502B1C0", VA = "0x18502C3C0")]
			public bool MGLBKIDHEOF(TOutputTerm LDKEHLGMDNE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x502B3E0", Offset = "0x502A1E0", VA = "0x18502B3E0")]
			public bool HEKCMJCBIMA(TOutputTerm LDKEHLGMDNE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x502A090", Offset = "0x5028E90", VA = "0x18502A090")]
			public TTerm ANKECKFHLAI(TOutputTerm ACKNAFEOLBB)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x502CB00", Offset = "0x502B900", VA = "0x18502CB00")]
			public TOutputTerm OMKBCMCPCKP(TOutputTerm LDKEHLGMDNE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x502B4B0", Offset = "0x502A2B0", VA = "0x18502B4B0")]
			public TOutputTerm HEKIIIBOEAM(TOutputTerm LDKEHLGMDNE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x502A680", Offset = "0x5029480", VA = "0x18502A680")]
			public TTerm ECOADDIOCOD(TOutputSubstitution NHIALEKDFHB)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x502A750", Offset = "0x5029550", VA = "0x18502A750")]
			public TOutputTerm EMOJPGHMDFK(TOutputSubstitution NHIALEKDFHB)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x502C890", Offset = "0x502B690", VA = "0x18502C890")]
			public TOutputTerm OJHLBEPGNAN(TTerm LDKEHLGMDNE)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class GPOLFCDFJOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public DECENIKJKDL arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public GPOLFCDFJOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3733660", Offset = "0x3732460", VA = "0x183733660")]
			internal int CNHOELAABHK(DECENIKJKDL arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x37335C0", Offset = "0x37323C0", VA = "0x1837335C0")]
			internal TInput BLLLGPKMGIO(DECENIKJKDL arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x37336B0", Offset = "0x37324B0", VA = "0x1837336B0")]
			internal int FHACPPGACGM(DECENIKJKDL arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x37337C0", Offset = "0x37325C0", VA = "0x1837337C0")]
			internal TOutput LOOELEJHHLE(DECENIKJKDL arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class CFNBACAOBFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public DECENIKJKDL arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, GBEJPLIDJKI<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<GBEJPLIDJKI<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public CFNBACAOBFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4C60050", Offset = "0x4C5EE50", VA = "0x184C60050")]
			internal (string, TTerm) MMEJGGBKJIH(DLANLCBOMBM<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BAGOKHMNPNC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public DECENIKJKDL arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public BAGOKHMNPNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4743610", Offset = "0x4742410", VA = "0x184743610")]
			internal void NKPNCANAENG(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4743A90", Offset = "0x4742890", VA = "0x184743A90")]
			internal void OMILNCEGDKK(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4743E80", Offset = "0x4742C80", VA = "0x184743E80")]
			internal void PIFDDBMDJIK(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4743390", Offset = "0x4742190", VA = "0x184743390")]
			internal void DLIEAIMEMNP(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ANGAOOIDAPA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public DECENIKJKDL arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
			public ANGAOOIDAPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3637C20", Offset = "0x3636A20", VA = "0x183637C20")]
			internal TTerm OHLNBPMNCNB(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3627D60", Offset = "0x3626B60", VA = "0x183627D60")]
		private static FEJHELBEDPI JFAMKPPHEBB([CallerMemberName] string OCCHBLONHPL = "")
		{
			return default(FEJHELBEDPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3632430", Offset = "0x3631230", VA = "0x183632430")]
		public static Dictionary<TNode, List<DLANLCBOMBM<TType>>> PGMGBMPCKKP(TRoot GOKLEGFJHEB, TDeps IKMKPNFBOIN, TGraph FNHIIKAPEEC, IEnumerable<TNode> ABCAMALGADA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x362B110", Offset = "0x3629F10", VA = "0x18362B110")]
		private static (Dictionary<TTerm, GBEJPLIDJKI<TNode>>, List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>>) PCNCDEMPCJI(IEnumerable<TNode> ABCAMALGADA, DECENIKJKDL ILCDOKLHIEO)
		{
			return default((Dictionary<TTerm, GBEJPLIDJKI<TNode>>, List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3625840", Offset = "0x3624640", VA = "0x183625840")]
		private static void HFPMCFGBIDH(TNode NBFOPMANPGI, Dictionary<TInput, TTerm> EIEGPEEPGEO, Dictionary<TOutput, TTerm> KFABGIKMFEP, Dictionary<TTerm, GBEJPLIDJKI<TNode>> HIKLMEBCOHM, Dictionary<GBEJPLIDJKI<TNode>, TTerm> HOGODMPCFEG, List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> MFFJGOMGHCG, Stack<TNode> EIFMIDBJHJB, List<EMMKCGLIIDB<TNode>> DGOIOOFBOHL, DECENIKJKDL ILCDOKLHIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x362A350", Offset = "0x3629150", VA = "0x18362A350")]
		private static Dictionary<string, TTerm> NGMELBNMJCF(TNode NBFOPMANPGI, Dictionary<TTerm, GBEJPLIDJKI<TNode>> HIKLMEBCOHM, Dictionary<GBEJPLIDJKI<TNode>, TTerm> HOAOHGNNMGH, List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> MFFJGOMGHCG, DECENIKJKDL ILCDOKLHIEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x22A49B0", Offset = "0x22A37B0", VA = "0x1822A49B0")]
		private static (TPort, TTerm)[] BKECLCLAKGE<TPort>(TNode NBFOPMANPGI, Func<DECENIKJKDL, TNode, int> PMPAOLPHAJA, Func<DECENIKJKDL, TNode, int, TPort> PMDEOHKJOFO, Func<DECENIKJKDL, TPort, TType> JGGNGECBLJC, Dictionary<TPort, TTerm> KEPALOCOBPN, DECENIKJKDL ILCDOKLHIEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3634340", Offset = "0x3633140", VA = "0x183634340")]
		private static (TTerm, TTerm) PJCJFLNHMDM((TOutput Output, TTerm Id)[] NHNIENDEIDD, List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> MFFJGOMGHCG, Dictionary<string, TTerm> HOAOHGNNMGH, Stack<TNode> EIFMIDBJHJB, DECENIKJKDL ILCDOKLHIEO)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x362C690", Offset = "0x362B490", VA = "0x18362C690")]
		private static void PEECFNMGBAI((TInput PortKey, TTerm Id)[] IKIGCPEBFIF, TTerm MKCJIMKGHPG, TTerm GNMAKEBFBJE, List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> MFFJGOMGHCG, Dictionary<TOutput, TTerm> KFABGIKMFEP, Dictionary<string, TTerm> HOAOHGNNMGH, Stack<TNode> EIFMIDBJHJB, DECENIKJKDL ILCDOKLHIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3620400", Offset = "0x361F200", VA = "0x183620400")]
		private static TTerm ABNKBAFCMCE(TInput PMNEDIFJMIN, List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> MFFJGOMGHCG, Dictionary<TOutput, TTerm> KFABGIKMFEP, Stack<TNode> EIFMIDBJHJB, DECENIKJKDL ILCDOKLHIEO)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3625280", Offset = "0x3624080", VA = "0x183625280")]
		private static TTerm FHFHPPGNDCD([In] TType LPFFKBBBCBL, IOKind BCBLDNDIHCH, List<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> MFFJGOMGHCG, IReadOnlyDictionary<string, TTerm> HOAOHGNNMGH, DECENIKJKDL ILCDOKLHIEO)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3622B30", Offset = "0x3621930", VA = "0x183622B30")]
		private static Dictionary<TNode, List<DLANLCBOMBM<TType>>> CNPIHALIHAM(TOutputSubstitution[] IHDPNNCCDJF, Dictionary<TTerm, GBEJPLIDJKI<TNode>> HIKLMEBCOHM, IEnumerable<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> MFFJGOMGHCG, DECENIKJKDL ILCDOKLHIEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x36249A0", Offset = "0x36237A0", VA = "0x1836249A0")]
		private static Dictionary<TNode, List<DLANLCBOMBM<TType>>> EMGAIFOEGHG(Dictionary<TTerm, GBEJPLIDJKI<TNode>> HIKLMEBCOHM, DECENIKJKDL ILCDOKLHIEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3629380", Offset = "0x3628180", VA = "0x183629380")]
		private static void NAIKNHDOFHM([In] TNode NBFOPMANPGI, Stack<TNode> EIFMIDBJHJB, List<EMMKCGLIIDB<TNode>> DGOIOOFBOHL, DECENIKJKDL ILCDOKLHIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3623BD0", Offset = "0x36229D0", VA = "0x183623BD0")]
		private static void DPFFHJGJPEF(Dictionary<GBEJPLIDJKI<TNode>, TTerm> HOAOHGNNMGH, List<EMMKCGLIIDB<TNode>> DGOIOOFBOHL, DECENIKJKDL ILCDOKLHIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3630940", Offset = "0x362F740", VA = "0x183630940")]
		private static Dictionary<TTerm, TType> PGEKEOEJOME(Dictionary<TTerm, TOutputSubstitution> IHDPNNCCDJF, IEnumerable<KeyValuePair<TTerm, LLDPCHIGJIH<TType>>> MFFJGOMGHCG, DECENIKJKDL ILCDOKLHIEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3627DA0", Offset = "0x3626BA0", VA = "0x183627DA0")]
		private static BAAANDEIBME<TType> JNIHHABHHPJ(TOutputTerm LPFFKBBBCBL, Dictionary<TTerm, TType> MFFJGOMGHCG, Dictionary<TTerm, TType> AJGMHAKKLJA, DECENIKJKDL ILCDOKLHIEO)
		{
			return default(BAAANDEIBME<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3629080", Offset = "0x3627E80", VA = "0x183629080")]
		private static TOutputTerm MNNFBDGPKFG(TOutputTerm FHGJEFODKOP, DECENIKJKDL ILCDOKLHIEO)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x286B420", Offset = "0x286A220", VA = "0x18286B420")]
	public static Dictionary<TNode, List<DLANLCBOMBM<TType>>> PGMGBMPCKKP<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::IPDBNNDKHNI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> OELHNDCFEMO, TRoot GOKLEGFJHEB, TGraph FNHIIKAPEEC, IEnumerable<TNode> ABCAMALGADA) where TDeps : global::NNJMCEJCFHE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct DLANLCBOMBM<TType> : IEquatable<DLANLCBOMBM<TType>>, CFGACMJPKMC<DLANLCBOMBM<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string PAHJIBDDKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType GBGIFIBHFIE;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x370E5F0", Offset = "0x370D3F0", VA = "0x18370E5F0")]
	internal DLANLCBOMBM(string OCCHBLONHPL, [In] TType BOMGCICIGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5048A00", Offset = "0x5047800", VA = "0x185048A00")]
	public bool BOFBAKIJPFH([In] DLANLCBOMBM<TType> EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5048B20", Offset = "0x5047920", VA = "0x185048B20", Slot = "4")]
	public bool Equals(DLANLCBOMBM<TType> EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x36127B0", Offset = "0x36115B0", VA = "0x1836127B0", Slot = "0")]
	public override bool Equals(object EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1DF6260", Offset = "0x1DF5060", VA = "0x181DF6260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5048B70", Offset = "0x5047970", VA = "0x185048B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5048AD0", Offset = "0x50478D0", VA = "0x185048AD0", Slot = "5")]
	private bool DLAHOHAKKEK([In] DLANLCBOMBM<TType> EDOEJIMPOFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BGNPJLDIPFH
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x25193E0", Offset = "0x25181E0", VA = "0x1825193E0")]
	public static DLANLCBOMBM<TType> IKCDCJJCDKO<TType>(string OCCHBLONHPL, TType BOMGCICIGJJ)
	{
		return default(DLANLCBOMBM<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x25193A0", Offset = "0x25181A0", VA = "0x1825193A0")]
	public static (string, TType) BLNAPIDKLNK<TType>([In] this DLANLCBOMBM<TType> OELHNDCFEMO)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GBEJPLIDJKI<TNode> : IEquatable<GBEJPLIDJKI<TNode>>, CFGACMJPKMC<GBEJPLIDJKI<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode FMHKIIDHPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string PAHJIBDDKIP;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xBF9910", Offset = "0xBF8710", VA = "0x180BF9910")]
	internal GBEJPLIDJKI(TNode NBFOPMANPGI, string OCCHBLONHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x36DDF90", Offset = "0x36DCD90", VA = "0x1836DDF90")]
	public bool BOFBAKIJPFH([In] GBEJPLIDJKI<TNode> EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x36DE130", Offset = "0x36DCF30", VA = "0x1836DE130", Slot = "4")]
	public bool Equals(GBEJPLIDJKI<TNode> EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x36127B0", Offset = "0x36115B0", VA = "0x1836127B0", Slot = "0")]
	public override bool Equals(object EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x36DE1D0", Offset = "0x36DCFD0", VA = "0x1836DE1D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x36DE240", Offset = "0x36DD040", VA = "0x1836DE240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x36DDEF0", Offset = "0x36DCCF0", VA = "0x1836DDEF0", Slot = "5")]
	private bool ADMOMJCLCFD([In] GBEJPLIDJKI<TNode> EDOEJIMPOFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DKJEKNDPNIF
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25C2690", Offset = "0x25C1490", VA = "0x1825C2690")]
	public static GBEJPLIDJKI<TNode> IKCDCJJCDKO<TNode>(TNode NBFOPMANPGI, string OCCHBLONHPL)
	{
		return default(GBEJPLIDJKI<TNode>);
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
