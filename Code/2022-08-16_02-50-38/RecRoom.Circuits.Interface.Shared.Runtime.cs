using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ONMHINOFGNA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LMHIKADCFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x77C4B46800960B4", Offset = "0x0", VA = "0x77C4B48000960B4", Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x960FC800960B4", Offset = "0x0", VA = "0x960FE000960B4", Slot = "1")]
	void FBFPGDIHEJL(string AMDKCMALAFD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x960FE877C4B5C", Offset = "0x0", VA = "0x96100077C4B5C", Slot = "2")]
	void MGGCJPPOJIN();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x772646A80096112", Offset = "0x0", VA = "0x772646C00096112", Slot = "3")]
	void PCFCKFGIIOI(string EHGGIAFACBG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9619080096112", Offset = "0x0", VA = "0x9619200096112", Slot = "4")]
	string EIKIBNAHMAI(object HLJJNKOAONN);
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
