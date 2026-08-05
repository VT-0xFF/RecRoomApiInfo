using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KPBPBOKGNCF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x23D6E88023D699", Offset = "0x0", VA = "0x23D6EA0023D699", Slot = "0")]
	void FPLGBFAGNKF(object LHKCFFJGAEC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x23D6E889589984", Offset = "0x0", VA = "0x23D6EA09589984", Slot = "1")]
	void BOPLJJNBKAK(object LHKCFFJGAEC);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x95899928023D6F0", Offset = "0x0", VA = "0x95899940023D6F0", Slot = "2")]
	void OMAMCCOHKIB(object LHKCFFJGAEC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23D73F8023D6F0", Offset = "0x0", VA = "0x23D7410023D6F0", Slot = "3")]
	void HOBKELPMDDO(object BCCEHJNGNAL, string OIAIKKGGJAI, params object[] DJELKPGJPKM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23D74E89589984", Offset = "0x0", VA = "0x23D75009589984", Slot = "4")]
	void OEMHCFNLOBE(Exception OBECAPFMAJL);
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
