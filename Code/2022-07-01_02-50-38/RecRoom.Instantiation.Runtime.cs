using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Photon.Pun;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EHHLGCFOCAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid JAMGHEGOEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string GBNELIKKKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int HIOBFMDJHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid PFMJIKAEGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DEJMEAJINNE MOIHPMBOGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 MGNGCAEFCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion LPPLCNKCKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float PFIKDCHIDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool CEAIIIBBFMG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x124D7B0", Offset = "0x124BFB0", VA = "0x18124D7B0")]
	public EHHLGCFOCAG(string EGOAMFEEOCO, Guid HAIEEAACGLM, int PGKKNCMJGLA, Guid IHOPKDKCCFP, DEJMEAJINNE HNOLHBHGIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x124D560", Offset = "0x124BD60", VA = "0x18124D560")]
	public NCJNKCHIEJD.DMGLPFCEEBJ LCOEJOILMMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x124D700", Offset = "0x124BF00", VA = "0x18124D700")]
	public CIKENDIBGBO PCFMLIFIMPL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DEJMEAJINNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> LIMHPONALBN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x124D4E0", Offset = "0x124BCE0", VA = "0x18124D4E0")]
	public DEJMEAJINNE([Optional] Dictionary<string, object> LIMHPONALBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x124D300", Offset = "0x124BB00", VA = "0x18124D300")]
	[NotNull]
	public static DEJMEAJINNE BFEDGNJJKBK(PhotonView IOBPGNIOIGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B2F410", Offset = "0x3B2DC10", VA = "0x183B2F410")]
	public bool DHIHCKAPBED<T>(string HJCJKDOGPGK, out T HKJMLEKHILN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25AE2F0", Offset = "0x25ACAF0", VA = "0x1825AE2F0")]
	public void AGHFILABLHM<T>(string HJCJKDOGPGK, T HKJMLEKHILN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x124D480", Offset = "0x124BC80", VA = "0x18124D480")]
	public void IIDOOJBFPNM(string HJCJKDOGPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x56F780", VA = "0x180570F80")]
	public Dictionary<string, object> BFPCALDOOAK()
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
