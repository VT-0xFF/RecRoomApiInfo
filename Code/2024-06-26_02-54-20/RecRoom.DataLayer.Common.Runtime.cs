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
