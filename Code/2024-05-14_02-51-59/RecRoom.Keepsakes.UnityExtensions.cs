using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MHFBHPKHCHP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63733B0", Offset = "0x6371DB0", VA = "0x1863733B0")]
	public static KeepsakeTheme BIAHEPCEBNE(this ELKIIOINBBG KEKOHNJFKFJ, Guid OBLNJEPEFPG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6373300", Offset = "0x6371D00", VA = "0x186373300")]
	public static KeepsakeTheme BIAHEPCEBNE(this ELKIIOINBBG KEKOHNJFKFJ, NMJLEKDIICC KBCODLCDGFK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63734A0", Offset = "0x6371EA0", VA = "0x1863734A0")]
	public static List<KeepsakeTheme> IJDFELIJODK(this ELKIIOINBBG KEKOHNJFKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63735E0", Offset = "0x6371FE0", VA = "0x1863735E0")]
	public static NMJLEKDIICC PJFBCBJEKLP(this ELKIIOINBBG KEKOHNJFKFJ, Guid OBLNJEPEFPG)
	{
		return default(NMJLEKDIICC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6373560", Offset = "0x6371F60", VA = "0x186373560")]
	public static int OKHNCKPJBDO(this ELKIIOINBBG KEKOHNJFKFJ, NMJLEKDIICC MGFPLKIAABK)
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
