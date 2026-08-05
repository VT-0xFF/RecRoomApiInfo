using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LKFGFCHEPLI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6911A70", Offset = "0x6910270", VA = "0x186911A70")]
	public static KeepsakeTheme PKGIPMOOFHB(this ACAIJMDAAFL GOHDOKCJOFP, Guid IMDIPHCNPIB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6911B60", Offset = "0x6910360", VA = "0x186911B60")]
	public static KeepsakeTheme PKGIPMOOFHB(this ACAIJMDAAFL GOHDOKCJOFP, NIPPJGHMNJM OBJCPNPEOJI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6911930", Offset = "0x6910130", VA = "0x186911930")]
	public static List<KeepsakeTheme> FCGLJCFFAAL(this ACAIJMDAAFL GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69118A0", Offset = "0x69100A0", VA = "0x1869118A0")]
	public static NIPPJGHMNJM AHAEKCHKIJN(this ACAIJMDAAFL GOHDOKCJOFP, Guid IMDIPHCNPIB)
	{
		return default(NIPPJGHMNJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69119F0", Offset = "0x69101F0", VA = "0x1869119F0")]
	public static int LEAJLHAJPGN(this ACAIJMDAAFL GOHDOKCJOFP, NIPPJGHMNJM CKOCGIMJNAL)
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
