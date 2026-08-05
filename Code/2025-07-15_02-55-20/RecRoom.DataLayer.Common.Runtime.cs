using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NAEHKMDNNHC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Banned = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Host = 10,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Moderator = 20,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Contributor = 25,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	CoOwner = 30,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TemporaryCoOwner = 31,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Creator = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OODDHFJJEKH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x807D580", Offset = "0x807C180", VA = "0x18807D580")]
	public static string DCJLCCFNKGD(this NAEHKMDNNHC OMOPAJCGHAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum FMEODGEFBMO : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Head = 0,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Torso = 1,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	LeftHand = 2,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	RightHand = 3,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Mouth = 4,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Legs = 5,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	LeftFoot = 6,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RightFoot = 7,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	FullBody = 8,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Nose = 9,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Face = 10,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Roomie_Head = 20
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Flags]
public enum LIOBKCDAIND
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Nose = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Face = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Roomie_Head = 0x100000
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum RoomKeyResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Success = 0,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		InvalidParameters = 1,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		DoesNotExist = 2,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		NameTooShort = 3,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		NameTooLong = 4,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		DuplicateName = 5,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		InappropriateName = 6,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		DescriptionTooShort = 7,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		DescriptionTooLong = 8,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		InappropriateDescription = 9,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		PriceIsInvalid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		PermissionDenied = 12,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		PlayerHasRoomUnderModerationReview = 13,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		JuniorStatusFail = 14,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		PlayerIsNotCoOwner = 15,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		RoomKeyLimitReached = 16,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		PlayerAlreadyOwns = 17,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		RoomUnderModerationReview = 18,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		PurchaseFailed = 19,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		RoomDoesNotExist = 20,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		PaidKeyPurchasingDisabled = 21,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		CreateOrModifyKeysDisabled = 22,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		RoomKeyUnderModerationReview = 23,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		PlayerRestrictedFromP2PSelling = 24,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PlayerNotRecRoomPlusMember = 25,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		InvalidRoomCurrency = 26,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		RoomCurrenciesAreDisabled = 27,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		ImageDoesNotExist = 28,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		NotEnoughCurrency = 29,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		PlayerRestrictedFromP2PBuying = 30
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Flags]
public enum EGDJJHHKOAN
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Top = 2,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Bottom = 4,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Left = 8,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Right = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Center = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	LeftAndRight = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	TopAndBottom = 6,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AllSides = 0x1E
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
public enum CGOJMPEHCAK
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	PingPong = 1,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	StopAtStart = 2,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	StopAtEnd = 4,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	AllowHolding = 8
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LAPPBOKJFEA
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Team1 = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Team2 = 1,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Team3 = 2,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Team4 = 3,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Team5 = 4,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Team6 = 5,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Team7 = 6,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Team8 = 7,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Team9 = 8,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Team10 = 9,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Team11 = 10,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Team12 = 11,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Team13 = 12,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Team14 = 13,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Team15 = 14,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Team16 = 15,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Team17 = 16,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Team18 = 17,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Team19 = 18,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Team20 = 19,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Team21 = 20,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Team22 = 21,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Team23 = 22,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Team24 = 23,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Team25 = 24,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Team26 = 25,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Team27 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Team28 = 27,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Team29 = 28,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Team30 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Team31 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Team32 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Team33 = 32,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Team34 = 33,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Team35 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Team36 = 35,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Team37 = 36,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Team38 = 37,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Team39 = 38,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Team40 = 39,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	ANY = -1,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	MAX_VALUE = 39
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EIPGLKDBBOK
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Cube,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Sphere
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum OKBLHMOFDJD
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Pivot,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Handle
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum HFDBLEOKNJB
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum GNKFNDCHLOH
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Unassigned = 0,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	LimitedOneUseOnly = 10,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	DisallowKeyLock = 15,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	UseOnly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	EditAndSave = 40,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Publish = 60,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Charge = 80,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Unlimited = 100
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GCBNCPFBMII
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Restrict,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Allow
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum GIGBGNAJIDL
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Any,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	MasterOrAuth
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PBDNDKNMPAG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x807D690", Offset = "0x807C290", VA = "0x18807D690")]
	public static bool CGGLDOOGOBP(this GIGBGNAJIDL CEBNHJNKAJN, bool COLMHMKIPOB, bool JILDDJCGLLA)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum PhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Physical = 4
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum PGKGFNEKPMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Dominant,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Offhand,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	DualWield
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NGEMBLHLIKG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x18541D0", Offset = "0x1852DD0", VA = "0x1818541D0")]
	public static bool JPNIBMONANG(this PGKGFNEKPMJ FHLFNIAFPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1918D70", Offset = "0x1917970", VA = "0x181918D70")]
	public static bool PICMBOBNFIB(this PGKGFNEKPMJ FHLFNIAFPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1435540", Offset = "0x1434140", VA = "0x181435540")]
	public static bool FBBOGIHIHCN(this PGKGFNEKPMJ FHLFNIAFPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x807D480", Offset = "0x807C080", VA = "0x18807D480")]
	public static string KKLPNHKLBBP(this PGKGFNEKPMJ FHLFNIAFPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x807D450", Offset = "0x807C050", VA = "0x18807D450")]
	public static string APDBFHEBJKO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum KEMCMOHNHFH
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum OPAGMKMMJLA
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Color,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	ColorAndMaterial
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum LGMDOCAFNFL
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	CAN_ADD_ROOM_BANS = 1018,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	CAN_MODIFY_ROOM_WIDE_ASSETS = 1019
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum MMLMAHNDNOJ : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Head
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum OKDGPFAAALL
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Key,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	CircuitEventKey
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum CHOAEADBPCN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Legacy = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Rooms2 = 2
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum JHOLAGKEPAB
{
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	DuringGame,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	PrePostGame,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Manual
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum DPFNKMGMIEH
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	LinearOut,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Solid,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	EaseOut
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum DHKDMMAKPBD
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Hard,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Soft,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Sword,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Neon,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Laser,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Rainbow,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	RainbowStriped
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum DMDHPBKLGNK
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Linear,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Constant,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Exponential,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Sinewave,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Reverse,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Wiggle
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum CFBMCAPEOOJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EHAGHDACMAE
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Tool
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum MMGGFMEPBPM
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Private,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Unlisted
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum AFJPHDDPDEH
{
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum MOLJNEKAMFB
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum APAGBLEFGGN
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RoomLowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Room = 1,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RoomHighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	LoudspeakerHighPitch = 22,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	CallLowPitch = 30,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	CallNone = 31,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	CallHighPitch = 32
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum EMPPHIOPPNL
{
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	CoachVO,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	VoiceCall,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	RoomieAI,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	RemoteRoomieAI,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	GameAI
}
namespace RecRoom.DataLayer.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum VoiceOption
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Coach,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Alloy,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Ash,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Ballad,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Coral,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Echo,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Sage,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Shimmer,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Verse
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FCBJOEGEAKE : IEquatable<FCBJOEGEAKE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public readonly EMPPHIOPPNL CKLFHJABLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public readonly string LGDAJEDHIKO;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x807D3B0", Offset = "0x807BFB0", VA = "0x18807D3B0")]
	public FCBJOEGEAKE(EMPPHIOPPNL DPNGEAJJEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x807D340", Offset = "0x807BF40", VA = "0x18807D340")]
	public FCBJOEGEAKE(EMPPHIOPPNL DPNGEAJJEHG, string MCIANHIFPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x807D2B0", Offset = "0x807BEB0", VA = "0x18807D2B0")]
	public bool ILFCIJIKJBO(EMPPHIOPPNL AAPMMBHJDHN, string OEFEAOCIDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x807D180", Offset = "0x807BD80", VA = "0x18807D180", Slot = "4")]
	public bool Equals(FCBJOEGEAKE IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x807D1A0", Offset = "0x807BDA0", VA = "0x18807D1A0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x807D240", Offset = "0x807BE40", VA = "0x18807D240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum IEABKGJKKMM
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Linear
}
namespace Cpp2IlInjected
{
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
}
