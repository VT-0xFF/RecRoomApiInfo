using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EKBPLFKPBNI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string GGLENFALIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D97C10", Offset = "0x7D96A10", VA = "0x187D97C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string ICDHLJJIPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D97A40", Offset = "0x7D96840", VA = "0x187D97A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string BKKPBMNBBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D97A40", Offset = "0x7D96840", VA = "0x187D97A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string KPMBPPLOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D97C10", Offset = "0x7D96A10", VA = "0x187D97C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D979C0", Offset = "0x7D967C0", VA = "0x187D979C0")]
	public static string BBGHHMGMMLN([Optional] string AADKKJPBNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D97AD0", Offset = "0x7D968D0", VA = "0x187D97AD0")]
	private static string KCBBKPFMKOC(string NOBPJADLJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D97A50", Offset = "0x7D96850", VA = "0x187D97A50")]
	public static void EOGGPNANHNI(string NOBPJADLJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D97B30", Offset = "0x7D96930", VA = "0x187D97B30")]
	public static bool LGLOCKMJKBE(string NOBPJADLJBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D97C20", Offset = "0x7D96A20", VA = "0x187D97C20")]
	public static void PGCCCBGNECP(string NOBPJADLJBL, string FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D97BA0", Offset = "0x7D969A0", VA = "0x187D97BA0")]
	public static string MLCAOIMILNH(string NOBPJADLJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D97950", Offset = "0x7D96750", VA = "0x187D97950")]
	public static void ALLLEMPNKPM(string NOBPJADLJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void ACOBKFDODKC()
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
