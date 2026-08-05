using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface FOHHKPJKGLI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x250B82898DB1C0", Offset = "0x0", VA = "0x250B84098DB1C0", Slot = "0")]
	void OEJDKKHBHHB(object LEDKGOEDJCM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9AD4C3280250C13", Offset = "0x0", VA = "0x9AD4C3400250C13", Slot = "1")]
	void NIADEBEBBJK(object LEDKGOEDJCM);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x250C6280250C13", Offset = "0x0", VA = "0x250C6400250C13", Slot = "2")]
	void GIAKCKJJMPA(object LEDKGOEDJCM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x250C6289AD4C50", Offset = "0x0", VA = "0x250C6409AD4C50", Slot = "3")]
	void CCFAOHNDJOL(object EJDIFPAIGMC, string FFCCHAGPLED, params object[] GOFCIAANDLN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9AD4C5E80250C6A", Offset = "0x0", VA = "0x9AD4C6000250C6A", Slot = "4")]
	void KHNNEHINOKH(Exception AGDNDCIGOME);
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
