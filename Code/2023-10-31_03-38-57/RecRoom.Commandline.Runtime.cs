using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PBAAHNCJGPE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ILMBPGNBAMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> PIPDEJMPPAN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] ABIHNHNBPJM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] DFJIEOAOJAF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] AIJDLHFKAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BFCBE0", Offset = "0x5BFBFE0", VA = "0x185BFCBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] LCBBJAEEFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BFCBF0", Offset = "0x5BFBFF0", VA = "0x185BFCBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BFCDA0", Offset = "0x5BFC1A0", VA = "0x185BFCDA0")]
	internal static string[] LKKGEELIGKN(string[] CKEAIBIAOMA, string[] MHLLAEHADIK, List<string> HKCPIEDDPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BFCEC0", Offset = "0x5BFC2C0", VA = "0x185BFCEC0")]
	public static string MLGJODAJNJC(string FNMHNJPNNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BFCB40", Offset = "0x5BFBF40", VA = "0x185BFCB40")]
	public static bool DIOMIHGCEPC(string FNMHNJPNNBG)
	{
		return default(bool);
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
