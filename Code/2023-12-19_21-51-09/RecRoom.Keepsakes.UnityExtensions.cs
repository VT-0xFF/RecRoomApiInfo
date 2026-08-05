using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PFLJMOIIOLP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E35550", Offset = "0x5E34150", VA = "0x185E35550")]
	public static KeepsakeTheme JHAAMAGPLDG(this OOGDHFOKHDJ CEICFMOFGAN, Guid LCCDFMPKKEO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E354A0", Offset = "0x5E340A0", VA = "0x185E354A0")]
	public static KeepsakeTheme JHAAMAGPLDG(this OOGDHFOKHDJ CEICFMOFGAN, PFJPMLCFECE OLNBPEIBJAP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E35360", Offset = "0x5E33F60", VA = "0x185E35360")]
	public static List<KeepsakeTheme> FEIKCHFKBBI(this OOGDHFOKHDJ CEICFMOFGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E352D0", Offset = "0x5E33ED0", VA = "0x185E352D0")]
	public static PFJPMLCFECE AEBALOGNIEE(this OOGDHFOKHDJ CEICFMOFGAN, Guid LCCDFMPKKEO)
	{
		return default(PFJPMLCFECE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E35420", Offset = "0x5E34020", VA = "0x185E35420")]
	public static int JBMDAFCGLJL(this OOGDHFOKHDJ CEICFMOFGAN, PFJPMLCFECE DEJJALCJCNF)
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
