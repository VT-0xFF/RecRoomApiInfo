using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OMMCGFKIGBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6904580", Offset = "0x6902F80", VA = "0x186904580")]
	public static KeepsakeTheme BCAHNCPGLDH(this JPCLHPMNMIM KNCHPAAMIFB, Guid MJMCOANGIDF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6904670", Offset = "0x6903070", VA = "0x186904670")]
	public static KeepsakeTheme BCAHNCPGLDH(this JPCLHPMNMIM KNCHPAAMIFB, PLLDBMLOFLD HHJDOPGJJLA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6904790", Offset = "0x6903190", VA = "0x186904790")]
	public static List<KeepsakeTheme> KLFPGPEDIPD(this JPCLHPMNMIM KNCHPAAMIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6904850", Offset = "0x6903250", VA = "0x186904850")]
	public static PLLDBMLOFLD OALFDAAIDHK(this JPCLHPMNMIM KNCHPAAMIFB, Guid MJMCOANGIDF)
	{
		return default(PLLDBMLOFLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6904710", Offset = "0x6903110", VA = "0x186904710")]
	public static int IEFNAKPOEDL(this JPCLHPMNMIM KNCHPAAMIFB, PLLDBMLOFLD IFFOKACPIEE)
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
