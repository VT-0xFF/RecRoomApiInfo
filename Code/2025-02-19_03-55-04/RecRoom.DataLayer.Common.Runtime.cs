using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HNNAMAANNEG : byte
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
public static class GAAMCJEGBDN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x743C050", Offset = "0x743AC50", VA = "0x18743C050")]
	public static string FCPKCIJBBAK(this HNNAMAANNEG FHNMLKMLDFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MNMFJNIJMID
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
public enum KOKIEDBNDOK
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
public enum KFNAEGLIHIN
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
public enum HOKDHKDGDAL
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
public enum HNJGCLBEEGE
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
public enum EMHIIIEMMGI
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Cube,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Sphere
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum EFGPDDFBOLH
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Pivot,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Handle
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum HMLPHKJFFOG
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum OAEFILPJPNI
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
public enum LOKOGBFJAGG
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Restrict,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Allow
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum EFFDMNDJJMG
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Dominant,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Offhand,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DualWield
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GFJPOFLIHLD
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x13FBD70", Offset = "0x13FA970", VA = "0x1813FBD70")]
	public static bool NLOJJHPCFGP(this EFFDMNDJJMG EBANGFJCKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x13FBD80", Offset = "0x13FA980", VA = "0x1813FBD80")]
	public static bool FLGFBAPJJNO(this EFFDMNDJJMG EBANGFJCKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x104FE50", Offset = "0x104EA50", VA = "0x18104FE50")]
	public static bool MDBEOBAODGP(this EFFDMNDJJMG EBANGFJCKEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x743C190", Offset = "0x743AD90", VA = "0x18743C190")]
	public static string PCHMBKHAPCK(this EFFDMNDJJMG EBANGFJCKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x743C160", Offset = "0x743AD60", VA = "0x18743C160")]
	public static string DPNJJMCOLOG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum HGFGAMBABML
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FNIHIEAJNOG
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Color,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	ColorAndMaterial
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum CMIDFMPOMIC
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Key,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	CircuitEventKey
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum OINIBEENKNO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Legacy = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Rooms2 = 2
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum CPKAIPHJPMH
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	DuringGame,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	PrePostGame,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Manual
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum NDOCMEAPCAH
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LinearOut,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Solid,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	EaseOut
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum NCNBLHBEHNF
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Hard,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Soft,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Sword,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Neon,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Laser,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Rainbow,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	RainbowStriped
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum IAOJPFAFLIP
{
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Linear,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Constant,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Exponential,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Sinewave,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Reverse,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Wiggle
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum INJLACPLDPA : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IOIKPKJENHB
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Tool
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum MEPGBPIBEBN
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	Private,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Unlisted
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum CKBJHKOEDDL
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum PCFADNKAOBF
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum OCEAFEILDEK
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	RoomLowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Room = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	RoomHighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	LoudspeakerHighPitch = 22,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	CallLowPitch = 30,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	CallNone = 31,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	CallHighPitch = 32
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum PPKKPDPOIBC
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	CoachVO,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	VoiceCall
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct KPJLOFILBEP : IEquatable<KPJLOFILBEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public readonly PPKKPDPOIBC GOAIAPMGIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public readonly string PFDLPNOBAPA;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x743C450", Offset = "0x743B050", VA = "0x18743C450")]
	public KPJLOFILBEP(PPKKPDPOIBC HKGEDMGHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x743C4E0", Offset = "0x743B0E0", VA = "0x18743C4E0")]
	public KPJLOFILBEP(PPKKPDPOIBC HKGEDMGHELN, string PPBJNGHHAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x743C3C0", Offset = "0x743AFC0", VA = "0x18743C3C0")]
	public bool OGMNHACECPD(PPKKPDPOIBC IBFIOBMBNMA, string DOMLPHFGLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x743C290", Offset = "0x743AE90", VA = "0x18743C290", Slot = "4")]
	public bool Equals(KPJLOFILBEP PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x743C2B0", Offset = "0x743AEB0", VA = "0x18743C2B0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x743C350", Offset = "0x743AF50", VA = "0x18743C350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum FDNDEFNMLJG
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
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
