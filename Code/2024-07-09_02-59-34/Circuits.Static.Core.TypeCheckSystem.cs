using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct MCICJNOPBGC<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType DOJGHAOJFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind GNHJHDJCHDJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1AC2370", Offset = "0x1AC0F70", VA = "0x181AC2370")]
	internal MCICJNOPBGC(TType HGPIKDLKBHO, IOKind BCHKNFBDAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x446FA80", Offset = "0x446E680", VA = "0x18446FA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DAJBLIGNICO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2992810", Offset = "0x2991410", VA = "0x182992810")]
	public static MCICJNOPBGC<TType> FCDPFGJNKNI<TType>(TType HGPIKDLKBHO, IOKind BCHKNFBDAGF)
	{
		return default(MCICJNOPBGC<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2992840", Offset = "0x2991440", VA = "0x182992840")]
	public static (TType, IOKind) LCDCEHFLLOI<TType>([In] this MCICJNOPBGC<TType> ENEDBNLKLJL)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2992880", Offset = "0x2991480", VA = "0x182992880")]
	public static void LLELCMMKHDC<TType>([In] this MCICJNOPBGC<TType> ENEDBNLKLJL, [Out] TType HGPIKDLKBHO, [Out] IOKind BCHKNFBDAGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct EFONFGHCGAC<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly JNCEANNPNLH<TNode> BIFNGODLNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly JNCEANNPNLH<TNode> IIPNGBJADEP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3844E30", Offset = "0x3843A30", VA = "0x183844E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HPDAKCLICHB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B5EDB0", Offset = "0x2B5D9B0", VA = "0x182B5EDB0")]
	public static (JNCEANNPNLH<TNode>, JNCEANNPNLH<TNode>) LCDCEHFLLOI<TNode>([In] this EFONFGHCGAC<TNode> ENEDBNLKLJL)
	{
		return default((JNCEANNPNLH<TNode>, JNCEANNPNLH<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B5EE50", Offset = "0x2B5DA50", VA = "0x182B5EE50")]
	public static void LLELCMMKHDC<TNode>([In] this EFONFGHCGAC<TNode> ENEDBNLKLJL, [Out] JNCEANNPNLH<TNode> HDIFBMODGOB, [Out] JNCEANNPNLH<TNode> ADFEKOHGOPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CILPHKODICB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PJIPAIPEOMG PPOHKNHONJC(TRoot LNPGMAMPBAC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType LCAMJINFJFB(TRoot LNPGMAMPBAC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MCICJNOPBGC<TType> CNLBHDKDIAG(TRoot LNPGMAMPBAC, [In] MCICJNOPBGC<TType> HFIDNJCGLJB, [In] MCICJNOPBGC<TType> MGPFNHKFBHO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LGKKMMDKAPO(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TNode AIJMDPAKHCL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AEMIEOFDBLM(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TNode AIJMDPAKHCL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput MOJDOBGBFFO(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TNode AIJMDPAKHCL, int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FKOJCIFOLJA(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TNode AIJMDPAKHCL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput GPJIOKAEGIF(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TNode AIJMDPAKHCL, int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<LNIALGKCAMO<TType>> OBBOGJBHKIC(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TNode AIJMDPAKHCL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<EFONFGHCGAC<TNode>> DAMEBLJBPKD(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TNode AIJMDPAKHCL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType MBDMKBPCEHL(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TInput NGMMAKENIFG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int ANHCHLLMLEL(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TInput NGMMAKENIFG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput FIHIIOKKOEG(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TInput NGMMAKENIFG, int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode MHHMPCAKCDF(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TInput NGMMAKENIFG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType AJFPLIFNHCI(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TOutput KCIEOFBOPOK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int ALIGMIHKFPN(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TOutput KCIEOFBOPOK);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput DAGCIODMLJA(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TOutput KCIEOFBOPOK, int BAEBMIBABAE);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode PDKEJGBBAKF(TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, TOutput KCIEOFBOPOK);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BEKCANGLNOG(TRoot LNPGMAMPBAC, TType HGPIKDLKBHO);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType LHOEMLJNKAM(TRoot LNPGMAMPBAC, TType HGPIKDLKBHO, IEnumerable<TType> FIAEIOPGGEM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LFLJAOKJBJO(TRoot LNPGMAMPBAC, TType HGPIKDLKBHO, Action<TType> CNFONCJKCEO, Action<TType> OPIDDGHGHKE, Action<TType> OCHCBOAJIHJ, Action<TType> PDGGEJBJPLL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType HCDBHDEDBPG(TRoot LNPGMAMPBAC, TType HGPIKDLKBHO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string IPPENAJHDDO(TRoot LNPGMAMPBAC, TType HGPIKDLKBHO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification COPGCDLOCEK(TRoot LNPGMAMPBAC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NLDGPBPIIJN<TOutputSubstitution[], LGLBGBDJHMM> DFNHIEILFFG(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm FHFAALNPKJM(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm DIAHPFFDAGA(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TTerm MBCCKEODFCO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm FEGJJHMJLPO(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TTerm LHEHPOLGBPN, TTerm BIAIEKINDGJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NGMJJCJHJNM(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TTerm HFIDNJCGLJB, TTerm MGPFNHKFBHO);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool DAHKDKPLPHH(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TOutputTerm OBFDCMIIFJI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool PAOFHAHCDDJ(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TOutputTerm OBFDCMIIFJI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm NEDCINBJNCB(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TOutputTerm OBFDCMIIFJI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm MABDIDACFDG(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TOutputTerm OBFDCMIIFJI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm PKGKKLDEBFP(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TOutputTerm OBFDCMIIFJI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm CKAPOFEPBJD(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TOutputSubstitution KAHNAENEEPP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm OAANIHPDOFD(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TOutputSubstitution KAHNAENEEPP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm LMCHCAPFNOD(TRoot LNPGMAMPBAC, TUnification ICCKIIKDKBP, TTerm MBCCKEODFCO);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CIAJJNKECPJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CILPHKODICB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100")]
	public static global::CIAJJNKECPJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> FCDPFGJNKNI()
	{
		return default(global::CIAJJNKECPJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LDDMACNNAEL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class PDJMKCHGAGM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CILPHKODICB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class HOJDCDDMMKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot LIOIAHEPIFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps CCLGEEFPAEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification GPPFJLMEJIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph KJDODCLNPJD;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public PJIPAIPEOMG LIGGEBONGGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x3DEC0F0", Offset = "0x3DEACF0", VA = "0x183DEC0F0")]
				get
				{
					return default(PJIPAIPEOMG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3DED450", Offset = "0x3DEC050", VA = "0x183DED450")]
			private HOJDCDDMMKI(TRoot LNPGMAMPBAC, TDeps EIDBKEEIBKK, TUnification LJHLOMBMPAO, TGraph MJHKHLBJKPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3DEB570", Offset = "0x3DEA170", VA = "0x183DEB570")]
			public static HOJDCDDMMKI FCDPFGJNKNI(TRoot LNPGMAMPBAC, TDeps EIDBKEEIBKK, TUnification LJHLOMBMPAO, TGraph MJHKHLBJKPH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC3E0", Offset = "0x3DEAFE0", VA = "0x183DEC3E0")]
			public TType LCAMJINFJFB()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3DEAF40", Offset = "0x3DE9B40", VA = "0x183DEAF40")]
			public MCICJNOPBGC<TType> CNLBHDKDIAG(MCICJNOPBGC<TType> HFIDNJCGLJB, MCICJNOPBGC<TType> MGPFNHKFBHO)
			{
				return default(MCICJNOPBGC<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC600", Offset = "0x3DEB200", VA = "0x183DEC600")]
			public int LGKKMMDKAPO(TNode AIJMDPAKHCL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3DEA930", Offset = "0x3DE9530", VA = "0x183DEA930")]
			public int AEMIEOFDBLM(TNode AIJMDPAKHCL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3DECD40", Offset = "0x3DEB940", VA = "0x183DECD40")]
			public TInput MOJDOBGBFFO(TNode AIJMDPAKHCL, int BAEBMIBABAE)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBD60", Offset = "0x3DEA960", VA = "0x183DEBD60")]
			public int FKOJCIFOLJA(TNode AIJMDPAKHCL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBDA0", Offset = "0x3DEA9A0", VA = "0x183DEBDA0")]
			public TOutput GPJIOKAEGIF(TNode AIJMDPAKHCL, int BAEBMIBABAE)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3DED030", Offset = "0x3DEBC30", VA = "0x183DED030")]
			public IEnumerable<LNIALGKCAMO<TType>> OBBOGJBHKIC(TNode AIJMDPAKHCL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3DEB270", Offset = "0x3DE9E70", VA = "0x183DEB270")]
			public IEnumerable<EFONFGHCGAC<TNode>> DAMEBLJBPKD([In] TNode AIJMDPAKHCL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3DECAD0", Offset = "0x3DEB6D0", VA = "0x183DECAD0")]
			public TType MBDMKBPCEHL(TInput NGMMAKENIFG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3DEAC20", Offset = "0x3DE9820", VA = "0x183DEAC20")]
			public int BDMOPFFJLHH(TInput NGMMAKENIFG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBBD0", Offset = "0x3DEA7D0", VA = "0x183DEBBD0")]
			public TOutput FIHIIOKKOEG(TInput NGMMAKENIFG, int BAEBMIBABAE)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3DECB60", Offset = "0x3DEB760", VA = "0x183DECB60")]
			public TNode MHHMPCAKCDF(TInput NGMMAKENIFG)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3DEAB00", Offset = "0x3DE9700", VA = "0x183DEAB00")]
			public TType AJFPLIFNHCI(TOutput KCIEOFBOPOK)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3DEB4D0", Offset = "0x3DEA0D0", VA = "0x183DEB4D0")]
			public int DNNAFDCKFKA(TOutput KCIEOFBOPOK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3DEB020", Offset = "0x3DE9C20", VA = "0x183DEB020")]
			public TInput DAGCIODMLJA(TOutput KCIEOFBOPOK, int BAEBMIBABAE)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3DED210", Offset = "0x3DEBE10", VA = "0x183DED210")]
			public TNode PDKEJGBBAKF(TOutput KCIEOFBOPOK)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3DEAC60", Offset = "0x3DE9860", VA = "0x183DEAC60")]
			public bool BEKCANGLNOG(TType HGPIKDLKBHO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC700", Offset = "0x3DEB300", VA = "0x183DEC700")]
			public TType LHOEMLJNKAM(TType HGPIKDLKBHO, IEnumerable<TType> FIAEIOPGGEM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC5A0", Offset = "0x3DEB1A0", VA = "0x183DEC5A0")]
			public void LFLJAOKJBJO(TType HGPIKDLKBHO, Action<TType> CNFONCJKCEO, Action<TType> OPIDDGHGHKE, Action<TType> OCHCBOAJIHJ, Action<TType> PDGGEJBJPLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBFB0", Offset = "0x3DEABB0", VA = "0x183DEBFB0")]
			public TType HCDBHDEDBPG(TType HGPIKDLKBHO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC130", Offset = "0x3DEAD30", VA = "0x183DEC130")]
			public string IPPENAJHDDO(TType HGPIKDLKBHO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3DEBA40", Offset = "0x3DEA640", VA = "0x183DEBA40")]
			public TTerm FHFAALNPKJM()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3DEB400", Offset = "0x3DEA000", VA = "0x183DEB400")]
			public TTerm DIAHPFFDAGA(TTerm MBCCKEODFCO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3DEB9A0", Offset = "0x3DEA5A0", VA = "0x183DEB9A0")]
			public TTerm FEGJJHMJLPO(TTerm LHEHPOLGBPN, TTerm BIAIEKINDGJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3DECED0", Offset = "0x3DEBAD0", VA = "0x183DECED0")]
			public void NGMJJCJHJNM(TTerm HFIDNJCGLJB, TTerm MGPFNHKFBHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3DED1C0", Offset = "0x3DEBDC0", VA = "0x183DED1C0")]
			public bool PAOFHAHCDDJ(TOutputTerm MBCCKEODFCO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3DEB160", Offset = "0x3DE9D60", VA = "0x183DEB160")]
			public bool DAHKDKPLPHH(TOutputTerm MBCCKEODFCO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC280", Offset = "0x3DEAE80", VA = "0x183DEC280")]
			public TTerm JNIOOGECPAJ(TOutputTerm OBFDCMIIFJI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC930", Offset = "0x3DEB530", VA = "0x183DEC930")]
			public TOutputTerm MABDIDACFDG(TOutputTerm MBCCKEODFCO)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3DED400", Offset = "0x3DEC000", VA = "0x183DED400")]
			public TOutputTerm PKGKKLDEBFP(TOutputTerm MBCCKEODFCO)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3DEAD90", Offset = "0x3DE9990", VA = "0x183DEAD90")]
			public TTerm CKAPOFEPBJD(TOutputSubstitution DHGODHMCNNO)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3DECFA0", Offset = "0x3DEBBA0", VA = "0x183DECFA0")]
			public TOutputTerm OAANIHPDOFD(TOutputSubstitution DHGODHMCNNO)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3DEC7C0", Offset = "0x3DEB3C0", VA = "0x183DEC7C0")]
			public TOutputTerm LMCHCAPFNOD(TTerm MBCCKEODFCO)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class AHKLNDCIKDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public HOJDCDDMMKI arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public AHKLNDCIKDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3D122D0", Offset = "0x3D10ED0", VA = "0x183D122D0")]
			internal int MKIFFPEDLHB(HOJDCDDMMKI arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3D121B0", Offset = "0x3D10DB0", VA = "0x183D121B0")]
			internal TInput GEKJIDJFHFD(HOJDCDDMMKI arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3D12270", Offset = "0x3D10E70", VA = "0x183D12270")]
			internal int IKCCJCEABGD(HOJDCDDMMKI arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3D11FE0", Offset = "0x3D10BE0", VA = "0x183D11FE0")]
			internal TOutput DMMIIMECHGA(HOJDCDDMMKI arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PJOAFPFBFCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public HOJDCDDMMKI arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, JNCEANNPNLH<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<JNCEANNPNLH<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public PJOAFPFBFCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x47982D0", Offset = "0x4796ED0", VA = "0x1847982D0")]
			internal (string, TTerm) IMJPDCPDODB(LNIALGKCAMO<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DPNJBOFPEIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public HOJDCDDMMKI arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public DPNJBOFPEIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x58E8BF0", Offset = "0x58E77F0", VA = "0x1858E8BF0")]
			internal void BMNMCLCDNLK(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x58E8EB0", Offset = "0x58E7AB0", VA = "0x1858E8EB0")]
			internal void COJAHDGOOLO(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x58E96B0", Offset = "0x58E82B0", VA = "0x1858E96B0")]
			internal void GIFCFLMKBOF(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x58E9370", Offset = "0x58E7F70", VA = "0x1858E9370")]
			internal void GCJKFCPHNBK(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NCBGEKBKIDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HOJDCDDMMKI arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public NCBGEKBKIDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3C14CF0", Offset = "0x3C138F0", VA = "0x183C14CF0")]
			internal TTerm NBOBJHJAHIJ(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x475F2A0", Offset = "0x475DEA0", VA = "0x18475F2A0")]
		private static AIEKDGCGBEF FHHJEFLCGGH([CallerMemberName] string LONKACOOPGJ = "")
		{
			return default(AIEKDGCGBEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x475C190", Offset = "0x475AD90", VA = "0x18475C190")]
		public static Dictionary<TNode, List<LNIALGKCAMO<TType>>> AOJFFIEDNJD(TRoot LNPGMAMPBAC, TDeps EIDBKEEIBKK, TGraph MJHKHLBJKPH, IEnumerable<TNode> PLKHEJJLFFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x475F2E0", Offset = "0x475DEE0", VA = "0x18475F2E0")]
		private static (Dictionary<TTerm, JNCEANNPNLH<TNode>>, List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>>) GAOLFFEEHKM(IEnumerable<TNode> PLKHEJJLFFM, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return default((Dictionary<TTerm, JNCEANNPNLH<TNode>>, List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x475FF10", Offset = "0x475EB10", VA = "0x18475FF10")]
		private static void GIFOHNBKKBK(TNode AIJMDPAKHCL, Dictionary<TInput, TTerm> CANJHPMEEOH, Dictionary<TOutput, TTerm> OCLNKEIHDAM, Dictionary<TTerm, JNCEANNPNLH<TNode>> LIPJFAFIODK, Dictionary<JNCEANNPNLH<TNode>, TTerm> CMHEHBPCMFC, List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> PBCJCHDIBHF, Stack<TNode> LABBACDDGGP, List<EFONFGHCGAC<TNode>> CBODEHNJCOP, HOJDCDDMMKI OKLJLMJMKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x47640C0", Offset = "0x4762CC0", VA = "0x1847640C0")]
		private static Dictionary<string, TTerm> PGIEAIDLFGA(TNode AIJMDPAKHCL, Dictionary<TTerm, JNCEANNPNLH<TNode>> LIPJFAFIODK, Dictionary<JNCEANNPNLH<TNode>, TTerm> DNMDAJPNCAC, List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> PBCJCHDIBHF, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BD6BE0", Offset = "0x2BD57E0", VA = "0x182BD6BE0")]
		private static (TPort, TTerm)[] IOIEEELHOBM<TPort>(TNode AIJMDPAKHCL, Func<HOJDCDDMMKI, TNode, int> AOPBLKFAPLI, Func<HOJDCDDMMKI, TNode, int, TPort> PBPGDIIDLOC, Func<HOJDCDDMMKI, TPort, TType> DHMGAADEHNH, Dictionary<TPort, TTerm> KKPOMDFJFLE, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4763210", Offset = "0x4761E10", VA = "0x184763210")]
		private static (TTerm, TTerm) NKEPDKOMCCO((TOutput Output, TTerm Id)[] IJGFEGNCDMF, List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> PBCJCHDIBHF, Dictionary<string, TTerm> DNMDAJPNCAC, Stack<TNode> LABBACDDGGP, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4761180", Offset = "0x475FD80", VA = "0x184761180")]
		private static void HILACBDCMDF((TInput PortKey, TTerm Id)[] HJOHPNILCPK, TTerm NHPBHEJEOBE, TTerm GHIOOMDDFEN, List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> PBCJCHDIBHF, Dictionary<TOutput, TTerm> OCLNKEIHDAM, Dictionary<string, TTerm> DNMDAJPNCAC, Stack<TNode> LABBACDDGGP, HOJDCDDMMKI OKLJLMJMKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x475C7B0", Offset = "0x475B3B0", VA = "0x18475C7B0")]
		private static TTerm BFINGNPEEJL(TInput NGMMAKENIFG, List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> PBCJCHDIBHF, Dictionary<TOutput, TTerm> OCLNKEIHDAM, Stack<TNode> LABBACDDGGP, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x475DC20", Offset = "0x475C820", VA = "0x18475DC20")]
		private static TTerm COMLJLACBFN([In] TType HGPIKDLKBHO, IOKind BCHKNFBDAGF, List<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> PBCJCHDIBHF, IReadOnlyDictionary<string, TTerm> DNMDAJPNCAC, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x475CD80", Offset = "0x475B980", VA = "0x18475CD80")]
		private static Dictionary<TNode, List<LNIALGKCAMO<TType>>> BHGLMMLCNPC(TOutputSubstitution[] PJCNGJGJMFN, Dictionary<TTerm, JNCEANNPNLH<TNode>> LIPJFAFIODK, IEnumerable<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> PBCJCHDIBHF, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4761F60", Offset = "0x4760B60", VA = "0x184761F60")]
		private static Dictionary<TNode, List<LNIALGKCAMO<TType>>> IGJEBLHNLHD(Dictionary<TTerm, JNCEANNPNLH<TNode>> LIPJFAFIODK, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4762D80", Offset = "0x4761980", VA = "0x184762D80")]
		private static void KDAKDCNCPPL([In] TNode AIJMDPAKHCL, Stack<TNode> LABBACDDGGP, List<EFONFGHCGAC<TNode>> CBODEHNJCOP, HOJDCDDMMKI OKLJLMJMKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4760C50", Offset = "0x475F850", VA = "0x184760C50")]
		private static void HAFHEBNPMJM(Dictionary<JNCEANNPNLH<TNode>, TTerm> DNMDAJPNCAC, List<EFONFGHCGAC<TNode>> CBODEHNJCOP, HOJDCDDMMKI OKLJLMJMKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x475E280", Offset = "0x475CE80", VA = "0x18475E280")]
		private static Dictionary<TTerm, TType> FFBIFMHNDOI(Dictionary<TTerm, TOutputSubstitution> PJCNGJGJMFN, IEnumerable<KeyValuePair<TTerm, MCICJNOPBGC<TType>>> PBCJCHDIBHF, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4762430", Offset = "0x4761030", VA = "0x184762430")]
		private static FLLFKKECNDP<TType> IHKEKADDHNO(TOutputTerm HGPIKDLKBHO, Dictionary<TTerm, TType> PBCJCHDIBHF, Dictionary<TTerm, TType> EKDHMOLEJIP, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return default(FLLFKKECNDP<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x475DAA0", Offset = "0x475C6A0", VA = "0x18475DAA0")]
		private static TOutputTerm CLELDHMOGBM(TOutputTerm JGMDAGCADPJ, HOJDCDDMMKI OKLJLMJMKDA)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2BFBF40", Offset = "0x2BFAB40", VA = "0x182BFBF40")]
	public static Dictionary<TNode, List<LNIALGKCAMO<TType>>> AOJFFIEDNJD<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::CIAJJNKECPJ<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> ENEDBNLKLJL, TRoot LNPGMAMPBAC, TGraph MJHKHLBJKPH, IEnumerable<TNode> PLKHEJJLFFM) where TDeps : global::CILPHKODICB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct LNIALGKCAMO<TType> : IEquatable<LNIALGKCAMO<TType>>, BLAHLINOAIB<LNIALGKCAMO<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ACNBDEPIOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType KHEBILMEMAK;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x41AFFE0", Offset = "0x41AEBE0", VA = "0x1841AFFE0")]
	internal LNIALGKCAMO(string LONKACOOPGJ, [In] TType OGODDCKKBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x428C830", Offset = "0x428B430", VA = "0x18428C830")]
	public bool JLOLPFEAPBE([In] LNIALGKCAMO<TType> HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x428C7E0", Offset = "0x428B3E0", VA = "0x18428C7E0", Slot = "4")]
	public bool Equals(LNIALGKCAMO<TType> HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF910", Offset = "0x3EAE510", VA = "0x183EAF910", Slot = "0")]
	public override bool Equals(object HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x202D8D0", Offset = "0x202C4D0", VA = "0x18202D8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x428C960", Offset = "0x428B560", VA = "0x18428C960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x428C910", Offset = "0x428B510", VA = "0x18428C910", Slot = "5")]
	private bool LPDKNIPJKCK([In] LNIALGKCAMO<TType> HEIGABGMPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NABBOJCJPBC
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2C9C270", Offset = "0x2C9AE70", VA = "0x182C9C270")]
	public static LNIALGKCAMO<TType> FCDPFGJNKNI<TType>(string LONKACOOPGJ, TType OGODDCKKBCN)
	{
		return default(LNIALGKCAMO<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2C9C2A0", Offset = "0x2C9AEA0", VA = "0x182C9C2A0")]
	public static (string, TType) LCDCEHFLLOI<TType>([In] this LNIALGKCAMO<TType> ENEDBNLKLJL)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct JNCEANNPNLH<TNode> : IEquatable<JNCEANNPNLH<TNode>>, BLAHLINOAIB<JNCEANNPNLH<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode ALAPOEEMCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string ACNBDEPIOMC;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xD98E30", Offset = "0xD97A30", VA = "0x180D98E30")]
	internal JNCEANNPNLH(TNode AIJMDPAKHCL, string LONKACOOPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x40D43E0", Offset = "0x40D2FE0", VA = "0x1840D43E0")]
	public bool JLOLPFEAPBE([In] JNCEANNPNLH<TNode> HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x40D4230", Offset = "0x40D2E30", VA = "0x1840D4230", Slot = "4")]
	public bool Equals(JNCEANNPNLH<TNode> HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF910", Offset = "0x3EAE510", VA = "0x183EAF910", Slot = "0")]
	public override bool Equals(object HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x40D4370", Offset = "0x40D2F70", VA = "0x1840D4370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x40D45A0", Offset = "0x40D31A0", VA = "0x1840D45A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x40D42D0", Offset = "0x40D2ED0", VA = "0x1840D42D0", Slot = "5")]
	private bool FGCNEBDLCJL([In] JNCEANNPNLH<TNode> HEIGABGMPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KODFMJCKIOF
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2BF9880", Offset = "0x2BF8480", VA = "0x182BF9880")]
	public static JNCEANNPNLH<TNode> FCDPFGJNKNI<TNode>(TNode AIJMDPAKHCL, string LONKACOOPGJ)
	{
		return default(JNCEANNPNLH<TNode>);
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
