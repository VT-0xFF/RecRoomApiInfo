using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KGGDBHJFJJG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x29976E872BDCDC", Offset = "0x0", VA = "0x299770072BDCDC", Slot = "0")]
	void AMJBGJGBGPP(object MNIOACBCBNF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72BDCDA802997BB", Offset = "0x0", VA = "0x72BDCDC002997BB", Slot = "1")]
	void OOCNEJAIBBL(object MNIOACBCBNF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2997FC802997C0", Offset = "0x0", VA = "0x2997FE002997C0", Slot = "2")]
	void JIIPOKCPALK(object MNIOACBCBNF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2997FE872BDCDC", Offset = "0x0", VA = "0x299800072BDCDC", Slot = "3")]
	void KPLKPKGNMCA(object IGBOEABBEHO, string DKNGCKIKEID, params object[] GOLEKIJBOAN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72BDCDA8029984B", Offset = "0x0", VA = "0x72BDCDC0029984B", Slot = "4")]
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
