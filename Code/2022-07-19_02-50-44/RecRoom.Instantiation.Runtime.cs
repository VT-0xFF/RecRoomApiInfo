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
public class MKNCBJDFKBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PENIBENAJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string AINPEHBHKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int BPFBPBJDAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid JMPLLMDCDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LGJBMHALPMK OOPOOKECEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 MMCGNJEGMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion CBENJMNODLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float BCIMAKHFEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool AEGIBAJGGKC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x520FBB0", Offset = "0x520EBB0", VA = "0x18520FBB0")]
	public MKNCBJDFKBF(string LKGALACAPON, Guid IGAJFFPEPNL, int FCIGEEBIHFD, Guid IMKDPNEJCJL, LGJBMHALPMK PLAMGBNFJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x520FA10", Offset = "0x520EA10", VA = "0x18520FA10")]
	public FGCJOBFCEJE.MPDKEBCHCHO KAEAFABDPHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x520F960", Offset = "0x520E960", VA = "0x18520F960")]
	public IDELCAJPDID EOJNPAHAKIG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LGJBMHALPMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> HNKCAJIPDMM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x520F8E0", Offset = "0x520E8E0", VA = "0x18520F8E0")]
	public LGJBMHALPMK([Optional] Dictionary<string, object> HNKCAJIPDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x520F700", Offset = "0x520E700", VA = "0x18520F700")]
	[NotNull]
	public static LGJBMHALPMK GKKFLLBOAKB(PhotonView KCOCGLPFGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25DBEC0", Offset = "0x25DAEC0", VA = "0x1825DBEC0")]
	public bool NOGIDOCGHEN<T>(string DDFHJDPPNBF, out T BMNJAHFFOPC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7620", Offset = "0x2DF6620", VA = "0x182DF7620")]
	public void MLBPEOBGAOB<T>(string DDFHJDPPNBF, T BMNJAHFFOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x520F880", Offset = "0x520E880", VA = "0x18520F880")]
	public void INAIIIEHGLD(string DDFHJDPPNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x58C1D0", Offset = "0x58B1D0", VA = "0x18058C1D0")]
	public Dictionary<string, object> KBMPCPOHBND()
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
