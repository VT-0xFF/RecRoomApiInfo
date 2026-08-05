using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OMNCDBCFJBM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84296E0", Offset = "0x84288E0", VA = "0x1884296E0")]
	public static KCOIBEOACMP CEBCPPBDNIB([In] this Color CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8429760", Offset = "0x8428960", VA = "0x188429760")]
	public static Color JKAINKAKBPB(this KCOIBEOACMP CEENCLMGJAM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8429790", Offset = "0x8428990", VA = "0x188429790")]
	public static Color? LBJKAKNHIOL(this KCOIBEOACMP CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MOOCNFNIBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84292A0", Offset = "0x84284A0", VA = "0x1884292A0")]
	public static Quaternion NJEFMLODPIH(LFFCLDOINOI DHAOEHNLNON)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8429110", Offset = "0x8428310", VA = "0x188429110")]
	public static BELCIKMIECJ BCBHOPMJKNF(Quaternion IDJHKLLHJFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8429200", Offset = "0x8428400", VA = "0x188429200")]
	public static Quaternion KGGPHFFCNAH(BELCIKMIECJ DHAOEHNLNON)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JABFGPKMNHL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8428EB0", Offset = "0x84280B0", VA = "0x188428EB0")]
	public static PKCKCMJJADK CEBCPPBDNIB([In] this Quaternion CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8428F30", Offset = "0x8428130", VA = "0x188428F30")]
	public static Quaternion JKAINKAKBPB(this PKCKCMJJADK CEENCLMGJAM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8428FA0", Offset = "0x84281A0", VA = "0x188428FA0")]
	public static Quaternion? LBJKAKNHIOL(this PKCKCMJJADK CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KPFCJBCKBJL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8429040", Offset = "0x8428240", VA = "0x188429040")]
	public static JJPDGEBBBBC CEBCPPBDNIB([In] this Vector2 CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84290B0", Offset = "0x84282B0", VA = "0x1884290B0")]
	public static Vector2 JKAINKAKBPB(this JJPDGEBBBBC CEENCLMGJAM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NOLPLGEPPML
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84294B0", Offset = "0x84286B0", VA = "0x1884294B0")]
	public static BELCIKMIECJ CEBCPPBDNIB([In] this Vector3 CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8429520", Offset = "0x8428720", VA = "0x188429520")]
	public static BELCIKMIECJ GHCHDOLGCGM([In] this Vector3? CEENCLMGJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x84295E0", Offset = "0x84287E0", VA = "0x1884295E0")]
	public static Vector3 JKAINKAKBPB(this BELCIKMIECJ CEENCLMGJAM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8429650", Offset = "0x8428850", VA = "0x188429650")]
	public static Vector3? LBJKAKNHIOL(this BELCIKMIECJ CEENCLMGJAM)
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
