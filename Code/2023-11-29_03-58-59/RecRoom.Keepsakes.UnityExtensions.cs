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
	[Cpp2IlInjected.Address(RVA = "0x5E34C50", Offset = "0x5E34050", VA = "0x185E34C50")]
	public static KeepsakeTheme BMHBNDGJFEK(this EKFHLDMDMDD CHJDMKIKGKN, Guid BFDAGJGHJBC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E34D40", Offset = "0x5E34140", VA = "0x185E34D40")]
	public static KeepsakeTheme BMHBNDGJFEK(this EKFHLDMDMDD CHJDMKIKGKN, PCEKIMKFBFL CPBHPKBFHEN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E34F00", Offset = "0x5E34300", VA = "0x185E34F00")]
	public static List<KeepsakeTheme> PAGKLAPLAMP(this EKFHLDMDMDD CHJDMKIKGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E34DF0", Offset = "0x5E341F0", VA = "0x185E34DF0")]
	public static PCEKIMKFBFL JOEOIOLGOKC(this EKFHLDMDMDD CHJDMKIKGKN, Guid BFDAGJGHJBC)
	{
		return default(PCEKIMKFBFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E34E80", Offset = "0x5E34280", VA = "0x185E34E80")]
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
