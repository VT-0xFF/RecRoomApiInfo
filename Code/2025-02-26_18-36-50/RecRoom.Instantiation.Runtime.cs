using System;
using System.Reflection;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Foundation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IDECODEGFDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid IHJCOGCOJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string DFGACDCNALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int HEBBCPJOFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid PEABBCDCPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DPGADNNJFDK LJFANABBFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 NAMOIOBECGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion KGCMOGJCFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 PKJENICKIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool PFIKAEKGKBH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x749E370", Offset = "0x749D770", VA = "0x18749E370")]
	public IDECODEGFDL(string HEEFCLHHCJJ, Guid FBLPOOJAEOJ, int OBDCNMDIMNB, Guid IEJINLAAIEE, DPGADNNJFDK LILMOGKBGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x749E1C0", Offset = "0x749D5C0", VA = "0x18749E1C0")]
	public BAKCGJBIBFA MBHLHBGLDDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x749E270", Offset = "0x749D670", VA = "0x18749E270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MAHLPKDHCCL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x749E4E0", Offset = "0x749D8E0", VA = "0x18749E4E0")]
	public static bool OBDNKOIEKFK(this PhotonView GAFKCGNMDOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x749E4C0", Offset = "0x749D8C0", VA = "0x18749E4C0")]
	public static object[] ILMJHGEDDCD(this PhotonView GAFKCGNMDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x749E510", Offset = "0x749D910", VA = "0x18749E510")]
	public static ViewId OLIHLICBMJK(this PhotonView GAFKCGNMDOE)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x749E5B0", Offset = "0x749D9B0", VA = "0x18749E5B0")]
	public static DPGADNNJFDK PJKKHEFGBLO(this PhotonView GAFKCGNMDOE)
	{
		return default(DPGADNNJFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x749E490", Offset = "0x749D890", VA = "0x18749E490")]
	public static DPGADNNJFDK BAALDENLGGI(this FNJFJFBHCFA FJJOKDBOKAE)
	{
		return default(DPGADNNJFDK);
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
