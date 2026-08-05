using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KFLPEFKGGIK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24572E897804EC", Offset = "0x0", VA = "0x245730097804EC", Slot = "0")]
	void BHODMEFJDOG(object COBKBPPCGME);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x977F92A802457D6", Offset = "0x0", VA = "0x977F92C002457D6", Slot = "1")]
	void LFJPHHHDLOL(object COBKBPPCGME);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x245884802457E0", Offset = "0x0", VA = "0x245886002457E0", Slot = "2")]
	void EAPGJLNFPHM(object COBKBPPCGME);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24588E8977F92C", Offset = "0x0", VA = "0x2458900977F92C", Slot = "3")]
	void FPLEKLGJAKG(object HFFDKMJEBIA, string JMLJCJAAPJD, params object[] KFIENCBOEKJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x977F95A80245926", Offset = "0x0", VA = "0x977F95C00245926", Slot = "4")]
	void IKKICMNGMPF(Exception PGEDAMLBKMN);
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
