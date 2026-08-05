using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct HJKBMLPHDOC<TMNode>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly global::DKJLBCAIGHC<TMNode> MPNOKNKHOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public global::BCIODEDGGAO<TMNode> HHNMFKLFONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public global::KCPBJCLCDKE<TMNode, global::DKJLBCAIGHC<TMNode>> MINIKDOMMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public global::KCPBJCLCDKE<TMNode, global::KEHILDLDDPM<global::DKJLBCAIGHC<TMNode>>> MLJAFDCPLNK;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DFIABDCMIPN
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22FD550", Offset = "0x22FBD50", VA = "0x1822FD550")]
	public static void FOAPFFHPHEB<TMNode>(this ref global::HJKBMLPHDOC<TMNode> DCJNPPINKOA)
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
