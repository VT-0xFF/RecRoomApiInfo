using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PEBGCLKOELH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22B2238022B200", Offset = "0x0", VA = "0x22B2250022B200", Slot = "0")]
	void NOCJPHOMELN(object KFIEDGIKACP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22B22388FF9DAC", Offset = "0x0", VA = "0x22B22508FF9DAC", Slot = "1")]
	void MDEODFKEEPD(object KFIEDGIKACP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x90E34A68022B2CE", Offset = "0x0", VA = "0x90E34A80022B2CE", Slot = "2")]
	void GDBKNPKOPNG(object KFIEDGIKACP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22B31D8022B2CE", Offset = "0x0", VA = "0x22B31F0022B2CE", Slot = "3")]
	void OEMEHDNGLAA(object FJNGJOFLBMD, string KDEPONGBNBL, params object[] CCBNPDAGICC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22B31D890E34C4", Offset = "0x0", VA = "0x22B31F090E34C4", Slot = "4")]
	void KIBAIBCDKCE(Exception LNOFJJLDMOF);
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
