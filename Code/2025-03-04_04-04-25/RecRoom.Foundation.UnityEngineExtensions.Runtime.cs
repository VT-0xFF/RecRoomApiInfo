using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JOFABJOMOHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x34731E0", Offset = "0x34717E0", VA = "0x1834731E0")]
	public static T OEPNDMNIGHF<T>(this T JDCFMPOHCEA) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3473000", Offset = "0x3471600", VA = "0x183473000")]
	public static T EEIHHLHFLNA<T>(this T JDCFMPOHCEA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3473090", Offset = "0x3471690", VA = "0x183473090")]
	public static void HGPDCCGFMAO<T>(T JDCFMPOHCEA, T OKCHLIEAIJP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3473150", Offset = "0x3471750", VA = "0x183473150")]
	public static bool HPLGCCOLHOJ<T>(this T GMFKPONAANG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x752EDF0", Offset = "0x752D3F0", VA = "0x18752EDF0")]
	public static string LJGMLMLJICA(this UnityEngine.Object GMFKPONAANG)
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
