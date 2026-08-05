using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AEIOBEGHMKA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum MJAIFJOCDEE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Nose = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Face = 0x400
}
namespace RecRoom.DataLayer
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum RoomKeyResult
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Success = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		InvalidParameters = 1,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		DoesNotExist = 2,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		NameTooShort = 3,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		NameTooLong = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		DuplicateName = 5,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		InappropriateName = 6,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		DescriptionTooShort = 7,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		DescriptionTooLong = 8,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		InappropriateDescription = 9,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		PriceIsInvalid = 10,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		PermissionDenied = 12,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		PlayerHasRoomUnderModerationReview = 13,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		JuniorStatusFail = 14,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		PlayerIsNotCoOwner = 15,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		RoomKeyLimitReached = 16,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		PlayerAlreadyOwns = 17,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		RoomUnderModerationReview = 18,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		PurchaseFailed = 19,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		RoomDoesNotExist = 20,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		PaidKeyPurchasingDisabled = 21,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		CreateOrModifyKeysDisabled = 22,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		RoomKeyUnderModerationReview = 23,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		PlayerRestrictedFromP2PSelling = 24,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		PlayerNotRecRoomPlusMember = 25,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		InvalidRoomCurrency = 26,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		RoomCurrenciesAreDisabled = 27,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		ImageDoesNotExist = 28,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		NotEnoughCurrency = 29,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		PlayerRestrictedFromP2PBuying = 30
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Flags]
public enum GIFMPOBABNE
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Top = 2,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Bottom = 4,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Left = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Right = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Center = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	LeftAndRight = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	TopAndBottom = 6,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	AllSides = 0x1E
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum HIDAGLHANGE
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	PingPong = 1,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	StopAtStart = 2,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	StopAtEnd = 4,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	AllowHolding = 8
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum OGLHJHBKBAC
{
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Cube,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Sphere
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PONDPDGFLDF
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Pivot,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	Handle
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BPFDFNAOGMP
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MEODFHIGGGL
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Unassigned = 0,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	LimitedOneUseOnly = 10,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	DisallowKeyLock = 15,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	UseOnly = 20,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	EditAndSave = 40,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Publish = 60,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Charge = 80,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Unlimited = 100
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum JCAKJDAGADO
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Restrict,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Allow
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum DFPPOIJHGMN
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Dominant,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Offhand,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	DualWield
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IFIKAELBLMB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1140750", Offset = "0x113EF50", VA = "0x181140750")]
	public static bool BKAPCMNLBPP(this DFPPOIJHGMN ADMLMBAOKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1140720", Offset = "0x113EF20", VA = "0x181140720")]
	public static bool IPJJAIFLICG(this DFPPOIJHGMN ADMLMBAOKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1140730", Offset = "0x113EF30", VA = "0x181140730")]
	public static bool OJNOILJOFCP(this DFPPOIJHGMN ADMLMBAOKIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3540", Offset = "0x6EE1D40", VA = "0x186EE3540")]
	public static string HGBEGJPHJAC(this DFPPOIJHGMN ADMLMBAOKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3640", Offset = "0x6EE1E40", VA = "0x186EE3640")]
	public static string IIAAJGGPOHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum NEDCKNNIBBL
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum DDDPKDHADPI
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Color,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	ColorAndMaterial
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum BKLPOAGACGM
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Key,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	CircuitEventKey
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Flags]
public enum MBLEDMPFHDI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Legacy = 1,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Rooms2 = 2
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum PNCAMBDKOLF
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	DuringGame,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	PrePostGame,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Manual
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum HGPEDDALCKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	LinearOut,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Solid,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	EaseOut
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum GHGKGHNLAEK
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Hard,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Soft,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Sword,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Neon,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Laser,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Rainbow,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	RainbowStriped
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum AOMHDGFHELH
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Linear,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Constant,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Exponential,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Sinewave,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Reverse,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Wiggle
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum FMLELDCHGMI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum INCIIPCJKBM
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Tool
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum GINPKJDPNDP
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Private,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Unlisted
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum HNNBIECDFEH
{
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum CJHFFAMFIDA
{
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum NFNDHKMDGHH
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RoomLowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Room = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	RoomHighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LoudspeakerHighPitch = 22,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	CallLowPitch = 30,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	CallNone = 31,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	CallHighPitch = 32
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum GCIPOACPEKA
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	CoachVO,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	VoiceCall
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NKOCPABNFHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly GCIPOACPEKA POAMNLFMAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly string LGIHMHJNDNP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3700", Offset = "0x6EE1F00", VA = "0x186EE3700")]
	public NKOCPABNFHO(GCIPOACPEKA NIEDIBKMFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EE37A0", Offset = "0x6EE1FA0", VA = "0x186EE37A0")]
	public NKOCPABNFHO(GCIPOACPEKA NIEDIBKMFCK, string CEDEMKONLEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EE3670", Offset = "0x6EE1E70", VA = "0x186EE3670")]
	public bool AMEKKNKFGMJ(GCIPOACPEKA HLBMMAAPACH, string DKMMIPGJLHJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum LHOIFHJNALA
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
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
