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
public interface BLKLKNJNIID : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ABPHEPKLOCC : BLKLKNJNIID, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KIJBPNOFNNH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float DJGAODFCDIF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JOAGHKKNMDI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HBAAEHCBNNO EBFOJDAAFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	HBAAEHCBNNO DCMNHAFECDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	SkinnedMeshRenderer[] LHCJHHMEACC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Material IFNKPPEELDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Renderer[] MFKNMAFKONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IONAMLJCLBI.EPMFDMLBDCD ADFGECDCPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FAHAOBKPMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	CIFHCHIGFCF MANMLIOLGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AvatarConfiguration DHGFBPPBBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFDKLMDJMNB([In] MMNFJHLEJHG FAPCDBOJNBD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPAHMHFKIMC(int FEJALILJGHL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFICKOPONGE(LLGDDBJNDAK ANANENHFKHF, Texture AGBELKENJFI, Color GODGBCOHAJA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILHCJEGKHKM(bool IANPEPDIDNB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNCFAOKGCOF(AKKOOIDKLNO GALEDNLDGCG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGHGJCAJBOD(ELNPIJIEBOB EJKOOEFJHNG, Color? GCKOLKABAJC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JCHAKOBHKBL(JOKFPFKNGNJ PEMGCOHLNAD, Texture2D BDAIEAKKDFD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CFBOIEBFHAE();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LKEMGHMAMLP PMHPEGFHGFJ(BPPOMJONOGG OBLKGLCKNNP, bool GGFOKGACMJM, int[] AOMGOCOHHKN, Func<Dictionary<string, LLGDDBJNDAK>, (LKEMGHMAMLP, KLHBLGBFFDH<Dictionary<string, PHKGFEHMLBA<Texture2D>>>)> NOECOFPPOCB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LKEMGHMAMLP OFEHKPBBJAB(BPPOMJONOGG OBLKGLCKNNP, bool GGFOKGACMJM, int[] AOMGOCOHHKN);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CJJDALLIIAN();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BANIGEDOCIP(IONAMLJCLBI.EPMFDMLBDCD EEDJFLPHBGN);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ILPLJOFIJIL(AvatarFaceShape OANIPCLJBHC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BDEOJLJJJLJ(AvatarBodyShape NLMAEIDEOID);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GCMIGKJMHOC(IEKNNJIHFMK EGADONEDPAC, float OOHGFGHCOAJ, bool BHJMHIMEMCL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AJGEDCOLJCO(bool AKNPPECOPCI = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CMIPAAIJLGD(AFLDMIJCCDM MDFALFHFLME, float OOHGFGHCOAJ, bool KPBJMIGOJCG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IJJGLJCCCED(PPFKBBIJKBH EEMPKBDIOGI, float OOHGFGHCOAJ, bool LBLFCEDCDIH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GGFCPCDJPCK(bool AKNPPECOPCI = false);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CFFFJPFCMJL(bool AKNPPECOPCI = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void POGBOBDAIPD(KMBJPNFNLBA MAPLPIGEHBJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IBALOJOACIH(bool NEOADBHBGGE, bool LEENJDNBDAA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void LLOCHOINOKB();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void EKDBPINOKDA();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CFFPACDHBEL([Optional] JJMEKHLKNJB KFFFNCOIDFN, [Optional] bool? OBCMEHLLCAH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PKOPGCDNGNP(float KOGLMODGKLP, Color GCKOLKABAJC, bool NOKPILMLOPP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JOPNFGGDFLO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JOAGHKKNMDI ENMDGKKFJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DKHBNCECMKL AJNOHKDKICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KGCOEBBKGCN KCPFOGJKIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	KGCOEBBKGCN ALBLEJFMLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform GNLOAOBIKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TeardownAvatarDisplaySystem();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CleanupDisplayMeshes();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DKHBNCECMKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PPEBHELAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBNFLNOAFBO([In] HEILDFICPPP MBCFMKDOGBC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEMJGDBCGMJ(LMICPILDBNN BACJLJILCKP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HJENFOGBGIP([In] EABIGMNFGNA MBCFMKDOGBC);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KGCOEBBKGCN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CNIBPJLPBFA LHIOEEEDAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float LBJKDGAIFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CNIBPJLPBFA FLGIOEJEGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool NGEEKJCDJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Vector3 DONEAIBKKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Quaternion MBCECDJMEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JCBGAPIBLBL(NFIEDKKPELO DKILGKEHOLM, bool AENDFIMJKFK);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HNALLBEJPOF();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PCDGKBKGNND(int JDNJKFGACKH, float BBFNOHNDNLH);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ICAJLJGGDCO();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NKKNOCIOLHC(bool AENFHNMCJOM);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KGEICNGMCME();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IENJBNCAIGI();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AOKEDCGEJCK(bool AENFHNMCJOM);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CHNHJLKAEDD(Transform LIPFJJEAFCE, Vector3 IHIJHMKCPPP, Quaternion LOJMBNJIMDE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FGFHPLNOLGF
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	OutfitType FEMDHAMIGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IReadOnlyList<OutfitType> MCAHFJEAGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	IEnumerable<OutfitType> KHPAKGFOOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	IONAMLJCLBI.EPMFDMLBDCD FBJHBFBPFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Guid PAAINMNNDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CFGAKMOKMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0FC0", Offset = "0x7BEFBC0", VA = "0x187BF0FC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool PCNPFBPOIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BF10B0", Offset = "0x7BEFCB0", VA = "0x187BF10B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string NKFMGJBLBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CHDHOGJEKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DAGEDEFKFIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool AAAFMEOGFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool BKOJHFPPAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	Color KOCMILDENNI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool BLPAAOFCENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool PJEPLKIJNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool HKPHDJAFHPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AdditionalOutfitTypeData BHLOIMCIKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	AdditionalHatData MANLGPMKPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HairData APCEIELJPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	HelmetHairMode CEJLHLNAFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1010", Offset = "0x7BEFC10", VA = "0x187BF1010", Slot = "20")]
		get
		{
			return default(HelmetHairMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool GDDIEHGGOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1100", Offset = "0x7BEFD00", VA = "0x187BF1100", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool ODDFCIOGGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	AnchorParamsRestrictions NDJEHGIAHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF11A0", Offset = "0x7BEFDA0", VA = "0x187BF11A0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool HCAIKJGLDEC(AvatarItemBodyType CAKCPCANKDP);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CLEDIPNPPKJ(bool MJINCFCJJEK = true);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NMMPCPHAGGP
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGFHPLNOLGF BNFMGHMDDKL(GameObject DNPJNJCBEBE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EMALKFCEBEL(LLGDDBJNDAK JNCBLLJJFKA, FGFHPLNOLGF BLPDIDCADLB, AvatarItemBodyType CAKCPCANKDP);
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
