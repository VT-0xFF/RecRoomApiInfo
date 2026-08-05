using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JOMBACIGFHK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int HLAAIAFJAKO;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int FAHLEOAKKOD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int MLBPBMDEECD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72947C0", Offset = "0x72935C0", VA = "0x1872947C0")]
	public static void DCCPIOHHOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72946E0", Offset = "0x72934E0", VA = "0x1872946E0")]
	public static void BBDEOKCKKDD(int[] KHLAOBDDEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7294810", Offset = "0x7293610", VA = "0x187294810")]
	public static int NNDAOGDJPKP(int FLFINDPODHC, Func<int, bool> IBKHCGNLEFM, bool DMHPKMKJFOE = true)
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
