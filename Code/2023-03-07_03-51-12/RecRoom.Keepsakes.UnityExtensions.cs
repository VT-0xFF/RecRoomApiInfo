using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NBECJPAICDM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1A69600", Offset = "0x1A68A00", VA = "0x181A69600")]
	public static KeepsakeTheme OELHPDKHDGD(this DAFDICOBIOD NBEGMMIIDMD, Guid BHFEEHHPAJE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1A69700", Offset = "0x1A68B00", VA = "0x181A69700")]
	public static KeepsakeTheme OELHPDKHDGD(this DAFDICOBIOD NBEGMMIIDMD, BNJAPKFAEJH OGPFJLMNHLK)
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
