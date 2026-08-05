using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IODNJBLNJOB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EGLBICOMAJH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> BENJKIBGFLC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] EBFPMOLHLME;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] IKLJHJMBBMD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] ONCGKDBPNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x603D1D0", Offset = "0x603BFD0", VA = "0x18603D1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] BCJBHOEBDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x603CF80", Offset = "0x603BD80", VA = "0x18603CF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x603CE60", Offset = "0x603BC60", VA = "0x18603CE60")]
	internal static string[] EBIOCGAAHNO(string[] CLNDPEPAKCD, string[] DFNJCELDGJK, List<string> GCGBFDFAJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x603CDC0", Offset = "0x603BBC0", VA = "0x18603CDC0")]
	public static string CJDPEIJNGAF(string POBAGCACOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x603D130", Offset = "0x603BF30", VA = "0x18603D130")]
	public static bool MFKKBFDKOGP(string POBAGCACOMM)
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
