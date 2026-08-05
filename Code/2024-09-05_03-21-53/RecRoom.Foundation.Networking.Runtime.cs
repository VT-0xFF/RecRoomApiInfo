using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CDPBNKDMJPP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int JKFFEABEHLK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int OJKDKMIHBGL;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int FBMEDGLAPDA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3780", Offset = "0x6BB2180", VA = "0x186BB3780")]
	public static void EEKPJBEBLNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BB37D0", Offset = "0x6BB21D0", VA = "0x186BB37D0")]
	public static void HMMNBGMIOEE(int[] PAFLFDNKIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BB38B0", Offset = "0x6BB22B0", VA = "0x186BB38B0")]
	public static int NGKMOGIKKCO(int COGGJOJOFLF, Func<int, bool> GLJJNLECMOJ, bool LGAKDNCMFLP = true)
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
