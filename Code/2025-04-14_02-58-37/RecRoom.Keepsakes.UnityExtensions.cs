using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MPIJAAECFLF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x795CD40", Offset = "0x795B740", VA = "0x18795CD40")]
	public static KeepsakeTheme GKJBMPHFPJJ(this MMMNCFHKKMD GIGHOMPCPHH, Guid FKFIGDCMLBH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x795CE40", Offset = "0x795B840", VA = "0x18795CE40")]
	public static KeepsakeTheme GKJBMPHFPJJ(this MMMNCFHKKMD GIGHOMPCPHH, GAMIHGPENBO NFIKPHOGNHM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x795CF90", Offset = "0x795B990", VA = "0x18795CF90")]
	public static List<KeepsakeTheme> NBKEBPAMCKB(this MMMNCFHKKMD GIGHOMPCPHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x795CEF0", Offset = "0x795B8F0", VA = "0x18795CEF0")]
	public static GAMIHGPENBO LAFKKLHEBOA(this MMMNCFHKKMD GIGHOMPCPHH, Guid FKFIGDCMLBH)
	{
		return default(GAMIHGPENBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x795D060", Offset = "0x795BA60", VA = "0x18795D060")]
	public static int NMBGNJLPLAK(this MMMNCFHKKMD GIGHOMPCPHH, GAMIHGPENBO PCOCJPMELMO)
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
