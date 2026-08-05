using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum KKPLFEECLAM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EOPHEDLGPCK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> EJOMFDLPOAE;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] BFLNPCFIEDB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] HEEDGADIJGC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] BJPMNJLJHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6082260", Offset = "0x6080E60", VA = "0x186082260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] PAABKCCMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6081F70", Offset = "0x6080B70", VA = "0x186081F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6081E50", Offset = "0x6080A50", VA = "0x186081E50")]
	internal static string[] AEJGDFDJJKH(string[] KFOAPPBEEJP, string[] EONPOIGNLBF, List<string> OCIBGCNFBPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60821C0", Offset = "0x6080DC0", VA = "0x1860821C0")]
	public static string LBOGONHEKNI(string OJMJLFJMBMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6082120", Offset = "0x6080D20", VA = "0x186082120")]
	public static bool KIOFFAEBIJN(string OJMJLFJMBMB)
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
