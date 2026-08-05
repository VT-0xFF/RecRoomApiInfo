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
	[Cpp2IlInjected.Address(RVA = "0x78C27B0", Offset = "0x78C1BB0", VA = "0x1878C27B0")]
	public PBLDHPJABID(string PPMKMIJJDLA, Guid PDLPKNJHJOL, int LJLLCOCKDAC, Guid OAGBMEMFNEC, NKNHEFKHIEC CCPIJFMLJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x78C2600", Offset = "0x78C1A00", VA = "0x1878C2600")]
	public EFLLCEMMOMM KENDNMBGAKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78C26B0", Offset = "0x78C1AB0", VA = "0x1878C26B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GCNHEAPKFNG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x78C24C0", Offset = "0x78C18C0", VA = "0x1878C24C0")]
	public static bool CLJNFCMONAI(this PhotonView EKLEPCBGCMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x78C24F0", Offset = "0x78C18F0", VA = "0x1878C24F0")]
	public static object[] DDEJCOGNHME(this PhotonView EKLEPCBGCMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78C2420", Offset = "0x78C1820", VA = "0x1878C2420")]
	public static ViewId AJFLPKCNDKP(this PhotonView EKLEPCBGCMK)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x78C2540", Offset = "0x78C1940", VA = "0x1878C2540")]
	public static NKNHEFKHIEC GDBKDOCPFLD(this PhotonView EKLEPCBGCMK)
	{
		return default(NKNHEFKHIEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x78C2510", Offset = "0x78C1910", VA = "0x1878C2510")]
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
