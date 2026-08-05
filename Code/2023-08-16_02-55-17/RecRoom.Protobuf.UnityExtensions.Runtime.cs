using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EDIFMMOGHIN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BDA0", Offset = "0x6F7AFA0", VA = "0x186F7BDA0")]
	public static GFMLHJPADHG IOAMGHHAJNN(this in Color KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BE40", Offset = "0x6F7B040", VA = "0x186F7BE40")]
	public static Color JHIOLOAEPHF(this GFMLHJPADHG KPIHKJNPOFH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BF10", Offset = "0x6F7B110", VA = "0x186F7BF10")]
	public static Color? MLBCGDMFGJD(this GFMLHJPADHG KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BDPGCDGANCL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B920", Offset = "0x6F7AB20", VA = "0x186F7B920")]
	public static PEHBPPHFBPO IOAMGHHAJNN(this in Quaternion KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F7B9C0", Offset = "0x6F7ABC0", VA = "0x186F7B9C0")]
	public static Quaternion JHIOLOAEPHF(this PEHBPPHFBPO KPIHKJNPOFH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BA90", Offset = "0x6F7AC90", VA = "0x186F7BA90")]
	public static Quaternion? MLBCGDMFGJD(this PEHBPPHFBPO KPIHKJNPOFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LKDGNCNCANN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C030", Offset = "0x6F7B230", VA = "0x186F7C030")]
	public static Quaternion EKABHCNNFEF(KDHHNFOJCPF JFGIPFOFKHL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C2E0", Offset = "0x6F7B4E0", VA = "0x186F7C2E0")]
	public static CHMPGEJCMIF KEJFLPOFJFB(Quaternion BEGJNNCAHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F7C240", Offset = "0x6F7B440", VA = "0x186F7C240")]
	public static Quaternion EPMLFHLFOKJ(CHMPGEJCMIF JFGIPFOFKHL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BPLNCLABABF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BBB0", Offset = "0x6F7ADB0", VA = "0x186F7BBB0")]
	public static CHMPGEJCMIF IOAMGHHAJNN(this in Vector3 KPIHKJNPOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BC40", Offset = "0x6F7AE40", VA = "0x186F7BC40")]
	public static Vector3 JHIOLOAEPHF(this CHMPGEJCMIF KPIHKJNPOFH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7BCE0", Offset = "0x6F7AEE0", VA = "0x186F7BCE0")]
	public static Vector3? MLBCGDMFGJD(this CHMPGEJCMIF KPIHKJNPOFH)
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
