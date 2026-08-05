using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Photon.Pun;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MNBHEDJMLDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid FCADBHIKPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string EKCNOPOMBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int EMKCLJGCBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid BOHIJMOEIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DDCIMCLOFBM KHPEEMFGONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 CNEKGDKGHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion LABHFJHFGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 PDJIIHOINMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool OLHGNBOMEGC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6023C10", Offset = "0x6023010", VA = "0x186023C10")]
	public MNBHEDJMLDK(string JOJBJEEFDFC, Guid NHDKFBOGPAO, int CMCEFFHNHEM, Guid NCDJBDDKNMI, DDCIMCLOFBM JCFHEELLACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6023A50", Offset = "0x6022E50", VA = "0x186023A50")]
	public LIACPJHHNMP EKIGNMDOCNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6023B10", Offset = "0x6022F10", VA = "0x186023B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DDCIMCLOFBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> GCPHJGCPPIL;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60239C0", Offset = "0x6022DC0", VA = "0x1860239C0")]
	public DDCIMCLOFBM([Optional] Dictionary<string, object> GCPHJGCPPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60237B0", Offset = "0x6022BB0", VA = "0x1860237B0")]
	[NotNull]
	public static DDCIMCLOFBM AMCKIMOFFEF(PhotonView LJOKLMGDNKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x24AA050", Offset = "0x24A9450", VA = "0x1824AA050")]
	public bool KDHJGKFFEEJ<T>(string CONEAMPCFEL, [Out] T PAHKKNONPEO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x24A9EC0", Offset = "0x24A92C0", VA = "0x1824A9EC0")]
	public bool BMDJLPLGAPF<T>(string CONEAMPCFEL, [Out] T PAHKKNONPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24AA810", Offset = "0x24A9C10", VA = "0x1824AA810")]
	public void NIEAIDPCAEB<T>(string CONEAMPCFEL, T PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6023960", Offset = "0x6022D60", VA = "0x186023960")]
	public void FKMFNEFKHJM(string CONEAMPCFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
	public Dictionary<string, object> GBJIEFDBPLH()
	{
		return null;
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
