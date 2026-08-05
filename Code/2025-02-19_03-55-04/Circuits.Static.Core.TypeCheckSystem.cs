using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct IDNMPKHGCEH<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType JCIALHFDOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind KJICHBLHFMP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xAB5D40", Offset = "0xAB4940", VA = "0x180AB5D40")]
	internal IDNMPKHGCEH(TType ADFFEBFOCBD, IOKind BLCNAAGOPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x46EAEE0", Offset = "0x46E9AE0", VA = "0x1846EAEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LKIBMJCEDCE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3452D20", Offset = "0x3451920", VA = "0x183452D20")]
	public static IDNMPKHGCEH<TType> JPHABLICNHB<TType>(TType ADFFEBFOCBD, IOKind BLCNAAGOPDJ)
	{
		return default(IDNMPKHGCEH<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3452D50", Offset = "0x3451950", VA = "0x183452D50")]
	public static (TType, IOKind) PGGPKLPNFLM<TType>([In] this IDNMPKHGCEH<TType> DKGDAEBOJKO)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3452CB0", Offset = "0x34518B0", VA = "0x183452CB0")]
	public static void EALEPKLOIDH<TType>([In] this IDNMPKHGCEH<TType> DKGDAEBOJKO, [Out] TType ADFFEBFOCBD, [Out] IOKind BLCNAAGOPDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KAPHAEEFLHF<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PPNLBODDFHH<TNode> GFMCCHOPONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PPNLBODDFHH<TNode> NPLHAPJPODP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4A05B60", Offset = "0x4A04760", VA = "0x184A05B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JBFMGKMBMDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x33F3E10", Offset = "0x33F2A10", VA = "0x1833F3E10")]
	public static (PPNLBODDFHH<TNode>, PPNLBODDFHH<TNode>) PGGPKLPNFLM<TNode>([In] this KAPHAEEFLHF<TNode> DKGDAEBOJKO)
	{
		return default((PPNLBODDFHH<TNode>, PPNLBODDFHH<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x33F3D10", Offset = "0x33F2910", VA = "0x1833F3D10")]
	public static void EALEPKLOIDH<TNode>([In] this KAPHAEEFLHF<TNode> DKGDAEBOJKO, [Out] PPNLBODDFHH<TNode> NFOAKNOEKCL, [Out] PPNLBODDFHH<TNode> AFFPJGJMKFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HDDOKKNCFKG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEJDGHKGNNJ NCLIMDDBMNG(TRoot EBMDCHEPJIM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType DFODLOBLINP(TRoot EBMDCHEPJIM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDNMPKHGCEH<TType> HEMCICIMHFD(TRoot EBMDCHEPJIM, [In] IDNMPKHGCEH<TType> IFMENDFGFGN, [In] IDNMPKHGCEH<TType> DPEOCFNLADP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LJBFOMGHEPC(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TNode PCMPEACCDMA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MOHEHMEKBCD(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TNode PCMPEACCDMA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput KMDCHBBKCNA(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TNode PCMPEACCDMA, int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LDADJIPDGFJ(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TNode PCMPEACCDMA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput CCFGPJFCFAK(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TNode PCMPEACCDMA, int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<FMEPONGHBLC<TType>> DNFMEMILBEE(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TNode PCMPEACCDMA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KAPHAEEFLHF<TNode>> AMAGMBAMBBN(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TNode PCMPEACCDMA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType MAKMPCLEOHM(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TInput CPPOMEHPJCH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int DEOMNEOHKHB(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TInput CPPOMEHPJCH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput PPHGCKNIAPB(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TInput CPPOMEHPJCH, int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode CLDCAPNJJGD(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TInput CPPOMEHPJCH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType FGLCCAPPFHC(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TOutput EPOPAMDLOCM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int MCJIDLNOHFO(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TOutput EPOPAMDLOCM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput CHPKMJFPIGM(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TOutput EPOPAMDLOCM, int BIEEMEKMINN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode BDMCDIMGGAN(TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, TOutput EPOPAMDLOCM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BNMOIEOMONL(TRoot EBMDCHEPJIM, TType ADFFEBFOCBD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType MMLKIKDPLFD(TRoot EBMDCHEPJIM, TType ADFFEBFOCBD, IEnumerable<TType> LMPPCFMNHKH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IDLLIFMCALF(TRoot EBMDCHEPJIM, TType ADFFEBFOCBD, Action<TType> IFCCOPAIPCC, Action<TType> HHONCMHHNNL, Action<TType> BLJJHONDMPN, Action<TType> OHCJENMIOAK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType GHFEFIJGMFD(TRoot EBMDCHEPJIM, TType ADFFEBFOCBD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string MBIJOFMECKG(TRoot EBMDCHEPJIM, TType ADFFEBFOCBD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification LBFKGPBFKML(TRoot EBMDCHEPJIM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	PNJEPLMEKHI<TOutputSubstitution[], KLJHHNJNNDG> CNLLGEHFMBK(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm CBDPHFHJJMB(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm IKDDJFFKPHB(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TTerm HFJEBJIMMFB);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm LBDBFPOGJBF(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TTerm POLACNBCNMG, TTerm LDFAIJKGKCP);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PEBGIKKKNFD(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TTerm IFMENDFGFGN, TTerm DPEOCFNLADP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool BMAJJKLKGCB(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TOutputTerm IIOEKGAHKKG);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool LJMGBEBIGII(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TOutputTerm IIOEKGAHKKG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm NFHNCFFMJOE(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TOutputTerm IIOEKGAHKKG);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm KMIMFFEBEOF(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TOutputTerm IIOEKGAHKKG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm LECNIEBMOHG(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TOutputTerm IIOEKGAHKKG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm GOEIJMAOGCL(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TOutputSubstitution NCCNEKMANLN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm GJBABCGGMBG(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TOutputSubstitution NCCNEKMANLN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm PFNFNIHCAME(TRoot EBMDCHEPJIM, TUnification OBAEJLLJMAD, TTerm HFJEBJIMMFB);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ACHCGHAOLLI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HDDOKKNCFKG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
	public static global::ACHCGHAOLLI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> JPHABLICNHB()
	{
		return default(global::ACHCGHAOLLI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MBNDDIHEMHP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class HFCNKONGENI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HDDOKKNCFKG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class COJMDHDNDBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot JHCLOFMDCND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps ADPFGNLLLFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification BAMIFBDLKBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph PJCHMANKFIC;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public PEJDGHKGNNJ PCDKBPMHLOM
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x5BAC910", Offset = "0x5BAB510", VA = "0x185BAC910")]
				get
				{
					return default(PEJDGHKGNNJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5BADF60", Offset = "0x5BACB60", VA = "0x185BADF60")]
			private COJMDHDNDBP(TRoot EBMDCHEPJIM, TDeps CJMMHNIMOJB, TUnification CAKGNMFCJJP, TGraph GGBMBLFEJIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5BACC10", Offset = "0x5BAB810", VA = "0x185BACC10")]
			public static COJMDHDNDBP JPHABLICNHB(TRoot EBMDCHEPJIM, TDeps CJMMHNIMOJB, TUnification CAKGNMFCJJP, TGraph GGBMBLFEJIF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5BABD80", Offset = "0x5BAA980", VA = "0x185BABD80")]
			public TType DFODLOBLINP()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5BAC610", Offset = "0x5BAB210", VA = "0x185BAC610")]
			public IDNMPKHGCEH<TType> HEMCICIMHFD(IDNMPKHGCEH<TType> IFMENDFGFGN, IDNMPKHGCEH<TType> DPEOCFNLADP)
			{
				return default(IDNMPKHGCEH<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD420", Offset = "0x5BAC020", VA = "0x185BAD420")]
			public int LJBFOMGHEPC(TNode PCMPEACCDMA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD9C0", Offset = "0x5BAC5C0", VA = "0x185BAD9C0")]
			public int MOHEHMEKBCD(TNode PCMPEACCDMA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5BACD20", Offset = "0x5BAB920", VA = "0x185BACD20")]
			public TInput KMDCHBBKCNA(TNode PCMPEACCDMA, int BIEEMEKMINN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD140", Offset = "0x5BABD40", VA = "0x185BAD140")]
			public int LDADJIPDGFJ(TNode PCMPEACCDMA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5BAB890", Offset = "0x5BAA490", VA = "0x185BAB890")]
			public TOutput CCFGPJFCFAK(TNode PCMPEACCDMA, int BIEEMEKMINN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5BABE00", Offset = "0x5BAAA00", VA = "0x185BABE00")]
			public IEnumerable<FMEPONGHBLC<TType>> DNFMEMILBEE(TNode PCMPEACCDMA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5BAB390", Offset = "0x5BA9F90", VA = "0x185BAB390")]
			public IEnumerable<KAPHAEEFLHF<TNode>> AMAGMBAMBBN([In] TNode PCMPEACCDMA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD770", Offset = "0x5BAC370", VA = "0x185BAD770")]
			public TType MAKMPCLEOHM(TInput CPPOMEHPJCH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5BAC2C0", Offset = "0x5BAAEC0", VA = "0x185BAC2C0")]
			public int GJIPDBIBLGP(TInput CPPOMEHPJCH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5BADE90", Offset = "0x5BACA90", VA = "0x185BADE90")]
			public TOutput PPHGCKNIAPB(TInput CPPOMEHPJCH, int BIEEMEKMINN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5BABB60", Offset = "0x5BAA760", VA = "0x185BABB60")]
			public TNode CLDCAPNJJGD(TInput CPPOMEHPJCH)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5BABFE0", Offset = "0x5BAABE0", VA = "0x185BABFE0")]
			public TType FGLCCAPPFHC(TOutput EPOPAMDLOCM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD580", Offset = "0x5BAC180", VA = "0x185BAD580")]
			public int LPKKBPKADKJ(TOutput EPOPAMDLOCM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5BABA70", Offset = "0x5BAA670", VA = "0x185BABA70")]
			public TInput CHPKMJFPIGM(TOutput EPOPAMDLOCM, int BIEEMEKMINN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5BAB450", Offset = "0x5BAA050", VA = "0x185BAB450")]
			public TNode BDMCDIMGGAN(TOutput EPOPAMDLOCM)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5BAB690", Offset = "0x5BAA290", VA = "0x185BAB690")]
			public bool BNMOIEOMONL(TType ADFFEBFOCBD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD900", Offset = "0x5BAC500", VA = "0x185BAD900")]
			public TType MMLKIKDPLFD(TType ADFFEBFOCBD, IEnumerable<TType> LMPPCFMNHKH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5BAC670", Offset = "0x5BAB270", VA = "0x185BAC670")]
			public void IDLLIFMCALF(TType ADFFEBFOCBD, Action<TType> IFCCOPAIPCC, Action<TType> HHONCMHHNNL, Action<TType> BLJJHONDMPN, Action<TType> OHCJENMIOAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5BAC1B0", Offset = "0x5BAADB0", VA = "0x185BAC1B0")]
			public TType GHFEFIJGMFD(TType ADFFEBFOCBD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD8C0", Offset = "0x5BAC4C0", VA = "0x185BAD8C0")]
			public string MBIJOFMECKG(TType ADFFEBFOCBD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5BAB7E0", Offset = "0x5BAA3E0", VA = "0x185BAB7E0")]
			public TTerm CBDPHFHJJMB()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5BAC8C0", Offset = "0x5BAB4C0", VA = "0x185BAC8C0")]
			public TTerm IKDDJFFKPHB(TTerm HFJEBJIMMFB)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5BACFA0", Offset = "0x5BABBA0", VA = "0x185BACFA0")]
			public TTerm LBDBFPOGJBF(TTerm POLACNBCNMG, TTerm LDFAIJKGKCP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5BADC00", Offset = "0x5BAC800", VA = "0x185BADC00")]
			public void PEBGIKKKNFD(TTerm IFMENDFGFGN, TTerm DPEOCFNLADP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD530", Offset = "0x5BAC130", VA = "0x185BAD530")]
			public bool LJMGBEBIGII(TOutputTerm HFJEBJIMMFB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5BAB5C0", Offset = "0x5BAA1C0", VA = "0x185BAB5C0")]
			public bool BMAJJKLKGCB(TOutputTerm HFJEBJIMMFB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5BABF90", Offset = "0x5BAAB90", VA = "0x185BABF90")]
			public TTerm ENEMJPANAHF(TOutputTerm IIOEKGAHKKG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5BACED0", Offset = "0x5BABAD0", VA = "0x185BACED0")]
			public TOutputTerm KMIMFFEBEOF(TOutputTerm HFJEBJIMMFB)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5BAD240", Offset = "0x5BABE40", VA = "0x185BAD240")]
			public TOutputTerm LECNIEBMOHG(TOutputTerm HFJEBJIMMFB)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5BAC450", Offset = "0x5BAB050", VA = "0x185BAC450")]
			public TTerm GOEIJMAOGCL(TOutputSubstitution EMENHAFNFAJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5BAC1F0", Offset = "0x5BAADF0", VA = "0x185BAC1F0")]
			public TOutputTerm GJBABCGGMBG(TOutputSubstitution EMENHAFNFAJ)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5BADC50", Offset = "0x5BAC850", VA = "0x185BADC50")]
			public TOutputTerm PFNFNIHCAME(TTerm HFJEBJIMMFB)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EOAJJKJBEMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public COJMDHDNDBP arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public EOAJJKJBEMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4004FC0", Offset = "0x4003BC0", VA = "0x184004FC0")]
			internal int ADNHHFEPLAG(COJMDHDNDBP arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x40050E0", Offset = "0x4003CE0", VA = "0x1840050E0")]
			internal TInput ICHCAAOCBLM(COJMDHDNDBP arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4005080", Offset = "0x4003C80", VA = "0x184005080")]
			internal int GDLILDJCFKG(COJMDHDNDBP arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x40052A0", Offset = "0x4003EA0", VA = "0x1840052A0")]
			internal TOutput JAIIPDKHIEC(COJMDHDNDBP arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class INLJBCAEBMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public COJMDHDNDBP arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, PPNLBODDFHH<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<PPNLBODDFHH<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public INLJBCAEBMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4716D70", Offset = "0x4715970", VA = "0x184716D70")]
			internal (string, TTerm) LKIBHGLCNNJ(FMEPONGHBLC<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class NMKBEIIJLPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public COJMDHDNDBP arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public NMKBEIIJLPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4E5F590", Offset = "0x4E5E190", VA = "0x184E5F590")]
			internal void IEKHOBIAPGI(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4E5EF20", Offset = "0x4E5DB20", VA = "0x184E5EF20")]
			internal void BHDBMNBMPGL(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4E5F150", Offset = "0x4E5DD50", VA = "0x184E5F150")]
			internal void GFHEADPEMJH(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4E5FCB0", Offset = "0x4E5E8B0", VA = "0x184E5FCB0")]
			internal void OEHHPKFJJJD(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NEEKLFOLIGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public COJMDHDNDBP arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public NEEKLFOLIGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3FBBE80", Offset = "0x3FBAA80", VA = "0x183FBBE80")]
			internal TTerm FNJJEENFDGN(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4596060", Offset = "0x4594C60", VA = "0x184596060")]
		private static ALLOIHPLAKC CNNMOJKCLAK([CallerMemberName] string BGKKCEGMOKH = "")
		{
			return default(ALLOIHPLAKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x45A5E70", Offset = "0x45A4A70", VA = "0x1845A5E70")]
		public static Dictionary<TNode, List<FMEPONGHBLC<TType>>> PMKNFCJGFOG(TRoot EBMDCHEPJIM, TDeps CJMMHNIMOJB, TGraph GGBMBLFEJIF, IEnumerable<TNode> COOOHJEJAEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4599F30", Offset = "0x4598B30", VA = "0x184599F30")]
		private static (Dictionary<TTerm, PPNLBODDFHH<TNode>>, List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>>) GBPJDPIAJCG(IEnumerable<TNode> COOOHJEJAEK, COJMDHDNDBP GJPLANLJOMM)
		{
			return default((Dictionary<TTerm, PPNLBODDFHH<TNode>>, List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4591980", Offset = "0x4590580", VA = "0x184591980")]
		private static void AAFPGENADDH(TNode PCMPEACCDMA, Dictionary<TInput, TTerm> GFMBMGBLLDL, Dictionary<TOutput, TTerm> KGEBNPKLNII, Dictionary<TTerm, PPNLBODDFHH<TNode>> DDFJOJFMBOP, Dictionary<PPNLBODDFHH<TNode>, TTerm> MHOLOFLBIPP, List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> IFOBNFNEEEE, Stack<TNode> GHPEEKHHOLN, List<KAPHAEEFLHF<TNode>> MCCIIBHEEJB, COJMDHDNDBP GJPLANLJOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4593880", Offset = "0x4592480", VA = "0x184593880")]
		private static Dictionary<string, TTerm> BGLOBGMKMMO(TNode PCMPEACCDMA, Dictionary<TTerm, PPNLBODDFHH<TNode>> DDFJOJFMBOP, Dictionary<PPNLBODDFHH<TNode>, TTerm> ABFEHOILEHF, List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> IFOBNFNEEEE, COJMDHDNDBP GJPLANLJOMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x32B3D60", Offset = "0x32B2960", VA = "0x1832B3D60")]
		private static (TPort, TTerm)[] EJIDFJFFJEB<TPort>(TNode PCMPEACCDMA, Func<COJMDHDNDBP, TNode, int> MBNFAPHHKLL, Func<COJMDHDNDBP, TNode, int, TPort> GAJLCFEPBFA, Func<COJMDHDNDBP, TPort, TType> FMAEAEPIBHO, Dictionary<TPort, TTerm> CHNAECGAPHG, COJMDHDNDBP GJPLANLJOMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x459C630", Offset = "0x459B230", VA = "0x18459C630")]
		private static (TTerm, TTerm) GFMCKOPGPBK((TOutput Output, TTerm Id)[] JJJIDDAMLHL, List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> IFOBNFNEEEE, Dictionary<string, TTerm> ABFEHOILEHF, Stack<TNode> GHPEEKHHOLN, COJMDHDNDBP GJPLANLJOMM)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x45A1CF0", Offset = "0x45A08F0", VA = "0x1845A1CF0")]
		private static void LGBPGIFJJLJ((TInput PortKey, TTerm Id)[] FFLPFHIJDHD, TTerm GDGENKFJMLI, TTerm KPBHAINDAKN, List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> IFOBNFNEEEE, Dictionary<TOutput, TTerm> KGEBNPKLNII, Dictionary<string, TTerm> ABFEHOILEHF, Stack<TNode> GHPEEKHHOLN, COJMDHDNDBP GJPLANLJOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4594E70", Offset = "0x4593A70", VA = "0x184594E70")]
		private static TTerm CDOOHBLCGPP(TInput CPPOMEHPJCH, List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> IFOBNFNEEEE, Dictionary<TOutput, TTerm> KGEBNPKLNII, Stack<TNode> GHPEEKHHOLN, COJMDHDNDBP GJPLANLJOMM)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x45A2AE0", Offset = "0x45A16E0", VA = "0x1845A2AE0")]
		private static TTerm MLJFPLHGKIH([In] TType ADFFEBFOCBD, IOKind BLCNAAGOPDJ, List<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> IFOBNFNEEEE, IReadOnlyDictionary<string, TTerm> ABFEHOILEHF, COJMDHDNDBP GJPLANLJOMM)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x45A5170", Offset = "0x45A3D70", VA = "0x1845A5170")]
		private static Dictionary<TNode, List<FMEPONGHBLC<TType>>> PMCDBJLDHBN(TOutputSubstitution[] KCPOMHEMPJJ, Dictionary<TTerm, PPNLBODDFHH<TNode>> DDFJOJFMBOP, IEnumerable<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> IFOBNFNEEEE, COJMDHDNDBP GJPLANLJOMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4593050", Offset = "0x4591C50", VA = "0x184593050")]
		private static Dictionary<TNode, List<FMEPONGHBLC<TType>>> AAPDAMGMLLG(Dictionary<TTerm, PPNLBODDFHH<TNode>> DDFJOJFMBOP, COJMDHDNDBP GJPLANLJOMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x459E3C0", Offset = "0x459CFC0", VA = "0x18459E3C0")]
		private static void IHECPLABAFK([In] TNode PCMPEACCDMA, Stack<TNode> GHPEEKHHOLN, List<KAPHAEEFLHF<TNode>> MCCIIBHEEJB, COJMDHDNDBP GJPLANLJOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x459F150", Offset = "0x459DD50", VA = "0x18459F150")]
		private static void KKNBOCDCCOL(Dictionary<PPNLBODDFHH<TNode>, TTerm> ABFEHOILEHF, List<KAPHAEEFLHF<TNode>> MCCIIBHEEJB, COJMDHDNDBP GJPLANLJOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4598270", Offset = "0x4596E70", VA = "0x184598270")]
		private static Dictionary<TTerm, TType> DJGCFFCJMIP(Dictionary<TTerm, TOutputSubstitution> KCPOMHEMPJJ, IEnumerable<KeyValuePair<TTerm, IDNMPKHGCEH<TType>>> IFOBNFNEEEE, COJMDHDNDBP GJPLANLJOMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4593BD0", Offset = "0x45927D0", VA = "0x184593BD0")]
		private static AKMEDOPOELG<TType> BOLDNNJKCFD(TOutputTerm ADFFEBFOCBD, Dictionary<TTerm, TType> IFOBNFNEEEE, Dictionary<TTerm, TType> POACKIHOABP, COJMDHDNDBP GJPLANLJOMM)
		{
			return default(AKMEDOPOELG<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x45A3460", Offset = "0x45A2060", VA = "0x1845A3460")]
		private static TOutputTerm MLNBFMHFNLL(TOutputTerm LEDFDKPDPGC, COJMDHDNDBP GJPLANLJOMM)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3465C90", Offset = "0x3464890", VA = "0x183465C90")]
	public static Dictionary<TNode, List<FMEPONGHBLC<TType>>> PMKNFCJGFOG<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::ACHCGHAOLLI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DKGDAEBOJKO, TRoot EBMDCHEPJIM, TGraph GGBMBLFEJIF, IEnumerable<TNode> COOOHJEJAEK) where TDeps : global::HDDOKKNCFKG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct FMEPONGHBLC<TType> : IEquatable<FMEPONGHBLC<TType>>, DEHBBIJPDMB<FMEPONGHBLC<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string NMFKAOGOELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType JCKPEGDPMGP;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4419DD0", Offset = "0x44189D0", VA = "0x184419DD0")]
	internal FMEPONGHBLC(string BGKKCEGMOKH, [In] TType BKJEHHGCPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4419C60", Offset = "0x4418860", VA = "0x184419C60")]
	public bool FPLOCOJHLFI([In] FMEPONGHBLC<TType> PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4419C10", Offset = "0x4418810", VA = "0x184419C10", Slot = "4")]
	public bool Equals(FMEPONGHBLC<TType> PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4419B80", Offset = "0x4418780", VA = "0x184419B80", Slot = "0")]
	public override bool Equals(object PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25A7190", Offset = "0x25A5D90", VA = "0x1825A7190", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4419D90", Offset = "0x4418990", VA = "0x184419D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4419D40", Offset = "0x4418940", VA = "0x184419D40", Slot = "5")]
	private bool JHCNMMCJAJA([In] FMEPONGHBLC<TType> PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ABKKJCNADIB
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9DB0", Offset = "0x3AB89B0", VA = "0x183AB9DB0")]
	public static FMEPONGHBLC<TType> JPHABLICNHB<TType>(string BGKKCEGMOKH, TType BKJEHHGCPCC)
	{
		return default(FMEPONGHBLC<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9DE0", Offset = "0x3AB89E0", VA = "0x183AB9DE0")]
	public static (string, TType) PGGPKLPNFLM<TType>([In] this FMEPONGHBLC<TType> DKGDAEBOJKO)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct PPNLBODDFHH<TNode> : IEquatable<PPNLBODDFHH<TNode>>, DEHBBIJPDMB<PPNLBODDFHH<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode ACIONEPINEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string NMFKAOGOELC;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x142BCA0", Offset = "0x142A8A0", VA = "0x18142BCA0")]
	internal PPNLBODDFHH(TNode PCMPEACCDMA, string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x508A8F0", Offset = "0x50894F0", VA = "0x18508A8F0")]
	public bool FPLOCOJHLFI([In] PPNLBODDFHH<TNode> PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x508A7B0", Offset = "0x50893B0", VA = "0x18508A7B0", Slot = "4")]
	public bool Equals(PPNLBODDFHH<TNode> PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4419B80", Offset = "0x4418780", VA = "0x184419B80", Slot = "0")]
	public override bool Equals(object PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x508AAB0", Offset = "0x50896B0", VA = "0x18508AAB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x508AB20", Offset = "0x5089720", VA = "0x18508AB20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x508A8A0", Offset = "0x50894A0", VA = "0x18508A8A0", Slot = "5")]
	private bool FJGKCBBNGCD([In] PPNLBODDFHH<TNode> PELBNOCGOOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HCGOAAJHBPO
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3388630", Offset = "0x3387230", VA = "0x183388630")]
	public static PPNLBODDFHH<TNode> JPHABLICNHB<TNode>(TNode PCMPEACCDMA, string BGKKCEGMOKH)
	{
		return default(PPNLBODDFHH<TNode>);
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
