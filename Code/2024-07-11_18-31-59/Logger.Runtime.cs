using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DJDPNNJEBNN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27D1448027D0F5", Offset = "0x0", VA = "0x27D1460027D0F5", Slot = "0")]
	void MGFMJHPPHBP(object KBNCOADBJAI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27D14E8A32DF5C", Offset = "0x0", VA = "0x27D1500A32DF5C", Slot = "1")]
	void IIBMDNBEHCM(object KBNCOADBJAI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA2CA4FE8027D175", Offset = "0x0", VA = "0xA2CA5000027D175", Slot = "2")]
	void BMLAECFBIAL(object KBNCOADBJAI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27D2248027D175", Offset = "0x0", VA = "0x27D2260027D175", Slot = "3")]
	void PBGLCDGJOIN(object CNBJCJOALNK, string BGOCEECJDJL, params object[] FJCOFFFFCFE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27D2248A32EF00", Offset = "0x0", VA = "0x27D2260A32EF00", Slot = "4")]
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
