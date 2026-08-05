using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FHCENLGINIA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string IDGBNNMKGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7810C20", Offset = "0x7810020", VA = "0x187810C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string MPBLNMFPMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7810BB0", Offset = "0x780FFB0", VA = "0x187810BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string FKDKNNPPODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7810BB0", Offset = "0x780FFB0", VA = "0x187810BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string EOBBKJJGELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7810C20", Offset = "0x7810020", VA = "0x187810C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7810BC0", Offset = "0x780FFC0", VA = "0x187810BC0")]
	private static string DHBFLAKGLOF(string PMILCDIBAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7810D80", Offset = "0x7810180", VA = "0x187810D80")]
	public static void MFKKMMPOPFI(string PMILCDIBAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7810D10", Offset = "0x7810110", VA = "0x187810D10")]
	public static bool KPFJHHFNLIA(string PMILCDIBAOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7810B30", Offset = "0x780FF30", VA = "0x187810B30")]
	public static void AMLMKDKFEJH(string PMILCDIBAOD, string AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7810C30", Offset = "0x7810030", VA = "0x187810C30")]
	public static string IFEBCHDFDAM(string PMILCDIBAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7810CA0", Offset = "0x78100A0", VA = "0x187810CA0")]
	public static void IIPMHHGILCH(string PMILCDIBAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	private static void DJENJICFHPF()
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
