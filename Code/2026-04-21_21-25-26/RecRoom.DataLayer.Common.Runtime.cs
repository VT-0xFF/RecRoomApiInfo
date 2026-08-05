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
	public static class CUZCCCAIAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9932AA0", Offset = "0x99314A0", VA = "0x189932AA0")]
		public static string SHIMMLTXGRY(this AccountRoleType a)
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
		GiftingRateLimited = 36,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		CannotUpdateToTokenPrice = 37
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Flags]
	public enum CrosshairTickMasks
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		Top = 2,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		Bottom = 4,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		Left = 8,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		Right = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		Center = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		LeftAndRight = 0x18,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		TopAndBottom = 6,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		AllSides = 0x1E
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Flags]
	public enum FrameFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PingPong = 1,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		StopAtStart = 2,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		StopAtEnd = 4,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		AllowHolding = 8
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum GameTeam
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Team1 = 0,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Team2 = 1,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Team3 = 2,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Team4 = 3,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Team5 = 4,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Team6 = 5,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Team7 = 6,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Team8 = 7,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Team9 = 8,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Team10 = 9,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Team11 = 10,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Team12 = 11,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Team13 = 12,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Team14 = 13,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Team15 = 14,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Team16 = 15,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Team17 = 16,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Team18 = 17,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Team19 = 18,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Team20 = 19,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Team21 = 20,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Team22 = 21,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Team23 = 22,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		Team24 = 23,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Team25 = 24,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Team26 = 25,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Team27 = 26,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Team28 = 27,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		Team29 = 28,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		Team30 = 29,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		Team31 = 30,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Team32 = 31,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Team33 = 32,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Team34 = 33,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Team35 = 34,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Team36 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Team37 = 36,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Team38 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Team39 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Team40 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		ANY = -1,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		MAX_VALUE = 39
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum GlassPaneShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Cube,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Sphere
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum GrabberAttachmentMode
	{
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Pivot,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Center,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		Handle
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum HandType
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Unknown = -1,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Right
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum InventionPermission
	{
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		Unassigned = 0,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		LimitedOneUseOnly = 10,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		DisallowKeyLock = 15,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		UseOnly = 20,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		EditAndSave = 40,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		Publish = 60,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		Charge = 80,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		Unlimited = 100
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum LocomotionFilterModes
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		Restrict,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		Allow
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum NetworkSetterPermissionMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Master,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		Any,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		MasterOrAuth
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class KKMGUITYCTS
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9932EC0", Offset = "0x99318C0", VA = "0x189932EC0")]
		public static bool VCELSHCDVTF(this NetworkSetterPermissionMode a, bool b, bool c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public enum PhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Physical_Sticky = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		Physical = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum PreferredHandedness
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		Dominant,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		Offhand,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		DualWield
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class GFUKOIRYFBV
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1996F60", Offset = "0x1995960", VA = "0x181996F60")]
		public static bool EINJEHFVAQN(this PreferredHandedness a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x195FD70", Offset = "0x195E770", VA = "0x18195FD70")]
		public static bool OTWQYFDXXTM(this PreferredHandedness a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1567400", Offset = "0x1565E00", VA = "0x181567400")]
		public static bool KQOISAJQMDV(this PreferredHandedness a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9932DC0", Offset = "0x99317C0", VA = "0x189932DC0")]
		public static string RYXXZDKJOLB(this PreferredHandedness a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9932D90", Offset = "0x9931790", VA = "0x189932D90")]
		public static string DHJHZTSGFZF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum RbexInterpolationMode
	{
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		OnlyForReducedPhysicsRateAndNotParenting,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		Never,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		OnEvenWhenParenting
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum RecolorModes
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		Color,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		ColorAndMaterial
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum RolePermission
	{
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		INVALID = -1,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		CAN_EDIT_ROOM_ROLES = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		VOTE_KICK_PERMISSION = 3,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		CAN_INVITE = 4,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		CAN_TALK = 6,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		CAN_PRINT_PHOTOS = 7,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		CAN_START_GAMES = 8,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		CAN_SELF_REVIVE = 9,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		AUTO_ASSIGNED_GAME_ROLES = 11,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		CAN_CHANGE_GAME_MODE = 12,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		CAN_USE_MAKER_PEN = 13,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		CAN_USE_DELETE_ALL_BUTTON = 14,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		CAN_SAVE_INVENTIONS = 15,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		DISABLE_MIC_AUTO_MUTE = 16,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		CAN_END_GAMES_EARLY = 17,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		CAN_USE_SHARE_CAM = 18,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		CAN_EDIT_CIRCUITS = 19,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		CAN_SPAWN_INVENTIONS = 20,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		CAN_SPAWN_CONSUMABLES = 21,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		CAN_USE_ROOM_RESET_BUTTON = 22,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		AUTO_ASSIGNED_PLAYER_TAGS = 24,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		CAN_USE_RRS = 25,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		ROOM_LEVEL_THRESHOLD = 1000,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		CAN_SAVE_ROOM = 1001,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		CAN_PUBLISH_ROOM = 1002,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		CAN_CLONE_ROOM = 1003,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		CAN_RESTORE_ROOM = 1004,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		CAN_CREATE_SUBROOMS = 1008,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		CAN_NAME_SUBROOMS = 1009,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		CAN_CLONE_SUBROOMS = 1010,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		CAN_MOVE_SUBROOMS = 1011,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		CAN_DELETE_SUBROOMS = 1012,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		CAN_EDIT_SUBROOM_SETTINGS = 1013,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		CAN_RESET_CLOUD_VARIABLES = 1014,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		CAN_DELETE_CLOUD_VARIABLES = 1015,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		CAN_EDIT_ROOM_PROGRESSION = 1016,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		CAN_REMOVE_ROOM_BANS = 1017,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		CAN_ADD_ROOM_BANS = 1018,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		CAN_MODIFY_ROOM_WIDE_ASSETS = 1019
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum RoomKeyType
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Key,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		CircuitEventKey
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[Flags]
	public enum RoomVersionFlags : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Legacy = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Rooms2 = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum SpawnPointPurposeType
	{
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		DuringGame,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		PrePostGame,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Manual
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum TrailGradientTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		LinearOut,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		Solid,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		EaseInOut,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		EaseOut
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum TrailMaterialTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		Hard,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		Soft,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		Sword,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		Neon,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		Laser,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Rainbow,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		RainbowStriped
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum TrailWidthCurveTypes
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Linear,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		EaseInOut,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		Exponential,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Sinewave,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Reverse,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Wiggle
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum TransformTrackRate : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Limited,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Full
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum TriggerVolumeV1Mode
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		Tool
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum UgcAccessibility
	{
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		Private,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		Public,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Unlisted
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum UgcPurchasableItemVisibility
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		AlwaysVisible,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		HiddenInWatchStore
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum UpdateLOD
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		TwoPointFiveMeters = 0,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		FiveMeters = 1,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		TenMeters = 2,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		TwentyMeters = 3,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		FiftyMeters = 4,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		HundredMeters = 5,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		FiveHundredMeters = 6,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		GreaterThanFiveHundredMeters = 7,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		Invalid = -1
	}
}
namespace RecRoom.DataLayer.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum AudioType
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		_2D,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		_3D
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum VOIPFilter
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		RoomLowPitch = 0,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		Room = 1,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		RoomHighPitch = 2,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		RadioLowPitch = 10,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		Radio = 11,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		RadioHighPitch = 12,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		LoudspeakerLowPitch = 20,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Loudspeaker = 21,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		LoudspeakerHighPitch = 22,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		CallLowPitch = 30,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		CallNone = 31,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		CallHighPitch = 32
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum Channel
	{
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Voice,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Sfx,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Music,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		Ambience,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Master,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		CoachVO,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		VoiceCall,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		RoomieAI,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		RemoteRoomieAI,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		GameAI
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum VoiceOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Coach,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Alloy,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Ash,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Ballad,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Coral,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Echo,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Sage,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Shimmer,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Verse
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct ChannelAndSubChannel : IEquatable<ChannelAndSubChannel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public readonly Channel Channel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public readonly string SubChannel;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9932D50", Offset = "0x9931750", VA = "0x189932D50")]
		public ChannelAndSubChannel(Channel channel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9932D20", Offset = "0x9931720", VA = "0x189932D20")]
		public ChannelAndSubChannel(Channel channel, string subChannel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9932CE0", Offset = "0x99316E0", VA = "0x189932CE0")]
		public bool PAUJQPXYOAW(Channel a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9932BB0", Offset = "0x99315B0", VA = "0x189932BB0", Slot = "4")]
		public bool Equals(ChannelAndSubChannel other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9932BD0", Offset = "0x99315D0", VA = "0x189932BD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9932C70", Offset = "0x9931670", VA = "0x189932C70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum RolloffCurve
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Logarithmic,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Linear
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public enum TexturedQuadMaterialType
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		UnlitOpaque,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		LitOpaque,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
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
