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
public class FCIHGCHFCMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid GKEMPAGHFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string GIJOHDPJIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int CDJJKDDBFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid HPKEKFACKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GJENIFNNJEN LPLDGONADDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 FIKECJKJAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion EDMDHCBPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 IPCBBKCLHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool HCGLBHMHMLE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C79430", Offset = "0x6C78030", VA = "0x186C79430")]
	public FCIHGCHFCMJ(string MFPCKNHBBHM, Guid FOCOFMDCPHF, int FLJPJGNMAIC, Guid EFCDLMBDPAA, GJENIFNNJEN IKIPIKOMPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C79270", Offset = "0x6C77E70", VA = "0x186C79270")]
	public GFAHGIKBLIJ LBPDAMMPNNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C79330", Offset = "0x6C77F30", VA = "0x186C79330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GJENIFNNJEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> GJJJCCCOGCC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C79770", Offset = "0x6C78370", VA = "0x186C79770")]
	public GJENIFNNJEN([Optional] Dictionary<string, object> GJJJCCCOGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C795B0", Offset = "0x6C781B0", VA = "0x186C795B0")]
	[NotNull]
	public static GJENIFNNJEN JCIBGIMAJHL(PhotonView JNJLLOKLABC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E06830", Offset = "0x2E05430", VA = "0x182E06830")]
	public bool NNAAPMJPMIH<T>(string NONKDEOLPHL, [Out] T CABLCDOIFFL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2E06200", Offset = "0x2E04E00", VA = "0x182E06200")]
	public bool EELGKEILNJP<T>(string NONKDEOLPHL, [Out] T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2E066D0", Offset = "0x2E052D0", VA = "0x182E066D0")]
	public void GAOLHIMCFIN<T>(string NONKDEOLPHL, T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C79550", Offset = "0x6C78150", VA = "0x186C79550")]
	public void CEFMELNJEMA(string NONKDEOLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
	public Dictionary<string, object> BLDGLIJPHBM()
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
