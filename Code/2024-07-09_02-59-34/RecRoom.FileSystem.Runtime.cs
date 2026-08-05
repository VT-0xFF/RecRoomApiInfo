using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ECDABFOAMEO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string HBLGLIHAPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69C3A60", Offset = "0x69C2660", VA = "0x1869C3A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string AMJCDGFNCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69C3A70", Offset = "0x69C2670", VA = "0x1869C3A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string OGHHHJFBOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69C3A60", Offset = "0x69C2660", VA = "0x1869C3A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69C3990", Offset = "0x69C2590", VA = "0x1869C3990")]
	private static string AGEHCOLPMEI(string BPMIFKHAMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69C3BE0", Offset = "0x69C27E0", VA = "0x1869C3BE0")]
	public static void OGFBOFJBPAJ(string BPMIFKHAMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69C3AF0", Offset = "0x69C26F0", VA = "0x1869C3AF0")]
	public static bool NFFJDODDCKE(string BPMIFKHAMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69C3B60", Offset = "0x69C2760", VA = "0x1869C3B60")]
	public static void OEFEJGJNKHD(string BPMIFKHAMKI, string JGFKFMMOAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69C3A80", Offset = "0x69C2680", VA = "0x1869C3A80")]
	public static string LKDJPHHINDL(string BPMIFKHAMKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69C39F0", Offset = "0x69C25F0", VA = "0x1869C39F0")]
	public static void CPGFKBEIEBJ(string BPMIFKHAMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	private static void ICNICPAHMBF()
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
