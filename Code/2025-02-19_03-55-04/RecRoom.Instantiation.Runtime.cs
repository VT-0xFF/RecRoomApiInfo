using System;
using System.Reflection;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IODINKAINFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid GLMKIGLKFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PIKHMCHBOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int CFGGCDGNMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid GLAPPOPNDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly JLHPGPMALFI CFBAJCCDHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 JCCKFLFINHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion BLLDMMJBALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 JKIMKCFOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool KPIDMIEAJFG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x74E2E10", Offset = "0x74E1A10", VA = "0x1874E2E10")]
	public IODINKAINFK(string IMLADFAALMK, Guid IAAOCCMALBO, int DOFGEIPBENL, Guid DIDCADGGMMP, JLHPGPMALFI ANBNKGKMIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74E2C60", Offset = "0x74E1860", VA = "0x1874E2C60")]
	public PHEKHLGEKLI PHLGLCPHKKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x74E2D10", Offset = "0x74E1910", VA = "0x1874E2D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ENONELEBLEH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74E2BE0", Offset = "0x74E17E0", VA = "0x1874E2BE0")]
	public static bool NDCPGNHCHOD(this PhotonView DPCLJPBHKAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74E2C40", Offset = "0x74E1840", VA = "0x1874E2C40")]
	public static object[] PGGMMFGAKFK(this PhotonView DPCLJPBHKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74E2A80", Offset = "0x74E1680", VA = "0x1874E2A80")]
	public static ViewId GACDPKNDGKE(this PhotonView DPCLJPBHKAL)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74E2B20", Offset = "0x74E1720", VA = "0x1874E2B20")]
	public static JLHPGPMALFI MCGNGJBGHAL(this PhotonView DPCLJPBHKAL)
	{
		return default(JLHPGPMALFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74E2C10", Offset = "0x74E1810", VA = "0x1874E2C10")]
	public static JLHPGPMALFI NEFHGJALMOG(this EHIKALDMBIK KNNHCEBFGKJ)
	{
		return default(JLHPGPMALFI);
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
