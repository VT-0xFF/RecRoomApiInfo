using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GEOGAPFJNJM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9C790B2802550F5", Offset = "0x0", VA = "0x9C790B4002550F5", Slot = "0")]
	void NMLCBHAJNOK(object AMPJEKFBOKH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x255194802550F5", Offset = "0x0", VA = "0x255196002550F5", Slot = "1")]
	void MMIGOPPAHNK(object AMPJEKFBOKH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x25519489D973A0", Offset = "0x0", VA = "0x25519609D973A0", Slot = "2")]
	void KAAOHBFMKKP(object AMPJEKFBOKH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9D973BA802551E7", Offset = "0x0", VA = "0x9D973BC002551E7", Slot = "3")]
	void HEHAAMCEFDP(object EOIJJPCMNGA, string IBEIMKOECHH, params object[] NEAMBEFDODM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2551EB802551E7", Offset = "0x0", VA = "0x2551ED002551E7", Slot = "4")]
	void KIAJAIFKOML(Exception CAHOMEFOOJF);
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
