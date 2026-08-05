using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NJEJIFLPNEK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3F4F790", Offset = "0x3F4DD90", VA = "0x183F4F790")]
	public static T NNBLLGNEBCO<T>(this T JNMMMBJNOND) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3F4F700", Offset = "0x3F4DD00", VA = "0x183F4F700")]
	public static T KMOAOHKMLOK<T>(this T JNMMMBJNOND) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F4F5B0", Offset = "0x3F4DBB0", VA = "0x183F4F5B0")]
	public static void BFOLJGGGKLM<T>(T JNMMMBJNOND, T AAGCKLPFJME) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3F4F670", Offset = "0x3F4DC70", VA = "0x183F4F670")]
	public static bool HCODIGOEAIN<T>(this T MPIDDJPOOMJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x852C350", Offset = "0x852A950", VA = "0x18852C350")]
	public static string KGEKHLEJAGA(this UnityEngine.Object MPIDDJPOOMJ)
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
