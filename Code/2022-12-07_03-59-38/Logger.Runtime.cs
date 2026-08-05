using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PANKLONHMLA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A36BE875DC4F8", Offset = "0x0", VA = "0x2A36C0075DC4F8", Slot = "0")]
	void AJGKFIDACMM(object OIFMFCIPKIK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x75DC37A802A370B", Offset = "0x0", VA = "0x75DC37C002A370B", Slot = "1")]
	void KBMFMHAODFH(object OIFMFCIPKIK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A3759802A3710", Offset = "0x0", VA = "0x2A375B002A3710", Slot = "2")]
	void DJEAOKOFLJM(object OIFMFCIPKIK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A375E875DC37C", Offset = "0x0", VA = "0x2A3760075DC37C", Slot = "3")]
	void LMLDHCANECO(object MAMKOIKAADI, string MCFKLOJJFHI, params object[] JGHKPEFMHLD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75DC37A802A379E", Offset = "0x0", VA = "0x75DC37C002A379E", Slot = "4")]
	void LEDHDAHMEKA(Exception DMGGPOEOJGF);
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
