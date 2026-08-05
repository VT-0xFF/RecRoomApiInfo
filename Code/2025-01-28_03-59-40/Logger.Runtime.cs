using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AMGPLCCFDEC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xADCC84E802C5164", Offset = "0x0", VA = "0xADCC850002C5164", Slot = "0")]
	void IKHOJNLBJOK(object MOKKIOIDAGN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2C51F7802C5170", Offset = "0x0", VA = "0x2C51F9002C5170", Slot = "1")]
	void AAENNJOABKH(object MOKKIOIDAGN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C51FE8ADC9210", Offset = "0x0", VA = "0x2C52000ADC9210", Slot = "2")]
	void NDLLJOKOENK(object MOKKIOIDAGN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xADCC84E802C5294", Offset = "0x0", VA = "0xADCC850002C5294", Slot = "3")]
	void PIGGAODIPFO(object GCGNIOHLIKK, string HNCNCHKHLCP, params object[] OKBEKNPNPIM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C5327802C52A0", Offset = "0x0", VA = "0x2C5329002C52A0", Slot = "4")]
	void HJLIGKLLEID(Exception PHEKEBLADHB);
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
