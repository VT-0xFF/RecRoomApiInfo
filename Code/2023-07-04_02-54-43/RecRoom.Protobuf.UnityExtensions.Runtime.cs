using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JJPNGBFKPBO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x726C9C0", Offset = "0x726AFC0", VA = "0x18726C9C0")]
	public static NLCLMIJPEEL DHDFEGACAHE(this in Color PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x726CA60", Offset = "0x726B060", VA = "0x18726CA60")]
	public static Color EMHFJGFFMPB(this NLCLMIJPEEL PBJDHAKDMFG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x726CB30", Offset = "0x726B130", VA = "0x18726CB30")]
	public static Color? ENBLGJCDAHO(this NLCLMIJPEEL PBJDHAKDMFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LIJFAFCONGK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x726CC50", Offset = "0x726B250", VA = "0x18726CC50")]
	public static OFEBCLGNNMF DHDFEGACAHE(this in Quaternion PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x726CCF0", Offset = "0x726B2F0", VA = "0x18726CCF0")]
	public static Quaternion EMHFJGFFMPB(this OFEBCLGNNMF PBJDHAKDMFG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x726CDC0", Offset = "0x726B3C0", VA = "0x18726CDC0")]
	public static Quaternion? ENBLGJCDAHO(this OFEBCLGNNMF PBJDHAKDMFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IOKDHELOCEG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x726C710", Offset = "0x726AD10", VA = "0x18726C710")]
	public static Quaternion GHDJBGOBPMC(AIOBKBBKJEL GOMDNNCBLHP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x726C660", Offset = "0x726AC60", VA = "0x18726C660")]
	public static KNJGJALNGMI DKJHJNJPBKA(Quaternion KMABGKGDBPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x726C920", Offset = "0x726AF20", VA = "0x18726C920")]
	public static Quaternion PMPFDPKMENP(KNJGJALNGMI GOMDNNCBLHP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BBOKNKFBDDL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x726C470", Offset = "0x726AA70", VA = "0x18726C470")]
	public static KNJGJALNGMI DHDFEGACAHE(this in Vector3 PBJDHAKDMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x726C500", Offset = "0x726AB00", VA = "0x18726C500")]
	public static Vector3 EMHFJGFFMPB(this KNJGJALNGMI PBJDHAKDMFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x726C5A0", Offset = "0x726ABA0", VA = "0x18726C5A0")]
	public static Vector3? ENBLGJCDAHO(this KNJGJALNGMI PBJDHAKDMFG)
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
