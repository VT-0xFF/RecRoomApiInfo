using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FGDNKDEJIJD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x39EA380", Offset = "0x39E9580", VA = "0x1839EA380")]
	public static T KIONLGLFMEK<T>(this T IPOCHJJJBCM) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x39EA1A0", Offset = "0x39E93A0", VA = "0x1839EA1A0")]
	public static T DPDJFBJKJMM<T>(this T IPOCHJJJBCM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x39EA230", Offset = "0x39E9430", VA = "0x1839EA230")]
	public static void FHBJPOKCEBF<T>(T IPOCHJJJBCM, T CMOCFNBHPLJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x39EA2F0", Offset = "0x39E94F0", VA = "0x1839EA2F0")]
	public static bool INAPNEGPBBC<T>(this T KFMNDOMPAMC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C83C00", Offset = "0x7C82E00", VA = "0x187C83C00")]
	public static string DICODBAHMEK(this UnityEngine.Object KFMNDOMPAMC)
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
