using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LNPOEGJJINB<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType MEBDELDBDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind JDNOBHHPMNC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x18D3A40", Offset = "0x18D2C40", VA = "0x1818D3A40")]
	internal LNPOEGJJINB(TType MJMAEGDPBNJ, IOKind MMKFDKKNOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D689C0", Offset = "0x3D67BC0", VA = "0x183D689C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MKOJHPJBAPN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2953820", Offset = "0x2952A20", VA = "0x182953820")]
	public static LNPOEGJJINB<TType> DHBNKMCPKNO<TType>(TType MJMAEGDPBNJ, IOKind MMKFDKKNOCI)
	{
		return default(LNPOEGJJINB<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2953850", Offset = "0x2952A50", VA = "0x182953850")]
	public static (TType, IOKind) DKJGBLAKLJH<TType>([In] this LNPOEGJJINB<TType> AOFIGDLFNLH)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2953890", Offset = "0x2952A90", VA = "0x182953890")]
	public static void EHCLCENNOFJ<TType>([In] this LNPOEGJJINB<TType> AOFIGDLFNLH, [Out] TType MJMAEGDPBNJ, [Out] IOKind MMKFDKKNOCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct JCEBBDPAHAI<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MOKHADJFGFB<TNode> HMAALLJIBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MOKHADJFGFB<TNode> LOCFLDBPILI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3BEB900", Offset = "0x3BEAB00", VA = "0x183BEB900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EJPDMJGIHDF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2743110", Offset = "0x2742310", VA = "0x182743110")]
	public static (MOKHADJFGFB<TNode>, MOKHADJFGFB<TNode>) DKJGBLAKLJH<TNode>([In] this JCEBBDPAHAI<TNode> AOFIGDLFNLH)
	{
		return default((MOKHADJFGFB<TNode>, MOKHADJFGFB<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27431B0", Offset = "0x27423B0", VA = "0x1827431B0")]
	public static void EHCLCENNOFJ<TNode>([In] this JCEBBDPAHAI<TNode> AOFIGDLFNLH, [Out] MOKHADJFGFB<TNode> EAIBKNOIIGG, [Out] MOKHADJFGFB<TNode> PKGAILNKPEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LNJPLDAOLEC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAIGMKJOFGH PIDMFKJIDGH(TRoot MFIBAFBMCBA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType DHEIABIMIII(TRoot MFIBAFBMCBA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LNPOEGJJINB<TType> BDOMJFGOCFG(TRoot MFIBAFBMCBA, [In] LNPOEGJJINB<TType> DEHAFGPDPHM, [In] LNPOEGJJINB<TType> FAFKEFEMLFH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ELEDMOOMCEO(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TNode JCCACJKHFKB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IGJPJAFGMAH(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TNode JCCACJKHFKB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput FKMHOABEFBD(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TNode JCCACJKHFKB, int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BAPEPNGOEMC(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TNode JCCACJKHFKB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput FFIDBIJENEI(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TNode JCCACJKHFKB, int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<FJEMIMEEACD<TType>> HIENKDDCAKA(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TNode JCCACJKHFKB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<JCEBBDPAHAI<TNode>> FCNOMKCJENI(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TNode JCCACJKHFKB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NGEAGKLFEAO(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TInput BHCBEHDFPNA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int DPDLJFNJCFM(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TInput BHCBEHDFPNA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput NPMECPCCJCC(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TInput BHCBEHDFPNA, int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode CBLLBMEOPAJ(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TInput BHCBEHDFPNA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType HGJJAOKNBOD(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TOutput OCMENJCDIMP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int MBEEBDONLNC(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TOutput OCMENJCDIMP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput LLIKKHOJNOA(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TOutput OCMENJCDIMP, int MBGANDEDPDN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode KAPIPKHFBFL(TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, TOutput OCMENJCDIMP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HJBJNIEGIHE(TRoot MFIBAFBMCBA, TType MJMAEGDPBNJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType EJCAFIOANGI(TRoot MFIBAFBMCBA, TType MJMAEGDPBNJ, IEnumerable<TType> ENDONMBPFHO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JMLJLKONNFB(TRoot MFIBAFBMCBA, TType MJMAEGDPBNJ, Action<TType> DMJDGOIPKAO, Action<TType> NHLPLJCDNGE, Action<TType> HMBHPNEKFKG, Action<TType> IOPJACPGMNA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType ENOGJNIIEJJ(TRoot MFIBAFBMCBA, TType MJMAEGDPBNJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string HCMMGCBGBKF(TRoot MFIBAFBMCBA, TType MJMAEGDPBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification BFCNDIBFDHG(TRoot MFIBAFBMCBA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OAAHAKNOJDO<TOutputSubstitution[], EPJKOMMHEAH> MBCMGDOEAHM(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm FNFHBAGLGMF(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm NACKAEJJKFA(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TTerm LOJLOEKHHOD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm OJFCFCFFCKB(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TTerm BOAMPKDFKLM, TTerm JFGPAIHHEJK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GNIKJNKBAIJ(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TTerm DEHAFGPDPHM, TTerm FAFKEFEMLFH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool DCPPLFFALKE(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TOutputTerm PNMLIDEOLBJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DBONIMJEONP(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TOutputTerm PNMLIDEOLBJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm EMJEJCLALDJ(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TOutputTerm PNMLIDEOLBJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm JHFAJCDLELP(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TOutputTerm PNMLIDEOLBJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm DLKNOJIHANC(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TOutputTerm PNMLIDEOLBJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm ENAHGOCOGJA(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TOutputSubstitution OGCAHHCAGON);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm GJFINFFHOMA(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TOutputSubstitution OGCAHHCAGON);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm IDGCJFAGIGA(TRoot MFIBAFBMCBA, TUnification AGENIPJGCEL, TTerm LOJLOEKHHOD);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CADGOBGGJEG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::LNJPLDAOLEC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90")]
	public static global::CADGOBGGJEG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DHBNKMCPKNO()
	{
		return default(global::CADGOBGGJEG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PNOFAMPKNAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class POPIPCNCENK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::LNJPLDAOLEC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class PDEBADAKJAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot NECEBBLCHMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps ODBKJNALJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification IECCGEGCDPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph BCADKKKHNIA;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public HAIGMKJOFGH MIKOPGKGMGF
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x419AB30", Offset = "0x4199D30", VA = "0x18419AB30")]
				get
				{
					return default(HAIGMKJOFGH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x419C260", Offset = "0x419B460", VA = "0x18419C260")]
			private PDEBADAKJAE(TRoot MFIBAFBMCBA, TDeps OAENIJAKBHE, TUnification KJELNJHGKLJ, TGraph AOFKLCLPNLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x419A1C0", Offset = "0x41993C0", VA = "0x18419A1C0")]
			public static PDEBADAKJAE DHBNKMCPKNO(TRoot MFIBAFBMCBA, TDeps OAENIJAKBHE, TUnification KJELNJHGKLJ, TGraph AOFKLCLPNLP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x419A2B0", Offset = "0x41994B0", VA = "0x18419A2B0")]
			public TType DHEIABIMIII()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4199B60", Offset = "0x4198D60", VA = "0x184199B60")]
			public LNPOEGJJINB<TType> BDOMJFGOCFG(LNPOEGJJINB<TType> DEHAFGPDPHM, LNPOEGJJINB<TType> FAFKEFEMLFH)
			{
				return default(LNPOEGJJINB<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x419A650", Offset = "0x4199850", VA = "0x18419A650")]
			public int ELEDMOOMCEO(TNode JCCACJKHFKB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x419B660", Offset = "0x419A860", VA = "0x18419B660")]
			public int IGJPJAFGMAH(TNode JCCACJKHFKB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x419AB90", Offset = "0x4199D90", VA = "0x18419AB90")]
			public TInput FKMHOABEFBD(TNode JCCACJKHFKB, int MBGANDEDPDN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x41999C0", Offset = "0x4198BC0", VA = "0x1841999C0")]
			public int BAPEPNGOEMC(TNode JCCACJKHFKB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x419A9A0", Offset = "0x4199BA0", VA = "0x18419A9A0")]
			public TOutput FFIDBIJENEI(TNode JCCACJKHFKB, int MBGANDEDPDN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x419B410", Offset = "0x419A610", VA = "0x18419B410")]
			public IEnumerable<FJEMIMEEACD<TType>> HIENKDDCAKA(TNode JCCACJKHFKB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x419A8C0", Offset = "0x4199AC0", VA = "0x18419A8C0")]
			public IEnumerable<JCEBBDPAHAI<TNode>> FCNOMKCJENI([In] TNode JCCACJKHFKB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x419BD40", Offset = "0x419AF40", VA = "0x18419BD40")]
			public TType NGEAGKLFEAO(TInput BHCBEHDFPNA)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4199DA0", Offset = "0x4198FA0", VA = "0x184199DA0")]
			public int CLEGIPHLGPE(TInput BHCBEHDFPNA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x419BFF0", Offset = "0x419B1F0", VA = "0x18419BFF0")]
			public TOutput NPMECPCCJCC(TInput BHCBEHDFPNA, int MBGANDEDPDN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4199BC0", Offset = "0x4198DC0", VA = "0x184199BC0")]
			public TNode CBLLBMEOPAJ(TInput BHCBEHDFPNA)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x419B310", Offset = "0x419A510", VA = "0x18419B310")]
			public TType HGJJAOKNBOD(TOutput OCMENJCDIMP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x419BE50", Offset = "0x419B050", VA = "0x18419BE50")]
			public int NOOLEJJCDKB(TOutput OCMENJCDIMP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x419BB70", Offset = "0x419AD70", VA = "0x18419BB70")]
			public TInput LLIKKHOJNOA(TOutput OCMENJCDIMP, int MBGANDEDPDN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x419B9D0", Offset = "0x419ABD0", VA = "0x18419B9D0")]
			public TNode KAPIPKHFBFL(TOutput OCMENJCDIMP)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x419B450", Offset = "0x419A650", VA = "0x18419B450")]
			public bool HJBJNIEGIHE(TType MJMAEGDPBNJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x419A550", Offset = "0x4199750", VA = "0x18419A550")]
			public TType EJCAFIOANGI(TType MJMAEGDPBNJ, IEnumerable<TType> ENDONMBPFHO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x419B970", Offset = "0x419AB70", VA = "0x18419B970")]
			public void JMLJLKONNFB(TType MJMAEGDPBNJ, Action<TType> DMJDGOIPKAO, Action<TType> NHLPLJCDNGE, Action<TType> HMBHPNEKFKG, Action<TType> IOPJACPGMNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x419A750", Offset = "0x4199950", VA = "0x18419A750")]
			public TType ENOGJNIIEJJ(TType MJMAEGDPBNJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x419B0F0", Offset = "0x419A2F0", VA = "0x18419B0F0")]
			public string HCMMGCBGBKF(TType MJMAEGDPBNJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x419AD80", Offset = "0x4199F80", VA = "0x18419AD80")]
			public TTerm FNFHBAGLGMF()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x419BC80", Offset = "0x419AE80", VA = "0x18419BC80")]
			public TTerm NACKAEJJKFA(TTerm LOJLOEKHHOD)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x419C0C0", Offset = "0x419B2C0", VA = "0x18419C0C0")]
			public TTerm OJFCFCFFCKB(TTerm BOAMPKDFKLM, TTerm JFGPAIHHEJK)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x419AFC0", Offset = "0x419A1C0", VA = "0x18419AFC0")]
			public void GNIKJNKBAIJ(TTerm DEHAFGPDPHM, TTerm FAFKEFEMLFH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4199EA0", Offset = "0x41990A0", VA = "0x184199EA0")]
			public bool DBONIMJEONP(TOutputTerm LOJLOEKHHOD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4199EE0", Offset = "0x41990E0", VA = "0x184199EE0")]
			public bool DCPPLFFALKE(TOutputTerm LOJLOEKHHOD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x419AE80", Offset = "0x419A080", VA = "0x18419AE80")]
			public TTerm GEEHCHDNKJG(TOutputTerm PNMLIDEOLBJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x419B760", Offset = "0x419A960", VA = "0x18419B760")]
			public TOutputTerm JHFAJCDLELP(TOutputTerm LOJLOEKHHOD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x419A490", Offset = "0x4199690", VA = "0x18419A490")]
			public TOutputTerm DLKNOJIHANC(TOutputTerm LOJLOEKHHOD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x419A690", Offset = "0x4199890", VA = "0x18419A690")]
			public TTerm ENAHGOCOGJA(TOutputSubstitution ANJDJOPLHLK)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x419AF40", Offset = "0x419A140", VA = "0x18419AF40")]
			public TOutputTerm GJFINFFHOMA(TOutputSubstitution ANJDJOPLHLK)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x419B620", Offset = "0x419A820", VA = "0x18419B620")]
			public TOutputTerm IDGCJFAGIGA(TTerm LOJLOEKHHOD)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FIAGFHAAGPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PDEBADAKJAE arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public FIAGFHAAGPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3781180", Offset = "0x3780380", VA = "0x183781180")]
			internal int NAMFEJOCDHE(PDEBADAKJAE arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3781060", Offset = "0x3780260", VA = "0x183781060")]
			internal TInput JLAKOBDOOIA(PDEBADAKJAE arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3781240", Offset = "0x3780440", VA = "0x183781240")]
			internal int OAGEBFDEPAG(PDEBADAKJAE arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3780F40", Offset = "0x3780140", VA = "0x183780F40")]
			internal TOutput AGPPJLFLFIC(PDEBADAKJAE arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EOODNMFKOBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public PDEBADAKJAE arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, MOKHADJFGFB<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<MOKHADJFGFB<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public EOODNMFKOBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x342F990", Offset = "0x342EB90", VA = "0x18342F990")]
			internal (string, TTerm) OOGCPAANFAK(FJEMIMEEACD<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class CDGKJKPFLPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PDEBADAKJAE arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public CDGKJKPFLPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4939EF0", Offset = "0x49390F0", VA = "0x184939EF0")]
			internal void IIIHFCGIGHF(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x493A650", Offset = "0x4939850", VA = "0x18493A650")]
			internal void LLFJJJOOOFN(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x493A4B0", Offset = "0x49396B0", VA = "0x18493A4B0")]
			internal void JADMHAKMAID(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x493A9F0", Offset = "0x4939BF0", VA = "0x18493A9F0")]
			internal void MAKMHEMBBIH(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JNHFLFMGFNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PDEBADAKJAE arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
			public JNHFLFMGFNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x38BF420", Offset = "0x38BE620", VA = "0x1838BF420")]
			internal TTerm NHFNIJACJNJ(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x41C7290", Offset = "0x41C6490", VA = "0x1841C7290")]
		private static MFGMNPGBIHL NPAGFKKICLC([CallerMemberName] string MPENHPFDCDK = "")
		{
			return default(MFGMNPGBIHL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x41C38F0", Offset = "0x41C2AF0", VA = "0x1841C38F0")]
		public static Dictionary<TNode, List<FJEMIMEEACD<TType>>> LAGKBEBFAEJ(TRoot MFIBAFBMCBA, TDeps OAENIJAKBHE, TGraph AOFKLCLPNLP, IEnumerable<TNode> MCMNPMKHJJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x41C5130", Offset = "0x41C4330", VA = "0x1841C5130")]
		private static (Dictionary<TTerm, MOKHADJFGFB<TNode>>, List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>>) MLFGNHEPCEJ(IEnumerable<TNode> MCMNPMKHJJL, PDEBADAKJAE INFIIIMCAKM)
		{
			return default((Dictionary<TTerm, MOKHADJFGFB<TNode>>, List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x41C5B60", Offset = "0x41C4D60", VA = "0x1841C5B60")]
		private static void MMLIIFJGEGB(TNode JCCACJKHFKB, Dictionary<TInput, TTerm> MFLHMKGEJPL, Dictionary<TOutput, TTerm> CCHNINIMOEA, Dictionary<TTerm, MOKHADJFGFB<TNode>> CJAIJEPMFDM, Dictionary<MOKHADJFGFB<TNode>, TTerm> DGFAHAHOCLP, List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> OOEIJLFKMGG, Stack<TNode> CJKBPAMLMNA, List<JCEBBDPAHAI<TNode>> PDOAAIAACFH, PDEBADAKJAE INFIIIMCAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x41C3610", Offset = "0x41C2810", VA = "0x1841C3610")]
		private static Dictionary<string, TTerm> KMKFINENADB(TNode JCCACJKHFKB, Dictionary<TTerm, MOKHADJFGFB<TNode>> CJAIJEPMFDM, Dictionary<MOKHADJFGFB<TNode>, TTerm> MHKDPKFGEIL, List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> OOEIJLFKMGG, PDEBADAKJAE INFIIIMCAKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x283BFB0", Offset = "0x283B1B0", VA = "0x18283BFB0")]
		private static (TPort, TTerm)[] EFCEIOEJPJK<TPort>(TNode JCCACJKHFKB, Func<PDEBADAKJAE, TNode, int> PFGJEKDMFIK, Func<PDEBADAKJAE, TNode, int, TPort> BMFBHAALIEI, Func<PDEBADAKJAE, TPort, TType> GCPEDHAFIEB, Dictionary<TPort, TTerm> FBAPMLNPLPB, PDEBADAKJAE INFIIIMCAKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x41C66C0", Offset = "0x41C58C0", VA = "0x1841C66C0")]
		private static (TTerm, TTerm) NJLHGOGALNO((TOutput Output, TTerm Id)[] JDEIDENAEGI, List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> OOEIJLFKMGG, Dictionary<string, TTerm> MHKDPKFGEIL, Stack<TNode> CJKBPAMLMNA, PDEBADAKJAE INFIIIMCAKM)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x41C45A0", Offset = "0x41C37A0", VA = "0x1841C45A0")]
		private static void MBIMFNJIABB((TInput PortKey, TTerm Id)[] BIFMLIGMEOK, TTerm BDBHJLOOAPB, TTerm BEJJIAMJHND, List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> OOEIJLFKMGG, Dictionary<TOutput, TTerm> CCHNINIMOEA, Dictionary<string, TTerm> MHKDPKFGEIL, Stack<TNode> CJKBPAMLMNA, PDEBADAKJAE INFIIIMCAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x41C2760", Offset = "0x41C1960", VA = "0x1841C2760")]
		private static TTerm IJMLPBOOEOC(TInput BHCBEHDFPNA, List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> OOEIJLFKMGG, Dictionary<TOutput, TTerm> CCHNINIMOEA, Stack<TNode> CJKBPAMLMNA, PDEBADAKJAE INFIIIMCAKM)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x41C30A0", Offset = "0x41C22A0", VA = "0x1841C30A0")]
		private static TTerm KACBGPNCGOD([In] TType MJMAEGDPBNJ, IOKind MMKFDKKNOCI, List<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> OOEIJLFKMGG, IReadOnlyDictionary<string, TTerm> MHKDPKFGEIL, PDEBADAKJAE INFIIIMCAKM)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x41C72D0", Offset = "0x41C64D0", VA = "0x1841C72D0")]
		private static Dictionary<TNode, List<FJEMIMEEACD<TType>>> PLBLHIIKCKK(TOutputSubstitution[] JNCNGICOAGM, Dictionary<TTerm, MOKHADJFGFB<TNode>> CJAIJEPMFDM, IEnumerable<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> OOEIJLFKMGG, PDEBADAKJAE INFIIIMCAKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x41C1EF0", Offset = "0x41C10F0", VA = "0x1841C1EF0")]
		private static Dictionary<TNode, List<FJEMIMEEACD<TType>>> EJIKMCCAAJO(Dictionary<TTerm, MOKHADJFGFB<TNode>> CJAIJEPMFDM, PDEBADAKJAE INFIIIMCAKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x41C2340", Offset = "0x41C1540", VA = "0x1841C2340")]
		private static void FGNGFLLALGO([In] TNode JCCACJKHFKB, Stack<TNode> CJKBPAMLMNA, List<JCEBBDPAHAI<TNode>> PDOAAIAACFH, PDEBADAKJAE INFIIIMCAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x41C2C10", Offset = "0x41C1E10", VA = "0x1841C2C10")]
		private static void JCMKFCPKOMF(Dictionary<MOKHADJFGFB<TNode>, TTerm> MHKDPKFGEIL, List<JCEBBDPAHAI<TNode>> PDOAAIAACFH, PDEBADAKJAE INFIIIMCAKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x41C0F70", Offset = "0x41C0170", VA = "0x1841C0F70")]
		private static Dictionary<TTerm, TType> BABLBELDBLL(Dictionary<TTerm, TOutputSubstitution> JNCNGICOAGM, IEnumerable<KeyValuePair<TTerm, LNPOEGJJINB<TType>>> OOEIJLFKMGG, PDEBADAKJAE INFIIIMCAKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x41C3E30", Offset = "0x41C3030", VA = "0x1841C3E30")]
		private static DIGJANEAKHC<TType> LAPCJGFGLCN(TOutputTerm MJMAEGDPBNJ, Dictionary<TTerm, TType> OOEIJLFKMGG, Dictionary<TTerm, TType> KFPKKDDFIOC, PDEBADAKJAE INFIIIMCAKM)
		{
			return default(DIGJANEAKHC<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x41C1D80", Offset = "0x41C0F80", VA = "0x1841C1D80")]
		private static TOutputTerm CPAIFOEEHMI(TOutputTerm DJLFNILGGKN, PDEBADAKJAE INFIIIMCAKM)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A146D0", Offset = "0x2A138D0", VA = "0x182A146D0")]
	public static Dictionary<TNode, List<FJEMIMEEACD<TType>>> LAGKBEBFAEJ<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::CADGOBGGJEG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> AOFIGDLFNLH, TRoot MFIBAFBMCBA, TGraph AOFKLCLPNLP, IEnumerable<TNode> MCMNPMKHJJL) where TDeps : global::LNJPLDAOLEC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct FJEMIMEEACD<TType> : IEquatable<FJEMIMEEACD<TType>>, JHLFGBMKOFP<FJEMIMEEACD<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string FLDBLPHJNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType OKLKGKEJCMH;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x341D960", Offset = "0x341CB60", VA = "0x18341D960")]
	internal FJEMIMEEACD(string MPENHPFDCDK, [In] TType FICDJEFAMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x37B2DD0", Offset = "0x37B1FD0", VA = "0x1837B2DD0")]
	public bool HFGJIEPGIDK([In] FJEMIMEEACD<TType> MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x37B2D00", Offset = "0x37B1F00", VA = "0x1837B2D00", Slot = "4")]
	public bool Equals(FJEMIMEEACD<TType> MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x37B2D50", Offset = "0x37B1F50", VA = "0x1837B2D50", Slot = "0")]
	public override bool Equals(object MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E55170", Offset = "0x1E54370", VA = "0x181E55170", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x37B2EF0", Offset = "0x37B20F0", VA = "0x1837B2EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x37B2EA0", Offset = "0x37B20A0", VA = "0x1837B2EA0", Slot = "5")]
	private bool PIBAHGCMFIB([In] FJEMIMEEACD<TType> MEJMHKPOODP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MFONGEDCOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x293BCD0", Offset = "0x293AED0", VA = "0x18293BCD0")]
	public static FJEMIMEEACD<TType> DHBNKMCPKNO<TType>(string MPENHPFDCDK, TType FICDJEFAMIG)
	{
		return default(FJEMIMEEACD<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x293BD00", Offset = "0x293AF00", VA = "0x18293BD00")]
	public static (string, TType) DKJGBLAKLJH<TType>([In] this FJEMIMEEACD<TType> AOFIGDLFNLH)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct MOKHADJFGFB<TNode> : IEquatable<MOKHADJFGFB<TNode>>, JHLFGBMKOFP<MOKHADJFGFB<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode KAGFLFNBIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string FLDBLPHJNKM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xC29F90", Offset = "0xC29190", VA = "0x180C29F90")]
	internal MOKHADJFGFB(TNode JCCACJKHFKB, string MPENHPFDCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3F4A930", Offset = "0x3F49B30", VA = "0x183F4A930")]
	public bool HFGJIEPGIDK([In] MOKHADJFGFB<TNode> MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3F4A870", Offset = "0x3F49A70", VA = "0x183F4A870", Slot = "4")]
	public bool Equals(MOKHADJFGFB<TNode> MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37B2D50", Offset = "0x37B1F50", VA = "0x1837B2D50", Slot = "0")]
	public override bool Equals(object MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3F4A8C0", Offset = "0x3F49AC0", VA = "0x183F4A8C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3F4AAD0", Offset = "0x3F49CD0", VA = "0x183F4AAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3F4A780", Offset = "0x3F49980", VA = "0x183F4A780", Slot = "5")]
	private bool BHCBJLODCDA([In] MOKHADJFGFB<TNode> MEJMHKPOODP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GKIDABFDPIK
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x288F900", Offset = "0x288EB00", VA = "0x18288F900")]
	public static MOKHADJFGFB<TNode> DHBNKMCPKNO<TNode>(TNode JCCACJKHFKB, string MPENHPFDCDK)
	{
		return default(MOKHADJFGFB<TNode>);
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
