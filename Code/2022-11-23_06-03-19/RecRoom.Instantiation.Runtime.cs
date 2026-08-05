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
public class CJDNBLOMJIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid CINJKDNAGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PEEPBGHLBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int APKDNIILOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid GBOCHPHFAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly JLJCOPPMEBD BGFGCAFJFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 AMADAKGCFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion HFFCHEBENLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 CENIBHOEPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool BNEAOGKMBJF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EB89C0", Offset = "0x5EB77C0", VA = "0x185EB89C0")]
	public CJDNBLOMJIN(string BEKHBMMBGHO, Guid LFJHAMPHAIO, int MGFHJNCJJPD, Guid FNFDICADAII, JLJCOPPMEBD NDIJONHLLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8740", Offset = "0x5EB7540", VA = "0x185EB8740")]
	public BHFLDCCAAEK.KPFKLLNPGHC CHHEAIHOPHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8900", Offset = "0x5EB7700", VA = "0x185EB8900")]
	public OEFLHOOCPAP GMOBNDBLLKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JLJCOPPMEBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> CFMKJCIDMKN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8C90", Offset = "0x5EB7A90", VA = "0x185EB8C90")]
	public JLJCOPPMEBD([Optional] Dictionary<string, object> CFMKJCIDMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8AE0", Offset = "0x5EB78E0", VA = "0x185EB8AE0")]
	[NotNull]
	public static JLJCOPPMEBD PLNJEHKMALP(PhotonView BDEPBKMNBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28F2010", Offset = "0x28F0E10", VA = "0x1828F2010")]
	public bool GINCMLLPDOD<T>(string BIMCDHOFDCP, out T GKFICKKHACC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28F27D0", Offset = "0x28F15D0", VA = "0x1828F27D0")]
	public void NMFBOCJEJOB<T>(string BIMCDHOFDCP, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8A80", Offset = "0x5EB7880", VA = "0x185EB8A80")]
	public void DOHHNJJEEIG(string BIMCDHOFDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
	public Dictionary<string, object> NHLOJDCCKBK()
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
