using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct LPNHOJOMAMN<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType EMHLKEMKMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind LIGGENOCMGF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xDCD740", Offset = "0xDCC140", VA = "0x180DCD740")]
	internal LPNHOJOMAMN(TType DGNODDPLLPC, IOKind IJKNEDEJKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5749EC0", Offset = "0x57488C0", VA = "0x185749EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CDANJBNNBAH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3B87200", Offset = "0x3B85C00", VA = "0x183B87200")]
	public static LPNHOJOMAMN<TType> KDBDJPAJKDJ<TType>(TType DGNODDPLLPC, IOKind IJKNEDEJKGF)
	{
		return default(LPNHOJOMAMN<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B87230", Offset = "0x3B85C30", VA = "0x183B87230")]
	public static (TType, IOKind) ODBKGHDGNOM<TType>([In] this LPNHOJOMAMN<TType> DKGBCFDLMOI)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B87270", Offset = "0x3B85C70", VA = "0x183B87270")]
	public static void ODNAGOAKDMJ<TType>([In] this LPNHOJOMAMN<TType> DKGBCFDLMOI, [Out] TType DGNODDPLLPC, [Out] IOKind IJKNEDEJKGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KDGIEOJBCED<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BNEAHJDLHIA<TNode> JAAONOCNDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BNEAHJDLHIA<TNode> EPBPKNJFBMM;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x564A150", Offset = "0x5648B50", VA = "0x18564A150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JAJLKADFMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3E16BB0", Offset = "0x3E155B0", VA = "0x183E16BB0")]
	public static (BNEAHJDLHIA<TNode>, BNEAHJDLHIA<TNode>) ODBKGHDGNOM<TNode>([In] this KDGIEOJBCED<TNode> DKGBCFDLMOI)
	{
		return default((BNEAHJDLHIA<TNode>, BNEAHJDLHIA<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E16C00", Offset = "0x3E15600", VA = "0x183E16C00")]
	public static void ODNAGOAKDMJ<TNode>([In] this KDGIEOJBCED<TNode> DKGBCFDLMOI, [Out] BNEAHJDLHIA<TNode> IIIICGAEODJ, [Out] BNEAHJDLHIA<TNode> ELBIKJBAIEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CBCCGNEDKCO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CBKNPHFFHDI EEGNFAJHEOB(TRoot FAIGKPPBFHA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType NIJDFCBHMBA(TRoot FAIGKPPBFHA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LPNHOJOMAMN<TType> EPMNIEOJMFM(TRoot FAIGKPPBFHA, [In] LPNHOJOMAMN<TType> CFAKKPGMPGD, [In] LPNHOJOMAMN<TType> KMGOFHJBCKL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JFLMDEPPANG(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TNode MNHKIMAOFNO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NNLLLBCJMAH(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TNode MNHKIMAOFNO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput ADJJNFNIHAO(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TNode MNHKIMAOFNO, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CIPPNJBBEJK(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TNode MNHKIMAOFNO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput DLIMPKBKPFP(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TNode MNHKIMAOFNO, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<EHDPCPNLDNN<TType>> MNBMIEPKPGB(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TNode MNHKIMAOFNO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KDGIEOJBCED<TNode>> FOLPOMCOGCH(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TNode MNHKIMAOFNO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType CCHIFOIAHDH(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TInput GHANLDMHBLD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int FJMLFNEHFLG(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TInput GHANLDMHBLD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput JIEIENBNJOC(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TInput GHANLDMHBLD, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode NPGGBMJHEKP(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TInput GHANLDMHBLD);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType PKHHHAOAIAI(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TOutput EDNHDPIMANI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int NAMKBNLEEBB(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TOutput EDNHDPIMANI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput MEEAKBNMOGE(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TOutput EDNHDPIMANI, int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode AHIPODJABLJ(TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, TOutput EDNHDPIMANI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KAPLDNFHMIC(TRoot FAIGKPPBFHA, TType DGNODDPLLPC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType IGJINBAFLAH(TRoot FAIGKPPBFHA, TType DGNODDPLLPC, IEnumerable<TType> EGAMCBLHGAO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KFEDKKLJCBA(TRoot FAIGKPPBFHA, TType DGNODDPLLPC, Action<TType> OCCGGDPAFGO, Action<TType> LCICJNIFCMM, Action<TType> GPDLFMMJFFH, Action<TType> HHBONNJFKNP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType EHIEOPKDMKL(TRoot FAIGKPPBFHA, TType DGNODDPLLPC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string BNMJEJEDALK(TRoot FAIGKPPBFHA, TType DGNODDPLLPC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification AJFOFNGDPLP(TRoot FAIGKPPBFHA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FEENKEDBOAD<TOutputSubstitution[], EFLAGBIEFMN> KECALLLPNCI(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm CMDJOJAMLGJ(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm NDECJICBMED(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TTerm GFFCFCHPJFM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm FGNHIOECCFK(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TTerm EILINOAEIMG, TTerm KAHHEMPAJEL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GCNPHJIFNEG(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TTerm CFAKKPGMPGD, TTerm KMGOFHJBCKL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool LOKFOEGFEMA(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TOutputTerm MGMGPGINCAG);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool FPJHNNBHCAG(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TOutputTerm MGMGPGINCAG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm CNFKDPGFGBC(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TOutputTerm MGMGPGINCAG);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm JHKMLNNKFLA(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TOutputTerm MGMGPGINCAG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm OKNPGMDKBGN(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TOutputTerm MGMGPGINCAG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm GAPPPNODAHI(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TOutputSubstitution JGEJIBLCJFG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm IDDANDKFEAM(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TOutputSubstitution JGEJIBLCJFG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm FPGMKKOCFIO(TRoot FAIGKPPBFHA, TUnification NLGELMAJOID, TTerm GFFCFCHPJFM);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct OMPLIGLCAPL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CBCCGNEDKCO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	public static global::OMPLIGLCAPL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> KDBDJPAJKDJ()
	{
		return default(global::OMPLIGLCAPL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LGLGKCNKJHA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class NOCEKABGGPD<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CBCCGNEDKCO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class AEDOMAINNFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot GLKLCNOCKAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps JEIACCFEIAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification GLLKMEPGOPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph KOONACLOGEK;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public CBKNPHFFHDI IECDIIPNBPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x53053B0", Offset = "0x5303DB0", VA = "0x1853053B0")]
				get
				{
					return default(CBKNPHFFHDI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x53054C0", Offset = "0x5303EC0", VA = "0x1853054C0")]
			private AEDOMAINNFH(TRoot FAIGKPPBFHA, TDeps KPEJCAGFLDG, TUnification DKEEMHFIALI, TGraph HNPPIOOOPNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5304980", Offset = "0x5303380", VA = "0x185304980")]
			public static AEDOMAINNFH KDBDJPAJKDJ(TRoot FAIGKPPBFHA, TDeps KPEJCAGFLDG, TUnification DKEEMHFIALI, TGraph HNPPIOOOPNL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5305050", Offset = "0x5303A50", VA = "0x185305050")]
			public TType NIJDFCBHMBA()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5303B30", Offset = "0x5302530", VA = "0x185303B30")]
			public LPNHOJOMAMN<TType> EPMNIEOJMFM(LPNHOJOMAMN<TType> CFAKKPGMPGD, LPNHOJOMAMN<TType> KMGOFHJBCKL)
			{
				return default(LPNHOJOMAMN<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5304540", Offset = "0x5302F40", VA = "0x185304540")]
			public int JFLMDEPPANG(TNode MNHKIMAOFNO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5305110", Offset = "0x5303B10", VA = "0x185305110")]
			public int NNLLLBCJMAH(TNode MNHKIMAOFNO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x53032A0", Offset = "0x5301CA0", VA = "0x1853032A0")]
			public TInput ADJJNFNIHAO(TNode MNHKIMAOFNO, int KABGMIEBEFC)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x53036E0", Offset = "0x53020E0", VA = "0x1853036E0")]
			public int CIPPNJBBEJK(TNode MNHKIMAOFNO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5303940", Offset = "0x5302340", VA = "0x185303940")]
			public TOutput DLIMPKBKPFP(TNode MNHKIMAOFNO, int KABGMIEBEFC)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5304DF0", Offset = "0x53037F0", VA = "0x185304DF0")]
			public IEnumerable<EHDPCPNLDNN<TType>> MNBMIEPKPGB(TNode MNHKIMAOFNO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5303F40", Offset = "0x5302940", VA = "0x185303F40")]
			public IEnumerable<KDGIEOJBCED<TNode>> FOLPOMCOGCH([In] TNode MNHKIMAOFNO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5303590", Offset = "0x5301F90", VA = "0x185303590")]
			public TType CCHIFOIAHDH(TInput GHANLDMHBLD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5303850", Offset = "0x5302250", VA = "0x185303850")]
			public int COKGBJHKHAP(TInput GHANLDMHBLD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5304650", Offset = "0x5303050", VA = "0x185304650")]
			public TOutput JIEIENBNJOC(TInput GHANLDMHBLD, int KABGMIEBEFC)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x53051D0", Offset = "0x5303BD0", VA = "0x1853051D0")]
			public TNode NPGGBMJHEKP(TInput GHANLDMHBLD)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5305470", Offset = "0x5303E70", VA = "0x185305470")]
			public TType PKHHHAOAIAI(TOutput EDNHDPIMANI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5303E70", Offset = "0x5302870", VA = "0x185303E70")]
			public int FMMMGADEPMC(TOutput EDNHDPIMANI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5304CD0", Offset = "0x53036D0", VA = "0x185304CD0")]
			public TInput MEEAKBNMOGE(TOutput EDNHDPIMANI, int KABGMIEBEFC)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x53033B0", Offset = "0x5301DB0", VA = "0x1853033B0")]
			public TNode AHIPODJABLJ(TOutput EDNHDPIMANI)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5304770", Offset = "0x5303170", VA = "0x185304770")]
			public bool KAPLDNFHMIC(TType DGNODDPLLPC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5304400", Offset = "0x5302E00", VA = "0x185304400")]
			public TType IGJINBAFLAH(TType DGNODDPLLPC, IEnumerable<TType> EGAMCBLHGAO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5304A80", Offset = "0x5303480", VA = "0x185304A80")]
			public void KFEDKKLJCBA(TType DGNODDPLLPC, Action<TType> OCCGGDPAFGO, Action<TType> LCICJNIFCMM, Action<TType> GPDLFMMJFFH, Action<TType> HHBONNJFKNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5303A80", Offset = "0x5302480", VA = "0x185303A80")]
			public TType EHIEOPKDMKL(TType DGNODDPLLPC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5303480", Offset = "0x5301E80", VA = "0x185303480")]
			public string BNMJEJEDALK(TType DGNODDPLLPC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5303720", Offset = "0x5302120", VA = "0x185303720")]
			public TTerm CMDJOJAMLGJ()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5304F30", Offset = "0x5303930", VA = "0x185304F30")]
			public TTerm NDECJICBMED(TTerm GFFCFCHPJFM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5303CA0", Offset = "0x53026A0", VA = "0x185303CA0")]
			public TTerm FGNHIOECCFK(TTerm EILINOAEIMG, TTerm KAHHEMPAJEL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x53041F0", Offset = "0x5302BF0", VA = "0x1853041F0")]
			public void GCNPHJIFNEG(TTerm CFAKKPGMPGD, TTerm KMGOFHJBCKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5304050", Offset = "0x5302A50", VA = "0x185304050")]
			public bool FPJHNNBHCAG(TOutputTerm GFFCFCHPJFM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5304C80", Offset = "0x5303680", VA = "0x185304C80")]
			public bool LOKFOEGFEMA(TOutputTerm GFFCFCHPJFM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x53039B0", Offset = "0x53023B0", VA = "0x1853039B0")]
			public TTerm DNHOAJMKKDL(TOutputTerm MGMGPGINCAG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5304580", Offset = "0x5302F80", VA = "0x185304580")]
			public TOutputTerm JHKMLNNKFLA(TOutputTerm GFFCFCHPJFM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5305220", Offset = "0x5303C20", VA = "0x185305220")]
			public TOutputTerm OKNPGMDKBGN(TOutputTerm GFFCFCHPJFM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x53041A0", Offset = "0x5302BA0", VA = "0x1853041A0")]
			public TTerm GAPPPNODAHI(TOutputSubstitution AEJHMLBJIKL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x53043B0", Offset = "0x5302DB0", VA = "0x1853043B0")]
			public TOutputTerm IDDANDKFEAM(TOutputSubstitution AEJHMLBJIKL)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5303F80", Offset = "0x5302980", VA = "0x185303F80")]
			public TOutputTerm FPGMKKOCFIO(TTerm GFFCFCHPJFM)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IFGFKOPEEOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public AEDOMAINNFH arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public IFGFKOPEEOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4FFF030", Offset = "0x4FFDA30", VA = "0x184FFF030")]
			internal int DPBBDANODJG(AEDOMAINNFH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x52E07C0", Offset = "0x52DF1C0", VA = "0x1852E07C0")]
			internal TInput ENEDDJMMBMJ(AEDOMAINNFH arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x52E0830", Offset = "0x52DF230", VA = "0x1852E0830")]
			internal int JLMFIBIKDBL(AEDOMAINNFH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x52E08E0", Offset = "0x52DF2E0", VA = "0x1852E08E0")]
			internal TOutput KNFHOEDPALM(AEDOMAINNFH arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NHHOLKMJJCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public AEDOMAINNFH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, BNEAHJDLHIA<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<BNEAHJDLHIA<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public NHHOLKMJJCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5A5D840", Offset = "0x5A5C240", VA = "0x185A5D840")]
			internal (string, TTerm) GALJNNGAIKP(EHDPCPNLDNN<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MFEJAFCGKCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AEDOMAINNFH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public MFEJAFCGKCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5942350", Offset = "0x5940D50", VA = "0x185942350")]
			internal void KJKHDIBHNAB(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5942910", Offset = "0x5941310", VA = "0x185942910")]
			internal void OEPIIEICMLK(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5942750", Offset = "0x5941150", VA = "0x185942750")]
			internal void NHFJDEIEDBI(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5941E90", Offset = "0x5940890", VA = "0x185941E90")]
			internal void CBCKOLHNJPP(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LACAKKHLBMI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public AEDOMAINNFH arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public LACAKKHLBMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x5193720", Offset = "0x5192120", VA = "0x185193720")]
			internal TTerm IPEFHINMONN(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5A6D670", Offset = "0x5A6C070", VA = "0x185A6D670")]
		private static NDPBDHPILEI EEBJIJMFGIF([CallerMemberName] string IELIBBNCJAC = "")
		{
			return default(NDPBDHPILEI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5A729E0", Offset = "0x5A713E0", VA = "0x185A729E0")]
		public static Dictionary<TNode, List<EHDPCPNLDNN<TType>>> JPLGKHEDOAN(TRoot FAIGKPPBFHA, TDeps KPEJCAGFLDG, TGraph HNPPIOOOPNL, IEnumerable<TNode> EFJLHLAODDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5A6E150", Offset = "0x5A6CB50", VA = "0x185A6E150")]
		private static (Dictionary<TTerm, BNEAHJDLHIA<TNode>>, List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>>) GNLNLALLEAJ(IEnumerable<TNode> EFJLHLAODDP, AEDOMAINNFH MFHBGCBJCJO)
		{
			return default((Dictionary<TTerm, BNEAHJDLHIA<TNode>>, List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5A69DE0", Offset = "0x5A687E0", VA = "0x185A69DE0")]
		private static void ACMEILBCMAD(TNode MNHKIMAOFNO, Dictionary<TInput, TTerm> FEKBCDFNFEK, Dictionary<TOutput, TTerm> CPCLPEKLLON, Dictionary<TTerm, BNEAHJDLHIA<TNode>> DAMMAPBMMEB, Dictionary<BNEAHJDLHIA<TNode>, TTerm> FGOKMGBFMIP, List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> JJICEAJAKFH, Stack<TNode> NELPFJPJNAM, List<KDGIEOJBCED<TNode>> DBKFGFEGJIE, AEDOMAINNFH MFHBGCBJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5A6AA00", Offset = "0x5A69400", VA = "0x185A6AA00")]
		private static Dictionary<string, TTerm> AEODFALKCLL(TNode MNHKIMAOFNO, Dictionary<TTerm, BNEAHJDLHIA<TNode>> DAMMAPBMMEB, Dictionary<BNEAHJDLHIA<TNode>, TTerm> OKNPJKBKKON, List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> JJICEAJAKFH, AEDOMAINNFH MFHBGCBJCJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x453CEE0", Offset = "0x453B8E0", VA = "0x18453CEE0")]
		private static (TPort, TTerm)[] ABAIALIJOFN<TPort>(TNode MNHKIMAOFNO, Func<AEDOMAINNFH, TNode, int> NFJJHNLOLDC, Func<AEDOMAINNFH, TNode, int, TPort> BJPIGKKFNHB, Func<AEDOMAINNFH, TPort, TType> MMNBCOFCMJM, Dictionary<TPort, TTerm> BPCLIILNDOO, AEDOMAINNFH MFHBGCBJCJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5A75600", Offset = "0x5A74000", VA = "0x185A75600")]
		private static (TTerm, TTerm) LPFEPIBGJEH((TOutput Output, TTerm Id)[] KMNNAIEIKPD, List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> JJICEAJAKFH, Dictionary<string, TTerm> OKNPJKBKKON, Stack<TNode> NELPFJPJNAM, AEDOMAINNFH MFHBGCBJCJO)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5A6EBF0", Offset = "0x5A6D5F0", VA = "0x185A6EBF0")]
		private static void HJNCKNCBGOJ((TInput PortKey, TTerm Id)[] GGJLBGCBLPO, TTerm PHKEKCBFAHG, TTerm JAKOCCMPEGJ, List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> JJICEAJAKFH, Dictionary<TOutput, TTerm> CPCLPEKLLON, Dictionary<string, TTerm> OKNPJKBKKON, Stack<TNode> NELPFJPJNAM, AEDOMAINNFH MFHBGCBJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5A76B80", Offset = "0x5A75580", VA = "0x185A76B80")]
		private static TTerm OGJKOOFHBML(TInput GHANLDMHBLD, List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> JJICEAJAKFH, Dictionary<TOutput, TTerm> CPCLPEKLLON, Stack<TNode> NELPFJPJNAM, AEDOMAINNFH MFHBGCBJCJO)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5A72F40", Offset = "0x5A71940", VA = "0x185A72F40")]
		private static TTerm KCIIMGJHKJN([In] TType DGNODDPLLPC, IOKind IJKNEDEJKGF, List<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> JJICEAJAKFH, IReadOnlyDictionary<string, TTerm> OKNPJKBKKON, AEDOMAINNFH MFHBGCBJCJO)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5A6AD10", Offset = "0x5A69710", VA = "0x185A6AD10")]
		private static Dictionary<TNode, List<EHDPCPNLDNN<TType>>> BKOKLHKGOIB(TOutputSubstitution[] ANHDDPFNKHK, Dictionary<TTerm, BNEAHJDLHIA<TNode>> DAMMAPBMMEB, IEnumerable<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> JJICEAJAKFH, AEDOMAINNFH MFHBGCBJCJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5A762A0", Offset = "0x5A74CA0", VA = "0x185A762A0")]
		private static Dictionary<TNode, List<EHDPCPNLDNN<TType>>> MEHIFDPNHOA(Dictionary<TTerm, BNEAHJDLHIA<TNode>> DAMMAPBMMEB, AEDOMAINNFH MFHBGCBJCJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5A6CDF0", Offset = "0x5A6B7F0", VA = "0x185A6CDF0")]
		private static void DCDCDKODHFF([In] TNode MNHKIMAOFNO, Stack<TNode> NELPFJPJNAM, List<KDGIEOJBCED<TNode>> DBKFGFEGJIE, AEDOMAINNFH MFHBGCBJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5A6C940", Offset = "0x5A6B340", VA = "0x185A6C940")]
		private static void CJMJHIHIMEJ(Dictionary<BNEAHJDLHIA<TNode>, TTerm> OKNPJKBKKON, List<KDGIEOJBCED<TNode>> DBKFGFEGJIE, AEDOMAINNFH MFHBGCBJCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5A70470", Offset = "0x5A6EE70", VA = "0x185A70470")]
		private static Dictionary<TTerm, TType> JLJGOILEHIG(Dictionary<TTerm, TOutputSubstitution> ANHDDPFNKHK, IEnumerable<KeyValuePair<TTerm, LPNHOJOMAMN<TType>>> JJICEAJAKFH, AEDOMAINNFH MFHBGCBJCJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5A74170", Offset = "0x5A72B70", VA = "0x185A74170")]
		private static DBCJPOJBOOF<TType> LLHHPDMLPBB(TOutputTerm DGNODDPLLPC, Dictionary<TTerm, TType> JJICEAJAKFH, Dictionary<TTerm, TType> DMBGDIBKIKH, AEDOMAINNFH MFHBGCBJCJO)
		{
			return default(DBCJPOJBOOF<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5A73820", Offset = "0x5A72220", VA = "0x185A73820")]
		private static TOutputTerm LGLFDOMPPIM(TOutputTerm JAIPIMLDLEL, AEDOMAINNFH MFHBGCBJCJO)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3E6F900", Offset = "0x3E6E300", VA = "0x183E6F900")]
	public static Dictionary<TNode, List<EHDPCPNLDNN<TType>>> JPLGKHEDOAN<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::OMPLIGLCAPL<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DKGBCFDLMOI, TRoot FAIGKPPBFHA, TGraph HNPPIOOOPNL, IEnumerable<TNode> EFJLHLAODDP) where TDeps : global::CBCCGNEDKCO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct EHDPCPNLDNN<TType> : IEquatable<EHDPCPNLDNN<TType>>, IIHDAIFMJNA<EHDPCPNLDNN<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string DDPJMHMICBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType HFCJEDMGNNE;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4B13B40", Offset = "0x4B12540", VA = "0x184B13B40")]
	internal EHDPCPNLDNN(string IELIBBNCJAC, [In] TType FCOMCEKMICO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4B139E0", Offset = "0x4B123E0", VA = "0x184B139E0")]
	public bool MENPHCFDABP([In] EHDPCPNLDNN<TType> GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4B13930", Offset = "0x4B12330", VA = "0x184B13930", Slot = "4")]
	public bool Equals(EHDPCPNLDNN<TType> GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x45D2450", Offset = "0x45D0E50", VA = "0x1845D2450", Slot = "0")]
	public override bool Equals(object GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4B13980", Offset = "0x4B12380", VA = "0x184B13980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4B13B00", Offset = "0x4B12500", VA = "0x184B13B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4B13AB0", Offset = "0x4B124B0", VA = "0x184B13AB0", Slot = "5")]
	private bool OKJPOEKOKOH([In] EHDPCPNLDNN<TType> GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JNLFGHIBMJK
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3E2A100", Offset = "0x3E28B00", VA = "0x183E2A100")]
	public static EHDPCPNLDNN<TType> KDBDJPAJKDJ<TType>(string IELIBBNCJAC, TType FCOMCEKMICO)
	{
		return default(EHDPCPNLDNN<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3E2A130", Offset = "0x3E28B30", VA = "0x183E2A130")]
	public static (string, TType) ODBKGHDGNOM<TType>([In] this EHDPCPNLDNN<TType> DKGBCFDLMOI)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct BNEAHJDLHIA<TNode> : IEquatable<BNEAHJDLHIA<TNode>>, IIHDAIFMJNA<BNEAHJDLHIA<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode BDOIOHDHMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string DDPJMHMICBF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
	internal BNEAHJDLHIA(TNode MNHKIMAOFNO, string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6781D20", Offset = "0x6780720", VA = "0x186781D20")]
	public bool MENPHCFDABP([In] BNEAHJDLHIA<TNode> GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6781CD0", Offset = "0x67806D0", VA = "0x186781CD0", Slot = "4")]
	public bool Equals(BNEAHJDLHIA<TNode> GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x45D2450", Offset = "0x45D0E50", VA = "0x1845D2450", Slot = "0")]
	public override bool Equals(object GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4B13980", Offset = "0x4B12380", VA = "0x184B13980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6781DF0", Offset = "0x67807F0", VA = "0x186781DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6781C80", Offset = "0x6780680", VA = "0x186781C80", Slot = "5")]
	private bool EFGHLAIPADK([In] BNEAHJDLHIA<TNode> GOCNHGEHNFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ANIBEMNNFCJ
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x32D28B0", Offset = "0x32D12B0", VA = "0x1832D28B0")]
	public static BNEAHJDLHIA<TNode> KDBDJPAJKDJ<TNode>(TNode MNHKIMAOFNO, string IELIBBNCJAC)
	{
		return default(BNEAHJDLHIA<TNode>);
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
