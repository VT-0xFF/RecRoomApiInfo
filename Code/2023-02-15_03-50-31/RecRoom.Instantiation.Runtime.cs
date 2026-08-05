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
	[Cpp2IlInjected.Address(RVA = "0x649D2F0", Offset = "0x649C6F0", VA = "0x18649D2F0")]
	public LMHNNMECCEL(string FMCEKOCABPG, Guid ABNJPACONCI, int MNACFINODAD, Guid DBPLFMJCACN, ICICNMLAACJ EHKMBEIKOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x649D070", Offset = "0x649C470", VA = "0x18649D070")]
	public DEJHKECOGON.PAHGBFLJNCF AJDJDBAJFDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x649D230", Offset = "0x649C630", VA = "0x18649D230")]
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
	[Cpp2IlInjected.Address(RVA = "0x649CFE0", Offset = "0x649C3E0", VA = "0x18649CFE0")]
	public ICICNMLAACJ([Optional] Dictionary<string, object> BJHIBDCIHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x649CE30", Offset = "0x649C230", VA = "0x18649CE30")]
	[NotNull]
	public static ICICNMLAACJ LMEBCGPFGOB(PhotonView CHOBEAJIPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x35DAAA0", Offset = "0x35D9EA0", VA = "0x1835DAAA0")]
	public bool CPKINNFJFHF<T>(string EBOEHIFNNLM, out T JFBPNBNBHOE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x35DB260", Offset = "0x35DA660", VA = "0x1835DB260")]
	public void HDECKBNAIGA<T>(string EBOEHIFNNLM, T JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x649CDD0", Offset = "0x649C1D0", VA = "0x18649CDD0")]
	public void BCBAFCFKBLF(string EBOEHIFNNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E40", Offset = "0x6E1240", VA = "0x1806E1E40")]
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
