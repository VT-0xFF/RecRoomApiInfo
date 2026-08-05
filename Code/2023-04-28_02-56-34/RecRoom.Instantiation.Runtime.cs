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
public class GILOJIOAKMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid FFHFNNCNPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string OOKDMAHOPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int CGHBFEFCMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid ILDJJKJEBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly KGECCBMEJNE BFGAEGLFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 ONLIEKELHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion FJOFOBDGDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 GIDKIJHPLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool INBIPONBOGD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A16470", Offset = "0x6A14E70", VA = "0x186A16470")]
	public GILOJIOAKMI(string KJMIGPLGEHH, Guid OHCLLGIGLFE, int ODAPACIOJEN, Guid JNOJMCDAKFA, KGECCBMEJNE KFPGAMMPPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A162B0", Offset = "0x6A14CB0", VA = "0x186A162B0")]
	public NFNMGBBEDLH.IKIBDHJJKKJ KLCHDGCPOFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A161F0", Offset = "0x6A14BF0", VA = "0x186A161F0")]
	public LMNMBNFBNEC IENMKJOGDKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KGECCBMEJNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> BLGEAPIIGNO;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A16740", Offset = "0x6A15140", VA = "0x186A16740")]
	public KGECCBMEJNE([Optional] Dictionary<string, object> BLGEAPIIGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A16590", Offset = "0x6A14F90", VA = "0x186A16590")]
	[NotNull]
	public static KGECCBMEJNE GFGGJELJDJM(PhotonView KANBPIJHFNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24BD6E0", Offset = "0x24BC0E0", VA = "0x1824BD6E0")]
	public bool DJKANKJNGBD<T>(string OGFDNCPKECB, out T LPJDDLMPNCG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24BDEA0", Offset = "0x24BC8A0", VA = "0x1824BDEA0")]
	public void EFMALMFMJGL<T>(string OGFDNCPKECB, T LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A16530", Offset = "0x6A14F30", VA = "0x186A16530")]
	public void FJEBMLODAAK(string OGFDNCPKECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
	public Dictionary<string, object> FJPGFILAKHC()
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
