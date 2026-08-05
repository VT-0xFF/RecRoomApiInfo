using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OKFDEJANPHP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x81112A0", Offset = "0x81100A0", VA = "0x1881112A0")]
	public static KeepsakeTheme BHDMDOONKHF(this NBIEOFHOKIL HEJIJKOGOJP, Guid OEDJPEFAHHO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81111F0", Offset = "0x810FFF0", VA = "0x1881111F0")]
	public static KeepsakeTheme BHDMDOONKHF(this NBIEOFHOKIL HEJIJKOGOJP, MMIEHDFJNAE IKEHNNDDOCO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8111430", Offset = "0x8110230", VA = "0x188111430")]
	public static List<KeepsakeTheme> GDILMBGIEBG(this NBIEOFHOKIL HEJIJKOGOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8111500", Offset = "0x8110300", VA = "0x188111500")]
	public static MMIEHDFJNAE PAFDPNCAIJB(this NBIEOFHOKIL HEJIJKOGOJP, Guid OEDJPEFAHHO)
	{
		return default(MMIEHDFJNAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81113A0", Offset = "0x81101A0", VA = "0x1881113A0")]
	public static int DFHFFPBAOHC(this NBIEOFHOKIL HEJIJKOGOJP, MMIEHDFJNAE OFJECDIDCNG)
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
