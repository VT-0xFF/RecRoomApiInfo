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
public class CHBGGCPDPID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid AJGCNICNMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string NEELLAACBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int KMMHEAELALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid MAEPFAFFJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly JLEJHAOEGCL PIMLHHFFBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 KLBAENMJHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion EKOCGHPFCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float LLLBIABIPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool KGDDMFCJHON;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x51EF4C0", Offset = "0x51EE6C0", VA = "0x1851EF4C0")]
	public CHBGGCPDPID(string HDNOELEMEFN, Guid PBPFAPGAONN, int BGLOAKHBDPH, Guid DEAJPILEDHE, JLEJHAOEGCL ICJOKMMBMEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51EF320", Offset = "0x51EE520", VA = "0x1851EF320")]
	public NNEOLLMGFIG.HCKGKPCPLCN IKICFIJOJDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51EF270", Offset = "0x51EE470", VA = "0x1851EF270")]
	public MOJKJIEMPPF COOOBMOGAIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class JLEJHAOEGCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> CKHCKOBNGBB;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x51EF7B0", Offset = "0x51EE9B0", VA = "0x1851EF7B0")]
	public JLEJHAOEGCL([Optional] Dictionary<string, object> CKHCKOBNGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x51EF630", Offset = "0x51EE830", VA = "0x1851EF630")]
	[NotNull]
	public static JLEJHAOEGCL ECFCFKHPBKE(PhotonView CCIJKPLGJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2790720", Offset = "0x278F920", VA = "0x182790720")]
	public bool FINJNPJEIIJ<T>(string ICIBGJCBOAM, out T LDPMPDNIHLJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36F3EF0", Offset = "0x36F30F0", VA = "0x1836F3EF0")]
	public void AMBCHILDJAC<T>(string ICIBGJCBOAM, T LDPMPDNIHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x51EF5D0", Offset = "0x51EE7D0", VA = "0x1851EF5D0")]
	public void CDCPBPNLMGM(string ICIBGJCBOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0")]
	public Dictionary<string, object> CMLOELIKCGL()
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
