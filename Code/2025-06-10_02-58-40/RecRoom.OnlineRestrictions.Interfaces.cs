using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum FGDEPBGLNII : byte
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
public enum FOINPJINGEM : byte
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
public interface MCCNADEBFLC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OHEFCLKCDMD([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MPCMGKGLBPP([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ANBPNLBIIAK([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OMHJBLONAMG([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MOMNAFBEOLO([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NJNPBOHAIAD(FOINPJINGEM CEJIDBLNDHP, [Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MGPOEDAHAPH([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KENHPEICLHK([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HOJHEAELNDP([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HGIHONEJNLB([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KGMNPEOOMEK([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GEFPLIFJGOC([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ADNNBKFDLDD([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool CAEKOHHFMHH([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool EDIPICHPOIC([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool NKKDLHBBLFL([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool HMIJHCBHNBE(POMMHOFONBO PMKDGGBOKBI, [Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool POEGDPIBCOE(NINIEFKJHJN PMKDGGBOKBI, [Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HBPKKDEOOKD([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool KEMGLOILFNP([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool APOFMHKICPC([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OJNFOGCFLJH([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool IMANFFOONJA([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool LEEFMHAEKLO([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool KGEHFOHGAFF(MHLABCLMLML BHGHJPNDBMK, [Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CCNPIADBBGF([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool GDHEGDFNJKP([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool HLMICDBIJPJ([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool INLHFCBEGBH([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool IMMPAJCHJED(EEKBNPMGDMG GBMKDAMAOMB, [Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool LAJPDMGFGKJ([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool ECFFOJJDLFE([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool BOJGCNPEODO([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool NDNLOMDAKGJ([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HEDHGONHHGP([Out] FGDEPBGLNII AMDMCFPLOGP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	string FNFIGGFHMAJ(FGDEPBGLNII KHNGMHPGOLE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AMPNJKHLKIC
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB950", Offset = "0x7FEAB50", VA = "0x187FEB950")]
	public static bool LLINGCMDKLF(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB350", Offset = "0x7FEA550", VA = "0x187FEB350")]
	public static bool IOHGDJLMPMO(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBF50", Offset = "0x7FEB150", VA = "0x187FEBF50")]
	public static bool OHEFCLKCDMD(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBC40", Offset = "0x7FEAE40", VA = "0x187FEBC40")]
	public static bool MPCMGKGLBPP(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA5B0", Offset = "0x7FE97B0", VA = "0x187FEA5B0")]
	public static bool ANBPNLBIIAK(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC0C0", Offset = "0x7FEB2C0", VA = "0x187FEC0C0")]
	public static bool OMHJBLONAMG(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBB80", Offset = "0x7FEAD80", VA = "0x187FEBB80")]
	public static bool MOMNAFBEOLO(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBDC0", Offset = "0x7FEAFC0", VA = "0x187FEBDC0")]
	public static bool NJNPBOHAIAD(this MCCNADEBFLC LHPDGBFBJHN, FOINPJINGEM CEJIDBLNDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBAC0", Offset = "0x7FEACC0", VA = "0x187FEBAC0")]
	public static bool MGPOEDAHAPH(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB580", Offset = "0x7FEA780", VA = "0x187FEB580")]
	public static bool KENHPEICLHK(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB040", Offset = "0x7FEA240", VA = "0x187FEB040")]
	public static bool HOJHEAELNDP(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7FEADF0", Offset = "0x7FE9FF0", VA = "0x187FEADF0")]
	public static bool HGIHONEJNLB(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB710", Offset = "0x7FEA910", VA = "0x187FEB710")]
	public static bool KGMNPEOOMEK(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7FEABB0", Offset = "0x7FE9DB0", VA = "0x187FEABB0")]
	public static bool GEFPLIFJGOC(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA4F0", Offset = "0x7FE96F0", VA = "0x187FEA4F0")]
	public static bool ADNNBKFDLDD(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA7F0", Offset = "0x7FE99F0", VA = "0x187FEA7F0")]
	public static bool CAEKOHHFMHH(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAA30", Offset = "0x7FE9C30", VA = "0x187FEAA30")]
	public static bool EDIPICHPOIC(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBE90", Offset = "0x7FEB090", VA = "0x187FEBE90")]
	public static bool NKKDLHBBLFL(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAF70", Offset = "0x7FEA170", VA = "0x187FEAF70")]
	public static bool HMIJHCBHNBE(this MCCNADEBFLC LHPDGBFBJHN, POMMHOFONBO PMKDGGBOKBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC180", Offset = "0x7FEB380", VA = "0x187FEC180")]
	public static bool POEGDPIBCOE(this MCCNADEBFLC LHPDGBFBJHN, NINIEFKJHJN PMKDGGBOKBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAC70", Offset = "0x7FE9E70", VA = "0x187FEAC70")]
	public static bool HBPKKDEOOKD(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB4C0", Offset = "0x7FEA6C0", VA = "0x187FEB4C0")]
	public static bool KEMGLOILFNP(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA670", Offset = "0x7FE9870", VA = "0x187FEA670")]
	public static bool APOFMHKICPC(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC000", Offset = "0x7FEB200", VA = "0x187FEC000")]
	public static bool OJNFOGCFLJH(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB100", Offset = "0x7FEA300", VA = "0x187FEB100")]
	public static bool IMANFFOONJA(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB890", Offset = "0x7FEAA90", VA = "0x187FEB890")]
	public static bool LEEFMHAEKLO(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB640", Offset = "0x7FEA840", VA = "0x187FEB640")]
	public static bool KGEHFOHGAFF(this MCCNADEBFLC LHPDGBFBJHN, MHLABCLMLML BHGHJPNDBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA8B0", Offset = "0x7FE9AB0", VA = "0x187FEA8B0")]
	public static bool CCNPIADBBGF(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAAF0", Offset = "0x7FE9CF0", VA = "0x187FEAAF0")]
	public static bool GDHEGDFNJKP(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAEB0", Offset = "0x7FEA0B0", VA = "0x187FEAEB0")]
	public static bool HLMICDBIJPJ(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB290", Offset = "0x7FEA490", VA = "0x187FEB290")]
	public static bool INLHFCBEGBH(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB1C0", Offset = "0x7FEA3C0", VA = "0x187FEB1C0")]
	public static bool IMMPAJCHJED(this MCCNADEBFLC LHPDGBFBJHN, EEKBNPMGDMG GBMKDAMAOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FEB7D0", Offset = "0x7FEA9D0", VA = "0x187FEB7D0")]
	public static bool LAJPDMGFGKJ(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA970", Offset = "0x7FE9B70", VA = "0x187FEA970")]
	public static bool ECFFOJJDLFE(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7FEA730", Offset = "0x7FE9930", VA = "0x187FEA730")]
	public static bool BOJGCNPEODO(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBD00", Offset = "0x7FEAF00", VA = "0x187FEBD00")]
	public static bool NDNLOMDAKGJ(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FEAD30", Offset = "0x7FE9F30", VA = "0x187FEAD30")]
	public static bool HEDHGONHHGP(this MCCNADEBFLC LHPDGBFBJHN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum BJLPOMOOLKL : byte
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
public enum NCDPINNCPGD : byte
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
public enum POMMHOFONBO : byte
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
public enum NINIEFKJHJN : byte
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
public enum MHLABCLMLML : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RegularObjects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConditionallyRestrictedObjects = 6
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum EEKBNPMGDMG
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	UnblockedCreators = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = 6
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KIEJCPGHGPL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	FGDEPBGLNII CCGAMOFDCJM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool OHEFCLKCDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MPCMGKGLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ANBPNLBIIAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OMHJBLONAMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NCDPINNCPGD FBBIAENLFHD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MGPOEDAHAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KENHPEICLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool HOJHEAELNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool HGIHONEJNLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KGMNPEOOMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool GEFPLIFJGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ADNNBKFDLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CAEKOHHFMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool EDIPICHPOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NKKDLHBBLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	POMMHOFONBO NJBDJLKNFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NINIEFKJHJN ADFCKAIPLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool HBPKKDEOOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool KEMGLOILFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool APOFMHKICPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OJNFOGCFLJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool IMANFFOONJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LEEFMHAEKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	MHLABCLMLML CGPICBGCIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CCNPIADBBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GDHEGDFNJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool HLMICDBIJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool INLHFCBEGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	EEKBNPMGDMG GLLCADAOCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool LAJPDMGFGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool ECFFOJJDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BOJGCNPEODO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool NDNLOMDAKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HEDHGONHHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FHJNIAOAABK
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC250", Offset = "0x7FEB450", VA = "0x187FEC250")]
	public static string PHDAEKMENOA(FGDEPBGLNII MLMPPNLIAEF)
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
