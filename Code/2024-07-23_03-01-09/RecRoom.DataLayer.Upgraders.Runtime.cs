using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::NDOEJCOAIGB(typeof(ContainerFlagsData))]
public static class GKIMOLKFEJC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68B7E70", Offset = "0x68B7070", VA = "0x1868B7E70")]
	[global::HHDDCPOCECG(1)]
	public static void LGHLBCNGFMM([global::COKOBOEFFNH(1)] HMOHHGDNCHA PCGKLJIFANF, [Out][global::COKOBOEFFNH(1)] HMOHHGDNCHA DLPOFFJEBEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::NDOEJCOAIGB(typeof(ObjectPolicyData))]
public static class BCBJHBOAGBH
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68B7E60", Offset = "0x68B7060", VA = "0x1868B7E60")]
	[global::HHDDCPOCECG(2)]
	public static void OFDIEEKOOCM([global::COKOBOEFFNH(3)] bool OMJPLHEEFMK, [Out][global::COKOBOEFFNH(3)] PIHMGPGBMPI GAEADNFFCGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::NDOEJCOAIGB(typeof(PersistentUserTagData))]
public static class IEJGNCFOECC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68B7E80", Offset = "0x68B7080", VA = "0x1868B7E80")]
	[global::HHDDCPOCECG(1)]
	public static void IGKEDAPBGPM([global::COKOBOEFFNH(1)] FixedList32Bytes<int> DJEEKAMJJDN, [Out][global::COKOBOEFFNH(2)] bool IPGGFCHDGAC)
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
