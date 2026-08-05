using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum IEFCHCLDIDC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Moderation = 2,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Platform = 4,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	RecNetJunior = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Settings = 0x20
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum DIPGJHNNCCL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Party = 0x12,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FavoriteFriend = 0x1C,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Friend = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Any = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FOFNLEKOGHD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGPPCPBEGDA([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EIHAFDKBAFL([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BIDGMIOILKE([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JECCLMBLFGM(DIPGJHNNCCL BICBNPLLAID, [Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PEPAGHNADHK([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DHCOAPJEMDA([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GBDIABLOMIL([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BOBHJLCEAKD([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool PMIMJEHDACA([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JLFIAIEBELL([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ABHNBIGIIFI([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EJNFBMHFIPO([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BOAFNDIBLAK([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool EAABPJOICJB([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool EPKODCDLKMP(KJFKCDHGGBL HIAEHFCGCNO, [Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PILFAKANDDK(CLHHFLBMBIO HIAEHFCGCNO, [Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool ANMBMBFCPAA([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool ADKILMCDFOJ([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LAEEDPHFFPL([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool NAHEKKEMLMC([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool CFKAHGOFHLN([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool APEJCNJBFDI([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool PPDCDPGPEDC(GLNPOGKFFOF HPPPLLCFNKH, [Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool NKILNNBAGHP([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool DFNEIAOCMGH([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CNNGNGJFECF([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool PKFNCCKMOJB([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool MEJHKFNOCEK(CBGECBIBMHE MFFPIBNMDMP, [Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool HNIMBEFHBIL([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool FFIMAPLJOON([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CBKLIKIJIJD([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool PLKHBEJBJJP([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool OICPHPEKEJO([Out] IEFCHCLDIDC LEJPOHFMACG);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	string CJEBCPEDPCL(IEFCHCLDIDC FOKJBCKHNMH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OELLAPOCAGN
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C85D40", Offset = "0x6C84340", VA = "0x186C85D40")]
	public static bool FOLEFHCMGMG(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C86030", Offset = "0x6C84630", VA = "0x186C86030")]
	public static bool IGKBNPDAMPP(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C867C0", Offset = "0x6C84DC0", VA = "0x186C867C0")]
	public static bool PGPPCPBEGDA(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C85A30", Offset = "0x6C84030", VA = "0x186C85A30")]
	public static bool EIHAFDKBAFL(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C85370", Offset = "0x6C83970", VA = "0x186C85370")]
	public static bool BIDGMIOILKE(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C861A0", Offset = "0x6C847A0", VA = "0x186C861A0")]
	public static bool JECCLMBLFGM(this FOFNLEKOGHD AJLMDOAKCDN, DIPGJHNNCCL BICBNPLLAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C86700", Offset = "0x6C84D00", VA = "0x186C86700")]
	public static bool PEPAGHNADHK(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C858B0", Offset = "0x6C83EB0", VA = "0x186C858B0")]
	public static bool DHCOAPJEMDA(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C85EB0", Offset = "0x6C844B0", VA = "0x186C85EB0")]
	public static bool GBDIABLOMIL(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C854F0", Offset = "0x6C83AF0", VA = "0x186C854F0")]
	public static bool BOBHJLCEAKD(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C86AC0", Offset = "0x6C850C0", VA = "0x186C86AC0")]
	public static bool PMIMJEHDACA(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C86270", Offset = "0x6C84870", VA = "0x186C86270")]
	public static bool JLFIAIEBELL(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C85070", Offset = "0x6C83670", VA = "0x186C85070")]
	public static bool ABHNBIGIIFI(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C85AF0", Offset = "0x6C840F0", VA = "0x186C85AF0")]
	public static bool EJNFBMHFIPO(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C85430", Offset = "0x6C83A30", VA = "0x186C85430")]
	public static bool BOAFNDIBLAK(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C85970", Offset = "0x6C83F70", VA = "0x186C85970")]
	public static bool EAABPJOICJB(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C85BB0", Offset = "0x6C841B0", VA = "0x186C85BB0")]
	public static bool EPKODCDLKMP(this FOFNLEKOGHD AJLMDOAKCDN, KJFKCDHGGBL HIAEHFCGCNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C86870", Offset = "0x6C84E70", VA = "0x186C86870")]
	public static bool PILFAKANDDK(this FOFNLEKOGHD AJLMDOAKCDN, CLHHFLBMBIO HIAEHFCGCNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C851F0", Offset = "0x6C837F0", VA = "0x186C851F0")]
	public static bool ANMBMBFCPAA(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C85130", Offset = "0x6C83730", VA = "0x186C85130")]
	public static bool ADKILMCDFOJ(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C86330", Offset = "0x6C84930", VA = "0x186C86330")]
	public static bool LAEEDPHFFPL(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C864C0", Offset = "0x6C84AC0", VA = "0x186C864C0")]
	public static bool NAHEKKEMLMC(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C85670", Offset = "0x6C83C70", VA = "0x186C85670")]
	public static bool CFKAHGOFHLN(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C852B0", Offset = "0x6C838B0", VA = "0x186C852B0")]
	public static bool APEJCNJBFDI(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C86B80", Offset = "0x6C85180", VA = "0x186C86B80")]
	public static bool PPDCDPGPEDC(this FOFNLEKOGHD AJLMDOAKCDN, GLNPOGKFFOF HPPPLLCFNKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C86580", Offset = "0x6C84B80", VA = "0x186C86580")]
	public static bool NKILNNBAGHP(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C857F0", Offset = "0x6C83DF0", VA = "0x186C857F0")]
	public static bool DFNEIAOCMGH(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C85730", Offset = "0x6C83D30", VA = "0x186C85730")]
	public static bool CNNGNGJFECF(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C86940", Offset = "0x6C84F40", VA = "0x186C86940")]
	public static bool PKFNCCKMOJB(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C863F0", Offset = "0x6C849F0", VA = "0x186C863F0")]
	public static bool MEJHKFNOCEK(this FOFNLEKOGHD AJLMDOAKCDN, CBGECBIBMHE MFFPIBNMDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C85F70", Offset = "0x6C84570", VA = "0x186C85F70")]
	public static bool HNIMBEFHBIL(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C85C80", Offset = "0x6C84280", VA = "0x186C85C80")]
	public static bool FFIMAPLJOON(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C855B0", Offset = "0x6C83BB0", VA = "0x186C855B0")]
	public static bool CBKLIKIJIJD(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C86A00", Offset = "0x6C85000", VA = "0x186C86A00")]
	public static bool PLKHBEJBJJP(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C86640", Offset = "0x6C84C40", VA = "0x186C86640")]
	public static bool OICPHPEKEJO(this FOFNLEKOGHD AJLMDOAKCDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum MGKIFDEGJPF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Party = 2,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	FavoriteFriend = 4,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Friend = 8,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Any = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Flags]
public enum MJGLLLFOJFB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Party = 2,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	FavoriteFriends = 4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Friends = 0xC,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	PartyAndFavoriteFriends = 6,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	PartyAndFriends = 0xE,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	All = 0x1E
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
public enum KJFKCDHGGBL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Dorm = 2,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	All = 0xA
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
public enum CLHHFLBMBIO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TransientDormOnly = 2,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	SavedDorm = 4,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	All = 0xC
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Flags]
public enum GLNPOGKFFOF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RegularObjects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConditionallyRestrictedObjects = 6
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum CBGECBIBMHE
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	UnblockedCreators = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = 6
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FGJCHKDDGGO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IEFCHCLDIDC LMLOICJFAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PGPPCPBEGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EIHAFDKBAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MJGLLLFOJFB DFOINIDMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PEPAGHNADHK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DHCOAPJEMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool GBDIABLOMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BOBHJLCEAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool PMIMJEHDACA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JLFIAIEBELL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool ABHNBIGIIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool EJNFBMHFIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BOAFNDIBLAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool EAABPJOICJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KJFKCDHGGBL NALHPOEEIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CLHHFLBMBIO GFAAJJMCACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ANMBMBFCPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool ADKILMCDFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool LAEEDPHFFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NAHEKKEMLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CFKAHGOFHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool APEJCNJBFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GLNPOGKFFOF HKOEECAPAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool NKILNNBAGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DFNEIAOCMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CNNGNGJFECF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PKFNCCKMOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CBGECBIBMHE KDNJGMEIIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool HNIMBEFHBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool FFIMAPLJOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool CBKLIKIJIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PLKHBEJBJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OICPHPEKEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JDCPPECGPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C85000", Offset = "0x6C83600", VA = "0x186C85000")]
	public static string KJEFPEHPIHE(IEFCHCLDIDC MADFKNCBFBG)
	{
		return null;
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
