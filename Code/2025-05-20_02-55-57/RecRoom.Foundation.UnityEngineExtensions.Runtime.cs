using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FECGDBLDFOP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x37F53A0", Offset = "0x37F45A0", VA = "0x1837F53A0")]
	public static T PDJPPFHDFPO<T>(this T CEENCLMGJAM) where T : UnityEngine.Object
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x37F5250", Offset = "0x37F4450", VA = "0x1837F5250")]
	public static T HHMOGAFGDHG<T>(this T CEENCLMGJAM) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x37F52E0", Offset = "0x37F44E0", VA = "0x1837F52E0")]
	public static void NKIHMKCBMHG<T>(T CEENCLMGJAM, T FNJGMJGALLH) where T : class
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x37F51C0", Offset = "0x37F43C0", VA = "0x1837F51C0")]
	public static bool HCMDKDAMNEH<T>(this T DBCLNEGBNLN) where T : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CC6CA0", Offset = "0x7CC5EA0", VA = "0x187CC6CA0")]
	public static string JEBFJHCKOMB(this UnityEngine.Object DBCLNEGBNLN)
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
