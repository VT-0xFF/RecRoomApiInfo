using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JLNIEHPDHIA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface GIOLNLDAOOJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3006230", Offset = "0x3005230", VA = "0x183006230")]
	public static T ANHOMELEJFB<T>(this T GFJPFDOHONG) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3006290", Offset = "0x3005290", VA = "0x183006290")]
	public static T DAPLCHEKCJE<T>(this T GFJPFDOHONG) where T : class, GIOLNLDAOOJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x30063B0", Offset = "0x30053B0", VA = "0x1830063B0")]
	public static void KBEBFLOGDKE<T>(T GFJPFDOHONG, T DFABCHNPEEM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3006320", Offset = "0x3005320", VA = "0x183006320")]
	public static bool JFLCKEGHBFC<T>(this T IFPBFCLBBDP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF820", Offset = "0x6ECE820", VA = "0x186ECF820")]
	public static string LFPPKPHLMDI(this UnityEngine.Object IFPBFCLBBDP)
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
