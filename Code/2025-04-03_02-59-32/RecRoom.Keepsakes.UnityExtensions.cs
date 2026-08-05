using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CJPJABDNGJP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x78D6100", Offset = "0x78D5500", VA = "0x1878D6100")]
	public static KeepsakeTheme MDEAHCLOAII(this EIAKNHKEEII HEKFIEJNOCO, Guid LMJKJEPMLBH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x78D6200", Offset = "0x78D5600", VA = "0x1878D6200")]
	public static KeepsakeTheme MDEAHCLOAII(this EIAKNHKEEII HEKFIEJNOCO, LAHJBOFKJLL AHCABCJHNEO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78D62C0", Offset = "0x78D56C0", VA = "0x1878D62C0")]
	public static List<KeepsakeTheme> MGMGCCEMPCB(this EIAKNHKEEII HEKFIEJNOCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78D6060", Offset = "0x78D5460", VA = "0x1878D6060")]
	public static LAHJBOFKJLL JMLABIOBJCF(this EIAKNHKEEII HEKFIEJNOCO, Guid LMJKJEPMLBH)
	{
		return default(LAHJBOFKJLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78D5FD0", Offset = "0x78D53D0", VA = "0x1878D5FD0")]
	public static int JALKNDOKKIO(this EIAKNHKEEII HEKFIEJNOCO, LAHJBOFKJLL CNOKJKFMJAG)
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
