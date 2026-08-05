using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JDAKAOJMELB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A110", Offset = "0x6F08B10", VA = "0x186F0A110")]
	public static LEOKPLHAGBE KJCBMOAEMAH([In] this Color BBCPNLGGBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A0E0", Offset = "0x6F08AE0", VA = "0x186F0A0E0")]
	public static Color FIOJCIMJMME(this LEOKPLHAGBE BBCPNLGGBMJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A190", Offset = "0x6F08B90", VA = "0x186F0A190")]
	public static Color? KJOGKBCCAAA(this LEOKPLHAGBE BBCPNLGGBMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DODPNAACECN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F09BC0", Offset = "0x6F085C0", VA = "0x186F09BC0")]
	public static Quaternion JHPLLAEBINF(MPAFOPGAGIP EEOBDBMOHPL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F09AD0", Offset = "0x6F084D0", VA = "0x186F09AD0")]
	public static OPPNBFLOPAI FJLDEAMHDEK(Quaternion KNLKNGIBAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F09A30", Offset = "0x6F08430", VA = "0x186F09A30")]
	public static Quaternion COLMICLONIE(OPPNBFLOPAI EEOBDBMOHPL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IAFLIBFINGP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F09FC0", Offset = "0x6F089C0", VA = "0x186F09FC0")]
	public static HLGOHFBOJOD KJCBMOAEMAH([In] this Quaternion BBCPNLGGBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F09F50", Offset = "0x6F08950", VA = "0x186F09F50")]
	public static Quaternion FIOJCIMJMME(this HLGOHFBOJOD BBCPNLGGBMJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A040", Offset = "0x6F08A40", VA = "0x186F0A040")]
	public static Quaternion? KJOGKBCCAAA(this HLGOHFBOJOD BBCPNLGGBMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MNOJGCKFCGE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A270", Offset = "0x6F08C70", VA = "0x186F0A270")]
	public static AONPPFFFNAI KJCBMOAEMAH([In] this Vector2 BBCPNLGGBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F0A210", Offset = "0x6F08C10", VA = "0x186F0A210")]
	public static Vector2 FIOJCIMJMME(this AONPPFFFNAI BBCPNLGGBMJ)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FEEFEMNCMCI
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F09E50", Offset = "0x6F08850", VA = "0x186F09E50")]
	public static OPPNBFLOPAI KJCBMOAEMAH([In] this Vector3 BBCPNLGGBMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F09DE0", Offset = "0x6F087E0", VA = "0x186F09DE0")]
	public static Vector3 FIOJCIMJMME(this OPPNBFLOPAI BBCPNLGGBMJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F09EC0", Offset = "0x6F088C0", VA = "0x186F09EC0")]
	public static Vector3? KJOGKBCCAAA(this OPPNBFLOPAI BBCPNLGGBMJ)
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
