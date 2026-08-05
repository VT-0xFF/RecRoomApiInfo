using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct JGHCBDAAPKA
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B153E0", Offset = "0x7B147E0", VA = "0x187B153E0")]
	public static JGHCBDAAPKA HIHFKEJHDAH(LMKAPNBAFDO KIBGFJNEFGA)
	{
		return default(JGHCBDAAPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B154C0", Offset = "0x7B148C0", VA = "0x187B154C0")]
	public JGHCBDAAPKA(LMKAPNBAFDO KIBGFJNEFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B15400", Offset = "0x7B14800", VA = "0x187B15400")]
	public void DOIAIPJNOFC([In] FixedString128Bytes EMIHGGEGHBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ENLFBCHBPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B153E0", Offset = "0x7B147E0", VA = "0x187B153E0")]
	public static JGHCBDAAPKA LCPPIJLGEFB(this LMKAPNBAFDO KIBGFJNEFGA)
	{
		return default(JGHCBDAAPKA);
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
