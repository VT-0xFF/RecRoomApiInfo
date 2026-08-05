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
public enum FIPEGJCKBJH
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
public enum CKFLGJGBKKJ
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
public enum NKDNAEDNLMA
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Landscape,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Portrait
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FCOAHODBHIN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CPLJDHLNHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OKMELHMCMHI(object GKNJCIECGND, bool HAEOPMADCBO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DAGNHJOICPK
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
public interface NLGOPFNJEBB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T KMLLBGHALDK<T>(string KKLNCEHOHED);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JDPKGHJBGNG : CPIOAFLOODD, HLLFEFDKOFG, JJMOKANPECG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	RegionInfo BFHGNMBICDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GCAGPOGHIOK DLBGFCELLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DCJELNHNEGF GBODOKPKOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FIPEGJCKBJH EPNOPOOPHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NKDNAEDNLMA HGGOGDBAOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool LPMKNCGPAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GIBNCFAABLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BFNPNABJCMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool LCKEOONHOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool KFNPODFJNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool MIPAOFOLIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MFDAIPDMDLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool CPOEMCEKKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AHPDIJDJLKD<DateTime?> GetPlatformProfileDateOfBirth();

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
	NONMCJIBNII PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "18")]
	NONMCJIBNII RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "20")]
	AHPDIJDJLKD<KDCLHLEGNJH> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "21")]
	NONMCJIBNII RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NONMCJIBNII RequestContactsPermission();

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
	bool IsForcedIsolationByPlatformSettings(out string DCGAHPMHLKF);

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
	NPOKKIMLPEB.LFPPDCKKMBO GetPlatformFriendPicture(string DBDFCOFCIBK);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JLNCNJEHMHB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool FNAFNGPDAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 LGCOOPMBGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 IHKMPOEAMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Camera MACBJIGAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GameObject HPNAMLCJADB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	EJJIINICHFG BAKNDIBIAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EJJIINICHFG
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float KNGKIGMBPOD
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
public enum KDCLHLEGNJH
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AAOOKAOJHHB
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MPHCNOBIADL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	PGDADKMBOJE BMDIBBCJECO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BMFGEEFCKKA
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action COAKLLLNBJA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<PHEJJABPEDC.JJNDAGBGNOD> CPNJHNNCFFI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CIBCDAOLCCO(OOMDOBMPJDB FPJDFIHIKPB);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KALELJMANIE();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOHHFGAKANI(PHEJJABPEDC.JJNDAGBGNOD EBMAJAPNFFK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JPDJLNKDNGK
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MIIJLDHKBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DNJLKMHFCMK
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AIJJGCIHKNI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KEDHAIHKLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PDHBIJBGJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OPACMMCLJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool HEOOJADPHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> FFACMGFFMDM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NONMCJIBNII EALLCEPJAOE();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NGIGONMDEIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public LPIJMDOELEB OICOOAKFDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public long GCEJMLINLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public long LCNJCLGOFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public string JCIHNJFFIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public POOBKFDPEJA? NFJJFBKNDCN;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct POOBKFDPEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public string DBHDBMCEGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string[] MJFCABPAEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Dictionary<string, string> KCJIBJBKCGC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum LPIJMDOELEB
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
	[Obsolete]
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
	QUICK_ORIENTATION_DOOR = 124,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	CAROUSEL_ENDPOINT_WATCH = 125,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	REC_ROOM_CREATOR_ACADEMY_WATCH = 200,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RRCA_LEARN_TO_CREATE_WATCH = 201,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	RRCA_CREATION_TUTORIALS_WATCH = 202,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	RRCA_BUILDING_TUTORIALS_WATCH = 203,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	RRCA_CIRCUITS_TUTORIALS_WATCH = 204
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LFOOKLEDFLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool NEBPKKBKPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Matchmaking.NOIOLLJBCOD LDFGKAIIOLO;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1942C80", Offset = "0x1941A80", VA = "0x181942C80")]
	public LFOOKLEDFLI(Matchmaking.NOIOLLJBCOD KNJLFHKJACE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DDJBPPIAMAK
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MIGIONPGLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum IMICDEDFHMA
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	LeaveParty,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	InviteParty,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	PartyAutoFollow,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	EveryoneAutoFollow
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NLDFJIDFDKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool CMAHMMBMMEB;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NJIFLBLONLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8041D0", Offset = "0x802FD0", VA = "0x1808041D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1942C90", Offset = "0x1941A90", VA = "0x181942C90")]
	public void KOBLBAJGIHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x18BA9D0", Offset = "0x18B97D0", VA = "0x1818BA9D0")]
	public NLDFJIDFDKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CPJGJKIJLFF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool KOPIAJNOCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<NLDFJIDFDKA> LIGBPABDHKA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEOLJAGGING();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGIGONMDEIF OIGDDJDIFPE();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFAKHGPGDOK(LPIJMDOELEB KGDHPOJLMNA);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GIELFLCMAOJ(MKJEIIPNOCA LEIPIECFPDJ, CFIBOHOJNNP ECHMPPEOAFK, string AEKNFONEILD, [Optional] Action<LFOOKLEDFLI> MOFDIHMCEHH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LEHBEEKEFAL(string GGOKNKBDAPM, LPIJMDOELEB HDFGONCNJAH, bool PEHAGJLJHHF = false);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KKIEGDALAEL(int JMIAPMFLFBD, IMICDEDFHMA PCCJHOKKHCE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AKGHGFPKEMH(MKJEIIPNOCA LEIPIECFPDJ, int JMIAPMFLFBD, LPIJMDOELEB HDFGONCNJAH);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CIJAGPAMIKC(MKJEIIPNOCA LEIPIECFPDJ, HHBMHNHHBGA NADDFIPEPHG, LPIJMDOELEB HDFGONCNJAH);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ONKHEJCLCND(MKJEIIPNOCA LEIPIECFPDJ, ChatMessage MBHDLDJGJPL, long ABGBHABJBPE, [Optional] Action<LFOOKLEDFLI> MOFDIHMCEHH);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LMOOKMMNOGB(CFIBOHOJNNP ECHMPPEOAFK, LPIJMDOELEB HDFGONCNJAH, IMICDEDFHMA PCCJHOKKHCE, bool BBDJJEMALLI, string JODFKBMFLGP = "");

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DHCBJLIJKOI(long OFOPNAOLFGC, NGIGONMDEIF JABNDAIKPIM, bool MNLBFIKPDPC, [Optional] Action<LFOOKLEDFLI> MOFDIHMCEHH);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DHCBJLIJKOI(string HDKNPGFMJBP, NGIGONMDEIF JABNDAIKPIM, bool MNLBFIKPDPC, [Optional] Action<LFOOKLEDFLI> MOFDIHMCEHH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DHCBJLIJKOI(MKJEIIPNOCA LEIPIECFPDJ, NGIGONMDEIF JABNDAIKPIM, bool MNLBFIKPDPC, [Optional] Action<LFOOKLEDFLI> MOFDIHMCEHH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DHCBJLIJKOI(PKOFOJDEKJK LEIPIECFPDJ, NGIGONMDEIF JABNDAIKPIM, bool MNLBFIKPDPC, [Optional] Action<LFOOKLEDFLI> MOFDIHMCEHH);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DHCBJLIJKOI(MKJEIIPNOCA LEIPIECFPDJ, CFIBOHOJNNP ECHMPPEOAFK, NGIGONMDEIF JABNDAIKPIM, bool MNLBFIKPDPC, [Optional] string AEKNFONEILD, [Optional] Action<LFOOKLEDFLI> MOFDIHMCEHH, string JODFKBMFLGP = "", [Optional] CBFHJEDLELG KMFPCPJOIHJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PPBGANFOELB(NGIGONMDEIF JABNDAIKPIM, [Optional] Action<LFOOKLEDFLI> MOFDIHMCEHH);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "19")]
	NONMCJIBNII JNMBFCJOCON(AAKPOCGKLMG NFEMNOIGKAP, LPIJMDOELEB HDFGONCNJAH);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool AGIKIHCFNHJ(CDFMABNLGEJ OIEGDHOJGCM, LPIJMDOELEB HDFGONCNJAH, Matchmaking.ICMMICNFJFD DGKNMKICFCB = Matchmaking.ICMMICNFJFD.PublicMatchmaking);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EBPFOOOKOAG
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AONJOIGBJIO(FOHHNNEFOIN OKIIFNIJCAO, List<KeepsakeInstanceDTO> KAKNMLFDDDK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum CKNLLOIDIJD
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum MKBJNLAFGJA
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Min = -1,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Minor,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Major,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Vital,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Max
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IOLABGNOCIN
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable Play(MKBJNLAFGJA PFBCGCECKGL, string EICNGODLNGA, float OJEMEIILDPA, [Optional] Action IIPKIDOCHMK, [Optional] object PENEAGIHAFN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(MKBJNLAFGJA PFBCGCECKGL, float IGGLOLPFBCL, CKNLLOIDIJD ANJLCKKPNNN, string EICNGODLNGA, Color? GDBABKJHHIO, string HONFHFLECCD, Color? FNDGHMFKMDO, float OJEMEIILDPA, [Optional] Action IIPKIDOCHMK, [Optional] object PENEAGIHAFN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PlayVirtualWatchNotification(HHBMHNHHBGA CAJMIGKHKEC);
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
