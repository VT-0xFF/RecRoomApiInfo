using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GAHCGELKIGL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string EEJAHGIMFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8382430", Offset = "0x8381230", VA = "0x188382430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string JEFDHAPLLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83821E0", Offset = "0x8380FE0", VA = "0x1883821E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string KNDPPJHMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83821E0", Offset = "0x8380FE0", VA = "0x1883821E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string JEOFOGEDPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8382430", Offset = "0x8381230", VA = "0x188382430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8382440", Offset = "0x8381240", VA = "0x188382440")]
	public static string KKFPMNNDEBO([Optional] string MIGBPBFPLDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x83821F0", Offset = "0x8380FF0", VA = "0x1883821F0")]
	private static string CKOOEDEEMMH(string GHADMHNDJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8382340", Offset = "0x8381140", VA = "0x188382340")]
	public static void FFGKOEGCCDD(string GHADMHNDJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83824C0", Offset = "0x83812C0", VA = "0x1883824C0")]
	public static bool NFMLNABJIMC(string GHADMHNDJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83822C0", Offset = "0x83810C0", VA = "0x1883822C0")]
	public static void ENLGLGKFEGI(string GHADMHNDJBK, string KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8382250", Offset = "0x8381050", VA = "0x188382250")]
	public static string DNJMJKBNFIJ(string GHADMHNDJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x83823C0", Offset = "0x83811C0", VA = "0x1883823C0")]
	public static void GEMDLKLDION(string GHADMHNDJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private static void ANNCGKECJMB()
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
