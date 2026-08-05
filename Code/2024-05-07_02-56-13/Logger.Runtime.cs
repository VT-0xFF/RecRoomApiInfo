using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IAFPOFNODCF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x98A818A80250612", Offset = "0x0", VA = "0x98A818C00250612", Slot = "0")]
	void PHDBFKGPBFI(object OMJOPGOBIEL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x25069F80250620", Offset = "0x0", VA = "0x2506A100250620", Slot = "1")]
	void CLKMIIOMMCL(object OMJOPGOBIEL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2506AE898A3BEC", Offset = "0x0", VA = "0x2506B0098A3BEC", Slot = "2")]
	void ENCMOPKOEPF(object OMJOPGOBIEL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x98A5C0E802506E0", Offset = "0x0", VA = "0x98A5C10002506E0", Slot = "3")]
	void DBPBNKLKNEO(object KAEEGPAIBEC, string IHFDBLMLKMD, params object[] JPEJCADBOCG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25070E802506E0", Offset = "0x0", VA = "0x250710002506E0", Slot = "4")]
	void HEHPIJGHGHP(Exception PFDFCFFEKPJ);
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
