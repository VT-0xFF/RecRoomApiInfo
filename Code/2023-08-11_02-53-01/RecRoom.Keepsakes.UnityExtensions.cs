using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GBBDBALBPBP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F27BE0", Offset = "0x6F263E0", VA = "0x186F27BE0")]
	public static KeepsakeTheme IBLLKKOPOEK(this FDJMJPOBBAH OAFFOBLPFIG, Guid LKGGLHIONPO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F27AD0", Offset = "0x6F262D0", VA = "0x186F27AD0")]
	public static KeepsakeTheme IBLLKKOPOEK(this FDJMJPOBBAH OAFFOBLPFIG, HILCHEIPPND FDPJBFKADEJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F27A20", Offset = "0x6F26220", VA = "0x186F27A20")]
	public static List<KeepsakeTheme> HKKNNNOCDOB(this FDJMJPOBBAH OAFFOBLPFIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F27910", Offset = "0x6F26110", VA = "0x186F27910")]
	public static HILCHEIPPND AGADEFFKNKG(this FDJMJPOBBAH OAFFOBLPFIG, Guid LKGGLHIONPO)
	{
		return default(HILCHEIPPND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F279A0", Offset = "0x6F261A0", VA = "0x186F279A0")]
	public static int BNAIBBDDMLH(this FDJMJPOBBAH OAFFOBLPFIG, HILCHEIPPND OBPJKIHHCKA)
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
