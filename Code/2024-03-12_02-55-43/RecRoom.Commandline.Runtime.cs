using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HOMBGBGDPMG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PBPOCFPIGCH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> ADPIJMEDDBN;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] PGCNJNGNMOF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] AIICKMBOCGK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] IMDBCPNDBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x60AC5E0", Offset = "0x60AB7E0", VA = "0x1860AC5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] FGDLGBGKFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x60AC7B0", Offset = "0x60AB9B0", VA = "0x1860AC7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60AC690", Offset = "0x60AB890", VA = "0x1860AC690")]
	internal static string[] IILKHFEFOGJ(string[] KLHAHNLHCLH, string[] LMDHHKDFCMD, List<string> IODFIILHMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60AC960", Offset = "0x60ABB60", VA = "0x1860AC960")]
	public static string OIHMPGFPBJM(string IMAIGADBGGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60AC5F0", Offset = "0x60AB7F0", VA = "0x1860AC5F0")]
	public static bool HPPMPEGAOLO(string IMAIGADBGGK)
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
