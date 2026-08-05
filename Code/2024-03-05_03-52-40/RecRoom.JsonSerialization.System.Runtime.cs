using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ELDPBDPDJNI : JsonConverter<Dictionary<string, object>>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6104230", Offset = "0x6103030", VA = "0x186104230", Slot = "27")]
	public override Dictionary<string, object> Read(Utf8JsonReader INLIFCPEGKK, Type DEMCNIKEPHP, JsonSerializerOptions BAELEFOBFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6103FD0", Offset = "0x6102DD0", VA = "0x186103FD0")]
	private object JLAAEBNFBFP(Utf8JsonReader INLIFCPEGKK, JsonSerializerOptions BAELEFOBFMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6104640", Offset = "0x6103440", VA = "0x186104640", Slot = "28")]
	public override void Write(Utf8JsonWriter FCAJMDOFLNK, Dictionary<string, object> MAEBFBHFPDE, JsonSerializerOptions BAELEFOBFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61046C0", Offset = "0x61034C0", VA = "0x1861046C0")]
	public ELDPBDPDJNI()
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
