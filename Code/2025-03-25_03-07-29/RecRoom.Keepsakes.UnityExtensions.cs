using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EEBAPJGBBIH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7864E90", Offset = "0x7864290", VA = "0x187864E90")]
	public static KeepsakeTheme CJAPNNBEKHP(this KDNDLFGGOLF ECPDNOJCJEA, Guid NLMCBFMCBDO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7864F90", Offset = "0x7864390", VA = "0x187864F90")]
	public static KeepsakeTheme CJAPNNBEKHP(this KDNDLFGGOLF ECPDNOJCJEA, DCINACICPGL ANCMFJLFCNG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7864DC0", Offset = "0x78641C0", VA = "0x187864DC0")]
	public static List<KeepsakeTheme> BLIPOCHLNPE(this KDNDLFGGOLF ECPDNOJCJEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7865040", Offset = "0x7864440", VA = "0x187865040")]
	public static DCINACICPGL IPGPAENEFLK(this KDNDLFGGOLF ECPDNOJCJEA, Guid NLMCBFMCBDO)
	{
		return default(DCINACICPGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7864D30", Offset = "0x7864130", VA = "0x187864D30")]
	public static int AOIFFEIAKKM(this KDNDLFGGOLF ECPDNOJCJEA, DCINACICPGL CKJNDFNDNFA)
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
