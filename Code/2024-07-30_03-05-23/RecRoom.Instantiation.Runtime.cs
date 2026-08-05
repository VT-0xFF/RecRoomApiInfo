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
public class OFGPNLKMLGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid JJHJDJIPIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string CHKNFDCAAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int AFMKBBKIKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid JEJPOCJIOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly FMHFLNMAMMF FIGAKOGNPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 GJMAELHLBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion FODPGOBPIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 ELBJGPEEFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool DNFKNFPELDC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C340", Offset = "0x6A2A940", VA = "0x186A2C340")]
	public OFGPNLKMLGO(string ALGLCCEBAGM, Guid EIAIIFKHPII, int NIIGDADIFIK, Guid MJPKKDMBIHB, FMHFLNMAMMF GJNKFNOCPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C180", Offset = "0x6A2A780", VA = "0x186A2C180")]
	public AFEEBDAHHBN AKKEBGMKCLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C240", Offset = "0x6A2A840", VA = "0x186A2C240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FMHFLNMAMMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> CJEJMNCEEAO;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C0F0", Offset = "0x6A2A6F0", VA = "0x186A2C0F0")]
	public FMHFLNMAMMF([Optional] Dictionary<string, object> CJEJMNCEEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A2BEE0", Offset = "0x6A2A4E0", VA = "0x186A2BEE0")]
	[NotNull]
	public static FMHFLNMAMMF DJPFADKPBNO(PhotonView NHMHCGNANBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B87020", Offset = "0x2B85620", VA = "0x182B87020")]
	public bool APLEJEFPFAB<T>(string IBBDLGCDELM, [Out] T DMNGPNKHPKF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B874B0", Offset = "0x2B85AB0", VA = "0x182B874B0")]
	public bool CICMFIAABIH<T>(string IBBDLGCDELM, [Out] T DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B87980", Offset = "0x2B85F80", VA = "0x182B87980")]
	public void ECADPABFBJL<T>(string IBBDLGCDELM, T DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C090", Offset = "0x6A2A690", VA = "0x186A2C090")]
	public void HHOKGKJNBNI(string IBBDLGCDELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
	public Dictionary<string, object> JGKEPNNBAGP()
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
