using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BCLJFBBFAFC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6930350", Offset = "0x692F750", VA = "0x186930350")]
	public static KeepsakeTheme GBFENKCBDLG(this LCBAPIDBFPB BENNAIJLPHL, Guid AGIDFPANIND)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6930440", Offset = "0x692F840", VA = "0x186930440")]
	public static KeepsakeTheme GBFENKCBDLG(this LCBAPIDBFPB BENNAIJLPHL, CLHOCNKNHHO KADFEBECLDM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69304F0", Offset = "0x692F8F0", VA = "0x1869304F0")]
	public static List<KeepsakeTheme> IKHGOAIMFLD(this LCBAPIDBFPB BENNAIJLPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6930630", Offset = "0x692FA30", VA = "0x186930630")]
	public static CLHOCNKNHHO NIBBCAPLEND(this LCBAPIDBFPB BENNAIJLPHL, Guid AGIDFPANIND)
	{
		return default(CLHOCNKNHHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69305B0", Offset = "0x692F9B0", VA = "0x1869305B0")]
	public static int LIEPCAMEGKL(this LCBAPIDBFPB BENNAIJLPHL, CLHOCNKNHHO CFPOGFJBDHO)
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
