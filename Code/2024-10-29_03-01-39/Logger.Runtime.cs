using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NAAEIEAKGMH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A2685802A2600", Offset = "0x0", VA = "0x2A2687002A2600", Slot = "0")]
	void CDMGIBILAAG(object IKKEHAGICFD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A268E8A871390", Offset = "0x0", VA = "0x2A26900A871390", Slot = "1")]
	void MGJHGMJFFKH(object IKKEHAGICFD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA8734E6802A271F", Offset = "0x0", VA = "0xA8734E8002A271F", Slot = "2")]
	void EPFFODEJOHA(object IKKEHAGICFD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A27A5802A2720", Offset = "0x0", VA = "0x2A27A7002A2720", Slot = "3")]
	void OHJGDAIFDOD(object NDMMIOJEOEB, string PKNNBLNOLJP, params object[] NABJMDALPIF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A27AE8A871390", Offset = "0x0", VA = "0x2A27B00A871390", Slot = "4")]
	void NKBFOPNCLDG(Exception MGAOLPCHOAD);
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
