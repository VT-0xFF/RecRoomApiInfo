using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct JFFOOOPNGNI<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType FJKMPMDCIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind FGNGJAHPFDM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1BA5FC0", Offset = "0x1BA45C0", VA = "0x181BA5FC0")]
	internal JFFOOOPNGNI(TType BDKLEMDNAFL, IOKind HKNOINJGIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x401BAB0", Offset = "0x401A0B0", VA = "0x18401BAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CIKIFKCHAFO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x296F7D0", Offset = "0x296DDD0", VA = "0x18296F7D0")]
	public static JFFOOOPNGNI<TType> NKOJKFHACJH<TType>(TType BDKLEMDNAFL, IOKind HKNOINJGIFI)
	{
		return default(JFFOOOPNGNI<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x296F720", Offset = "0x296DD20", VA = "0x18296F720")]
	public static (TType, IOKind) HPKPEBDGJMB<TType>([In] this JFFOOOPNGNI<TType> ELMHNMGFNPC)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x296F760", Offset = "0x296DD60", VA = "0x18296F760")]
	public static void NFDKAIMDEJH<TType>([In] this JFFOOOPNGNI<TType> ELMHNMGFNPC, [Out] TType BDKLEMDNAFL, [Out] IOKind HKNOINJGIFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct CKFJJPMDCIF<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LMPHMINOOLE<TNode> ILKGLIOPDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LMPHMINOOLE<TNode> EJAPOBEFAMF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x50BD980", Offset = "0x50BBF80", VA = "0x1850BD980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LHKPPPLCNIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C12DC0", Offset = "0x2C113C0", VA = "0x182C12DC0")]
	public static (LMPHMINOOLE<TNode>, LMPHMINOOLE<TNode>) HPKPEBDGJMB<TNode>([In] this CKFJJPMDCIF<TNode> ELMHNMGFNPC)
	{
		return default((LMPHMINOOLE<TNode>, LMPHMINOOLE<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C12E60", Offset = "0x2C11460", VA = "0x182C12E60")]
	public static void NFDKAIMDEJH<TNode>([In] this CKFJJPMDCIF<TNode> ELMHNMGFNPC, [Out] LMPHMINOOLE<TNode> GKFLJIIICHM, [Out] LMPHMINOOLE<TNode> GCLENKIGLBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EMLLDHLGIKO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOOGKFLMCLH ONHGHMNAGFC(TRoot GOKNAIEAOEG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType LPJMDNEBMHO(TRoot GOKNAIEAOEG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JFFOOOPNGNI<TType> GFJPAILFHHE(TRoot GOKNAIEAOEG, [In] JFFOOOPNGNI<TType> MIGBCLGIEPA, [In] JFFOOOPNGNI<TType> MMACHIKDDMH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int NELPAGGOOJO(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TNode FNNLHNNHGAD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LHOOLIEJGNB(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TNode FNNLHNNHGAD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput ADFJNBNOLCD(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TNode FNNLHNNHGAD, int EBDMAJMOJLN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int APDEGOLABJE(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TNode FNNLHNNHGAD);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput KHBJONGJNJN(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TNode FNNLHNNHGAD, int EBDMAJMOJLN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<FNBNBFACOFM<TType>> KBHMICAMKPD(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TNode FNNLHNNHGAD);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<CKFJJPMDCIF<TNode>> EBNNHHNELGE(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TNode FNNLHNNHGAD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType PCELBBCKFBC(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TInput NGALCNCLJMG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int NBOGAEFJELG(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TInput NGALCNCLJMG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput PCCNNFGIDMC(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TInput NGALCNCLJMG, int EBDMAJMOJLN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode PICKIMKFGJN(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TInput NGALCNCLJMG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType FMJFCAANOKJ(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TOutput MBDLHAFMFEI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int FIIKJIEDEOI(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TOutput MBDLHAFMFEI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput MAIFMIMMCHH(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TOutput MBDLHAFMFEI, int EBDMAJMOJLN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode LPGNCOECLPO(TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, TOutput MBDLHAFMFEI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JLMFGMDLNNL(TRoot GOKNAIEAOEG, TType BDKLEMDNAFL);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType CAPMBPMBOIC(TRoot GOKNAIEAOEG, TType BDKLEMDNAFL, IEnumerable<TType> LOKCNNKODNL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ANMLDBJLBLN(TRoot GOKNAIEAOEG, TType BDKLEMDNAFL, Action<TType> MEHBDBJGCAC, Action<TType> JMMLEOCKEBI, Action<TType> IPECGFICPHO, Action<TType> FIBDGKBPNEN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType KLCHEEEKDMJ(TRoot GOKNAIEAOEG, TType BDKLEMDNAFL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string LDJBMEIDKHI(TRoot GOKNAIEAOEG, TType BDKLEMDNAFL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification PAPBAFBLBBM(TRoot GOKNAIEAOEG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	HHANDHIMCMH<TOutputSubstitution[], EKHHLAEJNGE> DHGLFLAOFAD(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm FDEFBAFJNIE(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm PPOAPPFJLKP(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TTerm HAIBMLBHLIG);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm BDEEJFLHLHB(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TTerm ANJCAANKHOF, TTerm NLDMHMGCOCL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EIPOGHFANAI(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TTerm MIGBCLGIEPA, TTerm MMACHIKDDMH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool EEPIHICMPFN(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TOutputTerm FAJPPKJNLKO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DIHNCNKGKIA(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TOutputTerm FAJPPKJNLKO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm LIFIEEKDBLL(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TOutputTerm FAJPPKJNLKO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm GPLKABJEAPL(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TOutputTerm FAJPPKJNLKO);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm EIHMLFEHCLI(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TOutputTerm FAJPPKJNLKO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm OBIIPNAOKAL(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TOutputSubstitution IBADLOJDMJL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm LGLEHHKPAHE(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TOutputSubstitution IBADLOJDMJL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm MECBPANEIFB(TRoot GOKNAIEAOEG, TUnification LDGIMNHJHCJ, TTerm HAIBMLBHLIG);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PJODGHHBGIK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::EMLLDHLGIKO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190")]
	public static global::PJODGHHBGIK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> NKOJKFHACJH()
	{
		return default(global::PJODGHHBGIK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GJJIJDLMBKA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class FINILHGGLII<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::EMLLDHLGIKO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class PBDNGEAOHEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot OCNEBKEFEDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps CMJNCHPHOJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification NEMKDHFICGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph IEKNCEFIFMG;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public HOOGKFLMCLH LKHLBIAIHLB
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4802C40", Offset = "0x4801240", VA = "0x184802C40")]
				get
				{
					return default(HOOGKFLMCLH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4803CA0", Offset = "0x48022A0", VA = "0x184803CA0")]
			private PBDNGEAOHEG(TRoot GOKNAIEAOEG, TDeps MEELJJGMLGH, TUnification DGDNGCJLHPK, TGraph CEAMJPPFFCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4803360", Offset = "0x4801960", VA = "0x184803360")]
			public static PBDNGEAOHEG NKOJKFHACJH(TRoot GOKNAIEAOEG, TDeps MEELJJGMLGH, TUnification DGDNGCJLHPK, TGraph CEAMJPPFFCL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4802E80", Offset = "0x4801480", VA = "0x184802E80")]
			public TType LPJMDNEBMHO()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4802170", Offset = "0x4800770", VA = "0x184802170")]
			public JFFOOOPNGNI<TType> GFJPAILFHHE(JFFOOOPNGNI<TType> MIGBCLGIEPA, JFFOOOPNGNI<TType> MMACHIKDDMH)
			{
				return default(JFFOOOPNGNI<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4803260", Offset = "0x4801860", VA = "0x184803260")]
			public int NELPAGGOOJO(TNode FNNLHNNHGAD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4802A80", Offset = "0x4801080", VA = "0x184802A80")]
			public int LHOOLIEJGNB(TNode FNNLHNNHGAD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x48011A0", Offset = "0x47FF7A0", VA = "0x1848011A0")]
			public TInput ADFJNBNOLCD(TNode FNNLHNNHGAD, int EBDMAJMOJLN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4801370", Offset = "0x47FF970", VA = "0x184801370")]
			public int APDEGOLABJE(TNode FNNLHNNHGAD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x48026B0", Offset = "0x4800CB0", VA = "0x1848026B0")]
			public TOutput KHBJONGJNJN(TNode FNNLHNNHGAD, int EBDMAJMOJLN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x48025D0", Offset = "0x4800BD0", VA = "0x1848025D0")]
			public IEnumerable<FNBNBFACOFM<TType>> KBHMICAMKPD(TNode FNNLHNNHGAD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x48017F0", Offset = "0x47FFDF0", VA = "0x1848017F0")]
			public IEnumerable<CKFJJPMDCIF<TNode>> EBNNHHNELGE([In] TNode FNNLHNNHGAD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x48039A0", Offset = "0x4801FA0", VA = "0x1848039A0")]
			public TType PCELBBCKFBC(TInput NGALCNCLJMG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4803100", Offset = "0x4801700", VA = "0x184803100")]
			public int MDKCIIANCCN(TInput NGALCNCLJMG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4803880", Offset = "0x4801E80", VA = "0x184803880")]
			public TOutput PCCNNFGIDMC(TInput NGALCNCLJMG, int EBDMAJMOJLN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x48039E0", Offset = "0x4801FE0", VA = "0x1848039E0")]
			public TNode PICKIMKFGJN(TInput NGALCNCLJMG)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4801FF0", Offset = "0x48005F0", VA = "0x184801FF0")]
			public TType FMJFCAANOKJ(TOutput MBDLHAFMFEI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4801A10", Offset = "0x4800010", VA = "0x184801A10")]
			public int EFOKCMOMIOL(TOutput MBDLHAFMFEI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4802EC0", Offset = "0x48014C0", VA = "0x184802EC0")]
			public TInput MAIFMIMMCHH(TOutput MBDLHAFMFEI, int EBDMAJMOJLN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4802D40", Offset = "0x4801340", VA = "0x184802D40")]
			public TNode LPGNCOECLPO(TOutput MBDLHAFMFEI)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4802400", Offset = "0x4800A00", VA = "0x184802400")]
			public bool JLMFGMDLNNL(TType BDKLEMDNAFL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4801610", Offset = "0x47FFC10", VA = "0x184801610")]
			public TType CAPMBPMBOIC(TType BDKLEMDNAFL, IEnumerable<TType> LOKCNNKODNL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x48011F0", Offset = "0x47FF7F0", VA = "0x1848011F0")]
			public void ANMLDBJLBLN(TType BDKLEMDNAFL, Action<TType> MEHBDBJGCAC, Action<TType> JMMLEOCKEBI, Action<TType> IPECGFICPHO, Action<TType> FIBDGKBPNEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4802820", Offset = "0x4800E20", VA = "0x184802820")]
			public TType KLCHEEEKDMJ(TType BDKLEMDNAFL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4802970", Offset = "0x4800F70", VA = "0x184802970")]
			public string LDJBMEIDKHI(TType BDKLEMDNAFL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4801DE0", Offset = "0x48003E0", VA = "0x184801DE0")]
			public TTerm FDEFBAFJNIE()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4803BD0", Offset = "0x48021D0", VA = "0x184803BD0")]
			public TTerm PPOAPPFJLKP(TTerm HAIBMLBHLIG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x48014C0", Offset = "0x47FFAC0", VA = "0x1848014C0")]
			public TTerm BDEEJFLHLHB(TTerm ANJCAANKHOF, TTerm NLDMHMGCOCL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4801D40", Offset = "0x4800340", VA = "0x184801D40")]
			public void EIPOGHFANAI(TTerm MIGBCLGIEPA, TTerm MMACHIKDDMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x48017A0", Offset = "0x47FFDA0", VA = "0x1848017A0")]
			public bool DIHNCNKGKIA(TOutputTerm HAIBMLBHLIG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x48018F0", Offset = "0x47FFEF0", VA = "0x1848018F0")]
			public bool EEPIHICMPFN(TOutputTerm HAIBMLBHLIG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4801FA0", Offset = "0x48005A0", VA = "0x184801FA0")]
			public TTerm FFOGMNONGNI(TOutputTerm FAJPPKJNLKO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x48022E0", Offset = "0x48008E0", VA = "0x1848022E0")]
			public TOutputTerm GPLKABJEAPL(TOutputTerm HAIBMLBHLIG)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4801B30", Offset = "0x4800130", VA = "0x184801B30")]
			public TOutputTerm EIHMLFEHCLI(TOutputTerm HAIBMLBHLIG)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4803690", Offset = "0x4801C90", VA = "0x184803690")]
			public TTerm OBIIPNAOKAL(TOutputSubstitution IEHNBCFNOPH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4802A30", Offset = "0x4801030", VA = "0x184802A30")]
			public TOutputTerm LGLEHHKPAHE(TOutputSubstitution IEHNBCFNOPH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x48031C0", Offset = "0x48017C0", VA = "0x1848031C0")]
			public TOutputTerm MECBPANEIFB(TTerm HAIBMLBHLIG)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class OAIGAONHGOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PBDNGEAOHEG arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public OAIGAONHGOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x46D0230", Offset = "0x46CE830", VA = "0x1846D0230")]
			internal int MGCMBCIFBAA(PBDNGEAOHEG arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x46D0110", Offset = "0x46CE710", VA = "0x1846D0110")]
			internal TInput LHBALFDDHPN(PBDNGEAOHEG arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x46D01D0", Offset = "0x46CE7D0", VA = "0x1846D01D0")]
			internal int MBFDOCHDJLM(PBDNGEAOHEG arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x46D0290", Offset = "0x46CE890", VA = "0x1846D0290")]
			internal TOutput PAJFHGJPLBK(PBDNGEAOHEG arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IFGPLGMDFNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public PBDNGEAOHEG arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, LMPHMINOOLE<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<LMPHMINOOLE<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public IFGPLGMDFNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3E17170", Offset = "0x3E15770", VA = "0x183E17170")]
			internal (string, TTerm) MLJLNGMEJID(FNBNBFACOFM<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LDGJDPCDPNN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PBDNGEAOHEG arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public LDGJDPCDPNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4299570", Offset = "0x4297B70", VA = "0x184299570")]
			internal void NOMHHAIKGPC(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x429A0C0", Offset = "0x42986C0", VA = "0x18429A0C0")]
			internal void PLNKIKACKOO(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4299130", Offset = "0x4297730", VA = "0x184299130")]
			internal void KNFAAHDFCIK(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4299AF0", Offset = "0x42980F0", VA = "0x184299AF0")]
			internal void OHMJMIGBNAP(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FPPCKJOMAOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PBDNGEAOHEG arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public FPPCKJOMAOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3B8BBE0", Offset = "0x3B8A1E0", VA = "0x183B8BBE0")]
			internal TTerm BPGFBNBPPCA(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3B9DF50", Offset = "0x3B9C550", VA = "0x183B9DF50")]
		private static EDOLANCNCJN ECOMJPIDCBK([CallerMemberName] string LGJDNDBECCI = "")
		{
			return default(EDOLANCNCJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BA3130", Offset = "0x3BA1730", VA = "0x183BA3130")]
		public static Dictionary<TNode, List<FNBNBFACOFM<TType>>> LMFIDFCDGLL(TRoot GOKNAIEAOEG, TDeps MEELJJGMLGH, TGraph CEAMJPPFFCL, IEnumerable<TNode> AKAOPJJAEAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BA2510", Offset = "0x3BA0B10", VA = "0x183BA2510")]
		private static (Dictionary<TTerm, LMPHMINOOLE<TNode>>, List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>>) LDDHKIIGPLO(IEnumerable<TNode> AKAOPJJAEAN, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return default((Dictionary<TTerm, LMPHMINOOLE<TNode>>, List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C820", Offset = "0x3B9AE20", VA = "0x183B9C820")]
		private static void CMDJIPKAFCA(TNode FNNLHNNHGAD, Dictionary<TInput, TTerm> OCFINBLFGFN, Dictionary<TOutput, TTerm> DDHOEBMGEMI, Dictionary<TTerm, LMPHMINOOLE<TNode>> ABJEEBJMIDN, Dictionary<LMPHMINOOLE<TNode>, TTerm> EIGJEJMDICH, List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> KPMGLMJAJEK, Stack<TNode> CBJLOMMDGIM, List<CKFJJPMDCIF<TNode>> GFHFHALGMPN, PBDNGEAOHEG BBMJLAKPCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3B9EFA0", Offset = "0x3B9D5A0", VA = "0x183B9EFA0")]
		private static Dictionary<string, TTerm> FDMHLGGEFNL(TNode FNNLHNNHGAD, Dictionary<TTerm, LMPHMINOOLE<TNode>> ABJEEBJMIDN, Dictionary<LMPHMINOOLE<TNode>, TTerm> GOIGMIAHPMO, List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> KPMGLMJAJEK, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2879430", Offset = "0x2877A30", VA = "0x182879430")]
		private static (TPort, TTerm)[] FDOABAKAJKC<TPort>(TNode FNNLHNNHGAD, Func<PBDNGEAOHEG, TNode, int> EJILKELACNA, Func<PBDNGEAOHEG, TNode, int, TPort> GCHMCCKNEDB, Func<PBDNGEAOHEG, TPort, TType> EEPHPPBLHHH, Dictionary<TPort, TTerm> FOPDEAKCODN, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3B9F2F0", Offset = "0x3B9D8F0", VA = "0x183B9F2F0")]
		private static (TTerm, TTerm) FLGCCCPDBDN((TOutput Output, TTerm Id)[] BOCGOFMFKIA, List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> KPMGLMJAJEK, Dictionary<string, TTerm> GOIGMIAHPMO, Stack<TNode> CBJLOMMDGIM, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3BA01A0", Offset = "0x3B9E7A0", VA = "0x183BA01A0")]
		private static void FNIOMBJIMIC((TInput PortKey, TTerm Id)[] DBGKGGMDOJE, TTerm BOFMKCGGCPC, TTerm DPBMAPILLOA, List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> KPMGLMJAJEK, Dictionary<TOutput, TTerm> DDHOEBMGEMI, Dictionary<string, TTerm> GOIGMIAHPMO, Stack<TNode> CBJLOMMDGIM, PBDNGEAOHEG BBMJLAKPCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BA18E0", Offset = "0x3B9FEE0", VA = "0x183BA18E0")]
		private static TTerm GMOFBDCDIPF(TInput NGALCNCLJMG, List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> KPMGLMJAJEK, Dictionary<TOutput, TTerm> DDHOEBMGEMI, Stack<TNode> CBJLOMMDGIM, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3BA1EB0", Offset = "0x3BA04B0", VA = "0x183BA1EB0")]
		private static TTerm LAOKOJGGDNG([In] TType BDKLEMDNAFL, IOKind HKNOINJGIFI, List<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> KPMGLMJAJEK, IReadOnlyDictionary<string, TTerm> GOIGMIAHPMO, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3B9BB00", Offset = "0x3B9A100", VA = "0x183B9BB00")]
		private static Dictionary<TNode, List<FNBNBFACOFM<TType>>> AGNOIHNELIG(TOutputSubstitution[] KONBANNKHNP, Dictionary<TTerm, LMPHMINOOLE<TNode>> ABJEEBJMIDN, IEnumerable<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> KPMGLMJAJEK, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3B9DA80", Offset = "0x3B9C080", VA = "0x183B9DA80")]
		private static Dictionary<TNode, List<FNBNBFACOFM<TType>>> DOKPNLMLKEP(Dictionary<TTerm, LMPHMINOOLE<TNode>> ABJEEBJMIDN, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3BA3740", Offset = "0x3BA1D40", VA = "0x183BA3740")]
		private static void NFGOICFEJDB([In] TNode FNNLHNNHGAD, Stack<TNode> CBJLOMMDGIM, List<CKFJJPMDCIF<TNode>> GFHFHALGMPN, PBDNGEAOHEG BBMJLAKPCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3B9D550", Offset = "0x3B9BB50", VA = "0x183B9D550")]
		private static void CMNCHACMAAF(Dictionary<LMPHMINOOLE<TNode>, TTerm> GOIGMIAHPMO, List<CKFJJPMDCIF<TNode>> GFHFHALGMPN, PBDNGEAOHEG BBMJLAKPCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B9DF90", Offset = "0x3B9C590", VA = "0x183B9DF90")]
		private static Dictionary<TTerm, TType> EOBCDPBIDJE(Dictionary<TTerm, TOutputSubstitution> KONBANNKHNP, IEnumerable<KeyValuePair<TTerm, JFFOOOPNGNI<TType>>> KPMGLMJAJEK, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3BA0F90", Offset = "0x3B9F590", VA = "0x183BA0F90")]
		private static IABIEENJMAD<TType> FOCEJGHOKFA(TOutputTerm BDKLEMDNAFL, Dictionary<TTerm, TType> KPMGLMJAJEK, Dictionary<TTerm, TType> GIPKBENJJKM, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return default(IABIEENJMAD<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3BA3BD0", Offset = "0x3BA21D0", VA = "0x183BA3BD0")]
		private static TOutputTerm OHIOMPIKMFA(TOutputTerm GPDIFAFMDFK, PBDNGEAOHEG BBMJLAKPCGK)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B72A40", Offset = "0x2B71040", VA = "0x182B72A40")]
	public static Dictionary<TNode, List<FNBNBFACOFM<TType>>> LMFIDFCDGLL<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::PJODGHHBGIK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> ELMHNMGFNPC, TRoot GOKNAIEAOEG, TGraph CEAMJPPFFCL, IEnumerable<TNode> AKAOPJJAEAN) where TDeps : global::EMLLDHLGIKO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct FNBNBFACOFM<TType> : IEquatable<FNBNBFACOFM<TType>>, JLMFENJHCPD<FNBNBFACOFM<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string IKOGEGKCJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType CHBBACNMKNF;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3C060D0", Offset = "0x3C046D0", VA = "0x183C060D0")]
	internal FNBNBFACOFM(string LGJDNDBECCI, [In] TType DCKJFGBAGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3C05E80", Offset = "0x3C04480", VA = "0x183C05E80")]
	public bool DFENCMHGJBG([In] FNBNBFACOFM<TType> OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3C05FF0", Offset = "0x3C045F0", VA = "0x183C05FF0", Slot = "4")]
	public bool Equals(FNBNBFACOFM<TType> OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3C05F60", Offset = "0x3C04560", VA = "0x183C05F60", Slot = "0")]
	public override bool Equals(object OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2036DE0", Offset = "0x20353E0", VA = "0x182036DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3C06090", Offset = "0x3C04690", VA = "0x183C06090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3C06040", Offset = "0x3C04640", VA = "0x183C06040", Slot = "5")]
	private bool OOOKBCJNBDH([In] FNBNBFACOFM<TType> OGEIJLCLBIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JCDINNGLLPC
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8F30", Offset = "0x2BB7530", VA = "0x182BB8F30")]
	public static FNBNBFACOFM<TType> NKOJKFHACJH<TType>(string LGJDNDBECCI, TType DCKJFGBAGME)
	{
		return default(FNBNBFACOFM<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8EF0", Offset = "0x2BB74F0", VA = "0x182BB8EF0")]
	public static (string, TType) HPKPEBDGJMB<TType>([In] this FNBNBFACOFM<TType> ELMHNMGFNPC)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LMPHMINOOLE<TNode> : IEquatable<LMPHMINOOLE<TNode>>, JLMFENJHCPD<LMPHMINOOLE<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode JFNMFCIEBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string IKOGEGKCJIK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xEB3A60", Offset = "0xEB2060", VA = "0x180EB3A60")]
	internal LMPHMINOOLE(TNode FNNLHNNHGAD, string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x42E6CD0", Offset = "0x42E52D0", VA = "0x1842E6CD0")]
	public bool DFENCMHGJBG([In] LMPHMINOOLE<TNode> OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x42E6E00", Offset = "0x42E5400", VA = "0x1842E6E00", Slot = "4")]
	public bool Equals(LMPHMINOOLE<TNode> OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3C05F60", Offset = "0x3C04560", VA = "0x183C05F60", Slot = "0")]
	public override bool Equals(object OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x42E6E50", Offset = "0x42E5450", VA = "0x1842E6E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x42E6FA0", Offset = "0x42E55A0", VA = "0x1842E6FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x42E6F10", Offset = "0x42E5510", VA = "0x1842E6F10", Slot = "5")]
	private bool NHDKMOMELFL([In] LMPHMINOOLE<TNode> OGEIJLCLBIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GDDHPCEABBK
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F770", Offset = "0x2B6DD70", VA = "0x182B6F770")]
	public static LMPHMINOOLE<TNode> NKOJKFHACJH<TNode>(TNode FNNLHNNHGAD, string LGJDNDBECCI)
	{
		return default(LMPHMINOOLE<TNode>);
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
