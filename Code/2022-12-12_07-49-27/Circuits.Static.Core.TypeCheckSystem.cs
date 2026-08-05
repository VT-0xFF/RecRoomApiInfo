using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Utilities;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct AMCOBDJIIHJ<TType>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly TType PJDKMJMOPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IOKind MOBGJKPPDCD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x849E00", Offset = "0x848400", VA = "0x180849E00")]
	internal AMCOBDJIIHJ(TType MCLMFJEAHEC, IOKind FFDDNKCNBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3E33440", Offset = "0x3E31A40", VA = "0x183E33440")]
	public void EPGCMDKMDAG(out TType MCLMFJEAHEC, out IOKind FFDDNKCNBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3E33470", Offset = "0x3E31A70", VA = "0x183E33470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BHBLGDOPJFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x33B2C30", Offset = "0x33B1230", VA = "0x1833B2C30")]
	public static global::AMCOBDJIIHJ<TType> OJKIKDBCCPC<TType>(TType MCLMFJEAHEC, IOKind FFDDNKCNBMJ)
	{
		return default(global::AMCOBDJIIHJ<TType>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct FFHLNGJDMPJ<TNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly global::IOLFGMBPFCG<TNode> CBMCHMEJJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly global::IOLFGMBPFCG<TNode> JFHOMJMGGLO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBC90", Offset = "0x3DEA290", VA = "0x183DEBC90")]
	public void EPGCMDKMDAG(out global::IOLFGMBPFCG<TNode> FFMFLKJEKLP, out global::IOLFGMBPFCG<TNode> PHDGNGLFBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3DEBCD0", Offset = "0x3DEA2D0", VA = "0x183DEBCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CEBFIIALNHO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NNAECIINGJO DGBEIPAHCII(TRoot COMPFMNMPEI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TType NLOBNFDEJMH(TRoot COMPFMNMPEI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::AMCOBDJIIHJ<TType> OFCFIJJLAJG(TRoot COMPFMNMPEI, in global::AMCOBDJIIHJ<TType> OLACFPEGPAG, in global::AMCOBDJIIHJ<TType> GLLCOOLKDAC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LGJMLPJMJEJ(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TNode ELOCLFMIMAL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CDNEEFCOMLB(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TNode ELOCLFMIMAL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	TInput EHMNMFIHKFA(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TNode ELOCLFMIMAL, int EBBLFLFCHFB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PDIDIFAANJB(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TNode ELOCLFMIMAL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	TOutput GFPAKOFAMBK(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TNode ELOCLFMIMAL, int EBBLFLFCHFB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<global::AMPLMBDHAJB<TType>> BPGHIAIMLDM(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TNode ELOCLFMIMAL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<global::FFHLNGJDMPJ<TNode>> KLBDFAKONKG(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TNode ELOCLFMIMAL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	TType ACHOPHFMIBM(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TInput OHEHJIBMMJC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int EPPCAPCDKJO(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TInput OHEHJIBMMJC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	TOutput LGMIPEEONNL(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TInput OHEHJIBMMJC, int EBBLFLFCHFB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	TNode HGKOMBKELGP(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TInput OHEHJIBMMJC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "14")]
	TType ICIOEFKGLLJ(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TOutput ACJBEKDAGDG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int FJDHLALLNCM(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TOutput ACJBEKDAGDG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "16")]
	TInput DBGNLEDLNII(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TOutput ACJBEKDAGDG, int EBBLFLFCHFB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "17")]
	TNode BENEHJGMDAP(TRoot COMPFMNMPEI, TGraph HOHEJAGNDDK, TOutput ACJBEKDAGDG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HNBFOFELCNI(TRoot COMPFMNMPEI, TType MCLMFJEAHEC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	TType EGBINAFPCJJ(TRoot COMPFMNMPEI, TType MCLMFJEAHEC, IEnumerable<TType> DBMBMHIKCIN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CPBMGDHGCLN(TRoot COMPFMNMPEI, TType MCLMFJEAHEC, Action<TType> LGNPKBHOEEL, Action<TType> PNEILDGPKMF, Action<TType> MPDJBPLOICN, Action<TType> DLBBMGAPFOB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	TType JDEIABONFPJ(TRoot COMPFMNMPEI, TType MCLMFJEAHEC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	string OCIBAHEMDHJ(TRoot COMPFMNMPEI, TType MCLMFJEAHEC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	TUnification ALGCMLMGPCP(TRoot COMPFMNMPEI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	global::IKEELLNFFOM<TOutputSubstitution[], IHHGNGPIMCG> NGKMNIDEGJO(TRoot COMPFMNMPEI, TUnification GAGABPELEGB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "25")]
	TTerm NHIMCLFBPFK(TRoot COMPFMNMPEI, TUnification GAGABPELEGB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "26")]
	TTerm BIGFDMIDLGD(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TTerm HMADEPFLLKA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "27")]
	TTerm CLICLDDFNDM(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TTerm PHEBOHLEEKJ, TTerm KCHHIMPOGLA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JOFJGENJODF(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TTerm OLACFPEGPAG, TTerm GLLCOOLKDAC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool HCFDONFBAGN(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TOutputTerm OLBIGEINLMM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KOPNMPCKBFL(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TOutputTerm OLBIGEINLMM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "31")]
	TTerm ANEJMBJCOJN(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TOutputTerm OLBIGEINLMM);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "32")]
	TOutputTerm GAHLOACLFAF(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TOutputTerm OLBIGEINLMM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "33")]
	TOutputTerm ECJDBINGBOH(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TOutputTerm OLBIGEINLMM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "34")]
	TTerm FANIBOPOFJF(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TOutputSubstitution GCLHAIBDJHL);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	TOutputTerm FIDKDPLMHBG(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TOutputSubstitution GCLHAIBDJHL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	TOutputTerm ININGMAIDFD(TRoot COMPFMNMPEI, TUnification GAGABPELEGB, TTerm HMADEPFLLKA);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OCMPAMOANNP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CEBFIIALNHO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260")]
	public static global::OCMPAMOANNP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> OJKIKDBCCPC()
	{
		return default(global::OCMPAMOANNP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class FBLHIFIBFHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private static class CBNPDNEEFGC<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> where TDeps : global::CEBFIIALNHO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private sealed class JFEOIGMKPEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TRoot AMKPOIHFDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly TDeps NBJAAFCKOIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TUnification PNEDJGHKBOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public TGraph CFOOLBNDKGK;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			public NNAECIINGJO GMNDPFPDAEA
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x3DB9BA0", Offset = "0x3DB81A0", VA = "0x183DB9BA0")]
				get
				{
					return default(NNAECIINGJO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB9A0", Offset = "0x3DB9FA0", VA = "0x183DBB9A0")]
			private JFEOIGMKPEK(TRoot COMPFMNMPEI, TDeps LCOMIHDGHCD, TUnification FEMKLCADIFL, TGraph HOHEJAGNDDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB7F0", Offset = "0x3DB9DF0", VA = "0x183DBB7F0")]
			public static JFEOIGMKPEK OJKIKDBCCPC(TRoot COMPFMNMPEI, TDeps LCOMIHDGHCD, TUnification FEMKLCADIFL, TGraph HOHEJAGNDDK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB3A0", Offset = "0x3DB99A0", VA = "0x183DBB3A0")]
			public TType NLOBNFDEJMH()
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB5E0", Offset = "0x3DB9BE0", VA = "0x183DBB5E0")]
			public global::AMCOBDJIIHJ<TType> OFCFIJJLAJG(global::AMCOBDJIIHJ<TType> OLACFPEGPAG, global::AMCOBDJIIHJ<TType> GLLCOOLKDAC)
			{
				return default(global::AMCOBDJIIHJ<TType>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB070", Offset = "0x3DB9670", VA = "0x183DBB070")]
			public int LGJMLPJMJEJ(TNode ELOCLFMIMAL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA030", Offset = "0x3DB8630", VA = "0x183DBA030")]
			public int CDNEEFCOMLB(TNode ELOCLFMIMAL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA570", Offset = "0x3DB8B70", VA = "0x183DBA570")]
			public TInput EHMNMFIHKFA(TNode ELOCLFMIMAL, int EBBLFLFCHFB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB8E0", Offset = "0x3DB9EE0", VA = "0x183DBB8E0")]
			public int PDIDIFAANJB(TNode ELOCLFMIMAL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA890", Offset = "0x3DB8E90", VA = "0x183DBA890")]
			public TOutput GFPAKOFAMBK(TNode ELOCLFMIMAL, int EBBLFLFCHFB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9EB0", Offset = "0x3DB84B0", VA = "0x183DB9EB0")]
			public IEnumerable<global::AMPLMBDHAJB<TType>> BPGHIAIMLDM(TNode ELOCLFMIMAL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3DBAF80", Offset = "0x3DB9580", VA = "0x183DBAF80")]
			public IEnumerable<global::FFHLNGJDMPJ<TNode>> KLBDFAKONKG(in TNode ELOCLFMIMAL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9A00", Offset = "0x3DB8000", VA = "0x183DB9A00")]
			public TType ACHOPHFMIBM(TInput OHEHJIBMMJC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9DE0", Offset = "0x3DB83E0", VA = "0x183DB9DE0")]
			public int BKNOEKGHJPM(TInput OHEHJIBMMJC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB1C0", Offset = "0x3DB97C0", VA = "0x183DBB1C0")]
			public TOutput LGMIPEEONNL(TInput OHEHJIBMMJC, int EBBLFLFCHFB)
			{
				return (TOutput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9AD0", Offset = "0x3DB80D0", VA = "0x183DB9AD0")]
			public TNode HGKOMBKELGP(TInput OHEHJIBMMJC)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9A00", Offset = "0x3DB8000", VA = "0x183DB9A00")]
			public TType ICIOEFKGLLJ(TOutput ACJBEKDAGDG)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB6C0", Offset = "0x3DB9CC0", VA = "0x183DBB6C0")]
			public int OHHFGNHMOEM(TOutput ACJBEKDAGDG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA300", Offset = "0x3DB8900", VA = "0x183DBA300")]
			public TInput DBGNLEDLNII(TOutput ACJBEKDAGDG, int EBBLFLFCHFB)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9AD0", Offset = "0x3DB80D0", VA = "0x183DB9AD0")]
			public TNode BENEHJGMDAP(TOutput ACJBEKDAGDG)
			{
				return (TNode)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3DBAAC0", Offset = "0x3DB90C0", VA = "0x183DBAAC0")]
			public bool HNBFOFELCNI(TType MCLMFJEAHEC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA540", Offset = "0x3DB8B40", VA = "0x183DBA540")]
			public TType EGBINAFPCJJ(TType MCLMFJEAHEC, IEnumerable<TType> DBMBMHIKCIN)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA190", Offset = "0x3DB8790", VA = "0x183DBA190")]
			public void CPBMGDHGCLN(TType MCLMFJEAHEC, Action<TType> LGNPKBHOEEL, Action<TType> PNEILDGPKMF, Action<TType> MPDJBPLOICN, Action<TType> DLBBMGAPFOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3DBAD90", Offset = "0x3DB9390", VA = "0x183DBAD90")]
			public TType JDEIABONFPJ(TType MCLMFJEAHEC)
			{
				return (TType)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB4A0", Offset = "0x3DB9AA0", VA = "0x183DBB4A0")]
			public string OCIBAHEMDHJ(TType MCLMFJEAHEC)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3DBB220", Offset = "0x3DB9820", VA = "0x183DBB220")]
			public TTerm NHIMCLFBPFK()
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9C90", Offset = "0x3DB8290", VA = "0x183DB9C90")]
			public TTerm BIGFDMIDLGD(TTerm HMADEPFLLKA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA150", Offset = "0x3DB8750", VA = "0x183DBA150")]
			public TTerm CLICLDDFNDM(TTerm PHEBOHLEEKJ, TTerm KCHHIMPOGLA)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3DBADC0", Offset = "0x3DB93C0", VA = "0x183DBADC0")]
			public void JOFJGENJODF(TTerm OLACFPEGPAG, TTerm GLLCOOLKDAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3DBAFB0", Offset = "0x3DB95B0", VA = "0x183DBAFB0")]
			public bool KOPNMPCKBFL(TOutputTerm HMADEPFLLKA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3DBAA00", Offset = "0x3DB9000", VA = "0x183DBAA00")]
			public bool HCFDONFBAGN(TOutputTerm HMADEPFLLKA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9F70", Offset = "0x3DB8570", VA = "0x183DB9F70")]
			public TTerm CAGKNCFAFBN(TOutputTerm OLBIGEINLMM)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA7D0", Offset = "0x3DB8DD0", VA = "0x183DBA7D0")]
			public TOutputTerm GAHLOACLFAF(TOutputTerm HMADEPFLLKA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA480", Offset = "0x3DB8A80", VA = "0x183DBA480")]
			public TOutputTerm ECJDBINGBOH(TOutputTerm HMADEPFLLKA)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA650", Offset = "0x3DB8C50", VA = "0x183DBA650")]
			public TTerm FANIBOPOFJF(TOutputSubstitution EILAHCELOON)
			{
				return (TTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3DBA7A0", Offset = "0x3DB8DA0", VA = "0x183DBA7A0")]
			public TOutputTerm FIDKDPLMHBG(TOutputSubstitution EILAHCELOON)
			{
				return (TOutputTerm)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3DBAC50", Offset = "0x3DB9250", VA = "0x183DBAC50")]
			public TOutputTerm ININGMAIDFD(TTerm HMADEPFLLKA)
			{
				return (TOutputTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class KIFHHAFAADO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public JFEOIGMKPEK arg;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
			public KIFHHAFAADO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x3289F30", Offset = "0x3288530", VA = "0x183289F30")]
			internal int <GenerateConstraintsForNode>b__0(JFEOIGMKPEK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x344F7A0", Offset = "0x344DDA0", VA = "0x18344F7A0")]
			internal TInput <GenerateConstraintsForNode>b__1(JFEOIGMKPEK arg_, TNode node_, int index)
			{
				return (TInput)null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x344F800", Offset = "0x344DE00", VA = "0x18344F800")]
			internal int <GenerateConstraintsForNode>b__3(JFEOIGMKPEK arg_, TNode node_)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x344F880", Offset = "0x344DE80", VA = "0x18344F880")]
			internal TOutput <GenerateConstraintsForNode>b__4(JFEOIGMKPEK arg_, TNode node_, int index)
			{
				return (TOutput)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class KENNPCHILOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public JFEOIGMKPEK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public TNode node;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Dictionary<TTerm, global::IOLFGMBPFCG<TNode>> idToTypeParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public Dictionary<global::IOLFGMBPFCG<TNode>, TTerm> typeParameterToId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> idToType;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
			public KENNPCHILOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x344E5D0", Offset = "0x344CBD0", VA = "0x18344E5D0")]
			internal (string, TTerm) <IdentifyTypeParameters>b__0(global::AMPLMBDHAJB<TType> i)
			{
				return default((string, TTerm));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class BNDANKEEPDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JFEOIGMKPEK arg;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> idToType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IOKind ioKind;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public List<TTerm> terms;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public IReadOnlyDictionary<string, TTerm> typeParameterToId;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
			public BNDANKEEPDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4F2CCA0", Offset = "0x4F2B2A0", VA = "0x184F2CCA0")]
			internal void <GetTypeUnificationTerm>b__0(TType primitive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4F2D1E0", Offset = "0x4F2B7E0", VA = "0x184F2D1E0")]
			internal void <GetTypeUnificationTerm>b__1(TType typeParameterReference)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4F2D510", Offset = "0x4F2BB10", VA = "0x184F2D510")]
			internal void <GetTypeUnificationTerm>b__2(TType appliedGenericType)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x4F2D670", Offset = "0x4F2BC70", VA = "0x184F2D670")]
			internal void <GetTypeUnificationTerm>b__3(TType appliedGenericType)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class EPCBLAKLEJD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JFEOIGMKPEK arg;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x229B880", Offset = "0x2299E80", VA = "0x18229B880")]
			public EPCBLAKLEJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2C163A0", Offset = "0x2C149A0", VA = "0x182C163A0")]
			internal TTerm <GetTypeParameterAssignments>b__1(TOutputSubstitution i)
			{
				return (TTerm)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BDBDC0", Offset = "0x3BDA3C0", VA = "0x183BDBDC0")]
		private static GJPCDNJPNGE FGDJKLKABCD([CallerMemberName] string NBODBMLPNJA = "")
		{
			return default(GJPCDNJPNGE);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3BE06D0", Offset = "0x3BDECD0", VA = "0x183BE06D0")]
		public static Dictionary<TNode, List<global::AMPLMBDHAJB<TType>>> MBMHDLFCHLC(TRoot COMPFMNMPEI, TDeps LCOMIHDGHCD, TGraph HOHEJAGNDDK, IEnumerable<TNode> MDEGEJJPPEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3BE3C30", Offset = "0x3BE2230", VA = "0x183BE3C30")]
		private static (Dictionary<TTerm, global::IOLFGMBPFCG<TNode>>, List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>>) PDFGBIFAICF(IEnumerable<TNode> MDEGEJJPPEB, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return default((Dictionary<TTerm, global::IOLFGMBPFCG<TNode>>, List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3BDE520", Offset = "0x3BDCB20", VA = "0x183BDE520")]
		private static void JALOGIONEIE(TNode ELOCLFMIMAL, Dictionary<TInput, TTerm> GDGLICHOJED, Dictionary<TOutput, TTerm> JCENEIOPFIF, Dictionary<TTerm, global::IOLFGMBPFCG<TNode>> DOEOPCKBFIH, Dictionary<global::IOLFGMBPFCG<TNode>, TTerm> KAJBAEDPABL, List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> ACFBBCBLBJF, Stack<TNode> LEHNDJIGLKB, List<global::FFHLNGJDMPJ<TNode>> KDDCHEOLPGL, JFEOIGMKPEK LDLMPCMBDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BD60C0", Offset = "0x3BD46C0", VA = "0x183BD60C0")]
		private static Dictionary<string, TTerm> ANANIMFDPKP(TNode ELOCLFMIMAL, Dictionary<TTerm, global::IOLFGMBPFCG<TNode>> DOEOPCKBFIH, Dictionary<global::IOLFGMBPFCG<TNode>, TTerm> GELMCFLFDAD, List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> ACFBBCBLBJF, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A3D9F0", Offset = "0x3A3BFF0", VA = "0x183A3D9F0")]
		private static (TPort, TTerm)[] GABJKNCAJEM<TPort>(TNode ELOCLFMIMAL, Func<JFEOIGMKPEK, TNode, int> EILCMOIFNCH, Func<JFEOIGMKPEK, TNode, int, TPort> IIODDBCCHIA, Func<JFEOIGMKPEK, TPort, TType> HOPHCKINNGC, Dictionary<TPort, TTerm> JLLAJCFFLBK, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1810", Offset = "0x3BDFE10", VA = "0x183BE1810")]
		private static (TTerm, TTerm) OKPGHLMCJAH((TOutput Output, TTerm Id)[] DPACHNHPJDN, List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> ACFBBCBLBJF, Dictionary<string, TTerm> GELMCFLFDAD, Stack<TNode> LEHNDJIGLKB, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return default((TTerm, TTerm));
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BD6B40", Offset = "0x3BD5140", VA = "0x183BD6B40")]
		private static void CFEMOJGMOHG((TInput PortKey, TTerm Id)[] OFMBIGEGCFJ, TTerm CFNAEGBAHFB, TTerm LNDNFOJCHOE, List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> ACFBBCBLBJF, Dictionary<TOutput, TTerm> JCENEIOPFIF, Dictionary<string, TTerm> GELMCFLFDAD, Stack<TNode> LEHNDJIGLKB, JFEOIGMKPEK LDLMPCMBDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3BDBE40", Offset = "0x3BDA440", VA = "0x183BDBE40")]
		private static TTerm FGEEDBLLIPJ(TInput OHEHJIBMMJC, List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> ACFBBCBLBJF, Dictionary<TOutput, TTerm> JCENEIOPFIF, Stack<TNode> LEHNDJIGLKB, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3BDDF80", Offset = "0x3BDC580", VA = "0x183BDDF80")]
		private static TTerm IIDKCINFBAG(in TType MCLMFJEAHEC, IOKind FFDDNKCNBMJ, List<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> ACFBBCBLBJF, IReadOnlyDictionary<string, TTerm> GELMCFLFDAD, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return (TTerm)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3BDC890", Offset = "0x3BDAE90", VA = "0x183BDC890")]
		private static Dictionary<TNode, List<global::AMPLMBDHAJB<TType>>> GKHNJMJMBAI(TOutputSubstitution[] GLGHOBDFHKL, Dictionary<TTerm, global::IOLFGMBPFCG<TNode>> DOEOPCKBFIH, IEnumerable<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> ACFBBCBLBJF, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3BE1400", Offset = "0x3BDFA00", VA = "0x183BE1400")]
		private static Dictionary<TNode, List<global::AMPLMBDHAJB<TType>>> MHOCEHIOCCN(Dictionary<TTerm, global::IOLFGMBPFCG<TNode>> DOEOPCKBFIH, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BD6780", Offset = "0x3BD4D80", VA = "0x183BD6780")]
		private static void BLGPMGKBFJC(in TNode ELOCLFMIMAL, Stack<TNode> LEHNDJIGLKB, List<global::FFHLNGJDMPJ<TNode>> KDDCHEOLPGL, JFEOIGMKPEK LDLMPCMBDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3BD83F0", Offset = "0x3BD69F0", VA = "0x183BD83F0")]
		private static void ECNMBKNGBIN(Dictionary<global::IOLFGMBPFCG<TNode>, TTerm> GELMCFLFDAD, List<global::FFHLNGJDMPJ<TNode>> KDDCHEOLPGL, JFEOIGMKPEK LDLMPCMBDAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3BD8CC0", Offset = "0x3BD72C0", VA = "0x183BD8CC0")]
		private static Dictionary<TTerm, TType> EJOOOJEIMKO(Dictionary<TTerm, TOutputSubstitution> GLGHOBDFHKL, IEnumerable<KeyValuePair<TTerm, global::AMCOBDJIIHJ<TType>>> ACFBBCBLBJF, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3BDAC10", Offset = "0x3BD9210", VA = "0x183BDAC10")]
		private static global::IICAPBLJHHK<TType> FGAHJLGEMKJ(TOutputTerm MCLMFJEAHEC, Dictionary<TTerm, TType> ACFBBCBLBJF, Dictionary<TTerm, TType> ODMPDKFLOEI, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return default(global::IICAPBLJHHK<TType>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3BE0C40", Offset = "0x3BDF240", VA = "0x183BE0C40")]
		private static TOutputTerm MEABGCBFGLC(TOutputTerm PCCBMIFGNAD, JFEOIGMKPEK LDLMPCMBDAJ)
		{
			return (TOutputTerm)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x358DBF0", Offset = "0x358C1F0", VA = "0x18358DBF0")]
	public static Dictionary<TNode, List<global::AMPLMBDHAJB<TType>>> MBMHDLFCHLC<TNode, TType, TTerm, TOutputTerm, TOutputSubstitution, TUnification, TInput, TOutput, TGraph, TRoot, TDeps>(in global::OCMPAMOANNP<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot, TDeps> DKOFBKPNBJK, TRoot COMPFMNMPEI, TDeps LCOMIHDGHCD, TGraph HOHEJAGNDDK, IEnumerable<TNode> MDEGEJJPPEB) where TDeps : global::CEBFIIALNHO<TTerm, TOutputTerm, TOutputSubstitution, TUnification, TType, TInput, TOutput, TNode, TGraph, TRoot>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct AMPLMBDHAJB<TType> : IEquatable<global::AMPLMBDHAJB<TType>>, global::HHEBNBIKHFO<global::AMPLMBDHAJB<TType>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string FACJFEGFGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly TType ICKJLIDNONO;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3353500", Offset = "0x3351B00", VA = "0x183353500")]
	internal AMPLMBDHAJB(string NBODBMLPNJA, in TType PINEIEOGCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x423A070", Offset = "0x4238670", VA = "0x18423A070")]
	public bool CMHNKMMFGLG(in global::AMPLMBDHAJB<TType> OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x423A150", Offset = "0x4238750", VA = "0x18423A150", Slot = "4")]
	public bool Equals(global::AMPLMBDHAJB<TType> OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x328E5C0", Offset = "0x328CBC0", VA = "0x18328E5C0", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xAE71E0", Offset = "0xAE57E0", VA = "0x180AE71E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x423A1F0", Offset = "0x42387F0", VA = "0x18423A1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x423A000", Offset = "0x4238600", VA = "0x18423A000")]
	public (string, TType) ACBOBCMAEAO()
	{
		return default((string, TType));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x423A1A0", Offset = "0x42387A0", VA = "0x18423A1A0", Slot = "5")]
	private bool NBMFBLADBBL(in global::AMPLMBDHAJB<TType> OANENNOJEBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HGNEMJOJOJN
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x32D2890", Offset = "0x32D0E90", VA = "0x1832D2890")]
	public static global::AMPLMBDHAJB<TType> OJKIKDBCCPC<TType>(string NBODBMLPNJA, TType PINEIEOGCDA)
	{
		return default(global::AMPLMBDHAJB<TType>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct IOLFGMBPFCG<TNode> : IEquatable<global::IOLFGMBPFCG<TNode>>, global::HHEBNBIKHFO<global::IOLFGMBPFCG<TNode>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly TNode KJHDCIJNECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly string FACJFEGFGOO;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xAE7240", Offset = "0xAE5840", VA = "0x180AE7240")]
	internal IOLFGMBPFCG(TNode ELOCLFMIMAL, string NBODBMLPNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x328E4E0", Offset = "0x328CAE0", VA = "0x18328E4E0")]
	public bool CMHNKMMFGLG(in global::IOLFGMBPFCG<TNode> OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x328E650", Offset = "0x328CC50", VA = "0x18328E650", Slot = "4")]
	public bool Equals(global::IOLFGMBPFCG<TNode> OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x328E5C0", Offset = "0x328CBC0", VA = "0x18328E5C0", Slot = "0")]
	public override bool Equals(object OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAE71E0", Offset = "0xAE57E0", VA = "0x180AE71E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x328E6F0", Offset = "0x328CCF0", VA = "0x18328E6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x328E6A0", Offset = "0x328CCA0", VA = "0x18328E6A0", Slot = "5")]
	private bool FCHDJLJELMM(in global::IOLFGMBPFCG<TNode> OANENNOJEBB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LPBNMFBBBJC
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x44663E0", Offset = "0x44649E0", VA = "0x1844663E0")]
	public static global::IOLFGMBPFCG<TNode> OJKIKDBCCPC<TNode>(TNode ELOCLFMIMAL, string NBODBMLPNJA)
	{
		return default(global::IOLFGMBPFCG<TNode>);
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
