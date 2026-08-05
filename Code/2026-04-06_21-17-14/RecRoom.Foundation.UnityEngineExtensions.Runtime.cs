using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EHYDQQTNUEQ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface PZTXZFMPQRQ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3946E10", Offset = "0x3945E10", VA = "0x183946E10")]
	public static a LJXZZJWPNKO<a>(this a a) where a : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3946CC0", Offset = "0x3945CC0", VA = "0x183946CC0")]
	public static b ILWPNKODBTL<b>(this b a) where b : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3946D50", Offset = "0x3945D50", VA = "0x183946D50")]
	public static void LBYXUYIXGUJ<d>(d a, d b) where d : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3946E70", Offset = "0x3945E70", VA = "0x183946E70")]
	public static bool YMCVKIPUGOJ<e>(this e a) where e : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x99F29A0", Offset = "0x99F19A0", VA = "0x1899F29A0")]
	public static string CDLMNIWWDJQ(this UnityEngine.Object a)
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
