using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NLIOHGLDCPP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string CFDCEENBAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x68E5E70", Offset = "0x68E5070", VA = "0x1868E5E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string DKJOBEDJFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68E5F00", Offset = "0x68E5100", VA = "0x1868E5F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string DPHPPOIPGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68E5E70", Offset = "0x68E5070", VA = "0x1868E5E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68E6000", Offset = "0x68E5200", VA = "0x1868E6000")]
	private static string PJHLNDFMPFL(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68E5F10", Offset = "0x68E5110", VA = "0x1868E5F10")]
	public static void LBMFJFPLMNC(string BECGFNBELMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68E5F90", Offset = "0x68E5190", VA = "0x1868E5F90")]
	public static bool MPMAMEKNAGE(string BECGFNBELMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68E5E80", Offset = "0x68E5080", VA = "0x1868E5E80")]
	public static void HFLMKDJJNHA(string BECGFNBELMK, string LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68E5E00", Offset = "0x68E5000", VA = "0x1868E5E00")]
	public static string CAHOGOEICJG(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68E5D90", Offset = "0x68E4F90", VA = "0x1868E5D90")]
	public static void BJMNBIDALPC(string BECGFNBELMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	private static void CDJFGMFOFAK()
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
