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
	[Cpp2IlInjected.Address(RVA = "0x692BE60", Offset = "0x692B060", VA = "0x18692BE60")]
	public static KeepsakeTheme PKGIPMOOFHB(this ACAIJMDAAFL GOHDOKCJOFP, Guid IMDIPHCNPIB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x692BF50", Offset = "0x692B150", VA = "0x18692BF50")]
	public static KeepsakeTheme PKGIPMOOFHB(this ACAIJMDAAFL GOHDOKCJOFP, NIPPJGHMNJM OBJCPNPEOJI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x692BD20", Offset = "0x692AF20", VA = "0x18692BD20")]
	public static List<KeepsakeTheme> FCGLJCFFAAL(this ACAIJMDAAFL GOHDOKCJOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x692BC90", Offset = "0x692AE90", VA = "0x18692BC90")]
	public static NIPPJGHMNJM AHAEKCHKIJN(this ACAIJMDAAFL GOHDOKCJOFP, Guid IMDIPHCNPIB)
	{
		return default(NIPPJGHMNJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x692BDE0", Offset = "0x692AFE0", VA = "0x18692BDE0")]
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
