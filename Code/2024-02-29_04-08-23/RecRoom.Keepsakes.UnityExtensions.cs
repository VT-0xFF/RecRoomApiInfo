using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HEKLLAGHBHM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x602D1C0", Offset = "0x602BFC0", VA = "0x18602D1C0")]
	public static KeepsakeTheme AAPGJCAHPNL(this BDIHIGBPAAF IEHBMNBOFCL, Guid GFIDPDNCIHA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x602D110", Offset = "0x602BF10", VA = "0x18602D110")]
	public static KeepsakeTheme AAPGJCAHPNL(this BDIHIGBPAAF IEHBMNBOFCL, EFLJMDBPODD BBDPHCNNPCK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x602D3C0", Offset = "0x602C1C0", VA = "0x18602D3C0")]
	public static List<KeepsakeTheme> OIDMANFHGFB(this BDIHIGBPAAF IEHBMNBOFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x602D2B0", Offset = "0x602C0B0", VA = "0x18602D2B0")]
	public static EFLJMDBPODD FCHFIJPFODA(this BDIHIGBPAAF IEHBMNBOFCL, Guid GFIDPDNCIHA)
	{
		return default(EFLJMDBPODD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x602D340", Offset = "0x602C140", VA = "0x18602D340")]
	public static int KIKHHGMKCIN(this BDIHIGBPAAF IEHBMNBOFCL, EFLJMDBPODD NPOCCMNJGID)
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
