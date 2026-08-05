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
	[Cpp2IlInjected.Address(RVA = "0x75503D0", Offset = "0x754E9D0", VA = "0x1875503D0")]
	public static KeepsakeTheme PDFFPALMGIB(this HPDENNBAGKP JEIEGFHFIPA, Guid CBCFADAIBAF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7550310", Offset = "0x754E910", VA = "0x187550310")]
	public static KeepsakeTheme PDFFPALMGIB(this HPDENNBAGKP JEIEGFHFIPA, MAIAFFCEMDA HOGPMAAFCHE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75501B0", Offset = "0x754E7B0", VA = "0x1875501B0")]
	public static List<KeepsakeTheme> DCNHIMMFENL(this HPDENNBAGKP JEIEGFHFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7550110", Offset = "0x754E710", VA = "0x187550110")]
	public static MAIAFFCEMDA CNIKIKAGIAL(this HPDENNBAGKP JEIEGFHFIPA, Guid CBCFADAIBAF)
	{
		return default(MAIAFFCEMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7550280", Offset = "0x754E880", VA = "0x187550280")]
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
