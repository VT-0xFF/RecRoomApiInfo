using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NKKINHPFFKM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0B30", Offset = "0x6EEFB30", VA = "0x186EF0B30")]
	public static KeepsakeTheme JFOLKKONENJ(this KBEKIEKONKE PMNMDCCMPDH, Guid BBFGBGLJEMA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0C30", Offset = "0x6EEFC30", VA = "0x186EF0C30")]
	public static KeepsakeTheme JFOLKKONENJ(this KBEKIEKONKE PMNMDCCMPDH, JCBPJOGMEFH IICPDKNBEHC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0CE0", Offset = "0x6EEFCE0", VA = "0x186EF0CE0")]
	public static List<KeepsakeTheme> NCFGNLCNPAG(this KBEKIEKONKE PMNMDCCMPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0A90", Offset = "0x6EEFA90", VA = "0x186EF0A90")]
	public static JCBPJOGMEFH ACCAKBMIDGO(this KBEKIEKONKE PMNMDCCMPDH, Guid BBFGBGLJEMA)
	{
		return default(JCBPJOGMEFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EF0DB0", Offset = "0x6EEFDB0", VA = "0x186EF0DB0")]
	public static int NJCGPODLEFJ(this KBEKIEKONKE PMNMDCCMPDH, JCBPJOGMEFH ALNEPPEDLDB)
	{
		return default(int);
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
