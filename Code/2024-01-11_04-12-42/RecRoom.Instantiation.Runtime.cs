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
public class GOKACPNPBDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid IAPDPLMPEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FHAFCCICDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int FCNCNPGJCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid JAEOKEIJPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly OKKKHBBNDGF NNHOCIICEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 LMPBAOBONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion AMNPPNHEHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 NJJFPNKONPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool KNJLALNIOLK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4BB0", Offset = "0x5FE35B0", VA = "0x185FE4BB0")]
	public GOKACPNPBDB(string GOHKHHPOOPK, Guid GPBDCEKNGHC, int NDJPBEAFJEJ, Guid DMNOJKHFOCL, OKKKHBBNDGF ICLKKCGFKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FE49F0", Offset = "0x5FE33F0", VA = "0x185FE49F0")]
	public JOBJBPGPPEG LJICBDNFOHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4AB0", Offset = "0x5FE34B0", VA = "0x185FE4AB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OKKKHBBNDGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> FEMCAFLHAEM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4EE0", Offset = "0x5FE38E0", VA = "0x185FE4EE0")]
	public OKKKHBBNDGF([Optional] Dictionary<string, object> FEMCAFLHAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4D30", Offset = "0x5FE3730", VA = "0x185FE4D30")]
	[NotNull]
	public static OKKKHBBNDGF PFNEHLDLIKA(PhotonView CCALGGEFNKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2770E50", Offset = "0x276F850", VA = "0x182770E50")]
	public bool GFGJHMKHGPD<T>(string FHLJKJHFEEK, [Out] T BEEGCHJLJFC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2770CC0", Offset = "0x276F6C0", VA = "0x182770CC0")]
	public bool EKALEENJGMG<T>(string FHLJKJHFEEK, [Out] T BEEGCHJLJFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2771610", Offset = "0x2770010", VA = "0x182771610")]
	public void OGNHOBPFCBA<T>(string FHLJKJHFEEK, T BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4CD0", Offset = "0x5FE36D0", VA = "0x185FE4CD0")]
	public void BPOFHEGLDCM(string FHLJKJHFEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
	public Dictionary<string, object> PPIJGJEAHOI()
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
