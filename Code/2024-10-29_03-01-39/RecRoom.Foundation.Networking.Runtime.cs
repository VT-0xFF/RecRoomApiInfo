using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ODEMKJLOAGN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int MIOAALMIJOL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int EIGMNPKBHBN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int JAAMOJJHOFB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFB90", Offset = "0x6EBEB90", VA = "0x186EBFB90")]
	public static void BGCGKEELKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFBE0", Offset = "0x6EBEBE0", VA = "0x186EBFBE0")]
	public static void CFKEFBDPJOA(int[] MIDCCHGNEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFCC0", Offset = "0x6EBECC0", VA = "0x186EBFCC0")]
	public static int MMNJDLCFGMP(int FJMABOPOLJO, Func<int, bool> AHLDNNBAHJM, bool ENMNKGIENNF = true)
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
