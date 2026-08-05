using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BJLDAKNNLCA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8EF888E8022DD66", Offset = "0x0", VA = "0x8EF88900022DD66", Slot = "0")]
	void NGLKBDEIIAD(object CGHEBMJOFGL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22DD948022DD70", Offset = "0x0", VA = "0x22DD960022DD70", Slot = "1")]
	void KMHGOBPOAON(object CGHEBMJOFGL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22DD9E88EF8890", Offset = "0x0", VA = "0x22DDA008EF8890", Slot = "2")]
	void KHJODMCMOIC(object CGHEBMJOFGL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8EF888E8022DDC6", Offset = "0x0", VA = "0x8EF88900022DDC6", Slot = "3")]
	void FFADHPPFAJI(object GMNCNEPJHHN, string KFLIIANGBGC, params object[] HGIPKCLMBHH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22DDF48022DDD0", Offset = "0x0", VA = "0x22DDF60022DDD0", Slot = "4")]
	void JDEOGBAGFLO(Exception BJAHINDBFGE);
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
