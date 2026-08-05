using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BPCJALHOJNN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2B95EE875DFB5C", Offset = "0x0", VA = "0x2B95F0075DFB5C", Slot = "0")]
	void AECLFKCPDDB(object LAEOPKAJMLP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x75DE7AA802B962B", Offset = "0x0", VA = "0x75DE7AC002B962B", Slot = "1")]
	void DFHNBOCCLJI(object LAEOPKAJMLP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B968C802B9630", Offset = "0x0", VA = "0x2B968E002B9630", Slot = "2")]
	void KKKEBBLEFHK(object LAEOPKAJMLP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2B968E875DFB70", Offset = "0x0", VA = "0x2B9690075DFB70", Slot = "3")]
	void OKKCEMPFMPC(object JOOJGLPIMBB, string EJMDFOAAMOF, params object[] HNGHLHHNPMK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75E457A802B9724", Offset = "0x0", VA = "0x75E457C002B9724", Slot = "4")]
	void LDNFKGKMJII(Exception OAIKBNOGBIL);
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
