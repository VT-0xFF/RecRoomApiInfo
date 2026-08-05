using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LFFBCGBFKPO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string FPCCDNKPMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C92A80", Offset = "0x7C91C80", VA = "0x187C92A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string NIKNKEGCMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C92A90", Offset = "0x7C91C90", VA = "0x187C92A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string LLJLLKAKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C92A90", Offset = "0x7C91C90", VA = "0x187C92A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string NPDLOAJDJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C92A80", Offset = "0x7C91C80", VA = "0x187C92A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C92AA0", Offset = "0x7C91CA0", VA = "0x187C92AA0")]
	public static string EIBNEKMFNLJ([Optional] string KHCGHPAKOMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C92C10", Offset = "0x7C91E10", VA = "0x187C92C10")]
	private static string IGLGDMMAEMG(string PJPBBAPADDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C92B20", Offset = "0x7C91D20", VA = "0x187C92B20")]
	public static void HAEMKKCNBOL(string PJPBBAPADDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C92D60", Offset = "0x7C91F60", VA = "0x187C92D60")]
	public static bool NOEAKDCCJGF(string PJPBBAPADDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C92CE0", Offset = "0x7C91EE0", VA = "0x187C92CE0")]
	public static void NABHODNMINJ(string PJPBBAPADDN, string DHAOEHNLNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C92C70", Offset = "0x7C91E70", VA = "0x187C92C70")]
	public static string JONDKHOMMKI(string PJPBBAPADDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C92BA0", Offset = "0x7C91DA0", VA = "0x187C92BA0")]
	public static void HNIGDAMADKN(string PJPBBAPADDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
	private static void KJGEEEGHEHO()
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
