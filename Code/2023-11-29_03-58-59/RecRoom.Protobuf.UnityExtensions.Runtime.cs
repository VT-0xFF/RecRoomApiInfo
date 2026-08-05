using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HIDJJBPAFIH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x638FCC0", Offset = "0x638F0C0", VA = "0x18638FCC0")]
	public static JEGPEBECNNF ALIOEPOJFBC([In] this Color EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x638FDC0", Offset = "0x638F1C0", VA = "0x18638FDC0")]
	public static Color JKMDPBEAKHM(this JEGPEBECNNF EAODMOEAJOC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x638FD40", Offset = "0x638F140", VA = "0x18638FD40")]
	public static Color? IJIBCIDEHKI(this JEGPEBECNNF EAODMOEAJOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GHGABCJHNFD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x638F7A0", Offset = "0x638EBA0", VA = "0x18638F7A0")]
	public static Quaternion CPJFNCCIJEK(FPNHOBDNEKJ KKOACPFFAML)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x638F9C0", Offset = "0x638EDC0", VA = "0x18638F9C0")]
	public static GIEHIBJLBHG FGPKDNBMMOB(Quaternion HIACCOHCOGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x638FAB0", Offset = "0x638EEB0", VA = "0x18638FAB0")]
	public static Quaternion IJJLPPNIEJH(GIEHIBJLBHG KKOACPFFAML)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DNNLJADKBCB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x638F610", Offset = "0x638EA10", VA = "0x18638F610")]
	public static JBPJIFIMIHP ALIOEPOJFBC([In] this Quaternion EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x638F730", Offset = "0x638EB30", VA = "0x18638F730")]
	public static Quaternion JKMDPBEAKHM(this JBPJIFIMIHP EAODMOEAJOC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x638F690", Offset = "0x638EA90", VA = "0x18638F690")]
	public static Quaternion? IJIBCIDEHKI(this JBPJIFIMIHP EAODMOEAJOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DIGDLPHCKIH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638E940", VA = "0x18638F540")]
	public static BHLOOCNEPDN ALIOEPOJFBC([In] this Vector2 EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x638F5B0", Offset = "0x638E9B0", VA = "0x18638F5B0")]
	public static Vector2 JKMDPBEAKHM(this BHLOOCNEPDN EAODMOEAJOC)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HALDJOOBKED
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x638FB50", Offset = "0x638EF50", VA = "0x18638FB50")]
	public static GIEHIBJLBHG ALIOEPOJFBC([In] this Vector3 EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x638FC50", Offset = "0x638F050", VA = "0x18638FC50")]
	public static Vector3 JKMDPBEAKHM(this GIEHIBJLBHG EAODMOEAJOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x638FBC0", Offset = "0x638EFC0", VA = "0x18638FBC0")]
	public static Vector3? IJIBCIDEHKI(this GIEHIBJLBHG EAODMOEAJOC)
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
