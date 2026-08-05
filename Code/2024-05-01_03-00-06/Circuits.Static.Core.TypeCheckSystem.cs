using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct PMFNEJIOACE<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType LNPLBOHLOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind HGOCFPCHHPJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x18EBE50", Offset = "0x18EAC50", VA = "0x1818EBE50")]
	internal PMFNEJIOACE(TType DDEINLAGLLL, IOKind NLHFKFJCCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x41E0450", Offset = "0x41DF250", VA = "0x1841E0450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CHOGIEFOBPM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2716BC0", Offset = "0x27159C0", VA = "0x182716BC0")]
	public static PMFNEJIOACE<TType> KHDJPNLCMFA<TType>(TType DDEINLAGLLL, IOKind NLHFKFJCCLJ)
	{
		return default(PMFNEJIOACE<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2716B80", Offset = "0x2715980", VA = "0x182716B80")]
	public static (TType, IOKind) CMHIBDGAPJC<TType>([In] this PMFNEJIOACE<TType> ILACEKALGJH)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2716BF0", Offset = "0x27159F0", VA = "0x182716BF0")]
	public static void PHDHBCEACMN<TType>([In] this PMFNEJIOACE<TType> ILACEKALGJH, [Out] TType DDEINLAGLLL, [Out] IOKind NLHFKFJCCLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KBEKALDKLAE<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ANAPBEGFGLP<TNode> OCGCLFAKHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ANAPBEGFGLP<TNode> GIMMDKFEAGD;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA8B0", Offset = "0x3CD96B0", VA = "0x183CDA8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LCNOJICHMDE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x295BC60", Offset = "0x295AA60", VA = "0x18295BC60")]
	public static (ANAPBEGFGLP<TNode>, ANAPBEGFGLP<TNode>) CMHIBDGAPJC<TNode>([In] this KBEKALDKLAE<TNode> ILACEKALGJH)
	{
		return default((ANAPBEGFGLP<TNode>, ANAPBEGFGLP<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x295BD00", Offset = "0x295AB00", VA = "0x18295BD00")]
	public static void PHDHBCEACMN<TNode>([In] this KBEKALDKLAE<TNode> ILACEKALGJH, [Out] ANAPBEGFGLP<TNode> DCJCHFKPCOP, [Out] ANAPBEGFGLP<TNode> IKGIOHGPKCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CKGIKHEHKAI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NANBOFKENDO NJBKPNOKCPP(TRoot GDOPFEEANMP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType ECMICCKKHJH(TRoot GDOPFEEANMP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PMFNEJIOACE<TType> LBCLCCCFACO(TRoot GDOPFEEANMP, [In] PMFNEJIOACE<TType> MAEINFGKCEL, [In] PMFNEJIOACE<TType> FLBFHNBPNFN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OILEDMMNKDG(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TNode FMEAKEGGFNK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int FDFCNCCFJPP(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TNode FMEAKEGGFNK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput NALNFJFNPHD(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TNode FMEAKEGGFNK, int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JKIPCHGKOPG(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TNode FMEAKEGGFNK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput FDFCHDBOAFB(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TNode FMEAKEGGFNK, int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<KIGEDCLOOEM<TType>> DDPKBNGNPME(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TNode FMEAKEGGFNK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KBEKALDKLAE<TNode>> CCNFMBKMKAA(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TNode FMEAKEGGFNK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType EDMIDCIFCLD(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TInput PGOKJJEIBMC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int OPGDPLFFIKC(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TInput PGOKJJEIBMC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput GBPCHOKLOME(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TInput PGOKJJEIBMC, int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode NHNECFGBCDJ(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TInput PGOKJJEIBMC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType NMPCMFMBCLH(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TOutput FCKEONCPHOM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int ICHIDLLGCIF(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TOutput FCKEONCPHOM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput DFADEPPLJIJ(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TOutput FCKEONCPHOM, int AELAKOMEEDP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode LCBDFCHOCAI(TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, TOutput FCKEONCPHOM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PLEMGOHCCMG(TRoot GDOPFEEANMP, TType DDEINLAGLLL);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType GHAKCKCFJNN(TRoot GDOPFEEANMP, TType DDEINLAGLLL, IEnumerable<TType> KFLPBCJOBAG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JFLDPBFLNMJ(TRoot GDOPFEEANMP, TType DDEINLAGLLL, Action<TType> NGKFJHJDMFB, Action<TType> BGJEELLHELN, Action<TType> KHAJBLDKMLG, Action<TType> MLBMOKPIIHA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType CLBADNMFJHA(TRoot GDOPFEEANMP, TType DDEINLAGLLL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string BLFFLKPEJEB(TRoot GDOPFEEANMP, TType DDEINLAGLLL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification CHCPFFAPLJD(TRoot GDOPFEEANMP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	PJPNKGNAEHO<TOutputSubstitution[], PCJEOFJNKHC> PCMFHAOICLP(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm HCJHPKKLAJC(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm ACNCFOFJODD(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TTerm LOOFNDDLBIF);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm JLCODOEOADG(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TTerm FEAFHENKEAJ, TTerm CALLEFILHJM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AEAAKMOCGED(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TTerm MAEINFGKCEL, TTerm FLBFHNBPNFN);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool PIMINCDAOPG(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TOutputTerm IFILACEECOP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool GABEBFBCACD(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TOutputTerm IFILACEECOP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm BNFMDFBAKOG(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TOutputTerm IFILACEECOP);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm NIPJBOCNMOO(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TOutputTerm IFILACEECOP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm JNAPBEBLGIN(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TOutputTerm IFILACEECOP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm NJKMDADMICA(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TOutputSubstitution FNJHHEHFKLD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm CKHLDCDKOMP(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TOutputSubstitution FNJHHEHFKLD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm MJJBLMEBDFM(TRoot GDOPFEEANMP, TUnification GPEIIEKEGHA, TTerm LOOFNDDLBIF);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LENGLAPODHP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CKGIKHEHKAI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240")]
	public static global::LENGLAPODHP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> KHDJPNLCMFA()
	{
		return default(global::LENGLAPODHP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IJDEECIALOC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class FPLFLFBGCEB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CKGIKHEHKAI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class NEBFIOOLLCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot OLBMHECMJBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps IGLACPGNCPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification NGLEALCDBEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph CFMOGLHOOEA;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public NANBOFKENDO AMDCJMEMGAD
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4017870", Offset = "0x4016670", VA = "0x184017870")]
				get
				{
					return default(NANBOFKENDO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4018F40", Offset = "0x4017D40", VA = "0x184018F40")]
			private NEBFIOOLLCO(TRoot GDOPFEEANMP, TDeps GLJEJHKFIBB, TUnification IABCANOLMEM, TGraph ICEEKEMAGHB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4018140", Offset = "0x4016F40", VA = "0x184018140")]
			public static NEBFIOOLLCO KHDJPNLCMFA(TRoot GDOPFEEANMP, TDeps GLJEJHKFIBB, TUnification IABCANOLMEM, TGraph ICEEKEMAGHB)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4017020", Offset = "0x4015E20", VA = "0x184017020")]
			public TType ECMICCKKHJH()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4018230", Offset = "0x4017030", VA = "0x184018230")]
			public PMFNEJIOACE<TType> LBCLCCCFACO(PMFNEJIOACE<TType> MAEINFGKCEL, PMFNEJIOACE<TType> FLBFHNBPNFN)
			{
				return default(PMFNEJIOACE<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4018C70", Offset = "0x4017A70", VA = "0x184018C70")]
			public int OILEDMMNKDG(TNode FMEAKEGGFNK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x40173F0", Offset = "0x40161F0", VA = "0x1840173F0")]
			public int FDFCNCCFJPP(TNode FMEAKEGGFNK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4018600", Offset = "0x4017400", VA = "0x184018600")]
			public TInput NALNFJFNPHD(TNode FMEAKEGGFNK, int AELAKOMEEDP)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4017B00", Offset = "0x4016900", VA = "0x184017B00")]
			public int JKIPCHGKOPG(TNode FMEAKEGGFNK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4017250", Offset = "0x4016050", VA = "0x184017250")]
			public TOutput FDFCHDBOAFB(TNode FMEAKEGGFNK, int AELAKOMEEDP)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4016D70", Offset = "0x4015B70", VA = "0x184016D70")]
			public IEnumerable<KIGEDCLOOEM<TType>> DDPKBNGNPME(TNode FMEAKEGGFNK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4016A80", Offset = "0x4015880", VA = "0x184016A80")]
			public IEnumerable<KBEKALDKLAE<TNode>> CCNFMBKMKAA([In] TNode FMEAKEGGFNK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x40171B0", Offset = "0x4015FB0", VA = "0x1840171B0")]
			public TType EDMIDCIFCLD(TInput PGOKJJEIBMC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4018BF0", Offset = "0x40179F0", VA = "0x184018BF0")]
			public int OCMGLODCAEG(TInput PGOKJJEIBMC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4017640", Offset = "0x4016440", VA = "0x184017640")]
			public TOutput GBPCHOKLOME(TInput PGOKJJEIBMC, int AELAKOMEEDP)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4018740", Offset = "0x4017540", VA = "0x184018740")]
			public TNode NHNECFGBCDJ(TInput PGOKJJEIBMC)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4018AE0", Offset = "0x40178E0", VA = "0x184018AE0")]
			public TType NMPCMFMBCLH(TOutput FCKEONCPHOM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4016FE0", Offset = "0x4015DE0", VA = "0x184016FE0")]
			public int DJFDBACECKI(TOutput FCKEONCPHOM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4016DB0", Offset = "0x4015BB0", VA = "0x184016DB0")]
			public TInput DFADEPPLJIJ(TOutput FCKEONCPHOM, int AELAKOMEEDP)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4018440", Offset = "0x4017240", VA = "0x184018440")]
			public TNode LCBDFCHOCAI(TOutput FCKEONCPHOM)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4018E30", Offset = "0x4017C30", VA = "0x184018E30")]
			public bool PLEMGOHCCMG(TType DDEINLAGLLL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4017690", Offset = "0x4016490", VA = "0x184017690")]
			public TType GHAKCKCFJNN(TType DDEINLAGLLL, IEnumerable<TType> KFLPBCJOBAG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4017A60", Offset = "0x4016860", VA = "0x184017A60")]
			public void JFLDPBFLNMJ(TType DDEINLAGLLL, Action<TType> NGKFJHJDMFB, Action<TType> BGJEELLHELN, Action<TType> KHAJBLDKMLG, Action<TType> MLBMOKPIIHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4016C30", Offset = "0x4015A30", VA = "0x184016C30")]
			public TType CLBADNMFJHA(TType DDEINLAGLLL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x40168B0", Offset = "0x40156B0", VA = "0x1840168B0")]
			public string BLFFLKPEJEB(TType DDEINLAGLLL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x40177C0", Offset = "0x40165C0", VA = "0x1840177C0")]
			public TTerm HCJHPKKLAJC()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4016640", Offset = "0x4015440", VA = "0x184016640")]
			public TTerm ACNCFOFJODD(TTerm LOOFNDDLBIF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4017CC0", Offset = "0x4016AC0", VA = "0x184017CC0")]
			public TTerm JLCODOEOADG(TTerm FEAFHENKEAJ, TTerm CALLEFILHJM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4016870", Offset = "0x4015670", VA = "0x184016870")]
			public void AEAAKMOCGED(TTerm MAEINFGKCEL, TTerm FLBFHNBPNFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x40174F0", Offset = "0x40162F0", VA = "0x1840174F0")]
			public bool GABEBFBCACD(TOutputTerm LOOFNDDLBIF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4018DB0", Offset = "0x4017BB0", VA = "0x184018DB0")]
			public bool PIMINCDAOPG(TOutputTerm LOOFNDDLBIF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4017EE0", Offset = "0x4016CE0", VA = "0x184017EE0")]
			public TTerm JOJBEMAEIBF(TOutputTerm IFILACEECOP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x40188D0", Offset = "0x40176D0", VA = "0x1840188D0")]
			public TOutputTerm NIPJBOCNMOO(TOutputTerm LOOFNDDLBIF)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4017D60", Offset = "0x4016B60", VA = "0x184017D60")]
			public TOutputTerm JNAPBEBLGIN(TOutputTerm LOOFNDDLBIF)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4018950", Offset = "0x4017750", VA = "0x184018950")]
			public TTerm NJKMDADMICA(TOutputSubstitution BHEJPLGMAKD)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4016B00", Offset = "0x4015900", VA = "0x184016B00")]
			public TOutputTerm CKHLDCDKOMP(TOutputSubstitution BHEJPLGMAKD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4018500", Offset = "0x4017300", VA = "0x184018500")]
			public TOutputTerm MJJBLMEBDFM(TTerm LOOFNDDLBIF)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class NAKELBEPLLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NEBFIOOLLCO arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public NAKELBEPLLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2140", Offset = "0x3FF0F40", VA = "0x183FF2140")]
			internal int NLJGCDLMBBI(NEBFIOOLLCO arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3FF21E0", Offset = "0x3FF0FE0", VA = "0x183FF21E0")]
			internal TInput NNNMGFKIKAB(NEBFIOOLLCO arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2080", Offset = "0x3FF0E80", VA = "0x183FF2080")]
			internal int DOJGMACCMOK(NEBFIOOLLCO arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2300", Offset = "0x3FF1100", VA = "0x183FF2300")]
			internal TOutput ODMBGGMAODC(NEBFIOOLLCO arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BOKLJFLDKEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public NEBFIOOLLCO arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, ANAPBEGFGLP<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<ANAPBEGFGLP<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public BOKLJFLDKEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x488BB40", Offset = "0x488A940", VA = "0x18488BB40")]
			internal (string, TTerm) PKGJGAFIJCG(KIGEDCLOOEM<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class EAEOJDFKNKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public NEBFIOOLLCO arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public EAEOJDFKNKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x346FC80", Offset = "0x346EA80", VA = "0x18346FC80")]
			internal void FBNIABNLBGO(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x346F8E0", Offset = "0x346E6E0", VA = "0x18346F8E0")]
			internal void EHKMADOGMAG(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3470240", Offset = "0x346F040", VA = "0x183470240")]
			internal void GFHJKHOPKNB(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x34703E0", Offset = "0x346F1E0", VA = "0x1834703E0")]
			internal void HPFJAGGPKKE(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LBHGCPGEDFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public NEBFIOOLLCO arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public LBHGCPGEDFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3852B80", Offset = "0x3851980", VA = "0x183852B80")]
			internal TTerm HDNAGLDJIAJ(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3874E00", Offset = "0x3873C00", VA = "0x183874E00")]
		private static HPEKHJNCCIK HAJPGCMFIGA([CallerMemberName] string PHEKPMAPPHM = "")
		{
			return default(HPEKHJNCCIK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x386C6D0", Offset = "0x386B4D0", VA = "0x18386C6D0")]
		public static Dictionary<TNode, List<KIGEDCLOOEM<TType>>> BDFNFLJIJOJ(TRoot GDOPFEEANMP, TDeps GLJEJHKFIBB, TGraph ICEEKEMAGHB, IEnumerable<TNode> LPEJJNHCFKJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3871170", Offset = "0x386FF70", VA = "0x183871170")]
		private static (Dictionary<TTerm, ANAPBEGFGLP<TNode>>, List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>>) FKFIMGNFIIB(IEnumerable<TNode> LPEJJNHCFKJ, NEBFIOOLLCO PNJHNPALLNI)
		{
			return default((Dictionary<TTerm, ANAPBEGFGLP<TNode>>, List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3874E80", Offset = "0x3873C80", VA = "0x183874E80")]
		private static void HFMAMMBIEMM(TNode FMEAKEGGFNK, Dictionary<TInput, TTerm> FLBBKNBKEND, Dictionary<TOutput, TTerm> HKFIBDFLGKH, Dictionary<TTerm, ANAPBEGFGLP<TNode>> JPOIEAMDHJE, Dictionary<ANAPBEGFGLP<TNode>, TTerm> HJJFKLNCAGB, List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> JLLGCELPPOM, Stack<TNode> PNMJKNBJDOD, List<KBEKALDKLAE<TNode>> OEFHLEFBMDL, NEBFIOOLLCO PNJHNPALLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x386F770", Offset = "0x386E570", VA = "0x18386F770")]
		private static Dictionary<string, TTerm> FHDLDPOKJPJ(TNode FMEAKEGGFNK, Dictionary<TTerm, ANAPBEGFGLP<TNode>> JPOIEAMDHJE, Dictionary<ANAPBEGFGLP<TNode>, TTerm> AMFBBKCKGMD, List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> JLLGCELPPOM, NEBFIOOLLCO PNJHNPALLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x27CDDB0", Offset = "0x27CCBB0", VA = "0x1827CDDB0")]
		private static (TPort, TTerm)[] IDBIOJNHLAO<TPort>(TNode FMEAKEGGFNK, Func<NEBFIOOLLCO, TNode, int> JKKGJMEGKDM, Func<NEBFIOOLLCO, TNode, int, TPort> MAMEEHODNOP, Func<NEBFIOOLLCO, TPort, TType> MCFAMJOLOHF, Dictionary<TPort, TTerm> IKMCCPBNGPI, NEBFIOOLLCO PNJHNPALLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x386B5D0", Offset = "0x386A3D0", VA = "0x18386B5D0")]
		private static (TTerm, TTerm) AKNLMMNKIML((TOutput Output, TTerm Id)[] NPHPIACACPB, List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> JLLGCELPPOM, Dictionary<string, TTerm> AMFBBKCKGMD, Stack<TNode> PNMJKNBJDOD, NEBFIOOLLCO PNJHNPALLNI)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3877CD0", Offset = "0x3876AD0", VA = "0x183877CD0")]
		private static void IFEAIKPEHDP((TInput PortKey, TTerm Id)[] KNFKKLBMLEP, TTerm DKECCAKJPPL, TTerm BFOMNECFFNM, List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> JLLGCELPPOM, Dictionary<TOutput, TTerm> HKFIBDFLGKH, Dictionary<string, TTerm> AMFBBKCKGMD, Stack<TNode> PNMJKNBJDOD, NEBFIOOLLCO PNJHNPALLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x38793F0", Offset = "0x38781F0", VA = "0x1838793F0")]
		private static TTerm JBACPEAIFOL(TInput PGOKJJEIBMC, List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> JLLGCELPPOM, Dictionary<TOutput, TTerm> HKFIBDFLGKH, Stack<TNode> PNMJKNBJDOD, NEBFIOOLLCO PNJHNPALLNI)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x386E160", Offset = "0x386CF60", VA = "0x18386E160")]
		private static TTerm BLBBBLOLFFL([In] TType DDEINLAGLLL, IOKind NLHFKFJCCLJ, List<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> JLLGCELPPOM, IReadOnlyDictionary<string, TTerm> AMFBBKCKGMD, NEBFIOOLLCO PNJHNPALLNI)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3873C70", Offset = "0x3872A70", VA = "0x183873C70")]
		private static Dictionary<TNode, List<KIGEDCLOOEM<TType>>> FMIANEBAFPH(TOutputSubstitution[] HCKBPCEGGHC, Dictionary<TTerm, ANAPBEGFGLP<TNode>> JPOIEAMDHJE, IEnumerable<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> JLLGCELPPOM, NEBFIOOLLCO PNJHNPALLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x386FA50", Offset = "0x386E850", VA = "0x18386FA50")]
		private static Dictionary<TNode, List<KIGEDCLOOEM<TType>>> FIMCIFHJBDM(Dictionary<TTerm, ANAPBEGFGLP<TNode>> JPOIEAMDHJE, NEBFIOOLLCO PNJHNPALLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x387AA90", Offset = "0x3879890", VA = "0x18387AA90")]
		private static void LONDLOMPKKB([In] TNode FMEAKEGGFNK, Stack<TNode> PNMJKNBJDOD, List<KBEKALDKLAE<TNode>> OEFHLEFBMDL, NEBFIOOLLCO PNJHNPALLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x386EFF0", Offset = "0x386DDF0", VA = "0x18386EFF0")]
		private static void DEBAIJFLBDD(Dictionary<ANAPBEGFGLP<TNode>, TTerm> AMFBBKCKGMD, List<KBEKALDKLAE<TNode>> OEFHLEFBMDL, NEBFIOOLLCO PNJHNPALLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x38681A0", Offset = "0x3866FA0", VA = "0x1838681A0")]
		private static Dictionary<TTerm, TType> AAKLLMCCLCP(Dictionary<TTerm, TOutputSubstitution> HCKBPCEGGHC, IEnumerable<KeyValuePair<TTerm, PMFNEJIOACE<TType>>> JLLGCELPPOM, NEBFIOOLLCO PNJHNPALLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x386D290", Offset = "0x386C090", VA = "0x18386D290")]
		private static BOEJMFJFKMA<TType> BKFCCLKMMAI(TOutputTerm DDEINLAGLLL, Dictionary<TTerm, TType> JLLGCELPPOM, Dictionary<TTerm, TType> GHOBDPKIBDO, NEBFIOOLLCO PNJHNPALLNI)
		{
			return default(BOEJMFJFKMA<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x38747C0", Offset = "0x38735C0", VA = "0x1838747C0")]
		private static TOutputTerm GKLLMPHIPLI(TOutputTerm PNJKIBJNBGO, NEBFIOOLLCO PNJHNPALLNI)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2902720", Offset = "0x2901520", VA = "0x182902720")]
	public static Dictionary<TNode, List<KIGEDCLOOEM<TType>>> BDFNFLJIJOJ<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::LENGLAPODHP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> ILACEKALGJH, TRoot GDOPFEEANMP, TGraph ICEEKEMAGHB, IEnumerable<TNode> LPEJJNHCFKJ) where TDeps : global::CKGIKHEHKAI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KIGEDCLOOEM<TType> : IEquatable<KIGEDCLOOEM<TType>>, OBICLNGMMNH<KIGEDCLOOEM<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HFBLFDGJOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType PJKGBDBFBOE;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C210", Offset = "0x3D0B010", VA = "0x183D0C210")]
	internal KIGEDCLOOEM(string PHEKPMAPPHM, [In] TType JIBPAMOOBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C100", Offset = "0x3D0AF00", VA = "0x183D0C100")]
	public bool HGMAFNDJCNK([In] KIGEDCLOOEM<TType> GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C0B0", Offset = "0x3D0AEB0", VA = "0x183D0C0B0", Slot = "4")]
	public bool Equals(KIGEDCLOOEM<TType> GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x391DF10", Offset = "0x391CD10", VA = "0x18391DF10", Slot = "0")]
	public override bool Equals(object GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E83880", Offset = "0x1E82680", VA = "0x181E83880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C1D0", Offset = "0x3D0AFD0", VA = "0x183D0C1D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C060", Offset = "0x3D0AE60", VA = "0x183D0C060", Slot = "5")]
	private bool BOOCAMDHAOH([In] KIGEDCLOOEM<TType> GGINNHLAMLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DMJHOEAOJOO
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2759070", Offset = "0x2757E70", VA = "0x182759070")]
	public static KIGEDCLOOEM<TType> KHDJPNLCMFA<TType>(string PHEKPMAPPHM, TType JIBPAMOOBIB)
	{
		return default(KIGEDCLOOEM<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2759030", Offset = "0x2757E30", VA = "0x182759030")]
	public static (string, TType) CMHIBDGAPJC<TType>([In] this KIGEDCLOOEM<TType> ILACEKALGJH)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct ANAPBEGFGLP<TNode> : IEquatable<ANAPBEGFGLP<TNode>>, OBICLNGMMNH<ANAPBEGFGLP<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode MAFOFLEABBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string HFBLFDGJOMA;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xC2B5C0", Offset = "0xC2A3C0", VA = "0x180C2B5C0")]
	internal ANAPBEGFGLP(TNode FMEAKEGGFNK, string PHEKPMAPPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x391E170", Offset = "0x391CF70", VA = "0x18391E170")]
	public bool HGMAFNDJCNK([In] ANAPBEGFGLP<TNode> GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x391DF90", Offset = "0x391CD90", VA = "0x18391DF90", Slot = "4")]
	public bool Equals(ANAPBEGFGLP<TNode> GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x391DF10", Offset = "0x391CD10", VA = "0x18391DF10", Slot = "0")]
	public override bool Equals(object GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x391E030", Offset = "0x391CE30", VA = "0x18391E030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x391E240", Offset = "0x391D040", VA = "0x18391E240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x391DEC0", Offset = "0x391CCC0", VA = "0x18391DEC0", Slot = "5")]
	private bool DKHOJNJJJKH([In] ANAPBEGFGLP<TNode> GGINNHLAMLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class PELBLDIPENI
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2A4FBE0", Offset = "0x2A4E9E0", VA = "0x182A4FBE0")]
	public static ANAPBEGFGLP<TNode> KHDJPNLCMFA<TNode>(TNode FMEAKEGGFNK, string PHEKPMAPPHM)
	{
		return default(ANAPBEGFGLP<TNode>);
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
