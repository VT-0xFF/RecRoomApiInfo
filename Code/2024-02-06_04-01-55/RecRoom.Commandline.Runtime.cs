using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JPFNPKNCDKK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AJNOOHOKFCA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> MIKIBIEMFMA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] HBFPCEKLNCA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] HNDFBHILOGP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] ADKMIJPCBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6000B20", Offset = "0x5FFFF20", VA = "0x186000B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] ECABFHPBMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6000C50", Offset = "0x6000050", VA = "0x186000C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6000B30", Offset = "0x5FFFF30", VA = "0x186000B30")]
	internal static string[] LKBHMBOONNO(string[] IJIFCPFDILJ, string[] AMPHOBAIBKB, List<string> ACPHFEFGKKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6000A80", Offset = "0x5FFFE80", VA = "0x186000A80")]
	public static string JGFFIFGHLCB(string FHEIIELHIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60009E0", Offset = "0x5FFFDE0", VA = "0x1860009E0")]
	public static bool JDPOADEFGHB(string FHEIIELHIDO)
	{
		return default(bool);
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
