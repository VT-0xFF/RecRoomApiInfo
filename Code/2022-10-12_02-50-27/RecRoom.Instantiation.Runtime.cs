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
	[Cpp2IlInjected.Address(RVA = "0x1EC93A0", Offset = "0x1EC7BA0", VA = "0x181EC93A0")]
	public BBILIEECLND(string JCEGBIJMOPG, Guid BOHNHIHLPGH, int OGAGGFDPEDH, Guid PHKEBIPHMMK, NGCOJKAMMHL EBBLMELLFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9120", Offset = "0x1EC7920", VA = "0x181EC9120")]
	public DANPGKCOMBB.ACDKKJMGHCC DNGDPEAMJFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1EC92E0", Offset = "0x1EC7AE0", VA = "0x181EC92E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1EC9670", Offset = "0x1EC7E70", VA = "0x181EC9670")]
	public NGCOJKAMMHL([Optional] Dictionary<string, object> OAPKNGOLABC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1EC94C0", Offset = "0x1EC7CC0", VA = "0x181EC94C0")]
	[NotNull]
	public static NGCOJKAMMHL JPDGEGFAAHD(PhotonView JJOFMICFAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3FD1930", Offset = "0x3FD0130", VA = "0x183FD1930")]
	public bool EPBHELLGDLM<T>(string AGPLDPOAAIC, out T CCIMHDCKHOF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3FD1790", Offset = "0x3FCFF90", VA = "0x183FD1790")]
	public void DIMECELKFHA<T>(string AGPLDPOAAIC, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1EC9460", Offset = "0x1EC7C60", VA = "0x181EC9460")]
	public void ADDEDGCCJIP(string AGPLDPOAAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
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
