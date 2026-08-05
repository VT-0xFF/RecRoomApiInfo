using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JCMNGKKCMGB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66AD0A0", Offset = "0x66AC0A0", VA = "0x1866AD0A0")]
	public static AMDINPGBFLM CJKIIDNIDDE(this in Color AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66AD120", Offset = "0x66AC120", VA = "0x1866AD120")]
	public static Color EOLLHEJPBAN(this AMDINPGBFLM AOFCPKBHFEM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66ACFE0", Offset = "0x66ABFE0", VA = "0x1866ACFE0")]
	public static Color? ALBHNCFGDOH(this AMDINPGBFLM AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DGNGDIGELPG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x66ACD40", Offset = "0x66ABD40", VA = "0x1866ACD40")]
	public static Quaternion DIPIEBHBNII(MAKIBJJFIPE FNIHENPLJHK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66ACF40", Offset = "0x66ABF40", VA = "0x1866ACF40")]
	public static ICADAJKKDHJ EGELJONEJFI(Quaternion HPICHNDOOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x66ACED0", Offset = "0x66ABED0", VA = "0x1866ACED0")]
	public static Quaternion DNPGIFLONDL(ICADAJKKDHJ FNIHENPLJHK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OGJFHFDJPOI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66AD240", Offset = "0x66AC240", VA = "0x1866AD240")]
	public static HMEANOLBAJN CJKIIDNIDDE(this in Quaternion AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66AD2C0", Offset = "0x66AC2C0", VA = "0x1866AD2C0")]
	public static Quaternion EOLLHEJPBAN(this HMEANOLBAJN AOFCPKBHFEM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66AD180", Offset = "0x66AC180", VA = "0x1866AD180")]
	public static Quaternion? ALBHNCFGDOH(this HMEANOLBAJN AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BPKAKCILFHM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x66ACC80", Offset = "0x66ABC80", VA = "0x1866ACC80")]
	public static ICADAJKKDHJ CJKIIDNIDDE(this in Vector3 AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66ACCF0", Offset = "0x66ABCF0", VA = "0x1866ACCF0")]
	public static Vector3 EOLLHEJPBAN(this ICADAJKKDHJ AOFCPKBHFEM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66ACBF0", Offset = "0x66ABBF0", VA = "0x1866ACBF0")]
	public static Vector3? ALBHNCFGDOH(this ICADAJKKDHJ AOFCPKBHFEM)
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
