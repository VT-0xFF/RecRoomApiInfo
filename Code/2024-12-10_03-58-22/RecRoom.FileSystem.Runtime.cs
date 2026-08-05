using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JMCPHGHNOCE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string NJIFJFHLIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C460D0", Offset = "0x6C44CD0", VA = "0x186C460D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string BBFDNEBOJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C460E0", Offset = "0x6C44CE0", VA = "0x186C460E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string KBGOACEBPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C460E0", Offset = "0x6C44CE0", VA = "0x186C460E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string KBBFHKHIPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C460D0", Offset = "0x6C44CD0", VA = "0x186C460D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C46340", Offset = "0x6C44F40", VA = "0x186C46340")]
	private static string MKEPNOOPMGL(string BJNACHPNEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C46240", Offset = "0x6C44E40", VA = "0x186C46240")]
	public static void KKBODJMJPEL(string BJNACHPNEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C46160", Offset = "0x6C44D60", VA = "0x186C46160")]
	public static bool KECKILCPCAE(string BJNACHPNEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C462C0", Offset = "0x6C44EC0", VA = "0x186C462C0")]
	public static void MHPEGJHIDOG(string BJNACHPNEEP, string BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C461D0", Offset = "0x6C44DD0", VA = "0x186C461D0")]
	public static string KHEPIHBIJDP(string BJNACHPNEEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C460F0", Offset = "0x6C44CF0", VA = "0x186C460F0")]
	public static void GDJMNGJPAGP(string BJNACHPNEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	private static void BAMCFMCAAOJ()
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
