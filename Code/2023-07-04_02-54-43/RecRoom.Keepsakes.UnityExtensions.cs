using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MDBKENBDFEM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x726A9E0", Offset = "0x7268FE0", VA = "0x18726A9E0")]
	public static KeepsakeTheme NOEKNCHONNH(this NEEJAOENAHK HGEKNDJMGCO, Guid BHBNPLODPJC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x726A8D0", Offset = "0x7268ED0", VA = "0x18726A8D0")]
	public static KeepsakeTheme NOEKNCHONNH(this NEEJAOENAHK HGEKNDJMGCO, NHINHHJKNOE HBHMDCLPEIN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x726A820", Offset = "0x7268E20", VA = "0x18726A820")]
	public static List<KeepsakeTheme> LINMHOJAIHH(this NEEJAOENAHK HGEKNDJMGCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x726A790", Offset = "0x7268D90", VA = "0x18726A790")]
	public static NHINHHJKNOE CMPPCEAPPAB(this NEEJAOENAHK HGEKNDJMGCO, Guid BHBNPLODPJC)
	{
		return default(NHINHHJKNOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x726A710", Offset = "0x7268D10", VA = "0x18726A710")]
	public static int BDHCEBLDGHH(this NEEJAOENAHK HGEKNDJMGCO, NHINHHJKNOE DOLKJBDIFLO)
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
