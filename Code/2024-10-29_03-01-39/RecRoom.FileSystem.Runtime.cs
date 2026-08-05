using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JGDJHCOIJMO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string GBHGCCFNEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB120", Offset = "0x6EAA120", VA = "0x186EAB120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string AMHIGNEBFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB1A0", Offset = "0x6EAA1A0", VA = "0x186EAB1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string FEEEDNJBELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB1A0", Offset = "0x6EAA1A0", VA = "0x186EAB1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string CPFPJGJDAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB120", Offset = "0x6EAA120", VA = "0x186EAB120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB290", Offset = "0x6EAA290", VA = "0x186EAB290")]
	private static string LKIMDAHHBPG(string MBDMHLKHKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB370", Offset = "0x6EAA370", VA = "0x186EAB370")]
	public static void OPBHMLJLFAI(string MBDMHLKHKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB220", Offset = "0x6EAA220", VA = "0x186EAB220")]
	public static bool KGFODJCGCNA(string MBDMHLKHKIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB2F0", Offset = "0x6EAA2F0", VA = "0x186EAB2F0")]
	public static void MDDEHFGKMEG(string MBDMHLKHKIH, string CONAFKKIHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB130", Offset = "0x6EAA130", VA = "0x186EAB130")]
	public static string CIENHKPGKOD(string MBDMHLKHKIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB1B0", Offset = "0x6EAA1B0", VA = "0x186EAB1B0")]
	public static void ILDAKAMNGDH(string MBDMHLKHKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void HJNCPDHIKCE()
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
