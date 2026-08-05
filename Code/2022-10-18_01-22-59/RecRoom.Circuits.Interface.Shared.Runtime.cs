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
		[Cpp2IlInjected.Address(RVA = "0x29D4D78029D470", Offset = "0x0", VA = "0x29D4D90029D470", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29D4DE8731BD9C", Offset = "0x0", VA = "0x29D4E00731BD9C", Slot = "1")]
	void LNBMDOJAMGL(string BEMAPDNKPAD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x731AD228029D571", Offset = "0x0", VA = "0x731AD240029D571", Slot = "2")]
	void JHABPKKIPBF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29D5F68029D580", Offset = "0x0", VA = "0x29D5F80029D580", Slot = "3")]
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
