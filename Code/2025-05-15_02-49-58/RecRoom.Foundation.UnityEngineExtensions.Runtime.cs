using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AIJOPPJJGKI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3C00", Offset = "0x3FC2200", VA = "0x183FC3C00")]
	public static T HBFKGEIOIOC<T>(this T OCACDKEJIIB) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3B70", Offset = "0x3FC2170", VA = "0x183FC3B70")]
	public static T GHFIHNOGJHB<T>(this T OCACDKEJIIB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3C60", Offset = "0x3FC2260", VA = "0x183FC3C60")]
	public static void KHMCDHGDEMO<T>(T OCACDKEJIIB, T MIJLJBIHDMP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3AE0", Offset = "0x3FC20E0", VA = "0x183FC3AE0")]
	public static bool EKMICEANEBI<T>(this T BOMDCGFKGKF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F4C0", Offset = "0x7C5DAC0", VA = "0x187C5F4C0")]
	public static string PEIAPHCHIJJ(this UnityEngine.Object BOMDCGFKGKF)
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
