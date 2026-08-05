using System;
using System.Reflection;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NNBDDFDNPNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid GNNIFCADBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string HDABNGAACCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int HABEPCBBEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid DDNICLNLEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GPMAMEJIKCA MPOHLMDIEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 CPGAKMJDLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion DBFFJKGJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 OIHEBFGIBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool GACILHBIDGJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x78516E0", Offset = "0x7850AE0", VA = "0x1878516E0")]
	public NNBDDFDNPNN(string DEJPIJHJKHC, Guid PJENAEEDLAC, int NLKOCHANLIF, Guid EPPHOMAKDFP, GPMAMEJIKCA EPNGIJLKGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7851530", Offset = "0x7850930", VA = "0x187851530")]
	public MPAALDFCOIB OMBDPNOPPKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x78515E0", Offset = "0x78509E0", VA = "0x1878515E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EEKPJJFAGAM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7851440", Offset = "0x7850840", VA = "0x187851440")]
	public static bool OHBPMBFMCFK(this PhotonView FEDEGDPKLDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7851470", Offset = "0x7850870", VA = "0x187851470")]
	public static object[] PNCLLKHCGAI(this PhotonView FEDEGDPKLDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7851490", Offset = "0x7850890", VA = "0x187851490")]
	public static ViewId PODIKKFJEPO(this PhotonView FEDEGDPKLDC)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7851380", Offset = "0x7850780", VA = "0x187851380")]
	public static GPMAMEJIKCA AMIEEAKKADK(this PhotonView FEDEGDPKLDC)
	{
		return default(GPMAMEJIKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7851350", Offset = "0x7850750", VA = "0x187851350")]
	public static GPMAMEJIKCA ACNGLPADFAC(this HHOPOFLIDIG NFHKMOGHIBC)
	{
		return default(GPMAMEJIKCA);
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
