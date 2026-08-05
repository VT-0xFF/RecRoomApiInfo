using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LMEALDPBJKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5DC0", Offset = "0x7FF45C0", VA = "0x187FF5DC0")]
	public static KeepsakeTheme JACKJMIOEGD(this NBDBLHCMOOG EGOJLGMOLFK, Guid EHGGCLOFHJH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5D10", Offset = "0x7FF4510", VA = "0x187FF5D10")]
	public static KeepsakeTheme JACKJMIOEGD(this NBDBLHCMOOG EGOJLGMOLFK, FENEICOAGDP HKEBFFKEPOD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5C40", Offset = "0x7FF4440", VA = "0x187FF5C40")]
	public static List<KeepsakeTheme> GJGFJPDELMK(this NBDBLHCMOOG EGOJLGMOLFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5F50", Offset = "0x7FF4750", VA = "0x187FF5F50")]
	public static FENEICOAGDP NFFLHNNAKNO(this NBDBLHCMOOG EGOJLGMOLFK, Guid EHGGCLOFHJH)
	{
		return default(FENEICOAGDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FF5EC0", Offset = "0x7FF46C0", VA = "0x187FF5EC0")]
	public static int JDBFDINPLEO(this NBDBLHCMOOG EGOJLGMOLFK, FENEICOAGDP FKGFACJAFLC)
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
