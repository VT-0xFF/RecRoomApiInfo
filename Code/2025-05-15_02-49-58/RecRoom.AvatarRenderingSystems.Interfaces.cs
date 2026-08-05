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
public interface FNDPENBBHHD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float CJIPMCGKHCF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EEFKKODIKGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	GCADBNOOJOM GIJDKDPBBDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GCADBNOOJOM FKICFHPEPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	SkinnedMeshRenderer[] BCDFCKMLPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Material AIDPAHHCHLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Renderer[] LAPDFLIBNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DJMKKMKOHOE.KHMINOCKMDE BNDOMBIBDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FBBAILFPMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BLMBMEMIHNO CGILOPKPFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AvatarConfiguration MMMOHDOGNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMDIFILKIOE([In] HMAAKGCFJIK EFGPLJKHBGK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMCJHMAKKJD(int GKGMDAMJCNF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBBPFKMBGJB(ALBBMKANDAF HNMCGDBFDGH, Texture MOBCKEBGPFC, Color CHOGCLCILKL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DMJLKLMFLHD(bool LKECFFEIFNO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIBLNAAHMKF(NAFFPEBCHPI PMLCGCAHNGK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EHAKGAGPGAI(MCGIHJPPCCH FKAIEBDGNCN, Color? NGGKCKILBNF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FEDEOKJHDPN(GFLLLLCANOK IHIJDFFNDNI, Texture2D BFGBBIJNNHK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MDFLBHLKJAF();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ALBMIKCECHI KBANOGBGLKK(OMFDGHDDKHE EAEKJMJLOAC, bool EEAEBGKMHGP, int[] KIOKNKHEIMB, Func<Dictionary<string, ALBBMKANDAF>, (ALBMIKCECHI, KGAPFDAFEHM<Dictionary<string, GKHPBLLBAIL<Texture2D>>>)> CLMFFEADJPE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ALBMIKCECHI FBLCEBCCAMP(OMFDGHDDKHE EAEKJMJLOAC, bool EEAEBGKMHGP, int[] KIOKNKHEIMB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DMLDIIKDBJB();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool HKGLBHMPOCG(DJMKKMKOHOE.KHMINOCKMDE PPBPOBKGLON);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HIHMNPDOBII(AvatarFaceShape NOLJPELCPGH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DPPAKFIKPJJ(AvatarBodyShape JNNFLNPDLLA);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OCOHJLBJOOC(OAIBHFEEBFF OHKLPMGKCNP, float OHLIHBDBKCE, bool NGGBHLHDOAO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JBIOIOBPKBN(bool MMPAHNIJNOD = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IPEJBKIPPIA(OGHEPKGNCBA LHCBLABBENF, float OHLIHBDBKCE, bool CNDBMNGCPEP);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JMAGOFIIPAD(OJGFLCIKIFC GKKKGOHEELC, float OHLIHBDBKCE, bool ONLNMKMBDBE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void GNAAJEMACEG(bool MMPAHNIJNOD = false);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BDDPIPKHGLL(bool MMPAHNIJNOD = false);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BDGEOCHDEIN(ABOJDNCODIG AEHFOHDJDBI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NNHKGAFNBNJ(bool APHODKKNMPK, bool BKPHMFMOBOE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void ICPFDPMIICI();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FDMFMABKNNH();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void IMAHGOINCBB([Optional] HMAKLDEGKBC OGABAGJHKNB, [Optional] bool? AGLEHBFANOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GBFNELEFJAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EEFKKODIKGJ OLIAKELJPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CPCAHHNKCEK AHDDGCHGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EKFIOJKBHPO LGEIPIKACBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EKFIOJKBHPO MEJGBGHHDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform KLBBKNPLNCB
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
public interface CPCAHHNKCEK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGFLOGPPDFF([In] BJABNEMFONN JOIIFDKKKIE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCINBHCDCKF(FEBJLGDBOMJ LINHHCIFANJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJPPMMGMBIH([In] MEGLFPKOFKP JOIIFDKKKIE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EKFIOJKBHPO
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	ACKOLLANMDJ CFAKDOIEGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float MDAKCDIKJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ACKOLLANMDJ PFHACCAHHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Vector3 EMENJINFHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Quaternion HJGKPPALEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMNCKNLNKCG(OKECFPHNFBM IDAKFFICKHC, bool CBHHPIGGAMI);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKANKMCPKMI();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HPGKJHEKAMN(int PHIKMMCANBH, float CGBONFJILMP);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JOPMFAEKJFH();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JKDCAAMODLN(bool MIHGKLOAIPI);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OMFFKBHGPOJ();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AENLDHPCDDH();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DCPHJHIKMJN(bool MIHGKLOAIPI);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void COOCPPOKIJB(Transform JHDAOHEONAC, Vector3 MKBIPJMOOAN, Quaternion IADANCLOJAE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CKKEFOLDDDM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OutfitType FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IReadOnlyList<OutfitType> JMEKEJNCCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IEnumerable<OutfitType> AEFKMKGONEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DJMKKMKOHOE.KHMINOCKMDE OLBDBNHLDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Guid OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NALDFNNIJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E2C0", Offset = "0x7A5C8C0", VA = "0x187A5E2C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool MOHAACLMKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E3B0", Offset = "0x7A5C9B0", VA = "0x187A5E3B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string FECCKEDMBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool OEGMOFOEMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HBONCIGBNFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool OGMMPCHIJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MJOPPHNOLLM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Color JNMEDALLGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool JEABKAMFPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool IHKKAPFIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool ODMMKHJBEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	AdditionalOutfitTypeData KCBLFPBCKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AdditionalHatData MNDDEPHHMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HairData FIJDAGJDKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	HelmetHairMode DFMOPHPMEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E4A0", Offset = "0x7A5CAA0", VA = "0x187A5E4A0", Slot = "20")]
		get
		{
			return default(HelmetHairMode);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LHBBDDPBEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E400", Offset = "0x7A5CA00", VA = "0x187A5E400", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool PPJGMLNAJCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	AnchorParamsRestrictions IBOOGHBOKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7A5E310", Offset = "0x7A5C910", VA = "0x187A5E310", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool DPACCPMGNDE(AvatarItemBodyType MLPKEOCLJHM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool MFCHLKKHHAH(bool FJKFGHJJIPC = true);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GADAOPIMBPG
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CKKEFOLDDDM LLMDHHJHGGL(GameObject OMOOALIODHP);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGFMLECLJPI(ALBBMKANDAF LGIKDEFBHHP, CKKEFOLDDDM NPDKKINBDDF, AvatarItemBodyType MLPKEOCLJHM);
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
