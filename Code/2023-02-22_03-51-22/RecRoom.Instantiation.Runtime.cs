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
public class LMHNNMECCEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PMMBMKLPJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string DKDJCNNBKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int AOAMBOLALFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid GINEDABHDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ICICNMLAACJ OLJPJGIILCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 LPJKKJIJJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion HNCODGAIPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 JEECLGDGEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool FHONJNHGONF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64A1360", Offset = "0x64A0560", VA = "0x1864A1360")]
	public LMHNNMECCEL(string FMCEKOCABPG, Guid ABNJPACONCI, int MNACFINODAD, Guid DBPLFMJCACN, ICICNMLAACJ EHKMBEIKOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64A10E0", Offset = "0x64A02E0", VA = "0x1864A10E0")]
	public DEJHKECOGON.PAHGBFLJNCF AJDJDBAJFDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64A12A0", Offset = "0x64A04A0", VA = "0x1864A12A0")]
	public BLPDBKJLCGI DAHKBJGJNPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ICICNMLAACJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> BJHIBDCIHBE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64A1050", Offset = "0x64A0250", VA = "0x1864A1050")]
	public ICICNMLAACJ([Optional] Dictionary<string, object> BJHIBDCIHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64A0EA0", Offset = "0x64A00A0", VA = "0x1864A0EA0")]
	[NotNull]
	public static ICICNMLAACJ LMEBCGPFGOB(PhotonView CHOBEAJIPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x288A2D0", Offset = "0x28894D0", VA = "0x18288A2D0")]
	public bool CPKINNFJFHF<T>(string EBOEHIFNNLM, out T JFBPNBNBHOE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x288AA90", Offset = "0x2889C90", VA = "0x18288AA90")]
	public void HDECKBNAIGA<T>(string EBOEHIFNNLM, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64A0E40", Offset = "0x64A0040", VA = "0x1864A0E40")]
	public void BCBAFCFKBLF(string EBOEHIFNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C8AC0", Offset = "0x6C7CC0", VA = "0x1806C8AC0")]
	public Dictionary<string, object> CNNJKNEDONO()
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
