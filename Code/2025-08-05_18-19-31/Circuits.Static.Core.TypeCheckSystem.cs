using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct HDKDENFIPOK<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType GBFFBDIJNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind JDLBMGIGLCL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xD42670", Offset = "0xD41A70", VA = "0x180D42670")]
	internal HDKDENFIPOK(TType IIHAKBEOLJD, IOKind LOJKBLMCGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4FADEF0", Offset = "0x4FAD2F0", VA = "0x184FADEF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PLLLCEEHMKI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2AA0", Offset = "0x3ED1EA0", VA = "0x183ED2AA0")]
	public static HDKDENFIPOK<TType> EJOLKNBPCJB<TType>(TType IIHAKBEOLJD, IOKind LOJKBLMCGKG)
	{
		return default(HDKDENFIPOK<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2A60", Offset = "0x3ED1E60", VA = "0x183ED2A60")]
	public static (TType, IOKind) BIIHFMGKAOJ<TType>([In] this HDKDENFIPOK<TType> DMFKPMONDPO)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2A00", Offset = "0x3ED1E00", VA = "0x183ED2A00")]
	public static void BBBPACNHLNO<TType>([In] this HDKDENFIPOK<TType> DMFKPMONDPO, [Out] TType IIHAKBEOLJD, [Out] IOKind LOJKBLMCGKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct JHIMIKKGPID<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BGIKILHPDIH<TNode> BJDPBIJJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BGIKILHPDIH<TNode> MDDHIEAOBHB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5328EE0", Offset = "0x53282E0", VA = "0x185328EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DBAKDBBABGD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B06090", Offset = "0x3B05490", VA = "0x183B06090")]
	public static (BGIKILHPDIH<TNode>, BGIKILHPDIH<TNode>) BIIHFMGKAOJ<TNode>([In] this JHIMIKKGPID<TNode> DMFKPMONDPO)
	{
		return default((BGIKILHPDIH<TNode>, BGIKILHPDIH<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B05FB0", Offset = "0x3B053B0", VA = "0x183B05FB0")]
	public static void BBBPACNHLNO<TNode>([In] this JHIMIKKGPID<TNode> DMFKPMONDPO, [Out] BGIKILHPDIH<TNode> JLJHECODIOL, [Out] BGIKILHPDIH<TNode> DABLONGJEGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JIHKHFNOCHI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AELMFCBMNIP PNAJOHDMFPF(TRoot LDEPDDDHLLO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType PANPELACDLC(TRoot LDEPDDDHLLO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HDKDENFIPOK<TType> BIBBPEHEMNA(TRoot LDEPDDDHLLO, [In] HDKDENFIPOK<TType> KEHFCBFJCMA, [In] HDKDENFIPOK<TType> KGECIONKOCO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PBDLCPLPMLN(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TNode BLJBPFHLMML);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GGDGJACKGKO(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TNode BLJBPFHLMML);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput KAIPLEKPMCD(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TNode BLJBPFHLMML, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DNFHIEKIKHF(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TNode BLJBPFHLMML);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput HCBIBNMLDBF(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TNode BLJBPFHLMML, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<AJEMFHBMKDB<TType>> BGACLEFOGGB(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TNode BLJBPFHLMML);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<JHIMIKKGPID<TNode>> OHCJMAMHDJD(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TNode BLJBPFHLMML);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NFIPHJFJLFP(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TInput MICKAKKPGLH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int DAFPHLCGEJN(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TInput MICKAKKPGLH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput NFBFJJLEODM(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TInput MICKAKKPGLH, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode PPBHAEKDJJE(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TInput MICKAKKPGLH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType HFOLNOMMEDA(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TOutput AHGBOFMNHGN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int IFJFGCJOGHH(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TOutput AHGBOFMNHGN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput JKOJECPBCFB(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TOutput AHGBOFMNHGN, int NOEININIMIL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode EHNMKJLELKD(TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, TOutput AHGBOFMNHGN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool ODEHMENLGIL(TRoot LDEPDDDHLLO, TType IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType AKLELMCLHDE(TRoot LDEPDDDHLLO, TType IIHAKBEOLJD, IEnumerable<TType> CFNMBNFNAJD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LLIFEKDOJIK(TRoot LDEPDDDHLLO, TType IIHAKBEOLJD, Action<TType> BBJELFHBAMM, Action<TType> OMEFHMFGFAJ, Action<TType> NKAGNOFKBJP, Action<TType> IDNIBPFBOPE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType AIKLIHAKKLJ(TRoot LDEPDDDHLLO, TType IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string HNFMLFNANNN(TRoot LDEPDDDHLLO, TType IIHAKBEOLJD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification GPAFBELCHAI(TRoot LDEPDDDHLLO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	DGHPMJAIBNO<TOutputSubstitution[], KIBOPIAKFMB> GJFMLMOGLJN(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm MFFMBKKNAOG(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm EFHAJHLFLOA(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TTerm IIPJAILALEJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm GBBOKJFHKNE(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TTerm EOHGCIHCMID, TTerm BEKKFILOPCK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void PACFMKCCLPM(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TTerm KEHFCBFJCMA, TTerm KGECIONKOCO);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool OCFMDOIGDLL(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TOutputTerm LDMJPMJNGDE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CLOGBOLPAGP(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TOutputTerm LDMJPMJNGDE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm LBFAJCLFJLJ(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TOutputTerm LDMJPMJNGDE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm PHAEOLEGBIL(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TOutputTerm LDMJPMJNGDE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm AKIAOAKFCPJ(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TOutputTerm LDMJPMJNGDE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm KIGDFOIHKFC(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TOutputSubstitution FALOIMANNCP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm MPLDFCEDHCG(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TOutputSubstitution FALOIMANNCP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm IGBMGDDFBGB(TRoot LDEPDDDHLLO, TUnification JMBMNHDJKFK, TTerm IIPJAILALEJ);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LLGDCJEJECO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::JIHKHFNOCHI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
	public static global::LLGDCJEJECO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> EJOLKNBPCJB()
	{
		return default(global::LLGDCJEJECO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DLABGINEKPG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class IDNIFEAOIMH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::JIHKHFNOCHI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class AHDPLFIAFEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot NDDFGLPMAHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps BKENNDEEOJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification MCPCFJMECAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph IJKDBFLOLAN;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public AELMFCBMNIP ODPPNLGJCKO
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x52AC0A0", Offset = "0x52AB4A0", VA = "0x1852AC0A0")]
				get
				{
					return default(AELMFCBMNIP);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x52ACF40", Offset = "0x52AC340", VA = "0x1852ACF40")]
			private AHDPLFIAFEJ(TRoot LDEPDDDHLLO, TDeps MOHOCDOOLDA, TUnification CDIKNFIEPBG, TGraph KBCGJHHFJKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x52AB070", Offset = "0x52AA470", VA = "0x1852AB070")]
			public static AHDPLFIAFEJ EJOLKNBPCJB(TRoot LDEPDDDHLLO, TDeps MOHOCDOOLDA, TUnification CDIKNFIEPBG, TGraph KBCGJHHFJKD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x52ACB40", Offset = "0x52ABF40", VA = "0x1852ACB40")]
			public TType PANPELACDLC()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x52AA9F0", Offset = "0x52A9DF0", VA = "0x1852AA9F0")]
			public HDKDENFIPOK<TType> BIBBPEHEMNA(HDKDENFIPOK<TType> KEHFCBFJCMA, HDKDENFIPOK<TType> KGECIONKOCO)
			{
				return default(HDKDENFIPOK<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x52ACCF0", Offset = "0x52AC0F0", VA = "0x1852ACCF0")]
			public int PBDLCPLPMLN(TNode BLJBPFHLMML)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x52AB520", Offset = "0x52AA920", VA = "0x1852AB520")]
			public int GGDGJACKGKO(TNode BLJBPFHLMML)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x52ABD50", Offset = "0x52AB150", VA = "0x1852ABD50")]
			public TInput KAIPLEKPMCD(TNode BLJBPFHLMML, int NOEININIMIL)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x52AAD60", Offset = "0x52AA160", VA = "0x1852AAD60")]
			public int DNFHIEKIKHF(TNode BLJBPFHLMML)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x52AB6D0", Offset = "0x52AAAD0", VA = "0x1852AB6D0")]
			public TOutput HCBIBNMLDBF(TNode BLJBPFHLMML, int NOEININIMIL)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x52AA8D0", Offset = "0x52A9CD0", VA = "0x1852AA8D0")]
			public IEnumerable<AJEMFHBMKDB<TType>> BGACLEFOGGB(TNode BLJBPFHLMML)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x52AC960", Offset = "0x52ABD60", VA = "0x1852AC960")]
			public IEnumerable<JHIMIKKGPID<TNode>> OHCJMAMHDJD([In] TNode BLJBPFHLMML)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x52AC600", Offset = "0x52ABA00", VA = "0x1852AC600")]
			public TType NFIPHJFJLFP(TInput MICKAKKPGLH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x52AAC20", Offset = "0x52AA020", VA = "0x1852AAC20")]
			public int CGGINJNGEDP(TInput MICKAKKPGLH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x52AC4B0", Offset = "0x52AB8B0", VA = "0x1852AC4B0")]
			public TOutput NFBFJJLEODM(TInput MICKAKKPGLH, int NOEININIMIL)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x52ACEB0", Offset = "0x52AC2B0", VA = "0x1852ACEB0")]
			public TNode PPBHAEKDJJE(TInput MICKAKKPGLH)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x52AB7F0", Offset = "0x52AABF0", VA = "0x1852AB7F0")]
			public TType HFOLNOMMEDA(TOutput AHGBOFMNHGN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x52ABA00", Offset = "0x52AAE00", VA = "0x1852ABA00")]
			public int ICGNBMIEIEF(TOutput AHGBOFMNHGN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x52ABB90", Offset = "0x52AAF90", VA = "0x1852ABB90")]
			public TInput JKOJECPBCFB(TOutput AHGBOFMNHGN, int NOEININIMIL)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x52AAF60", Offset = "0x52AA360", VA = "0x1852AAF60")]
			public TNode EHNMKJLELKD(TOutput AHGBOFMNHGN)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x52AC790", Offset = "0x52ABB90", VA = "0x1852AC790")]
			public bool ODEHMENLGIL(TType IIHAKBEOLJD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x52AA7D0", Offset = "0x52A9BD0", VA = "0x1852AA7D0")]
			public TType AKLELMCLHDE(TType IIHAKBEOLJD, IEnumerable<TType> CFNMBNFNAJD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x52AC210", Offset = "0x52AB610", VA = "0x1852AC210")]
			public void LLIFEKDOJIK(TType IIHAKBEOLJD, Action<TType> BBJELFHBAMM, Action<TType> OMEFHMFGFAJ, Action<TType> NKAGNOFKBJP, Action<TType> IDNIBPFBOPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x52AA5E0", Offset = "0x52A99E0", VA = "0x1852AA5E0")]
			public TType AIKLIHAKKLJ(TType IIHAKBEOLJD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x52AB830", Offset = "0x52AAC30", VA = "0x1852AB830")]
			public string HNFMLFNANNN(TType IIHAKBEOLJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x52AC270", Offset = "0x52AB670", VA = "0x1852AC270")]
			public TTerm MFFMBKKNAOG()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x52AAF20", Offset = "0x52AA320", VA = "0x1852AAF20")]
			public TTerm EFHAJHLFLOA(TTerm IIPJAILALEJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x52AB390", Offset = "0x52AA790", VA = "0x1852AB390")]
			public TTerm GBBOKJFHKNE(TTerm EOHGCIHCMID, TTerm BEKKFILOPCK)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x52ACAD0", Offset = "0x52ABED0", VA = "0x1852ACAD0")]
			public void PACFMKCCLPM(TTerm KEHFCBFJCMA, TTerm KGECIONKOCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x52AACA0", Offset = "0x52AA0A0", VA = "0x1852AACA0")]
			public bool CLOGBOLPAGP(TOutputTerm IIPJAILALEJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x52AC690", Offset = "0x52ABA90", VA = "0x1852AC690")]
			public bool OCFMDOIGDLL(TOutputTerm IIPJAILALEJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x52ABE70", Offset = "0x52AB270", VA = "0x1852ABE70")]
			public TTerm KHEGOBIAABP(TOutputTerm LDMJPMJNGDE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x52ACDF0", Offset = "0x52AC1F0", VA = "0x1852ACDF0")]
			public TOutputTerm PHAEOLEGBIL(TOutputTerm IIPJAILALEJ)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x52AA790", Offset = "0x52A9B90", VA = "0x1852AA790")]
			public TOutputTerm AKIAOAKFCPJ(TOutputTerm IIPJAILALEJ)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x52ABFB0", Offset = "0x52AB3B0", VA = "0x1852ABFB0")]
			public TTerm KIGDFOIHKFC(TOutputSubstitution EAKHPIMEDHM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x52AC360", Offset = "0x52AB760", VA = "0x1852AC360")]
			public TOutputTerm MPLDFCEDHCG(TOutputSubstitution EAKHPIMEDHM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x52ABB50", Offset = "0x52AAF50", VA = "0x1852ABB50")]
			public TOutputTerm IGBMGDDFBGB(TTerm IIPJAILALEJ)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class MKHJKIGMMCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public AHDPLFIAFEJ arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public MKHJKIGMMCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5788CF0", Offset = "0x57880F0", VA = "0x185788CF0")]
			internal int GJIOOOGGDFI(AHDPLFIAFEJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5788CA0", Offset = "0x57880A0", VA = "0x185788CA0")]
			internal TInput BHJFODLBMBK(AHDPLFIAFEJ arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5788D70", Offset = "0x5788170", VA = "0x185788D70")]
			internal int OEAKAELPEFG(AHDPLFIAFEJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5788B20", Offset = "0x5787F20", VA = "0x185788B20")]
			internal TOutput APDFKMCMDGG(AHDPLFIAFEJ arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class EPILJDJPFDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public AHDPLFIAFEJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, BGIKILHPDIH<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<BGIKILHPDIH<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public EPILJDJPFDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x49FC880", Offset = "0x49FBC80", VA = "0x1849FC880")]
			internal (string, TTerm) HOLNAOKLNCI(AJEMFHBMKDB<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class OGJLDPGJOEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AHDPLFIAFEJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public OGJLDPGJOEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x59CD660", Offset = "0x59CCA60", VA = "0x1859CD660")]
			internal void KDGJHBIMDBF(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x59CD4D0", Offset = "0x59CC8D0", VA = "0x1859CD4D0")]
			internal void ECFEEKIMNKJ(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x59CDCC0", Offset = "0x59CD0C0", VA = "0x1859CDCC0")]
			internal void OCFPIDODKOB(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x59CDA80", Offset = "0x59CCE80", VA = "0x1859CDA80")]
			internal void KFAHECFOPJD(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class BHGHFEPPHFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public AHDPLFIAFEJ arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public BHGHFEPPHFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4FE7FC0", Offset = "0x4FE73C0", VA = "0x184FE7FC0")]
			internal TTerm EDBLLDAIEKG(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x50AC9A0", Offset = "0x50ABDA0", VA = "0x1850AC9A0")]
		private static NFGIBMDCOOA CFFGPEKOJKB([CallerMemberName] string HDNPPEBJPAE = "")
		{
			return default(NFGIBMDCOOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x50B1DE0", Offset = "0x50B11E0", VA = "0x1850B1DE0")]
		public static Dictionary<TNode, List<AJEMFHBMKDB<TType>>> IPFKHIFGPIP(TRoot LDEPDDDHLLO, TDeps MOHOCDOOLDA, TGraph KBCGJHHFJKD, IEnumerable<TNode> HOEGHOMABBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x50B0960", Offset = "0x50AFD60", VA = "0x1850B0960")]
		private static (Dictionary<TTerm, BGIKILHPDIH<TNode>>, List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>>) FHKGIKJNHOL(IEnumerable<TNode> HOEGHOMABBO, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return default((Dictionary<TTerm, BGIKILHPDIH<TNode>>, List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x50B3D80", Offset = "0x50B3180", VA = "0x1850B3D80")]
		private static void KMPGLFHJKDL(TNode BLJBPFHLMML, Dictionary<TInput, TTerm> OKOOIOEOBOC, Dictionary<TOutput, TTerm> EENIHCJLAND, Dictionary<TTerm, BGIKILHPDIH<TNode>> APOCGEANJKP, Dictionary<BGIKILHPDIH<TNode>, TTerm> NFDIMEJKJDE, List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> MDDLDICDLDM, Stack<TNode> GAECMEDIFHB, List<JHIMIKKGPID<TNode>> NFJBODMIPGO, AHDPLFIAFEJ ALOONCIOJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x50AFC50", Offset = "0x50AF050", VA = "0x1850AFC50")]
		private static Dictionary<string, TTerm> EDKJGLLNMLC(TNode BLJBPFHLMML, Dictionary<TTerm, BGIKILHPDIH<TNode>> APOCGEANJKP, Dictionary<BGIKILHPDIH<TNode>, TTerm> EGMCLIAGHMD, List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> MDDLDICDLDM, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x42F4340", Offset = "0x42F3740", VA = "0x1842F4340")]
		private static (TPort, TTerm)[] GKMHKMKJADI<TPort>(TNode BLJBPFHLMML, Func<AHDPLFIAFEJ, TNode, int> BHNLPFDJHAL, Func<AHDPLFIAFEJ, TNode, int, TPort> MNDHFEBKDLJ, Func<AHDPLFIAFEJ, TPort, TType> KPGOPPKFCFF, Dictionary<TPort, TTerm> MJCFJHHBBEM, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x50AE190", Offset = "0x50AD590", VA = "0x1850AE190")]
		private static (TTerm, TTerm) ECJCFMFLHFJ((TOutput Output, TTerm Id)[] NFODFFNPMBF, List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> MDDLDICDLDM, Dictionary<string, TTerm> EGMCLIAGHMD, Stack<TNode> GAECMEDIFHB, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x50AD600", Offset = "0x50ACA00", VA = "0x1850AD600")]
		private static void CFHIGDIIEPF((TInput PortKey, TTerm Id)[] EFIMLFFJPDM, TTerm IGCBOBFNJHB, TTerm PENGPJHECGK, List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> MDDLDICDLDM, Dictionary<TOutput, TTerm> EENIHCJLAND, Dictionary<string, TTerm> EGMCLIAGHMD, Stack<TNode> GAECMEDIFHB, AHDPLFIAFEJ ALOONCIOJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x50B2D40", Offset = "0x50B2140", VA = "0x1850B2D40")]
		private static TTerm JBBEKNMMODB(TInput MICKAKKPGLH, List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> MDDLDICDLDM, Dictionary<TOutput, TTerm> EENIHCJLAND, Stack<TNode> GAECMEDIFHB, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x50B4900", Offset = "0x50B3D00", VA = "0x1850B4900")]
		private static TTerm OJNHFICIAGG([In] TType IIHAKBEOLJD, IOKind LOJKBLMCGKG, List<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> MDDLDICDLDM, IReadOnlyDictionary<string, TTerm> EGMCLIAGHMD, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x50AAAA0", Offset = "0x50A9EA0", VA = "0x1850AAAA0")]
		private static Dictionary<TNode, List<AJEMFHBMKDB<TType>>> ABKPCEEGLDB(TOutputSubstitution[] OCOAJMJLJFK, Dictionary<TTerm, BGIKILHPDIH<TNode>> APOCGEANJKP, IEnumerable<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> MDDLDICDLDM, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x50AC550", Offset = "0x50AB950", VA = "0x1850AC550")]
		private static Dictionary<TNode, List<AJEMFHBMKDB<TType>>> BJPLIFAAILL(Dictionary<TTerm, BGIKILHPDIH<TNode>> APOCGEANJKP, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x50B74B0", Offset = "0x50B68B0", VA = "0x1850B74B0")]
		private static void PPKPFCILFOE([In] TNode BLJBPFHLMML, Stack<TNode> GAECMEDIFHB, List<JHIMIKKGPID<TNode>> NFJBODMIPGO, AHDPLFIAFEJ ALOONCIOJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50B7020", Offset = "0x50B6420", VA = "0x1850B7020")]
		private static void PLEPCIOILJH(Dictionary<BGIKILHPDIH<TNode>, TTerm> EGMCLIAGHMD, List<JHIMIKKGPID<TNode>> NFJBODMIPGO, AHDPLFIAFEJ ALOONCIOJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x50B4E70", Offset = "0x50B4270", VA = "0x1850B4E70")]
		private static Dictionary<TTerm, TType> OKPGFCEGFHG(Dictionary<TTerm, TOutputSubstitution> OCOAJMJLJFK, IEnumerable<KeyValuePair<TTerm, HDKDENFIPOK<TType>>> MDDLDICDLDM, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x50B1670", Offset = "0x50B0A70", VA = "0x1850B1670")]
		private static DPGCDKOEDPO<TType> HDGAHAICHCP(TOutputTerm IIHAKBEOLJD, Dictionary<TTerm, TType> MDDLDICDLDM, Dictionary<TTerm, TType> INGGBOBKCIL, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return default(DPGCDKOEDPO<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x50B1390", Offset = "0x50B0790", VA = "0x1850B1390")]
		private static TOutputTerm FJCHOLACBAE(TOutputTerm HDALICIGANE, AHDPLFIAFEJ ALOONCIOJJM)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3B11B20", Offset = "0x3B10F20", VA = "0x183B11B20")]
	public static Dictionary<TNode, List<AJEMFHBMKDB<TType>>> IPFKHIFGPIP<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::LLGDCJEJECO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DMFKPMONDPO, TRoot LDEPDDDHLLO, TGraph KBCGJHHFJKD, IEnumerable<TNode> HOEGHOMABBO) where TDeps : global::JIHKHFNOCHI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct AJEMFHBMKDB<TType> : IEquatable<AJEMFHBMKDB<TType>>, FFCNDHCLIDN<AJEMFHBMKDB<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string GODGCHFEMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType ICBLFIJMNDC;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4E92600", Offset = "0x4E91A00", VA = "0x184E92600")]
	internal AJEMFHBMKDB(string HDNPPEBJPAE, [In] TType CGMAGBDIDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x52B8880", Offset = "0x52B7C80", VA = "0x1852B8880")]
	public bool FFNDGINANCF([In] AJEMFHBMKDB<TType> LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x52B8830", Offset = "0x52B7C30", VA = "0x1852B8830", Slot = "4")]
	public bool Equals(AJEMFHBMKDB<TType> LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4566F50", Offset = "0x4566350", VA = "0x184566F50", Slot = "0")]
	public override bool Equals(object LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x52B8950", Offset = "0x52B7D50", VA = "0x1852B8950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x52B8A00", Offset = "0x52B7E00", VA = "0x1852B8A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x52B89B0", Offset = "0x52B7DB0", VA = "0x1852B89B0", Slot = "5")]
	private bool KJLNJMGHBMC([In] AJEMFHBMKDB<TType> LHDOHAKINKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GFDPMJDLAPA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3CB22B0", Offset = "0x3CB16B0", VA = "0x183CB22B0")]
	public static AJEMFHBMKDB<TType> EJOLKNBPCJB<TType>(string HDNPPEBJPAE, TType CGMAGBDIDHB)
	{
		return default(AJEMFHBMKDB<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2270", Offset = "0x3CB1670", VA = "0x183CB2270")]
	public static (string, TType) BIIHFMGKAOJ<TType>([In] this AJEMFHBMKDB<TType> DMFKPMONDPO)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct BGIKILHPDIH<TNode> : IEquatable<BGIKILHPDIH<TNode>>, FFCNDHCLIDN<BGIKILHPDIH<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode BIFNEDEFDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string GODGCHFEMGD;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x18FE520", Offset = "0x18FD920", VA = "0x1818FE520")]
	internal BGIKILHPDIH(TNode BLJBPFHLMML, string HDNPPEBJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x654D090", Offset = "0x654C490", VA = "0x18654D090")]
	public bool FFNDGINANCF([In] BGIKILHPDIH<TNode> LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x654D040", Offset = "0x654C440", VA = "0x18654D040", Slot = "4")]
	public bool Equals(BGIKILHPDIH<TNode> LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4566F50", Offset = "0x4566350", VA = "0x184566F50", Slot = "0")]
	public override bool Equals(object LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x654D230", Offset = "0x654C630", VA = "0x18654D230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x654D2E0", Offset = "0x654C6E0", VA = "0x18654D2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x654CFA0", Offset = "0x654C3A0", VA = "0x18654CFA0", Slot = "5")]
	private bool ACMEFMJLHPM([In] BGIKILHPDIH<TNode> LHDOHAKINKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AMKHGDCFAOL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3204240", Offset = "0x3203640", VA = "0x183204240")]
	public static BGIKILHPDIH<TNode> EJOLKNBPCJB<TNode>(TNode BLJBPFHLMML, string HDNPPEBJPAE)
	{
		return default(BGIKILHPDIH<TNode>);
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
