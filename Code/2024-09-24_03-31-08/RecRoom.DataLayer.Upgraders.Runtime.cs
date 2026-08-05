using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[global::HIBMIBNGGGP(typeof(ContainerFlagsData))]
public static class AIJIIMDAIHI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B5EC80", Offset = "0x6B5D680", VA = "0x186B5EC80")]
	[global::PDGBBAIDAHM(1)]
	public static void OEOCFOHLBCO([global::PKMPBHMMEBN(1)] PCKDAGNPJNH MIMPMICOIBA, [Out][global::PKMPBHMMEBN(1)] PCKDAGNPJNH GKAAGNAPAID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[global::HIBMIBNGGGP(typeof(ObjectPolicyData))]
public static class JMLFEJHMDHI
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B5EC90", Offset = "0x6B5D690", VA = "0x186B5EC90")]
	[global::PDGBBAIDAHM(2)]
	public static void NJOACFEMPHI([global::PKMPBHMMEBN(3)] bool AILGFHCACLL, [Out][global::PKMPBHMMEBN(3)] NFCIMKIGCDM DLDAJAKJJND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[global::HIBMIBNGGGP(typeof(PersistentUserTagData))]
public static class LLMNNEKBHBP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B5ECA0", Offset = "0x6B5D6A0", VA = "0x186B5ECA0")]
	[global::PDGBBAIDAHM(1)]
	public static void CAABJHKNELA([global::PKMPBHMMEBN(1)] FixedList32Bytes<int> CMLOGHHHANB, [Out][global::PKMPBHMMEBN(2)] bool EPOFLOHLPHG)
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
