using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum AccountRoleType : byte
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
		Creator = 255
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class IHXWHNEJREA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8205250", Offset = "0x8204650", VA = "0x188205250")]
		public static string LAFLTRDVMDL(this AccountRoleType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum AvatarBodyPart : sbyte
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
		Face,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		CustomBadge1
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[Flags]
	public enum AvatarBodyPartFlags
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
		CustomBadge1 = 0x800
	}
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
		PlayerRestrictedFromP2PBuying = 30,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		InvalidRelationship = 31,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		PlayerIsUgcGiftingRestricted = 32,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		PlayerIsUgcGiftReceivingRestricted = 33,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		CannotGiftFreeKey = 34,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		RoomKeyNotGiftable = 35,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		GiftingRateLimited = 36
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Flags]
	public enum CrosshairTickMasks
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Top = 2,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Bottom = 4,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		Left = 8,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Right = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Center = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		LeftAndRight = 0x18,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		TopAndBottom = 6,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		AllSides = 0x1E
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Flags]
	public enum FrameFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PingPong = 1,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		StopAtStart = 2,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		StopAtEnd = 4,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		AllowHolding = 8
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum GameTeam
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Team1 = 0,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Team2 = 1,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Team3 = 2,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Team4 = 3,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Team5 = 4,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Team6 = 5,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Team7 = 6,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Team8 = 7,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Team9 = 8,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Team10 = 9,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Team11 = 10,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Team12 = 11,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Team13 = 12,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Team14 = 13,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Team15 = 14,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Team16 = 15,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Team17 = 16,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Team18 = 17,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Team19 = 18,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Team20 = 19,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Team21 = 20,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Team22 = 21,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Team23 = 22,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Team24 = 23,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Team25 = 24,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Team26 = 25,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Team27 = 26,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Team28 = 27,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Team29 = 28,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Team30 = 29,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		Team31 = 30,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Team32 = 31,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Team33 = 32,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Team34 = 33,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Team35 = 34,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Team36 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Team37 = 36,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Team38 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Team39 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Team40 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		ANY = -1,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		MAX_VALUE = 39
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum GlassPaneShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Cube,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Sphere
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum GrabberAttachmentMode
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Center,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Handle
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum HandType
	{
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Right
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum InventionPermission
	{
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Unassigned = 0,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		LimitedOneUseOnly = 10,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		DisallowKeyLock = 15,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		UseOnly = 20,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		EditAndSave = 40,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		Publish = 60,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Charge = 80,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Unlimited = 100
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum LocomotionFilterModes
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		Restrict,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Allow
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum NetworkSetterPermissionMode
	{
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Master,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Any,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		MasterOrAuth
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class XVIFAPKPCWB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8205490", Offset = "0x8204890", VA = "0x188205490")]
		public static bool RJAYHRMACOI(this NetworkSetterPermissionMode a, bool b, bool c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public enum PhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Physical = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum PreferredHandedness
	{
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		Dominant,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		Offhand,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		DualWield
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class WAEWPVAHZXY
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x163D270", Offset = "0x163C670", VA = "0x18163D270")]
		public static bool REFJIFLVORA(this PreferredHandedness a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x160BE80", Offset = "0x160B280", VA = "0x18160BE80")]
		public static bool ERSWWXATTGL(this PreferredHandedness a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1227D50", Offset = "0x1227150", VA = "0x181227D50")]
		public static bool QQUJEKXDBJQ(this PreferredHandedness a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8205360", Offset = "0x8204760", VA = "0x188205360")]
		public static string PYKZSPZITXM(this PreferredHandedness a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8205460", Offset = "0x8204860", VA = "0x188205460")]
		public static string QZCFKXQHMPG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum RbexInterpolationMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		OnlyForReducedPhysicsRateAndNotParenting,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		Never,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		OnEvenWhenParenting
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum RecolorModes
	{
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		ColorAndMaterial
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum RolePermission
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		CAN_EDIT_ROOM_ROLES = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		VOTE_KICK_PERMISSION = 3,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		CAN_INVITE = 4,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		CAN_TALK = 6,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		CAN_PRINT_PHOTOS = 7,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		CAN_START_GAMES = 8,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		CAN_SELF_REVIVE = 9,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		AUTO_ASSIGNED_GAME_ROLES = 11,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		CAN_CHANGE_GAME_MODE = 12,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		CAN_USE_MAKER_PEN = 13,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		CAN_USE_DELETE_ALL_BUTTON = 14,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		CAN_SAVE_INVENTIONS = 15,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		DISABLE_MIC_AUTO_MUTE = 16,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		CAN_END_GAMES_EARLY = 17,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		CAN_USE_SHARE_CAM = 18,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		CAN_EDIT_CIRCUITS = 19,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		CAN_SPAWN_INVENTIONS = 20,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		CAN_SPAWN_CONSUMABLES = 21,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		CAN_USE_ROOM_RESET_BUTTON = 22,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		AUTO_ASSIGNED_PLAYER_TAGS = 24,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		CAN_USE_RRS = 25,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		ROOM_LEVEL_THRESHOLD = 1000,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		CAN_SAVE_ROOM = 1001,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		CAN_PUBLISH_ROOM = 1002,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		CAN_CLONE_ROOM = 1003,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		CAN_RESTORE_ROOM = 1004,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		CAN_CREATE_SUBROOMS = 1008,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		CAN_NAME_SUBROOMS = 1009,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		CAN_CLONE_SUBROOMS = 1010,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		CAN_MOVE_SUBROOMS = 1011,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		CAN_DELETE_SUBROOMS = 1012,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		CAN_EDIT_SUBROOM_SETTINGS = 1013,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		CAN_RESET_CLOUD_VARIABLES = 1014,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		CAN_DELETE_CLOUD_VARIABLES = 1015,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		CAN_EDIT_ROOM_PROGRESSION = 1016,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		CAN_REMOVE_ROOM_BANS = 1017,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		CAN_ADD_ROOM_BANS = 1018,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		CAN_MODIFY_ROOM_WIDE_ASSETS = 1019
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum RoomKeyType
	{
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Key,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		CircuitEventKey
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[Flags]
	public enum RoomVersionFlags : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Legacy = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Rooms2 = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum SpawnPointPurposeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		DuringGame,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		PrePostGame,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Manual
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum TrailGradientTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		LinearOut,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Solid,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		EaseInOut,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		EaseOut
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TrailMaterialTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		Hard,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Soft,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Sword,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Neon,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		Laser,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		Rainbow,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		RainbowStriped
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum TrailWidthCurveTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		EaseInOut,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		Exponential,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Sinewave,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Reverse,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Wiggle
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TransformTrackRate : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Limited,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Full
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum TriggerVolumeV1Mode
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		Tool
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum UgcAccessibility
	{
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		Private,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		Public,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		Unlisted
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum UpdateLOD
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		TwoPointFiveMeters = 0,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		FiveMeters = 1,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		TenMeters = 2,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		TwentyMeters = 3,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		FiftyMeters = 4,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		HundredMeters = 5,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		FiveHundredMeters = 6,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		GreaterThanFiveHundredMeters = 7,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Invalid = -1
	}
}
namespace RecRoom.DataLayer.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum AudioType
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		_2D,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		_3D
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum VOIPFilter
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		RoomLowPitch = 0,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		Room = 1,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RoomHighPitch = 2,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		RadioLowPitch = 10,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		Radio = 11,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		RadioHighPitch = 12,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		LoudspeakerLowPitch = 20,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Loudspeaker = 21,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		LoudspeakerHighPitch = 22,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		CallLowPitch = 30,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		CallNone = 31,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		CallHighPitch = 32
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum Channel
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Voice,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Sfx,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Music,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Ambience,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Master,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		CoachVO,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		VoiceCall,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		RoomieAI,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		RemoteRoomieAI,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		GameAI
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum VoiceOption
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Coach,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Alloy,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Ash,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Ballad,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Coral,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Echo,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Sage,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Shimmer,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Verse
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct ChannelAndSubChannel : IEquatable<ChannelAndSubChannel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public readonly Channel Channel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public readonly string SubChannel;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8205210", Offset = "0x8204610", VA = "0x188205210")]
		public ChannelAndSubChannel(Channel channel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82051E0", Offset = "0x82045E0", VA = "0x1882051E0")]
		public ChannelAndSubChannel(Channel channel, string subChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8205130", Offset = "0x8204530", VA = "0x188205130")]
		public bool FWVRDADIBWL(Channel a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8205080", Offset = "0x8204480", VA = "0x188205080", Slot = "4")]
		public bool Equals(ChannelAndSubChannel other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82050A0", Offset = "0x82044A0", VA = "0x1882050A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8205170", Offset = "0x8204570", VA = "0x188205170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum RolloffCurve
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Logarithmic,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Linear
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum TexturedQuadMaterialType
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		UnlitOpaque,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		LitOpaque,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		LitTransparent
	}
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
