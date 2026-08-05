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
public class FIPIAHAGJDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid KPLEFOEOLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PFHNBNOKONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int MACDFFPKBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid PMCIJDDLDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PDHLGOEGHHH HKHFCNBPNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 BFENJPJIDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion ILMJFGHLIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 DJBGAGHAMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool OKNBAHFMHIO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD320", Offset = "0x6EDC320", VA = "0x186EDD320")]
	public FIPIAHAGJDH(string IHNJPHKOIIF, Guid AMNOLMOJDEK, int JMLMKGCJMOH, Guid JBNAGLIFCFP, PDHLGOEGHHH EEHHDMNGELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD160", Offset = "0x6EDC160", VA = "0x186EDD160")]
	public GOOIDFJKBHH ODMPMFOMFNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD220", Offset = "0x6EDC220", VA = "0x186EDD220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PDHLGOEGHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> GIBPIDGLFKE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD660", Offset = "0x6EDC660", VA = "0x186EDD660")]
	public PDHLGOEGHHH([Optional] Dictionary<string, object> GIBPIDGLFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD4A0", Offset = "0x6EDC4A0", VA = "0x186EDD4A0")]
	[NotNull]
	public static PDHLGOEGHHH IDHPFPMGDBJ(PhotonView NJFNPGALOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x31522B0", Offset = "0x31512B0", VA = "0x1831522B0")]
	public bool JIBJJFGCKGK<T>(string MLAECOMLIEC, [Out] T BJDKOHEGDOK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3152730", Offset = "0x3151730", VA = "0x183152730")]
	public bool KBPNIJINDEE<T>(string MLAECOMLIEC, [Out] T BJDKOHEGDOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3152C00", Offset = "0x3151C00", VA = "0x183152C00")]
	public void NONCGFKLPGD<T>(string MLAECOMLIEC, T BJDKOHEGDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD440", Offset = "0x6EDC440", VA = "0x186EDD440")]
	public void CAKBCGBONLK(string MLAECOMLIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
	public Dictionary<string, object> ANBBFIIGOLF()
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
