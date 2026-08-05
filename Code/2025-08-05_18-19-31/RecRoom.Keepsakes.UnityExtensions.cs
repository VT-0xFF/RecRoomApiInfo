using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LDIBONBEFDM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8301860", Offset = "0x8300C60", VA = "0x188301860")]
	public static KeepsakeTheme HJDAHMJDOGI(this BKFAJJKENCE JPGAFCLKGNM, Guid DBIALNJHNFJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8301960", Offset = "0x8300D60", VA = "0x188301960")]
	public static KeepsakeTheme HJDAHMJDOGI(this BKFAJJKENCE JPGAFCLKGNM, IJIHCOGNCDJ NJPHBMBCPHL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8301AB0", Offset = "0x8300EB0", VA = "0x188301AB0")]
	public static List<KeepsakeTheme> MDKDCKJPKMN(this BKFAJJKENCE JPGAFCLKGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8301B80", Offset = "0x8300F80", VA = "0x188301B80")]
	public static IJIHCOGNCDJ OEJKCGFIGGC(this BKFAJJKENCE JPGAFCLKGNM, Guid DBIALNJHNFJ)
	{
		return default(IJIHCOGNCDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8301A20", Offset = "0x8300E20", VA = "0x188301A20")]
	public static int KAGLINDCMCE(this BKFAJJKENCE JPGAFCLKGNM, IJIHCOGNCDJ GAGNGHPMDNA)
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
