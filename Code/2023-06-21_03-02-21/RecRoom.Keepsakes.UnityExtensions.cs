using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BPGJDPNJLCK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x15A70E0", Offset = "0x15A62E0", VA = "0x1815A70E0")]
	public static KeepsakeTheme IDKIDIBDCFD(this HCHPEGJPAGO EKDODOMDNPH, Guid JANCGILILJA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x15A71E0", Offset = "0x15A63E0", VA = "0x1815A71E0")]
	public static KeepsakeTheme IDKIDIBDCFD(this HCHPEGJPAGO EKDODOMDNPH, PIHCLHIKEPH HFBNDONAJIM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x15A7030", Offset = "0x15A6230", VA = "0x1815A7030")]
	public static List<KeepsakeTheme> HEPKIFBJMIC(this HCHPEGJPAGO EKDODOMDNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15A6FA0", Offset = "0x15A61A0", VA = "0x1815A6FA0")]
	public static PIHCLHIKEPH FKHNJLJHJJN(this HCHPEGJPAGO EKDODOMDNPH, Guid JANCGILILJA)
	{
		return default(PIHCLHIKEPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15A6F20", Offset = "0x15A6120", VA = "0x1815A6F20")]
	public static int AOFGLNFGBNN(this HCHPEGJPAGO EKDODOMDNPH, PIHCLHIKEPH HPMPEKNNPND)
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
