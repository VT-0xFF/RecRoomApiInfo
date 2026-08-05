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
	[Cpp2IlInjected.Address(RVA = "0x2CBA720", Offset = "0x2CB9720", VA = "0x182CBA720")]
	public static T CPGJMOBIOAG<T>(this T OLDDCPCBGIL) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2CBA780", Offset = "0x2CB9780", VA = "0x182CBA780")]
	public static T HGPDDLIJCBA<T>(this T OLDDCPCBGIL) where T : class, CLMDPBEODHA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CBA690", Offset = "0x2CB9690", VA = "0x182CBA690")]
	public static bool AKDPBCHKGFK<T>(this T HBFCGFKGCAF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x698A600", Offset = "0x6989600", VA = "0x18698A600")]
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
