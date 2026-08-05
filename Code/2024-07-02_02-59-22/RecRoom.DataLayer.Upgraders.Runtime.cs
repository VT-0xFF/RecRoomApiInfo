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
	[Cpp2IlInjected.Address(RVA = "0x69379A0", Offset = "0x69369A0", VA = "0x1869379A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6937990", Offset = "0x6936990", VA = "0x186937990")]
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
	[Cpp2IlInjected.Address(RVA = "0x69379B0", Offset = "0x69369B0", VA = "0x1869379B0")]
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
