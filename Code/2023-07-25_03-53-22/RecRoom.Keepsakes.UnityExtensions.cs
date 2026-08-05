using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EFEKGHCIMIB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7305580", Offset = "0x7304580", VA = "0x187305580")]
	public static KeepsakeTheme MJHEBBNDMLI(this CPLICJDPDAC ALPIPCHDOEM, Guid LMKJBONLEIO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7305680", Offset = "0x7304680", VA = "0x187305680")]
	public static KeepsakeTheme MJHEBBNDMLI(this CPLICJDPDAC ALPIPCHDOEM, KMEGHOEMOEP BIBPJHLPPCO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x73053C0", Offset = "0x73043C0", VA = "0x1873053C0")]
	public static List<KeepsakeTheme> DOHHPFIBNON(this CPLICJDPDAC ALPIPCHDOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7305470", Offset = "0x7304470", VA = "0x187305470")]
	public static KMEGHOEMOEP GDHLADOAMMJ(this CPLICJDPDAC ALPIPCHDOEM, Guid LMKJBONLEIO)
	{
		return default(KMEGHOEMOEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7305500", Offset = "0x7304500", VA = "0x187305500")]
	public static int JMBHPCLDNMI(this CPLICJDPDAC ALPIPCHDOEM, KMEGHOEMOEP EIIJKHEKNOL)
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
