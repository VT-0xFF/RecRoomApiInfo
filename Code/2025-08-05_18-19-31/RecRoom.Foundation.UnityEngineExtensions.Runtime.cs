using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PKGDMPEDEAM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1FD0", Offset = "0x3ED13D0", VA = "0x183ED1FD0")]
	public static T KJPANBIIABO<T>(this T DMFKPMONDPO) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1EB0", Offset = "0x3ED12B0", VA = "0x183ED1EB0")]
	public static T EPKMEFFNPLE<T>(this T DMFKPMONDPO) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1DF0", Offset = "0x3ED11F0", VA = "0x183ED1DF0")]
	public static void BDFOAEHPFKP<T>(T DMFKPMONDPO, T LHDOHAKINKP) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1F40", Offset = "0x3ED1340", VA = "0x183ED1F40")]
	public static bool JNMFLCIOBNJ<T>(this T DEJGDIIDCDN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82DA010", Offset = "0x82D9410", VA = "0x1882DA010")]
	public static string IJLMCBHMCKB(this UnityEngine.Object DEJGDIIDCDN)
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
