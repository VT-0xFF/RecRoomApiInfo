using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DPJBBDLGLOG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6881ED0", Offset = "0x6880ED0", VA = "0x186881ED0")]
	public static AFNLBKBDEME AFIENNPCBKD([In] this Color HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6881FD0", Offset = "0x6880FD0", VA = "0x186881FD0")]
	public static Color OMCMMHECHCJ(this AFNLBKBDEME HFLBADIEKAM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6881F50", Offset = "0x6880F50", VA = "0x186881F50")]
	public static Color? IFHMEDAGNBF(this AFNLBKBDEME HFLBADIEKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JIBKDCDMHHO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6882190", Offset = "0x6881190", VA = "0x186882190")]
	public static Quaternion KHBNDBOOPOB(FIMOLBGBCCD GPKMLHOONCL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68820A0", Offset = "0x68810A0", VA = "0x1868820A0")]
	public static OCDCEEAJCPP JECDIAEDHOM(Quaternion EJBINLBGMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6882000", Offset = "0x6881000", VA = "0x186882000")]
	public static Quaternion ACDLLOEBCJI(OCDCEEAJCPP GPKMLHOONCL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BCELBJNKLEH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6881D40", Offset = "0x6880D40", VA = "0x186881D40")]
	public static BIJELJKKGIC AFIENNPCBKD([In] this Quaternion HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6881E60", Offset = "0x6880E60", VA = "0x186881E60")]
	public static Quaternion OMCMMHECHCJ(this BIJELJKKGIC HFLBADIEKAM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6881DC0", Offset = "0x6880DC0", VA = "0x186881DC0")]
	public static Quaternion? IFHMEDAGNBF(this BIJELJKKGIC HFLBADIEKAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JMOPCCFIKMD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68823B0", Offset = "0x68813B0", VA = "0x1868823B0")]
	public static LDJENKGMLNA AFIENNPCBKD([In] this Vector2 HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6882420", Offset = "0x6881420", VA = "0x186882420")]
	public static Vector2 OMCMMHECHCJ(this LDJENKGMLNA HFLBADIEKAM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MKODMGKPPFL
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6882480", Offset = "0x6881480", VA = "0x186882480")]
	public static OCDCEEAJCPP AFIENNPCBKD([In] this Vector3 HFLBADIEKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6882580", Offset = "0x6881580", VA = "0x186882580")]
	public static Vector3 OMCMMHECHCJ(this OCDCEEAJCPP HFLBADIEKAM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68824F0", Offset = "0x68814F0", VA = "0x1868824F0")]
	public static Vector3? IFHMEDAGNBF(this OCDCEEAJCPP HFLBADIEKAM)
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
