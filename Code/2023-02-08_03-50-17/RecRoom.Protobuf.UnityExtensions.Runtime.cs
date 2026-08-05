using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BJIMJJOFHND
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x648B1A0", Offset = "0x6489FA0", VA = "0x18648B1A0")]
	public static DPFDLMJDEAN HGGLACGHMAP(this in Color BIKHFKCJEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x648B220", Offset = "0x648A020", VA = "0x18648B220")]
	public static Color IMPOKOFCPDO(this DPFDLMJDEAN BIKHFKCJEPO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x648B0E0", Offset = "0x6489EE0", VA = "0x18648B0E0")]
	public static Color? EKCIKDFBHOD(this DPFDLMJDEAN BIKHFKCJEPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JMDEEJLJLOA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x648B390", Offset = "0x648A190", VA = "0x18648B390")]
	public static Quaternion KOKOMPFGOMG(GFLOFEFMOBB CPLKBCGCHAN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x648B2F0", Offset = "0x648A0F0", VA = "0x18648B2F0")]
	public static PDBHCLPNEBI KEACEPKKIOM(Quaternion JLFBMDLGMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x648B280", Offset = "0x648A080", VA = "0x18648B280")]
	public static Quaternion EGCHBOIBKGP(PDBHCLPNEBI CPLKBCGCHAN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MCDPPIIIAPD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x648B6A0", Offset = "0x648A4A0", VA = "0x18648B6A0")]
	public static AHIBAELLEIJ HGGLACGHMAP(this in Quaternion BIKHFKCJEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x648B520", Offset = "0x648A320", VA = "0x18648B520")]
	public static AHIBAELLEIJ AEBMMBJICEA(this in Quaternion? BIKHFKCJEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x648B720", Offset = "0x648A520", VA = "0x18648B720")]
	public static Quaternion IMPOKOFCPDO(this AHIBAELLEIJ BIKHFKCJEPO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x648B5E0", Offset = "0x648A3E0", VA = "0x18648B5E0")]
	public static Quaternion? EKCIKDFBHOD(this AHIBAELLEIJ BIKHFKCJEPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MEBCCAOKMAO
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x648B8D0", Offset = "0x648A6D0", VA = "0x18648B8D0")]
	public static PDBHCLPNEBI HGGLACGHMAP(this in Vector3 BIKHFKCJEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x648B780", Offset = "0x648A580", VA = "0x18648B780")]
	public static PDBHCLPNEBI AEBMMBJICEA(this in Vector3? BIKHFKCJEPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x648B940", Offset = "0x648A740", VA = "0x18648B940")]
	public static Vector3 IMPOKOFCPDO(this PDBHCLPNEBI BIKHFKCJEPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x648B840", Offset = "0x648A640", VA = "0x18648B840")]
	public static Vector3? EKCIKDFBHOD(this PDBHCLPNEBI BIKHFKCJEPO)
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
