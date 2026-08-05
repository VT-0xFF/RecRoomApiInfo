using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FAKJIIAFOEG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string CDCJMDAEPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D4DEF0", Offset = "0x6D4D2F0", VA = "0x186D4DEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string KNFGDNFGCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D4DCA0", Offset = "0x6D4D0A0", VA = "0x186D4DCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string HKHDACGFAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6D4DCA0", Offset = "0x6D4D0A0", VA = "0x186D4DCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string NMIIDEEBJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D4DEF0", Offset = "0x6D4D2F0", VA = "0x186D4DEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D4DE10", Offset = "0x6D4D210", VA = "0x186D4DE10")]
	private static string JJNNEHGFOKC(string GEAOIIINCOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D4DCB0", Offset = "0x6D4D0B0", VA = "0x186D4DCB0")]
	public static void DLJMIAGJENN(string GEAOIIINCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D4DDA0", Offset = "0x6D4D1A0", VA = "0x186D4DDA0")]
	public static bool IONOOBJEFPG(string GEAOIIINCOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D4DE70", Offset = "0x6D4D270", VA = "0x186D4DE70")]
	public static void LJFELGIFNII(string GEAOIIINCOC, string EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D4DD30", Offset = "0x6D4D130", VA = "0x186D4DD30")]
	public static string HLBENGAHPDP(string GEAOIIINCOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D4DF00", Offset = "0x6D4D300", VA = "0x186D4DF00")]
	public static void OBHEFBJILGD(string GEAOIIINCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void KCOBKFEEBDP()
	{
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
