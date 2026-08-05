using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MNMEKELALBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid BANBAMLKLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string DCKJGHKPAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int FOPLEKDGDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid IDIPFPAPFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DDNEFPADLOB FICKOFLCFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 IIKJNDDFMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion NEMGOCEHIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 PFMPFEHANLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool PECAPAGHOCA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84A3C60", Offset = "0x84A2260", VA = "0x1884A3C60")]
	public MNMEKELALBC(string MAIHBFHEECO, Guid GGKKMCPLKME, int KLJHGACJHAL, Guid DEMDENAPFGM, DDNEFPADLOB CCENNKBKDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x84A3AB0", Offset = "0x84A20B0", VA = "0x1884A3AB0")]
	public CIOENMFOBPH NCFHLOHFPHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84A3B60", Offset = "0x84A2160", VA = "0x1884A3B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OAEKEGALALL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84A3E60", Offset = "0x84A2460", VA = "0x1884A3E60")]
	public static bool PAPEIMCBJLL(this RRNetworkView MLCJICFBOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x45AF160", Offset = "0x45AD760", VA = "0x1845AF160")]
	public static object[] DBKOHPLMPAB(this RRNetworkView MLCJICFBOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84A3E90", Offset = "0x84A2490", VA = "0x1884A3E90")]
	public static ViewId PKBPHNILHEA(this RRNetworkView MLCJICFBOOE)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x84A3DB0", Offset = "0x84A23B0", VA = "0x1884A3DB0")]
	public static DDNEFPADLOB ENCECOHGKEA(this RRNetworkView MLCJICFBOOE)
	{
		return default(DDNEFPADLOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84A3D80", Offset = "0x84A2380", VA = "0x1884A3D80")]
	public static DDNEFPADLOB AIANGKOPFCD(this KMJBHELCIEH MHCCEBNBPPI)
	{
		return default(DDNEFPADLOB);
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
