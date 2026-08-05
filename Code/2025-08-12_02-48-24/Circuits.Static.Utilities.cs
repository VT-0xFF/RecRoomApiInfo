using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class IIGEEALGHFM<TData> : BIIFFOGOHOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string OGPGDHDIMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData AIJFAAIOPNI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "7")]
	public override string JBIKIOHHBGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x52464D0", Offset = "0x5244AD0", VA = "0x1852464D0")]
	internal IIGEEALGHFM(string IFEHDCDCFPK, [In] TData DAJAOHIJHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CJPDCKHKLDE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B692F0", Offset = "0x2B678F0", VA = "0x182B692F0")]
	public static IIGEEALGHFM<GDCHOBJFCMN> BPFPEFLIIPC(string IFEHDCDCFPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B8A180", Offset = "0x3B88780", VA = "0x183B8A180")]
	public static IIGEEALGHFM<TData> BPFPEFLIIPC<TData>(string IFEHDCDCFPK, [In] TData DAJAOHIJHHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CIGHOHBCEAC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B86C20", Offset = "0x3B85220", VA = "0x183B86C20")]
	public static PKAAAAMEMEI<TOk, MMMFEDEBKPH> PHEPAAGJOCP<TOk>([In] this PKAAAAMEMEI<TOk, MMMFEDEBKPH> CCKLBDLJPNG, string IFEHDCDCFPK)
	{
		return default(PKAAAAMEMEI<TOk, MMMFEDEBKPH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BIIFFOGOHOI : LJOOEKCBACG, MMMFEDEBKPH, LCPFPNABOAN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B20D10", Offset = "0x2B1F310", VA = "0x182B20D10")]
	protected BIIFFOGOHOI()
	{
	}
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
