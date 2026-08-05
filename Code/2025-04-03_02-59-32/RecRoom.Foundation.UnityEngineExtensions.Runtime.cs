using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FMDNNLPEDDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x35C13C0", Offset = "0x35C07C0", VA = "0x1835C13C0")]
	public static T HHLLGMDMHAC<T>(this T JOCJBPPJMJJ) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35C1420", Offset = "0x35C0820", VA = "0x1835C1420")]
	public static T HOGDIANKABP<T>(this T JOCJBPPJMJJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x35C1270", Offset = "0x35C0670", VA = "0x1835C1270")]
	public static void BIEECLCLJNI<T>(T JOCJBPPJMJJ, T KNCKFHOKGJM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x35C1330", Offset = "0x35C0730", VA = "0x1835C1330")]
	public static bool ECLNJPNNIEO<T>(this T BLFGIKOAKOL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78B3750", Offset = "0x78B2B50", VA = "0x1878B3750")]
	public static string OFBEIACBDJD(this UnityEngine.Object BLFGIKOAKOL)
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
