using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DNHLKDIIFLB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA194BE680281050", Offset = "0x0", VA = "0xA194BE800281050", Slot = "0")]
	void EMMOGPNJFNP(object CAJBNIGHKAB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28107E80281050", Offset = "0x0", VA = "0x28108000281050", Slot = "1")]
	void ILJECICKHMM(object CAJBNIGHKAB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28107E8A194BE8", Offset = "0x0", VA = "0x2810800A194BE8", Slot = "2")]
	void JNGKCIFJIFE(object CAJBNIGHKAB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA193582802810A6", Offset = "0x0", VA = "0xA193584002810A6", Slot = "3")]
	void DGOLPFPAMHG(object FFHIJMOJNAI, string JFOBPJMAIKI, params object[] NENLABMEOHA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2810EC802810B0", Offset = "0x0", VA = "0x2810EE002810B0", Slot = "4")]
	void HPLOLMMJCNB(Exception MKGEIKBIPFF);
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
