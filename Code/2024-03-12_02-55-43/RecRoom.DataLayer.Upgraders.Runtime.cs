using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::OFFICHPLDGC(typeof(ContainerFlagsData))]
public static class DCJDNAJHFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61189B0", Offset = "0x6117BB0", VA = "0x1861189B0")]
	[global::HEFLIFNJBLL(1)]
	public static void APAAKBGKOFD([global::BFCFAOJOGHO(1)] MMOGLMFPNLM FDLGIHMKIIK, [Out][global::BFCFAOJOGHO(1)] MMOGLMFPNLM PKEEGNOPKPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::OFFICHPLDGC(typeof(ObjectPolicyData))]
public static class AOHKJCCGJHG
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6118990", Offset = "0x6117B90", VA = "0x186118990")]
	[global::HEFLIFNJBLL(2)]
	public static void LFIIPKDHDEF([global::BFCFAOJOGHO(3)] bool ANGCJDDKPPI, [Out][global::BFCFAOJOGHO(3)] OHBNJACEMFN NLKHKPJHECN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::OFFICHPLDGC(typeof(PersistentUserTagData))]
public static class CBEGLBFNODG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61189A0", Offset = "0x6117BA0", VA = "0x1861189A0")]
	[global::HEFLIFNJBLL(1)]
	public static void LMCHOKMJHHM([global::BFCFAOJOGHO(1)] FixedList32Bytes<int> BOBCAOFCCEB, [Out][global::BFCFAOJOGHO(2)] bool MAHDAJFGNKG)
	{
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
