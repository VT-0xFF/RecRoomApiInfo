using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OJBGENLDPLB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x663E520", Offset = "0x663D320", VA = "0x18663E520")]
	public static KeepsakeTheme HLPLCIJGEAL(this GCAGGPINOLE OBAPIKNALOO, Guid LOLLNBGLCPK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x663E610", Offset = "0x663D410", VA = "0x18663E610")]
	public static KeepsakeTheme HLPLCIJGEAL(this GCAGGPINOLE OBAPIKNALOO, HKHJHFEFCAI DANANDBCFIA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x663E470", Offset = "0x663D270", VA = "0x18663E470")]
	public static List<KeepsakeTheme> EPKCOMGOHMJ(this GCAGGPINOLE OBAPIKNALOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x663E6B0", Offset = "0x663D4B0", VA = "0x18663E6B0")]
	public static HKHJHFEFCAI PJJCBPEEMOA(this GCAGGPINOLE OBAPIKNALOO, Guid LOLLNBGLCPK)
	{
		return default(HKHJHFEFCAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x663E3F0", Offset = "0x663D1F0", VA = "0x18663E3F0")]
	public static int EOIKGICCEAJ(this GCAGGPINOLE OBAPIKNALOO, HKHJHFEFCAI AFNJJGDFFOE)
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
