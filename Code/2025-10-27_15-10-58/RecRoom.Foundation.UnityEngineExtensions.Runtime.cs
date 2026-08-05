using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BWBWQLAJQCZ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x36A71B0", Offset = "0x36A61B0", VA = "0x1836A71B0")]
	public static a BVYJXCEKYJX<a>(this a a) where a : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36A72D0", Offset = "0x36A62D0", VA = "0x1836A72D0")]
	public static b JFYRMMBQDLK<b>(this b a) where b : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x36A7210", Offset = "0x36A6210", VA = "0x1836A7210")]
	public static void EHNMYIWOLCC<d>(d a, d b) where d : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36A7360", Offset = "0x36A6360", VA = "0x1836A7360")]
	public static bool OWXWUIKPITO<e>(this e a) where e : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8758840", Offset = "0x8757840", VA = "0x188758840")]
	public static string NPDVDDVLEFJ(this UnityEngine.Object a)
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
