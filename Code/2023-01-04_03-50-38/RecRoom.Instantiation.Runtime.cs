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
public class ANABMJHNMOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid EAFIIEPKKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string ILMICKGAFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int BEICAEMCDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid BHINOLJMCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GPPOFCHIPML PMAOEPNDGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 GLGEMPIIFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion JMIAJHCHIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 PEOCLGMJNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool BAFPPLINNAH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60A5160", Offset = "0x60A4560", VA = "0x1860A5160")]
	public ANABMJHNMOB(string AAGKJCIKDND, Guid NMPMIKLJFFM, int IAAFAEHGGJP, Guid AIMIPICPBAN, GPPOFCHIPML BPFHAFDIDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60A4EE0", Offset = "0x60A42E0", VA = "0x1860A4EE0")]
	public NEFGHGCHJMG.OOBEFHBLGFC FPFKOOADHLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60A50A0", Offset = "0x60A44A0", VA = "0x1860A50A0")]
	public PFMGIANNEAD NNGEFBNFFGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GPPOFCHIPML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> KMCEDPBJJHN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60A5430", Offset = "0x60A4830", VA = "0x1860A5430")]
	public GPPOFCHIPML([Optional] Dictionary<string, object> KMCEDPBJJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60A5280", Offset = "0x60A4680", VA = "0x1860A5280")]
	[NotNull]
	public static GPPOFCHIPML MHCDNCJCNNF(PhotonView ANICJOOMAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1F70D60", Offset = "0x1F70160", VA = "0x181F70D60")]
	public bool GAMCGCGFADK<T>(string FOJIGKKHICE, out T IGDJJEECDAF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1F71520", Offset = "0x1F70920", VA = "0x181F71520")]
	public void KNBGLHDOKIA<T>(string FOJIGKKHICE, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60A5220", Offset = "0x60A4620", VA = "0x1860A5220")]
	public void GKDAOIMBAHJ(string FOJIGKKHICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
	public Dictionary<string, object> IMFFEMIEJKM()
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
