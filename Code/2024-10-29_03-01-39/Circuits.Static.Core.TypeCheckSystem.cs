using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct MMEAKJLNKAE<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType BFKMCKBKOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind ABKNEJDNGME;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9D4FE0", Offset = "0x9D3FE0", VA = "0x1809D4FE0")]
	internal MMEAKJLNKAE(TType PFCMGBLCCPJ, IOKind FEHCHLOCDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4964CA0", Offset = "0x4963CA0", VA = "0x184964CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HJMBALDOMOO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2F95000", Offset = "0x2F94000", VA = "0x182F95000")]
	public static MMEAKJLNKAE<TType> EJLELCHFLID<TType>(TType PFCMGBLCCPJ, IOKind FEHCHLOCDBK)
	{
		return default(MMEAKJLNKAE<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2F950A0", Offset = "0x2F940A0", VA = "0x182F950A0")]
	public static (TType, IOKind) IFNFNNMKCGN<TType>([In] this MMEAKJLNKAE<TType> GFJPFDOHONG)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2F95030", Offset = "0x2F94030", VA = "0x182F95030")]
	public static void GIFBHPBPLDG<TType>([In] this MMEAKJLNKAE<TType> GFJPFDOHONG, [Out] TType PFCMGBLCCPJ, [Out] IOKind FEHCHLOCDBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KCOAEHKJAJO<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ELHBEBDBPEG<TNode> MHAAOIENNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly ELHBEBDBPEG<TNode> PEAOGGMCCJL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4669A50", Offset = "0x4668A50", VA = "0x184669A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GKOFKOBMHED
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2F87380", Offset = "0x2F86380", VA = "0x182F87380")]
	public static (ELHBEBDBPEG<TNode>, ELHBEBDBPEG<TNode>) IFNFNNMKCGN<TNode>([In] this KCOAEHKJAJO<TNode> GFJPFDOHONG)
	{
		return default((ELHBEBDBPEG<TNode>, ELHBEBDBPEG<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2F87280", Offset = "0x2F86280", VA = "0x182F87280")]
	public static void GIFBHPBPLDG<TNode>([In] this KCOAEHKJAJO<TNode> GFJPFDOHONG, [Out] ELHBEBDBPEG<TNode> GGEOEEJGPGH, [Out] ELHBEBDBPEG<TNode> OLIPOMNIFIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CGIJGDOGLOG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	COKBDJJJNNK ECDAOELJOFD(TRoot BAOAKGNNKEP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType MHCNGFBNNFI(TRoot BAOAKGNNKEP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMEAKJLNKAE<TType> MOOPBDOLOLH(TRoot BAOAKGNNKEP, [In] MMEAKJLNKAE<TType> LOPBCKBMJBH, [In] MMEAKJLNKAE<TType> BMJGCJANGHI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BJIMKIFFECE(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TNode CHMIAHGMJKI);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CJIPCMKAHEH(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TNode CHMIAHGMJKI);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput IFIPBKOHHJJ(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TNode CHMIAHGMJKI, int KHAIDMGPIED);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HDAEFDHMLEB(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TNode CHMIAHGMJKI);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput HIEGHHLCMNP(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TNode CHMIAHGMJKI, int KHAIDMGPIED);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<HDOHDIFNMPC<TType>> MPALHKBOMFM(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TNode CHMIAHGMJKI);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KCOAEHKJAJO<TNode>> MNGOLFJAFND(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TNode CHMIAHGMJKI);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType IPEGMDEOOMN(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TInput EDAMLOGMMEK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int MNEFMONBGLC(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TInput EDAMLOGMMEK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput EBPBNJDKNHF(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TInput EDAMLOGMMEK, int KHAIDMGPIED);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode FINLCNIMHMN(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TInput EDAMLOGMMEK);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType FMBKONCKHLK(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TOutput KLPHLLIDBFC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int IDAKCDILOGN(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TOutput KLPHLLIDBFC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput AJOKPANDLDF(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TOutput KLPHLLIDBFC, int KHAIDMGPIED);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode GMHGFCHFBCG(TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, TOutput KLPHLLIDBFC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool AEPLMDFGEDC(TRoot BAOAKGNNKEP, TType PFCMGBLCCPJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType EDJDALFLECK(TRoot BAOAKGNNKEP, TType PFCMGBLCCPJ, IEnumerable<TType> BJMCECIEHPO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IKPOHLFMOME(TRoot BAOAKGNNKEP, TType PFCMGBLCCPJ, Action<TType> INLFODNJNJA, Action<TType> PGKBBFPCHKO, Action<TType> PECDHNACAJJ, Action<TType> MJKJPBEADEO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType EMOCADJCAIP(TRoot BAOAKGNNKEP, TType PFCMGBLCCPJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string LMOPBAAOFAO(TRoot BAOAKGNNKEP, TType PFCMGBLCCPJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification GCMMGPKBLLJ(TRoot BAOAKGNNKEP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	OBFFLKDLIBJ<TOutputSubstitution[], PPOILIOPEKP> BDNPBLHIDPO(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm EGKPCMIOFHL(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm HKEOAIPIEMM(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TTerm CNJGADMIMIH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm LNKOCMONCIC(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TTerm MMONLHEIBPH, TTerm FAEAEBGGAII);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MEANLGONDFG(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TTerm LOPBCKBMJBH, TTerm BMJGCJANGHI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool GBFNGFGAJID(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TOutputTerm NODMMMJGKDJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool LPPPIMMGKBE(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TOutputTerm NODMMMJGKDJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm OHIHKJJDJFA(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TOutputTerm NODMMMJGKDJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm GHDAGKBNGAP(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TOutputTerm NODMMMJGKDJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm BFHFDJMBBMM(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TOutputTerm NODMMMJGKDJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm MHOOKDAFPMO(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TOutputSubstitution EDMELMMNFNL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm DDFCADFBKJN(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TOutputSubstitution EDMELMMNFNL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm HFONLANCLJG(TRoot BAOAKGNNKEP, TUnification NGABIOFELIG, TTerm CNJGADMIMIH);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ADFMBEBABEI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CGIJGDOGLOG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8FEB40", Offset = "0x8FDB40", VA = "0x1808FEB40")]
	public static global::ADFMBEBABEI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> EJLELCHFLID()
	{
		return default(global::ADFMBEBABEI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DHMGIKIGCDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class DAFBPDCLOEO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CGIJGDOGLOG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class FPMKIBELEJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot ALCFFKKOPEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps FKIJPKLLNPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification JMJHACHMIOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph JAMHABDFNPF;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public COKBDJJJNNK JLBLLOBGHFJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4023620", Offset = "0x4022620", VA = "0x184023620")]
				get
				{
					return default(COKBDJJJNNK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x40237E0", Offset = "0x40227E0", VA = "0x1840237E0")]
			private FPMKIBELEJF(TRoot BAOAKGNNKEP, TDeps IKBDGBPPCAB, TUnification DIMFHAGCPFI, TGraph ABNOEFGAADG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4021850", Offset = "0x4020850", VA = "0x184021850")]
			public static FPMKIBELEJF EJLELCHFLID(TRoot BAOAKGNNKEP, TDeps IKBDGBPPCAB, TUnification DIMFHAGCPFI, TGraph ABNOEFGAADG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4023140", Offset = "0x4022140", VA = "0x184023140")]
			public TType MHCNGFBNNFI()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4023350", Offset = "0x4022350", VA = "0x184023350")]
			public MMEAKJLNKAE<TType> MOOPBDOLOLH(MMEAKJLNKAE<TType> LOPBCKBMJBH, MMEAKJLNKAE<TType> BMJGCJANGHI)
			{
				return default(MMEAKJLNKAE<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4021030", Offset = "0x4020030", VA = "0x184021030")]
			public int BJIMKIFFECE(TNode CHMIAHGMJKI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4021250", Offset = "0x4020250", VA = "0x184021250")]
			public int CJIPCMKAHEH(TNode CHMIAHGMJKI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x40226B0", Offset = "0x40216B0", VA = "0x1840226B0")]
			public TInput IFIPBKOHHJJ(TNode CHMIAHGMJKI, int KHAIDMGPIED)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4022290", Offset = "0x4021290", VA = "0x184022290")]
			public int HDAEFDHMLEB(TNode CHMIAHGMJKI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4022430", Offset = "0x4021430", VA = "0x184022430")]
			public TOutput HIEGHHLCMNP(TNode CHMIAHGMJKI, int KHAIDMGPIED)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4023520", Offset = "0x4022520", VA = "0x184023520")]
			public IEnumerable<HDOHDIFNMPC<TType>> MPALHKBOMFM(TNode CHMIAHGMJKI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4023310", Offset = "0x4022310", VA = "0x184023310")]
			public IEnumerable<KCOAEHKJAJO<TNode>> MNGOLFJAFND([In] TNode CHMIAHGMJKI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4022A60", Offset = "0x4021A60", VA = "0x184022A60")]
			public TType IPEGMDEOOMN(TInput EDAMLOGMMEK)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4021B60", Offset = "0x4020B60", VA = "0x184021B60")]
			public int FALNEAIGPMC(TInput EDAMLOGMMEK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x40214C0", Offset = "0x40204C0", VA = "0x1840214C0")]
			public TOutput EBPBNJDKNHF(TInput EDAMLOGMMEK, int KHAIDMGPIED)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4021CF0", Offset = "0x4020CF0", VA = "0x184021CF0")]
			public TNode FINLCNIMHMN(TInput EDAMLOGMMEK)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4021E10", Offset = "0x4020E10", VA = "0x184021E10")]
			public TType FMBKONCKHLK(TOutput KLPHLLIDBFC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4020D50", Offset = "0x401FD50", VA = "0x184020D50")]
			public int AJEJBCEPCKJ(TOutput KLPHLLIDBFC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4020DA0", Offset = "0x401FDA0", VA = "0x184020DA0")]
			public TInput AJOKPANDLDF(TOutput KLPHLLIDBFC, int KHAIDMGPIED)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x40221C0", Offset = "0x40211C0", VA = "0x1840221C0")]
			public TNode GMHGFCHFBCG(TOutput KLPHLLIDBFC)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4020C40", Offset = "0x401FC40", VA = "0x184020C40")]
			public bool AEPLMDFGEDC(TType PFCMGBLCCPJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4021590", Offset = "0x4020590", VA = "0x184021590")]
			public TType EDJDALFLECK(TType PFCMGBLCCPJ, IEnumerable<TType> BJMCECIEHPO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4022810", Offset = "0x4021810", VA = "0x184022810")]
			public void IKPOHLFMOME(TType PFCMGBLCCPJ, Action<TType> INLFODNJNJA, Action<TType> PGKBBFPCHKO, Action<TType> PECDHNACAJJ, Action<TType> MJKJPBEADEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4021AB0", Offset = "0x4020AB0", VA = "0x184021AB0")]
			public TType EMOCADJCAIP(TType PFCMGBLCCPJ)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4022BB0", Offset = "0x4021BB0", VA = "0x184022BB0")]
			public string LMOPBAAOFAO(TType PFCMGBLCCPJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4021690", Offset = "0x4020690", VA = "0x184021690")]
			public TTerm EGKPCMIOFHL()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x40225E0", Offset = "0x40215E0", VA = "0x1840225E0")]
			public TTerm HKEOAIPIEMM(TTerm CNJGADMIMIH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4022D40", Offset = "0x4021D40", VA = "0x184022D40")]
			public TTerm LNKOCMONCIC(TTerm MMONLHEIBPH, TTerm FAEAEBGGAII)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4022FA0", Offset = "0x4021FA0", VA = "0x184022FA0")]
			public void MEANLGONDFG(TTerm LOPBCKBMJBH, TTerm BMJGCJANGHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4022E10", Offset = "0x4021E10", VA = "0x184022E10")]
			public bool LPPPIMMGKBE(TOutputTerm CNJGADMIMIH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4021F00", Offset = "0x4020F00", VA = "0x184021F00")]
			public bool GBFNGFGAJID(TOutputTerm CNJGADMIMIH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4021130", Offset = "0x4020130", VA = "0x184021130")]
			public TTerm CIFJAFNHDOI(TOutputTerm NODMMMJGKDJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4022050", Offset = "0x4021050", VA = "0x184022050")]
			public TOutputTerm GHDAGKBNGAP(TOutputTerm CNJGADMIMIH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4020FE0", Offset = "0x401FFE0", VA = "0x184020FE0")]
			public TOutputTerm BFHFDJMBBMM(TOutputTerm CNJGADMIMIH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4023180", Offset = "0x4022180", VA = "0x184023180")]
			public TTerm MHOOKDAFPMO(TOutputSubstitution GNCOFENKJCA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x40213D0", Offset = "0x40203D0", VA = "0x1840213D0")]
			public TOutputTerm DDFCADFBKJN(TOutputSubstitution GNCOFENKJCA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4022310", Offset = "0x4021310", VA = "0x184022310")]
			public TOutputTerm HFONLANCLJG(TTerm CNJGADMIMIH)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class DFOAGDCFHGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public FPMKIBELEJF arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public DFOAGDCFHGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5D783B0", Offset = "0x5D773B0", VA = "0x185D783B0")]
			internal int HAPJLAJINJN(FPMKIBELEJF arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5D786A0", Offset = "0x5D776A0", VA = "0x185D786A0")]
			internal TInput PKGBAPHFCJI(FPMKIBELEJF arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5D78560", Offset = "0x5D77560", VA = "0x185D78560")]
			internal int PDPJBNFFDEA(FPMKIBELEJF arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5D78500", Offset = "0x5D77500", VA = "0x185D78500")]
			internal TOutput IJLKFGMFGCH(FPMKIBELEJF arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class MKCIDHJFFNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public FPMKIBELEJF arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, ELHBEBDBPEG<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<ELHBEBDBPEG<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public MKCIDHJFFNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4955560", Offset = "0x4954560", VA = "0x184955560")]
			internal (string, TTerm) ADDDPMADAJE(HDOHDIFNMPC<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JAKBMCFOHJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public FPMKIBELEJF arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public JAKBMCFOHJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x453BF80", Offset = "0x453AF80", VA = "0x18453BF80")]
			internal void EGFODFMPBOJ(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x453B7F0", Offset = "0x453A7F0", VA = "0x18453B7F0")]
			internal void CFDHJFICIGA(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x453C240", Offset = "0x453B240", VA = "0x18453C240")]
			internal void GFOMIFFPGJP(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x453C680", Offset = "0x453B680", VA = "0x18453C680")]
			internal void NNDMCLGJCCL(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CCJAECPMHJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FPMKIBELEJF arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public CCJAECPMHJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x416A2E0", Offset = "0x41692E0", VA = "0x18416A2E0")]
			internal TTerm NDAIECHHGPK(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CAD0", Offset = "0x5D2BAD0", VA = "0x185D2CAD0")]
		private static FGCMJDDBINM GEDIHMELHFM([CallerMemberName] string DMCFPOLFNCF = "")
		{
			return default(FGCMJDDBINM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B5D0", Offset = "0x5D2A5D0", VA = "0x185D2B5D0")]
		public static Dictionary<TNode, List<HDOHDIFNMPC<TType>>> EFCOOMNGGEB(TRoot BAOAKGNNKEP, TDeps IKBDGBPPCAB, TGraph ABNOEFGAADG, IEnumerable<TNode> NJNCDHGKCML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5D39D80", Offset = "0x5D38D80", VA = "0x185D39D80")]
		private static (Dictionary<TTerm, ELHBEBDBPEG<TNode>>, List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>>) PGNHNBAKFCD(IEnumerable<TNode> NJNCDHGKCML, FPMKIBELEJF FPMIIFOGKII)
		{
			return default((Dictionary<TTerm, ELHBEBDBPEG<TNode>>, List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D316F0", Offset = "0x5D306F0", VA = "0x185D316F0")]
		private static void LEBNGPIDPAD(TNode CHMIAHGMJKI, Dictionary<TInput, TTerm> ICOCILGFFFE, Dictionary<TOutput, TTerm> OMIJJHEAOEF, Dictionary<TTerm, ELHBEBDBPEG<TNode>> FPEELGKOOGB, Dictionary<ELHBEBDBPEG<TNode>, TTerm> HCLIMIMNHGH, List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> BBAGPDOOMKE, Stack<TNode> DDNNDJBIDJO, List<KCOAEHKJAJO<TNode>> AONNLMHLDMC, FPMKIBELEJF FPMIIFOGKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E110", Offset = "0x5D2D110", VA = "0x185D2E110")]
		private static Dictionary<string, TTerm> GNGGMNMGGMO(TNode CHMIAHGMJKI, Dictionary<TTerm, ELHBEBDBPEG<TNode>> FPEELGKOOGB, Dictionary<ELHBEBDBPEG<TNode>, TTerm> KDIOPMJNBCD, List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> BBAGPDOOMKE, FPMKIBELEJF FPMIIFOGKII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2E77170", Offset = "0x2E76170", VA = "0x182E77170")]
		private static (TPort, TTerm)[] MLJIDJPLCMH<TPort>(TNode CHMIAHGMJKI, Func<FPMKIBELEJF, TNode, int> IONDCCFGFBP, Func<FPMKIBELEJF, TNode, int, TPort> FPGOOHJNNIC, Func<FPMKIBELEJF, TPort, TType> OGINNCNNIIJ, Dictionary<TPort, TTerm> CMBDONHFHCC, FPMKIBELEJF FPMIIFOGKII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5D30220", Offset = "0x5D2F220", VA = "0x185D30220")]
		private static (TTerm, TTerm) HNLECPMHDFM((TOutput Output, TTerm Id)[] OEOCEOHLKPP, List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> BBAGPDOOMKE, Dictionary<string, TTerm> KDIOPMJNBCD, Stack<TNode> DDNNDJBIDJO, FPMKIBELEJF FPMIIFOGKII)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D33EC0", Offset = "0x5D32EC0", VA = "0x185D33EC0")]
		private static void LGCAAPJKBHL((TInput PortKey, TTerm Id)[] GHPOJDLNEJJ, TTerm LKEMMOGOMAB, TTerm MAGLIAJCGMC, List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> BBAGPDOOMKE, Dictionary<TOutput, TTerm> OMIJJHEAOEF, Dictionary<string, TTerm> KDIOPMJNBCD, Stack<TNode> DDNNDJBIDJO, FPMKIBELEJF FPMIIFOGKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D25A80", Offset = "0x5D24A80", VA = "0x185D25A80")]
		private static TTerm ABLBEODDDHA(TInput EDAMLOGMMEK, List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> BBAGPDOOMKE, Dictionary<TOutput, TTerm> OMIJJHEAOEF, Stack<TNode> DDNNDJBIDJO, FPMKIBELEJF FPMIIFOGKII)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A1F0", Offset = "0x5D291F0", VA = "0x185D2A1F0")]
		private static TTerm DECAOHONOKL([In] TType PFCMGBLCCPJ, IOKind FEHCHLOCDBK, List<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> BBAGPDOOMKE, IReadOnlyDictionary<string, TTerm> KDIOPMJNBCD, FPMKIBELEJF FPMIIFOGKII)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5D39070", Offset = "0x5D38070", VA = "0x185D39070")]
		private static Dictionary<TNode, List<HDOHDIFNMPC<TType>>> NMHCFFKICHO(TOutputSubstitution[] EOKOIFICBON, Dictionary<TTerm, ELHBEBDBPEG<TNode>> FPEELGKOOGB, IEnumerable<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> BBAGPDOOMKE, FPMKIBELEJF FPMIIFOGKII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BBE0", Offset = "0x5D2ABE0", VA = "0x185D2BBE0")]
		private static Dictionary<TNode, List<HDOHDIFNMPC<TType>>> GBBDKAHBNCH(Dictionary<TTerm, ELHBEBDBPEG<TNode>> FPEELGKOOGB, FPMKIBELEJF FPMIIFOGKII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5D368B0", Offset = "0x5D358B0", VA = "0x185D368B0")]
		private static void MCCCADFBNIG([In] TNode CHMIAHGMJKI, Stack<TNode> DDNNDJBIDJO, List<KCOAEHKJAJO<TNode>> AONNLMHLDMC, FPMKIBELEJF FPMIIFOGKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5D26AC0", Offset = "0x5D25AC0", VA = "0x185D26AC0")]
		private static void APHNBLCKMMO(Dictionary<ELHBEBDBPEG<TNode>, TTerm> KDIOPMJNBCD, List<KCOAEHKJAJO<TNode>> AONNLMHLDMC, FPMKIBELEJF FPMIIFOGKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D26FF0", Offset = "0x5D25FF0", VA = "0x185D26FF0")]
		private static Dictionary<TTerm, TType> CIFBPLLPPNL(Dictionary<TTerm, TOutputSubstitution> EOKOIFICBON, IEnumerable<KeyValuePair<TTerm, MMEAKJLNKAE<TType>>> BBAGPDOOMKE, FPMKIBELEJF FPMIIFOGKII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CB10", Offset = "0x5D2BB10", VA = "0x185D2CB10")]
		private static BHNGMIADPIG<TType> GEJMJKILLPM(TOutputTerm PFCMGBLCCPJ, Dictionary<TTerm, TType> BBAGPDOOMKE, Dictionary<TTerm, TType> NBMFIGMFHDG, FPMKIBELEJF FPMIIFOGKII)
		{
			return default(BHNGMIADPIG<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5D31570", Offset = "0x5D30570", VA = "0x185D31570")]
		private static TOutputTerm ILBFNEEDKED(TOutputTerm JHPDANOBHJC, FPMKIBELEJF FPMIIFOGKII)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2DBB3D0", Offset = "0x2DBA3D0", VA = "0x182DBB3D0")]
	public static Dictionary<TNode, List<HDOHDIFNMPC<TType>>> EFCOOMNGGEB<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::ADFMBEBABEI<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> GFJPFDOHONG, TRoot BAOAKGNNKEP, TGraph ABNOEFGAADG, IEnumerable<TNode> NJNCDHGKCML) where TDeps : global::CGIJGDOGLOG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct HDOHDIFNMPC<TType> : IEquatable<HDOHDIFNMPC<TType>>, PLNBPIMMAIH<HDOHDIFNMPC<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string KKNEIOOKBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType KBBNJMMGPIJ;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x41E8100", Offset = "0x41E7100", VA = "0x1841E8100")]
	internal HDOHDIFNMPC(string DMCFPOLFNCF, [In] TType ELJINAIAIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x41E7FE0", Offset = "0x41E6FE0", VA = "0x1841E7FE0")]
	public bool OCBJJFACBHD([In] HDOHDIFNMPC<TType> DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x41E7F40", Offset = "0x41E6F40", VA = "0x1841E7F40", Slot = "4")]
	public bool Equals(HDOHDIFNMPC<TType> DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3C6AC20", Offset = "0x3C69C20", VA = "0x183C6AC20", Slot = "0")]
	public override bool Equals(object DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2352620", Offset = "0x2351620", VA = "0x182352620", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x41E80C0", Offset = "0x41E70C0", VA = "0x1841E80C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x41E7F90", Offset = "0x41E6F90", VA = "0x1841E7F90", Slot = "5")]
	private bool KBPILNCAAAB([In] HDOHDIFNMPC<TType> DFABCHNPEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MFDFDPBBFGA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3084430", Offset = "0x3083430", VA = "0x183084430")]
	public static HDOHDIFNMPC<TType> EJLELCHFLID<TType>(string DMCFPOLFNCF, TType ELJINAIAIMI)
	{
		return default(HDOHDIFNMPC<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3084460", Offset = "0x3083460", VA = "0x183084460")]
	public static (string, TType) IFNFNNMKCGN<TType>([In] this HDOHDIFNMPC<TType> GFJPFDOHONG)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct ELHBEBDBPEG<TNode> : IEquatable<ELHBEBDBPEG<TNode>>, PLNBPIMMAIH<ELHBEBDBPEG<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode OKJCJFPNKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string KKNEIOOKBDG;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x11B3E40", Offset = "0x11B2E40", VA = "0x1811B3E40")]
	internal ELHBEBDBPEG(TNode CHMIAHGMJKI, string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C6AE10", Offset = "0x3C69E10", VA = "0x183C6AE10")]
	public bool OCBJJFACBHD([In] ELHBEBDBPEG<TNode> DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C6ABD0", Offset = "0x3C69BD0", VA = "0x183C6ABD0", Slot = "4")]
	public bool Equals(ELHBEBDBPEG<TNode> DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3C6AC20", Offset = "0x3C69C20", VA = "0x183C6AC20", Slot = "0")]
	public override bool Equals(object DFABCHNPEEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C6AD00", Offset = "0x3C69D00", VA = "0x183C6AD00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C6B010", Offset = "0x3C6A010", VA = "0x183C6B010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3C6ADC0", Offset = "0x3C69DC0", VA = "0x183C6ADC0", Slot = "5")]
	private bool IGMJHLLJDGB([In] ELHBEBDBPEG<TNode> DFABCHNPEEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class LMEFIFAKNKC
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x306BB50", Offset = "0x306AB50", VA = "0x18306BB50")]
	public static ELHBEBDBPEG<TNode> EJLELCHFLID<TNode>(TNode CHMIAHGMJKI, string DMCFPOLFNCF)
	{
		return default(ELHBEBDBPEG<TNode>);
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
