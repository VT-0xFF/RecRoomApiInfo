using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DJDPNNJEBNN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27CE738027CE6F", Offset = "0x0", VA = "0x27CE750027CE6F", Slot = "0")]
	void MGFMJHPPHBP(object KBNCOADBJAI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27CE738A32D3EC", Offset = "0x0", VA = "0x27CE750A32D3EC", Slot = "1")]
	void IIBMDNBEHCM(object KBNCOADBJAI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA32D3DA8027CEC6", Offset = "0x0", VA = "0xA32D3DC0027CEC6", Slot = "2")]
	void BMLAECFBIAL(object KBNCOADBJAI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27CEF38027CED0", Offset = "0x0", VA = "0x27CEF50027CED0", Slot = "3")]
	void PBGLCDGJOIN(object CNBJCJOALNK, string BGOCEECJDJL, params object[] FJCOFFFFCFE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27CEF38A118D68", Offset = "0x0", VA = "0x27CEF50A118D68", Slot = "4")]
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
