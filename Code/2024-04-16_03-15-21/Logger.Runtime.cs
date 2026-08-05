using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EHOGINAOANG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x244B7E899A1A00", Offset = "0x0", VA = "0x244B80099A1A00", Slot = "0")]
	void BNEKJNBCLOP(object AOBMECMACLL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x988C19A80244BA5", Offset = "0x0", VA = "0x988C19C00244BA5", Slot = "1")]
	void EBKECNHFPLF(object AOBMECMACLL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x244C4680244BA5", Offset = "0x0", VA = "0x244C4800244BA5", Slot = "2")]
	void KJNBPKKLDDE(object AOBMECMACLL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x244C46899A20C4", Offset = "0x0", VA = "0x244C48099A20C4", Slot = "3")]
	void NJOAGCDKGNP(object DPGBKIGAHAN, string NBHCKGNBPIL, params object[] FJIDAJDLPID);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x99A20DE80244C99", Offset = "0x0", VA = "0x99A20E000244C99", Slot = "4")]
	void FFMMJMJIEBE(Exception LNANIMJFAEO);
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
