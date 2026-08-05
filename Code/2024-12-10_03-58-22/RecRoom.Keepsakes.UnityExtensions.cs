using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KDONMBBBDIN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CF40", Offset = "0x6C8BB40", VA = "0x186C8CF40")]
	public static KeepsakeTheme OCMPCIEHJIL(this NCGDHPLKFLA IGEADGIGICG, Guid PGLONPJBOEL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CE90", Offset = "0x6C8BA90", VA = "0x186C8CE90")]
	public static KeepsakeTheme OCMPCIEHJIL(this NCGDHPLKFLA IGEADGIGICG, HEJGHJHBLCB GHGMNDDPDNB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CD20", Offset = "0x6C8B920", VA = "0x186C8CD20")]
	public static List<KeepsakeTheme> HNCPNINAHNB(this NCGDHPLKFLA IGEADGIGICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CDF0", Offset = "0x6C8B9F0", VA = "0x186C8CDF0")]
	public static HEJGHJHBLCB NBNBOPHJNCJ(this NCGDHPLKFLA IGEADGIGICG, Guid PGLONPJBOEL)
	{
		return default(HEJGHJHBLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C8CC90", Offset = "0x6C8B890", VA = "0x186C8CC90")]
	public static int EBDAKPJPOHE(this NCGDHPLKFLA IGEADGIGICG, HEJGHJHBLCB GCOLDAKADHJ)
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
