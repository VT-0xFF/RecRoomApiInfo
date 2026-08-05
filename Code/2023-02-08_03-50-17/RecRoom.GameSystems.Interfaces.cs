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
public enum JKPLIHAADII
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
public enum PDJPEDJGEHM
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
public interface EMDCLJCIBAN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Vector3 KCMKLHMMNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Vector3 NIHPAFOMEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Camera GHLNKNEKPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GameObject JFBADFOCDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CBLNHGHOJOP
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Room,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Club,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Invention,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	PlayerEvents
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum NIEFEOHAAHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CHANBBPGBIO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NKBELGPAFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OBHBNJGGBHP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T BNKHMNBGFPO<T>(string DPJGMDFEIDL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PBNODDMDOLF : FNDGNNDNODP, MFPHELIEHEG, FJANBNIGOAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	RegionInfo NEMPBNCMIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CLPLALGHHPC NMGMLJFFGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LFLDALAHGKK NCNNNACPHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JKPLIHAADII BFPDFABHAFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LLJHCFNIPNL EIIILIAEILA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MIFDEAGPFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool AKENNNAAKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool AMJBJPINBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool NMDNGDMMLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool GHIDEPDHNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool JEOCCKGENKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool BFPLPDGEFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool ABMGDAHGNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	global::KOILDJEEFJD<DateTime?> GetPlatformProfileDateOfBirth();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool IsEULARequired();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "15")]
	string GetEULA();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AcceptEULA();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FFFHIGBANBM PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "18")]
	FFFHIGBANBM RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	global::KOILDJEEFJD<NIEFEOHAAHJ> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	FFFHIGBANBM RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	FFFHIGBANBM RequestContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool HasContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool CanAskForContactsPermission();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool SupportsLinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LinkToDownloadUpdate();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool IsCrossPlatformWarningRequired();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AcceptCrossPlatformWarning();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool IsForcedIsolationByPlatformSettings(out string OAOAIFKDODE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool IsSiloedMatchmakingEnabled();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool RequestCrossPlatformMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool RequestSiloedMatchmaking();

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "33")]
	LFFDBFMLEEE.JFENPDGCNJE GetPlatformFriendPicture(string OIDGDHPNKGD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LAEOIMNFGIL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JKPMAFBIBCL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<ENJOFLINMPF.BKDFCDOBHPM> FOOMDGEEGOE;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EINAHOGDCGI(IGHAMEGJBOI DDCGMDEAFNC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAGDOKFHKIA();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOHDMPBIJOG(ENJOFLINMPF.BKDFCDOBHPM GGKEBFHDHIH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MIKJGDAPAMN
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool POHEONLELLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LCIJCOKLADC
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable Play(HDOALOEIFAO LDNHHELNBEC, string FPKGDGKMMEH, float OPOALHMBGOP, [Optional] Action JAKHBAJPHJL, [Optional] object PJLCFBGGKAC);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(HDOALOEIFAO LDNHHELNBEC, float LDFBDCKCIMG, OOBACOGLGNM LHFLBDDPANH, string FPKGDGKMMEH, Color? LKFKPDIKGBL, string GNANPJFPGDE, Color? KHANKMMMNID, float OPOALHMBGOP, [Optional] Action JAKHBAJPHJL, [Optional] object PJLCFBGGKAC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum OOBACOGLGNM
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HDOALOEIFAO
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Min = -1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Minor,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Major,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Vital,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Max
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LGLHMDHHKLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool GPGONAPLKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DLGPLOGNIAN
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HNLOFHLANFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool KOKPMALPNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NBPFEPIMLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool FCADBGDMDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JPNAEKADDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> PIIFFHEOLNK;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FFFHIGBANBM CLHHHLAKKKO();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	[Obsolete]
	void LKAKNOMNLPO(string LOPFJNPLLEH, string OFIAHNNCEDP, KLCHHKODBNO CIDOLAKJMED, bool PDKIOKAICJC, [Optional] Action<KBNFAOOFEHC> KFIGPBAEPJB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KLCHHKODBNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public CGFEBANIJGN GJDEGOPBGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public long LACKAMMAMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public long GCCOHELBFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public string CNCNIPLAPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public INKONJMGDFK? JEGBHIECCOD;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct INKONJMGDFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public string EJPFDNDBHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public string[] LGPLPHHGCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Dictionary<string, string> NECGMJEIAKL;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum CGFEBANIJGN
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	NOT_SET = 0,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	BOOT = 1,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	GAME_LOADING_NEXT_LEVEL = 2,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	PORTAL = 3,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AFK = 4,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	VOTE_KICKED = 5,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CHEAT = 6,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	ROOM_BANNED = 7,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	ACCEPTED_GAME_INVITE = 8,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	PARTY_ACTIVITY_SWITCH = 9,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	NOTIFICATION_NEW_ROOM_FROM_CREATOR = 10,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	NOTIFICATION_PLAYER_EVENT = 11,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	PEOPLE_MENU = 12,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	ACTIVITY_SELECT_MENU = 13,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	PERSISTENCE_ERROR = 14,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CIRCUIT_REINITIALIZE_ERROR = 15,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	BULLETIN_BOARD_FEATURED_ROOMS = 16,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	__DEPRECATED_CUSTOM_ROOMS_WATCH = 17,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[Obsolete]
	__DEPRECATED_CUSTOM_ROOMS_DOOR_V1_OR_RELOAD_ACTIVITY_OR_FOLLOW_PARTY_AFTER_DOOR = 18,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	QUIT = 19,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	EVENT_DIRECT_GOTO = 20,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	EVENT_NOTIFICATION = 21,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	REC_CENTER_SLIDESHOW = 22,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	COHORT_NUX = 23,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	QUICK_LAUNCH_MENU = 24,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	ANNOUNCEMENT = 25,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	DEPRECATED_1 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	DELAYED_ROOM_WARNING = 27,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	ROOM_CODE = 28,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	ROOM_COMMENT_NOTIFICATION = 29,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CLUBHOUSE_DIRECT_GOTO = 30,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CREATORANNOUNCEMENT_ROOMPUBLISHED = 31,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	FORCE_THROUGH_ADMIN_SITE = 32,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	RECOMMENDED_ROOMS_WATCH = 33,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	INSTANCE_FORCE_CLOSED = 34,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	HOT_ROOMS_WATCH = 35,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	LIVE_ROOMS_WATCH = 36,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	SEARCH_ROOMS_WATCH = 37,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	FAVORITE_ROOMS_WATCH = 38,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	DOOR_SELECT_WATCH = 39,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	FEATURED_ROOMS_WATCH = 40,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	RECNET_ROOMS_WATCH = 41,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	NEW_ROOMS_WATCH = 42,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ROOM_COMMENT_TELEPORT = 43,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	CURATED_PLAYLISTS_WATCH = 44,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PLAYER_EVENT_CODE = 45,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CREATORANNOUNCEMENT_EVENTPUBLISHED = 46,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	ROOM_REJOIN_WATCH = 47,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PLAYER_EVENT_DETAILS_WATCH = 48,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	RECENT_ROOMS_WATCH = 49,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	FRIEND_PRESENCE_ROOMS_WATCH = 50,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	MY_CLUBHOUSE_ROOMS_WATCH = 51,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	MY_SUBSCRIPTIONS_ROOMS_WATCH = 52,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	TOP_CREATORS_ROOMS_WATCH = 53,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	MORE_FROM_CONTEST_WINNERS_ROOMS_WATCH = 54,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	ROOM_LINK_BUTTON = 55,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	ROOM_SHOWCASE_POSTER = 56,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	THIS_ROOM_WATCH = 57,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	REC_CENTER_WATCH = 58,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	DORM_ROOM_WATCH = 59,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	ROOM_DETAILS_WATCH = 60,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	CLONED_ROOM = 61,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	CREATE_ROOM_RESUME_WATCH = 62,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	BROWSE_ROOMS_WATCH = 63,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	MEETUP_CODE = 64,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	TEST_CASE_WATCH = 65,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	CHAT_MESSAGE = 66,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	MY_CREATED_ROOMS_WATCH = 67,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	PLAYER_CREATED_ROOMS_WATCH = 68,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	PLAYER_SHOWCASE_ROOMS_WATCH = 69,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	CURRENT_CONTEST_ROOMS_WATCH = 70,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	TRENDING_TAGS_WATCH = 71,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	RRO_ROOMS_WATCH = 72,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	MAGIC_DOOR_DOOR = 73,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	MAGIC_DOOR_WATCH = 74,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	ROOM_NOTIFICATION_WATCH = 75,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	FOR_YOU_ROOMS_WATCH = 76,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	CLOUD_DATA_MENU = 77,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	SIMILAR_ROOMS_WATCH = 78,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DEEP_LINK = 79,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	PLATFORM_NOTIFICATION_ACTION = 80,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	ROOM_JACKPOT = 81,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	RRUI_REMOTE_PLAYER_PROFILE = 82,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	ALL_KEEPSAKE_ROOMS = 83,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	STANDARD_KEEPSAKE_ROOMS = 84,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	PREMIUM_KEEPSAKE_ROOMS = 85,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	KEEPSAKE_ROOM_HIGHLIGHT = 86,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	SHOW_ME_ALL_ROOMS = 87,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	BROADCASTING_LISTENER_DISCONNECT = 100,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CLUBHOUSE_WATCH_HOME = 101,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	ORIENTATION_DORM_DOOR = 102,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	MAKER_PEN_MAIN_MENU = 103,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	ROOM_CATEGORY_SELECT = 104,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ACCEPTED_PARTY_INVITE = 105,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	XBOX_GAME_INVITE = 106,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	PLAYSTATION_GAME_INVITE = 107,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	PHOTO_DETAILS_WATCH = 108,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	IMAGE_FEED_ITEM = 109,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	CIRCUITS_V2_GO_TO_ROOM = 110,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	CLUBHOUSE_OPTIONS_WATCH = 111,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	SESSION_TAKEOVER = 112,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DEBUG_CONSOLE = 113,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	PROGRESSSION_EVENT_TUTORIAL = 114,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	MESSAGE_CARD_IMAGE_CLICKED = 115,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	ROOM_EARNINGS_MESSAGE_CARD_BUTTON_CLICKED = 116,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	RR_URL = 117,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	CUSTOM_ROOM_DOOR = 118,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	RELOAD_ACTIVITY = 119,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	FOLLOW_PARTY_AFTER_DOOR = 120,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	REC_ROOM_CREATOR_ACADEMY_WATCH = 200,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	RRCA_LEARN_TO_CREATE_WATCH = 201,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	RRCA_CREATION_TUTORIALS_WATCH = 202,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RRCA_BUILDING_TUTORIALS_WATCH = 203,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	RRCA_CIRCUITS_TUTORIALS_WATCH = 204
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KBNFAOOFEHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool KBOIPABGMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Matchmaking.PGKAKNFOIGI BEFKJDBCIJD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x21E5040", Offset = "0x21E3E40", VA = "0x1821E5040")]
	public KBNFAOOFEHC(Matchmaking.PGKAKNFOIGI AJACKHAGDEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LBIJDBHHDDF
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKPNOAINEMB(DAOKIJHMDIJ LGADPIJNIHE, List<KeepsakeInstanceDTO> GECJNNEDJHM);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum LLJHCFNIPNL
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Landscape,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Portrait
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
