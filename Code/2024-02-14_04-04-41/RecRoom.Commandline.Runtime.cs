using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JAAOAPOPKHM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CLCDHIFNINJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> LDJJHPFCCKM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] APLPKECOMNN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] GHBHGCHJNNC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] HLINBLBPJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9D50", Offset = "0x5EA9150", VA = "0x185EA9D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] JMNJPNPGMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5EA99E0", Offset = "0x5EA8DE0", VA = "0x185EA99E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9C30", Offset = "0x5EA9030", VA = "0x185EA9C30")]
	internal static string[] MFDIPFDIJNI(string[] JMLDELPALGI, string[] GAAKFMLHACK, List<string> MCEIKLJMLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9B90", Offset = "0x5EA8F90", VA = "0x185EA9B90")]
	public static string GGFJGOCPDKJ(string FIJABPAFDME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9D60", Offset = "0x5EA9160", VA = "0x185EA9D60")]
	public static bool POFEDKHHJCO(string FIJABPAFDME)
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
