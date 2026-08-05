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
		[Cpp2IlInjected.Address(RVA = "0x6C47A90", Offset = "0x6C46490", VA = "0x186C47A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string FCLABGLDIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C47C80", Offset = "0x6C46680", VA = "0x186C47C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string IMIKDDGBFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C47C80", Offset = "0x6C46680", VA = "0x186C47C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string AHKMCAOKGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C47A90", Offset = "0x6C46490", VA = "0x186C47A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C47C90", Offset = "0x6C46690", VA = "0x186C47C90")]
	private static string KJCMPANAJLK(string BICLBBDNKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C47C00", Offset = "0x6C46600", VA = "0x186C47C00")]
	public static void DPOBPKNGAEM(string BICLBBDNKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C47B10", Offset = "0x6C46510", VA = "0x186C47B10")]
	public static bool BGDLEAEHALN(string BICLBBDNKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C47B80", Offset = "0x6C46580", VA = "0x186C47B80")]
	public static void DBDMJPIJBHI(string BICLBBDNKCN, string JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C47AA0", Offset = "0x6C464A0", VA = "0x186C47AA0")]
	public static string ADIECNNMGDO(string BICLBBDNKCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C47CF0", Offset = "0x6C466F0", VA = "0x186C47CF0")]
	public static void MDPEPNPOPKE(string BICLBBDNKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
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
