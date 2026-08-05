using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LGBKJPKBIKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid AONGBJAJJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string CEIGHHMPFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int OIGBPMIOPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid PIBBAKDNBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NALOKHDCBNN KIIKFFJPFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 BKPAIEKHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion GGEGPGBJIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 HNGFPHJMIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool DIAJNABHHJA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x82EE140", Offset = "0x82ED540", VA = "0x1882EE140")]
	public LGBKJPKBIKB(string BHECMNLMABG, Guid DENMIBAHAEL, int GKIPFHFIBNF, Guid KBCJANMKKCN, NALOKHDCBNN AOHANGHKOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x82EDF90", Offset = "0x82ED390", VA = "0x1882EDF90")]
	public NDENGIDCCAL LOAGJFCAJAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82EE040", Offset = "0x82ED440", VA = "0x1882EE040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CMMGEHJPKIN
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82EDEB0", Offset = "0x82ED2B0", VA = "0x1882EDEB0")]
	public static bool HFDIAOOGLNN(this RRNetworkView BPHIDAEMDAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4F452E0", Offset = "0x4F446E0", VA = "0x184F452E0")]
	public static object[] HIKIEEJCGOF(this RRNetworkView BPHIDAEMDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82EDE10", Offset = "0x82ED210", VA = "0x1882EDE10")]
	public static ViewId GIBKGNILDAO(this RRNetworkView BPHIDAEMDAO)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82EDEE0", Offset = "0x82ED2E0", VA = "0x1882EDEE0")]
	public static NALOKHDCBNN MJOEDJBCIFI(this RRNetworkView BPHIDAEMDAO)
	{
		return default(NALOKHDCBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82EDDE0", Offset = "0x82ED1E0", VA = "0x1882EDDE0")]
	public static NALOKHDCBNN CAOAEDOCNPA(this CKKBHIEFKJN FGEMBJJOPFK)
	{
		return default(NALOKHDCBNN);
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
