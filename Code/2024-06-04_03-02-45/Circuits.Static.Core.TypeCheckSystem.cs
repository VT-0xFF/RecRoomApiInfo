using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LKBACKGFHNO<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType LBCGEBEPPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind HIFMEAPMDBJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1A56D70", Offset = "0x1A55570", VA = "0x181A56D70")]
	internal LKBACKGFHNO(TType HKAKMPIMEOA, IOKind EDGHADIILHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x41587A0", Offset = "0x4156FA0", VA = "0x1841587A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KIBELCJNBGD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B284C0", Offset = "0x2B26CC0", VA = "0x182B284C0")]
	public static LKBACKGFHNO<TType> OJFFIHPLODM<TType>(TType HKAKMPIMEOA, IOKind EDGHADIILHJ)
	{
		return default(LKBACKGFHNO<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2B28480", Offset = "0x2B26C80", VA = "0x182B28480")]
	public static (TType, IOKind) NHNIDOKFLEF<TType>([In] this LKBACKGFHNO<TType> EGJINJKGIAK)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B28410", Offset = "0x2B26C10", VA = "0x182B28410")]
	public static void LNLDOCGFLCM<TType>([In] this LKBACKGFHNO<TType> EGJINJKGIAK, [Out] TType HKAKMPIMEOA, [Out] IOKind EDGHADIILHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KMEFJOBKPCB<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LBHIPMKLABM<TNode> CFJKLNAFEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LBHIPMKLABM<TNode> AGFIGEMNBBB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x40B31A0", Offset = "0x40B19A0", VA = "0x1840B31A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GOIPEJGMKIP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D690", Offset = "0x2A9BE90", VA = "0x182A9D690")]
	public static (LBHIPMKLABM<TNode>, LBHIPMKLABM<TNode>) NHNIDOKFLEF<TNode>([In] this KMEFJOBKPCB<TNode> EGJINJKGIAK)
	{
		return default((LBHIPMKLABM<TNode>, LBHIPMKLABM<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D590", Offset = "0x2A9BD90", VA = "0x182A9D590")]
	public static void LNLDOCGFLCM<TNode>([In] this KMEFJOBKPCB<TNode> EGJINJKGIAK, [Out] LBHIPMKLABM<TNode> LDKECOBJCHJ, [Out] LBHIPMKLABM<TNode> JFMCJHKCOJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PPOADEDNOLG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AHJKEBGFGJB ELJKKOAAGJO(TRoot AHKBBGKKCNK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType AHOPPKMHNEH(TRoot AHKBBGKKCNK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LKBACKGFHNO<TType> EOMANIDOLBB(TRoot AHKBBGKKCNK, [In] LKBACKGFHNO<TType> JOMKMIJJPCA, [In] LKBACKGFHNO<TType> DFLDBCDDIFI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IBANHBHKCIB(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TNode DDLCNKGIKEK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CIPPDHJJLEL(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TNode DDLCNKGIKEK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput FOIJANBOENA(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TNode DDLCNKGIKEK, int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LLOANLCDLPF(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TNode DDLCNKGIKEK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput IJELFOJABHJ(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TNode DDLCNKGIKEK, int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<MKPHKNHNCLA<TType>> MPEAKIJCFJL(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TNode DDLCNKGIKEK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KMEFJOBKPCB<TNode>> JLJJBFDHCCO(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TNode DDLCNKGIKEK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType BMLPLMFFLAG(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TInput FDJIPPJKNDH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int MCMPODDPLFL(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TInput FDJIPPJKNDH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput MNAHNJHPIFC(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TInput FDJIPPJKNDH, int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode LONHCDAJKOI(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TInput FDJIPPJKNDH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType JPJGFMLOBCC(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TOutput FALADFAFJNF);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int HIEIAPMNGFJ(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TOutput FALADFAFJNF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput GDLILKMAHNC(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TOutput FALADFAFJNF, int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode DEIFLFHKKIE(TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, TOutput FALADFAFJNF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DLIOOOINOOP(TRoot AHKBBGKKCNK, TType HKAKMPIMEOA);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType LGBODFFABBF(TRoot AHKBBGKKCNK, TType HKAKMPIMEOA, IEnumerable<TType> FJHKMJNDHBN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LAFGJCAEBDM(TRoot AHKBBGKKCNK, TType HKAKMPIMEOA, Action<TType> FBBPAMCNMNH, Action<TType> LFPFCDHANBL, Action<TType> CECIDCMPIBH, Action<TType> LGMHGJBFPHJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType OLNIAJKLEEC(TRoot AHKBBGKKCNK, TType HKAKMPIMEOA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string NCIBNBLEEJH(TRoot AHKBBGKKCNK, TType HKAKMPIMEOA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification FLLEMAMAAHM(TRoot AHKBBGKKCNK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MEKCEIEFNPI<TOutputSubstitution[], PLHOCJDFICM> GMBFGDOMBEC(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm FDBKLKLOGBF(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm IBPNLPMEAGJ(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TTerm GKINAIJMDKI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm CHHOAPPBLBP(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TTerm KGKGNFIBJEB, TTerm MBIIHBIIKOG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DNDLCGMFOFM(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TTerm JOMKMIJJPCA, TTerm DFLDBCDDIFI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool BFLOGJCDJNN(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TOutputTerm CDIHAPNPNCF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool AKKHKININNH(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TOutputTerm CDIHAPNPNCF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm EEKADKHCFOC(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TOutputTerm CDIHAPNPNCF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm IMBPMBMMJKK(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TOutputTerm CDIHAPNPNCF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm OJDKEDDEHAM(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TOutputTerm CDIHAPNPNCF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm JJNGLMKPOIE(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TOutputSubstitution DMOKAJAJPHK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm OAOPDKPIIHN(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TOutputSubstitution DMOKAJAJPHK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm AMCIDIGNCPH(TRoot AHKBBGKKCNK, TUnification PMKBBNFJAIO, TTerm GKINAIJMDKI);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LDFGNMHONNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::PPOADEDNOLG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320")]
	public static global::LDFGNMHONNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> OJFFIHPLODM()
	{
		return default(global::LDFGNMHONNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NIPCFNMIBLK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class NCGMMNNHNFI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::PPOADEDNOLG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class LOFBCBCFCMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot BENFNHCGCFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps MFLGLPAICLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification IPOKEBALLLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph MCOKPIFJIFE;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public AHJKEBGFGJB PHHICOIPKOO
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x416E3C0", Offset = "0x416CBC0", VA = "0x18416E3C0")]
				get
				{
					return default(AHJKEBGFGJB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x416F0C0", Offset = "0x416D8C0", VA = "0x18416F0C0")]
			private LOFBCBCFCMK(TRoot AHKBBGKKCNK, TDeps DNJOEPEBEMJ, TUnification ODAPDAFKJMK, TGraph NCNAHELFBKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x416EEB0", Offset = "0x416D6B0", VA = "0x18416EEB0")]
			public static LOFBCBCFCMK OJFFIHPLODM(TRoot AHKBBGKKCNK, TDeps DNJOEPEBEMJ, TUnification ODAPDAFKJMK, TGraph NCNAHELFBKL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x416DAC0", Offset = "0x416C2C0", VA = "0x18416DAC0")]
			public TType AHOPPKMHNEH()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x416E0B0", Offset = "0x416C8B0", VA = "0x18416E0B0")]
			public LKBACKGFHNO<TType> EOMANIDOLBB(LKBACKGFHNO<TType> JOMKMIJJPCA, LKBACKGFHNO<TType> DFLDBCDDIFI)
			{
				return default(LKBACKGFHNO<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x416E440", Offset = "0x416CC40", VA = "0x18416E440")]
			public int IBANHBHKCIB(TNode DDLCNKGIKEK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x416DE10", Offset = "0x416C610", VA = "0x18416DE10")]
			public int CIPPDHJJLEL(TNode DDLCNKGIKEK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x416E1F0", Offset = "0x416C9F0", VA = "0x18416E1F0")]
			public TInput FOIJANBOENA(TNode DDLCNKGIKEK, int JBDLDJOINOF)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x416E930", Offset = "0x416D130", VA = "0x18416E930")]
			public int LLOANLCDLPF(TNode DDLCNKGIKEK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x416E630", Offset = "0x416CE30", VA = "0x18416E630")]
			public TOutput IJELFOJABHJ(TNode DDLCNKGIKEK, int JBDLDJOINOF)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x416EB20", Offset = "0x416D320", VA = "0x18416EB20")]
			public IEnumerable<MKPHKNHNCLA<TType>> MPEAKIJCFJL(TNode DDLCNKGIKEK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x416E7B0", Offset = "0x416CFB0", VA = "0x18416E7B0")]
			public IEnumerable<KMEFJOBKPCB<TNode>> JLJJBFDHCCO([In] TNode DDLCNKGIKEK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x416DD30", Offset = "0x416C530", VA = "0x18416DD30")]
			public TType BMLPLMFFLAG(TInput FDJIPPJKNDH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x416EBF0", Offset = "0x416D3F0", VA = "0x18416EBF0")]
			public int MPFAALLIINA(TInput FDJIPPJKNDH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x416EA50", Offset = "0x416D250", VA = "0x18416EA50")]
			public TOutput MNAHNJHPIFC(TInput FDJIPPJKNDH, int JBDLDJOINOF)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x416EA00", Offset = "0x416D200", VA = "0x18416EA00")]
			public TNode LONHCDAJKOI(TInput FDJIPPJKNDH)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x416E7F0", Offset = "0x416CFF0", VA = "0x18416E7F0")]
			public TType JPJGFMLOBCC(TOutput FALADFAFJNF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x416E520", Offset = "0x416CD20", VA = "0x18416E520")]
			public int IEBCJKINAGC(TOutput FALADFAFJNF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x416E330", Offset = "0x416CB30", VA = "0x18416E330")]
			public TInput GDLILKMAHNC(TOutput FALADFAFJNF, int JBDLDJOINOF)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x416DE90", Offset = "0x416C690", VA = "0x18416DE90")]
			public TNode DEIFLFHKKIE(TOutput FALADFAFJNF)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x416DF30", Offset = "0x416C730", VA = "0x18416DF30")]
			public bool DLIOOOINOOP(TType HKAKMPIMEOA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x416E8F0", Offset = "0x416D0F0", VA = "0x18416E8F0")]
			public TType LGBODFFABBF(TType HKAKMPIMEOA, IEnumerable<TType> FJHKMJNDHBN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x416E890", Offset = "0x416D090", VA = "0x18416E890")]
			public void LAFGJCAEBDM(TType HKAKMPIMEOA, Action<TType> FBBPAMCNMNH, Action<TType> LFPFCDHANBL, Action<TType> CECIDCMPIBH, Action<TType> LGMHGJBFPHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x416EFC0", Offset = "0x416D7C0", VA = "0x18416EFC0")]
			public TType OLNIAJKLEEC(TType HKAKMPIMEOA)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x416EC30", Offset = "0x416D430", VA = "0x18416EC30")]
			public string NCIBNBLEEJH(TType HKAKMPIMEOA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x416E170", Offset = "0x416C970", VA = "0x18416E170")]
			public TTerm FDBKLKLOGBF()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x416E4D0", Offset = "0x416CCD0", VA = "0x18416E4D0")]
			public TTerm IBPNLPMEAGJ(TTerm GKINAIJMDKI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x416DD70", Offset = "0x416C570", VA = "0x18416DD70")]
			public TTerm CHHOAPPBLBP(TTerm KGKGNFIBJEB, TTerm MBIIHBIIKOG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x416DF70", Offset = "0x416C770", VA = "0x18416DF70")]
			public void DNDLCGMFOFM(TTerm JOMKMIJJPCA, TTerm DFLDBCDDIFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x416DB50", Offset = "0x416C350", VA = "0x18416DB50")]
			public bool AKKHKININNH(TOutputTerm GKINAIJMDKI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x416DC40", Offset = "0x416C440", VA = "0x18416DC40")]
			public bool BFLOGJCDJNN(TOutputTerm GKINAIJMDKI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x416E060", Offset = "0x416C860", VA = "0x18416E060")]
			public TTerm DNIHOKHFDDH(TOutputTerm CDIHAPNPNCF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x416E6D0", Offset = "0x416CED0", VA = "0x18416E6D0")]
			public TOutputTerm IMBPMBMMJKK(TOutputTerm GKINAIJMDKI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x416ED00", Offset = "0x416D500", VA = "0x18416ED00")]
			public TOutputTerm OJDKEDDEHAM(TOutputTerm GKINAIJMDKI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x416E720", Offset = "0x416CF20", VA = "0x18416E720")]
			public TTerm JJNGLMKPOIE(TOutputSubstitution KGFJHCCCBMA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x416ECB0", Offset = "0x416D4B0", VA = "0x18416ECB0")]
			public TOutputTerm OAOPDKPIIHN(TOutputSubstitution KGFJHCCCBMA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x416DBA0", Offset = "0x416C3A0", VA = "0x18416DBA0")]
			public TOutputTerm AMCIDIGNCPH(TTerm GKINAIJMDKI)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IDBFHNOFAME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public LOFBCBCFCMK arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public IDBFHNOFAME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3D6A2E0", Offset = "0x3D68AE0", VA = "0x183D6A2E0")]
			internal int KEDLDHDDMBA(LOFBCBCFCMK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3D6A190", Offset = "0x3D68990", VA = "0x183D6A190")]
			internal TInput JIHMDLBKAAC(LOFBCBCFCMK arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3D6A0D0", Offset = "0x3D688D0", VA = "0x183D6A0D0")]
			internal int FDBIEMFFLMJ(LOFBCBCFCMK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3D6A3A0", Offset = "0x3D68BA0", VA = "0x183D6A3A0")]
			internal TOutput LADIDCKCJIL(LOFBCBCFCMK arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LEDCLDDKDPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public LOFBCBCFCMK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, LBHIPMKLABM<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<LBHIPMKLABM<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public LEDCLDDKDPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4143BC0", Offset = "0x41423C0", VA = "0x184143BC0")]
			internal (string, TTerm) DHIFMJDGOPK(MKPHKNHNCLA<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class IBLANPIKGDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public LOFBCBCFCMK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public IBLANPIKGDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3D62840", Offset = "0x3D61040", VA = "0x183D62840")]
			internal void JAHDGCACKOL(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3D62610", Offset = "0x3D60E10", VA = "0x183D62610")]
			internal void GGNLKMKFHHA(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3D61F30", Offset = "0x3D60730", VA = "0x183D61F30")]
			internal void EIHOHIDOPJK(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3D62DC0", Offset = "0x3D615C0", VA = "0x183D62DC0")]
			internal void LBCHELAFIMI(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class GAOEIHALFIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LOFBCBCFCMK arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
			public GAOEIHALFIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3AD1760", Offset = "0x3ACFF60", VA = "0x183AD1760")]
			internal TTerm LDGFLGLFKNN(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4424D80", Offset = "0x4423580", VA = "0x184424D80")]
		private static PFIMPLEPCIJ NOOEKJMFLDB([CallerMemberName] string GCDLMFGKKMH = "")
		{
			return default(PFIMPLEPCIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x440E9B0", Offset = "0x440D1B0", VA = "0x18440E9B0")]
		public static Dictionary<TNode, List<MKPHKNHNCLA<TType>>> DJNOOCHNAOD(TRoot AHKBBGKKCNK, TDeps DNJOEPEBEMJ, TGraph NCNAHELFBKL, IEnumerable<TNode> FHGKIGCPICD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x44175F0", Offset = "0x4415DF0", VA = "0x1844175F0")]
		private static (Dictionary<TTerm, LBHIPMKLABM<TNode>>, List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>>) ICOPJDJJCPG(IEnumerable<TNode> FHGKIGCPICD, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return default((Dictionary<TTerm, LBHIPMKLABM<TNode>>, List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x441AEE0", Offset = "0x44196E0", VA = "0x18441AEE0")]
		private static void IPPNLONBGOH(TNode DDLCNKGIKEK, Dictionary<TInput, TTerm> NBABCBMKBHF, Dictionary<TOutput, TTerm> FGJEBOKHAAP, Dictionary<TTerm, LBHIPMKLABM<TNode>> HGFLFOCAJON, Dictionary<LBHIPMKLABM<TNode>, TTerm> ALGBKGHMJHK, List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> JKIAGFLFAHC, Stack<TNode> ONJOONPKCOF, List<KMEFJOBKPCB<TNode>> BCDIHFPJEHJ, LOFBCBCFCMK NIFGNHBNLFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4410810", Offset = "0x440F010", VA = "0x184410810")]
		private static Dictionary<string, TTerm> FCOFIPOIMCJ(TNode DDLCNKGIKEK, Dictionary<TTerm, LBHIPMKLABM<TNode>> HGFLFOCAJON, Dictionary<LBHIPMKLABM<TNode>, TTerm> AFOEALFIEGK, List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> JKIAGFLFAHC, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x29A5A90", Offset = "0x29A4290", VA = "0x1829A5A90")]
		private static (TPort, TTerm)[] IKPLNCBNINB<TPort>(TNode DDLCNKGIKEK, Func<LOFBCBCFCMK, TNode, int> KLDBFNLDMMG, Func<LOFBCBCFCMK, TNode, int, TPort> BKHNHEKJJAH, Func<LOFBCBCFCMK, TPort, TType> GOGIJOEKOFN, Dictionary<TPort, TTerm> KGDJONMEPGF, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x441E590", Offset = "0x441CD90", VA = "0x18441E590")]
		private static (TTerm, TTerm) JKGLOBEPLIL((TOutput Output, TTerm Id)[] CJLPBJALDFK, List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> JKIAGFLFAHC, Dictionary<string, TTerm> AFOEALFIEGK, Stack<TNode> ONJOONPKCOF, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4422370", Offset = "0x4420B70", VA = "0x184422370")]
		private static void NGAPNOAOHJD((TInput PortKey, TTerm Id)[] FPMJPCCLAIC, TTerm CJCIDDLJNDI, TTerm EGOKHOLMBJN, List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> JKIAGFLFAHC, Dictionary<TOutput, TTerm> FGJEBOKHAAP, Dictionary<string, TTerm> AFOEALFIEGK, Stack<TNode> ONJOONPKCOF, LOFBCBCFCMK NIFGNHBNLFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x440F620", Offset = "0x440DE20", VA = "0x18440F620")]
		private static TTerm EHLAEKDGFAF(TInput FDJIPPJKNDH, List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> JKIAGFLFAHC, Dictionary<TOutput, TTerm> FGJEBOKHAAP, Stack<TNode> ONJOONPKCOF, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x440EFC0", Offset = "0x440D7C0", VA = "0x18440EFC0")]
		private static TTerm DMHOEBFNPPH([In] TType HKAKMPIMEOA, IOKind EDGHADIILHJ, List<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> JKIAGFLFAHC, IReadOnlyDictionary<string, TTerm> AFOEALFIEGK, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4412B80", Offset = "0x4411380", VA = "0x184412B80")]
		private static Dictionary<TNode, List<MKPHKNHNCLA<TType>>> GKOGFNEIHMI(TOutputSubstitution[] OAEHBCCFIDE, Dictionary<TTerm, LBHIPMKLABM<TNode>> HGFLFOCAJON, IEnumerable<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> JKIAGFLFAHC, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x441A540", Offset = "0x4418D40", VA = "0x18441A540")]
		private static Dictionary<TNode, List<MKPHKNHNCLA<TType>>> IKDPDCJJDEL(Dictionary<TTerm, LBHIPMKLABM<TNode>> HGFLFOCAJON, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x44215C0", Offset = "0x441FDC0", VA = "0x1844215C0")]
		private static void NFCKAFIIHEN([In] TNode DDLCNKGIKEK, Stack<TNode> ONJOONPKCOF, List<KMEFJOBKPCB<TNode>> BCDIHFPJEHJ, LOFBCBCFCMK NIFGNHBNLFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4411930", Offset = "0x4410130", VA = "0x184411930")]
		private static void FJBCPOKMIPF(Dictionary<LBHIPMKLABM<TNode>, TTerm> AFOEALFIEGK, List<KMEFJOBKPCB<TNode>> BCDIHFPJEHJ, LOFBCBCFCMK NIFGNHBNLFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x44145C0", Offset = "0x4412DC0", VA = "0x1844145C0")]
		private static Dictionary<TTerm, TType> HIIOAMJNBNL(Dictionary<TTerm, TOutputSubstitution> OAEHBCCFIDE, IEnumerable<KeyValuePair<TTerm, LKBACKGFHNO<TType>>> JKIAGFLFAHC, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4420320", Offset = "0x441EB20", VA = "0x184420320")]
		private static JPEFLPACLHE<TType> JPLGPCJDKJA(TOutputTerm HKAKMPIMEOA, Dictionary<TTerm, TType> JKIAGFLFAHC, Dictionary<TTerm, TType> FLJDKJIJGIC, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return default(JPEFLPACLHE<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4419EF0", Offset = "0x44186F0", VA = "0x184419EF0")]
		private static TOutputTerm IHOICCKBJDB(TOutputTerm NDAGFCNBAGK, LOFBCBCFCMK NIFGNHBNLFL)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE7E30", Offset = "0x2BE6630", VA = "0x182BE7E30")]
	public static Dictionary<TNode, List<MKPHKNHNCLA<TType>>> DJNOOCHNAOD<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::LDFGNMHONNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> EGJINJKGIAK, TRoot AHKBBGKKCNK, TGraph NCNAHELFBKL, IEnumerable<TNode> FHGKIGCPICD) where TDeps : global::PPOADEDNOLG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct MKPHKNHNCLA<TType> : IEquatable<MKPHKNHNCLA<TType>>, LDBDBADILKG<MKPHKNHNCLA<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HMPIIAILGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType BHNFIGMHKKM;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4076850", Offset = "0x4075050", VA = "0x184076850")]
	internal MKPHKNHNCLA(string GCDLMFGKKMH, [In] TType JLGAEDLPFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x43829F0", Offset = "0x43811F0", VA = "0x1843829F0")]
	public bool FBAIKNDMJDK([In] MKPHKNHNCLA<TType> OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x43829A0", Offset = "0x43811A0", VA = "0x1843829A0", Slot = "4")]
	public bool Equals(MKPHKNHNCLA<TType> OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x413DD20", Offset = "0x413C520", VA = "0x18413DD20", Slot = "0")]
	public override bool Equals(object OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CAF0", Offset = "0x1F8B2F0", VA = "0x181F8CAF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4382B20", Offset = "0x4381320", VA = "0x184382B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4382AD0", Offset = "0x43812D0", VA = "0x184382AD0", Slot = "5")]
	private bool PNJBEIPOIAC([In] MKPHKNHNCLA<TType> OGFCKBADKBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GPOHEEIJDBO
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D9F0", Offset = "0x2A9C1F0", VA = "0x182A9D9F0")]
	public static MKPHKNHNCLA<TType> OJFFIHPLODM<TType>(string GCDLMFGKKMH, TType JLGAEDLPFCD)
	{
		return default(MKPHKNHNCLA<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2A9D9B0", Offset = "0x2A9C1B0", VA = "0x182A9D9B0")]
	public static (string, TType) NHNIDOKFLEF<TType>([In] this MKPHKNHNCLA<TType> EGJINJKGIAK)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LBHIPMKLABM<TNode> : IEquatable<LBHIPMKLABM<TNode>>, LDBDBADILKG<LBHIPMKLABM<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode LCCLDDFOOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string HMPIIAILGKB;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xD63BE0", Offset = "0xD623E0", VA = "0x180D63BE0")]
	internal LBHIPMKLABM(TNode DDLCNKGIKEK, string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x413DF30", Offset = "0x413C730", VA = "0x18413DF30")]
	public bool FBAIKNDMJDK([In] LBHIPMKLABM<TNode> OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x413DE00", Offset = "0x413C600", VA = "0x18413DE00", Slot = "4")]
	public bool Equals(LBHIPMKLABM<TNode> OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x413DD20", Offset = "0x413C520", VA = "0x18413DD20", Slot = "0")]
	public override bool Equals(object OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x413E010", Offset = "0x413C810", VA = "0x18413E010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x413E120", Offset = "0x413C920", VA = "0x18413E120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x413E0D0", Offset = "0x413C8D0", VA = "0x18413E0D0", Slot = "5")]
	private bool IFHKGNGDDKN([In] LBHIPMKLABM<TNode> OGFCKBADKBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DLGIFMKLOLC
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x28F6CB0", Offset = "0x28F54B0", VA = "0x1828F6CB0")]
	public static LBHIPMKLABM<TNode> OJFFIHPLODM<TNode>(TNode DDLCNKGIKEK, string GCDLMFGKKMH)
	{
		return default(LBHIPMKLABM<TNode>);
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
