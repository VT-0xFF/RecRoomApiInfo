using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct HPNFMEKDDKC<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly global::GJECEMGANGF<TMNode> CFDKBHBLDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public global::NOAFEGBKJNK<TMNode> NMFKIGBJLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public global::FNMHACEACIJ<TMNode, global::GJECEMGANGF<TMNode>> NNHCCDNOHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public global::FNMHACEACIJ<TMNode, global::DCOMKEJKBMO<global::GJECEMGANGF<TMNode>>> DLHGIFABMAA;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GFOFNJAJPDD
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2E70", Offset = "0x2DC1870", VA = "0x182DC2E70")]
	public static void NJKFKCNNMGK<TMNode>(this ref global::HPNFMEKDDKC<TMNode> DCIIOIKIJFP)
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
