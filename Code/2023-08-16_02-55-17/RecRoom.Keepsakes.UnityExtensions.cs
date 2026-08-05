using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DHFOGDELJKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F79C20", Offset = "0x6F78E20", VA = "0x186F79C20")]
	public static KeepsakeTheme FDIAMLEOPFJ(this EOBEKFCDCGB MHGFMGGOLKA, Guid CKCOJKGAGID)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F79D20", Offset = "0x6F78F20", VA = "0x186F79D20")]
	public static KeepsakeTheme FDIAMLEOPFJ(this EOBEKFCDCGB MHGFMGGOLKA, DLHAJNJECEF NPEGKDLIHJE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F79EB0", Offset = "0x6F790B0", VA = "0x186F79EB0")]
	public static List<KeepsakeTheme> MJJMHONCEOD(this EOBEKFCDCGB MHGFMGGOLKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F79F60", Offset = "0x6F79160", VA = "0x186F79F60")]
	public static DLHAJNJECEF PKJNIIECKGN(this EOBEKFCDCGB MHGFMGGOLKA, Guid CKCOJKGAGID)
	{
		return default(DLHAJNJECEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F79E30", Offset = "0x6F79030", VA = "0x186F79E30")]
	public static int KDABOALJICO(this EOBEKFCDCGB MHGFMGGOLKA, DLHAJNJECEF HKACKNCFAEK)
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
