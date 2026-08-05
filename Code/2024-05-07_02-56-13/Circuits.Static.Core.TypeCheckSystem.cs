using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct KCHBHGMLJEI<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType DIOCHMJOOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind BPNCIKBBNIC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1902280", Offset = "0x1901480", VA = "0x181902280")]
	internal KCHBHGMLJEI(TType FLPJMDMACMC, IOKind IGPJCOJJFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C699C0", Offset = "0x3C68BC0", VA = "0x183C699C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KKIIDHEJMCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x297ADE0", Offset = "0x2979FE0", VA = "0x18297ADE0")]
	public static KCHBHGMLJEI<TType> MIJABIECKKD<TType>(TType FLPJMDMACMC, IOKind IGPJCOJJFOJ)
	{
		return default(KCHBHGMLJEI<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x297ADA0", Offset = "0x2979FA0", VA = "0x18297ADA0")]
	public static (TType, IOKind) LOGPIIKPOON<TType>([In] this KCHBHGMLJEI<TType> KNKOEEEKHDK)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x297AE10", Offset = "0x297A010", VA = "0x18297AE10")]
	public static void NAEOOGIIDLH<TType>([In] this KCHBHGMLJEI<TType> KNKOEEEKHDK, [Out] TType FLPJMDMACMC, [Out] IOKind IGPJCOJJFOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct CABGGJNEBIN<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly EFJHBGHKJBB<TNode> FHAHPHDGKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly EFJHBGHKJBB<TNode> OMBNPILNBEE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A140", Offset = "0x4A79340", VA = "0x184A7A140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EPIOJMALNBB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2782DA0", Offset = "0x2781FA0", VA = "0x182782DA0")]
	public static (EFJHBGHKJBB<TNode>, EFJHBGHKJBB<TNode>) LOGPIIKPOON<TNode>([In] this CABGGJNEBIN<TNode> KNKOEEEKHDK)
	{
		return default((EFJHBGHKJBB<TNode>, EFJHBGHKJBB<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2782E40", Offset = "0x2782040", VA = "0x182782E40")]
	public static void NAEOOGIIDLH<TNode>([In] this CABGGJNEBIN<TNode> KNKOEEEKHDK, [Out] EFJHBGHKJBB<TNode> EBKLEGBLPGD, [Out] EFJHBGHKJBB<TNode> JCPNHMOLDGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OAIMMFJAJLH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IHMHECJDOHM JMENBLLHKFF(TRoot MIAAKEAGJGI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType IJNOFLIJGJF(TRoot MIAAKEAGJGI);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KCHBHGMLJEI<TType> KJEGDHGJOAP(TRoot MIAAKEAGJGI, [In] KCHBHGMLJEI<TType> EFLJLNCMHDD, [In] KCHBHGMLJEI<TType> DJDKOLONKNI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int CMBIPGJCKNI(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TNode CLKPBALPCKM);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DMMGEOMECDF(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TNode CLKPBALPCKM);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput KBGBBILBOLI(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TNode CLKPBALPCKM, int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HDILAIFBPDH(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TNode CLKPBALPCKM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput LEKHKFJBMCL(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TNode CLKPBALPCKM, int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<IIPKCLFDCEK<TType>> NDIDLPBEBBI(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TNode CLKPBALPCKM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<CABGGJNEBIN<TNode>> CMJAFFHHNBE(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TNode CLKPBALPCKM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType CHIGBAACPCG(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TInput CCAOJBHBKKC);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int DCLDGLAJIJL(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TInput CCAOJBHBKKC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput PKOHIPEJMKE(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TInput CCAOJBHBKKC, int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode HJBBLIJIFNM(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TInput CCAOJBHBKKC);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType LJKGGJINNGG(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TOutput JOANOPHIHDM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int EPPJLMKMABA(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TOutput JOANOPHIHDM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput ENBDNLEICLC(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TOutput JOANOPHIHDM, int HMFNCGHECPG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode BJLKHJHILJP(TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, TOutput JOANOPHIHDM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool DDEHNCGGPJI(TRoot MIAAKEAGJGI, TType FLPJMDMACMC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType CCOENBMCMOF(TRoot MIAAKEAGJGI, TType FLPJMDMACMC, IEnumerable<TType> BFAJCNFAOON);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KLMAGIKLCAA(TRoot MIAAKEAGJGI, TType FLPJMDMACMC, Action<TType> IJOPHEAJKLE, Action<TType> HKLBIBOEDGP, Action<TType> BMBCKINEDFF, Action<TType> JOKLMMDNNPK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType HJHPEKIEFBO(TRoot MIAAKEAGJGI, TType FLPJMDMACMC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string GNKHKIPHDLN(TRoot MIAAKEAGJGI, TType FLPJMDMACMC);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification MLHAKJMAPOD(TRoot MIAAKEAGJGI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NFMFLMAOFMP<TOutputSubstitution[], OMPNGPMCKPG> PECDIKADGPG(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm GBACLMFKJEC(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm PFJHJENGOHP(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TTerm GNFAPCHBCGI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm KPHIIHMCLAM(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TTerm AGNBNOOMFNG, TTerm LKEJHNGNLDG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DAHHELGCNNE(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TTerm EFLJLNCMHDD, TTerm DJDKOLONKNI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool JDDDHJKMEDM(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TOutputTerm KCOIAIOCPBI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KKFGBMEIJEJ(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TOutputTerm KCOIAIOCPBI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm FIIMBDMMDCK(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TOutputTerm KCOIAIOCPBI);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm HEHIFNLAIKB(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TOutputTerm KCOIAIOCPBI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm CPCGIIJJDBI(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TOutputTerm KCOIAIOCPBI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm CPKOKJLDPFC(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TOutputSubstitution GLBAMPKGBNN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm OHAKMEGCONJ(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TOutputSubstitution GLBAMPKGBNN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm COGCNAOGMCP(TRoot MIAAKEAGJGI, TUnification ALIOKONNCEI, TTerm GNFAPCHBCGI);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct GFEKAMNKBAA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::OAIMMFJAJLH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130")]
	public static global::GFEKAMNKBAA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> MIJABIECKKD()
	{
		return default(global::GFEKAMNKBAA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class IAKEFMEFGBK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class LLPDEDHLGJK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::OAIMMFJAJLH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class NGCLIEBBPFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot AKJHKAMODFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps GKFJOCMLIHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification OMCPLGKDLOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph FHICHHKNBBK;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public IHMHECJDOHM HKDAAAEIKNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4037410", Offset = "0x4036610", VA = "0x184037410")]
				get
				{
					return default(IHMHECJDOHM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4038960", Offset = "0x4037B60", VA = "0x184038960")]
			private NGCLIEBBPFK(TRoot MIAAKEAGJGI, TDeps NMAKCOKENKA, TUnification AHPADLHNBBO, TGraph PPIENIHGEEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x40382E0", Offset = "0x40374E0", VA = "0x1840382E0")]
			public static NGCLIEBBPFK MIJABIECKKD(TRoot MIAAKEAGJGI, TDeps NMAKCOKENKA, TUnification AHPADLHNBBO, TGraph PPIENIHGEEC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4037640", Offset = "0x4036840", VA = "0x184037640")]
			public TType IJNOFLIJGJF()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x40379B0", Offset = "0x4036BB0", VA = "0x1840379B0")]
			public KCHBHGMLJEI<TType> KJEGDHGJOAP(KCHBHGMLJEI<TType> EFLJLNCMHDD, KCHBHGMLJEI<TType> DJDKOLONKNI)
			{
				return default(KCHBHGMLJEI<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x40362E0", Offset = "0x40354E0", VA = "0x1840362E0")]
			public int CMBIPGJCKNI(TNode CLKPBALPCKM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4036C30", Offset = "0x4035E30", VA = "0x184036C30")]
			public int DMMGEOMECDF(TNode CLKPBALPCKM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4037960", Offset = "0x4036B60", VA = "0x184037960")]
			public TInput KBGBBILBOLI(TNode CLKPBALPCKM, int HMFNCGHECPG)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4037010", Offset = "0x4036210", VA = "0x184037010")]
			public int HDILAIFBPDH(TNode CLKPBALPCKM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4037FA0", Offset = "0x40371A0", VA = "0x184037FA0")]
			public TOutput LEKHKFJBMCL(TNode CLKPBALPCKM, int HMFNCGHECPG)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4038500", Offset = "0x4037700", VA = "0x184038500")]
			public IEnumerable<IIPKCLFDCEK<TType>> NDIDLPBEBBI(TNode CLKPBALPCKM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4036320", Offset = "0x4035520", VA = "0x184036320")]
			public IEnumerable<CABGGJNEBIN<TNode>> CMJAFFHHNBE([In] TNode CLKPBALPCKM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x40361E0", Offset = "0x40353E0", VA = "0x1840361E0")]
			public TType CHIGBAACPCG(TInput CCAOJBHBKKC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x40368D0", Offset = "0x4035AD0", VA = "0x1840368D0")]
			public int DCONGAEBDCN(TInput CCAOJBHBKKC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4038780", Offset = "0x4037980", VA = "0x184038780")]
			public TOutput PKOHIPEJMKE(TInput CCAOJBHBKKC, int HMFNCGHECPG)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x40372E0", Offset = "0x40364E0", VA = "0x1840372E0")]
			public TNode HJBBLIJIFNM(TInput CCAOJBHBKKC)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x40380E0", Offset = "0x40372E0", VA = "0x1840380E0")]
			public TType LJKGGJINNGG(TOutput JOANOPHIHDM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4037530", Offset = "0x4036730", VA = "0x184037530")]
			public int HONNOMIJDBC(TOutput JOANOPHIHDM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4036C70", Offset = "0x4035E70", VA = "0x184036C70")]
			public TInput ENBDNLEICLC(TOutput JOANOPHIHDM, int HMFNCGHECPG)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4035FC0", Offset = "0x40351C0", VA = "0x184035FC0")]
			public TNode BJLKHJHILJP(TOutput JOANOPHIHDM)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4036960", Offset = "0x4035B60", VA = "0x184036960")]
			public bool DDEHNCGGPJI(TType FLPJMDMACMC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4036050", Offset = "0x4035250", VA = "0x184036050")]
			public TType CCOENBMCMOF(TType FLPJMDMACMC, IEnumerable<TType> BFAJCNFAOON)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4037DA0", Offset = "0x4036FA0", VA = "0x184037DA0")]
			public void KLMAGIKLCAA(TType FLPJMDMACMC, Action<TType> IJOPHEAJKLE, Action<TType> HKLBIBOEDGP, Action<TType> BMBCKINEDFF, Action<TType> JOKLMMDNNPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4037390", Offset = "0x4036590", VA = "0x184037390")]
			public TType HJHPEKIEFBO(TType FLPJMDMACMC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4036F00", Offset = "0x4036100", VA = "0x184036F00")]
			public string GNKHKIPHDLN(TType FLPJMDMACMC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4036E80", Offset = "0x4036080", VA = "0x184036E80")]
			public TTerm GBACLMFKJEC()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4038680", Offset = "0x4037880", VA = "0x184038680")]
			public TTerm PFJHJENGOHP(TTerm GNFAPCHBCGI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4037E00", Offset = "0x4037000", VA = "0x184037E00")]
			public TTerm KPHIIHMCLAM(TTerm AGNBNOOMFNG, TTerm LKEJHNGNLDG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x40366E0", Offset = "0x40358E0", VA = "0x1840366E0")]
			public void DAHHELGCNNE(TTerm EFLJLNCMHDD, TTerm DJDKOLONKNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4037C40", Offset = "0x4036E40", VA = "0x184037C40")]
			public bool KKFGBMEIJEJ(TOutputTerm GNFAPCHBCGI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x40377F0", Offset = "0x40369F0", VA = "0x1840377F0")]
			public bool JDDDHJKMEDM(TOutputTerm GNFAPCHBCGI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4036B30", Offset = "0x4035D30", VA = "0x184036B30")]
			public TTerm DKLPIPDMAMD(TOutputTerm KCOIAIOCPBI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4037190", Offset = "0x4036390", VA = "0x184037190")]
			public TOutputTerm HEHIFNLAIKB(TOutputTerm GNFAPCHBCGI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4036520", Offset = "0x4035720", VA = "0x184036520")]
			public TOutputTerm CPCGIIJJDBI(TOutputTerm GNFAPCHBCGI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x40366A0", Offset = "0x40358A0", VA = "0x1840366A0")]
			public TTerm CPKOKJLDPFC(TOutputSubstitution MHDMBDODHHM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x40385C0", Offset = "0x40377C0", VA = "0x1840385C0")]
			public TOutputTerm OHAKMEGCONJ(TOutputSubstitution MHDMBDODHHM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4036420", Offset = "0x4035620", VA = "0x184036420")]
			public TOutputTerm COGCNAOGMCP(TTerm GNFAPCHBCGI)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class BLNFDIFINCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NGCLIEBBPFK arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public BLNFDIFINCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x48AA930", Offset = "0x48A9B30", VA = "0x1848AA930")]
			internal int BBOAICEOMNO(NGCLIEBBPFK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x48AAA40", Offset = "0x48A9C40", VA = "0x1848AAA40")]
			internal TInput IHGBHPGLPGK(NGCLIEBBPFK arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x48AABB0", Offset = "0x48A9DB0", VA = "0x1848AABB0")]
			internal int NBMGMGKFFDF(NGCLIEBBPFK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x48AAAF0", Offset = "0x48A9CF0", VA = "0x1848AAAF0")]
			internal TOutput IJCNHMKAJLI(NGCLIEBBPFK arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class FNPIDIKAMPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public NGCLIEBBPFK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, EFJHBGHKJBB<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<EFJHBGHKJBB<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public FNPIDIKAMPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x38178E0", Offset = "0x3816AE0", VA = "0x1838178E0")]
			internal (string, TTerm) OCCDGOJJMHO(IIPKCLFDCEK<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class KKKFKBOOEEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public NGCLIEBBPFK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public KKKFKBOOEEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3C9BC80", Offset = "0x3C9AE80", VA = "0x183C9BC80")]
			internal void LHCOJAJOEPN(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3C9B8E0", Offset = "0x3C9AAE0", VA = "0x183C9B8E0")]
			internal void HHBIACNLCLI(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3C9B150", Offset = "0x3C9A350", VA = "0x183C9B150")]
			internal void CALFDCOPOIB(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3C9B490", Offset = "0x3C9A690", VA = "0x183C9B490")]
			internal void FDKNHPJDAHJ(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class DCLLCCPGAIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public NGCLIEBBPFK arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public DCLLCCPGAIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3815B40", Offset = "0x3814D40", VA = "0x183815B40")]
			internal TTerm AKAEMPNKBEF(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3D8E110", Offset = "0x3D8D310", VA = "0x183D8E110")]
		private static BLKDCPILLAK NMNNNNODDMG([CallerMemberName] string IKEFBMMMAJB = "")
		{
			return default(BLKDCPILLAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D86890", Offset = "0x3D85A90", VA = "0x183D86890")]
		public static Dictionary<TNode, List<IIPKCLFDCEK<TType>>> JOAFHPDBBCM(TRoot MIAAKEAGJGI, TDeps NMAKCOKENKA, TGraph PPIENIHGEEC, IEnumerable<TNode> FHHLKCLFIBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D86DC0", Offset = "0x3D85FC0", VA = "0x183D86DC0")]
		private static (Dictionary<TTerm, EFJHBGHKJBB<TNode>>, List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>>) LEOEHKGNDDP(IEnumerable<TNode> FHHLKCLFIBM, NGCLIEBBPFK GFMMLICJDDH)
		{
			return default((Dictionary<TTerm, EFJHBGHKJBB<TNode>>, List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3D8E150", Offset = "0x3D8D350", VA = "0x183D8E150")]
		private static void NPMBFHOJMFE(TNode CLKPBALPCKM, Dictionary<TInput, TTerm> KPJEAKOHHMP, Dictionary<TOutput, TTerm> IFPPMHGOFKA, Dictionary<TTerm, EFJHBGHKJBB<TNode>> MDHAEPOIPEB, Dictionary<EFJHBGHKJBB<TNode>, TTerm> IIDKLBFNFDP, List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> GBBOFIJKNMG, Stack<TNode> NLFPGGPNPHL, List<CABGGJNEBIN<TNode>> IHIDODNGOFE, NGCLIEBBPFK GFMMLICJDDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3D903C0", Offset = "0x3D8F5C0", VA = "0x183D903C0")]
		private static Dictionary<string, TTerm> OEHOEKCKBFC(TNode CLKPBALPCKM, Dictionary<TTerm, EFJHBGHKJBB<TNode>> MDHAEPOIPEB, Dictionary<EFJHBGHKJBB<TNode>, TTerm> AFIILPJBOFI, List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> GBBOFIJKNMG, NGCLIEBBPFK GFMMLICJDDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2582B50", Offset = "0x2581D50", VA = "0x182582B50")]
		private static (TPort, TTerm)[] KOLLFLMKGMA<TPort>(TNode CLKPBALPCKM, Func<NGCLIEBBPFK, TNode, int> PPHHDECLONI, Func<NGCLIEBBPFK, TNode, int, TPort> GIDJBNOLMHH, Func<NGCLIEBBPFK, TPort, TType> GEIBNPDGOLJ, Dictionary<TPort, TTerm> INKOFDPALLN, NGCLIEBBPFK GFMMLICJDDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D8BCB0", Offset = "0x3D8AEB0", VA = "0x183D8BCB0")]
		private static (TTerm, TTerm) MPJCGHLPHHG((TOutput Output, TTerm Id)[] DNLOJHNFNEH, List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> GBBOFIJKNMG, Dictionary<string, TTerm> AFIILPJBOFI, Stack<TNode> NLFPGGPNPHL, NGCLIEBBPFK GFMMLICJDDH)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B110", Offset = "0x3D8A310", VA = "0x183D8B110")]
		private static void LOADFJPCFHI((TInput PortKey, TTerm Id)[] AOMGHNALNKP, TTerm JECBHFPMAIO, TTerm AFBNBHDHJFG, List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> GBBOFIJKNMG, Dictionary<TOutput, TTerm> IFPPMHGOFKA, Dictionary<string, TTerm> AFIILPJBOFI, Stack<TNode> NLFPGGPNPHL, NGCLIEBBPFK GFMMLICJDDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E080", Offset = "0x3D7D280", VA = "0x183D7E080")]
		private static TTerm BNLEPBAMDAP(TInput CCAOJBHBKKC, List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> GBBOFIJKNMG, Dictionary<TOutput, TTerm> IFPPMHGOFKA, Stack<TNode> NLFPGGPNPHL, NGCLIEBBPFK GFMMLICJDDH)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3D84A00", Offset = "0x3D83C00", VA = "0x183D84A00")]
		private static TTerm GGKHHLNBNKE([In] TType FLPJMDMACMC, IOKind IGPJCOJJFOJ, List<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> GBBOFIJKNMG, IReadOnlyDictionary<string, TTerm> AFIILPJBOFI, NGCLIEBBPFK GFMMLICJDDH)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3D83EC0", Offset = "0x3D830C0", VA = "0x183D83EC0")]
		private static Dictionary<TNode, List<IIPKCLFDCEK<TType>>> GECOPNIGHNJ(TOutputSubstitution[] AKCCNKOBBIK, Dictionary<TTerm, EFJHBGHKJBB<TNode>> MDHAEPOIPEB, IEnumerable<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> GBBOFIJKNMG, NGCLIEBBPFK GFMMLICJDDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3D894F0", Offset = "0x3D886F0", VA = "0x183D894F0")]
		private static Dictionary<TNode, List<IIPKCLFDCEK<TType>>> LHDDLABLFMO(Dictionary<TTerm, EFJHBGHKJBB<TNode>> MDHAEPOIPEB, NGCLIEBBPFK GFMMLICJDDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3D911B0", Offset = "0x3D903B0", VA = "0x183D911B0")]
		private static void PEEOGNOJPFM([In] TNode CLKPBALPCKM, Stack<TNode> NLFPGGPNPHL, List<CABGGJNEBIN<TNode>> IHIDODNGOFE, NGCLIEBBPFK GFMMLICJDDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D85400", Offset = "0x3D84600", VA = "0x183D85400")]
		private static void GMDNNDGFCGO(Dictionary<EFJHBGHKJBB<TNode>, TTerm> AFIILPJBOFI, List<CABGGJNEBIN<TNode>> IHIDODNGOFE, NGCLIEBBPFK GFMMLICJDDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3D7FD20", Offset = "0x3D7EF20", VA = "0x183D7FD20")]
		private static Dictionary<TTerm, TType> CNDAHBIJIKF(Dictionary<TTerm, TOutputSubstitution> AKCCNKOBBIK, IEnumerable<KeyValuePair<TTerm, KCHBHGMLJEI<TType>>> GBBOFIJKNMG, NGCLIEBBPFK GFMMLICJDDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3D820C0", Offset = "0x3D812C0", VA = "0x183D820C0")]
		private static PKNGEFGGMEI<TType> EMCGBAEIDEO(TOutputTerm FLPJMDMACMC, Dictionary<TTerm, TType> GBBOFIJKNMG, Dictionary<TTerm, TType> EFHIGOEKJMJ, NGCLIEBBPFK GFMMLICJDDH)
		{
			return default(PKNGEFGGMEI<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DDA0", Offset = "0x3D7CFA0", VA = "0x183D7DDA0")]
		private static TOutputTerm BJIFGFBMMJC(TOutputTerm BMLKAHLEGMJ, NGCLIEBBPFK GFMMLICJDDH)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2919160", Offset = "0x2918360", VA = "0x182919160")]
	public static Dictionary<TNode, List<IIPKCLFDCEK<TType>>> JOAFHPDBBCM<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::GFEKAMNKBAA<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> KNKOEEEKHDK, TRoot MIAAKEAGJGI, TGraph PPIENIHGEEC, IEnumerable<TNode> FHHLKCLFIBM) where TDeps : global::OAIMMFJAJLH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IIPKCLFDCEK<TType> : IEquatable<IIPKCLFDCEK<TType>>, BLODAJINHJK<IIPKCLFDCEK<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string ECHFBJHACCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType GPCHMAHCPNE;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x389EF50", Offset = "0x389E150", VA = "0x18389EF50")]
	internal IIPKCLFDCEK(string IKEFBMMMAJB, [In] TType FCMIIFBKIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3A406D0", Offset = "0x3A3F8D0", VA = "0x183A406D0")]
	public bool JLFMJDFPDBJ([In] IIPKCLFDCEK<TType> NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3A40680", Offset = "0x3A3F880", VA = "0x183A40680", Slot = "4")]
	public bool Equals(IIPKCLFDCEK<TType> NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3475920", Offset = "0x3474B20", VA = "0x183475920", Slot = "0")]
	public override bool Equals(object NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E94A70", Offset = "0x1E93C70", VA = "0x181E94A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3A407A0", Offset = "0x3A3F9A0", VA = "0x183A407A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3A40630", Offset = "0x3A3F830", VA = "0x183A40630", Slot = "5")]
	private bool BIDMEHELEFC([In] IIPKCLFDCEK<TType> NOBJAPGNDAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OFCDHBBAGBA
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E700", Offset = "0x2A2D900", VA = "0x182A2E700")]
	public static IIPKCLFDCEK<TType> MIJABIECKKD<TType>(string IKEFBMMMAJB, TType FCMIIFBKIDD)
	{
		return default(IIPKCLFDCEK<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2A2E6C0", Offset = "0x2A2D8C0", VA = "0x182A2E6C0")]
	public static (string, TType) LOGPIIKPOON<TType>([In] this IIPKCLFDCEK<TType> KNKOEEEKHDK)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct EFJHBGHKJBB<TNode> : IEquatable<EFJHBGHKJBB<TNode>>, BLODAJINHJK<EFJHBGHKJBB<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode FLBKFFJHCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string ECHFBJHACCL;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xC46070", Offset = "0xC45270", VA = "0x180C46070")]
	internal EFJHBGHKJBB(TNode CLKPBALPCKM, string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3475B30", Offset = "0x3474D30", VA = "0x183475B30")]
	public bool JLFMJDFPDBJ([In] EFJHBGHKJBB<TNode> NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x34758D0", Offset = "0x3474AD0", VA = "0x1834758D0", Slot = "4")]
	public bool Equals(EFJHBGHKJBB<TNode> NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3475920", Offset = "0x3474B20", VA = "0x183475920", Slot = "0")]
	public override bool Equals(object NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x34759F0", Offset = "0x3474BF0", VA = "0x1834759F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3475C40", Offset = "0x3474E40", VA = "0x183475C40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3475830", Offset = "0x3474A30", VA = "0x183475830", Slot = "5")]
	private bool BLIPMKCENNB([In] EFJHBGHKJBB<TNode> NOBJAPGNDAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MBGJJFANELJ
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x299A2D0", Offset = "0x29994D0", VA = "0x18299A2D0")]
	public static EFJHBGHKJBB<TNode> MIJABIECKKD<TNode>(TNode CLKPBALPCKM, string IKEFBMMMAJB)
	{
		return default(EFJHBGHKJBB<TNode>);
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
