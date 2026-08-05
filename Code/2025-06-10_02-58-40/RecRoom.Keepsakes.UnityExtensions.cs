using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GEJIPIDHAFP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CA9FE0", Offset = "0x7CA91E0", VA = "0x187CA9FE0")]
	public static KeepsakeTheme ENJDOFEEFPK(this MEBGNIEBDPP OBHJPIMFHEM, Guid ILGEEOKLNJP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA0E0", Offset = "0x7CA92E0", VA = "0x187CAA0E0")]
	public static KeepsakeTheme ENJDOFEEFPK(this MEBGNIEBDPP OBHJPIMFHEM, JDOMPGJPOEI FOFNKPMEPKE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA190", Offset = "0x7CA9390", VA = "0x187CAA190")]
	public static List<KeepsakeTheme> FJLEHMAEFBC(this MEBGNIEBDPP OBHJPIMFHEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA2F0", Offset = "0x7CA94F0", VA = "0x187CAA2F0")]
	public static JDOMPGJPOEI PFOABDMHHID(this MEBGNIEBDPP OBHJPIMFHEM, Guid ILGEEOKLNJP)
	{
		return default(JDOMPGJPOEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7CAA260", Offset = "0x7CA9460", VA = "0x187CAA260")]
	public static int NJHANCMDJNP(this MEBGNIEBDPP OBHJPIMFHEM, JDOMPGJPOEI OKOMECGCMED)
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
