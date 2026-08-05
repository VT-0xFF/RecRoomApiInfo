using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LCOMAIIPALL<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType KEFOPLEGHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind CJKJLGFBJCB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1791620", Offset = "0x1790A20", VA = "0x181791620")]
	internal LCOMAIIPALL(TType FICJMFBEBIN, IOKind EBCIBAEHIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B65670", Offset = "0x3B64A70", VA = "0x183B65670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JFDNMICFNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26EA540", Offset = "0x26E9940", VA = "0x1826EA540")]
	public static LCOMAIIPALL<TType> CPLKLKACALP<TType>(TType FICJMFBEBIN, IOKind EBCIBAEHIMM)
	{
		return default(LCOMAIIPALL<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x26EA570", Offset = "0x26E9970", VA = "0x1826EA570")]
	public static (TType, IOKind) PKDBGMPCBCL<TType>([In] this LCOMAIIPALL<TType> LOMPFKEACIP)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x26EA4E0", Offset = "0x26E98E0", VA = "0x1826EA4E0")]
	public static void ABNKHBBCCGC<TType>([In] this LCOMAIIPALL<TType> LOMPFKEACIP, [Out] TType FICJMFBEBIN, [Out] IOKind EBCIBAEHIMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct JEKJHKOEJJM<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly AGFHOPFHNKK<TNode> OLCNMNCBLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly AGFHOPFHNKK<TNode> FHBBDGGELIB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3A24730", Offset = "0x3A23B30", VA = "0x183A24730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NFEEAMGIIKN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27B8230", Offset = "0x27B7630", VA = "0x1827B8230")]
	public static (AGFHOPFHNKK<TNode>, AGFHOPFHNKK<TNode>) PKDBGMPCBCL<TNode>([In] this JEKJHKOEJJM<TNode> LOMPFKEACIP)
	{
		return default((AGFHOPFHNKK<TNode>, AGFHOPFHNKK<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27B8150", Offset = "0x27B7550", VA = "0x1827B8150")]
	public static void ABNKHBBCCGC<TNode>([In] this JEKJHKOEJJM<TNode> LOMPFKEACIP, [Out] AGFHOPFHNKK<TNode> BGDKODNOBOD, [Out] AGFHOPFHNKK<TNode> APAKCINIMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LKGIICIBKOB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OGAAHBBBMPE BEJDGICDILM(TRoot DHHBNGOGOPD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType BODLFKIJKPB(TRoot DHHBNGOGOPD);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LCOMAIIPALL<TType> EFEMHAELDLC(TRoot DHHBNGOGOPD, [In] LCOMAIIPALL<TType> NNOKPENDLPE, [In] LCOMAIIPALL<TType> OBLEBBNJEBK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GEDLKEFGPJG(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TNode DKBEBHEBAJO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OBEIJPDBGNM(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TNode DKBEBHEBAJO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput MBEOCIDNDLM(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TNode DKBEBHEBAJO, int AHDNEIKOMIB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JAKPLBOMKOO(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TNode DKBEBHEBAJO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput PCCMCNGFPEC(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TNode DKBEBHEBAJO, int AHDNEIKOMIB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<GNGMEIJENHA<TType>> PHJKBHPHIMM(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TNode DKBEBHEBAJO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<JEKJHKOEJJM<TNode>> PLFOAEKEEAM(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TNode DKBEBHEBAJO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NCHEOKOBJLP(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TInput EPJNNNGOOAO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int FMHHLJJONJE(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TInput EPJNNNGOOAO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput ELKIHPHBAHM(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TInput EPJNNNGOOAO, int AHDNEIKOMIB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode BIMBGEEJDOL(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TInput EPJNNNGOOAO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType DFHPEIKBOIO(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TOutput NCFFHCMILBH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int AEGDGNIIFME(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TOutput NCFFHCMILBH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput FEKOFHMPFEG(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TOutput NCFFHCMILBH, int AHDNEIKOMIB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode APEKMMCEHLB(TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, TOutput NCFFHCMILBH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KGLJPDGBGNN(TRoot DHHBNGOGOPD, TType FICJMFBEBIN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType MJKDNGBNGCF(TRoot DHHBNGOGOPD, TType FICJMFBEBIN, IEnumerable<TType> KLMHLLMGJEN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FMICIBCGDLC(TRoot DHHBNGOGOPD, TType FICJMFBEBIN, Action<TType> DHJFDPGDGPK, Action<TType> CLJBHKIJNOE, Action<TType> MHKEFGGEJEN, Action<TType> GBPNNEOIPAH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType FILICJGOIBF(TRoot DHHBNGOGOPD, TType FICJMFBEBIN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string CDFGDOJBFCE(TRoot DHHBNGOGOPD, TType FICJMFBEBIN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification GHKOPPAFACJ(TRoot DHHBNGOGOPD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IAPKJCHKLLD<TOutputSubstitution[], PKAEFJIJPHG> ALMLBDLGOEF(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm BMEKPOKPEMA(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm AMMKFCJBFOJ(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TTerm HCKMDFIOHEN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm IMODKIGHJND(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TTerm BJPEAGPCDMF, TTerm KGJKGLPDNBK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JIIKMALPAHD(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TTerm NNOKPENDLPE, TTerm OBLEBBNJEBK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool NMEGELDFAED(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TOutputTerm ABCCNHFMOFE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool BHMHPBCEHFF(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TOutputTerm ABCCNHFMOFE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm IKEOBEKJNPJ(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TOutputTerm ABCCNHFMOFE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm OBAOAIKHDNL(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TOutputTerm ABCCNHFMOFE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm EPEFAOFAEJB(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TOutputTerm ABCCNHFMOFE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm NAIMAOEOPLG(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TOutputSubstitution GMLCFAJPBNH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm DMDIIDGPFOO(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TOutputSubstitution GMLCFAJPBNH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm JLMBHIOMPAL(TRoot DHHBNGOGOPD, TUnification IGEDPEFGLPN, TTerm HCKMDFIOHEN);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BKNBGGPFBCO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::LKGIICIBKOB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780")]
	public static global::BKNBGGPFBCO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> CPLKLKACALP()
	{
		return default(global::BKNBGGPFBCO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FEBLIPJGAGN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class EOCNMKEDCJG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::LKGIICIBKOB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class MAIEMNDIHOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot OPHGKOLAGBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps AJFLHONBNIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification EPLFDEJHAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph DLPLKHIMMDA;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public OGAAHBBBMPE FANAMBLEKEM
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x3D9A3D0", Offset = "0x3D997D0", VA = "0x183D9A3D0")]
				get
				{
					return default(OGAAHBBBMPE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A7D0", Offset = "0x3D99BD0", VA = "0x183D9A7D0")]
			private MAIEMNDIHOO(TRoot DHHBNGOGOPD, TDeps MLLANHDPJEE, TUnification EHHFMPBGIPM, TGraph HOGIGPFBANF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3D99860", Offset = "0x3D98C60", VA = "0x183D99860")]
			public static MAIEMNDIHOO CPLKLKACALP(TRoot DHHBNGOGOPD, TDeps MLLANHDPJEE, TUnification EHHFMPBGIPM, TGraph HOGIGPFBANF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3D996A0", Offset = "0x3D98AA0", VA = "0x183D996A0")]
			public TType BODLFKIJKPB()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3D99A50", Offset = "0x3D98E50", VA = "0x183D99A50")]
			public LCOMAIIPALL<TType> EFEMHAELDLC(LCOMAIIPALL<TType> NNOKPENDLPE, LCOMAIIPALL<TType> OBLEBBNJEBK)
			{
				return default(LCOMAIIPALL<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3D99E70", Offset = "0x3D99270", VA = "0x183D99E70")]
			public int GEDLKEFGPJG(TNode DKBEBHEBAJO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A590", Offset = "0x3D99990", VA = "0x183D9A590")]
			public int OBEIJPDBGNM(TNode DKBEBHEBAJO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A260", Offset = "0x3D99660", VA = "0x183D9A260")]
			public TInput MBEOCIDNDLM(TNode DKBEBHEBAJO, int AHDNEIKOMIB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3D99FF0", Offset = "0x3D993F0", VA = "0x183D99FF0")]
			public int JAKPLBOMKOO(TNode DKBEBHEBAJO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A610", Offset = "0x3D99A10", VA = "0x183D9A610")]
			public TOutput PCCMCNGFPEC(TNode DKBEBHEBAJO, int AHDNEIKOMIB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A710", Offset = "0x3D99B10", VA = "0x183D9A710")]
			public IEnumerable<GNGMEIJENHA<TType>> PHJKBHPHIMM(TNode DKBEBHEBAJO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A750", Offset = "0x3D99B50", VA = "0x183D9A750")]
			public IEnumerable<JEKJHKOEJJM<TNode>> PLFOAEKEEAM([In] TNode DKBEBHEBAJO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A390", Offset = "0x3D99790", VA = "0x183D9A390")]
			public TType NCHEOKOBJLP(TInput EPJNNNGOOAO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3D995D0", Offset = "0x3D989D0", VA = "0x183D995D0")]
			public int BNFONMOPMMA(TInput EPJNNNGOOAO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3D99B90", Offset = "0x3D98F90", VA = "0x183D99B90")]
			public TOutput ELKIHPHBAHM(TInput EPJNNNGOOAO, int AHDNEIKOMIB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3D99500", Offset = "0x3D98900", VA = "0x183D99500")]
			public TNode BIMBGEEJDOL(TInput EPJNNNGOOAO)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3D99960", Offset = "0x3D98D60", VA = "0x183D99960")]
			public TType DFHPEIKBOIO(TOutput NCFFHCMILBH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3D99EB0", Offset = "0x3D992B0", VA = "0x183D99EB0")]
			public int GIPFPIPLLIC(TOutput NCFFHCMILBH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3D99C80", Offset = "0x3D99080", VA = "0x183D99C80")]
			public TInput FEKOFHMPFEG(TOutput NCFFHCMILBH, int AHDNEIKOMIB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3D993C0", Offset = "0x3D987C0", VA = "0x183D993C0")]
			public TNode APEKMMCEHLB(TOutput NCFFHCMILBH)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A1B0", Offset = "0x3D995B0", VA = "0x183D9A1B0")]
			public bool KGLJPDGBGNN(TType FICJMFBEBIN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A2B0", Offset = "0x3D996B0", VA = "0x183D9A2B0")]
			public TType MJKDNGBNGCF(TType FICJMFBEBIN, IEnumerable<TType> KLMHLLMGJEN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3D99DD0", Offset = "0x3D991D0", VA = "0x183D99DD0")]
			public void FMICIBCGDLC(TType FICJMFBEBIN, Action<TType> DHJFDPGDGPK, Action<TType> CLJBHKIJNOE, Action<TType> MHKEFGGEJEN, Action<TType> GBPNNEOIPAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3D99D50", Offset = "0x3D99150", VA = "0x183D99D50")]
			public TType FILICJGOIBF(TType FICJMFBEBIN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3D996E0", Offset = "0x3D98AE0", VA = "0x183D996E0")]
			public string CDFGDOJBFCE(TType FICJMFBEBIN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3D99550", Offset = "0x3D98950", VA = "0x183D99550")]
			public TTerm BMEKPOKPEMA()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3D992D0", Offset = "0x3D986D0", VA = "0x183D992D0")]
			public TTerm AMMKFCJBFOJ(TTerm HCKMDFIOHEN)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D99F50", Offset = "0x3D99350", VA = "0x183D99F50")]
			public TTerm IMODKIGHJND(TTerm BJPEAGPCDMF, TTerm KGJKGLPDNBK)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A0C0", Offset = "0x3D994C0", VA = "0x183D9A0C0")]
			public void JIIKMALPAHD(TTerm NNOKPENDLPE, TTerm OBLEBBNJEBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3D99410", Offset = "0x3D98810", VA = "0x183D99410")]
			public bool BHMHPBCEHFF(TOutputTerm HCKMDFIOHEN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A4A0", Offset = "0x3D998A0", VA = "0x183D9A4A0")]
			public bool NMEGELDFAED(TOutputTerm HCKMDFIOHEN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3D99280", Offset = "0x3D98680", VA = "0x183D99280")]
			public TTerm AIMNPMJFDAA(TOutputTerm ABCCNHFMOFE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A4F0", Offset = "0x3D998F0", VA = "0x183D9A4F0")]
			public TOutputTerm OBAOAIKHDNL(TOutputTerm HCKMDFIOHEN)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3D99BE0", Offset = "0x3D98FE0", VA = "0x183D99BE0")]
			public TOutputTerm EPEFAOFAEJB(TOutputTerm HCKMDFIOHEN)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A2F0", Offset = "0x3D996F0", VA = "0x183D9A2F0")]
			public TTerm NAIMAOEOPLG(TOutputSubstitution LEAENOMHIKH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3D99A00", Offset = "0x3D98E00", VA = "0x183D99A00")]
			public TOutputTerm DMDIIDGPFOO(TOutputSubstitution LEAENOMHIKH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3D9A110", Offset = "0x3D99510", VA = "0x183D9A110")]
			public TOutputTerm JLMBHIOMPAL(TTerm HCKMDFIOHEN)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BEDIEGKMMAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public MAIEMNDIHOO arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public BEDIEGKMMAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x471AD00", Offset = "0x471A100", VA = "0x18471AD00")]
			internal int EFGHOCCIEKK(MAIEMNDIHOO arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x471AC40", Offset = "0x471A040", VA = "0x18471AC40")]
			internal TInput EBMPCPGFNKB(MAIEMNDIHOO arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x471AD50", Offset = "0x471A150", VA = "0x18471AD50")]
			internal int KCLEAELNGGN(MAIEMNDIHOO arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x471ADF0", Offset = "0x471A1F0", VA = "0x18471ADF0")]
			internal TOutput NDONFCMMGMD(MAIEMNDIHOO arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LPNPMHJBHHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public MAIEMNDIHOO arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, AGFHOPFHNKK<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<AGFHOPFHNKK<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public LPNPMHJBHHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3BE4780", Offset = "0x3BE3B80", VA = "0x183BE4780")]
			internal (string, TTerm) BNOHHFPBIAD(GNGMEIJENHA<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HGDLABAIOIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public MAIEMNDIHOO arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public HGDLABAIOIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x375BC60", Offset = "0x375B060", VA = "0x18375BC60")]
			internal void NMNHGGEIDNH(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x375C310", Offset = "0x375B710", VA = "0x18375C310")]
			internal void OAKMNGBIPBI(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x375B820", Offset = "0x375AC20", VA = "0x18375B820")]
			internal void DNONJHOLGIO(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x375B9E0", Offset = "0x375ADE0", VA = "0x18375B9E0")]
			internal void KHAJMFOBLEH(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MFDAOFAEFNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public MAIEMNDIHOO arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public MFDAOFAEFNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x36C0BA0", Offset = "0x36BFFA0", VA = "0x1836C0BA0")]
			internal TTerm EMNBNBGLHDG(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x32CB040", Offset = "0x32CA440", VA = "0x1832CB040")]
		private static LACAGJLFIDN JIGLNLIAGAI([CallerMemberName] string GFBABMFGHOJ = "")
		{
			return default(LACAGJLFIDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x32CC0D0", Offset = "0x32CB4D0", VA = "0x1832CC0D0")]
		public static Dictionary<TNode, List<GNGMEIJENHA<TType>>> PDOHIFBFPPJ(TRoot DHHBNGOGOPD, TDeps MLLANHDPJEE, TGraph HOGIGPFBANF, IEnumerable<TNode> NFNIOOIAHDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x32C8110", Offset = "0x32C7510", VA = "0x1832C8110")]
		private static (Dictionary<TTerm, AGFHOPFHNKK<TNode>>, List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>>) HNLLNHMIKHO(IEnumerable<TNode> NFNIOOIAHDN, MAIEMNDIHOO CMDECJALHDG)
		{
			return default((Dictionary<TTerm, AGFHOPFHNKK<TNode>>, List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x32C8BD0", Offset = "0x32C7FD0", VA = "0x1832C8BD0")]
		private static void HOOBHKGADIE(TNode DKBEBHEBAJO, Dictionary<TInput, TTerm> DOGFFNMMGIO, Dictionary<TOutput, TTerm> PGNDLGFBNGP, Dictionary<TTerm, AGFHOPFHNKK<TNode>> EGJBOGCFNCJ, Dictionary<AGFHOPFHNKK<TNode>, TTerm> PAMEBMJCIEH, List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> JMCIOPINLBL, Stack<TNode> HLOLFKPBPEN, List<JEKJHKOEJJM<TNode>> LJGHALCJIAB, MAIEMNDIHOO CMDECJALHDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x32C7910", Offset = "0x32C6D10", VA = "0x1832C7910")]
		private static Dictionary<string, TTerm> HBEODNHLEBL(TNode DKBEBHEBAJO, Dictionary<TTerm, AGFHOPFHNKK<TNode>> EGJBOGCFNCJ, Dictionary<AGFHOPFHNKK<TNode>, TTerm> NOPFJLDKPNN, List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> JMCIOPINLBL, MAIEMNDIHOO CMDECJALHDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2FB0130", Offset = "0x2FAF530", VA = "0x182FB0130")]
		private static (TPort, TTerm)[] ODCEMPKDIDB<TPort>(TNode DKBEBHEBAJO, Func<MAIEMNDIHOO, TNode, int> FDBEAHGEFBF, Func<MAIEMNDIHOO, TNode, int, TPort> HABBOMBDEAA, Func<MAIEMNDIHOO, TPort, TType> NBDHJNPHMLC, Dictionary<TPort, TTerm> CBEMAOJIKDJ, MAIEMNDIHOO CMDECJALHDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x32C55F0", Offset = "0x32C49F0", VA = "0x1832C55F0")]
		private static (TTerm, TTerm) AHBLGDAFOHP((TOutput Output, TTerm Id)[] PHGKKOHPNNN, List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> JMCIOPINLBL, Dictionary<string, TTerm> NOPFJLDKPNN, Stack<TNode> HLOLFKPBPEN, MAIEMNDIHOO CMDECJALHDG)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x32C6280", Offset = "0x32C5680", VA = "0x1832C6280")]
		private static void CBBLNMIEPJM((TInput PortKey, TTerm Id)[] EAELCGHJPDI, TTerm KPOALPLEIEO, TTerm ENIKPGAAMMN, List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> JMCIOPINLBL, Dictionary<TOutput, TTerm> PGNDLGFBNGP, Dictionary<string, TTerm> NOPFJLDKPNN, Stack<TNode> HLOLFKPBPEN, MAIEMNDIHOO CMDECJALHDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x32C7C10", Offset = "0x32C7010", VA = "0x1832C7C10")]
		private static TTerm HGCLLKEJDPI(TInput EPJNNNGOOAO, List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> JMCIOPINLBL, Dictionary<TOutput, TTerm> PGNDLGFBNGP, Stack<TNode> HLOLFKPBPEN, MAIEMNDIHOO CMDECJALHDG)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x32C7350", Offset = "0x32C6750", VA = "0x1832C7350")]
		private static TTerm EHNEGIJKHJG([In] TType FICJMFBEBIN, IOKind EBCIBAEHIMM, List<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> JMCIOPINLBL, IReadOnlyDictionary<string, TTerm> NOPFJLDKPNN, MAIEMNDIHOO CMDECJALHDG)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x32CB080", Offset = "0x32CA480", VA = "0x1832CB080")]
		private static Dictionary<TNode, List<GNGMEIJENHA<TType>>> KEKKHBGAFFM(TOutputSubstitution[] CDJMBLNPDBG, Dictionary<TTerm, AGFHOPFHNKK<TNode>> EGJBOGCFNCJ, IEnumerable<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> JMCIOPINLBL, MAIEMNDIHOO CMDECJALHDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x32CBC60", Offset = "0x32CB060", VA = "0x1832CBC60")]
		private static Dictionary<TNode, List<GNGMEIJENHA<TType>>> MPFNEOKOBDC(Dictionary<TTerm, AGFHOPFHNKK<TNode>> EGJBOGCFNCJ, MAIEMNDIHOO CMDECJALHDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x32CC650", Offset = "0x32CBA50", VA = "0x1832CC650")]
		private static void PHEAJCNDEPM([In] TNode DKBEBHEBAJO, Stack<TNode> HLOLFKPBPEN, List<JEKJHKOEJJM<TNode>> LJGHALCJIAB, MAIEMNDIHOO CMDECJALHDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x32C6EA0", Offset = "0x32C62A0", VA = "0x1832C6EA0")]
		private static void DPMDBICFMPD(Dictionary<AGFHOPFHNKK<TNode>, TTerm> NOPFJLDKPNN, List<JEKJHKOEJJM<TNode>> LJGHALCJIAB, MAIEMNDIHOO CMDECJALHDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x32C97F0", Offset = "0x32C8BF0", VA = "0x1832C97F0")]
		private static Dictionary<TTerm, TType> IDNGOAADICI(Dictionary<TTerm, TOutputSubstitution> CDJMBLNPDBG, IEnumerable<KeyValuePair<TTerm, LCOMAIIPALL<TType>>> JMCIOPINLBL, MAIEMNDIHOO CMDECJALHDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x32CA6E0", Offset = "0x32C9AE0", VA = "0x1832CA6E0")]
		private static MEHMHNNDBEN<TType> IKNNFDMMPCH(TOutputTerm FICJMFBEBIN, Dictionary<TTerm, TType> JMCIOPINLBL, Dictionary<TTerm, TType> ABNDHJPENBL, MAIEMNDIHOO CMDECJALHDG)
		{
			return default(MEHMHNNDBEN<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x32CAEC0", Offset = "0x32CA2C0", VA = "0x1832CAEC0")]
		private static TOutputTerm JBFBFHNAJCJ(TOutputTerm ONMEHLNFDMB, MAIEMNDIHOO CMDECJALHDG)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2657DF0", Offset = "0x26571F0", VA = "0x182657DF0")]
	public static Dictionary<TNode, List<GNGMEIJENHA<TType>>> PDOHIFBFPPJ<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::BKNBGGPFBCO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> LOMPFKEACIP, TRoot DHHBNGOGOPD, TGraph HOGIGPFBANF, IEnumerable<TNode> NFNIOOIAHDN) where TDeps : global::LKGIICIBKOB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GNGMEIJENHA<TType> : IEquatable<GNGMEIJENHA<TType>>, OOCNEMALIND<GNGMEIJENHA<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string GAOODFEKINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType JFALJAMLJAC;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3727640", Offset = "0x3726A40", VA = "0x183727640")]
	internal GNGMEIJENHA(string GFBABMFGHOJ, [In] TType MKEIIGKPFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3727490", Offset = "0x3726890", VA = "0x183727490")]
	public bool CKOGKAMODKI([In] GNGMEIJENHA<TType> KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3727560", Offset = "0x3726960", VA = "0x183727560", Slot = "4")]
	public bool Equals(GNGMEIJENHA<TType> KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x36D3450", Offset = "0x36D2850", VA = "0x1836D3450", Slot = "0")]
	public override bool Equals(object KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D84770", Offset = "0x1D83B70", VA = "0x181D84770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3727600", Offset = "0x3726A00", VA = "0x183727600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x37275B0", Offset = "0x37269B0", VA = "0x1837275B0", Slot = "5")]
	private bool KEJJIBHHGJF([In] GNGMEIJENHA<TType> KMJGEHGGFFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ALAINLGNNJO
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2CF75E0", Offset = "0x2CF69E0", VA = "0x182CF75E0")]
	public static GNGMEIJENHA<TType> CPLKLKACALP<TType>(string GFBABMFGHOJ, TType MKEIIGKPFIN)
	{
		return default(GNGMEIJENHA<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7610", Offset = "0x2CF6A10", VA = "0x182CF7610")]
	public static (string, TType) PKDBGMPCBCL<TType>([In] this GNGMEIJENHA<TType> LOMPFKEACIP)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AGFHOPFHNKK<TNode> : IEquatable<AGFHOPFHNKK<TNode>>, OOCNEMALIND<AGFHOPFHNKK<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode BJAACIJNJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string GAOODFEKINE;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xB97460", Offset = "0xB96860", VA = "0x180B97460")]
	internal AGFHOPFHNKK(TNode DKBEBHEBAJO, string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x36D32B0", Offset = "0x36D26B0", VA = "0x1836D32B0")]
	public bool CKOGKAMODKI([In] AGFHOPFHNKK<TNode> KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x36D3520", Offset = "0x36D2920", VA = "0x1836D3520", Slot = "4")]
	public bool Equals(AGFHOPFHNKK<TNode> KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x36D3450", Offset = "0x36D2850", VA = "0x1836D3450", Slot = "0")]
	public override bool Equals(object KMJGEHGGFFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x36D3570", Offset = "0x36D2970", VA = "0x1836D3570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x36D36C0", Offset = "0x36D2AC0", VA = "0x1836D36C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x36D3630", Offset = "0x36D2A30", VA = "0x1836D3630", Slot = "5")]
	private bool MFCIEOFDDMN([In] AGFHOPFHNKK<TNode> KMJGEHGGFFC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FGEGFEEMDPH
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2658D70", Offset = "0x2658170", VA = "0x182658D70")]
	public static AGFHOPFHNKK<TNode> CPLKLKACALP<TNode>(TNode DKBEBHEBAJO, string GFBABMFGHOJ)
	{
		return default(AGFHOPFHNKK<TNode>);
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
