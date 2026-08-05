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
public interface PIBLOCDINDP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float NFEBFCGCNJF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NGCNOPAGGEC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OLDENIALAEA CMMIOGBOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OLDENIALAEA NOPLGFBEMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	SkinnedMeshRenderer[] EENAEOCLHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Material DMIAEAAFGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Renderer[] ICACEFGPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LDBNJIFCKAL.HECKIELMCBP KKEIODIHMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool AKFIKOPJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HBFPFNMMLAG JLHDAMOOPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AvatarConfiguration NACCBFNCPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOIGNCBPFDD([In] BLOINHJMALA IAAFDBNCEPO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEJNJCPFMHK(int BALKEAPIFFL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILBEIJCPEOK(IKCNPCJGLNP OHHMIFPIBLM, Texture PMLDGMGPAKD, Color KPLEFMLIDMJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHKDEANNLAM(bool OHLLOEBHPFI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JENGCNNPCOD(HDGGCAEIEHM NFHKMOGHIBC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJILODOODPL(CPDABLBNCDE KACJOCGPGGC, Color? CKANMCILFBE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HEKHAEICLND(GOJKKFOFNHC HLFCGCADEAN, Texture2D HLPGJNCKNML);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BNNNJNKBBMA();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KPNDCLGPJDN BKPCNLNKONK(NLGEAGICHBO HCMEIANJNMN, bool ILDCBNAMPLC, int[] BHELONIJEEA, Func<Dictionary<string, IKCNPCJGLNP>, (KPNDCLGPJDN, COLCOEKKCIF<Dictionary<string, FHGKGMPNNBH<Texture2D>>>)> GPMMJHKIIPF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KPNDCLGPJDN DANGFOGAMOA(NLGEAGICHBO HCMEIANJNMN, bool ILDCBNAMPLC, int[] BHELONIJEEA);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ELICBODJFEB();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BOJGPBMACDE(LDBNJIFCKAL.HECKIELMCBP MABLMFGFFFE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JJABNPIHGBF(AvatarFaceShape ADLLKLFHIAN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OFAEPEKIEDH(AvatarBodyShape EDJLCMFDJBN);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KPPAGHONIKN(KEHGEIMFGPM MDPPHLHBJGE, float FIIKLGCIAGG, bool ONGJOCKLGND);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void POACCHIJDOP(bool BMGIFKNGKEE = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MGAOOLCKBDL(BGLIFKJGBNO KMJDCBOCFCF, float FIIKLGCIAGG, bool BDJJKLDPMEH);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EGEHIPNAJKJ(BKNDIMCPBGA CEHMONGLABB, float FIIKLGCIAGG, bool HPAAHCHOIPP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CKHJPKMAMLA(bool BMGIFKNGKEE = false);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EMOEHPIHKBF(bool BMGIFKNGKEE = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FGFKKPJLHCK(OMEFKCHKIOM AJICEFHNLGH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BNFFLHKDIGE(bool JCGDOIPNFOP, bool LFANGJEKPLM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EPPHNJMMLGF();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void POIJPDEKPLL();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void AGHMHIIIKEE([Optional] GHDNJFDBFAB HENEICJGNKK, [Optional] bool? BIKEDNADPEB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PAHJFAGMNMK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NGCNOPAGGEC NKOJGAGHPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PBCNDHELJOL DDECBBMLBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CINJLPKEMIB EABBECOKHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	CINJLPKEMIB JIOEDJAOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform HGDMMGDIIMO
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
public interface PBCNDHELJOL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool NFLEONEBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHOIJPLBHOB([In] BHKDFFIKKMI OACDOGEEHNB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFDGAEGBMBM(GOHHKNOFECI INEOKGBFMOJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNOOBJMBFJK([In] CHODNKAHLOE OACDOGEEHNB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CINJLPKEMIB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JLDMEMCNCMD LIBPLFPNMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float GCCKGCMDFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JLDMEMCNCMD ODKGKEOCLML
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Vector3 AOJLFGLOECL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Quaternion OKELCCGCDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHOGKOOMMEM(LFGDPDKIHFI FBOKGPFKJCL, bool GIPGMKNGIBJ);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHEHOAFOENC();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGDJPDKIGOI(int HLJKJMCIFDD, float BJGCENEOGBI);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LOHGGMBFGJF();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KAPIDPKLABL(bool ODCIGAJHLFG);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BANGLMNLNJJ();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ENNBLOHGOLF();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FAJJOMCHOFJ(bool ODCIGAJHLFG);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FOCBHENNCBA(Transform PBIFOHNGFLL, Vector3 MEFLDLLJODM, Quaternion NOAPNNMFGIC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CEPIODKIFMN
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OutfitType DMNPLKDIDKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IReadOnlyList<OutfitType> HENHHNFONOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IEnumerable<OutfitType> KCFBLLNMMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	LDBNJIFCKAL.HECKIELMCBP JHFDLKHJEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Guid PEOBHBKAJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LJLBICAKPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x764A3F0", Offset = "0x76497F0", VA = "0x18764A3F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LPGMKMPMNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x764A260", Offset = "0x7649660", VA = "0x18764A260", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string EHLGIJAAIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LMGPBNENONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GEKOMIHKJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PBEKOEDECJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CPAGAEAHAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Color JAMDPMGGFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool DLCBAHACGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool AAGOPHKOOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool EOPHFJECKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	AdditionalOutfitTypeData NPEJEANKFEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AdditionalHatData NBHIMJPGDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HairData FBHGBONBAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HelmetHairMode BNBGHMMLBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x764A440", Offset = "0x7649840", VA = "0x18764A440", Slot = "20")]
		get
		{
			return default(HelmetHairMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NGOFFEPOKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x764A2B0", Offset = "0x76496B0", VA = "0x18764A2B0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool LHCNDNIOEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	AnchorParamsRestrictions LELLBHELPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x764A350", Offset = "0x7649750", VA = "0x18764A350", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool GPLBJOCCLFG(AvatarItemBodyType GBHGDGJMNEI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool KMOAKFFAJKG(bool JEJBHLONLED = true);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ENLOLIMGIBD
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CEPIODKIFMN NJAJEJOEIND(GameObject FAHGNPJKBFP);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHGGKKMJIFO(IKCNPCJGLNP PEOGNHIKLPA, CEPIODKIFMN AKNKKDBDMJE, AvatarItemBodyType GBHGDGJMNEI);
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
