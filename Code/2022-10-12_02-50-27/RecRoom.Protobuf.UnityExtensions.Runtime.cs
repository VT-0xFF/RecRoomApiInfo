using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DBDNFJMHPBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC1A0", Offset = "0x1ECA9A0", VA = "0x181ECC1A0")]
	public static MEBGCOBFINN HHDOHEHKDKI(this in Color IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC080", Offset = "0x1ECA880", VA = "0x181ECC080")]
	public static Color ADHMOLAJGDE(this MEBGCOBFINN IPNNIJODOPO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC0E0", Offset = "0x1ECA8E0", VA = "0x181ECC0E0")]
	public static Color? EONLBGCKLGN(this MEBGCOBFINN IPNNIJODOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CLEJHFAJDLA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1ECBEF0", Offset = "0x1ECA6F0", VA = "0x181ECBEF0")]
	public static Quaternion PKHPPAMDACO(MDLLFDLKMLE PJDKPCLOECB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1ECBDE0", Offset = "0x1ECA5E0", VA = "0x181ECBDE0")]
	public static PJOINGHEBCP BNFKABAGPDF(Quaternion HMHFOCIPBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1ECBE80", Offset = "0x1ECA680", VA = "0x181ECBE80")]
	public static Quaternion NMDCNPOLPNA(PJOINGHEBCP PJDKPCLOECB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OKBOLKNPCDO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC340", Offset = "0x1ECAB40", VA = "0x181ECC340")]
	public static MDGKEAFILBI HHDOHEHKDKI(this in Quaternion IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC3C0", Offset = "0x1ECABC0", VA = "0x181ECC3C0")]
	public static MDGKEAFILBI IIAFMJFLLAN(this in Quaternion? IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC220", Offset = "0x1ECAA20", VA = "0x181ECC220")]
	public static Quaternion ADHMOLAJGDE(this MDGKEAFILBI IPNNIJODOPO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC280", Offset = "0x1ECAA80", VA = "0x181ECC280")]
	public static Quaternion? EONLBGCKLGN(this MDGKEAFILBI IPNNIJODOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OKPIGIPNBJC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC560", Offset = "0x1ECAD60", VA = "0x181ECC560")]
	public static PJOINGHEBCP HHDOHEHKDKI(this in Vector3 IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC5D0", Offset = "0x1ECADD0", VA = "0x181ECC5D0")]
	public static PJOINGHEBCP IIAFMJFLLAN(this in Vector3? IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC480", Offset = "0x1ECAC80", VA = "0x181ECC480")]
	public static Vector3 ADHMOLAJGDE(this PJOINGHEBCP IPNNIJODOPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1ECC4D0", Offset = "0x1ECACD0", VA = "0x181ECC4D0")]
	public static Vector3? EONLBGCKLGN(this PJOINGHEBCP IPNNIJODOPO)
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
