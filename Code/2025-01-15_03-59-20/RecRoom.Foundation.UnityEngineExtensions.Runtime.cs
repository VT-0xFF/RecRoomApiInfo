using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JJJIGBPKNBA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface BBCPCGGBHPG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x30D6C40", Offset = "0x30D6040", VA = "0x1830D6C40")]
	public static T GDGMMIPBEOP<T>(this T MPLBPEBNKFP) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x30D6CA0", Offset = "0x30D60A0", VA = "0x1830D6CA0")]
	public static T PMFNKKOGECE<T>(this T MPLBPEBNKFP) where T : class, BBCPCGGBHPG
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x30D6B80", Offset = "0x30D5F80", VA = "0x1830D6B80")]
	public static void FFOCKMFMECL<T>(T MPLBPEBNKFP, T BMKPAKCEMFK) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x30D6AF0", Offset = "0x30D5EF0", VA = "0x1830D6AF0")]
	public static bool AGBEFLHOKFN<T>(this T NCHBKHMIMGJ) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x701A730", Offset = "0x7019B30", VA = "0x18701A730")]
	public static string DEGEMPIKEDP(this UnityEngine.Object NCHBKHMIMGJ)
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
