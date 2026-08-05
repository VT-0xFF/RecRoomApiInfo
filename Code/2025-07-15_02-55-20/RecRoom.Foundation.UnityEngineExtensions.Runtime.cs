using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GFFDIGFDPFM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C44130", Offset = "0x3C42D30", VA = "0x183C44130")]
	public static T MFNMJBJEADB<T>(this T JBDFDFABHKD) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C44190", Offset = "0x3C42D90", VA = "0x183C44190")]
	public static T NOMKFHPNBEE<T>(this T JBDFDFABHKD) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C44070", Offset = "0x3C42C70", VA = "0x183C44070")]
	public static void LPEJFJJJDDC<T>(T JBDFDFABHKD, T IIOGPDPGOLB) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3C44220", Offset = "0x3C42E20", VA = "0x183C44220")]
	public static bool OBNAHFICFEJ<T>(this T KOJLNGLNBMH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x812BA50", Offset = "0x812A650", VA = "0x18812BA50")]
	public static string KKFMCJFHLEN(this UnityEngine.Object KOJLNGLNBMH)
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
