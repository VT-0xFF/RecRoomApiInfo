using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MPFGFGAFBDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string GJCNMNLEBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C67610", Offset = "0x6C66810", VA = "0x186C67610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string LANHOIDPGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C67710", Offset = "0x6C66910", VA = "0x186C67710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string IHEBELIKHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C67710", Offset = "0x6C66910", VA = "0x186C67710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string DCNOOLNJBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C67610", Offset = "0x6C66810", VA = "0x186C67610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C675B0", Offset = "0x6C667B0", VA = "0x186C675B0")]
	private static string CPMKJNAELAL(string PBNPILECCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C67690", Offset = "0x6C66890", VA = "0x186C67690")]
	public static void FABKHOHIKKH(string PBNPILECCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C67720", Offset = "0x6C66920", VA = "0x186C67720")]
	public static bool GNAIJAPJEFE(string PBNPILECCPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C67800", Offset = "0x6C66A00", VA = "0x186C67800")]
	public static void LIANECKHHDL(string PBNPILECCPK, string LJIEGDEDOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C67790", Offset = "0x6C66990", VA = "0x186C67790")]
	public static string HEBKKLPGADN(string PBNPILECCPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C67620", Offset = "0x6C66820", VA = "0x186C67620")]
	public static void ECGMMMHMCCA(string PBNPILECCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void MEALLEBELKP()
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
