using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LJPEDPLEGBD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x611CAA0", Offset = "0x611BAA0", VA = "0x18611CAA0")]
	public static IEPIBPDBKGK PNKNJNLKBEB(this in Color BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x611C980", Offset = "0x611B980", VA = "0x18611C980")]
	public static Color CJKIJAOEIBM(this IEPIBPDBKGK BLHHJNENDMO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x611C9E0", Offset = "0x611B9E0", VA = "0x18611C9E0")]
	public static Color? IGONMBFEOAA(this IEPIBPDBKGK BLHHJNENDMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ALJNNFIIFLB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x611C590", Offset = "0x611B590", VA = "0x18611C590")]
	public static Quaternion FJGMCMPFEFB(KEEKOKPLOMO FILAKGLBGGA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x611C4F0", Offset = "0x611B4F0", VA = "0x18611C4F0")]
	public static HFCEFBLJADM EPAMJHBGIMJ(Quaternion GJFGEDKHAHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x611C480", Offset = "0x611B480", VA = "0x18611C480")]
	public static Quaternion ECCHMGIJNCL(HFCEFBLJADM FILAKGLBGGA)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GJDFHJCKPJE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x611C900", Offset = "0x611B900", VA = "0x18611C900")]
	public static DCHOMBPLLEI PNKNJNLKBEB(this in Quaternion BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x611C720", Offset = "0x611B720", VA = "0x18611C720")]
	public static DCHOMBPLLEI BBAEDDGPPJI(this in Quaternion? BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x611C7E0", Offset = "0x611B7E0", VA = "0x18611C7E0")]
	public static Quaternion CJKIJAOEIBM(this DCHOMBPLLEI BLHHJNENDMO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x611C840", Offset = "0x611B840", VA = "0x18611C840")]
	public static Quaternion? IGONMBFEOAA(this DCHOMBPLLEI BLHHJNENDMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OJBMKOIGGNO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x611CCC0", Offset = "0x611BCC0", VA = "0x18611CCC0")]
	public static HFCEFBLJADM PNKNJNLKBEB(this in Vector3 BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x611CB20", Offset = "0x611BB20", VA = "0x18611CB20")]
	public static HFCEFBLJADM BBAEDDGPPJI(this in Vector3? BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x611CBE0", Offset = "0x611BBE0", VA = "0x18611CBE0")]
	public static Vector3 CJKIJAOEIBM(this HFCEFBLJADM BLHHJNENDMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x611CC30", Offset = "0x611BC30", VA = "0x18611CC30")]
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
