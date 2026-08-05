using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface GBEHEHLFCID
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x89A4562802E7991", Offset = "0x0", VA = "0x89A4564002E7991", Slot = "0")]
	void JGIMFEIAGIB(object HGFFDKCANPF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2E79FE802E79A0", Offset = "0x0", VA = "0x2E7A00002E79A0", Slot = "1")]
	void JCHGICOJJJL(object HGFFDKCANPF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E79FE889A0A24", Offset = "0x0", VA = "0x2E7A00089A0A24", Slot = "2")]
	void NJNHBMLMKAJ(object HGFFDKCANPF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x89A0A22802E7A5E", Offset = "0x0", VA = "0x89A0A24002E7A5E", Slot = "3")]
	void NGKNPHODJIH(object JFDMKPDIBDL, string JIHLEMBEPHC, params object[] PFFFGKKOEPM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E7ABC802E7A60", Offset = "0x0", VA = "0x2E7ABE002E7A60", Slot = "4")]
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
