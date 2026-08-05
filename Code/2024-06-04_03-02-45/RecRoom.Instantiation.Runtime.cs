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
public class PNIHDGLOHMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid LAMNPDMGGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string HPLDDKBFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int FKJNLIOGAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid NDOLPDIFIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DJGGOKHNNOC GGNENBGDCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 KIBDPDIBGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion PHONLGLKLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 HIIKKDBGJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool NBHEBNKLKNB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x687A650", Offset = "0x6878E50", VA = "0x18687A650")]
	public PNIHDGLOHMA(string EDHNNIHIAFG, Guid FAJDHCAPOBJ, int BMPLCLCOIHE, Guid IOLHOGJMOAK, DJGGOKHNNOC HJIOHHGLFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x687A490", Offset = "0x6878C90", VA = "0x18687A490")]
	public GBEDBPBMHIE PJEAKBDMNAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x687A550", Offset = "0x6878D50", VA = "0x18687A550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class DJGGOKHNNOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, object> IGKHJGPOGKA;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x687A400", Offset = "0x6878C00", VA = "0x18687A400")]
	public DJGGOKHNNOC([Optional] Dictionary<string, object> IGKHJGPOGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x687A250", Offset = "0x6878A50", VA = "0x18687A250")]
	[NotNull]
	public static DJGGOKHNNOC NLKBMGPOENF(PhotonView HLNNELMBBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28F5A20", Offset = "0x28F4220", VA = "0x1828F5A20")]
	public bool GFIHGBPIMCF<T>(string JOEHGGMHBAA, [Out] T IPHHABIKCHD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28F6350", Offset = "0x28F4B50", VA = "0x1828F6350")]
	public bool MIFNOJIONNC<T>(string JOEHGGMHBAA, [Out] T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28F61F0", Offset = "0x28F49F0", VA = "0x1828F61F0")]
	public void KAMKODPJIMO<T>(string JOEHGGMHBAA, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x687A1F0", Offset = "0x68789F0", VA = "0x18687A1F0")]
	public void GALPDKBCKMP(string JOEHGGMHBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
	public Dictionary<string, object> NHJFOODJNPD()
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
