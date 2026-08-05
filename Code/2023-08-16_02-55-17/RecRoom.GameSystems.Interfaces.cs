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
public enum DKLHKPANLDP
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
public enum EICDPOCGAHB
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
public enum IBFPILCAPAN
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Landscape,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Portrait
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NBJOJCNGECN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GHCPGAHIOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFHLLGMOPBH(object FDCOCHLAHJD, bool NCAOMFCEFCC);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JNMHLJGAIDP
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
public interface FICDFIEGAMN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T HLHBNDMLGBD<T>(string NABCGCEIEGG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface COAHBDJAGEL : LKOHEKFLMKE, NKJMIAAHDPN, OODHIAELMJN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	RegionInfo HDAMHGINFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	KMDIDBNJCHN KDBJKHMPAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KNEAFEIOKGC LJHIOPDIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DKLHKPANLDP IKEBJAOMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IBFPILCAPAN FOLAAGAEGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool HEKILOGEOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KAAOMGNLGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool BAMKEKDFGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CFAAHCKINNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool BBIKMAELDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LPFJKELEIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool JNJEJELIJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool PJMHJMHOGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OOMFLHAHLDK<DateTime?> GetPlatformProfileDateOfBirth();

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
	GIOBGNHJLID PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "18")]
	GIOBGNHJLID RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "20")]
	OOMFLHAHLDK<DNDLLOJKMLB> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "21")]
	GIOBGNHJLID RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	GIOBGNHJLID RequestContactsPermission();

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
	bool IsForcedIsolationByPlatformSettings(out string FEPMOMFCOOJ);

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
	OALCEKCJONB.NFKHIGGIPFB GetPlatformFriendPicture(string FBCODHMMCOB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GEGJPPMHKLD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool AHAGEAFIPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 DHLIPNBDDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 GGEHPCKDGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Camera OHKLKOGIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GameObject MJMGOHGGALN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KJNKAAIIHDM DJBIEDOKNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HFMPGNIBJKD ACENPCBLHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool NAMBMKKJKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float JNLGHBHKPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KJNKAAIIHDM
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float FHDKDDEMNCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum DNDLLOJKMLB
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EKEJLBPJNPN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BMHCFFJIMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HFMPGNIBJKD JCKNILAKGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MCCHMKHJLMF
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KFJAKMBHHIC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<MMCOABOKGIJ.HGDGMDMPCBB> FEKJILGGHBL;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KPBPGNHDNLA(DDKJBDFCNCK CBJEOBIIMPP);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACPKIJFNFHJ();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOKOJFNOJCO(MMCOABOKGIJ.HGDGMDMPCBB KELGMCFBOOF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KFHMJIMJKGN
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool NLJMDHJBODC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LPLMADMBKIA
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool PMLFKBIAMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool NCDAEDPBBMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool DILEBBOMEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KFFGINEBOHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HFDCGCJDMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> DJJHFEKKKPL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "8")]
	GIOBGNHJLID LFPFFIDLBCK();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OKCDAKNKDLH(long MMMEAMEIMKE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HOLJGMICHJK(int MIOMNEOFMJG, string OAOODDGMMLC, [Optional] KKDLDDJDEJL NAKCIEDHNKJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ACNEKNIPOFC(KKDLDDJDEJL DLJJINDIADH, bool KGPFBLKLMJI = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HPGHLBFCBJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NCIFGIGODHG DHOHAFONONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public long LPMBNNKANJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public long NBIJJEEELDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public string MBKKJEPEOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public string GBKDNOJONOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public MDACMIBEJCI? EKDHHHMPJHK;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct MDACMIBEJCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string NEELOLCLEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string[] EECPMGDGKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Dictionary<string, string> COGPNEPNGOH;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NCIFGIGODHG
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NOT_SET = 0,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	BOOT = 1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GAME_LOADING_NEXT_LEVEL = 2,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	PORTAL = 3,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	AFK = 4,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	VOTE_KICKED = 5,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CHEAT = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	ROOM_BANNED = 7,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	ACCEPTED_GAME_INVITE = 8,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	PARTY_ACTIVITY_SWITCH = 9,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	NOTIFICATION_NEW_ROOM_FROM_CREATOR = 10,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	NOTIFICATION_PLAYER_EVENT = 11,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	PEOPLE_MENU = 12,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	ACTIVITY_SELECT_MENU = 13,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	PERSISTENCE_ERROR = 14,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CIRCUIT_REINITIALIZE_ERROR = 15,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	BULLETIN_BOARD_FEATURED_ROOMS = 16,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	__DEPRECATED_CUSTOM_ROOMS_WATCH = 17,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[Obsolete]
	__DEPRECATED_CUSTOM_ROOMS_DOOR_V1_OR_RELOAD_ACTIVITY_OR_FOLLOW_PARTY_AFTER_DOOR = 18,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	QUIT = 19,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	EVENT_DIRECT_GOTO = 20,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	EVENT_NOTIFICATION = 21,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	REC_CENTER_SLIDESHOW = 22,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	COHORT_NUX = 23,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	QUICK_LAUNCH_MENU = 24,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ANNOUNCEMENT = 25,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	DEPRECATED_1 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	DELAYED_ROOM_WARNING = 27,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	ROOM_CODE = 28,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	ROOM_COMMENT_NOTIFICATION = 29,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CLUBHOUSE_DIRECT_GOTO = 30,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CREATORANNOUNCEMENT_ROOMPUBLISHED = 31,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	FORCE_THROUGH_ADMIN_SITE = 32,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	RECOMMENDED_ROOMS_WATCH = 33,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	INSTANCE_FORCE_CLOSED = 34,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	HOT_ROOMS_WATCH = 35,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	LIVE_ROOMS_WATCH = 36,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	SEARCH_ROOMS_WATCH = 37,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	FAVORITE_ROOMS_WATCH = 38,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	DOOR_SELECT_WATCH = 39,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	FEATURED_ROOMS_WATCH = 40,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	RECNET_ROOMS_WATCH = 41,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	NEW_ROOMS_WATCH = 42,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ROOM_COMMENT_TELEPORT = 43,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	CURATED_PLAYLISTS_WATCH = 44,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	PLAYER_EVENT_CODE = 45,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	CREATORANNOUNCEMENT_EVENTPUBLISHED = 46,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	ROOM_REJOIN_WATCH = 47,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	PLAYER_EVENT_DETAILS_WATCH = 48,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	RECENT_ROOMS_WATCH = 49,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	FRIEND_PRESENCE_ROOMS_WATCH = 50,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	MY_CLUBHOUSE_ROOMS_WATCH = 51,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	MY_SUBSCRIPTIONS_ROOMS_WATCH = 52,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	TOP_CREATORS_ROOMS_WATCH = 53,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	MORE_FROM_CONTEST_WINNERS_ROOMS_WATCH = 54,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[Obsolete]
	RISING_ROOMS_WATCH = 88,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	ROOM_LINK_BUTTON = 55,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	ROOM_SHOWCASE_POSTER = 56,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	THIS_ROOM_WATCH = 57,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	REC_CENTER_WATCH = 58,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	DORM_ROOM_WATCH = 59,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	ROOM_DETAILS_WATCH = 60,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CLONED_ROOM = 61,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	CREATE_ROOM_RESUME_WATCH = 62,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	BROWSE_ROOMS_WATCH = 63,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	MEETUP_CODE = 64,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	TEST_CASE_WATCH = 65,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	CHAT_MESSAGE = 66,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	MY_CREATED_ROOMS_WATCH = 67,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	PLAYER_CREATED_ROOMS_WATCH = 68,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	PLAYER_SHOWCASE_ROOMS_WATCH = 69,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CURRENT_CONTEST_ROOMS_WATCH = 70,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	TRENDING_TAGS_WATCH = 71,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	RRO_ROOMS_WATCH = 72,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	MAGIC_DOOR_DOOR = 73,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	MAGIC_DOOR_WATCH = 74,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	ROOM_NOTIFICATION_WATCH = 75,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	FOR_YOU_ROOMS_WATCH = 76,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	CLOUD_DATA_MENU = 77,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	SIMILAR_ROOMS_WATCH = 78,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	DEEP_LINK = 79,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	PLATFORM_NOTIFICATION_ACTION = 80,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	ROOM_JACKPOT = 81,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	RRUI_REMOTE_PLAYER_PROFILE = 82,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	ALL_KEEPSAKE_ROOMS = 83,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	STANDARD_KEEPSAKE_ROOMS = 84,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	PREMIUM_KEEPSAKE_ROOMS = 85,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	KEEPSAKE_ROOM_HIGHLIGHT = 86,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	SHOW_ME_ALL_ROOMS = 87,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	BROADCASTING_LISTENER_DISCONNECT = 100,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	CLUBHOUSE_WATCH_HOME = 101,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	ORIENTATION_DORM_DOOR = 102,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	MAKER_PEN_MAIN_MENU = 103,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	ROOM_CATEGORY_SELECT = 104,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	ACCEPTED_PARTY_INVITE = 105,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	XBOX_GAME_INVITE = 106,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	PLAYSTATION_GAME_INVITE = 107,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	PHOTO_DETAILS_WATCH = 108,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	IMAGE_FEED_ITEM = 109,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	CIRCUITS_V2_GO_TO_ROOM = 110,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	CLUBHOUSE_OPTIONS_WATCH = 111,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	SESSION_TAKEOVER = 112,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	DEBUG_CONSOLE = 113,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PROGRESSSION_EVENT_TUTORIAL = 114,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	MESSAGE_CARD_IMAGE_CLICKED = 115,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	ROOM_EARNINGS_MESSAGE_CARD_BUTTON_CLICKED = 116,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	CUSTOM_ROOM_DOOR = 118,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RELOAD_ACTIVITY = 119,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	FOLLOW_PARTY_AFTER_DOOR = 120,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	HOME_LOGIN = 121,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	HOME_ROOM = 122,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	PLAY_MENU_BANNER = 123,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	QUICK_ORIENTATION_DOOR = 124,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	CAROUSEL_ENDPOINT_WATCH = 125,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	HEARTBEAT_TIMEOUT = 126,
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
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PJAGLBAHCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool KFEHHPDMAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Matchmaking.HGGMBHKOIED CELHLBONAPN;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F81510", Offset = "0x6F80710", VA = "0x186F81510")]
	public PJAGLBAHCJB(Matchmaking.HGGMBHKOIED CGJBDJNHGPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MODLEJABKHB
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CCLPLAGPKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NAFEJNLGCGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool JNKHAIHKMBO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool NNHHIKNNMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xB688A0", Offset = "0xB67AA0", VA = "0x180B688A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xF4B4C0", Offset = "0xF4A6C0", VA = "0x180F4B4C0")]
	public void CFGMPOACLDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA3F7A0", Offset = "0xA3E9A0", VA = "0x180A3F7A0")]
	public NAFEJNLGCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KPCKIAFAACI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool BAEMOBKOLAF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<NAFEJNLGCGE> IJPNNKEOOOF;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNMIGCNGDDN();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HPGHLBFCBJJ BMGFKDNAGFI();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJJBKCJELCN(NCIFGIGODHG FGIADOJFAEB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PPJFILIIFPF(KKDLDDJDEJL DLJJINDIADH, NKFEOLDLFPD IKJABKAGDPF, string CGHNLHNDLKH, [Optional] Action<PJAGLBAHCJB> CLBLNLMEJHN);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GLGGIFDKMHN(string KOINPHALDNB, NCIFGIGODHG BADCCBDAOOM, bool DGJLGKDMODO = false);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OLAEJHEMGED(int MIOMNEOFMJG, Matchmaking.CNNJPIPGLHM GLFAGPKCHMN);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DDALFPJHLPI(KKDLDDJDEJL DLJJINDIADH, NKFEOLDLFPD IKJABKAGDPF, int MIOMNEOFMJG, NCIFGIGODHG BADCCBDAOOM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DLJBDGJAHJK(KKDLDDJDEJL DLJJINDIADH, NKFEOLDLFPD IKJABKAGDPF, EFCJDAPFPEP KAGIDHMKMPI, NCIFGIGODHG BADCCBDAOOM);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JGAEJHBCNCD(KKDLDDJDEJL DLJJINDIADH, ChatMessage PBMIBNGBINM, long HJFMNOJHPCA, [Optional] Action<PJAGLBAHCJB> CLBLNLMEJHN);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DEHJJJKCKOJ(NKFEOLDLFPD IKJABKAGDPF, NCIFGIGODHG BADCCBDAOOM, Matchmaking.CNNJPIPGLHM GLFAGPKCHMN, bool PMIKJJBLBBK, string KIPJMFHCJCI = "");

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NMJCADCJEOO(long HBFBDJIOFCF, HPGHLBFCBJJ PKEFENHEEBL, bool EMOIHGMGGMH, [Optional] Action<PJAGLBAHCJB> CLBLNLMEJHN);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NMJCADCJEOO(string MNLEELJBGMN, HPGHLBFCBJJ PKEFENHEEBL, bool EMOIHGMGGMH, [Optional] Action<PJAGLBAHCJB> CLBLNLMEJHN);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NMJCADCJEOO(KKDLDDJDEJL DLJJINDIADH, HPGHLBFCBJJ PKEFENHEEBL, bool EMOIHGMGGMH, [Optional] Action<PJAGLBAHCJB> CLBLNLMEJHN);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NMJCADCJEOO(DFCKHNPHLOG DLJJINDIADH, HPGHLBFCBJJ PKEFENHEEBL, bool EMOIHGMGGMH, [Optional] Action<PJAGLBAHCJB> CLBLNLMEJHN);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IMMDGOCNMNA(long HBFBDJIOFCF, long BGOPDGBJMDP, HPGHLBFCBJJ PKEFENHEEBL, bool EMOIHGMGGMH, List<int> NFCKMCKLEJI, [Optional] Action<PJAGLBAHCJB> CLBLNLMEJHN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NMJCADCJEOO(KKDLDDJDEJL DLJJINDIADH, NKFEOLDLFPD IKJABKAGDPF, HPGHLBFCBJJ PKEFENHEEBL, bool EMOIHGMGGMH, [Optional] string CGHNLHNDLKH, [Optional] Action<PJAGLBAHCJB> CLBLNLMEJHN, string KIPJMFHCJCI = "", [Optional] JFCNENLAIHN NALGJPOFHKM);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ICBFIHKFLIK(HPGHLBFCBJJ PKEFENHEEBL, [Optional] Action<PJAGLBAHCJB> CLBLNLMEJHN);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "20")]
	GIOBGNHJLID OFPFJHIFEPP(CFOGLKHCMMJ MCCLJOBKNJB, NCIFGIGODHG BADCCBDAOOM);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool JGJDEBPJJON(INAJDIGOLFE JBCLPKDIBCK, NCIFGIGODHG BADCCBDAOOM, Matchmaking.LFFJOHOKFDH CALNFPIKOEG = Matchmaking.LFFJOHOKFDH.PublicMatchmaking, bool KBOAJOOGGAH = true);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GFLMCFANCML
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCCHIBDEHBC(PPPFGNOFILG DLLFKNMJGGG, List<KeepsakeInstanceDTO> AMCPPNILEPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum HCEHLCFKAMC
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum BIHCKBMLPNN
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Min = -1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Minor,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Major,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Vital,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Max
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HGMNIHJCAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable Play(BIHCKBMLPNN PFNECEADDFA, string CLGIKEMIEFF, float KPNFPBFKGFM, [Optional] Action JHGMNDBGFFP, [Optional] object COEMOGPOKIC);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(BIHCKBMLPNN PFNECEADDFA, float FBFKDEJMDGN, HCEHLCFKAMC DLELJHHNFOJ, string CLGIKEMIEFF, Color? BOFHNBBPFIA, string HDPJEDCOJJO, Color? PNKAPFGCBEC, float KPNFPBFKGFM, [Optional] Action JHGMNDBGFFP, [Optional] object COEMOGPOKIC);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PlayVirtualWatchNotification(EFCJDAPFPEP JPOEHOENKPI);
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
