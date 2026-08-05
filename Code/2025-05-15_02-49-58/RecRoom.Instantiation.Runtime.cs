using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FLOHPLGLJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PCOOEAMCAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string DHMCHAFKPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int GBGKKFDFFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid DAKAIKDKNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NEEICKGOONJ MCDNEEJDCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 MJJFMHOFJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion GMKIGHDIIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 DAEGLJOIOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool CHHFJGKODDP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E880", Offset = "0x7C6CE80", VA = "0x187C6E880")]
	public FLOHPLGLJLN(string NJBHNMHIDFO, Guid ILIJOMFFCEM, int KDDLGAMAPEH, Guid CJHMIILEEBE, NEEICKGOONJ FPAFIGMCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E6D0", Offset = "0x7C6CCD0", VA = "0x187C6E6D0")]
	public NKMCEMELPEA OJPNDGOCLBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E780", Offset = "0x7C6CD80", VA = "0x187C6E780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DNIELEGNHFC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E5C0", Offset = "0x7C6CBC0", VA = "0x187C6E5C0")]
	public static bool HMPJHKEOPJC(this RRNetworkView NNAEIGBDCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x49A1D20", Offset = "0x49A0320", VA = "0x1849A1D20")]
	public static object[] AFJLEEBDEJK(this RRNetworkView NNAEIGBDCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E520", Offset = "0x7C6CB20", VA = "0x187C6E520")]
	public static ViewId GHMNEJPNIHL(this RRNetworkView NNAEIGBDCOK)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E5F0", Offset = "0x7C6CBF0", VA = "0x187C6E5F0")]
	public static NEEICKGOONJ KCCLKIJMNOO(this RRNetworkView NNAEIGBDCOK)
	{
		return default(NEEICKGOONJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E6A0", Offset = "0x7C6CCA0", VA = "0x187C6E6A0")]
	public static NEEICKGOONJ LNDKKLAGNKM(this PDFFKFEBJJB PMLCGCAHNGK)
	{
		return default(NEEICKGOONJ);
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
