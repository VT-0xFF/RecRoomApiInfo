using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GEDIDPEFCNI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x722D670", Offset = "0x722CA70", VA = "0x18722D670")]
	public static KeepsakeTheme LBJKKJLIECM(this EGBNLJBLJLB CHLJPKFIHHL, Guid HODMOHOMIKF)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x722D770", Offset = "0x722CB70", VA = "0x18722D770")]
	public static KeepsakeTheme LBJKKJLIECM(this EGBNLJBLJLB CHLJPKFIHHL, GMHDHODCNMC AIMIEGFIDMA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x722D540", Offset = "0x722C940", VA = "0x18722D540")]
	public static List<KeepsakeTheme> DBAOMKFFNBM(this EGBNLJBLJLB CHLJPKFIHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x722D880", Offset = "0x722CC80", VA = "0x18722D880")]
	public static GMHDHODCNMC PLKJPOMCADI(this EGBNLJBLJLB CHLJPKFIHHL, Guid HODMOHOMIKF)
	{
		return default(GMHDHODCNMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x722D5F0", Offset = "0x722C9F0", VA = "0x18722D5F0")]
	public static int GFHAECBOIHK(this EGBNLJBLJLB CHLJPKFIHHL, GMHDHODCNMC HDLDJIFAKDK)
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
