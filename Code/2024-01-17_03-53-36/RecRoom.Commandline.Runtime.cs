using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GIBELLELJAE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JKCPAFMFKIN
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> FEIKIHJIAIE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] KLEEOJGIICF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] KEMAHJNLJAG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] BGKBMCBEAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F290", Offset = "0x5F4E090", VA = "0x185F4F290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] MKKHMFBKCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F4F0E0", Offset = "0x5F4DEE0", VA = "0x185F4F0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EFC0", Offset = "0x5F4DDC0", VA = "0x185F4EFC0")]
	internal static string[] HDNLADILLEF(string[] NHBGABHMAOP, string[] GNFCJJJNMFH, List<string> NPAPIFNLKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EE80", Offset = "0x5F4DC80", VA = "0x185F4EE80")]
	public static string BIKLOJBMKHL(string FJPACLEAEGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F4EF20", Offset = "0x5F4DD20", VA = "0x185F4EF20")]
	public static bool DOMJAJHBLFN(string FJPACLEAEGP)
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
