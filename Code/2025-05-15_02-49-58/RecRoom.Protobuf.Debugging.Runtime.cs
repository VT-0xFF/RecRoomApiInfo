using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AOKMMFCFDBP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter KPPKPPELEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9860", Offset = "0x7FD7E60", VA = "0x187FD9860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter MJMKIGDKKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9900", Offset = "0x7FD7F00", VA = "0x187FD9900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter HLFLLJEJIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7FD98B0", Offset = "0x7FD7EB0", VA = "0x187FD98B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter LHAFCBNJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FD9950", Offset = "0x7FD7F50", VA = "0x187FD9950")]
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
