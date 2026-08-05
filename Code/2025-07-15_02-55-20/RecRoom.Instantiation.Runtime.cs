using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CLJHJGGOKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid ECODJGOIEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string CJBKLLIPEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int IIMHBOFALJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid EFCEKHIEAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly MJAPGGNPMGD LIFMPPAILNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 BCBKGNPANPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion EFKBKJCNDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 CBMLEOEPLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool DELJPFEMNJB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x813FB10", Offset = "0x813E710", VA = "0x18813FB10")]
	public CLJHJGGOKAA(string HNHFKFKDOJD, Guid ICLIAEHPAAE, int MIGBHNAIBEH, Guid MJIIKICHOLO, MJAPGGNPMGD GMDKHDDJABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x813F960", Offset = "0x813E560", VA = "0x18813F960")]
	public HCMBAAIOIJI BHJLHCNBKJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x813FA10", Offset = "0x813E610", VA = "0x18813FA10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CMCLIHKIFEC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x813FCE0", Offset = "0x813E8E0", VA = "0x18813FCE0")]
	public static bool KIMPEIJCFHP(this RRNetworkView CDNODGDIFHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x48C0590", Offset = "0x48BF190", VA = "0x1848C0590")]
	public static object[] HAMJNIAPJHK(this RRNetworkView CDNODGDIFHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x813FD10", Offset = "0x813E910", VA = "0x18813FD10")]
	public static ViewId NNFNEDLHLGK(this RRNetworkView CDNODGDIFHH)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x813FC30", Offset = "0x813E830", VA = "0x18813FC30")]
	public static MJAPGGNPMGD BDBFIBMDOMK(this RRNetworkView CDNODGDIFHH)
	{
		return default(MJAPGGNPMGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x813FDB0", Offset = "0x813E9B0", VA = "0x18813FDB0")]
	public static MJAPGGNPMGD OJMDOJNDOOK(this JAAFJCNEMDM KCHMACEBLIA)
	{
		return default(MJAPGGNPMGD);
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
