using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KFLIBLCDICB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJDEPIIMEOL();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IHEOBAFNGIE
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float IDFEGEHLHMM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KONLHIGFPIP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EPHHEFDKGKL PHKOIPEGNLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EPHHEFDKGKL NDEJCADFKFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	SkinnedMeshRenderer[] JJFDGPMHMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Material LGFCKIBHAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Renderer[] EOIBOEPJCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	OFCOHJLOKGA.PFHBFKIKAIN JKIBGPBECNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KBJOGPKOJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HIEAKOJGBND JKDIFCDGINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AvatarConfiguration IAOLBMPLGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHBKNEGAGFE([In] CDCNBGOLNIK NDMGCCGDIEF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EPLAEOFHCFF(int AEABCPDILIB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NDFHONBMPHC(PNMBCADMOBD NFABKHIKACP, Texture BJNLCCOJPGB, Color ANGGEBMNOMC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IJFACHOHHOO(bool EHEHMOJDJMH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMIGPCKCNND(BOPLBKOIMNN AJLJPILGNIP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LINPJBKGDNE(GBPFKAICOIN DBDFKFEEDLP, Color? NEMIFEKMDAI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EODBBEFBNLE(FENAFGNFMMH LBHPCBIADNN, Texture2D NANHFKKMKAD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EPOHJGPOHDH();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ABAHHGGDFBO OLGJOGHAEGN(FNKGLCNJMMP AADNIMCCGHH, bool KPBGNFHBGEF, int[] OMLNPHJACGI, Func<Dictionary<string, PNMBCADMOBD>, (ABAHHGGDFBO, GFHJFJDJPFP<Dictionary<string, HLHLINEFKHE<Texture2D>>>)> CBMKHBLIFLE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ABAHHGGDFBO PLBDGIFEOAD(FNKGLCNJMMP AADNIMCCGHH, bool KPBGNFHBGEF, int[] OMLNPHJACGI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AJLHFJKFAIH();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LIONKMPEFEI(OFCOHJLOKGA.PFHBFKIKAIN MMNCICHGLOO);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GIOANOCMBPC(AvatarFaceShape NEAIGBOFLLF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ABJLIDNIDLD(AvatarBodyShape NBHBLOFAGDA);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OJBJMEAMGLN(KGACCJNCEGJ GHAHJIAABMF, float KJIOHKMJAPE, bool CEDCAMKNBED);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IPALHFKIPKP(bool EOIKCNEEDGA = false);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void PLEPBFCFLLD(FFNJLAPEAAH HLPNHJOANIK, float KJIOHKMJAPE, bool GLCMJMLHLIJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JGBMPODEHFN(NHLAOOPBHOL NMKKJBELNLF, float KJIOHKMJAPE, bool KHEDMEHLNLJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EDPNIPIAPGJ(bool EOIKCNEEDGA = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ILGEPPGBDDA(bool EOIKCNEEDGA = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DALMCDANEBG(BDJFFDNIHPO CHPDFJOFFPE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CPBDCHEKGGJ(bool BHPLJHDNKEK, bool KOPMEOMCANO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NKFDJJEAHEI();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ABMJMEINPAB();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CCOLOEHCFND([Optional] BCHLBCJFNPL KFGJHKKPMNP, [Optional] bool? PNMEILKOIBK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void JAAKKNMHJPO(float PONNOGKMBDD, Color NEMIFEKMDAI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MLAFNJOHGFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KONLHIGFPIP KHNPKDEMIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FHHGLMCDKMP OCLDIJKBLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	JGDIKKCCKEJ DJJEFJOLIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JGDIKKCCKEJ ILHIHBIPNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform LPFNJEDHPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TeardownAvatarDisplaySystem();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CleanupDisplayMeshes();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FHHGLMCDKMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool CFMEGCKFFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMKKOMIEJPB([In] ADLDHGFBDOG HDDLIPCPJJK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGPFFLJIODK(KFMCNMACHEH DADJAGHLKNG);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGMGBFIELHN([In] LDNPDDIOLGB HDDLIPCPJJK);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JGDIKKCCKEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CIGCOHPAJFE BJHPGOEEDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float FMDIFJNEGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CIGCOHPAJFE LMBIDCLFKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool MBNGCPHCKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Vector3 HCJOJMPOJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Quaternion BMKCJOKDABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OKILNHOEPON(KDFDOLIJIHM CKCKEFFHJAP, bool GOGLCIFAFPE);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PHBDJMPMCHO();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NKBBJDMOCIM(int ACLNMHBIKII, float LDNJDCJGGOE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CMNKIHGNLLN();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LAGMAAAEOJJ(bool PGEJJMOHEOB);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LKHGEFMOHLG();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OBCFOEIPDBO();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IGODJPCPFFH(bool PGEJJMOHEOB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CDNFGMGJGLL(Transform FLKKOCNDECC, Vector3 BLJIKHPALFC, Quaternion JAGOBBCFJOO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ENJNFKLCFEL
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OutfitType MDJHIPCKDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IReadOnlyList<OutfitType> DICCAINBGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	IEnumerable<OutfitType> FOAEKDBOJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	OFCOHJLOKGA.PFHBFKIKAIN NIHJDDCICJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Guid HHPKMABLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool BINLMGFOOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7A80390", Offset = "0x7A7F590", VA = "0x187A80390", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OGPKNGMFAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7A803E0", Offset = "0x7A7F5E0", VA = "0x187A803E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string KIPFOFHOAIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CECELFJPEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DBICGADCIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PAEILMIPCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IGGINHBIGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	Color NPODAFDLCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool BFMHEMPIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool BDLDENJCBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool ALJGBFFPIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AdditionalOutfitTypeData HHAHEHFLADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	AdditionalHatData MICKGJKPFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HairData KPEAHHACPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HelmetHairMode JGBJJPIMEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7A80430", Offset = "0x7A7F630", VA = "0x187A80430", Slot = "20")]
		get
		{
			return default(HelmetHairMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool GMBKAKIPIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7A802F0", Offset = "0x7A7F4F0", VA = "0x187A802F0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool PBOJGNHHJMI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	AnchorParamsRestrictions HMCNGIEFNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7A80250", Offset = "0x7A7F450", VA = "0x187A80250", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool IDJELAAOMHO(AvatarItemBodyType LHNAOOFCGOL);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool JKHBNHBLFKO(bool MAPFNMCIGOJ = true);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CDJOBBECAIH
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ENJNFKLCFEL GKLLLLMHNEH(GameObject IJDBKPEJDOI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPICPEAJMAN(PNMBCADMOBD GHFPLCMOBOL, ENJNFKLCFEL DLBGMBBCKAG, AvatarItemBodyType LHNAOOFCGOL);
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
