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
public class FJMOJEGFIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid LCICIPPIJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string NOPNOBHDAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int DIHEFJDOIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid GMPDHDCLBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GJNCMOPHFIJ LBOIPFEDFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 FPHIADAAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion CFKIIBBOFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 HKFOPEENMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool FFKFCLHPMHI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x600A8E0", Offset = "0x6009CE0", VA = "0x18600A8E0")]
	public FJMOJEGFIEJ(string HABMBBKOFME, Guid AGDNKDLJPMG, int HHLGELIILKL, Guid BKAHKJDNMOD, GJNCMOPHFIJ IOENJKNDLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x600A720", Offset = "0x6009B20", VA = "0x18600A720")]
	public MHBFBPJPFJM.HHDHPAJKHFB MEGKPDDPBGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x600A660", Offset = "0x6009A60", VA = "0x18600A660")]
	public MGCAEGHFFKA KAPEGLJCMLJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GJNCMOPHFIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> GMCHJPKJBEO;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x600ABB0", Offset = "0x6009FB0", VA = "0x18600ABB0")]
	public GJNCMOPHFIJ([Optional] Dictionary<string, object> GMCHJPKJBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x600AA00", Offset = "0x6009E00", VA = "0x18600AA00")]
	[NotNull]
	public static GJNCMOPHFIJ JAGLELAIMED(PhotonView ODDIKGOJDNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3918230", Offset = "0x3917630", VA = "0x183918230")]
	public bool MLNCJCFKCNK<T>(string MPIADBGKNBD, out T PKODKJLGOIN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3918090", Offset = "0x3917490", VA = "0x183918090")]
	public void JKDFMHKJMMK<T>(string MPIADBGKNBD, T PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x600A9A0", Offset = "0x6009DA0", VA = "0x18600A9A0")]
	public void GMLJNDAKNDK(string MPIADBGKNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0")]
	public Dictionary<string, object> IKHBEIDHJOB()
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
