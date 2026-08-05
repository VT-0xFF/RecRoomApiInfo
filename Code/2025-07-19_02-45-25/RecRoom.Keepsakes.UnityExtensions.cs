using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IGPPLFLLICD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x81C6A30", Offset = "0x81C5A30", VA = "0x1881C6A30")]
	public static KeepsakeTheme BKLBCECAPLJ(this EJHNPOJJKLP PAOKFDJPALE, Guid GJOGOFAANPP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81C6B30", Offset = "0x81C5B30", VA = "0x1881C6B30")]
	public static KeepsakeTheme BKLBCECAPLJ(this EJHNPOJJKLP PAOKFDJPALE, GEAEHEAKOFP BPBEMBAFJCL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81C6BE0", Offset = "0x81C5BE0", VA = "0x1881C6BE0")]
	public static List<KeepsakeTheme> EMMBCGCLMOJ(this EJHNPOJJKLP PAOKFDJPALE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81C6D40", Offset = "0x81C5D40", VA = "0x1881C6D40")]
	public static GEAEHEAKOFP KBCFNLLLHCD(this EJHNPOJJKLP PAOKFDJPALE, Guid GJOGOFAANPP)
	{
		return default(GEAEHEAKOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81C6CB0", Offset = "0x81C5CB0", VA = "0x1881C6CB0")]
	public static int IOMDEEJHCJH(this EJHNPOJJKLP PAOKFDJPALE, GEAEHEAKOFP NJCHGBOMHEO)
	{
		return default(int);
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
