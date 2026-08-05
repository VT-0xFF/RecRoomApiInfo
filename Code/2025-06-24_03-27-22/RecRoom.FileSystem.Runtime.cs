using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NEHJEGJLBCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string EGLEPCBKFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1D50", Offset = "0x7DC0950", VA = "0x187DC1D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string BIOMGFIGCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1ED0", Offset = "0x7DC0AD0", VA = "0x187DC1ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string AFDNJCBODCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1ED0", Offset = "0x7DC0AD0", VA = "0x187DC1ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string NJJGBFIMLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1D50", Offset = "0x7DC0950", VA = "0x187DC1D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DC2020", Offset = "0x7DC0C20", VA = "0x187DC2020")]
	public static string PEKHABENDFH([Optional] string OHJFOIKDMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1FC0", Offset = "0x7DC0BC0", VA = "0x187DC1FC0")]
	private static string NAEFMCAKHJP(string MCLDNGJMMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1D60", Offset = "0x7DC0960", VA = "0x187DC1D60")]
	public static void EIDJFIHKNEN(string MCLDNGJMMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1F50", Offset = "0x7DC0B50", VA = "0x187DC1F50")]
	public static bool KDBGFMIINLE(string MCLDNGJMMPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1E50", Offset = "0x7DC0A50", VA = "0x187DC1E50")]
	public static void GJEKGKPPPDO(string MCLDNGJMMPC, string PEDMEJIDLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1EE0", Offset = "0x7DC0AE0", VA = "0x187DC1EE0")]
	public static string IGLIIBBPPDE(string MCLDNGJMMPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7DC1DE0", Offset = "0x7DC09E0", VA = "0x187DC1DE0")]
	public static void FJLCEJFLIPD(string MCLDNGJMMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void HFNJJCFLODL()
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
