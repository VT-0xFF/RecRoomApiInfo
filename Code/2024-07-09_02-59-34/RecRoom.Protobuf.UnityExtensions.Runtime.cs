using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GGDOGMKNIMF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x70142D0", Offset = "0x7012ED0", VA = "0x1870142D0")]
	public static FOGJAJHMHFE CJJBNJOFCID([In] this Color ENEDBNLKLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7014350", Offset = "0x7012F50", VA = "0x187014350")]
	public static Color GCPIDJEBGBI(this FOGJAJHMHFE ENEDBNLKLJL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7014380", Offset = "0x7012F80", VA = "0x187014380")]
	public static Color? NKLGNPIOEED(this FOGJAJHMHFE ENEDBNLKLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LMBGLCGBCJB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7014660", Offset = "0x7013260", VA = "0x187014660")]
	public static Quaternion GHONBMMEHFC(MENIOHGHBAJ JGFKFMMOAJO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7014570", Offset = "0x7013170", VA = "0x187014570")]
	public static DDEPKBHFOHB CCFKLLIIFNN(Quaternion DNCKGNCNBKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7014880", Offset = "0x7013480", VA = "0x187014880")]
	public static Quaternion JEMKACEJEND(DDEPKBHFOHB JGFKFMMOAJO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PJBMHJEIDMD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7014920", Offset = "0x7013520", VA = "0x187014920")]
	public static JLHPLBBKPMF CJJBNJOFCID([In] this Quaternion ENEDBNLKLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70149A0", Offset = "0x70135A0", VA = "0x1870149A0")]
	public static Quaternion GCPIDJEBGBI(this JLHPLBBKPMF ENEDBNLKLJL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7014A10", Offset = "0x7013610", VA = "0x187014A10")]
	public static Quaternion? NKLGNPIOEED(this JLHPLBBKPMF ENEDBNLKLJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FMDIMNKIHFC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7014200", Offset = "0x7012E00", VA = "0x187014200")]
	public static INJKIKMMCME CJJBNJOFCID([In] this Vector2 ENEDBNLKLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7014270", Offset = "0x7012E70", VA = "0x187014270")]
	public static Vector2 GCPIDJEBGBI(this INJKIKMMCME ENEDBNLKLJL)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KFMKOAIBIAG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7014400", Offset = "0x7013000", VA = "0x187014400")]
	public static DDEPKBHFOHB CJJBNJOFCID([In] this Vector3 ENEDBNLKLJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7014470", Offset = "0x7013070", VA = "0x187014470")]
	public static Vector3 GCPIDJEBGBI(this DDEPKBHFOHB ENEDBNLKLJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x70144E0", Offset = "0x70130E0", VA = "0x1870144E0")]
	public static Vector3? NKLGNPIOEED(this DDEPKBHFOHB ENEDBNLKLJL)
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
