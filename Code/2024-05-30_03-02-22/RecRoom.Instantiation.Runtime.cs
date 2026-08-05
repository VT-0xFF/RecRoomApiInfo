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
public class LFLDNBKCFOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid KGAHALLNEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string APPCLABADDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int NCJJGCLIOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid EBJGKKMLCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly HNDLPIGFBJM IDIEPPELMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 HFHFPGFAPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion HFLDDHFJBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 JKDBLJBGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool AIOIEKNAOAA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6420FF0", Offset = "0x64201F0", VA = "0x186420FF0")]
	public LFLDNBKCFOJ(string HDOGLMBKHEN, Guid OEGCLLIHAPM, int GOMKBEFMAON, Guid NICCKEGEBLI, HNDLPIGFBJM OFOJGGHMDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6420E30", Offset = "0x6420030", VA = "0x186420E30")]
	public NBHPLBKPNGH GHPNENJILGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6420EF0", Offset = "0x64200F0", VA = "0x186420EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HNDLPIGFBJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> MHHJEDFOABN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6420DA0", Offset = "0x641FFA0", VA = "0x186420DA0")]
	public HNDLPIGFBJM([Optional] Dictionary<string, object> MHHJEDFOABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6420BF0", Offset = "0x641FDF0", VA = "0x186420BF0")]
	[NotNull]
	public static HNDLPIGFBJM NCHGOEFOALO(PhotonView OBGPCAOMNDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29C0CD0", Offset = "0x29BFED0", VA = "0x1829C0CD0")]
	public bool GMADCLHMMHE<T>(string MNOIAMGNLNL, [Out] T HLCKBKFCMPI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29C1600", Offset = "0x29C0800", VA = "0x1829C1600")]
	public bool LOILFHGLHIG<T>(string MNOIAMGNLNL, [Out] T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29C14A0", Offset = "0x29C06A0", VA = "0x1829C14A0")]
	public void HNJFJKPNHAB<T>(string MNOIAMGNLNL, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6420B90", Offset = "0x641FD90", VA = "0x186420B90")]
	public void BIFLKBKPGJE(string MNOIAMGNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
	public Dictionary<string, object> LOPOMHGLHID()
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
