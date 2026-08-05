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
public class MFKKNAKAFKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid IPAPEIDPJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string DNBPMGMCMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int DNLNAFAEFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid JPGMNDBJALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GPBLGPFLAJB PBOOBKEEOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 OJIMPAELBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion NDJDDGGIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 FHOABBPIPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool GBNNNFIMPMI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C92730", Offset = "0x5C91530", VA = "0x185C92730")]
	public MFKKNAKAFKL(string DAFCOOMAPBP, Guid GNMHODDKGGP, int EFKHCBPNKGM, Guid KFHOIDCMAMA, GPBLGPFLAJB IPMHDBAJDAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C92570", Offset = "0x5C91370", VA = "0x185C92570")]
	public FOCINANNOGB ODOBJMDFOMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C92630", Offset = "0x5C91430", VA = "0x185C92630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GPBLGPFLAJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> AALDAKNINHB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5C924E0", Offset = "0x5C912E0", VA = "0x185C924E0")]
	public GPBLGPFLAJB([Optional] Dictionary<string, object> AALDAKNINHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5C922D0", Offset = "0x5C910D0", VA = "0x185C922D0")]
	[NotNull]
	public static GPBLGPFLAJB HGKLPOEIIEK(PhotonView KBMGDEBBCNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x23A76E0", Offset = "0x23A64E0", VA = "0x1823A76E0")]
	public bool HOKMFLFGDOM<T>(string GMOPMNAPKBE, [Out] T POACLGOFKAJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x23A7550", Offset = "0x23A6350", VA = "0x1823A7550")]
	public bool HKOGFIFGINH<T>(string GMOPMNAPKBE, [Out] T POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x23A7EA0", Offset = "0x23A6CA0", VA = "0x1823A7EA0")]
	public void MFACMGCFCOL<T>(string GMOPMNAPKBE, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C92480", Offset = "0x5C91280", VA = "0x185C92480")]
	public void KCJHGNBNEJA(string GMOPMNAPKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
	public Dictionary<string, object> BMGKFHMOIGO()
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
