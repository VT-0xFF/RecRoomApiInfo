using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct OJHLHJLEFPP<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType FOJLLEMFFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind ICNOIECKKBN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xDAC230", Offset = "0xDAB030", VA = "0x180DAC230")]
	internal OJHLHJLEFPP(TType ADGMECOLKNH, IOKind HMDPEKHOHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5AD31C0", Offset = "0x5AD1FC0", VA = "0x185AD31C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BMJFCIFHBPG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5E30", Offset = "0x3AA4C30", VA = "0x183AA5E30")]
	public static OJHLHJLEFPP<TType> ELDPFIHNJDG<TType>(TType ADGMECOLKNH, IOKind HMDPEKHOHLP)
	{
		return default(OJHLHJLEFPP<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5E60", Offset = "0x3AA4C60", VA = "0x183AA5E60")]
	public static (TType, IOKind) JJNAPGGLFJI<TType>([In] this OJHLHJLEFPP<TType> DBBEADIHLKO)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5EA0", Offset = "0x3AA4CA0", VA = "0x183AA5EA0")]
	public static void MLOAOPFMIPK<TType>([In] this OJHLHJLEFPP<TType> DBBEADIHLKO, [Out] TType ADGMECOLKNH, [Out] IOKind HMDPEKHOHLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct FOPAPKKGHKA<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LHEAJFCOAGM<TNode> MIKICGEDOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LHEAJFCOAGM<TNode> LOMMOPMPANP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4F34BF0", Offset = "0x4F339F0", VA = "0x184F34BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DIHDOANPLAE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B58D10", Offset = "0x3B57B10", VA = "0x183B58D10")]
	public static (LHEAJFCOAGM<TNode>, LHEAJFCOAGM<TNode>) JJNAPGGLFJI<TNode>([In] this FOPAPKKGHKA<TNode> DBBEADIHLKO)
	{
		return default((LHEAJFCOAGM<TNode>, LHEAJFCOAGM<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B58DB0", Offset = "0x3B57BB0", VA = "0x183B58DB0")]
	public static void MLOAOPFMIPK<TNode>([In] this FOPAPKKGHKA<TNode> DBBEADIHLKO, [Out] LHEAJFCOAGM<TNode> NNEMEIEKIAF, [Out] LHEAJFCOAGM<TNode> JOGLOLMOJGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MPBCPNMBOAN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NDOHEACPGPP DFPIMKDBOFB(TRoot MMENCBNBOBJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType GHHIKGMBDAN(TRoot MMENCBNBOBJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OJHLHJLEFPP<TType> KCENKMHJHKP(TRoot MMENCBNBOBJ, [In] OJHLHJLEFPP<TType> CHAEOFDBIAH, [In] OJHLHJLEFPP<TType> EBEGEKLHGJL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KKHMBNNKJEH(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TNode DFHOHFFNCIJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IOOCDIPBINP(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TNode DFHOHFFNCIJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput ADAJMMGMHNJ(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TNode DFHOHFFNCIJ, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BGPBHBAAFMC(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TNode DFHOHFFNCIJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput CPOMBOJPAGC(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TNode DFHOHFFNCIJ, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<OPMJMPLEKME<TType>> KCJDKHEFKBE(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TNode DFHOHFFNCIJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<FOPAPKKGHKA<TNode>> HOBGBCFJDJJ(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TNode DFHOHFFNCIJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType HMKKPJGDBHJ(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TInput DANFKLEPBNF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int GKCLPFIICFJ(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TInput DANFKLEPBNF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput CFLBOLJPFBB(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TInput DANFKLEPBNF, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode EBMGMGCICHA(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TInput DANFKLEPBNF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType CHCCOJAMAML(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TOutput LCAAPKFEJGM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int CHJGDCEGJNJ(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TOutput LCAAPKFEJGM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput EDEKIHMDGCK(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TOutput LCAAPKFEJGM, int JJJJBEGKNIN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode FENNBDLNOKC(TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, TOutput LCAAPKFEJGM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool ACDPLFKKFKO(TRoot MMENCBNBOBJ, TType ADGMECOLKNH);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType PMPBPIJCKMD(TRoot MMENCBNBOBJ, TType ADGMECOLKNH, IEnumerable<TType> DKGKBMHILLH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MCAEADOBGPC(TRoot MMENCBNBOBJ, TType ADGMECOLKNH, Action<TType> FCAMEFLNKFJ, Action<TType> OKEGCGMALHG, Action<TType> FHKDLKDFNBP, Action<TType> CNAHJHMPGAP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType PHDLLJIOIEK(TRoot MMENCBNBOBJ, TType ADGMECOLKNH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string LGJKCMMAIME(TRoot MMENCBNBOBJ, TType ADGMECOLKNH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification NDMCCJMBGFL(TRoot MMENCBNBOBJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GECIHKBMECG<TOutputSubstitution[], NILBFGOPNAM> FPDJOAEHJNB(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm OFGAFBKOJMA(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm IMPPCFEKIFO(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TTerm JGOGDIOAPAL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm KKNHACCNGLP(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TTerm ODAFCJJIICF, TTerm AMOBAKBDGHA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JJIOBBPNLKL(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TTerm CHAEOFDBIAH, TTerm EBEGEKLHGJL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool AJFIKNMJFCO(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TOutputTerm HFOONHAMELE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool APHNEBKBFGM(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TOutputTerm HFOONHAMELE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm FGEGNOHAFKJ(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TOutputTerm HFOONHAMELE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm KIBHCCJFGLD(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TOutputTerm HFOONHAMELE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm ONPLIEFAPFN(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TOutputTerm HFOONHAMELE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm HKENJDCCLIH(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TOutputSubstitution KJFIIHBPMOK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm CHJGLMBONLP(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TOutputSubstitution KJFIIHBPMOK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm KEKGGEBMFIH(TRoot MMENCBNBOBJ, TUnification OLLMIGAGNEP, TTerm JGOGDIOAPAL);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BLCLIBAMJLL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::MPBCPNMBOAN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xADF8C0", Offset = "0xADE6C0", VA = "0x180ADF8C0")]
	public static global::BLCLIBAMJLL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> ELDPFIHNJDG()
	{
		return default(global::BLCLIBAMJLL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KCGFNIFIMGA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class BLCFODKMHCH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::MPBCPNMBOAN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class FDBCBDDBDAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot CNGEAHLGPEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps JJFIAFGFAGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification ICAGOAGBDMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph KIHNJFNPNKG;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public NDOHEACPGPP ONMIIKMMJAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4EFB440", Offset = "0x4EFA240", VA = "0x184EFB440")]
				get
				{
					return default(NDOHEACPGPP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4EFC3D0", Offset = "0x4EFB1D0", VA = "0x184EFC3D0")]
			private FDBCBDDBDAJ(TRoot MMENCBNBOBJ, TDeps OPJFEEDOIEH, TUnification AEDKOJJNKGF, TGraph CPOICOGAHOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA760", Offset = "0x4EF9560", VA = "0x184EFA760")]
			public static FDBCBDDBDAJ ELDPFIHNJDG(TRoot MMENCBNBOBJ, TDeps OPJFEEDOIEH, TUnification AEDKOJJNKGF, TGraph CPOICOGAHOC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4EFAAE0", Offset = "0x4EF98E0", VA = "0x184EFAAE0")]
			public TType GHHIKGMBDAN()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4EFB5F0", Offset = "0x4EFA3F0", VA = "0x184EFB5F0")]
			public OJHLHJLEFPP<TType> KCENKMHJHKP(OJHLHJLEFPP<TType> CHAEOFDBIAH, OJHLHJLEFPP<TType> EBEGEKLHGJL)
			{
				return default(OJHLHJLEFPP<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4EFBA50", Offset = "0x4EFA850", VA = "0x184EFBA50")]
			public int KKHMBNNKJEH(TNode DFHOHFFNCIJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4EFB0A0", Offset = "0x4EF9EA0", VA = "0x184EFB0A0")]
			public int IOOCDIPBINP(TNode DFHOHFFNCIJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4EF9A80", Offset = "0x4EF8880", VA = "0x184EF9A80")]
			public TInput ADAJMMGMHNJ(TNode DFHOHFFNCIJ, int JJJJBEGKNIN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4EF9D90", Offset = "0x4EF8B90", VA = "0x184EF9D90")]
			public int BGPBHBAAFMC(TNode DFHOHFFNCIJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA170", Offset = "0x4EF8F70", VA = "0x184EFA170")]
			public TOutput CPOMBOJPAGC(TNode DFHOHFFNCIJ, int JJJJBEGKNIN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4EFB650", Offset = "0x4EFA450", VA = "0x184EFB650")]
			public IEnumerable<OPMJMPLEKME<TType>> KCJDKHEFKBE(TNode DFHOHFFNCIJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4EFAE80", Offset = "0x4EF9C80", VA = "0x184EFAE80")]
			public IEnumerable<FOPAPKKGHKA<TNode>> HOBGBCFJDJJ([In] TNode DFHOHFFNCIJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4EFAD70", Offset = "0x4EF9B70", VA = "0x184EFAD70")]
			public TType HMKKPJGDBHJ(TInput DANFKLEPBNF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4EFC040", Offset = "0x4EFAE40", VA = "0x184EFC040")]
			public int OLPFEFLJBKB(TInput DANFKLEPBNF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4EF9F30", Offset = "0x4EF8D30", VA = "0x184EF9F30")]
			public TOutput CFLBOLJPFBB(TInput DANFKLEPBNF, int JJJJBEGKNIN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA2D0", Offset = "0x4EF90D0", VA = "0x184EFA2D0")]
			public TNode EBMGMGCICHA(TInput DANFKLEPBNF)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA000", Offset = "0x4EF8E00", VA = "0x184EFA000")]
			public TType CHCCOJAMAML(TOutput LCAAPKFEJGM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA9D0", Offset = "0x4EF97D0", VA = "0x184EFA9D0")]
			public int FPMOJCMDLKO(TOutput LCAAPKFEJGM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA510", Offset = "0x4EF9310", VA = "0x184EFA510")]
			public TInput EDEKIHMDGCK(TOutput LCAAPKFEJGM, int JJJJBEGKNIN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA860", Offset = "0x4EF9660", VA = "0x184EFA860")]
			public TNode FENNBDLNOKC(TOutput LCAAPKFEJGM)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4EF9860", Offset = "0x4EF8660", VA = "0x184EF9860")]
			public bool ACDPLFKKFKO(TType ADGMECOLKNH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4EFC310", Offset = "0x4EFB110", VA = "0x184EFC310")]
			public TType PMPBPIJCKMD(TType ADGMECOLKNH, IEnumerable<TType> DKGKBMHILLH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4EFBD80", Offset = "0x4EFAB80", VA = "0x184EFBD80")]
			public void MCAEADOBGPC(TType ADGMECOLKNH, Action<TType> FCAMEFLNKFJ, Action<TType> OKEGCGMALHG, Action<TType> FHKDLKDFNBP, Action<TType> CNAHJHMPGAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4EFC220", Offset = "0x4EFB020", VA = "0x184EFC220")]
			public TType PHDLLJIOIEK(TType ADGMECOLKNH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4EFBD40", Offset = "0x4EFAB40", VA = "0x184EFBD40")]
			public string LGJKCMMAIME(TType ADGMECOLKNH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4EFBFB0", Offset = "0x4EFADB0", VA = "0x184EFBFB0")]
			public TTerm OFGAFBKOJMA()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4EFB000", Offset = "0x4EF9E00", VA = "0x184EFB000")]
			public TTerm IMPPCFEKIFO(TTerm JGOGDIOAPAL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4EFBAE0", Offset = "0x4EFA8E0", VA = "0x184EFBAE0")]
			public TTerm KKNHACCNGLP(TTerm ODAFCJJIICF, TTerm AMOBAKBDGHA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4EFB2F0", Offset = "0x4EFA0F0", VA = "0x184EFB2F0")]
			public void JJIOBBPNLKL(TTerm CHAEOFDBIAH, TTerm EBEGEKLHGJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4EF9C70", Offset = "0x4EF8A70", VA = "0x184EF9C70")]
			public bool APHNEBKBFGM(TOutputTerm JGOGDIOAPAL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4EF9AD0", Offset = "0x4EF88D0", VA = "0x184EF9AD0")]
			public bool AJFIKNMJFCO(TOutputTerm JGOGDIOAPAL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4EFAC50", Offset = "0x4EF9A50", VA = "0x184EFAC50")]
			public TTerm GJHKFNHPHOC(TOutputTerm HFOONHAMELE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4EFB8C0", Offset = "0x4EFA6C0", VA = "0x184EFB8C0")]
			public TOutputTerm KIBHCCJFGLD(TOutputTerm JGOGDIOAPAL)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4EFC100", Offset = "0x4EFAF00", VA = "0x184EFC100")]
			public TOutputTerm ONPLIEFAPFN(TOutputTerm JGOGDIOAPAL)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4EFACA0", Offset = "0x4EF9AA0", VA = "0x184EFACA0")]
			public TTerm HKENJDCCLIH(TOutputSubstitution FCEMJPOBMAA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA120", Offset = "0x4EF8F20", VA = "0x184EFA120")]
			public TOutputTerm CHJGLMBONLP(TOutputSubstitution FCEMJPOBMAA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4EFB820", Offset = "0x4EFA620", VA = "0x184EFB820")]
			public TOutputTerm KEKGGEBMFIH(TTerm JGOGDIOAPAL)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class DFKKCCEBPIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public FDBCBDDBDAJ arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public DFKKCCEBPIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4538FE0", Offset = "0x4537DE0", VA = "0x184538FE0")]
			internal int CGAGMANPOMO(FDBCBDDBDAJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4538E20", Offset = "0x4537C20", VA = "0x184538E20")]
			internal TInput BCDMDKDFKBM(FDBCBDDBDAJ arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4538F40", Offset = "0x4537D40", VA = "0x184538F40")]
			internal int BGFBFCAONAF(FDBCBDDBDAJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4539150", Offset = "0x4537F50", VA = "0x184539150")]
			internal TOutput JGJKPEDBELD(FDBCBDDBDAJ arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ENFIBONFCBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public FDBCBDDBDAJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, LHEAJFCOAGM<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<LHEAJFCOAGM<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public ENFIBONFCBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4A78920", Offset = "0x4A77720", VA = "0x184A78920")]
			internal (string, TTerm) FDBDAAANJII(OPMJMPLEKME<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DLEKBGCJNJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public FDBCBDDBDAJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public DLEKBGCJNJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4576220", Offset = "0x4575020", VA = "0x184576220")]
			internal void NPKDOLLLFDI(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4575BB0", Offset = "0x45749B0", VA = "0x184575BB0")]
			internal void IFIFBHAOLDB(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x45759F0", Offset = "0x45747F0", VA = "0x1845759F0")]
			internal void DDBIAGPDGOF(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4575FA0", Offset = "0x4574DA0", VA = "0x184575FA0")]
			internal void NOJCFGLJBKI(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DOCFEGBODPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FDBCBDDBDAJ arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public DOCFEGBODPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x45B48F0", Offset = "0x45B36F0", VA = "0x1845B48F0")]
			internal TTerm MCBJGECFIAC(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67E0400", Offset = "0x67DF200", VA = "0x1867E0400")]
		private static AGDMIFDFONN EJDEDBAGCIO([CallerMemberName] string PFLDDMDPCBI = "")
		{
			return default(AGDMIFDFONN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67D7680", Offset = "0x67D6480", VA = "0x1867D7680")]
		public static Dictionary<TNode, List<OPMJMPLEKME<TType>>> ALIKCEEMKIN(TRoot MMENCBNBOBJ, TDeps OPJFEEDOIEH, TGraph CPOICOGAHOC, IEnumerable<TNode> CCNCEPNOMOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67E6DC0", Offset = "0x67E5BC0", VA = "0x1867E6DC0")]
		private static (Dictionary<TTerm, LHEAJFCOAGM<TNode>>, List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>>) LPNJIFPLIDO(IEnumerable<TNode> CCNCEPNOMOE, FDBCBDDBDAJ EIENELGOLAB)
		{
			return default((Dictionary<TTerm, LHEAJFCOAGM<TNode>>, List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67E8BD0", Offset = "0x67E79D0", VA = "0x1867E8BD0")]
		private static void OLLBEEIODFN(TNode DFHOHFFNCIJ, Dictionary<TInput, TTerm> MJMBGAMDADG, Dictionary<TOutput, TTerm> GLIOLNHOBII, Dictionary<TTerm, LHEAJFCOAGM<TNode>> BJDAOFOOJDK, Dictionary<LHEAJFCOAGM<TNode>, TTerm> IGFMNLNAIGI, List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> BJANIFPOPON, Stack<TNode> EGAPJPPLICP, List<FOPAPKKGHKA<TNode>> DHJGFKLHFOF, FDBCBDDBDAJ EIENELGOLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67D6750", Offset = "0x67D5550", VA = "0x1867D6750")]
		private static Dictionary<string, TTerm> AGODIMHPDPG(TNode DFHOHFFNCIJ, Dictionary<TTerm, LHEAJFCOAGM<TNode>> BJDAOFOOJDK, Dictionary<LHEAJFCOAGM<TNode>, TTerm> FENMGECJEGL, List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> BJANIFPOPON, FDBCBDDBDAJ EIENELGOLAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9420", Offset = "0x3EB8220", VA = "0x183EB9420")]
		private static (TPort, TTerm)[] HNJJHPIKNAJ<TPort>(TNode DFHOHFFNCIJ, Func<FDBCBDDBDAJ, TNode, int> AMELOJAECNF, Func<FDBCBDDBDAJ, TNode, int, TPort> EGENKKIMIHK, Func<FDBCBDDBDAJ, TPort, TType> PKADNBNGAJD, Dictionary<TPort, TTerm> POEIMKFFGCE, FDBCBDDBDAJ EIENELGOLAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67D88A0", Offset = "0x67D76A0", VA = "0x1867D88A0")]
		private static (TTerm, TTerm) BFGFHIMNFEE((TOutput Output, TTerm Id)[] GJKFFKIPDNC, List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> BJANIFPOPON, Dictionary<string, TTerm> FENMGECJEGL, Stack<TNode> EGAPJPPLICP, FDBCBDDBDAJ EIENELGOLAB)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67DA200", Offset = "0x67D9000", VA = "0x1867DA200")]
		private static void CODPEMAIFFH((TInput PortKey, TTerm Id)[] JGNNGLCMHPC, TTerm NKEMHBDJJGG, TTerm CMFFEMBKCJP, List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> BJANIFPOPON, Dictionary<TOutput, TTerm> GLIOLNHOBII, Dictionary<string, TTerm> FENMGECJEGL, Stack<TNode> EGAPJPPLICP, FDBCBDDBDAJ EIENELGOLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67DFF00", Offset = "0x67DED00", VA = "0x1867DFF00")]
		private static TTerm ECILBILKHJA(TInput DANFKLEPBNF, List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> BJANIFPOPON, Dictionary<TOutput, TTerm> GLIOLNHOBII, Stack<TNode> EGAPJPPLICP, FDBCBDDBDAJ EIENELGOLAB)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x67E3630", Offset = "0x67E2430", VA = "0x1867E3630")]
		private static TTerm HNBPCJACLFH([In] TType ADGMECOLKNH, IOKind HMDPEKHOHLP, List<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> BJANIFPOPON, IReadOnlyDictionary<string, TTerm> FENMGECJEGL, FDBCBDDBDAJ EIENELGOLAB)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67E1090", Offset = "0x67DFE90", VA = "0x1867E1090")]
		private static Dictionary<TNode, List<OPMJMPLEKME<TType>>> EMENOBKFNJG(TOutputSubstitution[] INDLLODLBDK, Dictionary<TTerm, LHEAJFCOAGM<TNode>> BJDAOFOOJDK, IEnumerable<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> BJANIFPOPON, FDBCBDDBDAJ EIENELGOLAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x67E7E80", Offset = "0x67E6C80", VA = "0x1867E7E80")]
		private static Dictionary<TNode, List<OPMJMPLEKME<TType>>> MNNJOOCPDIA(Dictionary<TTerm, LHEAJFCOAGM<TNode>> BJDAOFOOJDK, FDBCBDDBDAJ EIENELGOLAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x67E5000", Offset = "0x67E3E00", VA = "0x1867E5000")]
		private static void KKFFHEPBFBK([In] TNode DFHOHFFNCIJ, Stack<TNode> EGAPJPPLICP, List<FOPAPKKGHKA<TNode>> DHJGFKLHFOF, FDBCBDDBDAJ EIENELGOLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67E2810", Offset = "0x67E1610", VA = "0x1867E2810")]
		private static void HFCAHEMAMLK(Dictionary<LHEAJFCOAGM<TNode>, TTerm> FENMGECJEGL, List<FOPAPKKGHKA<TNode>> DHJGFKLHFOF, FDBCBDDBDAJ EIENELGOLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x67DD610", Offset = "0x67DC410", VA = "0x1867DD610")]
		private static Dictionary<TTerm, TType> DEOHHFEGBOD(Dictionary<TTerm, TOutputSubstitution> INDLLODLBDK, IEnumerable<KeyValuePair<TTerm, OJHLHJLEFPP<TType>>> BJANIFPOPON, FDBCBDDBDAJ EIENELGOLAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x67E3BF0", Offset = "0x67E29F0", VA = "0x1867E3BF0")]
		private static KJAHANGMDME<TType> IKCELJPEPIG(TOutputTerm ADGMECOLKNH, Dictionary<TTerm, TType> BJANIFPOPON, Dictionary<TTerm, TType> FAJIBAIPGCN, FDBCBDDBDAJ EIENELGOLAB)
		{
			return default(KJAHANGMDME<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x67E7D00", Offset = "0x67E6B00", VA = "0x1867E7D00")]
		private static TOutputTerm MILKNCNJHBM(TOutputTerm AEEFAPDCNGA, FDBCBDDBDAJ EIENELGOLAB)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3DA5C30", Offset = "0x3DA4A30", VA = "0x183DA5C30")]
	public static Dictionary<TNode, List<OPMJMPLEKME<TType>>> ALIKCEEMKIN<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::BLCLIBAMJLL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DBBEADIHLKO, TRoot MMENCBNBOBJ, TGraph CPOICOGAHOC, IEnumerable<TNode> CCNCEPNOMOE) where TDeps : global::MPBCPNMBOAN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OPMJMPLEKME<TType> : IEquatable<OPMJMPLEKME<TType>>, EDENICGIGJP<OPMJMPLEKME<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string LBDOKALIJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType JKBLCFPJAAI;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5985E10", Offset = "0x5984C10", VA = "0x185985E10")]
	internal OPMJMPLEKME(string PFLDDMDPCBI, [In] TType ONEAGHEJIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5B2EDD0", Offset = "0x5B2DBD0", VA = "0x185B2EDD0")]
	public bool MHIAFJJKEOB([In] OPMJMPLEKME<TType> FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5B2ED80", Offset = "0x5B2DB80", VA = "0x185B2ED80", Slot = "4")]
	public bool Equals(OPMJMPLEKME<TType> FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4A579D0", Offset = "0x4A567D0", VA = "0x184A579D0", Slot = "0")]
	public override bool Equals(object FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5689750", Offset = "0x5688550", VA = "0x185689750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5B2EEA0", Offset = "0x5B2DCA0", VA = "0x185B2EEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5B2ED30", Offset = "0x5B2DB30", VA = "0x185B2ED30", Slot = "5")]
	private bool BGCIGJILLEM([In] OPMJMPLEKME<TType> FGAEAFBDBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BBIFJOLPOMH
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C7B0", Offset = "0x3A9B5B0", VA = "0x183A9C7B0")]
	public static OPMJMPLEKME<TType> ELDPFIHNJDG<TType>(string PFLDDMDPCBI, TType ONEAGHEJIPO)
	{
		return default(OPMJMPLEKME<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C7E0", Offset = "0x3A9B5E0", VA = "0x183A9C7E0")]
	public static (string, TType) JJNAPGGLFJI<TType>([In] this OPMJMPLEKME<TType> DBBEADIHLKO)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LHEAJFCOAGM<TNode> : IEquatable<LHEAJFCOAGM<TNode>>, EDENICGIGJP<LHEAJFCOAGM<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode CFOFFGMCOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string LBDOKALIJED;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1942DD0", Offset = "0x1941BD0", VA = "0x181942DD0")]
	internal LHEAJFCOAGM(TNode DFHOHFFNCIJ, string PFLDDMDPCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5689820", Offset = "0x5688620", VA = "0x185689820")]
	public bool MHIAFJJKEOB([In] LHEAJFCOAGM<TNode> FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5689700", Offset = "0x5688500", VA = "0x185689700", Slot = "4")]
	public bool Equals(LHEAJFCOAGM<TNode> FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4A579D0", Offset = "0x4A567D0", VA = "0x184A579D0", Slot = "0")]
	public override bool Equals(object FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x56897B0", Offset = "0x56885B0", VA = "0x1856897B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5689AA0", Offset = "0x56888A0", VA = "0x185689AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x56899C0", Offset = "0x56887C0", VA = "0x1856899C0", Slot = "5")]
	private bool PHNJIOIJJAP([In] LHEAJFCOAGM<TNode> FGAEAFBDBPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MDIEPJGLMLK
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3DBACA0", Offset = "0x3DB9AA0", VA = "0x183DBACA0")]
	public static LHEAJFCOAGM<TNode> ELDPFIHNJDG<TNode>(TNode DFHOHFFNCIJ, string PFLDDMDPCBI)
	{
		return default(LHEAJFCOAGM<TNode>);
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
