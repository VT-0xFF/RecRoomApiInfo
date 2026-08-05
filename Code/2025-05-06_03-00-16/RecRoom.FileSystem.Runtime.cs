using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ACOKABIFFHL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string IFMLHPBNFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B23DF0", Offset = "0x7B225F0", VA = "0x187B23DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string PEOHBAHNIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B24030", Offset = "0x7B22830", VA = "0x187B24030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string GBHJKKOHDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B24030", Offset = "0x7B22830", VA = "0x187B24030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string LIJAJPJGKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B23DF0", Offset = "0x7B225F0", VA = "0x187B23DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B23D70", Offset = "0x7B22570", VA = "0x187B23D70")]
	public static string CFCKDLJFAJL([Optional] string JONKJCBBMCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B23E00", Offset = "0x7B22600", VA = "0x187B23E00")]
	private static string ELBEAANGEIM(string CGOKOPBMMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B23CF0", Offset = "0x7B224F0", VA = "0x187B23CF0")]
	public static void AEFFCADLHHO(string CGOKOPBMMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B23F50", Offset = "0x7B22750", VA = "0x187B23F50")]
	public static bool JICEPJBJFFM(string CGOKOPBMMLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B23ED0", Offset = "0x7B226D0", VA = "0x187B23ED0")]
	public static void HEEOMOLLHKB(string CGOKOPBMMLE, string NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B23FC0", Offset = "0x7B227C0", VA = "0x187B23FC0")]
	public static string LIOLCICHMPH(string CGOKOPBMMLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B23E60", Offset = "0x7B22660", VA = "0x187B23E60")]
	public static void FEOFHGHFEMK(string CGOKOPBMMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void CDKOJALPPDG()
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
