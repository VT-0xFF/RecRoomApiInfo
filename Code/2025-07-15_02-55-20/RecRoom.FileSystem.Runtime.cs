using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CKDBMDBLGNL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string IIFNBPMNLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80F6B20", Offset = "0x80F5720", VA = "0x1880F6B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string JGBBHMKJNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80F6C00", Offset = "0x80F5800", VA = "0x1880F6C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string HBLMLCAAEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80F6C00", Offset = "0x80F5800", VA = "0x1880F6C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string PENEAMNFMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80F6B20", Offset = "0x80F5720", VA = "0x1880F6B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x80F6C10", Offset = "0x80F5810", VA = "0x1880F6C10")]
	public static string IFIIPHOHMFB([Optional] string MICLGNPFFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80F6BA0", Offset = "0x80F57A0", VA = "0x1880F6BA0")]
	private static string GJAILEOLCOM(string OKJOHKDNPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80F6D80", Offset = "0x80F5980", VA = "0x1880F6D80")]
	public static void ONMNJDGMCID(string OKJOHKDNPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80F6B30", Offset = "0x80F5730", VA = "0x1880F6B30")]
	public static bool EDDIMBNDPJO(string OKJOHKDNPGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80F6C90", Offset = "0x80F5890", VA = "0x1880F6C90")]
	public static void INNILPPPMBM(string OKJOHKDNPGK, string CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x80F6D10", Offset = "0x80F5910", VA = "0x1880F6D10")]
	public static string MKEMKKLJIIC(string OKJOHKDNPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x80F6E00", Offset = "0x80F5A00", VA = "0x1880F6E00")]
	public static void PAEGKIFDNPC(string OKJOHKDNPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	private static void NLHHJMAFPNF()
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
