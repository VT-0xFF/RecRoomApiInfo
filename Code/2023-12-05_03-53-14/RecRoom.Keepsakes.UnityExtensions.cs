using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AGEHALDEAKG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E34B70", Offset = "0x5E33F70", VA = "0x185E34B70")]
	public static KeepsakeTheme BMHBNDGJFEK(this EKFHLDMDMDD CHJDMKIKGKN, Guid BFDAGJGHJBC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E34C60", Offset = "0x5E34060", VA = "0x185E34C60")]
	public static KeepsakeTheme BMHBNDGJFEK(this EKFHLDMDMDD CHJDMKIKGKN, PCEKIMKFBFL CPBHPKBFHEN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E34E20", Offset = "0x5E34220", VA = "0x185E34E20")]
	public static List<KeepsakeTheme> PAGKLAPLAMP(this EKFHLDMDMDD CHJDMKIKGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E34D10", Offset = "0x5E34110", VA = "0x185E34D10")]
	public static PCEKIMKFBFL JOEOIOLGOKC(this EKFHLDMDMDD CHJDMKIKGKN, Guid BFDAGJGHJBC)
	{
		return default(PCEKIMKFBFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E34DA0", Offset = "0x5E341A0", VA = "0x185E34DA0")]
	public static int MABLIOIMCBN(this EKFHLDMDMDD CHJDMKIKGKN, PCEKIMKFBFL OKNNJPGLGJC)
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
