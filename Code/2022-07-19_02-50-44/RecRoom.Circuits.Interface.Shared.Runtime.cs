using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PCOJAPHOKBB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LEKCIMLCADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x27B93E86FB91FC", Offset = "0x0", VA = "0x27B94006FB91FC", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F94E228027B9B8", Offset = "0x0", VA = "0x6F94E240027B9B8", Slot = "1")]
	void JIGMCPACHFM(string LDKPDNBIJND);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27B9E78027B9C0", Offset = "0x0", VA = "0x27B9E90027B9C0", Slot = "2")]
	void AOEGFALDIMM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27B9EE86F83EF4", Offset = "0x0", VA = "0x27B9F006F83EF4", Slot = "3")]
	void BMDFHCDDOIA(string EOGLFEOLNBK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8F428027BA5B", Offset = "0x0", VA = "0x6FB8F440027BA5B", Slot = "4")]
	string DFJJIKAIJEM(object OOJKHPLJJMJ);
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
