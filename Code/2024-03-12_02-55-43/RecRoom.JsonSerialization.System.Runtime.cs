using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KLNEEMGFKOI : JsonConverter<Dictionary<string, object>>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6173ED0", Offset = "0x61730D0", VA = "0x186173ED0", Slot = "27")]
	public override Dictionary<string, object> Read(Utf8JsonReader ODNMKNFNAPP, Type NCDCCCBBFPB, JsonSerializerOptions AGAKJLDACOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6173C70", Offset = "0x6172E70", VA = "0x186173C70")]
	private object AIBHKKIMAHE(Utf8JsonReader ODNMKNFNAPP, JsonSerializerOptions AGAKJLDACOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61742E0", Offset = "0x61734E0", VA = "0x1861742E0", Slot = "28")]
	public override void Write(Utf8JsonWriter MNAHEBBEBLG, Dictionary<string, object> AFCGKMGKPEF, JsonSerializerOptions AGAKJLDACOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6174360", Offset = "0x6173560", VA = "0x186174360")]
	public KLNEEMGFKOI()
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
