using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IGCAPHPPAGN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67B3540", Offset = "0x67B2740", VA = "0x1867B3540")]
	public static KCILNBHOPIC OHDBDPJBHPM([In] this Color KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67B3490", Offset = "0x67B2690", VA = "0x1867B3490")]
	public static Color LKMADFBDLGL(this KCILNBHOPIC KNKOEEEKHDK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67B34C0", Offset = "0x67B26C0", VA = "0x1867B34C0")]
	public static Color? MDPMPHOGCCG(this KCILNBHOPIC KNKOEEEKHDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AHCIIIEHAIH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67B2F80", Offset = "0x67B2180", VA = "0x1867B2F80")]
	public static Quaternion EAAKMHCCBHF(LKMPCDDAOCP FODGEDCJIDC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67B3230", Offset = "0x67B2430", VA = "0x1867B3230")]
	public static BJIEAOIOLDL GPLGIMLFFMN(Quaternion GHDHEFAJCMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67B3190", Offset = "0x67B2390", VA = "0x1867B3190")]
	public static Quaternion GBIOFEEEEAF(BJIEAOIOLDL FODGEDCJIDC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JCAJBJMICGE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67B36D0", Offset = "0x67B28D0", VA = "0x1867B36D0")]
	public static GGKHKENDCID OHDBDPJBHPM([In] this Quaternion KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67B35C0", Offset = "0x67B27C0", VA = "0x1867B35C0")]
	public static Quaternion LKMADFBDLGL(this GGKHKENDCID KNKOEEEKHDK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67B3630", Offset = "0x67B2830", VA = "0x1867B3630")]
	public static Quaternion? MDPMPHOGCCG(this GGKHKENDCID KNKOEEEKHDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MLJJDNELPFG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67B37B0", Offset = "0x67B29B0", VA = "0x1867B37B0")]
	public static HPKOADDJOHD OHDBDPJBHPM([In] this Vector2 KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67B3750", Offset = "0x67B2950", VA = "0x1867B3750")]
	public static Vector2 LKMADFBDLGL(this HPKOADDJOHD KNKOEEEKHDK)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FJPOCHMIILO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67B3420", Offset = "0x67B2620", VA = "0x1867B3420")]
	public static BJIEAOIOLDL OHDBDPJBHPM([In] this Vector3 KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67B3320", Offset = "0x67B2520", VA = "0x1867B3320")]
	public static Vector3 LKMADFBDLGL(this BJIEAOIOLDL KNKOEEEKHDK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67B3390", Offset = "0x67B2590", VA = "0x1867B3390")]
	public static Vector3? MDPMPHOGCCG(this BJIEAOIOLDL KNKOEEEKHDK)
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
