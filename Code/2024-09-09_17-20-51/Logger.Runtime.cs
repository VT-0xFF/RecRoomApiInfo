using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface HIMJLHGHAJA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28EB258028EB21", Offset = "0x0", VA = "0x28EB270028EB21", Slot = "0")]
	void LHPAJEFICIG(object FEMNEHJOJBN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28EB258A71D854", Offset = "0x0", VA = "0x28EB270A71D854", Slot = "1")]
	void PDOGJLIGNAD(object FEMNEHJOJBN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA71D8428028EB78", Offset = "0x0", VA = "0xA71D8440028EB78", Slot = "2")]
	void EFALNILAKLE(object FEMNEHJOJBN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28EBA38028EB80", Offset = "0x0", VA = "0x28EBA50028EB80", Slot = "3")]
	void GHJGNLNEDGA(object MPOBGCPIOEI, string EPLBBPBANLK, params object[] BBLLNFBCDFH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28EBA38A4F7644", Offset = "0x0", VA = "0x28EBA50A4F7644", Slot = "4")]
	void KNIODBNLABE(Exception DGKPIJKBMCH);
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
