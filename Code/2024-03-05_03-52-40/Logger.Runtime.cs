using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ABOHMLOCAHI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x96E8D3A80248BC8", Offset = "0x0", VA = "0x96E8D3C00248BC8", Slot = "0")]
	void INBEFCGIFMO(object KOLDIMNADKN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x248C0680248BD0", Offset = "0x0", VA = "0x248C0800248BD0", Slot = "1")]
	void CFDGHMJOMDN(object KOLDIMNADKN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x248C0E896E8D3C", Offset = "0x0", VA = "0x248C10096E8D3C", Slot = "2")]
	void OELCGMCOLOC(object KOLDIMNADKN);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x96E7A7E80248C36", Offset = "0x0", VA = "0x96E7A8000248C36", Slot = "3")]
	void CNIFKMEAFGP(object KMABAKEMFMI, string JNKFGFMNPLJ, params object[] LBACBNGIGEC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x248C6E80248C40", Offset = "0x0", VA = "0x248C7000248C40", Slot = "4")]
	void PKKPILHAEDM(Exception DDDLEJNOIIO);
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
