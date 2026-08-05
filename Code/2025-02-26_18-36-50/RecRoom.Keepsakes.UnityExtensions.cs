using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CEPBCKGBNIK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x74B1F50", Offset = "0x74B1350", VA = "0x1874B1F50")]
	public static KeepsakeTheme PDFFPALMGIB(this HPDENNBAGKP JEIEGFHFIPA, Guid CBCFADAIBAF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74B1E90", Offset = "0x74B1290", VA = "0x1874B1E90")]
	public static KeepsakeTheme PDFFPALMGIB(this HPDENNBAGKP JEIEGFHFIPA, MAIAFFCEMDA HOGPMAAFCHE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74B1D30", Offset = "0x74B1130", VA = "0x1874B1D30")]
	public static List<KeepsakeTheme> DCNHIMMFENL(this HPDENNBAGKP JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74B1C90", Offset = "0x74B1090", VA = "0x1874B1C90")]
	public static MAIAFFCEMDA CNIKIKAGIAL(this HPDENNBAGKP JEIEGFHFIPA, Guid CBCFADAIBAF)
	{
		return default(MAIAFFCEMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74B1E00", Offset = "0x74B1200", VA = "0x1874B1E00")]
	public static int KCAPDHMGDAI(this HPDENNBAGKP JEIEGFHFIPA, MAIAFFCEMDA EALFFCNJEPJ)
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
