using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HLJCFCHLOHC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA42231A802801AE", Offset = "0x0", VA = "0xA42231C002801AE", Slot = "0")]
	void IOIJAALEDGI(object IGMINGONOGN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2801FD802801AE", Offset = "0x0", VA = "0x2801FF002801AE", Slot = "1")]
	void EALPDDBBHPM(object IGMINGONOGN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2801FD8A422338", Offset = "0x0", VA = "0x2801FF0A422338", Slot = "2")]
	void PAHNJPDDDAB(object IGMINGONOGN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA42234680280205", Offset = "0x0", VA = "0xA42234800280205", Slot = "3")]
	void LLLEMOBDGHB(object NGDLPEOFMHL, string HCFPFEPBAJC, params object[] OHIOFOHNMPI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28025480280205", Offset = "0x0", VA = "0x28025600280205", Slot = "4")]
	void DALJONHLFMH(Exception EHPDFDGNBIH);
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
