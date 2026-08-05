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
public interface AFLDLDLNEBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float GNNOPFAGLOD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IGHDDCGAHHH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	LLEAAEBCCKF LNIMDCHPPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LLEAAEBCCKF AGJHGLAGFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	SkinnedMeshRenderer[] ILBHANEJEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Material FGIGFJENMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Renderer[] GBIIEPNBHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JICHGCEFAAI.NNADHONNNIJ NEFNKPOHHKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KJEAFAFPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	JBJPAOBCEOK BKHGFCJHLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AvatarConfiguration AMKHKKEKGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEANGMJCLKD([In] NFDBBAOJCKP FCMEGKLOAND);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKHAPDGIEAA(int JGJKFDFMJDO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKEDKKEBNEN(KDOBCGFCCMB GJCCIIMFCKD, Texture PJEGBEIHEIO, Color HFBMHNDFCOD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPAKPHFEGLM(bool DGMDLOGDLNM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKGKPFLAION(MNCBCAJDKJB CNCKIIIBBGO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOOFGMHLIIK(CMCJLFLAALO HMLAEFBLEHF, Color? DEJLIDMJHPI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LJHPIHMJABA(CGAJGDNCFMD CILJJCOEOKI, Texture2D FBFLLKLGAIO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MPFIAEMBHGF();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	OJJOHCMLHDB NNCMOJFOIAB(LMPPDFIGPDH ELLCBALOEMJ, bool KFHDBEBFAPC, int[] DEKFHJHJAFD, Func<Dictionary<string, KDOBCGFCCMB>, (OJJOHCMLHDB, HMBEFKLHMDK<Dictionary<string, EHIFMMNJMNN<Texture2D>>>)> HOGHNMGNICC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	OJJOHCMLHDB HLGEIACNMGM(LMPPDFIGPDH ELLCBALOEMJ, bool KFHDBEBFAPC, int[] DEKFHJHJAFD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LEOIPKKBJIB();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool GJOGFBMMBPC(JICHGCEFAAI.NNADHONNNIJ JONLFIIJGCH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KHBGIIBOKGA(AvatarFaceShape FLAFHLNGMIP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GIAEHNHPPGK(AvatarBodyShape CDIEHNANIME);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void HGGPJFOHBMN(LOCPCPHLCCB LJIBJAKOMJA, float OAIIHELJHLG, bool BDNKGNDKMKM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KKDEGJCGJOM(bool NJKLNAKEBEI = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HMEMCFAKKJM(KIEGMEAMIFO BHLNGJFAOFK, float OAIIHELJHLG, bool MGIPNNAINDG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IIANKLAKBFA(INHKJJEFEGH BIPIIAGGHDI, float OAIIHELJHLG, bool KLOOBJNPKDH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CDCPIECIMHC(bool NJKLNAKEBEI = false);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HHHHKPDONFM(bool NJKLNAKEBEI = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JJDNBGDODEG(GEMMNCOLLPK IBNBMGEBGNE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void LEHOKLJGIIL(bool AMJELANJDHF, bool GOOCNEPCJCL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void CEIHNMALCJF();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void HECMMLBEJBH();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void EMLNMHAPFAG([Optional] CAOCJKDHCLC MABJDEDIHDH, [Optional] bool? NKGIMPJGHHC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MAKMIFPFIDG
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	IGHDDCGAHHH KFNMCHALKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OCOBFHIIAOB HCLOIMANNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PPBDPCLLEJH AONEOOBHNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	PPBDPCLLEJH OIOPJCLOHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform HNEEAFIEIKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TeardownAvatarDisplaySystem();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CleanupDisplayMeshes();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OCOBFHIIAOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMLMHIBGHID([In] JMNIBAELLDP JNLGJDAPFNI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PDNCMADEBAB(JJGELAILKFI IJFNDEJJHBN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMJFFIBAPHM([In] AEEEFNBFKHG JNLGJDAPFNI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PPBDPCLLEJH
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	INDOKOCMJGN NNLOBABPACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float ALAEFHEAMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	INDOKOCMJGN JFFBNBOLOLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Vector3 IEEIACAJHBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Quaternion HONOMADONPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AILAHLBEKFE(JLIOAPNIDNL JNOIIIFBOLM, bool DLKFMHELCEO);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHPLDDENALJ();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ACEIMJEKIJF(int NPONMIBAODO, float EOCELADHEEC);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MDDKGPPEKJL();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HFDBOIHJHDN(bool HMKCBLNCLGO);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GFDFBDIKDBF();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ONKPMGNKKCD();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OHFEGONJMAL(bool HMKCBLNCLGO);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KDNFFDNFAMB(Transform BOGJJGPKPIJ, Vector3 MJLFCGFHHEA, Quaternion PDBHBOBECDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FLJBCFIDHCI
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OutfitType CEHBDLOOONB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IReadOnlyList<OutfitType> MEPMALCJNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IEnumerable<OutfitType> GICDPLADLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JICHGCEFAAI.NNADHONNNIJ OMBGOCGNGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Guid OCNPBLDHFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CMFNJGCGGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6C70", Offset = "0x7BC5A70", VA = "0x187BC6C70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JCGOKDAAOPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6C20", Offset = "0x7BC5A20", VA = "0x187BC6C20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string MHJFCPIFJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NIMGFNNCFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CEKOLGONJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FPOBFPGLDOI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PFDAABMPMAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Color ALNPLNMMBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool NPDMGIPKJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool HHFJINNHKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool CIALOLOBPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	AdditionalOutfitTypeData CKNKCBEJEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AdditionalHatData LAOCOKJKHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HairData EBBJJAONPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HelmetHairMode KNEFLBFCPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6A40", Offset = "0x7BC5840", VA = "0x187BC6A40", Slot = "20")]
		get
		{
			return default(HelmetHairMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CBDEPFJBGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6AE0", Offset = "0x7BC58E0", VA = "0x187BC6AE0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool IHDOMBEBMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	AnchorParamsRestrictions MNONOMEIHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6B80", Offset = "0x7BC5980", VA = "0x187BC6B80", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool CEMNPMDOPJL(AvatarItemBodyType NKMICFCAGBL);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CGGJGNFHJBA(bool FPFMPLPNFDK = true);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IHBLLANFAIP
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FLJBCFIDHCI IEDLCAGMPAI(GameObject OHJAGGPLIGB);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJKKIJJFJAG(KDOBCGFCCMB BGPHPGHJPMD, FLJBCFIDHCI CACIHEEMLOB, AvatarItemBodyType NKMICFCAGBL);
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
