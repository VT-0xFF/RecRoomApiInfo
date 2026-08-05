using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DONMNNICLPK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface GEODOPPEAJN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x30F8380", Offset = "0x30F7580", VA = "0x1830F8380")]
	public static T HOKMDBGCPMP<T>(this T MLNFAKCEGNM) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x30F83E0", Offset = "0x30F75E0", VA = "0x1830F83E0")]
	public static T ICDDMMNFCNP<T>(this T MLNFAKCEGNM) where T : class, GEODOPPEAJN
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x30F82C0", Offset = "0x30F74C0", VA = "0x1830F82C0")]
	public static void CMAGCCGLIPL<T>(T MLNFAKCEGNM, T JAINJPLCLDO) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x30F8470", Offset = "0x30F7670", VA = "0x1830F8470")]
	public static bool PLONAJPDILF<T>(this T LCACGJDNDHA) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7245890", Offset = "0x7244A90", VA = "0x187245890")]
	public static string ILFNDJBIKOI(this UnityEngine.Object LCACGJDNDHA)
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
