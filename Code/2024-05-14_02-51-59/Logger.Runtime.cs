using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KMDJJDLOPBI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x254FB280254F20", Offset = "0x0", VA = "0x254FB400254F20", Slot = "0")]
	void IGGHFJOIHIE(object EMEAPIGMNBK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x254FBE89A88F94", Offset = "0x0", VA = "0x254FC009A88F94", Slot = "1")]
	void OMHNDGPNFOI(object EMEAPIGMNBK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9A88F6280255060", Offset = "0x0", VA = "0x9A88F6400255060", Slot = "2")]
	void KNACHLPCOLG(object EMEAPIGMNBK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2550DF80255060", Offset = "0x0", VA = "0x2550E100255060", Slot = "3")]
	void PKEKEELAPOM(object JGGBEOJAHKH, string OPPPAIJEHEA, params object[] CADHKPGCKBL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2550EE89A85F64", Offset = "0x0", VA = "0x2550F009A85F64", Slot = "4")]
	void GDFHIPEJCHD(Exception KABNEKBCJNO);
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
