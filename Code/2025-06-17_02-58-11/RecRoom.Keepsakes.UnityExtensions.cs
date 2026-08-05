using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IAECEINGGPM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E000", Offset = "0x7D9CA00", VA = "0x187D9E000")]
	public static KeepsakeTheme OLFKHLHONCF(this KDHCIHAIJOA BPDOIFAEGPF, Guid APLOIMOLGJJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DF40", Offset = "0x7D9C940", VA = "0x187D9DF40")]
	public static KeepsakeTheme OLFKHLHONCF(this KDHCIHAIJOA BPDOIFAEGPF, JJFPKLGIJNA KHIOPBNCPPM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DDD0", Offset = "0x7D9C7D0", VA = "0x187D9DDD0")]
	public static List<KeepsakeTheme> HPGFPGFJMAO(this KDHCIHAIJOA BPDOIFAEGPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DEA0", Offset = "0x7D9C8A0", VA = "0x187D9DEA0")]
	public static JJFPKLGIJNA IBCPFOICPJB(this KDHCIHAIJOA BPDOIFAEGPF, Guid APLOIMOLGJJ)
	{
		return default(JJFPKLGIJNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D9DD40", Offset = "0x7D9C740", VA = "0x187D9DD40")]
	public static int AHDDCCGLMLD(this KDHCIHAIJOA BPDOIFAEGPF, JJFPKLGIJNA HBPOCPOHODD)
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
