using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BAMAEEMHEMC : byte
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
public static class DKKFKANHPME
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7F2AEC0", Offset = "0x7F296C0", VA = "0x187F2AEC0")]
	public static string BDFCLAOBJOM(this BAMAEEMHEMC BLIMNEEJIFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AMKHIMALNFB : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Flags]
public enum KBDIBAEPIGO
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Nose = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Face = 0x400
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum RoomKeyResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Success = 0,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		InvalidParameters = 1,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		DoesNotExist = 2,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		NameTooShort = 3,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		NameTooLong = 4,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		DuplicateName = 5,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		InappropriateName = 6,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		DescriptionTooShort = 7,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		DescriptionTooLong = 8,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		InappropriateDescription = 9,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		PriceIsInvalid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		PermissionDenied = 12,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		PlayerHasRoomUnderModerationReview = 13,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		JuniorStatusFail = 14,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		PlayerIsNotCoOwner = 15,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		RoomKeyLimitReached = 16,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		PlayerAlreadyOwns = 17,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		RoomUnderModerationReview = 18,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		PurchaseFailed = 19,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		RoomDoesNotExist = 20,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		PaidKeyPurchasingDisabled = 21,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		CreateOrModifyKeysDisabled = 22,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		RoomKeyUnderModerationReview = 23,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		PlayerRestrictedFromP2PSelling = 24,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		PlayerNotRecRoomPlusMember = 25,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		InvalidRoomCurrency = 26,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		RoomCurrenciesAreDisabled = 27,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		ImageDoesNotExist = 28,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		NotEnoughCurrency = 29,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PlayerRestrictedFromP2PBuying = 30
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Flags]
public enum ABLHKFGLOPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Top = 2,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Bottom = 4,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Left = 8,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Right = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Center = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	LeftAndRight = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	TopAndBottom = 6,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	AllSides = 0x1E
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
public enum PGELHJOMIOE
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PingPong = 1,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	StopAtStart = 2,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	StopAtEnd = 4,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	AllowHolding = 8
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LOODBKALLPL
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Team1 = 0,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Team2 = 1,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Team3 = 2,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Team4 = 3,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Team5 = 4,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Team6 = 5,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Team7 = 6,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Team8 = 7,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Team9 = 8,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Team10 = 9,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Team11 = 10,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Team12 = 11,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Team13 = 12,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Team14 = 13,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Team15 = 14,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Team16 = 15,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Team17 = 16,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Team18 = 17,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Team19 = 18,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Team20 = 19,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Team21 = 20,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Team22 = 21,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Team23 = 22,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Team24 = 23,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Team25 = 24,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Team26 = 25,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Team27 = 26,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Team28 = 27,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Team29 = 28,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Team30 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Team31 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Team32 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Team33 = 32,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Team34 = 33,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Team35 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Team36 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Team37 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Team38 = 37,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Team39 = 38,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Team40 = 39,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	ANY = -1,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	MAX_VALUE = 39
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IODBOIDAIAH
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Cube,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Sphere
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum JBCOJKHOOPF
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Pivot,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Handle
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum JMNLGEOMELD
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum HAHLEDDAHPJ
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Unassigned = 0,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	LimitedOneUseOnly = 10,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	DisallowKeyLock = 15,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	UseOnly = 20,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	EditAndSave = 40,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Publish = 60,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Charge = 80,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Unlimited = 100
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NCLIGPNKBLC
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Restrict,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Allow
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum PhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Physical = 4
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum IKOEOMLKCOB
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Dominant,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Offhand,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	DualWield
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IBAOEIKGCNA
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1732030", Offset = "0x1730830", VA = "0x181732030")]
	public static bool LKMBAKFICKA(this IKOEOMLKCOB APFPMOMMHNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1732020", Offset = "0x1730820", VA = "0x181732020")]
	public static bool ADKJMEOAIMC(this IKOEOMLKCOB APFPMOMMHNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x13317A0", Offset = "0x132FFA0", VA = "0x1813317A0")]
	public static bool MIDGCMADOPJ(this IKOEOMLKCOB APFPMOMMHNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F2AFD0", Offset = "0x7F297D0", VA = "0x187F2AFD0")]
	public static string EMKPIINIBCH(this IKOEOMLKCOB APFPMOMMHNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B0D0", Offset = "0x7F298D0", VA = "0x187F2B0D0")]
	public static string OBLLKFBEPFJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum CAKMKKHPGOG
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum NJHHDGDJBCG
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Color,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	ColorAndMaterial
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum EAIHJJGBIAB
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CAN_ADD_ROOM_BANS = 1018,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CAN_MODIFY_ROOM_WIDE_ASSETS = 1019
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum LGBMGFOIFNM
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Key,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	CircuitEventKey
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[Flags]
public enum JBMDLOJDIHF : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Legacy = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Rooms2 = 2
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum PNHFGLEGEPN
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	DuringGame,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	PrePostGame,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Manual
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum PAHPNOPELHE
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	LinearOut,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Solid,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	EaseOut
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum ONAPIBECPED
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Hard,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Soft,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Sword,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Neon,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Laser,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Rainbow,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	RainbowStriped
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IIHFCBMHOIG
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Linear,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Constant,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Exponential,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Sinewave,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Reverse,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Wiggle
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum LHKNHJGBEJF : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum NIENMLJDIPE
{
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	Tool
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum LLFJILOKJLH
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Private,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Unlisted
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KEIJGPDJMGG
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum AHNKLKPAIBG
{
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum CHLPDKCJFEH
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	RoomLowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Room = 1,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	RoomHighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	LoudspeakerHighPitch = 22,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	CallLowPitch = 30,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	CallNone = 31,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	CallHighPitch = 32
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum AAJPGJDJPHL
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	CoachVO,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	VoiceCall,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RoomieAI,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	RemoteRoomieAI
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct KBAIHMIILBN : IEquatable<KBAIHMIILBN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public readonly AAJPGJDJPHL NIIEKDGBPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public readonly string NJLIKNOPELL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B2B0", Offset = "0x7F29AB0", VA = "0x187F2B2B0")]
	public KBAIHMIILBN(AAJPGJDJPHL EMCANDPJKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B340", Offset = "0x7F29B40", VA = "0x187F2B340")]
	public KBAIHMIILBN(AAJPGJDJPHL EMCANDPJKPB, string EJMHPGOKBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B220", Offset = "0x7F29A20", VA = "0x187F2B220")]
	public bool LNBMFKFPMBK(AAJPGJDJPHL BLAFEEHBBPL, string LBHKABOJMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B190", Offset = "0x7F29990", VA = "0x187F2B190", Slot = "4")]
	public bool Equals(KBAIHMIILBN KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B100", Offset = "0x7F29900", VA = "0x187F2B100", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B1B0", Offset = "0x7F299B0", VA = "0x187F2B1B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum AEHFDDBLBJP
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
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
