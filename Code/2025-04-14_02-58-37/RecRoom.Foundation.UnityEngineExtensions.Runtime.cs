using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JNPGICCHFFI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x36E7E50", Offset = "0x36E6850", VA = "0x1836E7E50")]
	public static T OMDFDLGKHIE<T>(this T IJPDNJELPLO) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36E7D30", Offset = "0x36E6730", VA = "0x1836E7D30")]
	public static T BNEEPDLIPGD<T>(this T IJPDNJELPLO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x36E7EB0", Offset = "0x36E68B0", VA = "0x1836E7EB0")]
	public static void PKNNJGIOLDO<T>(T IJPDNJELPLO, T OLKLGHOAKNE) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36E7DC0", Offset = "0x36E67C0", VA = "0x1836E7DC0")]
	public static bool GGJDPGHGBDA<T>(this T OIIGDBLKEDN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x793A9C0", Offset = "0x79393C0", VA = "0x18793A9C0")]
	public static string EOLPCKEGGKJ(this UnityEngine.Object OIIGDBLKEDN)
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
