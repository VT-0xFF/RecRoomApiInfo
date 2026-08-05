using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PCCPBAEJGOL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3F683C0", Offset = "0x3F669C0", VA = "0x183F683C0")]
	public static T NBKHDJDJEML<T>(this T CCKLBDLJPNG) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3F68330", Offset = "0x3F66930", VA = "0x183F68330")]
	public static T IOMLBCIJPJH<T>(this T CCKLBDLJPNG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F68270", Offset = "0x3F66870", VA = "0x183F68270")]
	public static void IABOGGNOIKB<T>(T CCKLBDLJPNG, T IBCMCOKAJEM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3F681E0", Offset = "0x3F667E0", VA = "0x183F681E0")]
	public static bool CKBMMMEDPBO<T>(this T NDBJJGOPOFO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x848FD40", Offset = "0x848E340", VA = "0x18848FD40")]
	public static string AHAHJEMPGEN(this UnityEngine.Object NDBJJGOPOFO)
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
