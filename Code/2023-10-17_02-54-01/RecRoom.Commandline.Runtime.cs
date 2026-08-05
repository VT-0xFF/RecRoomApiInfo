using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum OBDHMEKDIPG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LHNFDPPBIFH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> PAAJLILDONP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] EKAHLBEAOJK;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] EAAOCPCOJDN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] EPDPKNKCGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5C56E30", Offset = "0x5C55630", VA = "0x185C56E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] IIIAOFBEJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C56C80", Offset = "0x5C55480", VA = "0x185C56C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C56E40", Offset = "0x5C55640", VA = "0x185C56E40")]
	internal static string[] JMIBKDFOOFK(string[] LBLKCAEEOOM, string[] PIPIJIONCCC, List<string> CPODIDIBENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5C56BE0", Offset = "0x5C553E0", VA = "0x185C56BE0")]
	public static string DCNMGOBHLAC(string LPBINBIAAEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C56F60", Offset = "0x5C55760", VA = "0x185C56F60")]
	public static bool LFIEGOHLDMB(string LPBINBIAAEN)
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
