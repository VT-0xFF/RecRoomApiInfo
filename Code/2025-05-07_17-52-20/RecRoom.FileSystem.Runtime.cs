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
		[Cpp2IlInjected.Address(RVA = "0x7C5FA60", Offset = "0x7C5EA60", VA = "0x187C5FA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string PJOCOMCEMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F8E0", Offset = "0x7C5E8E0", VA = "0x187C5F8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string FIGOAFKKKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F8E0", Offset = "0x7C5E8E0", VA = "0x187C5F8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string PHANLDFKJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FA60", Offset = "0x7C5EA60", VA = "0x187C5FA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FAD0", Offset = "0x7C5EAD0", VA = "0x187C5FAD0")]
	public static string MFFKKFIEFIO([Optional] string OJNJBFCJPGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FA70", Offset = "0x7C5EA70", VA = "0x187C5FA70")]
	private static string IBAHFCINHGJ(string IGFKNGAMFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F9E0", Offset = "0x7C5E9E0", VA = "0x187C5F9E0")]
	public static void GNOKINIDLHL(string IGFKNGAMFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F970", Offset = "0x7C5E970", VA = "0x187C5F970")]
	public static bool FNCKMNAJKHI(string IGFKNGAMFIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F8F0", Offset = "0x7C5E8F0", VA = "0x187C5F8F0")]
	public static void DIMCECCNICB(string IGFKNGAMFIG, string APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB50", Offset = "0x7C5EB50", VA = "0x187C5FB50")]
	public static string MGDOMLOFIFF(string IGFKNGAMFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FBC0", Offset = "0x7C5EBC0", VA = "0x187C5FBC0")]
	public static void PPCHDMEIHCG(string IGFKNGAMFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
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
