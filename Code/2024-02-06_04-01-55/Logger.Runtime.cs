using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HDDNBKOPHMD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x96BE10680244CFA", Offset = "0x0", VA = "0x96BE10800244CFA", Slot = "0")]
	void JBOJMAMBIHB(object ECHPFBNKINH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x244CFE80244CFA", Offset = "0x0", VA = "0x244D0000244CFA", Slot = "1")]
	void EGINKGMICPI(object ECHPFBNKINH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x244CFE896BE118", Offset = "0x0", VA = "0x244D00096BE118", Slot = "2")]
	void DBMJNCFFPFH(object ECHPFBNKINH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x96BE10680244D51", Offset = "0x0", VA = "0x96BE10800244D51", Slot = "3")]
	void IKPAAEGMPOJ(object HFPPGLCONIA, string BBJFPPIECOB, params object[] EALPNGKPAMO);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x244D8380244D60", Offset = "0x0", VA = "0x244D8500244D60", Slot = "4")]
	void KNJLAGOCLPH(Exception GJJHDBIJOMA);
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
