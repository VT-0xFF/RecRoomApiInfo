using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PDJLBDECDPH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x615CD70", Offset = "0x615B970", VA = "0x18615CD70")]
	public static KeepsakeTheme CPBDAILINMJ(this FJCFMFAJNGI DFCFBMIMDHA, Guid HFBDJOHJNOI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x615CE60", Offset = "0x615BA60", VA = "0x18615CE60")]
	public static KeepsakeTheme CPBDAILINMJ(this FJCFMFAJNGI DFCFBMIMDHA, ENHJGGFDCML EBCIMBLDHEK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x615CF90", Offset = "0x615BB90", VA = "0x18615CF90")]
	public static List<KeepsakeTheme> LHIICBFPKFK(this FJCFMFAJNGI DFCFBMIMDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x615D050", Offset = "0x615BC50", VA = "0x18615D050")]
	public static ENHJGGFDCML MECFMICMJPN(this FJCFMFAJNGI DFCFBMIMDHA, Guid HFBDJOHJNOI)
	{
		return default(ENHJGGFDCML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x615CF10", Offset = "0x615BB10", VA = "0x18615CF10")]
	public static int LDIPNAPKKBJ(this FJCFMFAJNGI DFCFBMIMDHA, ENHJGGFDCML AAFKOHDOHPE)
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
