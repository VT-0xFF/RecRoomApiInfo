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
public class AMEMFHDIDKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid BHIKAOAFAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string POJHMCDGEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int HLOHJAOFCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid OAKPAJHGACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly CKHKHLBEFEJ GKOJLIJGJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 BKEJMFAHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion ONICOCGNJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 GBDCCKDKPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool NJBOGKNHOAD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6156D70", Offset = "0x6155F70", VA = "0x186156D70")]
	public AMEMFHDIDKD(string OGBJKBBFCCI, Guid EKNBFNOKDLG, int HGEELPDKDKO, Guid MAJPFPBMDGN, CKHKHLBEFEJ CFBAFANLBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6156BB0", Offset = "0x6155DB0", VA = "0x186156BB0")]
	public LPPGCCDNGDO FLJKHIFNBNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6156C70", Offset = "0x6155E70", VA = "0x186156C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CKHKHLBEFEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> HLLJJCEMFCF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61570A0", Offset = "0x61562A0", VA = "0x1861570A0")]
	public CKHKHLBEFEJ([Optional] Dictionary<string, object> HLLJJCEMFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6156EF0", Offset = "0x61560F0", VA = "0x186156EF0")]
	[NotNull]
	public static CKHKHLBEFEJ KMIINKICOLC(PhotonView GIKBHIGDMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26CA8C0", Offset = "0x26C9AC0", VA = "0x1826CA8C0")]
	public bool JNNFGFKBPPN<T>(string GHBNLDGJPCB, [Out] T EKDDCPALANJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26CA290", Offset = "0x26C9490", VA = "0x1826CA290")]
	public bool GOFMAAJKAED<T>(string GHBNLDGJPCB, [Out] T EKDDCPALANJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x26CA760", Offset = "0x26C9960", VA = "0x1826CA760")]
	public void HPPDEOLAJNB<T>(string GHBNLDGJPCB, T EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6156E90", Offset = "0x6156090", VA = "0x186156E90")]
	public void FBCLMIGJMFH(string GHBNLDGJPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
	public Dictionary<string, object> DIGFDKECKNP()
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
