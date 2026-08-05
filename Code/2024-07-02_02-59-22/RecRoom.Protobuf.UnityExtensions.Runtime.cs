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
	[Cpp2IlInjected.Address(RVA = "0x6FAEA40", Offset = "0x6FADA40", VA = "0x186FAEA40")]
	public static OPOAPIEGMEK KLDBPIDHOEH([In] this Color OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE990", Offset = "0x6FAD990", VA = "0x186FAE990")]
	public static Color JGNOLJBBCJA(this OPOAPIEGMEK OLDDCPCBGIL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE9C0", Offset = "0x6FAD9C0", VA = "0x186FAE9C0")]
	public static Color? JNMLFIKLKBC(this OPOAPIEGMEK OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BKGEIOGCFKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE300", Offset = "0x6FAD300", VA = "0x186FAE300")]
	public static Quaternion GEMAKKBMEJE(KGNOAFLJLKF FHNKDHIILBL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE210", Offset = "0x6FAD210", VA = "0x186FAE210")]
	public static FCFHBHHCBNC BJEOEHMIDLK(Quaternion DAJJMAOCHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE520", Offset = "0x6FAD520", VA = "0x186FAE520")]
	public static Quaternion PNEGAJEKFPG(FCFHBHHCBNC FHNKDHIILBL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BOLBBNOBOAA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE6D0", Offset = "0x6FAD6D0", VA = "0x186FAE6D0")]
	public static ECDMIHFMDEC KLDBPIDHOEH([In] this Quaternion OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE5C0", Offset = "0x6FAD5C0", VA = "0x186FAE5C0")]
	public static Quaternion JGNOLJBBCJA(this ECDMIHFMDEC OLDDCPCBGIL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE630", Offset = "0x6FAD630", VA = "0x186FAE630")]
	public static Quaternion? JNMLFIKLKBC(this ECDMIHFMDEC OLDDCPCBGIL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EAGFMCADFHC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE7B0", Offset = "0x6FAD7B0", VA = "0x186FAE7B0")]
	public static APJMCMAFHFO KLDBPIDHOEH([In] this Vector2 OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE750", Offset = "0x6FAD750", VA = "0x186FAE750")]
	public static Vector2 JGNOLJBBCJA(this APJMCMAFHFO OLDDCPCBGIL)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HOLDNOLHAIF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE920", Offset = "0x6FAD920", VA = "0x186FAE920")]
	public static FCFHBHHCBNC KLDBPIDHOEH([In] this Vector3 OLDDCPCBGIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE820", Offset = "0x6FAD820", VA = "0x186FAE820")]
	public static Vector3 JGNOLJBBCJA(this FCFHBHHCBNC OLDDCPCBGIL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE890", Offset = "0x6FAD890", VA = "0x186FAE890")]
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
