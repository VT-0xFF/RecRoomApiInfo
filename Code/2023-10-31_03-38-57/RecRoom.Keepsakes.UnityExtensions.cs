using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CANNPNLFEAI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CA3D10", Offset = "0x5CA3110", VA = "0x185CA3D10")]
	public static KeepsakeTheme KEAOPEDKMMN(this JMPLFDCKJEC GCLFDBLLOOM, Guid PLAPOIHKMMF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CA3C60", Offset = "0x5CA3060", VA = "0x185CA3C60")]
	public static KeepsakeTheme KEAOPEDKMMN(this JMPLFDCKJEC GCLFDBLLOOM, COMPPKOFNKM BKABAKLFKMK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CA3B20", Offset = "0x5CA2F20", VA = "0x185CA3B20")]
	public static List<KeepsakeTheme> GILCDNFBCGD(this JMPLFDCKJEC GCLFDBLLOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CA3E00", Offset = "0x5CA3200", VA = "0x185CA3E00")]
	public static COMPPKOFNKM MFMBJKLOHHB(this JMPLFDCKJEC GCLFDBLLOOM, Guid PLAPOIHKMMF)
	{
		return default(COMPPKOFNKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CA3BE0", Offset = "0x5CA2FE0", VA = "0x185CA3BE0")]
	public static int HNPCLKDNEKL(this JMPLFDCKJEC GCLFDBLLOOM, COMPPKOFNKM ILEMGOKGDKG)
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
