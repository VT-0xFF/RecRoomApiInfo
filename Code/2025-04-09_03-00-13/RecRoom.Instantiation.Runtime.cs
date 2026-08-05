using System;
using System.Reflection;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PBLDHPJABID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid DCDLBMBBEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string NPIEACPFCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int PPIBHIMDLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid FDADKBOIOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NKNHEFKHIEC PBAFPDEIOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 KLIFIKMFFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion APIEPNJDKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 KLLLKPKKICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool EJECCLEMHDN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7911060", Offset = "0x7910460", VA = "0x187911060")]
	public PBLDHPJABID(string PPMKMIJJDLA, Guid PDLPKNJHJOL, int LJLLCOCKDAC, Guid OAGBMEMFNEC, NKNHEFKHIEC CCPIJFMLJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7910EB0", Offset = "0x79102B0", VA = "0x187910EB0")]
	public EFLLCEMMOMM KENDNMBGAKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7910F60", Offset = "0x7910360", VA = "0x187910F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GCNHEAPKFNG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7910D70", Offset = "0x7910170", VA = "0x187910D70")]
	public static bool CLJNFCMONAI(this PhotonView EKLEPCBGCMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7910DA0", Offset = "0x79101A0", VA = "0x187910DA0")]
	public static object[] DDEJCOGNHME(this PhotonView EKLEPCBGCMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7910CD0", Offset = "0x79100D0", VA = "0x187910CD0")]
	public static ViewId AJFLPKCNDKP(this PhotonView EKLEPCBGCMK)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7910DF0", Offset = "0x79101F0", VA = "0x187910DF0")]
	public static NKNHEFKHIEC GDBKDOCPFLD(this PhotonView EKLEPCBGCMK)
	{
		return default(NKNHEFKHIEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7910DC0", Offset = "0x79101C0", VA = "0x187910DC0")]
	public static NKNHEFKHIEC EDAEPILIHAL(this HPKEHNECJOA MHBNBGGMEBA)
	{
		return default(NKNHEFKHIEC);
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
