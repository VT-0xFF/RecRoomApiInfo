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
public class PACEJFNNHFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid GBGOFAFLJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string ENOAGODNBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int CPLFCAELKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid FNMGABOINCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly BCBFPPIPGDB DOOLOHGLMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 HMCEOKPBLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion GPMEHMCPPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float HEIICGCDHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool CHIBHPLICEA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5208810", Offset = "0x5207810", VA = "0x185208810")]
	public PACEJFNNHFD(string LGMEKMGGIMG, Guid CIJOKIJDCFN, int OKJPKGFIDIB, Guid JGEKHDICFGA, BCBFPPIPGDB BNHBAOHJFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5208670", Offset = "0x5207670", VA = "0x185208670")]
	public FKBKBDFBGMA.LJGJKHLFLOP IOGKLABHFHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x52085C0", Offset = "0x52075C0", VA = "0x1852085C0")]
	public FHCBCOBPDMG BHBMLNDDMJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class BCBFPPIPGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> GACJAGFBHJN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5208540", Offset = "0x5207540", VA = "0x185208540")]
	public BCBFPPIPGDB([Optional] Dictionary<string, object> GACJAGFBHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5208360", Offset = "0x5207360", VA = "0x185208360")]
	[NotNull]
	public static BCBFPPIPGDB EIPODOEJJMH(PhotonView DFFGLEEGGIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2333BD0", Offset = "0x2332BD0", VA = "0x182333BD0")]
	public bool NHHHDIDPJMI<T>(string GLMMMFPEBHE, out T GGAFBKIEDPG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FE88D0", Offset = "0x1FE78D0", VA = "0x181FE88D0")]
	public void IDLFALJALGN<T>(string GLMMMFPEBHE, T GGAFBKIEDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x52084E0", Offset = "0x52074E0", VA = "0x1852084E0")]
	public void IDBFDJDECBI(string GLMMMFPEBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
	public Dictionary<string, object> LKJNGHBADPP()
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
