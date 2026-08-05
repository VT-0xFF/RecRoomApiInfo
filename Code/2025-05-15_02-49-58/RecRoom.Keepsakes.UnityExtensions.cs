using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MBCJFBDHKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C81FF0", Offset = "0x7C805F0", VA = "0x187C81FF0")]
	public static KeepsakeTheme CLALKOJNLOL(this NKOPLKBCBHN PAKPDHLKNJE, Guid JMMICACHJNH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C81F30", Offset = "0x7C80530", VA = "0x187C81F30")]
	public static KeepsakeTheme CLALKOJNLOL(this NKOPLKBCBHN PAKPDHLKNJE, AFACIFHCNFE PDOFEIFJPIC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C820F0", Offset = "0x7C806F0", VA = "0x187C820F0")]
	public static List<KeepsakeTheme> FBHHOIFPJCB(this NKOPLKBCBHN PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C81E90", Offset = "0x7C80490", VA = "0x187C81E90")]
	public static AFACIFHCNFE BMKMJNPJIMJ(this NKOPLKBCBHN PAKPDHLKNJE, Guid JMMICACHJNH)
	{
		return default(AFACIFHCNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C821C0", Offset = "0x7C807C0", VA = "0x187C821C0")]
	public static int FELGBNANGCJ(this NKOPLKBCBHN PAKPDHLKNJE, AFACIFHCNFE HCKJHIJFJHB)
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
