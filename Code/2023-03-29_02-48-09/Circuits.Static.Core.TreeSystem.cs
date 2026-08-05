using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct LJANLIHCNOO<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly global::BLDAKPIDCBI<TMNode> AOCBNAGMBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public global::OIFKKCKIJBG<TMNode> LILHAELABIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public global::GDCCAJMMFKP<TMNode, global::BLDAKPIDCBI<TMNode>> KFPCMBOLNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public global::GDCCAJMMFKP<TMNode, global::AEGIJMDEGMJ<global::BLDAKPIDCBI<TMNode>>> IAJCOJILOEF;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NFPJIAAEPGD
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x31585B0", Offset = "0x31573B0", VA = "0x1831585B0")]
	public static void ECKNMJDFBGK<TMNode>(this ref global::LJANLIHCNOO<TMNode> CNBAEMLJEBG)
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
