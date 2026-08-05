using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GNGMABOGMHA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8524460", Offset = "0x8522E60", VA = "0x188524460")]
	public static BCLJBNLGDDE PGPOMLMDCHO([In] this Color NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8524430", Offset = "0x8522E30", VA = "0x188524430")]
	public static Color PGEPBAPICDN(this BCLJBNLGDDE NMEFAPBBOCD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x85243B0", Offset = "0x8522DB0", VA = "0x1885243B0")]
	public static Color? AEIOLAHJMOD(this BCLJBNLGDDE NMEFAPBBOCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HIKOICAEODA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x85244E0", Offset = "0x8522EE0", VA = "0x1885244E0")]
	public static Quaternion COOPPCOKILI(BMHJEOHMGNG HPGIDELCODH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85246F0", Offset = "0x85230F0", VA = "0x1885246F0")]
	public static EEPJEJHNEMK GFAGEGALONB(Quaternion ADECPNCCHBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x85247E0", Offset = "0x85231E0", VA = "0x1885247E0")]
	public static Quaternion KKBAHKGGIKC(EEPJEJHNEMK HPGIDELCODH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DPKKFMMKLAN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8524330", Offset = "0x8522D30", VA = "0x188524330")]
	public static HPALMCOCIMM PGPOMLMDCHO([In] this Quaternion NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85242C0", Offset = "0x8522CC0", VA = "0x1885242C0")]
	public static Quaternion PGEPBAPICDN(this HPALMCOCIMM NMEFAPBBOCD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8524220", Offset = "0x8522C20", VA = "0x188524220")]
	public static Quaternion? AEIOLAHJMOD(this HPALMCOCIMM NMEFAPBBOCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PCCLILEOHKL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85248E0", Offset = "0x85232E0", VA = "0x1885248E0")]
	public static ACLNPGOGDDA PGPOMLMDCHO([In] this Vector2 NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8524880", Offset = "0x8523280", VA = "0x188524880")]
	public static Vector2 PGEPBAPICDN(this ACLNPGOGDDA NMEFAPBBOCD)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CPHBFGMPEGG
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85241B0", Offset = "0x8522BB0", VA = "0x1885241B0")]
	public static EEPJEJHNEMK PGPOMLMDCHO([In] this Vector3 NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8524080", Offset = "0x8522A80", VA = "0x188524080")]
	public static EEPJEJHNEMK KMIGLMCNLNH([In] this Vector3? NMEFAPBBOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8524140", Offset = "0x8522B40", VA = "0x188524140")]
	public static Vector3 PGEPBAPICDN(this EEPJEJHNEMK NMEFAPBBOCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8523FF0", Offset = "0x85229F0", VA = "0x188523FF0")]
	public static Vector3? AEIOLAHJMOD(this EEPJEJHNEMK NMEFAPBBOCD)
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
