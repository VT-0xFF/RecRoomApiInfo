using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JJJBBNHMIFL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface NEEFIEJPFND
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x33FCC00", Offset = "0x33FB800", VA = "0x1833FCC00")]
	public static T JDDGFOHDKMM<T>(this T DKGDAEBOJKO) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x33FCC60", Offset = "0x33FB860", VA = "0x1833FCC60")]
	public static T MJOAAFHBKGJ<T>(this T DKGDAEBOJKO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x33FCAB0", Offset = "0x33FB6B0", VA = "0x1833FCAB0")]
	public static void DPJCBBDBMJC<T>(T DKGDAEBOJKO, T PELBNOCGOOJ) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x33FCB70", Offset = "0x33FB770", VA = "0x1833FCB70")]
	public static bool GCFMLPDBPGE<T>(this T CFMCKCBBBKK) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74D5510", Offset = "0x74D4110", VA = "0x1874D5510")]
	public static string FPCNNDAAGKE(this UnityEngine.Object CFMCKCBBBKK)
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
