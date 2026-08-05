using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BPEHFCJOHOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid DIOHHEIOKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FOAHKGPIGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int KFJKIICPKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid PNPLJBJKEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PJGPPIKLFJC HGDKFMKLOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 FLMJNMGJKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion MBCEPOHNHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 FKKBOCKEFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool OFGAAIKOKAG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x83458C0", Offset = "0x83442C0", VA = "0x1883458C0")]
	public BPEHFCJOHOP(string JOPFFGOACPD, Guid BKJIAAHHHPC, int FPNJGLAOJKE, Guid FPCKBBHLCAF, PJGPPIKLFJC PFECBPLPCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8345710", Offset = "0x8344110", VA = "0x188345710")]
	public CNKABLHOHBG PJBCEFAEJBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x83457C0", Offset = "0x83441C0", VA = "0x1883457C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MDIFKABPKDM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x83459E0", Offset = "0x83443E0", VA = "0x1883459E0")]
	public static bool FDEOPKKEIAP(this RRNetworkView EGPPKOBFLID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5322750", Offset = "0x5321150", VA = "0x185322750")]
	public static object[] FDCPGDLABEJ(this RRNetworkView EGPPKOBFLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8345AC0", Offset = "0x83444C0", VA = "0x188345AC0")]
	public static ViewId NNADBKFMBNL(this RRNetworkView EGPPKOBFLID)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8345A10", Offset = "0x8344410", VA = "0x188345A10")]
	public static PJGPPIKLFJC JIJIGLIGEBK(this RRNetworkView EGPPKOBFLID)
	{
		return default(PJGPPIKLFJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8345B60", Offset = "0x8344560", VA = "0x188345B60")]
	public static PJGPPIKLFJC OEOPJKIKNLN(this FAGNCHNIHPN HKENEGGNMIM)
	{
		return default(PJGPPIKLFJC);
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
