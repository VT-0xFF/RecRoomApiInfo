using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HGNPGNACFIE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x649A540", Offset = "0x6499940", VA = "0x18649A540")]
	public static EHMBEHEJKAN LENOCDGJGPN([In] this Color NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x649A490", Offset = "0x6499890", VA = "0x18649A490")]
	public static Color AFFCBAMFOKP(this EHMBEHEJKAN NHHBAHIFHJK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x649A4C0", Offset = "0x64998C0", VA = "0x18649A4C0")]
	public static Color? FNBGHJJJFLL(this EHMBEHEJKAN NHHBAHIFHJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DLKKJBBGFFH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x649A100", Offset = "0x6499500", VA = "0x18649A100")]
	public static Quaternion GGPMPKKPMAK(BBDCNCLNGFI MFNOAEFOKBK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x649A010", Offset = "0x6499410", VA = "0x18649A010")]
	public static PAJPNFIFKEP FIMJNINLJEB(Quaternion PHGFEIMKEKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x649A320", Offset = "0x6499720", VA = "0x18649A320")]
	public static Quaternion ODLNJCCNJMG(PAJPNFIFKEP MFNOAEFOKBK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IAEGIGBICOI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x649A6D0", Offset = "0x6499AD0", VA = "0x18649A6D0")]
	public static OFFDFEFMCPM LENOCDGJGPN([In] this Quaternion NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x649A5C0", Offset = "0x64999C0", VA = "0x18649A5C0")]
	public static Quaternion AFFCBAMFOKP(this OFFDFEFMCPM NHHBAHIFHJK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x649A630", Offset = "0x6499A30", VA = "0x18649A630")]
	public static Quaternion? FNBGHJJJFLL(this OFFDFEFMCPM NHHBAHIFHJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DPBMAINJKGK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x649A420", Offset = "0x6499820", VA = "0x18649A420")]
	public static LBHPCAJFLGA LENOCDGJGPN([In] this Vector2 NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x649A3C0", Offset = "0x64997C0", VA = "0x18649A3C0")]
	public static Vector2 AFFCBAMFOKP(this LBHPCAJFLGA NHHBAHIFHJK)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CMPJOEMMPIE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6499FA0", Offset = "0x64993A0", VA = "0x186499FA0")]
	public static PAJPNFIFKEP LENOCDGJGPN([In] this Vector3 NHHBAHIFHJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6499EA0", Offset = "0x64992A0", VA = "0x186499EA0")]
	public static Vector3 AFFCBAMFOKP(this PAJPNFIFKEP NHHBAHIFHJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6499F10", Offset = "0x6499310", VA = "0x186499F10")]
	public static Vector3? FNBGHJJJFLL(this PAJPNFIFKEP NHHBAHIFHJK)
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
