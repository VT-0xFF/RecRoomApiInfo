using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class INGNKHHDGIE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7960", Offset = "0x5CF6D60", VA = "0x185CF7960")]
	public static KeepsakeTheme BKFGDGLEAOF(this BKHPHMMENFK CCJFCCENPLD, Guid AMLCIGODEFN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CF78B0", Offset = "0x5CF6CB0", VA = "0x185CF78B0")]
	public static KeepsakeTheme BKFGDGLEAOF(this BKHPHMMENFK CCJFCCENPLD, AHMBGFPAINI HCMJMKPCPAA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7A50", Offset = "0x5CF6E50", VA = "0x185CF7A50")]
	public static List<KeepsakeTheme> GMEKKDEDPFG(this BKHPHMMENFK CCJFCCENPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7B10", Offset = "0x5CF6F10", VA = "0x185CF7B10")]
	public static AHMBGFPAINI KHEFADJMOGP(this BKHPHMMENFK CCJFCCENPLD, Guid AMLCIGODEFN)
	{
		return default(AHMBGFPAINI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7BA0", Offset = "0x5CF6FA0", VA = "0x185CF7BA0")]
	public static int OFNBPLPICCB(this BKHPHMMENFK CCJFCCENPLD, AHMBGFPAINI MDABNDNEHFP)
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
