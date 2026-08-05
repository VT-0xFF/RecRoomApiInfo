using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
public sealed class CPHMNFBGLLE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
	public CPHMNFBGLLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
public sealed class LLNJDGHKDAA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x43D58E0", Offset = "0x43D48E0", VA = "0x1843D58E0")]
	public LLNJDGHKDAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4342440", Offset = "0x4341440", VA = "0x184342440")]
	public LLNJDGHKDAA(DIIAMJCJKDN PJBHMCLCGND, FLFLKPDJIIG IEOCBIDHPFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Flags]
public enum DIIAMJCJKDN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Default = 7,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Access = 1,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Assign = 2,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	InstantiatedWithFixedConstructorSignature = 4,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	InstantiatedNoFixedConstructorSignature = 8
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Flags]
public enum FLFLKPDJIIG
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Itself = 1,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Members = 2,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	WithInheritors = 4,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	WithMembers = 3
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Method)]
public sealed class FCCJPELLBLM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
	public FCCJPELLBLM()
	{
	}
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
