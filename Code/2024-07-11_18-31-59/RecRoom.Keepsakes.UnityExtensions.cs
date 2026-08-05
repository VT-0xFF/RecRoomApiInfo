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
	[Cpp2IlInjected.Address(RVA = "0x6911B70", Offset = "0x6910570", VA = "0x186911B70")]
	public static KeepsakeTheme PKGIPMOOFHB(this ACAIJMDAAFL GOHDOKCJOFP, Guid IMDIPHCNPIB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6911C60", Offset = "0x6910660", VA = "0x186911C60")]
	public static KeepsakeTheme PKGIPMOOFHB(this ACAIJMDAAFL GOHDOKCJOFP, NIPPJGHMNJM OBJCPNPEOJI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6911A30", Offset = "0x6910430", VA = "0x186911A30")]
	public static List<KeepsakeTheme> FCGLJCFFAAL(this ACAIJMDAAFL GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69119A0", Offset = "0x69103A0", VA = "0x1869119A0")]
	public static NIPPJGHMNJM AHAEKCHKIJN(this ACAIJMDAAFL GOHDOKCJOFP, Guid IMDIPHCNPIB)
	{
		return default(NIPPJGHMNJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6911AF0", Offset = "0x69104F0", VA = "0x186911AF0")]
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
