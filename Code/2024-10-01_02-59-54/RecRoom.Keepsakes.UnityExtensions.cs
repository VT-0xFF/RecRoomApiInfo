using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EADLLNBDGLB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E29B70", Offset = "0x6E28F70", VA = "0x186E29B70")]
	public static KeepsakeTheme MPDMLGBDNIA(this HEKDBGJIEOL HPCAPMNEHGA, Guid LDEHNLDGLMP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E29C70", Offset = "0x6E29070", VA = "0x186E29C70")]
	public static KeepsakeTheme MPDMLGBDNIA(this HEKDBGJIEOL HPCAPMNEHGA, DMDJAJBNJFC FGDEOFMOALH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E29A00", Offset = "0x6E28E00", VA = "0x186E29A00")]
	public static List<KeepsakeTheme> DCAJAPJBEBA(this HEKDBGJIEOL HPCAPMNEHGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E29AD0", Offset = "0x6E28ED0", VA = "0x186E29AD0")]
	public static DMDJAJBNJFC DFHHNFICHKN(this HEKDBGJIEOL HPCAPMNEHGA, Guid LDEHNLDGLMP)
	{
		return default(DMDJAJBNJFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E29D30", Offset = "0x6E29130", VA = "0x186E29D30")]
	public static int NLNHFJLKELF(this HEKDBGJIEOL HPCAPMNEHGA, DMDJAJBNJFC JOPLLPELDEI)
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
