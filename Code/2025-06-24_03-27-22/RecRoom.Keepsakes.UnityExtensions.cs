using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NIFLGNOHIDK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C7B0", Offset = "0x7E1B3B0", VA = "0x187E1C7B0")]
	public static KeepsakeTheme GAGAIGDIFDD(this HFEHKPHOBIL GMBCCEAGHDM, Guid OPNNCFPKPIG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C700", Offset = "0x7E1B300", VA = "0x187E1C700")]
	public static KeepsakeTheme GAGAIGDIFDD(this HFEHKPHOBIL GMBCCEAGHDM, BHEHIPCPHLE CCFFFONBLIA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C8B0", Offset = "0x7E1B4B0", VA = "0x187E1C8B0")]
	public static List<KeepsakeTheme> GCDJGKPCLBA(this HFEHKPHOBIL GMBCCEAGHDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C660", Offset = "0x7E1B260", VA = "0x187E1C660")]
	public static BHEHIPCPHLE AEFLGECJNAN(this HFEHKPHOBIL GMBCCEAGHDM, Guid OPNNCFPKPIG)
	{
		return default(BHEHIPCPHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E1C980", Offset = "0x7E1B580", VA = "0x187E1C980")]
	public static int PAMNPOANHPH(this HFEHKPHOBIL GMBCCEAGHDM, BHEHIPCPHLE NLHDCHLLALI)
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
