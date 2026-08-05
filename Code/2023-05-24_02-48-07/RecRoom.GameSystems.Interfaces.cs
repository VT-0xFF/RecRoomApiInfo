using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum DNEOJGLBICE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Desktop_Valve,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Desktop_Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	PS4,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Desktop_MicrosoftVR,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Desktop_VRMissing,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OculusQuest,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	iOS,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	AndroidMobile,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	PicoNeo3,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	PicoPhoenix
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum OFJOOOIPNJB
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Desktop_Valve = 1,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Desktop_Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	PS4 = 4,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Desktop_MicrosoftVR = 8,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Desktop_VRMissing = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OculusQuest = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	iOS = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	XboxOne = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	AndroidMobile = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	PS5 = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	XboxSeries = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	PicoNeo3 = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	PicoPhoenix = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DBCICEJFIGD
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Landscape,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Portrait
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FDKKPKBEFIA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GFGOMOAECGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NAJLLGOGGBM(object FLDJLPKNKKO, bool HDFKCNNDKFP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum ABKJPJCNAKA
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Room,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Club,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Invention,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	PlayerEvents
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CCINDCBBMBH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T EJPBIMKBGBN<T>(string ECNGHFJBIJL);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KHINEMMODAO : ONAMNBNIGNC, GJANOCFHBPK, ONFJPKBEIOK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	RegionInfo GJOFFGMOOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IMNHIJEJNHL IICEIPAFCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ELODCOFCJAF NOELIKLEOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DNEOJGLBICE BAMPNIPHJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DBCICEJFIGD JDEPHFPMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool FDPGEKDKNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool DAMMANJKEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool AIDHONFFCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GCJMHBJJMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KNJOAODOBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LDKMFOCMHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool AENDPNEKEJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool OPIOBIDMELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "13")]
	global::NBFPPJGKGOH<DateTime?> GetPlatformProfileDateOfBirth();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IsEULARequired();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "15")]
	string GetEULA();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AcceptEULA();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "17")]
	EILHPPDHBHH PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EILHPPDHBHH RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "20")]
	global::NBFPPJGKGOH<IFBJBHHOBLC> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "21")]
	EILHPPDHBHH RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	EILHPPDHBHH RequestContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool HasContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool CanAskForContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool SupportsLinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IsCrossPlatformWarningRequired();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AcceptCrossPlatformWarning();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool IsForcedIsolationByPlatformSettings(out string AGACDCPAEFB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool IsSiloedMatchmakingEnabled();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool RequestCrossPlatformMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool RequestSiloedMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "33")]
	OLKDHCCNMMP.KMCMNIHKGLL GetPlatformFriendPicture(string PAMKAEFJHCF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FPODAMBEHMF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool BPIPEDCBNDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 EGEBNAJBGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 GMIOANFJBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Camera CDEDFJNNGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GameObject DIHOBBKCAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OIAJAJMGGGM IDLLIFFJNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OIAJAJMGGGM
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float HCGOLLIBEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum IFBJBHHOBLC
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IIIPBDCLFLH
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool DEOOMLLIALM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KBJOPGEOOCH GKKFMBPBKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CKKILPBAGPK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HBEKKDGJBIH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<IJEKAOPMGPB.LFLFBHBOLNA> OMKCKBJJAAN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CDGEHOPMHLN(AHPFPOOHAEN DOPKHDMJANO);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MOCHHOPAFCB();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGCFINKKBII(IJEKAOPMGPB.LFLFBHBOLNA JDILIPNHLAM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JCOIHNPPJEE
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool OIBMOOIKICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BBDNFHGFMBE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HJDOBAAJFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool AMHEMBNKKFP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GLGGKOPKDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool GBCHMHPBECM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool MDMEGDMNGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> AMJPFFIIHHG;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EILHPPDHBHH DHDLMJMDLLF();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OHENKGKJMCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public BOCGJDJJCBI FABCNDBLNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public long FDDMIOGNDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public long CFKIIOCPMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public string NMAGJFJEGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public OAHICNLFADF? CGHIBBMOEGO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OAHICNLFADF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public string BHCLBOFKJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string[] CGHAHCDOBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Dictionary<string, string> PDPINMGCONN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum BOCGJDJJCBI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	NOT_SET = 0,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	BOOT = 1,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GAME_LOADING_NEXT_LEVEL = 2,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	PORTAL = 3,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	AFK = 4,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	VOTE_KICKED = 5,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CHEAT = 6,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	ROOM_BANNED = 7,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	ACCEPTED_GAME_INVITE = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	PARTY_ACTIVITY_SWITCH = 9,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	NOTIFICATION_NEW_ROOM_FROM_CREATOR = 10,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	NOTIFICATION_PLAYER_EVENT = 11,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	PEOPLE_MENU = 12,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	ACTIVITY_SELECT_MENU = 13,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	PERSISTENCE_ERROR = 14,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CIRCUIT_REINITIALIZE_ERROR = 15,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	BULLETIN_BOARD_FEATURED_ROOMS = 16,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	__DEPRECATED_CUSTOM_ROOMS_WATCH = 17,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[Obsolete]
	__DEPRECATED_CUSTOM_ROOMS_DOOR_V1_OR_RELOAD_ACTIVITY_OR_FOLLOW_PARTY_AFTER_DOOR = 18,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	QUIT = 19,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	EVENT_DIRECT_GOTO = 20,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	EVENT_NOTIFICATION = 21,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	REC_CENTER_SLIDESHOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	COHORT_NUX = 23,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	QUICK_LAUNCH_MENU = 24,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ANNOUNCEMENT = 25,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	DEPRECATED_1 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	DELAYED_ROOM_WARNING = 27,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	ROOM_CODE = 28,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	ROOM_COMMENT_NOTIFICATION = 29,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CLUBHOUSE_DIRECT_GOTO = 30,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CREATORANNOUNCEMENT_ROOMPUBLISHED = 31,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	FORCE_THROUGH_ADMIN_SITE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	RECOMMENDED_ROOMS_WATCH = 33,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	INSTANCE_FORCE_CLOSED = 34,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	HOT_ROOMS_WATCH = 35,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	LIVE_ROOMS_WATCH = 36,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	SEARCH_ROOMS_WATCH = 37,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	FAVORITE_ROOMS_WATCH = 38,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	DOOR_SELECT_WATCH = 39,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	FEATURED_ROOMS_WATCH = 40,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	RECNET_ROOMS_WATCH = 41,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	NEW_ROOMS_WATCH = 42,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	ROOM_COMMENT_TELEPORT = 43,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	CURATED_PLAYLISTS_WATCH = 44,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PLAYER_EVENT_CODE = 45,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	CREATORANNOUNCEMENT_EVENTPUBLISHED = 46,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ROOM_REJOIN_WATCH = 47,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	PLAYER_EVENT_DETAILS_WATCH = 48,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	RECENT_ROOMS_WATCH = 49,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	FRIEND_PRESENCE_ROOMS_WATCH = 50,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	MY_CLUBHOUSE_ROOMS_WATCH = 51,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	MY_SUBSCRIPTIONS_ROOMS_WATCH = 52,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	TOP_CREATORS_ROOMS_WATCH = 53,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MORE_FROM_CONTEST_WINNERS_ROOMS_WATCH = 54,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	RISING_ROOMS_WATCH = 88,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	ROOM_LINK_BUTTON = 55,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	ROOM_SHOWCASE_POSTER = 56,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	THIS_ROOM_WATCH = 57,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	REC_CENTER_WATCH = 58,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DORM_ROOM_WATCH = 59,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	ROOM_DETAILS_WATCH = 60,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CLONED_ROOM = 61,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CREATE_ROOM_RESUME_WATCH = 62,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	BROWSE_ROOMS_WATCH = 63,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	MEETUP_CODE = 64,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	TEST_CASE_WATCH = 65,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	CHAT_MESSAGE = 66,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	MY_CREATED_ROOMS_WATCH = 67,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	PLAYER_CREATED_ROOMS_WATCH = 68,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	PLAYER_SHOWCASE_ROOMS_WATCH = 69,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	CURRENT_CONTEST_ROOMS_WATCH = 70,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	TRENDING_TAGS_WATCH = 71,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	RRO_ROOMS_WATCH = 72,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	MAGIC_DOOR_DOOR = 73,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	MAGIC_DOOR_WATCH = 74,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	ROOM_NOTIFICATION_WATCH = 75,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	FOR_YOU_ROOMS_WATCH = 76,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	CLOUD_DATA_MENU = 77,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	SIMILAR_ROOMS_WATCH = 78,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	DEEP_LINK = 79,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	PLATFORM_NOTIFICATION_ACTION = 80,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	ROOM_JACKPOT = 81,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	RRUI_REMOTE_PLAYER_PROFILE = 82,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	ALL_KEEPSAKE_ROOMS = 83,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	STANDARD_KEEPSAKE_ROOMS = 84,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	PREMIUM_KEEPSAKE_ROOMS = 85,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	KEEPSAKE_ROOM_HIGHLIGHT = 86,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SHOW_ME_ALL_ROOMS = 87,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	BROADCASTING_LISTENER_DISCONNECT = 100,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CLUBHOUSE_WATCH_HOME = 101,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	ORIENTATION_DORM_DOOR = 102,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	MAKER_PEN_MAIN_MENU = 103,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	ROOM_CATEGORY_SELECT = 104,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	ACCEPTED_PARTY_INVITE = 105,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	XBOX_GAME_INVITE = 106,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	PLAYSTATION_GAME_INVITE = 107,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	PHOTO_DETAILS_WATCH = 108,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	IMAGE_FEED_ITEM = 109,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	CIRCUITS_V2_GO_TO_ROOM = 110,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CLUBHOUSE_OPTIONS_WATCH = 111,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	SESSION_TAKEOVER = 112,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	DEBUG_CONSOLE = 113,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	PROGRESSSION_EVENT_TUTORIAL = 114,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	MESSAGE_CARD_IMAGE_CLICKED = 115,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	ROOM_EARNINGS_MESSAGE_CARD_BUTTON_CLICKED = 116,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	CUSTOM_ROOM_DOOR = 118,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RELOAD_ACTIVITY = 119,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	FOLLOW_PARTY_AFTER_DOOR = 120,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	HOME_LOGIN = 121,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	HOME_ROOM = 122,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	PLAY_MENU_BANNER = 123,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	REC_ROOM_CREATOR_ACADEMY_WATCH = 200,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	RRCA_LEARN_TO_CREATE_WATCH = 201,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	RRCA_CREATION_TUTORIALS_WATCH = 202,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RRCA_BUILDING_TUTORIALS_WATCH = 203,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	RRCA_CIRCUITS_TUTORIALS_WATCH = 204
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LPLLDHMHBCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool EKJFHILKKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Matchmaking.PAFIILGBNBC JOOMDEJHLDB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x13AADD0", Offset = "0x13A99D0", VA = "0x1813AADD0")]
	public LPLLDHMHBCF(Matchmaking.PAFIILGBNBC EGMEOIADPFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HAOMCPLNIHN
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool PFHINLDLMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum DJDAPLJGMAK
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	LeaveParty,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	InviteParty,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	PartyAutoFollow,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	EveryoneAutoFollow
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BPLECKBHGOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool JKCDCIIFNCB;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HPJADCOJLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xC23F10", Offset = "0xC22B10", VA = "0x180C23F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x13AADC0", Offset = "0x13A99C0", VA = "0x1813AADC0")]
	public void KGJCOHKEPMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1341480", Offset = "0x1340080", VA = "0x181341480")]
	public BPLECKBHGOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EFFPBJKNPNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HGLLIBHDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<BPLECKBHGOB> IBAELCBGCCA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMKJGDMMEDE();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OHENKGKJMCK GDLEKJODBLJ();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDFACNIFDFE(BOCGJDJJCBI PDHOFJLLEID);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KAAEOFHCGLI(LIGMBBOOEMF KADFJBDLABD, MPOOILGCDLJ CJNLJKIIPKB, string LCFFGMKJPDD, [Optional] Action<LPLLDHMHBCF> AJGFNLBEHNM);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ECBEBNINMII(string CLOEFHDDMBG, BOCGJDJJCBI ADPIDJIDOLP, bool HHCMBBLAOJF = false);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KMPIAECAEEE(int FNPPFCMGJKO, DJDAPLJGMAK BLEGJONFILE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OHIKEONEFKK(LIGMBBOOEMF KADFJBDLABD, int FNPPFCMGJKO, BOCGJDJJCBI ADPIDJIDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ACLCFJGKKKN(LIGMBBOOEMF KADFJBDLABD, OLHHKEMEKPM ODKAJOECGEC, BOCGJDJJCBI ADPIDJIDOLP);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MGNHCEMCJED(LIGMBBOOEMF KADFJBDLABD, ChatMessage EGHKCEJDIBI, long LMJFKBCCOEI, [Optional] Action<LPLLDHMHBCF> AJGFNLBEHNM);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LICNJDJJDJE(MPOOILGCDLJ CJNLJKIIPKB, BOCGJDJJCBI ADPIDJIDOLP, DJDAPLJGMAK BLEGJONFILE, bool DPLOHFOMAHA, string KKFEOGMAMPI = "");

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "13")]
	[Obsolete]
	void PKLOOMPONCC(string AGJEHAHDINL, string CKJCLPLEMFG, OHENKGKJMCK ALDLCGKLBIB, bool EEOFGPMAIJC, [Optional] Action<LPLLDHMHBCF> AJGFNLBEHNM);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PKLOOMPONCC(long HAMIEGOKEJC, OHENKGKJMCK ALDLCGKLBIB, bool EEOFGPMAIJC, [Optional] Action<LPLLDHMHBCF> AJGFNLBEHNM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PKLOOMPONCC(string AGJEHAHDINL, OHENKGKJMCK ALDLCGKLBIB, bool EEOFGPMAIJC, [Optional] Action<LPLLDHMHBCF> AJGFNLBEHNM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PKLOOMPONCC(LIGMBBOOEMF KADFJBDLABD, OHENKGKJMCK ALDLCGKLBIB, bool EEOFGPMAIJC, [Optional] Action<LPLLDHMHBCF> AJGFNLBEHNM);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PKLOOMPONCC(LBGHHLNPEFE KADFJBDLABD, OHENKGKJMCK ALDLCGKLBIB, bool EEOFGPMAIJC, [Optional] Action<LPLLDHMHBCF> AJGFNLBEHNM);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PKLOOMPONCC(LIGMBBOOEMF KADFJBDLABD, MPOOILGCDLJ CJNLJKIIPKB, OHENKGKJMCK ALDLCGKLBIB, bool EEOFGPMAIJC, [Optional] string LCFFGMKJPDD, [Optional] Action<LPLLDHMHBCF> AJGFNLBEHNM, string KKFEOGMAMPI = "", [Optional] OAEILIIIPED LBJHHPLDPCI);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PKLKIPKIHCI(OHENKGKJMCK ALDLCGKLBIB, [Optional] Action<LPLLDHMHBCF> AJGFNLBEHNM);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	EILHPPDHBHH IGJLBCBGLHD(LJAOJKPPELK JMNDMCKDOGM, BOCGJDJJCBI ADPIDJIDOLP);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool AGGFKEOJJGF(EFPJGGLIGDF DCGAOBGLGBN, BOCGJDJJCBI ADPIDJIDOLP, Matchmaking.CMEHDDFFBED GBBLKDNPNEE = Matchmaking.CMEHDDFFBED.PublicMatchmaking);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface AHEENIKOBAF
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJIJGABEPGH(BNIDNMGAHLD KAMMJLALHID, List<KeepsakeInstanceDTO> KMEAHOFDGEF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum DFCEPCFEIKM
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum NDLBGGAMIKD
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Min = -1,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Minor,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Major,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Vital,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Max
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface GGJKMMLNPGJ
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable Play(NDLBGGAMIKD ELNDIFKOCAP, string HEPDANIJLED, float NCOPMNKMGPG, [Optional] Action IACLOIAOHJF, [Optional] object LOCODDOHFMC);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(NDLBGGAMIKD ELNDIFKOCAP, float CINOMOOGIBF, DFCEPCFEIKM NHMMMOFOMGG, string HEPDANIJLED, Color? LGPECLCIIPP, string GENPEMAHJHL, Color? OPKEDMNCODG, float NCOPMNKMGPG, [Optional] Action IACLOIAOHJF, [Optional] object LOCODDOHFMC);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PlayVirtualWatchNotification(OLHHKEMEKPM DKIECHCHJFL);
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
