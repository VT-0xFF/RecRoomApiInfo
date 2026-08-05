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
public class HDMHBEBAKGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid LKCPBBLHKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string HFPEGHCDCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int INBNHKJOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid CALDGENKDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LOOAODKHEGG JMEMOLEGLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 MCOMLLJHBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion EAHANMKDOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 KFJELKBPBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool NNIGJMDAKJG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69D5FA0", Offset = "0x69D45A0", VA = "0x1869D5FA0")]
	public HDMHBEBAKGM(string ECFAGLDFCBE, Guid IJAGIEFLMNI, int GGMDJPADDPG, Guid PNEABIMLFHC, LOOAODKHEGG GKADFPNCIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69D5DE0", Offset = "0x69D43E0", VA = "0x1869D5DE0")]
	public FEDDCALFMHB FBMEILGLHCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D5EA0", Offset = "0x69D44A0", VA = "0x1869D5EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class LOOAODKHEGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> KCMODKPMJHN;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69D62D0", Offset = "0x69D48D0", VA = "0x1869D62D0")]
	public LOOAODKHEGG([Optional] Dictionary<string, object> KCMODKPMJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69D60C0", Offset = "0x69D46C0", VA = "0x1869D60C0")]
	[NotNull]
	public static LOOAODKHEGG OGAOHNOGNLC(PhotonView EEOIFKIKDHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C520", Offset = "0x2C1AB20", VA = "0x182C1C520")]
	public bool NCAHNJJKPNF<T>(string MNBFPOFIDHA, [Out] T FEBGGALLBNN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BEF0", Offset = "0x2C1A4F0", VA = "0x182C1BEF0")]
	public bool BCEGENOEGFO<T>(string MNBFPOFIDHA, [Out] T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C3C0", Offset = "0x2C1A9C0", VA = "0x182C1C3C0")]
	public void FNIGGHLNDBN<T>(string MNBFPOFIDHA, T FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69D6270", Offset = "0x69D4870", VA = "0x1869D6270")]
	public void PJEMHMBEIPM(string MNBFPOFIDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
	public Dictionary<string, object> KGBMEEFIPBK()
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
