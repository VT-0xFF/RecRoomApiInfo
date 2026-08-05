using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum HBELEMECPBB : byte
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
public enum BEOEAKPNMEM : byte
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
public interface MADIJKNICIM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BENOGINLEFF([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DDMOJHDOBLO([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AKJHENCCIII([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KMIEGIAACKE([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GEMJLBDIEBO(BEOEAKPNMEM BPLACFKMLDG, [Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FBIFPKEJILL([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NGLLCKAPBKJ([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FOHLFDNDEPC([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JCMCIFPOPEF([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CKPDCNPPGDE([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NBJPAMJKFGN([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LOLIJFCGKGK([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BDACALCHNPF([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KGGHMHDPDFE([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool BDDPLDIDAAN([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NJNCCLIHGFC(CIDMODAOJGJ IHCNNKNNOHD, [Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool DPFJDLANHMG(HIMPFPFIAME IHCNNKNNOHD, [Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool BBEDOEBHBAK([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CBEENMGCJHK([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool PHNNAMDIGHD([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool MLLECKMKAHA([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool KAODGOIAPPO([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool MEOAENGKHDJ([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool NJJBLKECJIE(PABOCFMNHFO HGELMBEOPOH, [Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool GCCGHAOIGOB([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool PMBCHGBDFLI([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool IBJCIOPHKCB([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DMNAFODGPDG([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool DKPJCKJEJII(JHNINJKPCHB FJJFJKNJJEA, [Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool OCGINPHFLKP([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool AIGJOIGAEON([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool LFENCADPCDE([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool DPKCMDIGIIH([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool DACNMPAFHON([Out] HBELEMECPBB LLLKNAJJKGB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	string EOGPNEFHHEB(HBELEMECPBB KMJMFHMNFOE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FDKDNFPJLAG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C150", Offset = "0x6C2A750", VA = "0x186C2C150")]
	public static bool GHDBPMLMKNH(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C8C0", Offset = "0x6C2AEC0", VA = "0x186C2C8C0")]
	public static bool MKNFNGGCOPE(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B770", Offset = "0x6C29D70", VA = "0x186C2B770")]
	public static bool BENOGINLEFF(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BA60", Offset = "0x6C2A060", VA = "0x186C2BA60")]
	public static bool DDMOJHDOBLO(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B470", Offset = "0x6C29A70", VA = "0x186C2B470")]
	public static bool AKJHENCCIII(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C5C0", Offset = "0x6C2ABC0", VA = "0x186C2C5C0")]
	public static bool KMIEGIAACKE(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C080", Offset = "0x6C2A680", VA = "0x186C2C080")]
	public static bool GEMJLBDIEBO(this MADIJKNICIM NKCCIBMIBBE, BEOEAKPNMEM BPLACFKMLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BE40", Offset = "0x6C2A440", VA = "0x186C2BE40")]
	public static bool FBIFPKEJILL(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CBB0", Offset = "0x6C2B1B0", VA = "0x186C2CBB0")]
	public static bool NGLLCKAPBKJ(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BF00", Offset = "0x6C2A500", VA = "0x186C2BF00")]
	public static bool FOHLFDNDEPC(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C380", Offset = "0x6C2A980", VA = "0x186C2C380")]
	public static bool JCMCIFPOPEF(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B8E0", Offset = "0x6C29EE0", VA = "0x186C2B8E0")]
	public static bool CKPDCNPPGDE(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CAF0", Offset = "0x6C2B0F0", VA = "0x186C2CAF0")]
	public static bool NBJPAMJKFGN(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C740", Offset = "0x6C2AD40", VA = "0x186C2C740")]
	public static bool LOLIJFCGKGK(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B5F0", Offset = "0x6C29BF0", VA = "0x186C2B5F0")]
	public static bool BDACALCHNPF(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C500", Offset = "0x6C2AB00", VA = "0x186C2C500")]
	public static bool KGGHMHDPDFE(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B6B0", Offset = "0x6C29CB0", VA = "0x186C2B6B0")]
	public static bool BDDPLDIDAAN(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CD40", Offset = "0x6C2B340", VA = "0x186C2CD40")]
	public static bool NJNCCLIHGFC(this MADIJKNICIM NKCCIBMIBBE, CIDMODAOJGJ IHCNNKNNOHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BCB0", Offset = "0x6C2A2B0", VA = "0x186C2BCB0")]
	public static bool DPFJDLANHMG(this MADIJKNICIM NKCCIBMIBBE, HIMPFPFIAME IHCNNKNNOHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B530", Offset = "0x6C29B30", VA = "0x186C2B530")]
	public static bool BBEDOEBHBAK(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B820", Offset = "0x6C29E20", VA = "0x186C2B820")]
	public static bool CBEENMGCJHK(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CED0", Offset = "0x6C2B4D0", VA = "0x186C2CED0")]
	public static bool PHNNAMDIGHD(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CA30", Offset = "0x6C2B030", VA = "0x186C2CA30")]
	public static bool MLLECKMKAHA(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C440", Offset = "0x6C2AA40", VA = "0x186C2C440")]
	public static bool KAODGOIAPPO(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C800", Offset = "0x6C2AE00", VA = "0x186C2C800")]
	public static bool MEOAENGKHDJ(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CC70", Offset = "0x6C2B270", VA = "0x186C2CC70")]
	public static bool NJJBLKECJIE(this MADIJKNICIM NKCCIBMIBBE, PABOCFMNHFO HGELMBEOPOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BFC0", Offset = "0x6C2A5C0", VA = "0x186C2BFC0")]
	public static bool GCCGHAOIGOB(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CF90", Offset = "0x6C2B590", VA = "0x186C2CF90")]
	public static bool PMBCHGBDFLI(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C2C0", Offset = "0x6C2A8C0", VA = "0x186C2C2C0")]
	public static bool IBJCIOPHKCB(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BBF0", Offset = "0x6C2A1F0", VA = "0x186C2BBF0")]
	public static bool DMNAFODGPDG(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BB20", Offset = "0x6C2A120", VA = "0x186C2BB20")]
	public static bool DKPJCKJEJII(this MADIJKNICIM NKCCIBMIBBE, JHNINJKPCHB FJJFJKNJJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CE10", Offset = "0x6C2B410", VA = "0x186C2CE10")]
	public static bool OCGINPHFLKP(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B3B0", Offset = "0x6C299B0", VA = "0x186C2B3B0")]
	public static bool AIGJOIGAEON(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C680", Offset = "0x6C2AC80", VA = "0x186C2C680")]
	public static bool LFENCADPCDE(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BD80", Offset = "0x6C2A380", VA = "0x186C2BD80")]
	public static bool DPKCMDIGIIH(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B9A0", Offset = "0x6C29FA0", VA = "0x186C2B9A0")]
	public static bool DACNMPAFHON(this MADIJKNICIM NKCCIBMIBBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum MEJPOAANGBD : byte
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
public enum HHAFCICAJNB : byte
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
public enum CIDMODAOJGJ : byte
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
public enum HIMPFPFIAME : byte
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
public enum PABOCFMNHFO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RegularObjects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConditionallyRestrictedObjects = 6
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum JHNINJKPCHB
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	UnblockedCreators = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = 6
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BPEJBPHAOJG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HBELEMECPBB OFDAICEIOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BENOGINLEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DDMOJHDOBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AKJHENCCIII
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HHAFCICAJNB IGPPDEBFABM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FBIFPKEJILL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NGLLCKAPBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FOHLFDNDEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JCMCIFPOPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CKPDCNPPGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool NBJPAMJKFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LOLIJFCGKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BDACALCHNPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KGGHMHDPDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BDDPLDIDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CIDMODAOJGJ JCMLBNMDPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HIMPFPFIAME LGCHBJBMKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool BBEDOEBHBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool CBEENMGCJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PHNNAMDIGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MLLECKMKAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KAODGOIAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MEOAENGKHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	PABOCFMNHFO LMJKLCEFLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GCCGHAOIGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PMBCHGBDFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IBJCIOPHKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool DMNAFODGPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	JHNINJKPCHB INPMJFKAPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool OCGINPHFLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool AIGJOIGAEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LFENCADPCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DPKCMDIGIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DACNMPAFHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MLBJAMNFNBE
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D050", Offset = "0x6C2B650", VA = "0x186C2D050")]
	public static string DKACNJODHNL(HBELEMECPBB JOCJMGGBHIC)
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
