using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FJEJHKAJLBN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x825B5B0", Offset = "0x825A9B0", VA = "0x18825B5B0")]
	public static HOKAMLOMLMP PEGKBLBFNLH([In] this Color KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x825B500", Offset = "0x825A900", VA = "0x18825B500")]
	public static Color ILOIKAMJPOD(this HOKAMLOMLMP KBBJDOAJMAF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x825B530", Offset = "0x825A930", VA = "0x18825B530")]
	public static Color? JHFECHHGBIH(this HOKAMLOMLMP KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HOAJKNLPEHL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x825B7F0", Offset = "0x825ABF0", VA = "0x18825B7F0")]
	public static Quaternion KLJFOCKAHCO(JNCONGMCEGE AOFGGGKINCN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x825B700", Offset = "0x825AB00", VA = "0x18825B700")]
	public static JFLHBNNGDGH HIGDLCMECLH(Quaternion OIGJDGJNJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x825BA00", Offset = "0x825AE00", VA = "0x18825BA00")]
	public static Quaternion MNJNKOLEOPM(JFLHBNNGDGH AOFGGGKINCN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JBCKEALKCCC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x825BBB0", Offset = "0x825AFB0", VA = "0x18825BBB0")]
	public static LJENOJEDBAN PEGKBLBFNLH([In] this Quaternion KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x825BAA0", Offset = "0x825AEA0", VA = "0x18825BAA0")]
	public static Quaternion ILOIKAMJPOD(this LJENOJEDBAN KBBJDOAJMAF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x825BB10", Offset = "0x825AF10", VA = "0x18825BB10")]
	public static Quaternion? JHFECHHGBIH(this LJENOJEDBAN KBBJDOAJMAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GMMLMGOFMNC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x825B690", Offset = "0x825AA90", VA = "0x18825B690")]
	public static PHPIGAMMLHE PEGKBLBFNLH([In] this Vector2 KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x825B630", Offset = "0x825AA30", VA = "0x18825B630")]
	public static Vector2 ILOIKAMJPOD(this PHPIGAMMLHE KBBJDOAJMAF)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DJCGKECADNJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x825B490", Offset = "0x825A890", VA = "0x18825B490")]
	public static JFLHBNNGDGH PEGKBLBFNLH([In] this Vector3 KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x825B3D0", Offset = "0x825A7D0", VA = "0x18825B3D0")]
	public static JFLHBNNGDGH KKOPMKGBNBN([In] this Vector3? KBBJDOAJMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x825B2D0", Offset = "0x825A6D0", VA = "0x18825B2D0")]
	public static Vector3 ILOIKAMJPOD(this JFLHBNNGDGH KBBJDOAJMAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x825B340", Offset = "0x825A740", VA = "0x18825B340")]
	public static Vector3? JHFECHHGBIH(this JFLHBNNGDGH KBBJDOAJMAF)
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
