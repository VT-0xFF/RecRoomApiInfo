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
public class ILOAOHHNKFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid AENCMEKEJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string KHOHKJDBBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int CLELCGBKEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid BDDAMPMCHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly EIEFMCHKIKF BFOPLJNPNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 AFLOHMGJCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion LLPNDHMIBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 DGNEJMALDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool IMDEJMPFGJG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C90BD0", Offset = "0x5C8FFD0", VA = "0x185C90BD0")]
	public ILOAOHHNKFP(string HFCKFJICBCH, Guid CNAHBEBBLDG, int HIHGKECJEOM, Guid IDNDMAONENM, EIEFMCHKIKF NMKMLHDHLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C90A10", Offset = "0x5C8FE10", VA = "0x185C90A10")]
	public NCBNEKFGEHD DBJNLNIKBGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C90AD0", Offset = "0x5C8FED0", VA = "0x185C90AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EIEFMCHKIKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> FKDCCCKBBKD;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5C90980", Offset = "0x5C8FD80", VA = "0x185C90980")]
	public EIEFMCHKIKF([Optional] Dictionary<string, object> FKDCCCKBBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C90770", Offset = "0x5C8FB70", VA = "0x185C90770")]
	[NotNull]
	public static EIEFMCHKIKF BDDAJOPAEIL(PhotonView AMJJOGJHMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22552F0", Offset = "0x22546F0", VA = "0x1822552F0")]
	public bool IEDNKFHOGLK<T>(string DGCJCBHPPBD, [Out] T EOHMJBFGDPD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2255770", Offset = "0x2254B70", VA = "0x182255770")]
	public bool KGENMDBKOHE<T>(string DGCJCBHPPBD, [Out] T EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2255190", Offset = "0x2254590", VA = "0x182255190")]
	public void GMFKOPHMECD<T>(string DGCJCBHPPBD, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C90920", Offset = "0x5C8FD20", VA = "0x185C90920")]
	public void BLFHNKIOGCM(string DGCJCBHPPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
	public Dictionary<string, object> CMFPIAKMCBG()
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
