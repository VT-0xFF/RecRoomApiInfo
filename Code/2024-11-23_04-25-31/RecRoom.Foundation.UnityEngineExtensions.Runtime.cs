using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FLJGFPLMMNG
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EHBOGEJLMAC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2550", Offset = "0x2EE0F50", VA = "0x182EE2550")]
	public static T EOPOICEDPDF<T>(this T PCBICLOONMH) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2EE24C0", Offset = "0x2EE0EC0", VA = "0x182EE24C0")]
	public static T DNLHNOJLJGM<T>(this T PCBICLOONMH) where T : class, EHBOGEJLMAC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2EE25B0", Offset = "0x2EE0FB0", VA = "0x182EE25B0")]
	public static void KHHAAJCNENL<T>(T PCBICLOONMH, T GDOGPMPJPOO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2670", Offset = "0x2EE1070", VA = "0x182EE2670")]
	public static bool OPDJGKALAHP<T>(this T BBNKFKDCOLP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E17C30", Offset = "0x6E16630", VA = "0x186E17C30")]
	public static string DMJMDEEHOII(this UnityEngine.Object BBNKFKDCOLP)
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
