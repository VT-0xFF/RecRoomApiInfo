using System;
using System.Globalization;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EFLMALILPON
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static char? LPHBAMEAEKP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static string HPDABKNDBIB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CultureInfo POGDLELMLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3669610", Offset = "0x3668410", VA = "0x183669610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static char MFDJGFNJAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3669660", Offset = "0x3668460", VA = "0x183669660")]
		get
		{
			return default(char);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string AJFHFCFAJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3669860", Offset = "0x3668660", VA = "0x183669860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36696B0", Offset = "0x36684B0", VA = "0x1836696B0")]
	public static bool CDODNKDNEBP(string MJECHIGBFPD, out float KBMKKHCLKJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3669610", Offset = "0x3668410", VA = "0x183669610")]
	private static CultureInfo NAGCHPOJOPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3669730", Offset = "0x3668530", VA = "0x183669730")]
	private static void FPMKMIIFAEL()
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
