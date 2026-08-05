using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GGBBLPGEOBA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Opportunistic,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Queue
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GOIIMPNDAAG
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Min = -1,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Minor,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Major,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Vital,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Max
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
