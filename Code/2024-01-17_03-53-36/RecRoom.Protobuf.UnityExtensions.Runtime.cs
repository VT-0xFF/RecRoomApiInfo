using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OOAKOEDMEOP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x656E210", Offset = "0x656D010", VA = "0x18656E210")]
	public static MBMDMKGKOJM OKNECDBNGHE([In] this Color OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x656E1E0", Offset = "0x656CFE0", VA = "0x18656E1E0")]
	public static Color HONCKFFEJNK(this MBMDMKGKOJM OJFDNDCDDBK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x656E160", Offset = "0x656CF60", VA = "0x18656E160")]
	public static Color? EKIGIKPNHMN(this MBMDMKGKOJM OJFDNDCDDBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KDCPEJHFHHN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x656DE50", Offset = "0x656CC50", VA = "0x18656DE50")]
	public static Quaternion HDLEFBKHDIL(DEAEPCFDMHC HKPHNGEBIED)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x656E070", Offset = "0x656CE70", VA = "0x18656E070")]
	public static EFDCINMKNLP MLEEONEKCEA(Quaternion BBAGHLJAPND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x656DDB0", Offset = "0x656CBB0", VA = "0x18656DDB0")]
	public static Quaternion FIDGLMBEECN(EFDCINMKNLP HKPHNGEBIED)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HFPDIHHHPMI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x656DC60", Offset = "0x656CA60", VA = "0x18656DC60")]
	public static AOBGDDNIMOI OKNECDBNGHE([In] this Quaternion OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x656DBF0", Offset = "0x656C9F0", VA = "0x18656DBF0")]
	public static Quaternion HONCKFFEJNK(this AOBGDDNIMOI OJFDNDCDDBK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x656DB50", Offset = "0x656C950", VA = "0x18656DB50")]
	public static Quaternion? EKIGIKPNHMN(this AOBGDDNIMOI OJFDNDCDDBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IGBKIAOKEAM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x656DD40", Offset = "0x656CB40", VA = "0x18656DD40")]
	public static LNJAFNELEIF OKNECDBNGHE([In] this Vector2 OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x656DCE0", Offset = "0x656CAE0", VA = "0x18656DCE0")]
	public static Vector2 HONCKFFEJNK(this LNJAFNELEIF OJFDNDCDDBK)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PKKPPJDBINJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x656E390", Offset = "0x656D190", VA = "0x18656E390")]
	public static EFDCINMKNLP OKNECDBNGHE([In] this Vector3 OJFDNDCDDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x656E320", Offset = "0x656D120", VA = "0x18656E320")]
	public static Vector3 HONCKFFEJNK(this EFDCINMKNLP OJFDNDCDDBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x656E290", Offset = "0x656D090", VA = "0x18656E290")]
	public static Vector3? EKIGIKPNHMN(this EFDCINMKNLP OJFDNDCDDBK)
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
