using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EJPCCGGCLOM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6224360", Offset = "0x6223560", VA = "0x186224360")]
	public static KeepsakeTheme AINBOINJIMG(this JAAAHEGBNKF ANAEOGBFNHN, Guid BICMFMGLGLI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6224450", Offset = "0x6223650", VA = "0x186224450")]
	public static KeepsakeTheme AINBOINJIMG(this JAAAHEGBNKF ANAEOGBFNHN, DHMJFGMICNG BLFIIMBAGAK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6224610", Offset = "0x6223810", VA = "0x186224610")]
	public static List<KeepsakeTheme> PNPNOOEANCG(this JAAAHEGBNKF ANAEOGBFNHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6224500", Offset = "0x6223700", VA = "0x186224500")]
	public static DHMJFGMICNG HBABPBBEAKG(this JAAAHEGBNKF ANAEOGBFNHN, Guid BICMFMGLGLI)
	{
		return default(DHMJFGMICNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6224590", Offset = "0x6223790", VA = "0x186224590")]
	public static int LKJOPOKGKKG(this JAAAHEGBNKF ANAEOGBFNHN, DHMJFGMICNG EJMDKAENEMN)
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
