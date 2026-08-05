using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FMOJFIBJCPL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x690B0D0", Offset = "0x6909CD0", VA = "0x18690B0D0")]
	public static KeepsakeTheme BCAEPOCBKJF(this FEJJBKGOOFP DJIBBLNPCFA, Guid NDDEHDPMJHK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x690B1C0", Offset = "0x6909DC0", VA = "0x18690B1C0")]
	public static KeepsakeTheme BCAEPOCBKJF(this FEJJBKGOOFP DJIBBLNPCFA, GHIGMDMNOAN DLFIMHIGEAN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x690B260", Offset = "0x6909E60", VA = "0x18690B260")]
	public static List<KeepsakeTheme> FALMNKDOIAB(this FEJJBKGOOFP DJIBBLNPCFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x690B320", Offset = "0x6909F20", VA = "0x18690B320")]
	public static GHIGMDMNOAN LAKDGMJJMDP(this FEJJBKGOOFP DJIBBLNPCFA, Guid NDDEHDPMJHK)
	{
		return default(GHIGMDMNOAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x690B3B0", Offset = "0x6909FB0", VA = "0x18690B3B0")]
	public static int MNMEIMIMJBD(this FEJJBKGOOFP DJIBBLNPCFA, GHIGMDMNOAN EKNGONBDMOI)
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
