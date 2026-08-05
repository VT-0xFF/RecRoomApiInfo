using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ALBEHOLPCMN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string JKDHLOAMNLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8D60", Offset = "0x7AF8160", VA = "0x187AF8D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string MDFLCEPKLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8D70", Offset = "0x7AF8170", VA = "0x187AF8D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string GGOCOMPBGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8D70", Offset = "0x7AF8170", VA = "0x187AF8D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string OCAHLPMBKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8D60", Offset = "0x7AF8160", VA = "0x187AF8D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7AF8FB0", Offset = "0x7AF83B0", VA = "0x187AF8FB0")]
	public static string IEJJNMICACF([Optional] string BPLIDJEJLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7AF8EE0", Offset = "0x7AF82E0", VA = "0x187AF8EE0")]
	private static string GCPDOPAHHAG(string BHKOPEBBFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7AF8DF0", Offset = "0x7AF81F0", VA = "0x187AF8DF0")]
	public static void CJHABDLPGEJ(string BHKOPEBBFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7AF8F40", Offset = "0x7AF8340", VA = "0x187AF8F40")]
	public static bool GLMGDJIPJJB(string BHKOPEBBFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7AF9030", Offset = "0x7AF8430", VA = "0x187AF9030")]
	public static void OPKJCLGAGJO(string BHKOPEBBFJK, string AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF8E70", Offset = "0x7AF8270", VA = "0x187AF8E70")]
	public static string GALOFBLPIFN(string BHKOPEBBFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF8D80", Offset = "0x7AF8180", VA = "0x187AF8D80")]
	public static void CGPIGONKJPH(string BHKOPEBBFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
	private static void HNDGFELGBMN()
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
