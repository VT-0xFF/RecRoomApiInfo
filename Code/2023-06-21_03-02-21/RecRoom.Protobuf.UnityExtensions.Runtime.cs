using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MLHHOONIOAE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x15A8690", Offset = "0x15A7890", VA = "0x1815A8690")]
	public static JABLBAOHJAE IOEANABOGCL(this in Color DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x15A84A0", Offset = "0x15A76A0", VA = "0x1815A84A0")]
	public static Color AKLCAJOKCCK(this JABLBAOHJAE DCMHODHEGEC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x15A8570", Offset = "0x15A7770", VA = "0x1815A8570")]
	public static Color? INAGHDGIMJM(this JABLBAOHJAE DCMHODHEGEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CLILJCMPPKD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15A7EB0", Offset = "0x15A70B0", VA = "0x1815A7EB0")]
	public static ECFENABDFGI IOEANABOGCL(this in Quaternion DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15A7CC0", Offset = "0x15A6EC0", VA = "0x1815A7CC0")]
	public static Quaternion AKLCAJOKCCK(this ECFENABDFGI DCMHODHEGEC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x15A7D90", Offset = "0x15A6F90", VA = "0x1815A7D90")]
	public static Quaternion? INAGHDGIMJM(this ECFENABDFGI DCMHODHEGEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HJDMBDJNJCO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x15A80A0", Offset = "0x15A72A0", VA = "0x1815A80A0")]
	public static Quaternion NMCFBGCFJJP(DHNFOGMCHEB JCEJEOAKGOJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x15A7FF0", Offset = "0x15A71F0", VA = "0x1815A7FF0")]
	public static LPJBOOMNEPL HACCJHBGFII(Quaternion CDDGPAMKMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x15A7F50", Offset = "0x15A7150", VA = "0x1815A7F50")]
	public static Quaternion CPKJHLFDHFJ(LPJBOOMNEPL JCEJEOAKGOJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KEAAJOJCOFE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x15A8410", Offset = "0x15A7610", VA = "0x1815A8410")]
	public static LPJBOOMNEPL IOEANABOGCL(this in Vector3 DCMHODHEGEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x15A82B0", Offset = "0x15A74B0", VA = "0x1815A82B0")]
	public static Vector3 AKLCAJOKCCK(this LPJBOOMNEPL DCMHODHEGEC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x15A8350", Offset = "0x15A7550", VA = "0x1815A8350")]
	public static Vector3? INAGHDGIMJM(this LPJBOOMNEPL DCMHODHEGEC)
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
