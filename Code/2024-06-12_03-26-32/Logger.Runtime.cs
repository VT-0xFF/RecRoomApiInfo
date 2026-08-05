using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PDINJOMHAFF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x278A2D80278A29", Offset = "0x0", VA = "0x278A2F00278A29", Slot = "0")]
	void LCOFNOOCLJC(object MIIBHDDJGII);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x278A2D8A398E0C", Offset = "0x0", VA = "0x278A2F0A398E0C", Slot = "1")]
	void HIHBJDNLPLH(object MIIBHDDJGII);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA398DFA80278A80", Offset = "0x0", VA = "0xA398DFC00278A80", Slot = "2")]
	void OOAGCEDPLHB(object MIIBHDDJGII);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x278AA580278A80", Offset = "0x0", VA = "0x278AA700278A80", Slot = "3")]
	void GLLDBFGOMPL(object FBMKGECLCCA, string KKEJAEKDBIN, params object[] LLJCEPGKLEC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x278AA58A33D6A4", Offset = "0x0", VA = "0x278AA70A33D6A4", Slot = "4")]
	void DPJEFLLPANG(Exception JCLKODFKPHM);
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
