using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HJJIPFBKHAH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string EMIBNPHKFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B410", Offset = "0x7C29A10", VA = "0x187C2B410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string PJOCOMCEMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B290", Offset = "0x7C29890", VA = "0x187C2B290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string FIGOAFKKKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B290", Offset = "0x7C29890", VA = "0x187C2B290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string PHANLDFKJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B410", Offset = "0x7C29A10", VA = "0x187C2B410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B480", Offset = "0x7C29A80", VA = "0x187C2B480")]
	public static string MFFKKFIEFIO([Optional] string OJNJBFCJPGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B420", Offset = "0x7C29A20", VA = "0x187C2B420")]
	private static string IBAHFCINHGJ(string IGFKNGAMFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B390", Offset = "0x7C29990", VA = "0x187C2B390")]
	public static void GNOKINIDLHL(string IGFKNGAMFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B320", Offset = "0x7C29920", VA = "0x187C2B320")]
	public static bool FNCKMNAJKHI(string IGFKNGAMFIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B2A0", Offset = "0x7C298A0", VA = "0x187C2B2A0")]
	public static void DIMCECCNICB(string IGFKNGAMFIG, string APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B500", Offset = "0x7C29B00", VA = "0x187C2B500")]
	public static string MGDOMLOFIFF(string IGFKNGAMFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B570", Offset = "0x7C29B70", VA = "0x187C2B570")]
	public static void PPCHDMEIHCG(string IGFKNGAMFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
	private static void CFHJEAGMJEK()
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
