using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NMGNHIGAAPA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EHADCKEBOIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> EDOKJAEJMNB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] BMLDMIAPJOB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] NMGOPHGPFIN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] FPEHJMEDPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D360", Offset = "0x5D8C760", VA = "0x185D8D360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] DKMDHGFMBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D1B0", Offset = "0x5D8C5B0", VA = "0x185D8D1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D8CFF0", Offset = "0x5D8C3F0", VA = "0x185D8CFF0")]
	internal static string[] AGDNEEJMAMA(string[] BMNCMMLFAHC, string[] ODEJHDKOEAO, List<string> CJAPMFAKJNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D110", Offset = "0x5D8C510", VA = "0x185D8D110")]
	public static string GFPHBGLGIAJ(string NFLINLJKKJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D370", Offset = "0x5D8C770", VA = "0x185D8D370")]
	public static bool MAGBODMKMEC(string NFLINLJKKJO)
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
