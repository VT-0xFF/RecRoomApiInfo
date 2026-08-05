using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[MJHPIEDEDFE]
public delegate void JDBIGDIKDJC();
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class FELBGPGFAON<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class GCBDJNHCIFN
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BFFMAMAENHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class MCPGJBAGEHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class APHLOLJNCBE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class JFEPHIHKECG
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
