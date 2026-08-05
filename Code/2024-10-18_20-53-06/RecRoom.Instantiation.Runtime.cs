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
public class IPHLLLPPIAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid JAMOBLHILGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string LNMLGHIBKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int IEPHACNFLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid NKGNIHBAPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NDGJHOLJPCD EKJLAIOKEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 DPFKDMMBOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion HOGDMCNOLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 IFLMNPAOEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool IBEKBMJBAHF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E05AF0", Offset = "0x6E04EF0", VA = "0x186E05AF0")]
	public IPHLLLPPIAH(string IMDAMHNKLIB, Guid CJBCOGACECF, int CLCMBICOIIN, Guid COHJIHMFNCH, NDGJHOLJPCD APLOJMJGFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E05930", Offset = "0x6E04D30", VA = "0x186E05930")]
	public OCHGCFIEBDA NKLJADCNIPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E059F0", Offset = "0x6E04DF0", VA = "0x186E059F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NDGJHOLJPCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> MLDNPGCLJBO;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E05E30", Offset = "0x6E05230", VA = "0x186E05E30")]
	public NDGJHOLJPCD([Optional] Dictionary<string, object> MLDNPGCLJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E05C70", Offset = "0x6E05070", VA = "0x186E05C70")]
	[NotNull]
	public static NDGJHOLJPCD FDFHEPKKHPN(PhotonView JAACMBBNMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1480", Offset = "0x2FB0880", VA = "0x182FB1480")]
	public bool LCKMIEGKAOE<T>(string OEOMDKHBDFI, [Out] T EEPLCHCGAIN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2FB12F0", Offset = "0x2FB06F0", VA = "0x182FB12F0")]
	public bool JGHHOJPLECF<T>(string OEOMDKHBDFI, [Out] T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2FB1C50", Offset = "0x2FB1050", VA = "0x182FB1C50")]
	public void MCAKFOHFDBM<T>(string OEOMDKHBDFI, T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E05C10", Offset = "0x6E05010", VA = "0x186E05C10")]
	public void BJFEGIDGDBE(string OEOMDKHBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
	public Dictionary<string, object> AIFHMKKLEJH()
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
