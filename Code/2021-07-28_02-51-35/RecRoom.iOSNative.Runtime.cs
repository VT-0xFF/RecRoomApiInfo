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

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool AJMCDJCIHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x408690", Offset = "0x407490", VA = "0x180408690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0")]
	public static void KIDCCNNLKPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x408690", Offset = "0x407490", VA = "0x180408690")]
	public static bool APDGIJJOINC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1293AB0", Offset = "0x12928B0", VA = "0x181293AB0")]
	public static bool MHFJAFEHFFJ(Action<double> KGGONEPEHDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x621CB0", Offset = "0x620AB0", VA = "0x180621CB0")]
	public static int AKOPJLIIBMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1293AA0", Offset = "0x12928A0", VA = "0x181293AA0")]
	public static int GAAEFILMCHP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1293AA0", Offset = "0x12928A0", VA = "0x181293AA0")]
	public static int AFKHEJPBGJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0")]
	public static void EBAMCCJMLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0")]
	public static void IGGNJMPPLLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0")]
	public static void KONMPCCGKOH(bool AEBFKFLKADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0")]
	public static void DNIKOAAPLCM(POHADGOKAKB KKKBLDOJOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x1804082D0")]
	public static void GBOIPJJOHGH(bool IFFOAAPCIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x556D90", Offset = "0x555B90", VA = "0x180556D90")]
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
