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
		[Cpp2IlInjected.Address(RVA = "0x68CBB80", Offset = "0x68CA580", VA = "0x1868CBB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string DKJOBEDJFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68CBC10", Offset = "0x68CA610", VA = "0x1868CBC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string DPHPPOIPGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68CBB80", Offset = "0x68CA580", VA = "0x1868CBB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68CBD10", Offset = "0x68CA710", VA = "0x1868CBD10")]
	private static string PJHLNDFMPFL(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68CBC20", Offset = "0x68CA620", VA = "0x1868CBC20")]
	public static void LBMFJFPLMNC(string BECGFNBELMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68CBCA0", Offset = "0x68CA6A0", VA = "0x1868CBCA0")]
	public static bool MPMAMEKNAGE(string BECGFNBELMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68CBB90", Offset = "0x68CA590", VA = "0x1868CBB90")]
	public static void HFLMKDJJNHA(string BECGFNBELMK, string LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68CBB10", Offset = "0x68CA510", VA = "0x1868CBB10")]
	public static string CAHOGOEICJG(string BECGFNBELMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68CBAA0", Offset = "0x68CA4A0", VA = "0x1868CBAA0")]
	public static void BJMNBIDALPC(string BECGFNBELMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
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
