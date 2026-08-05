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
public class AADBGEBFFPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid NKCAHCFEPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FKJJGKIGADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int EGLEGLANCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid GFLPGDOBACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly AMJILMEAFOK IJCEHCMHKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 MLELCAAHFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion MPKKDIEJJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 GAANLOFIIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool PKFHGJCFNJM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD0E0", Offset = "0x5DFBEE0", VA = "0x185DFD0E0")]
	public AADBGEBFFPE(string PHPPAMIKEEH, Guid CPMOBINJIJA, int JPONBKLBCFE, Guid KIJHFLMGJOM, AMJILMEAFOK LPKDELMBFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCF20", Offset = "0x5DFBD20", VA = "0x185DFCF20")]
	public EDJEMAPGLIL GMNIFCDJAEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCFE0", Offset = "0x5DFBDE0", VA = "0x185DFCFE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AMJILMEAFOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> BKPGEKMDMBG;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD410", Offset = "0x5DFC210", VA = "0x185DFD410")]
	public AMJILMEAFOK([Optional] Dictionary<string, object> BKPGEKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD260", Offset = "0x5DFC060", VA = "0x185DFD260")]
	[NotNull]
	public static AMJILMEAFOK EPBDGCHLOLJ(PhotonView NABGHGKJIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B12740", Offset = "0x2B11540", VA = "0x182B12740")]
	public bool OLBECDHEMJL<T>(string GAMCILOFBAF, [Out] T PHPDIJICBJO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B12110", Offset = "0x2B10F10", VA = "0x182B12110")]
	public bool BODDMJBFILN<T>(string GAMCILOFBAF, [Out] T PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B125E0", Offset = "0x2B113E0", VA = "0x182B125E0")]
	public void CCOBHHAAMMF<T>(string GAMCILOFBAF, T PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD200", Offset = "0x5DFC000", VA = "0x185DFD200")]
	public void BFKGBCINJJC(string GAMCILOFBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x770F10", Offset = "0x76FD10", VA = "0x180770F10")]
	public Dictionary<string, object> FAANPLPEFIM()
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
