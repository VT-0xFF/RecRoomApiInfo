using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FFLMPOODBCA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7611AF0", Offset = "0x76102F0", VA = "0x187611AF0")]
	public static AIDHMOPKDHH KBGBIJFEDIC([In] this Color EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7611B70", Offset = "0x7610370", VA = "0x187611B70")]
	public static Color KDFBDMHOPOO(this AIDHMOPKDHH EGGDEECAALI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7611A70", Offset = "0x7610270", VA = "0x187611A70")]
	public static Color? FOEDLADGEBA(this AIDHMOPKDHH EGGDEECAALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KDCHJCKDCEC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7611C40", Offset = "0x7610440", VA = "0x187611C40")]
	public static Quaternion IHFLOOALHCM(FFHJMMELHAC EBNFOODJNOB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7611E50", Offset = "0x7610650", VA = "0x187611E50")]
	public static CKEBIHOJCBI LAAIBCKOMBA(Quaternion NIDJCMNFKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7611BA0", Offset = "0x76103A0", VA = "0x187611BA0")]
	public static Quaternion HHIDICFBKEF(CKEBIHOJCBI EBNFOODJNOB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PBOKOCJANDN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7612210", Offset = "0x7610A10", VA = "0x187612210")]
	public static DBGOLPGFKLN KBGBIJFEDIC([In] this Quaternion EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7612290", Offset = "0x7610A90", VA = "0x187612290")]
	public static Quaternion KDFBDMHOPOO(this DBGOLPGFKLN EGGDEECAALI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7612170", Offset = "0x7610970", VA = "0x187612170")]
	public static Quaternion? FOEDLADGEBA(this DBGOLPGFKLN EGGDEECAALI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CIDPAHFBBFA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76119A0", Offset = "0x76101A0", VA = "0x1876119A0")]
	public static IHEOLAJLLDD KBGBIJFEDIC([In] this Vector2 EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7611A10", Offset = "0x7610210", VA = "0x187611A10")]
	public static Vector2 KDFBDMHOPOO(this IHEOLAJLLDD EGGDEECAALI)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KONMJCGBJAH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7611FD0", Offset = "0x76107D0", VA = "0x187611FD0")]
	public static CKEBIHOJCBI KBGBIJFEDIC([In] this Vector3 EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76120B0", Offset = "0x76108B0", VA = "0x1876120B0")]
	public static CKEBIHOJCBI NEMKKBDLHLB([In] this Vector3? EGGDEECAALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7612040", Offset = "0x7610840", VA = "0x187612040")]
	public static Vector3 KDFBDMHOPOO(this CKEBIHOJCBI EGGDEECAALI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7611F40", Offset = "0x7610740", VA = "0x187611F40")]
	public static Vector3? FOEDLADGEBA(this CKEBIHOJCBI EGGDEECAALI)
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
