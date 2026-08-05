using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
public class JNPIFCHJLEA : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Type PHDAFPOPIJA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1346F60", Offset = "0x1345760", VA = "0x181346F60")]
	public JNPIFCHJLEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6CB410", Offset = "0x6C9C10", VA = "0x1806CB410")]
	public JNPIFCHJLEA(Type GJPGKHFHDOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field)]
public class BCHDPPCKNIE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x50AC00", Offset = "0x509400", VA = "0x18050AC00")]
	public BCHDPPCKNIE()
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
