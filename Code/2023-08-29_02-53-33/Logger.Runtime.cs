using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface MLEHJAMOLIK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8A7CAEA80258515", Offset = "0x0", VA = "0x8A7CAEC00258515", Slot = "0")]
	void GEPKNBOCDIP(object FDJKGAAPBBG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x25855C80258515", Offset = "0x0", VA = "0x25855E00258515", Slot = "1")]
	void NGIFCHHLPBA(object FDJKGAAPBBG);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x25855C88A7CB0C", Offset = "0x0", VA = "0x25855E08A7CB0C", Slot = "2")]
	void CLEFMIEDHDP(object FDJKGAAPBBG);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8A7CB1A80258564", Offset = "0x0", VA = "0x8A7CB1C00258564", Slot = "3")]
	void OLGBPAJNAII(object JNNDIHFHMHC, string HJGELMEMICC, params object[] KLEPOOAJLPJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2585AB80258564", Offset = "0x0", VA = "0x2585AD00258564", Slot = "4")]
	void LNGEJEFAEBO(Exception BBMEKAJEEEN);
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
