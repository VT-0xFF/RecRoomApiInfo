using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LYJUIMIOGQR
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8E30", Offset = "0x3CB7A30", VA = "0x183CB8E30")]
	public static a MSXMGSFKMWZ<a>(this a a) where a : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8C50", Offset = "0x3CB7850", VA = "0x183CB8C50")]
	public static b AAWOYPKPOEY<b>(this b a) where b : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8CE0", Offset = "0x3CB78E0", VA = "0x183CB8CE0")]
	public static void JMAAPTVVAHA<d>(d a, d b) where d : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3CB8DA0", Offset = "0x3CB79A0", VA = "0x183CB8DA0")]
	public static bool KFEVCIUYEPS<e>(this e a) where e : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8A39850", Offset = "0x8A38450", VA = "0x188A39850")]
	public static string QAHXSSDSVCH(this UnityEngine.Object a)
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
