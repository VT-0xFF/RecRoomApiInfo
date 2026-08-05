using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PIPNKFEEHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64A1730", Offset = "0x64A0B30", VA = "0x1864A1730")]
	public static CGJJMPBCBLG LMGAKHPBOLH(this in Color PKCJMFFNILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64A17B0", Offset = "0x64A0BB0", VA = "0x1864A17B0")]
	public static Color LPJEJNEGJFP(this CGJJMPBCBLG PKCJMFFNILJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64A1670", Offset = "0x64A0A70", VA = "0x1864A1670")]
	public static Color? FIMOLPKPBHD(this CGJJMPBCBLG PKCJMFFNILJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JAGBNGAPHKP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64A12F0", Offset = "0x64A06F0", VA = "0x1864A12F0")]
	public static Quaternion DDKJPJLENNL(APKAFPALNAL ONIBEFDCPGD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64A1480", Offset = "0x64A0880", VA = "0x1864A1480")]
	public static DKJKBCNICCP KBBOECBJAEG(Quaternion CPAPEOGLBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64A1280", Offset = "0x64A0680", VA = "0x1864A1280")]
	public static Quaternion BFPHPHADNEE(DKJKBCNICCP ONIBEFDCPGD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ELBCJADBFAA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64A11A0", Offset = "0x64A05A0", VA = "0x1864A11A0")]
	public static IKJKHDHLGAG LMGAKHPBOLH(this in Quaternion PKCJMFFNILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64A1220", Offset = "0x64A0620", VA = "0x1864A1220")]
	public static Quaternion LPJEJNEGJFP(this IKJKHDHLGAG PKCJMFFNILJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64A10E0", Offset = "0x64A04E0", VA = "0x1864A10E0")]
	public static Quaternion? FIMOLPKPBHD(this IKJKHDHLGAG PKCJMFFNILJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LCIINNKOAGL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64A15B0", Offset = "0x64A09B0", VA = "0x1864A15B0")]
	public static DKJKBCNICCP LMGAKHPBOLH(this in Vector3 PKCJMFFNILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64A1620", Offset = "0x64A0A20", VA = "0x1864A1620")]
	public static Vector3 LPJEJNEGJFP(this DKJKBCNICCP PKCJMFFNILJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64A1520", Offset = "0x64A0920", VA = "0x1864A1520")]
	public static Vector3? FIMOLPKPBHD(this DKJKBCNICCP PKCJMFFNILJ)
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
