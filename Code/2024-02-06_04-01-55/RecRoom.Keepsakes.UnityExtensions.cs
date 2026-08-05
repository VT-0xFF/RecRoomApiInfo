using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DGJGFJCIPNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60AB7D0", Offset = "0x60AABD0", VA = "0x1860AB7D0")]
	public static KeepsakeTheme HKCLCJBIOOC(this IDBFMLEOKFI IALOIPDIIAG, Guid JKBCBKNFNIG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60AB8C0", Offset = "0x60AACC0", VA = "0x1860AB8C0")]
	public static KeepsakeTheme HKCLCJBIOOC(this IDBFMLEOKFI IALOIPDIIAG, MHFCDHEHNAN JHNPKJNGHMD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60AB970", Offset = "0x60AAD70", VA = "0x1860AB970")]
	public static List<KeepsakeTheme> IEOLLAGKCDN(this IDBFMLEOKFI IALOIPDIIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60ABA30", Offset = "0x60AAE30", VA = "0x1860ABA30")]
	public static MHFCDHEHNAN JDLAHCCFGFJ(this IDBFMLEOKFI IALOIPDIIAG, Guid JKBCBKNFNIG)
	{
		return default(MHFCDHEHNAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60ABAC0", Offset = "0x60AAEC0", VA = "0x1860ABAC0")]
	public static int JKCEBAOPMKL(this IDBFMLEOKFI IALOIPDIIAG, MHFCDHEHNAN HKIILMNBMEC)
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
