using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PDCJOCEIAOG
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ADEHDOEONIL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A509B0", Offset = "0x2A4F9B0", VA = "0x182A509B0")]
	public static T BDAHDAJKODM<T>(this T HFLBADIEKAM) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A50AA0", Offset = "0x2A4FAA0", VA = "0x182A50AA0")]
	public static T NIBFFEKAAML<T>(this T HFLBADIEKAM) where T : class, ADEHDOEONIL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A50A10", Offset = "0x2A4FA10", VA = "0x182A50A10")]
	public static bool IHICJKMEFPM<T>(this T KDEEPMDJGFD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x62C7EC0", Offset = "0x62C6EC0", VA = "0x1862C7EC0")]
	public static string HBAAILIOMDA(this UnityEngine.Object KDEEPMDJGFD)
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
