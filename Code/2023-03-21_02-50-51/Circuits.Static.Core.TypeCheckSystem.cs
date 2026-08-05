using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Utilities;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LPCAKOAGKJP<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType ECHKLFAEIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind IIFMCCAFOEB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F5ED0", Offset = "0x7F46D0", VA = "0x1807F5ED0")]
	internal LPCAKOAGKJP(TType EHPFPOFFCEJ, IOKind EBPNOEJPOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2FF0350", Offset = "0x2FEEB50", VA = "0x182FF0350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ACKHMHEPAGB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x17F1880", Offset = "0x17F0080", VA = "0x1817F1880")]
	public static global::LPCAKOAGKJP<TType> HHEHBEMBBBF<TType>(TType EHPFPOFFCEJ, IOKind EBPNOEJPOCM)
	{
		return default(global::LPCAKOAGKJP<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x17F1910", Offset = "0x17F0110", VA = "0x1817F1910")]
	public static (TType, IOKind) PFLAHKOKNME<TType>(this in global::LPCAKOAGKJP<TType> DCJNPPINKOA)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x17F18B0", Offset = "0x17F00B0", VA = "0x1817F18B0")]
	public static void NEMBEEBJDEF<TType>(this in global::LPCAKOAGKJP<TType> DCJNPPINKOA, out TType EHPFPOFFCEJ, out IOKind EBPNOEJPOCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct NDCKPGBEHHL<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly global::KHMOLPBFJMK<TNode> MCNKEGMEFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly global::KHMOLPBFJMK<TNode> MHAKOAEICGK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E160", Offset = "0x2E3C960", VA = "0x182E3E160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MCLAIJFJCPG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24F68E0", Offset = "0x24F50E0", VA = "0x1824F68E0")]
	public static (global::KHMOLPBFJMK<TNode>, global::KHMOLPBFJMK<TNode>) PFLAHKOKNME<TNode>(this in global::NDCKPGBEHHL<TNode> DCJNPPINKOA)
	{
		return default((global::KHMOLPBFJMK<TNode>, global::KHMOLPBFJMK<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24F6870", Offset = "0x24F5070", VA = "0x1824F6870")]
	public static void NEMBEEBJDEF<TNode>(this in global::NDCKPGBEHHL<TNode> DCJNPPINKOA, out global::KHMOLPBFJMK<TNode> NCBNFILGGOG, out global::KHMOLPBFJMK<TNode> NMABHKKNANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BOOENJJLIFG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HBMFCOKANHJ CEJJDLDNODE(TRoot FECENBBKPOP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType OELEILKLBIF(TRoot FECENBBKPOP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::LPCAKOAGKJP<TType> KDFDFAENPBC(TRoot FECENBBKPOP, in global::LPCAKOAGKJP<TType> EHDPPFDCEJK, in global::LPCAKOAGKJP<TType> NPIMFLIIAHF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PCMEPONNFLF(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TNode KFMDDCEOFLE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BLNHDLIFNPD(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TNode KFMDDCEOFLE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput GACCGHLADFG(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TNode KFMDDCEOFLE, int LHHBOCAHDEE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NANNLMCAKJI(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TNode KFMDDCEOFLE);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput EJCFJIBHKEI(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TNode KFMDDCEOFLE, int LHHBOCAHDEE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<global::IPFEHDOGDCK<TType>> BHPDPAKIOHF(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TNode KFMDDCEOFLE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<global::NDCKPGBEHHL<TNode>> GJOLIJAJMOK(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TNode KFMDDCEOFLE);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType KPIBNNNHLLC(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TInput JHPDOGGEPPC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int CEDPKCJMJJM(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TInput JHPDOGGEPPC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput CLCCIEOCFIF(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TInput JHPDOGGEPPC, int LHHBOCAHDEE);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode HNCLEJKMEML(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TInput JHPDOGGEPPC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType BNPJGPLJOCN(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TOutput NJOLPIOOJHP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int FECOCBLFLIL(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TOutput NJOLPIOOJHP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput EPDMNEFJIOA(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TOutput NJOLPIOOJHP, int LHHBOCAHDEE);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode ICOFGANBCDC(TRoot FECENBBKPOP, TGraph NELIICGHDHB, TOutput NJOLPIOOJHP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NJBCMMOPJFD(TRoot FECENBBKPOP, TType EHPFPOFFCEJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType AGMHNEGBHKP(TRoot FECENBBKPOP, TType EHPFPOFFCEJ, IEnumerable<TType> GDBAICMBLGE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KFDMOLCMIPB(TRoot FECENBBKPOP, TType EHPFPOFFCEJ, Action<TType> CGNHPABFGIH, Action<TType> BAIPLDPNCEC, Action<TType> HCLFCBFPDKA, Action<TType> IHCMMGLPKPN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType JDILABICENI(TRoot FECENBBKPOP, TType EHPFPOFFCEJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string JGHLFKIKNGG(TRoot FECENBBKPOP, TType EHPFPOFFCEJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification KEKLFMDENGI(TRoot FECENBBKPOP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	global::IMDNOFMHNPP<TOutputSubstitution[], JGDNADHAHMP> BJMOCPAMPJE(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm GFEPIJEJANG(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm EAMALIOKMIE(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TTerm HJAHAJHPMMI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm BIAMEOHFOND(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TTerm AOKNACFHLEG, TTerm LNDILOLNLJO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OOADNNKHKHB(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TTerm EHDPPFDCEJK, TTerm NPIMFLIIAHF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool EPGPPGAPNGA(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TOutputTerm GFDBHDFJMLO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KONCMJKOMMB(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TOutputTerm GFDBHDFJMLO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm HKAHIMCCJLB(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TOutputTerm GFDBHDFJMLO);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm DAAIJFCFNPD(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TOutputTerm GFDBHDFJMLO);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm CNELFPDOBNB(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TOutputTerm GFDBHDFJMLO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm PILMKNJDGKL(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TOutputSubstitution GDHLHCIBFHA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm OIMFCOOPCBB(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TOutputSubstitution GDHLHCIBFHA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm HNPGMDDCIHL(TRoot FECENBBKPOP, TUnification DPPPNHOHMJG, TTerm HJAHAJHPMMI);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DDOJJEHGFJA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::BOOENJJLIFG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D8D00", Offset = "0x6D7500", VA = "0x1806D8D00")]
	public static global::DDOJJEHGFJA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> HHEHBEMBBBF()
	{
		return default(global::DDOJJEHGFJA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HPJEDFIBFEK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class KFHCLHKCDHK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::BOOENJJLIFG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class MKHDGJIHFPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot GOKJGEHOFEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps EJDMNPDMICA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification GEFEOCKPMGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph EAHLMKHIBOG;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public HBMFCOKANHJ JEKCANMPKAO
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x2FB2500", Offset = "0x2FB0D00", VA = "0x182FB2500")]
				get
				{
					return default(HBMFCOKANHJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2FB4010", Offset = "0x2FB2810", VA = "0x182FB4010")]
			private MKHDGJIHFPH(TRoot FECENBBKPOP, TDeps JIFFNOBMAPO, TUnification BMAJOGEOJBD, TGraph NELIICGHDHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2ED0", Offset = "0x2FB16D0", VA = "0x182FB2ED0")]
			public static MKHDGJIHFPH HHEHBEMBBBF(TRoot FECENBBKPOP, TDeps JIFFNOBMAPO, TUnification BMAJOGEOJBD, TGraph NELIICGHDHB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3AE0", Offset = "0x2FB22E0", VA = "0x182FB3AE0")]
			public TType OELEILKLBIF()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3660", Offset = "0x2FB1E60", VA = "0x182FB3660")]
			public global::LPCAKOAGKJP<TType> KDFDFAENPBC(global::LPCAKOAGKJP<TType> EHDPPFDCEJK, global::LPCAKOAGKJP<TType> NPIMFLIIAHF)
			{
				return default(global::LPCAKOAGKJP<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3F20", Offset = "0x2FB2720", VA = "0x182FB3F20")]
			public int PCMEPONNFLF(TNode KFMDDCEOFLE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2370", Offset = "0x2FB0B70", VA = "0x182FB2370")]
			public int BLNHDLIFNPD(TNode KFMDDCEOFLE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2BB0", Offset = "0x2FB13B0", VA = "0x182FB2BB0")]
			public TInput GACCGHLADFG(TNode KFMDDCEOFLE, int LHHBOCAHDEE)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3970", Offset = "0x2FB2170", VA = "0x182FB3970")]
			public int NANNLMCAKJI(TNode KFMDDCEOFLE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2920", Offset = "0x2FB1120", VA = "0x182FB2920")]
			public TOutput EJCFJIBHKEI(TNode KFMDDCEOFLE, int LHHBOCAHDEE)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2180", Offset = "0x2FB0980", VA = "0x182FB2180")]
			public IEnumerable<global::IPFEHDOGDCK<TType>> BHPDPAKIOHF(TNode KFMDDCEOFLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2E10", Offset = "0x2FB1610", VA = "0x182FB2E10")]
			public IEnumerable<global::NDCKPGBEHHL<TNode>> GJOLIJAJMOK(in TNode KFMDDCEOFLE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x2FB24C0", Offset = "0x2FB0CC0", VA = "0x182FB24C0")]
			public TType KPIBNNNHLLC(TInput JHPDOGGEPPC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x2FB30B0", Offset = "0x2FB18B0", VA = "0x182FB30B0")]
			public int HHEJOMBKHDG(TInput JHPDOGGEPPC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2FB25F0", Offset = "0x2FB0DF0", VA = "0x182FB25F0")]
			public TOutput CLCCIEOCFIF(TInput JHPDOGGEPPC, int LHHBOCAHDEE)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3180", Offset = "0x2FB1980", VA = "0x182FB3180")]
			public TNode HNCLEJKMEML(TInput JHPDOGGEPPC)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2FB24C0", Offset = "0x2FB0CC0", VA = "0x182FB24C0")]
			public TType BNPJGPLJOCN(TOutput NJOLPIOOJHP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2DD0", Offset = "0x2FB15D0", VA = "0x182FB2DD0")]
			public int GHPEHBOFPMC(TOutput NJOLPIOOJHP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2A90", Offset = "0x2FB1290", VA = "0x182FB2A90")]
			public TInput EPDMNEFJIOA(TOutput NJOLPIOOJHP, int LHHBOCAHDEE)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3180", Offset = "0x2FB1980", VA = "0x182FB3180")]
			public TNode ICOFGANBCDC(TOutput NJOLPIOOJHP)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3A30", Offset = "0x2FB2230", VA = "0x182FB3A30")]
			public bool NJBCMMOPJFD(TType EHPFPOFFCEJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2150", Offset = "0x2FB0950", VA = "0x182FB2150")]
			public TType AGMHNEGBHKP(TType EHPFPOFFCEJ, IEnumerable<TType> GDBAICMBLGE)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2FB36B0", Offset = "0x2FB1EB0", VA = "0x182FB36B0")]
			public void KFDMOLCMIPB(TType EHPFPOFFCEJ, Action<TType> CGNHPABFGIH, Action<TType> BAIPLDPNCEC, Action<TType> HCLFCBFPDKA, Action<TType> IHCMMGLPKPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3420", Offset = "0x2FB1C20", VA = "0x182FB3420")]
			public TType JDILABICENI(TType EHPFPOFFCEJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3450", Offset = "0x2FB1C50", VA = "0x182FB3450")]
			public string JGHLFKIKNGG(TType EHPFPOFFCEJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2C90", Offset = "0x2FB1490", VA = "0x182FB2C90")]
			public TTerm GFEPIJEJANG()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2860", Offset = "0x2FB1060", VA = "0x182FB2860")]
			public TTerm EAMALIOKMIE(TTerm HJAHAJHPMMI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2240", Offset = "0x2FB0A40", VA = "0x182FB2240")]
			public TTerm BIAMEOHFOND(TTerm AOKNACFHLEG, TTerm LNDILOLNLJO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3CA0", Offset = "0x2FB24A0", VA = "0x182FB3CA0")]
			public void OOADNNKHKHB(TTerm EHDPPFDCEJK, TTerm NPIMFLIIAHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2FB38B0", Offset = "0x2FB20B0", VA = "0x182FB38B0")]
			public bool KONCMJKOMMB(TOutputTerm HJAHAJHPMMI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2FB2B80", Offset = "0x2FB1380", VA = "0x182FB2B80")]
			public bool EPGPPGAPNGA(TOutputTerm HJAHAJHPMMI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3DD0", Offset = "0x2FB25D0", VA = "0x182FB3DD0")]
			public TTerm OPDGKNBBBFH(TOutputTerm GFDBHDFJMLO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2FB27A0", Offset = "0x2FB0FA0", VA = "0x182FB27A0")]
			public TOutputTerm DAAIJFCFNPD(TOutputTerm HJAHAJHPMMI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2FB26E0", Offset = "0x2FB0EE0", VA = "0x182FB26E0")]
			public TOutputTerm CNELFPDOBNB(TOutputTerm HJAHAJHPMMI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3FE0", Offset = "0x2FB27E0", VA = "0x182FB3FE0")]
			public TTerm PILMKNJDGKL(TOutputSubstitution JBLIECCEPAP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3C70", Offset = "0x2FB2470", VA = "0x182FB3C70")]
			public TOutputTerm OIMFCOOPCBB(TOutputSubstitution JBLIECCEPAP)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2FB3250", Offset = "0x2FB1A50", VA = "0x182FB3250")]
			public TOutputTerm HNPGMDDCIHL(TTerm HJAHAJHPMMI)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class PELAEONNGEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public MKHDGJIHFPH arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
			public PELAEONNGEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2F09950", Offset = "0x2F08150", VA = "0x182F09950")]
			internal int <GenerateConstraintsForNode>b__0(MKHDGJIHFPH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2F099D0", Offset = "0x2F081D0", VA = "0x182F099D0")]
			internal TInput <GenerateConstraintsForNode>b__1(MKHDGJIHFPH arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x2F09A30", Offset = "0x2F08230", VA = "0x182F09A30")]
			internal int <GenerateConstraintsForNode>b__3(MKHDGJIHFPH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2F09AB0", Offset = "0x2F082B0", VA = "0x182F09AB0")]
			internal TOutput <GenerateConstraintsForNode>b__4(MKHDGJIHFPH arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IFBDJAEPBJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public MKHDGJIHFPH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, global::KHMOLPBFJMK<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<global::KHMOLPBFJMK<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
			public IFBDJAEPBJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x180FB80", Offset = "0x180E380", VA = "0x18180FB80")]
			internal (string, TTerm) <IdentifyTypeParameters>b__0(global::IPFEHDOGDCK<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FPDJGJLDMOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public MKHDGJIHFPH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
			public FPDJGJLDMOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x299A1B0", Offset = "0x29989B0", VA = "0x18299A1B0")]
			internal void <GetTypeUnificationTerm>b__0(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x299A6F0", Offset = "0x2998EF0", VA = "0x18299A6F0")]
			internal void <GetTypeUnificationTerm>b__1(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x299A8C0", Offset = "0x29990C0", VA = "0x18299A8C0")]
			internal void <GetTypeUnificationTerm>b__2(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x299AB80", Offset = "0x2999380", VA = "0x18299AB80")]
			internal void <GetTypeUnificationTerm>b__3(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BENFIMLPCGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public MKHDGJIHFPH arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1063840", Offset = "0x1062040", VA = "0x181063840")]
			public BENFIMLPCGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x2724440", Offset = "0x2722C40", VA = "0x182724440")]
			internal TTerm <GetTypeParameterAssignments>b__1(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x25F7B90", Offset = "0x25F6390", VA = "0x1825F7B90")]
		private static JEPNGMEPEAB HJFABJCBIFG([CallerMemberName] string LOIAMCEJAFO = "")
		{
			return default(JEPNGMEPEAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x25FA6C0", Offset = "0x25F8EC0", VA = "0x1825FA6C0")]
		public static Dictionary<TNode, List<global::IPFEHDOGDCK<TType>>> LMDFIKFODDK(TRoot FECENBBKPOP, TDeps JIFFNOBMAPO, TGraph NELIICGHDHB, IEnumerable<TNode> MIJLLPHEMKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x25FF250", Offset = "0x25FDA50", VA = "0x1825FF250")]
		private static (Dictionary<TTerm, global::KHMOLPBFJMK<TNode>>, List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>>) MILGPFAMLAF(IEnumerable<TNode> MIJLLPHEMKA, MKHDGJIHFPH CBHLECKANBK)
		{
			return default((Dictionary<TTerm, global::KHMOLPBFJMK<TNode>>, List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x25FD9E0", Offset = "0x25FC1E0", VA = "0x1825FD9E0")]
		private static void MDNLADMENJN(TNode KFMDDCEOFLE, Dictionary<TInput, TTerm> ECHDJECLIJP, Dictionary<TOutput, TTerm> NIJDFHCGNFF, Dictionary<TTerm, global::KHMOLPBFJMK<TNode>> OICFABNLABP, Dictionary<global::KHMOLPBFJMK<TNode>, TTerm> BBPOEKHCOCF, List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> IJNMBHGDBGC, Stack<TNode> NEAADMAFEDL, List<global::NDCKPGBEHHL<TNode>> DGKKGBBICJB, MKHDGJIHFPH CBHLECKANBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x25F7C10", Offset = "0x25F6410", VA = "0x1825F7C10")]
		private static Dictionary<string, TTerm> HOJGFJOGAGI(TNode KFMDDCEOFLE, Dictionary<TTerm, global::KHMOLPBFJMK<TNode>> OICFABNLABP, Dictionary<global::KHMOLPBFJMK<TNode>, TTerm> JPDDOPENMKN, List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> IJNMBHGDBGC, MKHDGJIHFPH CBHLECKANBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x21C35A0", Offset = "0x21C1DA0", VA = "0x1821C35A0")]
		private static (TPort, TTerm)[] DCGINNOANIN<TPort>(TNode KFMDDCEOFLE, Func<MKHDGJIHFPH, TNode, int> JKKCDHIEBML, Func<MKHDGJIHFPH, TNode, int, TPort> GNJBKBKGPPH, Func<MKHDGJIHFPH, TPort, TType> KCLELLJCJFM, Dictionary<TPort, TTerm> HCHAADAOHDK, MKHDGJIHFPH CBHLECKANBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x25F6250", Offset = "0x25F4A50", VA = "0x1825F6250")]
		private static (TTerm, TTerm) FAAKIHJCFIE((TOutput Output, TTerm Id)[] HFPHDDBHGGP, List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> IJNMBHGDBGC, Dictionary<string, TTerm> JPDDOPENMKN, Stack<TNode> NEAADMAFEDL, MKHDGJIHFPH CBHLECKANBK)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x25FC010", Offset = "0x25FA810", VA = "0x1825FC010")]
		private static void MAJIPJGCEDG((TInput PortKey, TTerm Id)[] BGHEOPBGGFM, TTerm CHENDFGOCGL, TTerm PFMEANBOLCG, List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> IJNMBHGDBGC, Dictionary<TOutput, TTerm> NIJDFHCGNFF, Dictionary<string, TTerm> JPDDOPENMKN, Stack<TNode> NEAADMAFEDL, MKHDGJIHFPH CBHLECKANBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x25F4650", Offset = "0x25F2E50", VA = "0x1825F4650")]
		private static TTerm ECGBGEDAMJK(TInput JHPDOGGEPPC, List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> IJNMBHGDBGC, Dictionary<TOutput, TTerm> NIJDFHCGNFF, Stack<TNode> NEAADMAFEDL, MKHDGJIHFPH CBHLECKANBK)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x25F40B0", Offset = "0x25F28B0", VA = "0x1825F40B0")]
		private static TTerm DMMADEIMKHH(in TType EHPFPOFFCEJ, IOKind EBPNOEJPOCM, List<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> IJNMBHGDBGC, IReadOnlyDictionary<string, TTerm> JPDDOPENMKN, MKHDGJIHFPH CBHLECKANBK)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2600970", Offset = "0x25FF170", VA = "0x182600970")]
		private static Dictionary<TNode, List<global::IPFEHDOGDCK<TType>>> MMCPDDMMDBK(TOutputSubstitution[] FNAGEKECPEA, Dictionary<TTerm, global::KHMOLPBFJMK<TNode>> OICFABNLABP, IEnumerable<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> IJNMBHGDBGC, MKHDGJIHFPH CBHLECKANBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x25F8320", Offset = "0x25F6B20", VA = "0x1825F8320")]
		private static Dictionary<TNode, List<global::IPFEHDOGDCK<TType>>> ICENMHHJCOJ(Dictionary<TTerm, global::KHMOLPBFJMK<TNode>> OICFABNLABP, MKHDGJIHFPH CBHLECKANBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x25F38F0", Offset = "0x25F20F0", VA = "0x1825F38F0")]
		private static void DFOIGCFBNHI(in TNode KFMDDCEOFLE, Stack<TNode> NEAADMAFEDL, List<global::NDCKPGBEHHL<TNode>> DGKKGBBICJB, MKHDGJIHFPH CBHLECKANBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x26019D0", Offset = "0x26001D0", VA = "0x1826019D0")]
		private static void NKONNAHKHEB(Dictionary<global::KHMOLPBFJMK<TNode>, TTerm> JPDDOPENMKN, List<global::NDCKPGBEHHL<TNode>> DGKKGBBICJB, MKHDGJIHFPH CBHLECKANBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x25F9700", Offset = "0x25F7F00", VA = "0x1825F9700")]
		private static Dictionary<TTerm, TType> IGPALJNKFJP(Dictionary<TTerm, TOutputSubstitution> FNAGEKECPEA, IEnumerable<KeyValuePair<TTerm, global::LPCAKOAGKJP<TType>>> IJNMBHGDBGC, MKHDGJIHFPH CBHLECKANBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x25F50A0", Offset = "0x25F38A0", VA = "0x1825F50A0")]
		private static global::PLKADEAGMGD<TType> EPMJEEKLIND(TOutputTerm EHPFPOFFCEJ, Dictionary<TTerm, TType> IJNMBHGDBGC, Dictionary<TTerm, TType> KOOFLAHMFBG, MKHDGJIHFPH CBHLECKANBK)
		{
			return default(global::PLKADEAGMGD<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x25F3540", Offset = "0x25F1D40", VA = "0x1825F3540")]
		private static TOutputTerm AIPDIBNGMOD(TOutputTerm JDNPLEBHNNL, MKHDGJIHFPH CBHLECKANBK)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2567690", Offset = "0x2565E90", VA = "0x182567690")]
	public static Dictionary<TNode, List<global::IPFEHDOGDCK<TType>>> LMDFIKFODDK<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>(this in global::DDOJJEHGFJA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DCJNPPINKOA, TRoot FECENBBKPOP, TGraph NELIICGHDHB, IEnumerable<TNode> MIJLLPHEMKA) where TDeps : global::BOOENJJLIFG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IPFEHDOGDCK<TType> : IEquatable<global::IPFEHDOGDCK<TType>>, global::CJAAPIKJAAB<global::IPFEHDOGDCK<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ILMHEGPAEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType KNIEPLPJDHN;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27FF5E0", Offset = "0x27FDDE0", VA = "0x1827FF5E0")]
	internal IPFEHDOGDCK(string LOIAMCEJAFO, in TType PLCOAAKLOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x360BF20", Offset = "0x360A720", VA = "0x18360BF20")]
	public bool HNNAGFAIMMF(in global::IPFEHDOGDCK<TType> HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x360BED0", Offset = "0x360A6D0", VA = "0x18360BED0", Slot = "4")]
	public bool Equals(global::IPFEHDOGDCK<TType> HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2608EA0", Offset = "0x26076A0", VA = "0x182608EA0", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7839B0", Offset = "0x7821B0", VA = "0x1807839B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x360C000", Offset = "0x360A800", VA = "0x18360C000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x360BE80", Offset = "0x360A680", VA = "0x18360BE80", Slot = "5")]
	private bool DEDNIEHOPOB(in global::IPFEHDOGDCK<TType> HAKPJJGEGOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BAOOBKGNCKB
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x23DC540", Offset = "0x23DAD40", VA = "0x1823DC540")]
	public static global::IPFEHDOGDCK<TType> HHEHBEMBBBF<TType>(string LOIAMCEJAFO, TType PLCOAAKLOGF)
	{
		return default(global::IPFEHDOGDCK<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x23DC570", Offset = "0x23DAD70", VA = "0x1823DC570")]
	public static (string, TType) PFLAHKOKNME<TType>(this in global::IPFEHDOGDCK<TType> DCJNPPINKOA)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct KHMOLPBFJMK<TNode> : IEquatable<global::KHMOLPBFJMK<TNode>>, global::CJAAPIKJAAB<global::KHMOLPBFJMK<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode NPIHEILHLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string ILMHEGPAEKG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7000B0", Offset = "0x6FE8B0", VA = "0x1807000B0")]
	internal KHMOLPBFJMK(TNode KFMDDCEOFLE, string LOIAMCEJAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2609010", Offset = "0x2607810", VA = "0x182609010")]
	public bool HNNAGFAIMMF(in global::KHMOLPBFJMK<TNode> HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2608E50", Offset = "0x2607650", VA = "0x182608E50", Slot = "4")]
	public bool Equals(global::KHMOLPBFJMK<TNode> HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2608EA0", Offset = "0x26076A0", VA = "0x182608EA0", Slot = "0")]
	public override bool Equals(object HAKPJJGEGOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2608F80", Offset = "0x2607780", VA = "0x182608F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x2609270", Offset = "0x2607A70", VA = "0x182609270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x2609220", Offset = "0x2607A20", VA = "0x182609220", Slot = "5")]
	private bool NADMIABELGE(in global::KHMOLPBFJMK<TNode> HAKPJJGEGOM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EDBAJFGIEMB
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x14A79B0", Offset = "0x14A61B0", VA = "0x1814A79B0")]
	public static global::KHMOLPBFJMK<TNode> HHEHBEMBBBF<TNode>(TNode KFMDDCEOFLE, string LOIAMCEJAFO)
	{
		return default(global::KHMOLPBFJMK<TNode>);
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
