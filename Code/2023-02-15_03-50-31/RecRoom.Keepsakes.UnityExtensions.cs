using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JIJCLNNNFEL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64A3DF0", Offset = "0x64A31F0", VA = "0x1864A3DF0")]
	public static KeepsakeTheme PHEMICIODIA(this AOCHACKAKMO OBOKKBNADPB, Guid EODPCOEOPHD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64A3D00", Offset = "0x64A3100", VA = "0x1864A3D00")]
	public static KeepsakeTheme PHEMICIODIA(this AOCHACKAKMO OBOKKBNADPB, GICFHEKEBDK OBAGJCOFCHI)
	{
		return default(KeepsakeTheme);
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
