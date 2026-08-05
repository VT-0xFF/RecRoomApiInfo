using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MIGGNMFODMK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface KHDFJDKCGNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B450", Offset = "0x2D99A50", VA = "0x182D9B450")]
	public static T OPBAPPBEGCE<T>(this T BJNJBGHPMEH) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B4B0", Offset = "0x2D99AB0", VA = "0x182D9B4B0")]
	public static T PAAIDPKJDAP<T>(this T BJNJBGHPMEH) where T : class, KHDFJDKCGNC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2D9B3C0", Offset = "0x2D999C0", VA = "0x182D9B3C0")]
	public static bool DOBHLACPNFN<T>(this T GHMNBJIOGAM) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B84FF0", Offset = "0x6B835F0", VA = "0x186B84FF0")]
	public static string BBBIKJIBACL(this UnityEngine.Object GHMNBJIOGAM)
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
