using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct PPCKNLKCKFC<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType PNINAMLCHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind CMMKFCKFJIB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1BD6240", Offset = "0x1BD5240", VA = "0x181BD6240")]
	internal PPCKNLKCKFC(TType HNGLFCFOHLI, IOKind KKBBCGJFAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47CD150", Offset = "0x47CC150", VA = "0x1847CD150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LJFPLPCLDBC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D130", Offset = "0x2C7C130", VA = "0x182C7D130")]
	public static PPCKNLKCKFC<TType> GAKCNKPJGEK<TType>(TType HNGLFCFOHLI, IOKind KKBBCGJFAKI)
	{
		return default(PPCKNLKCKFC<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D1D0", Offset = "0x2C7C1D0", VA = "0x182C7D1D0")]
	public static (TType, IOKind) NELBIDCDMIE<TType>([In] this PPCKNLKCKFC<TType> KALCJEIICGB)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D160", Offset = "0x2C7C160", VA = "0x182C7D160")]
	public static void JNNCHEFJEMI<TType>([In] this PPCKNLKCKFC<TType> KALCJEIICGB, [Out] TType HNGLFCFOHLI, [Out] IOKind KKBBCGJFAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct PIIHGOPFEAH<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly PGIGIKAPHHH<TNode> LIMKBIHCEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly PGIGIKAPHHH<TNode> MNDBDLNBIOE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x47A52D0", Offset = "0x47A42D0", VA = "0x1847A52D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GIECFHKGGLG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA630", Offset = "0x2BB9630", VA = "0x182BBA630")]
	public static (PGIGIKAPHHH<TNode>, PGIGIKAPHHH<TNode>) NELBIDCDMIE<TNode>([In] this PIIHGOPFEAH<TNode> KALCJEIICGB)
	{
		return default((PGIGIKAPHHH<TNode>, PGIGIKAPHHH<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA530", Offset = "0x2BB9530", VA = "0x182BBA530")]
	public static void JNNCHEFJEMI<TNode>([In] this PIIHGOPFEAH<TNode> KALCJEIICGB, [Out] PGIGIKAPHHH<TNode> OHFIHFHICKK, [Out] PGIGIKAPHHH<TNode> CENGDJBMKEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HEBDMPFAJKH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EAIIAGBAIGF DDPBMNGDACE(TRoot JMCFDCHCIPI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType NMLAOPADCKL(TRoot JMCFDCHCIPI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PPCKNLKCKFC<TType> INCCCKABJLE(TRoot JMCFDCHCIPI, [In] PPCKNLKCKFC<TType> PNODNPKGJKB, [In] PPCKNLKCKFC<TType> JHNJJGDAEGF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HFOGECGALFM(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TNode OHDOOCGHDGN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FJCCICJMHPJ(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TNode OHDOOCGHDGN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput KOIHOPAFMGC(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TNode OHDOOCGHDGN, int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FFHBEKKEGHE(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TNode OHDOOCGHDGN);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput EFHCKCHOKIB(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TNode OHDOOCGHDGN, int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<BLCPKLAMOBO<TType>> ENGCBJHLAHM(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TNode OHDOOCGHDGN);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<PIIHGOPFEAH<TNode>> AOGHDPDAKNM(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TNode OHDOOCGHDGN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType JGGEIPNGHMF(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TInput MIFEONEPPKP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int HDNCFFDCHLN(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TInput MIFEONEPPKP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput JNIMHBCIOPO(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TInput MIFEONEPPKP, int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode BMPLPFJBLMD(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TInput MIFEONEPPKP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType MHGJNIBHCJJ(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TOutput CKLHFLIDCEO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int BOONBMNABIB(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TOutput CKLHFLIDCEO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput NGFHGEOCIFJ(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TOutput CKLHFLIDCEO, int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode EJCCGCHGLJK(TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, TOutput CKLHFLIDCEO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BLGAAPNPBDP(TRoot JMCFDCHCIPI, TType HNGLFCFOHLI);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType ADEJNKJLEOK(TRoot JMCFDCHCIPI, TType HNGLFCFOHLI, IEnumerable<TType> IBPIHAFLDDB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ANECLEOFFME(TRoot JMCFDCHCIPI, TType HNGLFCFOHLI, Action<TType> AFLBCFGAFHB, Action<TType> FGHPMJCNCPD, Action<TType> MGDOOCNFIED, Action<TType> EAHPKJMJONI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType ABJMDKEEDKD(TRoot JMCFDCHCIPI, TType HNGLFCFOHLI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string ENMMJAPMFHI(TRoot JMCFDCHCIPI, TType HNGLFCFOHLI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification FKHEPJNJIMN(TRoot JMCFDCHCIPI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	DFAHBLOKBPH<TOutputSubstitution[], DNBIAPHIKOM> DFJKMMLJPDD(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm PPJJINHHIOO(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm LBMOAONMGGK(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TTerm BAGMGJGJLNH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm LNMODNKDNEO(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TTerm GOCEFODHDBO, TTerm FICFNKLGBCA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void INGPHMGJNAM(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TTerm PNODNPKGJKB, TTerm JHNJJGDAEGF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool GHBHNLBBJEB(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TOutputTerm LCGDOBKJCNL);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool ECKLDCKMDCD(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TOutputTerm LCGDOBKJCNL);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm CHMHGIMJJHJ(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TOutputTerm LCGDOBKJCNL);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm AFIGAEKCPKO(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TOutputTerm LCGDOBKJCNL);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm PNCKADJPMGM(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TOutputTerm LCGDOBKJCNL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm HICJOMMLLEM(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TOutputSubstitution DOGHGFIFNOL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm HAPDEIKHNAH(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TOutputSubstitution DOGHGFIFNOL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm CPANKPLHIMI(TRoot JMCFDCHCIPI, TUnification GHFLELKPNNP, TTerm BAGMGJGJLNH);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IEMLGAEIHKN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HEBDMPFAJKH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950")]
	public static global::IEMLGAEIHKN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> GAKCNKPJGEK()
	{
		return default(global::IEMLGAEIHKN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PLFPEIIECBM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class KGNFGAGHFDD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HEBDMPFAJKH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class EEODDDMIONG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot KILMHGFMJMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps PICDEEMCPCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification CLPKNJKCEBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph LNFADBOOMKB;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public EAIIAGBAIGF HPMMNKFPFHB
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x388F410", Offset = "0x388E410", VA = "0x18388F410")]
				get
				{
					return default(EAIIAGBAIGF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3891C70", Offset = "0x3890C70", VA = "0x183891C70")]
			private EEODDDMIONG(TRoot JMCFDCHCIPI, TDeps HPGJLJLFPIH, TUnification PENIHAJCMID, TGraph MKCPNDCEKPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3890740", Offset = "0x388F740", VA = "0x183890740")]
			public static EEODDDMIONG GAKCNKPJGEK(TRoot JMCFDCHCIPI, TDeps HPGJLJLFPIH, TUnification PENIHAJCMID, TGraph MKCPNDCEKPI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x38919C0", Offset = "0x38909C0", VA = "0x1838919C0")]
			public TType NMLAOPADCKL()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3890D20", Offset = "0x388FD20", VA = "0x183890D20")]
			public PPCKNLKCKFC<TType> INCCCKABJLE(PPCKNLKCKFC<TType> PNODNPKGJKB, PPCKNLKCKFC<TType> JHNJJGDAEGF)
			{
				return default(PPCKNLKCKFC<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3890AC0", Offset = "0x388FAC0", VA = "0x183890AC0")]
			public int HFOGECGALFM(TNode OHDOOCGHDGN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3890440", Offset = "0x388F440", VA = "0x183890440")]
			public int FJCCICJMHPJ(TNode OHDOOCGHDGN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3891260", Offset = "0x3890260", VA = "0x183891260")]
			public TInput KOIHOPAFMGC(TNode OHDOOCGHDGN, int HCALFJOJKJO)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x38903C0", Offset = "0x388F3C0", VA = "0x1838903C0")]
			public int FFHBEKKEGHE(TNode OHDOOCGHDGN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x388FEA0", Offset = "0x388EEA0", VA = "0x18388FEA0")]
			public TOutput EFHCKCHOKIB(TNode OHDOOCGHDGN, int HCALFJOJKJO)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3890130", Offset = "0x388F130", VA = "0x183890130")]
			public IEnumerable<BLCPKLAMOBO<TType>> ENGCBJHLAHM(TNode OHDOOCGHDGN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x388F930", Offset = "0x388E930", VA = "0x18388F930")]
			public IEnumerable<PIIHGOPFEAH<TNode>> AOGHDPDAKNM([In] TNode OHDOOCGHDGN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3890FC0", Offset = "0x388FFC0", VA = "0x183890FC0")]
			public TType JGGEIPNGHMF(TInput MIFEONEPPKP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x388FC90", Offset = "0x388EC90", VA = "0x18388FC90")]
			public int DBGDIBBIHKI(TInput MIFEONEPPKP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3891110", Offset = "0x3890110", VA = "0x183891110")]
			public TOutput JNIMHBCIOPO(TInput MIFEONEPPKP, int HCALFJOJKJO)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x388FA80", Offset = "0x388EA80", VA = "0x18388FA80")]
			public TNode BMPLPFJBLMD(TInput MIFEONEPPKP)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x38917D0", Offset = "0x38907D0", VA = "0x1838917D0")]
			public TType MHGJNIBHCJJ(TOutput CKLHFLIDCEO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3891640", Offset = "0x3890640", VA = "0x183891640")]
			public int MBIIIMIGPKH(TOutput CKLHFLIDCEO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x38918E0", Offset = "0x38908E0", VA = "0x1838918E0")]
			public TInput NGFHGEOCIFJ(TOutput CKLHFLIDCEO, int HCALFJOJKJO)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3890030", Offset = "0x388F030", VA = "0x183890030")]
			public TNode EJCCGCHGLJK(TOutput CKLHFLIDCEO)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x388F970", Offset = "0x388E970", VA = "0x18388F970")]
			public bool BLGAAPNPBDP(TType HNGLFCFOHLI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x388F5B0", Offset = "0x388E5B0", VA = "0x18388F5B0")]
			public TType ADEJNKJLEOK(TType HNGLFCFOHLI, IEnumerable<TType> IBPIHAFLDDB)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x388F6F0", Offset = "0x388E6F0", VA = "0x18388F6F0")]
			public void ANECLEOFFME(TType HNGLFCFOHLI, Action<TType> AFLBCFGAFHB, Action<TType> FGHPMJCNCPD, Action<TType> MGDOOCNFIED, Action<TType> EAHPKJMJONI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x388F3D0", Offset = "0x388E3D0", VA = "0x18388F3D0")]
			public TType ABJMDKEEDKD(TType HNGLFCFOHLI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x38901F0", Offset = "0x388F1F0", VA = "0x1838901F0")]
			public string ENMMJAPMFHI(TType HNGLFCFOHLI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3891B80", Offset = "0x3890B80", VA = "0x183891B80")]
			public TTerm PPJJINHHIOO()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3891460", Offset = "0x3890460", VA = "0x183891460")]
			public TTerm LBMOAONMGGK(TTerm BAGMGJGJLNH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x38914A0", Offset = "0x38904A0", VA = "0x1838914A0")]
			public TTerm LNMODNKDNEO(TTerm GOCEFODHDBO, TTerm FICFNKLGBCA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3890EB0", Offset = "0x388FEB0", VA = "0x183890EB0")]
			public void INGPHMGJNAM(TTerm PNODNPKGJKB, TTerm JHNJJGDAEGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x388FDE0", Offset = "0x388EDE0", VA = "0x18388FDE0")]
			public bool ECKLDCKMDCD(TOutputTerm BAGMGJGJLNH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3890880", Offset = "0x388F880", VA = "0x183890880")]
			public bool GHBHNLBBJEB(TOutputTerm BAGMGJGJLNH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x38911A0", Offset = "0x38901A0", VA = "0x1838911A0")]
			public TTerm KEMHHCNNEBP(TOutputTerm LCGDOBKJCNL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x388F6B0", Offset = "0x388E6B0", VA = "0x18388F6B0")]
			public TOutputTerm AFIGAEKCPKO(TOutputTerm BAGMGJGJLNH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3891B00", Offset = "0x3890B00", VA = "0x183891B00")]
			public TOutputTerm PNCKADJPMGM(TOutputTerm BAGMGJGJLNH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3890B80", Offset = "0x388FB80", VA = "0x183890B80")]
			public TTerm HICJOMMLLEM(TOutputSubstitution GJNAPNEMFDA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x38909C0", Offset = "0x388F9C0", VA = "0x1838909C0")]
			public TOutputTerm HAPDEIKHNAH(TOutputSubstitution GJNAPNEMFDA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x388FC50", Offset = "0x388EC50", VA = "0x18388FC50")]
			public TOutputTerm CPANKPLHIMI(TTerm BAGMGJGJLNH)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class MPIBIGAPFFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public EEODDDMIONG arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public MPIBIGAPFFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4585BE0", Offset = "0x4584BE0", VA = "0x184585BE0")]
			internal int PEMBJGCBCEK(EEODDDMIONG arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4585B20", Offset = "0x4584B20", VA = "0x184585B20")]
			internal TInput KNJKJJCJMGD(EEODDDMIONG arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4585840", Offset = "0x4584840", VA = "0x184585840")]
			internal int CFMLABMBJHA(EEODDDMIONG arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x45859E0", Offset = "0x45849E0", VA = "0x1845859E0")]
			internal TOutput HMAIKKHFDLB(EEODDDMIONG arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class DAPHONECJEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public EEODDDMIONG arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, PGIGIKAPHHH<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<PGIGIKAPHHH<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public DAPHONECJEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x58203F0", Offset = "0x581F3F0", VA = "0x1858203F0")]
			internal (string, TTerm) EDIJCAFIFDP(BLCPKLAMOBO<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class AKIFNMGDHCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public EEODDDMIONG arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public AKIFNMGDHCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3E25E40", Offset = "0x3E24E40", VA = "0x183E25E40")]
			internal void CEPKEJEBHID(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3E26A70", Offset = "0x3E25A70", VA = "0x183E26A70")]
			internal void NGDAOGINFAH(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3E26570", Offset = "0x3E25570", VA = "0x183E26570")]
			internal void GKAKHLOBCJC(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3E26770", Offset = "0x3E25770", VA = "0x183E26770")]
			internal void HPAHHAOOMAL(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class IEKBIGCKFKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public EEODDDMIONG arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
			public IEKBIGCKFKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3EC2300", Offset = "0x3EC1300", VA = "0x183EC2300")]
			internal TTerm EHLANENJGEF(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x41DEC00", Offset = "0x41DDC00", VA = "0x1841DEC00")]
		private static HBGKLLMLFKL MEGKMAAOIAG([CallerMemberName] string CKEJJGPNKGO = "")
		{
			return default(HBGKLLMLFKL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x41D47C0", Offset = "0x41D37C0", VA = "0x1841D47C0")]
		public static Dictionary<TNode, List<BLCPKLAMOBO<TType>>> EGBCBKIMIID(TRoot JMCFDCHCIPI, TDeps HPGJLJLFPIH, TGraph MKCPNDCEKPI, IEnumerable<TNode> HOMCNBABMFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x41CDDC0", Offset = "0x41CCDC0", VA = "0x1841CDDC0")]
		private static (Dictionary<TTerm, PGIGIKAPHHH<TNode>>, List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>>) CLLENPJNOKN(IEnumerable<TNode> HOMCNBABMFK, EEODDDMIONG OEMEKBFANIG)
		{
			return default((Dictionary<TTerm, PGIGIKAPHHH<TNode>>, List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x41D8130", Offset = "0x41D7130", VA = "0x1841D8130")]
		private static void HDJOHFCCNJP(TNode OHDOOCGHDGN, Dictionary<TInput, TTerm> BAMHNPLDGDN, Dictionary<TOutput, TTerm> GMEAMHMGPNP, Dictionary<TTerm, PGIGIKAPHHH<TNode>> IHIHADICAHL, Dictionary<PGIGIKAPHHH<TNode>, TTerm> KEJAKAOFAJE, List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> NKNBMBJOKOD, Stack<TNode> CEMFPHADHDI, List<PIIHGOPFEAH<TNode>> IGGHMPMCGJK, EEODDDMIONG OEMEKBFANIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x41DE8D0", Offset = "0x41DD8D0", VA = "0x1841DE8D0")]
		private static Dictionary<string, TTerm> KBJHJGJFHON(TNode OHDOOCGHDGN, Dictionary<TTerm, PGIGIKAPHHH<TNode>> IHIHADICAHL, Dictionary<PGIGIKAPHHH<TNode>, TTerm> HAILECJOHAB, List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> NKNBMBJOKOD, EEODDDMIONG OEMEKBFANIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8340", Offset = "0x2AE7340", VA = "0x182AE8340")]
		private static (TPort, TTerm)[] MLJKADABDCG<TPort>(TNode OHDOOCGHDGN, Func<EEODDDMIONG, TNode, int> MGDKBNDFHNI, Func<EEODDDMIONG, TNode, int, TPort> ALJHKFIKOHB, Func<EEODDDMIONG, TPort, TType> JEDLAGLNOID, Dictionary<TPort, TTerm> KMJOCKADHIL, EEODDDMIONG OEMEKBFANIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x41D0520", Offset = "0x41CF520", VA = "0x1841D0520")]
		private static (TTerm, TTerm) CNHHEPMDEEH((TOutput Output, TTerm Id)[] FNPAAGAEKPL, List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> NKNBMBJOKOD, Dictionary<string, TTerm> HAILECJOHAB, Stack<TNode> CEMFPHADHDI, EEODDDMIONG OEMEKBFANIG)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x41D12D0", Offset = "0x41D02D0", VA = "0x1841D12D0")]
		private static void DMCCPJIMPCK((TInput PortKey, TTerm Id)[] FHCLAGOMKDK, TTerm GPBEODKKKPJ, TTerm LGLPNEJAEPH, List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> NKNBMBJOKOD, Dictionary<TOutput, TTerm> GMEAMHMGPNP, Dictionary<string, TTerm> HAILECJOHAB, Stack<TNode> CEMFPHADHDI, EEODDDMIONG OEMEKBFANIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x41DA710", Offset = "0x41D9710", VA = "0x1841DA710")]
		private static TTerm HKIJCPMGMLN(TInput MIFEONEPPKP, List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> NKNBMBJOKOD, Dictionary<TOutput, TTerm> GMEAMHMGPNP, Stack<TNode> CEMFPHADHDI, EEODDDMIONG OEMEKBFANIG)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x41E0B70", Offset = "0x41DFB70", VA = "0x1841E0B70")]
		private static TTerm OKLKCFMAFBI([In] TType HNGLFCFOHLI, IOKind KKBBCGJFAKI, List<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> NKNBMBJOKOD, IReadOnlyDictionary<string, TTerm> HAILECJOHAB, EEODDDMIONG OEMEKBFANIG)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x41D6830", Offset = "0x41D5830", VA = "0x1841D6830")]
		private static Dictionary<TNode, List<BLCPKLAMOBO<TType>>> GPMKDDBNLGB(TOutputSubstitution[] BCLKPHGBPHE, Dictionary<TTerm, PGIGIKAPHHH<TNode>> IHIHADICAHL, IEnumerable<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> NKNBMBJOKOD, EEODDDMIONG OEMEKBFANIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x41D4D90", Offset = "0x41D3D90", VA = "0x1841D4D90")]
		private static Dictionary<TNode, List<BLCPKLAMOBO<TType>>> FEBDIKNCHMB(Dictionary<TTerm, PGIGIKAPHHH<TNode>> IHIHADICAHL, EEODDDMIONG OEMEKBFANIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x41DFE50", Offset = "0x41DEE50", VA = "0x1841DFE50")]
		private static void NDJJFFHFKEA([In] TNode OHDOOCGHDGN, Stack<TNode> CEMFPHADHDI, List<PIIHGOPFEAH<TNode>> IGGHMPMCGJK, EEODDDMIONG OEMEKBFANIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x41CB1C0", Offset = "0x41CA1C0", VA = "0x1841CB1C0")]
		private static void BOICHLDPPGE(Dictionary<PGIGIKAPHHH<TNode>, TTerm> HAILECJOHAB, List<PIIHGOPFEAH<TNode>> IGGHMPMCGJK, EEODDDMIONG OEMEKBFANIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x41DD650", Offset = "0x41DC650", VA = "0x1841DD650")]
		private static Dictionary<TTerm, TType> ILKIIAKDBPH(Dictionary<TTerm, TOutputSubstitution> BCLKPHGBPHE, IEnumerable<KeyValuePair<TTerm, PPCKNLKCKFC<TType>>> NKNBMBJOKOD, EEODDDMIONG OEMEKBFANIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x41DECC0", Offset = "0x41DDCC0", VA = "0x1841DECC0")]
		private static IHMGDPHFMFJ<TType> MPIJGPFLCED(TOutputTerm HNGLFCFOHLI, Dictionary<TTerm, TType> NKNBMBJOKOD, Dictionary<TTerm, TType> JLBEALEHLIN, EEODDDMIONG OEMEKBFANIG)
		{
			return default(IHMGDPHFMFJ<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x41CC0C0", Offset = "0x41CB0C0", VA = "0x1841CC0C0")]
		private static TOutputTerm BPLFOHIIKPB(TOutputTerm DEFBECAOFED, EEODDDMIONG OEMEKBFANIG)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CB60", Offset = "0x2D7BB60", VA = "0x182D7CB60")]
	public static Dictionary<TNode, List<BLCPKLAMOBO<TType>>> EGBCBKIMIID<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::IEMLGAEIHKN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> KALCJEIICGB, TRoot JMCFDCHCIPI, TGraph MKCPNDCEKPI, IEnumerable<TNode> HOMCNBABMFK) where TDeps : global::HEBDMPFAJKH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct BLCPKLAMOBO<TType> : IEquatable<BLCPKLAMOBO<TType>>, GCBAFALFAIH<BLCPKLAMOBO<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string NPDJPDJBDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType AKOKJIJMACA;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C590", Offset = "0x4E9B590", VA = "0x184E9C590")]
	internal BLCPKLAMOBO(string CKEJJGPNKGO, [In] TType CJLJBBEMHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C470", Offset = "0x4E9B470", VA = "0x184E9C470")]
	public bool NHJNKDEDALG([In] BLCPKLAMOBO<TType> ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C420", Offset = "0x4E9B420", VA = "0x184E9C420", Slot = "4")]
	public bool Equals(BLCPKLAMOBO<TType> ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x41C9100", Offset = "0x41C8100", VA = "0x1841C9100", Slot = "0")]
	public override bool Equals(object ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x20654C0", Offset = "0x20644C0", VA = "0x1820654C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C550", Offset = "0x4E9B550", VA = "0x184E9C550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C3D0", Offset = "0x4E9B3D0", VA = "0x184E9C3D0", Slot = "5")]
	private bool DFMAHJGNBHI([In] BLCPKLAMOBO<TType> ACBLPNJDJBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GBIBEFCOOGA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2BB53C0", Offset = "0x2BB43C0", VA = "0x182BB53C0")]
	public static BLCPKLAMOBO<TType> GAKCNKPJGEK<TType>(string CKEJJGPNKGO, TType CJLJBBEMHKO)
	{
		return default(BLCPKLAMOBO<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2BB53F0", Offset = "0x2BB43F0", VA = "0x182BB53F0")]
	public static (string, TType) NELBIDCDMIE<TType>([In] this BLCPKLAMOBO<TType> KALCJEIICGB)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct PGIGIKAPHHH<TNode> : IEquatable<PGIGIKAPHHH<TNode>>, GCBAFALFAIH<PGIGIKAPHHH<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode CPFJDMHAFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string NPDJPDJBDCA;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xEB7C80", Offset = "0xEB6C80", VA = "0x180EB7C80")]
	internal PGIGIKAPHHH(TNode OHDOOCGHDGN, string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x47A3A00", Offset = "0x47A2A00", VA = "0x1847A3A00")]
	public bool NHJNKDEDALG([In] PGIGIKAPHHH<TNode> ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x47A3940", Offset = "0x47A2940", VA = "0x1847A3940", Slot = "4")]
	public bool Equals(PGIGIKAPHHH<TNode> ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x41C9100", Offset = "0x41C8100", VA = "0x1841C9100", Slot = "0")]
	public override bool Equals(object ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x47A3990", Offset = "0x47A2990", VA = "0x1847A3990", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x47A3BC0", Offset = "0x47A2BC0", VA = "0x1847A3BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x47A38A0", Offset = "0x47A28A0", VA = "0x1847A38A0", Slot = "5")]
	private bool AHLDMKCOFDP([In] PGIGIKAPHHH<TNode> ACBLPNJDJBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FJOOAFOOIGF
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2BAAF30", Offset = "0x2BA9F30", VA = "0x182BAAF30")]
	public static PGIGIKAPHHH<TNode> GAKCNKPJGEK<TNode>(TNode OHDOOCGHDGN, string CKEJJGPNKGO)
	{
		return default(PGIGIKAPHHH<TNode>);
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
