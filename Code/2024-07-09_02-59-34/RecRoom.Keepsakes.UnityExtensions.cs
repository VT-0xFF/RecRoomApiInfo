using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JAKEOLPJHOG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A09B80", Offset = "0x6A08780", VA = "0x186A09B80")]
	public static KeepsakeTheme BBGHGKNHGAB(this ADFECGCNGJL DMMHPLIIKDJ, Guid HHNICFJCOKP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A09C70", Offset = "0x6A08870", VA = "0x186A09C70")]
	public static KeepsakeTheme BBGHGKNHGAB(this ADFECGCNGJL DMMHPLIIKDJ, EMCICLIIJNH DBBAEANKOMK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A09DA0", Offset = "0x6A089A0", VA = "0x186A09DA0")]
	public static List<KeepsakeTheme> OKLLMMBEJJB(this ADFECGCNGJL DMMHPLIIKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A09D10", Offset = "0x6A08910", VA = "0x186A09D10")]
	public static EMCICLIIJNH CDOJJJPODAM(this ADFECGCNGJL DMMHPLIIKDJ, Guid HHNICFJCOKP)
	{
		return default(EMCICLIIJNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A09E60", Offset = "0x6A08A60", VA = "0x186A09E60")]
	public static int PHCEHIFPIIH(this ADFECGCNGJL DMMHPLIIKDJ, EMCICLIIJNH GEHJLMIMBDP)
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
