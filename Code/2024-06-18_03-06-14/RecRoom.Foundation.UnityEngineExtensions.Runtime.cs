using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MCCDMFDIPGH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface IAEAPCOOODH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6B60", Offset = "0x2BF5560", VA = "0x182BF6B60")]
	public static T HJEDACIAOHF<T>(this T BBCPNLGGBMJ) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6BC0", Offset = "0x2BF55C0", VA = "0x182BF6BC0")]
	public static T NICLECDEHJM<T>(this T BBCPNLGGBMJ) where T : class, IAEAPCOOODH
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6AD0", Offset = "0x2BF54D0", VA = "0x182BF6AD0")]
	public static bool HBAGAMAHBIA<T>(this T GKHPLGCJCPF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68E3520", Offset = "0x68E1F20", VA = "0x1868E3520")]
	public static string FIMJIDOGLDB(this UnityEngine.Object GKHPLGCJCPF)
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
