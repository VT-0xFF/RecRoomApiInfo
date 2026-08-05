using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct EKPFILFIDBL<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly global::IOJDDMIHILI<TMNode> PKIJCICIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public global::BBCFELJPIFE<TMNode> OKMCPBJBNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public global::EHKBGJNIKOG<TMNode, global::IOJDDMIHILI<TMNode>> EMIBHNNCMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public global::EHKBGJNIKOG<TMNode, global::IHBDCAMGFOD<global::IOJDDMIHILI<TMNode>>> LILCAAEDFCG;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HJOFNCBILJG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35C8980", Offset = "0x35C7D80", VA = "0x1835C8980")]
	public static void ACJHDFNHANL<TMNode>(this ref global::EKPFILFIDBL<TMNode> PKCJMFFNILJ)
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
