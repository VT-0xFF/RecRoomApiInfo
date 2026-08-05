using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct GIFDADDBAEH<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType PBNBGAHIAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind INBPNAJLJLL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xC9CD20", Offset = "0xC9B520", VA = "0x180C9CD20")]
	internal GIFDADDBAEH(TType CEPGAJKBPDM, IOKind OHKMCDAJBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4C8A920", Offset = "0x4C89120", VA = "0x184C8A920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NBDLJMDNLJA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3B44C40", Offset = "0x3B43440", VA = "0x183B44C40")]
	public static GIFDADDBAEH<TType> CCPKJDCALBG<TType>(TType CEPGAJKBPDM, IOKind OHKMCDAJBCD)
	{
		return default(GIFDADDBAEH<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B44CE0", Offset = "0x3B434E0", VA = "0x183B44CE0")]
	public static (TType, IOKind) HIIFOPLNPIJ<TType>([In] this GIFDADDBAEH<TType> DKBBJFIDEGB)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B44C70", Offset = "0x3B43470", VA = "0x183B44C70")]
	public static void EBKFCGEKMKA<TType>([In] this GIFDADDBAEH<TType> DKBBJFIDEGB, [Out] TType CEPGAJKBPDM, [Out] IOKind OHKMCDAJBCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct IJNNCNENPLP<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GINPDIOLJFC<TNode> MIHBOGIOFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GINPDIOLJFC<TNode> NOEGDAPBNIC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E85A50", Offset = "0x4E84250", VA = "0x184E85A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CIIFMGEHGIL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37B8390", Offset = "0x37B6B90", VA = "0x1837B8390")]
	public static (GINPDIOLJFC<TNode>, GINPDIOLJFC<TNode>) HIIFOPLNPIJ<TNode>([In] this IJNNCNENPLP<TNode> DKBBJFIDEGB)
	{
		return default((GINPDIOLJFC<TNode>, GINPDIOLJFC<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37B8290", Offset = "0x37B6A90", VA = "0x1837B8290")]
	public static void EBKFCGEKMKA<TNode>([In] this IJNNCNENPLP<TNode> DKBBJFIDEGB, [Out] GINPDIOLJFC<TNode> HGBNKPCDEON, [Out] GINPDIOLJFC<TNode> DPOCHOAKFKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface APOLDDKDPBF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NPCLOJKLJLJ FPFHIGNNDFI(TRoot MJAMEBJFAIN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType IELFOJJOEFA(TRoot MJAMEBJFAIN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GIFDADDBAEH<TType> DNNBOOFNBBB(TRoot MJAMEBJFAIN, [In] GIFDADDBAEH<TType> NOGJAHKGFJD, [In] GIFDADDBAEH<TType> LHMEHOJLNDH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int ONIEKMBNGMB(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TNode CJEDGIAKFCF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EJBNLJMHNLH(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TNode CJEDGIAKFCF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput HNLNOGMODKG(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TNode CJEDGIAKFCF, int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BAJNBMIHGFJ(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TNode CJEDGIAKFCF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput HIFBADLGIPN(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TNode CJEDGIAKFCF, int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<KJKKPLJKJDL<TType>> KFPBDIFDFDN(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TNode CJEDGIAKFCF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<IJNNCNENPLP<TNode>> KPLDEJHONBC(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TNode CJEDGIAKFCF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType CBEFLMLPPJA(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TInput FNFJALHKEGF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int GFIFGPIMJDB(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TInput FNFJALHKEGF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput BNBHDPOIENK(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TInput FNFJALHKEGF, int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode EDAMBDOKJEF(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TInput FNFJALHKEGF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType NJMHCBBLGCP(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TOutput ECOCMLPNFDM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int OIHIAGMAFAB(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TOutput ECOCMLPNFDM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput OOFPCMDBOHN(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TOutput ECOCMLPNFDM, int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode CKOIIMNECJM(TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, TOutput ECOCMLPNFDM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LFKNFAEJDNH(TRoot MJAMEBJFAIN, TType CEPGAJKBPDM);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType CHIHMKANGIK(TRoot MJAMEBJFAIN, TType CEPGAJKBPDM, IEnumerable<TType> HLOKMICNGBM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KLKFHGBLNDM(TRoot MJAMEBJFAIN, TType CEPGAJKBPDM, Action<TType> CHENMEEMFFG, Action<TType> JPABDJHEFNJ, Action<TType> BOHMJMOLBOC, Action<TType> KILBGMENEIH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType PGNPAFBGHCC(TRoot MJAMEBJFAIN, TType CEPGAJKBPDM);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string OBHGFLGCIDB(TRoot MJAMEBJFAIN, TType CEPGAJKBPDM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification IFKPEGOLGBC(TRoot MJAMEBJFAIN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	AOGODOAGAAO<TOutputSubstitution[], EMOGOMODAJG> IMPLNDMLNEI(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm JDJNBBJEAFF(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm IDNCFINMDFF(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TTerm NEJPKBEPJKI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm NMPMOOMKADK(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TTerm JPGKLKLGGMN, TTerm OOGMCHHLIPA);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ACAPGBFGADC(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TTerm NOGJAHKGFJD, TTerm LHMEHOJLNDH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool ANEJLPKGLBD(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TOutputTerm NMEANLMLDPN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KKMFIDDBAIA(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TOutputTerm NMEANLMLDPN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm GFNEICKANCD(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TOutputTerm NMEANLMLDPN);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm ILNDOMCEPFN(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TOutputTerm NMEANLMLDPN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm DDHOFAHFOEE(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TOutputTerm NMEANLMLDPN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm KOEPNBOCCKO(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TOutputSubstitution GKDHGLFMGJM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm BAHLJBPAPGJ(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TOutputSubstitution GKDHGLFMGJM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm JALHGNOGBMI(TRoot MJAMEBJFAIN, TUnification KDFDNJALANC, TTerm NEJPKBEPJKI);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct AHCAGPJPCNK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::APOLDDKDPBF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
	public static global::AHCAGPJPCNK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> CCPKJDCALBG()
	{
		return default(global::AHCAGPJPCNK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KBNICDCJGKB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class LGPBIKNPJIM<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::APOLDDKDPBF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class GCCOBGFBMBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot LCHPFLHNGGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps MELCHAMIAJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification OLHKBAKDOAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph BDIOEFAFABO;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public NPCLOJKLJLJ KEIFFKDCDJP
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4C7C690", Offset = "0x4C7AE90", VA = "0x184C7C690")]
				get
				{
					return default(NPCLOJKLJLJ);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4C7E4A0", Offset = "0x4C7CCA0", VA = "0x184C7E4A0")]
			private GCCOBGFBMBB(TRoot MJAMEBJFAIN, TDeps GGLINDGLEPB, TUnification KJFNLIOHHLM, TGraph OPFJIIPHLBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4C7C290", Offset = "0x4C7AA90", VA = "0x184C7C290")]
			public static GCCOBGFBMBB CCPKJDCALBG(TRoot MJAMEBJFAIN, TDeps GGLINDGLEPB, TUnification KJFNLIOHHLM, TGraph OPFJIIPHLBO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4C7D0B0", Offset = "0x4C7B8B0", VA = "0x184C7D0B0")]
			public TType IELFOJJOEFA()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4C7C950", Offset = "0x4C7B150", VA = "0x184C7C950")]
			public GIFDADDBAEH<TType> DNNBOOFNBBB(GIFDADDBAEH<TType> NOGJAHKGFJD, GIFDADDBAEH<TType> LHMEHOJLNDH)
			{
				return default(GIFDADDBAEH<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4C7E140", Offset = "0x4C7C940", VA = "0x184C7E140")]
			public int ONIEKMBNGMB(TNode CJEDGIAKFCF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4C7CC90", Offset = "0x4C7B490", VA = "0x184C7CC90")]
			public int EJBNLJMHNLH(TNode CJEDGIAKFCF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4C7CE30", Offset = "0x4C7B630", VA = "0x184C7CE30")]
			public TInput HNLNOGMODKG(TNode CJEDGIAKFCF, int PNJCJGEIDHG)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4C7BE40", Offset = "0x4C7A640", VA = "0x184C7BE40")]
			public int BAJNBMIHGFJ(TNode CJEDGIAKFCF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4C7CDE0", Offset = "0x4C7B5E0", VA = "0x184C7CDE0")]
			public TOutput HIFBADLGIPN(TNode CJEDGIAKFCF, int PNJCJGEIDHG)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4C7D540", Offset = "0x4C7BD40", VA = "0x184C7D540")]
			public IEnumerable<KJKKPLJKJDL<TType>> KFPBDIFDFDN(TNode CJEDGIAKFCF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4C7D930", Offset = "0x4C7C130", VA = "0x184C7D930")]
			public IEnumerable<IJNNCNENPLP<TNode>> KPLDEJHONBC([In] TNode CJEDGIAKFCF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4C7C140", Offset = "0x4C7A940", VA = "0x184C7C140")]
			public TType CBEFLMLPPJA(TInput FNFJALHKEGF)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4C7DDA0", Offset = "0x4C7C5A0", VA = "0x184C7DDA0")]
			public int NMHBGDKOHPH(TInput FNFJALHKEGF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4C7C020", Offset = "0x4C7A820", VA = "0x184C7C020")]
			public TOutput BNBHDPOIENK(TInput FNFJALHKEGF, int PNJCJGEIDHG)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4C7CAB0", Offset = "0x4C7B2B0", VA = "0x184C7CAB0")]
			public TNode EDAMBDOKJEF(TInput FNFJALHKEGF)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4C7DC00", Offset = "0x4C7C400", VA = "0x184C7DC00")]
			public TType NJMHCBBLGCP(TOutput ECOCMLPNFDM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4C7DBB0", Offset = "0x4C7C3B0", VA = "0x184C7DBB0")]
			public int LOGPELDGHHH(TOutput ECOCMLPNFDM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4C7E2E0", Offset = "0x4C7CAE0", VA = "0x184C7E2E0")]
			public TInput OOFPCMDBOHN(TOutput ECOCMLPNFDM, int PNJCJGEIDHG)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4C7C5F0", Offset = "0x4C7ADF0", VA = "0x184C7C5F0")]
			public TNode CKOIIMNECJM(TOutput ECOCMLPNFDM)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4C7DAA0", Offset = "0x4C7C2A0", VA = "0x184C7DAA0")]
			public bool LFKNFAEJDNH(TType CEPGAJKBPDM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4C7C4B0", Offset = "0x4C7ACB0", VA = "0x184C7C4B0")]
			public TType CHIHMKANGIK(TType CEPGAJKBPDM, IEnumerable<TType> HLOKMICNGBM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4C7D6E0", Offset = "0x4C7BEE0", VA = "0x184C7D6E0")]
			public void KLKFHGBLNDM(TType CEPGAJKBPDM, Action<TType> CHENMEEMFFG, Action<TType> JPABDJHEFNJ, Action<TType> BOHMJMOLBOC, Action<TType> KILBGMENEIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4C7E3E0", Offset = "0x4C7CBE0", VA = "0x184C7E3E0")]
			public TType PGNPAFBGHCC(TType CEPGAJKBPDM)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4C7DF70", Offset = "0x4C7C770", VA = "0x184C7DF70")]
			public string OBHGFLGCIDB(TType CEPGAJKBPDM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4C7D440", Offset = "0x4C7BC40", VA = "0x184C7D440")]
			public TTerm JDJNBBJEAFF()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4C7CFE0", Offset = "0x4C7B7E0", VA = "0x184C7CFE0")]
			public TTerm IDNCFINMDFF(TTerm NEJPKBEPJKI)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4C7DE30", Offset = "0x4C7C630", VA = "0x184C7DE30")]
			public TTerm NMPMOOMKADK(TTerm JPGKLKLGGMN, TTerm OOGMCHHLIPA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4C7B960", Offset = "0x4C7A160", VA = "0x184C7B960")]
			public void ACAPGBFGADC(TTerm NOGJAHKGFJD, TTerm LHMEHOJLNDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4C7D690", Offset = "0x4C7BE90", VA = "0x184C7D690")]
			public bool KKMFIDDBAIA(TOutputTerm NEJPKBEPJKI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4C7BC60", Offset = "0x4C7A460", VA = "0x184C7BC60")]
			public bool ANEJLPKGLBD(TOutputTerm NEJPKBEPJKI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4C7BB40", Offset = "0x4C7A340", VA = "0x184C7BB40")]
			public TTerm AEEIJPGLGHH(TOutputTerm NMEANLMLDPN)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4C7D210", Offset = "0x4C7BA10", VA = "0x184C7D210")]
			public TOutputTerm ILNDOMCEPFN(TOutputTerm NEJPKBEPJKI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4C7C7D0", Offset = "0x4C7AFD0", VA = "0x184C7C7D0")]
			public TOutputTerm DDHOFAHFOEE(TOutputTerm NEJPKBEPJKI)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4C7D860", Offset = "0x4C7C060", VA = "0x184C7D860")]
			public TTerm KOEPNBOCCKO(TOutputSubstitution BJNFGPEIDMM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4C7BD30", Offset = "0x4C7A530", VA = "0x184C7BD30")]
			public TOutputTerm BAHLJBPAPGJ(TOutputSubstitution BJNFGPEIDMM)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4C7D330", Offset = "0x4C7BB30", VA = "0x184C7D330")]
			public TOutputTerm JALHGNOGBMI(TTerm NEJPKBEPJKI)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class GINKLLPJKGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public GCCOBGFBMBB arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public GINKLLPJKGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x4C8C520", Offset = "0x4C8AD20", VA = "0x184C8C520")]
			internal int NEBCJOGNBLJ(GCCOBGFBMBB arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x4C8C3D0", Offset = "0x4C8ABD0", VA = "0x184C8C3D0")]
			internal TInput JFDFJKOPJPJ(GCCOBGFBMBB arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x4C8C370", Offset = "0x4C8AB70", VA = "0x184C8C370")]
			internal int IMFKLFPPLAH(GCCOBGFBMBB arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x4C8C600", Offset = "0x4C8AE00", VA = "0x184C8C600")]
			internal TOutput PGDIIBMFCIK(GCCOBGFBMBB arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IDIHHICPIGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public GCCOBGFBMBB arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, GINPDIOLJFC<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<GINPDIOLJFC<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public IDIHHICPIGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4E69930", Offset = "0x4E68130", VA = "0x184E69930")]
			internal (string, TTerm) HMPGJJIAHDH(KJKKPLJKJDL<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class OBLBDHKGNPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public GCCOBGFBMBB arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public OBLBDHKGNPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x571D3C0", Offset = "0x571BBC0", VA = "0x18571D3C0")]
			internal void NACFJAMBJIB(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x571CF10", Offset = "0x571B710", VA = "0x18571CF10")]
			internal void BBECLKMHHKC(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x571D1A0", Offset = "0x571B9A0", VA = "0x18571D1A0")]
			internal void IPMFFMIFHCG(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x571D680", Offset = "0x571BE80", VA = "0x18571D680")]
			internal void NIENNCAOGIC(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class AHIAGHHNJGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public GCCOBGFBMBB arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public AHIAGHHNJGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4BABE90", Offset = "0x4BAA690", VA = "0x184BABE90")]
			internal TTerm IFPOAHKJNBC(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x52EFAF0", Offset = "0x52EE2F0", VA = "0x1852EFAF0")]
		private static MMNJMCNIGPO GICJCKPMDNG([CallerMemberName] string HPANEBBHGAC = "")
		{
			return default(MMNJMCNIGPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x52EB740", Offset = "0x52E9F40", VA = "0x1852EB740")]
		public static Dictionary<TNode, List<KJKKPLJKJDL<TType>>> DEIIOCFCPAL(TRoot MJAMEBJFAIN, TDeps GGLINDGLEPB, TGraph OPFJIIPHLBO, IEnumerable<TNode> BLCKOOKMFDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x52ED680", Offset = "0x52EBE80", VA = "0x1852ED680")]
		private static (Dictionary<TTerm, GINPDIOLJFC<TNode>>, List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>>) GEGHMFLGFCP(IEnumerable<TNode> BLCKOOKMFDC, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return default((Dictionary<TTerm, GINPDIOLJFC<TNode>>, List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x52F3420", Offset = "0x52F1C20", VA = "0x1852F3420")]
		private static void LDLFIMCPJIE(TNode CJEDGIAKFCF, Dictionary<TInput, TTerm> HPNCIANAIPP, Dictionary<TOutput, TTerm> LDIFMLCOMJM, Dictionary<TTerm, GINPDIOLJFC<TNode>> NPBFMPCGLJD, Dictionary<GINPDIOLJFC<TNode>, TTerm> MDFGJPGJKBN, List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> IJCMBFEAEFE, Stack<TNode> CPKOIFAJJPD, List<IJNNCNENPLP<TNode>> MBJPGGEMJNH, GCCOBGFBMBB OPAHMKOAAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x52F0530", Offset = "0x52EED30", VA = "0x1852F0530")]
		private static Dictionary<string, TTerm> JELJCMEANLM(TNode CJEDGIAKFCF, Dictionary<TTerm, GINPDIOLJFC<TNode>> NPBFMPCGLJD, Dictionary<GINPDIOLJFC<TNode>, TTerm> CJMFCPGJIHI, List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> IJCMBFEAEFE, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x417F3A0", Offset = "0x417DBA0", VA = "0x18417F3A0")]
		private static (TPort, TTerm)[] BNLPMNFFMDN<TPort>(TNode CJEDGIAKFCF, Func<GCCOBGFBMBB, TNode, int> DGFILFMELLD, Func<GCCOBGFBMBB, TNode, int, TPort> MMBNCCFCBHN, Func<GCCOBGFBMBB, TPort, TType> EFIEAPDDFGH, Dictionary<TPort, TTerm> DMAINMGBGAK, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x52F6AD0", Offset = "0x52F52D0", VA = "0x1852F6AD0")]
		private static (TTerm, TTerm) LHIDKPDMJOE((TOutput Output, TTerm Id)[] BELGJOIAGCG, List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> IJCMBFEAEFE, Dictionary<string, TTerm> CJMFCPGJIHI, Stack<TNode> CPKOIFAJJPD, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x52E6360", Offset = "0x52E4B60", VA = "0x1852E6360")]
		private static void AADCAGJFHBF((TInput PortKey, TTerm Id)[] JJPGLAJNPLK, TTerm JNLKPBIMJDB, TTerm IIEHFKADOJJ, List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> IJCMBFEAEFE, Dictionary<TOutput, TTerm> LDIFMLCOMJM, Dictionary<string, TTerm> CJMFCPGJIHI, Stack<TNode> CPKOIFAJJPD, GCCOBGFBMBB OPAHMKOAAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x52ED0B0", Offset = "0x52EB8B0", VA = "0x1852ED0B0")]
		private static TTerm EEHHPMLMAJK(TInput FNFJALHKEGF, List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> IJCMBFEAEFE, Dictionary<TOutput, TTerm> LDIFMLCOMJM, Stack<TNode> CPKOIFAJJPD, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x52EFB70", Offset = "0x52EE370", VA = "0x1852EFB70")]
		private static TTerm JAIMEDIPFAG([In] TType CEPGAJKBPDM, IOKind OHKMCDAJBCD, List<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> IJCMBFEAEFE, IReadOnlyDictionary<string, TTerm> CJMFCPGJIHI, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x52FAE20", Offset = "0x52F9620", VA = "0x1852FAE20")]
		private static Dictionary<TNode, List<KJKKPLJKJDL<TType>>> PMHJHMDBDCF(TOutputSubstitution[] LMPCMCBDIBI, Dictionary<TTerm, GINPDIOLJFC<TNode>> NPBFMPCGLJD, IEnumerable<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> IJCMBFEAEFE, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x52F0880", Offset = "0x52EF080", VA = "0x1852F0880")]
		private static Dictionary<TNode, List<KJKKPLJKJDL<TType>>> KNIFIGIDAFE(Dictionary<TTerm, GINPDIOLJFC<TNode>> NPBFMPCGLJD, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x52F1B70", Offset = "0x52F0370", VA = "0x1852F1B70")]
		private static void LAJHOKPDJEC([In] TNode CJEDGIAKFCF, Stack<TNode> CPKOIFAJJPD, List<IJNNCNENPLP<TNode>> MBJPGGEMJNH, GCCOBGFBMBB OPAHMKOAAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x52F2480", Offset = "0x52F0C80", VA = "0x1852F2480")]
		private static void LDHIHFAHDBG(Dictionary<GINPDIOLJFC<TNode>, TTerm> CJMFCPGJIHI, List<IJNNCNENPLP<TNode>> MBJPGGEMJNH, GCCOBGFBMBB OPAHMKOAAKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x52E7F50", Offset = "0x52E6750", VA = "0x1852E7F50")]
		private static Dictionary<TTerm, TType> BBEDHAMNIOO(Dictionary<TTerm, TOutputSubstitution> LMPCMCBDIBI, IEnumerable<KeyValuePair<TTerm, GIFDADDBAEH<TType>>> IJCMBFEAEFE, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x52F8860", Offset = "0x52F7060", VA = "0x1852F8860")]
		private static ABDLIOMCAFI<TType> NGAIFCKHGPF(TOutputTerm CEPGAJKBPDM, Dictionary<TTerm, TType> IJCMBFEAEFE, Dictionary<TTerm, TType> LPHLJKPCIAD, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return default(ABDLIOMCAFI<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x52F9FA0", Offset = "0x52F87A0", VA = "0x1852F9FA0")]
		private static TOutputTerm PLGNMBOFCOL(TOutputTerm JAGAGDGMNKJ, GCCOBGFBMBB OPAHMKOAAKD)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E050", Offset = "0x3A8C850", VA = "0x183A8E050")]
	public static Dictionary<TNode, List<KJKKPLJKJDL<TType>>> DEIIOCFCPAL<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::AHCAGPJPCNK<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DKBBJFIDEGB, TRoot MJAMEBJFAIN, TGraph OPFJIIPHLBO, IEnumerable<TNode> BLCKOOKMFDC) where TDeps : global::APOLDDKDPBF<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KJKKPLJKJDL<TType> : IEquatable<KJKKPLJKJDL<TType>>, FLLPMOIALDN<KJKKPLJKJDL<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string NCBGIDALPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType HMJFFNAGIMG;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4E7C040", Offset = "0x4E7A840", VA = "0x184E7C040")]
	internal KJKKPLJKJDL(string HPANEBBHGAC, [In] TType NDKNJOCDHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x51B9230", Offset = "0x51B7A30", VA = "0x1851B9230")]
	public bool HGEOBDDFMIA([In] KJKKPLJKJDL<TType> KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x51B91E0", Offset = "0x51B79E0", VA = "0x1851B91E0", Slot = "4")]
	public bool Equals(KJKKPLJKJDL<TType> KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A670", Offset = "0x4C58E70", VA = "0x184C5A670", Slot = "0")]
	public override bool Equals(object KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C880", Offset = "0x4C8B080", VA = "0x184C8C880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x51B9360", Offset = "0x51B7B60", VA = "0x1851B9360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x51B9310", Offset = "0x51B7B10", VA = "0x1851B9310", Slot = "5")]
	private bool MAMLBEFIEGA([In] KJKKPLJKJDL<TType> KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NLNKJKFBKPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3B4AFB0", Offset = "0x3B497B0", VA = "0x183B4AFB0")]
	public static KJKKPLJKJDL<TType> CCPKJDCALBG<TType>(string HPANEBBHGAC, TType NDKNJOCDHNB)
	{
		return default(KJKKPLJKJDL<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x3B4AFE0", Offset = "0x3B497E0", VA = "0x183B4AFE0")]
	public static (string, TType) HIIFOPLNPIJ<TType>([In] this KJKKPLJKJDL<TType> DKBBJFIDEGB)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GINPDIOLJFC<TNode> : IEquatable<GINPDIOLJFC<TNode>>, FLLPMOIALDN<GINPDIOLJFC<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode DKNBIFDHJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string NCBGIDALPJM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x175B230", Offset = "0x1759A30", VA = "0x18175B230")]
	internal GINPDIOLJFC(TNode CJEDGIAKFCF, string HPANEBBHGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C8E0", Offset = "0x4C8B0E0", VA = "0x184C8C8E0")]
	public bool HGEOBDDFMIA([In] GINPDIOLJFC<TNode> KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C720", Offset = "0x4C8AF20", VA = "0x184C8C720", Slot = "4")]
	public bool Equals(GINPDIOLJFC<TNode> KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4C5A670", Offset = "0x4C58E70", VA = "0x184C5A670", Slot = "0")]
	public override bool Equals(object KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C810", Offset = "0x4C8B010", VA = "0x184C8C810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CAA0", Offset = "0x4C8B2A0", VA = "0x184C8CAA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C770", Offset = "0x4C8AF70", VA = "0x184C8C770", Slot = "5")]
	private bool GLEMGPNLOEH([In] GINPDIOLJFC<TNode> KEKEFPAJGHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IHDNMEGDEJH
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A20740", Offset = "0x3A1EF40", VA = "0x183A20740")]
	public static GINPDIOLJFC<TNode> CCPKJDCALBG<TNode>(TNode CJEDGIAKFCF, string HPANEBBHGAC)
	{
		return default(GINPDIOLJFC<TNode>);
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
