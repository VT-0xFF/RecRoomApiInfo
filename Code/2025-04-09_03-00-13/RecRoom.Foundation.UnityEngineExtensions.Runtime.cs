using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FMDNNLPEDDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x35D7670", Offset = "0x35D6A70", VA = "0x1835D7670")]
	public static T HHLLGMDMHAC<T>(this T JOCJBPPJMJJ) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35D76D0", Offset = "0x35D6AD0", VA = "0x1835D76D0")]
	public static T HOGDIANKABP<T>(this T JOCJBPPJMJJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x35D7520", Offset = "0x35D6920", VA = "0x1835D7520")]
	public static void BIEECLCLJNI<T>(T JOCJBPPJMJJ, T KNCKFHOKGJM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x35D75E0", Offset = "0x35D69E0", VA = "0x1835D75E0")]
	public static bool ECLNJPNNIEO<T>(this T BLFGIKOAKOL) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x79022D0", Offset = "0x79016D0", VA = "0x1879022D0")]
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
