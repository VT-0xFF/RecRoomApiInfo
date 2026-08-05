using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FGHAFCJFOHA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B34CF0", Offset = "0x6B33AF0", VA = "0x186B34CF0")]
	public static GPHGEDDAOCA EPOBOPBJBKM(this in Color LCNEHOGIJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B34C90", Offset = "0x6B33A90", VA = "0x186B34C90")]
	public static Color BPPOCFBLMGN(this GPHGEDDAOCA LCNEHOGIJPK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B34BD0", Offset = "0x6B339D0", VA = "0x186B34BD0")]
	public static Color? AGDJMPGAJFO(this GPHGEDDAOCA LCNEHOGIJPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NHNAHLEPFCD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B34FD0", Offset = "0x6B33DD0", VA = "0x186B34FD0")]
	public static Quaternion OEFDAFMNGNA(GBFLECLHGEH MMJOHADFCHO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B34EC0", Offset = "0x6B33CC0", VA = "0x186B34EC0")]
	public static BFNEONPGBLD AAIPHNIPCDI(Quaternion GHFDHGFJAOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B34F60", Offset = "0x6B33D60", VA = "0x186B34F60")]
	public static Quaternion EDDLPLBFBHA(BFNEONPGBLD MMJOHADFCHO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EFDJEGJIKDG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B34B50", Offset = "0x6B33950", VA = "0x186B34B50")]
	public static IKHINNEBHON EPOBOPBJBKM(this in Quaternion LCNEHOGIJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B34AF0", Offset = "0x6B338F0", VA = "0x186B34AF0")]
	public static Quaternion BPPOCFBLMGN(this IKHINNEBHON LCNEHOGIJPK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B34A30", Offset = "0x6B33830", VA = "0x186B34A30")]
	public static Quaternion? AGDJMPGAJFO(this IKHINNEBHON LCNEHOGIJPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JHLJFNCBLMG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B34E50", Offset = "0x6B33C50", VA = "0x186B34E50")]
	public static BFNEONPGBLD EPOBOPBJBKM(this in Vector3 LCNEHOGIJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B34E00", Offset = "0x6B33C00", VA = "0x186B34E00")]
	public static Vector3 BPPOCFBLMGN(this BFNEONPGBLD LCNEHOGIJPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B34D70", Offset = "0x6B33B70", VA = "0x186B34D70")]
	public static Vector3? AGDJMPGAJFO(this BFNEONPGBLD LCNEHOGIJPK)
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
