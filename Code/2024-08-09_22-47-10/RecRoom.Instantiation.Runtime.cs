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
public class PAOJOCMBCNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid OBMIJBCMHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string FDFCDEDDKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int CKLBACOBGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid IMPDEELEMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly ODBBKMHKLOF LJNCPIFLGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 DJODFMOGEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion NFFIALOEONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 LJOBILHMOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool IKAKPFBAFAK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x691CE60", Offset = "0x691C260", VA = "0x18691CE60")]
	public PAOJOCMBCNC(string AODLOFBKOIE, Guid OBAEDDFJIGE, int OPNNBJIKBNA, Guid JPDECNJMLJL, ODBBKMHKLOF KDFNMGEMDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x691CCA0", Offset = "0x691C0A0", VA = "0x18691CCA0")]
	public BLMKBLGHNLP APCGMJANOII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x691CD60", Offset = "0x691C160", VA = "0x18691CD60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ODBBKMHKLOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> HGOPMOFNBCO;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x691CC10", Offset = "0x691C010", VA = "0x18691CC10")]
	public ODBBKMHKLOF([Optional] Dictionary<string, object> HGOPMOFNBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x691CA60", Offset = "0x691BE60", VA = "0x18691CA60")]
	[NotNull]
	public static ODBBKMHKLOF NEGOIEGKJCI(PhotonView MCIOFDKAMNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B780", Offset = "0x2D0AB80", VA = "0x182D0B780")]
	public bool LPPDNPILAFJ<T>(string PEDCMDADFIN, [Out] T OBEEJPGJPFD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B150", Offset = "0x2D0A550", VA = "0x182D0B150")]
	public bool IBMOKPDMEIA<T>(string PEDCMDADFIN, [Out] T OBEEJPGJPFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D0B620", Offset = "0x2D0AA20", VA = "0x182D0B620")]
	public void KGJINEABJGO<T>(string PEDCMDADFIN, T OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x691CA00", Offset = "0x691BE00", VA = "0x18691CA00")]
	public void LHAIFCNDDDC(string PEDCMDADFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
	public Dictionary<string, object> HJHPGOJPPGK()
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
