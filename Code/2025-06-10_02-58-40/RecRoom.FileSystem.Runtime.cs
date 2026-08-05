using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KNONKECGMFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string KGGBLJOFACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F8C0", Offset = "0x7C4EAC0", VA = "0x187C4F8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string AKABIPAFIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F850", Offset = "0x7C4EA50", VA = "0x187C4F850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string KAHOCPJMFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F850", Offset = "0x7C4EA50", VA = "0x187C4F850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string JIKJAMDLPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F8C0", Offset = "0x7C4EAC0", VA = "0x187C4F8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C4FA30", Offset = "0x7C4EC30", VA = "0x187C4FA30")]
	public static string NAHCMOAFEHJ([Optional] string DONPPANJBAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F860", Offset = "0x7C4EA60", VA = "0x187C4F860")]
	private static string HFPHAPADJGG(string BLOCNHOFANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C4FAB0", Offset = "0x7C4ECB0", VA = "0x187C4FAB0")]
	public static void OKMMLIBIPEJ(string BLOCNHOFANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F950", Offset = "0x7C4EB50", VA = "0x187C4F950")]
	public static bool KMEKMAOJJAN(string BLOCNHOFANF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F8D0", Offset = "0x7C4EAD0", VA = "0x187C4F8D0")]
	public static void KLBFLGEAPDH(string BLOCNHOFANF, string CAIGHLKIDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F7E0", Offset = "0x7C4E9E0", VA = "0x187C4F7E0")]
	public static string AOCICDCHOCM(string BLOCNHOFANF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C4F9C0", Offset = "0x7C4EBC0", VA = "0x187C4F9C0")]
	public static void LGAFMJCNLAJ(string BLOCNHOFANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60")]
	private static void LICACLGEHBA()
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
