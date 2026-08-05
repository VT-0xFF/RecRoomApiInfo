using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BKPINALINEF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JsonConverter IPBJDBOMKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x17DFC10", Offset = "0x17DE810", VA = "0x1817DFC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JsonConverter CGLLFMDCNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x17DFCD0", Offset = "0x17DE8D0", VA = "0x1817DFCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JsonConverter FLKPLAJPMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x17DFC70", Offset = "0x17DE870", VA = "0x1817DFC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JsonConverter OPNANFOFMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17DFBB0", Offset = "0x17DE7B0", VA = "0x1817DFBB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OFCFBFLOODN
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x35F7D60", Offset = "0x35F6960", VA = "0x1835F7D60")]
	public static void NBEFAJODKCF<K, V>(this MapField<K, V> ADJBCMPCLMH, IEnumerable<(K Key, V value)> JBGIJHKCMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x35F7BA0", Offset = "0x35F67A0", VA = "0x1835F7BA0")]
	public static void NBEFAJODKCF<K, V>(this MapField<K, V> ADJBCMPCLMH, IEnumerable<KeyValuePair<K, V>> JBGIJHKCMJO)
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
