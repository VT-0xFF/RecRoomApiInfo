using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BJAFNFEIJCL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x688DB40", Offset = "0x688C340", VA = "0x18688DB40")]
	public static KeepsakeTheme ODMJDJKEOIP(this NPBKCBHNMCM KOFDOJONBID, Guid KODBMCEMBGH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x688DC30", Offset = "0x688C430", VA = "0x18688DC30")]
	public static KeepsakeTheme ODMJDJKEOIP(this NPBKCBHNMCM KOFDOJONBID, FLNOLEHFNJH EKLONNHGDDI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x688DA00", Offset = "0x688C200", VA = "0x18688DA00")]
	public static List<KeepsakeTheme> IEIOAKNMMLN(this NPBKCBHNMCM KOFDOJONBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x688D970", Offset = "0x688C170", VA = "0x18688D970")]
	public static FLNOLEHFNJH ANFJALBHPEF(this NPBKCBHNMCM KOFDOJONBID, Guid KODBMCEMBGH)
	{
		return default(FLNOLEHFNJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x688DAC0", Offset = "0x688C2C0", VA = "0x18688DAC0")]
	public static int OALMKOEIJGG(this NPBKCBHNMCM KOFDOJONBID, FLNOLEHFNJH KGLKJEOIFJL)
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
