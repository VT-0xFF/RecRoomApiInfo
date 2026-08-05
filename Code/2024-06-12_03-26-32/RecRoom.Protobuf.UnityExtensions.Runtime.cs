using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MMCAAFBOBMC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E900", Offset = "0x6F0D500", VA = "0x186F0E900")]
	public static GJGODDAJKGG PLFEAILJDFE([In] this Color HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E850", Offset = "0x6F0D450", VA = "0x186F0E850")]
	public static Color EGCBEAACMHC(this GJGODDAJKGG HNFMOHFACKF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E880", Offset = "0x6F0D480", VA = "0x186F0E880")]
	public static Color? PJLBLDNBHKE(this GJGODDAJKGG HNFMOHFACKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EBKEJEEHIED
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E300", Offset = "0x6F0CF00", VA = "0x186F0E300")]
	public static Quaternion DBLJJPAKLJF(BBMOLDMMHFA IMCLGJBJJKP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E520", Offset = "0x6F0D120", VA = "0x186F0E520")]
	public static EEBIFENPAPG EMHOPPIPKDI(Quaternion EILOPFMFJKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E260", Offset = "0x6F0CE60", VA = "0x186F0E260")]
	public static Quaternion CJMLCHJHGPN(EEBIFENPAPG IMCLGJBJJKP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BGMJMLJNCOA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E1E0", Offset = "0x6F0CDE0", VA = "0x186F0E1E0")]
	public static PEKMNLBILKH PLFEAILJDFE([In] this Quaternion HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E0D0", Offset = "0x6F0CCD0", VA = "0x186F0E0D0")]
	public static Quaternion EGCBEAACMHC(this PEKMNLBILKH HNFMOHFACKF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E140", Offset = "0x6F0CD40", VA = "0x186F0E140")]
	public static Quaternion? PJLBLDNBHKE(this PEKMNLBILKH HNFMOHFACKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KFKLAIKCBHP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E670", Offset = "0x6F0D270", VA = "0x186F0E670")]
	public static MCENINEIDDK PLFEAILJDFE([In] this Vector2 HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E610", Offset = "0x6F0D210", VA = "0x186F0E610")]
	public static Vector2 EGCBEAACMHC(this MCENINEIDDK HNFMOHFACKF)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MLDFDNKDKNL
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E7E0", Offset = "0x6F0D3E0", VA = "0x186F0E7E0")]
	public static EEBIFENPAPG PLFEAILJDFE([In] this Vector3 HNFMOHFACKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E6E0", Offset = "0x6F0D2E0", VA = "0x186F0E6E0")]
	public static Vector3 EGCBEAACMHC(this EEBIFENPAPG HNFMOHFACKF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F0E750", Offset = "0x6F0D350", VA = "0x186F0E750")]
	public static Vector3? PJLBLDNBHKE(this EEBIFENPAPG HNFMOHFACKF)
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
