using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MBKGHNEMCHF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2991FF8A96D914", Offset = "0x0", VA = "0x2992010A96D914", Slot = "0")]
	void JEHEHFEFLHD(object OLIMOPFMMIB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA96D90280299252", Offset = "0x0", VA = "0xA96D90400299252", Slot = "1")]
	void BJDGFHEJEDA(object OLIMOPFMMIB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29928380299260", Offset = "0x0", VA = "0x29928500299260", Slot = "2")]
	void DGGLCCHCDIG(object OLIMOPFMMIB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2992838A73942C", Offset = "0x0", VA = "0x2992850A73942C", Slot = "3")]
	void KMHKNHPBJKC(object EPLPPJHJIIM, string BEMIADMLHDO, params object[] KCHFAPGLICB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA96C5E680299348", Offset = "0x0", VA = "0xA96C5E800299348", Slot = "4")]
	void APBIIKEIEAI(Exception NNGGPGOOBAL);
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
