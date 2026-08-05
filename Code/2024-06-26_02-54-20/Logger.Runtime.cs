using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DNHLKDIIFLB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA36C9E68027D9F3", Offset = "0x0", VA = "0xA36C9E80027D9F3", Slot = "0")]
	void EMMOGPNJFNP(object CAJBNIGHKAB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27DA428027D9F3", Offset = "0x0", VA = "0x27DA440027D9F3", Slot = "1")]
	void ILJECICKHMM(object CAJBNIGHKAB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27DA4E8A36C9D8", Offset = "0x0", VA = "0x27DA500A36C9D8", Slot = "2")]
	void JNGKCIFJIFE(object CAJBNIGHKAB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xA3086128027DA75", Offset = "0x0", VA = "0xA3086140027DA75", Slot = "3")]
	void DGOLPFPAMHG(object FFHIJMOJNAI, string JFOBPJMAIKI, params object[] NENLABMEOHA);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27DB2C8027DA75", Offset = "0x0", VA = "0x27DB2E0027DA75", Slot = "4")]
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
