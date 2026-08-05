using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OJONAANFIPN
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface CLMDPBEODHA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1090", Offset = "0x2C9F690", VA = "0x182CA1090")]
	public static T CPGJMOBIOAG<T>(this T OLDDCPCBGIL) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2CA10F0", Offset = "0x2C9F6F0", VA = "0x182CA10F0")]
	public static T HGPDDLIJCBA<T>(this T OLDDCPCBGIL) where T : class, CLMDPBEODHA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1000", Offset = "0x2C9F600", VA = "0x182CA1000")]
	public static bool AKDPBCHKGFK<T>(this T HBFCGFKGCAF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69576A0", Offset = "0x6955CA0", VA = "0x1869576A0")]
	public static string KIHPNABNGJN(this UnityEngine.Object HBFCGFKGCAF)
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
