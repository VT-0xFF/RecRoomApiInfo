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
public class ALLKHDEPJBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid HIIFEHNOOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FHKFIGDGHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int JGKOCNJOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid HENACBOEDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LNBGPKOFJNK LJMONLEIADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 NOBECIHIBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion KCACHGKLDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 OBNLFLIHJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool PIICHMGDJGA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D80190", Offset = "0x6D7F590", VA = "0x186D80190")]
	public ALLKHDEPJBN(string HBGOACJMLDJ, Guid KEAOGEPDIKM, int KINHJNBFHPE, Guid OIFBADDAHOJ, LNBGPKOFJNK GEDFHEIHEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D7FFD0", Offset = "0x6D7F3D0", VA = "0x186D7FFD0")]
	public KJACEEEAGJG CIDPDFIJKDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D80090", Offset = "0x6D7F490", VA = "0x186D80090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LNBGPKOFJNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> HLDDCNJIMIN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D804D0", Offset = "0x6D7F8D0", VA = "0x186D804D0")]
	public LNBGPKOFJNK([Optional] Dictionary<string, object> HLDDCNJIMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D80310", Offset = "0x6D7F710", VA = "0x186D80310")]
	[NotNull]
	public static LNBGPKOFJNK HOCMCNGCKAF(PhotonView PIBNKMCBNKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4E50", Offset = "0x2FA4250", VA = "0x182FA4E50")]
	public bool NKKJANMEMGN<T>(string PBFBBOFLBNL, [Out] T PFKKDHPJFEH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4820", Offset = "0x2FA3C20", VA = "0x182FA4820")]
	public bool LMKOFBLAKGC<T>(string PBFBBOFLBNL, [Out] T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4CF0", Offset = "0x2FA40F0", VA = "0x182FA4CF0")]
	public void NBJJIKECOBK<T>(string PBFBBOFLBNL, T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D802B0", Offset = "0x6D7F6B0", VA = "0x186D802B0")]
	public void BIJNEFLCHFA(string PBFBBOFLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
	public Dictionary<string, object> JMLMCOPDBKH()
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
