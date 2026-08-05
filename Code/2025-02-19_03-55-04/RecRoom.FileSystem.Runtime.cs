using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NDLBKKBNOOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string ILKMFCKEJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74A9790", Offset = "0x74A8390", VA = "0x1874A9790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string GMLLGHGIAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x74A98F0", Offset = "0x74A84F0", VA = "0x1874A98F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string HPBCJNMBFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74A98F0", Offset = "0x74A84F0", VA = "0x1874A98F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string NELHEKFCJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74A9790", Offset = "0x74A8390", VA = "0x1874A9790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74A9810", Offset = "0x74A8410", VA = "0x1874A9810")]
	private static string FFMICFDELDD(string ICLCPILCBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74A9870", Offset = "0x74A8470", VA = "0x1874A9870")]
	public static void KDMAPPCMMON(string ICLCPILCBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74A9900", Offset = "0x74A8500", VA = "0x1874A9900")]
	public static bool LGHHNJFECLB(string ICLCPILCBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74A99E0", Offset = "0x74A85E0", VA = "0x1874A99E0")]
	public static void NDDDHADCOJO(string ICLCPILCBMO, string LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74A9970", Offset = "0x74A8570", VA = "0x1874A9970")]
	public static string MOHIBNHHMPG(string ICLCPILCBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74A97A0", Offset = "0x74A83A0", VA = "0x1874A97A0")]
	public static void DEJEGHOINED(string ICLCPILCBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	private static void ELMMMBLJNHJ()
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
