using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HNCNHOONNPG
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EHEFCKJDJIE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2E33E40", Offset = "0x2E32A40", VA = "0x182E33E40")]
	public static T ICIKLGDGNCC<T>(this T GMNCELIMKIF) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2E33EA0", Offset = "0x2E32AA0", VA = "0x182E33EA0")]
	public static T LAHOHIBKMNI<T>(this T GMNCELIMKIF) where T : class, EHEFCKJDJIE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E33D80", Offset = "0x2E32980", VA = "0x182E33D80")]
	public static void EHNMIONNDMI<T>(T GMNCELIMKIF, T FDOEIPBMJJM) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2E33F30", Offset = "0x2E32B30", VA = "0x182E33F30")]
	public static bool MPLDACJNGND<T>(this T PLAMADMDGIO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BD10", Offset = "0x6C6A910", VA = "0x186C6BD10")]
	public static string HMKGLIMHDEE(this UnityEngine.Object PLAMADMDGIO)
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
