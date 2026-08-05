using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EKEDFKAGHGN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C120E0", Offset = "0x3C10AE0", VA = "0x183C120E0")]
	public static T GJEIGJNOBNN<T>(this T DKGBCFDLMOI) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C12140", Offset = "0x3C10B40", VA = "0x183C12140")]
	public static T JCPIMNILCKB<T>(this T DKGBCFDLMOI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C121D0", Offset = "0x3C10BD0", VA = "0x183C121D0")]
	public static void NLBJPBFEKJC<T>(T DKGBCFDLMOI, T GOCNHGEHNFD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3C12050", Offset = "0x3C10A50", VA = "0x183C12050")]
	public static bool CMMFIDFPDFF<T>(this T PMNHIPACJLN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8522440", Offset = "0x8520E40", VA = "0x188522440")]
	public static string HLNKDJHNGDM(this UnityEngine.Object PMNHIPACJLN)
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
