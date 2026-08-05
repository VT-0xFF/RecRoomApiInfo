using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ACGGMJHHCEO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6544700", Offset = "0x6543500", VA = "0x186544700")]
	public static LJDOHNNKNIF FILLENIGNNA([In] this Color CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65446D0", Offset = "0x65434D0", VA = "0x1865446D0")]
	public static Color CINNELLPCMC(this LJDOHNNKNIF CNFBJPGPBBJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6544780", Offset = "0x6543580", VA = "0x186544780")]
	public static Color? MJNOHMDPBHE(this LJDOHNNKNIF CNFBJPGPBBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HFOLOOOOJDK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6544990", Offset = "0x6543790", VA = "0x186544990")]
	public static Quaternion JBKKEFPBNBL(GAHOBMFLGJF OMHIFBJFAGA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6544C50", Offset = "0x6543A50", VA = "0x186544C50")]
	public static MIPILLNLJFC NFJMMGCHGKF(Quaternion JAFLJADBPIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6544BB0", Offset = "0x65439B0", VA = "0x186544BB0")]
	public static Quaternion KGPEDPIMFLE(MIPILLNLJFC OMHIFBJFAGA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AJGHECDNILP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6544870", Offset = "0x6543670", VA = "0x186544870")]
	public static MIILMKECONB FILLENIGNNA([In] this Quaternion CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6544800", Offset = "0x6543600", VA = "0x186544800")]
	public static Quaternion CINNELLPCMC(this MIILMKECONB CNFBJPGPBBJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65448F0", Offset = "0x65436F0", VA = "0x1865448F0")]
	public static Quaternion? MJNOHMDPBHE(this MIILMKECONB CNFBJPGPBBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MEAKCOGCHDL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6544F10", Offset = "0x6543D10", VA = "0x186544F10")]
	public static GJHFOPPOCEE FILLENIGNNA([In] this Vector2 CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6544EB0", Offset = "0x6543CB0", VA = "0x186544EB0")]
	public static Vector2 CINNELLPCMC(this GJHFOPPOCEE CNFBJPGPBBJ)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MBJDLKDOMBP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6544DB0", Offset = "0x6543BB0", VA = "0x186544DB0")]
	public static MIPILLNLJFC FILLENIGNNA([In] this Vector3 CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6544D40", Offset = "0x6543B40", VA = "0x186544D40")]
	public static Vector3 CINNELLPCMC(this MIPILLNLJFC CNFBJPGPBBJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6544E20", Offset = "0x6543C20", VA = "0x186544E20")]
	public static Vector3? MJNOHMDPBHE(this MIPILLNLJFC CNFBJPGPBBJ)
	{
		return null;
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
