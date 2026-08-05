using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[NIGCOHNCHEO]
public delegate void HIAKBLMMKAB();
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class DKDOONNDEFE<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class JBPDNKIKLAM
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class KLPNDLAOJLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class BJEKECOEHPM
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class BLBEHKKHGGN<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class JBOJAFAIOEK
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
