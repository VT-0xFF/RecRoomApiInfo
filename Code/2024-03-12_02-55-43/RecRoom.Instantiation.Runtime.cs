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
public class IDEFPLPKLED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid KMKHHBFANCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string HBOLEPFJLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int PIHPFIPOMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid NNEFGGFFFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly KJLLFHEMGKE HMKDLDGKPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 PNLEOOLJLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion CJDLFPMECND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 NGBMLCGBOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool LFBBHFDDPBJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61736E0", Offset = "0x61728E0", VA = "0x1861736E0")]
	public IDEFPLPKLED(string HPODPEICNMJ, Guid ADMPGHEGDCB, int GHOKJANHFNC, Guid PHPJOOIDLLB, KJLLFHEMGKE PKKMNCDJIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6173520", Offset = "0x6172720", VA = "0x186173520")]
	public PFEICMMDHCB ONLODOEKKPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61735E0", Offset = "0x61727E0", VA = "0x1861735E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class KJLLFHEMGKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> GJLMFHDGMHC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6173A10", Offset = "0x6172C10", VA = "0x186173A10")]
	public KJLLFHEMGKE([Optional] Dictionary<string, object> GJLMFHDGMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6173800", Offset = "0x6172A00", VA = "0x186173800")]
	[NotNull]
	public static KJLLFHEMGKE AMOBDCNLNMM(PhotonView ELLENKLANEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x280E410", Offset = "0x280D610", VA = "0x18280E410")]
	public bool AOAADIOEPBK<T>(string HKNPGHOCJDO, [Out] T AFCGKMGKPEF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x280E890", Offset = "0x280DA90", VA = "0x18280E890")]
	public bool CGCJHOOABCL<T>(string HKNPGHOCJDO, [Out] T AFCGKMGKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x280ED60", Offset = "0x280DF60", VA = "0x18280ED60")]
	public void FMPOAGCCLEO<T>(string HKNPGHOCJDO, T AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61739B0", Offset = "0x6172BB0", VA = "0x1861739B0")]
	public void PADFOOPDKDB(string HKNPGHOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
	public Dictionary<string, object> BLPOCLLAOMJ()
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
