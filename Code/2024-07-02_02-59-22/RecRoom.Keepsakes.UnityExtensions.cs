using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BBIHBIBDPOB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69AB860", Offset = "0x69AA860", VA = "0x1869AB860")]
	public static KeepsakeTheme EHCICHDLCPG(this IMNOGJAJJGM MFNJBGPIIEN, Guid MMJNEIGAGKK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69AB950", Offset = "0x69AA950", VA = "0x1869AB950")]
	public static KeepsakeTheme EHCICHDLCPG(this IMNOGJAJJGM MFNJBGPIIEN, BJEOMDHFMAK FIPNFMNBCBD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69AB9F0", Offset = "0x69AA9F0", VA = "0x1869AB9F0")]
	public static List<KeepsakeTheme> EOJMILADAHA(this IMNOGJAJJGM MFNJBGPIIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69AB7D0", Offset = "0x69AA7D0", VA = "0x1869AB7D0")]
	public static BJEOMDHFMAK AHNDMGIJKBO(this IMNOGJAJJGM MFNJBGPIIEN, Guid MMJNEIGAGKK)
	{
		return default(BJEOMDHFMAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69ABAB0", Offset = "0x69AAAB0", VA = "0x1869ABAB0")]
	public static int PMHLEMJEDJB(this IMNOGJAJJGM MFNJBGPIIEN, BJEOMDHFMAK DMFDJEJIOIE)
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
