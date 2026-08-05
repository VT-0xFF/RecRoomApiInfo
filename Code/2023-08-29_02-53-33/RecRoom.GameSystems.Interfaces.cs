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
public enum EIDPBKBDDIE
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
public enum EILADPFBFLG
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
public enum DGJMEIDKAHA
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Landscape,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Portrait
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface GKAAIFBEBBN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HNPIMHPAHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGACBOEBMFM(object GAOLOMEJCOK, bool LGJJDNJOLDH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KLOMFNLGFBE
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
public interface LIOMIEAAEBC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T KEMICJFMGFL<T>(string KKIAKNLLHIO);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ACOPKPPLALA : DAKFFHCEMPM, ANAAPONOEAE, AGMFNKOLIGK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	RegionInfo ILCHIOMMMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DOBHHEPGGKA APOMDMMHDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JEKHLMOJNPM GDACANHDGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EIDPBKBDDIE DPPLOAFGPIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	DGJMEIDKAHA KHONECGHPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PIENPBNGMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool FOLINOGMEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool EEKKNAHEIGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GKNEPOPPJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool OGLBDAFCDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool JIODKNKPIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CFBKFBCHKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool ABCOBJFOGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MCFFIFIPNKE<DateTime?> GetPlatformProfileDateOfBirth();

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
	CCKGNGCPCCF PlatformLogin();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CCKGNGCPCCF RunVRDisplayModeConfirmation();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool IsDisplayModeSelectionRequired();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "20")]
	MCFFIFIPNKE<GOCBEIELGFP> RunDisplayModeSelection();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "21")]
	CCKGNGCPCCF RequestMicrophonePermissions();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	CCKGNGCPCCF RequestContactsPermission();

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
	bool IsForcedIsolationByPlatformSettings(out string CKIKFEIDNFM);

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
	MCAPCJPICKF.EBHHEPCDPCN GetPlatformFriendPicture(string NMCNCDONHPE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IAOMBNEEADI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool DHLBILKOGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 BCNDJFBDFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 GDMLEABHPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Camera CDKFLHIBGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	GameObject GJLAFBEJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NPBDHNHMJPI PDMDGIDJLMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	LNCHJMFHBFC AFDJOIEPAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OFKFMPGHMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float KAECHKBBPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NPBDHNHMJPI
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float OIMALBIFGGB
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
public enum GOCBEIELGFP
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	UNINITIALIZED,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	SCREEN
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KAKHBFDEIOP
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BPHCIDJJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	LNCHJMFHBFC OEHGJJOFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JFOCEJIILKK
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GMLPNMJIPGL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GCOBGGBLLPE.ALBKJOBCIHM> KDLOBJIHFPO;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DPACPKDKCOI(IAEPOBLKONA ILDBJBJJEJH);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJFBLKMEOIO();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PMANAOEMGNL(GCOBGGBLLPE.ALBKJOBCIHM GCCEIAPGIBM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CKLMAJDGHAE
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool NBHMIMOIEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OHGFADEOGNH
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MELCNENFOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GOFEFKHOKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KNBHGCCOEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LKDLODBIADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> KDGMAJCALIF;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CCKGNGCPCCF FFJFPMEAMBF();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NLIIDNLAJJP(long BNFMIDLPKDN);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IKHLICFENMO(int ELEHMFAPFEI, string IOJHGLPPGLD, [Optional] NJMLGDAHAMI ODFLKANLCOJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool KFBNKEKDEJK(NJMLGDAHAMI PPFKADKNPME, bool LLNIMKHJGDL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EMNEKFAMDBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public FKCGPIHHHEJ OLPAAHHJIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public long PGJNDGNMMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public long APDFPPOGNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public string NCLPMBLPLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public string NIKBBDLBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public DHHKNJPPIDI? HDEFCLIADIF;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DHHKNJPPIDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public string FGOEAGDBHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string[] MMJNLFOGLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public Dictionary<string, string> FAMKLILCGPE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FKCGPIHHHEJ
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
public struct CBHPODCAFGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool PCPKNPBDLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Matchmaking.LGIGHBMAMGG IMODLLMLAOD;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEDE0", Offset = "0x6FAE1E0", VA = "0x186FAEDE0")]
	public CBHPODCAFGG(Matchmaking.LGIGHBMAMGG MHCNPBLIMPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HGBIOLABNPO
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool HABKCECLKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ONMONJFIEMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool FLDHCKLBBMG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool HCKBMGFLPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xE29690", Offset = "0xE28A90", VA = "0x180E29690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xB944B0", Offset = "0xB938B0", VA = "0x180B944B0")]
	public void PKNAKDKANDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ADE0", Offset = "0xA6A1E0", VA = "0x180A6ADE0")]
	public ONMONJFIEMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EHDNAKJCIAN
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool NJKDNJCFGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<ONMONJFIEMD> JPOMMADCCIH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FONCJFANJIO();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMNEKFAMDBP IMAAOOAGHPA();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNDPBNKBLBD(FKCGPIHHHEJ CANIEFMHGCA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IDJHBPKOKOJ(NJMLGDAHAMI PPFKADKNPME, DAFKNICGNLA CBBCEFKLPNI, string DLPCLBICKLE, [Optional] Action<CBHPODCAFGG> OICMMFJFGJH);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MFICLKJGEBO(string PJGCMNENEJH, FKCGPIHHHEJ HMHLEPKJEMM, bool ONOCKAMDELD = false);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LPIIIMOHHDC(int ELEHMFAPFEI, Matchmaking.CGPCHJDDOEG JJIBNFKKOBG);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NLDBLAOFMHB(NJMLGDAHAMI PPFKADKNPME, DAFKNICGNLA CBBCEFKLPNI, int ELEHMFAPFEI, FKCGPIHHHEJ HMHLEPKJEMM);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BCLELHJJNOP(NJMLGDAHAMI PPFKADKNPME, DAFKNICGNLA CBBCEFKLPNI, ADBDLBPJDOM HGIJOPMNMFC, FKCGPIHHHEJ HMHLEPKJEMM);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EMPDDCJAFJJ(NJMLGDAHAMI PPFKADKNPME, ChatMessage OFDCFJHMILB, long DGCBAIIJBKK, [Optional] Action<CBHPODCAFGG> OICMMFJFGJH);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CFMEPJJOFCK(DAFKNICGNLA CBBCEFKLPNI, FKCGPIHHHEJ HMHLEPKJEMM, Matchmaking.CGPCHJDDOEG JJIBNFKKOBG, bool PEAKBDNECEB, string PPGFPPIJHEN = "");

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void APPCPLECNNH(long KLOAGIPENLJ, EMNEKFAMDBP COFNKMFPDJB, bool IIEBLKFEGLO, [Optional] Action<CBHPODCAFGG> OICMMFJFGJH);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void APPCPLECNNH(string LHLOHCCHLEP, EMNEKFAMDBP COFNKMFPDJB, bool IIEBLKFEGLO, [Optional] Action<CBHPODCAFGG> OICMMFJFGJH);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void APPCPLECNNH(NJMLGDAHAMI PPFKADKNPME, EMNEKFAMDBP COFNKMFPDJB, bool IIEBLKFEGLO, [Optional] Action<CBHPODCAFGG> OICMMFJFGJH);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void APPCPLECNNH(IPJMLDOLAND PPFKADKNPME, EMNEKFAMDBP COFNKMFPDJB, bool IIEBLKFEGLO, [Optional] Action<CBHPODCAFGG> OICMMFJFGJH);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BLMJEGIFPBC(long KLOAGIPENLJ, long AENJJHCEEHK, EMNEKFAMDBP COFNKMFPDJB, bool IIEBLKFEGLO, List<int> ENFLGDKEHAA, [Optional] Action<CBHPODCAFGG> OICMMFJFGJH);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void APPCPLECNNH(NJMLGDAHAMI PPFKADKNPME, DAFKNICGNLA CBBCEFKLPNI, EMNEKFAMDBP COFNKMFPDJB, bool IIEBLKFEGLO, [Optional] string DLPCLBICKLE, [Optional] Action<CBHPODCAFGG> OICMMFJFGJH, string PPGFPPIJHEN = "", [Optional] DOOAKLHOIPB BPFIEJBJDMP);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EKMNIFLGDPC(EMNEKFAMDBP COFNKMFPDJB, [Optional] Action<CBHPODCAFGG> OICMMFJFGJH);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "20")]
	CCKGNGCPCCF OABCMGIAIPF(AOHDBAGEKHH JOJCCEFKKBC, FKCGPIHHHEJ HMHLEPKJEMM);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool BBBJIJMCKOC(LGJMOMGMKCC MCOPFKEDMBK, FKCGPIHHHEJ HMHLEPKJEMM, Matchmaking.JPPAJABONOA BOGGDOKOBDO = Matchmaking.JPPAJABONOA.PublicMatchmaking, bool ONBAKEOKGLN = true);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MLCGBCNMPJC
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJBAOKMLMFI(MKMOLMPLENB BDMJOMIFMAC, List<KeepsakeInstanceDTO> CFGBJAIIABB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum MIDFFMDDFJD
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum BFAPILNLKIL
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
public interface NBLAFBENHED
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IDisposable Play(BFAPILNLKIL LNOGFPLHDJM, string JPGHKCNIBCC, float IDCDACBEHOE, [Optional] Action GBCKPIBLKJM, [Optional] object EJMCMDHOHIN);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable Play(BFAPILNLKIL LNOGFPLHDJM, float MIFFHLOHNCP, MIDFFMDDFJD MPCJJJFPHGN, string JPGHKCNIBCC, Color? OLCJDDOKCCJ, string JHJPOMCFEMG, Color? EMJCGGCFCAB, float IDCDACBEHOE, [Optional] Action GBCKPIBLKJM, [Optional] object EJMCMDHOHIN);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PlayVirtualWatchNotification(ADBDLBPJDOM HGJHDPGFLKO);
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
