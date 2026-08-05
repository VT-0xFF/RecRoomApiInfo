using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum DLGOCOOLOAC
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IMDBEAFDLHN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> LIHJEBIDDLI;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] NIDBICCDPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] MBJABDIMKFD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] FOCIPJOKGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x60EA8B0", Offset = "0x60E98B0", VA = "0x1860EA8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] PHDHKEDJBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x60EA5E0", Offset = "0x60E95E0", VA = "0x1860EA5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60EA790", Offset = "0x60E9790", VA = "0x1860EA790")]
	internal static string[] HDIKHBPOKGB(string[] JNCKKDEDLAL, string[] LEJBJBODDMI, List<string> IAGOIJOCBFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60EA8C0", Offset = "0x60E98C0", VA = "0x1860EA8C0")]
	public static string NAGMKHLACAO(string AHLEHOLMIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60EA540", Offset = "0x60E9540", VA = "0x1860EA540")]
	public static bool CKFFHOMKOFK(string AHLEHOLMIAD)
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
