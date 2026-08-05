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
public class OKDACEMFJGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid OPGJIGOOMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string BPLDLPNGOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int KHCPGCBJJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid OFGBBFDHNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly OOIGEBPICIM BELEADHJHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 EFLAJPBFADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion HEFNCFMIDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 PDAOFMFPEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool BBFHENNJNPE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6062490", Offset = "0x6060E90", VA = "0x186062490")]
	public OKDACEMFJGK(string FDMNJOPCFPM, Guid JLLHPLLKMKN, int ABGOKCJOGBB, Guid ALDGECFPEKH, OOIGEBPICIM CEBLDMMCLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60622D0", Offset = "0x6060CD0", VA = "0x1860622D0")]
	public BJGJMLANHAG.KNPMACEDOIA JPMCFFFFLCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6062210", Offset = "0x6060C10", VA = "0x186062210")]
	public CMKEMJJFAOM DJPHMDHLDLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OOIGEBPICIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> CBACAFEEDLJ;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6062760", Offset = "0x6061160", VA = "0x186062760")]
	public OOIGEBPICIM([Optional] Dictionary<string, object> CBACAFEEDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6062550", Offset = "0x6060F50", VA = "0x186062550")]
	[NotNull]
	public static OOIGEBPICIM OKLDFEHDPBK(PhotonView GMLENJDKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2218670", Offset = "0x2217070", VA = "0x182218670")]
	public bool OHBNCLEBFJI<T>(string KFEMFMGCJPM, out T NKJMIDIDBOE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x22184D0", Offset = "0x2216ED0", VA = "0x1822184D0")]
	public void LMCGMFHIJLB<T>(string KFEMFMGCJPM, T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6062700", Offset = "0x6061100", VA = "0x186062700")]
	public void OMBMHDCIFDM(string KFEMFMGCJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
	public Dictionary<string, object> JHPMEEOIJDA()
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
