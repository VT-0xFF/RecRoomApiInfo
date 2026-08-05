using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OFJLDPEJIPH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2D468E88AFAF28", Offset = "0x0", VA = "0x2D469008AFAF28", Slot = "0")]
	void DJGNNKLAGEN(object OEBNJDFJMBE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8AFBA8E802D4721", Offset = "0x0", VA = "0x8AFBA90002D4721", Slot = "1")]
	void HJKDMGEJOCL(object OEBNJDFJMBE);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2D47CB802D4740", Offset = "0x0", VA = "0x2D47CD002D4740", Slot = "2")]
	void OGMMPBDDHNK(object OEBNJDFJMBE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2D47CE88AFBA90", Offset = "0x0", VA = "0x2D47D008AFBA90", Slot = "3")]
	void DJOKCOCJFGB(object APPLJOFCBIB, string DCCMBDDMFFG, params object[] AHLCEBMCJMF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8B1A01A802D485E", Offset = "0x0", VA = "0x8B1A01C002D485E", Slot = "4")]
	void PCFFBPOOGPA(Exception JFHIOGAFNIM);
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
