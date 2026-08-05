using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DBDNFJMHPBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E44130", Offset = "0x5E43130", VA = "0x185E44130")]
	public static MEBGCOBFINN HHDOHEHKDKI(this in Color IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E44010", Offset = "0x5E43010", VA = "0x185E44010")]
	public static Color ADHMOLAJGDE(this MEBGCOBFINN IPNNIJODOPO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E44070", Offset = "0x5E43070", VA = "0x185E44070")]
	public static Color? EONLBGCKLGN(this MEBGCOBFINN IPNNIJODOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CLEJHFAJDLA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E43E80", Offset = "0x5E42E80", VA = "0x185E43E80")]
	public static Quaternion PKHPPAMDACO(MDLLFDLKMLE PJDKPCLOECB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E43D70", Offset = "0x5E42D70", VA = "0x185E43D70")]
	public static PJOINGHEBCP BNFKABAGPDF(Quaternion HMHFOCIPBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E43E10", Offset = "0x5E42E10", VA = "0x185E43E10")]
	public static Quaternion NMDCNPOLPNA(PJOINGHEBCP PJDKPCLOECB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OKBOLKNPCDO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E442D0", Offset = "0x5E432D0", VA = "0x185E442D0")]
	public static MDGKEAFILBI HHDOHEHKDKI(this in Quaternion IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E44350", Offset = "0x5E43350", VA = "0x185E44350")]
	public static MDGKEAFILBI IIAFMJFLLAN(this in Quaternion? IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E441B0", Offset = "0x5E431B0", VA = "0x185E441B0")]
	public static Quaternion ADHMOLAJGDE(this MDGKEAFILBI IPNNIJODOPO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E44210", Offset = "0x5E43210", VA = "0x185E44210")]
	public static Quaternion? EONLBGCKLGN(this MDGKEAFILBI IPNNIJODOPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OKPIGIPNBJC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E444F0", Offset = "0x5E434F0", VA = "0x185E444F0")]
	public static PJOINGHEBCP HHDOHEHKDKI(this in Vector3 IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E44560", Offset = "0x5E43560", VA = "0x185E44560")]
	public static PJOINGHEBCP IIAFMJFLLAN(this in Vector3? IPNNIJODOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E44410", Offset = "0x5E43410", VA = "0x185E44410")]
	public static Vector3 ADHMOLAJGDE(this PJOINGHEBCP IPNNIJODOPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E44460", Offset = "0x5E43460", VA = "0x185E44460")]
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
