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
public class KADHOLFHAKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid EPMHKGLIMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string HPNIKHKGNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int GOMHGMKMGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid AGEJBGIKBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly MMFLMKPLGPC DJCFGLOLKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 CMIONGHAGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion HMMDLPIJNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 NAKLDIOMBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool BFAGGHDEFBI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F8F0", Offset = "0x6F7E0F0", VA = "0x186F7F8F0")]
	public KADHOLFHAKF(string GGLFPAKLDNL, Guid JCECGOJINOM, int EKPHHOLCOPO, Guid HHGNDGOIHEP, MMFLMKPLGPC KGKHHJHNDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F730", Offset = "0x6F7DF30", VA = "0x186F7F730")]
	public JKIMGDGHAED KNAAMPKDMJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F7F7F0", Offset = "0x6F7DFF0", VA = "0x186F7F7F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MMFLMKPLGPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> FJOMAEAJCJA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FC30", Offset = "0x6F7E430", VA = "0x186F7FC30")]
	public MMFLMKPLGPC([Optional] Dictionary<string, object> FJOMAEAJCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FA70", Offset = "0x6F7E270", VA = "0x186F7FA70")]
	[NotNull]
	public static MMFLMKPLGPC LLBOANKEEEP(PhotonView AHOKJACJFBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3166E20", Offset = "0x3165620", VA = "0x183166E20")]
	public bool HDDNHEKKGGH<T>(string KCGKBDGKIOP, [Out] T INDENPJBLHO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3167740", Offset = "0x3165F40", VA = "0x183167740")]
	public bool PKCBJJNIPIC<T>(string KCGKBDGKIOP, [Out] T INDENPJBLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x31675E0", Offset = "0x3165DE0", VA = "0x1831675E0")]
	public void KLHHFEENEBM<T>(string KCGKBDGKIOP, T INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F7FA10", Offset = "0x6F7E210", VA = "0x186F7FA10")]
	public void CGFLGFPAOEK(string KCGKBDGKIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
	public Dictionary<string, object> KKDIDEMGCJF()
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
