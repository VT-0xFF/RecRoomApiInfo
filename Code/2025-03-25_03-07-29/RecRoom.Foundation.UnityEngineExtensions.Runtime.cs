using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IECAHAHCHDB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3652CE0", Offset = "0x36520E0", VA = "0x183652CE0")]
	public static T HGEILGIJCMJ<T>(this T CAMFIHKHJNG) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3652B00", Offset = "0x3651F00", VA = "0x183652B00")]
	public static T BIFMOKJKFOK<T>(this T CAMFIHKHJNG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3652C20", Offset = "0x3652020", VA = "0x183652C20")]
	public static void GOEKONFMHGI<T>(T CAMFIHKHJNG, T JAPIEEBOJEA) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3652B90", Offset = "0x3651F90", VA = "0x183652B90")]
	public static bool DNOCPNOHCPN<T>(this T HAPOBHMBDHP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7843920", Offset = "0x7842D20", VA = "0x187843920")]
	public static string PBIIIOFNAJP(this UnityEngine.Object HAPOBHMBDHP)
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
