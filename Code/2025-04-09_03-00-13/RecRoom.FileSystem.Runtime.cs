using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class INLBCHAMNOP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string KNFIALPMPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78CE110", Offset = "0x78CD510", VA = "0x1878CE110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string EDGBKEDBKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78CE090", Offset = "0x78CD490", VA = "0x1878CE090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private static string AIIKEJFPHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78CE090", Offset = "0x78CD490", VA = "0x1878CE090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string NCPLJNJFNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x78CE110", Offset = "0x78CD510", VA = "0x1878CE110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78CE200", Offset = "0x78CD600", VA = "0x1878CE200")]
	public static string NBFCOHJFJAC([Optional] string GDIHHGBLHJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78CE030", Offset = "0x78CD430", VA = "0x1878CE030")]
	private static string DNDJAKNNAEN(string IOOOOBAIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x78CDFB0", Offset = "0x78CD3B0", VA = "0x1878CDFB0")]
	public static void BBCDEPKIKIM(string IOOOOBAIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x78CE190", Offset = "0x78CD590", VA = "0x1878CE190")]
	public static bool MOACGPNMONA(string IOOOOBAIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x78CE280", Offset = "0x78CD680", VA = "0x1878CE280")]
	public static void PCPGDDDPIJD(string IOOOOBAIEAN, string HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x78CE0A0", Offset = "0x78CD4A0", VA = "0x1878CE0A0")]
	public static string FMOCGJENKME(string IOOOOBAIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x78CE120", Offset = "0x78CD520", VA = "0x1878CE120")]
	public static void HJAJKEADFEA(string IOOOOBAIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
	private static void BGEHIFBCKEP()
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
