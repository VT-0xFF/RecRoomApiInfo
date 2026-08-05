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
public class PFIHMLGHKJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid LLIFAKJFOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string GMFIHKPMHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int FAMNJFCFBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid EDLCMCJALNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NFCHCBPPBJC PFGPHOCCJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 HBEMNPFKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion EGDBJOCCALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 NLDIAJEINPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool EAGCEKIAMJB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5842110", Offset = "0x5840D10", VA = "0x185842110")]
	public PFIHMLGHKJP(string BEFLLLDODCP, Guid JDIFONIBFHI, int GNNGIBLMLCI, Guid KNMGDDJEHIJ, NFCHCBPPBJC EKGGOHDCFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5841F60", Offset = "0x5840B60", VA = "0x185841F60")]
	public GNCHGILJCEP.JOBDNMFCEKO PGJFOFJMFHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5841EA0", Offset = "0x5840AA0", VA = "0x185841EA0")]
	public KNIDHEBNHKD BMDPOAMPGPG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NFCHCBPPBJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> EICBLPCLIAE;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5841E20", Offset = "0x5840A20", VA = "0x185841E20")]
	public NFCHCBPPBJC([Optional] Dictionary<string, object> EICBLPCLIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5841C40", Offset = "0x5840840", VA = "0x185841C40")]
	[NotNull]
	public static NFCHCBPPBJC JFHKJBBDBBG(PhotonView BDAOGBJMIGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2323460", Offset = "0x2322060", VA = "0x182323460")]
	public bool EKDAOPLAPIM<T>(string IHPCMBAPNMC, out T PDMPLJICJLE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E1FB20", Offset = "0x2E1E720", VA = "0x182E1FB20")]
	public void KCACFLLCKKN<T>(string IHPCMBAPNMC, T PDMPLJICJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5841DC0", Offset = "0x58409C0", VA = "0x185841DC0")]
	public void MAHLOMNJIKK(string IHPCMBAPNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
	public Dictionary<string, object> FFNELBPGJPG()
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
