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
		[Cpp2IlInjected.Address(RVA = "0x746D7B28029FC61", Offset = "0x0", VA = "0x746D7B40029FC61", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29FCA88029FC61", Offset = "0x0", VA = "0x29FCAA0029FC61", Slot = "1")]
	void LNBMDOJAMGL(string BEMAPDNKPAD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29FCAE8746D7A4", Offset = "0x0", VA = "0x29FCB00746D7A4", Slot = "2")]
	void JHABPKKIPBF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74699EE8029FCD9", Offset = "0x0", VA = "0x74699F00029FCD9", Slot = "3")]
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
