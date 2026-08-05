using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LAFFFFNKAJK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2C509E879B41B4", Offset = "0x0", VA = "0x2C50A0079B41B4", Slot = "0")]
	void DHDJNBLMDNC(object KKLHLPEDHHE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x79B41A6802C50F8", Offset = "0x0", VA = "0x79B41A8002C50F8", Slot = "1")]
	void NPKICGACDMN(object KKLHLPEDHHE);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C512D802C5100", Offset = "0x0", VA = "0x2C512F002C5100", Slot = "2")]
	void NIBCFDKIMOM(object KKLHLPEDHHE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C512E879B41B4", Offset = "0x0", VA = "0x2C5130079B41B4", Slot = "3")]
	void BCOMNACIDGH(object KPJEGNGKPOH, string IBDOHFFALAD, params object[] IJPNBHGIPKF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79B41B2802C517B", Offset = "0x0", VA = "0x79B41B4002C517B", Slot = "4")]
	void LAEJNLMKBEM(Exception BGAGBEAHOKL);
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
