using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DMHICOGMJDO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B180", Offset = "0x6A19B80", VA = "0x186A1B180")]
	public static KeepsakeTheme JCEICMNFGFG(this OGDBACLOCBP CMIHNHHBGOO, Guid KOAIMKDICGM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B270", Offset = "0x6A19C70", VA = "0x186A1B270")]
	public static KeepsakeTheme JCEICMNFGFG(this OGDBACLOCBP CMIHNHHBGOO, MOMDKDLAOIH KIFEIBMFAAI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B050", Offset = "0x6A19A50", VA = "0x186A1B050")]
	public static List<KeepsakeTheme> CBIOEEBHBBN(this OGDBACLOCBP CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B310", Offset = "0x6A19D10", VA = "0x186A1B310")]
	public static MOMDKDLAOIH LDGMCEDNEPE(this OGDBACLOCBP CMIHNHHBGOO, Guid KOAIMKDICGM)
	{
		return default(MOMDKDLAOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A1B100", Offset = "0x6A19B00", VA = "0x186A1B100")]
	public static int GGNJDHBJCHF(this OGDBACLOCBP CMIHNHHBGOO, MOMDKDLAOIH CGNJALEGFFJ)
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
