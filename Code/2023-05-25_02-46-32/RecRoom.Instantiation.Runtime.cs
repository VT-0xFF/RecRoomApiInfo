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
public class GKDPOMOKADP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid HIAEEDKLLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FJIOGJNILPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int GLPJOPLPAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid OKCANCNNDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly CLCANEFNNPF AANDPBMGCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 FKHPKLBMBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion OOCFHNFGDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 BOIJDEBEJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool CCMIPDAGNOO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x16885D0", Offset = "0x1686DD0", VA = "0x1816885D0")]
	public GKDPOMOKADP(string JKENAADABML, Guid JGOKHMOPFKL, int EHCMCLFDEAO, Guid FLEFKKKBBCM, CLCANEFNNPF FLJGOIOPMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1688410", Offset = "0x1686C10", VA = "0x181688410")]
	public EPOJJNIDMDN CNFAAOJOFJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x16884D0", Offset = "0x1686CD0", VA = "0x1816884D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CLCANEFNNPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> DDHFNGPLHGC;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1688380", Offset = "0x1686B80", VA = "0x181688380")]
	public CLCANEFNNPF([Optional] Dictionary<string, object> DDHFNGPLHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16881C0", Offset = "0x16869C0", VA = "0x1816881C0")]
	[NotNull]
	public static CLCANEFNNPF LDPAKHKJPOD(PhotonView AFCPDJEIDLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x315ADC0", Offset = "0x31595C0", VA = "0x18315ADC0")]
	public bool KFBGNHHGLGM<T>(string BDFCACLHAFA, out T ECNGHFJBIJL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x315B6E0", Offset = "0x3159EE0", VA = "0x18315B6E0")]
	public void OLBGCODNBJK<T>(string BDFCACLHAFA, T ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1688160", Offset = "0x1686960", VA = "0x181688160")]
	public void CPPHPNNFPKL(string BDFCACLHAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x841940", Offset = "0x840140", VA = "0x180841940")]
	public Dictionary<string, object> HNCFBENFMLP()
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
