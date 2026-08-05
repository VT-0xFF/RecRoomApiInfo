using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DJDPNNJEBNN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27D6CE8A139970", Offset = "0x0", VA = "0x27D6D00A139970", Slot = "0")]
	void MGFMJHPPHBP(object KBNCOADBJAI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA13996E8027D759", Offset = "0x0", VA = "0xA1399700027D759", Slot = "1")]
	void IIBMDNBEHCM(object KBNCOADBJAI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27D7F28027D760", Offset = "0x0", VA = "0x27D7F40027D760", Slot = "2")]
	void BMLAECFBIAL(object KBNCOADBJAI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27D7FE8A13A8C0", Offset = "0x0", VA = "0x27D8000A13A8C0", Slot = "3")]
	void PBGLCDGJOIN(object CNBJCJOALNK, string BGOCEECJDJL, params object[] FJCOFFFFCFE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA13996E8027D889", Offset = "0x0", VA = "0xA1399700027D889", Slot = "4")]
	void JOOIPPFNPKN(Exception NKAKJFGNGPN);
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
