using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KDHKJJGECFG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int FLECPJNIFKC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int DLPCIOAKAKE;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int ACBIAIBHKOB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7235F60", Offset = "0x7235160", VA = "0x187235F60")]
	public static void PEFHGIKLIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7235BE0", Offset = "0x7234DE0", VA = "0x187235BE0")]
	public static void BJCJAFFCJMN(int[] LJHPIIDCOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7235CC0", Offset = "0x7234EC0", VA = "0x187235CC0")]
	public static int FKGHKOIGNBN(int FFOMBEHABLB, Func<int, bool> PLKIMHCKHFE, bool DKNOGNIKHMD = true)
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
