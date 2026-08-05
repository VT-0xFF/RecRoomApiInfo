using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct BALIGGABEML<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType IIJIPCLFFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind JAIGIMBHDHP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x17A8790", Offset = "0x17A7B90", VA = "0x1817A8790")]
	internal BALIGGABEML(TType KHENBEDBKDI, IOKind JIEMJCLIKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x46AD020", Offset = "0x46AC420", VA = "0x1846AD020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LBGNGHNKLCN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26A49B0", Offset = "0x26A3DB0", VA = "0x1826A49B0")]
	public static BALIGGABEML<TType> PIJMMFMEPKL<TType>(TType KHENBEDBKDI, IOKind JIEMJCLIKLC)
	{
		return default(BALIGGABEML<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x26A4910", Offset = "0x26A3D10", VA = "0x1826A4910")]
	public static (TType, IOKind) CDKFCOKAEAF<TType>([In] this BALIGGABEML<TType> LHCHBOKBAPK)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x26A4950", Offset = "0x26A3D50", VA = "0x1826A4950")]
	public static void OEGHLAHCHIH<TType>([In] this BALIGGABEML<TType> LHCHBOKBAPK, [Out] TType KHENBEDBKDI, [Out] IOKind JIEMJCLIKLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct FONAEBPEEBD<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly OOFHIBPJDAG<TNode> HMDGCHIOGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly OOFHIBPJDAG<TNode> ACMJEAONALN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x36C5970", Offset = "0x36C4D70", VA = "0x1836C5970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LDMKCNLEJPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26A5AD0", Offset = "0x26A4ED0", VA = "0x1826A5AD0")]
	public static (OOFHIBPJDAG<TNode>, OOFHIBPJDAG<TNode>) CDKFCOKAEAF<TNode>([In] this FONAEBPEEBD<TNode> LHCHBOKBAPK)
	{
		return default((OOFHIBPJDAG<TNode>, OOFHIBPJDAG<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26A5B70", Offset = "0x26A4F70", VA = "0x1826A5B70")]
	public static void OEGHLAHCHIH<TNode>([In] this FONAEBPEEBD<TNode> LHCHBOKBAPK, [Out] OOFHIBPJDAG<TNode> NAJACJFDALM, [Out] OOFHIBPJDAG<TNode> AKBGGCAJIBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CNONLHNOKKD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OOGEGPGEIEB JCJGCBCOJJM(TRoot MMKDJDGOBEM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType KOFBEKJJOCN(TRoot MMKDJDGOBEM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BALIGGABEML<TType> CGDADAAOBEF(TRoot MMKDJDGOBEM, [In] BALIGGABEML<TType> KKNFIGGNDFK, [In] BALIGGABEML<TType> PPBIBECNBNN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NALKMBIOADG(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TNode LJOKPMONGEA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KMFOKJFPANP(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TNode LJOKPMONGEA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput MLPDICHLKOO(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TNode LJOKPMONGEA, int FGBBDGJMFEH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IOMCCOLEMJG(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TNode LJOKPMONGEA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput HIKENKLGFKH(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TNode LJOKPMONGEA, int FGBBDGJMFEH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<EMAFOMOMLNH<TType>> GLIEFDAKLJC(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TNode LJOKPMONGEA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<FONAEBPEEBD<TNode>> LJNPLMODPDG(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TNode LJOKPMONGEA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType MCEOLJEFMNE(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TInput KJOOLMAMLNL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int CFIMODIHKGI(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TInput KJOOLMAMLNL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput LMEAIBCJFOO(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TInput KJOOLMAMLNL, int FGBBDGJMFEH);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode OFJGIKECBKN(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TInput KJOOLMAMLNL);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType KLHIJNABNGK(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TOutput NOBJGCEECEA);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int AEKABEDEGIE(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TOutput NOBJGCEECEA);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput GHNMPEFNGGL(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TOutput NOBJGCEECEA, int FGBBDGJMFEH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode OIDMKHBKMHI(TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, TOutput NOBJGCEECEA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CMGHLLKJPON(TRoot MMKDJDGOBEM, TType KHENBEDBKDI);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType BGCBLHNNJIM(TRoot MMKDJDGOBEM, TType KHENBEDBKDI, IEnumerable<TType> JDGLHILINEP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MDBOOAFLOIG(TRoot MMKDJDGOBEM, TType KHENBEDBKDI, Action<TType> NHIDEEFEAOB, Action<TType> PLCJBDDJCHF, Action<TType> PCGHBKNEBKE, Action<TType> LFBFFKKJGCI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType GOGMFLGPNFG(TRoot MMKDJDGOBEM, TType KHENBEDBKDI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string DGBCFBKBBDG(TRoot MMKDJDGOBEM, TType KHENBEDBKDI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification JOIIBGHEDDH(TRoot MMKDJDGOBEM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	EGECKPFNJNE<TOutputSubstitution[], JIBPJLBDKCG> DOCNLEACJKM(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm MIBAJLPFDFA(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm JEIBHJGMEMH(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TTerm ABGIOEJNHGE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm IEIHLDHNFLN(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TTerm IGAFFNPKBFA, TTerm HBMIPEJIPBL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BNKFLJCFBON(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TTerm KKNFIGGNDFK, TTerm PPBIBECNBNN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool BFKHIAJKELJ(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TOutputTerm MFNCNAKFLEF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CFBGPGMOFNE(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TOutputTerm MFNCNAKFLEF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm GEGCMKABFAI(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TOutputTerm MFNCNAKFLEF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm DNAJAHBGBEK(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TOutputTerm MFNCNAKFLEF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm AKCBKGMMMMP(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TOutputTerm MFNCNAKFLEF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm KLMJPNAENFH(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TOutputSubstitution MFMDBLBOONM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm MOLCONEFCCN(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TOutputSubstitution MFMDBLBOONM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm KBKKGEBLNBH(TRoot MMKDJDGOBEM, TUnification PDKHFIEILFC, TTerm ABGIOEJNHGE);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ENOHEHIFDKJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CNONLHNOKKD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0")]
	public static global::ENOHEHIFDKJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> PIJMMFMEPKL()
	{
		return default(global::ENOHEHIFDKJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HKCJMJGJODM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class EJBLHAMGHBD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CNONLHNOKKD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class CMJPEEEKNMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot KCJODJNNHEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps DPFDEDMMKGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification NAPGDELGKGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph DFEEPPBHEHN;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public OOGEGPGEIEB EOIDDANCAFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4BB70E0", Offset = "0x4BB64E0", VA = "0x184BB70E0")]
				get
				{
					return default(OOGEGPGEIEB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4BB7460", Offset = "0x4BB6860", VA = "0x184BB7460")]
			private CMJPEEEKNMD(TRoot MMKDJDGOBEM, TDeps BFMHNHDBGGN, TUnification GDLFCBCFMBE, TGraph GEBIGMANBLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4BB7260", Offset = "0x4BB6660", VA = "0x184BB7260")]
			public static CMJPEEEKNMD PIJMMFMEPKL(TRoot MMKDJDGOBEM, TDeps BFMHNHDBGGN, TUnification GDLFCBCFMBE, TGraph GEBIGMANBLB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6C10", Offset = "0x4BB6010", VA = "0x184BB6C10")]
			public TType KOFBEKJJOCN()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6280", Offset = "0x4BB5680", VA = "0x184BB6280")]
			public BALIGGABEML<TType> CGDADAAOBEF(BALIGGABEML<TType> KKNFIGGNDFK, BALIGGABEML<TType> PPBIBECNBNN)
			{
				return default(BALIGGABEML<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4BB7060", Offset = "0x4BB6460", VA = "0x184BB7060")]
			public int NALKMBIOADG(TNode LJOKPMONGEA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6B50", Offset = "0x4BB5F50", VA = "0x184BB6B50")]
			public int KMFOKJFPANP(TNode LJOKPMONGEA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6F80", Offset = "0x4BB6380", VA = "0x184BB6F80")]
			public TInput MLPDICHLKOO(TNode LJOKPMONGEA, int FGBBDGJMFEH)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4BB68E0", Offset = "0x4BB5CE0", VA = "0x184BB68E0")]
			public int IOMCCOLEMJG(TNode LJOKPMONGEA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4BB66A0", Offset = "0x4BB5AA0", VA = "0x184BB66A0")]
			public TOutput HIKENKLGFKH(TNode LJOKPMONGEA, int FGBBDGJMFEH)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6550", Offset = "0x4BB5950", VA = "0x184BB6550")]
			public IEnumerable<EMAFOMOMLNH<TType>> GLIEFDAKLJC(TNode LJOKPMONGEA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6C90", Offset = "0x4BB6090", VA = "0x184BB6C90")]
			public IEnumerable<FONAEBPEEBD<TNode>> LJNPLMODPDG([In] TNode LJOKPMONGEA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6DF0", Offset = "0x4BB61F0", VA = "0x184BB6DF0")]
			public TType MCEOLJEFMNE(TInput KJOOLMAMLNL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6590", Offset = "0x4BB5990", VA = "0x184BB6590")]
			public int GLPKHHNIAGH(TInput KJOOLMAMLNL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6CD0", Offset = "0x4BB60D0", VA = "0x184BB6CD0")]
			public TOutput LMEAIBCJFOO(TInput KJOOLMAMLNL, int FGBBDGJMFEH)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4BB7120", Offset = "0x4BB6520", VA = "0x184BB7120")]
			public TNode OFJGIKECBKN(TInput KJOOLMAMLNL)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6AB0", Offset = "0x4BB5EB0", VA = "0x184BB6AB0")]
			public TType KLHIJNABNGK(TOutput NOBJGCEECEA)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4BB67B0", Offset = "0x4BB5BB0", VA = "0x184BB67B0")]
			public int HJLOIJNKJMB(TOutput NOBJGCEECEA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6440", Offset = "0x4BB5840", VA = "0x184BB6440")]
			public TInput GHNMPEFNGGL(TOutput NOBJGCEECEA, int FGBBDGJMFEH)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4BB71C0", Offset = "0x4BB65C0", VA = "0x184BB71C0")]
			public TNode OIDMKHBKMHI(TOutput NOBJGCEECEA)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4BB62E0", Offset = "0x4BB56E0", VA = "0x184BB62E0")]
			public bool CMGHLLKJPON(TType KHENBEDBKDI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4BB60A0", Offset = "0x4BB54A0", VA = "0x184BB60A0")]
			public TType BGCBLHNNJIM(TType KHENBEDBKDI, IEnumerable<TType> JDGLHILINEP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6E30", Offset = "0x4BB6230", VA = "0x184BB6E30")]
			public void MDBOOAFLOIG(TType KHENBEDBKDI, Action<TType> NHIDEEFEAOB, Action<TType> PLCJBDDJCHF, Action<TType> PCGHBKNEBKE, Action<TType> LFBFFKKJGCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6620", Offset = "0x4BB5A20", VA = "0x184BB6620")]
			public TType GOGMFLGPNFG(TType KHENBEDBKDI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6320", Offset = "0x4BB5720", VA = "0x184BB6320")]
			public string DGBCFBKBBDG(TType KHENBEDBKDI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6E90", Offset = "0x4BB6290", VA = "0x184BB6E90")]
			public TTerm MIBAJLPFDFA()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6920", Offset = "0x4BB5D20", VA = "0x184BB6920")]
			public TTerm JEIBHJGMEMH(TTerm ABGIOEJNHGE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6800", Offset = "0x4BB5C00", VA = "0x184BB6800")]
			public TTerm IEIHLDHNFLN(TTerm IGAFFNPKBFA, TTerm HBMIPEJIPBL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4BB60E0", Offset = "0x4BB54E0", VA = "0x184BB60E0")]
			public void BNKFLJCFBON(TTerm KKNFIGGNDFK, TTerm PPBIBECNBNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6180", Offset = "0x4BB5580", VA = "0x184BB6180")]
			public bool CFBGPGMOFNE(TOutputTerm ABGIOEJNHGE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6000", Offset = "0x4BB5400", VA = "0x184BB6000")]
			public bool BFKHIAJKELJ(TOutputTerm ABGIOEJNHGE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4BB5EC0", Offset = "0x4BB52C0", VA = "0x184BB5EC0")]
			public TTerm AEEGAJLONCP(TOutputTerm MFNCNAKFLEF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4BB63A0", Offset = "0x4BB57A0", VA = "0x184BB63A0")]
			public TOutputTerm DNAJAHBGBEK(TOutputTerm ABGIOEJNHGE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4BB5F60", Offset = "0x4BB5360", VA = "0x184BB5F60")]
			public TOutputTerm AKCBKGMMMMP(TOutputTerm ABGIOEJNHGE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6B00", Offset = "0x4BB5F00", VA = "0x184BB6B00")]
			public TTerm KLMJPNAENFH(TOutputSubstitution EJAKIBOOPOG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6FD0", Offset = "0x4BB63D0", VA = "0x184BB6FD0")]
			public TOutputTerm MOLCONEFCCN(TOutputSubstitution EJAKIBOOPOG)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4BB6A10", Offset = "0x4BB5E10", VA = "0x184BB6A10")]
			public TOutputTerm KBKKGEBLNBH(TTerm ABGIOEJNHGE)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class AODFEBDAMBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public CMJPEEEKNMD arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public AODFEBDAMBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x38A1AE0", Offset = "0x38A0EE0", VA = "0x1838A1AE0")]
			internal int NJLLLNDOCID(CMJPEEEKNMD arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x38A1980", Offset = "0x38A0D80", VA = "0x1838A1980")]
			internal TInput GHLMIJKIINL(CMJPEEEKNMD arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x38A1A90", Offset = "0x38A0E90", VA = "0x1838A1A90")]
			internal int MLCBHMEJOCG(CMJPEEEKNMD arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x38A1B90", Offset = "0x38A0F90", VA = "0x1838A1B90")]
			internal TOutput PHMFPNLACBK(CMJPEEEKNMD arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PAKBFOEPBDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public CMJPEEEKNMD arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, OOFHIBPJDAG<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<OOFHIBPJDAG<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, BALIGGABEML<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public PAKBFOEPBDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4046770", Offset = "0x4045B70", VA = "0x184046770")]
			internal (string, TTerm) CBBBDPBGFHB(EMAFOMOMLNH<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BIJGBBFOCBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public CMJPEEEKNMD arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, BALIGGABEML<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public BIJGBBFOCBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x470D330", Offset = "0x470C730", VA = "0x18470D330")]
			internal void EKKKPHEDBKD(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x470CD00", Offset = "0x470C100", VA = "0x18470CD00")]
			internal void EJGEJIGIJDA(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x470D570", Offset = "0x470C970", VA = "0x18470D570")]
			internal void IMADOKKIGEP(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x470CA80", Offset = "0x470BE80", VA = "0x18470CA80")]
			internal void CBCGJECBMOD(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CMKPCJBEILA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public CMJPEEEKNMD arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public CMKPCJBEILA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x32BF080", Offset = "0x32BE480", VA = "0x1832BF080")]
			internal TTerm IMMBCDIAMAA(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32C54F0", Offset = "0x32C48F0", VA = "0x1832C54F0")]
		private static MEMAGMMPIIM KHIAPCGFFLK([CallerMemberName] string ADLKEGECLOG = "")
		{
			return default(MEMAGMMPIIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32C0480", Offset = "0x32BF880", VA = "0x1832C0480")]
		public static Dictionary<TNode, List<EMAFOMOMLNH<TType>>> DDAJBPFNOOP(TRoot MMKDJDGOBEM, TDeps BFMHNHDBGGN, TGraph GEBIGMANBLB, IEnumerable<TNode> OIBLLINBCCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x32C49F0", Offset = "0x32C3DF0", VA = "0x1832C49F0")]
		private static (Dictionary<TTerm, OOFHIBPJDAG<TNode>>, List<KeyValuePair<TTerm, BALIGGABEML<TType>>>) KAIMABNDBEE(IEnumerable<TNode> OIBLLINBCCF, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return default((Dictionary<TTerm, OOFHIBPJDAG<TNode>>, List<KeyValuePair<TTerm, BALIGGABEML<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x32CB560", Offset = "0x32CA960", VA = "0x1832CB560")]
		private static void ODFJKJFAPFJ(TNode LJOKPMONGEA, Dictionary<TInput, TTerm> MLAAGPPBHPI, Dictionary<TOutput, TTerm> ILGCMFEGFBD, Dictionary<TTerm, OOFHIBPJDAG<TNode>> AJDJCLEKKKL, Dictionary<OOFHIBPJDAG<TNode>, TTerm> GOKOFHJHKCE, List<KeyValuePair<TTerm, BALIGGABEML<TType>>> NNIAJDNCCCP, Stack<TNode> EAMIMIKELOC, List<FONAEBPEEBD<TNode>> KJDNJIPPADA, CMJPEEEKNMD NGEFMGOMMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x32BF110", Offset = "0x32BE510", VA = "0x1832BF110")]
		private static Dictionary<string, TTerm> ADEMCAPGMPE(TNode LJOKPMONGEA, Dictionary<TTerm, OOFHIBPJDAG<TNode>> AJDJCLEKKKL, Dictionary<OOFHIBPJDAG<TNode>, TTerm> CDILEHBKNGB, List<KeyValuePair<TTerm, BALIGGABEML<TType>>> NNIAJDNCCCP, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2474610", Offset = "0x2473A10", VA = "0x182474610")]
		private static (TPort, TTerm)[] AIDDJDEPMPB<TPort>(TNode LJOKPMONGEA, Func<CMJPEEEKNMD, TNode, int> FDPAOONNLMH, Func<CMJPEEEKNMD, TNode, int, TPort> FOFEIBOBNNN, Func<CMJPEEEKNMD, TPort, TType> OFGNAFJAEEL, Dictionary<TPort, TTerm> MDHBMEHMBPE, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32C9F70", Offset = "0x32C9370", VA = "0x1832C9F70")]
		private static (TTerm, TTerm) LKKKFGJHENJ((TOutput Output, TTerm Id)[] OFHIKDPPEHH, List<KeyValuePair<TTerm, BALIGGABEML<TType>>> NNIAJDNCCCP, Dictionary<string, TTerm> CDILEHBKNGB, Stack<TNode> EAMIMIKELOC, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x32C21B0", Offset = "0x32C15B0", VA = "0x1832C21B0")]
		private static void GBPNHEGDJMD((TInput PortKey, TTerm Id)[] KPAAJJLDABA, TTerm MMEEKIELCPF, TTerm BJGOPPMIDBE, List<KeyValuePair<TTerm, BALIGGABEML<TType>>> NNIAJDNCCCP, Dictionary<TOutput, TTerm> ILGCMFEGFBD, Dictionary<string, TTerm> CDILEHBKNGB, Stack<TNode> EAMIMIKELOC, CMJPEEEKNMD NGEFMGOMMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x32BF720", Offset = "0x32BEB20", VA = "0x1832BF720")]
		private static TTerm APEOGBFJMOK(TInput KJOOLMAMLNL, List<KeyValuePair<TTerm, BALIGGABEML<TType>>> NNIAJDNCCCP, Dictionary<TOutput, TTerm> ILGCMFEGFBD, Stack<TNode> EAMIMIKELOC, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x32C0F80", Offset = "0x32C0380", VA = "0x1832C0F80")]
		private static TTerm FCJBOELMBML([In] TType KHENBEDBKDI, IOKind JIEMJCLIKLC, List<KeyValuePair<TTerm, BALIGGABEML<TType>>> NNIAJDNCCCP, IReadOnlyDictionary<string, TTerm> CDILEHBKNGB, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32C7310", Offset = "0x32C6710", VA = "0x1832C7310")]
		private static Dictionary<TNode, List<EMAFOMOMLNH<TType>>> LAPFJMBFEPH(TOutputSubstitution[] DNNJNDHBDOP, Dictionary<TTerm, OOFHIBPJDAG<TNode>> AJDJCLEKKKL, IEnumerable<KeyValuePair<TTerm, BALIGGABEML<TType>>> NNIAJDNCCCP, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x32C2DD0", Offset = "0x32C21D0", VA = "0x1832C2DD0")]
		private static Dictionary<TNode, List<EMAFOMOMLNH<TType>>> GGEENHDEFFO(Dictionary<TTerm, OOFHIBPJDAG<TNode>> AJDJCLEKKKL, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x32C36B0", Offset = "0x32C2AB0", VA = "0x1832C36B0")]
		private static void ILHHENEKDBN([In] TNode LJOKPMONGEA, Stack<TNode> EAMIMIKELOC, List<FONAEBPEEBD<TNode>> KJDNJIPPADA, CMJPEEEKNMD NGEFMGOMMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x32CAC00", Offset = "0x32CA000", VA = "0x1832CAC00")]
		private static void MLANKOOIAOP(Dictionary<OOFHIBPJDAG<TNode>, TTerm> CDILEHBKNGB, List<FONAEBPEEBD<TNode>> KJDNJIPPADA, CMJPEEEKNMD NGEFMGOMMMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x32C5530", Offset = "0x32C4930", VA = "0x1832C5530")]
		private static Dictionary<TTerm, TType> KKFKLIJHCCC(Dictionary<TTerm, TOutputSubstitution> DNNJNDHBDOP, IEnumerable<KeyValuePair<TTerm, BALIGGABEML<TType>>> NNIAJDNCCCP, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x32C8AD0", Offset = "0x32C7ED0", VA = "0x1832C8AD0")]
		private static NMGFKHEHGDM<TType> LDKKIDHGHGD(TOutputTerm KHENBEDBKDI, Dictionary<TTerm, TType> NNIAJDNCCCP, Dictionary<TTerm, TType> JILCDALCFCE, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return default(NMGFKHEHGDM<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x32C0300", Offset = "0x32BF700", VA = "0x1832C0300")]
		private static TOutputTerm DBHGHLKHCKE(TOutputTerm AHOPNHGMGGL, CMJPEEEKNMD NGEFMGOMMMN)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x261BC30", Offset = "0x261B030", VA = "0x18261BC30")]
	public static Dictionary<TNode, List<EMAFOMOMLNH<TType>>> DDAJBPFNOOP<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::ENOHEHIFDKJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> LHCHBOKBAPK, TRoot MMKDJDGOBEM, TGraph GEBIGMANBLB, IEnumerable<TNode> OIBLLINBCCF) where TDeps : global::CNONLHNOKKD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EMAFOMOMLNH<TType> : IEquatable<EMAFOMOMLNH<TType>>, BGJBDKDCKID<EMAFOMOMLNH<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string DACJMNMHBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType OIGLPKIABOP;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x32E3C40", Offset = "0x32E3040", VA = "0x1832E3C40")]
	internal EMAFOMOMLNH(string ADLKEGECLOG, [In] TType NPHJOOELCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x32E3A10", Offset = "0x32E2E10", VA = "0x1832E3A10")]
	public bool CCJPNHFMMHK([In] EMAFOMOMLNH<TType> JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x32E3AE0", Offset = "0x32E2EE0", VA = "0x1832E3AE0", Slot = "4")]
	public bool Equals(EMAFOMOMLNH<TType> JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x32E3B30", Offset = "0x32E2F30", VA = "0x1832E3B30", Slot = "0")]
	public override bool Equals(object JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D65CA0", Offset = "0x1D650A0", VA = "0x181D65CA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x32E3C00", Offset = "0x32E3000", VA = "0x1832E3C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x32E3BB0", Offset = "0x32E2FB0", VA = "0x1832E3BB0", Slot = "5")]
	private bool FJEMBHCMFHI([In] EMAFOMOMLNH<TType> JLCJEDAFKJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MEPDJEPNDBA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x26D52A0", Offset = "0x26D46A0", VA = "0x1826D52A0")]
	public static EMAFOMOMLNH<TType> PIJMMFMEPKL<TType>(string ADLKEGECLOG, TType NPHJOOELCGO)
	{
		return default(EMAFOMOMLNH<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x26D5260", Offset = "0x26D4660", VA = "0x1826D5260")]
	public static (string, TType) CDKFCOKAEAF<TType>([In] this EMAFOMOMLNH<TType> LHCHBOKBAPK)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct OOFHIBPJDAG<TNode> : IEquatable<OOFHIBPJDAG<TNode>>, BGJBDKDCKID<OOFHIBPJDAG<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode LBPIDMGJBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string DACJMNMHBIF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xB97A80", Offset = "0xB96E80", VA = "0x180B97A80")]
	internal OOFHIBPJDAG(TNode LJOKPMONGEA, string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3FAB060", Offset = "0x3FAA460", VA = "0x183FAB060")]
	public bool CCJPNHFMMHK([In] OOFHIBPJDAG<TNode> JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3FAB2A0", Offset = "0x3FAA6A0", VA = "0x183FAB2A0", Slot = "4")]
	public bool Equals(OOFHIBPJDAG<TNode> JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x32E3B30", Offset = "0x32E2F30", VA = "0x1832E3B30", Slot = "0")]
	public override bool Equals(object JLCJEDAFKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3FAB340", Offset = "0x3FAA740", VA = "0x183FAB340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3FAB3F0", Offset = "0x3FAA7F0", VA = "0x183FAB3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3FAB250", Offset = "0x3FAA650", VA = "0x183FAB250", Slot = "5")]
	private bool ELAIOIJEOHC([In] OOFHIBPJDAG<TNode> JLCJEDAFKJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DOLBBGLEGOA
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x24B4730", Offset = "0x24B3B30", VA = "0x1824B4730")]
	public static OOFHIBPJDAG<TNode> PIJMMFMEPKL<TNode>(TNode LJOKPMONGEA, string ADLKEGECLOG)
	{
		return default(OOFHIBPJDAG<TNode>);
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
