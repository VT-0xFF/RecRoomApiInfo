using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HEDBHFDOKNI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7A00", Offset = "0x6FD6600", VA = "0x186FD7A00")]
	public static KeepsakeTheme BODBGIPAHKB(this DBLEGAFLABD GAICNONPFPG, Guid NCDLOEBMMGD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FD78F0", Offset = "0x6FD64F0", VA = "0x186FD78F0")]
	public static KeepsakeTheme BODBGIPAHKB(this DBLEGAFLABD GAICNONPFPG, LNCLLEGDNJK NHBCDDMCAAN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7B00", Offset = "0x6FD6700", VA = "0x186FD7B00")]
	public static List<KeepsakeTheme> MKNMCBILCPL(this DBLEGAFLABD GAICNONPFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7860", Offset = "0x6FD6460", VA = "0x186FD7860")]
	public static LNCLLEGDNJK ADCCAMCIFKI(this DBLEGAFLABD GAICNONPFPG, Guid NCDLOEBMMGD)
	{
		return default(LNCLLEGDNJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FD7BB0", Offset = "0x6FD67B0", VA = "0x186FD7BB0")]
	public static int PHKAPKIHHOH(this DBLEGAFLABD GAICNONPFPG, LNCLLEGDNJK PIKCKAKDFFC)
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
