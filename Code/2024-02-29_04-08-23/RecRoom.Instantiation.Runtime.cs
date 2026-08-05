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
public class MKHPKNOMIPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid NFLNJBLFDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string EDDPKMJEOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int LCDGHENGKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid MKCJKMELIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LNMHMOGECGL LAPGPOPNBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 CDFOMBDMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion DMOAIFFPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 BEFNNNFPHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool DILGHCEKDAI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x601A1C0", Offset = "0x6018FC0", VA = "0x18601A1C0")]
	public MKHPKNOMIPE(string PDNLHMCHEMA, Guid LHNOHNHBPBA, int KGNIAJHIEOI, Guid OMHIEBFNMIB, LNMHMOGECGL NCHOPIBIAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x601A000", Offset = "0x6018E00", VA = "0x18601A000")]
	public GFELEJKEJMO BOKPCPFKDKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x601A0C0", Offset = "0x6018EC0", VA = "0x18601A0C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LNMHMOGECGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> MGMHHCBPALH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6019F70", Offset = "0x6018D70", VA = "0x186019F70")]
	public LNMHMOGECGL([Optional] Dictionary<string, object> MGMHHCBPALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6019D60", Offset = "0x6018B60", VA = "0x186019D60")]
	[NotNull]
	public static LNMHMOGECGL FKGEFPHAJCE(PhotonView JNGHLJPLHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27A2240", Offset = "0x27A1040", VA = "0x1827A2240")]
	public bool GNMCOJGNPDP<T>(string JCMGBFKGKLO, [Out] T NKKIECLCEML) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x27A1C10", Offset = "0x27A0A10", VA = "0x1827A1C10")]
	public bool DMGEAMIKPCH<T>(string JCMGBFKGKLO, [Out] T NKKIECLCEML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27A20E0", Offset = "0x27A0EE0", VA = "0x1827A20E0")]
	public void FOBLAMHLHCD<T>(string JCMGBFKGKLO, T NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6019F10", Offset = "0x6018D10", VA = "0x186019F10")]
	public void JJGPDDBMEBN(string JCMGBFKGKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
	public Dictionary<string, object> GIFKAELCBGE()
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
