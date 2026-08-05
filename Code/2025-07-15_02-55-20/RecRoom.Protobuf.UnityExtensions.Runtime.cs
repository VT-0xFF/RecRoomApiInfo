using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OOOJHFNONEM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8910BE0", Offset = "0x890F7E0", VA = "0x188910BE0")]
	public static CCCNOHBIBGC PBHGMJKEMBG([In] this Color JBDFDFABHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8910BB0", Offset = "0x890F7B0", VA = "0x188910BB0")]
	public static Color GLDNKJDIMCO(this CCCNOHBIBGC JBDFDFABHKD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8910C60", Offset = "0x890F860", VA = "0x188910C60")]
	public static Color? PLFICDJGGPK(this CCCNOHBIBGC JBDFDFABHKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LFABAJFJMFE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x89105E0", Offset = "0x890F1E0", VA = "0x1889105E0")]
	public static Quaternion KCNBEDBOPIP(PODEEDMNBMI CBCNBAPLLJM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x89107F0", Offset = "0x890F3F0", VA = "0x1889107F0")]
	public static CABLFPAFHCO LMFNHNAINNO(Quaternion AHCGFFPBEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x89108E0", Offset = "0x890F4E0", VA = "0x1889108E0")]
	public static Quaternion NHIFIOKFNKE(CABLFPAFHCO CBCNBAPLLJM)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BJAIDKKPDIL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x89103F0", Offset = "0x890EFF0", VA = "0x1889103F0")]
	public static MHLDCONGHML PBHGMJKEMBG([In] this Quaternion JBDFDFABHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8910380", Offset = "0x890EF80", VA = "0x188910380")]
	public static Quaternion GLDNKJDIMCO(this MHLDCONGHML JBDFDFABHKD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8910470", Offset = "0x890F070", VA = "0x188910470")]
	public static Quaternion? PLFICDJGGPK(this MHLDCONGHML JBDFDFABHKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HHBMPANKOMI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8910570", Offset = "0x890F170", VA = "0x188910570")]
	public static EACNAGBELHK PBHGMJKEMBG([In] this Vector2 JBDFDFABHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8910510", Offset = "0x890F110", VA = "0x188910510")]
	public static Vector2 GLDNKJDIMCO(this EACNAGBELHK JBDFDFABHKD)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OHKBBIOPKBK
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8910AB0", Offset = "0x890F6B0", VA = "0x188910AB0")]
	public static CABLFPAFHCO PBHGMJKEMBG([In] this Vector3 JBDFDFABHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x89109F0", Offset = "0x890F5F0", VA = "0x1889109F0")]
	public static CABLFPAFHCO OANDHPMIFJK([In] this Vector3? JBDFDFABHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8910980", Offset = "0x890F580", VA = "0x188910980")]
	public static Vector3 GLDNKJDIMCO(this CABLFPAFHCO JBDFDFABHKD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8910B20", Offset = "0x890F720", VA = "0x188910B20")]
	public static Vector3? PLFICDJGGPK(this CABLFPAFHCO JBDFDFABHKD)
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
