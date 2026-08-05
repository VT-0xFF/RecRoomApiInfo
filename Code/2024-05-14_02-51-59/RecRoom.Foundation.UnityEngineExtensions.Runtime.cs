using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DHLICOOJMHE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface EELEMLJMEOO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27E6DF0", Offset = "0x27E57F0", VA = "0x1827E6DF0")]
	public static T GDIICMBMCFF<T>(this T CMJEIEIDHIK) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27E6D50", Offset = "0x27E5750", VA = "0x1827E6D50")]
	public static T EOPJLNGAICP<T>(this T CMJEIEIDHIK) where T : class, EELEMLJMEOO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27E6E50", Offset = "0x27E5850", VA = "0x1827E6E50")]
	public static bool NAGNMCIPLBJ<T>(this T COMOOAEHALC) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6352530", Offset = "0x6350F30", VA = "0x186352530")]
	public static string CFPBKDCJHPB(this UnityEngine.Object COMOOAEHALC)
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
