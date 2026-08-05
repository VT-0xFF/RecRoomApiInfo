using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AEDFEFNOPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x76B4A5A802333BA", Offset = "0x0", VA = "0x76B4A5C002333BA", Slot = "0")]
	void PDPFIKDJEEE(object ENHDLHMFJLO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x233401802333BA", Offset = "0x0", VA = "0x233403002333BA", Slot = "1")]
	void KJCHNLNNEGI(object ENHDLHMFJLO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23340E876B4A4C", Offset = "0x0", VA = "0x233410076B4A4C", Slot = "2")]
	void MPANPDAFJHI(object ENHDLHMFJLO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7629F7A80233437", Offset = "0x0", VA = "0x7629F7C00233437", Slot = "3")]
	void GKLPEBLJNFC(object ABFHDOGCMDC, string JBNHONFGMON, params object[] GBGLLILEMPG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2334E980233437", Offset = "0x0", VA = "0x2334EB00233437", Slot = "4")]
	void DPCIPOMPCFF(Exception BCAGFKLFAML);
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
