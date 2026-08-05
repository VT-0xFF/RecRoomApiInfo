using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DDBOIJKDGEL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string AFFMBJLGKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84F7840", Offset = "0x84F5E40", VA = "0x1884F7840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string DKGNCHIOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84F7570", Offset = "0x84F5B70", VA = "0x1884F7570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string EJCJNHMFNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84F7570", Offset = "0x84F5B70", VA = "0x1884F7570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string LLEHGGPAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84F7840", Offset = "0x84F5E40", VA = "0x1884F7840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84F75F0", Offset = "0x84F5BF0", VA = "0x1884F75F0")]
	public static string DHCJHIIGBLH([Optional] string GMOHGFCEGIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84F76F0", Offset = "0x84F5CF0", VA = "0x1884F76F0")]
	private static string GEBPEBCICPB(string BFHDBHOMJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84F7750", Offset = "0x84F5D50", VA = "0x1884F7750")]
	public static void INOOJLCOACB(string BFHDBHOMJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84F7580", Offset = "0x84F5B80", VA = "0x1884F7580")]
	public static bool CGBMIIPAOLG(string BFHDBHOMJKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84F7670", Offset = "0x84F5C70", VA = "0x1884F7670")]
	public static void DHFGFINLJIH(string BFHDBHOMJKM, string CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84F7850", Offset = "0x84F5E50", VA = "0x1884F7850")]
	public static string OAFMMCNCHNE(string BFHDBHOMJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84F77D0", Offset = "0x84F5DD0", VA = "0x1884F77D0")]
	public static void KGIFNMOIJPP(string BFHDBHOMJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private static void CEONCHAMOPB()
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
