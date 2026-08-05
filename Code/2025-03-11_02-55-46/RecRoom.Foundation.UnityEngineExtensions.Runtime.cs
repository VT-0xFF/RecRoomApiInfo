using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LCCGHPPFPFP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3559770", Offset = "0x3558B70", VA = "0x183559770")]
	public static T OAILMFMEODN<T>(this T IIICNLIAPBJ) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x35596E0", Offset = "0x3558AE0", VA = "0x1835596E0")]
	public static T GDHPDHGBEGJ<T>(this T IIICNLIAPBJ) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x35597D0", Offset = "0x3558BD0", VA = "0x1835597D0")]
	public static void PEDJKAJCDDN<T>(T IIICNLIAPBJ, T MNALNBMKJLK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3559650", Offset = "0x3558A50", VA = "0x183559650")]
	public static bool AINJMNDFCPF<T>(this T NBAMGPFDMIB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76156F0", Offset = "0x7614AF0", VA = "0x1876156F0")]
	public static string FHCILECKIKE(this UnityEngine.Object NBAMGPFDMIB)
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
