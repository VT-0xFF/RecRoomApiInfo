using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct MACPHHBGIHP<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType AJCKJIKGPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind FPDAKHNMENO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1A95FF0", Offset = "0x1A94BF0", VA = "0x181A95FF0")]
	internal MACPHHBGIHP(TType NCNNODEFPOG, IOKind GOMLDOMNALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x43E2A50", Offset = "0x43E1650", VA = "0x1843E2A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KMLHDHBDNJG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAF60", Offset = "0x2BD9B60", VA = "0x182BDAF60")]
	public static MACPHHBGIHP<TType> PPOPBMPFEOP<TType>(TType NCNNODEFPOG, IOKind GOMLDOMNALF)
	{
		return default(MACPHHBGIHP<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAF20", Offset = "0x2BD9B20", VA = "0x182BDAF20")]
	public static (TType, IOKind) DIPACOKBEHG<TType>([In] this MACPHHBGIHP<TType> HNFMOHFACKF)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2BDAEB0", Offset = "0x2BD9AB0", VA = "0x182BDAEB0")]
	public static void ALCMIDHBGAI<TType>([In] this MACPHHBGIHP<TType> HNFMOHFACKF, [Out] TType NCNNODEFPOG, [Out] IOKind GOMLDOMNALF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct NIHLCJBDJNH<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GBLAMKFDNLJ<TNode> LJGEDIMOCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GBLAMKFDNLJ<TNode> COALBGNLLKN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4495080", Offset = "0x4493C80", VA = "0x184495080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BALEGOMKBEI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x287EAC0", Offset = "0x287D6C0", VA = "0x18287EAC0")]
	public static (GBLAMKFDNLJ<TNode>, GBLAMKFDNLJ<TNode>) DIPACOKBEHG<TNode>([In] this NIHLCJBDJNH<TNode> HNFMOHFACKF)
	{
		return default((GBLAMKFDNLJ<TNode>, GBLAMKFDNLJ<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x287E9C0", Offset = "0x287D5C0", VA = "0x18287E9C0")]
	public static void ALCMIDHBGAI<TNode>([In] this NIHLCJBDJNH<TNode> HNFMOHFACKF, [Out] GBLAMKFDNLJ<TNode> HOGIDEMINCM, [Out] GBLAMKFDNLJ<TNode> FKJHDCOBNND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MBCCBEOLCHG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANAEOCDPBDB KLOBIAEABKO(TRoot BLPDMPJLPPJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType GFFKAGKAIAM(TRoot BLPDMPJLPPJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MACPHHBGIHP<TType> DPFFEKLCFDD(TRoot BLPDMPJLPPJ, [In] MACPHHBGIHP<TType> HLHDFJDLHFM, [In] MACPHHBGIHP<TType> GIHDHONABPM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DNIBJLOKOGM(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TNode LNFMEAPGAAK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MPNGIOHPLFD(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TNode LNFMEAPGAAK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput CJOFPHIEKKA(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TNode LNFMEAPGAAK, int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HLNHIBLEJDI(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TNode LNFMEAPGAAK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput GCHPKPPEDIP(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TNode LNFMEAPGAAK, int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<LDHPBIPDFDM<TType>> EEMCIAPJJFG(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TNode LNFMEAPGAAK);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<NIHLCJBDJNH<TNode>> JDPANIDMEEG(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TNode LNFMEAPGAAK);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType KJKHANPCPJO(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TInput HJNPKADFMMO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int ODCDLAJNBAF(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TInput HJNPKADFMMO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput HCFDGBMGOLE(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TInput HJNPKADFMMO, int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode FBLKMAECDGH(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TInput HJNPKADFMMO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType KLAMGFGJPFP(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TOutput JDJMAGMGKBH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int JGGAMEALDJI(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TOutput JDJMAGMGKBH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput HIHEHBIFNKC(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TOutput JDJMAGMGKBH, int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode ENDNLMHJOLE(TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, TOutput JDJMAGMGKBH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PKJLLFECBLM(TRoot BLPDMPJLPPJ, TType NCNNODEFPOG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType GEOLBHIGKKA(TRoot BLPDMPJLPPJ, TType NCNNODEFPOG, IEnumerable<TType> DIAPHLMIJJP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PGGLJGCBLNK(TRoot BLPDMPJLPPJ, TType NCNNODEFPOG, Action<TType> CGFPOBEKNGG, Action<TType> JBDIBLJBODE, Action<TType> PNNGJPAEHMH, Action<TType> OPJBKPPLDNH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType MOBGIEGAJJH(TRoot BLPDMPJLPPJ, TType NCNNODEFPOG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string BINMIPIGEMN(TRoot BLPDMPJLPPJ, TType NCNNODEFPOG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification FALAJOKKIEN(TRoot BLPDMPJLPPJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	GFFELLBKJIA<TOutputSubstitution[], DICIKJENGEG> BENOHKMDFIJ(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm FLADALKJBDO(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm BLJBCEMHLCP(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TTerm BJAOHGOKDKD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm APMEGAFHCBC(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TTerm FODGPLAKPJP, TTerm PJFHHDPNDJM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void MGIMNOMDNOH(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TTerm HLHDFJDLHFM, TTerm GIHDHONABPM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool PLMGBMGNKFA(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TOutputTerm LLPCHLDHIBD);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KDAPFHMGNMI(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TOutputTerm LLPCHLDHIBD);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm ALJKFCAPACC(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TOutputTerm LLPCHLDHIBD);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm NAALNFJMDJM(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TOutputTerm LLPCHLDHIBD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm ODNKCLIHLJH(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TOutputTerm LLPCHLDHIBD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm LCENINPJAFA(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TOutputSubstitution LOOFGFHMIIE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm MDIMLNEGBLD(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TOutputSubstitution LOOFGFHMIIE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm KJMJDPFHHPE(TRoot BLPDMPJLPPJ, TUnification HFBICNKNLLF, TTerm BJAOHGOKDKD);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct HIDLBDKPCAG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::MBCCBEOLCHG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10")]
	public static global::HIDLBDKPCAG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> PPOPBMPFEOP()
	{
		return default(global::HIDLBDKPCAG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class POHEIBDCFMH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class AJMMINMBJNO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::MBCCBEOLCHG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class HGALELFOAHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot MOHNEGNCIIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps GACCLNIIFAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification OKMLKGFIBCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph JGBCCLCCKPF;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public ANAEOCDPBDB ANPGFHCBLGA
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x3D37450", Offset = "0x3D36050", VA = "0x183D37450")]
				get
				{
					return default(ANAEOCDPBDB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3D37B40", Offset = "0x3D36740", VA = "0x183D37B40")]
			private HGALELFOAHO(TRoot BLPDMPJLPPJ, TDeps CFCALMONEJL, TUnification GIGKBMJJNLO, TGraph ENLPGHMPOPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3D37810", Offset = "0x3D36410", VA = "0x183D37810")]
			public static HGALELFOAHO PPOPBMPFEOP(TRoot BLPDMPJLPPJ, TDeps CFCALMONEJL, TUnification GIGKBMJJNLO, TGraph ENLPGHMPOPJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3D36340", Offset = "0x3D34F40", VA = "0x183D36340")]
			public TType GFFKAGKAIAM()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3D35BC0", Offset = "0x3D347C0", VA = "0x183D35BC0")]
			public MACPHHBGIHP<TType> DPFFEKLCFDD(MACPHHBGIHP<TType> HLHDFJDLHFM, MACPHHBGIHP<TType> GIHDHONABPM)
			{
				return default(MACPHHBGIHP<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3D359E0", Offset = "0x3D345E0", VA = "0x183D359E0")]
			public int DNIBJLOKOGM(TNode LNFMEAPGAAK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3D371E0", Offset = "0x3D35DE0", VA = "0x183D371E0")]
			public int MPNGIOHPLFD(TNode LNFMEAPGAAK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3D35880", Offset = "0x3D34480", VA = "0x183D35880")]
			public TInput CJOFPHIEKKA(TNode LNFMEAPGAAK, int OPDMGNJCACB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3D367E0", Offset = "0x3D353E0", VA = "0x183D367E0")]
			public int HLNHIBLEJDI(TNode LNFMEAPGAAK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3D36230", Offset = "0x3D34E30", VA = "0x183D36230")]
			public TOutput GCHPKPPEDIP(TNode LNFMEAPGAAK, int OPDMGNJCACB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3D35CE0", Offset = "0x3D348E0", VA = "0x183D35CE0")]
			public IEnumerable<LDHPBIPDFDM<TType>> EEMCIAPJJFG(TNode LNFMEAPGAAK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3D36820", Offset = "0x3D35420", VA = "0x183D36820")]
			public IEnumerable<NIHLCJBDJNH<TNode>> JDPANIDMEEG([In] TNode LNFMEAPGAAK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3D36AF0", Offset = "0x3D356F0", VA = "0x183D36AF0")]
			public TType KJKHANPCPJO(TInput HJNPKADFMMO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3D352F0", Offset = "0x3D33EF0", VA = "0x183D352F0")]
			public int AJHJBBOOIHG(TInput HJNPKADFMMO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3D364F0", Offset = "0x3D350F0", VA = "0x183D364F0")]
			public TOutput HCFDGBMGOLE(TInput HJNPKADFMMO, int OPDMGNJCACB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3D36010", Offset = "0x3D34C10", VA = "0x183D36010")]
			public TNode FBLKMAECDGH(TInput HJNPKADFMMO)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3D36CB0", Offset = "0x3D358B0", VA = "0x183D36CB0")]
			public TType KLAMGFGJPFP(TOutput JDJMAGMGKBH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3D35D20", Offset = "0x3D34920", VA = "0x183D35D20")]
			public int EEPKLAJBPKI(TOutput JDJMAGMGKBH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3D365C0", Offset = "0x3D351C0", VA = "0x183D365C0")]
			public TInput HIHEHBIFNKC(TOutput JDJMAGMGKBH, int OPDMGNJCACB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3D35E30", Offset = "0x3D34A30", VA = "0x183D35E30")]
			public TNode ENDNLMHJOLE(TOutput JDJMAGMGKBH)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3D37660", Offset = "0x3D36260", VA = "0x183D37660")]
			public bool PKJLLFECBLM(TType NCNNODEFPOG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3D36280", Offset = "0x3D34E80", VA = "0x183D36280")]
			public TType GEOLBHIGKKA(TType NCNNODEFPOG, IEnumerable<TType> DIAPHLMIJJP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3D374E0", Offset = "0x3D360E0", VA = "0x183D374E0")]
			public void PGGLJGCBLNK(TType NCNNODEFPOG, Action<TType> CGFPOBEKNGG, Action<TType> JBDIBLJBODE, Action<TType> PNNGJPAEHMH, Action<TType> OPJBKPPLDNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3D370E0", Offset = "0x3D35CE0", VA = "0x183D370E0")]
			public TType MOBGIEGAJJH(TType NCNNODEFPOG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3D356E0", Offset = "0x3D342E0", VA = "0x183D356E0")]
			public string BINMIPIGEMN(TType NCNNODEFPOG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3D36100", Offset = "0x3D34D00", VA = "0x183D36100")]
			public TTerm FLADALKJBDO()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3D357A0", Offset = "0x3D343A0", VA = "0x183D357A0")]
			public TTerm BLJBCEMHLCP(TTerm BJAOHGOKDKD)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D35380", Offset = "0x3D33F80", VA = "0x183D35380")]
			public TTerm APMEGAFHCBC(TTerm FODGPLAKPJP, TTerm PJFHHDPNDJM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3D36F00", Offset = "0x3D35B00", VA = "0x183D36F00")]
			public void MGIMNOMDNOH(TTerm HLHDFJDLHFM, TTerm GIHDHONABPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3D36960", Offset = "0x3D35560", VA = "0x183D36960")]
			public bool KDAPFHMGNMI(TOutputTerm BJAOHGOKDKD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3D37750", Offset = "0x3D36350", VA = "0x183D37750")]
			public bool PLMGBMGNKFA(TOutputTerm BJAOHGOKDKD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3D35590", Offset = "0x3D34190", VA = "0x183D35590")]
			public TTerm BEAJFKFHIBF(TOutputTerm LLPCHLDHIBD)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3D372E0", Offset = "0x3D35EE0", VA = "0x183D372E0")]
			public TOutputTerm NAALNFJMDJM(TOutputTerm BJAOHGOKDKD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3D37320", Offset = "0x3D35F20", VA = "0x183D37320")]
			public TOutputTerm ODNKCLIHLJH(TOutputTerm BJAOHGOKDKD)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3D36D40", Offset = "0x3D35940", VA = "0x183D36D40")]
			public TTerm LCENINPJAFA(TOutputSubstitution LNGCOMBAOHH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3D36E00", Offset = "0x3D35A00", VA = "0x183D36E00")]
			public TOutputTerm MDIMLNEGBLD(TOutputSubstitution LNGCOMBAOHH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3D36B70", Offset = "0x3D35770", VA = "0x183D36B70")]
			public TOutputTerm KJMJDPFHHPE(TTerm BJAOHGOKDKD)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BIDFIAINFAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public HGALELFOAHO arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public BIDFIAINFAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4E5C6F0", Offset = "0x4E5B2F0", VA = "0x184E5C6F0")]
			internal int LONKECGKMDI(HGALELFOAHO arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4E5C480", Offset = "0x4E5B080", VA = "0x184E5C480")]
			internal TInput IANGHLHHHNC(HGALELFOAHO arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4E5C540", Offset = "0x4E5B140", VA = "0x184E5C540")]
			internal int LAJBKKEAPOO(HGALELFOAHO arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4E5C5A0", Offset = "0x4E5B1A0", VA = "0x184E5C5A0")]
			internal TOutput LHHOMMCANBG(HGALELFOAHO arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JCKFFNFEJLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public HGALELFOAHO arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, GBLAMKFDNLJ<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<GBLAMKFDNLJ<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public JCKFFNFEJLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x40126C0", Offset = "0x40112C0", VA = "0x1840126C0")]
			internal (string, TTerm) ICMNJFGNOAL(LDHPBIPDFDM<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class MOGKDKHOPFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public HGALELFOAHO arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public MOGKDKHOPFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x44260E0", Offset = "0x4424CE0", VA = "0x1844260E0")]
			internal void OLJPBIGEKED(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x44259A0", Offset = "0x44245A0", VA = "0x1844259A0")]
			internal void FPAOPJEDECE(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4425590", Offset = "0x4424190", VA = "0x184425590")]
			internal void ECEGIKJFMMM(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4425DC0", Offset = "0x44249C0", VA = "0x184425DC0")]
			internal void IPDDFNKLHFH(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ICHFDEDHNCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HGALELFOAHO arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public ICHFDEDHNCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3C683A0", Offset = "0x3C66FA0", VA = "0x183C683A0")]
			internal TTerm LKCMHONOPPC(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA090", Offset = "0x3DD8C90", VA = "0x183DDA090")]
		private static NNGHJDCGFMF COHCJGKDELC([CallerMemberName] string GFLNGGKHEOH = "")
		{
			return default(NNGHJDCGFMF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6AD0", Offset = "0x3DD56D0", VA = "0x183DD6AD0")]
		public static Dictionary<TNode, List<LDHPBIPDFDM<TType>>> BAOIAPDNAEM(TRoot BLPDMPJLPPJ, TDeps CFCALMONEJL, TGraph ENLPGHMPOPJ, IEnumerable<TNode> FHFJPMCHFND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3DE6970", Offset = "0x3DE5570", VA = "0x183DE6970")]
		private static (Dictionary<TTerm, GBLAMKFDNLJ<TNode>>, List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>>) OJBIDBNFHIP(IEnumerable<TNode> FHFJPMCHFND, HGALELFOAHO KDGMEPEFEJC)
		{
			return default((Dictionary<TTerm, GBLAMKFDNLJ<TNode>>, List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3DE1980", Offset = "0x3DE0580", VA = "0x183DE1980")]
		private static void JEFHNANONLE(TNode LNFMEAPGAAK, Dictionary<TInput, TTerm> KONLMMAOPKN, Dictionary<TOutput, TTerm> OIJCBDFBJGA, Dictionary<TTerm, GBLAMKFDNLJ<TNode>> HOCCBIBBLOO, Dictionary<GBLAMKFDNLJ<TNode>, TTerm> LNNCEIBCKKI, List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> IFBGBHODFBM, Stack<TNode> DEMNPGKECHM, List<NIHLCJBDJNH<TNode>> COOAJECEKGE, HGALELFOAHO KDGMEPEFEJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDEA0", Offset = "0x3DDCAA0", VA = "0x183DDDEA0")]
		private static Dictionary<string, TTerm> GJMHOBMIKED(TNode LNFMEAPGAAK, Dictionary<TTerm, GBLAMKFDNLJ<TNode>> HOCCBIBBLOO, Dictionary<GBLAMKFDNLJ<TNode>, TTerm> PKNBOFFIFNF, List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> IFBGBHODFBM, HGALELFOAHO KDGMEPEFEJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x255B320", Offset = "0x2559F20", VA = "0x18255B320")]
		private static (TPort, TTerm)[] OCCLKNKIHIC<TPort>(TNode LNFMEAPGAAK, Func<HGALELFOAHO, TNode, int> CILEFEDLFMA, Func<HGALELFOAHO, TNode, int, TPort> GPJANEIBFIN, Func<HGALELFOAHO, TPort, TType> BGJAHMJMGMB, Dictionary<TPort, TTerm> DAKLPKJGGEC, HGALELFOAHO KDGMEPEFEJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7510", Offset = "0x3DE6110", VA = "0x183DE7510")]
		private static (TTerm, TTerm) PFPALGPJONA((TOutput Output, TTerm Id)[] NNNNICCNMLA, List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> IFBGBHODFBM, Dictionary<string, TTerm> PKNBOFFIFNF, Stack<TNode> DEMNPGKECHM, HGALELFOAHO KDGMEPEFEJC)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB2F0", Offset = "0x3DD9EF0", VA = "0x183DDB2F0")]
		private static void EIGLMCCOLFD((TInput PortKey, TTerm Id)[] GLDEEBPEGBP, TTerm LKMOAAHJAKF, TTerm NMJPNACIFPM, List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> IFBGBHODFBM, Dictionary<TOutput, TTerm> OIJCBDFBJGA, Dictionary<string, TTerm> PKNBOFFIFNF, Stack<TNode> DEMNPGKECHM, HGALELFOAHO KDGMEPEFEJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3DDED50", Offset = "0x3DDD950", VA = "0x183DDED50")]
		private static TTerm HDFINIOFFNM(TInput HJNPKADFMMO, List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> IFBGBHODFBM, Dictionary<TOutput, TTerm> OIJCBDFBJGA, Stack<TNode> DEMNPGKECHM, HGALELFOAHO KDGMEPEFEJC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2630", Offset = "0x3DE1230", VA = "0x183DE2630")]
		private static TTerm MPGIOFOOLGF([In] TType NCNNODEFPOG, IOKind GOMLDOMNALF, List<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> IFBGBHODFBM, IReadOnlyDictionary<string, TTerm> PKNBOFFIFNF, HGALELFOAHO KDGMEPEFEJC)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2C40", Offset = "0x3DE1840", VA = "0x183DE2C40")]
		private static Dictionary<TNode, List<LDHPBIPDFDM<TType>>> MPLDJGFFJNN(TOutputSubstitution[] PAEHHKDIJOH, Dictionary<TTerm, GBLAMKFDNLJ<TNode>> HOCCBIBBLOO, IEnumerable<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> IFBGBHODFBM, HGALELFOAHO KDGMEPEFEJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD9BE0", Offset = "0x3DD87E0", VA = "0x183DD9BE0")]
		private static Dictionary<TNode, List<LDHPBIPDFDM<TType>>> BPAJGOIDNKC(Dictionary<TTerm, GBLAMKFDNLJ<TNode>> HOCCBIBBLOO, HGALELFOAHO KDGMEPEFEJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3DDF2D0", Offset = "0x3DDDED0", VA = "0x183DDF2D0")]
		private static void INEBINOBFDP([In] TNode LNFMEAPGAAK, Stack<TNode> DEMNPGKECHM, List<NIHLCJBDJNH<TNode>> COOAJECEKGE, HGALELFOAHO KDGMEPEFEJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8870", Offset = "0x3DD7470", VA = "0x183DD8870")]
		private static void BIMGBNNNFLN(Dictionary<GBLAMKFDNLJ<TNode>, TTerm> PKNBOFFIFNF, List<NIHLCJBDJNH<TNode>> COOAJECEKGE, HGALELFOAHO KDGMEPEFEJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4BF0", Offset = "0x3DD37F0", VA = "0x183DD4BF0")]
		private static Dictionary<TTerm, TType> AGOJICOENDL(Dictionary<TTerm, TOutputSubstitution> PAEHHKDIJOH, IEnumerable<KeyValuePair<TTerm, MACPHHBGIHP<TType>>> IFBGBHODFBM, HGALELFOAHO KDGMEPEFEJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAA20", Offset = "0x3DD9620", VA = "0x183DDAA20")]
		private static IJOGPJMNLNP<TType> EGMBFOOLNPC(TOutputTerm NCNNODEFPOG, Dictionary<TTerm, TType> IFBGBHODFBM, Dictionary<TTerm, TType> EMPAPNNPHEJ, HGALELFOAHO KDGMEPEFEJC)
		{
			return default(IJOGPJMNLNP<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7D70", Offset = "0x3DD6970", VA = "0x183DD7D70")]
		private static TOutputTerm BDFFHFDPMFH(TOutputTerm FPFAACFGFKG, HGALELFOAHO KDGMEPEFEJC)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2CFAD40", Offset = "0x2CF9940", VA = "0x182CFAD40")]
	public static Dictionary<TNode, List<LDHPBIPDFDM<TType>>> BAOIAPDNAEM<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::HIDLBDKPCAG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> HNFMOHFACKF, TRoot BLPDMPJLPPJ, TGraph ENLPGHMPOPJ, IEnumerable<TNode> FHFJPMCHFND) where TDeps : global::MBCCBEOLCHG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct LDHPBIPDFDM<TType> : IEquatable<LDHPBIPDFDM<TType>>, AAKCPPDLFNK<LDHPBIPDFDM<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string JBJAOBKIEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType IPOJMNAMIID;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4078E20", Offset = "0x4077A20", VA = "0x184078E20")]
	internal LDHPBIPDFDM(string GFLNGGKHEOH, [In] TType MGBJPECNDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x41F2CE0", Offset = "0x41F18E0", VA = "0x1841F2CE0")]
	public bool JDBLILIAMFK([In] LDHPBIPDFDM<TType> OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x41F2C90", Offset = "0x41F1890", VA = "0x1841F2C90", Slot = "4")]
	public bool Equals(LDHPBIPDFDM<TType> OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3C706A0", Offset = "0x3C6F2A0", VA = "0x183C706A0", Slot = "0")]
	public override bool Equals(object OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FE64D0", Offset = "0x1FE50D0", VA = "0x181FE64D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x41F2DC0", Offset = "0x41F19C0", VA = "0x1841F2DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x41F2C40", Offset = "0x41F1840", VA = "0x1841F2C40", Slot = "5")]
	private bool AKGOGIOBCHK([In] LDHPBIPDFDM<TType> OCNJFCPHJLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HMAONMHDKBM
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2B20C00", Offset = "0x2B1F800", VA = "0x182B20C00")]
	public static LDHPBIPDFDM<TType> PPOPBMPFEOP<TType>(string GFLNGGKHEOH, TType MGBJPECNDGD)
	{
		return default(LDHPBIPDFDM<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2B20BC0", Offset = "0x2B1F7C0", VA = "0x182B20BC0")]
	public static (string, TType) DIPACOKBEHG<TType>([In] this LDHPBIPDFDM<TType> HNFMOHFACKF)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GBLAMKFDNLJ<TNode> : IEquatable<GBLAMKFDNLJ<TNode>>, AAKCPPDLFNK<GBLAMKFDNLJ<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode MAIIKAJJGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string JBJAOBKIEOM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xD86720", Offset = "0xD85320", VA = "0x180D86720")]
	internal GBLAMKFDNLJ(TNode LNFMEAPGAAK, string GFLNGGKHEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C70890", Offset = "0x3C6F490", VA = "0x183C70890")]
	public bool JDBLILIAMFK([In] GBLAMKFDNLJ<TNode> OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C70730", Offset = "0x3C6F330", VA = "0x183C70730", Slot = "4")]
	public bool Equals(GBLAMKFDNLJ<TNode> OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3C706A0", Offset = "0x3C6F2A0", VA = "0x183C706A0", Slot = "0")]
	public override bool Equals(object OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C70820", Offset = "0x3C6F420", VA = "0x183C70820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C70A90", Offset = "0x3C6F690", VA = "0x183C70A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3C707D0", Offset = "0x3C6F3D0", VA = "0x183C707D0", Slot = "5")]
	private bool GNKLLLCPLOH([In] GBLAMKFDNLJ<TNode> OCNJFCPHJLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NKKIIJGKONB
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA0F90", Offset = "0x2C9FB90", VA = "0x182CA0F90")]
	public static GBLAMKFDNLJ<TNode> PPOPBMPFEOP<TNode>(TNode LNFMEAPGAAK, string GFLNGGKHEOH)
	{
		return default(GBLAMKFDNLJ<TNode>);
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
