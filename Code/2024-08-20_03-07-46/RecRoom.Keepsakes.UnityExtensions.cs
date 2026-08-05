using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NOABHDNBDDG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69B4CC0", Offset = "0x69B3CC0", VA = "0x1869B4CC0")]
	public static KeepsakeTheme NOHCAOBJHNI(this FLPMHBMGMKF HADKCEDAMNP, Guid IIFFOFLIAJN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69B4C20", Offset = "0x69B3C20", VA = "0x1869B4C20")]
	public static KeepsakeTheme NOHCAOBJHNI(this FLPMHBMGMKF HADKCEDAMNP, KEAEDCOMCGE IENAHOFFMBM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69B4AD0", Offset = "0x69B3AD0", VA = "0x1869B4AD0")]
	public static List<KeepsakeTheme> IJDOMAFHABK(this FLPMHBMGMKF HADKCEDAMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69B4B90", Offset = "0x69B3B90", VA = "0x1869B4B90")]
	public static KEAEDCOMCGE MDCMAPPJJKJ(this FLPMHBMGMKF HADKCEDAMNP, Guid IIFFOFLIAJN)
	{
		return default(KEAEDCOMCGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69B4A50", Offset = "0x69B3A50", VA = "0x1869B4A50")]
	public static int FDCDJEIAHIN(this FLPMHBMGMKF HADKCEDAMNP, KEAEDCOMCGE MENDAEIFIHE)
	{
		return default(int);
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
