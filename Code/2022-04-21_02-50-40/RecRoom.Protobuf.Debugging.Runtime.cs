using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BELMHLGDIFI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter BGDJEJMMIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8030", Offset = "0x4BF7030", VA = "0x184BF8030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter JNDPNDEDLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4BF7FD0", Offset = "0x4BF6FD0", VA = "0x184BF7FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter PJPJJLGPJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4BF7F10", Offset = "0x4BF6F10", VA = "0x184BF7F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter KILDNOJKBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4BF7F70", Offset = "0x4BF6F70", VA = "0x184BF7F70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ECNCAOPKMGL
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2B431C0", Offset = "0x2B421C0", VA = "0x182B431C0")]
	public static void BDCBOONDFIL<K, V>(this MapField<K, V> IEAADLFMGGC, IEnumerable<(K Key, V value)> LFABLMMJAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B43380", Offset = "0x2B42380", VA = "0x182B43380")]
	public static void BDCBOONDFIL<K, V>(this MapField<K, V> IEAADLFMGGC, IEnumerable<KeyValuePair<K, V>> LFABLMMJAJP)
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
