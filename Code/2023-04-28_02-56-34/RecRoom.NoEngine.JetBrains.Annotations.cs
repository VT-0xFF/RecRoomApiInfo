using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
public sealed class OKHHOGJDDEN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
	public OKHHOGJDDEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
public sealed class JMGBOOEBJLA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4974420", Offset = "0x4972E20", VA = "0x184974420")]
	public JMGBOOEBJLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x99C890", Offset = "0x99B290", VA = "0x18099C890")]
	public JMGBOOEBJLA(EDEDOFNEJCC DHCDHFLLCPF, ANAAAPADLPM ADMDLBDAIBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Flags]
public enum EDEDOFNEJCC
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
public enum ANAAAPADLPM
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
