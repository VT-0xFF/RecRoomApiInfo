using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IKHMMHLGLPM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F79AD0", Offset = "0x6F780D0", VA = "0x186F79AD0")]
	public static OPOAPIEGMEK KLDBPIDHOEH([In] this Color OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F79A20", Offset = "0x6F78020", VA = "0x186F79A20")]
	public static Color JGNOLJBBCJA(this OPOAPIEGMEK OLDDCPCBGIL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F79A50", Offset = "0x6F78050", VA = "0x186F79A50")]
	public static Color? JNMLFIKLKBC(this OPOAPIEGMEK OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BKGEIOGCFKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F79390", Offset = "0x6F77990", VA = "0x186F79390")]
	public static Quaternion GEMAKKBMEJE(KGNOAFLJLKF FHNKDHIILBL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F792A0", Offset = "0x6F778A0", VA = "0x186F792A0")]
	public static FCFHBHHCBNC BJEOEHMIDLK(Quaternion DAJJMAOCHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F795B0", Offset = "0x6F77BB0", VA = "0x186F795B0")]
	public static Quaternion PNEGAJEKFPG(FCFHBHHCBNC FHNKDHIILBL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BOLBBNOBOAA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F79760", Offset = "0x6F77D60", VA = "0x186F79760")]
	public static ECDMIHFMDEC KLDBPIDHOEH([In] this Quaternion OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F79650", Offset = "0x6F77C50", VA = "0x186F79650")]
	public static Quaternion JGNOLJBBCJA(this ECDMIHFMDEC OLDDCPCBGIL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F796C0", Offset = "0x6F77CC0", VA = "0x186F796C0")]
	public static Quaternion? JNMLFIKLKBC(this ECDMIHFMDEC OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EAGFMCADFHC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F79840", Offset = "0x6F77E40", VA = "0x186F79840")]
	public static APJMCMAFHFO KLDBPIDHOEH([In] this Vector2 OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F797E0", Offset = "0x6F77DE0", VA = "0x186F797E0")]
	public static Vector2 JGNOLJBBCJA(this APJMCMAFHFO OLDDCPCBGIL)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HOLDNOLHAIF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F799B0", Offset = "0x6F77FB0", VA = "0x186F799B0")]
	public static FCFHBHHCBNC KLDBPIDHOEH([In] this Vector3 OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F798B0", Offset = "0x6F77EB0", VA = "0x186F798B0")]
	public static Vector3 JGNOLJBBCJA(this FCFHBHHCBNC OLDDCPCBGIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F79920", Offset = "0x6F77F20", VA = "0x186F79920")]
	public static Vector3? JNMLFIKLKBC(this FCFHBHHCBNC OLDDCPCBGIL)
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
