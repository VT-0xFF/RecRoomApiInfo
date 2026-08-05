using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct ADMGOMCHOAC<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly global::HAFOMODBANL<TMNode> OFLAGOLGPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public global::IBHLJJIMPLO<TMNode> OENPHKHMPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public global::MKCHHHPNMHD<TMNode, global::HAFOMODBANL<TMNode>> JAGJOAIDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public global::MKCHHHPNMHD<TMNode, global::EPNDIEBEBHF<global::HAFOMODBANL<TMNode>>> OAIKOAKHGFO;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LGIPNCHCILJ
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36CD6B0", Offset = "0x36CC4B0", VA = "0x1836CD6B0")]
	public static void KGNKLNCMPDI<TMNode>(ref global::ADMGOMCHOAC<TMNode> BLHHJNENDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x33CEC20", Offset = "0x33CDA20", VA = "0x1833CEC20")]
	public static global::IIJDBLNGLFL<global::HAFOMODBANL<TMNode>, NEKKIIHPMHL> IKIPAPDPEOO<TMNode>(in global::ADMGOMCHOAC<TMNode> BLHHJNENDMO)
	{
		return default(global::IIJDBLNGLFL<global::HAFOMODBANL<TMNode>, NEKKIIHPMHL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PEEPPDLHDAO<TMNode>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public global::ADMGOMCHOAC<TMNode> JKMNDMKDPNL;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GGAHCCFAHID
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x33BAC90", Offset = "0x33B9A90", VA = "0x1833BAC90")]
	public static void KGNKLNCMPDI<TMNode>(ref global::PEEPPDLHDAO<TMNode> BLHHJNENDMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x33CEC20", Offset = "0x33CDA20", VA = "0x1833CEC20")]
	public static global::IIJDBLNGLFL<global::HAFOMODBANL<TMNode>, NEKKIIHPMHL> IKIPAPDPEOO<TMNode>(in global::PEEPPDLHDAO<TMNode> BLHHJNENDMO)
	{
		return default(global::IIJDBLNGLFL<global::HAFOMODBANL<TMNode>, NEKKIIHPMHL>);
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
