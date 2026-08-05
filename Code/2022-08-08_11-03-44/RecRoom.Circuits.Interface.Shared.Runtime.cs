using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface JJHOMKNJJAP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FHCMGLJECLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x95E3B80095C50", Offset = "0x0", VA = "0x95E3D00095C50", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x95E3E8774CF20", Offset = "0x0", VA = "0x95E400774CF20", Slot = "1")]
	void FCKCIJFEOAM(string MBHNCPMPIFB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x77D7CF680095E6F", Offset = "0x0", VA = "0x77D7CF800095E6F", Slot = "2")]
	void MGLNDOPKIPO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9603280095E6F", Offset = "0x0", VA = "0x9603400095E6F", Slot = "3")]
	void DLGIFPHPCHO(string LPDLECBMBMG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x96032877D7D00", Offset = "0x0", VA = "0x96034077D7D00", Slot = "4")]
	string AMCCCHDMEBL(object MDAEAKFNGDG);
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
