using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PALHDELKBJL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface BNAIGNFOINF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD2D0", Offset = "0x2FBC4D0", VA = "0x182FBD2D0")]
	public static T CCFFKHPABFO<T>(this T AEFKHDNCNFD) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD3C0", Offset = "0x2FBC5C0", VA = "0x182FBD3C0")]
	public static T HPCOBAFJOKA<T>(this T AEFKHDNCNFD) where T : class, BNAIGNFOINF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD450", Offset = "0x2FBC650", VA = "0x182FBD450")]
	public static void LDEPFBJNNHA<T>(T AEFKHDNCNFD, T KDHPJMADEAD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2FBD330", Offset = "0x2FBC530", VA = "0x182FBD330")]
	public static bool FEDKOONNMCK<T>(this T JMJAOKJJFGJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C8BEB0", Offset = "0x6C8B0B0", VA = "0x186C8BEB0")]
	public static string EOPAFMHJHFB(this UnityEngine.Object JMJAOKJJFGJ)
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
