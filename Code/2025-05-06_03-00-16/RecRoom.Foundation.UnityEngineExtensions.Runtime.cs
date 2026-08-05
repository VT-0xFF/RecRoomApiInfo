using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AKLACAMJJMP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3F0D410", Offset = "0x3F0BC10", VA = "0x183F0D410")]
	public static T PFJIJKBGJAH<T>(this T NFOGFJOGLPE) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3F0D230", Offset = "0x3F0BA30", VA = "0x183F0D230")]
	public static T CKNAIDMJHHA<T>(this T NFOGFJOGLPE) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F0D2C0", Offset = "0x3F0BAC0", VA = "0x183F0D2C0")]
	public static void ILACKMLNCNE<T>(T NFOGFJOGLPE, T PGPJMFPAKOO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3F0D380", Offset = "0x3F0BB80", VA = "0x183F0D380")]
	public static bool LPNCPIENCKC<T>(this T PNHCNFOFAFI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B57F10", Offset = "0x7B56710", VA = "0x187B57F10")]
	public static string HPGNNMFNLJE(this UnityEngine.Object PNHCNFOFAFI)
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
