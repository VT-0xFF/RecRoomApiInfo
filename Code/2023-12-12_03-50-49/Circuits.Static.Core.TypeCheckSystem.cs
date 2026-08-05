using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct ADJNNPBFDMM<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType CCNHBOAJCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind KOGIFOOOMDF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1752790", Offset = "0x1750F90", VA = "0x181752790")]
	internal ADJNNPBFDMM(TType HJNJPNKDEFH, IOKind JKOEFMMPGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3546460", Offset = "0x3544C60", VA = "0x183546460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EEJLCNFBKDA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x237BD00", Offset = "0x237A500", VA = "0x18237BD00")]
	public static ADJNNPBFDMM<TType> AKKFLOCCMNP<TType>(TType HJNJPNKDEFH, IOKind JKOEFMMPGHK)
	{
		return default(ADJNNPBFDMM<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x237BD90", Offset = "0x237A590", VA = "0x18237BD90")]
	public static (TType, IOKind) NCMOAMEHFEG<TType>([In] this ADJNNPBFDMM<TType> PIEBBHMNEOG)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x237BD30", Offset = "0x237A530", VA = "0x18237BD30")]
	public static void DJEJHKAEBIG<TType>([In] this ADJNNPBFDMM<TType> PIEBBHMNEOG, [Out] TType HJNJPNKDEFH, [Out] IOKind JKOEFMMPGHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct EMPAJECHCOE<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly CHNMOMELGGC<TNode> OMGDGKFBCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly CHNMOMELGGC<TNode> FJNNIHANKHI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x311CCC0", Offset = "0x311B4C0", VA = "0x18311CCC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FIOBFABOPIB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24C5BE0", Offset = "0x24C43E0", VA = "0x1824C5BE0")]
	public static (CHNMOMELGGC<TNode>, CHNMOMELGGC<TNode>) NCMOAMEHFEG<TNode>([In] this EMPAJECHCOE<TNode> PIEBBHMNEOG)
	{
		return default((CHNMOMELGGC<TNode>, CHNMOMELGGC<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24C5B00", Offset = "0x24C4300", VA = "0x1824C5B00")]
	public static void DJEJHKAEBIG<TNode>([In] this EMPAJECHCOE<TNode> PIEBBHMNEOG, [Out] CHNMOMELGGC<TNode> PCIGCGBJFLC, [Out] CHNMOMELGGC<TNode> FLACNDCEKPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HHJDEABFHAE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BBBLJJCEMFO EOFGIGHHFEA(TRoot PHEKGOFMNOB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType KGMNKBCAPJH(TRoot PHEKGOFMNOB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ADJNNPBFDMM<TType> OCDPGDJHALB(TRoot PHEKGOFMNOB, [In] ADJNNPBFDMM<TType> NMCFAAKFHJI, [In] ADJNNPBFDMM<TType> AKHEBCAILGG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OMCCMGFFMAN(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TNode ELOONLEOBIM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AABEHOMKIND(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TNode ELOONLEOBIM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput EEKNCJCEDOE(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TNode ELOONLEOBIM, int EAHCFBMNNCF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DIBOLBICOOJ(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TNode ELOONLEOBIM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput DIEMNOHBBCI(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TNode ELOONLEOBIM, int EAHCFBMNNCF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<EDMADECGABL<TType>> LHADHKBBDOD(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TNode ELOONLEOBIM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<EMPAJECHCOE<TNode>> GOGEIIHBAFE(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TNode ELOONLEOBIM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NKJFOPBOGBF(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TInput LLJFBBILFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int FPIEMFFDHIJ(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TInput LLJFBBILFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput MGLHIOMDGFB(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TInput LLJFBBILFIJ, int EAHCFBMNNCF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode CFGKBJMBHME(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TInput LLJFBBILFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType DJONKHKDIOC(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TOutput LBOALPOGADH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int CCOOEBLIGMJ(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TOutput LBOALPOGADH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput NMBBGJBNLKL(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TOutput LBOALPOGADH, int EAHCFBMNNCF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode AHKCHFHJBFD(TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, TOutput LBOALPOGADH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool AMAOIGHJFLH(TRoot PHEKGOFMNOB, TType HJNJPNKDEFH);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType CDGHNENPKEK(TRoot PHEKGOFMNOB, TType HJNJPNKDEFH, IEnumerable<TType> KMCAMFBCBIH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IEEAMDPMNNO(TRoot PHEKGOFMNOB, TType HJNJPNKDEFH, Action<TType> PADDMAJDIGM, Action<TType> MHOMDECHIKC, Action<TType> HBHNMPCGDBJ, Action<TType> KIDCHBABIBM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType JCHPOHAOJKN(TRoot PHEKGOFMNOB, TType HJNJPNKDEFH);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string AJBPLMJLNDA(TRoot PHEKGOFMNOB, TType HJNJPNKDEFH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification NDONHHGGDHH(TRoot PHEKGOFMNOB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	LBFOJMHFNLD<TOutputSubstitution[], CLJHHCKGBLK> BNHHBDDMHDJ(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm KIMCAHOGGJH(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm KEENECDNACA(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TTerm BPNHAFLHMOL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm HEHIHMFDDFC(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TTerm FLHELLMECOK, TTerm IDADLFNFKJF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LOMKFIAOBAK(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TTerm NMCFAAKFHJI, TTerm AKHEBCAILGG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool NNOFLLLHHEN(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TOutputTerm OJBFCPKGKJC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JMKEGLACHBG(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TOutputTerm OJBFCPKGKJC);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm FFHIJPEFIPD(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TOutputTerm OJBFCPKGKJC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm IGJOAENKGPH(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TOutputTerm OJBFCPKGKJC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm GMABKHDOMOI(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TOutputTerm OJBFCPKGKJC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm JEAIBLFGLHL(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TOutputSubstitution GINNKIJEBAC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm LAEFIAMMMGB(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TOutputSubstitution GINNKIJEBAC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm CJKLKKFEDMF(TRoot PHEKGOFMNOB, TUnification PLCDGKFLLBC, TTerm BPNHAFLHMOL);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LJCELOLIEFO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HHJDEABFHAE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0")]
	public static global::LJCELOLIEFO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> AKKFLOCCMNP()
	{
		return default(global::LJCELOLIEFO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EBPLLLIEPDG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class LJALAFOIJLO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::HHJDEABFHAE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class HFMKFAPIMAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot NJGNBOOOJDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps KKICHGCFDJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification CJPDPLDHHPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph MJOMJCLGJBB;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public BBBLJJCEMFO BJKFIPPLEBJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x3596310", Offset = "0x3594B10", VA = "0x183596310")]
				get
				{
					return default(BBBLJJCEMFO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3597DF0", Offset = "0x35965F0", VA = "0x183597DF0")]
			private HFMKFAPIMAH(TRoot PHEKGOFMNOB, TDeps JFHMOFHDJOF, TUnification FDKHJEAOLHA, TGraph OLMAEEEFKOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3595700", Offset = "0x3593F00", VA = "0x183595700")]
			public static HFMKFAPIMAH AKKFLOCCMNP(TRoot PHEKGOFMNOB, TDeps JFHMOFHDJOF, TUnification FDKHJEAOLHA, TGraph OLMAEEEFKOE)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3596FE0", Offset = "0x35957E0", VA = "0x183596FE0")]
			public TType KGMNKBCAPJH()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3597C10", Offset = "0x3596410", VA = "0x183597C10")]
			public ADJNNPBFDMM<TType> OCDPGDJHALB(ADJNNPBFDMM<TType> NMCFAAKFHJI, ADJNNPBFDMM<TType> AKHEBCAILGG)
			{
				return default(ADJNNPBFDMM<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3597D30", Offset = "0x3596530", VA = "0x183597D30")]
			public int OMCCMGFFMAN(TNode ELOONLEOBIM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3595250", Offset = "0x3593A50", VA = "0x183595250")]
			public int AABEHOMKIND(TNode ELOONLEOBIM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3596150", Offset = "0x3594950", VA = "0x183596150")]
			public TInput EEKNCJCEDOE(TNode ELOONLEOBIM, int EAHCFBMNNCF)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3595D30", Offset = "0x3594530", VA = "0x183595D30")]
			public int DIBOLBICOOJ(TNode ELOONLEOBIM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3595F40", Offset = "0x3594740", VA = "0x183595F40")]
			public TOutput DIEMNOHBBCI(TNode ELOONLEOBIM, int EAHCFBMNNCF)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3597370", Offset = "0x3595B70", VA = "0x183597370")]
			public IEnumerable<EDMADECGABL<TType>> LHADHKBBDOD(TNode ELOONLEOBIM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3596470", Offset = "0x3594C70", VA = "0x183596470")]
			public IEnumerable<EMPAJECHCOE<TNode>> GOGEIIHBAFE([In] TNode ELOONLEOBIM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3597700", Offset = "0x3595F00", VA = "0x183597700")]
			public TType NKJFOPBOGBF(TInput LLJFBBILFIJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3596D60", Offset = "0x3595560", VA = "0x183596D60")]
			public int JKEBBKDBJJL(TInput LLJFBBILFIJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3597590", Offset = "0x3595D90", VA = "0x183597590")]
			public TOutput MGLHIOMDGFB(TInput LLJFBBILFIJ, int EAHCFBMNNCF)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3595BC0", Offset = "0x35943C0", VA = "0x183595BC0")]
			public TNode CFGKBJMBHME(TInput LLJFBBILFIJ)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3596010", Offset = "0x3594810", VA = "0x183596010")]
			public TType DJONKHKDIOC(TOutput LBOALPOGADH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3595910", Offset = "0x3594110", VA = "0x183595910")]
			public int CCGMLGKFFOJ(TOutput LBOALPOGADH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3597930", Offset = "0x3596130", VA = "0x183597930")]
			public TInput NMBBGJBNLKL(TOutput LBOALPOGADH, int EAHCFBMNNCF)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3595290", Offset = "0x3593A90", VA = "0x183595290")]
			public TNode AHKCHFHJBFD(TOutput LBOALPOGADH)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x35958D0", Offset = "0x35940D0", VA = "0x1835958D0")]
			public bool AMAOIGHJFLH(TType HJNJPNKDEFH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3595AB0", Offset = "0x35942B0", VA = "0x183595AB0")]
			public TType CDGHNENPKEK(TType HJNJPNKDEFH, IEnumerable<TType> KMCAMFBCBIH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3596830", Offset = "0x3595030", VA = "0x183596830")]
			public void IEEAMDPMNNO(TType HJNJPNKDEFH, Action<TType> PADDMAJDIGM, Action<TType> MHOMDECHIKC, Action<TType> HBHNMPCGDBJ, Action<TType> KIDCHBABIBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3596AD0", Offset = "0x35952D0", VA = "0x183596AD0")]
			public TType JCHPOHAOJKN(TType HJNJPNKDEFH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x35954C0", Offset = "0x3593CC0", VA = "0x1835954C0")]
			public string AJBPLMJLNDA(TType HJNJPNKDEFH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3597130", Offset = "0x3595930", VA = "0x183597130")]
			public TTerm KIMCAHOGGJH()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3596F40", Offset = "0x3595740", VA = "0x183596F40")]
			public TTerm KEENECDNACA(TTerm BPNHAFLHMOL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x35966E0", Offset = "0x3594EE0", VA = "0x1835966E0")]
			public TTerm HEHIHMFDDFC(TTerm FLHELLMECOK, TTerm IDADLFNFKJF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3597540", Offset = "0x3595D40", VA = "0x183597540")]
			public void LOMKFIAOBAK(TTerm NMCFAAKFHJI, TTerm AKHEBCAILGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3596DA0", Offset = "0x35955A0", VA = "0x183596DA0")]
			public bool JMKEGLACHBG(TOutputTerm BPNHAFLHMOL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3597A50", Offset = "0x3596250", VA = "0x183597A50")]
			public bool NNOFLLLHHEN(TOutputTerm BPNHAFLHMOL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3596570", Offset = "0x3594D70", VA = "0x183596570")]
			public TTerm HCGNKCILNMK(TOutputTerm OJBFCPKGKJC)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3596A80", Offset = "0x3595280", VA = "0x183596A80")]
			public TOutputTerm IGJOAENKGPH(TOutputTerm BPNHAFLHMOL)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x35963D0", Offset = "0x3594BD0", VA = "0x1835963D0")]
			public TOutputTerm GMABKHDOMOI(TOutputTerm BPNHAFLHMOL)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3596BC0", Offset = "0x35953C0", VA = "0x183596BC0")]
			public TTerm JEAIBLFGLHL(TOutputSubstitution CPABOBCJOMH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3597220", Offset = "0x3595A20", VA = "0x183597220")]
			public TOutputTerm LAEFIAMMMGB(TOutputSubstitution CPABOBCJOMH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3595CE0", Offset = "0x35944E0", VA = "0x183595CE0")]
			public TOutputTerm CJKLKKFEDMF(TTerm BPNHAFLHMOL)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BAGOKCHLGOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public HFMKFAPIMAH arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public BAGOKCHLGOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x45655A0", Offset = "0x4563DA0", VA = "0x1845655A0")]
			internal int IDACNIJBCJM(HFMKFAPIMAH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x45656A0", Offset = "0x4563EA0", VA = "0x1845656A0")]
			internal TInput KHIOLKOHNPK(HFMKFAPIMAH arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x45657B0", Offset = "0x4563FB0", VA = "0x1845657B0")]
			internal int PAKKPLJBDCC(HFMKFAPIMAH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x45654F0", Offset = "0x4563CF0", VA = "0x1845654F0")]
			internal TOutput BOGGEBABGGG(HFMKFAPIMAH arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class OCHPGMBDAJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public HFMKFAPIMAH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, CHNMOMELGGC<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<CHNMOMELGGC<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public OCHPGMBDAJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3DFFB10", Offset = "0x3DFE310", VA = "0x183DFFB10")]
			internal (string, TTerm) BCPNPGFNBPE(EDMADECGABL<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class OECJNNOKEED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public HFMKFAPIMAH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public OECJNNOKEED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3E04D50", Offset = "0x3E03550", VA = "0x183E04D50")]
			internal void EALFDGJJHOL(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3E04F90", Offset = "0x3E03790", VA = "0x183E04F90")]
			internal void OBJHMFMPHNG(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3E04510", Offset = "0x3E02D10", VA = "0x183E04510")]
			internal void CELAMNKNLGO(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3E049D0", Offset = "0x3E031D0", VA = "0x183E049D0")]
			internal void CHGJFCFMCCH(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class KIOKDIAKEGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HFMKFAPIMAH arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
			public KIOKDIAKEGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x351C760", Offset = "0x351AF60", VA = "0x18351C760")]
			internal TTerm GHGCDAMEJIG(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3A6BD80", Offset = "0x3A6A580", VA = "0x183A6BD80")]
		private static EPPNNCCDLMB ONNBPBKFNAI([CallerMemberName] string PMDCAPIFBIP = "")
		{
			return default(EPPNNCCDLMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3A5B030", Offset = "0x3A59830", VA = "0x183A5B030")]
		public static Dictionary<TNode, List<EDMADECGABL<TType>>> COICPOANHPD(TRoot PHEKGOFMNOB, TDeps JFHMOFHDJOF, TGraph OLMAEEEFKOE, IEnumerable<TNode> ALECNGGHJAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A61140", Offset = "0x3A5F940", VA = "0x183A61140")]
		private static (Dictionary<TTerm, CHNMOMELGGC<TNode>>, List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>>) MEOPBGNNOIF(IEnumerable<TNode> ALECNGGHJAI, HFMKFAPIMAH AKIAGKECAIA)
		{
			return default((Dictionary<TTerm, CHNMOMELGGC<TNode>>, List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A62830", Offset = "0x3A61030", VA = "0x183A62830")]
		private static void MOHAJHPOBOO(TNode ELOONLEOBIM, Dictionary<TInput, TTerm> HCBMOGNJAOE, Dictionary<TOutput, TTerm> MALDHLFJKMD, Dictionary<TTerm, CHNMOMELGGC<TNode>> PNDMKIIAHNA, Dictionary<CHNMOMELGGC<TNode>, TTerm> FOLOLPFNCLF, List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> CNHBNFOEBKA, Stack<TNode> OGKLJNJMABJ, List<EMPAJECHCOE<TNode>> DDIHNAEABDE, HFMKFAPIMAH AKIAGKECAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B730", Offset = "0x3A69F30", VA = "0x183A6B730")]
		private static Dictionary<string, TTerm> OAPMCCMNDJP(TNode ELOONLEOBIM, Dictionary<TTerm, CHNMOMELGGC<TNode>> PNDMKIIAHNA, Dictionary<CHNMOMELGGC<TNode>, TTerm> PLFADEBMIIG, List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> CNHBNFOEBKA, HFMKFAPIMAH AKIAGKECAIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x239BE00", Offset = "0x239A600", VA = "0x18239BE00")]
		private static (TPort, TTerm)[] NGPOMOLPJHC<TPort>(TNode ELOONLEOBIM, Func<HFMKFAPIMAH, TNode, int> LKGBILBFPLC, Func<HFMKFAPIMAH, TNode, int, TPort> FJJBJMBMEJB, Func<HFMKFAPIMAH, TPort, TType> AMHLFPJKBOM, Dictionary<TPort, TTerm> GPBJFFHFCEA, HFMKFAPIMAH AKIAGKECAIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D5A0", Offset = "0x3A5BDA0", VA = "0x183A5D5A0")]
		private static (TTerm, TTerm) KFJMJJAECKF((TOutput Output, TTerm Id)[] NNIENAGCMCA, List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> CNHBNFOEBKA, Dictionary<string, TTerm> PLFADEBMIIG, Stack<TNode> OGKLJNJMABJ, HFMKFAPIMAH AKIAGKECAIA)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3A67D30", Offset = "0x3A66530", VA = "0x183A67D30")]
		private static void NGMAIHEGCND((TInput PortKey, TTerm Id)[] AENKLOGIEEL, TTerm GAABFGHHDHI, TTerm GNBJADJCFKE, List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> CNHBNFOEBKA, Dictionary<TOutput, TTerm> MALDHLFJKMD, Dictionary<string, TTerm> PLFADEBMIIG, Stack<TNode> OGKLJNJMABJ, HFMKFAPIMAH AKIAGKECAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3A6AD20", Offset = "0x3A69520", VA = "0x183A6AD20")]
		private static TTerm NNBCENJAIHB(TInput LLJFBBILFIJ, List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> CNHBNFOEBKA, Dictionary<TOutput, TTerm> MALDHLFJKMD, Stack<TNode> OGKLJNJMABJ, HFMKFAPIMAH AKIAGKECAIA)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A200", Offset = "0x3A68A00", VA = "0x183A6A200")]
		private static TTerm NHFHFEFNFJB([In] TType HJNJPNKDEFH, IOKind JKOEFMMPGHK, List<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> CNHBNFOEBKA, IReadOnlyDictionary<string, TTerm> PLFADEBMIIG, HFMKFAPIMAH AKIAGKECAIA)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A571B0", Offset = "0x3A559B0", VA = "0x183A571B0")]
		private static Dictionary<TNode, List<EDMADECGABL<TType>>> ADPEHEHHJBO(TOutputSubstitution[] GAJCCAJGJOP, Dictionary<TTerm, CHNMOMELGGC<TNode>> PNDMKIIAHNA, IEnumerable<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> CNHBNFOEBKA, HFMKFAPIMAH AKIAGKECAIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3A5CCC0", Offset = "0x3A5B4C0", VA = "0x183A5CCC0")]
		private static Dictionary<TNode, List<EDMADECGABL<TType>>> FJKPPKAIAKJ(Dictionary<TTerm, CHNMOMELGGC<TNode>> PNDMKIIAHNA, HFMKFAPIMAH AKIAGKECAIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3A59990", Offset = "0x3A58190", VA = "0x183A59990")]
		private static void AEKPNOMLBNE([In] TNode ELOONLEOBIM, Stack<TNode> OGKLJNJMABJ, List<EMPAJECHCOE<TNode>> DDIHNAEABDE, HFMKFAPIMAH AKIAGKECAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A210", Offset = "0x3A58A10", VA = "0x183A5A210")]
		private static void CLPAABCJKNB(Dictionary<CHNMOMELGGC<TNode>, TTerm> PLFADEBMIIG, List<EMPAJECHCOE<TNode>> DDIHNAEABDE, HFMKFAPIMAH AKIAGKECAIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3A66E40", Offset = "0x3A65640", VA = "0x183A66E40")]
		private static Dictionary<TTerm, TType> NGGHEBEAKNF(Dictionary<TTerm, TOutputSubstitution> GAJCCAJGJOP, IEnumerable<KeyValuePair<TTerm, ADJNNPBFDMM<TType>>> CNHBNFOEBKA, HFMKFAPIMAH AKIAGKECAIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3A64880", Offset = "0x3A63080", VA = "0x183A64880")]
		private static JLEEOCGECPK<TType> NCDGMLEFHHE(TOutputTerm HJNJPNKDEFH, Dictionary<TTerm, TType> CNHBNFOEBKA, Dictionary<TTerm, TType> KPAIMHKKLCO, HFMKFAPIMAH AKIAGKECAIA)
		{
			return default(JLEEOCGECPK<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3A5C6D0", Offset = "0x3A5AED0", VA = "0x183A5C6D0")]
		private static TOutputTerm DKHEANCCFNE(TOutputTerm LEPGBJBPGDP, HFMKFAPIMAH AKIAGKECAIA)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2379C00", Offset = "0x2378400", VA = "0x182379C00")]
	public static Dictionary<TNode, List<EDMADECGABL<TType>>> COICPOANHPD<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::LJCELOLIEFO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> PIEBBHMNEOG, TRoot PHEKGOFMNOB, TGraph OLMAEEEFKOE, IEnumerable<TNode> ALECNGGHJAI) where TDeps : global::HHJDEABFHAE<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EDMADECGABL<TType> : IEquatable<EDMADECGABL<TType>>, AIENODJKFOP<EDMADECGABL<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string JOBPEPKBADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType BCCCKJEPFAD;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x30FA2B0", Offset = "0x30F8AB0", VA = "0x1830FA2B0")]
	internal EDMADECGABL(string PMDCAPIFBIP, [In] TType MLHLKNAMIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x30FA1A0", Offset = "0x30F89A0", VA = "0x1830FA1A0")]
	public bool PCNBHFDPOMC([In] EDMADECGABL<TType> FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x30FA100", Offset = "0x30F8900", VA = "0x1830FA100", Slot = "4")]
	public bool Equals(EDMADECGABL<TType> FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30FA080", Offset = "0x30F8880", VA = "0x1830FA080", Slot = "0")]
	public override bool Equals(object FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BFB0", Offset = "0x1D0A7B0", VA = "0x181D0BFB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x30FA270", Offset = "0x30F8A70", VA = "0x1830FA270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x30FA150", Offset = "0x30F8950", VA = "0x1830FA150", Slot = "5")]
	private bool KLLDGNOABME([In] EDMADECGABL<TType> FPJCFKAMJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class POMMDGEBEJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x265B260", Offset = "0x2659A60", VA = "0x18265B260")]
	public static EDMADECGABL<TType> AKKFLOCCMNP<TType>(string PMDCAPIFBIP, TType MLHLKNAMIGM)
	{
		return default(EDMADECGABL<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x265B290", Offset = "0x2659A90", VA = "0x18265B290")]
	public static (string, TType) NCMOAMEHFEG<TType>([In] this EDMADECGABL<TType> PIEBBHMNEOG)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct CHNMOMELGGC<TNode> : IEquatable<CHNMOMELGGC<TNode>>, AIENODJKFOP<CHNMOMELGGC<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode JIGPGHGODMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string JOBPEPKBADK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xB58170", Offset = "0xB56970", VA = "0x180B58170")]
	internal CHNMOMELGGC(TNode ELOONLEOBIM, string PMDCAPIFBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x49CF550", Offset = "0x49CDD50", VA = "0x1849CF550")]
	public bool PCNBHFDPOMC([In] CHNMOMELGGC<TNode> FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x49CF3F0", Offset = "0x49CDBF0", VA = "0x1849CF3F0", Slot = "4")]
	public bool Equals(CHNMOMELGGC<TNode> FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x30FA080", Offset = "0x30F8880", VA = "0x1830FA080", Slot = "0")]
	public override bool Equals(object FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x49CF440", Offset = "0x49CDC40", VA = "0x1849CF440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x49CF6F0", Offset = "0x49CDEF0", VA = "0x1849CF6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x49CF500", Offset = "0x49CDD00", VA = "0x1849CF500", Slot = "5")]
	private bool ICDCGIKKAJN([In] CHNMOMELGGC<TNode> FPJCFKAMJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IHIIKOGIPBI
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x25055C0", Offset = "0x2503DC0", VA = "0x1825055C0")]
	public static CHNMOMELGGC<TNode> AKKFLOCCMNP<TNode>(TNode ELOONLEOBIM, string PMDCAPIFBIP)
	{
		return default(CHNMOMELGGC<TNode>);
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
