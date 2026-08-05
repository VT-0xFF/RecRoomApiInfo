using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BOGDBMMLMCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid IBJBGEDPEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string GCIIOJIAMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int OJPCMKIPGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid LBFBFGJPFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ENKCMKGNHEJ NOJKDCBGHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 JILMILDHLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion FOJJHGMABOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 FOANFLBGIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool GHMLONKJONB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x81B30C0", Offset = "0x81B20C0", VA = "0x1881B30C0")]
	public BOGDBMMLMCC(string NIMMNBBALAD, Guid PGDEGPGCAIN, int FPLJGBABAEM, Guid ACHLNPFJANI, ENKCMKGNHEJ MBLKDALNGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81B2F10", Offset = "0x81B1F10", VA = "0x1881B2F10")]
	public KNNJGEFDCOE JDLAFAKFIMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81B2FC0", Offset = "0x81B1FC0", VA = "0x1881B2FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MCOPOFPLNAH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81B31E0", Offset = "0x81B21E0", VA = "0x1881B31E0")]
	public static bool CCCIDIEAKNL(this RRNetworkView GBKCMPDBPJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4D81D80", Offset = "0x4D80D80", VA = "0x184D81D80")]
	public static object[] PFEGAIOFBLG(this RRNetworkView GBKCMPDBPJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81B32F0", Offset = "0x81B22F0", VA = "0x1881B32F0")]
	public static ViewId IMFLMFPDKNF(this RRNetworkView GBKCMPDBPJK)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81B3240", Offset = "0x81B2240", VA = "0x1881B3240")]
	public static ENKCMKGNHEJ HILJPAIGGAP(this RRNetworkView GBKCMPDBPJK)
	{
		return default(ENKCMKGNHEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81B3210", Offset = "0x81B2210", VA = "0x1881B3210")]
	public static ENKCMKGNHEJ FFJEDMFFGFC(this PGJMEEHDJEL OGEALFKCCAP)
	{
		return default(ENKCMKGNHEJ);
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
