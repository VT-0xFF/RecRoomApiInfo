using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GNPOLNLHLEO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67482D0", Offset = "0x67476D0", VA = "0x1867482D0")]
	public static OKJEGNBPNLL HBIMCCJEPGN([In] this Color MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6748220", Offset = "0x6747620", VA = "0x186748220")]
	public static Color CMCHCKHHIFC(this OKJEGNBPNLL MEEBIDIALDO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6748250", Offset = "0x6747650", VA = "0x186748250")]
	public static Color? FMKNNEACKAD(this OKJEGNBPNLL MEEBIDIALDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DABKHHDMGHI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6747F60", Offset = "0x6747360", VA = "0x186747F60")]
	public static Quaternion BPBCDLNGDFN(HFHLGDMJMOE FLKOGFDGJDF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6747E70", Offset = "0x6747270", VA = "0x186747E70")]
	public static JOMIDEGDEPO BGDHLLOLHIL(Quaternion HMDCHAJCLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6748180", Offset = "0x6747580", VA = "0x186748180")]
	public static Quaternion NAOBEJAJGGH(JOMIDEGDEPO FLKOGFDGJDF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PCLJNOFCJFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6748530", Offset = "0x6747930", VA = "0x186748530")]
	public static NIMOHMOOKJD HBIMCCJEPGN([In] this Quaternion MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6748420", Offset = "0x6747820", VA = "0x186748420")]
	public static Quaternion CMCHCKHHIFC(this NIMOHMOOKJD MEEBIDIALDO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6748490", Offset = "0x6747890", VA = "0x186748490")]
	public static Quaternion? FMKNNEACKAD(this NIMOHMOOKJD MEEBIDIALDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LDBKEKAHKKK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67483B0", Offset = "0x67477B0", VA = "0x1867483B0")]
	public static EKHPMAICCKG HBIMCCJEPGN([In] this Vector2 MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6748350", Offset = "0x6747750", VA = "0x186748350")]
	public static Vector2 CMCHCKHHIFC(this EKHPMAICCKG MEEBIDIALDO)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AKPKAFKBAIM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6747E00", Offset = "0x6747200", VA = "0x186747E00")]
	public static JOMIDEGDEPO HBIMCCJEPGN([In] this Vector3 MEEBIDIALDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6747D00", Offset = "0x6747100", VA = "0x186747D00")]
	public static Vector3 CMCHCKHHIFC(this JOMIDEGDEPO MEEBIDIALDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6747D70", Offset = "0x6747170", VA = "0x186747D70")]
	public static Vector3? FMKNNEACKAD(this JOMIDEGDEPO MEEBIDIALDO)
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
