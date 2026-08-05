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
public class KNJLDHIHLDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid GLNCBMJFJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string LAPFGJNAFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int IKNGFIJKCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid CGCLKGLPNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PMFJLOLNGMB OLLBKLJOBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 AAFOEIIFAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion BMCBDKGAEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 MJPFAMNOKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool PEFMJDDGKCB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2896E60", Offset = "0x2896060", VA = "0x182896E60")]
	public KNJLDHIHLDI(string FKIKBLLAGCJ, Guid PAGNOLBLPEI, int ABBOIALFPGA, Guid ODJJHDBLAGK, PMFJLOLNGMB OBINCBMPMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2896BF0", Offset = "0x2895DF0", VA = "0x182896BF0")]
	public GKFNMPFILLL.ADMJFINPIGI BJNJJMGJCDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2896DA0", Offset = "0x2895FA0", VA = "0x182896DA0")]
	public NFAMCPJAHMJ HCPIKDJLEDO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class PMFJLOLNGMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> KFEPHJKBEFG;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2897160", Offset = "0x2896360", VA = "0x182897160")]
	public PMFJLOLNGMB([Optional] Dictionary<string, object> KFEPHJKBEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2896FE0", Offset = "0x28961E0", VA = "0x182896FE0")]
	[NotNull]
	public static PMFJLOLNGMB LHDHKKFNABF(PhotonView KPPLLFPIALK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3AE42B0", Offset = "0x3AE34B0", VA = "0x183AE42B0")]
	public bool HNIJFJOBNMJ<T>(string JCNAPFOCJDI, out T ADBNEBBHMOP) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x51B6A40", Offset = "0x51B5C40", VA = "0x1851B6A40")]
	public void CEAJIHNFBDD<T>(string JCNAPFOCJDI, T ADBNEBBHMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2896F80", Offset = "0x2896180", VA = "0x182896F80")]
	public void CEDMIKNCMLN(string JCNAPFOCJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x624050", Offset = "0x623250", VA = "0x180624050")]
	public Dictionary<string, object> FDDENKKPFFE()
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
