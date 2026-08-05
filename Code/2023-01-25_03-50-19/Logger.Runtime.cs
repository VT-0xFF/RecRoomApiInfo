using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface LAFFFFNKAJK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2AC846802AC842", Offset = "0x0", VA = "0x2AC848002AC842", Slot = "0")]
	void DHDJNBLMDNC(object KKLHLPEDHHE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2AC84E877CD974", Offset = "0x0", VA = "0x2AC850077CD974", Slot = "1")]
	void NPKICGACDMN(object KKLHLPEDHHE);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x77CD556802AC872", Offset = "0x0", VA = "0x77CD558002AC872", Slot = "2")]
	void NIBCFDKIMOM(object KKLHLPEDHHE);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2AC91E802AC872", Offset = "0x0", VA = "0x2AC920002AC872", Slot = "3")]
	void BCOMNACIDGH(object KPJEGNGKPOH, string IBDOHFFALAD, params object[] IJPNBHGIPKF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2AC91E877CDAF4", Offset = "0x0", VA = "0x2AC920077CDAF4", Slot = "4")]
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
