using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IFOFPGPOIFO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int DDANAENFMKB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int ACDBFACNNAN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int JDNMLDCMCED;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69B8FF0", Offset = "0x69B75F0", VA = "0x1869B8FF0")]
	public static void PBNMLFKEDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69B8C80", Offset = "0x69B7280", VA = "0x1869B8C80")]
	public static void BPMLNPBNBNG(int[] LBKDONOILLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69B8D60", Offset = "0x69B7360", VA = "0x1869B8D60")]
	public static int EMHKPDPDFPE(int HCPNOAMICKE, Func<int, bool> EMOCANGHPBM, bool DECLBMNKHHI = true)
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
