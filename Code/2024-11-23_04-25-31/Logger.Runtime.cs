using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MKDIGONPDGF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA9C68EE802A3F01", Offset = "0x0", VA = "0xA9C68F0002A3F01", Slot = "0")]
	void PMAPEFGPDFK(object DAKGLLFOGCM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F05802A3F01", Offset = "0x0", VA = "0x2A3F07002A3F01", Slot = "1")]
	void FPNMEKEIIAD(object DAKGLLFOGCM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F058A9C6900", Offset = "0x0", VA = "0x2A3F070A9C6900", Slot = "2")]
	void DKAOGHLAPOM(object DAKGLLFOGCM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA9C68EE802A3F58", Offset = "0x0", VA = "0xA9C68F0002A3F58", Slot = "3")]
	void HCFAIDLBANB(object KMDNOIPDFGB, string ICABLEDECHB, params object[] LPLPEHNKFMM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F83802A3F60", Offset = "0x0", VA = "0x2A3F85002A3F60", Slot = "4")]
	void APNNNHFDEBM(Exception HMCKAKHHODE);
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
