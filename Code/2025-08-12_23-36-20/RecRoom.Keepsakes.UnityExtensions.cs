using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GJBCAKEPAKB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x83DE490", Offset = "0x83DD290", VA = "0x1883DE490")]
	public static KeepsakeTheme DGCIHAGMCNM(this HCFJKHLMHDM EKOKCFOMOOD, Guid CHAPBCKABGN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x83DE590", Offset = "0x83DD390", VA = "0x1883DE590")]
	public static KeepsakeTheme DGCIHAGMCNM(this HCFJKHLMHDM EKOKCFOMOOD, PEIKCOPGDKJ OICGPDGOEAI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x83DE770", Offset = "0x83DD570", VA = "0x1883DE770")]
	public static List<KeepsakeTheme> MBMEJPNDCGH(this HCFJKHLMHDM EKOKCFOMOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x83DE6D0", Offset = "0x83DD4D0", VA = "0x1883DE6D0")]
	public static PEIKCOPGDKJ LPOJJLOJKCG(this HCFJKHLMHDM EKOKCFOMOOD, Guid CHAPBCKABGN)
	{
		return default(PEIKCOPGDKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83DE640", Offset = "0x83DD440", VA = "0x1883DE640")]
	public static int KOOMPKHOCAG(this HCFJKHLMHDM EKOKCFOMOOD, PEIKCOPGDKJ AKMAFPBEIMM)
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
