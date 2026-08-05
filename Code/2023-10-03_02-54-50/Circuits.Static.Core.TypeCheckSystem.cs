using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct PJMJFGIAMPH<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType OHBHGCLHIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind LAFELOBLBMM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x165B6D0", Offset = "0x1659ED0", VA = "0x18165B6D0")]
	internal PJMJFGIAMPH(TType BJKOKHNAAID, IOKind ALGDFCFHKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3E879A0", Offset = "0x3E861A0", VA = "0x183E879A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ANJMELNMPIF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29C8800", Offset = "0x29C7000", VA = "0x1829C8800")]
	public static PJMJFGIAMPH<TType> MJLGMKKAMEE<TType>(TType BJKOKHNAAID, IOKind ALGDFCFHKDF)
	{
		return default(PJMJFGIAMPH<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29C8830", Offset = "0x29C7030", VA = "0x1829C8830")]
	public static (TType, IOKind) NENBDCLAFOO<TType>([In] this PJMJFGIAMPH<TType> CLEGCKJMIEA)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29C87A0", Offset = "0x29C6FA0", VA = "0x1829C87A0")]
	public static void IDOGKACACAK<TType>([In] this PJMJFGIAMPH<TType> CLEGCKJMIEA, [Out] TType BJKOKHNAAID, [Out] IOKind ALGDFCFHKDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KHPPCCLJHPP<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MBIKLBCGHCO<TNode> PIDHIFIDIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MBIKLBCGHCO<TNode> HLBNHMJCPEG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x38D9FB0", Offset = "0x38D87B0", VA = "0x1838D9FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BPDHNACMCDE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2198970", Offset = "0x2197170", VA = "0x182198970")]
	public static (MBIKLBCGHCO<TNode>, MBIKLBCGHCO<TNode>) NENBDCLAFOO<TNode>([In] this KHPPCCLJHPP<TNode> CLEGCKJMIEA)
	{
		return default((MBIKLBCGHCO<TNode>, MBIKLBCGHCO<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2198890", Offset = "0x2197090", VA = "0x182198890")]
	public static void IDOGKACACAK<TNode>([In] this KHPPCCLJHPP<TNode> CLEGCKJMIEA, [Out] MBIKLBCGHCO<TNode> MANEBEMOKEE, [Out] MBIKLBCGHCO<TNode> HOCFNIKGEJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DANLOFNNJLB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HHIIIPLPDNO MHEABPFIHHF(TRoot KLOAHFNCDKG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType KIAJNENALBL(TRoot KLOAHFNCDKG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PJMJFGIAMPH<TType> JOPJCKLACNO(TRoot KLOAHFNCDKG, [In] PJMJFGIAMPH<TType> LCFOIJICGNF, [In] PJMJFGIAMPH<TType> CEDMGMKLGHI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HHHIMMINLNI(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TNode LBKDEGBJKJF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EPALMHEODLK(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TNode LBKDEGBJKJF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput FAMOFBKHOOJ(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TNode LBKDEGBJKJF, int ADMJKDLHPCI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PINFPDAOCCH(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TNode LBKDEGBJKJF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput GPDDAKKHIFD(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TNode LBKDEGBJKJF, int ADMJKDLHPCI);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<ICMMNAJIOHE<TType>> GIGHGGPKJGO(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TNode LBKDEGBJKJF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<KHPPCCLJHPP<TNode>> CJPFIFBDKMJ(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TNode LBKDEGBJKJF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType NIEEFIJDAFC(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TInput EJAHENBAJFL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int PJBDNJGLOCD(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TInput EJAHENBAJFL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput GFGPNKGBFKJ(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TInput EJAHENBAJFL, int ADMJKDLHPCI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode EHNPLLEFOMG(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TInput EJAHENBAJFL);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType NKNLJNCIIDJ(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TOutput FFMHOHOIJJO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int DIDMOPHBOBP(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TOutput FFMHOHOIJJO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput GEGHECHKMMG(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TOutput FFMHOHOIJJO, int ADMJKDLHPCI);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode JADJMHLCFLJ(TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, TOutput FFMHOHOIJJO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool EDAALMMHNNG(TRoot KLOAHFNCDKG, TType BJKOKHNAAID);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType PIAKBAFDIND(TRoot KLOAHFNCDKG, TType BJKOKHNAAID, IEnumerable<TType> NEIMAIMJLPH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HLBIINDNKEK(TRoot KLOAHFNCDKG, TType BJKOKHNAAID, Action<TType> AMBAJOGPBFA, Action<TType> KIOIAIBHDAD, Action<TType> GGAIBFHKBNG, Action<TType> ELFGJLNFBDD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType LPOIEPFHOPK(TRoot KLOAHFNCDKG, TType BJKOKHNAAID);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string COMPJABEOND(TRoot KLOAHFNCDKG, TType BJKOKHNAAID);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification POCMNPFIMLG(TRoot KLOAHFNCDKG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ENHODGJKDIF<TOutputSubstitution[], OFFEGPLAFGN> NBPMLECDFCG(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm MINPDKPBBPK(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm PJPFFELHCHD(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TTerm EEEFJCLGBGP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm MNCNCICODKB(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TTerm HIOBCEJFLJO, TTerm DNJMIEEELNJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IJLPFAGGOEO(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TTerm LCFOIJICGNF, TTerm CEDMGMKLGHI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool MNICFJJBIOI(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TOutputTerm CKNFHAFAJJD);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool NFAFBPIJFJB(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TOutputTerm CKNFHAFAJJD);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm KGMEMHIFNML(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TOutputTerm CKNFHAFAJJD);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm PCJNCCMHDDD(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TOutputTerm CKNFHAFAJJD);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm GJAPBENKGDC(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TOutputTerm CKNFHAFAJJD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm AAAHCNBONAB(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TOutputSubstitution MAKAHJJHGCE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm MOMCLAMCILE(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TOutputSubstitution MAKAHJJHGCE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm HDGMCCCBOFC(TRoot KLOAHFNCDKG, TUnification KLONGFGPABM, TTerm EEEFJCLGBGP);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct MLDACILHOPC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::DANLOFNNJLB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
	public static global::MLDACILHOPC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> MJLGMKKAMEE()
	{
		return default(global::MLDACILHOPC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MFGBPCHOJNK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class KOCPKKLFCMF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::DANLOFNNJLB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class IBMBOJFFAFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot AAPMKHJIGLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps FNCFAFMLHIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification IACFOOHOMNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph DMCGBIAJJOD;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public HHIIIPLPDNO AIJJADELACM
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x3653BA0", Offset = "0x36523A0", VA = "0x183653BA0")]
				get
				{
					return default(HHIIIPLPDNO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x36540E0", Offset = "0x36528E0", VA = "0x1836540E0")]
			private IBMBOJFFAFH(TRoot KLOAHFNCDKG, TDeps AGOMFIAFNMP, TUnification IKPEGLBFHOH, TGraph NGCHALDJFIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3653CA0", Offset = "0x36524A0", VA = "0x183653CA0")]
			public static IBMBOJFFAFH MJLGMKKAMEE(TRoot KLOAHFNCDKG, TDeps AGOMFIAFNMP, TUnification IKPEGLBFHOH, TGraph NGCHALDJFIH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3653B60", Offset = "0x3652360", VA = "0x183653B60")]
			public TType KIAJNENALBL()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3653B00", Offset = "0x3652300", VA = "0x183653B00")]
			public PJMJFGIAMPH<TType> JOPJCKLACNO(PJMJFGIAMPH<TType> LCFOIJICGNF, PJMJFGIAMPH<TType> CEDMGMKLGHI)
			{
				return default(PJMJFGIAMPH<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x36539C0", Offset = "0x36521C0", VA = "0x1836539C0")]
			public int HHHIMMINLNI(TNode LBKDEGBJKJF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3653760", Offset = "0x3651F60", VA = "0x183653760")]
			public int EPALMHEODLK(TNode LBKDEGBJKJF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x36537A0", Offset = "0x3651FA0", VA = "0x1836537A0")]
			public TInput FAMOFBKHOOJ(TNode LBKDEGBJKJF, int ADMJKDLHPCI)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3654050", Offset = "0x3652850", VA = "0x183654050")]
			public int PINFPDAOCCH(TNode LBKDEGBJKJF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3653920", Offset = "0x3652120", VA = "0x183653920")]
			public TOutput GPDDAKKHIFD(TNode LBKDEGBJKJF, int ADMJKDLHPCI)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3653890", Offset = "0x3652090", VA = "0x183653890")]
			public IEnumerable<ICMMNAJIOHE<TType>> GIGHGGPKJGO(TNode LBKDEGBJKJF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3653600", Offset = "0x3651E00", VA = "0x183653600")]
			public IEnumerable<KHPPCCLJHPP<TNode>> CJPFIFBDKMJ([In] TNode LBKDEGBJKJF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3653F30", Offset = "0x3652730", VA = "0x183653F30")]
			public TType NIEEFIJDAFC(TInput EJAHENBAJFL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3653BE0", Offset = "0x36523E0", VA = "0x183653BE0")]
			public int LPEPBNIGFBI(TInput EJAHENBAJFL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3653840", Offset = "0x3652040", VA = "0x183653840")]
			public TOutput GFGPNKGBFKJ(TInput EJAHENBAJFL, int ADMJKDLHPCI)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3653710", Offset = "0x3651F10", VA = "0x183653710")]
			public TNode EHNPLLEFOMG(TInput EJAHENBAJFL)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3653F70", Offset = "0x3652770", VA = "0x183653F70")]
			public TType NKNLJNCIIDJ(TOutput FFMHOHOIJJO)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3653EE0", Offset = "0x36526E0", VA = "0x183653EE0")]
			public int NFNCOGOACGI(TOutput FFMHOHOIJJO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x36537F0", Offset = "0x3651FF0", VA = "0x1836537F0")]
			public TInput GEGHECHKMMG(TOutput FFMHOHOIJJO, int ADMJKDLHPCI)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3653AB0", Offset = "0x36522B0", VA = "0x183653AB0")]
			public TNode JADJMHLCFLJ(TOutput FFMHOHOIJJO)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x36536D0", Offset = "0x3651ED0", VA = "0x1836536D0")]
			public bool EDAALMMHNNG(TType BJKOKHNAAID)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3654010", Offset = "0x3652810", VA = "0x183654010")]
			public TType PIAKBAFDIND(TType BJKOKHNAAID, IEnumerable<TType> NEIMAIMJLPH)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3653A00", Offset = "0x3652200", VA = "0x183653A00")]
			public void HLBIINDNKEK(TType BJKOKHNAAID, Action<TType> AMBAJOGPBFA, Action<TType> KIOIAIBHDAD, Action<TType> GGAIBFHKBNG, Action<TType> ELFGJLNFBDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3653C20", Offset = "0x3652420", VA = "0x183653C20")]
			public TType LPOIEPFHOPK(TType BJKOKHNAAID)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3653640", Offset = "0x3651E40", VA = "0x183653640")]
			public string COMPJABEOND(TType BJKOKHNAAID)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3653C60", Offset = "0x3652460", VA = "0x183653C60")]
			public TTerm MINPDKPBBPK()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3654090", Offset = "0x3652890", VA = "0x183654090")]
			public TTerm PJPFFELHCHD(TTerm EEEFJCLGBGP)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3653DA0", Offset = "0x36525A0", VA = "0x183653DA0")]
			public TTerm MNCNCICODKB(TTerm HIOBCEJFLJO, TTerm DNJMIEEELNJ)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3653A60", Offset = "0x3652260", VA = "0x183653A60")]
			public void IJLPFAGGOEO(TTerm LCFOIJICGNF, TTerm CEDMGMKLGHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3653E90", Offset = "0x3652690", VA = "0x183653E90")]
			public bool NFAFBPIJFJB(TOutputTerm EEEFJCLGBGP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3653DF0", Offset = "0x36525F0", VA = "0x183653DF0")]
			public bool MNICFJJBIOI(TOutputTerm EEEFJCLGBGP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3653680", Offset = "0x3651E80", VA = "0x183653680")]
			public TTerm DMAGPJOOONB(TOutputTerm CKNFHAFAJJD)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3653FC0", Offset = "0x36527C0", VA = "0x183653FC0")]
			public TOutputTerm PCJNCCMHDDD(TOutputTerm EEEFJCLGBGP)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x36538D0", Offset = "0x36520D0", VA = "0x1836538D0")]
			public TOutputTerm GJAPBENKGDC(TOutputTerm EEEFJCLGBGP)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x36535B0", Offset = "0x3651DB0", VA = "0x1836535B0")]
			public TTerm AAAHCNBONAB(TOutputSubstitution AACGMJHHNBK)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3653E40", Offset = "0x3652640", VA = "0x183653E40")]
			public TOutputTerm MOMCLAMCILE(TOutputSubstitution AACGMJHHNBK)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3653970", Offset = "0x3652170", VA = "0x183653970")]
			public TOutputTerm HDGMCCCBOFC(TTerm EEEFJCLGBGP)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class NGLMEDNHPHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IBMBOJFFAFH arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public NGLMEDNHPHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x3CA13B0", Offset = "0x3C9FBB0", VA = "0x183CA13B0")]
			internal int PONBEJCABMF(IBMBOJFFAFH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x3CA1310", Offset = "0x3C9FB10", VA = "0x183CA1310")]
			internal TInput LHLAMEFHHLE(IBMBOJFFAFH arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x3CA11F0", Offset = "0x3C9F9F0", VA = "0x183CA11F0")]
			internal int GEBCPJABMOI(IBMBOJFFAFH arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x3CA10F0", Offset = "0x3C9F8F0", VA = "0x183CA10F0")]
			internal TOutput CNLGNJJFPFA(IBMBOJFFAFH arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class KFDOEEIAODG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public IBMBOJFFAFH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, MBIKLBCGHCO<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<MBIKLBCGHCO<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public KFDOEEIAODG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x38D3C50", Offset = "0x38D2450", VA = "0x1838D3C50")]
			internal (string, TTerm) ANALOGIFOMP(ICMMNAJIOHE<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class NNDCAJIFDNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IBMBOJFFAFH arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public NNDCAJIFDNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x3CBCBD0", Offset = "0x3CBB3D0", VA = "0x183CBCBD0")]
			internal void DJPDACJHPLG(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x3CBD650", Offset = "0x3CBBE50", VA = "0x183CBD650")]
			internal void ICAMDEKPAOA(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3CBD2D0", Offset = "0x3CBBAD0", VA = "0x183CBD2D0")]
			internal void GKJNEKILBIL(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3CBD050", Offset = "0x3CBB850", VA = "0x183CBD050")]
			internal void FOHAGCEOBBA(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class ELEHIBBFOHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public IBMBOJFFAFH arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public ELEHIBBFOHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3015F40", Offset = "0x3014740", VA = "0x183015F40")]
			internal TTerm EFEKCOALBFM(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x39063F0", Offset = "0x3904BF0", VA = "0x1839063F0")]
		private static ECHCHECCMNK PBNJAEPBDMD([CallerMemberName] string BOBHOMKFHJB = "")
		{
			return default(ECHCHECCMNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3901530", Offset = "0x38FFD30", VA = "0x183901530")]
		public static Dictionary<TNode, List<ICMMNAJIOHE<TType>>> GNNOCAMEBLJ(TRoot KLOAHFNCDKG, TDeps AGOMFIAFNMP, TGraph NGCHALDJFIH, IEnumerable<TNode> GAKDOIALEGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x38F82E0", Offset = "0x38F6AE0", VA = "0x1838F82E0")]
		private static (Dictionary<TTerm, MBIKLBCGHCO<TNode>>, List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>>) CDLGMCBHODO(IEnumerable<TNode> GAKDOIALEGL, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return default((Dictionary<TTerm, MBIKLBCGHCO<TNode>>, List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x38FAC70", Offset = "0x38F9470", VA = "0x1838FAC70")]
		private static void DCFKGLEHCHN(TNode LBKDEGBJKJF, Dictionary<TInput, TTerm> ILNJIBOBJCE, Dictionary<TOutput, TTerm> PHOONFEICCM, Dictionary<TTerm, MBIKLBCGHCO<TNode>> CMNPPCONFAG, Dictionary<MBIKLBCGHCO<TNode>, TTerm> HFOHDJLAPOG, List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> EFCAMPNCHNO, Stack<TNode> ALINNDKLJKN, List<KHPPCCLJHPP<TNode>> MCLEOINMEOI, IBMBOJFFAFH EIMPEEDPEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x39007E0", Offset = "0x38FEFE0", VA = "0x1839007E0")]
		private static Dictionary<string, TTerm> FKBNCAJANBJ(TNode LBKDEGBJKJF, Dictionary<TTerm, MBIKLBCGHCO<TNode>> CMNPPCONFAG, Dictionary<MBIKLBCGHCO<TNode>, TTerm> HDKHPPIOPIH, List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> EFCAMPNCHNO, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2167570", Offset = "0x2165D70", VA = "0x182167570")]
		private static (TPort, TTerm)[] FHEEENEFGGN<TPort>(TNode LBKDEGBJKJF, Func<IBMBOJFFAFH, TNode, int> JOBHOEGLJCF, Func<IBMBOJFFAFH, TNode, int, TPort> LIOHMAGOIOO, Func<IBMBOJFFAFH, TPort, TType> MFLPJBJHJFO, Dictionary<TPort, TTerm> MIKHGCGOMEH, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x38F6070", Offset = "0x38F4870", VA = "0x1838F6070")]
		private static (TTerm, TTerm) CBJLHLHKKCF((TOutput Output, TTerm Id)[] BBJPBACJFEK, List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> EFCAMPNCHNO, Dictionary<string, TTerm> HDKHPPIOPIH, Stack<TNode> ALINNDKLJKN, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3905750", Offset = "0x3903F50", VA = "0x183905750")]
		private static void KJCOKDFDFGE((TInput PortKey, TTerm Id)[] LGBLJCNKMMO, TTerm LGBFBABMADK, TTerm FDJNMOOPJKI, List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> EFCAMPNCHNO, Dictionary<TOutput, TTerm> PHOONFEICCM, Dictionary<string, TTerm> HDKHPPIOPIH, Stack<TNode> ALINNDKLJKN, IBMBOJFFAFH EIMPEEDPEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x38FF870", Offset = "0x38FE070", VA = "0x1838FF870")]
		private static TTerm FDHCJKFKJNP(TInput EJAHENBAJFL, List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> EFCAMPNCHNO, Dictionary<TOutput, TTerm> PHOONFEICCM, Stack<TNode> ALINNDKLJKN, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x38FF2B0", Offset = "0x38FDAB0", VA = "0x1838FF2B0")]
		private static TTerm EIACFBIKJDK([In] TType BJKOKHNAAID, IOKind ALGDFCFHKDF, List<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> EFCAMPNCHNO, IReadOnlyDictionary<string, TTerm> HDKHPPIOPIH, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x38F15C0", Offset = "0x38EFDC0", VA = "0x1838F15C0")]
		private static Dictionary<TNode, List<ICMMNAJIOHE<TType>>> BGNONFKECPD(TOutputSubstitution[] LGAPINKIELA, Dictionary<TTerm, MBIKLBCGHCO<TNode>> CMNPPCONFAG, IEnumerable<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> EFCAMPNCHNO, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x38FBD00", Offset = "0x38FA500", VA = "0x1838FBD00")]
		private static Dictionary<TNode, List<ICMMNAJIOHE<TType>>> EDFKGPJANKM(Dictionary<TTerm, MBIKLBCGHCO<TNode>> CMNPPCONFAG, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x38F3E60", Offset = "0x38F2660", VA = "0x1838F3E60")]
		private static void BPFNDLMJAHM([In] TNode LBKDEGBJKJF, Stack<TNode> ALINNDKLJKN, List<KHPPCCLJHPP<TNode>> MCLEOINMEOI, IBMBOJFFAFH EIMPEEDPEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3903080", Offset = "0x3901880", VA = "0x183903080")]
		private static void JINHGMDMHCA(Dictionary<MBIKLBCGHCO<TNode>, TTerm> HDKHPPIOPIH, List<KHPPCCLJHPP<TNode>> MCLEOINMEOI, IBMBOJFFAFH EIMPEEDPEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x38FC5E0", Offset = "0x38FADE0", VA = "0x1838FC5E0")]
		private static Dictionary<TTerm, TType> EENDOHHADNK(Dictionary<TTerm, TOutputSubstitution> LGAPINKIELA, IEnumerable<KeyValuePair<TTerm, PJMJFGIAMPH<TType>>> EFCAMPNCHNO, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x39028A0", Offset = "0x39010A0", VA = "0x1839028A0")]
		private static OCIMHDHLOGG<TType> IHEKNNDEOOO(TOutputTerm BJKOKHNAAID, Dictionary<TTerm, TType> EFCAMPNCHNO, Dictionary<TTerm, TType> PBBLGCKBEBB, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return default(OCIMHDHLOGG<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x38F9270", Offset = "0x38F7A70", VA = "0x1838F9270")]
		private static TOutputTerm CFOKHKIMCPJ(TOutputTerm LFGCDJEIELO, IBMBOJFFAFH EIMPEEDPEPM)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x246E280", Offset = "0x246CA80", VA = "0x18246E280")]
	public static Dictionary<TNode, List<ICMMNAJIOHE<TType>>> GNNOCAMEBLJ<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::MLDACILHOPC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> CLEGCKJMIEA, TRoot KLOAHFNCDKG, TGraph NGCHALDJFIH, IEnumerable<TNode> GAKDOIALEGL) where TDeps : global::DANLOFNNJLB<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct ICMMNAJIOHE<TType> : IEquatable<ICMMNAJIOHE<TType>>, LKPADMBBDIC<ICMMNAJIOHE<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string MJLCABAKOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType OOKPPEFMIOL;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3658B50", Offset = "0x3657350", VA = "0x183658B50")]
	internal ICMMNAJIOHE(string BOBHOMKFHJB, [In] TType EDGPKNKIJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3658920", Offset = "0x3657120", VA = "0x183658920")]
	public bool BNNKBIKNDJH([In] ICMMNAJIOHE<TType> GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3658A40", Offset = "0x3657240", VA = "0x183658A40", Slot = "4")]
	public bool Equals(ICMMNAJIOHE<TType> GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3658A90", Offset = "0x3657290", VA = "0x183658A90", Slot = "0")]
	public override bool Equals(object GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1C71B00", Offset = "0x1C70300", VA = "0x181C71B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3658B10", Offset = "0x3657310", VA = "0x183658B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x36589F0", Offset = "0x36571F0", VA = "0x1836589F0", Slot = "5")]
	private bool DIFEDANDDFB([In] ICMMNAJIOHE<TType> GHNNCJBDHKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ONAKNCLGCCB
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x24F4A10", Offset = "0x24F3210", VA = "0x1824F4A10")]
	public static ICMMNAJIOHE<TType> MJLGMKKAMEE<TType>(string BOBHOMKFHJB, TType EDGPKNKIJIN)
	{
		return default(ICMMNAJIOHE<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x24F4A40", Offset = "0x24F3240", VA = "0x1824F4A40")]
	public static (string, TType) NENBDCLAFOO<TType>([In] this ICMMNAJIOHE<TType> CLEGCKJMIEA)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct MBIKLBCGHCO<TNode> : IEquatable<MBIKLBCGHCO<TNode>>, LKPADMBBDIC<MBIKLBCGHCO<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode COGBOENMHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string MJLCABAKOPI;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAB95B0", Offset = "0xAB7DB0", VA = "0x180AB95B0")]
	internal MBIKLBCGHCO(TNode LBKDEGBJKJF, string BOBHOMKFHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3B970B0", Offset = "0x3B958B0", VA = "0x183B970B0")]
	public bool BNNKBIKNDJH([In] MBIKLBCGHCO<TNode> GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B972A0", Offset = "0x3B95AA0", VA = "0x183B972A0", Slot = "4")]
	public bool Equals(MBIKLBCGHCO<TNode> GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3658A90", Offset = "0x3657290", VA = "0x183658A90", Slot = "0")]
	public override bool Equals(object GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3B972F0", Offset = "0x3B95AF0", VA = "0x183B972F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3B97400", Offset = "0x3B95C00", VA = "0x183B97400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3B97360", Offset = "0x3B95B60", VA = "0x183B97360", Slot = "5")]
	private bool OACIHNMKDKG([In] MBIKLBCGHCO<TNode> GHNNCJBDHKF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class AKBFNCELEIE
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x29B2830", Offset = "0x29B1030", VA = "0x1829B2830")]
	public static MBIKLBCGHCO<TNode> MJLGMKKAMEE<TNode>(TNode LBKDEGBJKJF, string BOBHOMKFHJB)
	{
		return default(MBIKLBCGHCO<TNode>);
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
