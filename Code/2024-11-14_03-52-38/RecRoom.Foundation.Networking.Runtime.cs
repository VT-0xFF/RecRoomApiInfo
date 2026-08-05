using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NFIKHNJIDIE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static int GFKNJGHJBGD;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static int DKPAHFBKIBK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static int FANDLMBAJLM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D62AA0", Offset = "0x6D61EA0", VA = "0x186D62AA0")]
	public static void GAEOJLMHFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D62AF0", Offset = "0x6D61EF0", VA = "0x186D62AF0")]
	public static void KJNAFJJHMNC(int[] KADAPNMIOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D62800", Offset = "0x6D61C00", VA = "0x186D62800")]
	public static int DCNCDDPEJGI(int AKEDFPIAAAG, Func<int, bool> GNBBDALHGEE, bool GCFPHEIEDOC = true)
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
