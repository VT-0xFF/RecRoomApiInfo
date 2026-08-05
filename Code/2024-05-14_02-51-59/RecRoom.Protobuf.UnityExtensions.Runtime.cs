using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ICGBJMFDHHN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x690C580", Offset = "0x690AF80", VA = "0x18690C580")]
	public static ONCPOOIGFAF BOALAEMEPIG([In] this Color CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x690C600", Offset = "0x690B000", VA = "0x18690C600")]
	public static Color HIBHLHEFCGJ(this ONCPOOIGFAF CMJEIEIDHIK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x690C630", Offset = "0x690B030", VA = "0x18690C630")]
	public static Color? OLJCCBHMOHB(this ONCPOOIGFAF CMJEIEIDHIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BCDNKFHAIIK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x690C1D0", Offset = "0x690ABD0", VA = "0x18690C1D0")]
	public static Quaternion NAAFLAFNPJP(PPOMPOMCEJI ABDLEBPKDKC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x690C040", Offset = "0x690AA40", VA = "0x18690C040")]
	public static DIGIEFFFKAB IHJNPJMKBKE(Quaternion BLPLEMJGIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x690C130", Offset = "0x690AB30", VA = "0x18690C130")]
	public static Quaternion IKHOMILGDMD(DIGIEFFFKAB ABDLEBPKDKC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ENDLADONGIM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x690C3F0", Offset = "0x690ADF0", VA = "0x18690C3F0")]
	public static BBOBOJDLAAH BOALAEMEPIG([In] this Quaternion CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x690C470", Offset = "0x690AE70", VA = "0x18690C470")]
	public static Quaternion HIBHLHEFCGJ(this BBOBOJDLAAH CMJEIEIDHIK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x690C4E0", Offset = "0x690AEE0", VA = "0x18690C4E0")]
	public static Quaternion? OLJCCBHMOHB(this BBOBOJDLAAH CMJEIEIDHIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OHIGMIPKKDB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x690C820", Offset = "0x690B220", VA = "0x18690C820")]
	public static JGNEGDPOCMG BOALAEMEPIG([In] this Vector2 CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x690C890", Offset = "0x690B290", VA = "0x18690C890")]
	public static Vector2 HIBHLHEFCGJ(this JGNEGDPOCMG CMJEIEIDHIK)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LCOOMBAKKFP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x690C6B0", Offset = "0x690B0B0", VA = "0x18690C6B0")]
	public static DIGIEFFFKAB BOALAEMEPIG([In] this Vector3 CMJEIEIDHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x690C720", Offset = "0x690B120", VA = "0x18690C720")]
	public static Vector3 HIBHLHEFCGJ(this DIGIEFFFKAB CMJEIEIDHIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x690C790", Offset = "0x690B190", VA = "0x18690C790")]
	public static Vector3? OLJCCBHMOHB(this DIGIEFFFKAB CMJEIEIDHIK)
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
