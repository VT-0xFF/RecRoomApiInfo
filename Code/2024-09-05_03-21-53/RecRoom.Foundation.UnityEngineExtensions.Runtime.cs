using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NBPIMGEIMJB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface FOMEIIKJHPI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2DC2050", Offset = "0x2DC0A50", VA = "0x182DC2050")]
	public static T DECBPEDOJEF<T>(this T PECHDAFMNOO) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2DC1FC0", Offset = "0x2DC09C0", VA = "0x182DC1FC0")]
	public static T BJNBIIEJCBI<T>(this T PECHDAFMNOO) where T : class, FOMEIIKJHPI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2DC20B0", Offset = "0x2DC0AB0", VA = "0x182DC20B0")]
	public static bool ICPKEGKBLPE<T>(this T GIGIFGONEAO) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3590", Offset = "0x6BC1F90", VA = "0x186BC3590")]
	public static string COAJNLDAIHJ(this UnityEngine.Object GIGIFGONEAO)
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
