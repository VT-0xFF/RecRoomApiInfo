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
	[Cpp2IlInjected.Address(RVA = "0x5F700A0", Offset = "0x5F6F4A0", VA = "0x185F700A0")]
	public HLFIAPIKAIE(string DGLMKKCBADE, Guid NCIJMMOAJHD, int PJMJGNEPFFH, Guid DFBMEKJBCAI, MDDKNIHJDMN NFNNPNNDPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FEE0", Offset = "0x5F6F2E0", VA = "0x185F6FEE0")]
	public ONHIPNDMNGN JMLCEABCOEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F6FFA0", Offset = "0x5F6F3A0", VA = "0x185F6FFA0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x5F703D0", Offset = "0x5F6F7D0", VA = "0x185F703D0")]
	public MDDKNIHJDMN([Optional] Dictionary<string, object> COCGFKLJHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F701C0", Offset = "0x5F6F5C0", VA = "0x185F701C0")]
	[NotNull]
	public static MDDKNIHJDMN JGNNLHOKMGJ(PhotonView MPAMJPPMOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27045C0", Offset = "0x27039C0", VA = "0x1827045C0")]
	public bool MFCFPLHBNLD<T>(string KCGLPAPOILB, [Out] T FDFHGIHHGHO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2704430", Offset = "0x2703830", VA = "0x182704430")]
	public bool EGDCMINJFJD<T>(string KCGLPAPOILB, [Out] T FDFHGIHHGHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x27042D0", Offset = "0x27036D0", VA = "0x1827042D0")]
	public void BDBEANEDBLI<T>(string KCGLPAPOILB, T FDFHGIHHGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5F70370", Offset = "0x5F6F770", VA = "0x185F70370")]
	public void NJHEJNEGCKN(string KCGLPAPOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
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
