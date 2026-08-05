using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LJPEDPLEGBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x226B8A0", Offset = "0x226A6A0", VA = "0x18226B8A0")]
	public static IEPIBPDBKGK PNKNJNLKBEB(this in Color BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x226B780", Offset = "0x226A580", VA = "0x18226B780")]
	public static Color CJKIJAOEIBM(this IEPIBPDBKGK BLHHJNENDMO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x226B7E0", Offset = "0x226A5E0", VA = "0x18226B7E0")]
	public static Color? IGONMBFEOAA(this IEPIBPDBKGK BLHHJNENDMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ALJNNFIIFLB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x226B390", Offset = "0x226A190", VA = "0x18226B390")]
	public static Quaternion FJGMCMPFEFB(KEEKOKPLOMO FILAKGLBGGA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x226B2F0", Offset = "0x226A0F0", VA = "0x18226B2F0")]
	public static HFCEFBLJADM EPAMJHBGIMJ(Quaternion GJFGEDKHAHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x226B280", Offset = "0x226A080", VA = "0x18226B280")]
	public static Quaternion ECCHMGIJNCL(HFCEFBLJADM FILAKGLBGGA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GJDFHJCKPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x226B700", Offset = "0x226A500", VA = "0x18226B700")]
	public static DCHOMBPLLEI PNKNJNLKBEB(this in Quaternion BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x226B520", Offset = "0x226A320", VA = "0x18226B520")]
	public static DCHOMBPLLEI BBAEDDGPPJI(this in Quaternion? BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x226B5E0", Offset = "0x226A3E0", VA = "0x18226B5E0")]
	public static Quaternion CJKIJAOEIBM(this DCHOMBPLLEI BLHHJNENDMO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x226B640", Offset = "0x226A440", VA = "0x18226B640")]
	public static Quaternion? IGONMBFEOAA(this DCHOMBPLLEI BLHHJNENDMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OJBMKOIGGNO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x226BAC0", Offset = "0x226A8C0", VA = "0x18226BAC0")]
	public static HFCEFBLJADM PNKNJNLKBEB(this in Vector3 BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x226B920", Offset = "0x226A720", VA = "0x18226B920")]
	public static HFCEFBLJADM BBAEDDGPPJI(this in Vector3? BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x226B9E0", Offset = "0x226A7E0", VA = "0x18226B9E0")]
	public static Vector3 CJKIJAOEIBM(this HFCEFBLJADM BLHHJNENDMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x226BA30", Offset = "0x226A830", VA = "0x18226BA30")]
	public static Vector3? IGONMBFEOAA(this HFCEFBLJADM BLHHJNENDMO)
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
