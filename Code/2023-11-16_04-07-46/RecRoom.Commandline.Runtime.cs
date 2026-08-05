using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum EDIJAMHCJBB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JEKOMFBFHMK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> CCOMKJOIEGL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] MDGDPEEHGAG;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] JONLIMCIHMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] ENIPHHKEKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D6F490", Offset = "0x5D6E490", VA = "0x185D6F490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] AAKLICMHMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D6F2E0", Offset = "0x5D6E2E0", VA = "0x185D6F2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F4A0", Offset = "0x5D6E4A0", VA = "0x185D6F4A0")]
	internal static string[] KIPEGEMKPMB(string[] LFMAJNOKMCD, string[] KDIKLGNDEPL, List<string> NLHHNKFOIDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F240", Offset = "0x5D6E240", VA = "0x185D6F240")]
	public static string BPOKCBIENJN(string OGCJFLBKOOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D6F1A0", Offset = "0x5D6E1A0", VA = "0x185D6F1A0")]
	public static bool BLCGGNMCPFI(string OGCJFLBKOOA)
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
