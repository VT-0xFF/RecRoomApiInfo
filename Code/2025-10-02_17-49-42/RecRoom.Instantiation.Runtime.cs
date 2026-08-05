using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MGNEPFHCMDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PKELPKLAMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string OKLMIOJLEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int LIHKHGDJCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid OFABONJFCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly HCBPGOEJGIG NLCEFKJNHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 NGNFCFGNCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion OHBEIHCPLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 JHKBPPBGAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool MOCBMFOPBMD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8536B50", Offset = "0x8535550", VA = "0x188536B50")]
	public MGNEPFHCMDN(string PKKNHBLDAJM, Guid JEIEAPPJOBG, int BGMMNHDMDPP, Guid FJFCHHLHHFI, HCBPGOEJGIG FIIEEBNHOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x85369A0", Offset = "0x85353A0", VA = "0x1885369A0")]
	public EAGDCAGBMFM EGLANIPAIFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8536A50", Offset = "0x8535450", VA = "0x188536A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MLLGMEAPCOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8536C70", Offset = "0x8535670", VA = "0x188536C70")]
	public static bool FMDHPECKCJO(this RRNetworkView DMJMJBPOHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4601C70", Offset = "0x4600670", VA = "0x184601C70")]
	public static object[] FHMMJMBEFHO(this RRNetworkView DMJMJBPOHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8536CA0", Offset = "0x85356A0", VA = "0x188536CA0")]
	public static ViewId FMINMIGCEPN(this RRNetworkView DMJMJBPOHHC)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8536D40", Offset = "0x8535740", VA = "0x188536D40")]
	public static HCBPGOEJGIG LGEBFMHJDBG(this RRNetworkView DMJMJBPOHHC)
	{
		return default(HCBPGOEJGIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8536DF0", Offset = "0x85357F0", VA = "0x188536DF0")]
	public static HCBPGOEJGIG PPHIPPAMDEL(this IGHNJFNIPEM PDCLAJMPOEB)
	{
		return default(HCBPGOEJGIG);
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
