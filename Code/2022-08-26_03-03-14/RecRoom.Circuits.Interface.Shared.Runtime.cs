using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JMEMLBOCMKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KHFFNHNKJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x96ECE878739D0", Offset = "0x0", VA = "0x96ED0078739D0", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x77D583A80096EF5", Offset = "0x0", VA = "0x77D583C00096EF5", Slot = "1")]
	void KAGJJOBHIOC(string FHNLBBBEDLN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x96F3F80096F00", Offset = "0x0", VA = "0x96F4100096F00", Slot = "2")]
	void LHCBNBOMFDP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x96F3F87874318", Offset = "0x0", VA = "0x96F4107874318", Slot = "3")]
	void GAECHCABPCP(string CIJKLAFFGJI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x787432280096F81", Offset = "0x0", VA = "0x787432400096F81", Slot = "4")]
	string HGAPNLCIJKB(object EBMPLNBFAKM);
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
