using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FLPGPFCOJKO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum LNAIBHFFGNM
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		SwitchBetweenCurrentToolAndEraser,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		SwitchBetweenCurrentToolAndLastUsed,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		ShowColorPalette
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum POHADGOKAKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool AJMCDJCIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x403930", Offset = "0x402730", VA = "0x180403930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080")]
	public static void KIDCCNNLKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x403930", Offset = "0x402730", VA = "0x180403930")]
	public static bool APDGIJJOINC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x38CCA00", Offset = "0x38CB800", VA = "0x1838CCA00")]
	public static bool MHFJAFEHFFJ(Action<double> KGGONEPEHDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x43E630", Offset = "0x43D430", VA = "0x18043E630")]
	public static LNAIBHFFGNM JHNLFPBDBKN()
	{
		return default(LNAIBHFFGNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4F9EF0", Offset = "0x4F8CF0", VA = "0x1804F9EF0")]
	public static int AKOPJLIIBMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xA8C9E0", Offset = "0xA8B7E0", VA = "0x180A8C9E0")]
	public static int GAAEFILMCHP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA8C9E0", Offset = "0xA8B7E0", VA = "0x180A8C9E0")]
	public static int AFKHEJPBGJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080")]
	public static void EBAMCCJMLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080")]
	public static void IGGNJMPPLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080")]
	public static void KONMPCCGKOH(bool AEBFKFLKADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080")]
	public static void DNIKOAAPLCM(POHADGOKAKB KKKBLDOJOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x402080", Offset = "0x400E80", VA = "0x180402080")]
	public static void GBOIPJJOHGH(bool IFFOAAPCIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8C0C50", Offset = "0x8BFA50", VA = "0x1808C0C50")]
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
