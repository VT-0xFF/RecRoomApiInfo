using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AOLEOBCDFDK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FFCB60", Offset = "0x5FFB560", VA = "0x185FFCB60")]
	public static KeepsakeTheme CJKCMPAADEB(this HGMPDHJFIFG FKFIJGNHDJN, Guid PCOKCDLEHCJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FFCC50", Offset = "0x5FFB650", VA = "0x185FFCC50")]
	public static KeepsakeTheme CJKCMPAADEB(this HGMPDHJFIFG FKFIJGNHDJN, HFMMDPIDLMH DNMCENONBHL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FFCD00", Offset = "0x5FFB700", VA = "0x185FFCD00")]
	public static List<KeepsakeTheme> CKEFBIGEMBL(this HGMPDHJFIFG FKFIJGNHDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FFCDC0", Offset = "0x5FFB7C0", VA = "0x185FFCDC0")]
	public static HFMMDPIDLMH DOGEFKNGKAG(this HGMPDHJFIFG FKFIJGNHDJN, Guid PCOKCDLEHCJ)
	{
		return default(HFMMDPIDLMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FFCAE0", Offset = "0x5FFB4E0", VA = "0x185FFCAE0")]
	public static int ACGMDFDJNHM(this HGMPDHJFIFG FKFIJGNHDJN, HFMMDPIDLMH MGKNNIMFEDM)
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
