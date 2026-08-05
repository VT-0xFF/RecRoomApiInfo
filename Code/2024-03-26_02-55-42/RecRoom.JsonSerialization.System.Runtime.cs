using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EMLMKEAEHNA : JsonConverter<Dictionary<string, object>>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61DD930", Offset = "0x61DCD30", VA = "0x1861DD930", Slot = "27")]
	public override Dictionary<string, object> Read(Utf8JsonReader JIKGIJPCJAL, Type BCIABKBDMJE, JsonSerializerOptions ABKDMFHFFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61DD6D0", Offset = "0x61DCAD0", VA = "0x1861DD6D0")]
	private object EMNOGKCJEOO(Utf8JsonReader JIKGIJPCJAL, JsonSerializerOptions ABKDMFHFFCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61DDD40", Offset = "0x61DD140", VA = "0x1861DDD40", Slot = "28")]
	public override void Write(Utf8JsonWriter NHJJKKKEGHL, Dictionary<string, object> PCGOHCLJAPN, JsonSerializerOptions ABKDMFHFFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61DDDC0", Offset = "0x61DD1C0", VA = "0x1861DDDC0")]
	public EMLMKEAEHNA()
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
