using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HILIHBDINIB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KONIHDMPKJH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> OFJNHKNKFOH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] IKHGBCIEBFI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] BOKIEJIJJGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] HCFPIMFMHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6115700", Offset = "0x6114B00", VA = "0x186115700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] JJKKIKBIBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61157B0", Offset = "0x6114BB0", VA = "0x1861157B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61155E0", Offset = "0x61149E0", VA = "0x1861155E0")]
	internal static string[] CAFCANCKMJO(string[] DOKOJKAGGKL, string[] IPCMICAICCP, List<string> PADGOEFKPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6115710", Offset = "0x6114B10", VA = "0x186115710")]
	public static string JEJANPMJAFH(string NPJNICJKKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6115960", Offset = "0x6114D60", VA = "0x186115960")]
	public static bool NJLCHHJPLHC(string NPJNICJKKMK)
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
