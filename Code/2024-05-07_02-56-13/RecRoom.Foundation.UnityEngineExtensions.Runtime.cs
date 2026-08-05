using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MLALCJNEMFP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface OBEAHHBICGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x29BB0E0", Offset = "0x29BA2E0", VA = "0x1829BB0E0")]
	public static T KLNGFBMMFDG<T>(this T KNKOEEEKHDK) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29BB140", Offset = "0x29BA340", VA = "0x1829BB140")]
	public static T NLPGIBGKDEJ<T>(this T KNKOEEEKHDK) where T : class, OBEAHHBICGO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x29BB050", Offset = "0x29BA250", VA = "0x1829BB050")]
	public static bool CEIGELKAPDJ<T>(this T JFJMICPDNDH) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6203E00", Offset = "0x6203000", VA = "0x186203E00")]
	public static string EMJHCPJAPJA(this UnityEngine.Object JFJMICPDNDH)
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
