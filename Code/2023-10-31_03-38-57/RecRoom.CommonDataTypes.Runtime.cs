using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct GameTeamColorSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public bool TeamOutfitColorEmissionEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float TeamOutfitColorEmissionAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public TeamColor[] CustomTeamColors;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BFCF70", Offset = "0x5BFC370", VA = "0x185BFCF70")]
	public bool BPNPGDGFHCI(FGNECAEAMMM JPKLFCCFOKE, [Out] Color DJDNAMFLFCL, bool OHLFEDMFLLB = false)
	{
		return default(bool);
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct TeamColor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public FGNECAEAMMM Team;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Color AlternateColor;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FGNECAEAMMM
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TEAM_1 = 0,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	TEAM_2 = 1,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TEAM_3 = 2,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	TEAM_4 = 3,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	TEAM_5 = 4,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	TEAM_6 = 5,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	TEAM_7 = 6,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	TEAM_8 = 7,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	TEAM_9 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	TEAM_10 = 9,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	TEAM_11 = 10,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	TEAM_12 = 11,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	TEAM_13 = 12,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	TEAM_14 = 13,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	TEAM_15 = 14,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	TEAM_16 = 15,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	TEAM_17 = 16,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	TEAM_18 = 17,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	TEAM_19 = 18,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	TEAM_20 = 19,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	TEAM_21 = 20,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	TEAM_22 = 21,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	TEAM_23 = 22,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	TEAM_24 = 23,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TEAM_25 = 24,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	TEAM_26 = 25,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	TEAM_27 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TEAM_28 = 27,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	TEAM_29 = 28,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	TEAM_30 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	TEAM_31 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	TEAM_32 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	TEAM_33 = 32,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	TEAM_34 = 33,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	TEAM_35 = 34,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	TEAM_36 = 35,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	TEAM_37 = 36,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	TEAM_38 = 37,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	TEAM_39 = 38,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TEAM_40 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	ANY = -1,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	MAX_VALUE = 39
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PKBDPNJCFBO
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	PERMANENT,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	ROOM_SUPPORT,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	CUSTOM_LOCOMOTION,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	DEBUG
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BNBGMEDENDO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BAAFBOAGLJE KPDKEGOAACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BAAFBOAGLJE BFHMJLCJNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LNBCGNKPFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IHONIJOODNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OAELJMFAJKM CHELLBNIFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AddVRMovementModeRequest(KGJCEAPLGMK HEMGDOJCBKK, object KJAGMGIFCEM, PKBDPNJCFBO AAEOMDCOKDH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void RemoveVRMovementModeRequest(object KJAGMGIFCEM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JOBJDEAOKCN
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	MODE_1,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	MODE_2,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	MODE_3,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	MODE_4,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	MODE_5,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	MODE_6,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	MODE_7,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	MODE_8,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	MODE_9,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	MODE_10
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum JOJPKAFFDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Code,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	PartyGesture,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	ProfileScreen,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	PeopleMenuShortcut,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	InviteToPartyDialog,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	PartyInviteInChat,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	AutoRejoinPartyChat,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	InviteOnlineFriends,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	PartyInviteMessage
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BAAFBOAGLJE
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	VR_WALK,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	VR_TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NCBOMIGIBNC
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	NONE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	OFFERER,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	ACCEPTER
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum PGEGPJDNGMO
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	FriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	FavoriteFriendsOnly,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Offline
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum KGJCEAPLGMK
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	TELEPORT,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	WALK
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ENAHPFLGOKO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BFCF60", Offset = "0x5BFC360", VA = "0x185BFCF60")]
	public static BAAFBOAGLJE NIJHIDLDGIP(this KGJCEAPLGMK DGDIMEGBJJP)
	{
		return default(BAAFBOAGLJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BLILHMGBHMD]
public class KBKJGNJMCDI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public string CMEGEFCLJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KBKJGNJMCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[BLILHMGBHMD]
public class NJAAHLPBMGP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long GCMFHNCGAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x11802D0", Offset = "0x117F6D0", VA = "0x1811802D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public NJAAHLPBMGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BLILHMGBHMD]
public class GGBJLJLEDMF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int HDAPECJNDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75C180", Offset = "0x75B580", VA = "0x18075C180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x766EA0", Offset = "0x7662A0", VA = "0x180766EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GGBJLJLEDMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BLILHMGBHMD]
public class OCDHDANFAEB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long KKLEHCHFOID
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x11802D0", Offset = "0x117F6D0", VA = "0x1811802D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OCDHDANFAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BLILHMGBHMD]
public class MBGNGNBLHIN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string LKEHLMKADPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MBGNGNBLHIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BLILHMGBHMD]
public class LPDDHBAKOFO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HFLIKNMJBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75C180", Offset = "0x75B580", VA = "0x18075C180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x766EA0", Offset = "0x7662A0", VA = "0x180766EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LPDDHBAKOFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BLILHMGBHMD]
public class EKIBFDJKKGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Guid IPABHHJJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1A94150", Offset = "0x1A93550", VA = "0x181A94150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EKIBFDJKKGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[BLILHMGBHMD]
public class IPGNPFPMHDH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int KGBPFMAJKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x75C180", Offset = "0x75B580", VA = "0x18075C180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x766EA0", Offset = "0x7662A0", VA = "0x180766EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IPGNPFPMHDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BLILHMGBHMD]
public class MKIMECJANJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public long IDEBHPKPMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x11802D0", Offset = "0x117F6D0", VA = "0x1811802D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MKIMECJANJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[BLILHMGBHMD]
public class HAMOOFABGFN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public long MHMEEOJJHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x11802D0", Offset = "0x117F6D0", VA = "0x1811802D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HAMOOFABGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[BLILHMGBHMD]
public class KHKOAILNHCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string DDACLMPPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int? BJIHFMCDNCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xD2B4E0", Offset = "0xD2A8E0", VA = "0x180D2B4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KHKOAILNHCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[BLILHMGBHMD]
public class GHCLFBCGHEN
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public long GAGCEPHBGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x11802D0", Offset = "0x117F6D0", VA = "0x1811802D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GHCLFBCGHEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum GPCHFLNELFN
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	New,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Daily,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Weekly
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BLILHMGBHMD]
public class FMCAFOLLOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GPCHFLNELFN? AIGJMECCBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x11802D0", Offset = "0x117F6D0", VA = "0x1811802D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FMCAFOLLOOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[BLILHMGBHMD]
public class POKCPJCMCCP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int HDAPECJNDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75C180", Offset = "0x75B580", VA = "0x18075C180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x766EA0", Offset = "0x7662A0", VA = "0x180766EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public POKCPJCMCCP()
	{
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
