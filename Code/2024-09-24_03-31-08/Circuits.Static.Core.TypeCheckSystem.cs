using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct BHMMGHNFFEF<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType GPKIFFDGPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind LPNMKJLLABP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F740", Offset = "0x1E3E140", VA = "0x181E3F740")]
	internal BHMMGHNFFEF(TType AOGCIMANLIJ, IOKind CHKEMMNJKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x50C0340", Offset = "0x50BED40", VA = "0x1850C0340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LFNILKFBDLK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BB70", Offset = "0x2E1A570", VA = "0x182E1BB70")]
	public static BHMMGHNFFEF<TType> OOAFHJGKFEK<TType>(TType AOGCIMANLIJ, IOKind CHKEMMNJKFI)
	{
		return default(BHMMGHNFFEF<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BAC0", Offset = "0x2E1A4C0", VA = "0x182E1BAC0")]
	public static (TType, IOKind) DKOFJDBLENN<TType>([In] this BHMMGHNFFEF<TType> NKCEKILMAAM)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E1BB00", Offset = "0x2E1A500", VA = "0x182E1BB00")]
	public static void GJGCCCKLLFN<TType>([In] this BHMMGHNFFEF<TType> NKCEKILMAAM, [Out] TType AOGCIMANLIJ, [Out] IOKind CHKEMMNJKFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct GKJAKPMMHGG<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LFFCADAJHBM<TNode> ACHGJBIFHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LFFCADAJHBM<TNode> DNEILOLEHPG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3EDDF40", Offset = "0x3EDC940", VA = "0x183EDDF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EKANADJNHMH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEA80", Offset = "0x2BCD480", VA = "0x182BCEA80")]
	public static (LFFCADAJHBM<TNode>, LFFCADAJHBM<TNode>) DKOFJDBLENN<TNode>([In] this GKJAKPMMHGG<TNode> NKCEKILMAAM)
	{
		return default((LFFCADAJHBM<TNode>, LFFCADAJHBM<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEB20", Offset = "0x2BCD520", VA = "0x182BCEB20")]
	public static void GJGCCCKLLFN<TNode>([In] this GKJAKPMMHGG<TNode> NKCEKILMAAM, [Out] LFFCADAJHBM<TNode> OMCEEKENOBB, [Out] LFFCADAJHBM<TNode> MOBHGIAPGGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LOPGBIOPBMA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PHAMLIOLJCC JACHBDMMOLH(TRoot BAFHJDFHJHD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType KENCINAAKPD(TRoot BAFHJDFHJHD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BHMMGHNFFEF<TType> KJCNHHILKNH(TRoot BAFHJDFHJHD, [In] BHMMGHNFFEF<TType> MFLKJAHENBP, [In] BHMMGHNFFEF<TType> PLHCHKLJLJD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CDIJEGLKCIG(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TNode AOOGCKADIHP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DFBADIKGBAP(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TNode AOOGCKADIHP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput EKIKBHDELCC(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TNode AOOGCKADIHP, int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JPDBAGDHCCO(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TNode AOOGCKADIHP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput AECOAHGLBKL(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TNode AOOGCKADIHP, int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<PFHGEENILMG<TType>> EONNCANPFCM(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TNode AOOGCKADIHP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<GKJAKPMMHGG<TNode>> JNFCEOECCPA(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TNode AOOGCKADIHP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType LNHJJMCBMMK(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TInput AHBBCFFJCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int MAIIDHMHIAB(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TInput AHBBCFFJCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput JANIPBFLPHP(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TInput AHBBCFFJCCJ, int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode DINOCLOFFDD(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TInput AHBBCFFJCCJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType FGOLNPFMLMK(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TOutput GECGGIHOOIJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int IJEEFCHCAPK(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TOutput GECGGIHOOIJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput BCOMIHPEINA(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TOutput GECGGIHOOIJ, int ENMILGHAHOM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode BDNFCCKNDAM(TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, TOutput GECGGIHOOIJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool INNLLJNKNBD(TRoot BAFHJDFHJHD, TType AOGCIMANLIJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType IAGIBBKOELJ(TRoot BAFHJDFHJHD, TType AOGCIMANLIJ, IEnumerable<TType> CLHBKEBPKDG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ALNAMLMABCH(TRoot BAFHJDFHJHD, TType AOGCIMANLIJ, Action<TType> CGFPJPLHCCL, Action<TType> AHGECGMCDML, Action<TType> DAIENGONOCG, Action<TType> NNOPCOKGBBD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType PDLHJGPNBIO(TRoot BAFHJDFHJHD, TType AOGCIMANLIJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string CAMGABHFFLK(TRoot BAFHJDFHJHD, TType AOGCIMANLIJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification HIJBAGFPHKA(TRoot BAFHJDFHJHD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CDOLGFBAJII<TOutputSubstitution[], PKNKGFKCKHA> IIKHMIAKMLD(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm BDKGPLHOFGN(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm GFGJKAHIFFD(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TTerm AOKAAHALICC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm HNPNAJJFLOP(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TTerm CFBNLICAJEE, TTerm HPOPBHJPBJH);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JMDCGNBPBJD(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TTerm MFLKJAHENBP, TTerm PLHCHKLJLJD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool APDOPCNPHEF(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TOutputTerm HBJJCPANLNE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool FOKJHJHEIFH(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TOutputTerm HBJJCPANLNE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm AKHGIDGFFJL(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TOutputTerm HBJJCPANLNE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm ANBOANAHFHH(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TOutputTerm HBJJCPANLNE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm MHNIPGPCIAC(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TOutputTerm HBJJCPANLNE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm OKMKMDHOCDP(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TOutputSubstitution NABFKLKLCGF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm NAELBHJOPDA(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TOutputSubstitution NABFKLKLCGF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm PMADGECFNCI(TRoot BAFHJDFHJHD, TUnification CIFHNJADOID, TTerm AOKAAHALICC);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IOMBIDBOPHH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::LOPGBIOPBMA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0")]
	public static global::IOMBIDBOPHH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> OOAFHJGKFEK()
	{
		return default(global::IOMBIDBOPHH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BABKLBOHDPG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class MKIFINHOCIO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::LOPGBIOPBMA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class BDJIPFGMHKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot CHMOOKFGBDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps IAOFHDDJJCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification LPFPPKMIOML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph ONIFGHGEGEB;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public PHAMLIOLJCC PEBJMDDAGAI
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x50A1070", Offset = "0x509FA70", VA = "0x1850A1070")]
				get
				{
					return default(PHAMLIOLJCC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x50A3820", Offset = "0x50A2220", VA = "0x1850A3820")]
			private BDJIPFGMHKN(TRoot BAFHJDFHJHD, TDeps HBFCALFCDLO, TUnification ACPCLNKAAHB, TGraph OAHHBCOOBCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x50A3520", Offset = "0x50A1F20", VA = "0x1850A3520")]
			public static BDJIPFGMHKN OOAFHJGKFEK(TRoot BAFHJDFHJHD, TDeps HBFCALFCDLO, TUnification ACPCLNKAAHB, TGraph OAHHBCOOBCN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x50A2C70", Offset = "0x50A1670", VA = "0x1850A2C70")]
			public TType KENCINAAKPD()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x50A2F10", Offset = "0x50A1910", VA = "0x1850A2F10")]
			public BHMMGHNFFEF<TType> KJCNHHILKNH(BHMMGHNFFEF<TType> MFLKJAHENBP, BHMMGHNFFEF<TType> PLHCHKLJLJD)
			{
				return default(BHMMGHNFFEF<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x50A1950", Offset = "0x50A0350", VA = "0x1850A1950")]
			public int CDIJEGLKCIG(TNode AOOGCKADIHP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x50A19D0", Offset = "0x50A03D0", VA = "0x1850A19D0")]
			public int DFBADIKGBAP(TNode AOOGCKADIHP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x50A1C40", Offset = "0x50A0640", VA = "0x1850A1C40")]
			public TInput EKIKBHDELCC(TNode AOOGCKADIHP, int ENMILGHAHOM)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x50A2B00", Offset = "0x50A1500", VA = "0x1850A2B00")]
			public int JPDBAGDHCCO(TNode AOOGCKADIHP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x50A0F30", Offset = "0x509F930", VA = "0x1850A0F30")]
			public TOutput AECOAHGLBKL(TNode AOOGCKADIHP, int ENMILGHAHOM)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x50A1D20", Offset = "0x50A0720", VA = "0x1850A1D20")]
			public IEnumerable<PFHGEENILMG<TType>> EONNCANPFCM(TNode AOOGCKADIHP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x50A2A40", Offset = "0x50A1440", VA = "0x1850A2A40")]
			public IEnumerable<GKJAKPMMHGG<TNode>> JNFCEOECCPA([In] TNode AOOGCKADIHP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x50A2FC0", Offset = "0x50A19C0", VA = "0x1850A2FC0")]
			public TType LNHJJMCBMMK(TInput AHBBCFFJCCJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x50A2D20", Offset = "0x50A1720", VA = "0x1850A2D20")]
			public int KGMNGJGKBPG(TInput AHBBCFFJCCJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x50A2740", Offset = "0x50A1140", VA = "0x1850A2740")]
			public TOutput JANIPBFLPHP(TInput AHBBCFFJCCJ, int ENMILGHAHOM)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x50A1BA0", Offset = "0x50A05A0", VA = "0x1850A1BA0")]
			public TNode DINOCLOFFDD(TInput AHBBCFFJCCJ)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x50A1EF0", Offset = "0x50A08F0", VA = "0x1850A1EF0")]
			public TType FGOLNPFMLMK(TOutput GECGGIHOOIJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x50A1F30", Offset = "0x50A0930", VA = "0x1850A1F30")]
			public int FKKADIADEGI(TOutput GECGGIHOOIJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x50A14A0", Offset = "0x509FEA0", VA = "0x1850A14A0")]
			public TInput BCOMIHPEINA(TOutput GECGGIHOOIJ, int ENMILGHAHOM)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x50A1670", Offset = "0x50A0070", VA = "0x1850A1670")]
			public TNode BDNFCCKNDAM(TOutput GECGGIHOOIJ)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x50A2670", Offset = "0x50A1070", VA = "0x1850A2670")]
			public bool INNLLJNKNBD(TType AOGCIMANLIJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x50A2560", Offset = "0x50A0F60", VA = "0x1850A2560")]
			public TType IAGIBBKOELJ(TType AOGCIMANLIJ, IEnumerable<TType> CLHBKEBPKDG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x50A10A0", Offset = "0x509FAA0", VA = "0x1850A10A0")]
			public void ALNAMLMABCH(TType AOGCIMANLIJ, Action<TType> CGFPJPLHCCL, Action<TType> AHGECGMCDML, Action<TType> DAIENGONOCG, Action<TType> NNOPCOKGBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x50A36E0", Offset = "0x50A20E0", VA = "0x1850A36E0")]
			public TType PDLHJGPNBIO(TType AOGCIMANLIJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x50A1780", Offset = "0x50A0180", VA = "0x1850A1780")]
			public string CAMGABHFFLK(TType AOGCIMANLIJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x50A15F0", Offset = "0x509FFF0", VA = "0x1850A15F0")]
			public TTerm BDKGPLHOFGN()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x50A2200", Offset = "0x50A0C00", VA = "0x1850A2200")]
			public TTerm GFGJKAHIFFD(TTerm AOKAAHALICC)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x50A2490", Offset = "0x50A0E90", VA = "0x1850A2490")]
			public TTerm HNPNAJJFLOP(TTerm CFBNLICAJEE, TTerm HPOPBHJPBJH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x50A2810", Offset = "0x50A1210", VA = "0x1850A2810")]
			public void JMDCGNBPBJD(TTerm MFLKJAHENBP, TTerm PLHCHKLJLJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x50A2100", Offset = "0x50A0B00", VA = "0x1850A2100")]
			public bool FOKJHJHEIFH(TOutputTerm AOKAAHALICC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x50A1360", Offset = "0x509FD60", VA = "0x1850A1360")]
			public bool APDOPCNPHEF(TOutputTerm AOKAAHALICC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x50A2240", Offset = "0x50A0C40", VA = "0x1850A2240")]
			public TTerm GLIAANOJBDK(TOutputTerm HBJJCPANLNE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x50A1220", Offset = "0x509FC20", VA = "0x1850A1220")]
			public TOutputTerm ANBOANAHFHH(TOutputTerm AOKAAHALICC)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x50A3100", Offset = "0x50A1B00", VA = "0x1850A3100")]
			public TOutputTerm MHNIPGPCIAC(TOutputTerm AOKAAHALICC)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x50A3240", Offset = "0x50A1C40", VA = "0x1850A3240")]
			public TTerm OKMKMDHOCDP(TOutputSubstitution BCHJOBEAMMF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x50A3180", Offset = "0x50A1B80", VA = "0x1850A3180")]
			public TOutputTerm NAELBHJOPDA(TOutputSubstitution BCHJOBEAMMF)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x50A3720", Offset = "0x50A2120", VA = "0x1850A3720")]
			public TOutputTerm PMADGECFNCI(TTerm AOKAAHALICC)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class COJONCOLLGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public BDJIPFGMHKN arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public COJONCOLLGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x57A9CA0", Offset = "0x57A86A0", VA = "0x1857A9CA0")]
			internal int NLMILGOLMDK(BDJIPFGMHKN arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x57A9C40", Offset = "0x57A8640", VA = "0x1857A9C40")]
			internal TInput MBMJMGOCBKM(BDJIPFGMHKN arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x57A9AF0", Offset = "0x57A84F0", VA = "0x1857A9AF0")]
			internal int CJPLLIPDGFA(BDJIPFGMHKN arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x57A9D00", Offset = "0x57A8700", VA = "0x1857A9D00")]
			internal TOutput OKBLLGOJNCP(BDJIPFGMHKN arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EHLIMFBJMKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public BDJIPFGMHKN arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, LFFCADAJHBM<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<LFFCADAJHBM<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public EHLIMFBJMKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3A183D0", Offset = "0x3A16DD0", VA = "0x183A183D0")]
			internal (string, TTerm) JJNLCMGFGEB(PFHGEENILMG<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class PJKFLCBFFDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public BDJIPFGMHKN arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public PJKFLCBFFDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x49B6720", Offset = "0x49B5120", VA = "0x1849B6720")]
			internal void MNBKAKIFOBJ(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x49B5E90", Offset = "0x49B4890", VA = "0x1849B5E90")]
			internal void GGCDBHHIHBK(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x49B6310", Offset = "0x49B4D10", VA = "0x1849B6310")]
			internal void KJLJFDPBGJD(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x49B5D00", Offset = "0x49B4700", VA = "0x1849B5D00")]
			internal void BDPOJKANAFL(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ENOEKDDNDLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public BDJIPFGMHKN arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public ENOEKDDNDLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3A4B200", Offset = "0x3A49C00", VA = "0x183A4B200")]
			internal TTerm IEFKCMKIDFI(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x47053C0", Offset = "0x4703DC0", VA = "0x1847053C0")]
		private static ONOAOHKIBFG HNIPPHBLEOD([CallerMemberName] string DDDMPLCOGIM = "")
		{
			return default(ONOAOHKIBFG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4702840", Offset = "0x4701240", VA = "0x184702840")]
		public static Dictionary<TNode, List<PFHGEENILMG<TType>>> FPAABCEKENM(TRoot BAFHJDFHJHD, TDeps HBFCALFCDLO, TGraph OAHHBCOOBCN, IEnumerable<TNode> LENPDFEAKCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4710C30", Offset = "0x470F630", VA = "0x184710C30")]
		private static (Dictionary<TTerm, LFFCADAJHBM<TNode>>, List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>>) PLEJGHBHLGD(IEnumerable<TNode> LENPDFEAKCN, BDJIPFGMHKN OKHFPGFAECB)
		{
			return default((Dictionary<TTerm, LFFCADAJHBM<TNode>>, List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46FFC50", Offset = "0x46FE650", VA = "0x1846FFC50")]
		private static void CKOAKFBOPDA(TNode AOOGCKADIHP, Dictionary<TInput, TTerm> AFPIIMDAIEB, Dictionary<TOutput, TTerm> DJKALNNEMGC, Dictionary<TTerm, LFFCADAJHBM<TNode>> JCCCBKNAJPB, Dictionary<LFFCADAJHBM<TNode>, TTerm> OAAHMINPJNN, List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> NEPLDKIDEJG, Stack<TNode> CMAFNECCOPK, List<GKJAKPMMHGG<TNode>> AKPFCEGJHLA, BDJIPFGMHKN OKHFPGFAECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4703E60", Offset = "0x4702860", VA = "0x184703E60")]
		private static Dictionary<string, TTerm> GKCCHKFIBOI(TNode AOOGCKADIHP, Dictionary<TTerm, LFFCADAJHBM<TNode>> JCCCBKNAJPB, Dictionary<LFFCADAJHBM<TNode>, TTerm> DEFAOGNDJEA, List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> NEPLDKIDEJG, BDJIPFGMHKN OKHFPGFAECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2CB48D0", Offset = "0x2CB32D0", VA = "0x182CB48D0")]
		private static (TPort, TTerm)[] LNLAALKPIAB<TPort>(TNode AOOGCKADIHP, Func<BDJIPFGMHKN, TNode, int> CGLNJHMKLEG, Func<BDJIPFGMHKN, TNode, int, TPort> EMCCOCCDMIF, Func<BDJIPFGMHKN, TPort, TType> MMJMDLBLNBF, Dictionary<TPort, TTerm> DMFOGPFIPOC, BDJIPFGMHKN OKHFPGFAECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4708150", Offset = "0x4706B50", VA = "0x184708150")]
		private static (TTerm, TTerm) JFAGHCIJJBP((TOutput Output, TTerm Id)[] HAOMFAELCOC, List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> NEPLDKIDEJG, Dictionary<string, TTerm> DEFAOGNDJEA, Stack<TNode> CMAFNECCOPK, BDJIPFGMHKN OKHFPGFAECB)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x470C870", Offset = "0x470B270", VA = "0x18470C870")]
		private static void MKLODBJMCBM((TInput PortKey, TTerm Id)[] BAEJABIFIKO, TTerm AENNIDBABCK, TTerm EHOAPFFGGMH, List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> NEPLDKIDEJG, Dictionary<TOutput, TTerm> DJKALNNEMGC, Dictionary<string, TTerm> DEFAOGNDJEA, Stack<TNode> CMAFNECCOPK, BDJIPFGMHKN OKHFPGFAECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x47059F0", Offset = "0x47043F0", VA = "0x1847059F0")]
		private static TTerm IGGFPPICMAH(TInput AHBBCFFJCCJ, List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> NEPLDKIDEJG, Dictionary<TOutput, TTerm> DJKALNNEMGC, Stack<TNode> CMAFNECCOPK, BDJIPFGMHKN OKHFPGFAECB)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4708F40", Offset = "0x4707940", VA = "0x184708F40")]
		private static TTerm LILJJDMBCNH([In] TType AOGCIMANLIJ, IOKind CHKEMMNJKFI, List<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> NEPLDKIDEJG, IReadOnlyDictionary<string, TTerm> DEFAOGNDJEA, BDJIPFGMHKN OKHFPGFAECB)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4709550", Offset = "0x4707F50", VA = "0x184709550")]
		private static Dictionary<TNode, List<PFHGEENILMG<TType>>> LLFMKJJAJMM(TOutputSubstitution[] KBCDHFEIKLB, Dictionary<TTerm, LFFCADAJHBM<TNode>> JCCCBKNAJPB, IEnumerable<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> NEPLDKIDEJG, BDJIPFGMHKN OKHFPGFAECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x470ECE0", Offset = "0x470D6E0", VA = "0x18470ECE0")]
		private static Dictionary<TNode, List<PFHGEENILMG<TType>>> MOFLGHIJPLO(Dictionary<TTerm, LFFCADAJHBM<TNode>> JCCCBKNAJPB, BDJIPFGMHKN OKHFPGFAECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x47127B0", Offset = "0x47111B0", VA = "0x1847127B0")]
		private static void PNELNCFNOMA([In] TNode AOOGCKADIHP, Stack<TNode> CMAFNECCOPK, List<GKJAKPMMHGG<TNode>> AKPFCEGJHLA, BDJIPFGMHKN OKHFPGFAECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x470FBA0", Offset = "0x470E5A0", VA = "0x18470FBA0")]
		private static void ODBJKMKIGFM(Dictionary<LFFCADAJHBM<TNode>, TTerm> DEFAOGNDJEA, List<GKJAKPMMHGG<TNode>> AKPFCEGJHLA, BDJIPFGMHKN OKHFPGFAECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x46FDC70", Offset = "0x46FC670", VA = "0x1846FDC70")]
		private static Dictionary<TTerm, TType> CHCMAHJNBKA(Dictionary<TTerm, TOutputSubstitution> KBCDHFEIKLB, IEnumerable<KeyValuePair<TTerm, BHMMGHNFFEF<TType>>> NEPLDKIDEJG, BDJIPFGMHKN OKHFPGFAECB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4704A60", Offset = "0x4703460", VA = "0x184704A60")]
		private static CPOGLEEFNCN<TType> GOPDBOPDGKC(TOutputTerm AOGCIMANLIJ, Dictionary<TTerm, TType> NEPLDKIDEJG, Dictionary<TTerm, TType> CJEEOBCMPEP, BDJIPFGMHKN OKHFPGFAECB)
		{
			return default(CPOGLEEFNCN<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4702560", Offset = "0x4700F60", VA = "0x184702560")]
		private static TOutputTerm DBAPFCJDELN(TOutputTerm BDMLDEEJKGH, BDJIPFGMHKN OKHFPGFAECB)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC55A0", Offset = "0x2AC3FA0", VA = "0x182AC55A0")]
	public static Dictionary<TNode, List<PFHGEENILMG<TType>>> FPAABCEKENM<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::IOMBIDBOPHH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> NKCEKILMAAM, TRoot BAFHJDFHJHD, TGraph OAHHBCOOBCN, IEnumerable<TNode> LENPDFEAKCN) where TDeps : global::LOPGBIOPBMA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct PFHGEENILMG<TType> : IEquatable<PFHGEENILMG<TType>>, DFOHKGGFAED<PFHGEENILMG<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string FMJDNGHFJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType MBPHHBCFNIF;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x49A6130", Offset = "0x49A4B30", VA = "0x1849A6130")]
	internal PFHGEENILMG(string DDDMPLCOGIM, [In] TType GAODFBJOCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x49A5FC0", Offset = "0x49A49C0", VA = "0x1849A5FC0")]
	public bool FNAPBPPPEKA([In] PFHGEENILMG<TType> CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x49A5F70", Offset = "0x49A4970", VA = "0x1849A5F70", Slot = "4")]
	public bool Equals(PFHGEENILMG<TType> CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4489EC0", Offset = "0x44888C0", VA = "0x184489EC0", Slot = "0")]
	public override bool Equals(object CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x21A64A0", Offset = "0x21A4EA0", VA = "0x1821A64A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x49A60F0", Offset = "0x49A4AF0", VA = "0x1849A60F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x49A60A0", Offset = "0x49A4AA0", VA = "0x1849A60A0", Slot = "5")]
	private bool JPJOOLOACDH([In] PFHGEENILMG<TType> CGCLEIBHLHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JHLHIOLEFHM
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCAE0", Offset = "0x2DBB4E0", VA = "0x182DBCAE0")]
	public static PFHGEENILMG<TType> OOAFHJGKFEK<TType>(string DDDMPLCOGIM, TType GAODFBJOCLO)
	{
		return default(PFHGEENILMG<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2DBCAA0", Offset = "0x2DBB4A0", VA = "0x182DBCAA0")]
	public static (string, TType) DKOFJDBLENN<TType>([In] this PFHGEENILMG<TType> NKCEKILMAAM)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LFFCADAJHBM<TNode> : IEquatable<LFFCADAJHBM<TNode>>, DFOHKGGFAED<LFFCADAJHBM<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode PJGLMOMMKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string FMJDNGHFJGI;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xFFE660", Offset = "0xFFD060", VA = "0x180FFE660")]
	internal LFFCADAJHBM(TNode AOOGCKADIHP, string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4489FA0", Offset = "0x44889A0", VA = "0x184489FA0")]
	public bool FNAPBPPPEKA([In] LFFCADAJHBM<TNode> CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4489F50", Offset = "0x4488950", VA = "0x184489F50", Slot = "4")]
	public bool Equals(LFFCADAJHBM<TNode> CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4489EC0", Offset = "0x44888C0", VA = "0x184489EC0", Slot = "0")]
	public override bool Equals(object CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x448A160", Offset = "0x4488B60", VA = "0x18448A160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x448A270", Offset = "0x4488C70", VA = "0x18448A270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x448A1D0", Offset = "0x4488BD0", VA = "0x18448A1D0", Slot = "5")]
	private bool HFOFKJDAEOE([In] LFFCADAJHBM<TNode> CGCLEIBHLHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AJNNBIKBMDM
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3444850", Offset = "0x3443250", VA = "0x183444850")]
	public static LFFCADAJHBM<TNode> OOAFHJGKFEK<TNode>(TNode AOOGCKADIHP, string DDDMPLCOGIM)
	{
		return default(LFFCADAJHBM<TNode>);
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
