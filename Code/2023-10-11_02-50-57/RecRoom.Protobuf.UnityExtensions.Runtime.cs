using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BOFANAAAMIM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6208F90", Offset = "0x6207D90", VA = "0x186208F90")]
	public static BKANLPOPFNC GKMCGBDALGF([In] this Color LNKCIHFCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6208F60", Offset = "0x6207D60", VA = "0x186208F60")]
	public static Color EFHLMHLMFOG(this BKANLPOPFNC LNKCIHFCLHG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6208EE0", Offset = "0x6207CE0", VA = "0x186208EE0")]
	public static Color? BEICOMCMGJJ(this BKANLPOPFNC LNKCIHFCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HMKCGJJMKGC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6209400", Offset = "0x6208200", VA = "0x186209400")]
	public static Quaternion PDLGJJNEJEH(IPMIDOLCCEM PFDMLBFKIAP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6209310", Offset = "0x6208110", VA = "0x186209310")]
	public static OAHOBNENGJJ PBKELJHDHGB(Quaternion KDFCLCEBMJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6209270", Offset = "0x6208070", VA = "0x186209270")]
	public static Quaternion KBJBMMKLJFH(OAHOBNENGJJ PFDMLBFKIAP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ECIPGFGFNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x62091F0", Offset = "0x6207FF0", VA = "0x1862091F0")]
	public static IOIOMLIONGE GKMCGBDALGF([In] this Quaternion LNKCIHFCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6209180", Offset = "0x6207F80", VA = "0x186209180")]
	public static Quaternion EFHLMHLMFOG(this IOIOMLIONGE LNKCIHFCLHG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62090E0", Offset = "0x6207EE0", VA = "0x1862090E0")]
	public static Quaternion? BEICOMCMGJJ(this IOIOMLIONGE LNKCIHFCLHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CDKGNFCJIKA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6209070", Offset = "0x6207E70", VA = "0x186209070")]
	public static FKBAGBHKACJ GKMCGBDALGF([In] this Vector2 LNKCIHFCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6209010", Offset = "0x6207E10", VA = "0x186209010")]
	public static Vector2 EFHLMHLMFOG(this FKBAGBHKACJ LNKCIHFCLHG)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BDONJADHLFM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6208E70", Offset = "0x6207C70", VA = "0x186208E70")]
	public static OAHOBNENGJJ GKMCGBDALGF([In] this Vector3 LNKCIHFCLHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6208E00", Offset = "0x6207C00", VA = "0x186208E00")]
	public static Vector3 EFHLMHLMFOG(this OAHOBNENGJJ LNKCIHFCLHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6208D70", Offset = "0x6207B70", VA = "0x186208D70")]
	public static Vector3? BEICOMCMGJJ(this OAHOBNENGJJ LNKCIHFCLHG)
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
