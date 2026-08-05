using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ELFOLKCLFNL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface NMEAOAMKJEB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2CB22E0", Offset = "0x2CB16E0", VA = "0x182CB22E0")]
	public static T IGEDKNCGFDN<T>(this T MBGHIKEGJAA) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2CB2250", Offset = "0x2CB1650", VA = "0x182CB2250")]
	public static T CPDGJMLPKPI<T>(this T MBGHIKEGJAA) where T : class, NMEAOAMKJEB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CB2340", Offset = "0x2CB1740", VA = "0x182CB2340")]
	public static void LLJDLGNGANI<T>(T MBGHIKEGJAA, T OCKBFCIKBEN) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CB21C0", Offset = "0x2CB15C0", VA = "0x182CB21C0")]
	public static bool BGNOOGLIBEA<T>(this T PBAACPJGKNP) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E087D0", Offset = "0x6E07BD0", VA = "0x186E087D0")]
	public static string GMNMADAKJFN(this UnityEngine.Object PBAACPJGKNP)
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
