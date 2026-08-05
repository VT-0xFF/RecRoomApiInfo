using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct DHIMMHPHHOI
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEE50", Offset = "0x7CAE050", VA = "0x187CAEE50")]
	public static DHIMMHPHHOI NEKLFDMHCNA(FODGIOKBGBI FHEIHFBIKLF)
	{
		return default(DHIMMHPHHOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEF30", Offset = "0x7CAE130", VA = "0x187CAEF30")]
	public DHIMMHPHHOI(FODGIOKBGBI FHEIHFBIKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEE70", Offset = "0x7CAE070", VA = "0x187CAEE70")]
	public void BFEGJAKAIFE([In] FixedString128Bytes AKCEGHPGLOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CPOBPBDHAOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CAEE50", Offset = "0x7CAE050", VA = "0x187CAEE50")]
	public static DHIMMHPHHOI MKMJANKJNMB(this FODGIOKBGBI FHEIHFBIKLF)
	{
		return default(DHIMMHPHHOI);
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
