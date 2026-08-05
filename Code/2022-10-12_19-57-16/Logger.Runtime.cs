using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KGGDBHJFJJG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72C6A4E8029D4AA", Offset = "0x0", VA = "0x72C6A500029D4AA", Slot = "0")]
	void AMJBGJGBGPP(object MNIOACBCBNF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29D4ED8029D4C0", Offset = "0x0", VA = "0x29D4EF0029D4C0", Slot = "1")]
	void OOCNEJAIBBL(object MNIOACBCBNF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29D4EE872BDCE0", Offset = "0x0", VA = "0x29D4F0072BDCE0", Slot = "2")]
	void JIIPOKCPALK(object MNIOACBCBNF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72C191A8029D60D", Offset = "0x0", VA = "0x72C191C0029D60D", Slot = "3")]
	void KPLKPKGNMCA(object IGBOEABBEHO, string DKNGCKIKEID, params object[] GOLEKIJBOAN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29D72B8029D610", Offset = "0x0", VA = "0x29D72D0029D610", Slot = "4")]
	void PMHALNGIHGF(Exception DDKLCKNLJIP);
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
