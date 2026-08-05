using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NDOFIFKGJKB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string HOAFJCHHGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F4BA40", Offset = "0x6F4A240", VA = "0x186F4BA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string BFAKLGICKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F4BB40", Offset = "0x6F4A340", VA = "0x186F4BB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string ELJAPCEFHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F4BB40", Offset = "0x6F4A340", VA = "0x186F4BB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string PMHJCOBDJOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F4BA40", Offset = "0x6F4A240", VA = "0x186F4BA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B9E0", Offset = "0x6F4A1E0", VA = "0x186F4B9E0")]
	private static string EAKABKKAMMG(string EDMHAMLCOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BAC0", Offset = "0x6F4A2C0", VA = "0x186F4BAC0")]
	public static void GNMNCDPPMJG(string EDMHAMLCOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BA50", Offset = "0x6F4A250", VA = "0x186F4BA50")]
	public static bool FKEPEKPIMGM(string EDMHAMLCOLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BB50", Offset = "0x6F4A350", VA = "0x186F4BB50")]
	public static void OCPAJMNPGJK(string EDMHAMLCOLN, string EBNFOODJNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B970", Offset = "0x6F4A170", VA = "0x186F4B970")]
	public static string CBGBEJKIGKF(string EDMHAMLCOLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B900", Offset = "0x6F4A100", VA = "0x186F4B900")]
	public static void BHBPBDKEJKF(string EDMHAMLCOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
	private static void HNBFJAMBLCA()
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
