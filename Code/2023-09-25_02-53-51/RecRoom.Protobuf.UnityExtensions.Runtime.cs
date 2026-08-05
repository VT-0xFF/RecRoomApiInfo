using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NOMAKFDOIAH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6202100", Offset = "0x6201500", VA = "0x186202100")]
	public static PFMDILBFMMJ MFIMBGNEKOH([In] this Color CLFMFOEGLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62020D0", Offset = "0x62014D0", VA = "0x1862020D0")]
	public static Color HNNKJEMPCFP(this PFMDILBFMMJ CLFMFOEGLFG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6202050", Offset = "0x6201450", VA = "0x186202050")]
	public static Color? CJLCLBHGHGH(this PFMDILBFMMJ CLFMFOEGLFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PGPBHGGCGII
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6202220", Offset = "0x6201620", VA = "0x186202220")]
	public static Quaternion LOGEPDLJIMO(HEBJMLJKBLB OOIBMCBCEPD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6202440", Offset = "0x6201840", VA = "0x186202440")]
	public static FCOFMINFEFN NBKFKFKJIFL(Quaternion MDAKIHCEJMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6202180", Offset = "0x6201580", VA = "0x186202180")]
	public static Quaternion EHIJAOOLNMB(FCOFMINFEFN OOIBMCBCEPD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DACEAIBKNBG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6201D90", Offset = "0x6201190", VA = "0x186201D90")]
	public static MBKBKOEAFAL MFIMBGNEKOH([In] this Quaternion CLFMFOEGLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6201D20", Offset = "0x6201120", VA = "0x186201D20")]
	public static Quaternion HNNKJEMPCFP(this MBKBKOEAFAL CLFMFOEGLFG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6201C80", Offset = "0x6201080", VA = "0x186201C80")]
	public static Quaternion? CJLCLBHGHGH(this MBKBKOEAFAL CLFMFOEGLFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JCFAAMBLHCM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6201FE0", Offset = "0x62013E0", VA = "0x186201FE0")]
	public static FLBPACFKOEM MFIMBGNEKOH([In] this Vector2 CLFMFOEGLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6201F80", Offset = "0x6201380", VA = "0x186201F80")]
	public static Vector2 HNNKJEMPCFP(this FLBPACFKOEM CLFMFOEGLFG)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FMMDPLJDFPF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6201F10", Offset = "0x6201310", VA = "0x186201F10")]
	public static FCOFMINFEFN MFIMBGNEKOH([In] this Vector3 CLFMFOEGLFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6201EA0", Offset = "0x62012A0", VA = "0x186201EA0")]
	public static Vector3 HNNKJEMPCFP(this FCOFMINFEFN CLFMFOEGLFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6201E10", Offset = "0x6201210", VA = "0x186201E10")]
	public static Vector3? CJLCLBHGHGH(this FCOFMINFEFN CLFMFOEGLFG)
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
