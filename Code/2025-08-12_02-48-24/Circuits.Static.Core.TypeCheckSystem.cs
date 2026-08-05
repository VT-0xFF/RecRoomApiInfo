using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct EIAPILHBOEJ<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType MONFNOPPPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind LGCOOIDMAPH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xDAFA90", Offset = "0xDAE090", VA = "0x180DAFA90")]
	internal EIAPILHBOEJ(TType EHLAHNIAPLD, IOKind GLOHCOGKAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FB60", Offset = "0x4A7E160", VA = "0x184A7FB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BIKBPIBOHNG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3B22810", Offset = "0x3B20E10", VA = "0x183B22810")]
	public static EIAPILHBOEJ<TType> BPFPEFLIIPC<TType>(TType EHLAHNIAPLD, IOKind GLOHCOGKAOB)
	{
		return default(EIAPILHBOEJ<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B22840", Offset = "0x3B20E40", VA = "0x183B22840")]
	public static (TType, IOKind) GECDMFOGODJ<TType>([In] this EIAPILHBOEJ<TType> CCKLBDLJPNG)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B227B0", Offset = "0x3B20DB0", VA = "0x183B227B0")]
	public static void BHACFNDCJGJ<TType>([In] this EIAPILHBOEJ<TType> CCKLBDLJPNG, [Out] TType EHLAHNIAPLD, [Out] IOKind GLOHCOGKAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct GMFBJFFBHIG<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GHKPDIDDJIC<TNode> JDFAHHFMJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GHKPDIDDJIC<TNode> OPBKLFOOCFM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x500C600", Offset = "0x500AC00", VA = "0x18500C600", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GECKMAIPOJA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D9A6C0", Offset = "0x3D98CC0", VA = "0x183D9A6C0")]
	public static (GHKPDIDDJIC<TNode>, GHKPDIDDJIC<TNode>) GECDMFOGODJ<TNode>([In] this GMFBJFFBHIG<TNode> CCKLBDLJPNG)
	{
		return default((GHKPDIDDJIC<TNode>, GHKPDIDDJIC<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3D9A5E0", Offset = "0x3D98BE0", VA = "0x183D9A5E0")]
	public static void BHACFNDCJGJ<TNode>([In] this GMFBJFFBHIG<TNode> CCKLBDLJPNG, [Out] GHKPDIDDJIC<TNode> LEOAACGBJCD, [Out] GHKPDIDDJIC<TNode> GDBFOEGEGHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OFOBIJAMKLM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OALCPCGHNMA HAAOPLCNDCJ(TRoot PPOKNBNEDHM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType GHJEDJGNADA(TRoot PPOKNBNEDHM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EIAPILHBOEJ<TType> ENMAOKDPDIG(TRoot PPOKNBNEDHM, [In] EIAPILHBOEJ<TType> KNPHEACNGDK, [In] EIAPILHBOEJ<TType> IMDBLBCMEAE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JBEIODNOIIE(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TNode CFHHNIJODJI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ONMCCEMFEHF(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TNode CFHHNIJODJI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput FGFJCBALLFA(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TNode CFHHNIJODJI, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int GEMIACILFHI(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TNode CFHHNIJODJI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput OBBCBABJLMJ(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TNode CFHHNIJODJI, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IMPINADJKMH<TType>> HJLGFBOAILO(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TNode CFHHNIJODJI);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<GMFBJFFBHIG<TNode>> DGKECLGLHJJ(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TNode CFHHNIJODJI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType BEHCBJCPCLG(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TInput EKNLPIEMHNC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int ADAJFMMLIHP(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TInput EKNLPIEMHNC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput DFKKMGHNHHF(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TInput EKNLPIEMHNC, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode GBBABEGGIIK(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TInput EKNLPIEMHNC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType MHPJMOEODEE(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TOutput KAGGBDPGCAH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int LFPLHBKNFFJ(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TOutput KAGGBDPGCAH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput OMOLEEAHOPH(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TOutput KAGGBDPGCAH, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode HNNMFJPDAJK(TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, TOutput KAGGBDPGCAH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BCHPEICMMLB(TRoot PPOKNBNEDHM, TType EHLAHNIAPLD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType OBAAEEBHJFO(TRoot PPOKNBNEDHM, TType EHLAHNIAPLD, IEnumerable<TType> HJOJEJFGKKO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GKKCMLJGIDP(TRoot PPOKNBNEDHM, TType EHLAHNIAPLD, Action<TType> POEHMIINGBJ, Action<TType> KEFGDJNPACF, Action<TType> HPNIFDBFKBF, Action<TType> FPMAKJHFFMP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType CLNMMGNDIGF(TRoot PPOKNBNEDHM, TType EHLAHNIAPLD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string DJEHABHEHBL(TRoot PPOKNBNEDHM, TType EHLAHNIAPLD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification JKANMFPIELE(TRoot PPOKNBNEDHM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	PKAAAAMEMEI<TOutputSubstitution[], LJOOEKCBACG> AECFGBLIJIA(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm IOILOIACHOL(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm OGICBLKCOGB(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TTerm GJPJPENBEKD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm NDAAKHFLNAB(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TTerm BEDGCBJMDED, TTerm IKOPHEOIONA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IAHIGCDHDIM(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TTerm KNPHEACNGDK, TTerm IMDBLBCMEAE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool OCLAAKLOFGF(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TOutputTerm KEBGHBPJNPL);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KNEJDHKONBD(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TOutputTerm KEBGHBPJNPL);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm PAFPADJPJOD(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TOutputTerm KEBGHBPJNPL);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm GGLENAKIDBD(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TOutputTerm KEBGHBPJNPL);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm CMINAJONFLJ(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TOutputTerm KEBGHBPJNPL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm PLHLCLALJNM(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TOutputSubstitution BIDDHLCBNEE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm AAOIAPGGHLC(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TOutputSubstitution BIDDHLCBNEE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm BKALJIACGKK(TRoot PPOKNBNEDHM, TUnification GCNNAAICDOE, TTerm GJPJPENBEKD);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DJFOGMALEJC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::OFOBIJAMKLM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
	public static global::DJFOGMALEJC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> BPFPEFLIIPC()
	{
		return default(global::DJFOGMALEJC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PGNBMKNIKDA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class OKINNLBEOMG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::OFOBIJAMKLM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class JLGMEJEOGIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot KFENKPOKOKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps OBDNOJBNDGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification DNLOKKPBLOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph NFPEEEDDEJN;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public OALCPCGHNMA JKNELKPBGDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x54F0650", Offset = "0x54EEC50", VA = "0x1854F0650")]
				get
				{
					return default(OALCPCGHNMA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x54F1340", Offset = "0x54EF940", VA = "0x1854F1340")]
			private JLGMEJEOGIC(TRoot PPOKNBNEDHM, TDeps AIJNNPIBFLN, TUnification FCIGHLNAKIG, TGraph OHEEMHHMAGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x54EEB00", Offset = "0x54ED100", VA = "0x1854EEB00")]
			public static JLGMEJEOGIC BPFPEFLIIPC(TRoot PPOKNBNEDHM, TDeps AIJNNPIBFLN, TUnification FCIGHLNAKIG, TGraph OHEEMHHMAGD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x54EFB60", Offset = "0x54EE160", VA = "0x1854EFB60")]
			public TType GHJEDJGNADA()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x54EF540", Offset = "0x54EDB40", VA = "0x1854EF540")]
			public EIAPILHBOEJ<TType> ENMAOKDPDIG(EIAPILHBOEJ<TType> KNPHEACNGDK, EIAPILHBOEJ<TType> IMDBLBCMEAE)
			{
				return default(EIAPILHBOEJ<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x54F04B0", Offset = "0x54EEAB0", VA = "0x1854F04B0")]
			public int JBEIODNOIIE(TNode CFHHNIJODJI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x54F1130", Offset = "0x54EF730", VA = "0x1854F1130")]
			public int ONMCCEMFEHF(TNode CFHHNIJODJI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x54EF5A0", Offset = "0x54EDBA0", VA = "0x1854EF5A0")]
			public TInput FGFJCBALLFA(TNode CFHHNIJODJI, int LEPAEEGOBDO)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x54EF940", Offset = "0x54EDF40", VA = "0x1854EF940")]
			public int GEMIACILFHI(TNode CFHHNIJODJI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x54F0CF0", Offset = "0x54EF2F0", VA = "0x1854F0CF0")]
			public TOutput OBBCBABJLMJ(TNode CFHHNIJODJI, int LEPAEEGOBDO)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x54EFE70", Offset = "0x54EE470", VA = "0x1854EFE70")]
			public IEnumerable<IMPINADJKMH<TType>> HJLGFBOAILO(TNode CFHHNIJODJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x54EF240", Offset = "0x54ED840", VA = "0x1854EF240")]
			public IEnumerable<GMFBJFFBHIG<TNode>> DGKECLGLHJJ([In] TNode CFHHNIJODJI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x54EE920", Offset = "0x54ECF20", VA = "0x1854EE920")]
			public TType BEHCBJCPCLG(TInput EKNLPIEMHNC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x54F0AE0", Offset = "0x54EF0E0", VA = "0x1854F0AE0")]
			public int NMLAAFBBFGG(TInput EKNLPIEMHNC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x54EF130", Offset = "0x54ED730", VA = "0x1854EF130")]
			public TOutput DFKKMGHNHHF(TInput EKNLPIEMHNC, int LEPAEEGOBDO)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x54EF820", Offset = "0x54EDE20", VA = "0x1854EF820")]
			public TNode GBBABEGGIIK(TInput EKNLPIEMHNC)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x54F0750", Offset = "0x54EED50", VA = "0x1854F0750")]
			public TType MHPJMOEODEE(TOutput KAGGBDPGCAH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x54F02B0", Offset = "0x54EE8B0", VA = "0x1854F02B0")]
			public int IHPLCHHGLFH(TOutput KAGGBDPGCAH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x54F10A0", Offset = "0x54EF6A0", VA = "0x1854F10A0")]
			public TInput OMOLEEAHOPH(TOutput KAGGBDPGCAH, int LEPAEEGOBDO)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x54EFF30", Offset = "0x54EE530", VA = "0x1854EFF30")]
			public TNode HNNMFJPDAJK(TOutput KAGGBDPGCAH)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x54EE890", Offset = "0x54ECE90", VA = "0x1854EE890")]
			public bool BCHPEICMMLB(TType EHLAHNIAPLD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x54F0B20", Offset = "0x54EF120", VA = "0x1854F0B20")]
			public TType OBAAEEBHJFO(TType EHLAHNIAPLD, IEnumerable<TType> HJOJEJFGKKO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x54EFCB0", Offset = "0x54EE2B0", VA = "0x1854EFCB0")]
			public void GKKCMLJGIDP(TType EHLAHNIAPLD, Action<TType> POEHMIINGBJ, Action<TType> KEFGDJNPACF, Action<TType> HPNIFDBFKBF, Action<TType> FPMAKJHFFMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x54EEE00", Offset = "0x54ED400", VA = "0x1854EEE00")]
			public TType CLNMMGNDIGF(TType EHLAHNIAPLD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x54EF280", Offset = "0x54ED880", VA = "0x1854EF280")]
			public string DJEHABHEHBL(TType EHLAHNIAPLD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x54F0300", Offset = "0x54EE900", VA = "0x1854F0300")]
			public TTerm IOILOIACHOL()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x54F0E60", Offset = "0x54EF460", VA = "0x1854F0E60")]
			public TTerm OGICBLKCOGB(TTerm GJPJPENBEKD)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x54F0870", Offset = "0x54EEE70", VA = "0x1854F0870")]
			public TTerm NDAAKHFLNAB(TTerm BEDGCBJMDED, TTerm IKOPHEOIONA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x54F0050", Offset = "0x54EE650", VA = "0x1854F0050")]
			public void IAHIGCDHDIM(TTerm KNPHEACNGDK, TTerm IMDBLBCMEAE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x54F04F0", Offset = "0x54EEAF0", VA = "0x1854F04F0")]
			public bool KNEJDHKONBD(TOutputTerm GJPJPENBEKD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x54F0D90", Offset = "0x54EF390", VA = "0x1854F0D90")]
			public bool OCLAAKLOFGF(TOutputTerm GJPJPENBEKD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x54EF750", Offset = "0x54EDD50", VA = "0x1854EF750")]
			public TTerm FINNDCAJNDH(TOutputTerm KEBGHBPJNPL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x54EFB10", Offset = "0x54EE110", VA = "0x1854EFB10")]
			public TOutputTerm GGLENAKIDBD(TOutputTerm GJPJPENBEKD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x54EEF70", Offset = "0x54ED570", VA = "0x1854EEF70")]
			public TOutputTerm CMINAJONFLJ(TOutputTerm GJPJPENBEKD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x54F11F0", Offset = "0x54EF7F0", VA = "0x1854F11F0")]
			public TTerm PLHLCLALJNM(TOutputSubstitution DNELOJHNALN)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x54EE6F0", Offset = "0x54ECCF0", VA = "0x1854EE6F0")]
			public TOutputTerm AAOIAPGGHLC(TOutputSubstitution DNELOJHNALN)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x54EE9E0", Offset = "0x54ECFE0", VA = "0x1854EE9E0")]
			public TOutputTerm BKALJIACGKK(TTerm GJPJPENBEKD)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class AEFCDFGPNPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public JLGMEJEOGIC arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public AEFCDFGPNPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x53E5FE0", Offset = "0x53E45E0", VA = "0x1853E5FE0")]
			internal int OIHBCAHFLDK(JLGMEJEOGIC arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x53E60A0", Offset = "0x53E46A0", VA = "0x1853E60A0")]
			internal TInput PDNLNCJJDBP(JLGMEJEOGIC arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x53E5DD0", Offset = "0x53E43D0", VA = "0x1853E5DD0")]
			internal int DGEKCNKDBJE(JLGMEJEOGIC arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x53E5F40", Offset = "0x53E4540", VA = "0x1853E5F40")]
			internal TOutput GJBOPCHLHMO(JLGMEJEOGIC arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class LBJMNDNAOPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public JLGMEJEOGIC arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, GHKPDIDDJIC<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<GHKPDIDDJIC<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public LBJMNDNAOPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x56C7E00", Offset = "0x56C6400", VA = "0x1856C7E00")]
			internal (string, TTerm) HJMHLIAMDEJ(IMPINADJKMH<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FLNDDDECLDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JLGMEJEOGIC arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public FLNDDDECLDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AB10", Offset = "0x4F49110", VA = "0x184F4AB10")]
			internal void GMPCOLAEBBG(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4F4B210", Offset = "0x4F49810", VA = "0x184F4B210")]
			internal void JIAJLFGCGMI(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4F4A950", Offset = "0x4F48F50", VA = "0x184F4A950")]
			internal void AALJEPEHBPF(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AF90", Offset = "0x4F49590", VA = "0x184F4AF90")]
			internal void HFEFAINBMMK(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MEGHDHLPHOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JLGMEJEOGIC arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public MEGHDHLPHOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x45A7190", Offset = "0x45A5790", VA = "0x1845A7190")]
			internal TTerm KJLDIJFOCMB(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B80100", Offset = "0x5B7E700", VA = "0x185B80100")]
		private static NHCELAJFOCI IBHECGJENFJ([CallerMemberName] string DJFMCHMDHGK = "")
		{
			return default(NHCELAJFOCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B88300", Offset = "0x5B86900", VA = "0x185B88300")]
		public static Dictionary<TNode, List<IMPINADJKMH<TType>>> NDCOMCOFHMH(TRoot PPOKNBNEDHM, TDeps AIJNNPIBFLN, TGraph OHEEMHHMAGD, IEnumerable<TNode> MIGDPMAMOPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5B83B40", Offset = "0x5B82140", VA = "0x185B83B40")]
		private static (Dictionary<TTerm, GHKPDIDDJIC<TNode>>, List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>>) MNMIPOIJAEK(IEnumerable<TNode> MIGDPMAMOPG, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return default((Dictionary<TTerm, GHKPDIDDJIC<TNode>>, List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5B77610", Offset = "0x5B75C10", VA = "0x185B77610")]
		private static void AJAEAAKEEGP(TNode CFHHNIJODJI, Dictionary<TInput, TTerm> IFDGHAPJOPG, Dictionary<TOutput, TTerm> AOCOMKAOJCC, Dictionary<TTerm, GHKPDIDDJIC<TNode>> CCDGGDJPCOE, Dictionary<GHKPDIDDJIC<TNode>, TTerm> BNNGJACCBCB, List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> MPCNCJHNIIJ, Stack<TNode> GAOLKEIGOEL, List<GMFBJFFBHIG<TNode>> MNBMPFCBGCG, JLGMEJEOGIC HOOMHDKIGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5B81460", Offset = "0x5B7FA60", VA = "0x185B81460")]
		private static Dictionary<string, TTerm> IKFBOAGDACO(TNode CFHHNIJODJI, Dictionary<TTerm, GHKPDIDDJIC<TNode>> CCDGGDJPCOE, Dictionary<GHKPDIDDJIC<TNode>, TTerm> GBGOIODAMIM, List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> MPCNCJHNIIJ, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x44DE9A0", Offset = "0x44DCFA0", VA = "0x1844DE9A0")]
		private static (TPort, TTerm)[] GOHCOMNGGMB<TPort>(TNode CFHHNIJODJI, Func<JLGMEJEOGIC, TNode, int> JOPGIPBBIBP, Func<JLGMEJEOGIC, TNode, int, TPort> AEJJMPMPLNO, Func<JLGMEJEOGIC, TPort, TType> IJFCDKMHFJL, Dictionary<TPort, TTerm> MLNGBBCJNIB, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5B85D60", Offset = "0x5B84360", VA = "0x185B85D60")]
		private static (TTerm, TTerm) NBCDKNEOLCD((TOutput Output, TTerm Id)[] ODMHBALFOGI, List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> MPCNCJHNIIJ, Dictionary<string, TTerm> GBGOIODAMIM, Stack<TNode> GAOLKEIGOEL, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5B79DD0", Offset = "0x5B783D0", VA = "0x185B79DD0")]
		private static void CPEGJKNHECC((TInput PortKey, TTerm Id)[] KILIAGMLIDN, TTerm JIPPGBIBHAK, TTerm FJLCCFNBPGP, List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> MPCNCJHNIIJ, Dictionary<TOutput, TTerm> AOCOMKAOJCC, Dictionary<string, TTerm> GBGOIODAMIM, Stack<TNode> GAOLKEIGOEL, JLGMEJEOGIC HOOMHDKIGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5B78E60", Offset = "0x5B77460", VA = "0x185B78E60")]
		private static TTerm CNECFADLMGO(TInput EKNLPIEMHNC, List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> MPCNCJHNIIJ, Dictionary<TOutput, TTerm> AOCOMKAOJCC, Stack<TNode> GAOLKEIGOEL, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5B82AD0", Offset = "0x5B810D0", VA = "0x185B82AD0")]
		private static TTerm KMKHMJNEJNO([In] TType EHLAHNIAPLD, IOKind GLOHCOGKAOB, List<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> MPCNCJHNIIJ, IReadOnlyDictionary<string, TTerm> GBGOIODAMIM, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5B7E6E0", Offset = "0x5B7CCE0", VA = "0x185B7E6E0")]
		private static Dictionary<TNode, List<IMPINADJKMH<TType>>> ECLFACEBFHI(TOutputSubstitution[] CGACMNENJPM, Dictionary<TTerm, GHKPDIDDJIC<TNode>> CCDGGDJPCOE, IEnumerable<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> MPCNCJHNIIJ, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5B81D80", Offset = "0x5B80380", VA = "0x185B81D80")]
		private static Dictionary<TNode, List<IMPINADJKMH<TType>>> KDMHPKKGLGG(Dictionary<TTerm, GHKPDIDDJIC<TNode>> CCDGGDJPCOE, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5B7C6D0", Offset = "0x5B7ACD0", VA = "0x185B7C6D0")]
		private static void DNCLAAAEMPP([In] TNode CFHHNIJODJI, Stack<TNode> GAOLKEIGOEL, List<GMFBJFFBHIG<TNode>> MNBMPFCBGCG, JLGMEJEOGIC HOOMHDKIGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7F2A0", Offset = "0x5B7D8A0", VA = "0x185B7F2A0")]
		private static void FINKJDLKGLH(Dictionary<GHKPDIDDJIC<TNode>, TTerm> GBGOIODAMIM, List<GMFBJFFBHIG<TNode>> MNBMPFCBGCG, JLGMEJEOGIC HOOMHDKIGBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5B73BA0", Offset = "0x5B721A0", VA = "0x185B73BA0")]
		private static Dictionary<TTerm, TType> AGNKDGDHJEK(Dictionary<TTerm, TOutputSubstitution> CGACMNENJPM, IEnumerable<KeyValuePair<TTerm, EIAPILHBOEJ<TType>>> MPCNCJHNIIJ, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5B80960", Offset = "0x5B7EF60", VA = "0x185B80960")]
		private static FDKDBGPHKIF<TType> IEPIOHHPMKD(TOutputTerm EHLAHNIAPLD, Dictionary<TTerm, TType> MPCNCJHNIIJ, Dictionary<TTerm, TType> GMBMBGKOJIH, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return default(FDKDBGPHKIF<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5B81760", Offset = "0x5B7FD60", VA = "0x185B81760")]
		private static TOutputTerm JDIJKGPJJHF(TOutputTerm FPOLIOEMFFJ, JLGMEJEOGIC HOOMHDKIGBG)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3F69720", Offset = "0x3F67D20", VA = "0x183F69720")]
	public static Dictionary<TNode, List<IMPINADJKMH<TType>>> NDCOMCOFHMH<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::DJFOGMALEJC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> CCKLBDLJPNG, TRoot PPOKNBNEDHM, TGraph OHEEMHHMAGD, IEnumerable<TNode> MIGDPMAMOPG) where TDeps : global::OFOBIJAMKLM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IMPINADJKMH<TType> : IEquatable<IMPINADJKMH<TType>>, CFFKDHOLKHH<IMPINADJKMH<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string CLGAHBNBCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType HNAHOJADFHH;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5275BE0", Offset = "0x52741E0", VA = "0x185275BE0")]
	internal IMPINADJKMH(string DJFMCHMDHGK, [In] TType MNBLPDANDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5275A30", Offset = "0x5274030", VA = "0x185275A30")]
	public bool AOLJNLPKMBH([In] IMPINADJKMH<TType> IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5275B50", Offset = "0x5274150", VA = "0x185275B50", Slot = "4")]
	public bool Equals(IMPINADJKMH<TType> IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4F24B10", Offset = "0x4F23110", VA = "0x184F24B10", Slot = "0")]
	public override bool Equals(object IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4FEDC10", Offset = "0x4FEC210", VA = "0x184FEDC10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5275BA0", Offset = "0x52741A0", VA = "0x185275BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5275B00", Offset = "0x5274100", VA = "0x185275B00", Slot = "5")]
	private bool DFMDFGOEJHP([In] IMPINADJKMH<TType> IBCMCOKAJEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ILAAJALIGPK
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3E15150", Offset = "0x3E13750", VA = "0x183E15150")]
	public static IMPINADJKMH<TType> BPFPEFLIIPC<TType>(string DJFMCHMDHGK, TType MNBLPDANDHM)
	{
		return default(IMPINADJKMH<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3E15180", Offset = "0x3E13780", VA = "0x183E15180")]
	public static (string, TType) GECDMFOGODJ<TType>([In] this IMPINADJKMH<TType> CCKLBDLJPNG)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GHKPDIDDJIC<TNode> : IEquatable<GHKPDIDDJIC<TNode>>, CFFKDHOLKHH<GHKPDIDDJIC<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode MDCKGPJNBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string CLGAHBNBCJM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1953810", Offset = "0x1951E10", VA = "0x181953810")]
	internal GHKPDIDDJIC(TNode CFHHNIJODJI, string DJFMCHMDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4FEDA00", Offset = "0x4FEC000", VA = "0x184FEDA00")]
	public bool AOLJNLPKMBH([In] GHKPDIDDJIC<TNode> IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4FEDBC0", Offset = "0x4FEC1C0", VA = "0x184FEDBC0", Slot = "4")]
	public bool Equals(GHKPDIDDJIC<TNode> IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4F24B10", Offset = "0x4F23110", VA = "0x184F24B10", Slot = "0")]
	public override bool Equals(object IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4FEDC70", Offset = "0x4FEC270", VA = "0x184FEDC70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4FEDCE0", Offset = "0x4FEC2E0", VA = "0x184FEDCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4FEDAD0", Offset = "0x4FEC0D0", VA = "0x184FEDAD0", Slot = "5")]
	private bool BABKNMCLAFL([In] GHKPDIDDJIC<TNode> IBCMCOKAJEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class OAJANCJINIA
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C07290", Offset = "0x3C05890", VA = "0x183C07290")]
	public static GHKPDIDDJIC<TNode> BPFPEFLIIPC<TNode>(TNode CFHHNIJODJI, string DJFMCHMDHGK)
	{
		return default(GHKPDIDDJIC<TNode>);
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
