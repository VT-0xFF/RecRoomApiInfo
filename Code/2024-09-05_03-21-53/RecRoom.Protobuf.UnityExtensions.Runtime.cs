using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GFONNHKKJIP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x720C140", Offset = "0x720AB40", VA = "0x18720C140")]
	public static HECNLIJJPPA LKLOMDOAOHF([In] this Color PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x720C110", Offset = "0x720AB10", VA = "0x18720C110")]
	public static Color ILDFGHALABA(this HECNLIJJPPA PECHDAFMNOO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x720C1C0", Offset = "0x720ABC0", VA = "0x18720C1C0")]
	public static Color? OCMDDMDBAKN(this HECNLIJJPPA PECHDAFMNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KDOHJDPDJMD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x720C4A0", Offset = "0x720AEA0", VA = "0x18720C4A0")]
	public static Quaternion NLIEANHMMHC(ADBOECIIEHE OIGMDCDEKEG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x720C3B0", Offset = "0x720ADB0", VA = "0x18720C3B0")]
	public static MENHNALOKBE MFKNENAMPFC(Quaternion EDHNHMKOMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x720C310", Offset = "0x720AD10", VA = "0x18720C310")]
	public static Quaternion BAFILGANBGM(MENHNALOKBE OIGMDCDEKEG)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MCAACLIKGPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x720C720", Offset = "0x720B120", VA = "0x18720C720")]
	public static FBAJINKLDNO LKLOMDOAOHF([In] this Quaternion PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x720C6B0", Offset = "0x720B0B0", VA = "0x18720C6B0")]
	public static Quaternion ILDFGHALABA(this FBAJINKLDNO PECHDAFMNOO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x720C7A0", Offset = "0x720B1A0", VA = "0x18720C7A0")]
	public static Quaternion? OCMDDMDBAKN(this FBAJINKLDNO PECHDAFMNOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HHEJHNGAAPP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x720C2A0", Offset = "0x720ACA0", VA = "0x18720C2A0")]
	public static FGPFNJJFMAE LKLOMDOAOHF([In] this Vector2 PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x720C240", Offset = "0x720AC40", VA = "0x18720C240")]
	public static Vector2 ILDFGHALABA(this FGPFNJJFMAE PECHDAFMNOO)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FBGLJGLCJHH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x720BF50", Offset = "0x720A950", VA = "0x18720BF50")]
	public static MENHNALOKBE LKLOMDOAOHF([In] this Vector3 PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x720BFC0", Offset = "0x720A9C0", VA = "0x18720BFC0")]
	public static MENHNALOKBE NMOLEMIBIAN([In] this Vector3? PECHDAFMNOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x720BEE0", Offset = "0x720A8E0", VA = "0x18720BEE0")]
	public static Vector3 ILDFGHALABA(this MENHNALOKBE PECHDAFMNOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x720C080", Offset = "0x720AA80", VA = "0x18720C080")]
	public static Vector3? OCMDDMDBAKN(this MENHNALOKBE PECHDAFMNOO)
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
