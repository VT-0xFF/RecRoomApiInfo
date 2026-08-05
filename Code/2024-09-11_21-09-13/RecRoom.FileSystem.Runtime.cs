using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LACFEADBHPH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string EMBGMFLFLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B608A0", Offset = "0x6B5EEA0", VA = "0x186B608A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string FCLABGLDIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6B60A90", Offset = "0x6B5F090", VA = "0x186B60A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string IMIKDDGBFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B60A90", Offset = "0x6B5F090", VA = "0x186B60A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string AHKMCAOKGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B608A0", Offset = "0x6B5EEA0", VA = "0x186B608A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B60AA0", Offset = "0x6B5F0A0", VA = "0x186B60AA0")]
	private static string KJCMPANAJLK(string BICLBBDNKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B60A10", Offset = "0x6B5F010", VA = "0x186B60A10")]
	public static void DPOBPKNGAEM(string BICLBBDNKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B60920", Offset = "0x6B5EF20", VA = "0x186B60920")]
	public static bool BGDLEAEHALN(string BICLBBDNKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B60990", Offset = "0x6B5EF90", VA = "0x186B60990")]
	public static void DBDMJPIJBHI(string BICLBBDNKCN, string JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B608B0", Offset = "0x6B5EEB0", VA = "0x186B608B0")]
	public static string ADIECNNMGDO(string BICLBBDNKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B60B00", Offset = "0x6B5F100", VA = "0x186B60B00")]
	public static void MDPEPNPOPKE(string BICLBBDNKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void KLILEDODMJH()
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
