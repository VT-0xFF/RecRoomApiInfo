using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct ICNIBHEEMGF<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType KAFGKIIBACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind MDHDMPHCMMP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xB716C0", Offset = "0xB70AC0", VA = "0x180B716C0")]
	internal ICNIBHEEMGF(TType HAFNBBNOLPO, IOKind OHGBOBNHMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x49D7650", Offset = "0x49D6A50", VA = "0x1849D7650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LNBAFICBPPF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x36F8E30", Offset = "0x36F8230", VA = "0x1836F8E30")]
	public static ICNIBHEEMGF<TType> HBLBJMFGHFK<TType>(TType HAFNBBNOLPO, IOKind OHGBOBNHMBO)
	{
		return default(ICNIBHEEMGF<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36F8ED0", Offset = "0x36F82D0", VA = "0x1836F8ED0")]
	public static (TType, IOKind) OFPCAFDFKPJ<TType>([In] this ICNIBHEEMGF<TType> JOCJBPPJMJJ)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x36F8E60", Offset = "0x36F8260", VA = "0x1836F8E60")]
	public static void LKJBGMAPBIG<TType>([In] this ICNIBHEEMGF<TType> JOCJBPPJMJJ, [Out] TType HAFNBBNOLPO, [Out] IOKind OHGBOBNHMBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KBHCBCGGLJI<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EIBMIBHKGEA<TNode> DHBPIFMPLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly EIBMIBHKGEA<TNode> OACNGJGCDKC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4D50190", Offset = "0x4D4F590", VA = "0x184D50190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NNLODLIIPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37C6FA0", Offset = "0x37C63A0", VA = "0x1837C6FA0")]
	public static (EIBMIBHKGEA<TNode>, EIBMIBHKGEA<TNode>) OFPCAFDFKPJ<TNode>([In] this KBHCBCGGLJI<TNode> JOCJBPPJMJJ)
	{
		return default((EIBMIBHKGEA<TNode>, EIBMIBHKGEA<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37C6EA0", Offset = "0x37C62A0", VA = "0x1837C6EA0")]
	public static void LKJBGMAPBIG<TNode>([In] this KBHCBCGGLJI<TNode> JOCJBPPJMJJ, [Out] EIBMIBHKGEA<TNode> KGCKEJLFPJB, [Out] EIBMIBHKGEA<TNode> HKELKGIPNGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HHNOCMPLIFI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANPGLNMFLIK JLNAFBEKICH(TRoot BKHMOJGGBFN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType IBECCAGJOIF(TRoot BKHMOJGGBFN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ICNIBHEEMGF<TType> CHKBOHDOJMM(TRoot BKHMOJGGBFN, [In] ICNIBHEEMGF<TType> BICHNBDCKLH, [In] ICNIBHEEMGF<TType> CKCKMBIGMMF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PGMDOCFDGEE(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TNode BLGGFHHEDNC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int HOKOGHAKIMO(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TNode BLGGFHHEDNC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput BFANDEFPLCD(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TNode BLGGFHHEDNC, int CJFNAFNJJLB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JFNDDOOJDFB(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TNode BLGGFHHEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput CEEJKGNMNGI(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TNode BLGGFHHEDNC, int CJFNAFNJJLB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CHBGHAPNOBN<TType>> DDGGAJKILFD(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TNode BLGGFHHEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KBHCBCGGLJI<TNode>> LFDDBECIHFM(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TNode BLGGFHHEDNC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NBKHEMEIFPH(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TInput PJCOHHCODGF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int JHNJBCCHECB(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TInput PJCOHHCODGF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput BHCICPOMBNN(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TInput PJCOHHCODGF, int CJFNAFNJJLB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode OLKCGADBPHP(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TInput PJCOHHCODGF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType DFMPDHNLFHF(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TOutput OFLDFOLPLBP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int EGIJOPJPODF(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TOutput OFLDFOLPLBP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput MBOFEFAFNFB(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TOutput OFLDFOLPLBP, int CJFNAFNJJLB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode GFKNHIDHLLE(TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, TOutput OFLDFOLPLBP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GDFFCFHKBPE(TRoot BKHMOJGGBFN, TType HAFNBBNOLPO);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType MNDGBEMIMEL(TRoot BKHMOJGGBFN, TType HAFNBBNOLPO, IEnumerable<TType> HDGNCAHAOOK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HFHMIPEBKPO(TRoot BKHMOJGGBFN, TType HAFNBBNOLPO, Action<TType> KAMFOOMOHPK, Action<TType> IPKFNMBACBH, Action<TType> PFFGNMCLGBA, Action<TType> HEJMCHBHDAP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType GLIKGBIGECG(TRoot BKHMOJGGBFN, TType HAFNBBNOLPO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string OOBMPIBKCOK(TRoot BKHMOJGGBFN, TType HAFNBBNOLPO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification FHFNALFBNNJ(TRoot BKHMOJGGBFN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KGPHFOFOMPJ<TOutputSubstitution[], ADGPAJEIFGP> LOKELAPCAGP(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm BJFHHDIFGID(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm CLLOGGLIGMK(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TTerm BMAJCCHGNGM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm GLINGODADHP(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TTerm FJONCPGPEAA, TTerm DECLPGCFODA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JODHNMDAADO(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TTerm BICHNBDCKLH, TTerm CKCKMBIGMMF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool KCDIIKBEFKA(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TOutputTerm PCNFOMJHNOO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool BIPIKADFDJI(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TOutputTerm PCNFOMJHNOO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm ADIIKHNFLKP(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TOutputTerm PCNFOMJHNOO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm AFOJCNAFDCH(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TOutputTerm PCNFOMJHNOO);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm ELGKCHEADPC(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TOutputTerm PCNFOMJHNOO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm NFGLJHFKOMG(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TOutputSubstitution GBFDILOFHNA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm POCPGGAAEGM(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TOutputSubstitution GBFDILOFHNA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm IHHMEKHALFO(TRoot BKHMOJGGBFN, TUnification HCGPBLEDGMA, TTerm BMAJCCHGNGM);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LHJKNMAGHEE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HHNOCMPLIFI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9DE710", Offset = "0x9DDB10", VA = "0x1809DE710")]
	public static global::LHJKNMAGHEE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> HBLBJMFGHFK()
	{
		return default(global::LHJKNMAGHEE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IGCBCNNDKDN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class BCBBFKOMMOC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HHNOCMPLIFI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class CANOCFLCILH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot HLJCJLLDIEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps CPDLFFJNJHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification LEBFFNKOIBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph JAFKAEMKADN;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public ANPGLNMFLIK JJIKPJBPCJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x6301BF0", Offset = "0x6300FF0", VA = "0x186301BF0")]
				get
				{
					return default(ANPGLNMFLIK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6302340", Offset = "0x6301740", VA = "0x186302340")]
			private CANOCFLCILH(TRoot BKHMOJGGBFN, TDeps OHJFEHDLOHB, TUnification JOIDAKOOEAO, TGraph CHEHNOIOMFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6300AA0", Offset = "0x62FFEA0", VA = "0x186300AA0")]
			public static CANOCFLCILH HBLBJMFGHFK(TRoot BKHMOJGGBFN, TDeps OHJFEHDLOHB, TUnification JOIDAKOOEAO, TGraph CHEHNOIOMFH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6301150", Offset = "0x6300550", VA = "0x186301150")]
			public TType IBECCAGJOIF()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6300070", Offset = "0x62FF470", VA = "0x186300070")]
			public ICNIBHEEMGF<TType> CHKBOHDOJMM(ICNIBHEEMGF<TType> BICHNBDCKLH, ICNIBHEEMGF<TType> CKCKMBIGMMF)
			{
				return default(ICNIBHEEMGF<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6302130", Offset = "0x6301530", VA = "0x186302130")]
			public int PGMDOCFDGEE(TNode BLGGFHHEDNC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6300F90", Offset = "0x6300390", VA = "0x186300F90")]
			public int HOKOGHAKIMO(TNode BLGGFHHEDNC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x62FFAA0", Offset = "0x62FEEA0", VA = "0x1862FFAA0")]
			public TInput BFANDEFPLCD(TNode BLGGFHHEDNC, int CJFNAFNJJLB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6301280", Offset = "0x6300680", VA = "0x186301280")]
			public int JFNDDOOJDFB(TNode BLGGFHHEDNC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x62FFED0", Offset = "0x62FF2D0", VA = "0x1862FFED0")]
			public TOutput CEEJKGNMNGI(TNode BLGGFHHEDNC, int CJFNAFNJJLB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x63003A0", Offset = "0x62FF7A0", VA = "0x1863003A0")]
			public IEnumerable<CHBGHAPNOBN<TType>> DDGGAJKILFD(TNode BLGGFHHEDNC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6301780", Offset = "0x6300B80", VA = "0x186301780")]
			public IEnumerable<KBHCBCGGLJI<TNode>> LFDDBECIHFM([In] TNode BLGGFHHEDNC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6301AF0", Offset = "0x6300EF0", VA = "0x186301AF0")]
			public TType NBKHEMEIFPH(TInput PJCOHHCODGF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x63016C0", Offset = "0x6300AC0", VA = "0x1863016C0")]
			public int KNMAOOJAGNJ(TInput PJCOHHCODGF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x62FFB80", Offset = "0x62FEF80", VA = "0x1862FFB80")]
			public TOutput BHCICPOMBNN(TInput PJCOHHCODGF, int CJFNAFNJJLB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6301E90", Offset = "0x6301290", VA = "0x186301E90")]
			public TNode OLKCGADBPHP(TInput PJCOHHCODGF)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6300430", Offset = "0x62FF830", VA = "0x186300430")]
			public TType DFMPDHNLFHF(TOutput OFLDFOLPLBP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6302170", Offset = "0x6301570", VA = "0x186302170")]
			public int PNDKALINICO(TOutput OFLDFOLPLBP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6301800", Offset = "0x6300C00", VA = "0x186301800")]
			public TInput MBOFEFAFNFB(TOutput OFLDFOLPLBP, int CJFNAFNJJLB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63007D0", Offset = "0x62FFBD0", VA = "0x1863007D0")]
			public TNode GFKNHIDHLLE(TOutput OFLDFOLPLBP)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63006C0", Offset = "0x62FFAC0", VA = "0x1863006C0")]
			public bool GDFFCFHKBPE(TType HAFNBBNOLPO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63019E0", Offset = "0x6300DE0", VA = "0x1863019E0")]
			public TType MNDGBEMIMEL(TType HAFNBBNOLPO, IEnumerable<TType> HDGNCAHAOOK)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6300EF0", Offset = "0x63002F0", VA = "0x186300EF0")]
			public void HFHMIPEBKPO(TType HAFNBBNOLPO, Action<TType> KAMFOOMOHPK, Action<TType> IPKFNMBACBH, Action<TType> PFFGNMCLGBA, Action<TType> HEJMCHBHDAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x63008C0", Offset = "0x62FFCC0", VA = "0x1863008C0")]
			public TType GLIKGBIGECG(TType HAFNBBNOLPO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6301F20", Offset = "0x6301320", VA = "0x186301F20")]
			public string OOBMPIBKCOK(TType HAFNBBNOLPO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x62FFE50", Offset = "0x62FF250", VA = "0x1862FFE50")]
			public TTerm BJFHHDIFGID()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6300220", Offset = "0x62FF620", VA = "0x186300220")]
			public TTerm CLLOGGLIGMK(TTerm BMAJCCHGNGM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6300950", Offset = "0x62FFD50", VA = "0x186300950")]
			public TTerm GLINGODADHP(TTerm FJONCPGPEAA, TTerm DECLPGCFODA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x63013C0", Offset = "0x63007C0", VA = "0x1863013C0")]
			public void JODHNMDAADO(TTerm BICHNBDCKLH, TTerm CKCKMBIGMMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x62FFCE0", Offset = "0x62FF0E0", VA = "0x1862FFCE0")]
			public bool BIPIKADFDJI(TOutputTerm BMAJCCHGNGM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x63014F0", Offset = "0x63008F0", VA = "0x1863014F0")]
			public bool KCDIIKBEFKA(TOutputTerm BMAJCCHGNGM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6301D10", Offset = "0x6301110", VA = "0x186301D10")]
			public TTerm OGNFLLCLIPA(TOutputTerm PCNFOMJHNOO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x62FFA00", Offset = "0x62FEE00", VA = "0x1862FFA00")]
			public TOutputTerm AFOJCNAFDCH(TOutputTerm BMAJCCHGNGM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x63005B0", Offset = "0x62FF9B0", VA = "0x1863005B0")]
			public TOutputTerm ELGKCHEADPC(TOutputTerm BMAJCCHGNGM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6301B30", Offset = "0x6300F30", VA = "0x186301B30")]
			public TTerm NFGLJHFKOMG(TOutputSubstitution PAGEBPLLNIA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6302300", Offset = "0x6301700", VA = "0x186302300")]
			public TOutputTerm POCPGGAAEGM(TOutputSubstitution PAGEBPLLNIA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6301240", Offset = "0x6300640", VA = "0x186301240")]
			public TOutputTerm IHHMEKHALFO(TTerm BMAJCCHGNGM)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class LDINCKLDDDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public CANOCFLCILH arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public LDINCKLDDDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4E36540", Offset = "0x4E35940", VA = "0x184E36540")]
			internal int KEPMPHAJAME(CANOCFLCILH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4E36420", Offset = "0x4E35820", VA = "0x184E36420")]
			internal TInput GCCOIAKALJN(CANOCFLCILH arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4E36480", Offset = "0x4E35880", VA = "0x184E36480")]
			internal int KDFHFOEBDBA(CANOCFLCILH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4E36610", Offset = "0x4E35A10", VA = "0x184E36610")]
			internal TOutput LPGDLJGEFIP(CANOCFLCILH arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OBBKEDAOPOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public CANOCFLCILH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, EIBMIBHKGEA<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<EIBMIBHKGEA<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public OBBKEDAOPOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x51D7180", Offset = "0x51D6580", VA = "0x1851D7180")]
			internal (string, TTerm) ENDDJEOMJED(CHBGHAPNOBN<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BPCGOPIDJNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public CANOCFLCILH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public BPCGOPIDJNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6021280", Offset = "0x6020680", VA = "0x186021280")]
			internal void CCKJGOBJMKE(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x60217C0", Offset = "0x6020BC0", VA = "0x1860217C0")]
			internal void FLPBIIDHIME(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6021C40", Offset = "0x6021040", VA = "0x186021C40")]
			internal void JOGIHALNDPO(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6022050", Offset = "0x6021450", VA = "0x186022050")]
			internal void LHPEIHKIJJE(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JIBPODAONLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public CANOCFLCILH arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
			public JIBPODAONLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x470A510", Offset = "0x4709910", VA = "0x18470A510")]
			internal TTerm NIAPNOFFNMH(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5AFB290", Offset = "0x5AFA690", VA = "0x185AFB290")]
		private static FNONIIDNHKM EPFHDNMBIPH([CallerMemberName] string IGEPDAOOLBO = "")
		{
			return default(FNONIIDNHKM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5AF06B0", Offset = "0x5AEFAB0", VA = "0x185AF06B0")]
		public static Dictionary<TNode, List<CHBGHAPNOBN<TType>>> AIAFIACFDAO(TRoot BKHMOJGGBFN, TDeps OHJFEHDLOHB, TGraph CHEHNOIOMFH, IEnumerable<TNode> KMMNNCOJCAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5AF63E0", Offset = "0x5AF57E0", VA = "0x185AF63E0")]
		private static (Dictionary<TTerm, EIBMIBHKGEA<TNode>>, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>>) CGDKKMNHBGF(IEnumerable<TNode> KMMNNCOJCAG, CANOCFLCILH HBNMBAEKPFF)
		{
			return default((Dictionary<TTerm, EIBMIBHKGEA<TNode>>, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5AF0C70", Offset = "0x5AF0070", VA = "0x185AF0C70")]
		private static void BEBODPOJJMA(TNode BLGGFHHEDNC, Dictionary<TInput, TTerm> OLMFIGMKDMD, Dictionary<TOutput, TTerm> KDGCFNJPENI, Dictionary<TTerm, EIBMIBHKGEA<TNode>> AHJGMJENDGH, Dictionary<EIBMIBHKGEA<TNode>, TTerm> KGHJDHPMGFF, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, Stack<TNode> CNDAFHMIKNA, List<KBHCBCGGLJI<TNode>> CAOMLIBCHPA, CANOCFLCILH HBNMBAEKPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B00BC0", Offset = "0x5AFFFC0", VA = "0x185B00BC0")]
		private static Dictionary<string, TTerm> IDJNEANDFHB(TNode BLGGFHHEDNC, Dictionary<TTerm, EIBMIBHKGEA<TNode>> AHJGMJENDGH, Dictionary<EIBMIBHKGEA<TNode>, TTerm> LKKHIDEOCLK, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x361B070", Offset = "0x361A470", VA = "0x18361B070")]
		private static (TPort, TTerm)[] NBFDPFMDOFG<TPort>(TNode BLGGFHHEDNC, Func<CANOCFLCILH, TNode, int> OCLFBAELDDK, Func<CANOCFLCILH, TNode, int, TPort> PKKKGDOCEEP, Func<CANOCFLCILH, TPort, TType> NCJONOELOGG, Dictionary<TPort, TTerm> IAEGAFMJJNA, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B04220", Offset = "0x5B03620", VA = "0x185B04220")]
		private static (TTerm, TTerm) OLDCCGGDCKO((TOutput Output, TTerm Id)[] EENOIMJOHCP, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, Dictionary<string, TTerm> LKKHIDEOCLK, Stack<TNode> CNDAFHMIKNA, CANOCFLCILH HBNMBAEKPFF)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5AF8850", Offset = "0x5AF7C50", VA = "0x185AF8850")]
		private static void CIIBNIPCDCF((TInput PortKey, TTerm Id)[] COMKEBALMJE, TTerm MPJFFADFMPN, TTerm BBFBCPCLIJN, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, Dictionary<TOutput, TTerm> KDGCFNJPENI, Dictionary<string, TTerm> LKKHIDEOCLK, Stack<TNode> CNDAFHMIKNA, CANOCFLCILH HBNMBAEKPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B01A80", Offset = "0x5B00E80", VA = "0x185B01A80")]
		private static TTerm MKJKKPNOPIH(TInput PJCOHHCODGF, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, Dictionary<TOutput, TTerm> KDGCFNJPENI, Stack<TNode> CNDAFHMIKNA, CANOCFLCILH HBNMBAEKPFF)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC500", Offset = "0x5AFB900", VA = "0x185AFC500")]
		private static TTerm HHNAJFIAEOJ([In] TType HAFNBBNOLPO, IOKind OHGBOBNHMBO, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, IReadOnlyDictionary<string, TTerm> LKKHIDEOCLK, CANOCFLCILH HBNMBAEKPFF)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5AF32A0", Offset = "0x5AF26A0", VA = "0x185AF32A0")]
		private static Dictionary<TNode, List<CHBGHAPNOBN<TType>>> CALJBKAJDFN(TOutputSubstitution[] CGBNEBINGAN, Dictionary<TTerm, EIBMIBHKGEA<TNode>> AHJGMJENDGH, IEnumerable<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5B02F50", Offset = "0x5B02350", VA = "0x185B02F50")]
		private static Dictionary<TNode, List<CHBGHAPNOBN<TType>>> OKMJPBGGAMN(Dictionary<TTerm, EIBMIBHKGEA<TNode>> AHJGMJENDGH, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD3F0", Offset = "0x5AFC7F0", VA = "0x185AFD3F0")]
		private static void HPHGLJPDMHM([In] TNode BLGGFHHEDNC, Stack<TNode> CNDAFHMIKNA, List<KBHCBCGGLJI<TNode>> CAOMLIBCHPA, CANOCFLCILH HBNMBAEKPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5AFAD90", Offset = "0x5AFA190", VA = "0x185AFAD90")]
		private static void DJCFFEDALID(Dictionary<EIBMIBHKGEA<TNode>, TTerm> LKKHIDEOCLK, List<KBHCBCGGLJI<TNode>> CAOMLIBCHPA, CANOCFLCILH HBNMBAEKPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD860", Offset = "0x5AFCC60", VA = "0x185AFD860")]
		private static Dictionary<TTerm, TType> ICNOBHGOAGH(Dictionary<TTerm, TOutputSubstitution> CGBNEBINGAN, IEnumerable<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5AFB350", Offset = "0x5AFA750", VA = "0x185AFB350")]
		private static NPOJFHOGAHB<TType> FENEDPPEGLJ(TOutputTerm HAFNBBNOLPO, Dictionary<TTerm, TType> LHPAPNJDEJG, Dictionary<TTerm, TType> OEEONBHNECC, CANOCFLCILH HBNMBAEKPFF)
		{
			return default(NPOJFHOGAHB<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5B01210", Offset = "0x5B00610", VA = "0x185B01210")]
		private static TOutputTerm MJPMLGHJNJG(TOutputTerm PKKKEKONOBP, CANOCFLCILH HBNMBAEKPFF)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3648280", Offset = "0x3647680", VA = "0x183648280")]
	public static Dictionary<TNode, List<CHBGHAPNOBN<TType>>> AIAFIACFDAO<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::LHJKNMAGHEE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> JOCJBPPJMJJ, TRoot BKHMOJGGBFN, TGraph CHEHNOIOMFH, IEnumerable<TNode> KMMNNCOJCAG) where TDeps : global::HHNOCMPLIFI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CHBGHAPNOBN<TType> : IEquatable<CHBGHAPNOBN<TType>>, BDMMFIPCFEO<CHBGHAPNOBN<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string KAFLMFCDNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType BGOBCCBICIM;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x42D9FB0", Offset = "0x42D93B0", VA = "0x1842D9FB0")]
	internal CHBGHAPNOBN(string IGEPDAOOLBO, [In] TType GDLLPIFPLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x63FADD0", Offset = "0x63FA1D0", VA = "0x1863FADD0")]
	public bool EHKHGLACPFM([In] CHBGHAPNOBN<TType> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x63FAEB0", Offset = "0x63FA2B0", VA = "0x1863FAEB0", Slot = "4")]
	public bool Equals(CHBGHAPNOBN<TType> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x42C3140", Offset = "0x42C2540", VA = "0x1842C3140", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26EA740", Offset = "0x26E9B40", VA = "0x1826EA740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x63FAF50", Offset = "0x63FA350", VA = "0x1863FAF50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63FAF00", Offset = "0x63FA300", VA = "0x1863FAF00", Slot = "5")]
	private bool MEHICPGFGNI([In] CHBGHAPNOBN<TType> KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CIIOMIEMJDB
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x33EB670", Offset = "0x33EAA70", VA = "0x1833EB670")]
	public static CHBGHAPNOBN<TType> HBLBJMFGHFK<TType>(string IGEPDAOOLBO, TType GDLLPIFPLMG)
	{
		return default(CHBGHAPNOBN<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x33EB6A0", Offset = "0x33EAAA0", VA = "0x1833EB6A0")]
	public static (string, TType) OFPCAFDFKPJ<TType>([In] this CHBGHAPNOBN<TType> JOCJBPPJMJJ)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct EIBMIBHKGEA<TNode> : IEquatable<EIBMIBHKGEA<TNode>>, BDMMFIPCFEO<EIBMIBHKGEA<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode NFCKCCIBLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string KAFLMFCDNKO;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1536EA0", Offset = "0x15362A0", VA = "0x181536EA0")]
	internal EIBMIBHKGEA(TNode BLGGFHHEDNC, string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x42C3010", Offset = "0x42C2410", VA = "0x1842C3010")]
	public bool EHKHGLACPFM([In] EIBMIBHKGEA<TNode> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x42C31D0", Offset = "0x42C25D0", VA = "0x1842C31D0", Slot = "4")]
	public bool Equals(EIBMIBHKGEA<TNode> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x42C3140", Offset = "0x42C2540", VA = "0x1842C3140", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x42C3220", Offset = "0x42C2620", VA = "0x1842C3220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x42C3330", Offset = "0x42C2730", VA = "0x1842C3330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x42C32E0", Offset = "0x42C26E0", VA = "0x1842C32E0", Slot = "5")]
	private bool LEKHOPIACIJ([In] EIBMIBHKGEA<TNode> KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MIKCOCDOKHA
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x36DA760", Offset = "0x36D9B60", VA = "0x1836DA760")]
	public static EIBMIBHKGEA<TNode> HBLBJMFGHFK<TNode>(TNode BLGGFHHEDNC, string IGEPDAOOLBO)
	{
		return default(EIBMIBHKGEA<TNode>);
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
