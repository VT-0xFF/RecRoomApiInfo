using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KIHDPJEKOMG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8359230", Offset = "0x8357C30", VA = "0x188359230")]
	public static KeepsakeTheme GACLPJEIJMI(this NGILPANNKKE NKHELPOPPEM, Guid DFAIPONKOEG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8359330", Offset = "0x8357D30", VA = "0x188359330")]
	public static KeepsakeTheme GACLPJEIJMI(this NGILPANNKKE NKHELPOPPEM, KCEPIFFHDBI HLFIJJOBFNM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x83593F0", Offset = "0x8357DF0", VA = "0x1883593F0")]
	public static List<KeepsakeTheme> KGHLNBEBPDD(this NGILPANNKKE NKHELPOPPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8359550", Offset = "0x8357F50", VA = "0x188359550")]
	public static KCEPIFFHDBI PAJFPLBICKJ(this NGILPANNKKE NKHELPOPPEM, Guid DFAIPONKOEG)
	{
		return default(KCEPIFFHDBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x83594C0", Offset = "0x8357EC0", VA = "0x1883594C0")]
	public static int OOKODAJGNOC(this NGILPANNKKE NKHELPOPPEM, KCEPIFFHDBI IPEDAEKNAAO)
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
