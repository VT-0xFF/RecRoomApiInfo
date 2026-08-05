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
public class HLFIAPIKAIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid FECIBNKPNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string EGOHPHJGLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int BHHDBPOMGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid DJKNBJLBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly MDDKNIHJDMN GOKMLJJKHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 FFAIKMBLIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion CAPHJLBJELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 NPFONBILKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool PKFPNIDMPEG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FE98F0", Offset = "0x5FE82F0", VA = "0x185FE98F0")]
	public HLFIAPIKAIE(string DGLMKKCBADE, Guid NCIJMMOAJHD, int PJMJGNEPFFH, Guid DFBMEKJBCAI, MDDKNIHJDMN NFNNPNNDPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9730", Offset = "0x5FE8130", VA = "0x185FE9730")]
	public ONHIPNDMNGN JMLCEABCOEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FE97F0", Offset = "0x5FE81F0", VA = "0x185FE97F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class MDDKNIHJDMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> COCGFKLJHJH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9C20", Offset = "0x5FE8620", VA = "0x185FE9C20")]
	public MDDKNIHJDMN([Optional] Dictionary<string, object> COCGFKLJHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9A10", Offset = "0x5FE8410", VA = "0x185FE9A10")]
	[NotNull]
	public static MDDKNIHJDMN JGNNLHOKMGJ(PhotonView MPAMJPPMOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x275B660", Offset = "0x275A060", VA = "0x18275B660")]
	public bool MFCFPLHBNLD<T>(string KCGLPAPOILB, [Out] T FDFHGIHHGHO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x275B4D0", Offset = "0x2759ED0", VA = "0x18275B4D0")]
	public bool EGDCMINJFJD<T>(string KCGLPAPOILB, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x275B370", Offset = "0x2759D70", VA = "0x18275B370")]
	public void BDBEANEDBLI<T>(string KCGLPAPOILB, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FE9BC0", Offset = "0x5FE85C0", VA = "0x185FE9BC0")]
	public void NJHEJNEGCKN(string KCGLPAPOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
	public Dictionary<string, object> CAEMJPNOCOG()
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
