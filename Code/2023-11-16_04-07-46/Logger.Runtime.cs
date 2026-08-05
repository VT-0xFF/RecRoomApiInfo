using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PKBIFGBFCCE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2315C280231525", Offset = "0x0", VA = "0x2315C400231525", Slot = "0")]
	void PAOJJBFOCDP(object DJHKLFMABMI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2315C2892FAF58", Offset = "0x0", VA = "0x2315C4092FAF58", Slot = "1")]
	void EAJNPLMIEOD(object DJHKLFMABMI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x92FAF7280231615", Offset = "0x0", VA = "0x92FAF7400231615", Slot = "2")]
	void HPIHPDBEJLD(object DJHKLFMABMI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23161980231615", Offset = "0x0", VA = "0x23161B00231615", Slot = "3")]
	void FNDENJBKFDN(object ACJODAOHIHK, string DBCIFBLNDEG, params object[] IEECDEJOFJP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x231619892FAF84", Offset = "0x0", VA = "0x23161B092FAF84", Slot = "4")]
	void OEDHDJAHCAN(Exception KOOFLIKCDNB);
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
