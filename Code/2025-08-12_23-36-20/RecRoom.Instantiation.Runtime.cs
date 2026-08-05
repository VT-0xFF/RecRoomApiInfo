using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PPPBAFINOPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PJIBBFNMGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string LDEHPOPMNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int NKEFFBPEBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid DJMOMLEBGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly BFDLJFNDJKD AMNAEFKAPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 FEDKKAIHHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion NFKDICNPCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 JLNAGFEDOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool BJKEGOPBGFM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x83CAE70", Offset = "0x83C9C70", VA = "0x1883CAE70")]
	public PPPBAFINOPF(string MLPOJPAGPBH, Guid KONLMGJNMLO, int MIHDLKGJOGG, Guid GIFNCLMKCEA, BFDLJFNDJKD OPGIJJMMGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x83CACC0", Offset = "0x83C9AC0", VA = "0x1883CACC0")]
	public FCLGJEKKKPG PBOBJGJGEMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x83CAD70", Offset = "0x83C9B70", VA = "0x1883CAD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FJPNGLLIKIO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x83CABB0", Offset = "0x83C99B0", VA = "0x1883CABB0")]
	public static bool DDOICLJOOID(this RRNetworkView LNFCNKMMELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x45C3820", Offset = "0x45C2620", VA = "0x1845C3820")]
	public static object[] JDMOJBGFNPI(this RRNetworkView LNFCNKMMELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x83CAB10", Offset = "0x83C9910", VA = "0x1883CAB10")]
	public static ViewId ANBENOEICPM(this RRNetworkView LNFCNKMMELP)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83CAC10", Offset = "0x83C9A10", VA = "0x1883CAC10")]
	public static BFDLJFNDJKD NAKAHDNFLJJ(this RRNetworkView LNFCNKMMELP)
	{
		return default(BFDLJFNDJKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83CABE0", Offset = "0x83C99E0", VA = "0x1883CABE0")]
	public static BFDLJFNDJKD LFOKNPLBNBP(this AGAHNKFDNHP ONHEEOKCMKO)
	{
		return default(BFDLJFNDJKD);
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
