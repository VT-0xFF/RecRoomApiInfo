using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JLMLKHOKJDL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface MMJAGBJACKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4DA0", Offset = "0x2DC37A0", VA = "0x182DC4DA0")]
	public static T BOMNEAAMAHI<T>(this T NKCEKILMAAM) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4E00", Offset = "0x2DC3800", VA = "0x182DC4E00")]
	public static T EHHCKCKJHEK<T>(this T NKCEKILMAAM) where T : class, MMJAGBJACKB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4F20", Offset = "0x2DC3920", VA = "0x182DC4F20")]
	public static void OHAPGFPCKMJ<T>(T NKCEKILMAAM, T CGCLEIBHLHF) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2DC4E90", Offset = "0x2DC3890", VA = "0x182DC4E90")]
	public static bool MJLAAGHMLBA<T>(this T FHFDEAHMMBI) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0BF0", Offset = "0x6BAF5F0", VA = "0x186BB0BF0")]
	public static string BDAGFEEHGJJ(this UnityEngine.Object FHFDEAHMMBI)
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
