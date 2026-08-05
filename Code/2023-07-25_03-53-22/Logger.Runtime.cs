using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HDBPBCNEHOA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8EB1F26802A0615", Offset = "0x0", VA = "0x8EB1F28002A0615", Slot = "0")]
	void AHJGPEGCGMK(object CGJPMMKJEHF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A0623802A0615", Offset = "0x0", VA = "0x2A0625002A0615", Slot = "1")]
	void LEANGBBHEHM(object CGJPMMKJEHF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A062E88EB1F38", Offset = "0x0", VA = "0x2A063008EB1F38", Slot = "2")]
	void PIMHGNBGAFO(object CGJPMMKJEHF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8D998E2802A0634", Offset = "0x0", VA = "0x8D998E4002A0634", Slot = "3")]
	void BFGFNLPJAKI(object AEOEKGNDHFM, string PEGDKDFABOG, params object[] CIIMHINGMLG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A0658802A0634", Offset = "0x0", VA = "0x2A065A002A0634", Slot = "4")]
	void KHGBCNJOLNO(Exception JDHMJBPJLEH);
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
