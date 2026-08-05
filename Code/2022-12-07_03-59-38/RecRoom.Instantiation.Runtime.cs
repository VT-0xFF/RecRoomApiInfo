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
public class MIKJJGJPDJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid FCALNAHIJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string IFPNGJOJAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int IFEAKIFIICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid CIOJHMBOIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly AMCKBFKIOEN FCLKIAOPJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 PFDHJIKJMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion DNEOFIKMGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 HDGBDHAGOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool HCHOCKGGFKI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6096BD0", Offset = "0x60957D0", VA = "0x186096BD0")]
	public MIKJJGJPDJD(string BNGEJLKNOEH, Guid AEPOIAHPKGP, int OFPDDMJGKCO, Guid PHHIDPKIEOE, AMCKBFKIOEN MABIAGJMFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6096950", Offset = "0x6095550", VA = "0x186096950")]
	public OMOLHCDGNDH.NFGNMEKHMBJ HAKMDCOJHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6096B10", Offset = "0x6095710", VA = "0x186096B10")]
	public HDHHOJHIEHL PCPABPGCJCJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AMCKBFKIOEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> BPEAJPBLPHD;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60968C0", Offset = "0x60954C0", VA = "0x1860968C0")]
	public AMCKBFKIOEN([Optional] Dictionary<string, object> BPEAJPBLPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60966B0", Offset = "0x60952B0", VA = "0x1860966B0")]
	[NotNull]
	public static AMCKBFKIOEN DGIEFINCKNF(PhotonView ENAFFFEEEOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E36130", Offset = "0x1E34D30", VA = "0x181E36130")]
	public bool PDCGIMKGOOO<T>(string NANBEBOOGPM, out T NENFOEKGNGK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E35F90", Offset = "0x1E34B90", VA = "0x181E35F90")]
	public void CKBKODEFPCJ<T>(string NANBEBOOGPM, T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6096860", Offset = "0x6095460", VA = "0x186096860")]
	public void KFPKFODPJHB(string NANBEBOOGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
	public Dictionary<string, object> FPNHENCGPNC()
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
