using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BPCJALHOJNN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A497D802A4840", Offset = "0x0", VA = "0x2A497F002A4840", Slot = "0")]
	void AECLFKCPDDB(object LAEOPKAJMLP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A497E8772F0AC", Offset = "0x0", VA = "0x2A49800772F0AC", Slot = "1")]
	void DFHNBOCCLJI(object LAEOPKAJMLP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75EC40E802A4A5E", Offset = "0x0", VA = "0x75EC410002A4A5E", Slot = "2")]
	void KKKEBBLEFHK(object LAEOPKAJMLP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B5D802A4A60", Offset = "0x0", VA = "0x2A4B5F002A4A60", Slot = "3")]
	void OKKCEMPFMPC(object JOOJGLPIMBB, string EJMDFOAAMOF, params object[] HNGHLHHNPMK);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B5E875E0940", Offset = "0x0", VA = "0x2A4B60075E0940", Slot = "4")]
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
