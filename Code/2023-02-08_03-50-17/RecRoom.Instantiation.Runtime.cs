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
public class PAKMCLICLJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid LMGGEEGCKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string LLAGLAEEHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int EIJODMMENMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid GEDDHAPKCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LKKFINJGLGA KGHNCPHCGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 BBPKPLFFECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion MKOCKAEHCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 NPHINNAECKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool ANCJPDILCHI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x21D8CE0", Offset = "0x21D7AE0", VA = "0x1821D8CE0")]
	public PAKMCLICLJK(string JHKCJACNFGI, Guid KLMNBPHPHAA, int EDECNBNDAIL, Guid OAOCGBBNGNN, LKKFINJGLGA HFAKMODGCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x21D8A60", Offset = "0x21D7860", VA = "0x1821D8A60")]
	public APAABDEMAIJ.NKENOOEFBNP IBBCFIJAKDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21D8C20", Offset = "0x21D7A20", VA = "0x1821D8C20")]
	public PENMPBOLEME IEMOFHANDCB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LKKFINJGLGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> GOFPKGAPNJB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x21D89D0", Offset = "0x21D77D0", VA = "0x1821D89D0")]
	public LKKFINJGLGA([Optional] Dictionary<string, object> GOFPKGAPNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x21D87C0", Offset = "0x21D75C0", VA = "0x1821D87C0")]
	[NotNull]
	public static LKKFINJGLGA JCANMIFFFGD(PhotonView IPAJFMPKCLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3C74E80", Offset = "0x3C73C80", VA = "0x183C74E80")]
	public bool ICLIDKMCOMO<T>(string CKMEBFKEHMO, out T DPJGMDFEIDL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3C75640", Offset = "0x3C74440", VA = "0x183C75640")]
	public void LMMFIPJEJPN<T>(string CKMEBFKEHMO, T DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x21D8970", Offset = "0x21D7770", VA = "0x1821D8970")]
	public void PPEAGPDBOCM(string CKMEBFKEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F10", Offset = "0x6E5D10", VA = "0x1806E6F10")]
	public Dictionary<string, object> GEKCLOFMLLH()
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
