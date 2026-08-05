using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OCJPJIHNEFE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3EABDE0", Offset = "0x3EAABE0", VA = "0x183EABDE0")]
	public static T EMLGEEINBKE<T>(this T DBBEADIHLKO) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3EABE40", Offset = "0x3EAAC40", VA = "0x183EABE40")]
	public static T GAOLCMLONOL<T>(this T DBBEADIHLKO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3EABED0", Offset = "0x3EAACD0", VA = "0x183EABED0")]
	public static void JHKIHLMCDDI<T>(T DBBEADIHLKO, T FGAEAFBDBPK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3EABD50", Offset = "0x3EAAB50", VA = "0x183EABD50")]
	public static bool BAANJFKGODL<T>(this T ALGAKMGCCLO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83B6FB0", Offset = "0x83B5DB0", VA = "0x1883B6FB0")]
	public static string JDOKHGAGPBI(this UnityEngine.Object ALGAKMGCCLO)
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
