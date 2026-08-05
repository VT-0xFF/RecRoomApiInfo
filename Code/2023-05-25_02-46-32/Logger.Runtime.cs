using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GBEHEHLFCID
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2D01CE8898C348", Offset = "0x0", VA = "0x2D01D00898C348", Slot = "0")]
	void JGIMFEIAGIB(object HGFFDKCANPF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x898C346802D02A5", Offset = "0x0", VA = "0x898C348002D02A5", Slot = "1")]
	void JCHGICOJJJL(object HGFFDKCANPF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2D037F802D02B0", Offset = "0x0", VA = "0x2D0381002D02B0", Slot = "2")]
	void NJNHBMLMKAJ(object HGFFDKCANPF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2D038E8898C348", Offset = "0x0", VA = "0x2D03900898C348", Slot = "3")]
	void NGKNPHODJIH(object JFDMKPDIBDL, string JIHLEMBEPHC, params object[] PFFFGKKOEPM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x898C3DA802D0447", Offset = "0x0", VA = "0x898C3DC002D0447", Slot = "4")]
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
