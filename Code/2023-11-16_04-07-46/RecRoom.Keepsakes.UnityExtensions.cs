using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KPOJGJLNNGC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E16EB0", Offset = "0x5E15EB0", VA = "0x185E16EB0")]
	public static KeepsakeTheme COPCJOFGNBB(this CMCAIDPINDB PPJFGCMLNID, Guid MHFDLMAPPCJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E16E00", Offset = "0x5E15E00", VA = "0x185E16E00")]
	public static KeepsakeTheme COPCJOFGNBB(this CMCAIDPINDB PPJFGCMLNID, GOHFEJAPJPM PFNAPDCLBMM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E170B0", Offset = "0x5E160B0", VA = "0x185E170B0")]
	public static List<KeepsakeTheme> IJJIJNKMJIJ(this CMCAIDPINDB PPJFGCMLNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E17020", Offset = "0x5E16020", VA = "0x185E17020")]
	public static GOHFEJAPJPM HKKDBNCFMDG(this CMCAIDPINDB PPJFGCMLNID, Guid MHFDLMAPPCJ)
	{
		return default(GOHFEJAPJPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E16FA0", Offset = "0x5E15FA0", VA = "0x185E16FA0")]
	public static int FAPIODPNIJJ(this CMCAIDPINDB PPJFGCMLNID, GOHFEJAPJPM OAIMEMIEKGO)
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
