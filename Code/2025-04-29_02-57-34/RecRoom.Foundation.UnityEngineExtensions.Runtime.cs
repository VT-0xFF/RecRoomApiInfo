using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BCGFFJMKEGF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3443670", Offset = "0x3442A70", VA = "0x183443670")]
	public static T OIPJELBCNGO<T>(this T KBBJDOAJMAF) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3443520", Offset = "0x3442920", VA = "0x183443520")]
	public static T FNKKPJKDNML<T>(this T KBBJDOAJMAF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x34435B0", Offset = "0x34429B0", VA = "0x1834435B0")]
	public static void MOPDOEFFMFH<T>(T KBBJDOAJMAF, T DMMBOHMLHLF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3443490", Offset = "0x3442890", VA = "0x183443490")]
	public static bool BBIMDLNDDCP<T>(this T KLANNNFBLNB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B2D0D0", Offset = "0x7B2C4D0", VA = "0x187B2D0D0")]
	public static string NMKEBLIBPLC(this UnityEngine.Object KLANNNFBLNB)
	{
		return null;
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
