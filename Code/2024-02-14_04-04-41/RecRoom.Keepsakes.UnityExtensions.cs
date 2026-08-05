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
	[Cpp2IlInjected.Address(RVA = "0x5F83310", Offset = "0x5F82710", VA = "0x185F83310")]
	public static KeepsakeTheme CJKCMPAADEB(this HGMPDHJFIFG FKFIJGNHDJN, Guid PCOKCDLEHCJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F83400", Offset = "0x5F82800", VA = "0x185F83400")]
	public static KeepsakeTheme CJKCMPAADEB(this HGMPDHJFIFG FKFIJGNHDJN, HFMMDPIDLMH DNMCENONBHL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F834B0", Offset = "0x5F828B0", VA = "0x185F834B0")]
	public static List<KeepsakeTheme> CKEFBIGEMBL(this HGMPDHJFIFG FKFIJGNHDJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F83570", Offset = "0x5F82970", VA = "0x185F83570")]
	public static HFMMDPIDLMH DOGEFKNGKAG(this HGMPDHJFIFG FKFIJGNHDJN, Guid PCOKCDLEHCJ)
	{
		return default(HFMMDPIDLMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F83290", Offset = "0x5F82690", VA = "0x185F83290")]
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
