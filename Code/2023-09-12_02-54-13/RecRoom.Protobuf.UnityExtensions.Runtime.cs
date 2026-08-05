using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IEKNFPPOOPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x722C570", Offset = "0x722B970", VA = "0x18722C570")]
	public static NJLCNCFDOAP CJMDONJKOCN(this in Color ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x722C610", Offset = "0x722BA10", VA = "0x18722C610")]
	public static Color EFFJDOFDOEN(this NJLCNCFDOAP ODBHDBFBMOB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x722C6E0", Offset = "0x722BAE0", VA = "0x18722C6E0")]
	public static Color? HCFADFOBMLN(this NJLCNCFDOAP ODBHDBFBMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IHNPLMPKNIL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x722C800", Offset = "0x722BC00", VA = "0x18722C800")]
	public static HKEBIJNAEAM CJMDONJKOCN(this in Vector2 ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x722C880", Offset = "0x722BC80", VA = "0x18722C880")]
	public static Vector2 EFFJDOFDOEN(this HKEBIJNAEAM ODBHDBFBMOB)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GMDPIHOFPGF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x722C2E0", Offset = "0x722B6E0", VA = "0x18722C2E0")]
	public static CGPCLKCKAJC CJMDONJKOCN(this in Quaternion ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x722C380", Offset = "0x722B780", VA = "0x18722C380")]
	public static Quaternion EFFJDOFDOEN(this CGPCLKCKAJC ODBHDBFBMOB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x722C450", Offset = "0x722B850", VA = "0x18722C450")]
	public static Quaternion? HCFADFOBMLN(this CGPCLKCKAJC ODBHDBFBMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GMCHKEJCKCD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x722BF80", Offset = "0x722B380", VA = "0x18722BF80")]
	public static Quaternion KMCBPNPGEBC(LMGJDFOFMGN CLCAIFLMLCJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x722C190", Offset = "0x722B590", VA = "0x18722C190")]
	public static MCECJACDFAF MMEEOLAGKAE(Quaternion HAACKMMKBEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x722C240", Offset = "0x722B640", VA = "0x18722C240")]
	public static Quaternion PNFFMJNDFAI(MCECJACDFAF CLCAIFLMLCJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NBEPKCONKHN
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x722C8D0", Offset = "0x722BCD0", VA = "0x18722C8D0")]
	public static MCECJACDFAF CJMDONJKOCN(this in Vector3 ODBHDBFBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x722C960", Offset = "0x722BD60", VA = "0x18722C960")]
	public static Vector3 EFFJDOFDOEN(this MCECJACDFAF ODBHDBFBMOB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x722CA00", Offset = "0x722BE00", VA = "0x18722CA00")]
	public static Vector3? HCFADFOBMLN(this MCECJACDFAF ODBHDBFBMOB)
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
