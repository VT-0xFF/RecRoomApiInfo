using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum PJKCCMJGPJG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FNAAPFDANOC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> FCBBIDJLOEI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] NJJNGEOLJIH;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] GCMGDNHNFGI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] OFAFIMIFKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D8BE50", Offset = "0x5D8A650", VA = "0x185D8BE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] OEIBJEBDHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D8BCA0", Offset = "0x5D8A4A0", VA = "0x185D8BCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BE60", Offset = "0x5D8A660", VA = "0x185D8BE60")]
	internal static string[] OCFCOHMJMIB(string[] BEINKKPMHDO, string[] ABGDLEEHOCF, List<string> GCLLJJBGAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BB60", Offset = "0x5D8A360", VA = "0x185D8BB60")]
	public static string ACNMAJEOIDB(string PJCBEHMOMDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D8BC00", Offset = "0x5D8A400", VA = "0x185D8BC00")]
	public static bool GCPCJBIEKPI(string PJCBEHMOMDC)
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
