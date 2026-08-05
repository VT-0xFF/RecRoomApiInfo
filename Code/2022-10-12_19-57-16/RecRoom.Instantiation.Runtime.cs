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
public class BBILIEECLND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid KLLDBOPFMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string NIMANGNBMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int KBCOIOCIAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid KMELHADPFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NGCOJKAMMHL HKLKBNLOAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 HBGDONFADEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion PHGFHJHIHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 KEKPNJHGAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool KINKLANEEFB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E42480", Offset = "0x5E41480", VA = "0x185E42480")]
	public BBILIEECLND(string JCEGBIJMOPG, Guid BOHNHIHLPGH, int OGAGGFDPEDH, Guid PHKEBIPHMMK, NGCOJKAMMHL EBBLMELLFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E42200", Offset = "0x5E41200", VA = "0x185E42200")]
	public DANPGKCOMBB.ACDKKJMGHCC DNGDPEAMJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E423C0", Offset = "0x5E413C0", VA = "0x185E423C0")]
	public CFENKLMHKBJ NAMPOMCNHHB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class NGCOJKAMMHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> OAPKNGOLABC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E42750", Offset = "0x5E41750", VA = "0x185E42750")]
	public NGCOJKAMMHL([Optional] Dictionary<string, object> OAPKNGOLABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E425A0", Offset = "0x5E415A0", VA = "0x185E425A0")]
	[NotNull]
	public static NGCOJKAMMHL JPDGEGFAAHD(PhotonView JJOFMICFAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x33C1020", Offset = "0x33C0020", VA = "0x1833C1020")]
	public bool EPBHELLGDLM<T>(string AGPLDPOAAIC, out T CCIMHDCKHOF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x33C0E80", Offset = "0x33BFE80", VA = "0x1833C0E80")]
	public void DIMECELKFHA<T>(string AGPLDPOAAIC, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E42540", Offset = "0x5E41540", VA = "0x185E42540")]
	public void ADDEDGCCJIP(string AGPLDPOAAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
	public Dictionary<string, object> DAKHPJPJKKG()
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
