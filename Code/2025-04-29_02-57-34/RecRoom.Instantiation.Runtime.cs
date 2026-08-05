using System;
using System.Reflection;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KKBBLNDJLCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid FKLGIGAIFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string NMLOFINHDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int AMDKNKDFBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid DNOJDDJEOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly FHKNBBDCLOD PJAPBFLJEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 KHAINEMBOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion CNCCLHDGKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 FPMGHKHIBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool AMHCGDGHIPO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B3BF70", Offset = "0x7B3B370", VA = "0x187B3BF70")]
	public KKBBLNDJLCH(string GLCKFKOGJOM, Guid CPJGEBFLGCD, int CMLMFBEGMFO, Guid MGDNCABPODA, FHKNBBDCLOD OOPLPPPBIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B3BDC0", Offset = "0x7B3B1C0", VA = "0x187B3BDC0")]
	public DNGAMMAIPPM ALBHFAPDAAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B3BE70", Offset = "0x7B3B270", VA = "0x187B3BE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PAPBPIILOAC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C090", Offset = "0x7B3B490", VA = "0x187B3C090")]
	public static bool HJPFDHCBLOM(this PhotonView KNHIPANAKJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C220", Offset = "0x7B3B620", VA = "0x187B3C220")]
	public static object[] NHPHBLKMDAA(this PhotonView KNHIPANAKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C0C0", Offset = "0x7B3B4C0", VA = "0x187B3C0C0")]
	public static ViewId IHENOADBPPM(this PhotonView KNHIPANAKJG)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C160", Offset = "0x7B3B560", VA = "0x187B3C160")]
	public static FHKNBBDCLOD KPGCDNOLMJO(this PhotonView KNHIPANAKJG)
	{
		return default(FHKNBBDCLOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B3C240", Offset = "0x7B3B640", VA = "0x187B3C240")]
	public static FHKNBBDCLOD OJEKAPMLOFD(this BKCKLCPIJPC OPJDOLNIGOE)
	{
		return default(FHKNBBDCLOD);
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
