using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PKAMEBFLEIB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28149280281470", Offset = "0x0", VA = "0x28149400281470", Slot = "0")]
	void EPOKKHIFOPJ(object APPJEAMJBHK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2814928A26DA70", Offset = "0x0", VA = "0x2814940A26DA70", Slot = "1")]
	void HICDPOFEGEG(object APPJEAMJBHK);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA48189E8028153B", Offset = "0x0", VA = "0xA4818A00028153B", Slot = "2")]
	void OJDCNMADBEJ(object APPJEAMJBHK);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28158A8028153B", Offset = "0x0", VA = "0x28158C0028153B", Slot = "3")]
	void EILGKAGNEAP(object CAMDIODFJJE, string MLEOMJOOIIP, params object[] CNKOAIGMGCF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28158A8A4818BC", Offset = "0x0", VA = "0x28158C0A4818BC", Slot = "4")]
	void POIKPBNGBLA(Exception EHGELFGIEBE);
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
