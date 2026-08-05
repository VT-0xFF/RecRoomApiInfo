using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FMCDCHDDNCH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7F70", Offset = "0x5FF6970", VA = "0x185FF7F70")]
	public static KeepsakeTheme OBGLNBMHECN(this PLPLAPGGIAM FHOCAIDBAPC, Guid NGFIMDLEMBB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8060", Offset = "0x5FF6A60", VA = "0x185FF8060")]
	public static KeepsakeTheme OBGLNBMHECN(this PLPLAPGGIAM FHOCAIDBAPC, FFBKIBIIJNG LFEHNEMMDEO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7EB0", Offset = "0x5FF68B0", VA = "0x185FF7EB0")]
	public static List<KeepsakeTheme> MOMMBMIOAMM(this PLPLAPGGIAM FHOCAIDBAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7DA0", Offset = "0x5FF67A0", VA = "0x185FF7DA0")]
	public static FFBKIBIIJNG HNNAHNMPFBN(this PLPLAPGGIAM FHOCAIDBAPC, Guid NGFIMDLEMBB)
	{
		return default(FFBKIBIIJNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7E30", Offset = "0x5FF6830", VA = "0x185FF7E30")]
	public static int MABDDHDGHHN(this PLPLAPGGIAM FHOCAIDBAPC, FFBKIBIIJNG MGJIPDCMPMO)
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
