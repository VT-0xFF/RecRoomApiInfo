using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JILCFFKJCFH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA4176CA8027F58D", Offset = "0x0", VA = "0xA4176CC0027F58D", Slot = "0")]
	void FFHOJNCMEGD(object CNCAEGCNGHI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27F5DC8027F58D", Offset = "0x0", VA = "0x27F5DE0027F58D", Slot = "1")]
	void JPNFBODDPJG(object CNCAEGCNGHI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27F5DE8A4176BC", Offset = "0x0", VA = "0x27F5E00A4176BC", Slot = "2")]
	void INDCCLFJMDJ(object CNCAEGCNGHI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA20FFEA8027F604", Offset = "0x0", VA = "0xA20FFEC0027F604", Slot = "3")]
	void FAGMKMAGPDA(object MGIHCPMKPNG, string GCFIDHFGDMF, params object[] HCHKMMKNKKB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27F6A98027F604", Offset = "0x0", VA = "0x27F6AB0027F604", Slot = "4")]
	void DADPKOPNCNH(Exception DDPOICLDNND);
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
