using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NFKEHEKGDPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int MKOCKANGGBA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int IDEFFBDECGM;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int OGNFKCDKBDN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C390", Offset = "0x6C7B590", VA = "0x186C7C390")]
	public static void PHNNFKGDPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C2B0", Offset = "0x6C7B4B0", VA = "0x186C7C2B0")]
	public static void FALHLKDODKG(int[] LFAILGDKDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C020", Offset = "0x6C7B220", VA = "0x186C7C020")]
	public static int EHHPJIGFHMN(int HJAOALCPDOH, Func<int, bool> MKDFJMIOHJJ, bool HLILIJAHHLH = true)
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
