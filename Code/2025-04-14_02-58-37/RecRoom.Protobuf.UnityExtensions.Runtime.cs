using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LAKCOMNDBAB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80508D0", Offset = "0x804F2D0", VA = "0x1880508D0")]
	public static PPIPPNJIBCB CFLEALCFLNK([In] this Color IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8050950", Offset = "0x804F350", VA = "0x188050950")]
	public static Color DHOLDBOACBA(this PPIPPNJIBCB IJPDNJELPLO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8050980", Offset = "0x804F380", VA = "0x188050980")]
	public static Color? GAALFAPKPIM(this PPIPPNJIBCB IJPDNJELPLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PGPMCBPCGIF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8050DC0", Offset = "0x804F7C0", VA = "0x188050DC0")]
	public static Quaternion EPFMGLCJAGA(POFDEDHEBPJ DFPGGEDGGGN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8050FD0", Offset = "0x804F9D0", VA = "0x188050FD0")]
	public static NJHGGPJNBAC HLCBGEOMNAE(Quaternion FKJJBOOPDIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80510C0", Offset = "0x804FAC0", VA = "0x1880510C0")]
	public static Quaternion KBDOOCKEMDB(NJHGGPJNBAC DFPGGEDGGGN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MJHIJHFANPP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8050A00", Offset = "0x804F400", VA = "0x188050A00")]
	public static BJFNFPPJJBJ CFLEALCFLNK([In] this Quaternion IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8050A80", Offset = "0x804F480", VA = "0x188050A80")]
	public static Quaternion DHOLDBOACBA(this BJFNFPPJJBJ IJPDNJELPLO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8050AF0", Offset = "0x804F4F0", VA = "0x188050AF0")]
	public static Quaternion? GAALFAPKPIM(this BJFNFPPJJBJ IJPDNJELPLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JFIGGLEPAPO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8050800", Offset = "0x804F200", VA = "0x188050800")]
	public static EDLIJDHGLKM CFLEALCFLNK([In] this Vector2 IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8050870", Offset = "0x804F270", VA = "0x188050870")]
	public static Vector2 DHOLDBOACBA(this EDLIJDHGLKM IJPDNJELPLO)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NHIPJCKGGCP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8050B90", Offset = "0x804F590", VA = "0x188050B90")]
	public static NJHGGPJNBAC CFLEALCFLNK([In] this Vector3 IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8050D00", Offset = "0x804F700", VA = "0x188050D00")]
	public static NJHGGPJNBAC IBLKOEJNCPL([In] this Vector3? IJPDNJELPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8050C00", Offset = "0x804F600", VA = "0x188050C00")]
	public static Vector3 DHOLDBOACBA(this NJHGGPJNBAC IJPDNJELPLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8050C70", Offset = "0x804F670", VA = "0x188050C70")]
	public static Vector3? GAALFAPKPIM(this NJHGGPJNBAC IJPDNJELPLO)
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
