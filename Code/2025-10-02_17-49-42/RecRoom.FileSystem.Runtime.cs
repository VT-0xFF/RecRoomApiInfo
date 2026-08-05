using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IJNDLEBPFNH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string NGJECDBEANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84ED640", Offset = "0x84EC040", VA = "0x1884ED640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string NMMMNCDJFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84ED6C0", Offset = "0x84EC0C0", VA = "0x1884ED6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string GPPCPJFPLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84ED6C0", Offset = "0x84EC0C0", VA = "0x1884ED6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string KADBEEMHGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84ED640", Offset = "0x84EC040", VA = "0x1884ED640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84ED5C0", Offset = "0x84EBFC0", VA = "0x1884ED5C0")]
	public static string HHLIDMECECI([Optional] string MCLHODNGGAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84ED6D0", Offset = "0x84EC0D0", VA = "0x1884ED6D0")]
	private static string LMICIAHKHIB(string HEEMGKHJLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84ED540", Offset = "0x84EBF40", VA = "0x1884ED540")]
	public static void FACCJOIEFPM(string HEEMGKHJLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84ED7B0", Offset = "0x84EC1B0", VA = "0x1884ED7B0")]
	public static bool NMKKOHMCGJK(string HEEMGKHJLID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x84ED730", Offset = "0x84EC130", VA = "0x1884ED730")]
	public static void MNGLLOMJBHL(string HEEMGKHJLID, string BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84ED4D0", Offset = "0x84EBED0", VA = "0x1884ED4D0")]
	public static string ALOBGFOCDIJ(string HEEMGKHJLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84ED650", Offset = "0x84EC050", VA = "0x1884ED650")]
	public static void JBJBIJBNLKN(string HEEMGKHJLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void NDLDAIEOOKM()
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
