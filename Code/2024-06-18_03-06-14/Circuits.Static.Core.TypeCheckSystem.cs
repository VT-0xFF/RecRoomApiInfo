using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct JIGGJJDLLNA<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType PNFBJLDEHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind PEPGPMIJDIM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1AA4970", Offset = "0x1AA3370", VA = "0x181AA4970")]
	internal JIGGJJDLLNA(TType ADDOHDGDFOD, IOKind FPPEIGIJEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x40D78F0", Offset = "0x40D62F0", VA = "0x1840D78F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LKBFLHDCNCI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4180", Offset = "0x2BD2B80", VA = "0x182BD4180")]
	public static JIGGJJDLLNA<TType> KHKANEAPNIK<TType>(TType ADDOHDGDFOD, IOKind FPPEIGIJEHC)
	{
		return default(JIGGJJDLLNA<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2BD40D0", Offset = "0x2BD2AD0", VA = "0x182BD40D0")]
	public static (TType, IOKind) DELAFDGHFCE<TType>([In] this JIGGJJDLLNA<TType> BBCPNLGGBMJ)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4110", Offset = "0x2BD2B10", VA = "0x182BD4110")]
	public static void DNIPHOADCKN<TType>([In] this JIGGJJDLLNA<TType> BBCPNLGGBMJ, [Out] TType ADDOHDGDFOD, [Out] IOKind FPPEIGIJEHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct PFGJKJHPLCD<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly FKBAJDPEKMA<TNode> FNBMDMIKKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly FKBAJDPEKMA<TNode> GEIKGHFEKCO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x46C5F70", Offset = "0x46C4970", VA = "0x1846C5F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PHNNHEDPLAP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CF3210", Offset = "0x2CF1C10", VA = "0x182CF3210")]
	public static (FKBAJDPEKMA<TNode>, FKBAJDPEKMA<TNode>) DELAFDGHFCE<TNode>([In] this PFGJKJHPLCD<TNode> BBCPNLGGBMJ)
	{
		return default((FKBAJDPEKMA<TNode>, FKBAJDPEKMA<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2CF32B0", Offset = "0x2CF1CB0", VA = "0x182CF32B0")]
	public static void DNIPHOADCKN<TNode>([In] this PFGJKJHPLCD<TNode> BBCPNLGGBMJ, [Out] FKBAJDPEKMA<TNode> FKJLOGAHGLJ, [Out] FKBAJDPEKMA<TNode> MJMNBMLJKJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FBOOAAIOFCA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IBIDHJBCHDH BMIFEBBGBPN(TRoot GPKGNPPAAHE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType ICADAOACAGK(TRoot GPKGNPPAAHE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JIGGJJDLLNA<TType> HPNCMHFJFPA(TRoot GPKGNPPAAHE, [In] JIGGJJDLLNA<TType> NNEJNMNIIPM, [In] JIGGJJDLLNA<TType> MENCHHOFOIO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LNEFIIELCIH(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TNode CDPKDOCKGIC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AOBNNDPIJGN(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TNode CDPKDOCKGIC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput KGLGCNKNDON(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TNode CDPKDOCKGIC, int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KJLENPEFDCI(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TNode CDPKDOCKGIC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput OKPHABHPDLB(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TNode CDPKDOCKGIC, int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<LHJGJDLCJPP<TType>> MLCBALPMGKD(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TNode CDPKDOCKGIC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<PFGJKJHPLCD<TNode>> JNFKOGPJNIE(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TNode CDPKDOCKGIC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NNAIFPBOOLO(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TInput CGAJJAALELM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int JAKKKPEBHKC(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TInput CGAJJAALELM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput FGGCEKNFMEE(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TInput CGAJJAALELM, int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode GJBGCEEDKBC(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TInput CGAJJAALELM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType GGBOGDHMAIL(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TOutput HICKEIKKDJH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int GKLNPGHNMHH(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TOutput HICKEIKKDJH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput IPBOIKPACON(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TOutput HICKEIKKDJH, int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode FOJNOFAILAJ(TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, TOutput HICKEIKKDJH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MPHILGGFMNL(TRoot GPKGNPPAAHE, TType ADDOHDGDFOD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType IIJHEEFFILD(TRoot GPKGNPPAAHE, TType ADDOHDGDFOD, IEnumerable<TType> AEOBKFHKIGP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void OCEECCNNEMF(TRoot GPKGNPPAAHE, TType ADDOHDGDFOD, Action<TType> LNFOGIJPPMM, Action<TType> FKCHHHNJKDG, Action<TType> LKBGDEPKDKA, Action<TType> AEPFPLEEMGB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType IIOFHMDLEDM(TRoot GPKGNPPAAHE, TType ADDOHDGDFOD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string BHEFKBBGEHO(TRoot GPKGNPPAAHE, TType ADDOHDGDFOD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification EKIOKCHNAHC(TRoot GPKGNPPAAHE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	FNBKHJCMJJM<TOutputSubstitution[], DNHFHLFKGGH> MHCCKDNHBLM(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm NGPHIOKADLI(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm IFOBANEEDDP(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TTerm BBBBHPKGHFI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm BFKCFFCFACF(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TTerm CLIKFJHOANF, TTerm IAJKDACGMME);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OHNKGEGAFEK(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TTerm NNEJNMNIIPM, TTerm MENCHHOFOIO);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool BJBJFENBGGG(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TOutputTerm GJAIJKIMFKP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DLDMEPJIDMF(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TOutputTerm GJAIJKIMFKP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm HNOONCCFMEP(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TOutputTerm GJAIJKIMFKP);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm FHCGKBBAFMN(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TOutputTerm GJAIJKIMFKP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm LAOIACGDMOB(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TOutputTerm GJAIJKIMFKP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm IPOPJIEOPOD(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TOutputSubstitution MHPAENJFKAO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm COPLLFGBPNI(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TOutputSubstitution MHPAENJFKAO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm LEGFIPAFNPG(TRoot GPKGNPPAAHE, TUnification KGDIBDDKPHC, TTerm BBBBHPKGHFI);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PPMEGGAJMNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::FBOOAAIOFCA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
	public static global::PPMEGGAJMNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> KHKANEAPNIK()
	{
		return default(global::PPMEGGAJMNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JIOBKNLCJOD
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class PPMKAJINKMK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::FBOOAAIOFCA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class JLMMIJOLHCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot CMJBHOFLJPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps GKEFBNOFPEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification APLNDKGBJBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph FILGKBFAOFD;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public IBIDHJBCHDH NCJJLMDGJID
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x40F7D80", Offset = "0x40F6780", VA = "0x1840F7D80")]
				get
				{
					return default(IBIDHJBCHDH);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x40F9D50", Offset = "0x40F8750", VA = "0x1840F9D50")]
			private JLMMIJOLHCF(TRoot GPKGNPPAAHE, TDeps GMLBPALEECE, TUnification JFAKENLMNAN, TGraph PCJAPBCOFHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x40F8F90", Offset = "0x40F7990", VA = "0x1840F8F90")]
			public static JLMMIJOLHCF KHKANEAPNIK(TRoot GPKGNPPAAHE, TDeps GMLBPALEECE, TUnification JFAKENLMNAN, TGraph PCJAPBCOFHI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x40F8530", Offset = "0x40F6F30", VA = "0x1840F8530")]
			public TType ICADAOACAGK()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x40F83E0", Offset = "0x40F6DE0", VA = "0x1840F83E0")]
			public JIGGJJDLLNA<TType> HPNCMHFJFPA(JIGGJJDLLNA<TType> NNEJNMNIIPM, JIGGJJDLLNA<TType> MENCHHOFOIO)
			{
				return default(JIGGJJDLLNA<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x40F93A0", Offset = "0x40F7DA0", VA = "0x1840F93A0")]
			public int LNEFIIELCIH(TNode CDPKDOCKGIC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x40F73A0", Offset = "0x40F5DA0", VA = "0x1840F73A0")]
			public int AOBNNDPIJGN(TNode CDPKDOCKGIC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x40F8CC0", Offset = "0x40F76C0", VA = "0x1840F8CC0")]
			public TInput KGLGCNKNDON(TNode CDPKDOCKGIC, int ILOCEPPJPDO)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x40F9160", Offset = "0x40F7B60", VA = "0x1840F9160")]
			public int KJLENPEFDCI(TNode CDPKDOCKGIC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x40F9C80", Offset = "0x40F8680", VA = "0x1840F9C80")]
			public TOutput OKPHABHPDLB(TNode CDPKDOCKGIC, int ILOCEPPJPDO)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x40F94A0", Offset = "0x40F7EA0", VA = "0x1840F94A0")]
			public IEnumerable<LHJGJDLCJPP<TType>> MLCBALPMGKD(TNode CDPKDOCKGIC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x40F8BF0", Offset = "0x40F75F0", VA = "0x1840F8BF0")]
			public IEnumerable<PFGJKJHPLCD<TNode>> JNFKOGPJNIE([In] TNode CDPKDOCKGIC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x40F97A0", Offset = "0x40F81A0", VA = "0x1840F97A0")]
			public TType NNAIFPBOOLO(TInput CGAJJAALELM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x40F7A10", Offset = "0x40F6410", VA = "0x1840F7A10")]
			public int FBHMDDCGJKL(TInput CGAJJAALELM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x40F7BA0", Offset = "0x40F65A0", VA = "0x1840F7BA0")]
			public TOutput FGGCEKNFMEE(TInput CGAJJAALELM, int ILOCEPPJPDO)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x40F81F0", Offset = "0x40F6BF0", VA = "0x1840F81F0")]
			public TNode GJBGCEEDKBC(TInput CGAJJAALELM)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x40F8060", Offset = "0x40F6A60", VA = "0x1840F8060")]
			public TType GGBOGDHMAIL(TOutput HICKEIKKDJH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x40F7E40", Offset = "0x40F6840", VA = "0x1840F7E40")]
			public int FNMGHGGJKJG(TOutput HICKEIKKDJH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x40F8810", Offset = "0x40F7210", VA = "0x1840F8810")]
			public TInput IPBOIKPACON(TOutput HICKEIKKDJH, int ILOCEPPJPDO)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x40F7F50", Offset = "0x40F6950", VA = "0x1840F7F50")]
			public TNode FOJNOFAILAJ(TOutput HICKEIKKDJH)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x40F9670", Offset = "0x40F8070", VA = "0x1840F9670")]
			public bool MPHILGGFMNL(TType ADDOHDGDFOD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x40F86E0", Offset = "0x40F70E0", VA = "0x1840F86E0")]
			public TType IIJHEEFFILD(TType ADDOHDGDFOD, IEnumerable<TType> AEOBKFHKIGP)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x40F98B0", Offset = "0x40F82B0", VA = "0x1840F98B0")]
			public void OCEECCNNEMF(TType ADDOHDGDFOD, Action<TType> LNFOGIJPPMM, Action<TType> FKCHHHNJKDG, Action<TType> LKBGDEPKDKA, Action<TType> AEPFPLEEMGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x40F8720", Offset = "0x40F7120", VA = "0x1840F8720")]
			public TType IIOFHMDLEDM(TType ADDOHDGDFOD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x40F76D0", Offset = "0x40F60D0", VA = "0x1840F76D0")]
			public string BHEFKBBGEHO(TType ADDOHDGDFOD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x40F9760", Offset = "0x40F8160", VA = "0x1840F9760")]
			public TTerm NGPHIOKADLI()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x40F8620", Offset = "0x40F7020", VA = "0x1840F8620")]
			public TTerm IFOBANEEDDP(TTerm BBBBHPKGHFI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x40F7460", Offset = "0x40F5E60", VA = "0x1840F7460")]
			public TTerm BFKCFFCFACF(TTerm CLIKFJHOANF, TTerm IAJKDACGMME)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x40F9B10", Offset = "0x40F8510", VA = "0x1840F9B10")]
			public void OHNKGEGAFEK(TTerm NNEJNMNIIPM, TTerm MENCHHOFOIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x40F7910", Offset = "0x40F6310", VA = "0x1840F7910")]
			public bool DLDMEPJIDMF(TOutputTerm BBBBHPKGHFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x40F7750", Offset = "0x40F6150", VA = "0x1840F7750")]
			public bool BJBJFENBGGG(TOutputTerm BBBBHPKGHFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x40F8A30", Offset = "0x40F7430", VA = "0x1840F8A30")]
			public TTerm JJHMAEBBIDJ(TOutputTerm GJAIJKIMFKP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x40F7D40", Offset = "0x40F6740", VA = "0x1840F7D40")]
			public TOutputTerm FHCGKBBAFMN(TOutputTerm BBBBHPKGHFI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x40F9260", Offset = "0x40F7C60", VA = "0x1840F9260")]
			public TOutputTerm LAOIACGDMOB(TOutputTerm BBBBHPKGHFI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x40F8970", Offset = "0x40F7370", VA = "0x1840F8970")]
			public TTerm IPOPJIEOPOD(TOutputSubstitution NLKNDPNPKAP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x40F7850", Offset = "0x40F6250", VA = "0x1840F7850")]
			public TOutputTerm COPLLFGBPNI(TOutputSubstitution NLKNDPNPKAP)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x40F92A0", Offset = "0x40F7CA0", VA = "0x1840F92A0")]
			public TOutputTerm LEGFIPAFNPG(TTerm BBBBHPKGHFI)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class HEGCNFBHOEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public JLMMIJOLHCF arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public HEGCNFBHOEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3DB1550", Offset = "0x3DAFF50", VA = "0x183DB1550")]
			internal int GAMHKIHCBGC(JLMMIJOLHCF arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3DB14F0", Offset = "0x3DAFEF0", VA = "0x183DB14F0")]
			internal TInput DGEOEAGCIGG(JLMMIJOLHCF arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3DB17C0", Offset = "0x3DB01C0", VA = "0x183DB17C0")]
			internal int LHNBGCCLNHA(JLMMIJOLHCF arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3DB1680", Offset = "0x3DB0080", VA = "0x183DB1680")]
			internal TOutput HLFMKDBLPME(JLMMIJOLHCF arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ABBFBHFNDKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public JLMMIJOLHCF arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, FKBAJDPEKMA<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<FKBAJDPEKMA<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public ABBFBHFNDKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x3CB3C80", Offset = "0x3CB2680", VA = "0x183CB3C80")]
			internal (string, TTerm) CCENNAPJOKH(LHJGJDLCJPP<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class DPKJKNPIFHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JLMMIJOLHCF arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public DPKJKNPIFHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x57DB680", Offset = "0x57DA080", VA = "0x1857DB680")]
			internal void ANGBGHEJIDI(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x57DBBC0", Offset = "0x57DA5C0", VA = "0x1857DBBC0")]
			internal void HDDEABACLMO(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x57DC570", Offset = "0x57DAF70", VA = "0x1857DC570")]
			internal void MAKDEGAEHBA(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x57DC040", Offset = "0x57DAA40", VA = "0x1857DC040")]
			internal void IKNBCAADOBP(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class HIHMKLLKFDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JLMMIJOLHCF arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public HIHMKLLKFDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x383F3A0", Offset = "0x383DDA0", VA = "0x18383F3A0")]
			internal TTerm NCIBAKCKBKL(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4727CA0", Offset = "0x47266A0", VA = "0x184727CA0")]
		private static EFNLFAIIHGJ OACFMADGCFH([CallerMemberName] string CCMEKJGADHN = "")
		{
			return default(EFNLFAIIHGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4720F30", Offset = "0x471F930", VA = "0x184720F30")]
		public static Dictionary<TNode, List<LHJGJDLCJPP<TType>>> MAHEMKPAPON(TRoot GPKGNPPAAHE, TDeps GMLBPALEECE, TGraph PCJAPBCOFHI, IEnumerable<TNode> NHPJNECNFOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4721C50", Offset = "0x4720650", VA = "0x184721C50")]
		private static (Dictionary<TTerm, FKBAJDPEKMA<TNode>>, List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>>) NFABGINLMAE(IEnumerable<TNode> NHPJNECNFOH, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return default((Dictionary<TTerm, FKBAJDPEKMA<TNode>>, List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4713560", Offset = "0x4711F60", VA = "0x184713560")]
		private static void BEEPBPDNAKB(TNode CDPKDOCKGIC, Dictionary<TInput, TTerm> AADKJJNFDEF, Dictionary<TOutput, TTerm> LBBEJFNOHOA, Dictionary<TTerm, FKBAJDPEKMA<TNode>> FNABICFPOGO, Dictionary<FKBAJDPEKMA<TNode>, TTerm> KJPHOMIEMJI, List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> GOEEHLLAJAJ, Stack<TNode> AGDGCJALEIH, List<PFGJKJHPLCD<TNode>> GBPMCNELCKP, JLMMIJOLHCF PCNJMLOHDMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x471B630", Offset = "0x471A030", VA = "0x18471B630")]
		private static Dictionary<string, TTerm> ECKABNJLEBE(TNode CDPKDOCKGIC, Dictionary<TTerm, FKBAJDPEKMA<TNode>> FNABICFPOGO, Dictionary<FKBAJDPEKMA<TNode>, TTerm> PPJEKCKIJGJ, List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> GOEEHLLAJAJ, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2BA3660", Offset = "0x2BA2060", VA = "0x182BA3660")]
		private static (TPort, TTerm)[] FGBFJIOCHMM<TPort>(TNode CDPKDOCKGIC, Func<JLMMIJOLHCF, TNode, int> OBAFDBNDNIK, Func<JLMMIJOLHCF, TNode, int, TPort> BDCDEODCBHH, Func<JLMMIJOLHCF, TPort, TType> GOHDLLDJFJH, Dictionary<TPort, TTerm> GNEMEEIBLIL, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4718530", Offset = "0x4716F30", VA = "0x184718530")]
		private static (TTerm, TTerm) BHCMCPNGGFI((TOutput Output, TTerm Id)[] KPHKLBAABGC, List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> GOEEHLLAJAJ, Dictionary<string, TTerm> PPJEKCKIJGJ, Stack<TNode> AGDGCJALEIH, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4714EE0", Offset = "0x47138E0", VA = "0x184714EE0")]
		private static void BFEIFBBMCLO((TInput PortKey, TTerm Id)[] DCAOKMPCLKP, TTerm JALOBJNANCK, TTerm BJJBNNHOKIK, List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> GOEEHLLAJAJ, Dictionary<TOutput, TTerm> LBBEJFNOHOA, Dictionary<string, TTerm> PPJEKCKIJGJ, Stack<TNode> AGDGCJALEIH, JLMMIJOLHCF PCNJMLOHDMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x471CC90", Offset = "0x471B690", VA = "0x18471CC90")]
		private static TTerm GIMJMINBAEL(TInput CGAJJAALELM, List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> GOEEHLLAJAJ, Dictionary<TOutput, TTerm> LBBEJFNOHOA, Stack<TNode> AGDGCJALEIH, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4720350", Offset = "0x471ED50", VA = "0x184720350")]
		private static TTerm KCNHKFDFFKK([In] TType ADDOHDGDFOD, IOKind FPPEIGIJEHC, List<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> GOEEHLLAJAJ, IReadOnlyDictionary<string, TTerm> PPJEKCKIJGJ, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x471EA30", Offset = "0x471D430", VA = "0x18471EA30")]
		private static Dictionary<TNode, List<LHJGJDLCJPP<TType>>> HHNBHIOOHJO(TOutputSubstitution[] LFBGCHDCIDM, Dictionary<TTerm, FKBAJDPEKMA<TNode>> FNABICFPOGO, IEnumerable<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> GOEEHLLAJAJ, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4728680", Offset = "0x4727080", VA = "0x184728680")]
		private static Dictionary<TNode, List<LHJGJDLCJPP<TType>>> PBAGBGDIJLE(Dictionary<TTerm, FKBAJDPEKMA<TNode>> FNABICFPOGO, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x471BDC0", Offset = "0x471A7C0", VA = "0x18471BDC0")]
		private static void ECMKHLNJJIN([In] TNode CDPKDOCKGIC, Stack<TNode> AGDGCJALEIH, List<PFGJKJHPLCD<TNode>> GBPMCNELCKP, JLMMIJOLHCF PCNJMLOHDMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4724940", Offset = "0x4723340", VA = "0x184724940")]
		private static void NJPAHOHHGJC(Dictionary<FKBAJDPEKMA<TNode>, TTerm> PPJEKCKIJGJ, List<PFGJKJHPLCD<TNode>> GBPMCNELCKP, JLMMIJOLHCF PCNJMLOHDMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4726D00", Offset = "0x4725700", VA = "0x184726D00")]
		private static Dictionary<TTerm, TType> NKBJDHIJNNA(Dictionary<TTerm, TOutputSubstitution> LFBGCHDCIDM, IEnumerable<KeyValuePair<TTerm, JIGGJJDLLNA<TType>>> GOEEHLLAJAJ, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x471A150", Offset = "0x4718B50", VA = "0x18471A150")]
		private static ABMFALHKFKK<TType> BMAMMNBEMAG(TOutputTerm ADDOHDGDFOD, Dictionary<TTerm, TType> GOEEHLLAJAJ, Dictionary<TTerm, TType> ICBOJFKFPLA, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return default(ABMFALHKFKK<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x471C800", Offset = "0x471B200", VA = "0x18471C800")]
		private static TOutputTerm GILIIDCNPPK(TOutputTerm HGNDJEBMIMK, JLMMIJOLHCF PCNJMLOHDMH)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B740", Offset = "0x2B7A140", VA = "0x182B7B740")]
	public static Dictionary<TNode, List<LHJGJDLCJPP<TType>>> MAHEMKPAPON<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::PPMEGGAJMNG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> BBCPNLGGBMJ, TRoot GPKGNPPAAHE, TGraph PCJAPBCOFHI, IEnumerable<TNode> NHPJNECNFOH) where TDeps : global::FBOOAAIOFCA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct LHJGJDLCJPP<TType> : IEquatable<LHJGJDLCJPP<TType>>, FHPHFFGJALG<LHJGJDLCJPP<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string JGFOABOCNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType EJAJHEOEGDM;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4286E10", Offset = "0x4285810", VA = "0x184286E10")]
	internal LHJGJDLCJPP(string CCMEKJGADHN, [In] TType DABDBDEENPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4286F60", Offset = "0x4285960", VA = "0x184286F60")]
	public bool EBHDDKLMPJG([In] LHJGJDLCJPP<TType> HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4287040", Offset = "0x4285A40", VA = "0x184287040", Slot = "4")]
	public bool Equals(LHJGJDLCJPP<TType> HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3C24240", Offset = "0x3C22C40", VA = "0x183C24240", Slot = "0")]
	public override bool Equals(object HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1FFD650", Offset = "0x1FFC050", VA = "0x181FFD650", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4287090", Offset = "0x4285A90", VA = "0x184287090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4286F10", Offset = "0x4285910", VA = "0x184286F10", Slot = "5")]
	private bool CLEBGIPNPEJ([In] LHJGJDLCJPP<TType> HENLEJBGFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LPENJODBFDN
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2BE70E0", Offset = "0x2BE5AE0", VA = "0x182BE70E0")]
	public static LHJGJDLCJPP<TType> KHKANEAPNIK<TType>(string CCMEKJGADHN, TType DABDBDEENPC)
	{
		return default(LHJGJDLCJPP<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2BE70A0", Offset = "0x2BE5AA0", VA = "0x182BE70A0")]
	public static (string, TType) DELAFDGHFCE<TType>([In] this LHJGJDLCJPP<TType> BBCPNLGGBMJ)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct FKBAJDPEKMA<TNode> : IEquatable<FKBAJDPEKMA<TNode>>, FHPHFFGJALG<FKBAJDPEKMA<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode BBKLOAKHGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string JGFOABOCNPB;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xD90010", Offset = "0xD8EA10", VA = "0x180D90010")]
	internal FKBAJDPEKMA(TNode CDPKDOCKGIC, string CCMEKJGADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C24160", Offset = "0x3C22B60", VA = "0x183C24160")]
	public bool EBHDDKLMPJG([In] FKBAJDPEKMA<TNode> HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C24320", Offset = "0x3C22D20", VA = "0x183C24320", Slot = "4")]
	public bool Equals(FKBAJDPEKMA<TNode> HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3C24240", Offset = "0x3C22C40", VA = "0x183C24240", Slot = "0")]
	public override bool Equals(object HENLEJBGFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3C24370", Offset = "0x3C22D70", VA = "0x183C24370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C244C0", Offset = "0x3C22EC0", VA = "0x183C244C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3C243E0", Offset = "0x3C22DE0", VA = "0x183C243E0", Slot = "5")]
	private bool KMMFLLPJMKE([In] FKBAJDPEKMA<TNode> HENLEJBGFIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NOPJPCBABDL
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2C842B0", Offset = "0x2C82CB0", VA = "0x182C842B0")]
	public static FKBAJDPEKMA<TNode> KHKANEAPNIK<TNode>(TNode CDPKDOCKGIC, string CCMEKJGADHN)
	{
		return default(FKBAJDPEKMA<TNode>);
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
