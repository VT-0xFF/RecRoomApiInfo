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
public class KBNEEGLIJCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PCDLCGKJOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string GFPODGLHOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int DHHAGECLFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid OEMLHDMAOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly HHNCFHCFFKC NEMEKLGJLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 FDBNADNMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion MHMMIDFOFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 FMENFDJFDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool OICFLANMCKA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1250", Offset = "0x6BCFC50", VA = "0x186BD1250")]
	public KBNEEGLIJCA(string MAOAEMLFGPJ, Guid DOPDKMNMPEO, int NJFNMEHJEAK, Guid LLACDCKMCGB, HHNCFHCFFKC NCMAJPHCKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1090", Offset = "0x6BCFA90", VA = "0x186BD1090")]
	public NPAIFKHMPLO EJALLAJJPND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1150", Offset = "0x6BCFB50", VA = "0x186BD1150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HHNCFHCFFKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> IFGCDNBOFHI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1000", Offset = "0x6BCFA00", VA = "0x186BD1000")]
	public HHNCFHCFFKC([Optional] Dictionary<string, object> IFGCDNBOFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0E50", Offset = "0x6BCF850", VA = "0x186BD0E50")]
	[NotNull]
	public static HHNCFHCFFKC NLIECMBKBAB(PhotonView EKOKBMEDMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C96480", Offset = "0x2C94E80", VA = "0x182C96480")]
	public bool DCBHEAIHJLO<T>(string JODEIIFHAPK, [Out] T CLMKDBDPNNH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C96DB0", Offset = "0x2C957B0", VA = "0x182C96DB0")]
	public bool IJGBGHLOFMB<T>(string JODEIIFHAPK, [Out] T CLMKDBDPNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C96C50", Offset = "0x2C95650", VA = "0x182C96C50")]
	public void IDPEEMDPGBG<T>(string JODEIIFHAPK, T CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0DF0", Offset = "0x6BCF7F0", VA = "0x186BD0DF0")]
	public void MIOFMOMIMDC(string JODEIIFHAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
	public Dictionary<string, object> IGDHFNDMADA()
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
