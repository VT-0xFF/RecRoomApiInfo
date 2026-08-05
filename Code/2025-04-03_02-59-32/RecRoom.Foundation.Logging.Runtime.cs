using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct FENBAFDMGII
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x789BBC0", Offset = "0x789AFC0", VA = "0x18789BBC0")]
	public static FENBAFDMGII CLMIANKGGAM(GBHBOJAPDOA DPDKJPMBJOA)
	{
		return default(FENBAFDMGII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x789BBE0", Offset = "0x789AFE0", VA = "0x18789BBE0")]
	public FENBAFDMGII(GBHBOJAPDOA DPDKJPMBJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x789BB00", Offset = "0x789AF00", VA = "0x18789BB00")]
	public void CIEDCJNPNEC([In] FixedString128Bytes IPAAOHHFILB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MLLCOAOCDCK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x789BBC0", Offset = "0x789AFC0", VA = "0x18789BBC0")]
	public static FENBAFDMGII BCJLPHNGADA(this GBHBOJAPDOA DPDKJPMBJOA)
	{
		return default(FENBAFDMGII);
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
