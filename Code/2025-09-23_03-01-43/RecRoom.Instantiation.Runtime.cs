using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KCHFOBCKIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid OAEPNDKJHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string JFNOACGLBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int DKPPKPKCAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid AJLBLMGMABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ANOCIKLGHAF OHHMNLEMJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 PGBNPPMBLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion BGKDKGECOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 KHGBNADOONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool GKPMNGKGBNA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8540CF0", Offset = "0x853F2F0", VA = "0x188540CF0")]
	public KCHFOBCKIMB(string CDCAHPOCPKO, Guid GOCGBFBGDJN, int BABIGKEEIPL, Guid EIEGDICNOIG, ANOCIKLGHAF DMBDFLHOACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8540B40", Offset = "0x853F140", VA = "0x188540B40")]
	public KDDDPMKMLAO DHFJOMCHFJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8540BF0", Offset = "0x853F1F0", VA = "0x188540BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FMOJBHAODID
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8540990", Offset = "0x853EF90", VA = "0x188540990")]
	public static bool DKLEIELJNMJ(this RRNetworkView EPNGEANGHIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4655070", Offset = "0x4653670", VA = "0x184655070")]
	public static object[] EOPCHGLBFKG(this RRNetworkView EPNGEANGHIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8540AA0", Offset = "0x853F0A0", VA = "0x188540AA0")]
	public static ViewId PLIPCPLAEKG(this RRNetworkView EPNGEANGHIF)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x85409F0", Offset = "0x853EFF0", VA = "0x1885409F0")]
	public static ANOCIKLGHAF MOCKJMDLOAH(this RRNetworkView EPNGEANGHIF)
	{
		return default(ANOCIKLGHAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x85409C0", Offset = "0x853EFC0", VA = "0x1885409C0")]
	public static ANOCIKLGHAF HGDEJDBJAMC(this CIGJPCGGKGI ENMBHGMENHL)
	{
		return default(ANOCIKLGHAF);
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
