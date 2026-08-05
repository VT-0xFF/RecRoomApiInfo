using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PGIIPMJHCIP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int EEMGEDHNHAA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int NDFKJGLPDBO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int BJOAEDEMKPD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x700A580", Offset = "0x7009980", VA = "0x18700A580")]
	public static void AAAFMOPLCJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x700A860", Offset = "0x7009C60", VA = "0x18700A860")]
	public static void MMOALHMOPIG(int[] PKNIBMHIEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x700A5D0", Offset = "0x70099D0", VA = "0x18700A5D0")]
	public static int EDAANPPLLPC(int MGDIFAIDMOP, Func<int, bool> FMMFBDFINKL, bool COFNIIHFCOP = true)
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
