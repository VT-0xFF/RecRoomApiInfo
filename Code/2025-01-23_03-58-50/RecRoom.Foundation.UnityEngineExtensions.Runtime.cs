using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LKFAFMPBBDO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface MBEABKOEJJC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3110EF0", Offset = "0x310F6F0", VA = "0x183110EF0")]
	public static T LEMHMMLFMEK<T>(this T EGGDEECAALI) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3110E60", Offset = "0x310F660", VA = "0x183110E60")]
	public static T CHGAFNMHMEP<T>(this T EGGDEECAALI) where T : class, MBEABKOEJJC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3110FE0", Offset = "0x310F7E0", VA = "0x183110FE0")]
	public static void OFLFIBGOBMH<T>(T EGGDEECAALI, T LIHCAHPMPHD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3110F50", Offset = "0x310F750", VA = "0x183110F50")]
	public static bool LPEGGAPMKMG<T>(this T INCBEIDOHDO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F72000", Offset = "0x6F70800", VA = "0x186F72000")]
	public static string IHHBADOBGMH(this UnityEngine.Object INCBEIDOHDO)
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
