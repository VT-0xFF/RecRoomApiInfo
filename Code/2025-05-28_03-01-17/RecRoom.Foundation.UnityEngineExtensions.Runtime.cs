using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EKNDMMMMLEE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x377A8F0", Offset = "0x37796F0", VA = "0x18377A8F0")]
	public static T DBCCFOBCGCJ<T>(this T FPFHIDBMBMI) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x377A860", Offset = "0x3779660", VA = "0x18377A860")]
	public static T CMCKBMBDLGI<T>(this T FPFHIDBMBMI) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x377A950", Offset = "0x3779750", VA = "0x18377A950")]
	public static void OLLEIGLLOBB<T>(T FPFHIDBMBMI, T HBLONCAMFLG) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x377A7D0", Offset = "0x37795D0", VA = "0x18377A7D0")]
	public static bool BJNHIIHGPCC<T>(this T GLEBGNJJOHG) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DCBBA0", Offset = "0x7DCA9A0", VA = "0x187DCBBA0")]
	public static string IAOLDFJDJDE(this UnityEngine.Object GLEBGNJJOHG)
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
