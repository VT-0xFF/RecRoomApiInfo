using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KGAIFPFLLAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string HMGMNGFODJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B560", Offset = "0x7F99D60", VA = "0x187F9B560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string FHDPKFAIHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B4E0", Offset = "0x7F99CE0", VA = "0x187F9B4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string PNCIJKLOCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B4E0", Offset = "0x7F99CE0", VA = "0x187F9B4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string KPGCKMBGIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F9B560", Offset = "0x7F99D60", VA = "0x187F9B560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B570", Offset = "0x7F99D70", VA = "0x187F9B570")]
	public static string FLGACEIHMHB([Optional] string JIIMMFPIIBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B400", Offset = "0x7F99C00", VA = "0x187F9B400")]
	private static string BMLMGMEOFPI(string KBIHAKCHLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B460", Offset = "0x7F99C60", VA = "0x187F9B460")]
	public static void CKHIDMBDEHH(string KBIHAKCHLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B660", Offset = "0x7F99E60", VA = "0x187F9B660")]
	public static bool OBMCNPCFMFK(string KBIHAKCHLAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B380", Offset = "0x7F99B80", VA = "0x187F9B380")]
	public static void ADENKDIEJEM(string KBIHAKCHLAI, string IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B4F0", Offset = "0x7F99CF0", VA = "0x187F9B4F0")]
	public static string DANKBKDDMDI(string KBIHAKCHLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F9B5F0", Offset = "0x7F99DF0", VA = "0x187F9B5F0")]
	public static void GHCJGPOCMED(string KBIHAKCHLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
	private static void FBMOHPKOEGG()
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
