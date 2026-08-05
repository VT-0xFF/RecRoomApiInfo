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
public class PGPKEBEONOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid DFCGHENDJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string GCPAEPMKPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int ECGHBHGLMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid JPHLLGNFCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IJMKOOAPCAN AMNCBOACHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 KJEIHCPEBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion INEDIBJAGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 PCKIPKONONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool OAHMAOFGJIL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68F7C30", Offset = "0x68F6830", VA = "0x1868F7C30")]
	public PGPKEBEONOP(string NNDJGABFEBC, Guid NPKHOFNKGNK, int JFMNFGCBADH, Guid JJHKGEBFNIG, IJMKOOAPCAN FAOCLNFGLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68F7A70", Offset = "0x68F6670", VA = "0x1868F7A70")]
	public APOEFJOIPOO GCILBLDBEHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68F7B30", Offset = "0x68F6730", VA = "0x1868F7B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class IJMKOOAPCAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> NFHPINCNLCG;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68F79E0", Offset = "0x68F65E0", VA = "0x1868F79E0")]
	public IJMKOOAPCAN([Optional] Dictionary<string, object> NFHPINCNLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68F7830", Offset = "0x68F6430", VA = "0x1868F7830")]
	[NotNull]
	public static IJMKOOAPCAN OFIAPBBFPFD(PhotonView DGNNOOCHGJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DFB0", Offset = "0x2B6CBB0", VA = "0x182B6DFB0")]
	public bool CMBHFEACNLN<T>(string DPHIOKCFMFC, [Out] T GLMEMJNJKAN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E440", Offset = "0x2B6D040", VA = "0x182B6E440")]
	public bool HPOMEACPNGA<T>(string DPHIOKCFMFC, [Out] T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DE50", Offset = "0x2B6CA50", VA = "0x182B6DE50")]
	public void CBGDEMCKLAL<T>(string DPHIOKCFMFC, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68F77D0", Offset = "0x68F63D0", VA = "0x1868F77D0")]
	public void IFPALOLJLCH(string DPHIOKCFMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
	public Dictionary<string, object> GBLNGPIGHAI()
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
