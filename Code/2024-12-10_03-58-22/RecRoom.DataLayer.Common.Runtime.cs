using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BCGODMJDFFO
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
public enum CICKFGEMEAG
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
public enum HIAALFFJHJH
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
	LeftAndRight = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	TopAndBottom = 6,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	All = 0x1E
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum FGLGBDAFJGM
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	PingPong = 1,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	StopAtStart = 2,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	StopAtEnd = 4,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	AllowHolding = 8
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JBGLGHOCHMD
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Cube,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Sphere
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PMHDIJFIHNG
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Pivot,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	Handle
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum KOEIKGEMDHH
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LFLOAHHDFKI
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Unassigned = 0,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	LimitedOneUseOnly = 10,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	DisallowKeyLock = 15,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	UseOnly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	EditAndSave = 40,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Publish = 60,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Charge = 80,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Unlimited = 100
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum AHPNLHFLAON
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Restrict,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Allow
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum DDKHKEIJCFK
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Dominant,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Offhand,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	DualWield
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DKPLALKPALF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xF509F0", Offset = "0xF4F5F0", VA = "0x180F509F0")]
	public static bool CONCHKNIBIH(this DDKHKEIJCFK EEPKGOKGFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xF50A10", Offset = "0xF4F610", VA = "0x180F50A10")]
	public static bool BFNGOJBFKMO(this DDKHKEIJCFK EEPKGOKGFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xF509E0", Offset = "0xF4F5E0", VA = "0x180F509E0")]
	public static bool IBBPJOKEJHF(this DDKHKEIJCFK EEPKGOKGFAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF380", Offset = "0x6BDDF80", VA = "0x186BDF380")]
	public static string IBJJACNPIEN(this DDKHKEIJCFK EEPKGOKGFAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF480", Offset = "0x6BDE080", VA = "0x186BDF480")]
	public static string OENCFOPNJOF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum EGPFJKHDCKA
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum PEJLMIMHLEB
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Color,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	ColorAndMaterial
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum MIAAEAGOENI
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Key,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	CircuitEventKey
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[Flags]
public enum GNNIFAOGAPO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Legacy = 1,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Rooms2 = 2
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GHAIIJPLOIB
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	LinearOut,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Solid,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	EaseOut
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum FDANGPAIAMP
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Hard,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Soft,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Sword,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Neon,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Laser,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Rainbow,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	RainbowStriped
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum EKLHMHPLNCP
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Linear,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Constant,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Exponential,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Sinewave,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Reverse,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Wiggle
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum MJNMIJLCBLF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum KDAMCJNMFKF
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	Player,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Tool
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum MEMJPCPEGPB
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Private,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Public,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Unlisted
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum PFKPGFLKLMF
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum DDMCFFKAALE
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DONGGCPCFFL
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	RoomLowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Room = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RoomHighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	LoudspeakerHighPitch = 22,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	CallLowPitch = 30,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CallNone = 31,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CallHighPitch = 32
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum KHFOGBJKAPO
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	CoachVO,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	VoiceCall
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HNJOLFPOFJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly KHFOGBJKAPO GELAOPPILAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly string HJFDDBLOKLO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF5B0", Offset = "0x6BDE1B0", VA = "0x186BDF5B0")]
	public HNJOLFPOFJC(KHFOGBJKAPO KJMBOBLOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF540", Offset = "0x6BDE140", VA = "0x186BDF540")]
	public HNJOLFPOFJC(KHFOGBJKAPO KJMBOBLOOBM, string KILGEDFGELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF4B0", Offset = "0x6BDE0B0", VA = "0x186BDF4B0")]
	public bool MIAIGBLPKDM(KHFOGBJKAPO DIKEADOICNJ, string OEKAMIADPEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum AKLHJFGICIJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
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
