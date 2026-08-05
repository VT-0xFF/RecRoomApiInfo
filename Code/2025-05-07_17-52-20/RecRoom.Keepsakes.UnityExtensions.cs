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
	[Cpp2IlInjected.Address(RVA = "0x7CB6AD0", Offset = "0x7CB5AD0", VA = "0x187CB6AD0")]
	public static KeepsakeTheme CLALKOJNLOL(this NKOPLKBCBHN PAKPDHLKNJE, Guid JMMICACHJNH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6A20", Offset = "0x7CB5A20", VA = "0x187CB6A20")]
	public static KeepsakeTheme CLALKOJNLOL(this NKOPLKBCBHN PAKPDHLKNJE, AFACIFHCNFE PDOFEIFJPIC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6BD0", Offset = "0x7CB5BD0", VA = "0x187CB6BD0")]
	public static List<KeepsakeTheme> FBHHOIFPJCB(this NKOPLKBCBHN PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6980", Offset = "0x7CB5980", VA = "0x187CB6980")]
	public static AFACIFHCNFE BMKMJNPJIMJ(this NKOPLKBCBHN PAKPDHLKNJE, Guid JMMICACHJNH)
	{
		return default(AFACIFHCNFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CB6CA0", Offset = "0x7CB5CA0", VA = "0x187CB6CA0")]
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
