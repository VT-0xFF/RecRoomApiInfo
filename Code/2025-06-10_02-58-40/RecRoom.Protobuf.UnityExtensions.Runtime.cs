using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CFKAPCGMOOL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8422F00", Offset = "0x8422100", VA = "0x188422F00")]
	public static BKAEJAIMGCB ELKKKBEIKKA([In] this Color IPOCHJJJBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8422ED0", Offset = "0x84220D0", VA = "0x188422ED0")]
	public static Color BHIBMPPAILM(this BKAEJAIMGCB IPOCHJJJBCM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8422E50", Offset = "0x8422050", VA = "0x188422E50")]
	public static Color? ADNMDKIHCFP(this BKAEJAIMGCB IPOCHJJJBCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FCJMNPBCMPA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8423050", Offset = "0x8422250", VA = "0x188423050")]
	public static Quaternion CHGDFEJHCJC(OIFCPEKHHDM CAIGHLKIDBF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8423300", Offset = "0x8422500", VA = "0x188423300")]
	public static PPAPOHLOHAL KPGLHONAEMG(Quaternion OGOOPBPDABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8423260", Offset = "0x8422460", VA = "0x188423260")]
	public static Quaternion FJAIMBNBFLB(PPAPOHLOHAL CAIGHLKIDBF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JEICFOBGDKA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8423730", Offset = "0x8422930", VA = "0x188423730")]
	public static MEHFDIIHBBM ELKKKBEIKKA([In] this Quaternion IPOCHJJJBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84236C0", Offset = "0x84228C0", VA = "0x1884236C0")]
	public static Quaternion BHIBMPPAILM(this MEHFDIIHBBM IPOCHJJJBCM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8423620", Offset = "0x8422820", VA = "0x188423620")]
	public static Quaternion? ADNMDKIHCFP(this MEHFDIIHBBM IPOCHJJJBCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DEEDHOCIIJD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8422FE0", Offset = "0x84221E0", VA = "0x188422FE0")]
	public static LGNEFKDKAJD ELKKKBEIKKA([In] this Vector2 IPOCHJJJBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8422F80", Offset = "0x8422180", VA = "0x188422F80")]
	public static Vector2 BHIBMPPAILM(this LGNEFKDKAJD IPOCHJJJBCM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GBOKGGHJAFD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84234F0", Offset = "0x84226F0", VA = "0x1884234F0")]
	public static PPAPOHLOHAL ELKKKBEIKKA([In] this Vector3 IPOCHJJJBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8423560", Offset = "0x8422760", VA = "0x188423560")]
	public static PPAPOHLOHAL JPIAPEHDDEF([In] this Vector3? IPOCHJJJBCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8423480", Offset = "0x8422680", VA = "0x188423480")]
	public static Vector3 BHIBMPPAILM(this PPAPOHLOHAL IPOCHJJJBCM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x84233F0", Offset = "0x84225F0", VA = "0x1884233F0")]
	public static Vector3? ADNMDKIHCFP(this PPAPOHLOHAL IPOCHJJJBCM)
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
