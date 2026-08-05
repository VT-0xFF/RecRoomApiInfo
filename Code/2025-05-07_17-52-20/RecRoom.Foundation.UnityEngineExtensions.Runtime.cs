using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AIJOPPJJGKI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3F6CD60", Offset = "0x3F6BD60", VA = "0x183F6CD60")]
	public static T HBFKGEIOIOC<T>(this T OCACDKEJIIB) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3F6CCD0", Offset = "0x3F6BCD0", VA = "0x183F6CCD0")]
	public static T GHFIHNOGJHB<T>(this T OCACDKEJIIB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F6CDC0", Offset = "0x3F6BDC0", VA = "0x183F6CDC0")]
	public static void KHMCDHGDEMO<T>(T OCACDKEJIIB, T MIJLJBIHDMP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3F6CC40", Offset = "0x3F6BC40", VA = "0x183F6CC40")]
	public static bool EKMICEANEBI<T>(this T BOMDCGFKGKF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C93B80", Offset = "0x7C92B80", VA = "0x187C93B80")]
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
