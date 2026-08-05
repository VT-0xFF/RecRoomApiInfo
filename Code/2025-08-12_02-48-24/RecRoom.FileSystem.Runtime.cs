using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AJHNCMDEEOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string FFIDHBBEOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x845ACF0", Offset = "0x84592F0", VA = "0x18845ACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string MCNIGPCOPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x845AD00", Offset = "0x8459300", VA = "0x18845AD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string BOJAANLPADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x845AD00", Offset = "0x8459300", VA = "0x18845AD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string HIBIFAEFGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x845ACF0", Offset = "0x84592F0", VA = "0x18845ACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x845AED0", Offset = "0x84594D0", VA = "0x18845AED0")]
	public static string MOEFEGHPONJ([Optional] string JBGGGMHDAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x845AE70", Offset = "0x8459470", VA = "0x18845AE70")]
	private static string MDCJGAKHACJ(string JKCPEHCGLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x845AD10", Offset = "0x8459310", VA = "0x18845AD10")]
	public static void DCDPDPPIHFA(string JKCPEHCGLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x845AD90", Offset = "0x8459390", VA = "0x18845AD90")]
	public static bool KHMMKOKPGBE(string JKCPEHCGLIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x845AFC0", Offset = "0x84595C0", VA = "0x18845AFC0")]
	public static void PKJJDFFPALL(string JKCPEHCGLIK, string DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x845AE00", Offset = "0x8459400", VA = "0x18845AE00")]
	public static string LEHDBKPNELK(string JKCPEHCGLIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x845AF50", Offset = "0x8459550", VA = "0x18845AF50")]
	public static void OKAMEBOHHMJ(string JKCPEHCGLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void EIDFINPPNNG()
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
