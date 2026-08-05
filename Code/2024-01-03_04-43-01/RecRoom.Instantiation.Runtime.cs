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
public class IHHPNNIIIED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid PNILBCGCPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string CMNBKPOHHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int KHJFJGODOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid NOLDIFNBDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly BCGLOMNNECE GPGKDADCEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 GAFNFHBABIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion GAAKDKFPAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 EPPEKKPEMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool IOHHNEMGKPL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E22410", Offset = "0x5E21010", VA = "0x185E22410")]
	public IHHPNNIIIED(string CDJCGCBIKKC, Guid AOPAJIOIEDO, int IPGCHFJACAO, Guid OOGDLCNLEBD, BCGLOMNNECE IKKPMFNJILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E22250", Offset = "0x5E20E50", VA = "0x185E22250")]
	public FNMKCLFJBPC KPOMEMKALKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E22310", Offset = "0x5E20F10", VA = "0x185E22310", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BCGLOMNNECE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> FHNPJDHEAFA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E221C0", Offset = "0x5E20DC0", VA = "0x185E221C0")]
	public BCGLOMNNECE([Optional] Dictionary<string, object> FHNPJDHEAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E22010", Offset = "0x5E20C10", VA = "0x185E22010")]
	[NotNull]
	public static BCGLOMNNECE LDHDLAALBAG(PhotonView NFGKMLPPOFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22B6540", Offset = "0x22B5140", VA = "0x1822B6540")]
	public bool IKGDLKABABA<T>(string PPNDANAOAMK, [Out] T GCPEEAODAIB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x22B6E60", Offset = "0x22B5A60", VA = "0x1822B6E60")]
	public bool OBHCNONHGCA<T>(string PPNDANAOAMK, [Out] T GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x22B6D00", Offset = "0x22B5900", VA = "0x1822B6D00")]
	public void INLCAGHFLDH<T>(string PPNDANAOAMK, T GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E21FB0", Offset = "0x5E20BB0", VA = "0x185E21FB0")]
	public void IFJPOCDCFNK(string PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
	public Dictionary<string, object> BEBLIKABIEJ()
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
