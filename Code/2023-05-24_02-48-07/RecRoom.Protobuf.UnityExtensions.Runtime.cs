using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CPCBGKCGPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x13A5A10", Offset = "0x13A4610", VA = "0x1813A5A10")]
	public static KAINFBHHIEN ECCPKOGLKLF(this in Color GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x13A5BD0", Offset = "0x13A47D0", VA = "0x1813A5BD0")]
	public static Color NLJPEOGMFGO(this KAINFBHHIEN GPOCLJBKMHA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x13A5AB0", Offset = "0x13A46B0", VA = "0x1813A5AB0")]
	public static Color? HIPDKDJNNKL(this KAINFBHHIEN GPOCLJBKMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FCFHPIBOAJM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x13A5CA0", Offset = "0x13A48A0", VA = "0x1813A5CA0")]
	public static IMDNFGNONNN ECCPKOGLKLF(this in Quaternion GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x13A5E60", Offset = "0x13A4A60", VA = "0x1813A5E60")]
	public static Quaternion NLJPEOGMFGO(this IMDNFGNONNN GPOCLJBKMHA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13A5D40", Offset = "0x13A4940", VA = "0x1813A5D40")]
	public static Quaternion? HIPDKDJNNKL(this IMDNFGNONNN GPOCLJBKMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GEOLJENIFEL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x13A6080", Offset = "0x13A4C80", VA = "0x1813A6080")]
	public static Quaternion LFAHADNOIIC(PGMCOBAGOPG PHBHEFAPHDL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x13A5F30", Offset = "0x13A4B30", VA = "0x1813A5F30")]
	public static JMEOOMJNICO BFNGOGIALBH(Quaternion DEJEGENNCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x13A5FE0", Offset = "0x13A4BE0", VA = "0x1813A5FE0")]
	public static Quaternion DKEJPJKAFGO(JMEOOMJNICO PHBHEFAPHDL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KBBEOGJKEGD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x13A62A0", Offset = "0x13A4EA0", VA = "0x1813A62A0")]
	public static JMEOOMJNICO ECCPKOGLKLF(this in Vector3 GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x13A63F0", Offset = "0x13A4FF0", VA = "0x1813A63F0")]
	public static Vector3 NLJPEOGMFGO(this JMEOOMJNICO GPOCLJBKMHA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x13A6330", Offset = "0x13A4F30", VA = "0x1813A6330")]
	public static Vector3? HIPDKDJNNKL(this JMEOOMJNICO GPOCLJBKMHA)
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
