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
public class NIPMODLHPEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid FLCBKDNAJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PGIHLKBPCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int BBGBEKICOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid KBMBEGDOFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly MEAGKJAMDIL FAKPPDCAGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 CJKGBBPPBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion PHBMINHAFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float BLIELPCGJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool EIDOINCNEOG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D140", Offset = "0x4E7B740", VA = "0x184E7D140")]
	public NIPMODLHPEL(string DHILPHLLPPI, Guid IMCBBPBFKIB, int KBNDKGKPBMF, Guid OGMMGECOJOF, MEAGKJAMDIL OACBPHGHMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CFA0", Offset = "0x4E7B5A0", VA = "0x184E7CFA0")]
	public GJJBIOBGAMI.IBCEOOICKBO KGGCHMIKAME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CEF0", Offset = "0x4E7B4F0", VA = "0x184E7CEF0")]
	public OHLNKPALPLN IMIOJLCKIOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MEAGKJAMDIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> MBKNIJOJDHM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CE70", Offset = "0x4E7B470", VA = "0x184E7CE70")]
	public MEAGKJAMDIL([Optional] Dictionary<string, object> MBKNIJOJDHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CC90", Offset = "0x4E7B290", VA = "0x184E7CC90")]
	[NotNull]
	public static MEAGKJAMDIL FCJJBGAPBKD(PhotonView GPBCADGHJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1EF45A0", Offset = "0x1EF2BA0", VA = "0x181EF45A0")]
	public bool ACEOCCKNHLM<T>(string MKDJIBNCKNC, out T MPHFKGJNMOK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2F28780", Offset = "0x2F26D80", VA = "0x182F28780")]
	public void KJOMPIGOOHG<T>(string MKDJIBNCKNC, T MPHFKGJNMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CE10", Offset = "0x4E7B410", VA = "0x184E7CE10")]
	public void MNHCGCIEOKP(string MKDJIBNCKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
	public Dictionary<string, object> JELLIPFKEOH()
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
