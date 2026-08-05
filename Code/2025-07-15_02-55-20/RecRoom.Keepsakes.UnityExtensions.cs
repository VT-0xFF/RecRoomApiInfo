using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JNPOJPOLKLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8153480", Offset = "0x8152080", VA = "0x188153480")]
	public static KeepsakeTheme DBOPAFAPLCD(this MOLKACCDFDP GHKGDJLGKOB, Guid FIKJJNJEAPJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8153580", Offset = "0x8152180", VA = "0x188153580")]
	public static KeepsakeTheme DBOPAFAPLCD(this MOLKACCDFDP GHKGDJLGKOB, HINJKNFEFAE JNJLDABAMAL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8153630", Offset = "0x8152230", VA = "0x188153630")]
	public static List<KeepsakeTheme> DGIHEPKCHBH(this MOLKACCDFDP GHKGDJLGKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8153790", Offset = "0x8152390", VA = "0x188153790")]
	public static HINJKNFEFAE JNLBGOEHMHM(this MOLKACCDFDP GHKGDJLGKOB, Guid FIKJJNJEAPJ)
	{
		return default(HINJKNFEFAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8153700", Offset = "0x8152300", VA = "0x188153700")]
	public static int HHKCCCDEDOA(this MOLKACCDFDP GHKGDJLGKOB, HINJKNFEFAE IHIJKMLLOBC)
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
