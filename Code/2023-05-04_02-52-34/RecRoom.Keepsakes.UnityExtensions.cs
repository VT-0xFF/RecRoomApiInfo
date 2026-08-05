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
	[Cpp2IlInjected.Address(RVA = "0x6A41FF0", Offset = "0x6A413F0", VA = "0x186A41FF0")]
	public static KeepsakeTheme JCEICMNFGFG(this OGDBACLOCBP CMIHNHHBGOO, Guid KOAIMKDICGM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A420E0", Offset = "0x6A414E0", VA = "0x186A420E0")]
	public static KeepsakeTheme JCEICMNFGFG(this OGDBACLOCBP CMIHNHHBGOO, MOMDKDLAOIH KIFEIBMFAAI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A41EC0", Offset = "0x6A412C0", VA = "0x186A41EC0")]
	public static List<KeepsakeTheme> CBIOEEBHBBN(this OGDBACLOCBP CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A42180", Offset = "0x6A41580", VA = "0x186A42180")]
	public static MOMDKDLAOIH LDGMCEDNEPE(this OGDBACLOCBP CMIHNHHBGOO, Guid KOAIMKDICGM)
	{
		return default(MOMDKDLAOIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A41F70", Offset = "0x6A41370", VA = "0x186A41F70")]
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
