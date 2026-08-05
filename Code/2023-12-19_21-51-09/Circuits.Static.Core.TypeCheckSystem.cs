using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct GCLONBGKMMO<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType IBCFEMEEMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind HJAFEINCEEF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x17525C0", Offset = "0x17511C0", VA = "0x1817525C0")]
	internal GCLONBGKMMO(TType OMKEAAPIABA, IOKind GNDPFKOGKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35A3CC0", Offset = "0x35A28C0", VA = "0x1835A3CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JGHBJDJKHHF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2545FF0", Offset = "0x2544BF0", VA = "0x182545FF0")]
	public static GCLONBGKMMO<TType> OOMHMBNJBCG<TType>(TType OMKEAAPIABA, IOKind GNDPFKOGKHO)
	{
		return default(GCLONBGKMMO<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2545F50", Offset = "0x2544B50", VA = "0x182545F50")]
	public static (TType, IOKind) NCGCFNNBLDJ<TType>([In] this GCLONBGKMMO<TType> HHHLENOMLMP)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2545F90", Offset = "0x2544B90", VA = "0x182545F90")]
	public static void OJCJGJJAKEJ<TType>([In] this GCLONBGKMMO<TType> HHHLENOMLMP, [Out] TType OMKEAAPIABA, [Out] IOKind GNDPFKOGKHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct AFOBJPNNNFO<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DJPFBKNOBKA<TNode> IDCAGPPDBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly DJPFBKNOBKA<TNode> NFGGNJAFMDD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x356D5D0", Offset = "0x356C1D0", VA = "0x18356D5D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KJEMGMILHHG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x256E860", Offset = "0x256D460", VA = "0x18256E860")]
	public static (DJPFBKNOBKA<TNode>, DJPFBKNOBKA<TNode>) NCGCFNNBLDJ<TNode>([In] this AFOBJPNNNFO<TNode> HHHLENOMLMP)
	{
		return default((DJPFBKNOBKA<TNode>, DJPFBKNOBKA<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x256E900", Offset = "0x256D500", VA = "0x18256E900")]
	public static void OJCJGJJAKEJ<TNode>([In] this AFOBJPNNNFO<TNode> HHHLENOMLMP, [Out] DJPFBKNOBKA<TNode> CNJMMNBENNL, [Out] DJPFBKNOBKA<TNode> PLPCDFMLHIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FLLGEFPBJKN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BEJICDOEKPE LADJIJICHNL(TRoot NMHGPHBIAIB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType KEAAANEMLJK(TRoot NMHGPHBIAIB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GCLONBGKMMO<TType> OGLPGJBIGKB(TRoot NMHGPHBIAIB, [In] GCLONBGKMMO<TType> AGIBINPMDEG, [In] GCLONBGKMMO<TType> BBPKFALMKGI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DIFKPCIIHNJ(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TNode NIICEONAONO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FFHABNNMMKE(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TNode NIICEONAONO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput EELLNGKJLPD(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TNode NIICEONAONO, int DCGGFHOCGGH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NIKJFFEAMPP(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TNode NIICEONAONO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput PJCELOBNHGM(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TNode NIICEONAONO, int DCGGFHOCGGH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IEEONDAELIH<TType>> EMFEBOEPMJD(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TNode NIICEONAONO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<AFOBJPNNNFO<TNode>> HOBICDAKAGA(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TNode NIICEONAONO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType BEPAPBBEPGP(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TInput MAIMNHFMIBD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int DEKFIDJDPKD(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TInput MAIMNHFMIBD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput EFOPNKJOAFL(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TInput MAIMNHFMIBD, int DCGGFHOCGGH);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode NKPLNIFGILM(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TInput MAIMNHFMIBD);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType FLCNPDMCMPB(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TOutput KFCKHKPLALN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int BONEGJIACIL(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TOutput KFCKHKPLALN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput BHNPPPNKIOH(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TOutput KFCKHKPLALN, int DCGGFHOCGGH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode LCMJGDJDNKE(TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, TOutput KFCKHKPLALN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BDHPLIHGBLP(TRoot NMHGPHBIAIB, TType OMKEAAPIABA);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType BBILBKPDCDN(TRoot NMHGPHBIAIB, TType OMKEAAPIABA, IEnumerable<TType> BIDEFOEIMJB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DLIPEOOFJCO(TRoot NMHGPHBIAIB, TType OMKEAAPIABA, Action<TType> CLNFGLPELHI, Action<TType> FIEOLENKKLG, Action<TType> MNPGNDDIMPF, Action<TType> MJCFOILEFMK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType EHGPAMNHNOI(TRoot NMHGPHBIAIB, TType OMKEAAPIABA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string EFJEBDIDFLH(TRoot NMHGPHBIAIB, TType OMKEAAPIABA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification MNEKMNKHGPC(TRoot NMHGPHBIAIB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MEPDFJNPAPE<TOutputSubstitution[], LGEMOLNFJEJ> NKBKLGFAJDF(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm AOKKOAKEHMG(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm HEPEFHEHHKO(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TTerm NHIMJKMDKMH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm GAKCKBDKBEI(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TTerm JEHKFEAPIEI, TTerm JLMAKMFNDLF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DDOENNCCKBJ(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TTerm AGIBINPMDEG, TTerm BBPKFALMKGI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool HHIAGBPDBGN(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TOutputTerm LJEFFMKOPON);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DOHHEPJNHOI(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TOutputTerm LJEFFMKOPON);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm HDCHBPMFDFM(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TOutputTerm LJEFFMKOPON);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm FENCDOPAJNL(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TOutputTerm LJEFFMKOPON);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm OJJEIFIMPDP(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TOutputTerm LJEFFMKOPON);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm JNFEELAHHBF(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TOutputSubstitution LJEGBEFNKIK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm LBBNHOFLOGK(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TOutputSubstitution LJEGBEFNKIK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm ADKGKEDHDBA(TRoot NMHGPHBIAIB, TUnification FJAHEOCAMHA, TTerm NHIMJKMDKMH);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct DPBGMHKPGGM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::FLLGEFPBJKN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0")]
	public static global::DPBGMHKPGGM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> OOMHMBNJBCG()
	{
		return default(global::DPBGMHKPGGM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NCOLEANCOMI
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class HFJOIGPNHHK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::FLLGEFPBJKN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class OBJIJNGEDLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot EGCFCBLCCIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps KDJMALIPENJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification GACCCBGHCFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph FOGGBEGICPH;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public BEJICDOEKPE FIGDLMPFNEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x3DE69A0", Offset = "0x3DE55A0", VA = "0x183DE69A0")]
				get
				{
					return default(BEJICDOEKPE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3DE79A0", Offset = "0x3DE65A0", VA = "0x183DE79A0")]
			private OBJIJNGEDLO(TRoot NMHGPHBIAIB, TDeps BKGJDHEGAMG, TUnification OJIEEGCLFIM, TGraph AOCLFOFOOFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7420", Offset = "0x3DE6020", VA = "0x183DE7420")]
			public static OBJIJNGEDLO OOMHMBNJBCG(TRoot NMHGPHBIAIB, TDeps BKGJDHEGAMG, TUnification OJIEEGCLFIM, TGraph AOCLFOFOOFK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6BC0", Offset = "0x3DE57C0", VA = "0x183DE6BC0")]
			public TType KEAAANEMLJK()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7130", Offset = "0x3DE5D30", VA = "0x183DE7130")]
			public GCLONBGKMMO<TType> OGLPGJBIGKB(GCLONBGKMMO<TType> AGIBINPMDEG, GCLONBGKMMO<TType> BBPKFALMKGI)
			{
				return default(GCLONBGKMMO<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5680", Offset = "0x3DE4280", VA = "0x183DE5680")]
			public int DIFKPCIIHNJ(TNode NIICEONAONO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3DE60D0", Offset = "0x3DE4CD0", VA = "0x183DE60D0")]
			public int FFHABNNMMKE(TNode NIICEONAONO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3DE59D0", Offset = "0x3DE45D0", VA = "0x183DE59D0")]
			public TInput EELLNGKJLPD(TNode NIICEONAONO, int DCGGFHOCGGH)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6FD0", Offset = "0x3DE5BD0", VA = "0x183DE6FD0")]
			public int NIKJFFEAMPP(TNode NIICEONAONO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7840", Offset = "0x3DE6440", VA = "0x183DE7840")]
			public TOutput PJCELOBNHGM(TNode NIICEONAONO, int DCGGFHOCGGH)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5EB0", Offset = "0x3DE4AB0", VA = "0x183DE5EB0")]
			public IEnumerable<IEEONDAELIH<TType>> EMFEBOEPMJD(TNode NIICEONAONO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6710", Offset = "0x3DE5310", VA = "0x183DE6710")]
			public IEnumerable<AFOBJPNNNFO<TNode>> HOBICDAKAGA([In] TNode NIICEONAONO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5270", Offset = "0x3DE3E70", VA = "0x183DE5270")]
			public TType BEPAPBBEPGP(TInput MAIMNHFMIBD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6790", Offset = "0x3DE5390", VA = "0x183DE6790")]
			public int IOGKGHONNAE(TInput MAIMNHFMIBD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5C10", Offset = "0x3DE4810", VA = "0x183DE5C10")]
			public TOutput EFOPNKJOAFL(TInput MAIMNHFMIBD, int DCGGFHOCGGH)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3DE70E0", Offset = "0x3DE5CE0", VA = "0x183DE70E0")]
			public TNode NKPLNIFGILM(TInput MAIMNHFMIBD)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6260", Offset = "0x3DE4E60", VA = "0x183DE6260")]
			public TType FLCNPDMCMPB(TOutput KFCKHKPLALN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6DF0", Offset = "0x3DE59F0", VA = "0x183DE6DF0")]
			public int LKAFLLANKPO(TOutput KFCKHKPLALN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3DE53D0", Offset = "0x3DE3FD0", VA = "0x183DE53D0")]
			public TInput BHNPPPNKIOH(TOutput KFCKHKPLALN, int DCGGFHOCGGH)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6DA0", Offset = "0x3DE59A0", VA = "0x183DE6DA0")]
			public TNode LCMJGDJDNKE(TOutput KFCKHKPLALN)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5090", Offset = "0x3DE3C90", VA = "0x183DE5090")]
			public bool BDHPLIHGBLP(TType OMKEAAPIABA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3DE4FD0", Offset = "0x3DE3BD0", VA = "0x183DE4FD0")]
			public TType BBILBKPDCDN(TType OMKEAAPIABA, IEnumerable<TType> BIDEFOEIMJB)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3DE57E0", Offset = "0x3DE43E0", VA = "0x183DE57E0")]
			public void DLIPEOOFJCO(TType OMKEAAPIABA, Action<TType> CLNFGLPELHI, Action<TType> FIEOLENKKLG, Action<TType> MNPGNDDIMPF, Action<TType> MJCFOILEFMK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5DC0", Offset = "0x3DE49C0", VA = "0x183DE5DC0")]
			public TType EHGPAMNHNOI(TType OMKEAAPIABA)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5BD0", Offset = "0x3DE47D0", VA = "0x183DE5BD0")]
			public string EFJEBDIDFLH(TType OMKEAAPIABA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3DE4F20", Offset = "0x3DE3B20", VA = "0x183DE4F20")]
			public TTerm AOKKOAKEHMG()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6520", Offset = "0x3DE5120", VA = "0x183DE6520")]
			public TTerm HEPEFHEHHKO(TTerm NHIMJKMDKMH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3DE62B0", Offset = "0x3DE4EB0", VA = "0x183DE62B0")]
			public TTerm GAKCKBDKBEI(TTerm JEHKFEAPIEI, TTerm JLMAKMFNDLF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5420", Offset = "0x3DE4020", VA = "0x183DE5420")]
			public void DDOENNCCKBJ(TTerm AGIBINPMDEG, TTerm BBPKFALMKGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5910", Offset = "0x3DE4510", VA = "0x183DE5910")]
			public bool DOHHEPJNHOI(TOutputTerm NHIMJKMDKMH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3DE65F0", Offset = "0x3DE51F0", VA = "0x183DE65F0")]
			public bool HHIAGBPDBGN(TOutputTerm NHIMJKMDKMH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3DE77F0", Offset = "0x3DE63F0", VA = "0x183DE77F0")]
			public TTerm PECDMLLLLHO(TOutputTerm LJEFFMKOPON)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5FF0", Offset = "0x3DE4BF0", VA = "0x183DE5FF0")]
			public TOutputTerm FENCDOPAJNL(TOutputTerm NHIMJKMDKMH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3DE7350", Offset = "0x3DE5F50", VA = "0x183DE7350")]
			public TOutputTerm OJJEIFIMPDP(TOutputTerm NHIMJKMDKMH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3DE69E0", Offset = "0x3DE55E0", VA = "0x183DE69E0")]
			public TTerm JNFEELAHHBF(TOutputSubstitution CAMNNDBJBLC)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3DE6C00", Offset = "0x3DE5800", VA = "0x183DE6C00")]
			public TOutputTerm LBBNHOFLOGK(TOutputSubstitution CAMNNDBJBLC)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3DE4DC0", Offset = "0x3DE39C0", VA = "0x183DE4DC0")]
			public TOutputTerm ADKGKEDHDBA(TTerm NHIMJKMDKMH)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class DHMOAMFCOEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public OBJIJNGEDLO arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public DHMOAMFCOEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4E445D0", Offset = "0x4E431D0", VA = "0x184E445D0")]
			internal int KAHHFLODOPH(OBJIJNGEDLO arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4E44620", Offset = "0x4E43220", VA = "0x184E44620")]
			internal TInput NHEBBFKLPEP(OBJIJNGEDLO arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4E44460", Offset = "0x4E43060", VA = "0x184E44460")]
			internal int DPAIKLLBOGI(OBJIJNGEDLO arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4E44510", Offset = "0x4E43110", VA = "0x184E44510")]
			internal TOutput GDHKNHEGOAC(OBJIJNGEDLO arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PIJKLCLAILH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public OBJIJNGEDLO arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, DJPFBKNOBKA<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<DJPFBKNOBKA<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public PIJKLCLAILH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3EA05A0", Offset = "0x3E9F1A0", VA = "0x183EA05A0")]
			internal (string, TTerm) BIKNIKOOCDG(IEEONDAELIH<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class FCPFLAKKDJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public OBJIJNGEDLO arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public FCPFLAKKDJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x34C9910", Offset = "0x34C8510", VA = "0x1834C9910")]
			internal void HIHHLPMPAMO(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x34C9510", Offset = "0x34C8110", VA = "0x1834C9510")]
			internal void GKCHFBKFKHM(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x34C9B50", Offset = "0x34C8750", VA = "0x1834C9B50")]
			internal void HKECLEMBPAJ(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x34C9ED0", Offset = "0x34C8AD0", VA = "0x1834C9ED0")]
			internal void HNDBGOJAFNB(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class FBAHMDCMEKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OBJIJNGEDLO arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
			public FBAHMDCMEKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x34C5BF0", Offset = "0x34C47F0", VA = "0x1834C5BF0")]
			internal TTerm AFDHCAAKDDN(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3653530", Offset = "0x3652130", VA = "0x183653530")]
		private static OJOKGKDFNDH KIHLAPECION([CallerMemberName] string JEICAPDKHKI = "")
		{
			return default(OJOKGKDFNDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3658780", Offset = "0x3657380", VA = "0x183658780")]
		public static Dictionary<TNode, List<IEEONDAELIH<TType>>> ONJDHJHKOAE(TRoot NMHGPHBIAIB, TDeps BKGJDHEGAMG, TGraph AOCLFOFOOFK, IEnumerable<TNode> MCONEMCFFOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3657040", Offset = "0x3655C40", VA = "0x183657040")]
		private static (Dictionary<TTerm, DJPFBKNOBKA<TNode>>, List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>>) MPOJGHJEACN(IEnumerable<TNode> MCONEMCFFOM, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return default((Dictionary<TTerm, DJPFBKNOBKA<TNode>>, List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x364D0C0", Offset = "0x364BCC0", VA = "0x18364D0C0")]
		private static void GJDKHNFFHGI(TNode NIICEONAONO, Dictionary<TInput, TTerm> GABEDKKPEEA, Dictionary<TOutput, TTerm> ACMBAOGIAOC, Dictionary<TTerm, DJPFBKNOBKA<TNode>> EDIJGDDBEDA, Dictionary<DJPFBKNOBKA<TNode>, TTerm> BDDBGNJHLKP, List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> HPBLNGGOIBA, Stack<TNode> GCAIMLJNIEA, List<AFOBJPNNNFO<TNode>> EFLFGJFFDGE, OBJIJNGEDLO NGMDGDAKJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x364C800", Offset = "0x364B400", VA = "0x18364C800")]
		private static Dictionary<string, TTerm> DDBOGBKGLLD(TNode NIICEONAONO, Dictionary<TTerm, DJPFBKNOBKA<TNode>> EDIJGDDBEDA, Dictionary<DJPFBKNOBKA<TNode>, TTerm> JLPDCIJGAIF, List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> HPBLNGGOIBA, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2105740", Offset = "0x2104340", VA = "0x182105740")]
		private static (TPort, TTerm)[] BJLBIDNMBPO<TPort>(TNode NIICEONAONO, Func<OBJIJNGEDLO, TNode, int> PCAJMIAEMFB, Func<OBJIJNGEDLO, TNode, int, TPort> OEOICOAEMNI, Func<OBJIJNGEDLO, TPort, TType> JNAOEIGMKPO, Dictionary<TPort, TTerm> KLPBKMOHKNH, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x365D360", Offset = "0x365BF60", VA = "0x18365D360")]
		private static (TTerm, TTerm) PBOKINKGEKI((TOutput Output, TTerm Id)[] APGEHCGJEJO, List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> HPBLNGGOIBA, Dictionary<string, TTerm> JLPDCIJGAIF, Stack<TNode> GCAIMLJNIEA, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3654EA0", Offset = "0x3653AA0", VA = "0x183654EA0")]
		private static void LEMHOOJNBHC((TInput PortKey, TTerm Id)[] KOIHGOCMHIH, TTerm IMGOHMOIADC, TTerm CPLLEIIKMIO, List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> HPBLNGGOIBA, Dictionary<TOutput, TTerm> ACMBAOGIAOC, Dictionary<string, TTerm> JLPDCIJGAIF, Stack<TNode> GCAIMLJNIEA, OBJIJNGEDLO NGMDGDAKJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3652B20", Offset = "0x3651720", VA = "0x183652B20")]
		private static TTerm HGACECNGNHB(TInput MAIMNHFMIBD, List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> HPBLNGGOIBA, Dictionary<TOutput, TTerm> ACMBAOGIAOC, Stack<TNode> GCAIMLJNIEA, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x364CB00", Offset = "0x364B700", VA = "0x18364CB00")]
		private static TTerm DKALHCIPPBA([In] TType OMKEAAPIABA, IOKind GNDPFKOGKHO, List<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> HPBLNGGOIBA, IReadOnlyDictionary<string, TTerm> JLPDCIJGAIF, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x36519E0", Offset = "0x36505E0", VA = "0x1836519E0")]
		private static Dictionary<TNode, List<IEEONDAELIH<TType>>> GKCNJOMPBEI(TOutputSubstitution[] PJKLGIFKCDJ, Dictionary<TTerm, DJPFBKNOBKA<TNode>> EDIJGDDBEDA, IEnumerable<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> HPBLNGGOIBA, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x364C080", Offset = "0x364AC80", VA = "0x18364C080")]
		private static Dictionary<TNode, List<IEEONDAELIH<TType>>> CBKLHKDPOKL(Dictionary<TTerm, DJPFBKNOBKA<TNode>> EDIJGDDBEDA, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x364F9A0", Offset = "0x364E5A0", VA = "0x18364F9A0")]
		private static void GJOGAIEHCGA([In] TNode NIICEONAONO, Stack<TNode> GCAIMLJNIEA, List<AFOBJPNNNFO<TNode>> EFLFGJFFDGE, OBJIJNGEDLO NGMDGDAKJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x364A360", Offset = "0x3648F60", VA = "0x18364A360")]
		private static void APBJEFEKNPP(Dictionary<DJPFBKNOBKA<TNode>, TTerm> JLPDCIJGAIF, List<AFOBJPNNNFO<TNode>> EFLFGJFFDGE, OBJIJNGEDLO NGMDGDAKJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x365AAE0", Offset = "0x36596E0", VA = "0x18365AAE0")]
		private static Dictionary<TTerm, TType> OPIOPFKNIGH(Dictionary<TTerm, TOutputSubstitution> PJKLGIFKCDJ, IEnumerable<KeyValuePair<TTerm, GCLONBGKMMO<TType>>> HPBLNGGOIBA, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x365DFF0", Offset = "0x365CBF0", VA = "0x18365DFF0")]
		private static DICBCILEPFI<TType> POOCBDJGPGL(TOutputTerm OMKEAAPIABA, Dictionary<TTerm, TType> HPBLNGGOIBA, Dictionary<TTerm, TType> NPMIDGOLPAL, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return default(DICBCILEPFI<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x364B300", Offset = "0x3649F00", VA = "0x18364B300")]
		private static TOutputTerm CAHBGACPHJA(TOutputTerm IFGCFMIMLFI, OBJIJNGEDLO NGMDGDAKJOP)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2610BE0", Offset = "0x260F7E0", VA = "0x182610BE0")]
	public static Dictionary<TNode, List<IEEONDAELIH<TType>>> ONJDHJHKOAE<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::DPBGMHKPGGM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> HHHLENOMLMP, TRoot NMHGPHBIAIB, TGraph AOCLFOFOOFK, IEnumerable<TNode> MCONEMCFFOM) where TDeps : global::FLLGEFPBJKN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IEEONDAELIH<TType> : IEquatable<IEEONDAELIH<TType>>, GCMEALEGBOA<IEEONDAELIH<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ODBDFCEODFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType NJLHBFFHHKG;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x31587A0", Offset = "0x31573A0", VA = "0x1831587A0")]
	internal IEEONDAELIH(string JEICAPDKHKI, [In] TType NAEONIPJMHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3711EC0", Offset = "0x3710AC0", VA = "0x183711EC0")]
	public bool DPHKEJFMDME([In] IEEONDAELIH<TType> LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3712010", Offset = "0x3710C10", VA = "0x183712010", Slot = "4")]
	public bool Equals(IEEONDAELIH<TType> LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3711F90", Offset = "0x3710B90", VA = "0x183711F90", Slot = "0")]
	public override bool Equals(object LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EAF0", Offset = "0x1D0D6F0", VA = "0x181D0EAF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x37120B0", Offset = "0x3710CB0", VA = "0x1837120B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3712060", Offset = "0x3710C60", VA = "0x183712060", Slot = "5")]
	private bool ONKELJEJIIH([In] IEEONDAELIH<TType> LLMHBOEDHFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BCOEAEDNHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x22B7240", Offset = "0x22B5E40", VA = "0x1822B7240")]
	public static IEEONDAELIH<TType> OOMHMBNJBCG<TType>(string JEICAPDKHKI, TType NAEONIPJMHM)
	{
		return default(IEEONDAELIH<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x22B7200", Offset = "0x22B5E00", VA = "0x1822B7200")]
	public static (string, TType) NCGCFNNBLDJ<TType>([In] this IEEONDAELIH<TType> HHHLENOMLMP)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DJPFBKNOBKA<TNode> : IEquatable<DJPFBKNOBKA<TNode>>, GCMEALEGBOA<DJPFBKNOBKA<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode KMMDBIDINII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string ODBDFCEODFK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xB64CD0", Offset = "0xB638D0", VA = "0x180B64CD0")]
	internal DJPFBKNOBKA(TNode NIICEONAONO, string JEICAPDKHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4E4B830", Offset = "0x4E4A430", VA = "0x184E4B830")]
	public bool DPHKEJFMDME([In] DJPFBKNOBKA<TNode> LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4E4B900", Offset = "0x4E4A500", VA = "0x184E4B900", Slot = "4")]
	public bool Equals(DJPFBKNOBKA<TNode> LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3711F90", Offset = "0x3710B90", VA = "0x183711F90", Slot = "0")]
	public override bool Equals(object LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4E4BA40", Offset = "0x4E4A640", VA = "0x184E4BA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4E4BAB0", Offset = "0x4E4A6B0", VA = "0x184E4BAB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4E4B9A0", Offset = "0x4E4A5A0", VA = "0x184E4B9A0", Slot = "5")]
	private bool FIOKMOJHHEH([In] DJPFBKNOBKA<TNode> LLMHBOEDHFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PEAEHAFGPJG
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2661C10", Offset = "0x2660810", VA = "0x182661C10")]
	public static DJPFBKNOBKA<TNode> OOMHMBNJBCG<TNode>(TNode NIICEONAONO, string JEICAPDKHKI)
	{
		return default(DJPFBKNOBKA<TNode>);
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
