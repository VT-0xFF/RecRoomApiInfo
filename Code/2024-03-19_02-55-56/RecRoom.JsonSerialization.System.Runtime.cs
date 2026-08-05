using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LDPFEJIPEPG : JsonConverter<Dictionary<string, object>>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61B2280", Offset = "0x61B1280", VA = "0x1861B2280", Slot = "27")]
	public override Dictionary<string, object> Read(Utf8JsonReader PCOFGFPALLL, Type ECDHJIANGFO, JsonSerializerOptions KJMCMIAJLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61B2020", Offset = "0x61B1020", VA = "0x1861B2020")]
	private object FEEBAELMOOP(Utf8JsonReader PCOFGFPALLL, JsonSerializerOptions KJMCMIAJLKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61B2690", Offset = "0x61B1690", VA = "0x1861B2690", Slot = "28")]
	public override void Write(Utf8JsonWriter HKMKHKLNOHE, Dictionary<string, object> CFJDHAGGAJO, JsonSerializerOptions KJMCMIAJLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61B2710", Offset = "0x61B1710", VA = "0x1861B2710")]
	public LDPFEJIPEPG()
	{
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
