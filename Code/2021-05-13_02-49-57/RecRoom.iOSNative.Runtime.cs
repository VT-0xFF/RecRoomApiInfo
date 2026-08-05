using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FLPGPFCOJKO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum POHADGOKAKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0")]
	public static void KIDCCNNLKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3EA7B0", Offset = "0x3E9BB0", VA = "0x1803EA7B0")]
	public static bool APDGIJJOINC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x35DCCF0", Offset = "0x35DC0F0", VA = "0x1835DCCF0")]
	public static double GBAMNMPFEIN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x55F770", Offset = "0x55EB70", VA = "0x18055F770")]
	public static int AKOPJLIIBMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x657C00", Offset = "0x657000", VA = "0x180657C00")]
	public static int GAAEFILMCHP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x657C00", Offset = "0x657000", VA = "0x180657C00")]
	public static int AFKHEJPBGJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0")]
	public static void EBAMCCJMLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0")]
	public static void IGGNJMPPLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0")]
	public static void KONMPCCGKOH(bool AEBFKFLKADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0")]
	public static void DNIKOAAPLCM(POHADGOKAKB KKKBLDOJOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DC3B0", Offset = "0x3DB7B0", VA = "0x1803DC3B0")]
	public static void GBOIPJJOHGH(bool IFFOAAPCIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x656840", Offset = "0x655C40", VA = "0x180656840")]
	public static float PIANFONINJO()
	{
		return default(float);
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
