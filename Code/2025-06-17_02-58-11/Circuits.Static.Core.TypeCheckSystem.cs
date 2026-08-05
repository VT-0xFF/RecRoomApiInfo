using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct HJCNDDMJNPA<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType GLEDFKBBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind PGLBFAKPJCP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xCA8340", Offset = "0xCA6D40", VA = "0x180CA8340")]
	internal HJCNDDMJNPA(TType HHCAOFMCNLG, IOKind DLAMOOAFKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4CFAB00", Offset = "0x4CF9500", VA = "0x184CFAB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BBCAOMGLHBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x37E8980", Offset = "0x37E7380", VA = "0x1837E8980")]
	public static HJCNDDMJNPA<TType> FMDOFBCLPJB<TType>(TType HHCAOFMCNLG, IOKind DLAMOOAFKFA)
	{
		return default(HJCNDDMJNPA<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x37E8940", Offset = "0x37E7340", VA = "0x1837E8940")]
	public static (TType, IOKind) BMEAMFJJIEJ<TType>([In] this HJCNDDMJNPA<TType> NMEFAPBBOCD)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37E88E0", Offset = "0x37E72E0", VA = "0x1837E88E0")]
	public static void AJIECABKDHF<TType>([In] this HJCNDDMJNPA<TType> NMEFAPBBOCD, [Out] TType HHCAOFMCNLG, [Out] IOKind DLAMOOAFKFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct NIBFKIFAJOB<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly FKDHCICMBMA<TNode> JLBHLKKKGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly FKDHCICMBMA<TNode> DGIBAGPKCME;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5505330", Offset = "0x5503D30", VA = "0x185505330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EHFILJPLLII
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x38F8700", Offset = "0x38F7100", VA = "0x1838F8700")]
	public static (FKDHCICMBMA<TNode>, FKDHCICMBMA<TNode>) BMEAMFJJIEJ<TNode>([In] this NIBFKIFAJOB<TNode> NMEFAPBBOCD)
	{
		return default((FKDHCICMBMA<TNode>, FKDHCICMBMA<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x38F8620", Offset = "0x38F7020", VA = "0x1838F8620")]
	public static void AJIECABKDHF<TNode>([In] this NIBFKIFAJOB<TNode> NMEFAPBBOCD, [Out] FKDHCICMBMA<TNode> OCPABDEGAMF, [Out] FKDHCICMBMA<TNode> MAMEIEKFKPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ONICDDPNHDF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ACLFKCACOOJ FDEECLKCBDG(TRoot ALPBGLGCPNB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType LOPGLGKNCAM(TRoot ALPBGLGCPNB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HJCNDDMJNPA<TType> HHGCKILNGBG(TRoot ALPBGLGCPNB, [In] HJCNDDMJNPA<TType> LCMCGCNDGLJ, [In] HJCNDDMJNPA<TType> JAOCPECLJLL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CAMFCKFKMPP(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TNode DGGBJNBEMBF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OOPOFPPCBFF(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TNode DGGBJNBEMBF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput BELJPNBNBMJ(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TNode DGGBJNBEMBF, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PPBAFNGCEHL(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TNode DGGBJNBEMBF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput DIJPBICJOLF(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TNode DGGBJNBEMBF, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<NKHNEDJFHPE<TType>> AFDNDBEBACP(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TNode DGGBJNBEMBF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<NIBFKIFAJOB<TNode>> MCKADILPFMD(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TNode DGGBJNBEMBF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType IFFHLMCLIOD(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TInput OKFHNJPHDOP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int KNMEOOBKEJE(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TInput OKFHNJPHDOP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput IBMFFJCBHHB(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TInput OKFHNJPHDOP, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode MGPOHBLCMCC(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TInput OKFHNJPHDOP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType DOGBFPCKBEN(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TOutput BJNAAIKBJGG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int JGCGOGNAKJF(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TOutput BJNAAIKBJGG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput FCPMKLINNFL(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TOutput BJNAAIKBJGG, int MNFHMLCLFEB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode LCKMPNKEKCC(TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, TOutput BJNAAIKBJGG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool AFOOEFMHMHP(TRoot ALPBGLGCPNB, TType HHCAOFMCNLG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType NNGEBAEPOBJ(TRoot ALPBGLGCPNB, TType HHCAOFMCNLG, IEnumerable<TType> LHHBBBHJMGH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JKKAOABGGJO(TRoot ALPBGLGCPNB, TType HHCAOFMCNLG, Action<TType> PBAFAOPJFCF, Action<TType> HEPBABFNNCM, Action<TType> ADCAGCCEMLC, Action<TType> JMPPKDAHJDC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType AFHPACNIMEA(TRoot ALPBGLGCPNB, TType HHCAOFMCNLG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string EBAGKINLDBD(TRoot ALPBGLGCPNB, TType HHCAOFMCNLG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification HHKCNINLCPB(TRoot ALPBGLGCPNB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	KAFLOHEKGBO<TOutputSubstitution[], GJIFJLKDAGC> BMGEMOPHKGI(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm IJDPGMHIBPE(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm LNJGOIKFIGB(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TTerm DLPLOIHJBOI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm DOEJCHLILAM(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TTerm PHBACDCOLMA, TTerm NNIEOPCEMIL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FIBJNDOOJKK(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TTerm LCMCGCNDGLJ, TTerm JAOCPECLJLL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool JDCLBKHBNHE(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TOutputTerm JIKNHKMCGKA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DGBEPIFAMJM(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TOutputTerm JIKNHKMCGKA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm BEHFDPFCNMG(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TOutputTerm JIKNHKMCGKA);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm NGFHLODAOBA(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TOutputTerm JIKNHKMCGKA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm FPHALNBIOBB(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TOutputTerm JIKNHKMCGKA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm KDLNMAPKCJO(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TOutputSubstitution AIDHKHLGNPO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm CDPKFNCBJMI(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TOutputSubstitution AIDHKHLGNPO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm BLGMJBPHNDB(TRoot ALPBGLGCPNB, TUnification DIOMCLHBDEP, TTerm DLPLOIHJBOI);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct AIOKJNDNMJG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::ONICDDPNHDF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
	public static global::AIOKJNDNMJG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> FMDOFBCLPJB()
	{
		return default(global::AIOKJNDNMJG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KIALLHIDJFB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class ELDJFNOCOAC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::ONICDDPNHDF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class KNKBEFMJPDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot PFOPMMBCMFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps ALNCCEFEFKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification AAGILJBAMNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph GEHPAFJMOHE;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public ACLFKCACOOJ NNABPIKCIII
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x51E3DD0", Offset = "0x51E27D0", VA = "0x1851E3DD0")]
				get
				{
					return default(ACLFKCACOOJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x51E60C0", Offset = "0x51E4AC0", VA = "0x1851E60C0")]
			private KNKBEFMJPDI(TRoot ALPBGLGCPNB, TDeps BFPFMKIIKBG, TUnification EJECCANADDK, TGraph MAHFLPOCDJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x51E49F0", Offset = "0x51E33F0", VA = "0x1851E49F0")]
			public static KNKBEFMJPDI FMDOFBCLPJB(TRoot ALPBGLGCPNB, TDeps BFPFMKIIKBG, TUnification EJECCANADDK, TGraph MAHFLPOCDJP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x51E5A40", Offset = "0x51E4440", VA = "0x1851E5A40")]
			public TType LOPGLGKNCAM()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x51E4CD0", Offset = "0x51E36D0", VA = "0x1851E4CD0")]
			public HJCNDDMJNPA<TType> HHGCKILNGBG(HJCNDDMJNPA<TType> LCMCGCNDGLJ, HJCNDDMJNPA<TType> JAOCPECLJLL)
			{
				return default(HJCNDDMJNPA<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x51E3C20", Offset = "0x51E2620", VA = "0x1851E3C20")]
			public int CAMFCKFKMPP(TNode DGGBJNBEMBF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x51E5E40", Offset = "0x51E4840", VA = "0x1851E5E40")]
			public int OOPOFPPCBFF(TNode DGGBJNBEMBF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x51E3A40", Offset = "0x51E2440", VA = "0x1851E3A40")]
			public TInput BELJPNBNBMJ(TNode DGGBJNBEMBF, int MNFHMLCLFEB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x51E5FC0", Offset = "0x51E49C0", VA = "0x1851E5FC0")]
			public int PPBAFNGCEHL(TNode DGGBJNBEMBF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x51E41E0", Offset = "0x51E2BE0", VA = "0x1851E41E0")]
			public TOutput DIJPBICJOLF(TNode DGGBJNBEMBF, int MNFHMLCLFEB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x51E3800", Offset = "0x51E2200", VA = "0x1851E3800")]
			public IEnumerable<NKHNEDJFHPE<TType>> AFDNDBEBACP(TNode DGGBJNBEMBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x51E5AB0", Offset = "0x51E44B0", VA = "0x1851E5AB0")]
			public IEnumerable<NIBFKIFAJOB<TNode>> MCKADILPFMD([In] TNode DGGBJNBEMBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x51E50C0", Offset = "0x51E3AC0", VA = "0x1851E50C0")]
			public TType IFFHLMCLIOD(TInput OKFHNJPHDOP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x51E54D0", Offset = "0x51E3ED0", VA = "0x1851E54D0")]
			public int JELBIGMEDFN(TInput OKFHNJPHDOP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x51E4FA0", Offset = "0x51E39A0", VA = "0x1851E4FA0")]
			public TOutput IBMFFJCBHHB(TInput OKFHNJPHDOP, int MNFHMLCLFEB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x51E5BC0", Offset = "0x51E45C0", VA = "0x1851E5BC0")]
			public TNode MGPOHBLCMCC(TInput OKFHNJPHDOP)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x51E43D0", Offset = "0x51E2DD0", VA = "0x1851E43D0")]
			public TType DOGBFPCKBEN(TOutput BJNAAIKBJGG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x51E5370", Offset = "0x51E3D70", VA = "0x1851E5370")]
			public int JEIHCBKNDLI(TOutput BJNAAIKBJGG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x51E46C0", Offset = "0x51E30C0", VA = "0x1851E46C0")]
			public TInput FCPMKLINNFL(TOutput BJNAAIKBJGG, int MNFHMLCLFEB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x51E5810", Offset = "0x51E4210", VA = "0x1851E5810")]
			public TNode LCKMPNKEKCC(TOutput BJNAAIKBJGG)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x51E3930", Offset = "0x51E2330", VA = "0x1851E3930")]
			public bool AFOOEFMHMHP(TType HHCAOFMCNLG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x51E5E00", Offset = "0x51E4800", VA = "0x1851E5E00")]
			public TType NNGEBAEPOBJ(TType HHCAOFMCNLG, IEnumerable<TType> LHHBBBHJMGH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x51E5620", Offset = "0x51E4020", VA = "0x1851E5620")]
			public void JKKAOABGGJO(TType HHCAOFMCNLG, Action<TType> PBAFAOPJFCF, Action<TType> HEPBABFNNCM, Action<TType> ADCAGCCEMLC, Action<TType> JMPPKDAHJDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x51E3840", Offset = "0x51E2240", VA = "0x1851E3840")]
			public TType AFHPACNIMEA(TType HHCAOFMCNLG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x51E45B0", Offset = "0x51E2FB0", VA = "0x1851E45B0")]
			public string EBAGKINLDBD(TType HHCAOFMCNLG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x51E51B0", Offset = "0x51E3BB0", VA = "0x1851E51B0")]
			public TTerm IJDPGMHIBPE()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x51E5890", Offset = "0x51E4290", VA = "0x1851E5890")]
			public TTerm LNJGOIKFIGB(TTerm DLPLOIHJBOI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x51E4380", Offset = "0x51E2D80", VA = "0x1851E4380")]
			public TTerm DOEJCHLILAM(TTerm PHBACDCOLMA, TTerm NNIEOPCEMIL)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x51E4790", Offset = "0x51E3190", VA = "0x1851E4790")]
			public void FIBJNDOOJKK(TTerm LCMCGCNDGLJ, TTerm JAOCPECLJLL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x51E40B0", Offset = "0x51E2AB0", VA = "0x1851E40B0")]
			public bool DGBEPIFAMJM(TOutputTerm DLPLOIHJBOI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x51E52B0", Offset = "0x51E3CB0", VA = "0x1851E52B0")]
			public bool JDCLBKHBNHE(TOutputTerm DLPLOIHJBOI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x51E3EF0", Offset = "0x51E28F0", VA = "0x1851E3EF0")]
			public TTerm DFDBHNBBODM(TOutputTerm JIKNHKMCGKA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x51E5D00", Offset = "0x51E4700", VA = "0x1851E5D00")]
			public TOutputTerm NGFHLODAOBA(TOutputTerm DLPLOIHJBOI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x51E4C10", Offset = "0x51E3610", VA = "0x1851E4C10")]
			public TOutputTerm FPHALNBIOBB(TOutputTerm DLPLOIHJBOI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x51E5700", Offset = "0x51E4100", VA = "0x1851E5700")]
			public TTerm KDLNMAPKCJO(TOutputSubstitution CINEJBDEKKN)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x51E3E30", Offset = "0x51E2830", VA = "0x1851E3E30")]
			public TOutputTerm CDPKFNCBJMI(TOutputSubstitution CINEJBDEKKN)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x51E3BA0", Offset = "0x51E25A0", VA = "0x1851E3BA0")]
			public TOutputTerm BLGMJBPHNDB(TTerm DLPLOIHJBOI)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class DFGOCHHCOCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public KNKBEFMJPDI arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public DFGOCHHCOCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6AED050", Offset = "0x6AEBA50", VA = "0x186AED050")]
			internal int FCIKAFJCNAK(KNKBEFMJPDI arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6AED000", Offset = "0x6AEBA00", VA = "0x186AED000")]
			internal TInput DKLBJBBHEAK(KNKBEFMJPDI arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6AED0D0", Offset = "0x6AEBAD0", VA = "0x186AED0D0")]
			internal int JMANNJDDCND(KNKBEFMJPDI arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6AECE10", Offset = "0x6AEB810", VA = "0x186AECE10")]
			internal TOutput DJMBGEACFNP(KNKBEFMJPDI arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NFLIJNCEEFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public KNKBEFMJPDI arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, FKDHCICMBMA<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<FKDHCICMBMA<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public NFLIJNCEEFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x55008E0", Offset = "0x54FF2E0", VA = "0x1855008E0")]
			internal (string, TTerm) FKNMEDLPLKA(NKHNEDJFHPE<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class LBJCFACMPHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public KNKBEFMJPDI arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public LBJCFACMPHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x52743B0", Offset = "0x5272DB0", VA = "0x1852743B0")]
			internal void JLBEHEOIFHL(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5273E00", Offset = "0x5272800", VA = "0x185273E00")]
			internal void JIKMLEPNJHM(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5274760", Offset = "0x5273160", VA = "0x185274760")]
			internal void MIGDFBPAONE(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5273CE0", Offset = "0x52726E0", VA = "0x185273CE0")]
			internal void BIMHCKBIHHN(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class CLPNEPCEGMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public KNKBEFMJPDI arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public CLPNEPCEGMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4F71910", Offset = "0x4F70310", VA = "0x184F71910")]
			internal TTerm EELGEINPJAA(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x46A54E0", Offset = "0x46A3EE0", VA = "0x1846A54E0")]
		private static IAOCAOHODDC GNAECLAFCEL([CallerMemberName] string GBCFHNGPBLM = "")
		{
			return default(IAOCAOHODDC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x46A9FC0", Offset = "0x46A89C0", VA = "0x1846A9FC0")]
		public static Dictionary<TNode, List<NKHNEDJFHPE<TType>>> NMLNLOPNECP(TRoot ALPBGLGCPNB, TDeps BFPFMKIIKBG, TGraph MAHFLPOCDJP, IEnumerable<TNode> NGNPGCEONBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46A4AC0", Offset = "0x46A34C0", VA = "0x1846A4AC0")]
		private static (Dictionary<TTerm, FKDHCICMBMA<TNode>>, List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>>) FGLCGDEMMGO(IEnumerable<TNode> NGNPGCEONBL, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return default((Dictionary<TTerm, FKDHCICMBMA<TNode>>, List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x46AB5A0", Offset = "0x46A9FA0", VA = "0x1846AB5A0")]
		private static void OKOBIIMIIKI(TNode DGGBJNBEMBF, Dictionary<TInput, TTerm> MNEEGBNNEGP, Dictionary<TOutput, TTerm> HLENLMCHEBL, Dictionary<TTerm, FKDHCICMBMA<TNode>> CKADMJPLELA, Dictionary<FKDHCICMBMA<TNode>, TTerm> FBCNLPJMMMP, List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> NNHFGHNNGAF, Stack<TNode> JOLPIPEADNN, List<NIBFKIFAJOB<TNode>> NNIOPLIPMPB, KNKBEFMJPDI EFPDHJCEEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x46A8960", Offset = "0x46A7360", VA = "0x1846A8960")]
		private static Dictionary<string, TTerm> IPIBCIPOBBK(TNode DGGBJNBEMBF, Dictionary<TTerm, FKDHCICMBMA<TNode>> CKADMJPLELA, Dictionary<FKDHCICMBMA<TNode>, TTerm> JHCEAMGHDLL, List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> NNHFGHNNGAF, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE9E0", Offset = "0x3ECD3E0", VA = "0x183ECE9E0")]
		private static (TPort, TTerm)[] AGJMHBHKFIN<TPort>(TNode DGGBJNBEMBF, Func<KNKBEFMJPDI, TNode, int> FODPCMBGFHC, Func<KNKBEFMJPDI, TNode, int, TPort> IABJNPNMCKJ, Func<KNKBEFMJPDI, TPort, TType> CHHLEMIOMHK, Dictionary<TPort, TTerm> BEIPCLKIPNP, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x46A12A0", Offset = "0x469FCA0", VA = "0x1846A12A0")]
		private static (TTerm, TTerm) CFHMMJKLIDH((TOutput Output, TTerm Id)[] AMFGNJDNAFN, List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> NNHFGHNNGAF, Dictionary<string, TTerm> JHCEAMGHDLL, Stack<TNode> JOLPIPEADNN, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x46AF890", Offset = "0x46AE290", VA = "0x1846AF890")]
		private static void PJFAMDJFABD((TInput PortKey, TTerm Id)[] JKIFDDIDEJI, TTerm AOFCGKHNGDJ, TTerm ABILCKFLIPB, List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> NNHFGHNNGAF, Dictionary<TOutput, TTerm> HLENLMCHEBL, Dictionary<string, TTerm> JHCEAMGHDLL, Stack<TNode> JOLPIPEADNN, KNKBEFMJPDI EFPDHJCEEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x46AD640", Offset = "0x46AC040", VA = "0x1846AD640")]
		private static TTerm OODDKGOOOAL(TInput OKFHNJPHDOP, List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> NNHFGHNNGAF, Dictionary<TOutput, TTerm> HLENLMCHEBL, Stack<TNode> JOLPIPEADNN, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x46A8100", Offset = "0x46A6B00", VA = "0x1846A8100")]
		private static TTerm IOHLLDOPGBG([In] TType HHCAOFMCNLG, IOKind DLAMOOAFKFA, List<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> NNHFGHNNGAF, IReadOnlyDictionary<string, TTerm> JHCEAMGHDLL, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x46B0F50", Offset = "0x46AF950", VA = "0x1846B0F50")]
		private static Dictionary<TNode, List<NKHNEDJFHPE<TType>>> PPOJICEDIJG(TOutputSubstitution[] EJFKGAOIMMP, Dictionary<TTerm, FKDHCICMBMA<TNode>> CKADMJPLELA, IEnumerable<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> NNHFGHNNGAF, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x46A9090", Offset = "0x46A7A90", VA = "0x1846A9090")]
		private static Dictionary<TNode, List<NKHNEDJFHPE<TType>>> NDDKJLELFGM(Dictionary<TTerm, FKDHCICMBMA<TNode>> CKADMJPLELA, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x469E9E0", Offset = "0x469D3E0", VA = "0x18469E9E0")]
		private static void BDBMEOAKLHB([In] TNode DGGBJNBEMBF, Stack<TNode> JOLPIPEADNN, List<NIBFKIFAJOB<TNode>> NNIOPLIPMPB, KNKBEFMJPDI EFPDHJCEEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x46A0980", Offset = "0x469F380", VA = "0x1846A0980")]
		private static void CCBLODPCOEK(Dictionary<FKDHCICMBMA<TNode>, TTerm> JHCEAMGHDLL, List<NIBFKIFAJOB<TNode>> NNIOPLIPMPB, KNKBEFMJPDI EFPDHJCEEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x46A7290", Offset = "0x46A5C90", VA = "0x1846A7290")]
		private static Dictionary<TTerm, TType> HJONCFBBBNM(Dictionary<TTerm, TOutputSubstitution> EJFKGAOIMMP, IEnumerable<KeyValuePair<TTerm, HJCNDDMJNPA<TType>>> NNHFGHNNGAF, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x469FD80", Offset = "0x469E780", VA = "0x18469FD80")]
		private static ADEFLNKAAIF<TType> BDLPCDBBGKF(TOutputTerm HHCAOFMCNLG, Dictionary<TTerm, TType> NNHFGHNNGAF, Dictionary<TTerm, TType> DIAPHCLLMBP, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return default(ADEFLNKAAIF<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x46ADC60", Offset = "0x46AC660", VA = "0x1846ADC60")]
		private static TOutputTerm PIBKILGCMGM(TOutputTerm EIEECHKNFHN, KNKBEFMJPDI EFPDHJCEEGP)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3B09420", Offset = "0x3B07E20", VA = "0x183B09420")]
	public static Dictionary<TNode, List<NKHNEDJFHPE<TType>>> NMLNLOPNECP<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::AIOKJNDNMJG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> NMEFAPBBOCD, TRoot ALPBGLGCPNB, TGraph MAHFLPOCDJP, IEnumerable<TNode> NGNPGCEONBL) where TDeps : global::ONICDDPNHDF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct NKHNEDJFHPE<TType> : IEquatable<NKHNEDJFHPE<TType>>, FFDBOPCMCDN<NKHNEDJFHPE<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HMKINKIIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType CNGDOLIEGFJ;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5517220", Offset = "0x5515C20", VA = "0x185517220")]
	internal NKHNEDJFHPE(string GBCFHNGPBLM, [In] TType KLEDIIKELGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5517110", Offset = "0x5515B10", VA = "0x185517110")]
	public bool MMLILOGHCPE([In] NKHNEDJFHPE<TType> NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5517070", Offset = "0x5515A70", VA = "0x185517070", Slot = "4")]
	public bool Equals(NKHNEDJFHPE<TType> NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4B4DCE0", Offset = "0x4B4C6E0", VA = "0x184B4DCE0", Slot = "0")]
	public override bool Equals(object NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4B4DDB0", Offset = "0x4B4C7B0", VA = "0x184B4DDB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x55171E0", Offset = "0x5515BE0", VA = "0x1855171E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x55170C0", Offset = "0x5515AC0", VA = "0x1855170C0", Slot = "5")]
	private bool JCOFMIKKCFG([In] NKHNEDJFHPE<TType> NDNHELJMDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ILEGFDMJAMA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8CD0", Offset = "0x3AA76D0", VA = "0x183AA8CD0")]
	public static NKHNEDJFHPE<TType> FMDOFBCLPJB<TType>(string GBCFHNGPBLM, TType KLEDIIKELGP)
	{
		return default(NKHNEDJFHPE<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8C90", Offset = "0x3AA7690", VA = "0x183AA8C90")]
	public static (string, TType) BMEAMFJJIEJ<TType>([In] this NKHNEDJFHPE<TType> NMEFAPBBOCD)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct FKDHCICMBMA<TNode> : IEquatable<FKDHCICMBMA<TNode>>, FFDBOPCMCDN<FKDHCICMBMA<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode OOMFPOIGAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string HMKINKIIOPK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x17A0610", Offset = "0x179F010", VA = "0x1817A0610")]
	internal FKDHCICMBMA(TNode DGGBJNBEMBF, string GBCFHNGPBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4B4DE80", Offset = "0x4B4C880", VA = "0x184B4DE80")]
	public bool MMLILOGHCPE([In] FKDHCICMBMA<TNode> NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4B4DC90", Offset = "0x4B4C690", VA = "0x184B4DC90", Slot = "4")]
	public bool Equals(FKDHCICMBMA<TNode> NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4B4DCE0", Offset = "0x4B4C6E0", VA = "0x184B4DCE0", Slot = "0")]
	public override bool Equals(object NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4B4DE10", Offset = "0x4B4C810", VA = "0x184B4DE10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4B4E100", Offset = "0x4B4CB00", VA = "0x184B4E100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4B4E020", Offset = "0x4B4CA20", VA = "0x184B4E020", Slot = "5")]
	private bool POIGBKCBIBI([In] FKDHCICMBMA<TNode> NDNHELJMDCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GILONFIEMHD
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A6C0E0", Offset = "0x3A6AAE0", VA = "0x183A6C0E0")]
	public static FKDHCICMBMA<TNode> FMDOFBCLPJB<TNode>(TNode DGGBJNBEMBF, string GBCFHNGPBLM)
	{
		return default(FKDHCICMBMA<TNode>);
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
