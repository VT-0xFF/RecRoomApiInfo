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
	[Cpp2IlInjected.Address(RVA = "0x1E55E00", Offset = "0x1E54800", VA = "0x181E55E00")]
	internal DCPGNDGGJEO(TType JLAAKHANEHC, IOKind EGMGIMKMKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B2F2F0", Offset = "0x5B2DCF0", VA = "0x185B2F2F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MPKNCCEAJEO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E83480", Offset = "0x2E81E80", VA = "0x182E83480")]
	public static DCPGNDGGJEO<TType> GGBAHLJJLHO<TType>(TType JLAAKHANEHC, IOKind EGMGIMKMKNI)
	{
		return default(DCPGNDGGJEO<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E834B0", Offset = "0x2E81EB0", VA = "0x182E834B0")]
	public static (TType, IOKind) IHAFMFKNODA<TType>([In] this DCPGNDGGJEO<TType> BJNJBGHPMEH)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E834F0", Offset = "0x2E81EF0", VA = "0x182E834F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4416730", Offset = "0x4415130", VA = "0x184416730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DLIBAAOGLGB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFD00", Offset = "0x2BCE700", VA = "0x182BCFD00")]
	public static (LMGAEAHCGDF<TNode>, LMGAEAHCGDF<TNode>) IHAFMFKNODA<TNode>([In] this KEAAOPIHAAG<TNode> BJNJBGHPMEH)
	{
		return default((LMGAEAHCGDF<TNode>, LMGAEAHCGDF<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFDA0", Offset = "0x2BCE7A0", VA = "0x182BCFDA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40")]
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
				[Cpp2IlInjected.Address(RVA = "0x49104F0", Offset = "0x490EEF0", VA = "0x1849104F0")]
				get
				{
					return default(HPAPGHJDOEJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x49105F0", Offset = "0x490EFF0", VA = "0x1849105F0")]
			private OOONEHIPGKK(TRoot JPBBEMPIGCM, TDeps LAKCFHGOLJA, TUnification GKEDIFIAMGM, TGraph BDFEFAPJDHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x490EB50", Offset = "0x490D550", VA = "0x18490EB50")]
			public static OOONEHIPGKK GGBAHLJJLHO(TRoot JPBBEMPIGCM, TDeps LAKCFHGOLJA, TUnification GKEDIFIAMGM, TGraph BDFEFAPJDHE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x490FCF0", Offset = "0x490E6F0", VA = "0x18490FCF0")]
			public TType LKKKLHAIEHE()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4910140", Offset = "0x490EB40", VA = "0x184910140")]
			public DCPGNDGGJEO<TType> NGAEBOKCGCC(DCPGNDGGJEO<TType> JDKMLCHPKLA, DCPGNDGGJEO<TType> AENKMLMFBAD)
			{
				return default(DCPGNDGGJEO<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x490F1D0", Offset = "0x490DBD0", VA = "0x18490F1D0")]
			public int IJKJHKIPHJJ(TNode KOHLOCENPAH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x490E290", Offset = "0x490CC90", VA = "0x18490E290")]
			public int DEHDPLFMBNP(TNode KOHLOCENPAH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x490ED00", Offset = "0x490D700", VA = "0x18490ED00")]
			public TInput GKFACEKAHPO(TNode KOHLOCENPAH, int HGFDMIDEFHN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x490F620", Offset = "0x490E020", VA = "0x18490F620")]
			public int KBHJHGAMKPC(TNode KOHLOCENPAH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x490EE30", Offset = "0x490D830", VA = "0x18490EE30")]
			public TOutput HMGFOGKNAKM(TNode KOHLOCENPAH, int HGFDMIDEFHN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x490E6D0", Offset = "0x490D0D0", VA = "0x18490E6D0")]
			public IEnumerable<EIGJPCPJMLE<TType>> EKONPHFFKPO(TNode KOHLOCENPAH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x490DAF0", Offset = "0x490C4F0", VA = "0x18490DAF0")]
			public IEnumerable<KEAAOPIHAAG<TNode>> ADLNOOCHPEK([In] TNode KOHLOCENPAH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x490F2E0", Offset = "0x490DCE0", VA = "0x18490F2E0")]
			public TType JAIABPMAIGF(TInput DIGEGMNKCOG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x490FAF0", Offset = "0x490E4F0", VA = "0x18490FAF0")]
			public int LHHOKBLNEOK(TInput DIGEGMNKCOG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x490E4B0", Offset = "0x490CEB0", VA = "0x18490E4B0")]
			public TOutput EFBILKDLHPO(TInput DIGEGMNKCOG, int HGFDMIDEFHN)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x490E0A0", Offset = "0x490CAA0", VA = "0x18490E0A0")]
			public TNode CKIKHEGHICB(TInput DIGEGMNKCOG)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x490D9D0", Offset = "0x490C3D0", VA = "0x18490D9D0")]
			public TType ACALDECODHH(TOutput CEMLELOFBNI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x490E0F0", Offset = "0x490CAF0", VA = "0x18490E0F0")]
			public int DDIPJBEOEPC(TOutput CEMLELOFBNI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x490FDB0", Offset = "0x490E7B0", VA = "0x18490FDB0")]
			public TInput MJCPBKIMGAG(TOutput CEMLELOFBNI, int HGFDMIDEFHN)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x490F320", Offset = "0x490DD20", VA = "0x18490F320")]
			public TNode JBHDMOOFOLA(TOutput CEMLELOFBNI)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x490DBF0", Offset = "0x490C5F0", VA = "0x18490DBF0")]
			public bool AEAJGGKKDPJ(TType JLAAKHANEHC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x490DE20", Offset = "0x490C820", VA = "0x18490DE20")]
			public TType AMNIECJCPOC(TType JLAAKHANEHC, IEnumerable<TType> OBBGOMDKONB)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x490FFC0", Offset = "0x490E9C0", VA = "0x18490FFC0")]
			public void MNDDHNGOINN(TType JLAAKHANEHC, Action<TType> GMJPFHDHGLC, Action<TType> FCKHBAINMAG, Action<TType> NHOCPOBMLIH, Action<TType> JCBIEAGPNFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x490DF90", Offset = "0x490C990", VA = "0x18490DF90")]
			public TType AMOJFCKAEEM(TType JLAAKHANEHC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x490F800", Offset = "0x490E200", VA = "0x18490F800")]
			public string KPNELOJMBAD(TType JLAAKHANEHC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x490E5E0", Offset = "0x490CFE0", VA = "0x18490E5E0")]
			public TTerm EGICGFJOJAM()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x490EF20", Offset = "0x490D920", VA = "0x18490EF20")]
			public TTerm IEHDJNIMACI(TTerm OHHNFJGCEJE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x490E790", Offset = "0x490D190", VA = "0x18490E790")]
			public TTerm ELCFHLPFCPC(TTerm NEDJODMJOFF, TTerm OHIICHJPFBL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x490F660", Offset = "0x490E060", VA = "0x18490F660")]
			public void KJNICLJFPDE(TTerm JDKMLCHPKLA, TTerm AENKMLMFBAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4910390", Offset = "0x490ED90", VA = "0x184910390")]
			public bool NJGKNNPJOOP(TOutputTerm OHHNFJGCEJE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x490FA20", Offset = "0x490E420", VA = "0x18490FA20")]
			public bool KPPKMMPIHAC(TOutputTerm OHHNFJGCEJE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x490FF70", Offset = "0x490E970", VA = "0x18490FF70")]
			public TTerm MLCAHNJOJGP(TOutputTerm HHEHIDDGPHE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x490E360", Offset = "0x490CD60", VA = "0x18490E360")]
			public TOutputTerm DOIAEEMMKLO(TOutputTerm OHHNFJGCEJE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x490F440", Offset = "0x490DE40", VA = "0x18490F440")]
			public TOutputTerm JOCNPKCELDG(TOutputTerm OHHNFJGCEJE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x490FB80", Offset = "0x490E580", VA = "0x18490FB80")]
			public TTerm LHLEOMPPEGJ(TOutputSubstitution GECELDDAPFE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x490F0C0", Offset = "0x490DAC0", VA = "0x18490F0C0")]
			public TOutputTerm IIBGPKNJDNJ(TOutputSubstitution GECELDDAPFE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x490DD00", Offset = "0x490C700", VA = "0x18490DD00")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public EPPCNGLLGFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3A660C0", Offset = "0x3A64AC0", VA = "0x183A660C0")]
			internal int JJKJEHLPINM(OOONEHIPGKK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3A65E50", Offset = "0x3A64850", VA = "0x183A65E50")]
			internal TInput DLEEBGFINJE(OOONEHIPGKK arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3A66000", Offset = "0x3A64A00", VA = "0x183A66000")]
			internal int JECFEHECBNJ(OOONEHIPGKK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3A66210", Offset = "0x3A64C10", VA = "0x183A66210")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public NIHMDCNAPCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x47F9F70", Offset = "0x47F8970", VA = "0x1847F9F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public NLHBAFDDHJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4801A80", Offset = "0x4800480", VA = "0x184801A80")]
			internal void KBPOGFOJAEB(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4801250", Offset = "0x47FFC50", VA = "0x184801250")]
			internal void DEGAJAJBAIH(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4801D40", Offset = "0x4800740", VA = "0x184801D40")]
			internal void NPBCHPDMCEG(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4801480", Offset = "0x47FFE80", VA = "0x184801480")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public FNFGPEAHILP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3E0A9B0", Offset = "0x3E093B0", VA = "0x183E0A9B0")]
			internal TTerm KDOBOGMBFDM(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4090860", Offset = "0x408F260", VA = "0x184090860")]
		private static FBPLBJMCGOC AKEOHALHGGN([CallerMemberName] string KJPHMNNIMDP = "")
		{
			return default(FBPLBJMCGOC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x40908A0", Offset = "0x408F2A0", VA = "0x1840908A0")]
		public static Dictionary<TNode, List<EIGJPCPJMLE<TType>>> ALCJNDLDGLE(TRoot JPBBEMPIGCM, TDeps LAKCFHGOLJA, TGraph BDFEFAPJDHE, IEnumerable<TNode> KLOIHFEJIAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x40914B0", Offset = "0x408FEB0", VA = "0x1840914B0")]
		private static (Dictionary<TTerm, LMGAEAHCGDF<TNode>>, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>>) APOAINCAKBA(IEnumerable<TNode> KLOIHFEJIAM, OOONEHIPGKK IOBLLEKOCNN)
		{
			return default((Dictionary<TTerm, LMGAEAHCGDF<TNode>>, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4098020", Offset = "0x4096A20", VA = "0x184098020")]
		private static void KGGNEOLKLMK(TNode KOHLOCENPAH, Dictionary<TInput, TTerm> KPEHIFGMFKF, Dictionary<TOutput, TTerm> LEFMHIPOCGP, Dictionary<TTerm, LMGAEAHCGDF<TNode>> HPLCICFALOJ, Dictionary<LMGAEAHCGDF<TNode>, TTerm> EHCDBLMHBML, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, Stack<TNode> FNELIEOHLMA, List<KEAAOPIHAAG<TNode>> IPDGNHFPMPK, OOONEHIPGKK IOBLLEKOCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4092CF0", Offset = "0x40916F0", VA = "0x184092CF0")]
		private static Dictionary<string, TTerm> DCEAJIPDBOC(TNode KOHLOCENPAH, Dictionary<TTerm, LMGAEAHCGDF<TNode>> HPLCICFALOJ, Dictionary<LMGAEAHCGDF<TNode>, TTerm> AOJCJJCPDHP, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2D6BF80", Offset = "0x2D6A980", VA = "0x182D6BF80")]
		private static (TPort, TTerm)[] BNEGEEOIIBB<TPort>(TNode KOHLOCENPAH, Func<OOONEHIPGKK, TNode, int> PBPOCCEGBKM, Func<OOONEHIPGKK, TNode, int, TPort> GLHGGHNNCCC, Func<OOONEHIPGKK, TPort, TType> EHGLOAIPHBN, Dictionary<TPort, TTerm> NJFKALELKCP, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x409E160", Offset = "0x409CB60", VA = "0x18409E160")]
		private static (TTerm, TTerm) NFGNPIMLBDD((TOutput Output, TTerm Id)[] FPLMDJDONEI, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, Dictionary<string, TTerm> AOJCJJCPDHP, Stack<TNode> FNELIEOHLMA, OOONEHIPGKK IOBLLEKOCNN)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x409B210", Offset = "0x4099C10", VA = "0x18409B210")]
		private static void MNIJDACGIEO((TInput PortKey, TTerm Id)[] DAMPHGNICNC, TTerm GNAGOFFMLAD, TTerm GHAFMIGEPLA, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, Dictionary<TOutput, TTerm> LEFMHIPOCGP, Dictionary<string, TTerm> AOJCJJCPDHP, Stack<TNode> FNELIEOHLMA, OOONEHIPGKK IOBLLEKOCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4094720", Offset = "0x4093120", VA = "0x184094720")]
		private static TTerm GGBEABNPKBN(TInput DIGEGMNKCOG, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, Dictionary<TOutput, TTerm> LEFMHIPOCGP, Stack<TNode> FNELIEOHLMA, OOONEHIPGKK IOBLLEKOCNN)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4097070", Offset = "0x4095A70", VA = "0x184097070")]
		private static TTerm IDEJJEKEGDP([In] TType JLAAKHANEHC, IOKind EGMGIMKMKNI, List<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, IReadOnlyDictionary<string, TTerm> AOJCJJCPDHP, OOONEHIPGKK IOBLLEKOCNN)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4096050", Offset = "0x4094A50", VA = "0x184096050")]
		private static Dictionary<TNode, List<EIGJPCPJMLE<TType>>> GJGOPLDCPBH(TOutputSubstitution[] HFDLMFINJMN, Dictionary<TTerm, LMGAEAHCGDF<TNode>> HPLCICFALOJ, IEnumerable<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4099A90", Offset = "0x4098490", VA = "0x184099A90")]
		private static Dictionary<TNode, List<EIGJPCPJMLE<TType>>> MKMEAMICEHN(Dictionary<TTerm, LMGAEAHCGDF<TNode>> HPLCICFALOJ, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4093E00", Offset = "0x4092800", VA = "0x184093E00")]
		private static void EOLEEHHCDLL([In] TNode KOHLOCENPAH, Stack<TNode> FNELIEOHLMA, List<KEAAOPIHAAG<TNode>> IPDGNHFPMPK, OOONEHIPGKK IOBLLEKOCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x40938D0", Offset = "0x40922D0", VA = "0x1840938D0")]
		private static void EDCNEDOKLAJ(Dictionary<LMGAEAHCGDF<TNode>, TTerm> AOJCJJCPDHP, List<KEAAOPIHAAG<TNode>> IPDGNHFPMPK, OOONEHIPGKK IOBLLEKOCNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x409D0B0", Offset = "0x409BAB0", VA = "0x18409D0B0")]
		private static Dictionary<TTerm, TType> NEBBIJPAJAF(Dictionary<TTerm, TOutputSubstitution> HFDLMFINJMN, IEnumerable<KeyValuePair<TTerm, DCPGNDGGJEO<TType>>> LMPCFJNDMLG, OOONEHIPGKK IOBLLEKOCNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x40976D0", Offset = "0x40960D0", VA = "0x1840976D0")]
		private static OLCEOJBLPLC<TType> KEFLJLEFBAC(TOutputTerm JLAAKHANEHC, Dictionary<TTerm, TType> LMPCFJNDMLG, Dictionary<TTerm, TType> DNNINLMOCPD, OOONEHIPGKK IOBLLEKOCNN)
		{
			return default(OLCEOJBLPLC<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4096D70", Offset = "0x4095770", VA = "0x184096D70")]
		private static TOutputTerm HEBIIDDAFNP(TOutputTerm IDOPKLJHBBN, OOONEHIPGKK IOBLLEKOCNN)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2D80650", Offset = "0x2D7F050", VA = "0x182D80650")]
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
	[Cpp2IlInjected.Address(RVA = "0x3A36E90", Offset = "0x3A35890", VA = "0x183A36E90")]
	internal EIGJPCPJMLE(string KJPHMNNIMDP, [In] TType BDKHAKGONEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A36C40", Offset = "0x3A35640", VA = "0x183A36C40")]
	public bool ELNMFHABHNG([In] EIGJPCPJMLE<TType> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3A36DB0", Offset = "0x3A357B0", VA = "0x183A36DB0", Slot = "4")]
	public bool Equals(EIGJPCPJMLE<TType> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3A36D20", Offset = "0x3A35720", VA = "0x183A36D20", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x21B85A0", Offset = "0x21B6FA0", VA = "0x1821B85A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3A36E50", Offset = "0x3A35850", VA = "0x183A36E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3A36E00", Offset = "0x3A35800", VA = "0x183A36E00", Slot = "5")]
	private bool HGFOPICKBPB([In] EIGJPCPJMLE<TType> PLNBHPCFEOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DIGEPGIAJCL
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4DA0", Offset = "0x2BB37A0", VA = "0x182BB4DA0")]
	public static EIGJPCPJMLE<TType> GGBAHLJJLHO<TType>(string KJPHMNNIMDP, TType BDKHAKGONEH)
	{
		return default(EIGJPCPJMLE<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2BB4DD0", Offset = "0x2BB37D0", VA = "0x182BB4DD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1012BB0", Offset = "0x10115B0", VA = "0x181012BB0")]
	internal LMGAEAHCGDF(TNode KOHLOCENPAH, string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x44E5650", Offset = "0x44E4050", VA = "0x1844E5650")]
	public bool ELNMFHABHNG([In] LMGAEAHCGDF<TNode> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x44E5780", Offset = "0x44E4180", VA = "0x1844E5780", Slot = "4")]
	public bool Equals(LMGAEAHCGDF<TNode> PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3A36D20", Offset = "0x3A35720", VA = "0x183A36D20", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x44E5870", Offset = "0x44E4270", VA = "0x1844E5870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x44E58E0", Offset = "0x44E42E0", VA = "0x1844E58E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x44E57D0", Offset = "0x44E41D0", VA = "0x1844E57D0", Slot = "5")]
	private bool GBIJIIHLFLO([In] LMGAEAHCGDF<TNode> PLNBHPCFEOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NHCPDJLMKCI
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE8D0", Offset = "0x2EED2D0", VA = "0x182EEE8D0")]
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
