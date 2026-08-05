using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PDDMBACFDOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly Guid IDJLALACJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string CBIOKHFHHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly int MHOPBIDAJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly Guid GOKFOCIFJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly PIFBFEKACLF EOGMPIKEBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public Vector3 BKNMJONCLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Quaternion DPJLAFKHMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public Vector3 JGFJLPLNFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public bool PPPBFCJBJBL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80FDAA0", Offset = "0x80FC8A0", VA = "0x1880FDAA0")]
	public PDDMBACFDOH(string FLHKIEKANIH, Guid DGGLDKCLGCH, int MHJNMPOABCE, Guid ABICANLPDAM, PIFBFEKACLF KAGODNMLDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x80FD8F0", Offset = "0x80FC6F0", VA = "0x1880FD8F0")]
	public GCIJFIKDGLB CMCKKLLCMFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x80FD9A0", Offset = "0x80FC7A0", VA = "0x1880FD9A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FDIEJIIDLDA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x80FD7F0", Offset = "0x80FC5F0", VA = "0x1880FD7F0")]
	public static bool LKLIEOLNHBO(this RRNetworkView LNFFCKNEJCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x48171C0", Offset = "0x4815FC0", VA = "0x1848171C0")]
	public static object[] HMALEAAPNCE(this RRNetworkView LNFFCKNEJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80FD820", Offset = "0x80FC620", VA = "0x1880FD820")]
	public static ViewId MJDJJFPJICM(this RRNetworkView LNFFCKNEJCB)
	{
		return default(ViewId);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80FD740", Offset = "0x80FC540", VA = "0x1880FD740")]
	public static PIFBFEKACLF IDBIMFMEACG(this RRNetworkView LNFFCKNEJCB)
	{
		return default(PIFBFEKACLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80FD8C0", Offset = "0x80FC6C0", VA = "0x1880FD8C0")]
	public static PIFBFEKACLF OPAENPDMIBL(this POOIDDAMLPG OAEBFAAHGEJ)
	{
		return default(PIFBFEKACLF);
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
