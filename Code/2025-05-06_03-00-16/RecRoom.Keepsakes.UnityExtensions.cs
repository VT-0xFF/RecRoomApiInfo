using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DMHFEINIHDC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B7A900", Offset = "0x7B79100", VA = "0x187B7A900")]
	public static KeepsakeTheme GNIBIFMLEKM(this BNEMALMGLKL IPKPNIAEJDE, Guid HNPAEJPLMGK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B7AA00", Offset = "0x7B79200", VA = "0x187B7AA00")]
	public static KeepsakeTheme GNIBIFMLEKM(this BNEMALMGLKL IPKPNIAEJDE, CCAFHCPHPLB EMEKLPBAJBE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B7AAB0", Offset = "0x7B792B0", VA = "0x187B7AAB0")]
	public static List<KeepsakeTheme> HMNJFKCJFLP(this BNEMALMGLKL IPKPNIAEJDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B7AC10", Offset = "0x7B79410", VA = "0x187B7AC10")]
	public static CCAFHCPHPLB PIDCMHHDDDJ(this BNEMALMGLKL IPKPNIAEJDE, Guid HNPAEJPLMGK)
	{
		return default(CCAFHCPHPLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B7AB80", Offset = "0x7B79380", VA = "0x187B7AB80")]
	public static int PFECKPCKAAE(this BNEMALMGLKL IPKPNIAEJDE, CCAFHCPHPLB AKOLCMIIEMC)
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
