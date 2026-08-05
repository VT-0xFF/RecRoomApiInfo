using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PCIEIPFEAZB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD000", Offset = "0x3AFBE00", VA = "0x183AFD000")]
	public static a TDTIPKGRUNR<a>(this a a) where a : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCE20", Offset = "0x3AFBC20", VA = "0x183AFCE20")]
	public static b AYKAALJNRXQ<b>(this b a) where b : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCEB0", Offset = "0x3AFBCB0", VA = "0x183AFCEB0")]
	public static void CBZPUMJSXPO<d>(d a, d b) where d : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCF70", Offset = "0x3AFBD70", VA = "0x183AFCF70")]
	public static bool IQGZSJYXNTI<e>(this e a) where e : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84BA040", Offset = "0x84B8E40", VA = "0x1884BA040")]
	public static string KYIXTNWRRAZ(this UnityEngine.Object a)
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
