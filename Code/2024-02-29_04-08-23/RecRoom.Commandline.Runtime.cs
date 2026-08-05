using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum KOLMFCDHBNI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OIMGEDOMJHC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> JANCKIDGMFN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] BGOJNGPMMKO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] FGGEAEGKJPB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] LOOEPCFKBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F53450", Offset = "0x5F52250", VA = "0x185F53450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] FFFNFJOALGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F53580", Offset = "0x5F52380", VA = "0x185F53580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F53460", Offset = "0x5F52260", VA = "0x185F53460")]
	internal static string[] JKBNDEMEMDJ(string[] JOPJICEJNIA, string[] EPKCKPEOKPL, List<string> KNABHFIONDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F53310", Offset = "0x5F52110", VA = "0x185F53310")]
	public static string ALHJFBAGGFN(string PJNCGFPILMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F533B0", Offset = "0x5F521B0", VA = "0x185F533B0")]
	public static bool GGFDPPBONCB(string PJNCGFPILMK)
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
