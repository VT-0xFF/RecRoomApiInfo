using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DPPKKLPAMGM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string OIDMHIBOKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x696F4A0", Offset = "0x696E4A0", VA = "0x18696F4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string JDINJJDFCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x696F520", Offset = "0x696E520", VA = "0x18696F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string CPPBGMLCDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x696F520", Offset = "0x696E520", VA = "0x18696F520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string KBDGNPDJJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x696F4A0", Offset = "0x696E4A0", VA = "0x18696F4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x696F5A0", Offset = "0x696E5A0", VA = "0x18696F5A0")]
	private static string FIIJDKLLDNE(string PLCNFEGEAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x696F600", Offset = "0x696E600", VA = "0x18696F600")]
	public static void KHDKCBNHLEI(string PLCNFEGEAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x696F4B0", Offset = "0x696E4B0", VA = "0x18696F4B0")]
	public static bool AMKDJAHFAFA(string PLCNFEGEAJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x696F680", Offset = "0x696E680", VA = "0x18696F680")]
	public static void LDACCPAEDFD(string PLCNFEGEAJG, string AHGAPHMJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x696F700", Offset = "0x696E700", VA = "0x18696F700")]
	public static string NIFEDKFFBPI(string PLCNFEGEAJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x696F530", Offset = "0x696E530", VA = "0x18696F530")]
	public static void EJLPMCODCMF(string PLCNFEGEAJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void CODDAGLIJEM()
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
