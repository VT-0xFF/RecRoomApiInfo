using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class POAIEBGKBPC
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int FGFOJHADNGP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int HFBJNIDONJI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int MDMGMEJFHPD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E080C0", Offset = "0x6E06AC0", VA = "0x186E080C0")]
	public static void JODHGOPLHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E07D50", Offset = "0x6E06750", VA = "0x186E07D50")]
	public static void AFJLAMJEHEM(int[] GCNECLEBACK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E07E30", Offset = "0x6E06830", VA = "0x186E07E30")]
	public static int CKDDLFDFJEB(int IFCLKMKGJOL, Func<int, bool> KHGNPPOKGIM, bool DCEJPOPJEMJ = true)
	{
		return default(int);
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
