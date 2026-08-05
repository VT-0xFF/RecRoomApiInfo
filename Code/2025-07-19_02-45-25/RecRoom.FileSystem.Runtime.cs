using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MFDBAHOPPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string EIKOIMPOJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x816A2A0", Offset = "0x81692A0", VA = "0x18816A2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string HGKEIECBLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x816A2B0", Offset = "0x81692B0", VA = "0x18816A2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string NCBOCHKGIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x816A2B0", Offset = "0x81692B0", VA = "0x18816A2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string LKAAAIIBHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x816A2A0", Offset = "0x81692A0", VA = "0x18816A2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x816A320", Offset = "0x8169320", VA = "0x18816A320")]
	public static string MCLBPNBEMHE([Optional] string IHDKJKJDOJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x816A2C0", Offset = "0x81692C0", VA = "0x18816A2C0")]
	private static string IOCHBDJADJA(string AIPDNDCFPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x816A3A0", Offset = "0x81693A0", VA = "0x18816A3A0")]
	public static void PNGGPFKDGBH(string AIPDNDCFPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x816A140", Offset = "0x8169140", VA = "0x18816A140")]
	public static bool DJHHJGIMGHN(string AIPDNDCFPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x816A220", Offset = "0x8169220", VA = "0x18816A220")]
	public static void HHLMDBAPOFB(string AIPDNDCFPID, string INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x816A1B0", Offset = "0x81691B0", VA = "0x18816A1B0")]
	public static string EMOKDJHHMMA(string AIPDNDCFPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x816A0D0", Offset = "0x81690D0", VA = "0x18816A0D0")]
	public static void BNEJNIMPHLH(string AIPDNDCFPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	private static void IABDPJKCGGA()
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
