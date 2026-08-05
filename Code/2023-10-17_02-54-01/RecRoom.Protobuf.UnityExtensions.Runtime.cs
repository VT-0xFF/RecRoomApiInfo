using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ANLGGCFDFOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62090E0", Offset = "0x62078E0", VA = "0x1862090E0")]
	public static JCPPLDCKFBE BBOAPHOFBBK([In] this Color AFFJMIFONEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62091E0", Offset = "0x62079E0", VA = "0x1862091E0")]
	public static Color PFKIHJFLILM(this JCPPLDCKFBE AFFJMIFONEM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6209160", Offset = "0x6207960", VA = "0x186209160")]
	public static Color? OJGELONMNEH(this JCPPLDCKFBE AFFJMIFONEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CKLPDACBFKI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x62092B0", Offset = "0x6207AB0", VA = "0x1862092B0")]
	public static Quaternion IEEBNDAPBPP(FLKACFIADDG AELCABDCBDD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62094D0", Offset = "0x6207CD0", VA = "0x1862094D0")]
	public static PPGECKNEKGB IHGNHFAMNPE(Quaternion FHDNPMICGJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6209210", Offset = "0x6207A10", VA = "0x186209210")]
	public static Quaternion CBNCNFCOCBJ(PPGECKNEKGB AELCABDCBDD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MKPBAANBOAP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6209800", Offset = "0x6208000", VA = "0x186209800")]
	public static ICBDPMNKICN BBOAPHOFBBK([In] this Quaternion AFFJMIFONEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6209920", Offset = "0x6208120", VA = "0x186209920")]
	public static Quaternion PFKIHJFLILM(this ICBDPMNKICN AFFJMIFONEM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6209880", Offset = "0x6208080", VA = "0x186209880")]
	public static Quaternion? OJGELONMNEH(this ICBDPMNKICN AFFJMIFONEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KPAFPLNNNJO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6209730", Offset = "0x6207F30", VA = "0x186209730")]
	public static CMLGPJALFDA BBOAPHOFBBK([In] this Vector2 AFFJMIFONEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62097A0", Offset = "0x6207FA0", VA = "0x1862097A0")]
	public static Vector2 PFKIHJFLILM(this CMLGPJALFDA AFFJMIFONEM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HIGPKJPGKAF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62095C0", Offset = "0x6207DC0", VA = "0x1862095C0")]
	public static PPGECKNEKGB BBOAPHOFBBK([In] this Vector3 AFFJMIFONEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62096C0", Offset = "0x6207EC0", VA = "0x1862096C0")]
	public static Vector3 PFKIHJFLILM(this PPGECKNEKGB AFFJMIFONEM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6209630", Offset = "0x6207E30", VA = "0x186209630")]
	public static Vector3? OJGELONMNEH(this PPGECKNEKGB AFFJMIFONEM)
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
