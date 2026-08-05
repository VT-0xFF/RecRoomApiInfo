using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum PELIIIMLFIN : byte
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
public enum ANGNKLOGGHL : byte
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
public interface CHIEPMBALCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPPIDCJPGHN([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CIPLGNCCNPL([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PCAIFPHMGLJ([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HOJPPFELMAO([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PAGBAPGMHIJ([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NDFPHNEKEIN(ANGNKLOGGHL COENNKECAIM, [Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BOOEPBJCEIA([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JNGEMDJBAHK([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GFDNHPOEPJN([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JFALPHCAEAC([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LPOMAHALLGG([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool PDCPCJOHBMC([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FCAMLKKKBEI([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool GFAOPJGEMEI([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool GIDJFPHKKDM([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CPLHKHIEKGM([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LBBHGIHLHFD(HNOEFIFJGON ANEKAGILGGL, [Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool HCFJLDHLOPM(IJBEPHDCNGH ANEKAGILGGL, [Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BCGOEGFLLGD([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool LPKILDCJPGD([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool MPNKPKGLNMO([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OFDFBAHIDFM([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool OJLEBMAKOHH([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool EBPEGKHNFCK([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool AIPEAPAGJHG(ABFOAEOLJJE CPAMHBBHFKC, [Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool FIOLFKDIODN([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool HHMNBOIAFLH([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool OENDODBPLEO([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool PFHBAMFKNDM([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool PONHAKCPGKB(JPKFHGIAAIF GDFIFFCGCBF, [Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool IBDGONPCEOG([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool LPLNBNOIPOB([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool HFHHEJPPHLI([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PHNOABFCEIL([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HFLBFFLAOAB([Out] PELIIIMLFIN JLMJPLGEMPP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "35")]
	string BAADNKNEJCD(PELIIIMLFIN FIEPLOJIIPD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MBPOLBKNKEF
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7560860", Offset = "0x755F660", VA = "0x187560860")]
	public static bool GAKMFDHMHMP(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7561180", Offset = "0x755FF80", VA = "0x187561180")]
	public static bool KBKJGILKFJH(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x75615D0", Offset = "0x75603D0", VA = "0x1875615D0")]
	public static bool LPPIDCJPGHN(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x75604F0", Offset = "0x755F2F0", VA = "0x1875604F0")]
	public static bool CIPLGNCCNPL(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7561AC0", Offset = "0x75608C0", VA = "0x187561AC0")]
	public static bool PCAIFPHMGLJ(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7560EC0", Offset = "0x755FCC0", VA = "0x187560EC0")]
	public static bool HOJPPFELMAO(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7561A10", Offset = "0x7560810", VA = "0x187561A10")]
	public static bool PAGBAPGMHIJ(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7561730", Offset = "0x7560530", VA = "0x187561730")]
	public static bool NDFPHNEKEIN(this CHIEPMBALCJ JAKFGGFGGIH, ANGNKLOGGHL COENNKECAIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7560440", Offset = "0x755F240", VA = "0x187560440")]
	public static bool BOOEPBJCEIA(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x75610D0", Offset = "0x755FED0", VA = "0x1875610D0")]
	public static bool JNGEMDJBAHK(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7560A80", Offset = "0x755F880", VA = "0x187560A80")]
	public static bool GFDNHPOEPJN(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7561020", Offset = "0x755FE20", VA = "0x187561020")]
	public static bool JFALPHCAEAC(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7561520", Offset = "0x7560320", VA = "0x187561520")]
	public static bool LPOMAHALLGG(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7561B70", Offset = "0x7560970", VA = "0x187561B70")]
	public static bool PDCPCJOHBMC(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7560700", Offset = "0x755F500", VA = "0x187560700")]
	public static bool FCAMLKKKBEI(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x75609D0", Offset = "0x755F7D0", VA = "0x1875609D0")]
	public static bool GFAOPJGEMEI(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7560B30", Offset = "0x755F930", VA = "0x187560B30")]
	public static bool GIDJFPHKKDM(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x75605A0", Offset = "0x755F3A0", VA = "0x1875605A0")]
	public static bool CPLHKHIEKGM(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x75612F0", Offset = "0x75600F0", VA = "0x1875612F0")]
	public static bool LBBHGIHLHFD(this CHIEPMBALCJ JAKFGGFGGIH, HNOEFIFJGON ANEKAGILGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7560BE0", Offset = "0x755F9E0", VA = "0x187560BE0")]
	public static bool HCFJLDHLOPM(this CHIEPMBALCJ JAKFGGFGGIH, IJBEPHDCNGH ANEKAGILGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7560390", Offset = "0x755F190", VA = "0x187560390")]
	public static bool BCGOEGFLLGD(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x75613C0", Offset = "0x75601C0", VA = "0x1875613C0")]
	public static bool LPKILDCJPGD(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7561680", Offset = "0x7560480", VA = "0x187561680")]
	public static bool MPNKPKGLNMO(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x75618B0", Offset = "0x75606B0", VA = "0x1875618B0")]
	public static bool OFDFBAHIDFM(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7561960", Offset = "0x7560760", VA = "0x187561960")]
	public static bool OJLEBMAKOHH(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7560650", Offset = "0x755F450", VA = "0x187560650")]
	public static bool EBPEGKHNFCK(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x75602C0", Offset = "0x755F0C0", VA = "0x1875602C0")]
	public static bool AIPEAPAGJHG(this CHIEPMBALCJ JAKFGGFGGIH, ABFOAEOLJJE CPAMHBBHFKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x75607B0", Offset = "0x755F5B0", VA = "0x1875607B0")]
	public static bool FIOLFKDIODN(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7560E10", Offset = "0x755FC10", VA = "0x187560E10")]
	public static bool HHMNBOIAFLH(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7561800", Offset = "0x7560600", VA = "0x187561800")]
	public static bool OENDODBPLEO(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7561C20", Offset = "0x7560A20", VA = "0x187561C20")]
	public static bool PFHBAMFKNDM(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7561D80", Offset = "0x7560B80", VA = "0x187561D80")]
	public static bool PONHAKCPGKB(this CHIEPMBALCJ JAKFGGFGGIH, JPKFHGIAAIF GDFIFFCGCBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7560F70", Offset = "0x755FD70", VA = "0x187560F70")]
	public static bool IBDGONPCEOG(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7561470", Offset = "0x7560270", VA = "0x187561470")]
	public static bool LPLNBNOIPOB(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7560CB0", Offset = "0x755FAB0", VA = "0x187560CB0")]
	public static bool HFHHEJPPHLI(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7561CD0", Offset = "0x7560AD0", VA = "0x187561CD0")]
	public static bool PHNOABFCEIL(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7560D60", Offset = "0x755FB60", VA = "0x187560D60")]
	public static bool HFLBFFLAOAB(this CHIEPMBALCJ JAKFGGFGGIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum OIGLBPNJANH : byte
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
public enum CHLHJEOPCFK : byte
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
public enum HNOEFIFJGON : byte
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
public enum IJBEPHDCNGH : byte
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
public enum ABFOAEOLJJE : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	RegularObjects = 2,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ConditionallyRestrictedObjects = 6
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum JPKFHGIAAIF
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	UnblockedCreators = 2,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	All = 6
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DFIFGHKKLII
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	PELIIIMLFIN MENCOOOAIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LPPIDCJPGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CIPLGNCCNPL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PCAIFPHMGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HOJPPFELMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CHLHJEOPCFK BMAHMHEBEOD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BOOEPBJCEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool JNGEMDJBAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GFDNHPOEPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JFALPHCAEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool LPOMAHALLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PDCPCJOHBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool FCAMLKKKBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GFAOPJGEMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GIDJFPHKKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool CPLHKHIEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HNOEFIFJGON ENJNAHOALDB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IJBEPHDCNGH MHCNPKJAFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool BCGOEGFLLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LPKILDCJPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool MPNKPKGLNMO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OFDFBAHIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool OJLEBMAKOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EBPEGKHNFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	ABFOAEOLJJE MAEDFLIKMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool FIOLFKDIODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HHMNBOIAFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OENDODBPLEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool PFHBAMFKNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	JPKFHGIAAIF OPFOCCNKECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool IBDGONPCEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LPLNBNOIPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool HFHHEJPPHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PHNOABFCEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HFLBFFLAOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EMMAHBHJJMN
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7560250", Offset = "0x755F050", VA = "0x187560250")]
	public static string CEAKLFGBBFP(PELIIIMLFIN EDLHCINOAKH)
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
