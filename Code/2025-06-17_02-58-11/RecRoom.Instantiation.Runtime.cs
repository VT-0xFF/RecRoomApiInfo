using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class EHJPCDGEBBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PGKKBBBIOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string GEDLCENLHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int ELPOJKPOBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid BCBNPFMJDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly HFLODILPGJG ENJCMAOLKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 ICJIGFAHILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion ACEAKNBEHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 BHCFCONIOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool OALHDJJNBIF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A7A0", Offset = "0x7D891A0", VA = "0x187D8A7A0")]
	public EHJPCDGEBBK(string DBLNPCOHJMA, Guid NOFDABFMOJL, int DJNFDFOKIHC, Guid OIEHHJHKJEF, HFLODILPGJG KEMHBDIFMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A5F0", Offset = "0x7D88FF0", VA = "0x187D8A5F0")]
	public EHOGLJMNICP PMFGMHFEDNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A6A0", Offset = "0x7D890A0", VA = "0x187D8A6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ABAFDFOOAAB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A4F0", Offset = "0x7D88EF0", VA = "0x187D8A4F0")]
	public static bool FCPJLMEKFNA(this RRNetworkView MMGGIIKGBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4D182F0", Offset = "0x4D16CF0", VA = "0x184D182F0")]
	public static object[] HPMBLFDGNKC(this RRNetworkView MMGGIIKGBNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A520", Offset = "0x7D88F20", VA = "0x187D8A520")]
	public static ViewId HKFFMMBACFD(this RRNetworkView MMGGIIKGBNM)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A440", Offset = "0x7D88E40", VA = "0x187D8A440")]
	public static HFLODILPGJG CJJODJFCMOG(this RRNetworkView MMGGIIKGBNM)
	{
		return default(HFLODILPGJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D8A5C0", Offset = "0x7D88FC0", VA = "0x187D8A5C0")]
	public static HFLODILPGJG IFMEGIMNIMI(this LAHIEFNNKJK JKGCHKOAIPN)
	{
		return default(HFLODILPGJG);
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
