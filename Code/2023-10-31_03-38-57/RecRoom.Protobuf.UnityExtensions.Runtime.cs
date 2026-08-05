using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NFMABAPDDJB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61BF1A0", Offset = "0x61BE5A0", VA = "0x1861BF1A0")]
	public static HGFNIFMMLKF PJNKBIHCNDA([In] this Color LDMHFMNLDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61BF170", Offset = "0x61BE570", VA = "0x1861BF170")]
	public static Color ONLENKPGCBM(this HGFNIFMMLKF LDMHFMNLDHG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61BF220", Offset = "0x61BE620", VA = "0x1861BF220")]
	public static Color? PLPHCGAJPOH(this HGFNIFMMLKF LDMHFMNLDHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DKFJCJJCKEM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61BED40", Offset = "0x61BE140", VA = "0x1861BED40")]
	public static Quaternion BEJFLPOCCJK(PIFBOCAFLOH GHFAAPNAFDE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61BEC50", Offset = "0x61BE050", VA = "0x1861BEC50")]
	public static KNNNHOOLLDC ANDEDKJOENL(Quaternion KOPHEPKELJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61BEF60", Offset = "0x61BE360", VA = "0x1861BEF60")]
	public static Quaternion HBGJILOAGKM(KNNNHOOLLDC GHFAAPNAFDE)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DBKCJKEGCNK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61BEB30", Offset = "0x61BDF30", VA = "0x1861BEB30")]
	public static HMMGALNAFGO PJNKBIHCNDA([In] this Quaternion LDMHFMNLDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61BEAC0", Offset = "0x61BDEC0", VA = "0x1861BEAC0")]
	public static Quaternion ONLENKPGCBM(this HMMGALNAFGO LDMHFMNLDHG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61BEBB0", Offset = "0x61BDFB0", VA = "0x1861BEBB0")]
	public static Quaternion? PLPHCGAJPOH(this HMMGALNAFGO LDMHFMNLDHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BGOHNPDNNJD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61BEA50", Offset = "0x61BDE50", VA = "0x1861BEA50")]
	public static DOJCEEEDNEN PJNKBIHCNDA([In] this Vector2 LDMHFMNLDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61BE9F0", Offset = "0x61BDDF0", VA = "0x1861BE9F0")]
	public static Vector2 ONLENKPGCBM(this DOJCEEEDNEN LDMHFMNLDHG)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GPKLNONINPC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61BF070", Offset = "0x61BE470", VA = "0x1861BF070")]
	public static KNNNHOOLLDC PJNKBIHCNDA([In] this Vector3 LDMHFMNLDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61BF000", Offset = "0x61BE400", VA = "0x1861BF000")]
	public static Vector3 ONLENKPGCBM(this KNNNHOOLLDC LDMHFMNLDHG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x61BF0E0", Offset = "0x61BE4E0", VA = "0x1861BF0E0")]
	public static Vector3? PLPHCGAJPOH(this KNNNHOOLLDC LDMHFMNLDHG)
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
