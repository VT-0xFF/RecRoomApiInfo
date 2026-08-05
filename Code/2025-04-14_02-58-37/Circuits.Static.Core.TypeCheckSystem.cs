using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct IDAGKCMOKGD<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType ABBLELNBDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind DEOHBAKAOFO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xBB2110", Offset = "0xBB0B10", VA = "0x180BB2110")]
	internal IDAGKCMOKGD(TType OHCGINPDMEI, IOKind MJJGFHGNDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4A70320", Offset = "0x4A6ED20", VA = "0x184A70320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EJOOLJAHBMI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x34C2020", Offset = "0x34C0A20", VA = "0x1834C2020")]
	public static IDAGKCMOKGD<TType> DDDHPONDPCL<TType>(TType OHCGINPDMEI, IOKind MJJGFHGNDCN)
	{
		return default(IDAGKCMOKGD<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x34C20C0", Offset = "0x34C0AC0", VA = "0x1834C20C0")]
	public static (TType, IOKind) FIIFLPCCFLL<TType>([In] this IDAGKCMOKGD<TType> IJPDNJELPLO)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34C2050", Offset = "0x34C0A50", VA = "0x1834C2050")]
	public static void EHJACGLEOBL<TType>([In] this IDAGKCMOKGD<TType> IJPDNJELPLO, [Out] TType OHCGINPDMEI, [Out] IOKind MJJGFHGNDCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct ELEDHAKNFCB<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LOOGPIJIHNJ<TNode> EFOFPCNBNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly LOOGPIJIHNJ<TNode> OPFKGIBCCLK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x436F900", Offset = "0x436E300", VA = "0x18436F900", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GPGMPKJEMII
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3671DA0", Offset = "0x36707A0", VA = "0x183671DA0")]
	public static (LOOGPIJIHNJ<TNode>, LOOGPIJIHNJ<TNode>) FIIFLPCCFLL<TNode>([In] this ELEDHAKNFCB<TNode> IJPDNJELPLO)
	{
		return default((LOOGPIJIHNJ<TNode>, LOOGPIJIHNJ<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3671CA0", Offset = "0x36706A0", VA = "0x183671CA0")]
	public static void EHJACGLEOBL<TNode>([In] this ELEDHAKNFCB<TNode> IJPDNJELPLO, [Out] LOOGPIJIHNJ<TNode> AKJAPDOPIOF, [Out] LOOGPIJIHNJ<TNode> CPKHJEJFIJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MFGFINNBANN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPBBKEMMBPE AEFNKEAJABJ(TRoot MHHKOMDGDID);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType KMFOEJLHHNB(TRoot MHHKOMDGDID);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDAGKCMOKGD<TType> JAEFPMKJDPP(TRoot MHHKOMDGDID, [In] IDAGKCMOKGD<TType> HIHOACCANFP, [In] IDAGKCMOKGD<TType> JJEIFHEKJKL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int OLCNKFAGEBC(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TNode ABACLNNLPOO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int APJJENLMAKH(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TNode ABACLNNLPOO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput GFAANIEIGAL(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TNode ABACLNNLPOO, int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DDHNLFENGHJ(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TNode ABACLNNLPOO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput LENGCLKBIGI(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TNode ABACLNNLPOO, int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CGPILNCPJKO<TType>> NNBCPJHOJBH(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TNode ABACLNNLPOO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<ELEDHAKNFCB<TNode>> DBICDJIDGKG(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TNode ABACLNNLPOO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType LKIDJJPPDMD(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TInput OBMEHBOBMDK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int NMIKGEFOOJI(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TInput OBMEHBOBMDK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput FABGCOGEFPL(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TInput OBMEHBOBMDK, int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode PGDDBPBNIFK(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TInput OBMEHBOBMDK);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType FCBMKMBJEGJ(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TOutput NBCCNBKOOIE);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int ACPLHNBFHNL(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TOutput NBCCNBKOOIE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput CAHKLDGDBNL(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TOutput NBCCNBKOOIE, int DOAKEFBOPIA);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode MLHAMDDGOKD(TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, TOutput NBCCNBKOOIE);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IJOMJODKGDN(TRoot MHHKOMDGDID, TType OHCGINPDMEI);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType GGELBPJKDKM(TRoot MHHKOMDGDID, TType OHCGINPDMEI, IEnumerable<TType> LBGFDKJONCL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CCPGCFBLDFJ(TRoot MHHKOMDGDID, TType OHCGINPDMEI, Action<TType> BOLKIDCDNAM, Action<TType> DCCOKOIJLHB, Action<TType> HJHFCCLHNOL, Action<TType> HGDJJEDECPC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType GEFOKJOBNNK(TRoot MHHKOMDGDID, TType OHCGINPDMEI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string CMADLDHAEDG(TRoot MHHKOMDGDID, TType OHCGINPDMEI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification GAAKIJOCEGB(TRoot MHHKOMDGDID);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	CEGCKGHHPPP<TOutputSubstitution[], MJKMNFLLIGE> PMKAOHLBEJO(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm FIOJINMGMIK(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm EICPAGIHHIP(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TTerm LAEAGILACEI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm LLKIFKNLMMI(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TTerm CGKFGDDBBPE, TTerm JCDJPNMFCEK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MDGCIMOHLKO(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TTerm HIHOACCANFP, TTerm JJEIFHEKJKL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool EJBFMFHIHGL(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TOutputTerm KFHPPICNHKN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool FLEDOFBFDGA(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TOutputTerm KFHPPICNHKN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm FFJCJHOIACN(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TOutputTerm KFHPPICNHKN);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm OEMKPJOCMOO(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TOutputTerm KFHPPICNHKN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm JAENHEMIBLM(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TOutputTerm KFHPPICNHKN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm MBDAHCLOIPL(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TOutputSubstitution MAPEBONCIOF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm JJDFBHHCCLB(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TOutputSubstitution MAPEBONCIOF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm BGILPGPOLHE(TRoot MHHKOMDGDID, TUnification DEDCLPKPDDM, TTerm LAEAGILACEI);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IGBJCDPCGHH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::MFGFINNBANN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930")]
	public static global::IGBJCDPCGHH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DDDHPONDPCL()
	{
		return default(global::IGBJCDPCGHH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DEEBMMBFJGL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class GNJNHONHLNK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::MFGFINNBANN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class FMFJHKGFMPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot LKAEGJLGAIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps PNGBONDJLMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification CDFIAGDOBGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph HFMNHEFOOHB;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public NPBBKEMMBPE IMALLAAJAGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x47DE300", Offset = "0x47DCD00", VA = "0x1847DE300")]
				get
				{
					return default(NPBBKEMMBPE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x47DEFA0", Offset = "0x47DD9A0", VA = "0x1847DEFA0")]
			private FMFJHKGFMPB(TRoot MHHKOMDGDID, TDeps DODNABDPAAP, TUnification ODMJOLFFILO, TGraph FHMFCJGBAIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x47DCEA0", Offset = "0x47DB8A0", VA = "0x1847DCEA0")]
			public static FMFJHKGFMPB DDDHPONDPCL(TRoot MHHKOMDGDID, TDeps DODNABDPAAP, TUnification ODMJOLFFILO, TGraph FHMFCJGBAIP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x47DDF90", Offset = "0x47DC990", VA = "0x1847DDF90")]
			public TType KMFOEJLHHNB()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x47DDC10", Offset = "0x47DC610", VA = "0x1847DDC10")]
			public IDAGKCMOKGD<TType> JAEFPMKJDPP(IDAGKCMOKGD<TType> HIHOACCANFP, IDAGKCMOKGD<TType> JJEIFHEKJKL)
			{
				return default(IDAGKCMOKGD<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x47DED10", Offset = "0x47DD710", VA = "0x1847DED10")]
			public int OLCNKFAGEBC(TNode ABACLNNLPOO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x47DC620", Offset = "0x47DB020", VA = "0x1847DC620")]
			public int APJJENLMAKH(TNode ABACLNNLPOO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x47DD860", Offset = "0x47DC260", VA = "0x1847DD860")]
			public TInput GFAANIEIGAL(TNode ABACLNNLPOO, int DOAKEFBOPIA)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x47DD070", Offset = "0x47DBA70", VA = "0x1847DD070")]
			public int DDHNLFENGHJ(TNode ABACLNNLPOO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x47DE1C0", Offset = "0x47DCBC0", VA = "0x1847DE1C0")]
			public TOutput LENGCLKBIGI(TNode ABACLNNLPOO, int DOAKEFBOPIA)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x47DEB50", Offset = "0x47DD550", VA = "0x1847DEB50")]
			public IEnumerable<CGPILNCPJKO<TType>> NNBCPJHOJBH(TNode ABACLNNLPOO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x47DCC40", Offset = "0x47DB640", VA = "0x1847DCC40")]
			public IEnumerable<ELEDHAKNFCB<TNode>> DBICDJIDGKG([In] TNode ABACLNNLPOO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x47DE410", Offset = "0x47DCE10", VA = "0x1847DE410")]
			public TType LKIDJJPPDMD(TInput OBMEHBOBMDK)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x47DE970", Offset = "0x47DD370", VA = "0x1847DE970")]
			public int MEONLEPDFNG(TInput OBMEHBOBMDK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x47DD2B0", Offset = "0x47DBCB0", VA = "0x1847DD2B0")]
			public TOutput FABGCOGEFPL(TInput OBMEHBOBMDK, int DOAKEFBOPIA)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x47DEE10", Offset = "0x47DD810", VA = "0x1847DEE10")]
			public TNode PGDDBPBNIFK(TInput OBMEHBOBMDK)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x47DD460", Offset = "0x47DBE60", VA = "0x1847DD460")]
			public TType FCBMKMBJEGJ(TOutput NBCCNBKOOIE)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x47DE100", Offset = "0x47DCB00", VA = "0x1847DE100")]
			public int LCOLBEBDFGC(TOutput NBCCNBKOOIE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x47DC7F0", Offset = "0x47DB1F0", VA = "0x1847DC7F0")]
			public TInput CAHKLDGDBNL(TOutput NBCCNBKOOIE, int DOAKEFBOPIA)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x47DEA00", Offset = "0x47DD400", VA = "0x1847DEA00")]
			public TNode MLHAMDDGOKD(TOutput NBCCNBKOOIE)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x47DDB00", Offset = "0x47DC500", VA = "0x1847DDB00")]
			public bool IJOMJODKGDN(TType OHCGINPDMEI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x47DD9C0", Offset = "0x47DC3C0", VA = "0x1847DD9C0")]
			public TType GGELBPJKDKM(TType OHCGINPDMEI, IEnumerable<TType> LBGFDKJONCL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x47DC8C0", Offset = "0x47DB2C0", VA = "0x1847DC8C0")]
			public void CCPGCFBLDFJ(TType OHCGINPDMEI, Action<TType> BOLKIDCDNAM, Action<TType> DCCOKOIJLHB, Action<TType> HJHFCCLHNOL, Action<TType> HGDJJEDECPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x47DD710", Offset = "0x47DC110", VA = "0x1847DD710")]
			public TType GEFOKJOBNNK(TType OHCGINPDMEI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x47DCB00", Offset = "0x47DB500", VA = "0x1847DCB00")]
			public string CMADLDHAEDG(TType OHCGINPDMEI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x47DD520", Offset = "0x47DBF20", VA = "0x1847DD520")]
			public TTerm FIOJINMGMIK()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x47DD130", Offset = "0x47DBB30", VA = "0x1847DD130")]
			public TTerm EICPAGIHHIP(TTerm LAEAGILACEI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x47DE520", Offset = "0x47DCF20", VA = "0x1847DE520")]
			public TTerm LLKIFKNLMMI(TTerm CGKFGDDBBPE, TTerm JCDJPNMFCEK)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x47DE870", Offset = "0x47DD270", VA = "0x1847DE870")]
			public void MDGCIMOHLKO(TTerm HIHOACCANFP, TTerm JJEIFHEKJKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x47DD6D0", Offset = "0x47DC0D0", VA = "0x1847DD6D0")]
			public bool FLEDOFBFDGA(TOutputTerm LAEAGILACEI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x47DD270", Offset = "0x47DBC70", VA = "0x1847DD270")]
			public bool EJBFMFHIHGL(TOutputTerm LAEAGILACEI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x47DDA00", Offset = "0x47DC400", VA = "0x1847DDA00")]
			public TTerm HHNNLNAFCND(TOutputTerm KFHPPICNHKN)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x47DEC50", Offset = "0x47DD650", VA = "0x1847DEC50")]
			public TOutputTerm OEMKPJOCMOO(TOutputTerm LAEAGILACEI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x47DDDD0", Offset = "0x47DC7D0", VA = "0x1847DDDD0")]
			public TOutputTerm JAENHEMIBLM(TOutputTerm LAEAGILACEI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x47DE740", Offset = "0x47DD140", VA = "0x1847DE740")]
			public TTerm MBDAHCLOIPL(TOutputSubstitution AMDLKCKIMKB)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x47DDF50", Offset = "0x47DC950", VA = "0x1847DDF50")]
			public TOutputTerm JJDFBHHCCLB(TOutputSubstitution AMDLKCKIMKB)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x47DC6E0", Offset = "0x47DB0E0", VA = "0x1847DC6E0")]
			public TOutputTerm BGILPGPOLHE(TTerm LAEAGILACEI)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class FBOOOOLMGJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public FMFJHKGFMPB arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public FBOOOOLMGJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x47A9C10", Offset = "0x47A8610", VA = "0x1847A9C10")]
			internal int LBDIGPINFKE(FMFJHKGFMPB arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x47A9D30", Offset = "0x47A8730", VA = "0x1847A9D30")]
			internal TInput OCEMOGGLENC(FMFJHKGFMPB arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x47A9CD0", Offset = "0x47A86D0", VA = "0x1847A9CD0")]
			internal int NKPGEGNONED(FMFJHKGFMPB arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x47A9B30", Offset = "0x47A8530", VA = "0x1847A9B30")]
			internal TOutput DMCKDAMFPJF(FMFJHKGFMPB arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class PEDMJGCBDKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public FMFJHKGFMPB arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, LOOGPIJIHNJ<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<LOOGPIJIHNJ<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public PEDMJGCBDKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x53CAA60", Offset = "0x53C9460", VA = "0x1853CAA60")]
			internal (string, TTerm) IJAIBAHCHDO(CGPILNCPJKO<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GDOIIKHFLEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public FMFJHKGFMPB arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public GDOIIKHFLEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4886880", Offset = "0x4885280", VA = "0x184886880")]
			internal void BBBKKMLDONM(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4886D90", Offset = "0x4885790", VA = "0x184886D90")]
			internal void EKNLHHBDHDJ(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4886FA0", Offset = "0x48859A0", VA = "0x184886FA0")]
			internal void GAKFLIENIGK(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x48873B0", Offset = "0x4885DB0", VA = "0x1848873B0")]
			internal void NFPHOLIJNHK(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DLANKAOPGEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public FMFJHKGFMPB arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
			public DLANKAOPGEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3EE4EA0", Offset = "0x3EE38A0", VA = "0x183EE4EA0")]
			internal TTerm FPCNAIMJHLA(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x48DF5A0", Offset = "0x48DDFA0", VA = "0x1848DF5A0")]
		private static DJOAHGAECFA DNMPBCMHOPL([CallerMemberName] string EMLAIMJKHOE = "")
		{
			return default(DJOAHGAECFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x48E2040", Offset = "0x48E0A40", VA = "0x1848E2040")]
		public static Dictionary<TNode, List<CGPILNCPJKO<TType>>> IIOGGMGOFKO(TRoot MHHKOMDGDID, TDeps DODNABDPAAP, TGraph FHMFCJGBAIP, IEnumerable<TNode> BGHPLOELKGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x48E25F0", Offset = "0x48E0FF0", VA = "0x1848E25F0")]
		private static (Dictionary<TTerm, LOOGPIJIHNJ<TNode>>, List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>>) JKCFPIBDLHK(IEnumerable<TNode> BGHPLOELKGN, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return default((Dictionary<TTerm, LOOGPIJIHNJ<TNode>>, List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x48E13B0", Offset = "0x48DFDB0", VA = "0x1848E13B0")]
		private static void HGEPMBKEKHL(TNode ABACLNNLPOO, Dictionary<TInput, TTerm> GBGABDNMNGF, Dictionary<TOutput, TTerm> OOBOPFHMGJE, Dictionary<TTerm, LOOGPIJIHNJ<TNode>> GOMGAHJOFNN, Dictionary<LOOGPIJIHNJ<TNode>, TTerm> JCGNPEFDJEN, List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> JJMCEGFGHHP, Stack<TNode> BPECLBJBAPB, List<ELEDHAKNFCB<TNode>> BILNLGOIPDE, FMFJHKGFMPB JDKFBOCIIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x48DEC00", Offset = "0x48DD600", VA = "0x1848DEC00")]
		private static Dictionary<string, TTerm> BEOOMIFLGHG(TNode ABACLNNLPOO, Dictionary<TTerm, LOOGPIJIHNJ<TNode>> GOMGAHJOFNN, Dictionary<LOOGPIJIHNJ<TNode>, TTerm> GPAGLACNMGO, List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> JJMCEGFGHHP, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A7B7E0", Offset = "0x3A7A1E0", VA = "0x183A7B7E0")]
		private static (TPort, TTerm)[] KAGHNEJCDEF<TPort>(TNode ABACLNNLPOO, Func<FMFJHKGFMPB, TNode, int> KMLGAAAEONK, Func<FMFJHKGFMPB, TNode, int, TPort> KNCEIHACDFN, Func<FMFJHKGFMPB, TPort, TType> KPDCMBFAOFB, Dictionary<TPort, TTerm> IAFJKHJDAEO, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x48DF5E0", Offset = "0x48DDFE0", VA = "0x1848DF5E0")]
		private static (TTerm, TTerm) DPFEINAOKBP((TOutput Output, TTerm Id)[] JIAKPFHEFGI, List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> JJMCEGFGHHP, Dictionary<string, TTerm> GPAGLACNMGO, Stack<TNode> BPECLBJBAPB, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x48E3D00", Offset = "0x48E2700", VA = "0x1848E3D00")]
		private static void MCANBEOHOLL((TInput PortKey, TTerm Id)[] DEODNEFEADF, TTerm EPJOALGENAO, TTerm MNEAFINCDKO, List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> JJMCEGFGHHP, Dictionary<TOutput, TTerm> OOBOPFHMGJE, Dictionary<string, TTerm> GPAGLACNMGO, Stack<TNode> BPECLBJBAPB, FMFJHKGFMPB JDKFBOCIIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x48E3170", Offset = "0x48E1B70", VA = "0x1848E3170")]
		private static TTerm LKAJMCANNFP(TInput OBMEHBOBMDK, List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> JJMCEGFGHHP, Dictionary<TOutput, TTerm> OOBOPFHMGJE, Stack<TNode> BPECLBJBAPB, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x48E36F0", Offset = "0x48E20F0", VA = "0x1848E36F0")]
		private static TTerm LMDMLEPFECM([In] TType OHCGINPDMEI, IOKind MJJGFHGNDCN, List<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> JJMCEGFGHHP, IReadOnlyDictionary<string, TTerm> GPAGLACNMGO, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x48DDF90", Offset = "0x48DC990", VA = "0x1848DDF90")]
		private static Dictionary<TNode, List<CGPILNCPJKO<TType>>> BBHEIGLOHEE(TOutputSubstitution[] FICBJHDHMEG, Dictionary<TTerm, LOOGPIJIHNJ<TNode>> GOMGAHJOFNN, IEnumerable<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> JJMCEGFGHHP, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x48DDAE0", Offset = "0x48DC4E0", VA = "0x1848DDAE0")]
		private static Dictionary<TNode, List<CGPILNCPJKO<TType>>> ACPHNKOALOO(Dictionary<TTerm, LOOGPIJIHNJ<TNode>> GOMGAHJOFNN, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x48E4A70", Offset = "0x48E3470", VA = "0x1848E4A70")]
		private static void NGDEIPFNLHC([In] TNode ABACLNNLPOO, Stack<TNode> BPECLBJBAPB, List<ELEDHAKNFCB<TNode>> BILNLGOIPDE, FMFJHKGFMPB JDKFBOCIIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x48DF0A0", Offset = "0x48DDAA0", VA = "0x1848DF0A0")]
		private static void CPJCPBILENC(Dictionary<LOOGPIJIHNJ<TNode>, TTerm> GPAGLACNMGO, List<ELEDHAKNFCB<TNode>> BILNLGOIPDE, FMFJHKGFMPB JDKFBOCIIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x48E03D0", Offset = "0x48DEDD0", VA = "0x1848E03D0")]
		private static Dictionary<TTerm, TType> EBGCOENBMEK(Dictionary<TTerm, TOutputSubstitution> FICBJHDHMEG, IEnumerable<KeyValuePair<TTerm, IDAGKCMOKGD<TType>>> JJMCEGFGHHP, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x48E4EE0", Offset = "0x48E38E0", VA = "0x1848E4EE0")]
		private static MAJJMDFECCC<TType> OONEOKOLLAL(TOutputTerm OHCGINPDMEI, Dictionary<TTerm, TType> JJMCEGFGHHP, Dictionary<TTerm, TType> DKMHABFADGP, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return default(MAJJMDFECCC<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x48DEF30", Offset = "0x48DD930", VA = "0x1848DEF30")]
		private static TOutputTerm BIEAIGLPIOL(TOutputTerm MFEIMAHCPPD, FMFJHKGFMPB JDKFBOCIIAB)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x345ED40", Offset = "0x345D740", VA = "0x18345ED40")]
	public static Dictionary<TNode, List<CGPILNCPJKO<TType>>> IIOGGMGOFKO<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::IGBJCDPCGHH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> IJPDNJELPLO, TRoot MHHKOMDGDID, TGraph FHMFCJGBAIP, IEnumerable<TNode> BGHPLOELKGN) where TDeps : global::MFGFINNBANN<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CGPILNCPJKO<TType> : IEquatable<CGPILNCPJKO<TType>>, MIOHJJIPPAJ<CGPILNCPJKO<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HFKDIDMKBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType DBMLPLJAEEI;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x47D72D0", Offset = "0x47D5CD0", VA = "0x1847D72D0")]
	internal CGPILNCPJKO(string EMLAIMJKHOE, [In] TType IPIEHOKFANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6574E90", Offset = "0x6573890", VA = "0x186574E90")]
	public bool NFIADALNOFP([In] CGPILNCPJKO<TType> OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6574DF0", Offset = "0x65737F0", VA = "0x186574DF0", Slot = "4")]
	public bool Equals(CGPILNCPJKO<TType> OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4CC9380", Offset = "0x4CC7D80", VA = "0x184CC9380", Slot = "0")]
	public override bool Equals(object OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x270C760", Offset = "0x270B160", VA = "0x18270C760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6574F70", Offset = "0x6573970", VA = "0x186574F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6574E40", Offset = "0x6573840", VA = "0x186574E40", Slot = "5")]
	private bool KGFCPOHKEIK([In] CGPILNCPJKO<TType> OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FPPHFCCFNPC
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3632BC0", Offset = "0x36315C0", VA = "0x183632BC0")]
	public static CGPILNCPJKO<TType> DDDHPONDPCL<TType>(string EMLAIMJKHOE, TType IPIEHOKFANE)
	{
		return default(CGPILNCPJKO<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3632BF0", Offset = "0x36315F0", VA = "0x183632BF0")]
	public static (string, TType) FIIFLPCCFLL<TType>([In] this CGPILNCPJKO<TType> IJPDNJELPLO)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct LOOGPIJIHNJ<TNode> : IEquatable<LOOGPIJIHNJ<TNode>>, MIOHJJIPPAJ<LOOGPIJIHNJ<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode MAABIJAHBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string HFKDIDMKBGI;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1581470", Offset = "0x157FE70", VA = "0x181581470")]
	internal LOOGPIJIHNJ(TNode ABACLNNLPOO, string EMLAIMJKHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFD80", Offset = "0x4EEE780", VA = "0x184EEFD80")]
	public bool NFIADALNOFP([In] LOOGPIJIHNJ<TNode> OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFCC0", Offset = "0x4EEE6C0", VA = "0x184EEFCC0", Slot = "4")]
	public bool Equals(LOOGPIJIHNJ<TNode> OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4CC9380", Offset = "0x4CC7D80", VA = "0x184CC9380", Slot = "0")]
	public override bool Equals(object OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFD10", Offset = "0x4EEE710", VA = "0x184EEFD10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4EF0020", Offset = "0x4EEEA20", VA = "0x184EF0020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4EEFF90", Offset = "0x4EEE990", VA = "0x184EEFF90", Slot = "5")]
	private bool OHDLHECFECD([In] LOOGPIJIHNJ<TNode> OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FIHKDHDABFO
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3623C10", Offset = "0x3622610", VA = "0x183623C10")]
	public static LOOGPIJIHNJ<TNode> DDDHPONDPCL<TNode>(TNode ABACLNNLPOO, string EMLAIMJKHOE)
	{
		return default(LOOGPIJIHNJ<TNode>);
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
