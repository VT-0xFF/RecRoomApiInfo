using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CMFLKMCPKHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid MAMCHLPCCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PHLENMBCAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int OCMEJHKBDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid EDIDJKNBEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IKHGLHKGDCI IOCJMMBPLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 HKMBNCFKKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion PHNPMAOBIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 JFDFJOEOLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool HHCDIMIMODD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE960", Offset = "0x7DDD760", VA = "0x187DDE960")]
	public CMFLKMCPKHF(string PGMKJGMLBKD, Guid IGAICHKJHBJ, int CIFMFMPIJHN, Guid MLMMNGNEKMO, IKHGLHKGDCI BKLAOHONLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE7B0", Offset = "0x7DDD5B0", VA = "0x187DDE7B0")]
	public HKDDDPDOOAM JOKLGIKENFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE860", Offset = "0x7DDD660", VA = "0x187DDE860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KMJAGCDLNPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEA80", Offset = "0x7DDD880", VA = "0x187DDEA80")]
	public static bool COHLOGCDNCN(this RRNetworkView IOEIHBPMNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4E94C60", Offset = "0x4E93A60", VA = "0x184E94C60")]
	public static object[] MGAEAJPDKLE(this RRNetworkView IOEIHBPMNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEAB0", Offset = "0x7DDD8B0", VA = "0x187DDEAB0")]
	public static ViewId HPEEPLFGHDJ(this RRNetworkView IOEIHBPMNDC)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEB80", Offset = "0x7DDD980", VA = "0x187DDEB80")]
	public static IKHGLHKGDCI OFJKEJHNEFA(this RRNetworkView IOEIHBPMNDC)
	{
		return default(IKHGLHKGDCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7DDEB50", Offset = "0x7DDD950", VA = "0x187DDEB50")]
	public static IKHGLHKGDCI NHGPDAEMDAI(this KBOENGPNDFP CNCKIIIBBGO)
	{
		return default(IKHGLHKGDCI);
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
