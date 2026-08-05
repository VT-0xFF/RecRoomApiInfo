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
public class LOHOGOJBAPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid AOLGOIIDHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string MGHJNLHLCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int IMLBFJMPNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid EKJNCMCNKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly OHGDDLLHECC NAOMCNKMAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 NPLDMMNBNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion LBFPAHCMHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 AKKHNKMOPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool FBHNPDEHEAC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1A61AB0", Offset = "0x1A60EB0", VA = "0x181A61AB0")]
	public LOHOGOJBAPD(string OPGDEOIEKEH, Guid KIEAFCCDKIN, int LLMNGOGCLPF, Guid NMGEKCCBBBL, OHGDDLLHECC DLDGBLGNMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1A618F0", Offset = "0x1A60CF0", VA = "0x181A618F0")]
	public DBMCMCHBCII.PCICGKDADGF NMOFDPFHNBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1A61830", Offset = "0x1A60C30", VA = "0x181A61830")]
	public MMMHJDHFKBN CIGEJMLMHKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OHGDDLLHECC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> ADCLBOEMCIK;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1A61D80", Offset = "0x1A61180", VA = "0x181A61D80")]
	public OHGDDLLHECC([Optional] Dictionary<string, object> ADCLBOEMCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A61B70", Offset = "0x1A60F70", VA = "0x181A61B70")]
	[NotNull]
	public static OHGDDLLHECC CNPEBMBOGID(PhotonView FNDIGAAAAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3216E70", Offset = "0x3216270", VA = "0x183216E70")]
	public bool MPHIBFICBKB<T>(string NPBDKCONLNC, out T FPLJCBGEJAP) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3216CD0", Offset = "0x32160D0", VA = "0x183216CD0")]
	public void CODPHMBGNGD<T>(string NPBDKCONLNC, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1A61D20", Offset = "0x1A61120", VA = "0x181A61D20")]
	public void GAMANBAONBG(string NPBDKCONLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
	public Dictionary<string, object> OCLMPECMINK()
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
