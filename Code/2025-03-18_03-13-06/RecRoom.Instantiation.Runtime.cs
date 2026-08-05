using System;
using System.Reflection;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LFFBJMMABAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid DPBIFDIBNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string NEOFMDEACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int HBALPGKEEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid OHDKIONLAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly BNLAMAEAGEL NGIGLJNDMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 LAHGFMKGHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion NEDOKMKIJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 KEDFJDMFMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool LAKOJJHECJE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7634F20", Offset = "0x7634120", VA = "0x187634F20")]
	public LFFBJMMABAE(string LHOGCPEJPMP, Guid NGKBNOIMNFJ, int JKCEJCDDBEE, Guid NDFBNLGMNMN, BNLAMAEAGEL OOHNINNBFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7634D70", Offset = "0x7633F70", VA = "0x187634D70")]
	public FEEMFPCJHHD PMAEDHCDBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7634E20", Offset = "0x7634020", VA = "0x187634E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MPFBCBPNLEB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7635060", Offset = "0x7634260", VA = "0x187635060")]
	public static bool DJAHFPBACKE(this PhotonView JEEIAMNAPAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7635040", Offset = "0x7634240", VA = "0x187635040")]
	public static object[] BOFEAKAIBFB(this PhotonView JEEIAMNAPAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7635150", Offset = "0x7634350", VA = "0x187635150")]
	public static ViewId LMHBELLEGLI(this PhotonView JEEIAMNAPAO)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7635090", Offset = "0x7634290", VA = "0x187635090")]
	public static BNLAMAEAGEL FCIEGJKPPLC(this PhotonView JEEIAMNAPAO)
	{
		return default(BNLAMAEAGEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x76351F0", Offset = "0x76343F0", VA = "0x1876351F0")]
	public static BNLAMAEAGEL LNNLOEFODDG(this NGFMFFCDFEF BNHLGDBCCDH)
	{
		return default(BNLAMAEAGEL);
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
