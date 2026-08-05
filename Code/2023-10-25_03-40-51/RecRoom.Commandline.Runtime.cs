using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JJLPOPFPBNB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JGDJCNIBKAI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> IDICJCGKNHA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] MGPFHDBEEMP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] MDPDIDOIJFO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] KLADNCADPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5BFE6A0", Offset = "0x5BFD4A0", VA = "0x185BFE6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] EKBBOOFOGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5BFE7D0", Offset = "0x5BFD5D0", VA = "0x185BFE7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE6B0", Offset = "0x5BFD4B0", VA = "0x185BFE6B0")]
	internal static string[] CGDFGDALNPL(string[] FEFGKMEEDHM, string[] JPIMAKGPFGM, List<string> KOCOPLBMJCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BFEA20", Offset = "0x5BFD820", VA = "0x185BFEA20")]
	public static string LDPPGOPNADM(string KMMHDHGBEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BFE980", Offset = "0x5BFD780", VA = "0x185BFE980")]
	public static bool KLPDCJDGLJN(string KMMHDHGBEMH)
	{
		return default(bool);
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
