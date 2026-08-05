using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NGNFFEIMGOM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IIPFKEIBGNC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> JPMLGAPBELI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] CKDCIDPNDHO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] JKKAMIENPHC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] FJOEGPMOADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x608D3F0", Offset = "0x608C5F0", VA = "0x18608D3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] IKNKCFJDIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x608D520", Offset = "0x608C720", VA = "0x18608D520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x608D400", Offset = "0x608C600", VA = "0x18608D400")]
	internal static string[] HBFNFHOGAFO(string[] PPJPLEFJKML, string[] PDKPFFGCAPP, List<string> PFCILDCAFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x608D350", Offset = "0x608C550", VA = "0x18608D350")]
	public static string AHAOHHEBNOD(string EGJOOHIODFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x608D6C0", Offset = "0x608C8C0", VA = "0x18608D6C0")]
	public static bool ODPCHKJALFF(string EGJOOHIODFJ)
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
