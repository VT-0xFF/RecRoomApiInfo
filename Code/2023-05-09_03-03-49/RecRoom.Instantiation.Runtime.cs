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
public class LJJLPPOGDMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PECHJDEDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string BLMFNJICLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int POOBEKKEMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid HHAGELHIKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GEGAHEHGGCP EHFMODEFHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 NKAKGAAIHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion POCEHKCMLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 PEMIOODAJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool KMKPGJCDBLG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E6EAD0", Offset = "0x1E6D4D0", VA = "0x181E6EAD0")]
	public LJJLPPOGDMB(string OFPFFILADCG, Guid CDJGCCCGMJD, int OMFDOOMAGBN, Guid GHIPFJIIKOO, GEGAHEHGGCP FANACCGJIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E910", Offset = "0x1E6D310", VA = "0x181E6E910")]
	public DEILOBJFOCJ.EKGLECIKNAO EOAMGEDJPNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E850", Offset = "0x1E6D250", VA = "0x181E6E850")]
	public FLEAHHDHCDB EAGFFELCENA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GEGAHEHGGCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> JFIDKNJCCMK;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E7C0", Offset = "0x1E6D1C0", VA = "0x181E6E7C0")]
	public GEGAHEHGGCP([Optional] Dictionary<string, object> JFIDKNJCCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E5B0", Offset = "0x1E6CFB0", VA = "0x181E6E5B0")]
	[NotNull]
	public static GEGAHEHGGCP CAOANFLGNPF(PhotonView IHJOFIPFCMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x30CAB20", Offset = "0x30C9520", VA = "0x1830CAB20")]
	public bool JBPBACKGAAO<T>(string IGFDDANAMMH, out T MFBGAMJDOKA) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x30CA980", Offset = "0x30C9380", VA = "0x1830CA980")]
	public void CKIEIOOCMAM<T>(string IGFDDANAMMH, T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E760", Offset = "0x1E6D160", VA = "0x181E6E760")]
	public void HEOHJOBENDL(string IGFDDANAMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
	public Dictionary<string, object> INOBJKMHNMG()
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
