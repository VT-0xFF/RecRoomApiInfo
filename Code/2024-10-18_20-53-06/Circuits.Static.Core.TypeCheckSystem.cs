using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct AAIFJJCAAIB<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType NKDPEDOOFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind JIINHGMJFLA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C2B0", Offset = "0x1F6B6B0", VA = "0x181F6C2B0")]
	internal AAIFJJCAAIB(TType DPOLEDLIAMP, IOKind HGPHOMFLKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4620", Offset = "0x3FC3A20", VA = "0x183FC4620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EBMJLHLHHBO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CBA780", Offset = "0x2CB9B80", VA = "0x182CBA780")]
	public static AAIFJJCAAIB<TType> AHLALEPNKFA<TType>(TType DPOLEDLIAMP, IOKind HGPHOMFLKDB)
	{
		return default(AAIFJJCAAIB<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CBA820", Offset = "0x2CB9C20", VA = "0x182CBA820")]
	public static (TType, IOKind) NBLDAPGCLHM<TType>([In] this AAIFJJCAAIB<TType> MCPMOAEEEOJ)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CBA7B0", Offset = "0x2CB9BB0", VA = "0x182CBA7B0")]
	public static void KGNAIFFBBCO<TType>([In] this AAIFJJCAAIB<TType> MCPMOAEEEOJ, [Out] TType DPOLEDLIAMP, [Out] IOKind HGPHOMFLKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KFPJCNJJHPF<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ADFLPMFBJHC<TNode> PDEDMFKHFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ADFLPMFBJHC<TNode> HLOCIMGGBNC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4502FE0", Offset = "0x45023E0", VA = "0x184502FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FAIDNNMMOMB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A670", Offset = "0x2E29A70", VA = "0x182E2A670")]
	public static (ADFLPMFBJHC<TNode>, ADFLPMFBJHC<TNode>) NBLDAPGCLHM<TNode>([In] this KFPJCNJJHPF<TNode> MCPMOAEEEOJ)
	{
		return default((ADFLPMFBJHC<TNode>, ADFLPMFBJHC<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E2A570", Offset = "0x2E29970", VA = "0x182E2A570")]
	public static void KGNAIFFBBCO<TNode>([In] this KFPJCNJJHPF<TNode> MCPMOAEEEOJ, [Out] ADFLPMFBJHC<TNode> OPJKGPJPNJJ, [Out] ADFLPMFBJHC<TNode> EANFIEEELEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CFIHCAHJAFH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GGEKMJMDANN AOOIGBMGDGI(TRoot KCFGMPGPMFA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType CJDAMANIIAD(TRoot KCFGMPGPMFA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAIFJJCAAIB<TType> JNJLGHPDCJE(TRoot KCFGMPGPMFA, [In] AAIFJJCAAIB<TType> JKMLNPBBJIG, [In] AAIFJJCAAIB<TType> JDJGFJGMEAK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LABBDLOMBEJ(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TNode EKHCANKHNFM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NNPNODNDMIM(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TNode EKHCANKHNFM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput OGHDPNLJNMA(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TNode EKHCANKHNFM, int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IGMMGLFMEPC(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TNode EKHCANKHNFM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput NHGKHEFGHEA(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TNode EKHCANKHNFM, int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CPPIKLDEGAN<TType>> ILDOKIMGHLE(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TNode EKHCANKHNFM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KFPJCNJJHPF<TNode>> LBAPHBBIKOI(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TNode EKHCANKHNFM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType IHLPLMNCOHK(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TInput EBJHHBADCKF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int LHJMJCKIOMM(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TInput EBJHHBADCKF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput CGLFIGFIOHA(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TInput EBJHHBADCKF, int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode DLKKDPICHNL(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TInput EBJHHBADCKF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType EJBEILOKJMH(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TOutput FFCICFEFFCP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int NFFMDEMMJOA(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TOutput FFCICFEFFCP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput DDPHNKPGIFO(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TOutput FFCICFEFFCP, int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode DIAOHEFHMNM(TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, TOutput FFCICFEFFCP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IJMCLDPAEJL(TRoot KCFGMPGPMFA, TType DPOLEDLIAMP);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType NPKKIAHHJHE(TRoot KCFGMPGPMFA, TType DPOLEDLIAMP, IEnumerable<TType> BMECIIKMPIJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OFGKAPEHOMG(TRoot KCFGMPGPMFA, TType DPOLEDLIAMP, Action<TType> EIOPHNKPPMM, Action<TType> FGMBGCEMLFJ, Action<TType> NDDJPPHJGMG, Action<TType> LMFABEOIAPK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType EBGKPBNNHJA(TRoot KCFGMPGPMFA, TType DPOLEDLIAMP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string BHFADHPFGKE(TRoot KCFGMPGPMFA, TType DPOLEDLIAMP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification JBNNHIOAIOL(TRoot KCFGMPGPMFA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	LMFFMMPMNDB<TOutputSubstitution[], CIIOJBGFHGE> BECEGFIBALH(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm DCHLLENFFEM(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm HKLJIHJJHOJ(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TTerm PDHDHNMCNMD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm BGBCIPBGNMH(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TTerm AEMACDNHKLC, TTerm KNKLOPPILKI);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OMGDEOEFCPL(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TTerm JKMLNPBBJIG, TTerm JDJGFJGMEAK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool AKPEHAJAOEN(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TOutputTerm EKAOHDLKAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool HGDPGLMNOCJ(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TOutputTerm EKAOHDLKAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm HMOIPNMKAEM(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TOutputTerm EKAOHDLKAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm JCAFCKCHCGF(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TOutputTerm EKAOHDLKAFJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm KCGFIABNFDM(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TOutputTerm EKAOHDLKAFJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm ELDEHHJNKFJ(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TOutputSubstitution FGAMABBPCAE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm IMJJMKCAKFE(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TOutputSubstitution FGAMABBPCAE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm DMKIJJFHMEE(TRoot KCFGMPGPMFA, TUnification NMCAMFNGJFK, TTerm PDHDHNMCNMD);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ABHFAKKMCBJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CFIHCAHJAFH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0")]
	public static global::ABHFAKKMCBJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> AHLALEPNKFA()
	{
		return default(global::ABHFAKKMCBJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CJDOPJCDLLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class LKJCHMMODPE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CFIHCAHJAFH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class JKBDPDEMFHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot PAGLAEHKACJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps NFMMGNFMIOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification NHEFEEFHELA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph OBFIAMPHJIG;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public GGEKMJMDANN EJFLACGEBNJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4424B30", Offset = "0x4423F30", VA = "0x184424B30")]
				get
				{
					return default(GGEKMJMDANN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4426030", Offset = "0x4425430", VA = "0x184426030")]
			private JKBDPDEMFHI(TRoot KCFGMPGPMFA, TDeps CLOGBAKPPIL, TUnification FKHGBFKNBEL, TGraph CGOGNBPFMJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4423540", Offset = "0x4422940", VA = "0x184423540")]
			public static JKBDPDEMFHI AHLALEPNKFA(TRoot KCFGMPGPMFA, TDeps CLOGBAKPPIL, TUnification FKHGBFKNBEL, TGraph CGOGNBPFMJH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4423CE0", Offset = "0x44230E0", VA = "0x184423CE0")]
			public TType CJDAMANIIAD()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4425410", Offset = "0x4424810", VA = "0x184425410")]
			public AAIFJJCAAIB<TType> JNJLGHPDCJE(AAIFJJCAAIB<TType> JKMLNPBBJIG, AAIFJJCAAIB<TType> JDJGFJGMEAK)
			{
				return default(AAIFJJCAAIB<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4425650", Offset = "0x4424A50", VA = "0x184425650")]
			public int LABBDLOMBEJ(TNode EKHCANKHNFM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4425A80", Offset = "0x4424E80", VA = "0x184425A80")]
			public int NNPNODNDMIM(TNode EKHCANKHNFM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4425DB0", Offset = "0x44251B0", VA = "0x184425DB0")]
			public TInput OGHDPNLJNMA(TNode EKHCANKHNFM, int HAJICDLBEKC)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4424BB0", Offset = "0x4423FB0", VA = "0x184424BB0")]
			public int IGMMGLFMEPC(TNode EKHCANKHNFM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x44258A0", Offset = "0x4424CA0", VA = "0x1844258A0")]
			public TOutput NHGKHEFGHEA(TNode EKHCANKHNFM, int HAJICDLBEKC)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4424E90", Offset = "0x4424290", VA = "0x184424E90")]
			public IEnumerable<CPPIKLDEGAN<TType>> ILDOKIMGHLE(TNode EKHCANKHNFM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x44256D0", Offset = "0x4424AD0", VA = "0x1844256D0")]
			public IEnumerable<KFPJCNJJHPF<TNode>> LBAPHBBIKOI([In] TNode EKHCANKHNFM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4424C70", Offset = "0x4424070", VA = "0x184424C70")]
			public TType IHLPLMNCOHK(TInput EBJHHBADCKF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4425860", Offset = "0x4424C60", VA = "0x184425860")]
			public int LLBIDHKJBCG(TInput EBJHHBADCKF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4423B70", Offset = "0x4422F70", VA = "0x184423B70")]
			public TOutput CGLFIGFIOHA(TInput EBJHHBADCKF, int HAJICDLBEKC)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4424200", Offset = "0x4423600", VA = "0x184424200")]
			public TNode DLKKDPICHNL(TInput EBJHHBADCKF)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4424650", Offset = "0x4423A50", VA = "0x184424650")]
			public TType EJBEILOKJMH(TOutput FFCICFEFFCP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4425180", Offset = "0x4424580", VA = "0x184425180")]
			public int JDLGIBGFEEJ(TOutput FFCICFEFFCP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4424040", Offset = "0x4423440", VA = "0x184424040")]
			public TInput DDPHNKPGIFO(TOutput FFCICFEFFCP, int HAJICDLBEKC)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4424110", Offset = "0x4423510", VA = "0x184424110")]
			public TNode DIAOHEFHMNM(TOutput FFCICFEFFCP)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4424D80", Offset = "0x4424180", VA = "0x184424D80")]
			public bool IJMCLDPAEJL(TType DPOLEDLIAMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4425B80", Offset = "0x4424F80", VA = "0x184425B80")]
			public TType NPKKIAHHJHE(TType DPOLEDLIAMP, IEnumerable<TType> BMECIIKMPIJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4425CE0", Offset = "0x44250E0", VA = "0x184425CE0")]
			public void OFGKAPEHOMG(TType DPOLEDLIAMP, Action<TType> EIOPHNKPPMM, Action<TType> FGMBGCEMLFJ, Action<TType> NDDJPPHJGMG, Action<TType> LMFABEOIAPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x44243F0", Offset = "0x44237F0", VA = "0x1844243F0")]
			public TType EBGKPBNNHJA(TType DPOLEDLIAMP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4423A20", Offset = "0x4422E20", VA = "0x184423A20")]
			public string BHFADHPFGKE(TType DPOLEDLIAMP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4423E30", Offset = "0x4423230", VA = "0x184423E30")]
			public TTerm DCHLLENFFEM()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4424910", Offset = "0x4423D10", VA = "0x184424910")]
			public TTerm HKLJIHJJHOJ(TTerm PDHDHNMCNMD)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x44239D0", Offset = "0x4422DD0", VA = "0x1844239D0")]
			public TTerm BGBCIPBGNMH(TTerm AEMACDNHKLC, TTerm KNKLOPPILKI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4425EA0", Offset = "0x44252A0", VA = "0x184425EA0")]
			public void OMGDEOEFCPL(TTerm JKMLNPBBJIG, TTerm JDJGFJGMEAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4424870", Offset = "0x4423C70", VA = "0x184424870")]
			public bool HGDPGLMNOCJ(TOutputTerm PDHDHNMCNMD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4423760", Offset = "0x4422B60", VA = "0x184423760")]
			public bool AKPEHAJAOEN(TOutputTerm PDHDHNMCNMD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4424560", Offset = "0x4423960", VA = "0x184424560")]
			public TTerm EHOLGFNGGAC(TOutputTerm EKAOHDLKAFJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x44250B0", Offset = "0x44244B0", VA = "0x1844250B0")]
			public TOutputTerm JCAFCKCHCGF(TOutputTerm PDHDHNMCNMD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x44254C0", Offset = "0x44248C0", VA = "0x1844254C0")]
			public TOutputTerm KCGFIABNFDM(TOutputTerm PDHDHNMCNMD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4424720", Offset = "0x4423B20", VA = "0x184424720")]
			public TTerm ELDEHHJNKFJ(TOutputSubstitution HFDBLFNJBCF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4424F90", Offset = "0x4424390", VA = "0x184424F90")]
			public TOutputTerm IMJJMKCAKFE(TOutputSubstitution HFDBLFNJBCF)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4424320", Offset = "0x4423720", VA = "0x184424320")]
			public TOutputTerm DMKIJJFHMEE(TTerm PDHDHNMCNMD)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BCDJOECFLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public JKBDPDEMFHI arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public BCDJOECFLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5228F40", Offset = "0x5228340", VA = "0x185228F40")]
			internal int MHDHJCNOEOK(JKBDPDEMFHI arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5228D90", Offset = "0x5228190", VA = "0x185228D90")]
			internal TInput JGFOLGKPHIO(JKBDPDEMFHI arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5228C40", Offset = "0x5228040", VA = "0x185228C40")]
			internal int DFGGGEIAGKM(JKBDPDEMFHI arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5228E70", Offset = "0x5228270", VA = "0x185228E70")]
			internal TOutput KLJOHGEOGAL(JKBDPDEMFHI arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LMAMCANCOHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public JKBDPDEMFHI arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, ADFLPMFBJHC<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<ADFLPMFBJHC<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public LMAMCANCOHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x45D8A20", Offset = "0x45D7E20", VA = "0x1845D8A20")]
			internal (string, TTerm) OMKMNMALFJB(CPPIKLDEGAN<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JAIIMBOAGGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JKBDPDEMFHI arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public JAIIMBOAGGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x440A7D0", Offset = "0x4409BD0", VA = "0x18440A7D0")]
			internal void ECEHGKJAIGH(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4409ED0", Offset = "0x44092D0", VA = "0x184409ED0")]
			internal void CDKFIMLGCFI(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x440A390", Offset = "0x4409790", VA = "0x18440A390")]
			internal void CJPLMNNFEHD(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x440AD50", Offset = "0x440A150", VA = "0x18440AD50")]
			internal void FCFDGFFLMMG(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CMJGLLAHBGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JKBDPDEMFHI arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public CMJGLLAHBGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3B4B0A0", Offset = "0x3B4A4A0", VA = "0x183B4B0A0")]
			internal TTerm MHHIPADIIFB(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x45C26B0", Offset = "0x45C1AB0", VA = "0x1845C26B0")]
		private static NKKDGOJHDPD HJFIGAOJMIL([CallerMemberName] string DDDHPCNFCEK = "")
		{
			return default(NKKDGOJHDPD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x45BF000", Offset = "0x45BE400", VA = "0x1845BF000")]
		public static Dictionary<TNode, List<CPPIKLDEGAN<TType>>> EAGBLJDENLK(TRoot KCFGMPGPMFA, TDeps CLOGBAKPPIL, TGraph CGOGNBPFMJH, IEnumerable<TNode> JGPMDEDPADE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x45C47D0", Offset = "0x45C3BD0", VA = "0x1845C47D0")]
		private static (Dictionary<TTerm, ADFLPMFBJHC<TNode>>, List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>>) KLAMKNMGGEK(IEnumerable<TNode> JGPMDEDPADE, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return default((Dictionary<TTerm, ADFLPMFBJHC<TNode>>, List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x45C1030", Offset = "0x45C0430", VA = "0x1845C1030")]
		private static void GGNAGGDLOHG(TNode EKHCANKHNFM, Dictionary<TInput, TTerm> JJLABOKMDPF, Dictionary<TOutput, TTerm> NGLPKLFHPDM, Dictionary<TTerm, ADFLPMFBJHC<TNode>> IABEHMGEGJO, Dictionary<ADFLPMFBJHC<TNode>, TTerm> LOKLALHCKFN, List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> LEFFLGDLENN, Stack<TNode> IOOCFMKJFEO, List<KFPJCNJJHPF<TNode>> FPANGGBBFCL, JKBDPDEMFHI NDJFIKMCNAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x45BD5D0", Offset = "0x45BC9D0", VA = "0x1845BD5D0")]
		private static Dictionary<string, TTerm> AICNIIDIPIA(TNode EKHCANKHNFM, Dictionary<TTerm, ADFLPMFBJHC<TNode>> IABEHMGEGJO, Dictionary<ADFLPMFBJHC<TNode>, TTerm> ALKBKLDGDKI, List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> LEFFLGDLENN, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2DA2660", Offset = "0x2DA1A60", VA = "0x182DA2660")]
		private static (TPort, TTerm)[] KJOMLABDNEO<TPort>(TNode EKHCANKHNFM, Func<JKBDPDEMFHI, TNode, int> NLKIJHDICEE, Func<JKBDPDEMFHI, TNode, int, TPort> HNPPEDKNEAN, Func<JKBDPDEMFHI, TPort, TType> FJHMOMGJOGC, Dictionary<TPort, TTerm> EKLNOFBIIPF, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x45C26F0", Offset = "0x45C1AF0", VA = "0x1845C26F0")]
		private static (TTerm, TTerm) HNPCCIPGLOE((TOutput Output, TTerm Id)[] DJGLHBGKMGE, List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> LEFFLGDLENN, Dictionary<string, TTerm> ALKBKLDGDKI, Stack<TNode> IOOCFMKJFEO, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x45C0240", Offset = "0x45BF640", VA = "0x1845C0240")]
		private static void FJGLMHJFEKO((TInput PortKey, TTerm Id)[] HADCNPPEHJP, TTerm KEAJHDKKBAE, TTerm OBANIFBIMFI, List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> LEFFLGDLENN, Dictionary<TOutput, TTerm> NGLPKLFHPDM, Dictionary<string, TTerm> ALKBKLDGDKI, Stack<TNode> IOOCFMKJFEO, JKBDPDEMFHI NDJFIKMCNAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x45BFC70", Offset = "0x45BF070", VA = "0x1845BFC70")]
		private static TTerm EEFIIDCJOGI(TInput EBJHHBADCKF, List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> LEFFLGDLENN, Dictionary<TOutput, TTerm> NGLPKLFHPDM, Stack<TNode> IOOCFMKJFEO, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x45BF610", Offset = "0x45BEA10", VA = "0x1845BF610")]
		private static TTerm EBNODCELCBC([In] TType DPOLEDLIAMP, IOKind HGPHOMFLKDB, List<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> LEFFLGDLENN, IReadOnlyDictionary<string, TTerm> ALKBKLDGDKI, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x45BDDB0", Offset = "0x45BD1B0", VA = "0x1845BDDB0")]
		private static Dictionary<TNode, List<CPPIKLDEGAN<TType>>> CFMAGMEOKNA(TOutputSubstitution[] IENHNJPEALF, Dictionary<TTerm, ADFLPMFBJHC<TNode>> IABEHMGEGJO, IEnumerable<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> LEFFLGDLENN, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x45C53F0", Offset = "0x45C47F0", VA = "0x1845C53F0")]
		private static Dictionary<TNode, List<CPPIKLDEGAN<TType>>> NPKNOFLCFJB(Dictionary<TTerm, ADFLPMFBJHC<TNode>> IABEHMGEGJO, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x45BD920", Offset = "0x45BCD20", VA = "0x1845BD920")]
		private static void ALPMCEJKFIJ([In] TNode EKHCANKHNFM, Stack<TNode> IOOCFMKJFEO, List<KFPJCNJJHPF<TNode>> FPANGGBBFCL, JKBDPDEMFHI NDJFIKMCNAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x45BEAD0", Offset = "0x45BDED0", VA = "0x1845BEAD0")]
		private static void DFCMPLKMMIL(Dictionary<ADFLPMFBJHC<TNode>, TTerm> ALKBKLDGDKI, List<KFPJCNJJHPF<TNode>> FPANGGBBFCL, JKBDPDEMFHI NDJFIKMCNAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x45C3720", Offset = "0x45C2B20", VA = "0x1845C3720")]
		private static Dictionary<TTerm, TType> JCCHJICICPN(Dictionary<TTerm, TOutputSubstitution> IENHNJPEALF, IEnumerable<KeyValuePair<TTerm, AAIFJJCAAIB<TType>>> LEFFLGDLENN, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x45C1D60", Offset = "0x45C1160", VA = "0x1845C1D60")]
		private static EAJEDGEMDCE<TType> HJDNABALJDE(TOutputTerm DPOLEDLIAMP, Dictionary<TTerm, TType> LEFFLGDLENN, Dictionary<TTerm, TType> OJLLLCEEJNF, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return default(EAJEDGEMDCE<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x45C35A0", Offset = "0x45C29A0", VA = "0x1845C35A0")]
		private static TOutputTerm IBLPJOHNHBI(TOutputTerm PEMNNLCPEBH, JKBDPDEMFHI NDJFIKMCNAE)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C64BA0", Offset = "0x2C63FA0", VA = "0x182C64BA0")]
	public static Dictionary<TNode, List<CPPIKLDEGAN<TType>>> EAGBLJDENLK<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::ABHFAKKMCBJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> MCPMOAEEEOJ, TRoot KCFGMPGPMFA, TGraph CGOGNBPFMJH, IEnumerable<TNode> JGPMDEDPADE) where TDeps : global::CFIHCAHJAFH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CPPIKLDEGAN<TType> : IEquatable<CPPIKLDEGAN<TType>>, EPJDBDLJNML<CPPIKLDEGAN<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ICAKBBAJKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType OKMKBDKBDCD;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5A7F670", Offset = "0x5A7EA70", VA = "0x185A7F670")]
	internal CPPIKLDEGAN(string DDDHPCNFCEK, [In] TType CBKLMGLNFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5A7F550", Offset = "0x5A7E950", VA = "0x185A7F550")]
	public bool LPEDODGCMKF([In] CPPIKLDEGAN<TType> KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5A7F500", Offset = "0x5A7E900", VA = "0x185A7F500", Slot = "4")]
	public bool Equals(CPPIKLDEGAN<TType> KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3FD07C0", Offset = "0x3FCFBC0", VA = "0x183FD07C0", Slot = "0")]
	public override bool Equals(object KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2284E60", Offset = "0x2284260", VA = "0x182284E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5A7F630", Offset = "0x5A7EA30", VA = "0x185A7F630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5A7F4B0", Offset = "0x5A7E8B0", VA = "0x185A7F4B0", Slot = "5")]
	private bool AEEMPJEHMMJ([In] CPPIKLDEGAN<TType> KNLMODPGFOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LHEHFKJNJKF
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2F063E0", Offset = "0x2F057E0", VA = "0x182F063E0")]
	public static CPPIKLDEGAN<TType> AHLALEPNKFA<TType>(string DDDHPCNFCEK, TType CBKLMGLNFBD)
	{
		return default(CPPIKLDEGAN<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2F06410", Offset = "0x2F05810", VA = "0x182F06410")]
	public static (string, TType) NBLDAPGCLHM<TType>([In] this CPPIKLDEGAN<TType> MCPMOAEEEOJ)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct ADFLPMFBJHC<TNode> : IEquatable<ADFLPMFBJHC<TNode>>, EPJDBDLJNML<ADFLPMFBJHC<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode CJNFJNFMPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string ICAKBBAJKAF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x10957B0", Offset = "0x1094BB0", VA = "0x1810957B0")]
	internal ADFLPMFBJHC(TNode EKHCANKHNFM, string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0A40", Offset = "0x3FCFE40", VA = "0x183FD0A40")]
	public bool LPEDODGCMKF([In] ADFLPMFBJHC<TNode> KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3FD08A0", Offset = "0x3FCFCA0", VA = "0x183FD08A0", Slot = "4")]
	public bool Equals(ADFLPMFBJHC<TNode> KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3FD07C0", Offset = "0x3FCFBC0", VA = "0x183FD07C0", Slot = "0")]
	public override bool Equals(object KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3FD08F0", Offset = "0x3FCFCF0", VA = "0x183FD08F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0BC0", Offset = "0x3FCFFC0", VA = "0x183FD0BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0B70", Offset = "0x3FCFF70", VA = "0x183FD0B70", Slot = "5")]
	private bool NMOAHJAMFFD([In] ADFLPMFBJHC<TNode> KNLMODPGFOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NKHHPHNDCJP
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2FBDAA0", Offset = "0x2FBCEA0", VA = "0x182FBDAA0")]
	public static ADFLPMFBJHC<TNode> AHLALEPNKFA<TNode>(TNode EKHCANKHNFM, string DDDHPCNFCEK)
	{
		return default(ADFLPMFBJHC<TNode>);
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
