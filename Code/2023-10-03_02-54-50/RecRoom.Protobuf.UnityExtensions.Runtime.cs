using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DDMFFKCPCNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61CF780", Offset = "0x61CDF80", VA = "0x1861CF780")]
	public static KCFCEPBIOGG NDMEHJLGNHG([In] this Color CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61CF750", Offset = "0x61CDF50", VA = "0x1861CF750")]
	public static Color GHFHHMFPNJI(this KCFCEPBIOGG CLEGCKJMIEA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61CF6D0", Offset = "0x61CDED0", VA = "0x1861CF6D0")]
	public static Color? BIOMDMIFAOK(this KCFCEPBIOGG CLEGCKJMIEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FKPEFLIJAON
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61CF800", Offset = "0x61CE000", VA = "0x1861CF800")]
	public static Quaternion AACIBDKFFNM(HFACCEEJFPK KOIMDAJNDOD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61CFAC0", Offset = "0x61CE2C0", VA = "0x1861CFAC0")]
	public static JGFMHKGMFBG NOOCLBMDMAH(Quaternion NPFEENIOOPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61CFA20", Offset = "0x61CE220", VA = "0x1861CFA20")]
	public static Quaternion BLMPFIMDBAN(JGFMHKGMFBG KOIMDAJNDOD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HFJLNAMLPBE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61CFE30", Offset = "0x61CE630", VA = "0x1861CFE30")]
	public static FNLNCHHGPCM NDMEHJLGNHG([In] this Quaternion CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61CFDC0", Offset = "0x61CE5C0", VA = "0x1861CFDC0")]
	public static Quaternion GHFHHMFPNJI(this FNLNCHHGPCM CLEGCKJMIEA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61CFD20", Offset = "0x61CE520", VA = "0x1861CFD20")]
	public static Quaternion? BIOMDMIFAOK(this FNLNCHHGPCM CLEGCKJMIEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LEAPFMNJLPG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61CFF10", Offset = "0x61CE710", VA = "0x1861CFF10")]
	public static OJGIAFGGDPG NDMEHJLGNHG([In] this Vector2 CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61CFEB0", Offset = "0x61CE6B0", VA = "0x1861CFEB0")]
	public static Vector2 GHFHHMFPNJI(this OJGIAFGGDPG CLEGCKJMIEA)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GCFCJGDCBFH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61CFCB0", Offset = "0x61CE4B0", VA = "0x1861CFCB0")]
	public static JGFMHKGMFBG NDMEHJLGNHG([In] this Vector3 CLEGCKJMIEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61CFC40", Offset = "0x61CE440", VA = "0x1861CFC40")]
	public static Vector3 GHFHHMFPNJI(this JGFMHKGMFBG CLEGCKJMIEA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x61CFBB0", Offset = "0x61CE3B0", VA = "0x1861CFBB0")]
	public static Vector3? BIOMDMIFAOK(this JGFMHKGMFBG CLEGCKJMIEA)
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
