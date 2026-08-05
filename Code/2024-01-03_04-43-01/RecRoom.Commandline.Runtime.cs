using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum EFAAKNIFJEL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FKLKOOAODLA
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> CGLNGONJHDL;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] MKPDMHADGLO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] MFDPDGKHPLE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] AOPHHPIFFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D700", Offset = "0x5D8C300", VA = "0x185D8D700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] OIMILHIAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D8D710", Offset = "0x5D8C310", VA = "0x185D8D710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D960", Offset = "0x5D8C560", VA = "0x185D8D960")]
	internal static string[] PCBFCFCDGPN(string[] AGMGPGHHALL, string[] EPDNDIBBHNL, List<string> AMOMLKPBNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D8DA80", Offset = "0x5D8C680", VA = "0x185D8DA80")]
	public static string POAONOLFAKO(string OFNFKLOMJDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D8D8C0", Offset = "0x5D8C4C0", VA = "0x185D8D8C0")]
	public static bool MIHHJPHBLBI(string OFNFKLOMJDM)
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
