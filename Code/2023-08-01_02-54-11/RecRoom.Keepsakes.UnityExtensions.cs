using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class POFIGBIKMHL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72C7200", Offset = "0x72C6200", VA = "0x1872C7200")]
	public static KeepsakeTheme OCEGDNOKCAD(this OOJGBAODHBI NKHIMAEJAFL, Guid DOFNMNEMDFH)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72C70F0", Offset = "0x72C60F0", VA = "0x1872C70F0")]
	public static KeepsakeTheme OCEGDNOKCAD(this OOJGBAODHBI NKHIMAEJAFL, POHMPBPHJDB AAJHDBIOLHD)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72C7040", Offset = "0x72C6040", VA = "0x1872C7040")]
	public static List<KeepsakeTheme> GLLPLBHKNHB(this OOJGBAODHBI NKHIMAEJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72C6FB0", Offset = "0x72C5FB0", VA = "0x1872C6FB0")]
	public static POHMPBPHJDB FMNENGAIFPG(this OOJGBAODHBI NKHIMAEJAFL, Guid DOFNMNEMDFH)
	{
		return default(POHMPBPHJDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x72C7300", Offset = "0x72C6300", VA = "0x1872C7300")]
	public static int PDAAODCIOFO(this OOJGBAODHBI NKHIMAEJAFL, POHMPBPHJDB FBBPJENJIDG)
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
