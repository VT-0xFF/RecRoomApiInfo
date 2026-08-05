using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Flags]
public enum DLMKNDDLEGM
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
public enum CHPDJKEAKGO
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Pivot,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Center,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Handle
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HGPIBOIJKAI
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OJNODCAMEGH
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
public enum JCKNOHADBLN
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Dominant,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Offhand,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	DualWield
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MNMCIIGFCFP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xF20200", Offset = "0xF1EC00", VA = "0x180F20200")]
	public static bool CADKJDHPKCN(this JCKNOHADBLN MBGJLGIAHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xF20220", Offset = "0xF1EC20", VA = "0x180F20220")]
	public static bool FKIEPDPKKOG(this JCKNOHADBLN MBGJLGIAHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xF201F0", Offset = "0xF1EBF0", VA = "0x180F201F0")]
	public static bool LCGJEDJEIHN(this JCKNOHADBLN MBGJLGIAHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B47F50", Offset = "0x6B46950", VA = "0x186B47F50")]
	public static string EKFJMIKJHOO(this JCKNOHADBLN MBGJLGIAHGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B48050", Offset = "0x6B46A50", VA = "0x186B48050")]
	public static string NCCNDLLCCIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum MFAANDACBHL
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum AMCOKHKIICF
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Color,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ColorAndMaterial
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Flags]
public enum PGFEGNPFAFP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Legacy = 1,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Rooms2 = 2
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum AJCNCFPFOKG
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
public enum POPKKLIEMMD
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
public enum CPOGPKAJCKO
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
public enum NFCFPCIBOBP : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum JNKKEIFENFB
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
public enum NONNKEJNJOM
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum AJHGEDFMNAN
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
public enum EEEAIFIDAEA
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
public struct KKGCMPDDKKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly EEEAIFIDAEA CLPBPABKIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly string OMMEBONMCHJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B47E50", Offset = "0x6B46850", VA = "0x186B47E50")]
	public KKGCMPDDKKM(EEEAIFIDAEA MGKHIAMHDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B47EE0", Offset = "0x6B468E0", VA = "0x186B47EE0")]
	public KKGCMPDDKKM(EEEAIFIDAEA MGKHIAMHDEO, string GBNNJIOLPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B47DC0", Offset = "0x6B467C0", VA = "0x186B47DC0")]
	public bool HPPHELPCNBE(EEEAIFIDAEA FFHNMDAHOAK, string IFCPBFOMBJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum AJBPGJCIPOA
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
