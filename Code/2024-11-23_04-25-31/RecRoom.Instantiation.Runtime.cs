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
public class OFNMBFBPNPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid NDAHELKPKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string MBOEBOAEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int DGBNIDNKIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid ENMMMHBJMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly JIEGPMEGIID AHCDGFLELPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 CNDDIEKMION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion EAGIADDGNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 LNDKEGEMBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool HBFNBLAJEGC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E25A10", Offset = "0x6E24410", VA = "0x186E25A10")]
	public OFNMBFBPNPO(string JHGFACFIHND, Guid LJBOOCHLBLB, int ODOJJMOKMPM, Guid ECEAOGOFGJH, JIEGPMEGIID FJMCAEMAMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E25850", Offset = "0x6E24250", VA = "0x186E25850")]
	public IHOBBOMLDHI MDHIKLLODKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E25910", Offset = "0x6E24310", VA = "0x186E25910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JIEGPMEGIID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> LCFFBGPKKNI;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E257C0", Offset = "0x6E241C0", VA = "0x186E257C0")]
	public JIEGPMEGIID([Optional] Dictionary<string, object> LCFFBGPKKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E255A0", Offset = "0x6E23FA0", VA = "0x186E255A0")]
	[NotNull]
	public static JIEGPMEGIID APHAEEELAAA(PhotonView EPCOPABAPDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2F431B0", Offset = "0x2F41BB0", VA = "0x182F431B0")]
	public bool HPCEHODMPGB<T>(string PNABAFEIDND, [Out] T PKCLPFEIPFH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2F43020", Offset = "0x2F41A20", VA = "0x182F43020")]
	public bool ENIFCNAMDBF<T>(string PNABAFEIDND, [Out] T PKCLPFEIPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2F42EC0", Offset = "0x2F418C0", VA = "0x182F42EC0")]
	public void CADIEIMFLMA<T>(string PNABAFEIDND, T PKCLPFEIPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E25760", Offset = "0x6E24160", VA = "0x186E25760")]
	public void PJOABDGMIKH(string PNABAFEIDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560")]
	public Dictionary<string, object> KDLKMFPCBBK()
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
