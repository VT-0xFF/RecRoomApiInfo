using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AFLDICANEIB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E38FC0", Offset = "0x6E379C0", VA = "0x186E38FC0")]
	public static KeepsakeTheme BDFAALLNFBB(this BKNGICPKNMF PLJBPLDMFHL, Guid ODKODKJAEOJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E38F10", Offset = "0x6E37910", VA = "0x186E38F10")]
	public static KeepsakeTheme BDFAALLNFBB(this BKNGICPKNMF PLJBPLDMFHL, JLDMECKKCCB NALOOEBJCJE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E39160", Offset = "0x6E37B60", VA = "0x186E39160")]
	public static List<KeepsakeTheme> IHOAMBOPFPK(this BKNGICPKNMF PLJBPLDMFHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E390C0", Offset = "0x6E37AC0", VA = "0x186E390C0")]
	public static JLDMECKKCCB DMEBHDJMJND(this BKNGICPKNMF PLJBPLDMFHL, Guid ODKODKJAEOJ)
	{
		return default(JLDMECKKCCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E39230", Offset = "0x6E37C30", VA = "0x186E39230")]
	public static int NGOBHIECNNK(this BKNGICPKNMF PLJBPLDMFHL, JLDMECKKCCB PNCNHDNJJLC)
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
