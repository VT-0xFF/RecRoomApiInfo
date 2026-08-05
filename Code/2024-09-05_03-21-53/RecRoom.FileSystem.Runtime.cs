using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PDKCCNFGBNA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string DFAKEJKHGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6B9EDF0", Offset = "0x6B9D7F0", VA = "0x186B9EDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string DFDLCCDBEDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6B9EEE0", Offset = "0x6B9D8E0", VA = "0x186B9EEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string EPDHHDPOMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B9EEE0", Offset = "0x6B9D8E0", VA = "0x186B9EEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string ADMGJKLMMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B9EDF0", Offset = "0x6B9D7F0", VA = "0x186B9EDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B9EEF0", Offset = "0x6B9D8F0", VA = "0x186B9EEF0")]
	private static string HGEAGOKLFPL(string FNGJKHBMPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B9F040", Offset = "0x6B9DA40", VA = "0x186B9F040")]
	public static void JAPGBMIFCMP(string FNGJKHBMPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B9EE70", Offset = "0x6B9D870", VA = "0x186B9EE70")]
	public static bool FHDOAPMLPEF(string FNGJKHBMPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B9EF50", Offset = "0x6B9D950", VA = "0x186B9EF50")]
	public static void HIHGCCHPCOG(string FNGJKHBMPIH, string OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B9EFD0", Offset = "0x6B9D9D0", VA = "0x186B9EFD0")]
	public static string IAJBALABJAN(string FNGJKHBMPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B9EE00", Offset = "0x6B9D800", VA = "0x186B9EE00")]
	public static void FDAEDMEDJLM(string FNGJKHBMPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void DFHKGNIGPPB()
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
