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
public class JBIPENBLOOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid LKCAMHNKGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string MLFDFMOPBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int PGHMNPAPMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid HNBBGALPNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PDGHFOPGCHA NJIAEMHCPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 NHNADCFNHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion OEGELDHNNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 BIGHCNHKHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool EEPIKJEDAFH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64AB5F0", Offset = "0x64A9FF0", VA = "0x1864AB5F0")]
	public JBIPENBLOOE(string PDKJCGANJMP, Guid DHAIEEOLGJK, int BEMGONEIPDA, Guid AINMPCPLNKP, PDGHFOPGCHA DGNBNALMAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64AB370", Offset = "0x64A9D70", VA = "0x1864AB370")]
	public HKPFNADKPCO.PGGOGNENDHK BKEHNNOJIGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64AB530", Offset = "0x64A9F30", VA = "0x1864AB530")]
	public KLJOHJGAOPD HBMJLODEMPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PDGHFOPGCHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> AIIEGBGMKOA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64AB8C0", Offset = "0x64AA2C0", VA = "0x1864AB8C0")]
	public PDGHFOPGCHA([Optional] Dictionary<string, object> AIIEGBGMKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64AB6B0", Offset = "0x64AA0B0", VA = "0x1864AB6B0")]
	[NotNull]
	public static PDGHFOPGCHA NHGBPDBNAHC(PhotonView DICLGEOGLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2917F30", Offset = "0x2916930", VA = "0x182917F30")]
	public bool CKMNFEFPOIP<T>(string AJPNMLHDHNM, out T MNIAGKNOHEJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29186F0", Offset = "0x29170F0", VA = "0x1829186F0")]
	public void NLANNFAIKGA<T>(string AJPNMLHDHNM, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64AB860", Offset = "0x64AA260", VA = "0x1864AB860")]
	public void OLCIACFECIH(string AJPNMLHDHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
	public Dictionary<string, object> AKDDKMKCIFH()
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
