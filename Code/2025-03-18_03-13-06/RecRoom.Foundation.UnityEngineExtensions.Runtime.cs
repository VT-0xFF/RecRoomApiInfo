using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DFAGOBENGBB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x32C8600", Offset = "0x32C7800", VA = "0x1832C8600")]
	public static T LMJGILEHPHP<T>(this T NAELBAPCKEH) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x32C8720", Offset = "0x32C7920", VA = "0x1832C8720")]
	public static T NLOOMFEHMHC<T>(this T NAELBAPCKEH) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x32C8660", Offset = "0x32C7860", VA = "0x1832C8660")]
	public static void NIMCBCMFJDF<T>(T NAELBAPCKEH, T LDKNLBHIGFL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x32C8570", Offset = "0x32C7770", VA = "0x1832C8570")]
	public static bool HHNFLGOIOAJ<T>(this T ONELFPFEALD) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7627800", Offset = "0x7626A00", VA = "0x187627800")]
	public static string BPACKGBFGON(this UnityEngine.Object ONELFPFEALD)
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
