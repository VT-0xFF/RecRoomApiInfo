using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FMAODHFOLMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x29D34E8731AD24", Offset = "0x0", VA = "0x29D3500731AD24", Slot = "0")]
	void PNAJNCEFIKC(object LEOCGNJBNFD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x731AD228029D3E1", Offset = "0x0", VA = "0x731AD240029D3E1", Slot = "1")]
	void LPHGJHOGKAA(object LEOCGNJBNFD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29D4408029D3F0", Offset = "0x0", VA = "0x29D4420029D3F0", Slot = "2")]
	void BIAEOJAMGMN(object LEOCGNJBNFD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29D44E87319C58", Offset = "0x0", VA = "0x29D45007319C58", Slot = "3")]
	void GALEKFIIBPH(object NAHJDDBGMOA, string DDGOGNPOMJE, params object[] KMLLOCJHKPB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7319C4E8029D46B", Offset = "0x0", VA = "0x7319C500029D46B", Slot = "4")]
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
