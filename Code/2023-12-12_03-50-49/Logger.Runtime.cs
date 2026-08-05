using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NALNLDCPMEL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22D9CE893244F8", Offset = "0x0", VA = "0x22D9D0093244F8", Slot = "0")]
	void OHIILDFJLAF(object KIDCMOJGGGC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x91919DE8022D9F5", Offset = "0x0", VA = "0x91919E00022D9F5", Slot = "1")]
	void FIIHLJDHGNP(object KIDCMOJGGGC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22DA928022D9F5", Offset = "0x0", VA = "0x22DA940022D9F5", Slot = "2")]
	void IBJBAMNMDMB(object KIDCMOJGGGC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22DA928932349C", Offset = "0x0", VA = "0x22DA940932349C", Slot = "3")]
	void MANBBNDFJMK(object LFDLOIPEDMO, string EGKKOGLPHIA, params object[] ILIHAHINKGC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x93234B68022DAE5", Offset = "0x0", VA = "0x93234B80022DAE5", Slot = "4")]
	void JAFEDJBJPDF(Exception KPBHHHEDHGG);
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
