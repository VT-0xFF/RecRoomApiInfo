using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LPEODDAFBCP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x609C4B0", Offset = "0x609AEB0", VA = "0x18609C4B0")]
	public static DHDODJCFJCB HGEKGOKJCDE(this in Color DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x609C390", Offset = "0x609AD90", VA = "0x18609C390")]
	public static Color FFFJLEEKFAK(this DHDODJCFJCB DKOFBKPNBJK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x609C3F0", Offset = "0x609ADF0", VA = "0x18609C3F0")]
	public static Color? HFBMAANKFOP(this DHDODJCFJCB DKOFBKPNBJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KMFJELKDOKA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x609C190", Offset = "0x609AB90", VA = "0x18609C190")]
	public static Quaternion EGLICJHLNPC(OGBHAPAGIJI JIHCLPECHIB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x609C0F0", Offset = "0x609AAF0", VA = "0x18609C0F0")]
	public static FHNMKKEJMOO CGMGOKKCOIO(Quaternion AJAIFFPFPBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x609C320", Offset = "0x609AD20", VA = "0x18609C320")]
	public static Quaternion JFFCCGOPJGK(FHNMKKEJMOO JIHCLPECHIB)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HKIPGMILJDM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x609C070", Offset = "0x609AA70", VA = "0x18609C070")]
	public static HNFHDDDAFIO HGEKGOKJCDE(this in Quaternion DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x609BE90", Offset = "0x609A890", VA = "0x18609BE90")]
	public static HNFHDDDAFIO BHDNIPKJFMG(this in Quaternion? DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x609BF50", Offset = "0x609A950", VA = "0x18609BF50")]
	public static Quaternion FFFJLEEKFAK(this HNFHDDDAFIO DKOFBKPNBJK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x609BFB0", Offset = "0x609A9B0", VA = "0x18609BFB0")]
	public static Quaternion? HFBMAANKFOP(this HNFHDDDAFIO DKOFBKPNBJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OCMOIPAJGCL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x609C6D0", Offset = "0x609B0D0", VA = "0x18609C6D0")]
	public static FHNMKKEJMOO HGEKGOKJCDE(this in Vector3 DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x609C530", Offset = "0x609AF30", VA = "0x18609C530")]
	public static FHNMKKEJMOO BHDNIPKJFMG(this in Vector3? DKOFBKPNBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x609C5F0", Offset = "0x609AFF0", VA = "0x18609C5F0")]
	public static Vector3 FFFJLEEKFAK(this FHNMKKEJMOO DKOFBKPNBJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x609C640", Offset = "0x609B040", VA = "0x18609C640")]
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
