using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LPEODDAFBCP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CC40", Offset = "0x1D3B240", VA = "0x181D3CC40")]
	public static DHDODJCFJCB HGEKGOKJCDE(this in Color DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CB20", Offset = "0x1D3B120", VA = "0x181D3CB20")]
	public static Color FFFJLEEKFAK(this DHDODJCFJCB DKOFBKPNBJK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CB80", Offset = "0x1D3B180", VA = "0x181D3CB80")]
	public static Color? HFBMAANKFOP(this DHDODJCFJCB DKOFBKPNBJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KMFJELKDOKA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C920", Offset = "0x1D3AF20", VA = "0x181D3C920")]
	public static Quaternion EGLICJHLNPC(OGBHAPAGIJI JIHCLPECHIB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C880", Offset = "0x1D3AE80", VA = "0x181D3C880")]
	public static FHNMKKEJMOO CGMGOKKCOIO(Quaternion AJAIFFPFPBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CAB0", Offset = "0x1D3B0B0", VA = "0x181D3CAB0")]
	public static Quaternion JFFCCGOPJGK(FHNMKKEJMOO JIHCLPECHIB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HKIPGMILJDM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C800", Offset = "0x1D3AE00", VA = "0x181D3C800")]
	public static HNFHDDDAFIO HGEKGOKJCDE(this in Quaternion DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C620", Offset = "0x1D3AC20", VA = "0x181D3C620")]
	public static HNFHDDDAFIO BHDNIPKJFMG(this in Quaternion? DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C6E0", Offset = "0x1D3ACE0", VA = "0x181D3C6E0")]
	public static Quaternion FFFJLEEKFAK(this HNFHDDDAFIO DKOFBKPNBJK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D3C740", Offset = "0x1D3AD40", VA = "0x181D3C740")]
	public static Quaternion? HFBMAANKFOP(this HNFHDDDAFIO DKOFBKPNBJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OCMOIPAJGCL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CE60", Offset = "0x1D3B460", VA = "0x181D3CE60")]
	public static FHNMKKEJMOO HGEKGOKJCDE(this in Vector3 DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CCC0", Offset = "0x1D3B2C0", VA = "0x181D3CCC0")]
	public static FHNMKKEJMOO BHDNIPKJFMG(this in Vector3? DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CD80", Offset = "0x1D3B380", VA = "0x181D3CD80")]
	public static Vector3 FFFJLEEKFAK(this FHNMKKEJMOO DKOFBKPNBJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CDD0", Offset = "0x1D3B3D0", VA = "0x181D3CDD0")]
	public static Vector3? HFBMAANKFOP(this FHNMKKEJMOO DKOFBKPNBJK)
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
