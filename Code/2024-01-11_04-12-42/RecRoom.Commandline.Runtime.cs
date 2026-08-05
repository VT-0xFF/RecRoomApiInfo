using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum GCGHLADJIEB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HMJPPDPNNAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> IJKOHBCBPDN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] OMONLCEGHNI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] LNLGDFIOFPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] FIFNOCOCFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D800", Offset = "0x5F4C200", VA = "0x185F4D800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] MNAOIDAFMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F4D810", Offset = "0x5F4C210", VA = "0x185F4D810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DB00", Offset = "0x5F4C500", VA = "0x185F4DB00")]
	internal static string[] LEFOPBLAMDM(string[] EODIHOBPGON, string[] PJOCLNEDIDP, List<string> BNLHNPKKNBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F4D9C0", Offset = "0x5F4C3C0", VA = "0x185F4D9C0")]
	public static string JMDJBOKGEAD(string IMDNGKBIEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F4DA60", Offset = "0x5F4C460", VA = "0x185F4DA60")]
	public static bool JOGPMLHLFAB(string IMDNGKBIEKF)
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
