using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct IPJKBDPFCMM<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType HCHJICPCOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind AOGKIENPJIF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x18AF070", Offset = "0x18AE470", VA = "0x1818AF070")]
	internal IPJKBDPFCMM(TType NBMJAHOKHAI, IOKind BPMBLIKAEIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x39C69A0", Offset = "0x39C5DA0", VA = "0x1839C69A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MEFNBKHJADM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28A4B70", Offset = "0x28A3F70", VA = "0x1828A4B70")]
	public static IPJKBDPFCMM<TType> HGJFOBLHCKL<TType>(TType NBMJAHOKHAI, IOKind BPMBLIKAEIC)
	{
		return default(IPJKBDPFCMM<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28A4B30", Offset = "0x28A3F30", VA = "0x1828A4B30")]
	public static (TType, IOKind) COICJIAKJKE<TType>([In] this IPJKBDPFCMM<TType> MEEBIDIALDO)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28A4AD0", Offset = "0x28A3ED0", VA = "0x1828A4AD0")]
	public static void BNCCPBFLAPH<TType>([In] this IPJKBDPFCMM<TType> MEEBIDIALDO, [Out] TType NBMJAHOKHAI, [Out] IOKind BPMBLIKAEIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KEHGLJGDOCG<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KJPKKHDLOMA<TNode> LKALEGBHOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly KJPKKHDLOMA<TNode> EDAAENGFLHA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C73BE0", Offset = "0x3C72FE0", VA = "0x183C73BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HJJGCNDOHGA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27FCC30", Offset = "0x27FC030", VA = "0x1827FCC30")]
	public static (KJPKKHDLOMA<TNode>, KJPKKHDLOMA<TNode>) COICJIAKJKE<TNode>([In] this KEHGLJGDOCG<TNode> MEEBIDIALDO)
	{
		return default((KJPKKHDLOMA<TNode>, KJPKKHDLOMA<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27FCB50", Offset = "0x27FBF50", VA = "0x1827FCB50")]
	public static void BNCCPBFLAPH<TNode>([In] this KEHGLJGDOCG<TNode> MEEBIDIALDO, [Out] KJPKKHDLOMA<TNode> OOGPCKEGMIK, [Out] KJPKKHDLOMA<TNode> NPEJHBIFPCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PBFIIDFAKOI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGDNMFPAKOH HDFPDJGNODB(TRoot BEOJJJNJFFJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType ADHBOFIHKEG(TRoot BEOJJJNJFFJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IPJKBDPFCMM<TType> GLOHADOEBJJ(TRoot BEOJJJNJFFJ, [In] IPJKBDPFCMM<TType> LCALDLBCJKP, [In] IPJKBDPFCMM<TType> JPKPFNMFEIJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FOBFFJMCJBL(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TNode HBIAHPFPLFB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MEAEENOFFFC(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TNode HBIAHPFPLFB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput JGCGDKBANPK(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TNode HBIAHPFPLFB, int PMLKPJNGBAD);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OIDALNEGANN(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TNode HBIAHPFPLFB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput JHNJNOOIMOP(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TNode HBIAHPFPLFB, int PMLKPJNGBAD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<INCEHPKENPP<TType>> FHKGENLEAIK(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TNode HBIAHPFPLFB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KEHGLJGDOCG<TNode>> CDFAAHJKFGH(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TNode HBIAHPFPLFB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType FDAJMCBBDCC(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TInput CIBLPGDHGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int JMDGJDHPGHP(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TInput CIBLPGDHGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput FMGBMPENAED(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TInput CIBLPGDHGMJ, int PMLKPJNGBAD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode IGOCDJABOID(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TInput CIBLPGDHGMJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType ADMKCLEAAGP(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TOutput CHHLDLCNCAJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int KMEGIKNANPL(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TOutput CHHLDLCNCAJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput JHMJLLDIJFP(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TOutput CHHLDLCNCAJ, int PMLKPJNGBAD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode NMJLBDJENCL(TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, TOutput CHHLDLCNCAJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GIIIKNDJMAN(TRoot BEOJJJNJFFJ, TType NBMJAHOKHAI);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType PNPFMJJCNOD(TRoot BEOJJJNJFFJ, TType NBMJAHOKHAI, IEnumerable<TType> JELFLBMBHDA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GDEAKCMADKN(TRoot BEOJJJNJFFJ, TType NBMJAHOKHAI, Action<TType> PCFCFPOHNCM, Action<TType> CNKFNOOPPIL, Action<TType> KLEKEDOGCFF, Action<TType> AIJJLLCJMGB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType MOCGLKFMCJB(TRoot BEOJJJNJFFJ, TType NBMJAHOKHAI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string CKEMEKCCFKK(TRoot BEOJJJNJFFJ, TType NBMJAHOKHAI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification FEJBMMAGOAH(TRoot BEOJJJNJFFJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OJIJNKCPBAD<TOutputSubstitution[], FEBGENKADMF> ILDFPDELPOG(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm KEAGCOBHGPH(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm CFABCIJDPJL(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TTerm NNIOLMEHPIM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm GNMPBIELELB(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TTerm LCIAMFNJFEE, TTerm CMFFGOOLLIJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OKMBMJGLDJL(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TTerm LCALDLBCJKP, TTerm JPKPFNMFEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool OJMBBNGLCMM(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TOutputTerm CMHDGLNANAP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool OHAJLPLEIFN(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TOutputTerm CMHDGLNANAP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm OBKKMLPIGGC(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TOutputTerm CMHDGLNANAP);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm DBKOOMFCGNL(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TOutputTerm CMHDGLNANAP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm POCIKOEHFML(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TOutputTerm CMHDGLNANAP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm FKOPLKPJDFE(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TOutputSubstitution HCNMMFMBPAE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm HNDHFOKKGNI(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TOutputSubstitution HCNMMFMBPAE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm POAAOJAOMEM(TRoot BEOJJJNJFFJ, TUnification OJHHCJFJJPK, TTerm NNIOLMEHPIM);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct OPENKKGBIMD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::PBFIIDFAKOI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30")]
	public static global::OPENKKGBIMD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> HGJFOBLHCKL()
	{
		return default(global::OPENKKGBIMD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MPNHKAAFBHK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class EKCJLGHBKFF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::PBFIIDFAKOI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class CEGJFIJEJNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot DHEBBLCLMKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps IPFDEHDGNDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification JNHBGEFICMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph MCDGIJDEONN;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public EGDNMFPAKOH MPIJCKFPHCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4AE8F50", Offset = "0x4AE8350", VA = "0x184AE8F50")]
				get
				{
					return default(EGDNMFPAKOH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4AE9A80", Offset = "0x4AE8E80", VA = "0x184AE9A80")]
			private CEGJFIJEJNG(TRoot BEOJJJNJFFJ, TDeps IGMHAFBOHAM, TUnification GLDMNKGPBJB, TGraph EHDPMADBCLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8420", Offset = "0x4AE7820", VA = "0x184AE8420")]
			public static CEGJFIJEJNG HGJFOBLHCKL(TRoot BEOJJJNJFFJ, TDeps IGMHAFBOHAM, TUnification GLDMNKGPBJB, TGraph EHDPMADBCLO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4AE6FB0", Offset = "0x4AE63B0", VA = "0x184AE6FB0")]
			public TType ADHBOFIHKEG()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8010", Offset = "0x4AE7410", VA = "0x184AE8010")]
			public IPJKBDPFCMM<TType> GLOHADOEBJJ(IPJKBDPFCMM<TType> LCALDLBCJKP, IPJKBDPFCMM<TType> JPKPFNMFEIJ)
			{
				return default(IPJKBDPFCMM<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4AE7AB0", Offset = "0x4AE6EB0", VA = "0x184AE7AB0")]
			public int FOBFFJMCJBL(TNode HBIAHPFPLFB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8F10", Offset = "0x4AE8310", VA = "0x184AE8F10")]
			public int MEAEENOFFFC(TNode HBIAHPFPLFB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8930", Offset = "0x4AE7D30", VA = "0x184AE8930")]
			public TInput JGCGDKBANPK(TNode HBIAHPFPLFB, int PMLKPJNGBAD)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4AE93C0", Offset = "0x4AE87C0", VA = "0x184AE93C0")]
			public int OIDALNEGANN(TNode HBIAHPFPLFB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8D10", Offset = "0x4AE8110", VA = "0x184AE8D10")]
			public TOutput JHNJNOOIMOP(TNode HBIAHPFPLFB, int PMLKPJNGBAD)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4AE76B0", Offset = "0x4AE6AB0", VA = "0x184AE76B0")]
			public IEnumerable<INCEHPKENPP<TType>> FHKGENLEAIK(TNode HBIAHPFPLFB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4AE71D0", Offset = "0x4AE65D0", VA = "0x184AE71D0")]
			public IEnumerable<KEHGLJGDOCG<TNode>> CDFAAHJKFGH([In] TNode HBIAHPFPLFB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4AE75A0", Offset = "0x4AE69A0", VA = "0x184AE75A0")]
			public TType FDAJMCBBDCC(TInput CIBLPGDHGMJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4AE7AF0", Offset = "0x4AE6EF0", VA = "0x184AE7AF0")]
			public int GAEOOAGFEFH(TInput CIBLPGDHGMJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4AE7880", Offset = "0x4AE6C80", VA = "0x184AE7880")]
			public TOutput FMGBMPENAED(TInput CIBLPGDHGMJ, int PMLKPJNGBAD)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8890", Offset = "0x4AE7C90", VA = "0x184AE8890")]
			public TNode IGOCDJABOID(TInput CIBLPGDHGMJ)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4AE70C0", Offset = "0x4AE64C0", VA = "0x184AE70C0")]
			public TType ADMKCLEAAGP(TOutput CHHLDLCNCAJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4AE7F10", Offset = "0x4AE7310", VA = "0x184AE7F10")]
			public int GKFNCGHNHJL(TOutput CHHLDLCNCAJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8B30", Offset = "0x4AE7F30", VA = "0x184AE8B30")]
			public TInput JHMJLLDIJFP(TOutput CHHLDLCNCAJ, int PMLKPJNGBAD)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4AE9180", Offset = "0x4AE8580", VA = "0x184AE9180")]
			public TNode NMJLBDJENCL(TOutput CHHLDLCNCAJ)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4AE7D80", Offset = "0x4AE7180", VA = "0x184AE7D80")]
			public bool GIIIKNDJMAN(TType NBMJAHOKHAI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4AE9780", Offset = "0x4AE8B80", VA = "0x184AE9780")]
			public TType PNPFMJJCNOD(TType NBMJAHOKHAI, IEnumerable<TType> JELFLBMBHDA)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4AE7C00", Offset = "0x4AE7000", VA = "0x184AE7C00")]
			public void GDEAKCMADKN(TType NBMJAHOKHAI, Action<TType> PCFCFPOHNCM, Action<TType> CNKFNOOPPIL, Action<TType> KLEKEDOGCFF, Action<TType> AIJJLLCJMGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4AE9090", Offset = "0x4AE8490", VA = "0x184AE9090")]
			public TType MOCGLKFMCJB(TType NBMJAHOKHAI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4AE7400", Offset = "0x4AE6800", VA = "0x184AE7400")]
			public string CKEMEKCCFKK(TType NBMJAHOKHAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8E10", Offset = "0x4AE8210", VA = "0x184AE8E10")]
			public TTerm KEAGCOBHGPH()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4AE7210", Offset = "0x4AE6610", VA = "0x184AE7210")]
			public TTerm CFABCIJDPJL(TTerm NNIOLMEHPIM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8180", Offset = "0x4AE7580", VA = "0x184AE8180")]
			public TTerm GNMPBIELELB(TTerm LCIAMFNJFEE, TTerm CMFFGOOLLIJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4AE95E0", Offset = "0x4AE89E0", VA = "0x184AE95E0")]
			public void OKMBMJGLDJL(TTerm LCALDLBCJKP, TTerm JPKPFNMFEIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4AE92A0", Offset = "0x4AE86A0", VA = "0x184AE92A0")]
			public bool OHAJLPLEIFN(TOutputTerm NNIOLMEHPIM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4AE9510", Offset = "0x4AE8910", VA = "0x184AE9510")]
			public bool OJMBBNGLCMM(TOutputTerm NNIOLMEHPIM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4AE87C0", Offset = "0x4AE7BC0", VA = "0x184AE87C0")]
			public TTerm IEKHEBNMNNF(TOutputTerm CMHDGLNANAP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4AE7480", Offset = "0x4AE6880", VA = "0x184AE7480")]
			public TOutputTerm DBKOOMFCGNL(TOutputTerm NNIOLMEHPIM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4AE9A30", Offset = "0x4AE8E30", VA = "0x184AE9A30")]
			public TOutputTerm POCIKOEHFML(TOutputTerm NNIOLMEHPIM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4AE77B0", Offset = "0x4AE6BB0", VA = "0x184AE77B0")]
			public TTerm FKOPLKPJDFE(TOutputSubstitution DHNIEKOHONM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4AE8620", Offset = "0x4AE7A20", VA = "0x184AE8620")]
			public TOutputTerm HNDHFOKKGNI(TOutputSubstitution DHNIEKOHONM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4AE98C0", Offset = "0x4AE8CC0", VA = "0x184AE98C0")]
			public TOutputTerm POAAOJAOMEM(TTerm NNIOLMEHPIM)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class HGNGANEPDMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public CEGJFIJEJNG arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public HGNGANEPDMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x385CE90", Offset = "0x385C290", VA = "0x18385CE90")]
			internal int AJJCBCMOGEG(CEGJFIJEJNG arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x385CF50", Offset = "0x385C350", VA = "0x18385CF50")]
			internal TInput GOALEAJIPLG(CEGJFIJEJNG arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x385D170", Offset = "0x385C570", VA = "0x18385D170")]
			internal int JHHAKILPIEJ(CEGJFIJEJNG arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x385D000", Offset = "0x385C400", VA = "0x18385D000")]
			internal TOutput HGIHJMOJDIJ(CEGJFIJEJNG arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class GFNLIHJEFNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public CEGJFIJEJNG arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, KJPKKHDLOMA<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<KJPKKHDLOMA<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public GFNLIHJEFNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x37C0620", Offset = "0x37BFA20", VA = "0x1837C0620")]
			internal (string, TTerm) DEPLKPHMMIP(INCEHPKENPP<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class KOAKDEEGCBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public CEGJFIJEJNG arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public KOAKDEEGCBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3C82180", Offset = "0x3C81580", VA = "0x183C82180")]
			internal void FDJMJIJBIHN(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3C82580", Offset = "0x3C81980", VA = "0x183C82580")]
			internal void IJODNOOIDCL(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3C823C0", Offset = "0x3C817C0", VA = "0x183C823C0")]
			internal void HNNHMCBOLFA(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3C82740", Offset = "0x3C81B40", VA = "0x183C82740")]
			internal void LOJHDNKMFNI(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class KAMPACGCMJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public CEGJFIJEJNG arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
			public KAMPACGCMJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3846F80", Offset = "0x3846380", VA = "0x183846F80")]
			internal TTerm FDBFMLLAFLA(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3363300", Offset = "0x3362700", VA = "0x183363300")]
		private static FKDLAMHBNEG PIJHPCFAGKD([CallerMemberName] string CCNKHEJHFKM = "")
		{
			return default(FKDLAMHBNEG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3359BC0", Offset = "0x3358FC0", VA = "0x183359BC0")]
		public static Dictionary<TNode, List<INCEHPKENPP<TType>>> GEHIOBMMOOP(TRoot BEOJJJNJFFJ, TDeps IGMHAFBOHAM, TGraph EHDPMADBCLO, IEnumerable<TNode> DCFFCEBKIAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x335BC40", Offset = "0x335B040", VA = "0x18335BC40")]
		private static (Dictionary<TTerm, KJPKKHDLOMA<TNode>>, List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>>) JIJNCPPLMJE(IEnumerable<TNode> DCFFCEBKIAN, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return default((Dictionary<TTerm, KJPKKHDLOMA<TNode>>, List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3357CD0", Offset = "0x33570D0", VA = "0x183357CD0")]
		private static void GBBFIKJKAJD(TNode HBIAHPFPLFB, Dictionary<TInput, TTerm> HGIHDHJPGNH, Dictionary<TOutput, TTerm> JAJNFHAHNEE, Dictionary<TTerm, KJPKKHDLOMA<TNode>> DIODKKGKBEB, Dictionary<KJPKKHDLOMA<TNode>, TTerm> NLHOJDJKLMN, List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> BEFGOEOPOCI, Stack<TNode> GJPGMEPOGID, List<KEHGLJGDOCG<TNode>> IHPMFHIMEOM, CEGJFIJEJNG PBBNOGAMKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x33621E0", Offset = "0x33615E0", VA = "0x1833621E0")]
		private static Dictionary<string, TTerm> NJEIPEJHGDO(TNode HBIAHPFPLFB, Dictionary<TTerm, KJPKKHDLOMA<TNode>> DIODKKGKBEB, Dictionary<KJPKKHDLOMA<TNode>, TTerm> IJCBJNPHIME, List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> BEFGOEOPOCI, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x24AB030", Offset = "0x24AA430", VA = "0x1824AB030")]
		private static (TPort, TTerm)[] EFAHMEBLCBP<TPort>(TNode HBIAHPFPLFB, Func<CEGJFIJEJNG, TNode, int> AHAOAFCOGOB, Func<CEGJFIJEJNG, TNode, int, TPort> KBEANADBANP, Func<CEGJFIJEJNG, TPort, TType> CHGKJGMJAKF, Dictionary<TPort, TTerm> DBGPHKEHHBO, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x335E940", Offset = "0x335DD40", VA = "0x18335E940")]
		private static (TTerm, TTerm) LNELPOCBAAO((TOutput Output, TTerm Id)[] PAFGLOPGPCO, List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> BEFGOEOPOCI, Dictionary<string, TTerm> IJCBJNPHIME, Stack<TNode> GJPGMEPOGID, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x334F540", Offset = "0x334E940", VA = "0x18334F540")]
		private static void AGNLLFBIPBL((TInput PortKey, TTerm Id)[] DGBCALFBOAG, TTerm KJMLGAEJIAC, TTerm GDMKIFDDLKP, List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> BEFGOEOPOCI, Dictionary<TOutput, TTerm> JAJNFHAHNEE, Dictionary<string, TTerm> IJCBJNPHIME, Stack<TNode> GJPGMEPOGID, CEGJFIJEJNG PBBNOGAMKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x33619D0", Offset = "0x3360DD0", VA = "0x1833619D0")]
		private static TTerm MODJEGDGLGP(TInput CIBLPGDHGMJ, List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> BEFGOEOPOCI, Dictionary<TOutput, TTerm> JAJNFHAHNEE, Stack<TNode> GJPGMEPOGID, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x335A6C0", Offset = "0x3359AC0", VA = "0x18335A6C0")]
		private static TTerm HAHLLBPKNPE([In] TType NBMJAHOKHAI, IOKind BPMBLIKAEIC, List<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> BEFGOEOPOCI, IReadOnlyDictionary<string, TTerm> IJCBJNPHIME, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x33525F0", Offset = "0x33519F0", VA = "0x1833525F0")]
		private static Dictionary<TNode, List<INCEHPKENPP<TType>>> AJELCNAHFFC(TOutputSubstitution[] EMGKKCOBAAG, Dictionary<TTerm, KJPKKHDLOMA<TNode>> DIODKKGKBEB, IEnumerable<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> BEFGOEOPOCI, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3363830", Offset = "0x3362C30", VA = "0x183363830")]
		private static Dictionary<TNode, List<INCEHPKENPP<TType>>> PIOIAMOCFOH(Dictionary<TTerm, KJPKKHDLOMA<TNode>> DIODKKGKBEB, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x335E500", Offset = "0x335D900", VA = "0x18335E500")]
		private static void KIIHOMDJGAO([In] TNode HBIAHPFPLFB, Stack<TNode> GJPGMEPOGID, List<KEHGLJGDOCG<TNode>> IHPMFHIMEOM, CEGJFIJEJNG PBBNOGAMKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x33624E0", Offset = "0x33618E0", VA = "0x1833624E0")]
		private static void OJAIDNPECPF(Dictionary<KJPKKHDLOMA<TNode>, TTerm> IJCBJNPHIME, List<KEHGLJGDOCG<TNode>> IHPMFHIMEOM, CEGJFIJEJNG PBBNOGAMKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x33561B0", Offset = "0x33555B0", VA = "0x1833561B0")]
		private static Dictionary<TTerm, TType> FPFBKPJKJIP(Dictionary<TTerm, TOutputSubstitution> EMGKKCOBAAG, IEnumerable<KeyValuePair<TTerm, IPJKBDPFCMM<TType>>> BEFGOEOPOCI, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x335AC80", Offset = "0x335A080", VA = "0x18335AC80")]
		private static LDJGEBAMNJP<TType> HBKDHKLCAML(TOutputTerm NBMJAHOKHAI, Dictionary<TTerm, TType> BEFGOEOPOCI, Dictionary<TTerm, TType> PNLGEMHJHFP, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return default(LDJGEBAMNJP<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3353F30", Offset = "0x3353330", VA = "0x183353F30")]
		private static TOutputTerm ANDJPDMOFGA(TOutputTerm AEBEIDGMAIP, CEGJFIJEJNG PBBNOGAMKJE)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x28B42F0", Offset = "0x28B36F0", VA = "0x1828B42F0")]
	public static Dictionary<TNode, List<INCEHPKENPP<TType>>> GEHIOBMMOOP<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::OPENKKGBIMD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> MEEBIDIALDO, TRoot BEOJJJNJFFJ, TGraph EHDPMADBCLO, IEnumerable<TNode> DCFFCEBKIAN) where TDeps : global::PBFIIDFAKOI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct INCEHPKENPP<TType> : IEquatable<INCEHPKENPP<TType>>, IJKDBAHHGHL<INCEHPKENPP<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string CGOKMMHCJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType KPCCJGNNHOM;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x336BF40", Offset = "0x336B340", VA = "0x18336BF40")]
	internal INCEHPKENPP(string CCNKHEJHFKM, [In] TType PFOKBKGNHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x39C30F0", Offset = "0x39C24F0", VA = "0x1839C30F0")]
	public bool LCIFIJKLDNM([In] INCEHPKENPP<TType> MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x39C30A0", Offset = "0x39C24A0", VA = "0x1839C30A0", Slot = "4")]
	public bool Equals(INCEHPKENPP<TType> MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x37F1660", Offset = "0x37F0A60", VA = "0x1837F1660", Slot = "0")]
	public override bool Equals(object MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E29460", Offset = "0x1E28860", VA = "0x181E29460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x39C31C0", Offset = "0x39C25C0", VA = "0x1839C31C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x39C3050", Offset = "0x39C2450", VA = "0x1839C3050", Slot = "5")]
	private bool DCPHBKELFJG([In] INCEHPKENPP<TType> MGDPHHCBMMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KGEOFEPECCF
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x286E220", Offset = "0x286D620", VA = "0x18286E220")]
	public static INCEHPKENPP<TType> HGJFOBLHCKL<TType>(string CCNKHEJHFKM, TType PFOKBKGNHBM)
	{
		return default(INCEHPKENPP<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x286E1E0", Offset = "0x286D5E0", VA = "0x18286E1E0")]
	public static (string, TType) COICJIAKJKE<TType>([In] this INCEHPKENPP<TType> MEEBIDIALDO)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct KJPKKHDLOMA<TNode> : IEquatable<KJPKKHDLOMA<TNode>>, IJKDBAHHGHL<KJPKKHDLOMA<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode BLLJNFCFDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string CGOKMMHCJIB;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xC40350", Offset = "0xC3F750", VA = "0x180C40350")]
	internal KJPKKHDLOMA(TNode HBIAHPFPLFB, string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D0D0", Offset = "0x3C7C4D0", VA = "0x183C7D0D0")]
	public bool LCIFIJKLDNM([In] KJPKKHDLOMA<TNode> MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CE50", Offset = "0x3C7C250", VA = "0x183C7CE50", Slot = "4")]
	public bool Equals(KJPKKHDLOMA<TNode> MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x37F1660", Offset = "0x37F0A60", VA = "0x1837F1660", Slot = "0")]
	public override bool Equals(object MGDPHHCBMMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CF90", Offset = "0x3C7C390", VA = "0x183C7CF90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C7D1A0", Offset = "0x3C7C5A0", VA = "0x183C7D1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3C7CEF0", Offset = "0x3C7C2F0", VA = "0x183C7CEF0", Slot = "5")]
	private bool GJEAOGNMILF([In] KJPKKHDLOMA<TNode> MGDPHHCBMMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HGEIEGELFHC
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x27FC370", Offset = "0x27FB770", VA = "0x1827FC370")]
	public static KJPKKHDLOMA<TNode> HGJFOBLHCKL<TNode>(TNode HBIAHPFPLFB, string CCNKHEJHFKM)
	{
		return default(KJPKKHDLOMA<TNode>);
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
