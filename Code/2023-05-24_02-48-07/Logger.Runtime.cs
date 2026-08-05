using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GBEHEHLFCID
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x89D3912802DCB1C", Offset = "0x0", VA = "0x89D3914002DCB1C", Slot = "0")]
	void JGIMFEIAGIB(object HGFFDKCANPF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2DCBD0802DCB20", Offset = "0x0", VA = "0x2DCBD2002DCB20", Slot = "1")]
	void JCHGICOJJJL(object HGFFDKCANPF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2DCBDE8898E054", Offset = "0x0", VA = "0x2DCBE00898E054", Slot = "2")]
	void NJNHBMLMKAJ(object HGFFDKCANPF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x897E56E802DCC18", Offset = "0x0", VA = "0x897E570002DCC18", Slot = "3")]
	void NGKNPHODJIH(object JFDMKPDIBDL, string JIHLEMBEPHC, params object[] PFFFGKKOEPM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2DCC62802DCC20", Offset = "0x0", VA = "0x2DCC64002DCC20", Slot = "4")]
	void FCDHDKBAJAE(Exception LNDIIAIJNMN);
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
