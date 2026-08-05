using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MHDDIDMPDKK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	DateTime PDIBMDLBGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8ECAC0A802264A6", Offset = "0x0", VA = "0x8ECAC0C002264A6", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float NHOBHEGNFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x226548802264B0", Offset = "0x0", VA = "0x22654A002264B0", Slot = "1")]
		get;
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
