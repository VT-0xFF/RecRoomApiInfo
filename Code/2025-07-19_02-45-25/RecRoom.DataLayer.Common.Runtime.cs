using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PHBPGMMKBJJ : byte
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
public static class LKLHHAKEHGI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80F0C60", Offset = "0x80EFC60", VA = "0x1880F0C60")]
	public static string LMIGDHDFDJI(this PHBPGMMKBJJ GKNAOACDPDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IJELGOILOGJ : sbyte
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
	Roomie_Head = 20,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Roomie_Torso = 21,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Roomie_Face = 22
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Flags]
public enum NNAAFBAPDGO
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Nose = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Face = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Roomie_Head = 0x100000,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Roomie_Torso = 0x200000
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum RoomKeyResult
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Success = 0,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		InvalidParameters = 1,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		DoesNotExist = 2,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		NameTooShort = 3,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		NameTooLong = 4,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		DuplicateName = 5,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		InappropriateName = 6,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		DescriptionTooShort = 7,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		DescriptionTooLong = 8,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		InappropriateDescription = 9,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		PriceIsInvalid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		PermissionDenied = 12,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		PlayerHasRoomUnderModerationReview = 13,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		JuniorStatusFail = 14,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		PlayerIsNotCoOwner = 15,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		RoomKeyLimitReached = 16,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		PlayerAlreadyOwns = 17,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		RoomUnderModerationReview = 18,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		PurchaseFailed = 19,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		RoomDoesNotExist = 20,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		PaidKeyPurchasingDisabled = 21,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		CreateOrModifyKeysDisabled = 22,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		RoomKeyUnderModerationReview = 23,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PlayerRestrictedFromP2PSelling = 24,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PlayerNotRecRoomPlusMember = 25,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		InvalidRoomCurrency = 26,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		RoomCurrenciesAreDisabled = 27,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		ImageDoesNotExist = 28,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		NotEnoughCurrency = 29,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		PlayerRestrictedFromP2PBuying = 30
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[Flags]
public enum EHBNEEJGDLD
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Top = 2,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Bottom = 4,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Left = 8,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Right = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Center = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	LeftAndRight = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	TopAndBottom = 6,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	AllSides = 0x1E
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[Flags]
public enum LJKBDJAMCPE
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	PingPong = 1,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	StopAtStart = 2,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	StopAtEnd = 4,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	AllowHolding = 8
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DKDDPCHLJEF
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Team1 = 0,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Team2 = 1,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Team3 = 2,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Team4 = 3,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Team5 = 4,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Team6 = 5,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Team7 = 6,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Team8 = 7,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Team9 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Team10 = 9,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Team11 = 10,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Team12 = 11,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Team13 = 12,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Team14 = 13,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Team15 = 14,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Team16 = 15,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Team17 = 16,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Team18 = 17,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Team19 = 18,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Team20 = 19,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Team21 = 20,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Team22 = 21,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Team23 = 22,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Team24 = 23,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Team25 = 24,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Team26 = 25,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Team27 = 26,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Team28 = 27,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Team29 = 28,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Team30 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Team31 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Team32 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Team33 = 32,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Team34 = 33,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Team35 = 34,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Team36 = 35,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Team37 = 36,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Team38 = 37,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Team39 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Team40 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	ANY = -1,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	MAX_VALUE = 39
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BFNHIHKNNBD
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Cube,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Sphere
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum EFCIPIFADNE
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Pivot,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Handle
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum ALOALKLLOBH
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum KGCKBAIOBNL
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Unassigned = 0,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	LimitedOneUseOnly = 10,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	DisallowKeyLock = 15,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	UseOnly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	EditAndSave = 40,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Publish = 60,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Charge = 80,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Unlimited = 100
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum EKEDGMDPMAE
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Restrict,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Allow
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum PDOEAIKKMOC
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Any,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	MasterOrAuth
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class FGJJANEFJGB
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x80F0A40", Offset = "0x80EFA40", VA = "0x1880F0A40")]
	public static bool BMIEIOCMHJA(this PDOEAIKKMOC PBBNDGKGPAB, bool NCBJJBEHILE, bool FEKKNDLMPDO)
	{
		return default(bool);
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum PhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Physical = 4
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum DLCGHFKCFGO
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Dominant,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Offhand,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DualWield
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IBONCICCMMA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x186E7F0", Offset = "0x186D7F0", VA = "0x18186E7F0")]
	public static bool EDALELLKBBH(this DLCGHFKCFGO ECAFAONEDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x191EBF0", Offset = "0x191DBF0", VA = "0x18191EBF0")]
	public static bool BFDICKPBCGO(this DLCGHFKCFGO ECAFAONEDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14581B0", Offset = "0x14571B0", VA = "0x1814581B0")]
	public static bool JEAJCEHEHBF(this DLCGHFKCFGO ECAFAONEDML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80F0B60", Offset = "0x80EFB60", VA = "0x1880F0B60")]
	public static string CAJEGBKKGAF(this DLCGHFKCFGO ECAFAONEDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80F0B30", Offset = "0x80EFB30", VA = "0x1880F0B30")]
	public static string AJOJFALCPDF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum PCMEBGNJIKH
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum JMILMNDKMDN
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Color,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	ColorAndMaterial
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum OGKGADHHDKM
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	CAN_ADD_ROOM_BANS = 1018,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	CAN_MODIFY_ROOM_WIDE_ASSETS = 1019
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum OOMOBMPOMPL : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Waist,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Eye
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum CAIBPLFEHJI
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Key,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	CircuitEventKey
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Flags]
public enum DKPINMLAKAK : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Legacy = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Rooms2 = 2
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum NPEDJHJHGBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	DuringGame,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	PrePostGame,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Manual
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum JHILPLKDPIL
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	LinearOut,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Solid,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	EaseOut
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum POBPCCGGLIE
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Hard,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Soft,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Sword,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Neon,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Laser,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Rainbow,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	RainbowStriped
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum CICAMFMHLKD
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Linear,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Constant,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Exponential,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Sinewave,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reverse,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Wiggle
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JEHFMNHABAI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LHJCNBHLKIL
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Tool
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum KLKIFENPGNG
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Private,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Unlisted
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum FECJOJFDCBL
{
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum EBNEHNBIBMI
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum LJOHBOFFHPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RoomLowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Room = 1,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RoomHighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	LoudspeakerHighPitch = 22,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	CallLowPitch = 30,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	CallNone = 31,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	CallHighPitch = 32
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum DEKDPGDEEGG
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	CoachVO,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	VoiceCall,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	RoomieAI,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RemoteRoomieAI,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	GameAI
}
namespace RecRoom.DataLayer.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum VoiceOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Coach,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Alloy,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Ash,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Ballad,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Coral,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Echo,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Sage,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Shimmer,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Verse
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct OKCPOEIELLG : IEquatable<OKCPOEIELLG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public readonly DEKDPGDEEGG BMPKJKENDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public readonly string BMPMCOPDBCD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80F0FA0", Offset = "0x80EFFA0", VA = "0x1880F0FA0")]
	public OKCPOEIELLG(DEKDPGDEEGG JHPFOADKPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80F0F30", Offset = "0x80EFF30", VA = "0x1880F0F30")]
	public OKCPOEIELLG(DEKDPGDEEGG JHPFOADKPKM, string NDPPAIBFIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x80F0EA0", Offset = "0x80EFEA0", VA = "0x1880F0EA0")]
	public bool IIALKJEOEKH(DEKDPGDEEGG BGHCPOFEGAA, string OOCGOOFLEIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80F0E10", Offset = "0x80EFE10", VA = "0x1880F0E10", Slot = "4")]
	public bool Equals(OKCPOEIELLG EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80F0D70", Offset = "0x80EFD70", VA = "0x1880F0D70", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x80F0E30", Offset = "0x80EFE30", VA = "0x1880F0E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum DFBIEHOBKFF
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
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
