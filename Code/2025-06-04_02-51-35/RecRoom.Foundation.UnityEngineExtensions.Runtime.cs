using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PGCBGBLFEMM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2680", Offset = "0x3BA0E80", VA = "0x183BA2680")]
	public static T BHKOAMGOJDC<T>(this T DKBBJFIDEGB) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3BA27A0", Offset = "0x3BA0FA0", VA = "0x183BA27A0")]
	public static T JIGKBCJOGCI<T>(this T DKBBJFIDEGB) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3BA26E0", Offset = "0x3BA0EE0", VA = "0x183BA26E0")]
	public static void IFNAAPMLGJA<T>(T DKBBJFIDEGB, T KEKEFPAJGHD) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3BA2830", Offset = "0x3BA1030", VA = "0x183BA2830")]
	public static bool LPDGKOAPOGK<T>(this T HPLLAPMNIJF) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FCFA90", Offset = "0x7FCE290", VA = "0x187FCFA90")]
	public static string LHEALMAHAIK(this UnityEngine.Object HPLLAPMNIJF)
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
