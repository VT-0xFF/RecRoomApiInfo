using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OLFOAIEBLAI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8989470", Offset = "0x8988470", VA = "0x188989470")]
	public static BLHBCACJOPO FBGBLPHHDGN([In] this Color OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8989570", Offset = "0x8988570", VA = "0x188989570")]
	public static Color LABNBGADOBH(this BLHBCACJOPO OLHDOIOOPGE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x89894F0", Offset = "0x89884F0", VA = "0x1889894F0")]
	public static Color? HDLPFCCCOPB(this BLHBCACJOPO OLHDOIOOPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GOMFDKBMPEN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8988F90", Offset = "0x8987F90", VA = "0x188988F90")]
	public static Quaternion JDLFDGPDLJK(PEBOBKMAHLJ INCJDDLACNP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8988EA0", Offset = "0x8987EA0", VA = "0x188988EA0")]
	public static JMHCINBMPMJ EHMOJPJLKEI(Quaternion PFLJFEOKHNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x89891A0", Offset = "0x89881A0", VA = "0x1889891A0")]
	public static Quaternion PABJKNNLNDI(JMHCINBMPMJ INCJDDLACNP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GIJFCHIDGGA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8988D10", Offset = "0x8987D10", VA = "0x188988D10")]
	public static MAOGDCJBHMD FBGBLPHHDGN([In] this Quaternion OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8988E30", Offset = "0x8987E30", VA = "0x188988E30")]
	public static Quaternion LABNBGADOBH(this MAOGDCJBHMD OLHDOIOOPGE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8988D90", Offset = "0x8987D90", VA = "0x188988D90")]
	public static Quaternion? HDLPFCCCOPB(this MAOGDCJBHMD OLHDOIOOPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OPJJMFCCFPA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x89895A0", Offset = "0x89885A0", VA = "0x1889895A0")]
	public static MNAEEJMGAIH FBGBLPHHDGN([In] this Vector2 OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8989610", Offset = "0x8988610", VA = "0x188989610")]
	public static Vector2 LABNBGADOBH(this MNAEEJMGAIH OLHDOIOOPGE)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IEOKHMLBPAP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8989300", Offset = "0x8988300", VA = "0x188989300")]
	public static JMHCINBMPMJ FBGBLPHHDGN([In] this Vector3 OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8989240", Offset = "0x8988240", VA = "0x188989240")]
	public static JMHCINBMPMJ ABEKBNGAFDP([In] this Vector3? OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8989400", Offset = "0x8988400", VA = "0x188989400")]
	public static Vector3 LABNBGADOBH(this JMHCINBMPMJ OLHDOIOOPGE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8989370", Offset = "0x8988370", VA = "0x188989370")]
	public static Vector3? HDLPFCCCOPB(this JMHCINBMPMJ OLHDOIOOPGE)
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
