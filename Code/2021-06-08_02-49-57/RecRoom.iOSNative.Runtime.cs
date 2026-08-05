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
	[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820")]
	public static void KIDCCNNLKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x45E580", Offset = "0x45D380", VA = "0x18045E580")]
	public static bool PEIFCEIKNHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3EF680", Offset = "0x3EE480", VA = "0x1803EF680")]
	public static bool APDGIJJOINC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x366C6F0", Offset = "0x366B4F0", VA = "0x18366C6F0")]
	public static double GBAMNMPFEIN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3E3080", Offset = "0x3E1E80", VA = "0x1803E3080")]
	public static int AKOPJLIIBMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xBBCA10", Offset = "0xBBB810", VA = "0x180BBCA10")]
	public static int GAAEFILMCHP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xBBCA10", Offset = "0xBBB810", VA = "0x180BBCA10")]
	public static int AFKHEJPBGJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820")]
	public static void EBAMCCJMLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820")]
	public static void IGGNJMPPLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820")]
	public static void KONMPCCGKOH(bool AEBFKFLKADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820")]
	public static void DNIKOAAPLCM(POHADGOKAKB KKKBLDOJOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E6820", Offset = "0x3E5620", VA = "0x1803E6820")]
	public static void GBOIPJJOHGH(bool IFFOAAPCIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9CBA40", Offset = "0x9CA840", VA = "0x1809CBA40")]
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
