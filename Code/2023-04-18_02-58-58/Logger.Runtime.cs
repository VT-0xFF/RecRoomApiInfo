using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KKMCCLAPGLL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x25B3B58025B390", Offset = "0x0", VA = "0x25B3B70025B390", Slot = "0")]
	void FPNMONCCAAE(object AHADDDAMGKE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x25B3B588017414", Offset = "0x0", VA = "0x25B3B708017414", Slot = "1")]
	void NEGCNMACIEM(object AHADDDAMGKE);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x80F69228025B462", Offset = "0x0", VA = "0x80F69240025B462", Slot = "2")]
	void GGALHNMLAOJ(object AHADDDAMGKE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x25B4A98025B462", Offset = "0x0", VA = "0x25B4AB0025B462", Slot = "3")]
	void CMPCOMBEJIE(object DELCOFCGDFF, string JOALLMOAENA, params object[] ADCFFAJGNAM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25B4A9880F6944", Offset = "0x0", VA = "0x25B4AB080F6944", Slot = "4")]
	void OFMBMMPONGK(Exception CLOCKLEHOOP);
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
