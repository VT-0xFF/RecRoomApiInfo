using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KLOLGNOKECC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6036B60", Offset = "0x6035F60", VA = "0x186036B60")]
	public static KeepsakeTheme CGBJPAENKNP(this IIABPJOALAF GPNCNDIBNOH, Guid MHHMBEMHPMF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6036C50", Offset = "0x6036050", VA = "0x186036C50")]
	public static KeepsakeTheme CGBJPAENKNP(this IIABPJOALAF GPNCNDIBNOH, EOEHKPCAFMD ENINCLKCACM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6036D00", Offset = "0x6036100", VA = "0x186036D00")]
	public static List<KeepsakeTheme> KMGMPNKGHBM(this IIABPJOALAF GPNCNDIBNOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6036DC0", Offset = "0x60361C0", VA = "0x186036DC0")]
	public static EOEHKPCAFMD MLCANCCHBAC(this IIABPJOALAF GPNCNDIBNOH, Guid MHHMBEMHPMF)
	{
		return default(EOEHKPCAFMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6036E50", Offset = "0x6036250", VA = "0x186036E50")]
	public static int PINDOFEBJAK(this IIABPJOALAF GPNCNDIBNOH, EOEHKPCAFMD KNGHGCKGKIP)
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
