using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LJJNDAKCKFN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x232A39892F96A8", Offset = "0x0", VA = "0x232A3B092F96A8", Slot = "0")]
	void CLFELIEFDPO(object BNIILMIMBGO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x92F96B680232A41", Offset = "0x0", VA = "0x92F96B800232A41", Slot = "1")]
	void AIKBOFNDFKH(object BNIILMIMBGO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x232A9080232A41", Offset = "0x0", VA = "0x232A9200232A41", Slot = "2")]
	void MBLBKGHLOBI(object BNIILMIMBGO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x232A9E892F96A8", Offset = "0x0", VA = "0x232AA0092F96A8", Slot = "3")]
	void CPOEIPGBNCJ(object GMIADHJEACD, string NFCLHEIIJBK, params object[] BONEGMDLPMG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x921107680232AC5", Offset = "0x0", VA = "0x921107800232AC5", Slot = "4")]
	void CHIKOFMCJKA(Exception KDJDOHNLPMP);
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
