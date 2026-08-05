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
public class HGHMFMGLAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid JNBFBBNBMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string GKCIPCFCMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int LBMCJOJGJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid LJFCJOMDJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NJEJAGLLIJJ CDGGLHMCILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 COMGINPGKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion NLHMOIBBBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 LDDDMLFNCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool JKLELBEILGO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x663A140", Offset = "0x6638F40", VA = "0x18663A140")]
	public HGHMFMGLAPE(string EELPCBACAFO, Guid FAMEHNHMBFD, int OPGLDECJDGL, Guid MEJNBACMBLB, NJEJAGLLIJJ MOJNNHCAHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6639F80", Offset = "0x6638D80", VA = "0x186639F80")]
	public IHGAJNLLPNL.DIJMCOFPLJH GHONJLDPLPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6639EC0", Offset = "0x6638CC0", VA = "0x186639EC0")]
	public EEBBLOPNBIC DJLPNEHIHPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NJEJAGLLIJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> IJEFCBCEOFM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x663A410", Offset = "0x6639210", VA = "0x18663A410")]
	public NJEJAGLLIJJ([Optional] Dictionary<string, object> IJEFCBCEOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x663A260", Offset = "0x6639060", VA = "0x18663A260")]
	[NotNull]
	public static NJEJAGLLIJJ KKLECCKHIOI(PhotonView MECIOPPHKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x315B1E0", Offset = "0x3159FE0", VA = "0x18315B1E0")]
	public bool AMKBCCEHNAL<T>(string ANFHHLAHMJD, out T NLHFEJHKLAH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x315B9A0", Offset = "0x315A7A0", VA = "0x18315B9A0")]
	public void NIPKJFNBLBF<T>(string ANFHHLAHMJD, T NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x663A200", Offset = "0x6639000", VA = "0x18663A200")]
	public void IHKCCNMHHEB(string ANFHHLAHMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
	public Dictionary<string, object> AMBNNFIMAID()
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
