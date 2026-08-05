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
public class GHKBMIJIEFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid CEABLLIGKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string JJKIGEHMPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int KKILICINKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid AFNFIHLMOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly FGLKJMJLGFA KDHBINKEFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 GCHGGAPEHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion EHEOBFEBFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 PMDLMCAOIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool JKEJDHKBAKM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66A84F0", Offset = "0x66A74F0", VA = "0x1866A84F0")]
	public GHKBMIJIEFC(string ANCBAFIJPAE, Guid ADDAMFLPMHD, int FEKBFPFDHGN, Guid GFEMHGFNNBB, FGLKJMJLGFA KLHBFIIKCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66A8330", Offset = "0x66A7330", VA = "0x1866A8330")]
	public OJLKPBHKFGE.KAKJCKCEBKO MMLALPJBAFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66A8270", Offset = "0x66A7270", VA = "0x1866A8270")]
	public MCHFMHNOKME FJNPPJKBBLF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FGLKJMJLGFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> LOACFEDEHCH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x66A81E0", Offset = "0x66A71E0", VA = "0x1866A81E0")]
	public FGLKJMJLGFA([Optional] Dictionary<string, object> LOACFEDEHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66A7FD0", Offset = "0x66A6FD0", VA = "0x1866A7FD0")]
	[NotNull]
	public static FGLKJMJLGFA OMNFIKNKDNL(PhotonView FKGNAFCFFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x234D7A0", Offset = "0x234C7A0", VA = "0x18234D7A0")]
	public bool OHBANFGHGGE<T>(string EBOIOCBODNI, out T KPPLMEOMNGF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x234D600", Offset = "0x234C600", VA = "0x18234D600")]
	public void JPNFGACMGOG<T>(string EBOIOCBODNI, T KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66A8180", Offset = "0x66A7180", VA = "0x1866A8180")]
	public void PMMODKPOELK(string EBOIOCBODNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
	public Dictionary<string, object> KDHLHFGFCHI()
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
