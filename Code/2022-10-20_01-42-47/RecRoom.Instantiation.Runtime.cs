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
public class CDDJOMAFKBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid BMBNNACBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PJCOOJIEIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int ABFEIPBGBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid LEFJNNEOEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly EJNCMODAPKB DBENIAMFFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 DIMOLIPIEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion INDDMCHIJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 JPODFEPGFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool NJIIGDDBPAB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E96AB0", Offset = "0x5E958B0", VA = "0x185E96AB0")]
	public CDDJOMAFKBB(string FAOEKMGHFEI, Guid OKKDHDPDHJB, int LKLPPCJNEMI, Guid GLLAKBCFOEL, EJNCMODAPKB AJGCHFLPGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E968F0", Offset = "0x5E956F0", VA = "0x185E968F0")]
	public BAGIOHKLHDP.PNGGPKPOIGL PIGHPAOGHPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E96830", Offset = "0x5E95630", VA = "0x185E96830")]
	public KJLHJDCEJFL BPDECDNEBBP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EJNCMODAPKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> MOHBLMMOAHH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E96D80", Offset = "0x5E95B80", VA = "0x185E96D80")]
	public EJNCMODAPKB([Optional] Dictionary<string, object> MOHBLMMOAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E96BD0", Offset = "0x5E959D0", VA = "0x185E96BD0")]
	[NotNull]
	public static EJNCMODAPKB ONAMEEPGMNB(PhotonView LFIMBOIOPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D3F0", Offset = "0x1F2C1F0", VA = "0x181F2D3F0")]
	public bool CECEMJJAJEO<T>(string CCJNKBLKLDJ, out T IGJPNMBCJPK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1F2DBB0", Offset = "0x1F2C9B0", VA = "0x181F2DBB0")]
	public void PIGMJENILDA<T>(string CCJNKBLKLDJ, T IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E96B70", Offset = "0x5E95970", VA = "0x185E96B70")]
	public void AKJLIPOIGHF(string CCJNKBLKLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x658AC0", Offset = "0x6578C0", VA = "0x180658AC0")]
	public Dictionary<string, object> KPIPJCNEHFF()
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
