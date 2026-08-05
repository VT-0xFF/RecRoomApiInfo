using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BDEGKOMDLIF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFAE0", Offset = "0x7FFE0E0", VA = "0x187FFFAE0")]
	public static KeepsakeTheme OIIKPCHIIJH(this MECFDLBDOAJ MIPDPIDNIBN, Guid LDPNMFLPJKL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FFFA20", Offset = "0x7FFE020", VA = "0x187FFFA20")]
	public static KeepsakeTheme OIIKPCHIIJH(this MECFDLBDOAJ MIPDPIDNIBN, DJAEGFIGJOO HPIBAEHAMPI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF820", Offset = "0x7FFDE20", VA = "0x187FFF820")]
	public static List<KeepsakeTheme> AELCJJJFCFL(this MECFDLBDOAJ MIPDPIDNIBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF8F0", Offset = "0x7FFDEF0", VA = "0x187FFF8F0")]
	public static DJAEGFIGJOO GMPMFILNJGO(this MECFDLBDOAJ MIPDPIDNIBN, Guid LDPNMFLPJKL)
	{
		return default(DJAEGFIGJOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FFF990", Offset = "0x7FFDF90", VA = "0x187FFF990")]
	public static int KLDIDPKMKGC(this MECFDLBDOAJ MIPDPIDNIBN, DJAEGFIGJOO PFFBPBHCNNM)
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
