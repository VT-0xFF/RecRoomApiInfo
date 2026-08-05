using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EELKEBBDFJA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string NBJLDCPOCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2050", Offset = "0x6DF0A50", VA = "0x186DF2050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string DBCHONMADLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2040", Offset = "0x6DF0A40", VA = "0x186DF2040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string PBJEMNHOLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2040", Offset = "0x6DF0A40", VA = "0x186DF2040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string LNNOCMMJEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2050", Offset = "0x6DF0A50", VA = "0x186DF2050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2060", Offset = "0x6DF0A60", VA = "0x186DF2060")]
	private static string AKFKPHJJHLL(string MHHANLDHFOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DF20C0", Offset = "0x6DF0AC0", VA = "0x186DF20C0")]
	public static void GABOOFKADLN(string MHHANLDHFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2140", Offset = "0x6DF0B40", VA = "0x186DF2140")]
	public static bool KHNJJBMLIJF(string MHHANLDHFOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6DF21B0", Offset = "0x6DF0BB0", VA = "0x186DF21B0")]
	public static void LFHFOAJNHDD(string MHHANLDHFOC, string GGEMPJLCHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2230", Offset = "0x6DF0C30", VA = "0x186DF2230")]
	public static string NBMDDJNHDKP(string MHHANLDHFOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DF22A0", Offset = "0x6DF0CA0", VA = "0x186DF22A0")]
	public static void PHEJFDJCFOK(string MHHANLDHFOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	private static void LHHEGMBBNOB()
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
