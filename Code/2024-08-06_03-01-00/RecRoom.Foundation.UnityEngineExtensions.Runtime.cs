using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BEHPIFDGJKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ILABJFPMMGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28F9550", Offset = "0x28F7B50", VA = "0x1828F9550")]
	public static T OEFEGCKMCDP<T>(this T ELMHNMGFNPC) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28F94C0", Offset = "0x28F7AC0", VA = "0x1828F94C0")]
	public static T HIGBKCCLABC<T>(this T ELMHNMGFNPC) where T : class, ILABJFPMMGO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28F9430", Offset = "0x28F7A30", VA = "0x1828F9430")]
	public static bool GPPFEMAMBHH<T>(this T CDBNFNMIHPK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69C8820", Offset = "0x69C6E20", VA = "0x1869C8820")]
	public static string LIOKOCBMFFP(this UnityEngine.Object CDBNFNMIHPK)
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
