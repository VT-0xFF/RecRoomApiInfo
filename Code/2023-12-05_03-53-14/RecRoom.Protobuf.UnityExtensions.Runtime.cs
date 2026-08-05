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
	[Cpp2IlInjected.Address(RVA = "0x638FBE0", Offset = "0x638EFE0", VA = "0x18638FBE0")]
	public static JEGPEBECNNF ALIOEPOJFBC([In] this Color EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x638FCE0", Offset = "0x638F0E0", VA = "0x18638FCE0")]
	public static Color JKMDPBEAKHM(this JEGPEBECNNF EAODMOEAJOC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x638FC60", Offset = "0x638F060", VA = "0x18638FC60")]
	public static Color? IJIBCIDEHKI(this JEGPEBECNNF EAODMOEAJOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GHGABCJHNFD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x638F6C0", Offset = "0x638EAC0", VA = "0x18638F6C0")]
	public static Quaternion CPJFNCCIJEK(FPNHOBDNEKJ KKOACPFFAML)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x638F8E0", Offset = "0x638ECE0", VA = "0x18638F8E0")]
	public static GIEHIBJLBHG FGPKDNBMMOB(Quaternion HIACCOHCOGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x638F9D0", Offset = "0x638EDD0", VA = "0x18638F9D0")]
	public static Quaternion IJJLPPNIEJH(GIEHIBJLBHG KKOACPFFAML)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DNNLJADKBCB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x638F530", Offset = "0x638E930", VA = "0x18638F530")]
	public static JBPJIFIMIHP ALIOEPOJFBC([In] this Quaternion EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x638F650", Offset = "0x638EA50", VA = "0x18638F650")]
	public static Quaternion JKMDPBEAKHM(this JBPJIFIMIHP EAODMOEAJOC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x638F5B0", Offset = "0x638E9B0", VA = "0x18638F5B0")]
	public static Quaternion? IJIBCIDEHKI(this JBPJIFIMIHP EAODMOEAJOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DIGDLPHCKIH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x638F460", Offset = "0x638E860", VA = "0x18638F460")]
	public static BHLOOCNEPDN ALIOEPOJFBC([In] this Vector2 EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x638F4D0", Offset = "0x638E8D0", VA = "0x18638F4D0")]
	public static Vector2 JKMDPBEAKHM(this BHLOOCNEPDN EAODMOEAJOC)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HALDJOOBKED
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x638FA70", Offset = "0x638EE70", VA = "0x18638FA70")]
	public static GIEHIBJLBHG ALIOEPOJFBC([In] this Vector3 EAODMOEAJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x638FB70", Offset = "0x638EF70", VA = "0x18638FB70")]
	public static Vector3 JKMDPBEAKHM(this GIEHIBJLBHG EAODMOEAJOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x638FAE0", Offset = "0x638EEE0", VA = "0x18638FAE0")]
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
