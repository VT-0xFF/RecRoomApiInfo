using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JBOHHDKANFI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface KMEKGKKHANP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2AE52B0", Offset = "0x2AE3AB0", VA = "0x182AE52B0")]
	public static T CDPGOCIHKLI<T>(this T EGJINJKGIAK) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5310", Offset = "0x2AE3B10", VA = "0x182AE5310")]
	public static T HFJKDGCGONK<T>(this T EGJINJKGIAK) where T : class, KMEKGKKHANP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2AE53A0", Offset = "0x2AE3BA0", VA = "0x182AE53A0")]
	public static bool LAKILNNNOHM<T>(this T GHDJADLHPAA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x686CEC0", Offset = "0x686B6C0", VA = "0x18686CEC0")]
	public static string HLPDAHKBEJO(this UnityEngine.Object GHDJADLHPAA)
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
