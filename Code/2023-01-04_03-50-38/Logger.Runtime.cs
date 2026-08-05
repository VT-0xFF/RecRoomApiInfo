using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MHANHPGIMOL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A7AAE875EAFA0", Offset = "0x0", VA = "0x2A7AB0075EAFA0", Slot = "0")]
	void MFIHEHOKFNE(object HCDIHNPPHMM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x75EC072802A7B41", Offset = "0x0", VA = "0x75EC074002A7B41", Slot = "1")]
	void OCONKDLKCCJ(object HCDIHNPPHMM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BA0802A7B50", Offset = "0x0", VA = "0x2A7BA2002A7B50", Slot = "2")]
	void HPDOPNHAGJK(object HCDIHNPPHMM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BAE875EAFA8", Offset = "0x0", VA = "0x2A7BB0075EAFA8", Slot = "3")]
	void BDNIFMGOJBJ(object GKMHGIGLKCO, string AAKPIPNIBLA, params object[] MMLIFJCNOMF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75EAF9E802A7BCB", Offset = "0x0", VA = "0x75EAFA0002A7BCB", Slot = "4")]
	void MLINMNLHNFK(Exception GHBHEEBHPAJ);
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
