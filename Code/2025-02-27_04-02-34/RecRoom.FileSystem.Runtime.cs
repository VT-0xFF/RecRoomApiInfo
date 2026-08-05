using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AOEMIKJKCKH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string LABFOJOCLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74602E0", Offset = "0x745F6E0", VA = "0x1874602E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string GNPCJJDEKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7460370", Offset = "0x745F770", VA = "0x187460370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string AMGJBFICGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7460370", Offset = "0x745F770", VA = "0x187460370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string AKLICOGJLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74602E0", Offset = "0x745F6E0", VA = "0x1874602E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74603F0", Offset = "0x745F7F0", VA = "0x1874603F0")]
	private static string GBHNMBEIFPL(string DPEONNMDCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74602F0", Offset = "0x745F6F0", VA = "0x1874602F0")]
	public static void BFBAKGHBCJK(string DPEONNMDCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7460540", Offset = "0x745F940", VA = "0x187460540")]
	public static bool NPEIABAIHLD(string DPEONNMDCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7460450", Offset = "0x745F850", VA = "0x187460450")]
	public static void JAAEFJEBHNH(string DPEONNMDCPO, string GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7460380", Offset = "0x745F780", VA = "0x187460380")]
	public static string EMDFILMCGKH(string DPEONNMDCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74604D0", Offset = "0x745F8D0", VA = "0x1874604D0")]
	public static void MBEBBANLBEH(string DPEONNMDCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	private static void CCCIJJIFIDP()
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
