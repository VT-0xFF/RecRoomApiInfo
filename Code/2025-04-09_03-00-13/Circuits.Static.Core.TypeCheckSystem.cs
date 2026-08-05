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
	[Cpp2IlInjected.Address(RVA = "0xB61480", Offset = "0xB60880", VA = "0x180B61480")]
	internal ICNIBHEEMGF(TType HAFNBBNOLPO, IOKind OHGBOBNHMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x49F3460", Offset = "0x49F2860", VA = "0x1849F3460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LNBAFICBPPF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x370C650", Offset = "0x370BA50", VA = "0x18370C650")]
	public static ICNIBHEEMGF<TType> HBLBJMFGHFK<TType>(TType HAFNBBNOLPO, IOKind OHGBOBNHMBO)
	{
		return default(ICNIBHEEMGF<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x370C6F0", Offset = "0x370BAF0", VA = "0x18370C6F0")]
	public static (TType, IOKind) OFPCAFDFKPJ<TType>([In] this ICNIBHEEMGF<TType> JOCJBPPJMJJ)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x370C680", Offset = "0x370BA80", VA = "0x18370C680")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D6E8D0", Offset = "0x4D6DCD0", VA = "0x184D6E8D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NNLODLIIPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37D92E0", Offset = "0x37D86E0", VA = "0x1837D92E0")]
	public static (EIBMIBHKGEA<TNode>, EIBMIBHKGEA<TNode>) OFPCAFDFKPJ<TNode>([In] this KBHCBCGGLJI<TNode> JOCJBPPJMJJ)
	{
		return default((EIBMIBHKGEA<TNode>, EIBMIBHKGEA<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37D91E0", Offset = "0x37D85E0", VA = "0x1837D91E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F4930", Offset = "0x9F3D30", VA = "0x1809F4930")]
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
				[Cpp2IlInjected.Address(RVA = "0x62F6C40", Offset = "0x62F6040", VA = "0x1862F6C40")]
				get
				{
					return default(ANPGLNMFLIK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x62F7380", Offset = "0x62F6780", VA = "0x1862F7380")]
			private CANOCFLCILH(TRoot BKHMOJGGBFN, TDeps OHJFEHDLOHB, TUnification JOIDAKOOEAO, TGraph CHEHNOIOMFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x62F5B10", Offset = "0x62F4F10", VA = "0x1862F5B10")]
			public static CANOCFLCILH HBLBJMFGHFK(TRoot BKHMOJGGBFN, TDeps OHJFEHDLOHB, TUnification JOIDAKOOEAO, TGraph CHEHNOIOMFH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x62F61A0", Offset = "0x62F55A0", VA = "0x1862F61A0")]
			public TType IBECCAGJOIF()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x62F50F0", Offset = "0x62F44F0", VA = "0x1862F50F0")]
			public ICNIBHEEMGF<TType> CHKBOHDOJMM(ICNIBHEEMGF<TType> BICHNBDCKLH, ICNIBHEEMGF<TType> CKCKMBIGMMF)
			{
				return default(ICNIBHEEMGF<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x62F7170", Offset = "0x62F6570", VA = "0x1862F7170")]
			public int PGMDOCFDGEE(TNode BLGGFHHEDNC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x62F5FF0", Offset = "0x62F53F0", VA = "0x1862F5FF0")]
			public int HOKOGHAKIMO(TNode BLGGFHHEDNC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x62F4B20", Offset = "0x62F3F20", VA = "0x1862F4B20")]
			public TInput BFANDEFPLCD(TNode BLGGFHHEDNC, int CJFNAFNJJLB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x62F62D0", Offset = "0x62F56D0", VA = "0x1862F62D0")]
			public int JFNDDOOJDFB(TNode BLGGFHHEDNC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x62F4F50", Offset = "0x62F4350", VA = "0x1862F4F50")]
			public TOutput CEEJKGNMNGI(TNode BLGGFHHEDNC, int CJFNAFNJJLB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x62F5410", Offset = "0x62F4810", VA = "0x1862F5410")]
			public IEnumerable<CHBGHAPNOBN<TType>> DDGGAJKILFD(TNode BLGGFHHEDNC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x62F67D0", Offset = "0x62F5BD0", VA = "0x1862F67D0")]
			public IEnumerable<KBHCBCGGLJI<TNode>> LFDDBECIHFM([In] TNode BLGGFHHEDNC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x62F6B40", Offset = "0x62F5F40", VA = "0x1862F6B40")]
			public TType NBKHEMEIFPH(TInput PJCOHHCODGF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x62F6710", Offset = "0x62F5B10", VA = "0x1862F6710")]
			public int KNMAOOJAGNJ(TInput PJCOHHCODGF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x62F4C00", Offset = "0x62F4000", VA = "0x1862F4C00")]
			public TOutput BHCICPOMBNN(TInput PJCOHHCODGF, int CJFNAFNJJLB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x62F6ED0", Offset = "0x62F62D0", VA = "0x1862F6ED0")]
			public TNode OLKCGADBPHP(TInput PJCOHHCODGF)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x62F54A0", Offset = "0x62F48A0", VA = "0x1862F54A0")]
			public TType DFMPDHNLFHF(TOutput OFLDFOLPLBP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x62F71B0", Offset = "0x62F65B0", VA = "0x1862F71B0")]
			public int PNDKALINICO(TOutput OFLDFOLPLBP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x62F6850", Offset = "0x62F5C50", VA = "0x1862F6850")]
			public TInput MBOFEFAFNFB(TOutput OFLDFOLPLBP, int CJFNAFNJJLB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x62F5840", Offset = "0x62F4C40", VA = "0x1862F5840")]
			public TNode GFKNHIDHLLE(TOutput OFLDFOLPLBP)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x62F5730", Offset = "0x62F4B30", VA = "0x1862F5730")]
			public bool GDFFCFHKBPE(TType HAFNBBNOLPO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x62F6A30", Offset = "0x62F5E30", VA = "0x1862F6A30")]
			public TType MNDGBEMIMEL(TType HAFNBBNOLPO, IEnumerable<TType> HDGNCAHAOOK)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x62F5F50", Offset = "0x62F5350", VA = "0x1862F5F50")]
			public void HFHMIPEBKPO(TType HAFNBBNOLPO, Action<TType> KAMFOOMOHPK, Action<TType> IPKFNMBACBH, Action<TType> PFFGNMCLGBA, Action<TType> HEJMCHBHDAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x62F5930", Offset = "0x62F4D30", VA = "0x1862F5930")]
			public TType GLIKGBIGECG(TType HAFNBBNOLPO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x62F6F60", Offset = "0x62F6360", VA = "0x1862F6F60")]
			public string OOBMPIBKCOK(TType HAFNBBNOLPO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x62F4ED0", Offset = "0x62F42D0", VA = "0x1862F4ED0")]
			public TTerm BJFHHDIFGID()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x62F5290", Offset = "0x62F4690", VA = "0x1862F5290")]
			public TTerm CLLOGGLIGMK(TTerm BMAJCCHGNGM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x62F59C0", Offset = "0x62F4DC0", VA = "0x1862F59C0")]
			public TTerm GLINGODADHP(TTerm FJONCPGPEAA, TTerm DECLPGCFODA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x62F6410", Offset = "0x62F5810", VA = "0x1862F6410")]
			public void JODHNMDAADO(TTerm BICHNBDCKLH, TTerm CKCKMBIGMMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x62F4D60", Offset = "0x62F4160", VA = "0x1862F4D60")]
			public bool BIPIKADFDJI(TOutputTerm BMAJCCHGNGM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x62F6540", Offset = "0x62F5940", VA = "0x1862F6540")]
			public bool KCDIIKBEFKA(TOutputTerm BMAJCCHGNGM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x62F6D50", Offset = "0x62F6150", VA = "0x1862F6D50")]
			public TTerm OGNFLLCLIPA(TOutputTerm PCNFOMJHNOO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x62F4A80", Offset = "0x62F3E80", VA = "0x1862F4A80")]
			public TOutputTerm AFOJCNAFDCH(TOutputTerm BMAJCCHGNGM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x62F5620", Offset = "0x62F4A20", VA = "0x1862F5620")]
			public TOutputTerm ELGKCHEADPC(TOutputTerm BMAJCCHGNGM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x62F6B80", Offset = "0x62F5F80", VA = "0x1862F6B80")]
			public TTerm NFGLJHFKOMG(TOutputSubstitution PAGEBPLLNIA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x62F7340", Offset = "0x62F6740", VA = "0x1862F7340")]
			public TOutputTerm POCPGGAAEGM(TOutputSubstitution PAGEBPLLNIA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x62F6290", Offset = "0x62F5690", VA = "0x1862F6290")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public LDINCKLDDDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4E5C060", Offset = "0x4E5B460", VA = "0x184E5C060")]
			internal int KEPMPHAJAME(CANOCFLCILH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4E5BF40", Offset = "0x4E5B340", VA = "0x184E5BF40")]
			internal TInput GCCOIAKALJN(CANOCFLCILH arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4E5BFA0", Offset = "0x4E5B3A0", VA = "0x184E5BFA0")]
			internal int KDFHFOEBDBA(CANOCFLCILH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4E5C130", Offset = "0x4E5B530", VA = "0x184E5C130")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public OBBKEDAOPOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5208AD0", Offset = "0x5207ED0", VA = "0x185208AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public BPCGOPIDJNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6018410", Offset = "0x6017810", VA = "0x186018410")]
			internal void CCKJGOBJMKE(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6018950", Offset = "0x6017D50", VA = "0x186018950")]
			internal void FLPBIIDHIME(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6018DD0", Offset = "0x60181D0", VA = "0x186018DD0")]
			internal void JOGIHALNDPO(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x60191E0", Offset = "0x60185E0", VA = "0x1860191E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
			public JIBPODAONLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x47233B0", Offset = "0x47227B0", VA = "0x1847233B0")]
			internal TTerm NIAPNOFFNMH(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B34040", Offset = "0x5B33440", VA = "0x185B34040")]
		private static FNONIIDNHKM EPFHDNMBIPH([CallerMemberName] string IGEPDAOOLBO = "")
		{
			return default(FNONIIDNHKM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B29550", Offset = "0x5B28950", VA = "0x185B29550")]
		public static Dictionary<TNode, List<CHBGHAPNOBN<TType>>> AIAFIACFDAO(TRoot BKHMOJGGBFN, TDeps OHJFEHDLOHB, TGraph CHEHNOIOMFH, IEnumerable<TNode> KMMNNCOJCAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F1D0", Offset = "0x5B2E5D0", VA = "0x185B2F1D0")]
		private static (Dictionary<TTerm, EIBMIBHKGEA<TNode>>, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>>) CGDKKMNHBGF(IEnumerable<TNode> KMMNNCOJCAG, CANOCFLCILH HBNMBAEKPFF)
		{
			return default((Dictionary<TTerm, EIBMIBHKGEA<TNode>>, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B29B00", Offset = "0x5B28F00", VA = "0x185B29B00")]
		private static void BEBODPOJJMA(TNode BLGGFHHEDNC, Dictionary<TInput, TTerm> OLMFIGMKDMD, Dictionary<TOutput, TTerm> KDGCFNJPENI, Dictionary<TTerm, EIBMIBHKGEA<TNode>> AHJGMJENDGH, Dictionary<EIBMIBHKGEA<TNode>, TTerm> KGHJDHPMGFF, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, Stack<TNode> CNDAFHMIKNA, List<KBHCBCGGLJI<TNode>> CAOMLIBCHPA, CANOCFLCILH HBNMBAEKPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B398E0", Offset = "0x5B38CE0", VA = "0x185B398E0")]
		private static Dictionary<string, TTerm> IDJNEANDFHB(TNode BLGGFHHEDNC, Dictionary<TTerm, EIBMIBHKGEA<TNode>> AHJGMJENDGH, Dictionary<EIBMIBHKGEA<TNode>, TTerm> LKKHIDEOCLK, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3621420", Offset = "0x3620820", VA = "0x183621420")]
		private static (TPort, TTerm)[] NBFDPFMDOFG<TPort>(TNode BLGGFHHEDNC, Func<CANOCFLCILH, TNode, int> OCLFBAELDDK, Func<CANOCFLCILH, TNode, int, TPort> PKKKGDOCEEP, Func<CANOCFLCILH, TPort, TType> NCJONOELOGG, Dictionary<TPort, TTerm> IAEGAFMJJNA, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B3CF40", Offset = "0x5B3C340", VA = "0x185B3CF40")]
		private static (TTerm, TTerm) OLDCCGGDCKO((TOutput Output, TTerm Id)[] EENOIMJOHCP, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, Dictionary<string, TTerm> LKKHIDEOCLK, Stack<TNode> CNDAFHMIKNA, CANOCFLCILH HBNMBAEKPFF)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5B31630", Offset = "0x5B30A30", VA = "0x185B31630")]
		private static void CIIBNIPCDCF((TInput PortKey, TTerm Id)[] COMKEBALMJE, TTerm MPJFFADFMPN, TTerm BBFBCPCLIJN, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, Dictionary<TOutput, TTerm> KDGCFNJPENI, Dictionary<string, TTerm> LKKHIDEOCLK, Stack<TNode> CNDAFHMIKNA, CANOCFLCILH HBNMBAEKPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B3A7A0", Offset = "0x5B39BA0", VA = "0x185B3A7A0")]
		private static TTerm MKJKKPNOPIH(TInput PJCOHHCODGF, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, Dictionary<TOutput, TTerm> KDGCFNJPENI, Stack<TNode> CNDAFHMIKNA, CANOCFLCILH HBNMBAEKPFF)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B352B0", Offset = "0x5B346B0", VA = "0x185B352B0")]
		private static TTerm HHNAJFIAEOJ([In] TType HAFNBBNOLPO, IOKind OHGBOBNHMBO, List<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, IReadOnlyDictionary<string, TTerm> LKKHIDEOCLK, CANOCFLCILH HBNMBAEKPFF)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5B2C0F0", Offset = "0x5B2B4F0", VA = "0x185B2C0F0")]
		private static Dictionary<TNode, List<CHBGHAPNOBN<TType>>> CALJBKAJDFN(TOutputSubstitution[] CGBNEBINGAN, Dictionary<TTerm, EIBMIBHKGEA<TNode>> AHJGMJENDGH, IEnumerable<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3BC70", Offset = "0x5B3B070", VA = "0x185B3BC70")]
		private static Dictionary<TNode, List<CHBGHAPNOBN<TType>>> OKMJPBGGAMN(Dictionary<TTerm, EIBMIBHKGEA<TNode>> AHJGMJENDGH, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5B361A0", Offset = "0x5B355A0", VA = "0x185B361A0")]
		private static void HPHGLJPDMHM([In] TNode BLGGFHHEDNC, Stack<TNode> CNDAFHMIKNA, List<KBHCBCGGLJI<TNode>> CAOMLIBCHPA, CANOCFLCILH HBNMBAEKPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B33B40", Offset = "0x5B32F40", VA = "0x185B33B40")]
		private static void DJCFFEDALID(Dictionary<EIBMIBHKGEA<TNode>, TTerm> LKKHIDEOCLK, List<KBHCBCGGLJI<TNode>> CAOMLIBCHPA, CANOCFLCILH HBNMBAEKPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5B36610", Offset = "0x5B35A10", VA = "0x185B36610")]
		private static Dictionary<TTerm, TType> ICNOBHGOAGH(Dictionary<TTerm, TOutputSubstitution> CGBNEBINGAN, IEnumerable<KeyValuePair<TTerm, ICNIBHEEMGF<TType>>> LHPAPNJDEJG, CANOCFLCILH HBNMBAEKPFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5B34100", Offset = "0x5B33500", VA = "0x185B34100")]
		private static NPOJFHOGAHB<TType> FENEDPPEGLJ(TOutputTerm HAFNBBNOLPO, Dictionary<TTerm, TType> LHPAPNJDEJG, Dictionary<TTerm, TType> OEEONBHNECC, CANOCFLCILH HBNMBAEKPFF)
		{
			return default(NPOJFHOGAHB<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5B39F30", Offset = "0x5B39330", VA = "0x185B39F30")]
		private static TOutputTerm MJPMLGHJNJG(TOutputTerm PKKKEKONOBP, CANOCFLCILH HBNMBAEKPFF)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x365B920", Offset = "0x365AD20", VA = "0x18365B920")]
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
	[Cpp2IlInjected.Address(RVA = "0x42F8BB0", Offset = "0x42F7FB0", VA = "0x1842F8BB0")]
	internal CHBGHAPNOBN(string IGEPDAOOLBO, [In] TType GDLLPIFPLMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x63F0F50", Offset = "0x63F0350", VA = "0x1863F0F50")]
	public bool EHKHGLACPFM([In] CHBGHAPNOBN<TType> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x63F1030", Offset = "0x63F0430", VA = "0x1863F1030", Slot = "4")]
	public bool Equals(CHBGHAPNOBN<TType> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x42E1E60", Offset = "0x42E1260", VA = "0x1842E1E60", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26EBEC0", Offset = "0x26EB2C0", VA = "0x1826EBEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x63F10D0", Offset = "0x63F04D0", VA = "0x1863F10D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63F1080", Offset = "0x63F0480", VA = "0x1863F1080", Slot = "5")]
	private bool MEHICPGFGNI([In] CHBGHAPNOBN<TType> KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CIIOMIEMJDB
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x33FF870", Offset = "0x33FEC70", VA = "0x1833FF870")]
	public static CHBGHAPNOBN<TType> HBLBJMFGHFK<TType>(string IGEPDAOOLBO, TType GDLLPIFPLMG)
	{
		return default(CHBGHAPNOBN<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x33FF8A0", Offset = "0x33FECA0", VA = "0x1833FF8A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x154B000", Offset = "0x154A400", VA = "0x18154B000")]
	internal EIBMIBHKGEA(TNode BLGGFHHEDNC, string IGEPDAOOLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x42E1D30", Offset = "0x42E1130", VA = "0x1842E1D30")]
	public bool EHKHGLACPFM([In] EIBMIBHKGEA<TNode> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x42E1EF0", Offset = "0x42E12F0", VA = "0x1842E1EF0", Slot = "4")]
	public bool Equals(EIBMIBHKGEA<TNode> KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x42E1E60", Offset = "0x42E1260", VA = "0x1842E1E60", Slot = "0")]
	public override bool Equals(object KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x42E1F40", Offset = "0x42E1340", VA = "0x1842E1F40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x42E2050", Offset = "0x42E1450", VA = "0x1842E2050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x42E2000", Offset = "0x42E1400", VA = "0x1842E2000", Slot = "5")]
	private bool LEKHOPIACIJ([In] EIBMIBHKGEA<TNode> KNCKFHOKGJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MIKCOCDOKHA
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x36ED7E0", Offset = "0x36ECBE0", VA = "0x1836ED7E0")]
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
