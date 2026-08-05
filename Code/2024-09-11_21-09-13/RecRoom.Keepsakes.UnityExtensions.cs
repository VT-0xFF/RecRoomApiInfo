using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CJMOEKMIJCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BA6410", Offset = "0x6BA4A10", VA = "0x186BA6410")]
	public static KeepsakeTheme LIEDILONLCE(this KOEENFFKAEH EHABNPPLNPG, Guid OIHIGEJBGDG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BA6370", Offset = "0x6BA4970", VA = "0x186BA6370")]
	public static KeepsakeTheme LIEDILONLCE(this KOEENFFKAEH EHABNPPLNPG, DGKKLHHODBM CAMPMAKCDLJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BA62B0", Offset = "0x6BA48B0", VA = "0x186BA62B0")]
	public static List<KeepsakeTheme> FNNLMBGMCAA(this KOEENFFKAEH EHABNPPLNPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BA6500", Offset = "0x6BA4B00", VA = "0x186BA6500")]
	public static DGKKLHHODBM NHBLAJEMGHB(this KOEENFFKAEH EHABNPPLNPG, Guid OIHIGEJBGDG)
	{
		return default(DGKKLHHODBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BA6590", Offset = "0x6BA4B90", VA = "0x186BA6590")]
	public static int OLLAMBBHOKM(this KOEENFFKAEH EHABNPPLNPG, DGKKLHHODBM BNCHBFDCBEE)
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
