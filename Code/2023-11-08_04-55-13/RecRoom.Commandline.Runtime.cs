using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LDOINLEPAGO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FHAOLLKKOOM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> KIJCAHKIFEA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] FHLGEGCMGIE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] HOENOPGFPBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] BFACAEIHAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5D68790", Offset = "0x5D67590", VA = "0x185D68790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] DBEAAGELNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D68840", Offset = "0x5D67640", VA = "0x185D68840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D68670", Offset = "0x5D67470", VA = "0x185D68670")]
	internal static string[] ACFOMLPPCCO(string[] POKJHFKGEKA, string[] GNOAOGPHFGF, List<string> IFEBJBEIABF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D687A0", Offset = "0x5D675A0", VA = "0x185D687A0")]
	public static string FNGGLJOOAJE(string ENFDGODKGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D689F0", Offset = "0x5D677F0", VA = "0x185D689F0")]
	public static bool NMLIELAALAL(string ENFDGODKGDK)
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
