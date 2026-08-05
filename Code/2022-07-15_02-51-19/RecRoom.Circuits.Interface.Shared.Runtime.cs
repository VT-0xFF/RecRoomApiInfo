using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LHEAIGOLNFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DLMBNKFCNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F740EA80090194", Offset = "0x0", VA = "0x6F740EC00090194", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x901E9800901A0", Offset = "0x0", VA = "0x901EB000901A0", Slot = "1")]
	void KKDIOEODAIB(string IPJBPCNNBIO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x901EE86F740E0", Offset = "0x0", VA = "0x901F006F740E0", Slot = "2")]
	void KDGJMEAMPHF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x700FFCE8009023A", Offset = "0x0", VA = "0x700FFD00009023A", Slot = "3")]
	void FIGGOJMADBI(string ADIELDAOJPG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x903058009023A", Offset = "0x0", VA = "0x903070009023A", Slot = "4")]
	string BFDGAIDJAAK(object NHBCHHMAJOK);
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
