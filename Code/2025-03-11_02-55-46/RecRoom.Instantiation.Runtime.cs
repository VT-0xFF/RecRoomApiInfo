using System;
using System.Reflection;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NFPJIIKLFJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid NPOBKHEBPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PFOFAKHJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int FMJIPJJHLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid LPNHEMLKGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ANCOAIADDGI KIMLHMBKEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 LLLAMAJMODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion ANFMFACGGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 OJKGCKCDMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool MPHICOCNGED;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7622FA0", Offset = "0x76223A0", VA = "0x187622FA0")]
	public NFPJIIKLFJK(string AHLILHCEMPL, Guid KOBEAEPBFGJ, int CACMEMJABAN, Guid MMHINFKMJNK, ANCOAIADDGI KJPACHHMIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7622DF0", Offset = "0x76221F0", VA = "0x187622DF0")]
	public NBFMPKGMPHM ANFOEMPDDJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7622EA0", Offset = "0x76222A0", VA = "0x187622EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KDFANAPPNGM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7622C10", Offset = "0x7622010", VA = "0x187622C10")]
	public static bool DGLBCLAIKEA(this PhotonView GOGEGHBLCKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7622C70", Offset = "0x7622070", VA = "0x187622C70")]
	public static object[] IANKHHMJMIH(this PhotonView GOGEGHBLCKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7622C90", Offset = "0x7622090", VA = "0x187622C90")]
	public static ViewId KEDLEANAMOO(this PhotonView GOGEGHBLCKJ)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7622D30", Offset = "0x7622130", VA = "0x187622D30")]
	public static ANCOAIADDGI PGAPJCFDPNA(this PhotonView GOGEGHBLCKJ)
	{
		return default(ANCOAIADDGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7622C40", Offset = "0x7622040", VA = "0x187622C40")]
	public static ANCOAIADDGI HHIOELDHADA(this BNIIMGHMBPK GAPCIOOOOMF)
	{
		return default(ANCOAIADDGI);
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
