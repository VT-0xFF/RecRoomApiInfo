using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct APHDIABLKMD<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType MKIIDBFDPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind DFFECCNPCFC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x920710", Offset = "0x91FB10", VA = "0x180920710")]
	internal APHDIABLKMD(TType LGJDMOCCBDP, IOKind KJIMPNLGKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x412D8E0", Offset = "0x412CCE0", VA = "0x18412D8E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DLKHGDGCOCE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C8C710", Offset = "0x2C8BB10", VA = "0x182C8C710")]
	public static APHDIABLKMD<TType> AALKPJMFIHM<TType>(TType LGJDMOCCBDP, IOKind KJIMPNLGKFF)
	{
		return default(APHDIABLKMD<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C8C7B0", Offset = "0x2C8BBB0", VA = "0x182C8C7B0")]
	public static (TType, IOKind) FDHKLOPEDJD<TType>([In] this APHDIABLKMD<TType> MBGHIKEGJAA)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C8C740", Offset = "0x2C8BB40", VA = "0x182C8C740")]
	public static void CPFOJCEKBFH<TType>([In] this APHDIABLKMD<TType> MBGHIKEGJAA, [Out] TType LGJDMOCCBDP, [Out] IOKind KJIMPNLGKFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct HHKOEKAGPEF<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DJOHGMLCMKI<TNode> DMHCBCAKNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DJOHGMLCMKI<TNode> JJCGKINOPJK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x408E120", Offset = "0x408D520", VA = "0x18408E120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IGFEBMDMJHG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E9EB20", Offset = "0x2E9DF20", VA = "0x182E9EB20")]
	public static (DJOHGMLCMKI<TNode>, DJOHGMLCMKI<TNode>) FDHKLOPEDJD<TNode>([In] this HHKOEKAGPEF<TNode> MBGHIKEGJAA)
	{
		return default((DJOHGMLCMKI<TNode>, DJOHGMLCMKI<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E9EA20", Offset = "0x2E9DE20", VA = "0x182E9EA20")]
	public static void CPFOJCEKBFH<TNode>([In] this HHKOEKAGPEF<TNode> MBGHIKEGJAA, [Out] DJOHGMLCMKI<TNode> EHOEECMJEAD, [Out] DJOHGMLCMKI<TNode> CPKKNGGFDGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HGNEILHNIDM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIMDGGMPEGE CANELMGFCMD(TRoot FINELPFBLOK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType NCLPHNALNFA(TRoot FINELPFBLOK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	APHDIABLKMD<TType> FKCCEFFHHJL(TRoot FINELPFBLOK, [In] APHDIABLKMD<TType> GIDMNJLJNOH, [In] APHDIABLKMD<TType> OONEKAPAHLL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LFICJLKFGHK(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TNode ABBPLCKDHFH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ECMJLPHDDDC(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TNode ABBPLCKDHFH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput JKGJGPMADLI(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TNode ABBPLCKDHFH, int AEAHMAMPNLO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EPAPMOIBGJL(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TNode ABBPLCKDHFH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput IIOBKDDILJN(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TNode ABBPLCKDHFH, int AEAHMAMPNLO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<MNPKPMEOENH<TType>> JHFOBFKFKIP(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TNode ABBPLCKDHFH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<HHKOEKAGPEF<TNode>> FENCGDAHCEE(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TNode ABBPLCKDHFH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType FHPNKNJDIDI(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TInput GJMNBMBONPJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int CCMFGPAEGHB(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TInput GJMNBMBONPJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput CFIAKHHNBCC(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TInput GJMNBMBONPJ, int AEAHMAMPNLO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode DLIENJINECC(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TInput GJMNBMBONPJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType AEJGBIFFIMP(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TOutput FNAMNFIPOGA);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int FJHMAMKODIK(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TOutput FNAMNFIPOGA);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput GHAHLKGIFLM(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TOutput FNAMNFIPOGA, int AEAHMAMPNLO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode JPJMALPHGJG(TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, TOutput FNAMNFIPOGA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CCLJLPLEFHB(TRoot FINELPFBLOK, TType LGJDMOCCBDP);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType PANCDMAMMEC(TRoot FINELPFBLOK, TType LGJDMOCCBDP, IEnumerable<TType> OKLIDGAJALL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NOEIILNDOOD(TRoot FINELPFBLOK, TType LGJDMOCCBDP, Action<TType> BJJOEELJMLL, Action<TType> CBOGKFEBHGO, Action<TType> MEBPEBANGKJ, Action<TType> EDJAHICFFDC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType PFLDLMOCKGL(TRoot FINELPFBLOK, TType LGJDMOCCBDP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string JMCHILNDLNC(TRoot FINELPFBLOK, TType LGJDMOCCBDP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification LJFFBLKKJMI(TRoot FINELPFBLOK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MLIDCCDLMIE<TOutputSubstitution[], IDBHBLPOJHF> PAHPFOABNHI(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm OEGJOIMHFOM(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm PGDAEPBIDPE(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TTerm FDMECACPMGG);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm KNEDFGIPIJD(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TTerm NCNPDGLPGME, TTerm CAPKHGDIEMA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JAGCBNDOLDG(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TTerm GIDMNJLJNOH, TTerm OONEKAPAHLL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool LFAKFFPCIHN(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TOutputTerm POGLLEDBAGP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool HMPHMPAHOAI(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TOutputTerm POGLLEDBAGP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm KIGHKOOMDBH(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TOutputTerm POGLLEDBAGP);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm IHNJHJPJFJD(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TOutputTerm POGLLEDBAGP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm OKDFFINLBDI(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TOutputTerm POGLLEDBAGP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm DBBEIBJCIAN(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TOutputSubstitution LFPJLIOLDMO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm CLDKBMFCICA(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TOutputSubstitution LFPJLIOLDMO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm CIGDMACNGNO(TRoot FINELPFBLOK, TUnification LDNEIDNEFMB, TTerm FDMECACPMGG);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct FKDJBAJGJEN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HGNEILHNIDM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0")]
	public static global::FKDJBAJGJEN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> AALKPJMFIHM()
	{
		return default(global::FKDJBAJGJEN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HHOIDICMDDA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class OGEODAJOLHE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HGNEILHNIDM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class HDFBPBAPBDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot FKDEHKMEOCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps BBMJIKJPAIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification MAENADHJPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph ELDMOCIIPGA;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public AIMDGGMPEGE FBBEEFJKGCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x407D650", Offset = "0x407CA50", VA = "0x18407D650")]
				get
				{
					return default(AIMDGGMPEGE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x407EE10", Offset = "0x407E210", VA = "0x18407EE10")]
			private HDFBPBAPBDD(TRoot FINELPFBLOK, TDeps ICFGLKCGHOG, TUnification KIHEFNGMNPF, TGraph GFHEHGHBDMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x407C390", Offset = "0x407B790", VA = "0x18407C390")]
			public static HDFBPBAPBDD AALKPJMFIHM(TRoot FINELPFBLOK, TDeps ICFGLKCGHOG, TUnification KIHEFNGMNPF, TGraph GFHEHGHBDMK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x407E550", Offset = "0x407D950", VA = "0x18407E550")]
			public TType NCLPHNALNFA()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x407D300", Offset = "0x407C700", VA = "0x18407D300")]
			public APHDIABLKMD<TType> FKCCEFFHHJL(APHDIABLKMD<TType> GIDMNJLJNOH, APHDIABLKMD<TType> OONEKAPAHLL)
			{
				return default(APHDIABLKMD<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x407E330", Offset = "0x407D730", VA = "0x18407E330")]
			public int LFICJLKFGHK(TNode ABBPLCKDHFH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x407CD50", Offset = "0x407C150", VA = "0x18407CD50")]
			public int ECMJLPHDDDC(TNode ABBPLCKDHFH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x407DD40", Offset = "0x407D140", VA = "0x18407DD40")]
			public TInput JKGJGPMADLI(TNode ABBPLCKDHFH, int AEAHMAMPNLO)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x407CEE0", Offset = "0x407C2E0", VA = "0x18407CEE0")]
			public int EPAPMOIBGJL(TNode ABBPLCKDHFH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x407D9C0", Offset = "0x407CDC0", VA = "0x18407D9C0")]
			public TOutput IIOBKDDILJN(TNode ABBPLCKDHFH, int AEAHMAMPNLO)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x407DC60", Offset = "0x407D060", VA = "0x18407DC60")]
			public IEnumerable<MNPKPMEOENH<TType>> JHFOBFKFKIP(TNode ABBPLCKDHFH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x407D0A0", Offset = "0x407C4A0", VA = "0x18407D0A0")]
			public IEnumerable<HHKOEKAGPEF<TNode>> FENCGDAHCEE([In] TNode ABBPLCKDHFH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x407D0E0", Offset = "0x407C4E0", VA = "0x18407D0E0")]
			public TType FHPNKNJDIDI(TInput GJMNBMBONPJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x407CEA0", Offset = "0x407C2A0", VA = "0x18407CEA0")]
			public int EOBPGFONHIH(TInput GJMNBMBONPJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x407C800", Offset = "0x407BC00", VA = "0x18407C800")]
			public TOutput CFIAKHHNBCC(TInput GJMNBMBONPJ, int AEAHMAMPNLO)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x407CBB0", Offset = "0x407BFB0", VA = "0x18407CBB0")]
			public TNode DLIENJINECC(TInput GJMNBMBONPJ)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x407C5B0", Offset = "0x407B9B0", VA = "0x18407C5B0")]
			public TType AEJGBIFFIMP(TOutput FNAMNFIPOGA)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x407EB30", Offset = "0x407DF30", VA = "0x18407EB30")]
			public int PCHJEAAFCLA(TOutput FNAMNFIPOGA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x407D4E0", Offset = "0x407C8E0", VA = "0x18407D4E0")]
			public TInput GHAHLKGIFLM(TOutput FNAMNFIPOGA, int AEAHMAMPNLO)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x407DFD0", Offset = "0x407D3D0", VA = "0x18407DFD0")]
			public TNode JPJMALPHGJG(TOutput FNAMNFIPOGA)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x407C6D0", Offset = "0x407BAD0", VA = "0x18407C6D0")]
			public bool CCLJLPLEFHB(TType LGJDMOCCBDP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x407EA20", Offset = "0x407DE20", VA = "0x18407EA20")]
			public TType PANCDMAMMEC(TType LGJDMOCCBDP, IEnumerable<TType> OKLIDGAJALL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x407E690", Offset = "0x407DA90", VA = "0x18407E690")]
			public void NOEIILNDOOD(TType LGJDMOCCBDP, Action<TType> BJJOEELJMLL, Action<TType> CBOGKFEBHGO, Action<TType> MEBPEBANGKJ, Action<TType> EDJAHICFFDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x407EC00", Offset = "0x407E000", VA = "0x18407EC00")]
			public TType PFLDLMOCKGL(TType LGJDMOCCBDP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x407DED0", Offset = "0x407D2D0", VA = "0x18407DED0")]
			public string JMCHILNDLNC(TType LGJDMOCCBDP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x407E880", Offset = "0x407DC80", VA = "0x18407E880")]
			public TTerm OEGJOIMHFOM()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x407EDC0", Offset = "0x407E1C0", VA = "0x18407EDC0")]
			public TTerm PGDAEPBIDPE(TTerm FDMECACPMGG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x407E1C0", Offset = "0x407D5C0", VA = "0x18407E1C0")]
			public TTerm KNEDFGIPIJD(TTerm NCNPDGLPGME, TTerm CAPKHGDIEMA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x407DA60", Offset = "0x407CE60", VA = "0x18407DA60")]
			public void JAGCBNDOLDG(TTerm GIDMNJLJNOH, TTerm OONEKAPAHLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x407D530", Offset = "0x407C930", VA = "0x18407D530")]
			public bool HMPHMPAHOAI(TOutputTerm FDMECACPMGG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x407E210", Offset = "0x407D610", VA = "0x18407E210")]
			public bool LFAKFFPCIHN(TOutputTerm FDMECACPMGG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x407E480", Offset = "0x407D880", VA = "0x18407E480")]
			public TTerm LOFKICHBMLF(TOutputTerm POGLLEDBAGP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x407D810", Offset = "0x407CC10", VA = "0x18407D810")]
			public TOutputTerm IHNJHJPJFJD(TOutputTerm FDMECACPMGG)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x407E950", Offset = "0x407DD50", VA = "0x18407E950")]
			public TOutputTerm OKDFFINLBDI(TOutputTerm FDMECACPMGG)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x407CB60", Offset = "0x407BF60", VA = "0x18407CB60")]
			public TTerm DBBEIBJCIAN(TOutputSubstitution KOJIMCLBNND)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x407CA10", Offset = "0x407BE10", VA = "0x18407CA10")]
			public TOutputTerm CLDKBMFCICA(TOutputSubstitution KOJIMCLBNND)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x407C9C0", Offset = "0x407BDC0", VA = "0x18407C9C0")]
			public TOutputTerm CIGDMACNGNO(TTerm FDMECACPMGG)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class MNMPHFFKILB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public HDFBPBAPBDD arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public MNMPHFFKILB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x484D430", Offset = "0x484C830", VA = "0x18484D430")]
			internal int PNCCOBCCHFI(HDFBPBAPBDD arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x484D130", Offset = "0x484C530", VA = "0x18484D130")]
			internal TInput KAHKLMMFBBM(HDFBPBAPBDD arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x484D070", Offset = "0x484C470", VA = "0x18484D070")]
			internal int FGPGEJIACOL(HDFBPBAPBDD arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x484D370", Offset = "0x484C770", VA = "0x18484D370")]
			internal TOutput MHLAGCKOLFF(HDFBPBAPBDD arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NIMPMMDJFCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public HDFBPBAPBDD arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, DJOHGMLCMKI<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<DJOHGMLCMKI<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, APHDIABLKMD<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public NIMPMMDJFCK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x48C0270", Offset = "0x48BF670", VA = "0x1848C0270")]
			internal (string, TTerm) IPCDBLHLJLB(MNPKPMEOENH<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class OAACFLHHGPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public HDFBPBAPBDD arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, APHDIABLKMD<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public OAACFLHHGPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4A3D190", Offset = "0x4A3C590", VA = "0x184A3D190")]
			internal void NFMICCGLMCN(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4A3C6C0", Offset = "0x4A3BAC0", VA = "0x184A3C6C0")]
			internal void LGJEKKGNKCN(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4A3D450", Offset = "0x4A3C850", VA = "0x184A3D450")]
			internal void OCDPPCGMMLM(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4A3CB90", Offset = "0x4A3BF90", VA = "0x184A3CB90")]
			internal void LOCKFFCOPEG(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NAEIODCNGGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HDFBPBAPBDD arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public NAEIODCNGGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3B71770", Offset = "0x3B70B70", VA = "0x183B71770")]
			internal TTerm DAGLGHJAFAP(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4A68B60", Offset = "0x4A67F60", VA = "0x184A68B60")]
		private static KJMNDBGEIFP BOCBHFCDOMM([CallerMemberName] string ADANIHOIEKJ = "")
		{
			return default(KJMNDBGEIFP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4A70B90", Offset = "0x4A6FF90", VA = "0x184A70B90")]
		public static Dictionary<TNode, List<MNPKPMEOENH<TType>>> GHODFMIMFLK(TRoot FINELPFBLOK, TDeps ICFGLKCGHOG, TGraph GFHEHGHBDMK, IEnumerable<TNode> PDLDNFFFGIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4A72530", Offset = "0x4A71930", VA = "0x184A72530")]
		private static (Dictionary<TTerm, DJOHGMLCMKI<TNode>>, List<KeyValuePair<TTerm, APHDIABLKMD<TType>>>) INEIPFAEPJC(IEnumerable<TNode> PDLDNFFFGIF, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return default((Dictionary<TTerm, DJOHGMLCMKI<TNode>>, List<KeyValuePair<TTerm, APHDIABLKMD<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4A76430", Offset = "0x4A75830", VA = "0x184A76430")]
		private static void LKDFOMOIFLM(TNode ABBPLCKDHFH, Dictionary<TInput, TTerm> CPIDHPHAEFL, Dictionary<TOutput, TTerm> NJCIGDAMJDH, Dictionary<TTerm, DJOHGMLCMKI<TNode>> KCGMGDNPPHC, Dictionary<DJOHGMLCMKI<TNode>, TTerm> NOJAEIKHCFA, List<KeyValuePair<TTerm, APHDIABLKMD<TType>>> DJFDOBLLHBJ, Stack<TNode> GGHILPCHAAF, List<HHKOEKAGPEF<TNode>> FNLDEMIFOBL, HDFBPBAPBDD MGBFBAKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4A68F40", Offset = "0x4A68340", VA = "0x184A68F40")]
		private static Dictionary<string, TTerm> COLNOCDIBEF(TNode ABBPLCKDHFH, Dictionary<TTerm, DJOHGMLCMKI<TNode>> KCGMGDNPPHC, Dictionary<DJOHGMLCMKI<TNode>, TTerm> HEAJANBLAPH, List<KeyValuePair<TTerm, APHDIABLKMD<TType>>> DJFDOBLLHBJ, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x31BB190", Offset = "0x31BA590", VA = "0x1831BB190")]
		private static (TPort, TTerm)[] AKMPBANPJIH<TPort>(TNode ABBPLCKDHFH, Func<HDFBPBAPBDD, TNode, int> DCIDJJGLEJD, Func<HDFBPBAPBDD, TNode, int, TPort> GIIJKEAPFMI, Func<HDFBPBAPBDD, TPort, TType> OAGPFPAGCOB, Dictionary<TPort, TTerm> LOLINIAHJHP, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4A78040", Offset = "0x4A77440", VA = "0x184A78040")]
		private static (TTerm, TTerm) NAHOCKMPMAE((TOutput Output, TTerm Id)[] OECOKGMEMPF, List<KeyValuePair<TTerm, APHDIABLKMD<TType>>> DJFDOBLLHBJ, Dictionary<string, TTerm> HEAJANBLAPH, Stack<TNode> GGHILPCHAAF, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4A7ABA0", Offset = "0x4A79FA0", VA = "0x184A7ABA0")]
		private static void ONEGHJCIDLI((TInput PortKey, TTerm Id)[] IINLMHKCFCG, TTerm EHCJDFNAANJ, TTerm NPAEHDLMBKK, List<KeyValuePair<TTerm, APHDIABLKMD<TType>>> DJFDOBLLHBJ, Dictionary<TOutput, TTerm> NJCIGDAMJDH, Dictionary<string, TTerm> HEAJANBLAPH, Stack<TNode> GGHILPCHAAF, HDFBPBAPBDD MGBFBAKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4A6F1E0", Offset = "0x4A6E5E0", VA = "0x184A6F1E0")]
		private static TTerm GGBEBEKOIII(TInput GJMNBMBONPJ, List<KeyValuePair<TTerm, APHDIABLKMD<TType>>> DJFDOBLLHBJ, Dictionary<TOutput, TTerm> NJCIGDAMJDH, Stack<TNode> GGHILPCHAAF, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4A69290", Offset = "0x4A68690", VA = "0x184A69290")]
		private static TTerm DELIMHADALN([In] TType LGJDMOCCBDP, IOKind KJIMPNLGKFF, List<KeyValuePair<TTerm, APHDIABLKMD<TType>>> DJFDOBLLHBJ, IReadOnlyDictionary<string, TTerm> HEAJANBLAPH, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4A66150", Offset = "0x4A65550", VA = "0x184A66150")]
		private static Dictionary<TNode, List<MNPKPMEOENH<TType>>> AGBOEPOAMOH(TOutputSubstitution[] DFFKLKPDACF, Dictionary<TTerm, DJOHGMLCMKI<TNode>> KCGMGDNPPHC, IEnumerable<KeyValuePair<TTerm, APHDIABLKMD<TType>>> DJFDOBLLHBJ, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4A6E260", Offset = "0x4A6D660", VA = "0x184A6E260")]
		private static Dictionary<TNode, List<MNPKPMEOENH<TType>>> FNDKFHKIAJG(Dictionary<TTerm, DJOHGMLCMKI<TNode>> KCGMGDNPPHC, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4A720A0", Offset = "0x4A714A0", VA = "0x184A720A0")]
		private static void HHCNICDCGCE([In] TNode ABBPLCKDHFH, Stack<TNode> GGHILPCHAAF, List<HHKOEKAGPEF<TNode>> FNLDEMIFOBL, HDFBPBAPBDD MGBFBAKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4A685F0", Offset = "0x4A679F0", VA = "0x184A685F0")]
		private static void BJOOGBECLBK(Dictionary<DJOHGMLCMKI<TNode>, TTerm> HEAJANBLAPH, List<HHKOEKAGPEF<TNode>> FNLDEMIFOBL, HDFBPBAPBDD MGBFBAKCCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4A698F0", Offset = "0x4A68CF0", VA = "0x184A698F0")]
		private static Dictionary<TTerm, TType> ECCLNNIEMBD(Dictionary<TTerm, TOutputSubstitution> DFFKLKPDACF, IEnumerable<KeyValuePair<TTerm, APHDIABLKMD<TType>>> DJFDOBLLHBJ, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4A6CAF0", Offset = "0x4A6BEF0", VA = "0x184A6CAF0")]
		private static JEJCONLJHLG<TType> FILNHAHMAFM(TOutputTerm LGJDMOCCBDP, Dictionary<TTerm, TType> DJFDOBLLHBJ, Dictionary<TTerm, TType> HMKOCECLFBO, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return default(JEJCONLJHLG<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4A6FDF0", Offset = "0x4A6F1F0", VA = "0x184A6FDF0")]
		private static TOutputTerm GHAHIGHFALM(TOutputTerm LJEPEIILCNA, HDFBPBAPBDD MGBFBAKCCAP)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2E87BD0", Offset = "0x2E86FD0", VA = "0x182E87BD0")]
	public static Dictionary<TNode, List<MNPKPMEOENH<TType>>> GHODFMIMFLK<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::FKDJBAJGJEN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> MBGHIKEGJAA, TRoot FINELPFBLOK, TGraph GFHEHGHBDMK, IEnumerable<TNode> PDLDNFFFGIF) where TDeps : global::HGNEILHNIDM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct MNPKPMEOENH<TType> : IEquatable<MNPKPMEOENH<TType>>, CLKINMENLCJ<MNPKPMEOENH<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string BKJCNMKILGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType HCFEBDLGGJE;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x481CC70", Offset = "0x481C070", VA = "0x18481CC70")]
	internal MNPKPMEOENH(string ADANIHOIEKJ, [In] TType OJFNEKOBBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x484D490", Offset = "0x484C890", VA = "0x18484D490")]
	public bool CJGJEJGHIMG([In] MNPKPMEOENH<TType> OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x484D600", Offset = "0x484CA00", VA = "0x18484D600", Slot = "4")]
	public bool Equals(MNPKPMEOENH<TType> OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x484D570", Offset = "0x484C970", VA = "0x18484D570", Slot = "0")]
	public override bool Equals(object OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2291EA0", Offset = "0x22912A0", VA = "0x182291EA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x484D6A0", Offset = "0x484CAA0", VA = "0x18484D6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x484D650", Offset = "0x484CA50", VA = "0x18484D650", Slot = "5")]
	private bool KFCFEAFPNFL([In] MNPKPMEOENH<TType> OCKBFCIKBEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DPEAJIDMIFO
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F470", Offset = "0x2C8E870", VA = "0x182C8F470")]
	public static MNPKPMEOENH<TType> AALKPJMFIHM<TType>(string ADANIHOIEKJ, TType OJFNEKOBBKA)
	{
		return default(MNPKPMEOENH<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F4A0", Offset = "0x2C8E8A0", VA = "0x182C8F4A0")]
	public static (string, TType) FDHKLOPEDJD<TType>([In] this MNPKPMEOENH<TType> MBGHIKEGJAA)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DJOHGMLCMKI<TNode> : IEquatable<DJOHGMLCMKI<TNode>>, CLKINMENLCJ<DJOHGMLCMKI<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode DAGDPOOPLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string BKJCNMKILGO;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x10CA180", Offset = "0x10C9580", VA = "0x1810CA180")]
	internal DJOHGMLCMKI(TNode ABBPLCKDHFH, string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5C34820", Offset = "0x5C33C20", VA = "0x185C34820")]
	public bool CJGJEJGHIMG([In] DJOHGMLCMKI<TNode> OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5C34950", Offset = "0x5C33D50", VA = "0x185C34950", Slot = "4")]
	public bool Equals(DJOHGMLCMKI<TNode> OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x484D570", Offset = "0x484C970", VA = "0x18484D570", Slot = "0")]
	public override bool Equals(object OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5C349A0", Offset = "0x5C33DA0", VA = "0x185C349A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5C34AB0", Offset = "0x5C33EB0", VA = "0x185C34AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5C34A60", Offset = "0x5C33E60", VA = "0x185C34A60", Slot = "5")]
	private bool OAAHABHGFGA([In] DJOHGMLCMKI<TNode> OCKBFCIKBEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KEGOLDFKNFO
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2EFA230", Offset = "0x2EF9630", VA = "0x182EFA230")]
	public static DJOHGMLCMKI<TNode> AALKPJMFIHM<TNode>(TNode ABBPLCKDHFH, string ADANIHOIEKJ)
	{
		return default(DJOHGMLCMKI<TNode>);
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
