using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BCFHOGLFGKO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6811750", Offset = "0x6810950", VA = "0x186811750")]
	public static BDOJCGFJGFF IIADKJHBOIN(this in Color DIJPFIMLAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68116F0", Offset = "0x68108F0", VA = "0x1868116F0")]
	public static Color BBCFAILGGHN(this BDOJCGFJGFF DIJPFIMLAFB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68117D0", Offset = "0x68109D0", VA = "0x1868117D0")]
	public static Color? OGCKINPDKNF(this BDOJCGFJGFF DIJPFIMLAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JGJIKDLPBGF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6811AD0", Offset = "0x6810CD0", VA = "0x186811AD0")]
	public static Quaternion HJLIBLMGDCH(NOKBACLGMHI PCPEJHIMHJJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6811A30", Offset = "0x6810C30", VA = "0x186811A30")]
	public static PKMMAFIBLPB ABHMELEONOA(Quaternion MIAKBHAEAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6811C60", Offset = "0x6810E60", VA = "0x186811C60")]
	public static Quaternion KGLLCLABAJG(PKMMAFIBLPB PCPEJHIMHJJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IEHEHFBIBNF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68118F0", Offset = "0x6810AF0", VA = "0x1868118F0")]
	public static NHKNAKBHNAM IIADKJHBOIN(this in Quaternion DIJPFIMLAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6811890", Offset = "0x6810A90", VA = "0x186811890")]
	public static Quaternion BBCFAILGGHN(this NHKNAKBHNAM DIJPFIMLAFB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6811970", Offset = "0x6810B70", VA = "0x186811970")]
	public static Quaternion? OGCKINPDKNF(this NHKNAKBHNAM DIJPFIMLAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LBOKIKKAIMJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6811D20", Offset = "0x6810F20", VA = "0x186811D20")]
	public static PKMMAFIBLPB IIADKJHBOIN(this in Vector3 DIJPFIMLAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6811CD0", Offset = "0x6810ED0", VA = "0x186811CD0")]
	public static Vector3 BBCFAILGGHN(this PKMMAFIBLPB DIJPFIMLAFB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6811D90", Offset = "0x6810F90", VA = "0x186811D90")]
	public static Vector3? OGCKINPDKNF(this PKMMAFIBLPB DIJPFIMLAFB)
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
