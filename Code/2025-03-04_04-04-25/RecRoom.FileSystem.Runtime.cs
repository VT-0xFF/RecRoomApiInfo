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
		[Cpp2IlInjected.Address(RVA = "0x74FE5C0", Offset = "0x74FCBC0", VA = "0x1874FE5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string GNPCJJDEKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x74FE650", Offset = "0x74FCC50", VA = "0x1874FE650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string AMGJBFICGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74FE650", Offset = "0x74FCC50", VA = "0x1874FE650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string AKLICOGJLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74FE5C0", Offset = "0x74FCBC0", VA = "0x1874FE5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74FE6D0", Offset = "0x74FCCD0", VA = "0x1874FE6D0")]
	private static string GBHNMBEIFPL(string DPEONNMDCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74FE5D0", Offset = "0x74FCBD0", VA = "0x1874FE5D0")]
	public static void BFBAKGHBCJK(string DPEONNMDCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74FE820", Offset = "0x74FCE20", VA = "0x1874FE820")]
	public static bool NPEIABAIHLD(string DPEONNMDCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74FE730", Offset = "0x74FCD30", VA = "0x1874FE730")]
	public static void JAAEFJEBHNH(string DPEONNMDCPO, string GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74FE660", Offset = "0x74FCC60", VA = "0x1874FE660")]
	public static string EMDFILMCGKH(string DPEONNMDCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74FE7B0", Offset = "0x74FCDB0", VA = "0x1874FE7B0")]
	public static void MBEBBANLBEH(string DPEONNMDCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
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
