using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct LJMEOCHAACA<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly global::MKGFFLLANNG<TMNode> BACEBAMLPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public global::JJPDAGGNHHD<TMNode> PKFEDMJJLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public global::JLEIJOEKPCK<TMNode, global::MKGFFLLANNG<TMNode>> DOOCCGCNAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public global::JLEIJOEKPCK<TMNode, global::MJOBBPGFLAB<global::MKGFFLLANNG<TMNode>>> MKGCJNINDKA;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EOKCMPIBONC
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2F28E20", Offset = "0x2F28220", VA = "0x182F28E20")]
	public static void FBEHGKKMCPK<TMNode>(this ref global::LJMEOCHAACA<TMNode> COBPFFJEBON)
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
