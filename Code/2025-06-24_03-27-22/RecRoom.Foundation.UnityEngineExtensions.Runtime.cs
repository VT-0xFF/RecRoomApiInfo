using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OFAIFKHBKKO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F120", Offset = "0x3C6DD20", VA = "0x183C6F120")]
	public static T LMOEOPKHAHJ<T>(this T LAAPKLDJLPE) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F090", Offset = "0x3C6DC90", VA = "0x183C6F090")]
	public static T EEGHMBDJGJH<T>(this T LAAPKLDJLPE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F180", Offset = "0x3C6DD80", VA = "0x183C6F180")]
	public static void LPFIFNJDILF<T>(T LAAPKLDJLPE, T GMNGNCHKEBK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3C6F240", Offset = "0x3C6DE40", VA = "0x183C6F240")]
	public static bool OHCPKPPHPFC<T>(this T KDKJDFFGNJJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6040", Offset = "0x7DF4C40", VA = "0x187DF6040")]
	public static string OCOFFHKFNNG(this UnityEngine.Object KDKJDFFGNJJ)
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
