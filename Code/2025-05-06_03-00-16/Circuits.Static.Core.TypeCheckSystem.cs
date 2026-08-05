using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct DPNLABCEGEP<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType PALJBODIBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind CENFLLMJGJC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xBFDCC0", Offset = "0xBFC4C0", VA = "0x180BFDCC0")]
	internal DPNLABCEGEP(TType PIJHKCJDAHO, IOKind DEFHNJGHJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68EF0F0", Offset = "0x68ED8F0", VA = "0x1868EF0F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KCBHNCBHGAF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3832AD0", Offset = "0x38312D0", VA = "0x183832AD0")]
	public static DPNLABCEGEP<TType> CJOJELENPLJ<TType>(TType PIJHKCJDAHO, IOKind DEFHNJGHJCH)
	{
		return default(DPNLABCEGEP<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3832B70", Offset = "0x3831370", VA = "0x183832B70")]
	public static (TType, IOKind) MMLMMKPFOCC<TType>([In] this DPNLABCEGEP<TType> NFOGFJOGLPE)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3832B00", Offset = "0x3831300", VA = "0x183832B00")]
	public static void GBLJIMIKPOB<TType>([In] this DPNLABCEGEP<TType> NFOGFJOGLPE, [Out] TType PIJHKCJDAHO, [Out] IOKind DEFHNJGHJCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct MNPFPMJBFGO<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly OJDDJIOHEDA<TNode> CMNBEIHGCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly OJDDJIOHEDA<TNode> OIJMGMCPNCF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5298140", Offset = "0x5296940", VA = "0x185298140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OHABFDCIFGK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x395E8F0", Offset = "0x395D0F0", VA = "0x18395E8F0")]
	public static (OJDDJIOHEDA<TNode>, OJDDJIOHEDA<TNode>) MMLMMKPFOCC<TNode>([In] this MNPFPMJBFGO<TNode> NFOGFJOGLPE)
	{
		return default((OJDDJIOHEDA<TNode>, OJDDJIOHEDA<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x395E7F0", Offset = "0x395CFF0", VA = "0x18395E7F0")]
	public static void GBLJIMIKPOB<TNode>([In] this MNPFPMJBFGO<TNode> NFOGFJOGLPE, [Out] OJDDJIOHEDA<TNode> HKAFAMHBCLL, [Out] OJDDJIOHEDA<TNode> JAKFFJGMBEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OMGOOPKPJNO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OFAPNEPKMDG EHJFFDAPEHI(TRoot PNDCHGJLEGG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType IEOFAOOODOO(TRoot PNDCHGJLEGG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPNLABCEGEP<TType> CKHPIJGBLHL(TRoot PNDCHGJLEGG, [In] DPNLABCEGEP<TType> ANGFJALIIBO, [In] DPNLABCEGEP<TType> LNEMONKDKMJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OINNHFDLMLG(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TNode GDFCBMOFMFN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NDIMDCHCHLK(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TNode GDFCBMOFMFN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput COHHHAFBHJA(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TNode GDFCBMOFMFN, int FPEOONOJHML);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EGCEFGEAGMJ(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TNode GDFCBMOFMFN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput IMMCMOGCOFO(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TNode GDFCBMOFMFN, int FPEOONOJHML);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IJGNOPHNMDK<TType>> JCJHDHCONFF(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TNode GDFCBMOFMFN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<MNPFPMJBFGO<TNode>> MHDECJKMEBM(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TNode GDFCBMOFMFN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType AGFKCHGOMKH(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TInput JEOEDPICHHI);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int NLNKHJJKAAF(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TInput JEOEDPICHHI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput MGMAFIJKCPP(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TInput JEOEDPICHHI, int FPEOONOJHML);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode IBOEHGMOMGE(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TInput JEOEDPICHHI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType ODIJHHJIEAB(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TOutput ENLECGNCFFO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int AOOLIABKEKO(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TOutput ENLECGNCFFO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput KFDCKIMAKDK(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TOutput ENLECGNCFFO, int FPEOONOJHML);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode BKGAFKFELPK(TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, TOutput ENLECGNCFFO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OCCHLHIIFFA(TRoot PNDCHGJLEGG, TType PIJHKCJDAHO);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType FHDBCKBNMEE(TRoot PNDCHGJLEGG, TType PIJHKCJDAHO, IEnumerable<TType> DBCKMFCHJJI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MDHEFOIMGFL(TRoot PNDCHGJLEGG, TType PIJHKCJDAHO, Action<TType> FKPHEGFJAGO, Action<TType> LFCHDONPGFL, Action<TType> NBCBNIFAFMC, Action<TType> JCFFMINFPJD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType CHJMHMNNMJG(TRoot PNDCHGJLEGG, TType PIJHKCJDAHO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string AALNAGBONAL(TRoot PNDCHGJLEGG, TType PIJHKCJDAHO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification CLEFOKHCDOP(TRoot PNDCHGJLEGG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	HCGBMJDNFKJ<TOutputSubstitution[], PLLAIPNOLPG> FBMFIPOONFC(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm LGNGDJEMKCL(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm CBKLLCJJEDH(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TTerm PAIAOFCOJCE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm JIIKFJAFKGL(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TTerm MCBIGGDDMJN, TTerm FCJOOPHGPGB);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IJCNPFAHPCJ(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TTerm ANGFJALIIBO, TTerm LNEMONKDKMJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool LGLOPOOJACM(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TOutputTerm IBJMKHINIBJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CHLHMICECJD(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TOutputTerm IBJMKHINIBJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm IPNBABMOFIN(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TOutputTerm IBJMKHINIBJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm AIFEMIOMCFP(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TOutputTerm IBJMKHINIBJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm MCOHOKPJICD(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TOutputTerm IBJMKHINIBJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm PFLAJAKDFGG(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TOutputSubstitution LLCKABDCBIF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm KFKPIGACDMP(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TOutputSubstitution LLCKABDCBIF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm MLPJIIJHPOD(TRoot PNDCHGJLEGG, TUnification AGAMPLKDEJL, TTerm PAIAOFCOJCE);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct JCFOIGJBJAO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::OMGOOPKPJNO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
	public static global::JCFOIGJBJAO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> CJOJELENPLJ()
	{
		return default(global::JCFOIGJBJAO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EOBIKOKLIHF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class DBILCLKGPPN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::OMGOOPKPJNO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class BNNLDLNFMII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot DFJAHCLMMPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps GJAOBEFNFMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification IIMCHNAJJPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph NDCOLJDNELC;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public OFAPNEPKMDG FFNGEFPCBMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x6015AC0", Offset = "0x60142C0", VA = "0x186015AC0")]
				get
				{
					return default(OFAPNEPKMDG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6016900", Offset = "0x6015100", VA = "0x186016900")]
			private BNNLDLNFMII(TRoot PNDCHGJLEGG, TDeps ILEBEOADOPL, TUnification CFNHIGBJOJO, TGraph LJMFKPGJJNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6014600", Offset = "0x6012E00", VA = "0x186014600")]
			public static BNNLDLNFMII CJOJELENPLJ(TRoot PNDCHGJLEGG, TDeps ILEBEOADOPL, TUnification CFNHIGBJOJO, TGraph LJMFKPGJJNC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6014FF0", Offset = "0x60137F0", VA = "0x186014FF0")]
			public TType IEOFAOOODOO()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6014930", Offset = "0x6013130", VA = "0x186014930")]
			public DPNLABCEGEP<TType> CKHPIJGBLHL(DPNLABCEGEP<TType> ANGFJALIIBO, DPNLABCEGEP<TType> LNEMONKDKMJ)
			{
				return default(DPNLABCEGEP<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6016600", Offset = "0x6014E00", VA = "0x186016600")]
			public int OINNHFDLMLG(TNode GDFCBMOFMFN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x60162A0", Offset = "0x6014AA0", VA = "0x1860162A0")]
			public int NDIMDCHCHLK(TNode GDFCBMOFMFN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6014BE0", Offset = "0x60133E0", VA = "0x186014BE0")]
			public TInput COHHHAFBHJA(TNode GDFCBMOFMFN, int FPEOONOJHML)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6014CF0", Offset = "0x60134F0", VA = "0x186014CF0")]
			public int EGCEFGEAGMJ(TNode GDFCBMOFMFN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6015220", Offset = "0x6013A20", VA = "0x186015220")]
			public TOutput IMMCMOGCOFO(TNode GDFCBMOFMFN, int FPEOONOJHML)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6015390", Offset = "0x6013B90", VA = "0x186015390")]
			public IEnumerable<IJGNOPHNMDK<TType>> JCJHDHCONFF(TNode GDFCBMOFMFN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6016050", Offset = "0x6014850", VA = "0x186016050")]
			public IEnumerable<MNPFPMJBFGO<TNode>> MHDECJKMEBM([In] TNode GDFCBMOFMFN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6013FF0", Offset = "0x60127F0", VA = "0x186013FF0")]
			public TType AGFKCHGOMKH(TInput JEOEDPICHHI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x60160E0", Offset = "0x60148E0", VA = "0x1860160E0")]
			public int MKPLDPPPFHH(TInput JEOEDPICHHI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6015EB0", Offset = "0x60146B0", VA = "0x186015EB0")]
			public TOutput MGMAFIJKCPP(TInput JEOEDPICHHI, int FPEOONOJHML)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6014E40", Offset = "0x6013640", VA = "0x186014E40")]
			public TNode IBOEHGMOMGE(TInput JEOEDPICHHI)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6016530", Offset = "0x6014D30", VA = "0x186016530")]
			public TType ODIJHHJIEAB(TOutput ENLECGNCFFO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6015860", Offset = "0x6014060", VA = "0x186015860")]
			public int KOOMIIIMPCF(TOutput ENLECGNCFFO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6015570", Offset = "0x6013D70", VA = "0x186015570")]
			public TInput KFDCKIMAKDK(TOutput ENLECGNCFFO, int FPEOONOJHML)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x60142D0", Offset = "0x6012AD0", VA = "0x1860142D0")]
			public TNode BKGAFKFELPK(TOutput ENLECGNCFFO)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x60163A0", Offset = "0x6014BA0", VA = "0x1860163A0")]
			public bool OCCHLHIIFFA(TType PIJHKCJDAHO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6014DB0", Offset = "0x60135B0", VA = "0x186014DB0")]
			public TType FHDBCKBNMEE(TType PIJHKCJDAHO, IEnumerable<TType> DBCKMFCHJJI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6015CB0", Offset = "0x60144B0", VA = "0x186015CB0")]
			public void MDHEFOIMGFL(TType PIJHKCJDAHO, Action<TType> FKPHEGFJAGO, Action<TType> LFCHDONPGFL, Action<TType> NBCBNIFAFMC, Action<TType> JCFFMINFPJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6014480", Offset = "0x6012C80", VA = "0x186014480")]
			public TType CHJMHMNNMJG(TType PIJHKCJDAHO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6013EE0", Offset = "0x60126E0", VA = "0x186013EE0")]
			public string AALNAGBONAL(TType PIJHKCJDAHO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6015A50", Offset = "0x6014250", VA = "0x186015A50")]
			public TTerm LGNGDJEMKCL()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x60143D0", Offset = "0x6012BD0", VA = "0x1860143D0")]
			public TTerm CBKLLCJJEDH(TTerm PAIAOFCOJCE)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x60153D0", Offset = "0x6013BD0", VA = "0x1860153D0")]
			public TTerm JIIKFJAFKGL(TTerm MCBIGGDDMJN, TTerm FCJOOPHGPGB)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6015150", Offset = "0x6013950", VA = "0x186015150")]
			public void IJCNPFAHPCJ(TTerm ANGFJALIIBO, TTerm LNEMONKDKMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x60145C0", Offset = "0x6012DC0", VA = "0x1860145C0")]
			public bool CHLHMICECJD(TOutputTerm PAIAOFCOJCE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6015960", Offset = "0x6014160", VA = "0x186015960")]
			public bool LGLOPOOJACM(TOutputTerm PAIAOFCOJCE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6016840", Offset = "0x6015040", VA = "0x186016840")]
			public TTerm PPKDLMMKDLD(TOutputTerm IBJMKHINIBJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6014100", Offset = "0x6012900", VA = "0x186014100")]
			public TOutputTerm AIFEMIOMCFP(TOutputTerm PAIAOFCOJCE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6015BB0", Offset = "0x60143B0", VA = "0x186015BB0")]
			public TOutputTerm MCOHOKPJICD(TOutputTerm PAIAOFCOJCE)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x60166C0", Offset = "0x6014EC0", VA = "0x1860166C0")]
			public TTerm PFLAJAKDFGG(TOutputSubstitution HDBFMGMOEGH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x60156D0", Offset = "0x6013ED0", VA = "0x1860156D0")]
			public TOutputTerm KFKPIGACDMP(TOutputSubstitution HDBFMGMOEGH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x60161A0", Offset = "0x60149A0", VA = "0x1860161A0")]
			public TOutputTerm MLPJIIJHPOD(TTerm PAIAOFCOJCE)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class EMBPKBKHPLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public BNNLDLNFMII arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public EMBPKBKHPLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x442BD40", Offset = "0x442A540", VA = "0x18442BD40")]
			internal int ACCADMIPCFI(BNNLDLNFMII arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x442BF70", Offset = "0x442A770", VA = "0x18442BF70")]
			internal TInput KLCJGCEHFAH(BNNLDLNFMII arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x442C0A0", Offset = "0x442A8A0", VA = "0x18442C0A0")]
			internal int OKCACJNMENB(BNNLDLNFMII arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x442BDA0", Offset = "0x442A5A0", VA = "0x18442BDA0")]
			internal TOutput JBICAJEJOMC(BNNLDLNFMII arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JGBMHJIGMNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public BNNLDLNFMII arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, OJDDJIOHEDA<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<OJDDJIOHEDA<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public JGBMHJIGMNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4D68300", Offset = "0x4D66B00", VA = "0x184D68300")]
			internal (string, TTerm) PJPHIBDADOK(IJGNOPHNMDK<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GIDFJIKKAKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public BNNLDLNFMII arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public GIDFJIKKAKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x49B1C10", Offset = "0x49B0410", VA = "0x1849B1C10")]
			internal void BIKNFKBIMIJ(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x49B2880", Offset = "0x49B1080", VA = "0x1849B2880")]
			internal void NGMNBJBACJK(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x49B2470", Offset = "0x49B0C70", VA = "0x1849B2470")]
			internal void MHPJFBJMLDH(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x49B2150", Offset = "0x49B0950", VA = "0x1849B2150")]
			internal void MFEAELJKCMI(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class OJHIHIACCLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public BNNLDLNFMII arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public OJHIHIACCLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4979A00", Offset = "0x4978200", VA = "0x184979A00")]
			internal TTerm HNILNLEJBNG(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68B6FC0", Offset = "0x68B57C0", VA = "0x1868B6FC0")]
		private static MINEABMMGIB MNAPCBHEONF([CallerMemberName] string GLGOHIJMLFB = "")
		{
			return default(MINEABMMGIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x68B33D0", Offset = "0x68B1BD0", VA = "0x1868B33D0")]
		public static Dictionary<TNode, List<IJGNOPHNMDK<TType>>> LKJBDHBGOJN(TRoot PNDCHGJLEGG, TDeps ILEBEOADOPL, TGraph LJMFKPGJJNC, IEnumerable<TNode> CHHNLHCEBAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68ACB70", Offset = "0x68AB370", VA = "0x1868ACB70")]
		private static (Dictionary<TTerm, OJDDJIOHEDA<TNode>>, List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>>) EEHGDCFPBDE(IEnumerable<TNode> CHHNLHCEBAM, BNNLDLNFMII MJAILKMLAHP)
		{
			return default((Dictionary<TTerm, OJDDJIOHEDA<TNode>>, List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68AA1E0", Offset = "0x68A89E0", VA = "0x1868AA1E0")]
		private static void DNCPOGMLJCG(TNode GDFCBMOFMFN, Dictionary<TInput, TTerm> CIBFFBKMHBC, Dictionary<TOutput, TTerm> PMJDFLHGDJD, Dictionary<TTerm, OJDDJIOHEDA<TNode>> ADIAPFLLFJG, Dictionary<OJDDJIOHEDA<TNode>, TTerm> NGNOCAGMCGK, List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> HODDLFPDDBE, Stack<TNode> MBFCHCDPGMA, List<MNPFPMJBFGO<TNode>> OKFNBMBCDNO, BNNLDLNFMII MJAILKMLAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68A5FC0", Offset = "0x68A47C0", VA = "0x1868A5FC0")]
		private static Dictionary<string, TTerm> DHHBIDCHHGE(TNode GDFCBMOFMFN, Dictionary<TTerm, OJDDJIOHEDA<TNode>> ADIAPFLLFJG, Dictionary<OJDDJIOHEDA<TNode>, TTerm> HKJIGDKOAID, List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> HODDLFPDDBE, BNNLDLNFMII MJAILKMLAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3856D60", Offset = "0x3855560", VA = "0x183856D60")]
		private static (TPort, TTerm)[] CBDNFJHAJFK<TPort>(TNode GDFCBMOFMFN, Func<BNNLDLNFMII, TNode, int> DNCLJFEKKIB, Func<BNNLDLNFMII, TNode, int, TPort> IIEFKDOKIII, Func<BNNLDLNFMII, TPort, TType> EPLIKKPDDDI, Dictionary<TPort, TTerm> FAKLHADICJE, BNNLDLNFMII MJAILKMLAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68B4D60", Offset = "0x68B3560", VA = "0x1868B4D60")]
		private static (TTerm, TTerm) LNPNNFNHMFD((TOutput Output, TTerm Id)[] DKIIEIBDPOD, List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> HODDLFPDDBE, Dictionary<string, TTerm> HKJIGDKOAID, Stack<TNode> MBFCHCDPGMA, BNNLDLNFMII MJAILKMLAHP)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68AF200", Offset = "0x68ADA00", VA = "0x1868AF200")]
		private static void FDKECLNEMJB((TInput PortKey, TTerm Id)[] FDHEHNFLELM, TTerm GHICKGEHGDH, TTerm ICAOHMDBEOA, List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> HODDLFPDDBE, Dictionary<TOutput, TTerm> PMJDFLHGDJD, Dictionary<string, TTerm> HKJIGDKOAID, Stack<TNode> MBFCHCDPGMA, BNNLDLNFMII MJAILKMLAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x68B0C90", Offset = "0x68AF490", VA = "0x1868B0C90")]
		private static TTerm GCIPIGJLAPH(TInput JEOEDPICHHI, List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> HODDLFPDDBE, Dictionary<TOutput, TTerm> PMJDFLHGDJD, Stack<TNode> MBFCHCDPGMA, BNNLDLNFMII MJAILKMLAHP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x68B6970", Offset = "0x68B5170", VA = "0x1868B6970")]
		private static TTerm MFCIOOMDBGA([In] TType PIJHKCJDAHO, IOKind DEFHNJGHJCH, List<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> HODDLFPDDBE, IReadOnlyDictionary<string, TTerm> HKJIGDKOAID, BNNLDLNFMII MJAILKMLAHP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68A62F0", Offset = "0x68A4AF0", VA = "0x1868A62F0")]
		private static Dictionary<TNode, List<IJGNOPHNMDK<TType>>> DKGACOHJOJA(TOutputSubstitution[] OMAEDFAIDNM, Dictionary<TTerm, OJDDJIOHEDA<TNode>> ADIAPFLLFJG, IEnumerable<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> HODDLFPDDBE, BNNLDLNFMII MJAILKMLAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68A57D0", Offset = "0x68A3FD0", VA = "0x1868A57D0")]
		private static Dictionary<TNode, List<IJGNOPHNMDK<TType>>> ABNAIOHKLKA(Dictionary<TTerm, OJDDJIOHEDA<TNode>> ADIAPFLLFJG, BNNLDLNFMII MJAILKMLAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x68AFF60", Offset = "0x68AE760", VA = "0x1868AFF60")]
		private static void FILFOBCOALC([In] TNode GDFCBMOFMFN, Stack<TNode> MBFCHCDPGMA, List<MNPFPMJBFGO<TNode>> OKFNBMBCDNO, BNNLDLNFMII MJAILKMLAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x68B22A0", Offset = "0x68B0AA0", VA = "0x1868B22A0")]
		private static void HKDMPGCAIOI(Dictionary<OJDDJIOHEDA<TNode>, TTerm> HKJIGDKOAID, List<MNPFPMJBFGO<TNode>> OKFNBMBCDNO, BNNLDLNFMII MJAILKMLAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68B8020", Offset = "0x68B6820", VA = "0x1868B8020")]
		private static Dictionary<TTerm, TType> OIMKPAHFJJF(Dictionary<TTerm, TOutputSubstitution> OMAEDFAIDNM, IEnumerable<KeyValuePair<TTerm, DPNLABCEGEP<TType>>> HODDLFPDDBE, BNNLDLNFMII MJAILKMLAHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68BA000", Offset = "0x68B8800", VA = "0x1868BA000")]
		private static PPKNIFNDLFA<TType> PBCIKPLMHFE(TOutputTerm PIJHKCJDAHO, Dictionary<TTerm, TType> HODDLFPDDBE, Dictionary<TTerm, TType> JCIIFEEGFBE, BNNLDLNFMII MJAILKMLAHP)
		{
			return default(PPKNIFNDLFA<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x68AAE70", Offset = "0x68A9670", VA = "0x1868AAE70")]
		private static TOutputTerm EDGMIOHDMPK(TOutputTerm MBPJJBMGLMG, BNNLDLNFMII MJAILKMLAHP)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x360D970", Offset = "0x360C170", VA = "0x18360D970")]
	public static Dictionary<TNode, List<IJGNOPHNMDK<TType>>> LKJBDHBGOJN<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::JCFOIGJBJAO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> NFOGFJOGLPE, TRoot PNDCHGJLEGG, TGraph LJMFKPGJJNC, IEnumerable<TNode> CHHNLHCEBAM) where TDeps : global::OMGOOPKPJNO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IJGNOPHNMDK<TType> : IEquatable<IJGNOPHNMDK<TType>>, KMJPBECDOKN<IJGNOPHNMDK<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ACOJEEABMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType GIIPDOFLNDG;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x495B7F0", Offset = "0x4959FF0", VA = "0x18495B7F0")]
	internal IJGNOPHNMDK(string GLGOHIJMLFB, [In] TType JCBHHNBCPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A670", Offset = "0x4B78E70", VA = "0x184B7A670")]
	public bool IJPOBLPPPDM([In] IJGNOPHNMDK<TType> PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A590", Offset = "0x4B78D90", VA = "0x184B7A590", Slot = "4")]
	public bool Equals(IJGNOPHNMDK<TType> PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A5E0", Offset = "0x4B78DE0", VA = "0x184B7A5E0", Slot = "0")]
	public override bool Equals(object PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27C6A40", Offset = "0x27C5240", VA = "0x1827C6A40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A7A0", Offset = "0x4B78FA0", VA = "0x184B7A7A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A750", Offset = "0x4B78F50", VA = "0x184B7A750", Slot = "5")]
	private bool OPPJLIDJBCH([In] IJGNOPHNMDK<TType> PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HGKODODOJIH
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x37B7FF0", Offset = "0x37B67F0", VA = "0x1837B7FF0")]
	public static IJGNOPHNMDK<TType> CJOJELENPLJ<TType>(string GLGOHIJMLFB, TType JCBHHNBCPOK)
	{
		return default(IJGNOPHNMDK<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x37B8020", Offset = "0x37B6820", VA = "0x1837B8020")]
	public static (string, TType) MMLMMKPFOCC<TType>([In] this IJGNOPHNMDK<TType> NFOGFJOGLPE)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct OJDDJIOHEDA<TNode> : IEquatable<OJDDJIOHEDA<TNode>>, KMJPBECDOKN<OJDDJIOHEDA<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode OHGKHHGBPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string ACOJEEABMOC;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1618B10", Offset = "0x1617310", VA = "0x181618B10")]
	internal OJDDJIOHEDA(TNode GDFCBMOFMFN, string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5474430", Offset = "0x5472C30", VA = "0x185474430")]
	public bool IJPOBLPPPDM([In] OJDDJIOHEDA<TNode> PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5474240", Offset = "0x5472A40", VA = "0x185474240", Slot = "4")]
	public bool Equals(OJDDJIOHEDA<TNode> PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A5E0", Offset = "0x4B78DE0", VA = "0x184B7A5E0", Slot = "0")]
	public override bool Equals(object PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x54742E0", Offset = "0x5472AE0", VA = "0x1854742E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x54745B0", Offset = "0x5472DB0", VA = "0x1854745B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5474510", Offset = "0x5472D10", VA = "0x185474510", Slot = "5")]
	private bool NMHKCEMPMIE([In] OJDDJIOHEDA<TNode> PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class DCJMEEJLPMH
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35D0030", Offset = "0x35CE830", VA = "0x1835D0030")]
	public static OJDDJIOHEDA<TNode> CJOJELENPLJ<TNode>(TNode GDFCBMOFMFN, string GLGOHIJMLFB)
	{
		return default(OJDDJIOHEDA<TNode>);
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
