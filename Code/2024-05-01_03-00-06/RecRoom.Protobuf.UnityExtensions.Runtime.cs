using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HEBPKJIEJEN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67DDC00", Offset = "0x67DCA00", VA = "0x1867DDC00")]
	public static BKCJOLKNILF JPFDICAGNEF([In] this Color ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67DDBD0", Offset = "0x67DC9D0", VA = "0x1867DDBD0")]
	public static Color FPNHMAJLCHC(this BKCJOLKNILF ILACEKALGJH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67DDC80", Offset = "0x67DCA80", VA = "0x1867DDC80")]
	public static Color? LGKKELKOKBF(this BKCJOLKNILF ILACEKALGJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EILFCADGBCF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67DD9C0", Offset = "0x67DC7C0", VA = "0x1867DD9C0")]
	public static Quaternion OHJLLNJBMDO(AHDEAJMCJNJ LHODDAGAJKC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67DD830", Offset = "0x67DC630", VA = "0x1867DD830")]
	public static NMNOPLPJMFL ADEOCFLNBLE(Quaternion GEOEPPKNGLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67DD920", Offset = "0x67DC720", VA = "0x1867DD920")]
	public static Quaternion CMDOCCPCCIN(NMNOPLPJMFL LHODDAGAJKC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CGGNKIMOIIH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67DD710", Offset = "0x67DC510", VA = "0x1867DD710")]
	public static FHHGBAEHKPL JPFDICAGNEF([In] this Quaternion ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67DD6A0", Offset = "0x67DC4A0", VA = "0x1867DD6A0")]
	public static Quaternion FPNHMAJLCHC(this FHHGBAEHKPL ILACEKALGJH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67DD790", Offset = "0x67DC590", VA = "0x1867DD790")]
	public static Quaternion? LGKKELKOKBF(this FHHGBAEHKPL ILACEKALGJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MNFNAHKMMKN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67DDD60", Offset = "0x67DCB60", VA = "0x1867DDD60")]
	public static JKACHIPLIBE JPFDICAGNEF([In] this Vector2 ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67DDD00", Offset = "0x67DCB00", VA = "0x1867DDD00")]
	public static Vector2 FPNHMAJLCHC(this JKACHIPLIBE ILACEKALGJH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NHNCLIOJMKF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67DDE40", Offset = "0x67DCC40", VA = "0x1867DDE40")]
	public static NMNOPLPJMFL JPFDICAGNEF([In] this Vector3 ILACEKALGJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67DDDD0", Offset = "0x67DCBD0", VA = "0x1867DDDD0")]
	public static Vector3 FPNHMAJLCHC(this NMNOPLPJMFL ILACEKALGJH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67DDEB0", Offset = "0x67DCCB0", VA = "0x1867DDEB0")]
	public static Vector3? LGKKELKOKBF(this NMNOPLPJMFL ILACEKALGJH)
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
