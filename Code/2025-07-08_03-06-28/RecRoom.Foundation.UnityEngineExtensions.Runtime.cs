using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AIENPOJHEIM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x311AEE0", Offset = "0x3119CE0", VA = "0x18311AEE0")]
	public static T PBLEFOIEMAG<T>(this T FEOFEEGOGIO) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x311AD90", Offset = "0x3119B90", VA = "0x18311AD90")]
	public static T IKPCAAFGAMI<T>(this T FEOFEEGOGIO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x311AE20", Offset = "0x3119C20", VA = "0x18311AE20")]
	public static void LGGINMIKPOI<T>(T FEOFEEGOGIO, T LOKLFHKEJPC) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x311AD00", Offset = "0x3119B00", VA = "0x18311AD00")]
	public static bool HDNIKKJKCOM<T>(this T MKPNGAKJFMP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x80E9960", Offset = "0x80E8760", VA = "0x1880E9960")]
	public static string IFOJPJMKPHL(this UnityEngine.Object MKPNGAKJFMP)
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
