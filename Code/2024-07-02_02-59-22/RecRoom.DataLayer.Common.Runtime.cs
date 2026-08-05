using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JAFDOBAHKIN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum AHOPCOINALC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HPJFBALBIOJ
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OHCICINFCJL
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GGCPGDCBMND
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	LowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	None = 1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	HighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	LoudspeakerHighPitch = 22
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AMFPAFBOMPO
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Ambience,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Master,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	CoachVO
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct ALNANGBGNMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly AMFPAFBOMPO LJILLKDBOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly string EEPPBBCHOAK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x690F710", Offset = "0x690E710", VA = "0x18690F710")]
	public ALNANGBGNMK(AMFPAFBOMPO FAJHEEIDPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x690F7B0", Offset = "0x690E7B0", VA = "0x18690F7B0")]
	public ALNANGBGNMK(AMFPAFBOMPO FAJHEEIDPLC, string IMGPJKAALCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x690F680", Offset = "0x690E680", VA = "0x18690F680")]
	public bool LLCJCEAGHPA(AMFPAFBOMPO NOAFIBIMGCO, string OGACGMMJDDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BEPNGIFPFEH
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
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
