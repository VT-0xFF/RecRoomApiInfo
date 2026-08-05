using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct FKDFPMIFGKI<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType LLHMNEIJLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind LJKLOHFBGFH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x92AE10", Offset = "0x92A210", VA = "0x18092AE10")]
	internal FKDFPMIFGKI(TType EKNPHEPNHJD, IOKind DLDNIOIBGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3F4D970", Offset = "0x3F4CD70", VA = "0x183F4D970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LODGLOEFKOH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6490", Offset = "0x2FA5890", VA = "0x182FA6490")]
	public static FKDFPMIFGKI<TType> GIIIFAJNKEL<TType>(TType EKNPHEPNHJD, IOKind DLDNIOIBGAB)
	{
		return default(FKDFPMIFGKI<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2FA64C0", Offset = "0x2FA58C0", VA = "0x182FA64C0")]
	public static (TType, IOKind) KIHLJCKLJEM<TType>([In] this FKDFPMIFGKI<TType> EAFEIEDNLNL)
	{
		return default((TType, IOKind));
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6500", Offset = "0x2FA5900", VA = "0x182FA6500")]
	public static void NKENCEMDNGD<TType>([In] this FKDFPMIFGKI<TType> EAFEIEDNLNL, [Out] TType EKNPHEPNHJD, [Out] IOKind DLDNIOIBGAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct PFOAALJKPBI<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly GBIGLBILOPK<TNode> AOLBALAPNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GBIGLBILOPK<TNode> EJJFPHCLCFG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4B2DBE0", Offset = "0x4B2CFE0", VA = "0x184B2DBE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IAEGGBHMCIC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2EDBFC0", Offset = "0x2EDB3C0", VA = "0x182EDBFC0")]
	public static (GBIGLBILOPK<TNode>, GBIGLBILOPK<TNode>) KIHLJCKLJEM<TNode>([In] this PFOAALJKPBI<TNode> EAFEIEDNLNL)
	{
		return default((GBIGLBILOPK<TNode>, GBIGLBILOPK<TNode>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2EDC060", Offset = "0x2EDB460", VA = "0x182EDC060")]
	public static void NKENCEMDNGD<TNode>([In] this PFOAALJKPBI<TNode> EAFEIEDNLNL, [Out] GBIGLBILOPK<TNode> CGCHNDGEIJH, [Out] GBIGLBILOPK<TNode> LEGMFFDGEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KEHNAEMOGLH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DEPHANMOGLG MOEPFIHAACH(TRoot DADDPLMNJHB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType HGGGAAOBHAP(TRoot DADDPLMNJHB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKDFPMIFGKI<TType> BPIFLFDOEJE(TRoot DADDPLMNJHB, [In] FKDFPMIFGKI<TType> MMHCOKHACHF, [In] FKDFPMIFGKI<TType> DEOGINMLLDP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HCKDHMAHKHM(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TNode NAALEPHLNNP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BPLKCEHNGGH(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TNode NAALEPHLNNP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput NBNEHKGPOEB(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TNode NAALEPHLNNP, int OBFJPFHENMC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NIEECDKFJNI(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TNode NAALEPHLNNP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput PKFHEJIAEHK(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TNode NAALEPHLNNP, int OBFJPFHENMC);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CABPIHLHGLK<TType>> FCMJFIOBJLI(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TNode NAALEPHLNNP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<PFOAALJKPBI<TNode>> ECFOPBIIPNK(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TNode NAALEPHLNNP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType PKNODEPPNJO(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TInput CMILLOOAKEN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int PFMGHGIGOGJ(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TInput CMILLOOAKEN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput AIDKAKPLCHG(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TInput CMILLOOAKEN, int OBFJPFHENMC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode OEGMOGGHBJL(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TInput CMILLOOAKEN);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType PNFKBKIEGNH(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TOutput OIDJAKEJHMI);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int OMDKPJCNNDK(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TOutput OIDJAKEJHMI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput PKKMJGPHDJB(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TOutput OIDJAKEJHMI, int OBFJPFHENMC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode NDEHNLKMAIM(TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, TOutput OIDJAKEJHMI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PAKHAFPKHCE(TRoot DADDPLMNJHB, TType EKNPHEPNHJD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType DOOOLJEHHJJ(TRoot DADDPLMNJHB, TType EKNPHEPNHJD, IEnumerable<TType> JHOPEAAJIBL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GBFEOFFKAGP(TRoot DADDPLMNJHB, TType EKNPHEPNHJD, Action<TType> CEPHBKOMNPP, Action<TType> NMOHHKJNILE, Action<TType> HGIJFHBDHDP, Action<TType> ABCMEFAKMLC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType GLAKEEONFGD(TRoot DADDPLMNJHB, TType EKNPHEPNHJD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string DHGHKICLDJE(TRoot DADDPLMNJHB, TType EKNPHEPNHJD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification HGABPPABEIE(TRoot DADDPLMNJHB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "24")]
	BMFECDODLAB<TOutputSubstitution[], MBCBLBGJNJI> EBIGABOGBNJ(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm EMAOICBMIMP(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm PPEMCHNJNME(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TTerm GCFDOAHONPH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm JPBMLEKHAMN(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TTerm DDHIPMFIJHI, TTerm FMMMPENKMMF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OFMJPJEPEOD(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TTerm MMHCOKHACHF, TTerm DEOGINMLLDP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool IDJOFHCHEKC(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TOutputTerm DIBIKKMJBEG);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool GHANJCCLDKB(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TOutputTerm DIBIKKMJBEG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm CLPKMGMCELO(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TOutputTerm DIBIKKMJBEG);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm GOFOLIGIOHL(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TOutputTerm DIBIKKMJBEG);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm HMKDDDDIEGM(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TOutputTerm DIBIKKMJBEG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm EIDJNAJJAKP(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TOutputSubstitution KOEMAPACFEJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm OJPGFDDHGEC(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TOutputSubstitution KOEMAPACFEJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm EBDLCNCOLKK(TRoot DADDPLMNJHB, TUnification KKIOFCCOOOP, TTerm GCFDOAHONPH);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct OFOGPIBMKIH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::KEHNAEMOGLH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0")]
	public static global::OFOGPIBMKIH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> GIIIFAJNKEL()
	{
		return default(global::OFOGPIBMKIH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FDNAAMBPNIP
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private static class LAJDLKNPCLG<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::KEHNAEMOGLH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private sealed class OHMEOFEOIHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot FNBAEIOODBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps FBPPDGNLPDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification HLNLAKDAEPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph FLHKJLAHBAL;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public DEPHANMOGLG PLPMMOLIEOC
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x4A5ABD0", Offset = "0x4A59FD0", VA = "0x184A5ABD0")]
				get
				{
					return default(DEPHANMOGLG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4A5C9D0", Offset = "0x4A5BDD0", VA = "0x184A5C9D0")]
			private OHMEOFEOIHJ(TRoot DADDPLMNJHB, TDeps PJBENGOCCDF, TUnification MGJPKKIKGBL, TGraph ENLCABFJIOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4A5AF80", Offset = "0x4A5A380", VA = "0x184A5AF80")]
			public static OHMEOFEOIHJ GIIIFAJNKEL(TRoot DADDPLMNJHB, TDeps PJBENGOCCDF, TUnification MGJPKKIKGBL, TGraph ENLCABFJIOK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B490", Offset = "0x4A5A890", VA = "0x184A5B490")]
			public TType HGGGAAOBHAP()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A270", Offset = "0x4A59670", VA = "0x184A5A270")]
			public FKDFPMIFGKI<TType> BPIFLFDOEJE(FKDFPMIFGKI<TType> MMHCOKHACHF, FKDFPMIFGKI<TType> DEOGINMLLDP)
			{
				return default(FKDFPMIFGKI<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B450", Offset = "0x4A5A850", VA = "0x184A5B450")]
			public int HCKDHMAHKHM(TNode NAALEPHLNNP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A3F0", Offset = "0x4A597F0", VA = "0x184A5A3F0")]
			public int BPLKCEHNGGH(TNode NAALEPHLNNP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4A5BC50", Offset = "0x4A5B050", VA = "0x184A5BC50")]
			public TInput NBNEHKGPOEB(TNode NAALEPHLNNP, int OBFJPFHENMC)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4A5BF40", Offset = "0x4A5B340", VA = "0x184A5BF40")]
			public int NIEECDKFJNI(TNode NAALEPHLNNP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4A5C470", Offset = "0x4A5B870", VA = "0x184A5C470")]
			public TOutput PKFHEJIAEHK(TNode NAALEPHLNNP, int OBFJPFHENMC)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A9F0", Offset = "0x4A59DF0", VA = "0x184A5A9F0")]
			public IEnumerable<CABPIHLHGLK<TType>> FCMJFIOBJLI(TNode NAALEPHLNNP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A780", Offset = "0x4A59B80", VA = "0x184A5A780")]
			public IEnumerable<PFOAALJKPBI<TNode>> ECFOPBIIPNK([In] TNode NAALEPHLNNP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4A5C6B0", Offset = "0x4A5BAB0", VA = "0x184A5C6B0")]
			public TType PKNODEPPNJO(TInput CMILLOOAKEN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4A5BA50", Offset = "0x4A5AE50", VA = "0x184A5BA50")]
			public int NAEFFFBHKCC(TInput CMILLOOAKEN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A090", Offset = "0x4A59490", VA = "0x184A5A090")]
			public TOutput AIDKAKPLCHG(TInput CMILLOOAKEN, int OBFJPFHENMC)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4A5BFC0", Offset = "0x4A5B3C0", VA = "0x184A5BFC0")]
			public TNode OEGMOGGHBJL(TInput CMILLOOAKEN)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4A5C810", Offset = "0x4A5BC10", VA = "0x184A5C810")]
			public TType PNFKBKIEGNH(TOutput OIDJAKEJHMI)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4A5BE80", Offset = "0x4A5B280", VA = "0x184A5BE80")]
			public int NHHJDHHKEMB(TOutput OIDJAKEJHMI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4A5C5E0", Offset = "0x4A5B9E0", VA = "0x184A5C5E0")]
			public TInput PKKMJGPHDJB(TOutput OIDJAKEJHMI, int OBFJPFHENMC)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4A5BD70", Offset = "0x4A5B170", VA = "0x184A5BD70")]
			public TNode NDEHNLKMAIM(TOutput OIDJAKEJHMI)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4A5C300", Offset = "0x4A5B700", VA = "0x184A5C300")]
			public bool PAKHAFPKHCE(TType EKNPHEPNHJD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A600", Offset = "0x4A59A00", VA = "0x184A5A600")]
			public TType DOOOLJEHHJJ(TType EKNPHEPNHJD, IEnumerable<TType> JHOPEAAJIBL)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4A5AD10", Offset = "0x4A5A110", VA = "0x184A5AD10")]
			public void GBFEOFFKAGP(TType EKNPHEPNHJD, Action<TType> CEPHBKOMNPP, Action<TType> NMOHHKJNILE, Action<TType> HGIJFHBDHDP, Action<TType> ABCMEFAKMLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B210", Offset = "0x4A5A610", VA = "0x184A5B210")]
			public TType GLAKEEONFGD(TType EKNPHEPNHJD)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A430", Offset = "0x4A59830", VA = "0x184A5A430")]
			public string DHGHKICLDJE(TType EKNPHEPNHJD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A9B0", Offset = "0x4A59DB0", VA = "0x184A5A9B0")]
			public TTerm EMAOICBMIMP()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4A5C950", Offset = "0x4A5BD50", VA = "0x184A5C950")]
			public TTerm PPEMCHNJNME(TTerm GCFDOAHONPH)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B7B0", Offset = "0x4A5ABB0", VA = "0x184A5B7B0")]
			public TTerm JPBMLEKHAMN(TTerm DDHIPMFIJHI, TTerm FMMMPENKMMF)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x4A5C1C0", Offset = "0x4A5B5C0", VA = "0x184A5C1C0")]
			public void OFMJPJEPEOD(TTerm MMHCOKHACHF, TTerm DEOGINMLLDP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4A5AE30", Offset = "0x4A5A230", VA = "0x184A5AE30")]
			public bool GHANJCCLDKB(TOutputTerm GCFDOAHONPH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B770", Offset = "0x4A5AB70", VA = "0x184A5B770")]
			public bool IDJOFHCHEKC(TOutputTerm GCFDOAHONPH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B9D0", Offset = "0x4A5ADD0", VA = "0x184A5B9D0")]
			public TTerm MJFLGNHKOMC(TOutputTerm DIBIKKMJBEG)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B310", Offset = "0x4A5A710", VA = "0x184A5B310")]
			public TOutputTerm GOFOLIGIOHL(TOutputTerm GCFDOAHONPH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4A5B5B0", Offset = "0x4A5A9B0", VA = "0x184A5B5B0")]
			public TOutputTerm HMKDDDDIEGM(TOutputTerm GCFDOAHONPH)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A840", Offset = "0x4A59C40", VA = "0x184A5A840")]
			public TTerm EIDJNAJJAKP(TOutputSubstitution NJLFKGFEADK)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4A5C240", Offset = "0x4A5B640", VA = "0x184A5C240")]
			public TOutputTerm OJPGFDDHGEC(TOutputSubstitution NJLFKGFEADK)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4A5A640", Offset = "0x4A59A40", VA = "0x184A5A640")]
			public TOutputTerm EBDLCNCOLKK(TTerm GCFDOAHONPH)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class CPIGHBGBKMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public OHMEOFEOIHJ arg;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public CPIGHBGBKMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5727FE0", Offset = "0x57273E0", VA = "0x185727FE0")]
			internal int PPGLGNEIDCD(OHMEOFEOIHJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5727EC0", Offset = "0x57272C0", VA = "0x185727EC0")]
			internal TInput HOIAEFKPJHL(OHMEOFEOIHJ arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5727F80", Offset = "0x5727380", VA = "0x185727F80")]
			internal int JFGNMMDALBB(OHMEOFEOIHJ arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5727C80", Offset = "0x5727080", VA = "0x185727C80")]
			internal TOutput EOIGLOAPDCF(OHMEOFEOIHJ arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class IACDANDOEMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public OHMEOFEOIHJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, GBIGLBILOPK<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<GBIGLBILOPK<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public IACDANDOEMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x41FBB00", Offset = "0x41FAF00", VA = "0x1841FBB00")]
			internal (string, TTerm) AENBOAGLCHB(CABPIHLHGLK<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class BOMNOBMMOHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public OHMEOFEOIHJ arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> idToType;

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
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public BOMNOBMMOHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5278C40", Offset = "0x5278040", VA = "0x185278C40")]
			internal void JOGCCMFNOLM(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x52787C0", Offset = "0x5277BC0", VA = "0x1852787C0")]
			internal void CJIFAEJLIBN(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5279390", Offset = "0x5278790", VA = "0x185279390")]
			internal void LCHGLOKIKBK(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x52784A0", Offset = "0x52778A0", VA = "0x1852784A0")]
			internal void AJHNCBCABHO(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class JOMJPJOAAMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OHMEOFEOIHJ arg;

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
			public JOMJPJOAAMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3B66E50", Offset = "0x3B66250", VA = "0x183B66E50")]
			internal TTerm LMKEPBDLENK(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x45C9B00", Offset = "0x45C8F00", VA = "0x1845C9B00")]
		private static CFPHNJHCPKH IAJAJHKBKPC([CallerMemberName] string ACDGEPBIBHJ = "")
		{
			return default(CFPHNJHCPKH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x45C61A0", Offset = "0x45C55A0", VA = "0x1845C61A0")]
		public static Dictionary<TNode, List<CABPIHLHGLK<TType>>> EEIGOFMMNEF(TRoot DADDPLMNJHB, TDeps PJBENGOCCDF, TGraph ENLCABFJIOK, IEnumerable<TNode> OGGHGIFNCGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x45CA490", Offset = "0x45C9890", VA = "0x1845CA490")]
		private static (Dictionary<TTerm, GBIGLBILOPK<TNode>>, List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>>) KLJALPPHMPP(IEnumerable<TNode> OGGHGIFNCGF, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return default((Dictionary<TTerm, GBIGLBILOPK<TNode>>, List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x45C7E50", Offset = "0x45C7250", VA = "0x1845C7E50")]
		private static void GDJFBHLHKOG(TNode NAALEPHLNNP, Dictionary<TInput, TTerm> HEJPNEIPHGM, Dictionary<TOutput, TTerm> GCLJCBMKMHO, Dictionary<TTerm, GBIGLBILOPK<TNode>> CEMFCEMNPHL, Dictionary<GBIGLBILOPK<TNode>, TTerm> KMOBMFELJFN, List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> MEPFFIPKBDK, Stack<TNode> JKCEPEGIAFM, List<PFOAALJKPBI<TNode>> ELBMJLCFMPJ, OHMEOFEOIHJ IDJEKAFFOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x45CA160", Offset = "0x45C9560", VA = "0x1845CA160")]
		private static Dictionary<string, TTerm> KJHCFLLCHJJ(TNode NAALEPHLNNP, Dictionary<TTerm, GBIGLBILOPK<TNode>> CEMFCEMNPHL, Dictionary<GBIGLBILOPK<TNode>, TTerm> EHNIDKAIBGO, List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> MEPFFIPKBDK, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3068150", Offset = "0x3067550", VA = "0x183068150")]
		private static (TPort, TTerm)[] OPIOBLBOLBK<TPort>(TNode NAALEPHLNNP, Func<OHMEOFEOIHJ, TNode, int> ICCIMKKFKCK, Func<OHMEOFEOIHJ, TNode, int, TPort> BDHOPIBIGCO, Func<OHMEOFEOIHJ, TPort, TType> IGBMEKDLBGA, Dictionary<TPort, TTerm> NJGNJKKCMKJ, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x45C6780", Offset = "0x45C5B80", VA = "0x1845C6780")]
		private static (TTerm, TTerm) FHBGBPCLJPO((TOutput Output, TTerm Id)[] NFDCAHOLMGO, List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> MEPFFIPKBDK, Dictionary<string, TTerm> EHNIDKAIBGO, Stack<TNode> JKCEPEGIAFM, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x45CBA20", Offset = "0x45CAE20", VA = "0x1845CBA20")]
		private static void OIELPKEJFHM((TInput PortKey, TTerm Id)[] DFCNNFBLEHB, TTerm ACDHPDFADHO, TTerm FALEPOBLLNB, List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> MEPFFIPKBDK, Dictionary<TOutput, TTerm> GCLJCBMKMHO, Dictionary<string, TTerm> EHNIDKAIBGO, Stack<TNode> JKCEPEGIAFM, OHMEOFEOIHJ IDJEKAFFOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x45CB4A0", Offset = "0x45CA8A0", VA = "0x1845CB4A0")]
		private static TTerm MPINDGDNCDN(TInput CMILLOOAKEN, List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> MEPFFIPKBDK, Dictionary<TOutput, TTerm> GCLJCBMKMHO, Stack<TNode> JKCEPEGIAFM, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x45C5690", Offset = "0x45C4A90", VA = "0x1845C5690")]
		private static TTerm CCEILKCBDKJ([In] TType EKNPHEPNHJD, IOKind DLDNIOIBGAB, List<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> MEPFFIPKBDK, IReadOnlyDictionary<string, TTerm> EHNIDKAIBGO, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x45C4A00", Offset = "0x45C3E00", VA = "0x1845C4A00")]
		private static Dictionary<TNode, List<CABPIHLHGLK<TType>>> ACJMKACIFOE(TOutputSubstitution[] HAKANKMNHOF, Dictionary<TTerm, GBIGLBILOPK<TNode>> CEMFCEMNPHL, IEnumerable<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> MEPFFIPKBDK, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x45C9CB0", Offset = "0x45C90B0", VA = "0x1845C9CB0")]
		private static Dictionary<TNode, List<CABPIHLHGLK<TType>>> JDAHEJADMAK(Dictionary<TTerm, GBIGLBILOPK<TNode>> CEMFCEMNPHL, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x45CB030", Offset = "0x45CA430", VA = "0x1845CB030")]
		private static void MFGAKJJJHLM([In] TNode NAALEPHLNNP, Stack<TNode> JKCEPEGIAFM, List<PFOAALJKPBI<TNode>> ELBMJLCFMPJ, OHMEOFEOIHJ IDJEKAFFOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x45C5CA0", Offset = "0x45C50A0", VA = "0x1845C5CA0")]
		private static void DIDCJBPJGFA(Dictionary<GBIGLBILOPK<TNode>, TTerm> EHNIDKAIBGO, List<PFOAALJKPBI<TNode>> ELBMJLCFMPJ, OHMEOFEOIHJ IDJEKAFFOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x45C8B00", Offset = "0x45C7F00", VA = "0x1845C8B00")]
		private static Dictionary<TTerm, TType> HLLHMECMMBB(Dictionary<TTerm, TOutputSubstitution> HAKANKMNHOF, IEnumerable<KeyValuePair<TTerm, FKDFPMIFGKI<TType>>> MEPFFIPKBDK, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x45C7570", Offset = "0x45C6970", VA = "0x1845C7570")]
		private static BLOKLLOGIFH<TType> FPNDPNEHDGP(TOutputTerm EKNPHEPNHJD, Dictionary<TTerm, TType> MEPFFIPKBDK, Dictionary<TTerm, TType> CLENOLHAPKH, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return default(BLOKLLOGIFH<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x45C9B40", Offset = "0x45C8F40", VA = "0x1845C9B40")]
		private static TOutputTerm INPAKBAKAOH(TOutputTerm PFNDLMMFNPO, OHMEOFEOIHJ IDJEKAFFOBD)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2E9CA60", Offset = "0x2E9BE60", VA = "0x182E9CA60")]
	public static Dictionary<TNode, List<CABPIHLHGLK<TType>>> EEIGOFMMNEF<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>([In] this global::OFOGPIBMKIH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> EAFEIEDNLNL, TRoot DADDPLMNJHB, TGraph ENLCABFJIOK, IEnumerable<TNode> OGGHGIFNCGF) where TDeps : global::KEHNAEMOGLH<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct CABPIHLHGLK<TType> : IEquatable<CABPIHLHGLK<TType>>, FADLILBKPAO<CABPIHLHGLK<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string MKBLEONOOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType EHMICGAFDCF;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5449E50", Offset = "0x5449250", VA = "0x185449E50")]
	internal CABPIHLHGLK(string ACDGEPBIBHJ, [In] TType AEAAOACNKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5449D30", Offset = "0x5449130", VA = "0x185449D30")]
	public bool NIPJNKKLBEI([In] CABPIHLHGLK<TType> OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5449C90", Offset = "0x5449090", VA = "0x185449C90", Slot = "4")]
	public bool Equals(CABPIHLHGLK<TType> OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4000900", Offset = "0x3FFFD00", VA = "0x184000900", Slot = "0")]
	public override bool Equals(object OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x22DD060", Offset = "0x22DC460", VA = "0x1822DD060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5449E10", Offset = "0x5449210", VA = "0x185449E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5449CE0", Offset = "0x54490E0", VA = "0x185449CE0", Slot = "5")]
	private bool MHPCIIONFEE([In] CABPIHLHGLK<TType> OGKFFDCECEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OEHKONDMEBD
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x308D860", Offset = "0x308CC60", VA = "0x18308D860")]
	public static CABPIHLHGLK<TType> GIIIFAJNKEL<TType>(string ACDGEPBIBHJ, TType AEAAOACNKMO)
	{
		return default(CABPIHLHGLK<TType>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x308D890", Offset = "0x308CC90", VA = "0x18308D890")]
	public static (string, TType) KIHLJCKLJEM<TType>([In] this CABPIHLHGLK<TType> EAFEIEDNLNL)
	{
		return default((string, TType));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct GBIGLBILOPK<TNode> : IEquatable<GBIGLBILOPK<TNode>>, FADLILBKPAO<GBIGLBILOPK<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode FCMDHLLJOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string MKBLEONOOOC;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x10D9F40", Offset = "0x10D9340", VA = "0x1810D9F40")]
	internal GBIGLBILOPK(TNode NAALEPHLNNP, string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4000B40", Offset = "0x3FFFF40", VA = "0x184000B40")]
	public bool NIPJNKKLBEI([In] GBIGLBILOPK<TNode> OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4000990", Offset = "0x3FFFD90", VA = "0x184000990", Slot = "4")]
	public bool Equals(GBIGLBILOPK<TNode> OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4000900", Offset = "0x3FFFD00", VA = "0x184000900", Slot = "0")]
	public override bool Equals(object OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4000A30", Offset = "0x3FFFE30", VA = "0x184000A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4000D40", Offset = "0x4000140", VA = "0x184000D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4000AF0", Offset = "0x3FFFEF0", VA = "0x184000AF0", Slot = "5")]
	private bool KJALAIBEKJM([In] GBIGLBILOPK<TNode> OGKFFDCECEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IICIKGCMHJO
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2D40", Offset = "0x2EE2140", VA = "0x182EE2D40")]
	public static GBIGLBILOPK<TNode> GIIIFAJNKEL<TNode>(TNode NAALEPHLNNP, string ACDGEPBIBHJ)
	{
		return default(GBIGLBILOPK<TNode>);
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
