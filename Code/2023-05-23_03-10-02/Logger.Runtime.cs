using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IAFJNKBOOFK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9CE88A4B624", Offset = "0x0", VA = "0x2CF9D008A4B624", Slot = "0")]
	void OGCEGKIJJAP(object OLHOJKMAKNP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8A18B36802CFA37", Offset = "0x0", VA = "0x8A18B38002CFA37", Slot = "1")]
	void CCFJJJECMJE(object OLHOJKMAKNP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CFBA8802CFA40", Offset = "0x0", VA = "0x2CFBAA002CFA40", Slot = "2")]
	void ACMGBHDAFDO(object OLHOJKMAKNP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CFBAE8897A508", Offset = "0x0", VA = "0x2CFBB00897A508", Slot = "3")]
	void NHIPMNALDPH(object GEKPLLKAIKG, string EDBBNBBPEMJ, params object[] KBOOOAILJFG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x897A4F6802CFBCB", Offset = "0x0", VA = "0x897A4F8002CFBCB", Slot = "4")]
	void LPLAGMIJFFD(Exception MPCJJLOGAFH);
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
