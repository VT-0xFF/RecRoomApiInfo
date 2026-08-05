using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BFMKNBFAFDD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FEKLNACIDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1A6303801A62D4", Offset = "0x0", VA = "0x1A6305001A62D4", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1A630E87A260DC", Offset = "0x0", VA = "0x1A631007A260DC", Slot = "1")]
	void JGDNMPGJAKI(string JNAACNJBHOF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x796B046801A634D", Offset = "0x0", VA = "0x796B048001A634D", Slot = "2")]
	void OKMOCACJPKP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1A63E4801A634D", Offset = "0x0", VA = "0x1A63E6001A634D", Slot = "3")]
	void HFFDOINNMCO(string MEKFJFMIPGK);
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
