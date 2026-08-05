using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MYRIDPBKETA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface XOEXMPGHTTG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3C49420", Offset = "0x3C47E20", VA = "0x183C49420")]
	public static a IKAWTYXSJCI<a>(this a a) where a : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3C49480", Offset = "0x3C47E80", VA = "0x183C49480")]
	public static b XPKPLJIQRVN<b>(this b a) where b : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C49360", Offset = "0x3C47D60", VA = "0x183C49360")]
	public static void HUSFGVDPURF<d>(d a, d b) where d : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3C492D0", Offset = "0x3C47CD0", VA = "0x183C492D0")]
	public static bool DJEAVUFCVFV<e>(this e a) where e : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x99DF410", Offset = "0x99DDE10", VA = "0x1899DF410")]
	public static string YFOJYKWGAMA(this UnityEngine.Object a)
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
