using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PPFFOJFCBLE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IJNMMHIGPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x731B70E8029E7A8", Offset = "0x0", VA = "0x731B7100029E7A8", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29E7F88029E7B0", Offset = "0x0", VA = "0x29E7FA0029E7B0", Slot = "1")]
	void LNBMDOJAMGL(string BEMAPDNKPAD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29E7FE8731AD14", Offset = "0x0", VA = "0x29E8000731AD14", Slot = "2")]
	void JHABPKKIPBF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x731E90E8029E82A", Offset = "0x0", VA = "0x731E9100029E82A", Slot = "3")]
	void BIAEOJAMGMN(string GOJKMEMCPDE);
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
