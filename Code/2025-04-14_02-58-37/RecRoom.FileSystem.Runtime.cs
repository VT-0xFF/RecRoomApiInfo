using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ANGHBCJFKKC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string KMMFCANNIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7906850", Offset = "0x7905250", VA = "0x187906850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string EBAHFJPLFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7906580", Offset = "0x7904F80", VA = "0x187906580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string NHCHMHHBGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7906580", Offset = "0x7904F80", VA = "0x187906580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string MHHEBIOEHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7906850", Offset = "0x7905250", VA = "0x187906850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7906590", Offset = "0x7904F90", VA = "0x187906590")]
	public static string DDCDDMIEMDC([Optional] string CMNDDNKKNCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7906610", Offset = "0x7905010", VA = "0x187906610")]
	private static string EGCPCOLLKOG(string LMJJJIGEFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7906670", Offset = "0x7905070", VA = "0x187906670")]
	public static void EIILHBEIMBB(string LMJJJIGEFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7906860", Offset = "0x7905260", VA = "0x187906860")]
	public static bool PJGGABHBLNH(string LMJJJIGEFFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7906760", Offset = "0x7905160", VA = "0x187906760")]
	public static void LCODMGHDBJF(string LMJJJIGEFFK, string DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79066F0", Offset = "0x79050F0", VA = "0x1879066F0")]
	public static string EMHEPJCMMNI(string LMJJJIGEFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x79067E0", Offset = "0x79051E0", VA = "0x1879067E0")]
	public static void LJCHEFBGFKM(string LMJJJIGEFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	private static void DNJEBJBCBCN()
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
