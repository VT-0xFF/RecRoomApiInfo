using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KHHNFELLEHG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string DHGKHPAENMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69A4490", Offset = "0x69A2A90", VA = "0x1869A4490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string KNFBOIBKCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69A4520", Offset = "0x69A2B20", VA = "0x1869A4520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string NBFEFJKKFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69A4520", Offset = "0x69A2B20", VA = "0x1869A4520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string LLEBMEGDLOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69A4490", Offset = "0x69A2A90", VA = "0x1869A4490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69A43B0", Offset = "0x69A29B0", VA = "0x1869A43B0")]
	private static string CDNKICMKKFG(string DLMOEDNDKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69A44A0", Offset = "0x69A2AA0", VA = "0x1869A44A0")]
	public static void FOHALDODMHN(string DLMOEDNDKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69A45A0", Offset = "0x69A2BA0", VA = "0x1869A45A0")]
	public static bool NAOHIDAOPLG(string DLMOEDNDKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69A4410", Offset = "0x69A2A10", VA = "0x1869A4410")]
	public static void FJGLMPJNLJH(string DLMOEDNDKJK, string JHLEMCFOEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69A4530", Offset = "0x69A2B30", VA = "0x1869A4530")]
	public static string MECABHHJAEK(string DLMOEDNDKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69A4610", Offset = "0x69A2C10", VA = "0x1869A4610")]
	public static void PHCANLNIKKM(string DLMOEDNDKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	private static void PKIDAJADMFG()
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
