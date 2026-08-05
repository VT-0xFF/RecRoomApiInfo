using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JCMNGKKCMGB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x672A010", Offset = "0x6729410", VA = "0x18672A010")]
	public static AMDINPGBFLM CJKIIDNIDDE(this in Color AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x672A090", Offset = "0x6729490", VA = "0x18672A090")]
	public static Color EOLLHEJPBAN(this AMDINPGBFLM AOFCPKBHFEM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6729F50", Offset = "0x6729350", VA = "0x186729F50")]
	public static Color? ALBHNCFGDOH(this AMDINPGBFLM AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DGNGDIGELPG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6729CB0", Offset = "0x67290B0", VA = "0x186729CB0")]
	public static Quaternion DIPIEBHBNII(MAKIBJJFIPE FNIHENPLJHK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6729EB0", Offset = "0x67292B0", VA = "0x186729EB0")]
	public static ICADAJKKDHJ EGELJONEJFI(Quaternion HPICHNDOOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6729E40", Offset = "0x6729240", VA = "0x186729E40")]
	public static Quaternion DNPGIFLONDL(ICADAJKKDHJ FNIHENPLJHK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OGJFHFDJPOI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x672A1B0", Offset = "0x67295B0", VA = "0x18672A1B0")]
	public static HMEANOLBAJN CJKIIDNIDDE(this in Quaternion AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x672A230", Offset = "0x6729630", VA = "0x18672A230")]
	public static Quaternion EOLLHEJPBAN(this HMEANOLBAJN AOFCPKBHFEM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x672A0F0", Offset = "0x67294F0", VA = "0x18672A0F0")]
	public static Quaternion? ALBHNCFGDOH(this HMEANOLBAJN AOFCPKBHFEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BPKAKCILFHM
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6729BF0", Offset = "0x6728FF0", VA = "0x186729BF0")]
	public static ICADAJKKDHJ CJKIIDNIDDE(this in Vector3 AOFCPKBHFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6729C60", Offset = "0x6729060", VA = "0x186729C60")]
	public static Vector3 EOLLHEJPBAN(this ICADAJKKDHJ AOFCPKBHFEM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6729B60", Offset = "0x6728F60", VA = "0x186729B60")]
	public static Vector3? ALBHNCFGDOH(this ICADAJKKDHJ AOFCPKBHFEM)
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
