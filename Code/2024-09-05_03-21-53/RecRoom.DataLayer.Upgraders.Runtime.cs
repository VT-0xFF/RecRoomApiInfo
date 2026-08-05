using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::JHFJLJNPJGJ(typeof(ContainerFlagsData))]
public static class EBBHIHMNPLP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B71650", Offset = "0x6B70050", VA = "0x186B71650")]
	[global::MHIEMLPNJBJ(1)]
	public static void IOEJIOHDAGO([global::MLNBHEPCPMM(1)] NKIDGEMOIMN JALHAEBPNIO, [Out][global::MLNBHEPCPMM(1)] NKIDGEMOIMN OIPNOKHAEOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::JHFJLJNPJGJ(typeof(ObjectPolicyData))]
public static class NHPBGIDDKMP
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B71660", Offset = "0x6B70060", VA = "0x186B71660")]
	[global::MHIEMLPNJBJ(2)]
	public static void NGGFFBIJOBF([global::MLNBHEPCPMM(3)] bool LAPBAFDDKLN, [Out][global::MLNBHEPCPMM(3)] GJPPNGCHFKK JOPMDPIIDPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::JHFJLJNPJGJ(typeof(PersistentUserTagData))]
public static class AGPDBDOGPKC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B71640", Offset = "0x6B70040", VA = "0x186B71640")]
	[global::MHIEMLPNJBJ(1)]
	public static void MBLPCLMHEGB([global::MLNBHEPCPMM(1)] FixedList32Bytes<int> AHLLKDMIMLK, [Out][global::MLNBHEPCPMM(2)] bool FPOJALAHKMI)
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
