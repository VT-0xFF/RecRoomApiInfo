using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ENABFAOFMAN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7648910", Offset = "0x7647B10", VA = "0x187648910")]
	public static KeepsakeTheme NKFDECLIBIO(this OBODNDLNOCD CKLPHBNMNHA, Guid MDCODEADBDH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7648A10", Offset = "0x7647C10", VA = "0x187648A10")]
	public static KeepsakeTheme NKFDECLIBIO(this OBODNDLNOCD CKLPHBNMNHA, AJMLMFADNCB DIALJKCJKLG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x76487B0", Offset = "0x76479B0", VA = "0x1876487B0")]
	public static List<KeepsakeTheme> CJODJDANFEF(this OBODNDLNOCD CKLPHBNMNHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7648710", Offset = "0x7647910", VA = "0x187648710")]
	public static AJMLMFADNCB BIHIBLGNENG(this OBODNDLNOCD CKLPHBNMNHA, Guid MDCODEADBDH)
	{
		return default(AJMLMFADNCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7648880", Offset = "0x7647A80", VA = "0x187648880")]
	public static int JJDNHINJEOF(this OBODNDLNOCD CKLPHBNMNHA, AJMLMFADNCB KIFIBMNLIML)
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
