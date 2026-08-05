using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PLABCCAFOIB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2DFEFA802DFED0", Offset = "0x0", VA = "0x2DFEFC002DFED0", Slot = "0")]
	void KIMAHGDPAHN(object DPMCBMJDHJK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2DFEFE88335760", Offset = "0x0", VA = "0x2DFF0008335760", Slot = "1")]
	void NLNKJBHAOPL(object DPMCBMJDHJK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8335766802DFF47", Offset = "0x0", VA = "0x8335768002DFF47", Slot = "2")]
	void HNGFIMPFPEH(object DPMCBMJDHJK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2DFFC2802DFF50", Offset = "0x0", VA = "0x2DFFC4002DFF50", Slot = "3")]
	void GBOCGFNOFIA(object BKJKDPLKCNE, string MPHFMCGDKAK, params object[] LIKLGHJBPPH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2DFFCE883386B8", Offset = "0x0", VA = "0x2DFFD0083386B8", Slot = "4")]
	void ILGEHOKOJKB(Exception PLMJFOAHKNM);
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
