using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LGEEKGPBOIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1A61F08797B2F4", Offset = "0x0", VA = "0x1A61F20797B2F4", Slot = "0")]
	void GMHBDKJBFAD(object APOHKGBDLNO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7A260BA801A629D", Offset = "0x0", VA = "0x7A260BC001A629D", Slot = "1")]
	void NOKOMCDCFOA(object APOHKGBDLNO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1A62CC801A629D", Offset = "0x0", VA = "0x1A62CE001A629D", Slot = "2")]
	void HFFDOINNMCO(object APOHKGBDLNO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1A62CC87A260DC", Offset = "0x0", VA = "0x1A62CE07A260DC", Slot = "3")]
	void HIOJIOGOJEI(object ALLCABKLNNG, string OLJIOOJOBPJ, params object[] MIOMNNIBEOC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A260EA801A62D4", Offset = "0x0", VA = "0x7A260EC001A62D4", Slot = "4")]
	void IIHLKHDGKJI(Exception JFBJHLPOEBH);
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
