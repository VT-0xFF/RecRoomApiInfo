using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CODPOAMCIAH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string FLDJHCKGCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DE40B0", Offset = "0x6DE34B0", VA = "0x186DE40B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string PIHLHJABFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6DE4210", Offset = "0x6DE3610", VA = "0x186DE4210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string MDGLEKDKPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DE4210", Offset = "0x6DE3610", VA = "0x186DE4210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string LKFGKHKCEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DE40B0", Offset = "0x6DE34B0", VA = "0x186DE40B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DE41B0", Offset = "0x6DE35B0", VA = "0x186DE41B0")]
	private static string HFOOBJJCNBN(string BLDDFJAJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DE40C0", Offset = "0x6DE34C0", VA = "0x186DE40C0")]
	public static void CBEOKBEKFAL(string BLDDFJAJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4040", Offset = "0x6DE3440", VA = "0x186DE4040")]
	public static bool AHDDHDEMCKO(string BLDDFJAJFGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4220", Offset = "0x6DE3620", VA = "0x186DE4220")]
	public static void KLLPMCCEBLM(string BLDDFJAJFGI, string MPMEGOKIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DE42A0", Offset = "0x6DE36A0", VA = "0x186DE42A0")]
	public static string OPIPKJBNCNG(string BLDDFJAJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4140", Offset = "0x6DE3540", VA = "0x186DE4140")]
	public static void CCAIKHOPCJM(string BLDDFJAJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void JOLFHNKPBOJ()
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
