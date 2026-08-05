using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NHJMECHANLF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface JHDPOFMDBJJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x303EDB0", Offset = "0x303E1B0", VA = "0x18303EDB0")]
	public static T JNFIMMJBIJO<T>(this T EAFEIEDNLNL) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x303ED20", Offset = "0x303E120", VA = "0x18303ED20")]
	public static T JAHNLHDAJAK<T>(this T EAFEIEDNLNL) where T : class, JHDPOFMDBJJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x303EE10", Offset = "0x303E210", VA = "0x18303EE10")]
	public static void MCGHGPBDJNN<T>(T EAFEIEDNLNL, T OGKFFDCECEL) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x303EED0", Offset = "0x303E2D0", VA = "0x18303EED0")]
	public static bool MFFJCHPHJID<T>(this T FAKGLFFOLFI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D724A0", Offset = "0x6D718A0", VA = "0x186D724A0")]
	public static string GFJALMHMNHO(this UnityEngine.Object FAKGLFFOLFI)
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
