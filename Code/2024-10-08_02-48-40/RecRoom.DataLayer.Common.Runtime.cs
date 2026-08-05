using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum LDALOCJAPAM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Top = 2,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Bottom = 4,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Left = 8,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Right = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	LeftAndRight = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TopAndBottom = 6,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	All = 0x1E
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FACNHICCBCE
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Pivot,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Handle
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum IGDIBPEEMHD
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DAMOBBEOPGP
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Unassigned = 0,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	LimitedOneUseOnly = 10,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	DisallowKeyLock = 15,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	UseOnly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	EditAndSave = 40,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Publish = 60,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Charge = 80,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Unlimited = 100
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LNEFNPPNBPF
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Dominant,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Offhand,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DualWield
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JPOLJEGIHMK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x104A560", Offset = "0x1049760", VA = "0x18104A560")]
	public static bool GILEKKNMOKB(this LNEFNPPNBPF LDIAOOMEPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x104A530", Offset = "0x1049730", VA = "0x18104A530")]
	public static bool ICELNFGKGGA(this LNEFNPPNBPF LDIAOOMEPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x104A550", Offset = "0x1049750", VA = "0x18104A550")]
	public static bool OLJDFAOLKPN(this LNEFNPPNBPF LDIAOOMEPDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDF70", Offset = "0x6BFD170", VA = "0x186BFDF70")]
	public static string HMANACMHAKJ(this LNEFNPPNBPF LDIAOOMEPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDF40", Offset = "0x6BFD140", VA = "0x186BFDF40")]
	public static string BGLDNIFBMJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FNGCGGCLILE
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum AGBNMMHBJHP
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Color,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ColorAndMaterial
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Flags]
public enum MKOAAKDNFEF : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Legacy = 1,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Rooms2 = 2
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum KEHAJFEBMHG
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	LinearOut,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Solid,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	EaseOut
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public enum ELNEHICFDNJ
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Hard,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Soft,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Sword,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Neon,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Laser,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Rainbow,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	RainbowStriped
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum CODONMMDEOA
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	Linear,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Constant,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	EaseInOut,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Exponential,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	Sinewave,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	Reverse,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Wiggle
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum KFABMCIICMN : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum KOEAFBADJNF
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum NAJFOBBEMBN
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum NHPDHOJABDG
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	LowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	None = 1,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	HighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	LoudspeakerHighPitch = 22
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum CBLNMKKFGCO
{
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CoachVO
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct DOBPNBIEFGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly CBLNMKKFGCO HBLKKEMLPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly string JGBDBKMIDON;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDEB0", Offset = "0x6BFD0B0", VA = "0x186BFDEB0")]
	public DOBPNBIEFGI(CBLNMKKFGCO EAMAODJNFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDE40", Offset = "0x6BFD040", VA = "0x186BFDE40")]
	public DOBPNBIEFGI(CBLNMKKFGCO EAMAODJNFLO, string HMJLIMCJNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDDB0", Offset = "0x6BFCFB0", VA = "0x186BFDDB0")]
	public bool COBKPCGKNLJ(CBLNMKKFGCO KEBHCJKEBKO, string BALFJMFNJOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum HGIHIJKGPOF
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Linear
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
