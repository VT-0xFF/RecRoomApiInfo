using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HDFJJANEKNP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65AB6A0", Offset = "0x65AAAA0", VA = "0x1865AB6A0")]
	public static CPDNMHIIOPB GOGJDIDOEDD([In] this Color LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65AB670", Offset = "0x65AAA70", VA = "0x1865AB670")]
	public static Color BOEOGBDBLGM(this CPDNMHIIOPB LHCHBOKBAPK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x65AB720", Offset = "0x65AAB20", VA = "0x1865AB720")]
	public static Color? KNEMLNHBLNF(this CPDNMHIIOPB LHCHBOKBAPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LMFJMKOJAMB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x65AB930", Offset = "0x65AAD30", VA = "0x1865AB930")]
	public static Quaternion BNOAKIMJEOH(ELILFCMNIOB GMLIPIALCHN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65ABBF0", Offset = "0x65AAFF0", VA = "0x1865ABBF0")]
	public static GAEBDNFNIFF LDPHJCAPDHE(Quaternion AHJHNIPECLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x65ABB50", Offset = "0x65AAF50", VA = "0x1865ABB50")]
	public static Quaternion DGPBGCCOEBN(GAEBDNFNIFF GMLIPIALCHN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LCKDLKKGFIC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65AB810", Offset = "0x65AAC10", VA = "0x1865AB810")]
	public static CJNMHFFIFPJ GOGJDIDOEDD([In] this Quaternion LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65AB7A0", Offset = "0x65AABA0", VA = "0x1865AB7A0")]
	public static Quaternion BOEOGBDBLGM(this CJNMHFFIFPJ LHCHBOKBAPK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65AB890", Offset = "0x65AAC90", VA = "0x1865AB890")]
	public static Quaternion? KNEMLNHBLNF(this CJNMHFFIFPJ LHCHBOKBAPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OHIKLKLMNFF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x65ABD40", Offset = "0x65AB140", VA = "0x1865ABD40")]
	public static IDEHGHDMJMG GOGJDIDOEDD([In] this Vector2 LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65ABCE0", Offset = "0x65AB0E0", VA = "0x1865ABCE0")]
	public static Vector2 BOEOGBDBLGM(this IDEHGHDMJMG LHCHBOKBAPK)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DAFHJKEHAFD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65AB570", Offset = "0x65AA970", VA = "0x1865AB570")]
	public static GAEBDNFNIFF GOGJDIDOEDD([In] this Vector3 LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65AB500", Offset = "0x65AA900", VA = "0x1865AB500")]
	public static Vector3 BOEOGBDBLGM(this GAEBDNFNIFF LHCHBOKBAPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x65AB5E0", Offset = "0x65AA9E0", VA = "0x1865AB5E0")]
	public static Vector3? KNEMLNHBLNF(this GAEBDNFNIFF LHCHBOKBAPK)
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
