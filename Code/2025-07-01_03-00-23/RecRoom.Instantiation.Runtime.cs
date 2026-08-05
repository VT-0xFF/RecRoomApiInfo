using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ODCMNIBKEMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid IPCDPEBMLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string NOKBNPGCLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int MLDABDEOLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid JDMJEBJLFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly AKGINPGMGBG AFAPCDJJGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 DGHMAMNELGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion GBHJDFCFFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 KFMIJCGMFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool ECINJIAEDAA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7FEC0D0", Offset = "0x7FEA6D0", VA = "0x187FEC0D0")]
	public ODCMNIBKEMF(string HDCPENAKGHI, Guid NNCJGJLNGMD, int NCPABCEHPIB, Guid NFFCEGGNLPM, AKGINPGMGBG NHLLLILKFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBF20", Offset = "0x7FEA520", VA = "0x187FEBF20")]
	public BGMIICDLFLJ LILHMBJEMON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBFD0", Offset = "0x7FEA5D0", VA = "0x187FEBFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AEJCOHLJMEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBE10", Offset = "0x7FEA410", VA = "0x187FEBE10")]
	public static bool JAHONCIMIOE(this RRNetworkView PHGOJDGOFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4777E40", Offset = "0x4776440", VA = "0x184777E40")]
	public static object[] NMELENCHDNE(this RRNetworkView PHGOJDGOFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBD70", Offset = "0x7FEA370", VA = "0x187FEBD70")]
	public static ViewId BMEKDBBMOGL(this RRNetworkView PHGOJDGOFOF)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBE70", Offset = "0x7FEA470", VA = "0x187FEBE70")]
	public static AKGINPGMGBG OMKHICFCPHB(this RRNetworkView PHGOJDGOFOF)
	{
		return default(AKGINPGMGBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FEBE40", Offset = "0x7FEA440", VA = "0x187FEBE40")]
	public static AKGINPGMGBG JFGKKPECJGK(this POGNEKBDLPJ MJNKOFMOBDK)
	{
		return default(AKGINPGMGBG);
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
