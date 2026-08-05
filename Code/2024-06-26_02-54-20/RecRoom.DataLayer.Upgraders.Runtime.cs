using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::FADLMEFCONE(typeof(ContainerFlagsData))]
public static class NDABEJIPLPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6905490", Offset = "0x6903A90", VA = "0x186905490")]
	[global::JAFMILDMLHD(1)]
	public static void FOKKCBOBGFJ([global::PAFPPNGEDHI(1)] MJBOEELPMEM GFKMAIELMDB, [Out][global::PAFPPNGEDHI(1)] MJBOEELPMEM KNLOFBEKFGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::FADLMEFCONE(typeof(ObjectPolicyData))]
public static class BLMHBIACLLM
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6905480", Offset = "0x6903A80", VA = "0x186905480")]
	[global::JAFMILDMLHD(2)]
	public static void JGNCENHLAMD([global::PAFPPNGEDHI(3)] bool CKBAHEIOIJL, [Out][global::PAFPPNGEDHI(3)] IPLIKNBCAMB IDICACLIBFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::FADLMEFCONE(typeof(PersistentUserTagData))]
public static class NNEBKBPGLCA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69054A0", Offset = "0x6903AA0", VA = "0x1869054A0")]
	[global::JAFMILDMLHD(1)]
	public static void GBMPLBAIOAE([global::PAFPPNGEDHI(1)] FixedList32Bytes<int> LNFPBHCJGHO, [Out][global::PAFPPNGEDHI(2)] bool ICCDGFDGGKK)
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
