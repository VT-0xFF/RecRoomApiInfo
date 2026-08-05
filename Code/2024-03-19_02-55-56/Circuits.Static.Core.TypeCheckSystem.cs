using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct POBLMCANGOJ<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType MJIJAFEKHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind OEBHKDHKJPA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x18A4B00", Offset = "0x18A3B00", VA = "0x1818A4B00")]
	internal POBLMCANGOJ(TType IKHOLAJCJOG, IOKind AAKMKLNJOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x41631E0", Offset = "0x41621E0", VA = "0x1841631E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DCANHPIKLPE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2634D00", Offset = "0x2633D00", VA = "0x182634D00")]
	public static POBLMCANGOJ<TType> NAJBLLJFKKI<TType>(TType IKHOLAJCJOG, IOKind AAKMKLNJOIE)
	{
		return default(POBLMCANGOJ<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2634CC0", Offset = "0x2633CC0", VA = "0x182634CC0")]
	public static (TType, IOKind) BOACBOKKJGD<TType>([In] this POBLMCANGOJ<TType> AOFEPADBPDL)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2634D30", Offset = "0x2633D30", VA = "0x182634D30")]
	public static void PHGKEHMLKIB<TType>([In] this POBLMCANGOJ<TType> AOFEPADBPDL, [Out] TType IKHOLAJCJOG, [Out] IOKind AAKMKLNJOIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct BDPCNCGBLLI<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LMOEOCJAJCP<TNode> HCDGKDANAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LMOEOCJAJCP<TNode> NGMHKBICCDE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x47A71E0", Offset = "0x47A61E0", VA = "0x1847A71E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ABACCJOOABM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CBC0", Offset = "0x2D7BBC0", VA = "0x182D7CBC0")]
	public static (LMOEOCJAJCP<TNode>, LMOEOCJAJCP<TNode>) BOACBOKKJGD<TNode>([In] this BDPCNCGBLLI<TNode> AOFEPADBPDL)
	{
		return default((LMOEOCJAJCP<TNode>, LMOEOCJAJCP<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CC60", Offset = "0x2D7BC60", VA = "0x182D7CC60")]
	public static void PHGKEHMLKIB<TNode>([In] this BDPCNCGBLLI<TNode> AOFEPADBPDL, [Out] LMOEOCJAJCP<TNode> FKOPFOECIGH, [Out] LMOEOCJAJCP<TNode> DGKDEKELGHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HFBMEKPJKIK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OFIDEHIHCEH HLABDKAMOBG(TRoot HLMIIECLDOF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType BADLNNNMMJA(TRoot HLMIIECLDOF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	POBLMCANGOJ<TType> GLCDIOBLKFI(TRoot HLMIIECLDOF, [In] POBLMCANGOJ<TType> JAIIDLBPFND, [In] POBLMCANGOJ<TType> ECFHNKKEKBJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KBKLKICMGJC(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TNode PENNBKHEEFF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OOJGFDDCJLB(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TNode PENNBKHEEFF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput CFHOFHCICCO(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TNode PENNBKHEEFF, int GCDIELAOHNA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int GDJKBLIHAKP(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TNode PENNBKHEEFF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput FIMBFIGAJLD(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TNode PENNBKHEEFF, int GCDIELAOHNA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<JMFNKJCJKNH<TType>> AMAKJMFCHDB(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TNode PENNBKHEEFF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<BDPCNCGBLLI<TNode>> MFELCCDFAON(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TNode PENNBKHEEFF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NOJDJCAPBGN(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TInput IIBDJBFNFJM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int NLDJCPIEONO(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TInput IIBDJBFNFJM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput OMDNOIJHHBJ(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TInput IIBDJBFNFJM, int GCDIELAOHNA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode OMLONGCNJOM(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TInput IIBDJBFNFJM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType LGFBFFHIIGL(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TOutput MMMJGLCBBNG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int NAMGJFDKFJN(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TOutput MMMJGLCBBNG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput BBMLIKFJLHN(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TOutput MMMJGLCBBNG, int GCDIELAOHNA);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode MNBPAANFABL(TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, TOutput MMMJGLCBBNG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PPPBOPLAAAM(TRoot HLMIIECLDOF, TType IKHOLAJCJOG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType OPALCBDPHCB(TRoot HLMIIECLDOF, TType IKHOLAJCJOG, IEnumerable<TType> BMCCMOCAMIF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IBPEIMDPNCN(TRoot HLMIIECLDOF, TType IKHOLAJCJOG, Action<TType> CINGKPHGMCC, Action<TType> EKPONHIEMKE, Action<TType> BBMMDJOKINO, Action<TType> CECDHGFMHEJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType PFENNBPOMLD(TRoot HLMIIECLDOF, TType IKHOLAJCJOG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string HAFIJPMPOCG(TRoot HLMIIECLDOF, TType IKHOLAJCJOG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification CNLGEFCHDBI(TRoot HLMIIECLDOF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	PBAOJGOHCMJ<TOutputSubstitution[], HMMHOLFLIGF> CBJAGDPDCOJ(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm FPJHBHBLMIE(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm PAJFFPOBJGI(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TTerm GHGHJGNHELA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm IPFLBCIMDMK(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TTerm KDHDAOEHKNF, TTerm IIGDCCOFNDC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JIGGHIGEHBD(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TTerm JAIIDLBPFND, TTerm ECFHNKKEKBJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool ILDOPDKHBBB(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TOutputTerm BJEGDKNOAGN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool ODBHPIKCHAN(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TOutputTerm BJEGDKNOAGN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm MJNDGKGNJHM(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TOutputTerm BJEGDKNOAGN);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm JCIPGDBGFIB(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TOutputTerm BJEGDKNOAGN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm GHFPBCEFGDK(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TOutputTerm BJEGDKNOAGN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm HFECAJNCFCO(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TOutputSubstitution AIAEFIPBOPE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm NMHPFHCIDFN(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TOutputSubstitution AIAEFIPBOPE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm FMIBHGKAPBP(TRoot HLMIIECLDOF, TUnification OKBGNHIPEBM, TTerm GHGHJGNHELA);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BPHCAOBCEOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HFBMEKPJKIK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0")]
	public static global::BPHCAOBCEOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> NAJBLLJFKKI()
	{
		return default(global::BPHCAOBCEOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NLHPHAIEFEM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class NBBGCINBLBB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HFBMEKPJKIK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class JGBPJDBPHCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot NGBMMOKFIFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps JNLAGLJECOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification AGAEDJKGIOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph DJALNAOKAAN;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public OFIDEHIHCEH PDJENNKIDAD
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x3B392C0", Offset = "0x3B382C0", VA = "0x183B392C0")]
				get
				{
					return default(OFIDEHIHCEH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3B3B1E0", Offset = "0x3B3A1E0", VA = "0x183B3B1E0")]
			private JGBPJDBPHCE(TRoot HLMIIECLDOF, TDeps DGILCEAPJEB, TUnification FGGGCPKGHIM, TGraph AIAGFCPBNID)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3B3A2D0", Offset = "0x3B392D0", VA = "0x183B3A2D0")]
			public static JGBPJDBPHCE NAJBLLJFKKI(TRoot HLMIIECLDOF, TDeps DGILCEAPJEB, TUnification FGGGCPKGHIM, TGraph AIAGFCPBNID)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3B386F0", Offset = "0x3B376F0", VA = "0x183B386F0")]
			public TType BADLNNNMMJA()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3B39030", Offset = "0x3B38030", VA = "0x183B39030")]
			public POBLMCANGOJ<TType> GLCDIOBLKFI(POBLMCANGOJ<TType> JAIIDLBPFND, POBLMCANGOJ<TType> ECFHNKKEKBJ)
			{
				return default(POBLMCANGOJ<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3B39D80", Offset = "0x3B38D80", VA = "0x183B39D80")]
			public int KBKLKICMGJC(TNode PENNBKHEEFF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3B3AD00", Offset = "0x3B39D00", VA = "0x183B3AD00")]
			public int OOJGFDDCJLB(TNode PENNBKHEEFF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3B38A50", Offset = "0x3B37A50", VA = "0x183B38A50")]
			public TInput CFHOFHCICCO(TNode PENNBKHEEFF, int GCDIELAOHNA)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3B38E90", Offset = "0x3B37E90", VA = "0x183B38E90")]
			public int GDJKBLIHAKP(TNode PENNBKHEEFF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3B38BB0", Offset = "0x3B37BB0", VA = "0x183B38BB0")]
			public TOutput FIMBFIGAJLD(TNode PENNBKHEEFF, int GCDIELAOHNA)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3B38630", Offset = "0x3B37630", VA = "0x183B38630")]
			public IEnumerable<JMFNKJCJKNH<TType>> AMAKJMFCHDB(TNode PENNBKHEEFF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3B3A0F0", Offset = "0x3B390F0", VA = "0x183B3A0F0")]
			public IEnumerable<BDPCNCGBLLI<TNode>> MFELCCDFAON([In] TNode PENNBKHEEFF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3B3A890", Offset = "0x3B39890", VA = "0x183B3A890")]
			public TType NOJDJCAPBGN(TInput IIBDJBFNFJM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3B3A020", Offset = "0x3B39020", VA = "0x183B3A020")]
			public int LHLJPDECMHH(TInput IIBDJBFNFJM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3B3AB10", Offset = "0x3B39B10", VA = "0x183B3AB10")]
			public TOutput OMDNOIJHHBJ(TInput IIBDJBFNFJM, int GCDIELAOHNA)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3B3AC30", Offset = "0x3B39C30", VA = "0x183B3AC30")]
			public TNode OMLONGCNJOM(TInput IIBDJBFNFJM)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3B39F50", Offset = "0x3B38F50", VA = "0x183B39F50")]
			public TType LGFBFFHIIGL(TOutput MMMJGLCBBNG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3B3A5D0", Offset = "0x3B395D0", VA = "0x183B3A5D0")]
			public int NLJFBDKCFJL(TOutput MMMJGLCBBNG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3B387D0", Offset = "0x3B377D0", VA = "0x183B387D0")]
			public TInput BBMLIKFJLHN(TOutput MMMJGLCBBNG, int GCDIELAOHNA)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3B3A200", Offset = "0x3B39200", VA = "0x183B3A200")]
			public TNode MNBPAANFABL(TOutput MMMJGLCBBNG)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3B3B050", Offset = "0x3B3A050", VA = "0x183B3B050")]
			public bool PPPBOPLAAAM(TType IKHOLAJCJOG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3B3AD80", Offset = "0x3B39D80", VA = "0x183B3AD80")]
			public TType OPALCBDPHCB(TType IKHOLAJCJOG, IEnumerable<TType> BMCCMOCAMIF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3B39560", Offset = "0x3B38560", VA = "0x183B39560")]
			public void IBPEIMDPNCN(TType IKHOLAJCJOG, Action<TType> CINGKPHGMCC, Action<TType> EKPONHIEMKE, Action<TType> BBMMDJOKINO, Action<TType> CECDHGFMHEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3B3AFA0", Offset = "0x3B39FA0", VA = "0x183B3AFA0")]
			public TType PFENNBPOMLD(TType IKHOLAJCJOG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3B39340", Offset = "0x3B38340", VA = "0x183B39340")]
			public string HAFIJPMPOCG(TType IKHOLAJCJOG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3B38D20", Offset = "0x3B37D20", VA = "0x183B38D20")]
			public TTerm FPJHBHBLMIE()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3B3AE40", Offset = "0x3B39E40", VA = "0x183B3AE40")]
			public TTerm PAJFFPOBJGI(TTerm GHGHJGNHELA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3B39950", Offset = "0x3B38950", VA = "0x183B39950")]
			public TTerm IPFLBCIMDMK(TTerm KDHDAOEHKNF, TTerm IIGDCCOFNDC)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3B39BE0", Offset = "0x3B38BE0", VA = "0x183B39BE0")]
			public void JIGGHIGEHBD(TTerm JAIIDLBPFND, TTerm ECFHNKKEKBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3B3A920", Offset = "0x3B39920", VA = "0x183B3A920")]
			public bool ODBHPIKCHAN(TOutputTerm GHGHJGNHELA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3B396E0", Offset = "0x3B386E0", VA = "0x183B396E0")]
			public bool ILDOPDKHBBB(TOutputTerm GHGHJGNHELA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3B39A70", Offset = "0x3B38A70", VA = "0x183B39A70")]
			public TTerm JCFMCAENLHL(TOutputTerm BJEGDKNOAGN)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3B39AC0", Offset = "0x3B38AC0", VA = "0x183B39AC0")]
			public TOutputTerm JCIPGDBGFIB(TOutputTerm GHGHJGNHELA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3B38FE0", Offset = "0x3B37FE0", VA = "0x183B38FE0")]
			public TOutputTerm GHFPBCEFGDK(TOutputTerm GHGHJGNHELA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3B39490", Offset = "0x3B38490", VA = "0x183B39490")]
			public TTerm HFECAJNCFCO(TOutputSubstitution AIDIEFBPFIK)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3B3A6F0", Offset = "0x3B396F0", VA = "0x183B3A6F0")]
			public TOutputTerm NMHPFHCIDFN(TOutputSubstitution AIDIEFBPFIK)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3B38CD0", Offset = "0x3B37CD0", VA = "0x183B38CD0")]
			public TOutputTerm FMIBHGKAPBP(TTerm GHGHJGNHELA)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BKPBIPEMKDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public JGBPJDBPHCE arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public BKPBIPEMKDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x47BE900", Offset = "0x47BD900", VA = "0x1847BE900")]
			internal int EDPBCJNBKLB(JGBPJDBPHCE arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x47BEAE0", Offset = "0x47BDAE0", VA = "0x1847BEAE0")]
			internal TInput NGEHAICMFGC(JGBPJDBPHCE arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x47BE8B0", Offset = "0x47BD8B0", VA = "0x1847BE8B0")]
			internal int BKGHOPOOGOE(JGBPJDBPHCE arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x47BE950", Offset = "0x47BD950", VA = "0x1847BE950")]
			internal TOutput LKKGJDHMKOL(JGBPJDBPHCE arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class AGCPHFOFEEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public JGBPJDBPHCE arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, LMOEOCJAJCP<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<LMOEOCJAJCP<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public AGCPHFOFEEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x37A13B0", Offset = "0x37A03B0", VA = "0x1837A13B0")]
			internal (string, TTerm) CCADLAAPMIO(JMFNKJCJKNH<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PLCHDMGEPAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JGBPJDBPHCE arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public PLCHDMGEPAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4155A40", Offset = "0x4154A40", VA = "0x184155A40")]
			internal void HNKCOJOPOHO(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4155C80", Offset = "0x4154C80", VA = "0x184155C80")]
			internal void IDPMLFFLAGJ(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4155200", Offset = "0x4154200", VA = "0x184155200")]
			internal void EMBPOIIHKKH(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x41556C0", Offset = "0x41546C0", VA = "0x1841556C0")]
			internal void GIDCJOFPOAF(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BMBLCNECEHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JGBPJDBPHCE arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
			public BMBLCNECEHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x37A1B10", Offset = "0x37A0B10", VA = "0x1837A1B10")]
			internal TTerm OPMNGNMGGLL(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C230", Offset = "0x3F2B230", VA = "0x183F2C230")]
		private static AHHHHCHPBMN EJBFKNGCLMM([CallerMemberName] string GCMHJLFFDHO = "")
		{
			return default(AHHHHCHPBMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3F31120", Offset = "0x3F30120", VA = "0x183F31120")]
		public static Dictionary<TNode, List<JMFNKJCJKNH<TType>>> KICHPDPHKFL(TRoot HLMIIECLDOF, TDeps DGILCEAPJEB, TGraph AIAGFCPBNID, IEnumerable<TNode> GIEJLAIGHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D4F0", Offset = "0x3F2C4F0", VA = "0x183F2D4F0")]
		private static (Dictionary<TTerm, LMOEOCJAJCP<TNode>>, List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>>) FMNFBMIACKB(IEnumerable<TNode> GIEJLAIGHGP, JGBPJDBPHCE OMFIAODHHCI)
		{
			return default((Dictionary<TTerm, LMOEOCJAJCP<TNode>>, List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3F2EA70", Offset = "0x3F2DA70", VA = "0x183F2EA70")]
		private static void GJGAFCEIFOL(TNode PENNBKHEEFF, Dictionary<TInput, TTerm> MEOFFIEJJAJ, Dictionary<TOutput, TTerm> NMLPGKFBGFP, Dictionary<TTerm, LMOEOCJAJCP<TNode>> DOMEMFBFGDK, Dictionary<LMOEOCJAJCP<TNode>, TTerm> NOANLJPDDMF, List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> GCFIHLMOKBB, Stack<TNode> LAKCBLPAPJE, List<BDPCNCGBLLI<TNode>> PLBACKCOEAM, JGBPJDBPHCE OMFIAODHHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3F2BC20", Offset = "0x3F2AC20", VA = "0x183F2BC20")]
		private static Dictionary<string, TTerm> DEIJLNIGGIM(TNode PENNBKHEEFF, Dictionary<TTerm, LMOEOCJAJCP<TNode>> DOMEMFBFGDK, Dictionary<LMOEOCJAJCP<TNode>, TTerm> IDHJPFCGJDM, List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> GCFIHLMOKBB, JGBPJDBPHCE OMFIAODHHCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x26CE3E0", Offset = "0x26CD3E0", VA = "0x1826CE3E0")]
		private static (TPort, TTerm)[] MLMCOHEBGAI<TPort>(TNode PENNBKHEEFF, Func<JGBPJDBPHCE, TNode, int> OLIILECCMOA, Func<JGBPJDBPHCE, TNode, int, TPort> BEPMCIFMNEI, Func<JGBPJDBPHCE, TPort, TType> BJPHFKFGOLG, Dictionary<TPort, TTerm> MDIGNGLDCFP, JGBPJDBPHCE OMFIAODHHCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3F36740", Offset = "0x3F35740", VA = "0x183F36740")]
		private static (TTerm, TTerm) OOBFLHOBOKA((TOutput Output, TTerm Id)[] APEGEIBEGIF, List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> GCFIHLMOKBB, Dictionary<string, TTerm> IDHJPFCGJDM, Stack<TNode> LAKCBLPAPJE, JGBPJDBPHCE OMFIAODHHCI)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A390", Offset = "0x3F29390", VA = "0x183F2A390")]
		private static void ACCPBBDEPEC((TInput PortKey, TTerm Id)[] LKOHEIMNPAA, TTerm EEMDIPHNDGL, TTerm DDHEKKMHKGE, List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> GCFIHLMOKBB, Dictionary<TOutput, TTerm> NMLPGKFBGFP, Dictionary<string, TTerm> IDHJPFCGJDM, Stack<TNode> LAKCBLPAPJE, JGBPJDBPHCE OMFIAODHHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CFF0", Offset = "0x3F2BFF0", VA = "0x183F2CFF0")]
		private static TTerm FGDDOOFEFDJ(TInput IIBDJBFNFJM, List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> GCFIHLMOKBB, Dictionary<TOutput, TTerm> NMLPGKFBGFP, Stack<TNode> LAKCBLPAPJE, JGBPJDBPHCE OMFIAODHHCI)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3F354C0", Offset = "0x3F344C0", VA = "0x183F354C0")]
		private static TTerm NLLJMJGIGBG([In] TType IKHOLAJCJOG, IOKind AAKMKLNJOIE, List<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> GCFIHLMOKBB, IReadOnlyDictionary<string, TTerm> IDHJPFCGJDM, JGBPJDBPHCE OMFIAODHHCI)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3F31F20", Offset = "0x3F30F20", VA = "0x183F31F20")]
		private static Dictionary<TNode, List<JMFNKJCJKNH<TType>>> MGHEBJAKCMD(TOutputSubstitution[] KEOALGODHMB, Dictionary<TTerm, LMOEOCJAJCP<TNode>> DOMEMFBFGDK, IEnumerable<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> GCFIHLMOKBB, JGBPJDBPHCE OMFIAODHHCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3F302C0", Offset = "0x3F2F2C0", VA = "0x183F302C0")]
		private static Dictionary<TNode, List<JMFNKJCJKNH<TType>>> IJMECDCEDIN(Dictionary<TTerm, LMOEOCJAJCP<TNode>> DOMEMFBFGDK, JGBPJDBPHCE OMFIAODHHCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3F31AE0", Offset = "0x3F30AE0", VA = "0x183F31AE0")]
		private static void MCLCHFJBJDC([In] TNode PENNBKHEEFF, Stack<TNode> LAKCBLPAPJE, List<BDPCNCGBLLI<TNode>> PLBACKCOEAM, JGBPJDBPHCE OMFIAODHHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3F376D0", Offset = "0x3F366D0", VA = "0x183F376D0")]
		private static void PINAHMNJKJE(Dictionary<LMOEOCJAJCP<TNode>, TTerm> IDHJPFCGJDM, List<BDPCNCGBLLI<TNode>> PLBACKCOEAM, JGBPJDBPHCE OMFIAODHHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3F336E0", Offset = "0x3F326E0", VA = "0x183F336E0")]
		private static Dictionary<TTerm, TType> NGDFIFIDIAK(Dictionary<TTerm, TOutputSubstitution> KEOALGODHMB, IEnumerable<KeyValuePair<TTerm, POBLMCANGOJ<TType>>> GCFIHLMOKBB, JGBPJDBPHCE OMFIAODHHCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3F2C2B0", Offset = "0x3F2B2B0", VA = "0x183F2C2B0")]
		private static DCPPBKBIMOM<TType> FDKFAAMGEKH(TOutputTerm IKHOLAJCJOG, Dictionary<TTerm, TType> GCFIHLMOKBB, Dictionary<TTerm, TType> AMEJCPPGMKJ, JGBPJDBPHCE OMFIAODHHCI)
		{
			return default(DCPPBKBIMOM<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3F37550", Offset = "0x3F36550", VA = "0x183F37550")]
		private static TOutputTerm PAHEBDHINCA(TOutputTerm FIMJOJAPAPM, JGBPJDBPHCE OMFIAODHHCI)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28F7180", Offset = "0x28F6180", VA = "0x1828F7180")]
	public static Dictionary<TNode, List<JMFNKJCJKNH<TType>>> KICHPDPHKFL<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::BPHCAOBCEOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> AOFEPADBPDL, TRoot HLMIIECLDOF, TGraph AIAGFCPBNID, IEnumerable<TNode> GIEJLAIGHGP) where TDeps : global::HFBMEKPJKIK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct JMFNKJCJKNH<TType> : IEquatable<JMFNKJCJKNH<TType>>, CFFCNEHDDII<JMFNKJCJKNH<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string JJGLPFPAGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType PMFJPHDFKMI;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DC50", Offset = "0x3B4CC50", VA = "0x183B4DC50")]
	internal JMFNKJCJKNH(string GCMHJLFFDHO, [In] TType JPBFFJHMMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DA20", Offset = "0x3B4CA20", VA = "0x183B4DA20")]
	public bool DPBLCPAGKGA([In] JMFNKJCJKNH<TType> PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DAF0", Offset = "0x3B4CAF0", VA = "0x183B4DAF0", Slot = "4")]
	public bool Equals(JMFNKJCJKNH<TType> PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DB40", Offset = "0x3B4CB40", VA = "0x183B4DB40", Slot = "0")]
	public override bool Equals(object PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BBA0", Offset = "0x1E2ABA0", VA = "0x181E2BBA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DC10", Offset = "0x3B4CC10", VA = "0x183B4DC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DBC0", Offset = "0x3B4CBC0", VA = "0x183B4DBC0", Slot = "5")]
	private bool IEIOHLHGBMK([In] JMFNKJCJKNH<TType> PJNBIAFGNNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DIHCHEFCPPP
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x263D510", Offset = "0x263C510", VA = "0x18263D510")]
	public static JMFNKJCJKNH<TType> NAJBLLJFKKI<TType>(string GCMHJLFFDHO, TType JPBFFJHMMHH)
	{
		return default(JMFNKJCJKNH<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x263D4D0", Offset = "0x263C4D0", VA = "0x18263D4D0")]
	public static (string, TType) BOACBOKKJGD<TType>([In] this JMFNKJCJKNH<TType> AOFEPADBPDL)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LMOEOCJAJCP<TNode> : IEquatable<LMOEOCJAJCP<TNode>>, CFFCNEHDDII<LMOEOCJAJCP<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode MHIINAILEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string JJGLPFPAGLF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xC44CC0", Offset = "0xC43CC0", VA = "0x180C44CC0")]
	internal LMOEOCJAJCP(TNode PENNBKHEEFF, string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA860", Offset = "0x3CF9860", VA = "0x183CFA860")]
	public bool DPBLCPAGKGA([In] LMOEOCJAJCP<TNode> PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA980", Offset = "0x3CF9980", VA = "0x183CFA980", Slot = "4")]
	public bool Equals(LMOEOCJAJCP<TNode> PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3B4DB40", Offset = "0x3B4CB40", VA = "0x183B4DB40", Slot = "0")]
	public override bool Equals(object PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3CFA9D0", Offset = "0x3CF99D0", VA = "0x183CFA9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3CFAB20", Offset = "0x3CF9B20", VA = "0x183CFAB20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3CFAA40", Offset = "0x3CF9A40", VA = "0x183CFAA40", Slot = "5")]
	private bool INMAJDKJMCC([In] LMOEOCJAJCP<TNode> PJNBIAFGNNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JGHAHKMPADL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x28032B0", Offset = "0x28022B0", VA = "0x1828032B0")]
	public static LMOEOCJAJCP<TNode> NAJBLLJFKKI<TNode>(TNode PENNBKHEEFF, string GCMHJLFFDHO)
	{
		return default(LMOEOCJAJCP<TNode>);
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
