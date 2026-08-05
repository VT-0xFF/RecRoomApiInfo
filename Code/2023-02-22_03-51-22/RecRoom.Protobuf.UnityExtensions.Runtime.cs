using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PIPNKFEEHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64A5580", Offset = "0x64A4780", VA = "0x1864A5580")]
	public static CGJJMPBCBLG LMGAKHPBOLH(this in Color PKCJMFFNILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64A5600", Offset = "0x64A4800", VA = "0x1864A5600")]
	public static Color LPJEJNEGJFP(this CGJJMPBCBLG PKCJMFFNILJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64A54C0", Offset = "0x64A46C0", VA = "0x1864A54C0")]
	public static Color? FIMOLPKPBHD(this CGJJMPBCBLG PKCJMFFNILJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JAGBNGAPHKP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64A5140", Offset = "0x64A4340", VA = "0x1864A5140")]
	public static Quaternion DDKJPJLENNL(APKAFPALNAL ONIBEFDCPGD)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64A52D0", Offset = "0x64A44D0", VA = "0x1864A52D0")]
	public static DKJKBCNICCP KBBOECBJAEG(Quaternion CPAPEOGLBGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64A50D0", Offset = "0x64A42D0", VA = "0x1864A50D0")]
	public static Quaternion BFPHPHADNEE(DKJKBCNICCP ONIBEFDCPGD)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ELBCJADBFAA
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64A4FF0", Offset = "0x64A41F0", VA = "0x1864A4FF0")]
	public static IKJKHDHLGAG LMGAKHPBOLH(this in Quaternion PKCJMFFNILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64A5070", Offset = "0x64A4270", VA = "0x1864A5070")]
	public static Quaternion LPJEJNEGJFP(this IKJKHDHLGAG PKCJMFFNILJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64A4F30", Offset = "0x64A4130", VA = "0x1864A4F30")]
	public static Quaternion? FIMOLPKPBHD(this IKJKHDHLGAG PKCJMFFNILJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LCIINNKOAGL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64A5400", Offset = "0x64A4600", VA = "0x1864A5400")]
	public static DKJKBCNICCP LMGAKHPBOLH(this in Vector3 PKCJMFFNILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64A5470", Offset = "0x64A4670", VA = "0x1864A5470")]
	public static Vector3 LPJEJNEGJFP(this DKJKBCNICCP PKCJMFFNILJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64A5370", Offset = "0x64A4570", VA = "0x1864A5370")]
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
