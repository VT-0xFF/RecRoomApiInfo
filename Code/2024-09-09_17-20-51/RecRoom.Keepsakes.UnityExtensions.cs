using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BKFBLNANECC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2100", Offset = "0x6BD0B00", VA = "0x186BD2100")]
	public static KeepsakeTheme MLKLLMBMNJF(this IDLEPFJPCFD PEDEFMGDCEP, Guid PFKGIENKOJN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2040", Offset = "0x6BD0A40", VA = "0x186BD2040")]
	public static KeepsakeTheme MLKLLMBMNJF(this IDLEPFJPCFD PEDEFMGDCEP, GAPPDCPCNCP MDFBIIACEHC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1F70", Offset = "0x6BD0970", VA = "0x186BD1F70")]
	public static List<KeepsakeTheme> KGFLODBFIEI(this IDLEPFJPCFD PEDEFMGDCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2200", Offset = "0x6BD0C00", VA = "0x186BD2200")]
	public static GAPPDCPCNCP NHPMLBAPOPB(this IDLEPFJPCFD PEDEFMGDCEP, Guid PFKGIENKOJN)
	{
		return default(GAPPDCPCNCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1EE0", Offset = "0x6BD08E0", VA = "0x186BD1EE0")]
	public static int EPGKONLNIEL(this IDLEPFJPCFD PEDEFMGDCEP, GAPPDCPCNCP DLBPCHBONCJ)
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
