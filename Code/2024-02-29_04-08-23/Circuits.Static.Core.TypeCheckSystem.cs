using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct MPFCGIGHMBP<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType KKPIOFNDDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind AODJMHGOFEB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x17CEC40", Offset = "0x17CDA40", VA = "0x1817CEC40")]
	internal MPFCGIGHMBP(TType HFFNCGFKMBJ, IOKind HLGAEFIGAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3E01140", Offset = "0x3DFFF40", VA = "0x183E01140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KODNNHALOIG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2783140", Offset = "0x2781F40", VA = "0x182783140")]
	public static MPFCGIGHMBP<TType> KJKFMOENPNA<TType>(TType HFFNCGFKMBJ, IOKind HLGAEFIGAMG)
	{
		return default(MPFCGIGHMBP<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2783100", Offset = "0x2781F00", VA = "0x182783100")]
	public static (TType, IOKind) JNHCGJNPKKM<TType>([In] this MPFCGIGHMBP<TType> CNFBJPGPBBJ)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27830A0", Offset = "0x2781EA0", VA = "0x1827830A0")]
	public static void FLAGJIHGEHA<TType>([In] this MPFCGIGHMBP<TType> CNFBJPGPBBJ, [Out] TType HFFNCGFKMBJ, [Out] IOKind HLGAEFIGAMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct ELHOENKBNJF<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly AEFPOEHBENH<TNode> DKEADEBHAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly AEFPOEHBENH<TNode> LHLODOOOBOK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3253FC0", Offset = "0x3252DC0", VA = "0x183253FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JNEKPKMOBAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x275F6F0", Offset = "0x275E4F0", VA = "0x18275F6F0")]
	public static (AEFPOEHBENH<TNode>, AEFPOEHBENH<TNode>) JNHCGJNPKKM<TNode>([In] this ELHOENKBNJF<TNode> CNFBJPGPBBJ)
	{
		return default((AEFPOEHBENH<TNode>, AEFPOEHBENH<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x275F610", Offset = "0x275E410", VA = "0x18275F610")]
	public static void FLAGJIHGEHA<TNode>([In] this ELHOENKBNJF<TNode> CNFBJPGPBBJ, [Out] AEFPOEHBENH<TNode> DPMPIPDPNFG, [Out] AEFPOEHBENH<TNode> DJCBILALFKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FGJPHHNNODN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PKIACMADEMF JGOIGICBHPC(TRoot ADCDJFADKCK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType BMKCPEBIHOJ(TRoot ADCDJFADKCK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MPFCGIGHMBP<TType> EGLMALKEEGG(TRoot ADCDJFADKCK, [In] MPFCGIGHMBP<TType> EHBONBMIDMA, [In] MPFCGIGHMBP<TType> MKAKMHGMJJL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BOPFJLJPABL(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TNode ACNLHBNEANJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int PCELNHKIPJD(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TNode ACNLHBNEANJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput PODPFCMPHGH(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TNode ACNLHBNEANJ, int ENPOKNEMOMH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NKKOPDLNLEA(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TNode ACNLHBNEANJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput LBFOFPADNFF(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TNode ACNLHBNEANJ, int ENPOKNEMOMH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IBNFIIFLDPA<TType>> DBBFIPCHCJJ(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TNode ACNLHBNEANJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<ELHOENKBNJF<TNode>> MMIADGIFMFJ(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TNode ACNLHBNEANJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType GDACDIKEKAI(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TInput ECKJJAACLOE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int DLLNHLFCNJJ(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TInput ECKJJAACLOE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput PNHJEHEAJAP(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TInput ECKJJAACLOE, int ENPOKNEMOMH);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode MLPNMNACHMB(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TInput ECKJJAACLOE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType IKMGCLOOKAI(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TOutput ADPLPAEFBEL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int CHJEPBMOAIA(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TOutput ADPLPAEFBEL);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput FAGCFAFMHEO(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TOutput ADPLPAEFBEL, int ENPOKNEMOMH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode JHJNIOBLBFE(TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, TOutput ADPLPAEFBEL);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LDLOJOEPKBL(TRoot ADCDJFADKCK, TType HFFNCGFKMBJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType EPFBMNKENOO(TRoot ADCDJFADKCK, TType HFFNCGFKMBJ, IEnumerable<TType> PANHJBMNJHI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DMNGLBCMFIA(TRoot ADCDJFADKCK, TType HFFNCGFKMBJ, Action<TType> EIPPNBAJMHE, Action<TType> PEOAFFAKIDI, Action<TType> LBAHFNJICDI, Action<TType> MDPIOHAPACO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType HMHMHKFEIMD(TRoot ADCDJFADKCK, TType HFFNCGFKMBJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string MMPCAMHILFO(TRoot ADCDJFADKCK, TType HFFNCGFKMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification AGMEPKENLIE(TRoot ADCDJFADKCK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FBEPHKHKLJE<TOutputSubstitution[], KOAMPGHKKDA> NKJKDIPHILL(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm DAOEAHLNLBC(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm KDGLBGHCCAC(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TTerm IIDBAPOJJJL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm HIOKNGINHPP(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TTerm EIFHACOADFO, TTerm IDPPHHMPMLO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CBKBGHDMLPA(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TTerm EHBONBMIDMA, TTerm MKAKMHGMJJL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool IAFLHELCLCG(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TOutputTerm CHJLJCBAFCO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool HKCMKCHJIDL(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TOutputTerm CHJLJCBAFCO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm NOOLCDKACJP(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TOutputTerm CHJLJCBAFCO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm HJIFBGAKBPC(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TOutputTerm CHJLJCBAFCO);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm IBIGNKIODFB(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TOutputTerm CHJLJCBAFCO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm INGJPJFGNAJ(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TOutputSubstitution IBCPBIMBEAM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm NOKCOMMFEPD(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TOutputSubstitution IBCPBIMBEAM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm LEOJLFOKMLN(TRoot ADCDJFADKCK, TUnification ABBMKLGAJHC, TTerm IIDBAPOJJJL);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct APNGFNDHBDG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::FGJPHHNNODN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0")]
	public static global::APNGFNDHBDG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> KJKFMOENPNA()
	{
		return default(global::APNGFNDHBDG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BPOBLLGIPNL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class FEMMEMAKDMJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::FGJPHHNNODN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class KFBNLFAGIAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot CGOAPMHKIEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps IOBKGEEKHIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification IOFHPEKPMDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph CAJKMADJKKP;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public PKIACMADEMF HJAELOBJLNJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x3AA2340", Offset = "0x3AA1140", VA = "0x183AA2340")]
				get
				{
					return default(PKIACMADEMF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4CB0", Offset = "0x3AA3AB0", VA = "0x183AA4CB0")]
			private KFBNLFAGIAJ(TRoot ADCDJFADKCK, TDeps DNHMNAAINOD, TUnification GECJCHCGPAB, TGraph DOAPLFMMIBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3C00", Offset = "0x3AA2A00", VA = "0x183AA3C00")]
			public static KFBNLFAGIAJ KJKFMOENPNA(TRoot ADCDJFADKCK, TDeps DNHMNAAINOD, TUnification GECJCHCGPAB, TGraph DOAPLFMMIBD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2230", Offset = "0x3AA1030", VA = "0x183AA2230")]
			public TType BMKCPEBIHOJ()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2AF0", Offset = "0x3AA18F0", VA = "0x183AA2AF0")]
			public MPFCGIGHMBP<TType> EGLMALKEEGG(MPFCGIGHMBP<TType> EHBONBMIDMA, MPFCGIGHMBP<TType> MKAKMHGMJJL)
			{
				return default(MPFCGIGHMBP<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2480", Offset = "0x3AA1280", VA = "0x183AA2480")]
			public int BOPFJLJPABL(TNode ACNLHBNEANJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4890", Offset = "0x3AA3690", VA = "0x183AA4890")]
			public int PCELNHKIPJD(TNode ACNLHBNEANJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4AE0", Offset = "0x3AA38E0", VA = "0x183AA4AE0")]
			public TInput PODPFCMPHGH(TNode ACNLHBNEANJ, int ENPOKNEMOMH)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4680", Offset = "0x3AA3480", VA = "0x183AA4680")]
			public int NKKOPDLNLEA(TNode ACNLHBNEANJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3F00", Offset = "0x3AA2D00", VA = "0x183AA3F00")]
			public TOutput LBFOFPADNFF(TNode ACNLHBNEANJ, int ENPOKNEMOMH)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2890", Offset = "0x3AA1690", VA = "0x183AA2890")]
			public IEnumerable<IBNFIIFLDPA<TType>> DBBFIPCHCJJ(TNode ACNLHBNEANJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3AA43B0", Offset = "0x3AA31B0", VA = "0x183AA43B0")]
			public IEnumerable<ELHOENKBNJF<TNode>> MMIADGIFMFJ([In] TNode ACNLHBNEANJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2E90", Offset = "0x3AA1C90", VA = "0x183AA2E90")]
			public TType GDACDIKEKAI(TInput ECKJJAACLOE)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4C70", Offset = "0x3AA3A70", VA = "0x183AA4C70")]
			public int PPBGGNGCFAA(TInput ECKJJAACLOE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4970", Offset = "0x3AA3770", VA = "0x183AA4970")]
			public TOutput PNHJEHEAJAP(TInput ECKJJAACLOE, int ENPOKNEMOMH)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4290", Offset = "0x3AA3090", VA = "0x183AA4290")]
			public TNode MLPNMNACHMB(TInput ECKJJAACLOE)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3AA37D0", Offset = "0x3AA25D0", VA = "0x183AA37D0")]
			public TType IKMGCLOOKAI(TOutput ADPLPAEFBEL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2150", Offset = "0x3AA0F50", VA = "0x183AA2150")]
			public int ABINNJBOLJP(TOutput ADPLPAEFBEL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2DC0", Offset = "0x3AA1BC0", VA = "0x183AA2DC0")]
			public TInput FAGCFAFMHEO(TOutput ADPLPAEFBEL, int ENPOKNEMOMH)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3AA39C0", Offset = "0x3AA27C0", VA = "0x183AA39C0")]
			public TNode JHJNIOBLBFE(TOutput ADPLPAEFBEL)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4130", Offset = "0x3AA2F30", VA = "0x183AA4130")]
			public bool LDLOJOEPKBL(TType HFFNCGFKMBJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2CE0", Offset = "0x3AA1AE0", VA = "0x183AA2CE0")]
			public TType EPFBMNKENOO(TType HFFNCGFKMBJ, IEnumerable<TType> PANHJBMNJHI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2A30", Offset = "0x3AA1830", VA = "0x183AA2A30")]
			public void DMNGLBCMFIA(TType HFFNCGFKMBJ, Action<TType> EIPPNBAJMHE, Action<TType> PEOAFFAKIDI, Action<TType> LBAHFNJICDI, Action<TType> MDPIOHAPACO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3AA33F0", Offset = "0x3AA21F0", VA = "0x183AA33F0")]
			public TType HMHMHKFEIMD(TType HFFNCGFKMBJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3AA45C0", Offset = "0x3AA33C0", VA = "0x183AA45C0")]
			public string MMPCAMHILFO(TType HFFNCGFKMBJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2720", Offset = "0x3AA1520", VA = "0x183AA2720")]
			public TTerm DAOEAHLNLBC()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3BB0", Offset = "0x3AA29B0", VA = "0x183AA3BB0")]
			public TTerm KDGLBGHCCAC(TTerm IIDBAPOJJJL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2FA0", Offset = "0x3AA1DA0", VA = "0x183AA2FA0")]
			public TTerm HIOKNGINHPP(TTerm EIFHACOADFO, TTerm IDPPHHMPMLO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3AA2580", Offset = "0x3AA1380", VA = "0x183AA2580")]
			public void CBKBGHDMLPA(TTerm EHBONBMIDMA, TTerm MKAKMHGMJJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3AA32E0", Offset = "0x3AA20E0", VA = "0x183AA32E0")]
			public bool HKCMKCHJIDL(TOutputTerm IIDBAPOJJJL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3470", Offset = "0x3AA2270", VA = "0x183AA3470")]
			public bool IAFLHELCLCG(TOutputTerm IIDBAPOJJJL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3730", Offset = "0x3AA2530", VA = "0x183AA3730")]
			public TTerm IBMJLGEINHH(TOutputTerm CHJLJCBAFCO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3140", Offset = "0x3AA1F40", VA = "0x183AA3140")]
			public TOutputTerm HJIFBGAKBPC(TOutputTerm IIDBAPOJJJL)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3AA3590", Offset = "0x3AA2390", VA = "0x183AA3590")]
			public TOutputTerm IBIGNKIODFB(TOutputTerm IIDBAPOJJJL)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3AA38F0", Offset = "0x3AA26F0", VA = "0x183AA38F0")]
			public TTerm INGJPJFGNAJ(TOutputSubstitution PLAEJHDLJIB)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4780", Offset = "0x3AA3580", VA = "0x183AA4780")]
			public TOutputTerm NOKCOMMFEPD(TOutputSubstitution PLAEJHDLJIB)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3AA4170", Offset = "0x3AA2F70", VA = "0x183AA4170")]
			public TOutputTerm LEOJLFOKMLN(TTerm IIDBAPOJJJL)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class LDJNJEPCFHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public KFBNLFAGIAJ arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public LDJNJEPCFHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3BD9760", Offset = "0x3BD8560", VA = "0x183BD9760")]
			internal int JHGPKKLKOLP(KFBNLFAGIAJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3BD9880", Offset = "0x3BD8680", VA = "0x183BD9880")]
			internal TInput KMMFDKHMGCH(KFBNLFAGIAJ arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3BD9920", Offset = "0x3BD8720", VA = "0x183BD9920")]
			internal int MELEJMCGPLA(KFBNLFAGIAJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3BD99D0", Offset = "0x3BD87D0", VA = "0x183BD99D0")]
			internal TOutput OOCOJMLJBOF(KFBNLFAGIAJ arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LONBIAKPMLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public KFBNLFAGIAJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, AEFPOEHBENH<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<AEFPOEHBENH<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public LONBIAKPMLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3C2C420", Offset = "0x3C2B220", VA = "0x183C2C420")]
			internal (string, TTerm) FKPPLEGBICE(IBNFIIFLDPA<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class HBJGIKEJBKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public KFBNLFAGIAJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public HBJGIKEJBKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x37024D0", Offset = "0x37012D0", VA = "0x1837024D0")]
			internal void FJGFGENOLAK(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3702310", Offset = "0x3701110", VA = "0x183702310")]
			internal void DNOMILNHACK(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3702950", Offset = "0x3701750", VA = "0x183702950")]
			internal void LPPPMGGANKN(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3702E10", Offset = "0x3701C10", VA = "0x183702E10")]
			internal void PKPHKDCKGND(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HCCFPGHBOKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public KFBNLFAGIAJ arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public HCCFPGHBOKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x37069E0", Offset = "0x37057E0", VA = "0x1837069E0")]
			internal TTerm HCAELKMJGPM(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x35B4C30", Offset = "0x35B3A30", VA = "0x1835B4C30")]
		private static OLDEFDAMLOO GLHPPEFPGFD([CallerMemberName] string OHHBGJPCFJD = "")
		{
			return default(OLDEFDAMLOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x35BFDF0", Offset = "0x35BEBF0", VA = "0x1835BFDF0")]
		public static Dictionary<TNode, List<IBNFIIFLDPA<TType>>> OCPMIJOMMEC(TRoot ADCDJFADKCK, TDeps DNHMNAAINOD, TGraph DOAPLFMMIBD, IEnumerable<TNode> EIGKMPBMGAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x35B9100", Offset = "0x35B7F00", VA = "0x1835B9100")]
		private static (Dictionary<TTerm, AEFPOEHBENH<TNode>>, List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>>) JKKPDFFAIFP(IEnumerable<TNode> EIGKMPBMGAG, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return default((Dictionary<TTerm, AEFPOEHBENH<TNode>>, List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x35B1E20", Offset = "0x35B0C20", VA = "0x1835B1E20")]
		private static void FACKPFJCAFE(TNode ACNLHBNEANJ, Dictionary<TInput, TTerm> DOMFBENLLFB, Dictionary<TOutput, TTerm> FGHECEDPKAI, Dictionary<TTerm, AEFPOEHBENH<TNode>> GPPAEDIGPDC, Dictionary<AEFPOEHBENH<TNode>, TTerm> FPBKCCPKKIC, List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> LDHDAHFCDAH, Stack<TNode> JLIOKCJEKGA, List<ELHOENKBNJF<TNode>> GKJCIBKDILH, KFBNLFAGIAJ MLBFGGJBJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35ACE70", Offset = "0x35ABC70", VA = "0x1835ACE70")]
		private static Dictionary<string, TTerm> ALNNMEKMKNL(TNode ACNLHBNEANJ, Dictionary<TTerm, AEFPOEHBENH<TNode>> GPPAEDIGPDC, Dictionary<AEFPOEHBENH<TNode>, TTerm> OJHOLDMNEJL, List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> LDHDAHFCDAH, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2411640", Offset = "0x2410440", VA = "0x182411640")]
		private static (TPort, TTerm)[] MMNMFCDGINK<TPort>(TNode ACNLHBNEANJ, Func<KFBNLFAGIAJ, TNode, int> KNEFEFCMLOP, Func<KFBNLFAGIAJ, TNode, int, TPort> JMCHMACFNFA, Func<KFBNLFAGIAJ, TPort, TType> PLJPDKBGLII, Dictionary<TPort, TTerm> NCMGIONOIBK, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x35BD820", Offset = "0x35BC620", VA = "0x1835BD820")]
		private static (TTerm, TTerm) MAMBEJFNINP((TOutput Output, TTerm Id)[] MIDLLPANDIG, List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> LDHDAHFCDAH, Dictionary<string, TTerm> OJHOLDMNEJL, Stack<TNode> JLIOKCJEKGA, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x35BBF30", Offset = "0x35BAD30", VA = "0x1835BBF30")]
		private static void KHMJPBPAJOJ((TInput PortKey, TTerm Id)[] LNIGABDEMDD, TTerm DGADLNLIIAJ, TTerm JCFPAOJINHB, List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> LDHDAHFCDAH, Dictionary<TOutput, TTerm> FGHECEDPKAI, Dictionary<string, TTerm> OJHOLDMNEJL, Stack<TNode> JLIOKCJEKGA, KFBNLFAGIAJ MLBFGGJBJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x35B0CD0", Offset = "0x35AFAD0", VA = "0x1835B0CD0")]
		private static TTerm DIGIAGDIIME(TInput ECKJJAACLOE, List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> LDHDAHFCDAH, Dictionary<TOutput, TTerm> FGHECEDPKAI, Stack<TNode> JLIOKCJEKGA, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x35B4630", Offset = "0x35B3430", VA = "0x1835B4630")]
		private static TTerm FKLHNPMFGFM([In] TType HFFNCGFKMBJ, IOKind HLGAEFIGAMG, List<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> LDHDAHFCDAH, IReadOnlyDictionary<string, TTerm> OJHOLDMNEJL, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x35AEAA0", Offset = "0x35AD8A0", VA = "0x1835AEAA0")]
		private static Dictionary<TNode, List<IBNFIIFLDPA<TType>>> BJMDLKOBOIP(TOutputSubstitution[] MJEBMAGOKFA, Dictionary<TTerm, AEFPOEHBENH<TNode>> GPPAEDIGPDC, IEnumerable<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> LDHDAHFCDAH, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x35ADA50", Offset = "0x35AC850", VA = "0x1835ADA50")]
		private static Dictionary<TNode, List<IBNFIIFLDPA<TType>>> BJBABOKDHGM(Dictionary<TTerm, AEFPOEHBENH<TNode>> GPPAEDIGPDC, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x35B4CB0", Offset = "0x35B3AB0", VA = "0x1835B4CB0")]
		private static void HAJIJALOHGM([In] TNode ACNLHBNEANJ, Stack<TNode> JLIOKCJEKGA, List<ELHOENKBNJF<TNode>> GKJCIBKDILH, KFBNLFAGIAJ MLBFGGJBJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x35C0830", Offset = "0x35BF630", VA = "0x1835C0830")]
		private static void PCAKNEIFNMI(Dictionary<AEFPOEHBENH<TNode>, TTerm> OJHOLDMNEJL, List<ELHOENKBNJF<TNode>> GKJCIBKDILH, KFBNLFAGIAJ MLBFGGJBJJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x35B7750", Offset = "0x35B6550", VA = "0x1835B7750")]
		private static Dictionary<TTerm, TType> IEHKGDEDAGM(Dictionary<TTerm, TOutputSubstitution> MJEBMAGOKFA, IEnumerable<KeyValuePair<TTerm, MPFCGIGHMBP<TType>>> LDHDAHFCDAH, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x35B3E50", Offset = "0x35B2C50", VA = "0x1835B3E50")]
		private static OPMELBICLMG<TType> FCKMEDDFOGE(TOutputTerm HFFNCGFKMBJ, Dictionary<TTerm, TType> LDHDAHFCDAH, Dictionary<TTerm, TType> FNFFBGBDPIP, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return default(OPMELBICLMG<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x35C1190", Offset = "0x35BFF90", VA = "0x1835C1190")]
		private static TOutputTerm PKPOLKIDCND(TOutputTerm MLGEDLCMGMA, KFBNLFAGIAJ MLBFGGJBJJC)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x24ECFE0", Offset = "0x24EBDE0", VA = "0x1824ECFE0")]
	public static Dictionary<TNode, List<IBNFIIFLDPA<TType>>> OCPMIJOMMEC<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::APNGFNDHBDG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> CNFBJPGPBBJ, TRoot ADCDJFADKCK, TGraph DOAPLFMMIBD, IEnumerable<TNode> EIGKMPBMGAG) where TDeps : global::FGJPHHNNODN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IBNFIIFLDPA<TType> : IEquatable<IBNFIIFLDPA<TType>>, NLAOOBBGEHG<IBNFIIFLDPA<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string GMLPMAJDOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType DOPFJKKIEKK;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3840F80", Offset = "0x383FD80", VA = "0x183840F80")]
	internal IBNFIIFLDPA(string OHHBGJPCFJD, [In] TType EELHPBOLMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3840E20", Offset = "0x383FC20", VA = "0x183840E20")]
	public bool JNFOCAILINO([In] IBNFIIFLDPA<TType> FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3840DD0", Offset = "0x383FBD0", VA = "0x183840DD0", Slot = "4")]
	public bool Equals(IBNFIIFLDPA<TType> FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3674DE0", Offset = "0x3673BE0", VA = "0x183674DE0", Slot = "0")]
	public override bool Equals(object FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5210", Offset = "0x1DD4010", VA = "0x181DD5210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3840F40", Offset = "0x383FD40", VA = "0x183840F40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3840EF0", Offset = "0x383FCF0", VA = "0x183840EF0", Slot = "5")]
	private bool NCEPDLEGLLE([In] IBNFIIFLDPA<TType> FPEEGIOMOFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JPKCJLKFIKI
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2760920", Offset = "0x275F720", VA = "0x182760920")]
	public static IBNFIIFLDPA<TType> KJKFMOENPNA<TType>(string OHHBGJPCFJD, TType EELHPBOLMMJ)
	{
		return default(IBNFIIFLDPA<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x27608E0", Offset = "0x275F6E0", VA = "0x1827608E0")]
	public static (string, TType) JNHCGJNPKKM<TType>([In] this IBNFIIFLDPA<TType> CNFBJPGPBBJ)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct AEFPOEHBENH<TNode> : IEquatable<AEFPOEHBENH<TNode>>, NLAOOBBGEHG<AEFPOEHBENH<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode EDEGFHMOIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string GMLPMAJDOJG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xBA8D80", Offset = "0xBA7B80", VA = "0x180BA8D80")]
	internal AEFPOEHBENH(TNode ACNLHBNEANJ, string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3674ED0", Offset = "0x3673CD0", VA = "0x183674ED0")]
	public bool JNFOCAILINO([In] AEFPOEHBENH<TNode> FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3674D40", Offset = "0x3673B40", VA = "0x183674D40", Slot = "4")]
	public bool Equals(AEFPOEHBENH<TNode> FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3674DE0", Offset = "0x3673BE0", VA = "0x183674DE0", Slot = "0")]
	public override bool Equals(object FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3674E60", Offset = "0x3673C60", VA = "0x183674E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3675070", Offset = "0x3673E70", VA = "0x183675070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3674CF0", Offset = "0x3673AF0", VA = "0x183674CF0", Slot = "5")]
	private bool BOCBGLPGKLD([In] AEFPOEHBENH<TNode> FPEEGIOMOFF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OLOIJMOLMAC
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x28583C0", Offset = "0x28571C0", VA = "0x1828583C0")]
	public static AEFPOEHBENH<TNode> KJKFMOENPNA<TNode>(TNode ACNLHBNEANJ, string OHHBGJPCFJD)
	{
		return default(AEFPOEHBENH<TNode>);
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
