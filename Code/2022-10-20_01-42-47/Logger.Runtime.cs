using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FMAODHFOLMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x29E5FA8029E5BD", Offset = "0x0", VA = "0x29E5FC0029E5BD", Slot = "0")]
	void PNAJNCEFIKC(object LEOCGNJBNFD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29E5FA87456E1C", Offset = "0x0", VA = "0x29E5FC07456E1C", Slot = "1")]
	void LPHGJHOGKAA(object LEOCGNJBNFD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7456E2E8029E603", Offset = "0x0", VA = "0x7456E300029E603", Slot = "2")]
	void BIAEOJAMGMN(object LEOCGNJBNFD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29E6D48029E620", Offset = "0x0", VA = "0x29E6D60029E620", Slot = "3")]
	void GALEKFIIBPH(object NAHJDDBGMOA, string DDGOGNPOMJE, params object[] KMLLOCJHKPB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x29E6DE8731AEB0", Offset = "0x0", VA = "0x29E6E00731AEB0", Slot = "4")]
	void HEEDEAIKGOP(Exception AAGNMLCAPCC);
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
