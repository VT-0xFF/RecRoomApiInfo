using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HEOHLAMPJMC : byte
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
public static class NHDHGJOHHHF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71B47D0", Offset = "0x71B39D0", VA = "0x1871B47D0")]
	public static string EJJBDOGKMAM(this HEOHLAMPJMC DGMMAAOBBBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IEPCDHHNEOA
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
public enum KIACFJMEOKO
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
public enum GABNLKIMKEF
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
public enum BNHEGBCKMNN
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
public enum ILMHKLOOGBA
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Cube,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Sphere
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum APDMLCMBJBB
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Pivot,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Handle
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum IDCPFOBPGID
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum DOCHPNIHNFH
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Unassigned = 0,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	LimitedOneUseOnly = 10,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	DisallowKeyLock = 15,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	UseOnly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	EditAndSave = 40,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Publish = 60,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Charge = 80,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Unlimited = 100
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum DGNOAOLKAKC
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Restrict,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Allow
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MJKKGIFJLGF
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Dominant,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Offhand,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	DualWield
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EGBNJAKIPHP
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x13CACA0", Offset = "0x13C9EA0", VA = "0x1813CACA0")]
	public static bool HOIJNPJLJDN(this MJKKGIFJLGF JEGMPIJKIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x13CAC90", Offset = "0x13C9E90", VA = "0x1813CAC90")]
	public static bool HBIDEAIGDLJ(this MJKKGIFJLGF JEGMPIJKIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x13CACB0", Offset = "0x13C9EB0", VA = "0x1813CACB0")]
	public static bool NIJIMLOEPFF(this MJKKGIFJLGF JEGMPIJKIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x71B46D0", Offset = "0x71B38D0", VA = "0x1871B46D0")]
	public static string HPBJAOJMAEH(this MJKKGIFJLGF JEGMPIJKIGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x71B46A0", Offset = "0x71B38A0", VA = "0x1871B46A0")]
	public static string AALFBHNPJNN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum DCBINGCLJFB
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum EPJPGJBEIKM
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Color,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	ColorAndMaterial
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FFJCADLGMHL
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Key,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	CircuitEventKey
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[Flags]
public enum OBHANHDMLJF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Legacy = 1,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Rooms2 = 2
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OCMNNDKEADI
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	DuringGame,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	PrePostGame,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	Manual
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum BPGPNLFDOPM
{
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	LinearOut,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Solid,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	EaseOut
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum KONLKDAIANI
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Hard,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	Soft,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Sword,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Neon,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Laser,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Rainbow,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	RainbowStriped
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum IEDALHKNCLO
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Linear,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Constant,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Exponential,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Sinewave,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Reverse,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Wiggle
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum NEGICDPELDL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum OFNFLNDEGLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Tool
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum OAPBAHGKKDA
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Private,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Unlisted
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum MICCOKKHGKO
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum IDNDEKEBDDD
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum DIMNNEENIBB
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RoomLowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Room = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	RoomHighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	LoudspeakerHighPitch = 22,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	CallLowPitch = 30,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	CallNone = 31,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	CallHighPitch = 32
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GCKDBFOGBLB
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	CoachVO,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	VoiceCall
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct ECDEONNJFFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly GCKDBFOGBLB ILNKMGJIOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly string FPMBJHMNPPO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x71B4600", Offset = "0x71B3800", VA = "0x1871B4600")]
	public ECDEONNJFFN(GCKDBFOGBLB FLAIOLMMJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x71B4590", Offset = "0x71B3790", VA = "0x1871B4590")]
	public ECDEONNJFFN(GCKDBFOGBLB FLAIOLMMJCA, string FNALDDDEGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x71B4500", Offset = "0x71B3700", VA = "0x1871B4500")]
	public bool FCPPNGCCBIO(GCKDBFOGBLB MCLOGINJAPM, string DACKABFBCPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum DFONGNBBMKJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
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
