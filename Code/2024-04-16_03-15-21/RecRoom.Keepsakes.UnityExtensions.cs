using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ABNCEAJKPHC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6169E50", Offset = "0x6169050", VA = "0x186169E50")]
	public static KeepsakeTheme LONNKNADGED(this JKGKOOLOAGE JPFNBECBJPL, Guid GEAHAAAJNOC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6169F40", Offset = "0x6169140", VA = "0x186169F40")]
	public static KeepsakeTheme LONNKNADGED(this JKGKOOLOAGE JPFNBECBJPL, ABCEDIFEFAO DFBKDOCOKKK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6169D10", Offset = "0x6168F10", VA = "0x186169D10")]
	public static List<KeepsakeTheme> ALLFNDGCPKI(this JKGKOOLOAGE JPFNBECBJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6169FE0", Offset = "0x61691E0", VA = "0x186169FE0")]
	public static ABCEDIFEFAO OLJMFHPGPLJ(this JKGKOOLOAGE JPFNBECBJPL, Guid GEAHAAAJNOC)
	{
		return default(ABCEDIFEFAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6169DD0", Offset = "0x6168FD0", VA = "0x186169DD0")]
	public static int FPNDOBGHGIB(this JKGKOOLOAGE JPFNBECBJPL, ABCEDIFEFAO CAFCKFHOJBA)
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
