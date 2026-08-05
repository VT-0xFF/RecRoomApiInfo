using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HACCKIENACB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string LILKKCLFCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3A90", Offset = "0x7FA2090", VA = "0x187FA3A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string KBDMOCKFGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3AA0", Offset = "0x7FA20A0", VA = "0x187FA3AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string LPAKFHKABCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3AA0", Offset = "0x7FA20A0", VA = "0x187FA3AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string ADFIBDMOKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FA3A90", Offset = "0x7FA2090", VA = "0x187FA3A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3BA0", Offset = "0x7FA21A0", VA = "0x187FA3BA0")]
	public static string KEPFKIJCPAP([Optional] string PBLIKPCNFGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3D80", Offset = "0x7FA2380", VA = "0x187FA3D80")]
	private static string NALMGKLOMKE(string HIOPFIEJGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3AB0", Offset = "0x7FA20B0", VA = "0x187FA3AB0")]
	public static void GPMCIAEMHPJ(string HIOPFIEJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3D10", Offset = "0x7FA2310", VA = "0x187FA3D10")]
	public static bool MPEOJHHHGNC(string HIOPFIEJGKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3C20", Offset = "0x7FA2220", VA = "0x187FA3C20")]
	public static void LNFOOKOIFKE(string HIOPFIEJGKH, string ACJFHCNBBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3B30", Offset = "0x7FA2130", VA = "0x187FA3B30")]
	public static string IAKIGEGCFPH(string HIOPFIEJGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FA3CA0", Offset = "0x7FA22A0", VA = "0x187FA3CA0")]
	public static void MNIPMCGANEE(string HIOPFIEJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
	private static void NNNCBDBCFGK()
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
