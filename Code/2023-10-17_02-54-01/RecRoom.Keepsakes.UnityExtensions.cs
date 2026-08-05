using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PKEEACNEDBH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD8F0", Offset = "0x5CFC0F0", VA = "0x185CFD8F0")]
	public static KeepsakeTheme KMLNHJAABMB(this PEKCJOMCNIK PNFHHOFJABN, Guid LDDLFIKKAPG)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD9E0", Offset = "0x5CFC1E0", VA = "0x185CFD9E0")]
	public static KeepsakeTheme KMLNHJAABMB(this PEKCJOMCNIK PNFHHOFJABN, BPIBHGMLEGG IFPLONFBLKI)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDB10", Offset = "0x5CFC310", VA = "0x185CFDB10")]
	public static List<KeepsakeTheme> NODAMIJBPMG(this PEKCJOMCNIK PNFHHOFJABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CFD860", Offset = "0x5CFC060", VA = "0x185CFD860")]
	public static BPIBHGMLEGG KAHCHGCGNED(this PEKCJOMCNIK PNFHHOFJABN, Guid LDDLFIKKAPG)
	{
		return default(BPIBHGMLEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDA90", Offset = "0x5CFC290", VA = "0x185CFDA90")]
	public static int NKNHACBAMND(this PEKCJOMCNIK PNFHHOFJABN, BPIBHGMLEGG PHIJOHODEPD)
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
