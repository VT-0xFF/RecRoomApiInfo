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
public class ADINIACMIJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid CHEFBFIHFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string NCGKNKLMJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int BFFKBOLIGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid JBNKBFFELBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GJHANAJDLJA OBCILKFJMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 EHFBMINIGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion BHOIDFFDPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 CCGIGJECGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool GELAMOPKKHB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B92A10", Offset = "0x6B91010", VA = "0x186B92A10")]
	public ADINIACMIJA(string JOGIMNBNJJJ, Guid NFNEOPHONAC, int CCBPLNOKOOM, Guid HDMMLBENEIG, GJHANAJDLJA CKPOIFPIBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B92850", Offset = "0x6B90E50", VA = "0x186B92850")]
	public DOEGOLPCMBN JEHNOKMAJHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B92910", Offset = "0x6B90F10", VA = "0x186B92910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GJHANAJDLJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> FDDKPAGKIOP;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B92D40", Offset = "0x6B91340", VA = "0x186B92D40")]
	public GJHANAJDLJA([Optional] Dictionary<string, object> FDDKPAGKIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B92B30", Offset = "0x6B91130", VA = "0x186B92B30")]
	[NotNull]
	public static GJHANAJDLJA FKLOIKKNAGH(PhotonView NKLHHJOEDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CC0CC0", Offset = "0x2CBF2C0", VA = "0x182CC0CC0")]
	public bool LAFFHOKCOBI<T>(string LFOBGDLOPID, [Out] T KLABJGGMBGH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2CC1140", Offset = "0x2CBF740", VA = "0x182CC1140")]
	public bool OIMFOKBMHMB<T>(string LFOBGDLOPID, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2CC0B60", Offset = "0x2CBF160", VA = "0x182CC0B60")]
	public void ENCKAHEIPGI<T>(string LFOBGDLOPID, T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B92CE0", Offset = "0x6B912E0", VA = "0x186B92CE0")]
	public void MBEEDABKNGP(string LFOBGDLOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
	public Dictionary<string, object> HFOAHDOEEKE()
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
