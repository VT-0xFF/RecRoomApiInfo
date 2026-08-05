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
public class GLABAKABANJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid OHHILDBBIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string ALPBFFKMOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int IBIMLMDIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid DADEPEKMDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly JNEJNCCGGAA KJEEIHMKGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 FCEPBHLPABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion NDDNKFPGBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 GLCLEPEPGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool NMNHCOIDHDD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D3AD50", Offset = "0x1D39350", VA = "0x181D3AD50")]
	public GLABAKABANJ(string IMOKOPFFOAJ, Guid NKGKKIOMKGD, int HNLOGFDIEIJ, Guid DBGPJJMMAIB, JNEJNCCGGAA GIBONFOLMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D3AAD0", Offset = "0x1D390D0", VA = "0x181D3AAD0")]
	public MEFOCEBIEBJ.EDANOOBAKEL ADIBKKNGLDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D3AC90", Offset = "0x1D39290", VA = "0x181D3AC90")]
	public PLBPFPEOBEN KJBBILIBIJJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JNEJNCCGGAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> NJGDJAEIHMK;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1D3B020", Offset = "0x1D39620", VA = "0x181D3B020")]
	public JNEJNCCGGAA([Optional] Dictionary<string, object> NJGDJAEIHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D3AE70", Offset = "0x1D39470", VA = "0x181D3AE70")]
	[NotNull]
	public static JNEJNCCGGAA GMLKJCJILEF(PhotonView EDNIAMBKPNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3081D10", Offset = "0x3080310", VA = "0x183081D10")]
	public bool IDEDABPJLGL<T>(string AIGAKEKDKHM, out T MAKFNMHIJIF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x30824D0", Offset = "0x3080AD0", VA = "0x1830824D0")]
	public void KMNEKDAGPNL<T>(string AIGAKEKDKHM, T MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D3AE10", Offset = "0x1D39410", VA = "0x181D3AE10")]
	public void EMIFMEAGDDE(string AIGAKEKDKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
	public Dictionary<string, object> GIJOEGICNKF()
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
