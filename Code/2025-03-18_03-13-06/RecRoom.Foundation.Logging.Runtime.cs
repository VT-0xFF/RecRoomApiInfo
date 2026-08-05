using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct HBDFHABMAEH
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x760FA00", Offset = "0x760EC00", VA = "0x18760FA00")]
	public static HBDFHABMAEH AJAOLMPMCKD(PBBCGFNIILA NPAEAIAJLAP)
	{
		return default(HBDFHABMAEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x760FAE0", Offset = "0x760ECE0", VA = "0x18760FAE0")]
	public HBDFHABMAEH(PBBCGFNIILA NPAEAIAJLAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x760FA20", Offset = "0x760EC20", VA = "0x18760FA20")]
	public void LOMKKPGBMOB([In] FixedString128Bytes BKOPBBHMJGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DCIHILENNAM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x760FA00", Offset = "0x760EC00", VA = "0x18760FA00")]
	public static HBDFHABMAEH CAGPDGEFCII(this PBBCGFNIILA NPAEAIAJLAP)
	{
		return default(HBDFHABMAEH);
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
