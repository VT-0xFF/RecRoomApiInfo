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
public class CPCEDMAKGGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid LEJGGFELPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string MBGCHAPEKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int FOEKJONEEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid GHCGDPEJOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly BGNAGCPOAMI GCLINPNPCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 LCAOANGMOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion DFHDEEKICLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float GLKFEOODFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool IFNCPPDJFJD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4F00290", Offset = "0x4EFEA90", VA = "0x184F00290")]
	public CPCEDMAKGGD(string ALEIHJAKKGD, Guid FFAANAENAML, int LEFMFDBDGMP, Guid GLJNGFJLLCN, BGNAGCPOAMI GADMANLNNBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F00040", Offset = "0x4EFE840", VA = "0x184F00040")]
	public BPFBKAGIBCO.AECLEJDOEEK FEFALDFFAHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4F001E0", Offset = "0x4EFE9E0", VA = "0x184F001E0")]
	public LINMNHCNCKB FFOBCADAPIP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BGNAGCPOAMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> ACNFLAOBOOD;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4EFFFC0", Offset = "0x4EFE7C0", VA = "0x184EFFFC0")]
	public BGNAGCPOAMI([Optional] Dictionary<string, object> ACNFLAOBOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4EFFDE0", Offset = "0x4EFE5E0", VA = "0x184EFFDE0")]
	[NotNull]
	public static BGNAGCPOAMI EJCGHGKAIDJ(PhotonView HGGDHHFLAOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x23E90A0", Offset = "0x23E78A0", VA = "0x1823E90A0")]
	public bool OADACMKKJNG<T>(string BJKKIOODGOA, out T MFBIHMKFNKA) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D25680", Offset = "0x1D23E80", VA = "0x181D25680")]
	public void GCLFAKHIAMJ<T>(string BJKKIOODGOA, T MFBIHMKFNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4EFFF60", Offset = "0x4EFE760", VA = "0x184EFFF60")]
	public void JPAMCOIJOBL(string BJKKIOODGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5611D0", Offset = "0x55F9D0", VA = "0x1805611D0")]
	public Dictionary<string, object> MKPPAMHLABC()
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
