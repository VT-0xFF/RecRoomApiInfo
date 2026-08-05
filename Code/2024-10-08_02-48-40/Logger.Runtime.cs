using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PACHMFNGNKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x295B088A804BE8", Offset = "0x0", VA = "0x295B0A0A804BE8", Slot = "0")]
	void OBPAMGBPHCN(object ACKGBNDHEHM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA804C0280295B5B", Offset = "0x0", VA = "0xA804C0400295B5B", Slot = "1")]
	void PHDMNKNKIOJ(object ACKGBNDHEHM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x295B5F80295B5B", Offset = "0x0", VA = "0x295B6100295B5B", Slot = "2")]
	void DLPKEHPJALN(object ACKGBNDHEHM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x295B5F8A804C14", Offset = "0x0", VA = "0x295B610A804C14", Slot = "3")]
	void EEMKMAKDNEF(object GFIAFOEJCDD, string EAJPHFGLPOO, params object[] KLDEANCBDEG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA804C0280295BB2", Offset = "0x0", VA = "0xA804C0400295BB2", Slot = "4")]
	void JOMMAGOJOKG(Exception CPEKCGNCDLH);
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
