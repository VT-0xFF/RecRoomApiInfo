using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class INLBCHAMNOP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string KNFIALPMPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7880A20", Offset = "0x787FE20", VA = "0x187880A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string EDGBKEDBKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78809A0", Offset = "0x787FDA0", VA = "0x1878809A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string AIIKEJFPHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78809A0", Offset = "0x787FDA0", VA = "0x1878809A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string NCPLJNJFNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7880A20", Offset = "0x787FE20", VA = "0x187880A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7880940", Offset = "0x787FD40", VA = "0x187880940")]
	private static string DNDJAKNNAEN(string IOOOOBAIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78808C0", Offset = "0x787FCC0", VA = "0x1878808C0")]
	public static void BBCDEPKIKIM(string IOOOOBAIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7880AA0", Offset = "0x787FEA0", VA = "0x187880AA0")]
	public static bool MOACGPNMONA(string IOOOOBAIEAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7880B10", Offset = "0x787FF10", VA = "0x187880B10")]
	public static void PCPGDDDPIJD(string IOOOOBAIEAN, string HPMNBNLACCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x78809B0", Offset = "0x787FDB0", VA = "0x1878809B0")]
	public static string FMOCGJENKME(string IOOOOBAIEAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7880A30", Offset = "0x787FE30", VA = "0x187880A30")]
	public static void HJAJKEADFEA(string IOOOOBAIEAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0")]
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
