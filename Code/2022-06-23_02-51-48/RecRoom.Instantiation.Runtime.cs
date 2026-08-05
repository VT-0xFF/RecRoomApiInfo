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
public class OJDJLJMCGJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid BNECLLDODPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string MMGEKABKCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int GMIOGIPLMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid LIFJCHHJFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly EKMGHPPGADB PFIJBONGOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 MGBIBPNAOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion AGGBJEAFLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float LMLLNBFLLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool MDBPFNKCCDF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE680", Offset = "0x4FED880", VA = "0x184FEE680")]
	public OJDJLJMCGJK(string GDNBKFMLBGF, Guid BCIBHDDAHHJ, int PBBJDHBBCHC, Guid EFKEMLBINHA, EKMGHPPGADB FEPAABLFFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE4E0", Offset = "0x4FED6E0", VA = "0x184FEE4E0")]
	public BFGNCMEBFID.PIJLDCFENHH NODJNBHGNJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE430", Offset = "0x4FED630", VA = "0x184FEE430")]
	public KELACFFHONA JBOEMGELKHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EKMGHPPGADB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> HPOKEJLLIKM;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE3B0", Offset = "0x4FED5B0", VA = "0x184FEE3B0")]
	public EKMGHPPGADB([Optional] Dictionary<string, object> HPOKEJLLIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE230", Offset = "0x4FED430", VA = "0x184FEE230")]
	[NotNull]
	public static EKMGHPPGADB NCCLCCPKNPC(PhotonView KHMMEKDHDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2829F80", Offset = "0x2829180", VA = "0x182829F80")]
	public bool FIDGIGFFKFJ<T>(string DHDAEDILENC, out T PNLMJAPAHBD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1ED97D0", Offset = "0x1ED89D0", VA = "0x181ED97D0")]
	public void BIGDAPHKFNM<T>(string DHDAEDILENC, T PNLMJAPAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4FEE1D0", Offset = "0x4FED3D0", VA = "0x184FEE1D0")]
	public void MNIDDOJOCKH(string DHDAEDILENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x570F80", Offset = "0x570180", VA = "0x180570F80")]
	public Dictionary<string, object> GKFFGBPMGCN()
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
