using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EMOKLDEAGDL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28BE1E88DFCA54", Offset = "0x0", VA = "0x28BE2008DFCA54", Slot = "0")]
	void BKMKBHBEAIO(object NJCJMLIIBBO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8DF9BFE8028BE49", Offset = "0x0", VA = "0x8DF9C000028BE49", Slot = "1")]
	void HNOGLIEFHGI(object NJCJMLIIBBO);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28BF038028BE49", Offset = "0x0", VA = "0x28BF050028BE49", Slot = "2")]
	void KLCOOAGHEOI(object NJCJMLIIBBO);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28BF0388DFE560", Offset = "0x0", VA = "0x28BF0508DFE560", Slot = "3")]
	void APGCKKDOCAD(object JHAKINLMMJL, string OKEJGKEKJIO, params object[] GDDHAFPALIL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8DFE57E8028BF4E", Offset = "0x0", VA = "0x8DFE5800028BF4E", Slot = "4")]
	void KNGKPMNNBEF(Exception NFOPOEMEOGJ);
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
