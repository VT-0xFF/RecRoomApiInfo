using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::ECIMNNAHFGP(typeof(ContainerFlagsData))]
public static class ANMHPKAFALM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6898480", Offset = "0x6897080", VA = "0x186898480")]
	[global::NODCOOKBBCJ(1)]
	public static void JFPFFNLOJBH([global::BPFJPAPNAML(1)] KLJFOIFHPPB FHCCOANHDGL, [Out][global::BPFJPAPNAML(1)] KLJFOIFHPPB LMPEMKDAODG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::ECIMNNAHFGP(typeof(ObjectPolicyData))]
public static class DCHALAOKIJN
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6898490", Offset = "0x6897090", VA = "0x186898490")]
	[global::NODCOOKBBCJ(2)]
	public static void NIBJPKJGJHL([global::BPFJPAPNAML(3)] bool PDJNAFAHBCF, [Out][global::BPFJPAPNAML(3)] BCCIMNDHFAP NBEBDBNCFGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::ECIMNNAHFGP(typeof(PersistentUserTagData))]
public static class HIGKACBDCIH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68984A0", Offset = "0x68970A0", VA = "0x1868984A0")]
	[global::NODCOOKBBCJ(1)]
	public static void HFKAAEGFIGA([global::BPFJPAPNAML(1)] FixedList32Bytes<int> JFFGADICANO, [Out][global::BPFJPAPNAML(2)] bool BBGHPOCKDLH)
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
