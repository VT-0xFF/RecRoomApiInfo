using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct OAEAPLOIPMK<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly global::FGACGKAHALI<TMNode> AILGMEKJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public global::IDLGHEGKLJD<TMNode> EPEKNLDGFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public global::DHPHHFBLNKL<TMNode, global::FGACGKAHALI<TMNode>> HKFFKPMFCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public global::DHPHHFBLNKL<TMNode, global::GDPABKHNDLK<global::FGACGKAHALI<TMNode>>> ILLDNLANPEN;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NELDPKCEEPF
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3EC24F0", Offset = "0x3EC12F0", VA = "0x183EC24F0")]
	public static void DMKMELLNHHE<TMNode>(this ref global::OAEAPLOIPMK<TMNode> BIKHFKCJEPO)
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
