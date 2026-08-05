using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IIAAGJIPPOK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DE70", Offset = "0x3B7C470", VA = "0x183B7DE70")]
	public static T JKMIBOAHPHP<T>(this T PIKMBNLEPPK) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DED0", Offset = "0x3B7C4D0", VA = "0x183B7DED0")]
	public static T MFOMMJPFHOM<T>(this T PIKMBNLEPPK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DDB0", Offset = "0x3B7C3B0", VA = "0x183B7DDB0")]
	public static void IJPPDMEEKBE<T>(T PIKMBNLEPPK, T HOPHFOOKMCC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DD20", Offset = "0x3B7C320", VA = "0x183B7DD20")]
	public static bool IBMCNFKNOGJ<T>(this T ODCICEDDLMB) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FD7F90", Offset = "0x7FD6590", VA = "0x187FD7F90")]
	public static string CNBNMALDECC(this UnityEngine.Object ODCICEDDLMB)
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
