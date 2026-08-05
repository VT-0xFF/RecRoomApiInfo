using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CPCBGKCGPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x168D580", Offset = "0x168BD80", VA = "0x18168D580")]
	public static KAINFBHHIEN ECCPKOGLKLF(this in Color GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x168D740", Offset = "0x168BF40", VA = "0x18168D740")]
	public static Color NLJPEOGMFGO(this KAINFBHHIEN GPOCLJBKMHA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x168D620", Offset = "0x168BE20", VA = "0x18168D620")]
	public static Color? HIPDKDJNNKL(this KAINFBHHIEN GPOCLJBKMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FCFHPIBOAJM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x168D810", Offset = "0x168C010", VA = "0x18168D810")]
	public static IMDNFGNONNN ECCPKOGLKLF(this in Quaternion GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x168D9D0", Offset = "0x168C1D0", VA = "0x18168D9D0")]
	public static Quaternion NLJPEOGMFGO(this IMDNFGNONNN GPOCLJBKMHA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x168D8B0", Offset = "0x168C0B0", VA = "0x18168D8B0")]
	public static Quaternion? HIPDKDJNNKL(this IMDNFGNONNN GPOCLJBKMHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GEOLJENIFEL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x168DBF0", Offset = "0x168C3F0", VA = "0x18168DBF0")]
	public static Quaternion LFAHADNOIIC(PGMCOBAGOPG PHBHEFAPHDL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x168DAA0", Offset = "0x168C2A0", VA = "0x18168DAA0")]
	public static JMEOOMJNICO BFNGOGIALBH(Quaternion DEJEGENNCEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x168DB50", Offset = "0x168C350", VA = "0x18168DB50")]
	public static Quaternion DKEJPJKAFGO(JMEOOMJNICO PHBHEFAPHDL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KBBEOGJKEGD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x168DE10", Offset = "0x168C610", VA = "0x18168DE10")]
	public static JMEOOMJNICO ECCPKOGLKLF(this in Vector3 GPOCLJBKMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x168DF60", Offset = "0x168C760", VA = "0x18168DF60")]
	public static Vector3 NLJPEOGMFGO(this JMEOOMJNICO GPOCLJBKMHA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x168DEA0", Offset = "0x168C6A0", VA = "0x18168DEA0")]
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
