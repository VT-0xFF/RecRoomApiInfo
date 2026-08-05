using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ABEICOBJCMB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string FGLKJOKLJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C630", Offset = "0x6B8B030", VA = "0x186B8C630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string ECLGPJGBEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C640", Offset = "0x6B8B040", VA = "0x186B8C640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string IPENHIJHPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C640", Offset = "0x6B8B040", VA = "0x186B8C640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string GEDJIFOJFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C630", Offset = "0x6B8B030", VA = "0x186B8C630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C650", Offset = "0x6B8B050", VA = "0x186B8C650")]
	private static string DAOPOKFAGOL(string KCEMGCAKHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C6B0", Offset = "0x6B8B0B0", VA = "0x186B8C6B0")]
	public static void DPBEONLPHDP(string KCEMGCAKHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C890", Offset = "0x6B8B290", VA = "0x186B8C890")]
	public static bool NBOHDDKFMAA(string KCEMGCAKHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C7A0", Offset = "0x6B8B1A0", VA = "0x186B8C7A0")]
	public static void KMAKHBNMJNE(string KCEMGCAKHDC, string LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C820", Offset = "0x6B8B220", VA = "0x186B8C820")]
	public static string KOPANFGAPEN(string KCEMGCAKHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C730", Offset = "0x6B8B130", VA = "0x186B8C730")]
	public static void KKNJIILLNFG(string KCEMGCAKHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void NFABJEJODED()
	{
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
