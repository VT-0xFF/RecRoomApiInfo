using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PCAHPLMFCAA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface JPFFFEFBMNH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2B113A0", Offset = "0x2B105A0", VA = "0x182B113A0")]
	public static T JOHGAKDBAAN<T>(this T CJKIBFNGPNM) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2B11310", Offset = "0x2B10510", VA = "0x182B11310")]
	public static T HDDMEHLOPBD<T>(this T CJKIBFNGPNM) where T : class, JPFFFEFBMNH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B11400", Offset = "0x2B10600", VA = "0x182B11400")]
	public static bool MKDJLFIDJDE<T>(this T CDJAKLIPEBF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6413620", Offset = "0x6412820", VA = "0x186413620")]
	public static string BBPDDILILFH(this UnityEngine.Object CDJAKLIPEBF)
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
