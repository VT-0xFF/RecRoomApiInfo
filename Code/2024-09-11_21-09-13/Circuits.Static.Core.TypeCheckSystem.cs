using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct DCPGNDGGJEO<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType EMAFAACIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind ENAFDPGNLPC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D196D0", Offset = "0x1D17CD0", VA = "0x181D196D0")]
	internal DCPGNDGGJEO(TType JLAAKHANEHC, IOKind EGMGIMKMKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5A461D0", Offset = "0x5A447D0", VA = "0x185A461D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MPKNCCEAJEO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D690", Offset = "0x2D9BC90", VA = "0x182D9D690")]
	public static DCPGNDGGJEO<TType> GGBAHLJJLHO<TType>(TType JLAAKHANEHC, IOKind EGMGIMKMKNI)
	{
		return default(DCPGNDGGJEO<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D6C0", Offset = "0x2D9BCC0", VA = "0x182D9D6C0")]
	public static (TType, IOKind) IHAFMFKNODA<TType>([In] this DCPGNDGGJEO<TType> BJNJBGHPMEH)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2D9D700", Offset = "0x2D9BD00", VA = "0x182D9D700")]
	public static void MMDHOICOGNG<TType>([In] this DCPGNDGGJEO<TType> BJNJBGHPMEH, [Out] TType JLAAKHANEHC, [Out] IOKind EGMGIMKMKNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KEAAOPIHAAG<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LMGAEAHCGDF<TNode> FAADKCLBGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LMGAEAHCGDF<TNode> HEAOCHNOGGB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4341C30", Offset = "0x4340230", VA = "0x184341C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DLIBAAOGLGB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B15430", Offset = "0x2B13A30", VA = "0x182B15430")]
	public static (LMGAEAHCGDF<TNode>, LMGAEAHCGDF<TNode>) IHAFMFKNODA<TNode>([In] this KEAAOPIHAAG<TNode> BJNJBGHPMEH)
	{
		return default((LMGAEAHCGDF<TNode>, LMGAEAHCGDF<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B154D0", Offset = "0x2B13AD0", VA = "0x182B154D0")]
	public static void MMDHOICOGNG<TNode>([In] this KEAAOPIHAAG<TNode> BJNJBGHPMEH, [Out] LMGAEAHCGDF<TNode> NFCDCHABNCB, [Out] LMGAEAHCGDF<TNode> BCBMNIEKAKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JAGADNBNAOG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPAPGHJDOEJ OMOHPGBMFHA(TRoot JPBBEMPIGCM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType LKKKLHAIEHE(TRoot JPBBEMPIGCM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DCPGNDGGJEO<TType> NGAEBOKCGCC(TRoot JPBBEMPIGCM, [In] DCPGNDGGJEO<TType> JDKMLCHPKLA, [In] DCPGNDGGJEO<TType> AENKMLMFBAD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IJKJHKIPHJJ(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TNode KOHLOCENPAH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DEHDPLFMBNP(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TNode KOHLOCENPAH);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput GKFACEKAHPO(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TNode KOHLOCENPAH, int HGFDMIDEFHN);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KBHJHGAMKPC(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TNode KOHLOCENPAH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput HMGFOGKNAKM(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TNode KOHLOCENPAH, int HGFDMIDEFHN);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<EIGJPCPJMLE<TType>> EKONPHFFKPO(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TNode KOHLOCENPAH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KEAAOPIHAAG<TNode>> ADLNOOCHPEK(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TNode KOHLOCENPAH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType JAIABPMAIGF(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TInput DIGEGMNKCOG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int BCCIHFBOPPM(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TInput DIGEGMNKCOG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput EFBILKDLHPO(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TInput DIGEGMNKCOG, int HGFDMIDEFHN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode CKIKHEGHICB(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TInput DIGEGMNKCOG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType ACALDECODHH(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TOutput CEMLELOFBNI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int NFIJDBOHJFC(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TOutput CEMLELOFBNI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput MJCPBKIMGAG(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TOutput CEMLELOFBNI, int HGFDMIDEFHN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode JBHDMOOFOLA(TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, TOutput CEMLELOFBNI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool AEAJGGKKDPJ(TRoot JPBBEMPIGCM, TType JLAAKHANEHC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType AMNIECJCPOC(TRoot JPBBEMPIGCM, TType JLAAKHANEHC, IEnumerable<TType> OBBGOMDKONB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MNDDHNGOINN(TRoot JPBBEMPIGCM, TType JLAAKHANEHC, Action<TType> GMJPFHDHGLC, Action<TType> FCKHBAINMAG, Action<TType> NHOCPOBMLIH, Action<TType> JCBIEAGPNFF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType AMOJFCKAEEM(TRoot JPBBEMPIGCM, TType JLAAKHANEHC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string KPNELOJMBAD(TRoot JPBBEMPIGCM, TType JLAAKHANEHC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification HDJDKKIMNJL(TRoot JPBBEMPIGCM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BCLNLKLFCPB<TOutputSubstitution[], LBGFPGMHGDG> PMDFICGEKDJ(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm EGICGFJOJAM(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm IEHDJNIMACI(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TTerm OHHNFJGCEJE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm ELCFHLPFCPC(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TTerm NEDJODMJOFF, TTerm OHIICHJPFBL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KJNICLJFPDE(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TTerm JDKMLCHPKLA, TTerm AENKMLMFBAD);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool KPPKMMPIHAC(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TOutputTerm HHEHIDDGPHE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool NJGKNNPJOOP(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TOutputTerm HHEHIDDGPHE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm NPLDICOGNJH(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TOutputTerm HHEHIDDGPHE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm DOIAEEMMKLO(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TOutputTerm HHEHIDDGPHE);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm JOCNPKCELDG(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TOutputTerm HHEHIDDGPHE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm LHLEOMPPEGJ(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TOutputSubstitution HMFAKBHIBJP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm IIBGPKNJDNJ(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TOutputSubstitution HMFAKBHIBJP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm ALNMFNPPDPD(TRoot JPBBEMPIGCM, TUnification HAKNNCKOPFM, TTerm OHHNFJGCEJE);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DMDHNOLABFD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::JAGADNBNAOG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40")]
	public static global::DMDHNOLABFD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> GGBAHLJJLHO()
	{
		return default(global::DMDHNOLABFD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FGBFPJNPBBK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class IIOLEHJBIBN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::JAGADNBNAOG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class OOONEHIPGKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot GEBPHFIJDHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps HEJJNPLBKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification KOBGNLFNCAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph EODFIJMFGCO;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public HPAPGHJDOEJ FMCNFHJAODL
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x483C790", Offset = "0x483AD90", VA = "0x18483C790")]
				get
				{
					return default(HPAPGHJDOEJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x483C890", Offset = "0x483AE90", VA = "0x18483C890")]
			private OOONEHIPGKK(TRoot JPBBEMPIGCM, TDeps LAKCFHGOLJA, TUnification GKEDIFIAMGM, TGraph BDFEFAPJDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x483ADF0", Offset = "0x48393F0", VA = "0x18483ADF0")]
			public static OOONEHIPGKK GGBAHLJJLHO(TRoot JPBBEMPIGCM, TDeps LAKCFHGOLJA, TUnification GKEDIFIAMGM, TGraph BDFEFAPJDHE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x483BF90", Offset = "0x483A590", VA = "0x18483BF90")]
			public TType LKKKLHAIEHE()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x483C3E0", Offset = "0x483A9E0", VA = "0x18483C3E0")]
			public DCPGNDGGJEO<TType> NGAEBOKCGCC(DCPGNDGGJEO<TType> JDKMLCHPKLA, DCPGNDGGJEO<TType> AENKMLMFBAD)
			{
				return default(DCPGNDGGJEO<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x483B470", Offset = "0x4839A70", VA = "0x18483B470")]
			public int IJKJHKIPHJJ(TNode KOHLOCENPAH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x483A530", Offset = "0x4838B30", VA = "0x18483A530")]
			public int DEHDPLFMBNP(TNode KOHLOCENPAH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x483AFA0", Offset = "0x48395A0", VA = "0x18483AFA0")]
			public TInput GKFACEKAHPO(TNode KOHLOCENPAH, int HGFDMIDEFHN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x483B8C0", Offset = "0x4839EC0", VA = "0x18483B8C0")]
			public int KBHJHGAMKPC(TNode KOHLOCENPAH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x483B0D0", Offset = "0x48396D0", VA = "0x18483B0D0")]
			public TOutput HMGFOGKNAKM(TNode KOHLOCENPAH, int HGFDMIDEFHN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x483A970", Offset = "0x4838F70", VA = "0x18483A970")]
			public IEnumerable<EIGJPCPJMLE<TType>> EKONPHFFKPO(TNode KOHLOCENPAH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4839D90", Offset = "0x4838390", VA = "0x184839D90")]
			public IEnumerable<KEAAOPIHAAG<TNode>> ADLNOOCHPEK([In] TNode KOHLOCENPAH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x483B580", Offset = "0x4839B80", VA = "0x18483B580")]
			public TType JAIABPMAIGF(TInput DIGEGMNKCOG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x483BD90", Offset = "0x483A390", VA = "0x18483BD90")]
			public int LHHOKBLNEOK(TInput DIGEGMNKCOG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x483A750", Offset = "0x4838D50", VA = "0x18483A750")]
			public TOutput EFBILKDLHPO(TInput DIGEGMNKCOG, int HGFDMIDEFHN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x483A340", Offset = "0x4838940", VA = "0x18483A340")]
			public TNode CKIKHEGHICB(TInput DIGEGMNKCOG)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4839C70", Offset = "0x4838270", VA = "0x184839C70")]
			public TType ACALDECODHH(TOutput CEMLELOFBNI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x483A390", Offset = "0x4838990", VA = "0x18483A390")]
			public int DDIPJBEOEPC(TOutput CEMLELOFBNI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x483C050", Offset = "0x483A650", VA = "0x18483C050")]
			public TInput MJCPBKIMGAG(TOutput CEMLELOFBNI, int HGFDMIDEFHN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x483B5C0", Offset = "0x4839BC0", VA = "0x18483B5C0")]
			public TNode JBHDMOOFOLA(TOutput CEMLELOFBNI)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4839E90", Offset = "0x4838490", VA = "0x184839E90")]
			public bool AEAJGGKKDPJ(TType JLAAKHANEHC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x483A0C0", Offset = "0x48386C0", VA = "0x18483A0C0")]
			public TType AMNIECJCPOC(TType JLAAKHANEHC, IEnumerable<TType> OBBGOMDKONB)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x483C260", Offset = "0x483A860", VA = "0x18483C260")]
			public void MNDDHNGOINN(TType JLAAKHANEHC, Action<TType> GMJPFHDHGLC, Action<TType> FCKHBAINMAG, Action<TType> NHOCPOBMLIH, Action<TType> JCBIEAGPNFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x483A230", Offset = "0x4838830", VA = "0x18483A230")]
			public TType AMOJFCKAEEM(TType JLAAKHANEHC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x483BAA0", Offset = "0x483A0A0", VA = "0x18483BAA0")]
			public string KPNELOJMBAD(TType JLAAKHANEHC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x483A880", Offset = "0x4838E80", VA = "0x18483A880")]
			public TTerm EGICGFJOJAM()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x483B1C0", Offset = "0x48397C0", VA = "0x18483B1C0")]
			public TTerm IEHDJNIMACI(TTerm OHHNFJGCEJE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x483AA30", Offset = "0x4839030", VA = "0x18483AA30")]
			public TTerm ELCFHLPFCPC(TTerm NEDJODMJOFF, TTerm OHIICHJPFBL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x483B900", Offset = "0x4839F00", VA = "0x18483B900")]
			public void KJNICLJFPDE(TTerm JDKMLCHPKLA, TTerm AENKMLMFBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x483C630", Offset = "0x483AC30", VA = "0x18483C630")]
			public bool NJGKNNPJOOP(TOutputTerm OHHNFJGCEJE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x483BCC0", Offset = "0x483A2C0", VA = "0x18483BCC0")]
			public bool KPPKMMPIHAC(TOutputTerm OHHNFJGCEJE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x483C210", Offset = "0x483A810", VA = "0x18483C210")]
			public TTerm MLCAHNJOJGP(TOutputTerm HHEHIDDGPHE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x483A600", Offset = "0x4838C00", VA = "0x18483A600")]
			public TOutputTerm DOIAEEMMKLO(TOutputTerm OHHNFJGCEJE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x483B6E0", Offset = "0x4839CE0", VA = "0x18483B6E0")]
			public TOutputTerm JOCNPKCELDG(TOutputTerm OHHNFJGCEJE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x483BE20", Offset = "0x483A420", VA = "0x18483BE20")]
			public TTerm LHLEOMPPEGJ(TOutputSubstitution GECELDDAPFE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x483B360", Offset = "0x4839960", VA = "0x18483B360")]
			public TOutputTerm IIBGPKNJDNJ(TOutputSubstitution GECELDDAPFE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4839FA0", Offset = "0x48385A0", VA = "0x184839FA0")]
			public TOutputTerm ALNMFNPPDPD(TTerm OHHNFJGCEJE)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EPPCNGLLGFL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public OOONEHIPGKK arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public EPPCNGLLGFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x39917D0", Offset = "0x398FDD0", VA = "0x1839917D0")]
			internal int JJKJEHLPINM(OOONEHIPGKK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3991560", Offset = "0x398FB60", VA = "0x183991560")]
			internal TInput DLEEBGFINJE(OOONEHIPGKK arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3991710", Offset = "0x398FD10", VA = "0x183991710")]
			internal int JECFEHECBNJ(OOONEHIPGKK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3991920", Offset = "0x398FF20", VA = "0x183991920")]
			internal TOutput LJHGIMHIGCM(OOONEHIPGKK arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NIHMDCNAPCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public OOONEHIPGKK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, LMGAEAHCGDF<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<LMGAEAHCGDF<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public NIHMDCNAPCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x47237C0", Offset = "0x4721DC0", VA = "0x1847237C0")]
			internal (string, TTerm) AKPNNBAGLOM(EIGJPCPJMLE<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class NLHBAFDDHJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public OOONEHIPGKK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public NLHBAFDDHJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x472B3F0", Offset = "0x47299F0", VA = "0x18472B3F0")]
			internal void KBPOGFOJAEB(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x472ABC0", Offset = "0x47291C0", VA = "0x18472ABC0")]
			internal void DEGAJAJBAIH(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x472B6B0", Offset = "0x4729CB0", VA = "0x18472B6B0")]
			internal void NPBCHPDMCEG(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x472ADF0", Offset = "0x47293F0", VA = "0x18472ADF0")]
			internal void FDBKHPMAPEC(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FNFGPEAHILP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OOONEHIPGKK arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public FNFGPEAHILP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3D38690", Offset = "0x3D36C90", VA = "0x183D38690")]
			internal TTerm KDOBOGMBFDM(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0100", Offset = "0x3FBE700", VA = "0x183FC0100")]
		private static FBPLBJMCGOC AKEOHALHGGN([CallerMemberName] string KJPHMNNIMDP = "")
		{
			return default(FBPLBJMCGOC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0140", Offset = "0x3FBE740", VA = "0x183FC0140")]
		public static Dictionary<TNode, List<EIGJPCPJMLE<TType>>> ALCJNDLDGLE(TRoot JPBBEMPIGCM, TDeps LAKCFHGOLJA, TGraph BDFEFAPJDHE, IEnumerable<TNode> KLOIHFEJIAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3FC14D0", Offset = "0x3FBFAD0", VA = "0x183FC14D0")]
		private static (Dictionary<TTerm, LMGAEAHCGDF<TNode>>, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>>) APOAINCAKBA(IEnumerable<TNode> KLOIHFEJIAM, OOONEHIPGKK IOBLLEKOCNN)
		{
			return default((Dictionary<TTerm, LMGAEAHCGDF<TNode>>, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3FCB5A0", Offset = "0x3FC9BA0", VA = "0x183FCB5A0")]
		private static void KGGNEOLKLMK(TNode KOHLOCENPAH, Dictionary<TInput, TTerm> KPEHIFGMFKF, Dictionary<TOutput, TTerm> LEFMHIPOCGP, Dictionary<TTerm, LMGAEAHCGDF<TNode>> HPLCICFALOJ, Dictionary<LMGAEAHCGDF<TNode>, TTerm> EHCDBLMHBML, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, Stack<TNode> FNELIEOHLMA, List<KEAAOPIHAAG<TNode>> IPDGNHFPMPK, OOONEHIPGKK IOBLLEKOCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3FC3930", Offset = "0x3FC1F30", VA = "0x183FC3930")]
		private static Dictionary<string, TTerm> DCEAJIPDBOC(TNode KOHLOCENPAH, Dictionary<TTerm, LMGAEAHCGDF<TNode>> HPLCICFALOJ, Dictionary<LMGAEAHCGDF<TNode>, TTerm> AOJCJJCPDHP, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE570", Offset = "0x2BFCB70", VA = "0x182BFE570")]
		private static (TPort, TTerm)[] BNEGEEOIIBB<TPort>(TNode KOHLOCENPAH, Func<OOONEHIPGKK, TNode, int> PBPOCCEGBKM, Func<OOONEHIPGKK, TNode, int, TPort> GLHGGHNNCCC, Func<OOONEHIPGKK, TPort, TType> EHGLOAIPHBN, Dictionary<TPort, TTerm> NJFKALELKCP, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4620", Offset = "0x3FD2C20", VA = "0x183FD4620")]
		private static (TTerm, TTerm) NFGNPIMLBDD((TOutput Output, TTerm Id)[] FPLMDJDONEI, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, Dictionary<string, TTerm> AOJCJJCPDHP, Stack<TNode> FNELIEOHLMA, OOONEHIPGKK IOBLLEKOCNN)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3FCF9C0", Offset = "0x3FCDFC0", VA = "0x183FCF9C0")]
		private static void MNIJDACGIEO((TInput PortKey, TTerm Id)[] DAMPHGNICNC, TTerm GNAGOFFMLAD, TTerm GHAFMIGEPLA, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, Dictionary<TOutput, TTerm> LEFMHIPOCGP, Dictionary<string, TTerm> AOJCJJCPDHP, Stack<TNode> FNELIEOHLMA, OOONEHIPGKK IOBLLEKOCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3FC5D30", Offset = "0x3FC4330", VA = "0x183FC5D30")]
		private static TTerm GGBEABNPKBN(TInput DIGEGMNKCOG, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, Dictionary<TOutput, TTerm> LEFMHIPOCGP, Stack<TNode> FNELIEOHLMA, OOONEHIPGKK IOBLLEKOCNN)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3FC9CA0", Offset = "0x3FC82A0", VA = "0x183FC9CA0")]
		private static TTerm IDEJJEKEGDP([In] TType JLAAKHANEHC, IOKind EGMGIMKMKNI, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, IReadOnlyDictionary<string, TTerm> AOJCJJCPDHP, OOONEHIPGKK IOBLLEKOCNN)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3FC7C40", Offset = "0x3FC6240", VA = "0x183FC7C40")]
		private static Dictionary<TNode, List<EIGJPCPJMLE<TType>>> GJGOPLDCPBH(TOutputSubstitution[] HFDLMFINJMN, Dictionary<TTerm, LMGAEAHCGDF<TNode>> HPLCICFALOJ, IEnumerable<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3FCDD70", Offset = "0x3FCC370", VA = "0x183FCDD70")]
		private static Dictionary<TNode, List<EIGJPCPJMLE<TType>>> MKMEAMICEHN(Dictionary<TTerm, LMGAEAHCGDF<TNode>> HPLCICFALOJ, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4F80", Offset = "0x3FC3580", VA = "0x183FC4F80")]
		private static void EOLEEHHCDLL([In] TNode KOHLOCENPAH, Stack<TNode> FNELIEOHLMA, List<KEAAOPIHAAG<TNode>> IPDGNHFPMPK, OOONEHIPGKK IOBLLEKOCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4510", Offset = "0x3FC2B10", VA = "0x183FC4510")]
		private static void EDCNEDOKLAJ(Dictionary<LMGAEAHCGDF<TNode>, TTerm> AOJCJJCPDHP, List<KEAAOPIHAAG<TNode>> IPDGNHFPMPK, OOONEHIPGKK IOBLLEKOCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3FD2600", Offset = "0x3FD0C00", VA = "0x183FD2600")]
		private static Dictionary<TTerm, TType> NEBBIJPAJAF(Dictionary<TTerm, TOutputSubstitution> HFDLMFINJMN, IEnumerable<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3FCAC50", Offset = "0x3FC9250", VA = "0x183FCAC50")]
		private static OLCEOJBLPLC<TType> KEFLJLEFBAC(TOutputTerm JLAAKHANEHC, Dictionary<TTerm, TType> LMPCFJNDMLG, Dictionary<TTerm, TType> DNNINLMOCPD, OOONEHIPGKK IOBLLEKOCNN)
		{
			return default(OLCEOJBLPLC<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3FC9680", Offset = "0x3FC7C80", VA = "0x183FC9680")]
		private static TOutputTerm HEBIIDDAFNP(TOutputTerm IDOPKLJHBBN, OOONEHIPGKK IOBLLEKOCNN)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C98780", Offset = "0x2C96D80", VA = "0x182C98780")]
	public static Dictionary<TNode, List<EIGJPCPJMLE<TType>>> ALCJNDLDGLE<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::DMDHNOLABFD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> BJNJBGHPMEH, TRoot JPBBEMPIGCM, TGraph BDFEFAPJDHE, IEnumerable<TNode> KLOIHFEJIAM) where TDeps : global::JAGADNBNAOG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EIGJPCPJMLE<TType> : IEquatable<EIGJPCPJMLE<TType>>, GKKHBAJDJDD<EIGJPCPJMLE<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string FHACOBMPENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType BDFNHLNNAFE;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3961C50", Offset = "0x3960250", VA = "0x183961C50")]
	internal EIGJPCPJMLE(string KJPHMNNIMDP, [In] TType BDKHAKGONEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3961A00", Offset = "0x3960000", VA = "0x183961A00")]
	public bool ELNMFHABHNG([In] EIGJPCPJMLE<TType> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3961B70", Offset = "0x3960170", VA = "0x183961B70", Slot = "4")]
	public bool Equals(EIGJPCPJMLE<TType> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3961AE0", Offset = "0x39600E0", VA = "0x183961AE0", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2116B00", Offset = "0x2115100", VA = "0x182116B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3961C10", Offset = "0x3960210", VA = "0x183961C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3961BC0", Offset = "0x39601C0", VA = "0x183961BC0", Slot = "5")]
	private bool HGFOPICKBPB([In] EIGJPCPJMLE<TType> PLNBHPCFEOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DIGEPGIAJCL
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA4D0", Offset = "0x2AF8AD0", VA = "0x182AFA4D0")]
	public static EIGJPCPJMLE<TType> GGBAHLJJLHO<TType>(string KJPHMNNIMDP, TType BDKHAKGONEH)
	{
		return default(EIGJPCPJMLE<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA500", Offset = "0x2AF8B00", VA = "0x182AFA500")]
	public static (string, TType) IHAFMFKNODA<TType>([In] this EIGJPCPJMLE<TType> BJNJBGHPMEH)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LMGAEAHCGDF<TNode> : IEquatable<LMGAEAHCGDF<TNode>>, GKKHBAJDJDD<LMGAEAHCGDF<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode DFIMPCAKHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string FHACOBMPENF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xF42D50", Offset = "0xF41350", VA = "0x180F42D50")]
	internal LMGAEAHCGDF(TNode KOHLOCENPAH, string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x440E790", Offset = "0x440CD90", VA = "0x18440E790")]
	public bool ELNMFHABHNG([In] LMGAEAHCGDF<TNode> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x440E8C0", Offset = "0x440CEC0", VA = "0x18440E8C0", Slot = "4")]
	public bool Equals(LMGAEAHCGDF<TNode> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3961AE0", Offset = "0x39600E0", VA = "0x183961AE0", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x440E9B0", Offset = "0x440CFB0", VA = "0x18440E9B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x440EA20", Offset = "0x440D020", VA = "0x18440EA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x440E910", Offset = "0x440CF10", VA = "0x18440E910", Slot = "5")]
	private bool GBIJIIHLFLO([In] LMGAEAHCGDF<TNode> PLNBHPCFEOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NHCPDJLMKCI
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2E13060", Offset = "0x2E11660", VA = "0x182E13060")]
	public static LMGAEAHCGDF<TNode> GGBAHLJJLHO<TNode>(TNode KOHLOCENPAH, string KJPHMNNIMDP)
	{
		return default(LMGAEAHCGDF<TNode>);
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
