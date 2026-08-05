using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GOCMNILEFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FPBJBCFAPOD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> FLFNDOMHBOM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] MCEHHFBEALF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] BBLLDLHEFMD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] MHMHFECJCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5C56C80", Offset = "0x5C55A80", VA = "0x185C56C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] GHLALFNFFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5C56A30", Offset = "0x5C55830", VA = "0x185C56A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C56910", Offset = "0x5C55710", VA = "0x185C56910")]
	internal static string[] EKBABEKKBLG(string[] AGDJBOJCKCB, string[] HOEFCDMHLIG, List<string> OLANMAFIKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5C56870", Offset = "0x5C55670", VA = "0x185C56870")]
	public static string BCHLCOCELME(string NJLCOEPNOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C56BE0", Offset = "0x5C559E0", VA = "0x185C56BE0")]
	public static bool JDNABKAGANG(string NJLCOEPNOJM)
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
