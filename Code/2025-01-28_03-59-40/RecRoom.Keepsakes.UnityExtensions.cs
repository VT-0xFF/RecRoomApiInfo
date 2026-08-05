using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HIJNLEOGBHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7266D90", Offset = "0x7265F90", VA = "0x187266D90")]
	public static KeepsakeTheme KHKGPNJPJMD(this BAFCNJJFGLN ODPBGAGOMOC, Guid IOIJMEMDMBE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7266CD0", Offset = "0x7265ED0", VA = "0x187266CD0")]
	public static KeepsakeTheme KHKGPNJPJMD(this BAFCNJJFGLN ODPBGAGOMOC, PCJJIJAIMEE PKBGFKOAIFG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7266AD0", Offset = "0x7265CD0", VA = "0x187266AD0")]
	public static List<KeepsakeTheme> AKCIPBIFIFH(this BAFCNJJFGLN ODPBGAGOMOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7266BA0", Offset = "0x7265DA0", VA = "0x187266BA0")]
	public static PCJJIJAIMEE BJCDNDPLGEA(this BAFCNJJFGLN ODPBGAGOMOC, Guid IOIJMEMDMBE)
	{
		return default(PCJJIJAIMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7266C40", Offset = "0x7265E40", VA = "0x187266C40")]
	public static int BOIPKBJMBDI(this BAFCNJJFGLN ODPBGAGOMOC, PCJJIJAIMEE KJAKIKOOIAB)
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
