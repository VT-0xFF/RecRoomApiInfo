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
public class PHBOOLAONDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid FNAJAGKJHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string OOKLNDGOCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int DBMGHLFMDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid MGHAJNGEFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NNKOADHECPN PCPDNEHJLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 CIKPOOKMMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion KGONPCAJEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 HODIAEGDBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool LKCGCIGPOFP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61B1D30", Offset = "0x61B0D30", VA = "0x1861B1D30")]
	public PHBOOLAONDI(string KCFPNOGLDCA, Guid HGMNJEMGBPD, int BFFODNHEEBM, Guid MFKOMJODHGJ, NNKOADHECPN DDDGKPAJHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61B1B70", Offset = "0x61B0B70", VA = "0x1861B1B70")]
	public GIACEKKMFGD KHLLLMKFKFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61B1C30", Offset = "0x61B0C30", VA = "0x1861B1C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NNKOADHECPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> KHHHGIFJDGF;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61B1AE0", Offset = "0x61B0AE0", VA = "0x1861B1AE0")]
	public NNKOADHECPN([Optional] Dictionary<string, object> KHHHGIFJDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61B18D0", Offset = "0x61B08D0", VA = "0x1861B18D0")]
	[NotNull]
	public static NNKOADHECPN EGELLIDJEIN(PhotonView LAOJDFENHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28F9790", Offset = "0x28F8790", VA = "0x1828F9790")]
	public bool IJFOADKACJF<T>(string IPAJBJLLPIJ, [Out] T CFJDHAGGAJO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28F9600", Offset = "0x28F8600", VA = "0x1828F9600")]
	public bool DHCFPPGAILP<T>(string IPAJBJLLPIJ, [Out] T CFJDHAGGAJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28F9F50", Offset = "0x28F8F50", VA = "0x1828F9F50")]
	public void PCMENIKJJKG<T>(string IPAJBJLLPIJ, T CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61B1A80", Offset = "0x61B0A80", VA = "0x1861B1A80")]
	public void JOBFLKKFIPF(string IPAJBJLLPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
	public Dictionary<string, object> ECNIHFBDMOD()
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
