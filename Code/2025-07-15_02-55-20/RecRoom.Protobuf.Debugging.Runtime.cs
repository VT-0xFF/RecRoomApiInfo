using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NLAKHGNGNHA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter BAKJPAPHKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84E28D0", Offset = "0x84E14D0", VA = "0x1884E28D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter NACOFJFHIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84E2880", Offset = "0x84E1480", VA = "0x1884E2880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter IHMLILNJEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84E2970", Offset = "0x84E1570", VA = "0x1884E2970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter HELFHNLDLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84E2920", Offset = "0x84E1520", VA = "0x1884E2920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
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
