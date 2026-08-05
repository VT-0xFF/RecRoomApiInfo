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
public class LMLIDGAMPBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid IDPOKLIIPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FEKAAOPPMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int JFCFBGDFCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid POJJJKNFENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LIPLIBPIFHA GBHHKKEMEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 KPHHODPHKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion PGPJPPIBKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 GBOHJJOBPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool CDIOJLHEKGG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4211170", Offset = "0x420F970", VA = "0x184211170")]
	public LMLIDGAMPBL(string IJIIDLMJDKB, Guid LGPLJNDEOBN, int JNJJIEPFMIF, Guid HAPDIENBNEC, LIPLIBPIFHA JOMEFKLBLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4210F00", Offset = "0x420F700", VA = "0x184210F00")]
	public FBNNHOJBLCC.NKKJPGHHOMM EFLBCKIFDKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x42110B0", Offset = "0x420F8B0", VA = "0x1842110B0")]
	public KCJFEENMBCC NCHDMHOAGLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LIPLIBPIFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> PPLKEEHGHOA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4210E80", Offset = "0x420F680", VA = "0x184210E80")]
	public LIPLIBPIFHA([Optional] Dictionary<string, object> PPLKEEHGHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4210CA0", Offset = "0x420F4A0", VA = "0x184210CA0")]
	[NotNull]
	public static LIPLIBPIFHA BDLAAEGBBOP(PhotonView FMAOAOODAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xF9FFA0", Offset = "0xF9E7A0", VA = "0x180F9FFA0")]
	public bool PJOHNGKNBEM<T>(string BAGMDNPKAJL, out T CJMMBFLIBMO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xC60000", Offset = "0xC5E800", VA = "0x180C60000")]
	public void HEMBJNPDPPJ<T>(string BAGMDNPKAJL, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4210E20", Offset = "0x420F620", VA = "0x184210E20")]
	public void NHIAFFMKOAF(string BAGMDNPKAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
	public Dictionary<string, object> BIJKOILFJHJ()
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
