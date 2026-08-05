using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PIDBMMBABOF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E192F0", Offset = "0x6E186F0", VA = "0x186E192F0")]
	public static KeepsakeTheme INKOLFNALCE(this LFEHEOHAGJB BLMJILKGBHG, Guid DCANINCFJNC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E193F0", Offset = "0x6E187F0", VA = "0x186E193F0")]
	public static KeepsakeTheme INKOLFNALCE(this LFEHEOHAGJB BLMJILKGBHG, OLMJDNCJDKP PMPEBPGKHPK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E19220", Offset = "0x6E18620", VA = "0x186E19220")]
	public static List<KeepsakeTheme> AOCDJPAIDLL(this LFEHEOHAGJB BLMJILKGBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E19530", Offset = "0x6E18930", VA = "0x186E19530")]
	public static OLMJDNCJDKP NPOFDBEACGO(this LFEHEOHAGJB BLMJILKGBHG, Guid DCANINCFJNC)
	{
		return default(OLMJDNCJDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E194A0", Offset = "0x6E188A0", VA = "0x186E194A0")]
	public static int LFPBEGAIDOO(this LFEHEOHAGJB BLMJILKGBHG, OLMJDNCJDKP NIOPKALLHHO)
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
