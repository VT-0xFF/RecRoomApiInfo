using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GHHAIJGAMIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PFHGIADOCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PMIEKGBDOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int FNBOGGEJOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid ECHNIONAHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DDJGKBBEDKH DHAKDCNLBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 MILMNOPOIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion DDKKAJIGLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 NONFLPGEECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool PKGFMGAJLIC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C969C0", Offset = "0x7C95BC0", VA = "0x187C969C0")]
	public GHHAIJGAMIK(string FNBPEJBPIPG, Guid MKFCFEFNJMC, int JMNPJFNNBDG, Guid BGFODCFIGMI, DDJGKBBEDKH NPAPFBEAOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C96810", Offset = "0x7C95A10", VA = "0x187C96810")]
	public FCAIFKHJLCJ MLMBCMJCDKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C968C0", Offset = "0x7C95AC0", VA = "0x187C968C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AMPBDMIFBEF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C96690", Offset = "0x7C95890", VA = "0x187C96690")]
	public static bool HAFKICMIPJN(this RRNetworkView PEGCLJNJBJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4BFCF40", Offset = "0x4BFC140", VA = "0x184BFCF40")]
	public static object[] ELKPIAKBFMN(this RRNetworkView PEGCLJNJBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C96770", Offset = "0x7C95970", VA = "0x187C96770")]
	public static ViewId PGEHMEJOILI(this RRNetworkView PEGCLJNJBJG)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C966C0", Offset = "0x7C958C0", VA = "0x187C966C0")]
	public static DDJGKBBEDKH KLJFGNLCMMA(this RRNetworkView PEGCLJNJBJG)
	{
		return default(DDJGKBBEDKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C96660", Offset = "0x7C95860", VA = "0x187C96660")]
	public static DDJGKBBEDKH GADLCCMLECB(this DNJGHDDEDMD AJLJPILGNIP)
	{
		return default(DDJGKBBEDKH);
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
