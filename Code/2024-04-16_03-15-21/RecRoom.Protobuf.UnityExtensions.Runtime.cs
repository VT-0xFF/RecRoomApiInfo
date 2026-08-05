using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OPAEPGJHFCG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66F1BE0", Offset = "0x66F0DE0", VA = "0x1866F1BE0")]
	public static BJJBKPGKBGC JCBMCDNAHJB([In] this Color AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66F1C60", Offset = "0x66F0E60", VA = "0x1866F1C60")]
	public static Color MAOCPLNNJJM(this BJJBKPGKBGC AOFIGDLFNLH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66F1B60", Offset = "0x66F0D60", VA = "0x1866F1B60")]
	public static Color? FKJMLCMIINH(this BJJBKPGKBGC AOFIGDLFNLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DMODPBLCGOD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x66F1490", Offset = "0x66F0690", VA = "0x1866F1490")]
	public static Quaternion LDIIKAPEEBF(JAKLOCLGLGE MJGHOBDIDHD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66F16A0", Offset = "0x66F08A0", VA = "0x1866F16A0")]
	public static ACEONDEPGPG NIDNCOOGLDN(Quaternion KLJAJFBONNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x66F13F0", Offset = "0x66F05F0", VA = "0x1866F13F0")]
	public static Quaternion IJNJJPHPEBK(ACEONDEPGPG MJGHOBDIDHD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LNCMIKCHBOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66F1A70", Offset = "0x66F0C70", VA = "0x1866F1A70")]
	public static EONDKGJOAGL JCBMCDNAHJB([In] this Quaternion AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66F1AF0", Offset = "0x66F0CF0", VA = "0x1866F1AF0")]
	public static Quaternion MAOCPLNNJJM(this EONDKGJOAGL AOFIGDLFNLH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66F19D0", Offset = "0x66F0BD0", VA = "0x1866F19D0")]
	public static Quaternion? FKJMLCMIINH(this EONDKGJOAGL AOFIGDLFNLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IFJHMKOKHBK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x66F1900", Offset = "0x66F0B00", VA = "0x1866F1900")]
	public static ELIAFCNLOBH JCBMCDNAHJB([In] this Vector2 AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66F1970", Offset = "0x66F0B70", VA = "0x1866F1970")]
	public static Vector2 MAOCPLNNJJM(this ELIAFCNLOBH AOFIGDLFNLH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HHJMLHEOMBJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66F1820", Offset = "0x66F0A20", VA = "0x1866F1820")]
	public static ACEONDEPGPG JCBMCDNAHJB([In] this Vector3 AOFIGDLFNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66F1890", Offset = "0x66F0A90", VA = "0x1866F1890")]
	public static Vector3 MAOCPLNNJJM(this ACEONDEPGPG AOFIGDLFNLH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x66F1790", Offset = "0x66F0990", VA = "0x1866F1790")]
	public static Vector3? FKJMLCMIINH(this ACEONDEPGPG AOFIGDLFNLH)
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
