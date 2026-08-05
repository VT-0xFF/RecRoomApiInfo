using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OCBFGLBFAMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class ANPBNAOCMNO
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[ACMKPIHBDGI]
public delegate void GIOEEBGKLLM();
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class OIFIAGANGCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class BIBCOHLMMEM<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BDBIFBAAODK
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FFDFOEBLIME<T>
{
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
