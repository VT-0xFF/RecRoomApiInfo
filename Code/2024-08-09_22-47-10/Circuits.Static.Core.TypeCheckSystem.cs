using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct PDCEHNNOBLI<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType CJOIENFDBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind NOBFBGDJKID;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1BC35B0", Offset = "0x1BC29B0", VA = "0x181BC35B0")]
	internal PDCEHNNOBLI(TType EPPKBKJHHHJ, IOKind CFLPNHLNJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47CEF40", Offset = "0x47CE340", VA = "0x1847CEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CGEKCIIGGPM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x295BEF0", Offset = "0x295B2F0", VA = "0x18295BEF0")]
	public static PDCEHNNOBLI<TType> DDEJLDFANAB<TType>(TType EPPKBKJHHHJ, IOKind CFLPNHLNJIB)
	{
		return default(PDCEHNNOBLI<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x295BF90", Offset = "0x295B390", VA = "0x18295BF90")]
	public static (TType, IOKind) PIILHOGBPJF<TType>([In] this PDCEHNNOBLI<TType> ABPJKOBADEP)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x295BF20", Offset = "0x295B320", VA = "0x18295BF20")]
	public static void JJDJPLPGAPJ<TType>([In] this PDCEHNNOBLI<TType> ABPJKOBADEP, [Out] TType EPPKBKJHHHJ, [Out] IOKind CFLPNHLNJIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct LKFFOMCCMHK<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LOBHPMFPDCF<TNode> NHPBFMFPBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LOBHPMFPDCF<TNode> JHKCDGNFFLL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4240590", Offset = "0x423F990", VA = "0x184240590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BOHPMINGNHH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28FE250", Offset = "0x28FD650", VA = "0x1828FE250")]
	public static (LOBHPMFPDCF<TNode>, LOBHPMFPDCF<TNode>) PIILHOGBPJF<TNode>([In] this LKFFOMCCMHK<TNode> ABPJKOBADEP)
	{
		return default((LOBHPMFPDCF<TNode>, LOBHPMFPDCF<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28FE150", Offset = "0x28FD550", VA = "0x1828FE150")]
	public static void JJDJPLPGAPJ<TNode>([In] this LKFFOMCCMHK<TNode> ABPJKOBADEP, [Out] LOBHPMFPDCF<TNode> JNFNBKNOBNN, [Out] LOBHPMFPDCF<TNode> CNFAHLDDGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CMFKEDGONOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DKMLFKGIFDL HFJBJILFNJO(TRoot MILPLABKJCF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType JBLNNOAFGIC(TRoot MILPLABKJCF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PDCEHNNOBLI<TType> KIHNODECAKJ(TRoot MILPLABKJCF, [In] PDCEHNNOBLI<TType> LJHBAHCCIGM, [In] PDCEHNNOBLI<TType> EFOLFMFJLOF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LEBEMBCCMNN(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TNode ILPFPPMNEDJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BJNJBDOLAGA(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TNode ILPFPPMNEDJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput MBHFJMOOPAF(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TNode ILPFPPMNEDJ, int AGAGKNBDCIG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int GCOHJOONPNC(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TNode ILPFPPMNEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput KNJBMOFICNP(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TNode ILPFPPMNEDJ, int AGAGKNBDCIG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<GAICODBGGBJ<TType>> PINNIOOENCA(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TNode ILPFPPMNEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<LKFFOMCCMHK<TNode>> DFPHNDAAIJC(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TNode ILPFPPMNEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType MLFAEPKNALM(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TInput BCPLMINPIEH);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int FPEBLFCLEHM(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TInput BCPLMINPIEH);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput NACNPGIAMJA(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TInput BCPLMINPIEH, int AGAGKNBDCIG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode KPOMLOLFPIN(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TInput BCPLMINPIEH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType IKLHLKFNGFC(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TOutput DKGIEBLFDJO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int KLODMBOBALL(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TOutput DKGIEBLFDJO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput IEKEADLLNBK(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TOutput DKGIEBLFDJO, int AGAGKNBDCIG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode MECGABNMNBC(TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, TOutput DKGIEBLFDJO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HIGDGIJKMAP(TRoot MILPLABKJCF, TType EPPKBKJHHHJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType IKKBACHLPNF(TRoot MILPLABKJCF, TType EPPKBKJHHHJ, IEnumerable<TType> KNPDMLKJHKJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GOAEFJKCFIH(TRoot MILPLABKJCF, TType EPPKBKJHHHJ, Action<TType> OMALMMAMBAB, Action<TType> DOFJMCCJCAH, Action<TType> HJFHFBFAAJE, Action<TType> AAELFJLCJIA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType GIMDFLEGDGO(TRoot MILPLABKJCF, TType EPPKBKJHHHJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string CCIOLLAKIIF(TRoot MILPLABKJCF, TType EPPKBKJHHHJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification GHGBCFAEBDJ(TRoot MILPLABKJCF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NNKIHJJJOOI<TOutputSubstitution[], NDGMACBFDAM> GNAAGLPKOHC(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm MBNIOPGDPJJ(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm HJLEGEBCKKJ(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TTerm DHOKAGKBPCJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm ECHHOPIJADL(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TTerm FIJIJLPKIHA, TTerm KFGKPLPCACH);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OHHNMNDOBLJ(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TTerm LJHBAHCCIGM, TTerm EFOLFMFJLOF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool IOLLJFDEDMK(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TOutputTerm LJAACKGKEOA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool NDEODOEHGOB(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TOutputTerm LJAACKGKEOA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm DIJGJALLLCA(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TOutputTerm LJAACKGKEOA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm ENNPNEEIBNA(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TOutputTerm LJAACKGKEOA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm OODIBIHKNEO(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TOutputTerm LJAACKGKEOA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm JDIFJPLIFIH(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TOutputSubstitution PHKKPLNMPOK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm MJNJFFLBELN(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TOutputSubstitution PHKKPLNMPOK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm LMCPEMKFDNH(TRoot MILPLABKJCF, TUnification GMDEJIOAHJD, TTerm DHOKAGKBPCJ);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MNCGKCABCED<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CMFKEDGONOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960")]
	public static global::MNCGKCABCED<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DDEJLDFANAB()
	{
		return default(global::MNCGKCABCED<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MGPBMGOJLAG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class OLMDLAAMLLF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CMFKEDGONOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class IHGAFFFJEDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot JIDLAENMFAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps LGBOJIHHEIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification HHNMHICIDNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph MNOFCFMNFPD;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public DKMLFKGIFDL AFKMNKCBEIB
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x3E49390", Offset = "0x3E48790", VA = "0x183E49390")]
				get
				{
					return default(DKMLFKGIFDL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3E4A710", Offset = "0x3E49B10", VA = "0x183E4A710")]
			private IHGAFFFJEDJ(TRoot MILPLABKJCF, TDeps GPENJAMDJGM, TUnification JFMJNKENPLJ, TGraph KHHCBCFNIBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3E48070", Offset = "0x3E47470", VA = "0x183E48070")]
			public static IHGAFFFJEDJ DDEJLDFANAB(TRoot MILPLABKJCF, TDeps GPENJAMDJGM, TUnification JFMJNKENPLJ, TGraph KHHCBCFNIBN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3E49110", Offset = "0x3E48510", VA = "0x183E49110")]
			public TType JBLNNOAFGIC()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3E493F0", Offset = "0x3E487F0", VA = "0x183E493F0")]
			public PDCEHNNOBLI<TType> KIHNODECAKJ(PDCEHNNOBLI<TType> LJHBAHCCIGM, PDCEHNNOBLI<TType> EFOLFMFJLOF)
			{
				return default(PDCEHNNOBLI<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3E49810", Offset = "0x3E48C10", VA = "0x183E49810")]
			public int LEBEMBCCMNN(TNode ILPFPPMNEDJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3E47DD0", Offset = "0x3E471D0", VA = "0x183E47DD0")]
			public int BJNJBDOLAGA(TNode ILPFPPMNEDJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3E49A10", Offset = "0x3E48E10", VA = "0x183E49A10")]
			public TInput MBHFJMOOPAF(TNode ILPFPPMNEDJ, int AGAGKNBDCIG)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3E48630", Offset = "0x3E47A30", VA = "0x183E48630")]
			public int GCOHJOONPNC(TNode ILPFPPMNEDJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3E495C0", Offset = "0x3E489C0", VA = "0x183E495C0")]
			public TOutput KNJBMOFICNP(TNode ILPFPPMNEDJ, int AGAGKNBDCIG)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3E4A6D0", Offset = "0x3E49AD0", VA = "0x183E4A6D0")]
			public IEnumerable<GAICODBGGBJ<TType>> PINNIOOENCA(TNode ILPFPPMNEDJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3E48290", Offset = "0x3E47690", VA = "0x183E48290")]
			public IEnumerable<LKFFOMCCMHK<TNode>> DFPHNDAAIJC([In] TNode ILPFPPMNEDJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3E49E10", Offset = "0x3E49210", VA = "0x183E49E10")]
			public TType MLFAEPKNALM(TInput BCPLMINPIEH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3E4A370", Offset = "0x3E49770", VA = "0x183E4A370")]
			public int OIAMOEMHGMK(TInput BCPLMINPIEH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3E49F20", Offset = "0x3E49320", VA = "0x183E49F20")]
			public TOutput NACNPGIAMJA(TInput BCPLMINPIEH, int AGAGKNBDCIG)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3E49700", Offset = "0x3E48B00", VA = "0x183E49700")]
			public TNode KPOMLOLFPIN(TInput BCPLMINPIEH)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3E48ED0", Offset = "0x3E482D0", VA = "0x183E48ED0")]
			public TType IKLHLKFNGFC(TOutput DKGIEBLFDJO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3E4A5D0", Offset = "0x3E499D0", VA = "0x183E4A5D0")]
			public int PCMLMDIGEPE(TOutput DKGIEBLFDJO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3E48DC0", Offset = "0x3E481C0", VA = "0x183E48DC0")]
			public TInput IEKEADLLNBK(TOutput DKGIEBLFDJO, int AGAGKNBDCIG)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3E49C40", Offset = "0x3E49040", VA = "0x183E49C40")]
			public TNode MECGABNMNBC(TOutput DKGIEBLFDJO)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3E48AA0", Offset = "0x3E47EA0", VA = "0x183E48AA0")]
			public bool HIGDGIJKMAP(TType EPPKBKJHHHJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3E48E10", Offset = "0x3E48210", VA = "0x183E48E10")]
			public TType IKKBACHLPNF(TType EPPKBKJHHHJ, IEnumerable<TType> KNPDMLKJHKJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3E48940", Offset = "0x3E47D40", VA = "0x183E48940")]
			public void GOAEFJKCFIH(TType EPPKBKJHHHJ, Action<TType> OMALMMAMBAB, Action<TType> DOFJMCCJCAH, Action<TType> HJFHFBFAAJE, Action<TType> AAELFJLCJIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3E48730", Offset = "0x3E47B30", VA = "0x183E48730")]
			public TType GIMDFLEGDGO(TType EPPKBKJHHHJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3E47F20", Offset = "0x3E47320", VA = "0x183E47F20")]
			public string CCIOLLAKIIF(TType EPPKBKJHHHJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3E49BC0", Offset = "0x3E48FC0", VA = "0x183E49BC0")]
			public TTerm MBNIOPGDPJJ()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3E48BB0", Offset = "0x3E47FB0", VA = "0x183E48BB0")]
			public TTerm HJLEGEBCKKJ(TTerm DHOKAGKBPCJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3E483E0", Offset = "0x3E477E0", VA = "0x183E483E0")]
			public TTerm ECHHOPIJADL(TTerm FIJIJLPKIHA, TTerm KFGKPLPCACH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3E4A2B0", Offset = "0x3E496B0", VA = "0x183E4A2B0")]
			public void OHHNMNDOBLJ(TTerm LJHBAHCCIGM, TTerm EFOLFMFJLOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3E4A140", Offset = "0x3E49540", VA = "0x183E4A140")]
			public bool NDEODOEHGOB(TOutputTerm DHOKAGKBPCJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3E49060", Offset = "0x3E48460", VA = "0x183E49060")]
			public bool IOLLJFDEDMK(TOutputTerm DHOKAGKBPCJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3E489E0", Offset = "0x3E47DE0", VA = "0x183E489E0")]
			public TTerm HDPDMMOHJJJ(TOutputTerm LJAACKGKEOA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3E485F0", Offset = "0x3E479F0", VA = "0x183E485F0")]
			public TOutputTerm ENNPNEEIBNA(TOutputTerm DHOKAGKBPCJ)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3E4A4C0", Offset = "0x3E498C0", VA = "0x183E4A4C0")]
			public TOutputTerm OODIBIHKNEO(TOutputTerm DHOKAGKBPCJ)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3E49210", Offset = "0x3E48610", VA = "0x183E49210")]
			public TTerm JDIFJPLIFIH(TOutputSubstitution NMNBPDILMHC)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3E49D50", Offset = "0x3E49150", VA = "0x183E49D50")]
			public TOutputTerm MJNJFFLBELN(TOutputSubstitution NMNBPDILMHC)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3E49950", Offset = "0x3E48D50", VA = "0x183E49950")]
			public TOutputTerm LMCPEMKFDNH(TTerm DHOKAGKBPCJ)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class CJBDMHGHIKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IHGAFFFJEDJ arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public CJBDMHGHIKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5030520", Offset = "0x502F920", VA = "0x185030520")]
			internal int GBFAPOFLOAM(IHGAFFFJEDJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5030790", Offset = "0x502FB90", VA = "0x185030790")]
			internal TInput PBDHOHMFFGC(IHGAFFFJEDJ arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5030730", Offset = "0x502FB30", VA = "0x185030730")]
			internal int IIJDNILOLBD(IHGAFFFJEDJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5030600", Offset = "0x502FA00", VA = "0x185030600")]
			internal TOutput GIBKINDDKBJ(IHGAFFFJEDJ arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NMBEIPJIIBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public IHGAFFFJEDJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, LOBHPMFPDCF<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<LOBHPMFPDCF<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public NMBEIPJIIBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4530E90", Offset = "0x4530290", VA = "0x184530E90")]
			internal (string, TTerm) AJDIABOBPHJ(GAICODBGGBJ<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class AEILGFGGNDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IHGAFFFJEDJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public AEILGFGGNDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3CCB7D0", Offset = "0x3CCABD0", VA = "0x183CCB7D0")]
			internal void HBCPDKBCBAO(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3CCC120", Offset = "0x3CCB520", VA = "0x183CCC120")]
			internal void PCAEAOJFCCD(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3CCBF20", Offset = "0x3CCB320", VA = "0x183CCBF20")]
			internal void LKMKMHLHHKO(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3CCB640", Offset = "0x3CCAA40", VA = "0x183CCB640")]
			internal void APMBFGKBPFF(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OHNLNEPMPCJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public IHGAFFFJEDJ arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public OHNLNEPMPCJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3D65580", Offset = "0x3D64980", VA = "0x183D65580")]
			internal TTerm OMKHDANEFCI(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4718760", Offset = "0x4717B60", VA = "0x184718760")]
		private static FHDCIKFFLBO GPGMPNKPAJP([CallerMemberName] string FIKHOKLHCII = "")
		{
			return default(FHDCIKFFLBO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x471C180", Offset = "0x471B580", VA = "0x18471C180")]
		public static Dictionary<TNode, List<GAICODBGGBJ<TType>>> JKPONADOFJE(TRoot MILPLABKJCF, TDeps GPENJAMDJGM, TGraph KHHCBCFNIBN, IEnumerable<TNode> LPNMGCMAJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x471FC50", Offset = "0x471F050", VA = "0x18471FC50")]
		private static (Dictionary<TTerm, LOBHPMFPDCF<TNode>>, List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>>) OGEFPLMLEFH(IEnumerable<TNode> LPNMGCMAJOP, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return default((Dictionary<TTerm, LOBHPMFPDCF<TNode>>, List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x47194F0", Offset = "0x47188F0", VA = "0x1847194F0")]
		private static void HJAKIOPAELN(TNode ILPFPPMNEDJ, Dictionary<TInput, TTerm> LNLHPGKBDNM, Dictionary<TOutput, TTerm> AJHEANJOONC, Dictionary<TTerm, LOBHPMFPDCF<TNode>> PONNFPANJKL, Dictionary<LOBHPMFPDCF<TNode>, TTerm> KKIFAFHMLDA, List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> CELMCJBEIKM, Stack<TNode> HFNDOENKJFF, List<LKFFOMCCMHK<TNode>> AMIJHMILIGP, IHGAFFFJEDJ PEGMNLKCILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x47145B0", Offset = "0x47139B0", VA = "0x1847145B0")]
		private static Dictionary<string, TTerm> EPINDAIMDHJ(TNode ILPFPPMNEDJ, Dictionary<TTerm, LOBHPMFPDCF<TNode>> PONNFPANJKL, Dictionary<LOBHPMFPDCF<TNode>, TTerm> LIIBCKONIKN, List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> CELMCJBEIKM, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2C01B00", Offset = "0x2C00F00", VA = "0x182C01B00")]
		private static (TPort, TTerm)[] APGEMCGJAJM<TPort>(TNode ILPFPPMNEDJ, Func<IHGAFFFJEDJ, TNode, int> CNFKGGJAEAN, Func<IHGAFFFJEDJ, TNode, int, TPort> FAOPHMAKFMJ, Func<IHGAFFFJEDJ, TPort, TType> BGKFMDPJILF, Dictionary<TPort, TTerm> APCCCMBFHCC, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4716870", Offset = "0x4715C70", VA = "0x184716870")]
		private static (TTerm, TTerm) GFKIGHAACAL((TOutput Output, TTerm Id)[] JGFPDEKBLBG, List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> CELMCJBEIKM, Dictionary<string, TTerm> LIIBCKONIKN, Stack<TNode> HFNDOENKJFF, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4711D10", Offset = "0x4711110", VA = "0x184711D10")]
		private static void DOMBABPPBGN((TInput PortKey, TTerm Id)[] BFGMEIFFLLC, TTerm HOLPDNLGFNL, TTerm LNBOMJLMBIP, List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> CELMCJBEIKM, Dictionary<TOutput, TTerm> AJHEANJOONC, Dictionary<string, TTerm> LIIBCKONIKN, Stack<TNode> HFNDOENKJFF, IHGAFFFJEDJ PEGMNLKCILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x47181E0", Offset = "0x47175E0", VA = "0x1847181E0")]
		private static TTerm GLIKNFIDIAK(TInput BCPLMINPIEH, List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> CELMCJBEIKM, Dictionary<TOutput, TTerm> AJHEANJOONC, Stack<TNode> HFNDOENKJFF, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x471AE50", Offset = "0x471A250", VA = "0x18471AE50")]
		private static TTerm IMAJGJJPLPA([In] TType EPPKBKJHHHJ, IOKind CFLPNHLNJIB, List<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> CELMCJBEIKM, IReadOnlyDictionary<string, TTerm> LIIBCKONIKN, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x470E760", Offset = "0x470DB60", VA = "0x18470E760")]
		private static Dictionary<TNode, List<GAICODBGGBJ<TType>>> ANGBPDMLCFO(TOutputSubstitution[] HIBGNNPCJIC, Dictionary<TTerm, LOBHPMFPDCF<TNode>> PONNFPANJKL, IEnumerable<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> CELMCJBEIKM, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x470BB10", Offset = "0x470AF10", VA = "0x18470BB10")]
		private static Dictionary<TNode, List<GAICODBGGBJ<TType>>> AAACLGBDACP(Dictionary<TTerm, LOBHPMFPDCF<TNode>> PONNFPANJKL, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4710990", Offset = "0x470FD90", VA = "0x184710990")]
		private static void CBACMDPCMMC([In] TNode ILPFPPMNEDJ, Stack<TNode> HFNDOENKJFF, List<LKFFOMCCMHK<TNode>> AMIJHMILIGP, IHGAFFFJEDJ PEGMNLKCILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4711810", Offset = "0x4710C10", VA = "0x184711810")]
		private static void DFLFBEJCNFO(Dictionary<LOBHPMFPDCF<TNode>, TTerm> LIIBCKONIKN, List<LKFFOMCCMHK<TNode>> AMIJHMILIGP, IHGAFFFJEDJ PEGMNLKCILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x471C810", Offset = "0x471BC10", VA = "0x18471C810")]
		private static Dictionary<TTerm, TType> LFLCIEMLOFI(Dictionary<TTerm, TOutputSubstitution> HIBGNNPCJIC, IEnumerable<KeyValuePair<TTerm, PDCEHNNOBLI<TType>>> CELMCJBEIKM, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x470C920", Offset = "0x470BD20", VA = "0x18470C920")]
		private static DMABLNOGLNN<TType> AFGGKGLDPOE(TOutputTerm EPPKBKJHHHJ, Dictionary<TTerm, TType> CELMCJBEIKM, Dictionary<TTerm, TType> DKPFLLMGALD, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return default(DMABLNOGLNN<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x471FAF0", Offset = "0x471EEF0", VA = "0x18471FAF0")]
		private static TOutputTerm NIIECNJBBJG(TOutputTerm KJLLGFBKPLP, IHGAFFFJEDJ PEGMNLKCILJ)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C53240", Offset = "0x2C52640", VA = "0x182C53240")]
	public static Dictionary<TNode, List<GAICODBGGBJ<TType>>> JKPONADOFJE<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::MNCGKCABCED<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> ABPJKOBADEP, TRoot MILPLABKJCF, TGraph KHHCBCFNIBN, IEnumerable<TNode> LPNMGCMAJOP) where TDeps : global::CMFKEDGONOE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct GAICODBGGBJ<TType> : IEquatable<GAICODBGGBJ<TType>>, LIGCMNKHPCN<GAICODBGGBJ<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string KHPOGHNODCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType CAIAAJGGFCO;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9F10", Offset = "0x3CE9310", VA = "0x183CE9F10")]
	internal GAICODBGGBJ(string FIKHOKLHCII, [In] TType LMBKJMLBPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9CC0", Offset = "0x3CE90C0", VA = "0x183CE9CC0")]
	public bool EJHKLDLMEAH([In] GAICODBGGBJ<TType> IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9DA0", Offset = "0x3CE91A0", VA = "0x183CE9DA0", Slot = "4")]
	public bool Equals(GAICODBGGBJ<TType> IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9DF0", Offset = "0x3CE91F0", VA = "0x183CE9DF0", Slot = "0")]
	public override bool Equals(object IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2049120", Offset = "0x2048520", VA = "0x182049120", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9ED0", Offset = "0x3CE92D0", VA = "0x183CE9ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9E80", Offset = "0x3CE9280", VA = "0x183CE9E80", Slot = "5")]
	private bool HMMBPLKANOB([In] GAICODBGGBJ<TType> IEDCHGMDIML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PMIBFPGPIFK
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E370", Offset = "0x2D3D770", VA = "0x182D3E370")]
	public static GAICODBGGBJ<TType> DDEJLDFANAB<TType>(string FIKHOKLHCII, TType LMBKJMLBPMH)
	{
		return default(GAICODBGGBJ<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2D3E3A0", Offset = "0x2D3D7A0", VA = "0x182D3E3A0")]
	public static (string, TType) PIILHOGBPJF<TType>([In] this GAICODBGGBJ<TType> ABPJKOBADEP)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LOBHPMFPDCF<TNode> : IEquatable<LOBHPMFPDCF<TNode>>, LIGCMNKHPCN<LOBHPMFPDCF<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode DKJHLMGPNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string KHPOGHNODCD;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xEAD7B0", Offset = "0xEACBB0", VA = "0x180EAD7B0")]
	internal LOBHPMFPDCF(TNode ILPFPPMNEDJ, string FIKHOKLHCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x426C580", Offset = "0x426B980", VA = "0x18426C580")]
	public bool EJHKLDLMEAH([In] LOBHPMFPDCF<TNode> IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x426C660", Offset = "0x426BA60", VA = "0x18426C660", Slot = "4")]
	public bool Equals(LOBHPMFPDCF<TNode> IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9DF0", Offset = "0x3CE91F0", VA = "0x183CE9DF0", Slot = "0")]
	public override bool Equals(object IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x426C700", Offset = "0x426BB00", VA = "0x18426C700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x426C770", Offset = "0x426BB70", VA = "0x18426C770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x426C400", Offset = "0x426B800", VA = "0x18426C400", Slot = "5")]
	private bool CNLOEAKBPAN([In] LOBHPMFPDCF<TNode> IEDCHGMDIML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PHDAGIMKEEF
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2D3AEA0", Offset = "0x2D3A2A0", VA = "0x182D3AEA0")]
	public static LOBHPMFPDCF<TNode> DDEJLDFANAB<TNode>(TNode ILPFPPMNEDJ, string FIKHOKLHCII)
	{
		return default(LOBHPMFPDCF<TNode>);
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
